namespace TeleHelp_WFR
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.rbbMenuPrincipal = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.bbgAvatar = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.ibeAvatar = new Telerik.WinControls.UI.RadImageButtonElement();
            this.bbgLabelDadosUsuario = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.radLabelElement2 = new Telerik.WinControls.UI.RadLabelElement();
            this.radLabelElement3 = new Telerik.WinControls.UI.RadLabelElement();
            this.bbgDadosUsuario = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.lblUsuarioFilial = new Telerik.WinControls.UI.RadLabelElement();
            this.lblUsuarioNome = new Telerik.WinControls.UI.RadLabelElement();
            this.lblUsuarioCargo = new Telerik.WinControls.UI.RadLabelElement();
            this.bbgDataCorrente = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.lblDiaMesAno = new Telerik.WinControls.UI.RadLabelElement();
            this.lblDiaSemana = new Telerik.WinControls.UI.RadLabelElement();
            this.bbgSpace = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.lblSpace = new Telerik.WinControls.UI.RadLabelElement();
            this.bbgMenu = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.btnDashboard = new Telerik.WinControls.UI.RadButtonElement();
            this.btnCliente = new Telerik.WinControls.UI.RadButtonElement();
            this.btnFinanceiro = new Telerik.WinControls.UI.RadButtonElement();
            this.btnComercial = new Telerik.WinControls.UI.RadButtonElement();
            this.btnAdministrativo = new Telerik.WinControls.UI.RadButtonElement();
            this.btnParametro = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.btnSairSistema = new Telerik.WinControls.UI.RadMenuItem();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            this.dockPrincipal = new Telerik.WinControls.UI.Docking.RadDock();
            this.tlwMensagens = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.tlwMenuLateral = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.rdmMenuLateral = new Telerik.WinControls.UI.RadMenu();
            this.dctContainerPrincipal = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.radContextMenu1 = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.rbbMenuPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockPrincipal)).BeginInit();
            this.dockPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            this.tlwMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdmMenuLateral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dctContainerPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).BeginInit();
            this.toolTabStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rbbMenuPrincipal
            // 
            this.rbbMenuPrincipal.CloseButton = false;
            this.rbbMenuPrincipal.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1});
            // 
            // 
            // 
            this.rbbMenuPrincipal.ExitButton.Text = resources.GetString("rbbMenuPrincipal.ExitButton.Text");
            this.rbbMenuPrincipal.ExitButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            resources.ApplyResources(this.rbbMenuPrincipal, "rbbMenuPrincipal");
            this.rbbMenuPrincipal.MaximizeButton = false;
            this.rbbMenuPrincipal.Name = "rbbMenuPrincipal";
            // 
            // 
            // 
            this.rbbMenuPrincipal.OptionsButton.Text = resources.GetString("rbbMenuPrincipal.OptionsButton.Text");
            this.rbbMenuPrincipal.OptionsButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.rbbMenuPrincipal.StartButtonImage = global::TeleHelp_WFR.Properties.Resources.logo_icone_16x17;
            this.rbbMenuPrincipal.StartMenuItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnParametro,
            this.radMenuSeparatorItem1,
            this.btnSairSistema});
            this.rbbMenuPrincipal.ThemeName = "Office2013Light";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.rbbMenuPrincipal.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.rbbMenuPrincipal.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.rbbMenuPrincipal.GetChildAt(0).GetChildAt(6).GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.BorderLeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ribbonTab1.BorderRightColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ribbonTab1.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1});
            this.ribbonTab1.Name = "ribbonTab1";
            resources.ApplyResources(this.ribbonTab1, "ribbonTab1");
            this.ribbonTab1.UseMnemonic = false;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.EnableRippleAnimation = true;
            this.radRibbonBarGroup1.FocusBorderColor = System.Drawing.Color.Maroon;
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.bbgAvatar,
            this.bbgLabelDadosUsuario,
            this.bbgDadosUsuario,
            this.bbgDataCorrente,
            this.bbgSpace,
            this.bbgMenu});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            resources.ApplyResources(this.radRibbonBarGroup1, "radRibbonBarGroup1");
            // 
            // bbgAvatar
            // 
            this.bbgAvatar.AccessibleDescription = "bbgAvatar";
            this.bbgAvatar.AccessibleName = "bbgAvatar";
            resources.ApplyResources(this.bbgAvatar, "bbgAvatar");
            this.bbgAvatar.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.ibeAvatar});
            this.bbgAvatar.Name = "bbgAvatar";
            // 
            // ibeAvatar
            // 
            this.ibeAvatar.AccessibleDescription = "ibeAvatar";
            this.ibeAvatar.AccessibleName = "ibeAvatar";
            this.ibeAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ibeAvatar.Image = global::TeleHelp_WFR.Properties.Resources.jose;
            this.ibeAvatar.Name = "ibeAvatar";
            resources.ApplyResources(this.ibeAvatar, "ibeAvatar");
            this.ibeAvatar.Click += new System.EventHandler(this.ibeAvatar_Click);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.ibeAvatar.GetChildAt(1).GetChildAt(1))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment")));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.ibeAvatar.GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // bbgLabelDadosUsuario
            // 
            this.bbgLabelDadosUsuario.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1,
            this.radLabelElement2,
            this.radLabelElement3});
            resources.ApplyResources(this.bbgLabelDadosUsuario, "bbgLabelDadosUsuario");
            this.bbgLabelDadosUsuario.Name = "bbgLabelDadosUsuario";
            this.bbgLabelDadosUsuario.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bbgLabelDadosUsuario.ShowBorder = false;
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Name = "radLabelElement1";
            resources.ApplyResources(this.radLabelElement1, "radLabelElement1");
            this.radLabelElement1.TextWrap = true;
            // 
            // radLabelElement2
            // 
            this.radLabelElement2.MaxSize = new System.Drawing.Size(0, 30);
            this.radLabelElement2.MinSize = new System.Drawing.Size(0, 30);
            this.radLabelElement2.Name = "radLabelElement2";
            resources.ApplyResources(this.radLabelElement2, "radLabelElement2");
            this.radLabelElement2.TextWrap = true;
            // 
            // radLabelElement3
            // 
            this.radLabelElement3.Name = "radLabelElement3";
            resources.ApplyResources(this.radLabelElement3, "radLabelElement3");
            this.radLabelElement3.TextWrap = true;
            // 
            // bbgDadosUsuario
            // 
            this.bbgDadosUsuario.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblUsuarioFilial,
            this.lblUsuarioNome,
            this.lblUsuarioCargo});
            resources.ApplyResources(this.bbgDadosUsuario, "bbgDadosUsuario");
            this.bbgDadosUsuario.Name = "bbgDadosUsuario";
            this.bbgDadosUsuario.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bbgDadosUsuario.ShowBorder = false;
            // 
            // lblUsuarioFilial
            // 
            this.lblUsuarioFilial.AccessibleDescription = "lblUsuarioFilial";
            this.lblUsuarioFilial.AccessibleName = "lblUsuarioFilial";
            this.lblUsuarioFilial.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioFilial.Name = "lblUsuarioFilial";
            resources.ApplyResources(this.lblUsuarioFilial, "lblUsuarioFilial");
            this.lblUsuarioFilial.TextWrap = true;
            // 
            // lblUsuarioNome
            // 
            this.lblUsuarioNome.AccessibleDescription = "lblUsuarioNome";
            this.lblUsuarioNome.AccessibleName = "lblUsuarioNome";
            this.lblUsuarioNome.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(214)))));
            this.lblUsuarioNome.MaxSize = new System.Drawing.Size(0, 30);
            this.lblUsuarioNome.MinSize = new System.Drawing.Size(0, 30);
            this.lblUsuarioNome.Name = "lblUsuarioNome";
            resources.ApplyResources(this.lblUsuarioNome, "lblUsuarioNome");
            this.lblUsuarioNome.TextWrap = true;
            // 
            // lblUsuarioCargo
            // 
            this.lblUsuarioCargo.AccessibleDescription = "lblUsuarioCargo";
            this.lblUsuarioCargo.AccessibleName = "lblUsuarioCargo";
            this.lblUsuarioCargo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblUsuarioCargo.Name = "lblUsuarioCargo";
            resources.ApplyResources(this.lblUsuarioCargo, "lblUsuarioCargo");
            this.lblUsuarioCargo.TextWrap = true;
            // 
            // bbgDataCorrente
            // 
            this.bbgDataCorrente.AccessibleDescription = "bbgDataCorrente";
            this.bbgDataCorrente.AccessibleName = "bbgDataCorrente";
            this.bbgDataCorrente.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblDiaMesAno,
            this.lblDiaSemana});
            resources.ApplyResources(this.bbgDataCorrente, "bbgDataCorrente");
            this.bbgDataCorrente.Name = "bbgDataCorrente";
            this.bbgDataCorrente.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bbgDataCorrente.ShowBorder = false;
            // 
            // lblDiaMesAno
            // 
            this.lblDiaMesAno.AccessibleDescription = "lblDiaMesAno";
            this.lblDiaMesAno.AccessibleName = "lblDiaMesAno";
            this.lblDiaMesAno.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaMesAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            resources.ApplyResources(this.lblDiaMesAno, "lblDiaMesAno");
            this.lblDiaMesAno.Name = "lblDiaMesAno";
            this.lblDiaMesAno.TextWrap = true;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AccessibleDescription = "lblDiaSemana";
            this.lblDiaSemana.AccessibleName = "lblDiaSemana";
            this.lblDiaSemana.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.lblDiaSemana.Name = "lblDiaSemana";
            resources.ApplyResources(this.lblDiaSemana, "lblDiaSemana");
            this.lblDiaSemana.TextWrap = true;
            // 
            // bbgSpace
            // 
            this.bbgSpace.AccessibleDescription = "bbgSpace";
            this.bbgSpace.AccessibleName = "bbgSpace";
            this.bbgSpace.AutoSize = true;
            this.bbgSpace.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblSpace});
            resources.ApplyResources(this.bbgSpace, "bbgSpace");
            this.bbgSpace.MaxSize = new System.Drawing.Size(0, 0);
            this.bbgSpace.MinSize = new System.Drawing.Size(22, 22);
            this.bbgSpace.Name = "bbgSpace";
            this.bbgSpace.ShowBorder = false;
            // 
            // lblSpace
            // 
            this.lblSpace.AutoSize = false;
            this.lblSpace.Bounds = new System.Drawing.Rectangle(0, 0, 200, 96);
            this.lblSpace.MaxSize = new System.Drawing.Size(250, 0);
            this.lblSpace.MinSize = new System.Drawing.Size(250, 0);
            this.lblSpace.Name = "lblSpace";
            resources.ApplyResources(this.lblSpace, "lblSpace");
            this.lblSpace.TextWrap = true;
            // 
            // bbgMenu
            // 
            this.bbgMenu.AccessibleDescription = "bbgMenu";
            this.bbgMenu.AccessibleName = "bbgMenu";
            this.bbgMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnDashboard,
            this.btnCliente,
            this.btnFinanceiro,
            this.btnComercial,
            this.btnAdministrativo});
            resources.ApplyResources(this.bbgMenu, "bbgMenu");
            this.bbgMenu.Name = "bbgMenu";
            this.bbgMenu.ShowBorder = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.AccessibleDescription = "btnDashboard";
            this.btnDashboard.AccessibleName = "btnDashboard";
            this.btnDashboard.EnableRippleAnimation = true;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            resources.ApplyResources(this.btnDashboard, "btnDashboard");
            this.btnDashboard.MaxSize = new System.Drawing.Size(115, 0);
            this.btnDashboard.MinSize = new System.Drawing.Size(115, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShowBorder = false;
            // 
            // btnCliente
            // 
            this.btnCliente.AccessibleDescription = "btnCliente";
            this.btnCliente.AccessibleName = "btnCliente";
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            resources.ApplyResources(this.btnCliente, "btnCliente");
            this.btnCliente.MaxSize = new System.Drawing.Size(115, 0);
            this.btnCliente.MinSize = new System.Drawing.Size(115, 0);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.ShowBorder = false;
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.AccessibleDescription = "btnFinanceiro";
            this.btnFinanceiro.AccessibleName = "btnFinanceiro";
            this.btnFinanceiro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            resources.ApplyResources(this.btnFinanceiro, "btnFinanceiro");
            this.btnFinanceiro.MaxSize = new System.Drawing.Size(115, 0);
            this.btnFinanceiro.MinSize = new System.Drawing.Size(115, 0);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.ShowBorder = false;
            // 
            // btnComercial
            // 
            this.btnComercial.AccessibleDescription = "btnComercial";
            this.btnComercial.AccessibleName = "btnComercial";
            this.btnComercial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComercial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            resources.ApplyResources(this.btnComercial, "btnComercial");
            this.btnComercial.MaxSize = new System.Drawing.Size(115, 0);
            this.btnComercial.MinSize = new System.Drawing.Size(115, 0);
            this.btnComercial.Name = "btnComercial";
            this.btnComercial.ShowBorder = false;
            // 
            // btnAdministrativo
            // 
            this.btnAdministrativo.AccessibleDescription = "btnAdministrativo";
            this.btnAdministrativo.AccessibleName = "btnAdministrativo";
            this.btnAdministrativo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrativo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            resources.ApplyResources(this.btnAdministrativo, "btnAdministrativo");
            this.btnAdministrativo.MaxSize = new System.Drawing.Size(130, 0);
            this.btnAdministrativo.MinSize = new System.Drawing.Size(140, 0);
            this.btnAdministrativo.Name = "btnAdministrativo";
            this.btnAdministrativo.ShowBorder = false;
            // 
            // btnParametro
            // 
            this.btnParametro.Image = global::TeleHelp_WFR.Properties.Resources.if_params_115702;
            this.btnParametro.Name = "btnParametro";
            resources.ApplyResources(this.btnParametro, "btnParametro");
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            resources.ApplyResources(this.radMenuSeparatorItem1, "radMenuSeparatorItem1");
            // 
            // btnSairSistema
            // 
            this.btnSairSistema.AccessibleDescription = "btnSairSistema";
            resources.ApplyResources(this.btnSairSistema, "btnSairSistema");
            this.btnSairSistema.Image = global::TeleHelp_WFR.Properties.Resources.if_Exit_Arrow_Door_Signout_Out_Close_1654372;
            this.btnSairSistema.Name = "btnSairSistema";
            // 
            // radRibbonFormBehavior1
            // 
            this.radRibbonFormBehavior1.Form = this;
            // 
            // dockPrincipal
            // 
            this.dockPrincipal.ActiveWindow = this.tlwMensagens;
            this.dockPrincipal.CausesValidation = false;
            this.dockPrincipal.Controls.Add(this.radSplitContainer1);
            this.dockPrincipal.Controls.Add(this.toolTabStrip2);
            resources.ApplyResources(this.dockPrincipal, "dockPrincipal");
            this.dockPrincipal.IsCleanUpTarget = true;
            this.dockPrincipal.MainDocumentContainer = this.dctContainerPrincipal;
            this.dockPrincipal.Name = "dockPrincipal";
            // 
            // 
            // 
            this.dockPrincipal.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.dockPrincipal.ShowDocumentPinButton = true;
            this.dockPrincipal.TabStop = false;
            this.dockPrincipal.ThemeName = "Office2013Light";
            this.dockPrincipal.Click += new System.EventHandler(this.dockPrincipal_Click);
            // 
            // tlwMensagens
            // 
            this.tlwMensagens.Caption = null;
            this.tlwMensagens.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            resources.ApplyResources(this.tlwMensagens, "tlwMensagens");
            this.tlwMensagens.Name = "tlwMensagens";
            this.tlwMensagens.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.tlwMensagens.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.toolTabStrip1);
            this.radSplitContainer1.Controls.Add(this.dctContainerPrincipal);
            this.radSplitContainer1.IsCleanUpTarget = true;
            resources.ApplyResources(this.radSplitContainer1, "radSplitContainer1");
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.ThemeName = "Office2013Light";
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CanUpdateChildIndex = true;
            this.toolTabStrip1.Controls.Add(this.tlwMenuLateral);
            resources.ApplyResources(this.toolTabStrip1, "toolTabStrip1");
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.SizeInfo.AbsoluteSize = new System.Drawing.Size(164, 153);
            this.toolTabStrip1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-36, -47);
            this.toolTabStrip1.TabStop = false;
            this.toolTabStrip1.ThemeName = "Office2013Light";
            // 
            // tlwMenuLateral
            // 
            this.tlwMenuLateral.AllowDrop = true;
            this.tlwMenuLateral.Caption = null;
            this.tlwMenuLateral.Controls.Add(this.rdmMenuLateral);
            this.tlwMenuLateral.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlwMenuLateral.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.ActiveWindowList;
            resources.ApplyResources(this.tlwMenuLateral, "tlwMenuLateral");
            this.tlwMenuLateral.Name = "tlwMenuLateral";
            this.tlwMenuLateral.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.tlwMenuLateral.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // rdmMenuLateral
            // 
            resources.ApplyResources(this.rdmMenuLateral, "rdmMenuLateral");
            this.rdmMenuLateral.Name = "rdmMenuLateral";
            this.rdmMenuLateral.ThemeName = "Office2013Light";
            // 
            // dctContainerPrincipal
            // 
            this.dctContainerPrincipal.Name = "dctContainerPrincipal";
            // 
            // 
            // 
            this.dctContainerPrincipal.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.dctContainerPrincipal.SizeInfo.AbsoluteSize = new System.Drawing.Size(1210, 346);
            this.dctContainerPrincipal.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.dctContainerPrincipal.SizeInfo.SplitterCorrection = new System.Drawing.Size(36, 47);
            resources.ApplyResources(this.dctContainerPrincipal, "dctContainerPrincipal");
            this.dctContainerPrincipal.ThemeName = "Office2013Light";
            // 
            // toolTabStrip2
            // 
            this.toolTabStrip2.CanUpdateChildIndex = true;
            this.toolTabStrip2.Controls.Add(this.tlwMensagens);
            resources.ApplyResources(this.toolTabStrip2, "toolTabStrip2");
            this.toolTabStrip2.Name = "toolTabStrip2";
            // 
            // 
            // 
            this.toolTabStrip2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip2.SelectedIndex = 0;
            this.toolTabStrip2.TabStop = false;
            this.toolTabStrip2.ThemeName = "Office2013Light";
            // 
            // radContextMenu1
            // 
            this.radContextMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3});
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Name = "radMenuItem1";
            resources.ApplyResources(this.radMenuItem1, "radMenuItem1");
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            resources.ApplyResources(this.radMenuItem2, "radMenuItem2");
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Name = "radMenuItem3";
            resources.ApplyResources(this.radMenuItem3, "radMenuItem3");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dockPrincipal);
            this.Controls.Add(this.rbbMenuPrincipal);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ThemeName = "Office2013Light";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.rbbMenuPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockPrincipal)).EndInit();
            this.dockPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            this.tlwMenuLateral.ResumeLayout(false);
            this.tlwMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdmMenuLateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dctContainerPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).EndInit();
            this.toolTabStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadRibbonBar rbbMenuPrincipal;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup bbgAvatar;
        private Telerik.WinControls.UI.RadImageButtonElement ibeAvatar;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup bbgLabelDadosUsuario;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup bbgDadosUsuario;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup bbgDataCorrente;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup bbgSpace;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup bbgMenu;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement2;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement3;
        private Telerik.WinControls.UI.RadLabelElement lblUsuarioFilial;
        private Telerik.WinControls.UI.RadLabelElement lblUsuarioNome;
        private Telerik.WinControls.UI.RadLabelElement lblUsuarioCargo;
        private Telerik.WinControls.UI.RadLabelElement lblDiaMesAno;
        private Telerik.WinControls.UI.RadLabelElement lblDiaSemana;
        private Telerik.WinControls.UI.RadButtonElement btnDashboard;
        private Telerik.WinControls.UI.RadButtonElement btnCliente;
        private Telerik.WinControls.UI.RadButtonElement btnFinanceiro;
        private Telerik.WinControls.UI.RadButtonElement btnComercial;
        private Telerik.WinControls.UI.RadButtonElement btnAdministrativo;
        private Telerik.WinControls.UI.RadLabelElement lblSpace;
        private Telerik.WinControls.UI.RadMenuItem btnParametro;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem btnSairSistema;
        private Telerik.WinControls.UI.Docking.RadDock dockPrincipal;
        private Telerik.WinControls.UI.Docking.DocumentContainer dctContainerPrincipal;
        private Telerik.WinControls.UI.Docking.ToolWindow tlwMenuLateral;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow tlwMensagens;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.RadContextMenu radContextMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenu rdmMenuLateral;
    }
}
