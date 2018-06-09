namespace Core.Erp.Winform.Controles
{
    partial class UCIn_Grid_Movi_Detalle
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
            this.gridControlProductos = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProducto_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo_cmb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_stock_cmb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_pedidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_precio_publico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_precio_mayor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_precio_minimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto_cmb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldo_Cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_costo_promedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlProductos
            // 
            this.gridControlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductos.Location = new System.Drawing.Point(0, 0);
            this.gridControlProductos.MainView = this.gridViewProductos;
            this.gridControlProductos.Name = "gridControlProductos";
            this.gridControlProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProducto_grid});
            this.gridControlProductos.Size = new System.Drawing.Size(910, 313);
            this.gridControlProductos.TabIndex = 26;
            this.gridControlProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductos});
            this.gridControlProductos.Click += new System.EventHandler(this.gridControlProductos_Click);
            // 
            // gridViewProductos
            // 
            this.gridViewProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colpr_codigo,
            this.colpr_peso,
            this.coldo_Cantidad,
            this.colpr_stock,
            this.colpr_observacion,
            this.colpr_costo_promedio,
            this.gridColumn1});
            this.gridViewProductos.GridControl = this.gridControlProductos;
            this.gridViewProductos.Name = "gridViewProductos";
            this.gridViewProductos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewProductos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewProductos_CellValueChanged);
            this.gridViewProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewProductos_KeyDown);
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "Producto";
            this.colIdProducto.ColumnEdit = this.cmbProducto_grid;
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 0;
            this.colIdProducto.Width = 404;
            // 
            // cmbProducto_grid
            // 
            this.cmbProducto_grid.AutoHeight = false;
            this.cmbProducto_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducto_grid.Name = "cmbProducto_grid";
            this.cmbProducto_grid.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpr_descripcion,
            this.colpr_codigo_cmb,
            this.colpr_stock_cmb,
            this.colpr_pedidos,
            this.colDisponible,
            this.colpr_precio_publico,
            this.colpr_precio_mayor,
            this.colpr_precio_minimo,
            this.colIdProducto_cmb,
            this.colIdBodega,
            this.colIdSucursal});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Descripción";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 0;
            this.colpr_descripcion.Width = 317;
            // 
            // colpr_codigo_cmb
            // 
            this.colpr_codigo_cmb.Caption = "Código Producto";
            this.colpr_codigo_cmb.FieldName = "pr_codigo";
            this.colpr_codigo_cmb.Name = "colpr_codigo_cmb";
            this.colpr_codigo_cmb.Visible = true;
            this.colpr_codigo_cmb.VisibleIndex = 1;
            this.colpr_codigo_cmb.Width = 83;
            // 
            // colpr_stock_cmb
            // 
            this.colpr_stock_cmb.Caption = "Stock";
            this.colpr_stock_cmb.FieldName = "pr_stock_Bodega";
            this.colpr_stock_cmb.Name = "colpr_stock_cmb";
            this.colpr_stock_cmb.Visible = true;
            this.colpr_stock_cmb.VisibleIndex = 2;
            this.colpr_stock_cmb.Width = 66;
            // 
            // colpr_pedidos
            // 
            this.colpr_pedidos.Caption = "Pedidos";
            this.colpr_pedidos.FieldName = "pr_pedidos";
            this.colpr_pedidos.Name = "colpr_pedidos";
            this.colpr_pedidos.Visible = true;
            this.colpr_pedidos.VisibleIndex = 3;
            this.colpr_pedidos.Width = 55;
            // 
            // colDisponible
            // 
            this.colDisponible.Caption = "Disponibles";
            this.colDisponible.FieldName = "Disponible";
            this.colDisponible.Name = "colDisponible";
            this.colDisponible.Visible = true;
            this.colDisponible.VisibleIndex = 4;
            this.colDisponible.Width = 147;
            // 
            // colpr_precio_publico
            // 
            this.colpr_precio_publico.Caption = "P.V.P";
            this.colpr_precio_publico.FieldName = "pr_precio_publico";
            this.colpr_precio_publico.Name = "colpr_precio_publico";
            this.colpr_precio_publico.Visible = true;
            this.colpr_precio_publico.VisibleIndex = 5;
            this.colpr_precio_publico.Width = 70;
            // 
            // colpr_precio_mayor
            // 
            this.colpr_precio_mayor.Caption = "Precio Mayor";
            this.colpr_precio_mayor.FieldName = "pr_precio_mayor";
            this.colpr_precio_mayor.Name = "colpr_precio_mayor";
            this.colpr_precio_mayor.Visible = true;
            this.colpr_precio_mayor.VisibleIndex = 6;
            this.colpr_precio_mayor.Width = 80;
            // 
            // colpr_precio_minimo
            // 
            this.colpr_precio_minimo.Caption = "Precio Mímimo";
            this.colpr_precio_minimo.FieldName = "pr_precio_minimo";
            this.colpr_precio_minimo.Name = "colpr_precio_minimo";
            this.colpr_precio_minimo.Visible = true;
            this.colpr_precio_minimo.VisibleIndex = 7;
            this.colpr_precio_minimo.Width = 78;
            // 
            // colIdProducto_cmb
            // 
            this.colIdProducto_cmb.Caption = "IdProducto";
            this.colIdProducto_cmb.FieldName = "IdProducto";
            this.colIdProducto_cmb.Name = "colIdProducto_cmb";
            this.colIdProducto_cmb.Visible = true;
            this.colIdProducto_cmb.VisibleIndex = 8;
            this.colIdProducto_cmb.Width = 67;
            // 
            // colIdBodega
            // 
            this.colIdBodega.Caption = "IdBodega";
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            this.colIdBodega.Visible = true;
            this.colIdBodega.VisibleIndex = 9;
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.Caption = "IdSucursal";
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.Visible = true;
            this.colIdSucursal.VisibleIndex = 10;
            this.colIdSucursal.Width = 132;
            // 
            // colpr_codigo
            // 
            this.colpr_codigo.Caption = "Código";
            this.colpr_codigo.FieldName = "pr_codigo";
            this.colpr_codigo.Name = "colpr_codigo";
            this.colpr_codigo.OptionsColumn.AllowEdit = false;
            this.colpr_codigo.Visible = true;
            this.colpr_codigo.VisibleIndex = 1;
            this.colpr_codigo.Width = 147;
            // 
            // colpr_peso
            // 
            this.colpr_peso.Caption = "Peso";
            this.colpr_peso.FieldName = "pr_peso";
            this.colpr_peso.Name = "colpr_peso";
            this.colpr_peso.OptionsColumn.AllowEdit = false;
            this.colpr_peso.Visible = true;
            this.colpr_peso.VisibleIndex = 2;
            this.colpr_peso.Width = 91;
            // 
            // coldo_Cantidad
            // 
            this.coldo_Cantidad.Caption = "Cantidad";
            this.coldo_Cantidad.FieldName = "do_Cantidad";
            this.coldo_Cantidad.Name = "coldo_Cantidad";
            this.coldo_Cantidad.Visible = true;
            this.coldo_Cantidad.VisibleIndex = 3;
            this.coldo_Cantidad.Width = 97;
            // 
            // colpr_stock
            // 
            this.colpr_stock.Caption = "Stock Actual";
            this.colpr_stock.FieldName = "pr_stock_Bodega";
            this.colpr_stock.Name = "colpr_stock";
            this.colpr_stock.OptionsColumn.AllowEdit = false;
            this.colpr_stock.Width = 95;
            // 
            // colpr_observacion
            // 
            this.colpr_observacion.Caption = "Observación";
            this.colpr_observacion.FieldName = "pr_observacion";
            this.colpr_observacion.Name = "colpr_observacion";
            this.colpr_observacion.Visible = true;
            this.colpr_observacion.VisibleIndex = 4;
            this.colpr_observacion.Width = 346;
            // 
            // colpr_costo_promedio
            // 
            this.colpr_costo_promedio.Caption = "pr_costo_promedio";
            this.colpr_costo_promedio.FieldName = "pr_costo_promedio";
            this.colpr_costo_promedio.Name = "colpr_costo_promedio";
            this.colpr_costo_promedio.Visible = true;
            this.colpr_costo_promedio.VisibleIndex = 5;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "pr_precio_publico";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // UCIn_Grid_Movi_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlProductos);
            this.Name = "UCIn_Grid_Movi_Detalle";
            this.Size = new System.Drawing.Size(910, 313);
            this.Load += new System.EventHandler(this.UCInv_grid_movi_detalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource1;
        //private Infragistics.Win.UltraWinGrid.UltraCombo ucmb_productos;
        //private Infragistics.Win.UltraWinGrid.UltraCombo ultcCodigo;
        //public Infragistics.Win.UltraWinGrid.UltraGrid ultraGridMinvDetalle;
        private DevExpress.XtraGrid.GridControl gridControlProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_peso;
        private DevExpress.XtraGrid.Columns.GridColumn coldo_Cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_stock;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_observacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProducto_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo_cmb;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_stock_cmb;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_pedidos;
        private DevExpress.XtraGrid.Columns.GridColumn colDisponible;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_precio_publico;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_precio_mayor;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_precio_minimo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto_cmb;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_costo_promedio;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;

    }
}
