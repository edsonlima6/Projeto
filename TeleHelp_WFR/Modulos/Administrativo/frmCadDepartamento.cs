using Ninject;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TeleHelp.Application.Interface;
using TeleHelp.Domain.DTO;
using TeleHelp.Domain.Enums.Comuns;
using TeleHelp.Domain.Specifications;
using TeleHelp_WFR.Classes;
using Telerik.WinControls.UI;

namespace TeleHelp_WFR.Modulos.Administrativo
{
    public partial class frmCadDepartamento : frmCadastro
    {
        bool EnablePanel;
        SistemaEnuns.Acao _acao;
        DepartamentoDTO dptoDTO;
        List<DepartamentoDTO> listaDeptoDTO;
        IDepartamentoAppication departamentoAppication;

        public frmCadDepartamento() : base()
        {
            //InitializeComponent();
            EnablePanel = false;
            ControlesForm("DEPTO", "DADOS DO DEPARTAMENTO", "STATUS DO DEPARTAMENTO", "CADASTRO DE DEPARTAMENTO");
            departamentoAppication = Program._kernel.Get<IDepartamentoAppication>();
        }

        protected override void dropdBaseBD_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadDropDownList dropdown = (RadDropDownList)sender;
            var itemSelecionado = dropdown.SelectedValue;
            if (itemSelecionado != null && dropdBaseBD.Enabled)
            {
                dptoDTO = listaDeptoDTO.Find(g => g.Nome == itemSelecionado.ToString());
                txtNome.Text = dptoDTO.Nome;
                txtDescricao.Text = dptoDTO.Descricao;
                txtCodigo.Text = dptoDTO.IdDepartamento.ToString();

                if (dptoDTO.Ativo)
                {
                    rbtnSim.IsChecked = true;
                }
                else
                {
                    rbtnNao.IsChecked = true;
                }
            }
        }
        protected override bool Gravar()
        {

            try
            {
                if (_acao == SistemaEnuns.Acao.INCLUIR)
                {
                    if (rbtnSim.CheckState == CheckState.Unchecked && rbtnNao.CheckState == CheckState.Unchecked)
                    {
                        MessageBox.Show("O Status do departamento deve ser difinido.");
                        return false;
                    }

                    dptoDTO = new DepartamentoDTO() { Nome = txtNome.Text, Descricao = txtDescricao.Text, Ativo = rbtnSim.IsChecked };
                    dptoDTO.ValidaDepartamento();
                    departamentoAppication.Add(dptoDTO.departamento);
                    MessageBox.Show("Dados gravado com sucesso.");

                }
                else if (_acao == SistemaEnuns.Acao.ALTERAR)
                {
                    dptoDTO = new DepartamentoDTO();
                    dptoDTO.IdDepartamento = Convert.ToInt32(txtCodigo.Text);
                    dptoDTO.Ativo = rbtnSim.IsChecked;
                    dptoDTO.Nome = txtNome.Text;
                    dptoDTO.Descricao = txtDescricao.Text;
                    dptoDTO.ValidaDepartamento();

                    //FAZ O UPDATE NO BANCO DE DADOS
                    departamentoAppication.Update(dptoDTO.departamento = departamentoAppication.GetById(dptoDTO.IdDepartamento));
                    MessageBox.Show("Dados alterado com sucesso.");
                }
                Funcoes.LimpaCampos(panelCadastro.Controls);
                HabilitaCampos(EnablePanel);
                return true;
            }
            catch(System.Data.Entity.Infrastructure.DbUpdateException errorBD)
            {
                //var erro = new ExcptionBD();
                MessageBox.Show(ExcptionBD.ErrosDataBase(errorBD));
                return false;
            }
            catch (Exception erroIncluir)
            {
                MessageBox.Show(erroIncluir.Message);
                return false;
            }
        }
        protected override bool Alterar()
        {
            _acao = SistemaEnuns.Acao.ALTERAR;

            try
            {

                listaDeptoDTO = new List<DepartamentoDTO>();
                foreach (var item in departamentoAppication.GetAll())
                {
                    DepartamentoDTO dptoDTO = new DepartamentoDTO()
                    {
                        Nome = item.Nome,
                        Descricao = item.Descricao,
                        Ativo = item.Ativo,
                        IdDepartamento = item.IdDepartamento
                    };
                    dptoDTO.DisposeDepto();
                    listaDeptoDTO.Add(dptoDTO);
                }

                if (listaDeptoDTO.Count == 0)
                {
                    MessageBox.Show("Não existem Cargos na base de dados.\n Por gentileza realizar um novo cadastro.");
                    return false;
                }

                //ORDENA LISTA PARA ASCENDENTE
                listaDeptoDTO.Sort(delegate (DepartamentoDTO a, DepartamentoDTO b) { return a.Nome.CompareTo(b.Nome); });


                //PREENCHE DROPDOWNLIST 
                dropdBaseBD.DataSource = listaDeptoDTO;
                dropdBaseBD.DataMember = "IdDepartamento";
                dropdBaseBD.ValueMember = "Nome";
                dropdBaseBD.SelectedIndex = -1;
                HabilitaCampos(!EnablePanel, !EnablePanel);

                return true;
            }
            catch (Exception errorAlterar)
            {
                MessageBox.Show(errorAlterar.Message);
                return false;
            }
        }
        protected override bool Incluir()
        {
            _acao = SistemaEnuns.Acao.INCLUIR;
            HabilitaCampos(!EnablePanel);
            return true;
        }
        protected override bool Excluir()
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o Cargo " + dptoDTO.Nome.ToString(), "Alerta TeleHelp", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var dptoBD = departamentoAppication.GetById(dptoDTO.IdDepartamento);
                    departamentoAppication.Delete(dptoBD);
                    MessageBox.Show("Cargo deletado com sucesso.");
                    Funcoes.LimpaCampos(panelCadastro.Controls);
                    HabilitaCampos(EnablePanel);
                    return base.Excluir();

                }
                return false;
            }
            catch (Exception erroCancelar)
            {
                MessageBox.Show(erroCancelar.Message);
                return false;
            }
        }
        protected override bool Cancelar()
        {

            Funcoes.LimpaCampos(panelCadastro.Controls);
            HabilitaCampos(EnablePanel);
            return base.Cancelar();
        }



    }
}
