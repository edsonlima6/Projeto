using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TeleHelp_WFR.Compartilhado;
using TeleHelp_WFR.Modulos.Administrativo;
using Telerik.WinControls;

namespace TeleHelp_WFR.Modulos.Cliente
{
    public partial class frmCliente : Telerik.WinControls.UI.RadForm
    {
        public frmCliente() 
        {
            InitializeComponent();
            ConfiguraTela();
            ctrDisplayRepresentateVendedor1.OnUserControlButtonClicked += (s, e) => MessageBox.Show("Horray!");
        }

        private void ConfiguraTela()
        {
            DataTable DT = new DataTable();
           
            
        }

    }
}