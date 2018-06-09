namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Ingreso_varios_Cons
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
            this.ucGe_Menu_Mantenimiento_x_usuario1 = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovi_inven_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNumMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodMoviInven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovi_inven_tipo_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNumMovi_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto_sub_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_tipo_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAproba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_motivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsigno_tipo_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMotivo_oc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMotivo_Inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_EstadoAproba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesc_mov_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario1
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasSucursales = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde = new System.DateTime(2017, 1, 10, 12, 0, 6, 641);
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta = new System.DateTime(2017, 3, 10, 12, 0, 6, 641);
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario1.Name = "ucGe_Menu_Mantenimiento_x_usuario1";
            this.ucGe_Menu_Mantenimiento_x_usuario1.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Size = new System.Drawing.Size(1028, 155);
            this.ucGe_Menu_Mantenimiento_x_usuario1.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_bodega = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_sucursal = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 456);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1028, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlConsulta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 301);
            this.panel1.TabIndex = 2;
            // 
            // gridControlConsulta
            // 
            this.gridControlConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlConsulta.Location = new System.Drawing.Point(0, 0);
            this.gridControlConsulta.MainView = this.gridViewConsulta;
            this.gridControlConsulta.Name = "gridControlConsulta";
            this.gridControlConsulta.Size = new System.Drawing.Size(1028, 301);
            this.gridControlConsulta.TabIndex = 0;
            this.gridControlConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsulta});
            // 
            // gridViewConsulta
            // 
            this.gridViewConsulta.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridViewConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdBodega,
            this.colIdMovi_inven_tipo,
            this.colIdNumMovi,
            this.colCodMoviInven,
            this.colcm_observacion,
            this.colcm_fecha,
            this.colEstado,
            this.colIdEmpresa_inv,
            this.colIdSucursal_inv,
            this.colIdBodega_inv,
            this.colIdMovi_inven_tipo_inv,
            this.colIdNumMovi_inv,
            this.colIdCentroCosto,
            this.colIdCentroCosto_sub_centro_costo,
            this.colnom_sucursal,
            this.colnom_bodega,
            this.colnom_tipo_inv,
            this.colIdEstadoAproba,
            this.colnom_motivo,
            this.colsigno_tipo_inv,
            this.colIdMotivo_oc,
            this.colIdMotivo_Inv,
            this.colnom_EstadoAproba,
            this.colDesc_mov_inv,
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewConsulta.GridControl = this.gridControlConsulta;
            this.gridViewConsulta.Name = "gridViewConsulta";
            this.gridViewConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsulta.OptionsView.ShowGroupPanel = false;
            this.gridViewConsulta.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewConsulta_RowClick);
            this.gridViewConsulta.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewConsulta_RowCellStyle);
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
            this.colIdNumMovi.Caption = "# Mov. Ingreso";
            this.colIdNumMovi.FieldName = "IdNumMovi";
            this.colIdNumMovi.Name = "colIdNumMovi";
            this.colIdNumMovi.OptionsColumn.AllowEdit = false;
            this.colIdNumMovi.Visible = true;
            this.colIdNumMovi.VisibleIndex = 2;
            this.colIdNumMovi.Width = 82;
            // 
            // colCodMoviInven
            // 
            this.colCodMoviInven.FieldName = "CodMoviInven";
            this.colCodMoviInven.Name = "colCodMoviInven";
            // 
            // colcm_observacion
            // 
            this.colcm_observacion.Caption = "Observación";
            this.colcm_observacion.FieldName = "cm_observacion";
            this.colcm_observacion.Name = "colcm_observacion";
            this.colcm_observacion.OptionsColumn.AllowEdit = false;
            this.colcm_observacion.Visible = true;
            this.colcm_observacion.VisibleIndex = 3;
            this.colcm_observacion.Width = 263;
            // 
            // colcm_fecha
            // 
            this.colcm_fecha.Caption = "Fecha";
            this.colcm_fecha.FieldName = "cm_fecha";
            this.colcm_fecha.Name = "colcm_fecha";
            this.colcm_fecha.OptionsColumn.AllowEdit = false;
            this.colcm_fecha.Visible = true;
            this.colcm_fecha.VisibleIndex = 6;
            this.colcm_fecha.Width = 96;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Width = 82;
            // 
            // colIdEmpresa_inv
            // 
            this.colIdEmpresa_inv.FieldName = "IdEmpresa_inv";
            this.colIdEmpresa_inv.Name = "colIdEmpresa_inv";
            // 
            // colIdSucursal_inv
            // 
            this.colIdSucursal_inv.FieldName = "IdSucursal_inv";
            this.colIdSucursal_inv.Name = "colIdSucursal_inv";
            // 
            // colIdBodega_inv
            // 
            this.colIdBodega_inv.FieldName = "IdBodega_inv";
            this.colIdBodega_inv.Name = "colIdBodega_inv";
            // 
            // colIdMovi_inven_tipo_inv
            // 
            this.colIdMovi_inven_tipo_inv.FieldName = "IdMovi_inven_tipo_inv";
            this.colIdMovi_inven_tipo_inv.Name = "colIdMovi_inven_tipo_inv";
            // 
            // colIdNumMovi_inv
            // 
            this.colIdNumMovi_inv.FieldName = "IdNumMovi_inv";
            this.colIdNumMovi_inv.Name = "colIdNumMovi_inv";
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            // 
            // colIdCentroCosto_sub_centro_costo
            // 
            this.colIdCentroCosto_sub_centro_costo.FieldName = "IdCentroCosto_sub_centro_costo";
            this.colIdCentroCosto_sub_centro_costo.Name = "colIdCentroCosto_sub_centro_costo";
            // 
            // colnom_sucursal
            // 
            this.colnom_sucursal.Caption = "Sucursal";
            this.colnom_sucursal.FieldName = "nom_sucursal";
            this.colnom_sucursal.Name = "colnom_sucursal";
            this.colnom_sucursal.OptionsColumn.AllowEdit = false;
            this.colnom_sucursal.Visible = true;
            this.colnom_sucursal.VisibleIndex = 0;
            this.colnom_sucursal.Width = 139;
            // 
            // colnom_bodega
            // 
            this.colnom_bodega.Caption = "Bodega";
            this.colnom_bodega.FieldName = "nom_bodega";
            this.colnom_bodega.Name = "colnom_bodega";
            this.colnom_bodega.OptionsColumn.AllowEdit = false;
            this.colnom_bodega.Visible = true;
            this.colnom_bodega.VisibleIndex = 1;
            this.colnom_bodega.Width = 139;
            // 
            // colnom_tipo_inv
            // 
            this.colnom_tipo_inv.Caption = "Tipo Movimiento";
            this.colnom_tipo_inv.FieldName = "nom_tipo_inv";
            this.colnom_tipo_inv.Name = "colnom_tipo_inv";
            this.colnom_tipo_inv.OptionsColumn.AllowEdit = false;
            this.colnom_tipo_inv.Visible = true;
            this.colnom_tipo_inv.VisibleIndex = 4;
            this.colnom_tipo_inv.Width = 151;
            // 
            // colIdEstadoAproba
            // 
            this.colIdEstadoAproba.FieldName = "IdEstadoAproba";
            this.colIdEstadoAproba.Name = "colIdEstadoAproba";
            // 
            // colnom_motivo
            // 
            this.colnom_motivo.Caption = "Motivo";
            this.colnom_motivo.FieldName = "nom_motivo";
            this.colnom_motivo.Name = "colnom_motivo";
            this.colnom_motivo.OptionsColumn.AllowEdit = false;
            this.colnom_motivo.Width = 91;
            // 
            // colsigno_tipo_inv
            // 
            this.colsigno_tipo_inv.Caption = "Ing/Egr";
            this.colsigno_tipo_inv.FieldName = "signo_tipo_inv";
            this.colsigno_tipo_inv.Name = "colsigno_tipo_inv";
            this.colsigno_tipo_inv.OptionsColumn.AllowEdit = false;
            this.colsigno_tipo_inv.Visible = true;
            this.colsigno_tipo_inv.VisibleIndex = 5;
            this.colsigno_tipo_inv.Width = 48;
            // 
            // colIdMotivo_oc
            // 
            this.colIdMotivo_oc.FieldName = "IdMotivo_oc";
            this.colIdMotivo_oc.Name = "colIdMotivo_oc";
            // 
            // colIdMotivo_Inv
            // 
            this.colIdMotivo_Inv.FieldName = "IdMotivo_Inv";
            this.colIdMotivo_Inv.Name = "colIdMotivo_Inv";
            // 
            // colnom_EstadoAproba
            // 
            this.colnom_EstadoAproba.Caption = "Estado aprobación";
            this.colnom_EstadoAproba.FieldName = "nom_EstadoAproba";
            this.colnom_EstadoAproba.Name = "colnom_EstadoAproba";
            this.colnom_EstadoAproba.Visible = true;
            this.colnom_EstadoAproba.VisibleIndex = 8;
            this.colnom_EstadoAproba.Width = 89;
            // 
            // colDesc_mov_inv
            // 
            this.colDesc_mov_inv.Caption = "Motivo";
            this.colDesc_mov_inv.FieldName = "Desc_mov_inv";
            this.colDesc_mov_inv.Name = "colDesc_mov_inv";
            this.colDesc_mov_inv.Visible = true;
            this.colDesc_mov_inv.VisibleIndex = 7;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "OC";
            this.gridColumn1.FieldName = "IdOrdenCompra";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Factura";
            this.gridColumn2.FieldName = "co_factura";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 10;
            // 
            // FrmIn_Ingreso_varios_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario1);
            this.Name = "FrmIn_Ingreso_varios_Cons";
            this.Text = "Consulta Ingresos Varios";
            this.Load += new System.EventHandler(this.FrmIn_Ingreso_varios_Cons_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovi_inven_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNumMovi;
        private DevExpress.XtraGrid.Columns.GridColumn colCodMoviInven;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovi_inven_tipo_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNumMovi_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_sub_centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_tipo_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAproba;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_motivo;
        private DevExpress.XtraGrid.Columns.GridColumn colsigno_tipo_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotivo_oc;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotivo_Inv;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_EstadoAproba;
        private DevExpress.XtraGrid.Columns.GridColumn colDesc_mov_inv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}