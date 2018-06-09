namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_ProductoConsultaXBodega
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSeleccionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gridControl_Producto = new DevExpress.XtraGrid.GridControl();
            this.gridView_Producto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPedidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_Publico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_Mayor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_Minimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManeja_Iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManeja_Series = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Producto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSeleccionar,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(533, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSeleccionar
            // 
            this.toolStripButtonSeleccionar.Image = global::Core.Erp.Winform.Properties.Resources.nuevo;
            this.toolStripButtonSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSeleccionar.Name = "toolStripButtonSeleccionar";
            this.toolStripButtonSeleccionar.Size = new System.Drawing.Size(81, 22);
            this.toolStripButtonSeleccionar.Text = "Seleccionar";
            this.toolStripButtonSeleccionar.Click += new System.EventHandler(this.toolStripButtonSeleccionar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel1.Text = "                     ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton1.Text = "&Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // gridControl_Producto
            // 
            this.gridControl_Producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Producto.Location = new System.Drawing.Point(0, 25);
            this.gridControl_Producto.MainView = this.gridView_Producto;
            this.gridControl_Producto.Name = "gridControl_Producto";
            this.gridControl_Producto.Size = new System.Drawing.Size(533, 364);
            this.gridControl_Producto.TabIndex = 5;
            this.gridControl_Producto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Producto});
            this.gridControl_Producto.Click += new System.EventHandler(this.gridControl_Producto_Click);
            // 
            // gridView_Producto
            // 
            this.gridView_Producto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdProducto,
            this.colCodigo_Producto,
            this.colProducto,
            this.colidSucursal,
            this.colIdBodega,
            this.colBodega,
            this.colStock,
            this.colPeso,
            this.colPedidos,
            this.colPrecio_Publico,
            this.colPrecio_Mayor,
            this.colPrecio_Minimo,
            this.colManeja_Iva,
            this.colManeja_Series});
            this.gridView_Producto.GridControl = this.gridControl_Producto;
            this.gridView_Producto.Name = "gridView_Producto";
            this.gridView_Producto.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Producto.OptionsView.ShowGroupPanel = false;
            this.gridView_Producto.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_Producto_FocusedRowChanged);
            this.gridView_Producto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_Producto_KeyDown);
            this.gridView_Producto.DoubleClick += new System.EventHandler(this.gridView_Producto_DoubleClick);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            this.colIdEmpresa.Width = 74;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "Id";
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.OptionsColumn.AllowEdit = false;
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 1;
            this.colIdProducto.Width = 63;
            // 
            // colCodigo_Producto
            // 
            this.colCodigo_Producto.FieldName = "pr_codigo";
            this.colCodigo_Producto.Name = "colCodigo_Producto";
            this.colCodigo_Producto.OptionsColumn.AllowEdit = false;
            this.colCodigo_Producto.Width = 74;
            // 
            // colProducto
            // 
            this.colProducto.FieldName = "pr_descripcion";
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.AllowEdit = false;
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 0;
            this.colProducto.Width = 980;
            // 
            // colidSucursal
            // 
            this.colidSucursal.FieldName = "IdSucursal";
            this.colidSucursal.Name = "colidSucursal";
            this.colidSucursal.OptionsColumn.AllowEdit = false;
            this.colidSucursal.Width = 74;
            // 
            // colIdBodega
            // 
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            this.colIdBodega.OptionsColumn.AllowEdit = false;
            this.colIdBodega.Width = 74;
            // 
            // colBodega
            // 
            this.colBodega.FieldName = "Bodega ";
            this.colBodega.Name = "colBodega";
            this.colBodega.OptionsColumn.AllowEdit = false;
            this.colBodega.Width = 74;
            // 
            // colStock
            // 
            this.colStock.FieldName = "pr_stock ";
            this.colStock.Name = "colStock";
            this.colStock.OptionsColumn.AllowEdit = false;
            this.colStock.Width = 74;
            // 
            // colPeso
            // 
            this.colPeso.FieldName = "pr_peso ";
            this.colPeso.Name = "colPeso";
            this.colPeso.OptionsColumn.AllowEdit = false;
            this.colPeso.Width = 74;
            // 
            // colPedidos
            // 
            this.colPedidos.FieldName = "pr_pedidos ";
            this.colPedidos.Name = "colPedidos";
            this.colPedidos.OptionsColumn.AllowEdit = false;
            this.colPedidos.Width = 74;
            // 
            // colPrecio_Publico
            // 
            this.colPrecio_Publico.FieldName = "pr_precio_publico ";
            this.colPrecio_Publico.Name = "colPrecio_Publico";
            this.colPrecio_Publico.OptionsColumn.AllowEdit = false;
            this.colPrecio_Publico.Width = 74;
            // 
            // colPrecio_Mayor
            // 
            this.colPrecio_Mayor.FieldName = "pr_precio_mayor ";
            this.colPrecio_Mayor.Name = "colPrecio_Mayor";
            this.colPrecio_Mayor.OptionsColumn.AllowEdit = false;
            this.colPrecio_Mayor.Width = 74;
            // 
            // colPrecio_Minimo
            // 
            this.colPrecio_Minimo.FieldName = "pr_precio_minimo ";
            this.colPrecio_Minimo.Name = "colPrecio_Minimo";
            this.colPrecio_Minimo.OptionsColumn.AllowEdit = false;
            this.colPrecio_Minimo.Width = 83;
            // 
            // colManeja_Iva
            // 
            this.colManeja_Iva.FieldName = "pr_ManejaIva ";
            this.colManeja_Iva.Name = "colManeja_Iva";
            this.colManeja_Iva.OptionsColumn.AllowEdit = false;
            this.colManeja_Iva.Width = 72;
            // 
            // colManeja_Series
            // 
            this.colManeja_Series.FieldName = "pr_ManejaSeries ";
            this.colManeja_Series.Name = "colManeja_Series";
            this.colManeja_Series.OptionsColumn.AllowEdit = false;
            // 
            // FrmIn_ProductoConsultaXBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 389);
            this.Controls.Add(this.gridControl_Producto);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmIn_ProductoConsultaXBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Productos por Bodega";
            this.Load += new System.EventHandler(this.frmIn_ProductoConsultaXBodega_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSeleccionar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraGrid.GridControl gridControl_Producto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colidSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colPeso;
        private DevExpress.XtraGrid.Columns.GridColumn colPedidos;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_Publico;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_Mayor;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_Minimo;
        private DevExpress.XtraGrid.Columns.GridColumn colManeja_Iva;
        private DevExpress.XtraGrid.Columns.GridColumn colManeja_Series;
    }
}