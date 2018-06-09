namespace Core.Erp.Winform.Importacion
{
    partial class frmImp_GastosImportacion_Consulta
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
            this.gridControlOrdeGastos = new DevExpress.XtraGrid.GridControl();
            this.impordencompraextximpgastosxImportInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewGastos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRegistroGasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucusal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenCompraExt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodDocu_Pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGastoImp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodOrdenCompraExt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo_Importacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdeGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impordencompraextximpgastosxImportInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGastos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlOrdeGastos
            // 
            this.gridControlOrdeGastos.DataSource = this.impordencompraextximpgastosxImportInfoBindingSource;
            this.gridControlOrdeGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrdeGastos.Location = new System.Drawing.Point(0, 0);
            this.gridControlOrdeGastos.MainView = this.gridViewGastos;
            this.gridControlOrdeGastos.Name = "gridControlOrdeGastos";
            this.gridControlOrdeGastos.Size = new System.Drawing.Size(1131, 298);
            this.gridControlOrdeGastos.TabIndex = 8;
            this.gridControlOrdeGastos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGastos});
            // 
            // impordencompraextximpgastosxImportInfoBindingSource
            // 
            this.impordencompraextximpgastosxImportInfoBindingSource.DataSource = typeof(Core.Erp.Info.Importacion.imp_ordencompra_ext_x_imp_gastosxImport_Info);
            // 
            // gridViewGastos
            // 
            this.gridViewGastos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdRegistroGasto,
            this.colIdSucusal,
            this.colIdOrdenCompraExt,
            this.colFecha,
            this.colObservacion,
            this.colIdProveedor,
            this.colIdBanco,
            this.colCodDocu_Pago,
            this.colSucursal,
            this.colEstado,
            this.colIdCtaCble,
            this.colIdCtaCble_Banco,
            this.colIdGastoImp,
            this.colIdTipoCbte,
            this.colSecuencia,
            this.colCodOrdenCompraExt,
            this.colTipo_Importacion});
            this.gridViewGastos.GridControl = this.gridControlOrdeGastos;
            this.gridViewGastos.Name = "gridViewGastos";
            this.gridViewGastos.OptionsBehavior.Editable = false;
            this.gridViewGastos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewGastos.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdRegistroGasto, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewGastos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewPedidos_RowClick);
            this.gridViewGastos.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewGastos_RowStyle);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdRegistroGasto
            // 
            this.colIdRegistroGasto.Caption = "# Registro Gasto";
            this.colIdRegistroGasto.FieldName = "IdRegistroGasto";
            this.colIdRegistroGasto.Name = "colIdRegistroGasto";
            this.colIdRegistroGasto.Visible = true;
            this.colIdRegistroGasto.VisibleIndex = 0;
            // 
            // colIdSucusal
            // 
            this.colIdSucusal.FieldName = "IdSucusal";
            this.colIdSucusal.Name = "colIdSucusal";
            // 
            // colIdOrdenCompraExt
            // 
            this.colIdOrdenCompraExt.Caption = "# Importacion";
            this.colIdOrdenCompraExt.FieldName = "IdOrdenCompraExt";
            this.colIdOrdenCompraExt.Name = "colIdOrdenCompraExt";
            this.colIdOrdenCompraExt.Visible = true;
            this.colIdOrdenCompraExt.VisibleIndex = 3;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 4;
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observacion";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 5;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            // 
            // colIdBanco
            // 
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            // 
            // colCodDocu_Pago
            // 
            this.colCodDocu_Pago.Caption = "Codigo Documento Pago";
            this.colCodDocu_Pago.FieldName = "CodDocu_Pago";
            this.colCodDocu_Pago.Name = "colCodDocu_Pago";
            this.colCodDocu_Pago.Visible = true;
            this.colCodDocu_Pago.VisibleIndex = 6;
            // 
            // colSucursal
            // 
            this.colSucursal.Caption = "Sucursal";
            this.colSucursal.FieldName = "Sucursal";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.Visible = true;
            this.colSucursal.VisibleIndex = 1;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 7;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            // 
            // colIdCtaCble_Banco
            // 
            this.colIdCtaCble_Banco.FieldName = "IdCtaCble_Banco";
            this.colIdCtaCble_Banco.Name = "colIdCtaCble_Banco";
            // 
            // colIdGastoImp
            // 
            this.colIdGastoImp.FieldName = "IdGastoImp";
            this.colIdGastoImp.Name = "colIdGastoImp";
            // 
            // colIdTipoCbte
            // 
            this.colIdTipoCbte.FieldName = "IdTipoCbte";
            this.colIdTipoCbte.Name = "colIdTipoCbte";
            // 
            // colSecuencia
            // 
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            // 
            // colCodOrdenCompraExt
            // 
            this.colCodOrdenCompraExt.Caption = "Codigo Importacion";
            this.colCodOrdenCompraExt.FieldName = "CodOrdenCompraExt";
            this.colCodOrdenCompraExt.Name = "colCodOrdenCompraExt";
            this.colCodOrdenCompraExt.Visible = true;
            this.colCodOrdenCompraExt.VisibleIndex = 2;
            // 
            // colTipo_Importacion
            // 
            this.colTipo_Importacion.Caption = "Tipo Importacion";
            this.colTipo_Importacion.FieldName = "Tipo_Importacion";
            this.colTipo_Importacion.Name = "colTipo_Importacion";
            this.colTipo_Importacion.Visible = true;
            this.colTipo_Importacion.VisibleIndex = 8;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 5, 15, 25, 14, 111);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 5, 15, 25, 14, 111);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1131, 155);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1131, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 154);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlOrdeGastos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1131, 298);
            this.panel2.TabIndex = 17;
            // 
            // frmImp_GastosImportacion_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmImp_GastosImportacion_Consulta";
            this.Text = "Registro Gasto De Importacion Consulta";
            this.Load += new System.EventHandler(this.frmImp_GastosImportacion_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdeGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impordencompraextximpgastosxImportInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGastos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlOrdeGastos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGastos;
        private System.Windows.Forms.BindingSource impordencompraextximpgastosxImportInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRegistroGasto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucusal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenCompraExt;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colCodDocu_Pago;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Banco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGastoImp;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colCodOrdenCompraExt;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo_Importacion;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}