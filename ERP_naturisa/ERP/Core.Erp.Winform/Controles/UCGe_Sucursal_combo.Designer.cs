namespace Core.Erp.Winform.Controles
{
    partial class UCGe_Sucursal_combo
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.gridEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbsucursal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEstado2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbsucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEstado
            // 
            this.gridEstado.Caption = "estado";
            this.gridEstado.FieldName = "Estado";
            this.gridEstado.Name = "gridEstado";
            this.gridEstado.Visible = true;
            this.gridEstado.VisibleIndex = 3;
            this.gridEstado.Width = 37;
            // 
            // cmbsucursal
            // 
            this.cmbsucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbsucursal.Location = new System.Drawing.Point(0, 0);
            this.cmbsucursal.Name = "cmbsucursal";
            this.cmbsucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbsucursal.Properties.DisplayMember = "Su_Descripcion2";
            this.cmbsucursal.Properties.ValueMember = "IdSucursal";
            this.cmbsucursal.Properties.View = this.searchLookUpEdit1View;
            this.cmbsucursal.Size = new System.Drawing.Size(298, 20);
            this.cmbsucursal.TabIndex = 0;
            this.cmbsucursal.EditValueChanged += new System.EventHandler(this.cmbsucursal_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSucursal,
            this.colSucursal,
            this.gridEstado,
            this.colSEstado2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.gridEstado;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = false;
            this.searchLookUpEdit1View.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.Caption = "IdSucursal";
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.Visible = true;
            this.colIdSucursal.VisibleIndex = 0;
            this.colIdSucursal.Width = 80;
            // 
            // colSucursal
            // 
            this.colSucursal.Caption = "Sucursal";
            this.colSucursal.FieldName = "Su_Descripcion";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.Visible = true;
            this.colSucursal.VisibleIndex = 1;
            this.colSucursal.Width = 874;
            // 
            // colSEstado2
            // 
            this.colSEstado2.Caption = "Estado";
            this.colSEstado2.FieldName = "SEstado";
            this.colSEstado2.Name = "colSEstado2";
            this.colSEstado2.Visible = true;
            this.colSEstado2.VisibleIndex = 2;
            // 
            // UCGe_Sucursal_combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbsucursal);
            this.Name = "UCGe_Sucursal_combo";
            this.Size = new System.Drawing.Size(298, 22);
            this.Load += new System.EventHandler(this.UCGe_Sucursal_combo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbsucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        public DevExpress.XtraEditors.SearchLookUpEdit cmbsucursal;
        private DevExpress.XtraGrid.Columns.GridColumn gridEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colSEstado2;
    }
}
