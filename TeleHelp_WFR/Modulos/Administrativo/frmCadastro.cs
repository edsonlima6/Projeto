using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace TeleHelp_WFR.Modulos.Administrativo
{
    public partial class frmCadastro : frmBaseCadastro
    {
        public frmCadastro() : base()
        {
            InitializeComponent();
        }

        protected void HabilitaCampos(bool value, bool enableListagrupo = false)
        {
            panelCadastro.Enabled = value;
            dropdBaseBD.Visible = enableListagrupo;
            lbldropBD.Visible = enableListagrupo;
            rbtnNao.CheckState = CheckState.Unchecked;
            rbtnSim.CheckState = CheckState.Unchecked;
        }

        protected void ControlesForm(string lblDropBD, string panel, string group, string form)
        {
            lbldropBD.Text = lblDropBD;
            panelCadastro.Text = panel;
            rgroupAtivo.Text = group;
            this.Text = form;
        }

        protected virtual void dropdBaseBD_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            //UTILIZADO PELOS FORMS FILHOS
        }
    }
}
