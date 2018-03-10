namespace TeleHelp_WFR.Modulos.Administrativo
{
    partial class frmCadCargo
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
            this.txtCodigo = new Telerik.WinControls.UI.RadTextBox();
            this.painelCargo = new Telerik.WinControls.UI.RadPanel();
            this.lblCargo = new Telerik.WinControls.UI.RadLabel();
            this.dropListaCargo = new Telerik.WinControls.UI.RadDropDownList();
            this.rgrpCargo = new Telerik.WinControls.UI.RadGroupBox();
            this.rbtnNao = new Telerik.WinControls.UI.RadRadioButton();
            this.rbtnSim = new Telerik.WinControls.UI.RadRadioButton();
            this.rlblAtivo = new Telerik.WinControls.UI.RadLabel();
            this.rlblDescricao = new Telerik.WinControls.UI.RadLabel();
            this.rlblNome = new Telerik.WinControls.UI.RadLabel();
            this.txtNome = new Telerik.WinControls.UI.RadTextBox();
            this.txtDescricao = new Telerik.WinControls.UI.RadTextBox();
            this.rlblCodigo = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.painelCargo)).BeginInit();
            this.painelCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropListaCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrpCargo)).BeginInit();
            this.rgrpCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnNao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblAtivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(110, 78);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(67, 21);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.ThemeName = "Office2013Light";
            // 
            // painelCargo
            // 
            this.painelCargo.Controls.Add(this.lblCargo);
            this.painelCargo.Controls.Add(this.dropListaCargo);
            this.painelCargo.Controls.Add(this.rgrpCargo);
            this.painelCargo.Controls.Add(this.rlblDescricao);
            this.painelCargo.Controls.Add(this.rlblNome);
            this.painelCargo.Controls.Add(this.txtNome);
            this.painelCargo.Controls.Add(this.txtDescricao);
            this.painelCargo.Controls.Add(this.rlblCodigo);
            this.painelCargo.Controls.Add(this.txtCodigo);
            this.painelCargo.Enabled = false;
            this.painelCargo.Location = new System.Drawing.Point(8, 64);
            this.painelCargo.Name = "painelCargo";
            this.painelCargo.Size = new System.Drawing.Size(653, 364);
            this.painelCargo.TabIndex = 2;
            this.painelCargo.Text = "radPanel1";
            this.painelCargo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.painelCargo.ThemeName = "Office2013Light";
            ((Telerik.WinControls.UI.RadPanelElement)(this.painelCargo.GetChildAt(0))).Text = "DADOS DO CARGO";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.painelCargo.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.painelCargo.GetChildAt(0).GetChildAt(2))).TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.painelCargo.GetChildAt(0).GetChildAt(2))).LineLimit = false;
            // 
            // lblCargo
            // 
            this.lblCargo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCargo.Location = new System.Drawing.Point(35, 41);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 18);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "CARGO";
            this.lblCargo.Visible = false;
            // 
            // dropListaCargo
            // 
            this.dropListaCargo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.dropListaCargo.Location = new System.Drawing.Point(109, 38);
            this.dropListaCargo.Name = "dropListaCargo";
            this.dropListaCargo.Size = new System.Drawing.Size(219, 21);
            this.dropListaCargo.TabIndex = 7;
            this.dropListaCargo.Text = "radDropDownList1";
            this.dropListaCargo.ThemeName = "Office2013Light";
            this.dropListaCargo.Visible = false;
            this.dropListaCargo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.dropListaCargo_SelectedIndexChanged);
            // 
            // rgrpCargo
            // 
            this.rgrpCargo.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgrpCargo.Controls.Add(this.rbtnNao);
            this.rgrpCargo.Controls.Add(this.rbtnSim);
            this.rgrpCargo.Controls.Add(this.rlblAtivo);
            this.rgrpCargo.HeaderText = "STATUS DO CARGO";
            this.rgrpCargo.Location = new System.Drawing.Point(35, 166);
            this.rgrpCargo.Name = "rgrpCargo";
            this.rgrpCargo.Size = new System.Drawing.Size(195, 42);
            this.rgrpCargo.TabIndex = 6;
            this.rgrpCargo.Text = "STATUS DO CARGO";
            this.rgrpCargo.ThemeName = "Office2013Light";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.rgrpCargo.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Text = "STATUS DO CARGO";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.rgrpCargo.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.rgrpCargo.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbtnNao
            // 
            this.rbtnNao.Location = new System.Drawing.Point(140, 21);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(50, 19);
            this.rbtnNao.TabIndex = 5;
            this.rbtnNao.Text = "NÃO";
            this.rbtnNao.ThemeName = "Office2013Light";
            // 
            // rbtnSim
            // 
            this.rbtnSim.Location = new System.Drawing.Point(74, 21);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(44, 19);
            this.rbtnSim.TabIndex = 4;
            this.rbtnSim.Text = "SIM";
            this.rbtnSim.ThemeName = "Office2013Light";
            // 
            // rlblAtivo
            // 
            this.rlblAtivo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rlblAtivo.Location = new System.Drawing.Point(5, 22);
            this.rlblAtivo.Name = "rlblAtivo";
            this.rlblAtivo.Size = new System.Drawing.Size(38, 18);
            this.rlblAtivo.TabIndex = 3;
            this.rlblAtivo.Text = "ATIVO";
            // 
            // rlblDescricao
            // 
            this.rlblDescricao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rlblDescricao.Location = new System.Drawing.Point(35, 132);
            this.rlblDescricao.Name = "rlblDescricao";
            this.rlblDescricao.Size = new System.Drawing.Size(66, 18);
            this.rlblDescricao.TabIndex = 3;
            this.rlblDescricao.Text = "DESCRIÇÃO";
            // 
            // rlblNome
            // 
            this.rlblNome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rlblNome.Location = new System.Drawing.Point(35, 106);
            this.rlblNome.Name = "rlblNome";
            this.rlblNome.Size = new System.Drawing.Size(39, 18);
            this.rlblNome.TabIndex = 3;
            this.rlblNome.Text = "NOME";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(110, 104);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(245, 21);
            this.txtNome.TabIndex = 2;
            this.txtNome.ThemeName = "Office2013Light";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(110, 130);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(313, 21);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.ThemeName = "Office2013Light";
            // 
            // rlblCodigo
            // 
            this.rlblCodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rlblCodigo.Location = new System.Drawing.Point(35, 80);
            this.rlblCodigo.Name = "rlblCodigo";
            this.rlblCodigo.Size = new System.Drawing.Size(49, 18);
            this.rlblCodigo.TabIndex = 2;
            this.rlblCodigo.Text = "CÓDIGO";
            // 
            // frmCadCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 433);
            this.Controls.Add(this.painelCargo);
            this.Name = "frmCadCargo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmCargo";
            this.Controls.SetChildIndex(this.painelCargo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.painelCargo)).EndInit();
            this.painelCargo.ResumeLayout(false);
            this.painelCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropListaCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrpCargo)).EndInit();
            this.rgrpCargo.ResumeLayout(false);
            this.rgrpCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnNao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblAtivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlblCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtCodigo;
        private Telerik.WinControls.UI.RadPanel painelCargo;
        private Telerik.WinControls.UI.RadRadioButton rbtnNao;
        private Telerik.WinControls.UI.RadRadioButton rbtnSim;
        private Telerik.WinControls.UI.RadLabel rlblDescricao;
        private Telerik.WinControls.UI.RadLabel rlblNome;
        private Telerik.WinControls.UI.RadLabel rlblAtivo;
        private Telerik.WinControls.UI.RadTextBox txtNome;
        private Telerik.WinControls.UI.RadTextBox txtDescricao;
        private Telerik.WinControls.UI.RadLabel rlblCodigo;
        private Telerik.WinControls.UI.RadGroupBox rgrpCargo;
        private Telerik.WinControls.UI.RadDropDownList dropListaCargo;
        private Telerik.WinControls.UI.RadLabel lblCargo;
    }
}
