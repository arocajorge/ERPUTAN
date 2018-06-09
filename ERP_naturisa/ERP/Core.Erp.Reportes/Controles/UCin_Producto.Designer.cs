namespace Core.Erp.Reportes.Controles
{
    partial class UCin_Producto
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
            this.lblProductoIni = new System.Windows.Forms.Label();
            this.lblProductoFin = new System.Windows.Forms.Label();
            this.cmb_ProductoIni = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProductoIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion_ConCodigo_Ini = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_ProductoFin = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion_ConCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ProductoIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ProductoFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductoIni
            // 
            this.lblProductoIni.AutoSize = true;
            this.lblProductoIni.Location = new System.Drawing.Point(3, 9);
            this.lblProductoIni.Name = "lblProductoIni";
            this.lblProductoIni.Size = new System.Drawing.Size(83, 13);
            this.lblProductoIni.TabIndex = 0;
            this.lblProductoIni.Text = "Producto Inicial:";
            // 
            // lblProductoFin
            // 
            this.lblProductoFin.AutoSize = true;
            this.lblProductoFin.Location = new System.Drawing.Point(3, 36);
            this.lblProductoFin.Name = "lblProductoFin";
            this.lblProductoFin.Size = new System.Drawing.Size(78, 13);
            this.lblProductoFin.TabIndex = 1;
            this.lblProductoFin.Text = "Producto Final:";
            // 
            // cmb_ProductoIni
            // 
            this.cmb_ProductoIni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_ProductoIni.Location = new System.Drawing.Point(89, 6);
            this.cmb_ProductoIni.Name = "cmb_ProductoIni";
            this.cmb_ProductoIni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ProductoIni.Properties.DisplayMember = "pr_descripcion";
            this.cmb_ProductoIni.Properties.ValueMember = "IdProducto";
            this.cmb_ProductoIni.Properties.View = this.searchLookUpEdit1View;
            this.cmb_ProductoIni.Size = new System.Drawing.Size(141, 20);
            this.cmb_ProductoIni.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProductoIni,
            this.colpr_descripcion_ConCodigo_Ini});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProductoIni
            // 
            this.colIdProductoIni.Caption = "Id Producto";
            this.colIdProductoIni.FieldName = "IdProducto";
            this.colIdProductoIni.Name = "colIdProductoIni";
            this.colIdProductoIni.Visible = true;
            this.colIdProductoIni.VisibleIndex = 0;
            this.colIdProductoIni.Width = 175;
            // 
            // colpr_descripcion_ConCodigo_Ini
            // 
            this.colpr_descripcion_ConCodigo_Ini.Caption = "Descripcion del Producto";
            this.colpr_descripcion_ConCodigo_Ini.FieldName = "pr_descripcion";
            this.colpr_descripcion_ConCodigo_Ini.Name = "colpr_descripcion_ConCodigo_Ini";
            this.colpr_descripcion_ConCodigo_Ini.Visible = true;
            this.colpr_descripcion_ConCodigo_Ini.VisibleIndex = 1;
            this.colpr_descripcion_ConCodigo_Ini.Width = 1005;
            // 
            // cmb_ProductoFin
            // 
            this.cmb_ProductoFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_ProductoFin.Location = new System.Drawing.Point(89, 33);
            this.cmb_ProductoFin.Name = "cmb_ProductoFin";
            this.cmb_ProductoFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ProductoFin.Properties.DisplayMember = "pr_descripcion";
            this.cmb_ProductoFin.Properties.ValueMember = "IdProducto";
            this.cmb_ProductoFin.Properties.View = this.searchLookUpEdit2View;
            this.cmb_ProductoFin.Size = new System.Drawing.Size(141, 20);
            this.cmb_ProductoFin.TabIndex = 3;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colpr_descripcion_ConCodigo});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "Id Producto";
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 0;
            this.colIdProducto.Width = 119;
            // 
            // colpr_descripcion_ConCodigo
            // 
            this.colpr_descripcion_ConCodigo.Caption = "Descripcion del Producto";
            this.colpr_descripcion_ConCodigo.FieldName = "pr_descripcion";
            this.colpr_descripcion_ConCodigo.Name = "colpr_descripcion_ConCodigo";
            this.colpr_descripcion_ConCodigo.Visible = true;
            this.colpr_descripcion_ConCodigo.VisibleIndex = 1;
            this.colpr_descripcion_ConCodigo.Width = 1061;
            // 
            // UCin_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_ProductoFin);
            this.Controls.Add(this.cmb_ProductoIni);
            this.Controls.Add(this.lblProductoFin);
            this.Controls.Add(this.lblProductoIni);
            this.Name = "UCin_Producto";
            this.Size = new System.Drawing.Size(242, 58);
            this.Load += new System.EventHandler(this.UCin_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ProductoIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ProductoFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductoIni;
        private System.Windows.Forms.Label lblProductoFin;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_ProductoIni;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_ProductoFin;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProductoIni;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion_ConCodigo_Ini;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion_ConCodigo;

    }
}
