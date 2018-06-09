namespace Core.Erp.Reportes.Controles
{
    partial class UCct_CentroCosto
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_CentroCosto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_SubCentro_Costo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CentroCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SubCentro_Costo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_CentroCosto
            // 
            this.cmb_CentroCosto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_CentroCosto.Location = new System.Drawing.Point(99, 3);
            this.cmb_CentroCosto.Name = "cmb_CentroCosto";
            this.cmb_CentroCosto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_CentroCosto.Properties.DisplayMember = "Centro_costo2";
            this.cmb_CentroCosto.Properties.ValueMember = "IdCentroCosto";
            this.cmb_CentroCosto.Properties.View = this.searchLookUpEdit1View;
            this.cmb_CentroCosto.Size = new System.Drawing.Size(168, 20);
            this.cmb_CentroCosto.TabIndex = 1;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdCentroCosto,
            this.colCentro_costo2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdCentroCosto
            // 
            this.ColIdCentroCosto.Caption = "Id Centro de Costo ";
            this.ColIdCentroCosto.FieldName = "IdCentroCosto ";
            this.ColIdCentroCosto.Name = "ColIdCentroCosto";
            this.ColIdCentroCosto.Visible = true;
            this.ColIdCentroCosto.VisibleIndex = 0;
            this.ColIdCentroCosto.Width = 133;
            // 
            // colCentro_costo2
            // 
            this.colCentro_costo2.Caption = "Nombre de Centro Costo";
            this.colCentro_costo2.FieldName = "Centro_costo2";
            this.colCentro_costo2.Name = "colCentro_costo2";
            this.colCentro_costo2.Visible = true;
            this.colCentro_costo2.VisibleIndex = 1;
            this.colCentro_costo2.Width = 1047;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Centro de Costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subcentro de Costo";
            // 
            // cmb_SubCentro_Costo
            // 
            this.cmb_SubCentro_Costo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_SubCentro_Costo.Location = new System.Drawing.Point(99, 27);
            this.cmb_SubCentro_Costo.Name = "cmb_SubCentro_Costo";
            this.cmb_SubCentro_Costo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_SubCentro_Costo.Properties.DisplayMember = "Centro_costo2";
            this.cmb_SubCentro_Costo.Properties.ValueMember = "IdCentroCosto_sub_centro_costo";
            this.cmb_SubCentro_Costo.Properties.View = this.gridView1;
            this.cmb_SubCentro_Costo.Size = new System.Drawing.Size(168, 20);
            this.cmb_SubCentro_Costo.TabIndex = 4;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id Centro de Costo ";
            this.gridColumn1.FieldName = "IdCentroCosto ";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 133;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre de Centro Costo";
            this.gridColumn2.FieldName = "Centro_costo2";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 1047;
            // 
            // UCct_CentroCosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_SubCentro_Costo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_CentroCosto);
            this.Name = "UCct_CentroCosto";
            this.Size = new System.Drawing.Size(274, 51);
            this.Load += new System.EventHandler(this.UCct_CentroCosto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CentroCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SubCentro_Costo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmb_CentroCosto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_SubCentro_Costo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}
