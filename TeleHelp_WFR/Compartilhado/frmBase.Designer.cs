namespace TeleHelp_WFR.Compartilhado
{
    partial class frmBase
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
            this.cmbMenuBase = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.cbeMenuGravar = new Telerik.WinControls.UI.CommandBarStripElement();
            this.btnSalvar = new Telerik.WinControls.UI.CommandBarButton();
            this.btnAlterar = new Telerik.WinControls.UI.CommandBarButton();
            this.btnNovo = new Telerik.WinControls.UI.CommandBarButton();
            this.btnCancelar = new Telerik.WinControls.UI.CommandBarButton();
            this.btnExcluir = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMenuBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMenuBase
            // 
            this.cmbMenuBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbMenuBase.Location = new System.Drawing.Point(0, 0);
            this.cmbMenuBase.Name = "cmbMenuBase";
            this.cmbMenuBase.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.cmbMenuBase.Size = new System.Drawing.Size(640, 33);
            this.cmbMenuBase.TabIndex = 0;
            this.cmbMenuBase.Text = "radCommandBar1";
            this.cmbMenuBase.ThemeName = "Office2013Light";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.BorderBottomWidth = 0F;
            this.commandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.cbeMenuGravar});
            this.commandBarRowElement1.Text = "";
            this.commandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.UseCompatibleTextRendering = false;
            // 
            // cbeMenuGravar
            // 
            this.cbeMenuGravar.AccessibleDescription = "cbeMenuGravar";
            this.cbeMenuGravar.AccessibleName = "cbeMenuGravar";
            this.cbeMenuGravar.BorderBottomWidth = 0F;
            this.cbeMenuGravar.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder;
            this.cbeMenuGravar.BorderWidth = 0F;
            this.cbeMenuGravar.DisplayName = "commandBarStripElement1";
            this.cbeMenuGravar.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.btnSalvar,
            this.btnAlterar,
            this.btnNovo,
            this.btnCancelar,
            this.btnExcluir});
            this.cbeMenuGravar.Name = "cbeMenuGravar";
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleDescription = "btnSalvar";
            this.btnSalvar.AccessibleName = "btnSalvar";
            this.btnSalvar.DisplayName = "commandBarButton1";
            this.btnSalvar.DrawText = true;
            this.btnSalvar.Image = global::TeleHelp_WFR.Properties.Resources.if_simpline_save_24X24__1_;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AccessibleDescription = "btnAlterar";
            this.btnAlterar.AccessibleName = "btnAlterar";
            this.btnAlterar.DisplayName = "commandBarButton2";
            this.btnAlterar.DrawText = true;
            this.btnAlterar.Image = global::TeleHelp_WFR.Properties.Resources.if_icon_136_document_edit_24X24Real;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AccessibleDescription = "btnNovo";
            this.btnNovo.AccessibleName = "btnNovo";
            this.btnNovo.DisplayName = "commandBarButton3";
            this.btnNovo.DrawText = true;
            this.btnNovo.Image = global::TeleHelp_WFR.Properties.Resources.novo;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleDescription = "btnCancelar";
            this.btnCancelar.AccessibleName = "btnCancelar";
            this.btnCancelar.DisplayName = "commandBarButton4";
            this.btnCancelar.DrawText = true;
            this.btnCancelar.Image = global::TeleHelp_WFR.Properties.Resources.cancelar;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayName = "commandBarButton5";
            this.btnExcluir.DrawText = true;
            this.btnExcluir.Image = global::TeleHelp_WFR.Properties.Resources.excluir;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // commandBarStripElement2
            // 
            this.commandBarStripElement2.DisplayName = "commandBarStripElement2";
            this.commandBarStripElement2.Name = "commandBarStripElement2";
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 392);
            this.Controls.Add(this.cmbMenuBase);
            this.Name = "frmBase";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmBase";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.cmbMenuBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCommandBar cmbMenuBase;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement2;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.UI.CommandBarButton btnAlterar;
        private Telerik.WinControls.UI.CommandBarButton btnNovo;
        private Telerik.WinControls.UI.CommandBarButton btnSalvar;
        private Telerik.WinControls.UI.CommandBarButton btnCancelar;
        private Telerik.WinControls.UI.CommandBarButton btnExcluir;
        private Telerik.WinControls.UI.CommandBarStripElement cbeMenuGravar;
    }
}
