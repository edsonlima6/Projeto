using Ninject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using TeleHelp.Application.Interface;
using TeleHelp.Domain.DTO.InterfacesDTO;
using TeleHelp.Domain.Enums.Comuns;
using TeleHelp_WFR.Classes;
using TeleHelp_WFR.Compartilhado;
using Telerik.WinControls.UI;
using System.Text;
using System.Linq;
using System.Data.Entity.Infrastructure;
using TeleHelp.Domain.Specifications;

namespace TeleHelp_WFR.Modulos.Administrativo
{
    /// <summary>
    /// CLASSE DE CADASTRO DE USUARIO. CASO SEJA ALTERAÇÃO, TERÁ QUE INFORMAR A AÇÃO(ALTERAR) E O ID DO USUÁRIO(IDUSUARIO) ANTES DO LOAD DO FORM
    /// </summary>
    public partial class frmCadUsuario : frmBase
    {
        bool EnablePanel;
        public int IdUsuario;
        public SistemaEnuns.Acao acao;
        readonly IGrupoApplication grupoApp;
        readonly ICargoApplication cargoApp;
        readonly IDepartamentoAppication dptoApp;
        readonly IUsuarioAplication userApp;
        readonly IRepresentanteApplication representanteApp;
        IUsuarioDTO userDTO;

        ASCIIEncoding encod;

        public frmCadUsuario()
        {
            InitializeComponent();
            EnablePanel = false;
            HabilitaComponentes(EnablePanel);
            //INJEÇÃO DE DEPENDÊNCIA DO OBJETOS DTO
            userDTO = Program._kernel.Get<IUsuarioDTO>();
            //INJEÇÃO DE DEPENDÊNCIA DO BANCO DE DADOS DDD
            grupoApp = Program._kernel.Get<IGrupoApplication>();
            dptoApp = Program._kernel.Get<IDepartamentoAppication>();
            userApp = Program._kernel.Get<IUsuarioAplication>();
            cargoApp = Program._kernel.Get<ICargoApplication>();
            representanteApp = Program._kernel.Get<IRepresentanteApplication>();

            CarregaComponentes();
            //IdUsuario = 53;
            //acao = SistemaEnuns.Acao.ALTERAR;
        }
        
