using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TeleHelp.Application.Interface;
using TeleHelp.Domain.DTO;
using TeleHelp.Domain.DTO.InterfacesDTO;
using TeleHelp.Domain.Entities;
using TeleHelp_WFR.Classes;
using TeleHelp_WFR.Compartilhado;
using TeleHelp.Domain.Enums.Comuns;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Data.Entity.Infrastructure;
using TeleHelp.Domain.Specifications;
using Telerik.WinControls.Enumerations;

namespace TeleHelp_WFR.Modulos.Administrativo
{
    public partial class frmCadGrupo : RadForm
    {
        readonly IGrupoApplication _grupoApp;
        readonly IGrupoTelaApplication _grupoTelaApplication;
        readonly ITelaApplication _telaApplication;
        IGrupoDTO grupoDTO;
        bool EnableForm = false;
        int idGrupo { get; set; }
        int idTela { get; set; }

        public frmCadGrupo(IGrupoApplication grupoApp, IGrupoDTO _grupoDTO, IGrupoTelaApplication grupoTelaApplication, ITelaApplication telaApplication) : base()
        {
            InitializeComponent();
            _grupoApp = grupoApp;
            grupoDTO = _grupoDTO;
            _grupoTelaApplication = grupoTelaApplication;
            _telaApplication = telaApplication;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EnableForm = false;
            ctrBotoesPadraoCadastro1.disableBtnCancelar = true;
            Funcoes.LimpaCampos(panelEditGrupo.Controls);
            HabilitaCampos(EnableForm);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            EnableForm = true;
            idGrupo = 0;
            idTela = 0;
            Funcoes.LimpaCampos(panelEditGrupo.Controls);
            ctrBotoesPadraoCadastro1.disableBtnNovo = EnableForm;
            HabilitaCampos(EnableForm);
            grupoDTO.Acao = TeleHelp.Domain.Enums.Comuns.SistemaEnuns.Acao.INCLUIR;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos())
            {
                MessageBox.Show("ESCOLHA UM GRUPO VÁLIDO");
                return;
            }
            idGrupo = -1;
            idTela = -1;
            EnableForm = true;
            HabilitaCampos(EnableForm);
            ctrBotoesPadraoCadastro1.disableBtnAlterar = true;
            grupoDTO.Acao = TeleHelp.Domain.Enums.Comuns.SistemaEnuns.Acao.ALTERAR;
        }

        private void btnGravar_Click1(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampos())
                {
                    PreencheGrupo();

                    if (_grupoApp.AddGrupoTela(grupoDTO))
                    {
                        MessageBox.Show("DADOS GRAVADOS COM SUCESSO");
                    }
                    Funcoes.LimpaCampos(panelEditGrupo.Controls);
                    EnableForm = false;
                    HabilitaCampos(EnableForm);
                    ctrBotoesPadraoCadastro1.disableBtnGravar = true;
                    CarregaComponentesBD();
                    return;
                }

