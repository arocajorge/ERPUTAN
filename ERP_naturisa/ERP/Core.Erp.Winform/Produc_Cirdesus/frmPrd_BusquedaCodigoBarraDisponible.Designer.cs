namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_BusquedaCodigoBarraDisponible
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
            this.comListadoMaterialesDetInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inProductoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.gridCtrlCodigoBarraDisp = new DevExpress.XtraGrid.GridControl();
            this.gridVwCodigoBarraDisp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovi_inven_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNumMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_Secuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_tipo_movi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_precio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colet_IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colet_IdProcesoProductivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colet_IdEtapa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colot_IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colot_IdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colot_CodObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colot_IdOrdenTaller = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.comListadoMaterialesDetInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProductoInfoBindingSource)).BeginInit();
            this.groupBoxBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlCodigoBarraDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwCodigoBarraDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // comListadoMaterialesDetInfoBindingSource
            // 
            this.comListadoMaterialesDetInfoBindingSource.DataSource = typeof(Core.Erp.Info.Compras.com_ListadoMateriales_Det_Info);
            // 
            // inProductoInfoBindingSource
            // 
            this.inProductoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_Producto_Info);
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.gridCtrlCodigoBarraDisp);
            this.groupBoxBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBusqueda.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(647, 421);
            this.groupBoxBusqueda.TabIndex = 1;
            this.groupBoxBusqueda.TabStop = false;
            // 
            // gridCtrlCodigoBarraDisp
            // 
            this.gridCtrlCodigoBarraDisp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlCodigoBarraDisp.Location = new System.Drawing.Point(3, 16);
            this.gridCtrlCodigoBarraDisp.MainView = this.gridVwCodigoBarraDisp;
            this.gridCtrlCodigoBarraDisp.Name = "gridCtrlCodigoBarraDisp";
            this.gridCtrlCodigoBarraDisp.Size = new System.Drawing.Size(641, 402);
            this.gridCtrlCodigoBarraDisp.TabIndex = 0;
            this.gridCtrlCodigoBarraDisp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVwCodigoBarraDisp});
            this.gridCtrlCodigoBarraDisp.DoubleClick += new System.EventHandler(this.gridCtrlCodigoBarraDisp_DoubleClick);
            this.gridCtrlCodigoBarraDisp.Enter += new System.EventHandler(this.gridCtrlCodigoBarraDisp_Enter);
            // 
            // gridVwCodigoBarraDisp
            // 
            this.gridVwCodigoBarraDisp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdBodega,
            this.colIdMovi_inven_tipo,
            this.colIdNumMovi,
            this.colmv_Secuencia,
            this.colSecuencia,
            this.colIdProducto,
            this.colCodigoBarra,
            this.colmv_tipo_movi,
            this.coldm_cantidad,
            this.coldm_observacion,
            this.coldm_precio,
            this.colmv_costo,
            this.colProducto,
            this.colet_IdEmpresa,
            this.colet_IdProcesoProductivo,
            this.colet_IdEtapa,
            this.colot_IdEmpresa,
            this.colot_IdSucursal,
            this.colot_CodObra,
            this.colot_IdOrdenTaller});
            this.gridVwCodigoBarraDisp.GridControl = this.gridCtrlCodigoBarraDisp;
            this.gridVwCodigoBarraDisp.Name = "gridVwCodigoBarraDisp";
            this.gridVwCodigoBarraDisp.OptionsBehavior.Editable = false;
            this.gridVwCodigoBarraDisp.OptionsFind.AlwaysVisible = true;
            this.gridVwCodigoBarraDisp.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProducto, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridVwCodigoBarraDisp.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridVwCodigoBarraDisp_FocusedRowChanged);
            this.gridVwCodigoBarraDisp.DoubleClick += new System.EventHandler(this.gridCtrlCodigoBarraDisp_DoubleClick);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            // 
            // colIdBodega
            // 
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            // 
            // colIdMovi_inven_tipo
            // 
            this.colIdMovi_inven_tipo.FieldName = "IdMovi_inven_tipo";
            this.colIdMovi_inven_tipo.Name = "colIdMovi_inven_tipo";
            // 
            // colIdNumMovi
            // 
            this.colIdNumMovi.FieldName = "IdNumMovi";
            this.colIdNumMovi.Name = "colIdNumMovi";
            // 
            // colmv_Secuencia
            // 
            this.colmv_Secuencia.FieldName = "mv_Secuencia";
            this.colmv_Secuencia.Name = "colmv_Secuencia";
            // 
            // colSecuencia
            // 
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 0;
            this.colIdProducto.Width = 29;
            // 
            // colCodigoBarra
            // 
            this.colCodigoBarra.Caption = "Código de Barra";
            this.colCodigoBarra.FieldName = "CodigoBarra";
            this.colCodigoBarra.Name = "colCodigoBarra";
            this.colCodigoBarra.Visible = true;
            this.colCodigoBarra.VisibleIndex = 2;
            this.colCodigoBarra.Width = 159;
            // 
            // colmv_tipo_movi
            // 
            this.colmv_tipo_movi.FieldName = "mv_tipo_movi";
            this.colmv_tipo_movi.Name = "colmv_tipo_movi";
            // 
            // coldm_cantidad
            // 
            this.coldm_cantidad.Caption = "Cantidad";
            this.coldm_cantidad.FieldName = "dm_cantidad";
            this.coldm_cantidad.Name = "coldm_cantidad";
            this.coldm_cantidad.Visible = true;
            this.coldm_cantidad.VisibleIndex = 3;
            this.coldm_cantidad.Width = 63;
            // 
            // coldm_observacion
            // 
            this.coldm_observacion.Caption = "Observación";
            this.coldm_observacion.FieldName = "dm_observacion";
            this.coldm_observacion.Name = "coldm_observacion";
            this.coldm_observacion.Visible = true;
            this.coldm_observacion.VisibleIndex = 4;
            this.coldm_observacion.Width = 124;
            // 
            // coldm_precio
            // 
            this.coldm_precio.FieldName = "dm_precio";
            this.coldm_precio.Name = "coldm_precio";
            // 
            // colmv_costo
            // 
            this.colmv_costo.FieldName = "mv_costo";
            this.colmv_costo.Name = "colmv_costo";
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Producto";
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 1;
            this.colProducto.Width = 212;
            // 
            // colet_IdEmpresa
            // 
            this.colet_IdEmpresa.FieldName = "et_IdEmpresa";
            this.colet_IdEmpresa.Name = "colet_IdEmpresa";
            // 
            // colet_IdProcesoProductivo
            // 
            this.colet_IdProcesoProductivo.FieldName = "et_IdProcesoProductivo";
            this.colet_IdProcesoProductivo.Name = "colet_IdProcesoProductivo";
            // 
            // colet_IdEtapa
            // 
            this.colet_IdEtapa.FieldName = "et_IdEtapa";
            this.colet_IdEtapa.Name = "colet_IdEtapa";
            // 
            // colot_IdEmpresa
            // 
            this.colot_IdEmpresa.FieldName = "ot_IdEmpresa";
            this.colot_IdEmpresa.Name = "colot_IdEmpresa";
            // 
            // colot_IdSucursal
            // 
            this.colot_IdSucursal.FieldName = "ot_IdSucursal";
            this.colot_IdSucursal.Name = "colot_IdSucursal";
            // 
            // colot_CodObra
            // 
            this.colot_CodObra.FieldName = "ot_CodObra";
            this.colot_CodObra.Name = "colot_CodObra";
            // 
            // colot_IdOrdenTaller
            // 
            this.colot_IdOrdenTaller.FieldName = "ot_IdOrdenTaller";
            this.colot_IdOrdenTaller.Name = "colot_IdOrdenTaller";
            // 
            // frmPrd_BusquedaCodigoBarraDisponible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 421);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Name = "frmPrd_BusquedaCodigoBarraDisponible";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Productos (Códigos de Barras)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrd_BusquedaCodigoBarraDisponible_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.comListadoMaterialesDetInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProductoInfoBindingSource)).EndInit();
            this.groupBoxBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlCodigoBarraDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwCodigoBarraDisp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource comListadoMaterialesDetInfoBindingSource;
        private System.Windows.Forms.BindingSource inProductoInfoBindingSource;
        public System.Windows.Forms.GroupBox groupBoxBusqueda;
        private DevExpress.XtraGrid.GridControl gridCtrlCodigoBarraDisp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVwCodigoBarraDisp;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovi_inven_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNumMovi;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_Secuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBarra;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_tipo_movi;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_precio;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colet_IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colet_IdProcesoProductivo;
        private DevExpress.XtraGrid.Columns.GridColumn colet_IdEtapa;
        private DevExpress.XtraGrid.Columns.GridColumn colot_IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colot_IdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colot_CodObra;
        private DevExpress.XtraGrid.Columns.GridColumn colot_IdOrdenTaller;
    }
}