        private void frmCadUsuario_Load(object sender, System.EventArgs e)
        {
            if (acao == SistemaEnuns.Acao.ALTERAR && IdUsuario > 0)
            {
                PreencheCampos();
            }
            else
            {
                Incluir();
            }
        }
        /// <summary>
        /// MÉTODO SOMENTE QUANDO O FOR ALTERAÇÃO DE USUÁRIO
        /// </summary>
        private void PreencheCampos()
        {
            try
            {
                alteraBotao = true;
                userDTO.Usuario = userApp.GetById(IdUsuario);
                if (userDTO.Usuario == null)
                {
                    userDTO.NovoObjeto();
                    alteraBotao = false;
                    throw new Exception("USUÁRIO NÃO ENCONTRADO NA BASE DE DADOS");
                }
                Alterar();
                userDTO.gruposUsuario = userApp.GetListaGrupoUsuario(userDTO.Usuario.IdUsuario).ToList();
                userDTO.representanteUsuario = userApp.GetRepresentanteUsuario(userDTO.Usuario.IdUsuario);
                txtCodigo.Text = userDTO.Usuario.IdUsuario.ToString();
                txtNome.Text = userDTO.Usuario.Nome;
                txtLogin.Text = userDTO.Usuario.Login;
                mtxtEmail.Text = userDTO.Usuario.Email;
                dtDataCadastro.Value = userDTO.Usuario.DataCadastro.Date;
                mtxtMatricula.Text = userDTO.Usuario.Matricula.ToString();
                timeHEntrada.Value = Convert.ToDateTime(userDTO.Usuario.HorarioEntrada.Value.ToString());
                timeHSaida.Value = Convert.ToDateTime(userDTO.Usuario.HorarioSaida.Value.ToString());

                if (userDTO.Usuario.Ativo)
                {
                    rbtnSimAtivo.CheckState = CheckState.Checked;
                }
                else
                {
                    rbtnNaoAtivo.CheckState = CheckState.Checked;
                }
                if (userDTO.Usuario.Foto != null && userDTO.Usuario.Foto.Length > 0)
                {
                    imagemUsuario.Image = Funcoes.byteArrayToImage2(userDTO.Usuario.Foto);
                }
                foreach (var item in dropListaCargo.Items)
                {
                    if (item.Value.GetHashCode() == userDTO.Usuario.IdCargo)
                    {
                        dropListaCargo.SelectedItem = item;
                    }
                }
                foreach (var item in dropListaDepto.Items)
                {
                    if (item.Value.GetHashCode() == userDTO.Usuario.IdDepartamento)
                    {
                        dropListaDepto.SelectedItem = item;
                    }
                }

                //DROPDOWNLIST 
                if (userDTO.representanteUsuario != null && userDTO.representanteUsuario.IdRepresentante > 0)
                {
                    foreach (var item in dropListaRepresentante.Items)
                    {
                        if (item.Value.GetHashCode() == userDTO.representanteUsuario.IdRepresentante)
                        {
                            dropListaRepresentante.SelectedItem = item;
                        }
                    }
                    rbtnVendedorSim.CheckState = CheckState.Checked;
                }
                else
                {
                    rbtnVendedorNao.CheckState = CheckState.Checked;
                }

                if (userDTO.Usuario.IdTipoAtendimento != SistemaEnuns.TipoAtendimento.NAOATENDE.GetHashCode())
                {
                    foreach (var item in dropListaFilaAtendimento.Items)
                    {
                        if (item.Value.GetHashCode() == userDTO.IdTipoAtendimento)
                        {
                            dropListaFilaAtendimento.SelectedItem = item;
                        }
                    }
                    rbtnSimAtendente.CheckState = CheckState.Checked;
                }
                else
                {
                    rbtnNaoAtendente.CheckState = CheckState.Checked;
                }

                //HABILITA OS GRUPOS QUE ESTÃO PARA O USUÁRIO
                foreach (var item in rchechListaGrupos.Items)
                {
                    foreach (var grupoUsuario in userDTO.gruposUsuario)
                    {
                        if (item.Value.GetHashCode() == grupoUsuario.IdGrupo)
                        {
                            item.CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
                        }
                    }
                }

                panelUsuario.Enabled = !EnablePanel;
            }
            catch (Exception erroPreencheUsuario)
            {
                MessageBox.Show(erroPreencheUsuario.Message);
                return;
            }
        }

        protected override bool Incluir()
        {
            novoBotao = true;
            acao = SistemaEnuns.Acao.INCLUIR;
            userDTO.acao = acao;
            Funcoes.LimpaCampos(panelUsuario.Controls);
            HabilitaComponentes(!EnablePanel); 
            return true;
        }

        protected override bool Alterar()
        {
            acao = SistemaEnuns.Acao.ALTERAR;
            userDTO.acao = acao;
            HabilitaComponentes(!EnablePanel);
            return true;
        }