                MessageBox.Show("POR FAVOR PREENCHER TODOS OS CAMPOS");
                return;
            }
            catch (DbUpdateException errorDB)
            {
                MessageBox.Show(ExcptionBD.ErrosDataBase(errorDB));
            }
            catch (Exception erroGravar)
            {
                MessageBox.Show(erroGravar.Message);
            }
        }

        private void PreencheGrupo()
        {
            try
            {
                if (grupoDTO.Acao.Equals(SistemaEnuns.Acao.ALTERAR))
                {
                    grupoDTO.IdGrupo = int.Parse(txtCodigo.Text);
                }
                grupoDTO.Nome = txtNome.Text;
                grupoDTO.Descricao = txtDescricao.Text;
                grupoDTO.Ativo = rbtnSim.IsChecked;
                grupoDTO.GrupoTelas.Clear();


                foreach (var row in gdvTelaPermissao.Rows)
                {
                    var grupoTela = grupoDTO.PermissaoTela;
                    grupoTela.IdTela = (int)row.Cells[0].Value;
                    grupoTela.Incluir = Convert.ToBoolean(row.Cells[1].Value);
                    grupoTela.Alterar = Convert.ToBoolean(row.Cells[2].Value);
                    grupoTela.Excluir = Convert.ToBoolean(row.Cells[3].Value);
                    grupoTela.Consultar = Convert.ToBoolean(row.Cells[4].Value);

                    grupoDTO.GrupoTelas.Add(grupoTela);
                    grupoTela = null;
                }

            }
            catch (Exception)
            {
                throw new Exception("ERRO AO CARREGAR O GRUPO");
            }
        }

        private void HabilitaCampos(bool value)
        {
            if (value)
            {
                txtCodigo.TextBoxElement.Border.Visibility = ElementVisibility.Visible;
                txtNome.TextBoxElement.Border.Visibility = ElementVisibility.Visible;
                txtDescricao.TextBoxElement.Border.Visibility = ElementVisibility.Visible;
                txtNome.ReadOnly = !value;
                txtDescricao.ReadOnly = !value;
                rbtnNao.ReadOnly = !value;
                rbtnSim.ReadOnly = !value;
                groupTela.Enabled = value;
                panelGrupos.Enabled = !value;
            }
            else
            {
                txtCodigo.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed;
                txtNome.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed;
                txtDescricao.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed;
                txtNome.ReadOnly = !value;
                txtDescricao.ReadOnly = !value;
                rbtnNao.ReadOnly = !value;
                rbtnSim.ReadOnly = !value;
                groupTela.Enabled = value;
                panelGrupos.Enabled = !value;
            }


        }

        
        private void CarregaComponentesBD()
        {
            grupoDTO.NovosObjetos();
            try
            {
                grupoDTO.Grupos = _grupoApp.GetAll().ToList();
                if (grupoDTO.Grupos != null && grupoDTO.Grupos.Count > 0)
                {
                    var grupos = (from g in grupoDTO.Grupos select new { g.IdGrupo, g.Ativo, g.Nome, g.Descricao });
                    gdvGruposBD.DataSource = grupos;
                }

                grupoDTO.Telas = _telaApplication.GetAll().ToList();
                if (grupoDTO.Telas != null && grupoDTO.Telas.Count > 0)
                {
                    rchkTelas.DataSource = grupoDTO.Telas;
                    rchkTelas.ValueMember = "IdTela";
                    rchkTelas.DisplayMember = "Descricao";
                }

                grupoDTO.GrupoTelas = _grupoTelaApplication.GetAll().ToList();

            }
            catch (Exception)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL LOCALIZAR OS GRUPOS NO BANCO DE DADOS");
            }


        }

        private void frmCadGrupo_Load(object sender, EventArgs e)
        {
            CarregaComponentesBD();
            ComponentesTela();
        }

        private void ComponentesTela()
        {
            try
            {
                gdvGruposBD.GridViewElement.DrawBorder = false;
                gdvGruposBD.GridViewElement.GroupPanelElement.DrawBorder = false;
                txtCodigo.Enabled = false;
                ctrBotoesPadraoCadastro1.btnGravar.Click += new EventHandler(btnGravar_Click1);
                ctrBotoesPadraoCadastro1.btnAlterar.Click += new EventHandler(btnAlterar_Click);
                ctrBotoesPadraoCadastro1.btnNovo.Click += new EventHandler(btnNovo_Click);
                ctrBotoesPadraoCadastro1.btnExcluir.Visible = false;
                ctrBotoesPadraoCadastro1.btnCancelar.Click += new EventHandler(btnCancelar_Click);


                foreach (var column in gdvGruposBD.Columns)
                {
                    if (column.Name == "Ativo")
                    { 
                        column.MaxWidth = 45;
                        column.Width = 40;
                        column.HeaderText = "ATIVO";
                    }
                    if (column.Name == "IdGrupo")
                    {
                        column.MaxWidth = 65;
                        column.Width    = 60;
                        column.TextAlignment = ContentAlignment.MiddleCenter;
                        column.HeaderText = "CÓDIGO";
                    }
                    if (column.Name == "Nome")
                    {
                        column.Width = 160;
                        column.MinWidth = 150;
                        column.HeaderText = "NOME";
                    }
                    if (column.Name == "Descricao")
                    {
                        column.Width = 230;
                        column.MinWidth = 200;
                        column.HeaderText = "DESCRIÇÃO";
                    }
                }
                
                GridViewCheckBoxColumn ColumnIncluir = new GridViewCheckBoxColumn();
                ColumnIncluir.DataType = typeof(int);
                ColumnIncluir.Name = "Incluir";
                ColumnIncluir.FieldName = "Incluir";
                ColumnIncluir.HeaderText = "INCLUIR";
                ColumnIncluir.MaxWidth = 120;
                ColumnIncluir.MinWidth = 60;
                ColumnIncluir.Width = 80;

                GridViewCheckBoxColumn ColumnAlterar = new GridViewCheckBoxColumn();
                ColumnAlterar.DataType = typeof(int);
                ColumnAlterar.Name = "Alterar";
                ColumnAlterar.FieldName = "Alterar";
                ColumnAlterar.HeaderText = "ALTERAR";
                ColumnAlterar.MaxWidth = 120;
                ColumnAlterar.MinWidth = 60;
                ColumnAlterar.Width = 80;

                GridViewCheckBoxColumn ColumnExcluir = new GridViewCheckBoxColumn();
                ColumnExcluir.DataType = typeof(int);
                ColumnExcluir.Name = "Excluir";
                ColumnExcluir.FieldName = "Excluir";
                ColumnExcluir.HeaderText = "EXCLUIR";
                ColumnExcluir.MaxWidth = 120;
                ColumnExcluir.MinWidth = 60;
                ColumnExcluir.Width = 80;

                GridViewCheckBoxColumn ColumnConsultar = new GridViewCheckBoxColumn();
                ColumnConsultar.DataType = typeof(int);
                ColumnConsultar.Name = "Consultar";
                ColumnConsultar.FieldName = "Consultar";
                ColumnConsultar.HeaderText = "CONSULTAR";
                ColumnConsultar.MaxWidth = 120;
                ColumnConsultar.MinWidth = 60;
                ColumnConsultar.Width = 80;
                gdvTelaPermissao.MasterTemplate.Columns.Add(ColumnIncluir);
                gdvTelaPermissao.MasterTemplate.Columns.Add(ColumnAlterar);
                gdvTelaPermissao.MasterTemplate.Columns.Add(ColumnExcluir);
                gdvTelaPermissao.MasterTemplate.Columns.Add(ColumnConsultar);
                gdvTelaPermissao.GridViewElement.DrawBorder = false;
            }
            catch (Exception)
            {
                throw new Exception("ERRO NA CRIAÇÃO DO GRID DE ACESSO AS TELAS");
            }
        }


        private void gdvGruposBD_Click(object sender, EventArgs e)
        {
            try
            {
                idGrupo = Convert.ToInt32(((RadGridView)sender).CurrentRow.Cells[0].Value);

                var grupoExists = grupoDTO.Grupos.FirstOrDefault(g => g.IdGrupo.Equals(idGrupo));
                if (grupoExists != null)
                {
                    txtCodigo.Text = grupoExists.IdGrupo.ToString();
                    txtNome.Text = grupoExists.Nome;
                    txtDescricao.Text = grupoExists.Descricao;
                    if (grupoExists.Ativo)
                    {
                        rbtnSim.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        rbtnNao.CheckState = CheckState.Checked;
                    }

                    //PREENCHE GRID COM AS INFORMAÇÕES DO BANCO DE DADOS
                    if (grupoDTO.GrupoTelas != null)
                    {
                        var listaTela = grupoDTO.GrupoTelas.Where(gt => gt.IdGrupo.Equals(grupoExists.IdGrupo));

                        foreach (var check in rchkTelas.Items)
                        {
                            check.CheckState = ToggleState.Indeterminate;
                        }

                        gdvTelaPermissao.Visible = true;
                        foreach (var check in rchkTelas.Items)
                        {
                            if ((check.CheckState == ToggleState.On || check.CheckState == ToggleState.Off || check.CheckState == ToggleState.Indeterminate)
                                && grupoDTO.GrupoTelas.Any(gt => gt.IdGrupo.Equals(grupoExists.IdGrupo) && gt.IdTela.Equals(check.Value)))
                            {
                                var grupoBD = grupoDTO.GrupoTelas.FirstOrDefault(gt => gt.IdGrupo.Equals(idGrupo) && gt.IdTela.Equals(check.Value));
                                gdvTelaPermissao.Rows.AddNew();
                                var count = gdvTelaPermissao.Rows.Count();
                                gdvTelaPermissao.Rows[count - 1].Cells[0].Value = grupoBD.IdTela;
                                gdvTelaPermissao.Rows[count - 1].Cells[1].Value = Convert.ToBoolean(grupoBD.Incluir);
                                gdvTelaPermissao.Rows[count - 1].Cells[2].Value = Convert.ToBoolean(grupoBD.Alterar);
                                gdvTelaPermissao.Rows[count - 1].Cells[3].Value = Convert.ToBoolean(grupoBD.Excluir);
                                gdvTelaPermissao.Rows[count - 1].Cells[4].Value = Convert.ToBoolean(grupoBD.Consultar);
                                check.CheckState = ToggleState.On;
                            }
                            else
                            {
                                check.CheckState = Telerik.WinControls.Enumerations.ToggleState.Off;
                            }
                        }
                        if (!listaTela.Any())
                        {
                            foreach (var check in rchkTelas.Items)
                            {
                                check.CheckState = Telerik.WinControls.Enumerations.ToggleState.Indeterminate;
                            }
                        }

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO PARA HABILITAR GRUPO");
            }

        }
        private void MontaGridExistente()
        {
            gdvTelaPermissao.Visible = true;
            foreach (var check in rchkTelas.Items)
            {
                if ((check.CheckState == ToggleState.On || check.CheckState == ToggleState.Off || check.CheckState == ToggleState.Indeterminate)
                    && grupoDTO.GrupoTelas.Any(gt => gt.IdGrupo.Equals(idGrupo) && gt.IdTela.Equals(check.Value)))
                {
                    check.CheckState = ToggleState.On;


                    var grupoBD = grupoDTO.GrupoTelas.FirstOrDefault(gt => gt.IdGrupo.Equals(idGrupo) && gt.IdTela.Equals(check.Value));
                   


                    gdvTelaPermissao.Rows.AddNew();
                    var count = gdvTelaPermissao.Rows.Count();
                    gdvTelaPermissao.Rows[count - 1].Cells[0].Value = grupoBD.IdTela;
                    gdvTelaPermissao.Rows[count - 1].Cells[1].Value = Convert.ToBoolean(grupoBD.Incluir);
                    gdvTelaPermissao.Rows[count - 1].Cells[2].Value = Convert.ToBoolean(grupoBD.Alterar);
                    gdvTelaPermissao.Rows[count - 1].Cells[3].Value = Convert.ToBoolean(grupoBD.Excluir);
                    gdvTelaPermissao.Rows[count - 1].Cells[4].Value = Convert.ToBoolean(grupoBD.Consultar);

                }
                else
                {
                    check.CheckState = Telerik.WinControls.Enumerations.ToggleState.Off;
                }
            }
        }

        private bool ValidaCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtDescricao.Text) || (rbtnNao.CheckState == CheckState.Unchecked && rbtnSim.CheckState == CheckState.Unchecked))
            {
                return false;
            }
            return true;
        }

        private void rchkTelas_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {

            if (e.Item.CheckState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                idTela = Convert.ToInt32(e.Item.Value);
                if (!grupoDTO.GrupoTelas.Any(gt => gt.IdGrupo.Equals(idGrupo) && gt.IdTela.Equals(idTela)))
                {
                    gdvTelaPermissao.Visible = true;
                    gdvTelaPermissao.Rows.AddNew();
                    var countRow = gdvTelaPermissao.Rows.Count;
                    gdvTelaPermissao.Rows[countRow - 1].Cells[0].Value = idTela;
                    return;
                }
                return;
            }
            else if (e.Item.CheckState == Telerik.WinControls.Enumerations.ToggleState.Off)
            {
                var Id = e.Item.Value;
                int indexRow = -1;
                foreach (var row in gdvTelaPermissao.Rows)
                {
                    if (row.Cells[0].Value.Equals(Id))
                    {
                        indexRow = row.Index;
                    }
                }
                if (indexRow >= 0)
                {
                    gdvTelaPermissao.Rows.RemoveAt(indexRow);
                }
                return;
            }

            gdvTelaPermissao.Rows.Clear();
            gdvTelaPermissao.Visible = false;

        }
    }
}
