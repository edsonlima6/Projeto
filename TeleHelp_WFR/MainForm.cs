using System;
using System.Windows.Forms;
using Telerik.WinForms.Documents.FormatProviders.OpenXml.Docx;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls.UI;
using TeleHelp.Domain.Enums.Comuns;
using TeleHelp.Application.Interface;
using Ninject;
using Telerik.Windows.Documents.Flow.FormatProviders.Docx;

namespace TeleHelp_WFR
{


    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        //readonly IUsuarioAplication user;
        //frmLogin frmlogin;

        public MainForm()
        {
            InitializeComponent();
            //Allow the ribbon bar in the form's title bar
            (this.FormBehavior as Telerik.WinControls.UI.RadRibbonFormBehavior).AllowTheming = false;

            //DocxFormatProvider provider = new DocxFormatProvider();


            this.btnDashboard.Click += this.ItemMenuPrincipal_Click;
            this.btnCliente.Click += this.ItemMenuPrincipal_Click;
            this.btnFinanceiro.Click += this.ItemMenuPrincipal_Click;
            this.btnComercial.Click += this.ItemMenuPrincipal_Click;
            this.btnAdministrativo.Click += this.ItemMenuPrincipal_Click;


            DragDropService service = this.dockPrincipal.GetService<DragDropService>();
            service.Starting += new StateServiceStartingEventHandler(service_Starting);
            tlwMenuLateral.DockState = DockState.Hidden;
            tlwMensagens.DockState = DockState.Hidden;

        }
        #region "EVENTOS"

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        void service_Starting(object sender, StateServiceStartingEventArgs e)
        {
            e.Cancel = true;
        }
        private void tlwMenu_ClientSizeChanged(object sender, EventArgs e)
        {
            tlwMenuLateral.TabStrip.SizeInfo.AbsoluteSize = new System.Drawing.Size(200, 0);
        }
        /// <summary>
        /// Metodo responsavel por determinar o comportamento do evento click dos botões do menu principal
        /// </summary>
        void ItemMenuPrincipal_Click(object sender, EventArgs e)
        {
            SistemaEnuns.MenuPrincipal itemMenu = (SistemaEnuns.MenuPrincipal)System.Enum.Parse(typeof(SistemaEnuns.MenuPrincipal), (sender as RadButtonElement).Text);
            CarregaMenuLateral(itemMenu, sender);
            tlwMenuLateral.DockState = DockState.Docked;


        }
        void menuItem_Click(object sender, EventArgs e)
        {
            RadMenuItem item = (sender as RadMenuItem);
            tlwMenuLateral.DockState = DockState.AutoHide;
            MessageBox.Show(item.Text + " was clicked.");

        }
        #endregion
        private void CarregaMenuLateral(SistemaEnuns.MenuPrincipal itemMenu, object sender)
        {
            try
            {
                switch (itemMenu.GetHashCode())
                {
                    case 1:
                        MenuCliente();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        MenuAdministrativo();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }

        private void MenuCliente()
        {
            rdmMenuLateral.Items.Clear();
            RadMenuItem subitem = new Telerik.WinControls.UI.RadMenuItem();
            subitem.Items.Add(new Telerik.WinControls.UI.RadMenuItem("DASH COMERCIAL"));
            subitem.Items.Add(new Telerik.WinControls.UI.RadMenuItem("DASH CENTRAL"));
            RadMenuItem bargainItem = new Telerik.WinControls.UI.RadMenuItem("DASH FINACEIRO");
            bargainItem.Click += menuItem_Click;
            subitem.Items.Add(bargainItem);
            rdmMenuLateral.Items.Add(subitem.Items[0]);
            rdmMenuLateral.Items.Add(subitem.Items[1]);
            rdmMenuLateral.Items.Add(subitem.Items[2]);
            rdmMenuLateral.Orientation = System.Windows.Forms.Orientation.Vertical;
            rdmMenuLateral.Items[0].TextOrientation = System.Windows.Forms.Orientation.Vertical;
            rdmMenuLateral.Items[0].FlipText = true;
            rdmMenuLateral.Items[1].TextOrientation = System.Windows.Forms.Orientation.Vertical;
            rdmMenuLateral.Items[1].FlipText = true;
            rdmMenuLateral.Items[2].TextOrientation = System.Windows.Forms.Orientation.Vertical;
            rdmMenuLateral.Items[2].FlipText = true;
        }

        private void MenuAdministrativo()
        {

            try
            {
                rdmMenuLateral.Items.Clear();
                RadMenuItem subMenuCadastro = new Telerik.WinControls.UI.RadMenuItem("CADASTRO");
                //subMenuCadastro.Location = new System.Drawing.Point(15, 15);
                //subMenuCadastro.Size = new System.Drawing.Size(550, 30);
                RadMenuItem subMenuFinanceiro = new Telerik.WinControls.UI.RadMenuItem("FINANCEIRO");

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //rdmMenuLateral.Items[0].TextOrientation = System.Windows.Forms.Orientation.Vertical;
            //rdmMenuLateral.Items[0].Size = new System.Drawing.Size(609, 673);
            //rdmMenuLateral.Items[0].FlipText = true;

        }

        private void dockPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void ibeAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
