namespace TeleHelp_WFR.Modulos.Administrativo
{
    partial class frmCadGrupo
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.txtNome = new Telerik.WinControls.UI.RadTextBox();
            this.panelGrupo = new Telerik.WinControls.UI.RadPanel();
            this.panelGrupos = new Telerik.WinControls.UI.RadPanel();
            this.gdvGruposBD = new Telerik.WinControls.UI.RadGridView();
            this.panelEditGrupo = new Telerik.WinControls.UI.RadPanel();
            this.groupTela = new Telerik.WinControls.UI.RadGroupBox();
            this.gdvTelaPermissao = new Telerik.WinControls.UI.RadGridView();
            this.rchkTelas = new Telerik.WinControls.UI.RadCheckedListBox();
            this.txtCodigo = new Telerik.WinControls.UI.RadTextBox();
            this.lblCodigo = new Telerik.WinControls.UI.RadLabel();
            this.txtDescricao = new Telerik.WinControls.UI.RadTextBox();
            this.groupAtivo = new Telerik.WinControls.UI.RadGroupBox();
            this.rbtnSim = new Telerik.WinControls.UI.RadRadioButton();
            this.rbtnNao = new Telerik.WinControls.UI.RadRadioButton();
            this.lbNome = new Telerik.WinControls.UI.RadLabel();
            this.lbAtivo = new Telerik.WinControls.UI.RadLabel();
            this.lbDescricao = new Telerik.WinControls.UI.RadLabel();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.ctrBotoesPadraoCadastro1 = new TeleHelp_WFR.Controles.ctrBotoesPadraoCadastro();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelGrupo)).BeginInit();
            this.panelGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelGrupos)).BeginInit();
            this.panelGrupos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGruposBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGruposBD.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEditGrupo)).BeginInit();
            this.panelEditGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupTela)).BeginInit();
            this.groupTela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTelaPermissao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTelaPermissao.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rchkTelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAtivo)).BeginInit();
            this.groupAtivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnNao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAtivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(84, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(217, 19);
            this.txtNome.TabIndex = 1;
            this.txtNome.ThemeName = "Office2013Light";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.txtNome.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // panelGrupo
            // 
            this.panelGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrupo.Controls.Add(this.panelGrupos);
            this.panelGrupo.Controls.Add(this.panelEditGrupo);
            this.panelGrupo.Location = new System.Drawing.Point(9, 39);
            this.panelGrupo.Name = "panelGrupo";
            this.panelGrupo.Size = new System.Drawing.Size(1322, 568);
            this.panelGrupo.TabIndex = 2;
            this.panelGrupo.Text = "Dados do Grupo";
            this.panelGrupo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.panelGrupo.ThemeName = "Office2013Light";
            ((Telerik.WinControls.UI.RadPanelElement)(this.panelGrupo.GetChildAt(0))).Text = "Dados do Grupo";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panelGrupo.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.panelGrupo.GetChildAt(0).GetChildAt(2))).TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.panelGrupo.GetChildAt(0).GetChildAt(2))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.panelGrupo.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // panelGrupos
            // 
            this.panelGrupos.AccessibleDescription = "panelGrupos";
            this.panelGrupos.AccessibleName = "panelGrupos";
            this.panelGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelGrupos.Controls.Add(this.gdvGruposBD);
            this.panelGrupos.Location = new System.Drawing.Point(3, 23);
            this.panelGrupos.Name = "panelGrupos";
            this.panelGrupos.Size = new System.Drawing.Size(499, 545);
            this.panelGrupos.TabIndex = 3;
            this.panelGrupos.Text = "radPanel1";
            this.panelGrupos.ThemeName = "Office2013Light";
            ((Telerik.WinControls.UI.RadPanelElement)(this.panelGrupos.GetChildAt(0))).Text = "radPanel1";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panelGrupos.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.panelGrupos.GetChildAt(0).GetChildAt(2))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.panelGrupos.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // gdvGruposBD
            // 
            this.gdvGruposBD.AccessibleDescription = "gdvGruposBD";
            this.gdvGruposBD.AccessibleName = "gdvGruposBD";
            this.gdvGruposBD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvGruposBD.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.gdvGruposBD.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gdvGruposBD.MasterTemplate.AllowAddNewRow = false;
            this.gdvGruposBD.MasterTemplate.AllowColumnChooser = false;
            this.gdvGruposBD.MasterTemplate.AllowDeleteRow = false;
            this.gdvGruposBD.MasterTemplate.AllowDragToGroup = false;
            this.gdvGruposBD.MasterTemplate.AllowEditRow = false;
            this.gdvGruposBD.MasterTemplate.ClipboardCopyMode = Telerik.WinControls.UI.GridViewClipboardCopyMode.Disable;
            this.gdvGruposBD.MasterTemplate.ClipboardCutMode = Telerik.WinControls.UI.GridViewClipboardCutMode.Disable;
            this.gdvGruposBD.MasterTemplate.EnableGrouping = false;
            this.gdvGruposBD.MasterTemplate.ShowRowHeaderColumn = false;
            this.gdvGruposBD.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvGruposBD.Name = "gdvGruposBD";
            this.gdvGruposBD.ShowGroupPanelScrollbars = false;
            this.gdvGruposBD.ShowItemToolTips = false;
            this.gdvGruposBD.Size = new System.Drawing.Size(481, 539);
            this.gdvGruposBD.TabIndex = 0;
            this.gdvGruposBD.ThemeName = "Office2013Light";
            this.gdvGruposBD.Click += new System.EventHandler(this.gdvGruposBD_Click);
            // 
            // panelEditGrupo
            // 
            this.panelEditGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditGrupo.Controls.Add(this.groupTela);
            this.panelEditGrupo.Controls.Add(this.ctrBotoesPadraoCadastro1);
            this.panelEditGrupo.Controls.Add(this.txtCodigo);
            this.panelEditGrupo.Controls.Add(this.txtNome);
            this.panelEditGrupo.Controls.Add(this.lblCodigo);
            this.panelEditGrupo.Controls.Add(this.txtDescricao);
            this.panelEditGrupo.Controls.Add(this.groupAtivo);
            this.panelEditGrupo.Controls.Add(this.lbNome);
            this.panelEditGrupo.Controls.Add(this.lbAtivo);
            this.panelEditGrupo.Controls.Add(this.lbDescricao);
            this.panelEditGrupo.Location = new System.Drawing.Point(508, 23);
            this.panelEditGrupo.Name = "panelEditGrupo";
            this.panelEditGrupo.Size = new System.Drawing.Size(811, 542);
            this.panelEditGrupo.TabIndex = 3;
            this.panelEditGrupo.ThemeName = "Office2013Light";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panelEditGrupo.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.panelEditGrupo.GetChildAt(0).GetChildAt(2))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.panelEditGrupo.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // groupTela
            // 
            this.groupTela.AccessibleDescription = "groupTela";
            this.groupTela.AccessibleName = "groupTela";
            this.groupTela.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupTela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTela.Controls.Add(this.gdvTelaPermissao);
            this.groupTela.Controls.Add(this.rchkTelas);
            this.groupTela.Enabled = false;
            this.groupTela.HeaderText = "ACESSO AS TELAS";
            this.groupTela.Location = new System.Drawing.Point(12, 212);
            this.groupTela.Name = "groupTela";
            this.groupTela.Size = new System.Drawing.Size(789, 293);
            this.groupTela.TabIndex = 13;
            this.groupTela.Text = "ACESSO AS TELAS";
            this.groupTela.ThemeName = "Office2013Light";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupTela.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Text = "ACESSO AS TELAS";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupTela.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupTela.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).ForeColor = System.Drawing.SystemColors.Highlight;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupTela.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gdvTelaPermissao
            // 
            this.gdvTelaPermissao.AccessibleDescription = "gdvTelaPermissao";
            this.gdvTelaPermissao.AccessibleName = "gdvTelaPermissao";
            this.gdvTelaPermissao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvTelaPermissao.Location = new System.Drawing.Point(239, 28);
            // 
            // 
            // 
            this.gdvTelaPermissao.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gdvTelaPermissao.MasterTemplate.AllowAddNewRow = false;
            this.gdvTelaPermissao.MasterTemplate.AllowColumnReorder = false;
            this.gdvTelaPermissao.MasterTemplate.AllowDeleteRow = false;
            this.gdvTelaPermissao.MasterTemplate.AllowDragToGroup = false;
            this.gdvTelaPermissao.MasterTemplate.ClipboardCopyMode = Telerik.WinControls.UI.GridViewClipboardCopyMode.Disable;
            this.gdvTelaPermissao.MasterTemplate.ClipboardCutMode = Telerik.WinControls.UI.GridViewClipboardCutMode.Disable;
            this.gdvTelaPermissao.MasterTemplate.ClipboardPasteMode = Telerik.WinControls.UI.GridViewClipboardPasteMode.Disable;
            gridViewTextBoxColumn1.AllowGroup = false;
            gridViewTextBoxColumn1.AllowHide = false;
            gridViewTextBoxColumn1.DataType = typeof(int);
            gridViewTextBoxColumn1.HeaderText = "CÓDIGO";
            gridViewTextBoxColumn1.MaxWidth = 120;
            gridViewTextBoxColumn1.MinWidth = 40;
            gridViewTextBoxColumn1.Name = "IdTela";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 80;
            this.gdvTelaPermissao.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.gdvTelaPermissao.MasterTemplate.EnableGrouping = false;
            this.gdvTelaPermissao.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gdvTelaPermissao.Name = "gdvTelaPermissao";
            // 
            // 
            // 
            this.gdvTelaPermissao.RootElement.FocusBorderWidth = 3;
            this.gdvTelaPermissao.ShowGroupPanel = false;
            this.gdvTelaPermissao.ShowGroupPanelScrollbars = false;
            this.gdvTelaPermissao.Size = new System.Drawing.Size(550, 260);
            this.gdvTelaPermissao.TabIndex = 1;
            this.gdvTelaPermissao.ThemeName = "Office2013Light";
            this.gdvTelaPermissao.Visible = false;
            // 
            // rchkTelas
            // 
            this.rchkTelas.AccessibleDescription = "rchkTelas";
            this.rchkTelas.AccessibleName = "rchkTelas";
            this.rchkTelas.AllowColumnReorder = false;
            this.rchkTelas.AllowColumnResize = false;
            this.rchkTelas.AllowRemove = false;
            this.rchkTelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rchkTelas.Location = new System.Drawing.Point(0, 28);
            this.rchkTelas.Name = "rchkTelas";
            this.rchkTelas.Size = new System.Drawing.Size(227, 260);
            this.rchkTelas.TabIndex = 0;
            this.rchkTelas.Text = "radCheckedListBox1";
            this.rchkTelas.ThemeName = "Office2013Light";
            this.rchkTelas.ItemCheckedChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.rchkTelas_ItemCheckedChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(84, 70);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(68, 19);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.ThemeName = "Office2013Light";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.txtCodigo.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // lblCodigo
            // 
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCodigo.Location = new System.Drawing.Point(13, 72);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 18);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(84, 123);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(217, 19);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.ThemeName = "Office2013Light";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.txtDescricao.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // groupAtivo
            // 
            this.groupAtivo.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupAtivo.Controls.Add(this.rbtnSim);
            this.groupAtivo.Controls.Add(this.rbtnNao);
            this.groupAtivo.HeaderText = "";
            this.groupAtivo.Location = new System.Drawing.Point(84, 153);
            this.groupAtivo.Name = "groupAtivo";
            this.groupAtivo.Size = new System.Drawing.Size(128, 53);
            this.groupAtivo.TabIndex = 10;
            this.groupAtivo.ThemeName = "Office2013Light";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.groupAtivo.GetChildAt(0).GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.groupAtivo.GetChildAt(0).GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.groupAtivo.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupAtivo.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Text = "";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupAtivo.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupAtivo.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupAtivo.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupAtivo.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupAtivo.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // rbtnSim
            // 
            this.rbtnSim.Location = new System.Drawing.Point(7, 21);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.ReadOnly = true;
            this.rbtnSim.Size = new System.Drawing.Size(44, 19);
            this.rbtnSim.TabIndex = 8;
            this.rbtnSim.Text = "SIM";
            this.rbtnSim.ThemeName = "Office2013Light";
            // 
            // rbtnNao
            // 
            this.rbtnNao.Location = new System.Drawing.Point(79, 21);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.ReadOnly = true;
            this.rbtnNao.Size = new System.Drawing.Size(50, 19);
            this.rbtnNao.TabIndex = 9;
            this.rbtnNao.Text = "NÃO";
            this.rbtnNao.ThemeName = "Office2013Light";
            ((Telerik.WinControls.UI.RadRadioButtonElement)(this.rbtnNao.GetChildAt(0))).Text = "NÃO";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.rbtnNao.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // lbNome
            // 
            this.lbNome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbNome.Location = new System.Drawing.Point(12, 99);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(39, 18);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = "NOME";
            // 
            // lbAtivo
            // 
            this.lbAtivo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbAtivo.Location = new System.Drawing.Point(13, 174);
            this.lbAtivo.Name = "lbAtivo";
            this.lbAtivo.Size = new System.Drawing.Size(38, 18);
            this.lbAtivo.TabIndex = 5;
            this.lbAtivo.Text = "ATIVO";
            // 
            // lbDescricao
            // 
            this.lbDescricao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDescricao.Location = new System.Drawing.Point(12, 126);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(66, 18);
            this.lbDescricao.TabIndex = 5;
            this.lbDescricao.Text = "DESCRIÇÃO";
            // 
            // ctrBotoesPadraoCadastro1
            // 
            this.ctrBotoesPadraoCadastro1.BackColor = System.Drawing.Color.Transparent;
            this.ctrBotoesPadraoCadastro1.Location = new System.Drawing.Point(13, 16);
            this.ctrBotoesPadraoCadastro1.Name = "ctrBotoesPadraoCadastro1";
            this.ctrBotoesPadraoCadastro1.Size = new System.Drawing.Size(296, 35);
            this.ctrBotoesPadraoCadastro1.TabIndex = 12;
            // 
            // frmCadGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 619);
            this.Controls.Add(this.panelGrupo);
            this.Name = "frmCadGrupo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmCadGrupo";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.frmCadGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelGrupo)).EndInit();
            this.panelGrupo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelGrupos)).EndInit();
            this.panelGrupos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvGruposBD.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGruposBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEditGrupo)).EndInit();
            this.panelEditGrupo.ResumeLayout(false);
            this.panelEditGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupTela)).EndInit();
            this.groupTela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvTelaPermissao.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTelaPermissao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rchkTelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAtivo)).EndInit();
            this.groupAtivo.ResumeLayout(false);
            this.groupAtivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnNao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAtivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtNome;
        private Telerik.WinControls.UI.RadPanel panelGrupo;
        private Telerik.WinControls.UI.RadLabel lbDescricao;
        private Telerik.WinControls.UI.RadLabel lbAtivo;
        private Telerik.WinControls.UI.RadLabel lbNome;
        private Telerik.WinControls.UI.RadTextBox txtDescricao;
        private Telerik.WinControls.UI.RadRadioButton rbtnNao;
        private Telerik.WinControls.UI.RadRadioButton rbtnSim;
        private Telerik.WinControls.UI.RadGroupBox groupAtivo;
        private Telerik.WinControls.UI.RadTextBox txtCodigo;
        private Telerik.WinControls.UI.RadLabel lblCodigo;
        private Telerik.WinControls.UI.RadPanel panelEditGrupo;
        private Telerik.WinControls.UI.RadPanel panelGrupos;
        private Telerik.WinControls.UI.RadGridView gdvGruposBD;
        public Controles.ctrBotoesPadraoCadastro ctrBotoesPadraoCadastro1;
        private Telerik.WinControls.UI.RadGroupBox groupTela;
        private Telerik.WinControls.UI.RadCheckedListBox rchkTelas;
        private Telerik.WinControls.UI.RadGridView gdvTelaPermissao;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}
