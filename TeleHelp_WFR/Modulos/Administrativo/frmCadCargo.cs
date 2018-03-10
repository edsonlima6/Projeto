using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TeleHelp.Application.Interface;
using TeleHelp.Domain.DTO;
using TeleHelp.Domain.DTO.InterfacesDTO;
using TeleHelp.Domain.Enums.Comuns;
using TeleHelp_WFR.Classes;
using TeleHelp_WFR.Compartilhado;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TeleHelp_WFR.Modulos.Administrativo
{
    public partial class frmCadCargo : frmBase
    {
        bool enableControl = false;
        ICargoApplication cargoApp;
        ICargoDTO _cargoDTO;
        SistemaEnuns.Acao acao;
        List<CargoDTo> listaCargos;
        CargoDTo cargoDTO;

        public frmCadCargo(ICargoDTO cargoDTO, ICargoApplication _cargoApp) 
        {
            InitializeComponent();
            _cargoDTO = cargoDTO;
            cargoApp = _cargoApp;
        }



        protected override bool Gravar()
        {
            try
            {
                if (acao == SistemaEnuns.Acao.INCLUIR)
                {
                    if (rbtnSim.CheckState == CheckState.Unchecked && rbtnNao.CheckState == CheckState.Unchecked)
                    {
                        MessageBox.Show("STATUS DO CARGO DEVE SER SELECIONADO");
                        return false;
                    }

                    cargoDTO = new CargoDTo()
                    {
                        Nome = txtNome.Text,
                        Descricao = txtDescricao.Text,
                        Ativo = rbtnSim.IsChecked
                    };
                    var cargoBD = cargoDTO.GetCargo();
                    cargoApp.Add(cargoBD);
                    MessageBox.Show("DADOS GRAVADOS COM SUCESSO");
                }
                else if (acao == SistemaEnuns.Acao.ALTERAR)
                {
                    if (dropListaCargo.SelectedIndex < 0)
                    {
                        MessageBox.Show("CARGO DEVE SER SELECIONADO");
                        return false;
                    }
                    cargoDTO = new CargoDTo()
                    {
                        Nome = txtNome.Text,
                        Descricao = txtDescricao.Text,
                        Ativo = rbtnSim.IsChecked,
                        IdCargo = Convert.ToInt32(txtCodigo.Text)
                    };
                    var cargoModel = cargoDTO.GetCargo();
                    cargoApp.UpdateCargo(cargoModel);
                    MessageBox.Show("DADOS ALTERADO COM SUCESSO.");
                }
                Funcoes.LimpaCampos(painelCargo.Controls);
                HabilitaCampos(enableControl = false);
                return base.Gravar();
            }
            catch (Exception erroGravar)
            {
                MessageBox.Show(erroGravar.Message);
                return false;
            }

        }


        protected override bool Alterar()
        {
            acao = SistemaEnuns.Acao.ALTERAR;

            try
            {
                listaCargos = new List<CargoDTo>();
                foreach (var item in cargoApp.GetAll())
                {
                    CargoDTo cargoDTO = new CargoDTo()
                    {
                        Nome = item.Nome,
                        Descricao = item.Descricao,
                        Ativo = item.Ativo,
                        IdCargo = item.IdCargo
                    };
                    listaCargos.Add(cargoDTO);
                    _cargoDTO.listaCargos.Add(item);
                }

                //ORDENA LISTA PARA ASCENDENTE
                listaCargos.Sort(delegate (CargoDTo a, CargoDTo b) { return a.Nome.CompareTo(b.Nome); });
                var lista =  _cargoDTO.listaCargos.OrderBy(c => c.Nome);
                //_cargoDTO.listaCargos.Clear();
                foreach (var item in lista)
                {
                    _cargoDTO.listaCargos.Add(item);
                }

                //PREENCHE DROPDOWNLIST 
                dropListaCargo.DataSource = listaCargos;
                dropListaCargo.DataMember = "IdCargo";
                dropListaCargo.ValueMember = "Nome";
                dropListaCargo.SelectedIndex = -1;
                HabilitaCampos(enableControl = true, true);

                if (dropListaCargo.Items.Count == 0)
                {
                    MessageBox.Show("NÃO EXISTEM CARGOS NA BASE DE DADOS.\n POR GENTILEZA REALIZAR UM NOVO CADASTRO.");
                    HabilitaCampos(enableControl = false);
                    return false;
                }
                return base.Alterar();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }

        protected override bool Incluir()
        {
            acao = SistemaEnuns.Acao.INCLUIR;
            HabilitaCampos(enableControl = true);
            return base.Incluir();
        }

        protected override bool Cancelar()
        {
            Funcoes.LimpaCampos(painelCargo.Controls);
            HabilitaCampos(enableControl = false);
            return base.Cancelar();
        }

        protected override bool Excluir()
        {
            //try
            //{
            //    if (MessageBox.Show("Deseja excluir o Cargo " + cargoDTO.Nome.ToString(), "Alerta TeleHelp", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        var cargoDb = cargoApp.GetById(cargoDTO.IdCargo);
            //        cargoApp.Delete(cargoDb);
            //        MessageBox.Show("Cargo deletado com sucesso.");
            //        Funcoes.LimpaCampos(painelCargo.Controls);
            //        HabilitaCampos(enableControl = false);
            //        return base.Excluir();

            //    }
            //    return false;
            //}
            //catch (Exception erroCancelar)
            //{
            //    MessageBox.Show(erroCancelar.Message);
            //    return false;
            //}
            return true;
        }

        private void HabilitaCampos(bool value, bool enableListagrupo = false)
        {
            painelCargo.Enabled    = value;
            dropListaCargo.Visible = enableListagrupo;
            lblCargo.Visible       = enableListagrupo;
            rbtnNao.CheckState     = CheckState.Unchecked;
            rbtnSim.CheckState     = CheckState.Unchecked;
        }

        private void dropListaCargo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadDropDownList dropdown = (RadDropDownList)sender;
            var itemSelecionado = dropdown.SelectedValue;
            if (itemSelecionado != null && dropListaCargo.Enabled)
            {
                cargoDTO = listaCargos.Find(g => g.Nome == itemSelecionado.ToString());
                txtNome.Text = cargoDTO.Nome;
                txtDescricao.Text = cargoDTO.Descricao;
                txtCodigo.Text = cargoDTO.IdCargo.ToString();

                if (cargoDTO.Ativo)
                {
                    rbtnSim.IsChecked = true;
                }
                else
                {
                    rbtnNao.IsChecked = true;
                }
            }
        }
    }
}