        protected override bool Gravar()
        {
            try
            {
                if (acao == SistemaEnuns.Acao.INCLUIR && ValidaCampos())
                {
                    PreencheUsuario();

                    if (userApp.AddUsuario(userDTO))
                    {
                        MessageBox.Show("DADOS GRAVADOS COM SUCESSO ");
                    }
                }
                else if (acao == SistemaEnuns.Acao.ALTERAR)
                {
                    PreencheUsuario();


                    if (userApp.AddUsuario(userDTO))
                    {
                        MessageBox.Show("DADOS ALTERADO COM SUCESSO ");
                    }
                }
                else
                {
                    return false;
                }
                Funcoes.LimpaCampos(panelUsuario.Controls);
                HabilitaComponentes(EnablePanel);
                return true;
            }
            catch (DbUpdateException errorDB)
            {
                MessageBox.Show(ExcptionBD.ErrosDataBase(errorDB));
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        protected override bool Cancelar()
        {
            HabilitaComponentes(EnablePanel);
            Funcoes.LimpaCampos(panelUsuario.Controls);
            return base.Cancelar();
        }

        protected override bool Excluir()
        {
            try
            {

                if (MessageBox.Show("CONFIRMA A EXCLUSÃO DO USUÁRIO ? ", "ALERTA TELEHELP", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    acao = SistemaEnuns.Acao.EXCLUIR;
                    if (userApp.RemoveALLUsuario(userDTO))
                    {
                        MessageBox.Show("USUÁRIO EXCLUÍDO COM SUCESSO");
                    }
                }
                HabilitaComponentes(EnablePanel);
                Funcoes.LimpaCampos(panelUsuario.Controls);
                return true;
            }
            catch (DbUpdateException errorDB)
            {
                MessageBox.Show(ExcptionBD.ErrosDataBase(errorDB));
                return false;
            }
            catch (Exception erroExcluir)
            {
                MessageBox.Show(erroExcluir.Message);
                return false;
            }
        }

        /// <summary>
        /// MÉTODO RESPONSÁVEL PELOS GRUPOS DO USUÁRIO CADASTRADO
        /// </summary>
        private void rchechListaGrupos_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {
            try
            {
                userDTO.grupo = grupoApp.GetById(Convert.ToInt32(e.Item.Value));
                if (e.Item.CheckState == Telerik.WinControls.Enumerations.ToggleState.On)
                {

                    gdvGrupoPeriodo.Rows.AddNew();
                    var countRow = gdvGrupoPeriodo.RowCount;
                    gdvGrupoPeriodo.Rows[countRow - 1].Cells[0].Value = userDTO.grupo.IdGrupo;
                    gdvGrupoPeriodo.Rows[countRow - 1].Cells[1].Value = userDTO.grupo.Nome;
                }
                else if (e.Item.CheckState == Telerik.WinControls.Enumerations.ToggleState.Off)
                {
                    int indexRow = -1;
                    foreach (var item in gdvGrupoPeriodo.Rows)
                    {
                        if (item.Cells[0].Value.Equals(userDTO.grupo.IdGrupo))
                        {
                            indexRow = item.Index;
                        }
                    }
                    gdvGrupoPeriodo.Rows.RemoveAt(indexRow);
                }
                if (userDTO.gruposUsuario != null & userDTO.gruposUsuario.Count > 0)
                {
                    foreach (var row in gdvGrupoPeriodo.Rows)
                    {
                        foreach (var grupo in userDTO.gruposUsuario)
                        {
                            if (row.Cells[0].Value.Equals(grupo.IdGrupo))
                            {
                                row.Cells[2].Value = grupo.DataInicio;
                                if (grupo.DataFim !=null)
                                {
                                    row.Cells[3].Value = grupo.DataFim;
                                }
                            }
                        }
                    }
                }
            }
            catch (System.Exception errorChack)
            {
                MessageBox.Show(errorChack.Message);
            }
        }

        /// <summary>
        /// MÉTODO RESPONSÁVEL POR CARREGAR TODOS OS COMPONENTES DEPENDENTES DO BANCO DE DADOS 
        /// </summary>
        private void CarregaComponentes()
        {
            dtDataCadastro.Value = DateTime.Now;
            encod = new ASCIIEncoding();
            List<SistemaEnuns.TipoAtendimento> listAtendimento = new List<SistemaEnuns.TipoAtendimento>()
            {
                SistemaEnuns.TipoAtendimento.FILAINDICACAO, SistemaEnuns.TipoAtendimento.FILAPENDENCIA, SistemaEnuns.TipoAtendimento.FILATELEVENDAS
            };

            //CRIANDO A COLUNA DATAINICIAL DO GRID DE GRUPOS
            GridViewDateTimeColumn _dateTimeInicialColumn = new GridViewDateTimeColumn();
            _dateTimeInicialColumn.Name = "dtInicio";
            _dateTimeInicialColumn.HeaderText = "DATA INICIAL";
            _dateTimeInicialColumn.FieldName = "dtInicio";
            _dateTimeInicialColumn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            _dateTimeInicialColumn.Width = 120;
            _dateTimeInicialColumn.AllowHide = false;

            //CRIANDO A COLUNA DATAFINAL DO GRID DE GRUPOS
            GridViewDateTimeColumn _dateTimeFimColumn = new GridViewDateTimeColumn();
            _dateTimeFimColumn.Name = "dtFim";
            _dateTimeFimColumn.HeaderText = "DATA FINAL";
            _dateTimeFimColumn.FieldName = "dtFim";
            _dateTimeFimColumn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            _dateTimeFimColumn.Width = 120;
            _dateTimeFimColumn.AllowHide = false;
            gdvGrupoPeriodo.MasterTemplate.Columns.Add(_dateTimeInicialColumn);
            gdvGrupoPeriodo.MasterTemplate.Columns.Add(_dateTimeFimColumn);

            ((RegexMaskTextBoxProvider)mtxtEmail.MaskedEditBoxElement.Provider).ErrorMessage = "EMAIL INVÁLIDO";

            try
            {
                //PREENCHE O RADCHECKEDLISTVIEW DO GRUPO
                rchechListaGrupos.DataSource = grupoApp.GetAll();
                rchechListaGrupos.DisplayMember = "Nome";
                rchechListaGrupos.ValueMember = "IdGrupo";

                //PREENCHE O DROPDOWNLIST DO CARGO
                dropListaCargo.DataSource = cargoApp.GetAll();
                dropListaCargo.DisplayMember = "Nome";
                dropListaCargo.ValueMember = "IdCargo";
                dropListaCargo.SelectedIndex = -1;
                dropListaCargo.Text = "SELECIONE UMA OPÇÃO";

                //PREENCHE O DROPDOWNLIST DO DEPARTAMENTO
                dropListaDepto.DataSource = dptoApp.GetAll();
                dropListaDepto.DisplayMember = "Nome";
                dropListaDepto.ValueMember = "IdDepartamento";
                dropListaDepto.SelectedIndex = -1;
                dropListaDepto.Text = "SELECIONE UMA OPÇÃO";

                //
                //PREENCHE O DROPDOWNLIST DO REPRESENTANTE
                dropListaRepresentante.DataSource = representanteApp.GetAll();
                dropListaRepresentante.DisplayMember = "RazaoSocial";
                dropListaRepresentante.ValueMember = "IdRepresentante";


                //PREENCHE O DROPDOWNLIST DE INDICAÇÕES
                dropListaFilaAtendimento.DataSource = listAtendimento;
                foreach (var item in dropListaFilaAtendimento.Items)
                {
                    switch (item.Value.GetHashCode())
                    {
                        case 1: item.Text = "FILA INDICAÇÃO"; break;
                        case 2: item.Text = "FILA PENDÊNCIA"; break;
                        case 3: item.Text = "FILA TELEVENDAS"; break;

                    }
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void HabilitaComponentes(bool value)
        {
            panelUsuario.Enabled = value;
        }

        /// <summary>
        /// Método PARA PREENCHER O USUÁRIO DO DTO
        /// </summary>
        private void PreencheUsuario()
        {
            userDTO.Usuario = null;
            userDTO.NovoObjeto();
            dtDataCadastro.Value = DateTime.Now;
            userDTO.Ativo = rbtnSimAtivo.IsChecked;
            userDTO.IdTipoAtendimento = SistemaEnuns.TipoAtendimento.NAOATENDE.GetHashCode();
            userDTO.IdTipoUsuario = SistemaEnuns.TipoUsuario.USUARIO.GetHashCode();
            userDTO.IdCargo = dropListaCargo.SelectedItem.Value.GetHashCode();
            userDTO.IdDepartamento = dropListaDepto.SelectedItem.Value.GetHashCode();
            userDTO.Senha = encod.GetBytes(Funcoes.CriptografaHash(mtxtSenha.Text));
            userDTO.Matricula = int.Parse(mtxtMatricula.Text);
            userDTO.Nome = txtNome.Text;
            userDTO.Login = txtLogin.Text;
            userDTO.DataCadastro = dtDataCadastro.Value;
            userDTO.HorarioEntrada = timeHEntrada.Value.Value.TimeOfDay;
            userDTO.HorarioSaida = timeHSaida.Value.Value.TimeOfDay;

            if (imagemUsuario.Image != null)
            {
                userDTO.Foto = Funcoes.ImageToByteArray(imagemUsuario.Image);
            }
            if (acao == SistemaEnuns.Acao.ALTERAR)
            {
                userDTO.IdUsuario = int.Parse(txtCodigo.Text);
                userDTO.DataAlteracao = DateTime.Now;
            }
            if (!string.IsNullOrEmpty(mtxtEmail.Text))
            {
                userDTO.Email = mtxtEmail.Text;
            }
            if (!mtxtSenha.Text.Equals(mtxtConfirmaSenha.Text))
            {
                throw new Exception("AS SENHAS NÃO CONFEREM");
            }
            if (!(mtxtEmail.MaskedEditBoxElement.Provider as EMailMaskTextBoxProvider).Validate(mtxtEmail.Text))
            {
                throw new Exception("EMAIL INVÁLIDO");
            }
            if (rbtnVendedorSim.CheckState == CheckState.Checked)
            {
                userDTO.representanteUsuario = null;
                userDTO.NovoObjeto();
                userDTO.representanteUsuario.IdRepresentante = dropListaRepresentante.SelectedItem.Value.GetHashCode();
                userDTO.representanteUsuario.Ativo = true;
                userDTO.IdTipoUsuario = SistemaEnuns.TipoUsuario.VENDEDOR.GetHashCode();
            }
            if (rbtnSimAtendente.CheckState == CheckState.Checked)
            {
                userDTO.IdTipoAtendimento = dropListaFilaAtendimento.SelectedItem.Value.GetHashCode();
                userDTO.IdTipoUsuario = SistemaEnuns.TipoUsuario.ATENDENTE.GetHashCode();
            }

            if (gdvGrupoPeriodo.Rows.Count > 0)
            {

                userDTO.gruposUsuario.Clear();
                foreach (var item in gdvGrupoPeriodo.Rows)
                {
                    if (item.Cells[2].Value == null)
                    {
                        throw new Exception("SELECIONE O PERIODO INICIAL PARA O GRUPO QUE O COLABORADOR TERÁ ACESSO");
                    }
                    if (!userDTO.gruposUsuario.Exists(g => g.IdGrupo == int.Parse(item.Cells[0].Value.ToString())))
                    {
                        userDTO.NovoObjeto();
                        userDTO.grupoUsuario.IdGrupo = int.Parse(item.Cells[0].Value.ToString());
                        userDTO.grupoUsuario.IdUsuario = userDTO.IdUsuario;
                        userDTO.grupoUsuario.DataInicio = Convert.ToDateTime(item.Cells[2].Value);

                        if (item.Cells[3].Value != null)
                        {
                            userDTO.grupoUsuario.DataFim = Convert.ToDateTime(item.Cells[3].Value);
                        }
                    }
                    userDTO.gruposUsuario.Add(userDTO.grupoUsuario);
                    userDTO.grupoUsuario = null;
                }

            }
            if (acao != SistemaEnuns.Acao.EXCLUIR)
            {
                userDTO.ValidaCadastroUsuario();
            }

        }

        private void rbtnSimAtendente_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            var rbtn = (RadRadioButton)sender;

            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On && rbtn.Equals(rbtnSimAtendente))
            {
                dropListaFilaAtendimento.Visible = !EnablePanel;
                lblFilaAtendimento.Visible = !EnablePanel;
            }
            else
            {
                dropListaFilaAtendimento.Visible = EnablePanel;
                lblFilaAtendimento.Visible = EnablePanel;
            }
        }
        private void rbtnVendedorSim_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            var rbtn = (RadRadioButton)sender;

            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On && rbtn.Equals(rbtnVendedorSim))
            {
                dropListaRepresentante.Visible = !EnablePanel;
                lblRepresentante.Visible = !EnablePanel;
            }
            else
            {
                dropListaRepresentante.Visible = EnablePanel;
                lblRepresentante.Visible = EnablePanel;
            }
        }

        private void btnAlterarImagem_Click(object sender, EventArgs e)
        {
            try
            {
                // Stream stream;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Images Files(*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF;";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    if (openFile.OpenFile() != null)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            var bit = new Bitmap(openFile.OpenFile(), true);
                            bit.Save(memoryStream, ImageFormat.Bmp);
                            userDTO.Foto = memoryStream.ToArray();
                        }
                        imagemUsuario.Image = Funcoes.byteArrayToImage2(userDTO.Foto);
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ARQUIVO SELECIONADO INVÁLIDO \n SELECIONE UMA IMAGEM VÁLIDA.");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR NÃO DEFINIDO");
                return;
            }
        }

        private bool ValidaCampos()
        {
            if (rbtnSimAtivo.CheckState.Equals(rbtnNaoAtivo.CheckState))
            {
                throw new Exception("POR FAVOR INFORMAR O STATUS DO USUÁRIO");
            }
            if (rbtnVendedorSim.CheckState.Equals(rbtnVendedorNao.CheckState))
            {
                throw new Exception("POR FAVOR INFORMAR OS DADOS COMERCIAIS");
            }
            if (rbtnSimAtendente.CheckState.Equals(rbtnNaoAtendente.CheckState))
            {
                throw new Exception("POR FAVOR INFORMAR OS DADOS DE INDICAÇÃO");
            }
            if (dropListaCargo.SelectedIndex < 0 || dropListaDepto.SelectedIndex < 0)
            {
                throw new Exception("POR FAVOR INFORMAR OS DADOS CADASTRAIS");
            }
            return true;
        }
    }
}
