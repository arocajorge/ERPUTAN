namespace Core.Erp.Winform.Facturacion_Grafinpren
{
    partial class frmFa_Factura_Consulta
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
            this.gridConsultaCot = new DevExpress.XtraGrid.GridControl();
            this.gridView_factruras = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_tipoDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCbteVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_plazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodCbteVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_serie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_serie2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_NumFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_fech_venc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_tipo_venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_anio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_seguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_flete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_interes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_OtroValor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_OtroValor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_Transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_autorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_num_op = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_fecha_op = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_num_cotizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_fecha_cotizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_equipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_porc_comision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaCot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_factruras)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridConsultaCot
            // 
            this.gridConsultaCot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsultaCot.Location = new System.Drawing.Point(0, 161);
            this.gridConsultaCot.MainView = this.gridView_factruras;
            this.gridConsultaCot.Name = "gridConsultaCot";
            this.gridConsultaCot.Size = new System.Drawing.Size(1119, 202);
            this.gridConsultaCot.TabIndex = 19;
            this.gridConsultaCot.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_factruras});
            // 
            // gridView_factruras
            // 
            this.gridView_factruras.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sucursal,
            this.Bodega,
            this.Cliente,
            this.Vendedor,
            this.vt_tipoDoc,
            this.IVA,
            this.Subtotal,
            this.Total,
            this.Estado,
            this.IdCbteVta,
            this.vt_fecha,
            this.vt_plazo,
            this.IdEmpresa,
            this.IdSucursal,
            this.IdBodega,
            this.CodCbteVta,
            this.vt_serie1,
            this.vt_serie2,
            this.vt_NumFactura,
            this.IdCliente,
            this.IdVendedor,
            this.vt_fech_venc,
            this.vt_tipo_venta,
            this.vt_Observacion,
            this.IdPeriodo,
            this.vt_anio,
            this.vt_mes,
            this.vt_seguro,
            this.vt_flete,
            this.vt_interes,
            this.vt_OtroValor1,
            this.vt_OtroValor2,
            this.IdUsuario,
            this.Fecha_Transaccion,
            this.vt_autorizacion,
            this.col_num_op,
            this.col_fecha_op,
            this.col_num_cotizacion,
            this.col_fecha_cotizacion,
            this.col_nom_equipo,
            this.col_porc_comision});
            this.gridView_factruras.GridControl = this.gridConsultaCot;
            this.gridView_factruras.Name = "gridView_factruras";
            this.gridView_factruras.OptionsBehavior.Editable = false;
            this.gridView_factruras.OptionsView.ShowAutoFilterRow = true;
            this.gridView_factruras.OptionsView.ShowGroupPanel = false;
            this.gridView_factruras.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Sucursal, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Bodega, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.vt_NumFactura, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView_factruras.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_factruras_RowCellStyle);
            this.gridView_factruras.DoubleClick += new System.EventHandler(this.gridView_factruras_DoubleClick);
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 0;
            this.Sucursal.Width = 61;
            // 
            // Bodega
            // 
            this.Bodega.Caption = "Bodega";
            this.Bodega.FieldName = "Bodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.Visible = true;
            this.Bodega.VisibleIndex = 1;
            this.Bodega.Width = 58;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 3;
            this.Cliente.Width = 91;
            // 
            // Vendedor
            // 
            this.Vendedor.Caption = "Vendedor";
            this.Vendedor.FieldName = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Visible = true;
            this.Vendedor.VisibleIndex = 4;
            this.Vendedor.Width = 81;
            // 
            // vt_tipoDoc
            // 
            this.vt_tipoDoc.Caption = "Tipo Doc";
            this.vt_tipoDoc.FieldName = "vt_tipoDoc";
            this.vt_tipoDoc.Name = "vt_tipoDoc";
            this.vt_tipoDoc.Visible = true;
            this.vt_tipoDoc.VisibleIndex = 5;
            this.vt_tipoDoc.Width = 49;
            // 
            // IVA
            // 
            this.IVA.Caption = "IVA";
            this.IVA.FieldName = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.Visible = true;
            this.IVA.VisibleIndex = 10;
            this.IVA.Width = 28;
            // 
            // Subtotal
            // 
            this.Subtotal.Caption = "Subtotal";
            this.Subtotal.FieldName = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Visible = true;
            this.Subtotal.VisibleIndex = 11;
            this.Subtotal.Width = 47;
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 12;
            this.Total.Width = 31;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 18;
            this.Estado.Width = 43;
            // 
            // IdCbteVta
            // 
            this.IdCbteVta.Caption = "Id Cbte Vta";
            this.IdCbteVta.FieldName = "IdCbteVta";
            this.IdCbteVta.Name = "IdCbteVta";
            this.IdCbteVta.Visible = true;
            this.IdCbteVta.VisibleIndex = 6;
            this.IdCbteVta.Width = 62;
            // 
            // vt_fecha
            // 
            this.vt_fecha.Caption = "Fecha";
            this.vt_fecha.FieldName = "vt_fecha";
            this.vt_fecha.Name = "vt_fecha";
            this.vt_fecha.Visible = true;
            this.vt_fecha.VisibleIndex = 8;
            this.vt_fecha.Width = 42;
            // 
            // vt_plazo
            // 
            this.vt_plazo.Caption = "vt_plazo";
            this.vt_plazo.FieldName = "vt_plazo";
            this.vt_plazo.Name = "vt_plazo";
            this.vt_plazo.Width = 137;
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.Caption = "IdEmpresa";
            this.IdEmpresa.FieldName = "IdEmpresa";
            this.IdEmpresa.Name = "IdEmpresa";
            this.IdEmpresa.Width = 230;
            // 
            // IdSucursal
            // 
            this.IdSucursal.Caption = "IdSucursal";
            this.IdSucursal.FieldName = "IdSucursal";
            this.IdSucursal.Name = "IdSucursal";
            this.IdSucursal.Width = 208;
            // 
            // IdBodega
            // 
            this.IdBodega.Caption = "IdBodega";
            this.IdBodega.FieldName = "IdBodega";
            this.IdBodega.Name = "IdBodega";
            this.IdBodega.Width = 117;
            // 
            // CodCbteVta
            // 
            this.CodCbteVta.Caption = "CodCbteVta";
            this.CodCbteVta.FieldName = "CodCbteVta";
            this.CodCbteVta.Name = "CodCbteVta";
            this.CodCbteVta.Width = 175;
            // 
            // vt_serie1
            // 
            this.vt_serie1.Caption = "Serie1";
            this.vt_serie1.FieldName = "vt_serie1";
            this.vt_serie1.Name = "vt_serie1";
            this.vt_serie1.Width = 57;
            // 
            // vt_serie2
            // 
            this.vt_serie2.Caption = "Serie2";
            this.vt_serie2.FieldName = "vt_serie2";
            this.vt_serie2.Name = "vt_serie2";
            this.vt_serie2.Width = 55;
            // 
            // vt_NumFactura
            // 
            this.vt_NumFactura.Caption = "# Factura";
            this.vt_NumFactura.FieldName = "vt_NumFactura";
            this.vt_NumFactura.Name = "vt_NumFactura";
            this.vt_NumFactura.Visible = true;
            this.vt_NumFactura.VisibleIndex = 2;
            this.vt_NumFactura.Width = 66;
            // 
            // IdCliente
            // 
            this.IdCliente.Caption = "IdCliente";
            this.IdCliente.FieldName = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Width = 164;
            // 
            // IdVendedor
            // 
            this.IdVendedor.Caption = "IdVendedor";
            this.IdVendedor.FieldName = "IdVendedor";
            this.IdVendedor.Name = "IdVendedor";
            this.IdVendedor.Width = 136;
            // 
            // vt_fech_venc
            // 
            this.vt_fech_venc.Caption = "Fecha Venc.";
            this.vt_fech_venc.FieldName = "vt_fech_venc";
            this.vt_fech_venc.Name = "vt_fech_venc";
            this.vt_fech_venc.Visible = true;
            this.vt_fech_venc.VisibleIndex = 9;
            this.vt_fech_venc.Width = 65;
            // 
            // vt_tipo_venta
            // 
            this.vt_tipo_venta.Caption = "vt_tipo_venta";
            this.vt_tipo_venta.FieldName = "vt_tipo_venta";
            this.vt_tipo_venta.Name = "vt_tipo_venta";
            this.vt_tipo_venta.Width = 157;
            // 
            // vt_Observacion
            // 
            this.vt_Observacion.Caption = "Observación";
            this.vt_Observacion.FieldName = "vt_Observacion";
            this.vt_Observacion.Name = "vt_Observacion";
            this.vt_Observacion.Visible = true;
            this.vt_Observacion.VisibleIndex = 7;
            this.vt_Observacion.Width = 67;
            // 
            // IdPeriodo
            // 
            this.IdPeriodo.Caption = "IdPeriodo";
            this.IdPeriodo.FieldName = "IdPeriodo";
            this.IdPeriodo.Name = "IdPeriodo";
            this.IdPeriodo.Width = 118;
            // 
            // vt_anio
            // 
            this.vt_anio.Caption = "vt_anio";
            this.vt_anio.FieldName = "vt_anio";
            this.vt_anio.Name = "vt_anio";
            this.vt_anio.Width = 153;
            // 
            // vt_mes
            // 
            this.vt_mes.Caption = "vt_mes";
            this.vt_mes.FieldName = "vt_mes";
            this.vt_mes.Name = "vt_mes";
            this.vt_mes.Width = 127;
            // 
            // vt_seguro
            // 
            this.vt_seguro.Caption = "vt_seguro";
            this.vt_seguro.FieldName = "vt_seguro";
            this.vt_seguro.Name = "vt_seguro";
            this.vt_seguro.Width = 81;
            // 
            // vt_flete
            // 
            this.vt_flete.Caption = "vt_flete";
            this.vt_flete.FieldName = "vt_flete";
            this.vt_flete.Name = "vt_flete";
            this.vt_flete.Width = 99;
            // 
            // vt_interes
            // 
            this.vt_interes.Caption = "vt_interes";
            this.vt_interes.FieldName = "vt_interes";
            this.vt_interes.Name = "vt_interes";
            this.vt_interes.Width = 62;
            // 
            // vt_OtroValor1
            // 
            this.vt_OtroValor1.Caption = "vt_OtroValor1";
            this.vt_OtroValor1.FieldName = "vt_OtroValor1";
            this.vt_OtroValor1.Name = "vt_OtroValor1";
            this.vt_OtroValor1.Width = 84;
            // 
            // vt_OtroValor2
            // 
            this.vt_OtroValor2.Caption = "vt_OtroValor2";
            this.vt_OtroValor2.FieldName = "vt_OtroValor2";
            this.vt_OtroValor2.Name = "vt_OtroValor2";
            this.vt_OtroValor2.Width = 60;
            // 
            // IdUsuario
            // 
            this.IdUsuario.Caption = "Usuario";
            this.IdUsuario.FieldName = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Width = 54;
            // 
            // Fecha_Transaccion
            // 
            this.Fecha_Transaccion.Caption = "Fecha_Transaccion";
            this.Fecha_Transaccion.FieldName = "Fecha_Transaccion";
            this.Fecha_Transaccion.Name = "Fecha_Transaccion";
            this.Fecha_Transaccion.Width = 76;
            // 
            // vt_autorizacion
            // 
            this.vt_autorizacion.Caption = "Autorizacion";
            this.vt_autorizacion.FieldName = "vt_autorizacion";
            this.vt_autorizacion.Name = "vt_autorizacion";
            this.vt_autorizacion.Width = 70;
            // 
            // col_num_op
            // 
            this.col_num_op.Caption = "# OP";
            this.col_num_op.FieldName = "Factura_Graf.num_op";
            this.col_num_op.Name = "col_num_op";
            this.col_num_op.Visible = true;
            this.col_num_op.VisibleIndex = 13;
            this.col_num_op.Width = 36;
            // 
            // col_fecha_op
            // 
            this.col_fecha_op.Caption = "Fecha de OP";
            this.col_fecha_op.FieldName = "Factura_Graf.fecha_op";
            this.col_fecha_op.Name = "col_fecha_op";
            this.col_fecha_op.Visible = true;
            this.col_fecha_op.VisibleIndex = 17;
            this.col_fecha_op.Width = 64;
            // 
            // col_num_cotizacion
            // 
            this.col_num_cotizacion.Caption = "# de Cotización";
            this.col_num_cotizacion.FieldName = "Factura_Graf.num_cotizacion";
            this.col_num_cotizacion.Name = "col_num_cotizacion";
            this.col_num_cotizacion.Visible = true;
            this.col_num_cotizacion.VisibleIndex = 14;
            this.col_num_cotizacion.Width = 81;
            // 
            // col_fecha_cotizacion
            // 
            this.col_fecha_cotizacion.Caption = "Fecha de cotización";
            this.col_fecha_cotizacion.FieldName = "Factura_Graf.fecha_cotizacion";
            this.col_fecha_cotizacion.Name = "col_fecha_cotizacion";
            // 
            // col_nom_equipo
            // 
            this.col_nom_equipo.Caption = "Maquina";
            this.col_nom_equipo.FieldName = "Factura_Graf.nom_equipo";
            this.col_nom_equipo.Name = "col_nom_equipo";
            this.col_nom_equipo.Visible = true;
            this.col_nom_equipo.VisibleIndex = 15;
            this.col_nom_equipo.Width = 51;
            // 
            // col_porc_comision
            // 
            this.col_porc_comision.Caption = "% de Comisión";
            this.col_porc_comision.FieldName = "Factura_Graf.porc_comision";
            this.col_porc_comision.Name = "col_porc_comision";
            this.col_porc_comision.Visible = true;
            this.col_porc_comision.VisibleIndex = 16;
            this.col_porc_comision.Width = 78;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 5, 2, 12, 5, 4, 829);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 7, 2, 12, 5, 4, 830);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1119, 161);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 21;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 363);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1119, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 161);
            this.panel2.TabIndex = 23;
            // 
            // frmFa_Factura_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 385);
            this.Controls.Add(this.gridConsultaCot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmFa_Factura_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas - Consulta";
            this.Load += new System.EventHandler(this.frmFA_Factura_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaCot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_factruras)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridConsultaCot;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_factruras;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraGrid.Columns.GridColumn vt_tipoDoc;
        private DevExpress.XtraGrid.Columns.GridColumn IVA;
        private DevExpress.XtraGrid.Columns.GridColumn Subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn IdCbteVta;
        private DevExpress.XtraGrid.Columns.GridColumn vt_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn vt_plazo;
        private DevExpress.XtraGrid.Columns.GridColumn IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn IdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn IdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn CodCbteVta;
        private DevExpress.XtraGrid.Columns.GridColumn vt_serie1;
        private DevExpress.XtraGrid.Columns.GridColumn vt_serie2;
        private DevExpress.XtraGrid.Columns.GridColumn vt_NumFactura;
        private DevExpress.XtraGrid.Columns.GridColumn IdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn IdVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn vt_fech_venc;
        private DevExpress.XtraGrid.Columns.GridColumn vt_tipo_venta;
        private DevExpress.XtraGrid.Columns.GridColumn vt_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn IdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn vt_anio;
        private DevExpress.XtraGrid.Columns.GridColumn vt_mes;
        private DevExpress.XtraGrid.Columns.GridColumn vt_seguro;
        private DevExpress.XtraGrid.Columns.GridColumn vt_flete;
        private DevExpress.XtraGrid.Columns.GridColumn vt_interes;
        private DevExpress.XtraGrid.Columns.GridColumn vt_OtroValor1;
        private DevExpress.XtraGrid.Columns.GridColumn vt_OtroValor2;
        private DevExpress.XtraGrid.Columns.GridColumn IdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_Transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn vt_autorizacion;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn col_num_op;
        private DevExpress.XtraGrid.Columns.GridColumn col_fecha_op;
        private DevExpress.XtraGrid.Columns.GridColumn col_num_cotizacion;
        private DevExpress.XtraGrid.Columns.GridColumn col_fecha_cotizacion;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_equipo;
        private DevExpress.XtraGrid.Columns.GridColumn col_porc_comision;

    }
}