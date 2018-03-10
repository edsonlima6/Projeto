namespace TeleHelp_WFR.Controles
{
    partial class ctrGridViewClienteServicos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.ColumnGroupsViewDefinition columnGroupsViewDefinition1 = new Telerik.WinControls.UI.ColumnGroupsViewDefinition();
            Telerik.WinControls.UI.GridViewColumnGroup gridViewColumnGroup1 = new Telerik.WinControls.UI.GridViewColumnGroup();
            Telerik.WinControls.UI.GridViewColumnGroupRow gridViewColumnGroupRow1 = new Telerik.WinControls.UI.GridViewColumnGroupRow();
            Telerik.WinControls.UI.GridViewColumnGroup gridViewColumnGroup2 = new Telerik.WinControls.UI.GridViewColumnGroup();
            Telerik.WinControls.UI.GridViewColumnGroupRow gridViewColumnGroupRow2 = new Telerik.WinControls.UI.GridViewColumnGroupRow();
            Telerik.WinControls.UI.GridViewColumnGroup gridViewColumnGroup3 = new Telerik.WinControls.UI.GridViewColumnGroup();
            Telerik.WinControls.UI.GridViewColumnGroupRow gridViewColumnGroupRow3 = new Telerik.WinControls.UI.GridViewColumnGroupRow();
            this.gdvClienteServicos = new Telerik.WinControls.UI.RadGridView();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel20 = new Telerik.WinControls.UI.RadLabel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdvClienteServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvClienteServicos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvClienteServicos
            // 
            this.gdvClienteServicos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvClienteServicos.BackColor = System.Drawing.SystemColors.Control;
            this.gdvClienteServicos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdvClienteServicos.EnableTheming = false;
            this.gdvClienteServicos.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gdvClienteServicos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gdvClienteServicos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gdvClienteServicos.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gdvClienteServicos.MasterTemplate.AllowAddNewRow = false;
            this.gdvClienteServicos.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "colQuantidade";
            gridViewTextBoxColumn1.HeaderText = "QNT";
            gridViewTextBoxColumn1.MaxWidth = 30;
            gridViewTextBoxColumn1.MinWidth = 30;
            gridViewTextBoxColumn1.Name = "colQuantidade";
            gridViewTextBoxColumn1.Width = 30;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "colDescricaoServico";
            gridViewTextBoxColumn2.HeaderText = "DESCRICAO DE SERVIÇOS 24/7";
            gridViewTextBoxColumn2.MaxWidth = 170;
            gridViewTextBoxColumn2.MinWidth = 170;
            gridViewTextBoxColumn2.Name = "colDescricaoServico";
            gridViewTextBoxColumn2.Width = 170;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "colCodigoProduto";
            gridViewTextBoxColumn3.HeaderText = "CÓD. DO PRODUTO";
            gridViewTextBoxColumn3.Name = "colCodigoProduto";
            gridViewTextBoxColumn3.Width = 105;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "colValorUnitarioServico";
            gridViewTextBoxColumn4.HeaderText = "VALOR UNITÁRIO";
            gridViewTextBoxColumn4.MaxWidth = 100;
            gridViewTextBoxColumn4.MinWidth = 100;
            gridViewTextBoxColumn4.Name = "colValorUnitarioServico";
            gridViewTextBoxColumn4.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "colValorTotalServico";
            gridViewTextBoxColumn5.HeaderText = "VALOR TOTAL";
            gridViewTextBoxColumn5.MaxWidth = 100;
            gridViewTextBoxColumn5.MinWidth = 100;
            gridViewTextBoxColumn5.Name = "colValorTotalServico";
            gridViewTextBoxColumn5.Width = 100;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "colValorAdesaoServico";
            gridViewTextBoxColumn6.HeaderText = "VALOR UNITÁRIO";
            gridViewTextBoxColumn6.MaxWidth = 100;
            gridViewTextBoxColumn6.MinWidth = 100;
            gridViewTextBoxColumn6.Name = "colValorAdesaoServico";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 100;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "colValorTotalAdesaoServico";
            gridViewTextBoxColumn7.HeaderText = "VALOR TOTAL";
            gridViewTextBoxColumn7.MaxWidth = 100;
            gridViewTextBoxColumn7.MinWidth = 100;
            gridViewTextBoxColumn7.Name = "colValorTotalAdesaoServico";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 100;
            this.gdvClienteServicos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.gdvClienteServicos.MasterTemplate.EnableSorting = false;
            this.gdvClienteServicos.MasterTemplate.ShowFilteringRow = false;
            sortDescriptor1.PropertyName = "colValorUnitarioServico";
            this.gdvClienteServicos.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            gridViewColumnGroup1.Name = "mergeRoot";
            gridViewColumnGroupRow1.ColumnNames.Add("colQuantidade");
            gridViewColumnGroupRow1.ColumnNames.Add("colDescricaoServico");
            gridViewColumnGroupRow1.ColumnNames.Add("colCodigoProduto");
            gridViewColumnGroup1.Rows.Add(gridViewColumnGroupRow1);
            gridViewColumnGroup1.RowSpan = 28;
            gridViewColumnGroup1.ShowHeader = false;
            gridViewColumnGroup1.Text = "";
            gridViewColumnGroup2.Name = "group3";
            gridViewColumnGroupRow2.ColumnNames.Add("colValorUnitarioServico");
            gridViewColumnGroupRow2.ColumnNames.Add("colValorTotalServico");
            gridViewColumnGroup2.Rows.Add(gridViewColumnGroupRow2);
            gridViewColumnGroup2.Text = "VALOR MENSAL";
            gridViewColumnGroup3.Name = "group2";
            gridViewColumnGroupRow3.ColumnNames.Add("column6");
            gridViewColumnGroupRow3.ColumnNames.Add("colValorAdesaoServico");
            gridViewColumnGroupRow3.ColumnNames.Add("colValorTotalAdesaoServico");
            gridViewColumnGroup3.Rows.Add(gridViewColumnGroupRow3);
            gridViewColumnGroup3.Text = "VALOR ADESÃO";
            columnGroupsViewDefinition1.ColumnGroups.Add(gridViewColumnGroup1);
            columnGroupsViewDefinition1.ColumnGroups.Add(gridViewColumnGroup2);
            columnGroupsViewDefinition1.ColumnGroups.Add(gridViewColumnGroup3);
            this.gdvClienteServicos.MasterTemplate.ViewDefinition = columnGroupsViewDefinition1;
            this.gdvClienteServicos.Name = "gdvClienteServicos";
            this.gdvClienteServicos.ReadOnly = true;
            this.gdvClienteServicos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gdvClienteServicos.ShowGroupPanel = false;
            this.gdvClienteServicos.Size = new System.Drawing.Size(733, 449);
            this.gdvClienteServicos.TabIndex = 0;
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel4.AutoSize = false;
            this.radLabel4.BackColor = System.Drawing.Color.Transparent;
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.radLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(214)))));
            this.radLabel4.Location = new System.Drawing.Point(626, 455);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(107, 27);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "R$ 160,00";
            // 
            // radLabel20
            // 
            this.radLabel20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel20.BackColor = System.Drawing.Color.Transparent;
            this.radLabel20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel20.Location = new System.Drawing.Point(475, 460);
            this.radLabel20.Name = "radLabel20";
            this.radLabel20.Size = new System.Drawing.Size(145, 19);
            this.radLabel20.TabIndex = 5;
            this.radLabel20.Text = "VALOR TOTAL SERVIÇOS:";
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.Transparent;
            this.radButton1.Image = global::TeleHelp_WFR.Properties.Resources.adicionar;
            this.radButton1.Location = new System.Drawing.Point(15, 460);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(170, 24);
            this.radButton1.TabIndex = 7;
            this.radButton1.Text = "ADICIONAR SERVIÇOS";
            this.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton1.ThemeName = "Office2013Light";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Image = global::TeleHelp_WFR.Properties.Resources.adicionar;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "ADICIONAR SERVIÇOS";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // ctrGridViewClienteServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel20);
            this.Controls.Add(this.gdvClienteServicos);
            this.Name = "ctrGridViewClienteServicos";
            this.Size = new System.Drawing.Size(733, 485);
            ((System.ComponentModel.ISupportInitialize)(this.gdvClienteServicos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvClienteServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gdvClienteServicos;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel20;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
