namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_NotaCredito_Cons
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControlCredito = new DevExpress.XtraGrid.GridControl();
            this.gridViewCredito = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbteCble_Nota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebCre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_FechaNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_Autorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_serie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_serie2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_Nota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte_Nota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_subtotal_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_subtotal_siniva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_baseImponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_Por_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_valoriva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCod_ICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_Ice_base = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_Ice_por = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_Ice_valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_Serv_por = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_Serv_valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_BaseSeguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_vaCoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Acre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_IVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbteCble_Anulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte_Anulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_tipoLocacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoFlujo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdIden_credito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPagoLocExt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaisPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConvenioTributacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPagoSujetoRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_num_doc_modificado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_Autorizacion_Imprenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_Nota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCredito)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.CargarTodasBodegas = false;
            this.ucGe_Menu.CargarTodasSucursales = true;
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_anular = true;
            this.ucGe_Menu.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu.Enable_boton_consultar = true;
            this.ucGe_Menu.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu.Enable_boton_Duplicar = true;
            this.ucGe_Menu.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu.Enable_boton_GenerarXml = true;
            this.ucGe_Menu.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu.Enable_boton_Importar_XML = true;
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2016, 12, 10, 12, 10, 11, 846);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 2, 10, 12, 10, 11, 846);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(1094, 155);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = true;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = true;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 409);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1094, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // gridControlCredito
            // 
            this.gridControlCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCredito.Location = new System.Drawing.Point(0, 0);
            this.gridControlCredito.MainView = this.gridViewCredito;
            this.gridControlCredito.Name = "gridControlCredito";
            this.gridControlCredito.Size = new System.Drawing.Size(1094, 254);
            this.gridControlCredito.TabIndex = 2;
            this.gridControlCredito.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCredito});
            // 
            // gridViewCredito
            // 
            this.gridViewCredito.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdCbteCble_Nota,
            this.colDebCre,
            this.colnomProveedor,
            this.colcn_FechaNota,
            this.colcn_fecha,
            this.colcn_Autorizacion,
            this.colcn_serie1,
            this.colcn_serie2,
            this.colcn_Nota,
            this.colcn_observacion,
            this.colcn_total,
            this.colSaldo,
            this.colIdTipoCbte_Nota,
            this.colIdProveedor,
            this.colcn_subtotal_iva,
            this.colcn_subtotal_siniva,
            this.colcn_baseImponible,
            this.colcn_Por_iva,
            this.colcn_valoriva,
            this.colIdCod_ICE,
            this.colcn_Ice_base,
            this.colcn_Ice_por,
            this.colcn_Ice_valor,
            this.colcn_Serv_por,
            this.colcn_Serv_valor,
            this.colcn_BaseSeguro,
            this.colcn_vaCoa,
            this.colIdTipoServicio,
            this.colIdCtaCble_Acre,
            this.colIdCtaCble_IVA,
            this.colIdUsuario,
            this.colEstado,
            this.colMotivoAnu,
            this.colIdCbteCble_Anulacion,
            this.colIdTipoCbte_Anulacion,
            this.colcn_tipoLocacion,
            this.colIdCentroCosto,
            this.colIdSucursal,
            this.colIdTipoFlujo,
            this.colIdIden_credito,
            this.colPagoLocExt,
            this.colPaisPago,
            this.colConvenioTributacion,
            this.colPagoSujetoRetencion,
            this.colIdTipoNota,
            this.colcn_num_doc_modificado,
            this.colcn_Autorizacion_Imprenta,
            this.colNum_Nota});
            this.gridViewCredito.GridControl = this.gridControlCredito;
            this.gridViewCredito.Name = "gridViewCredito";
            this.gridViewCredito.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCredito.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewCredito_RowCellStyle);
            this.gridViewCredito.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCredito_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.ReadOnly = true;
            // 
            // colIdCbteCble_Nota
            // 
            this.colIdCbteCble_Nota.Caption = "#Cbte";
            this.colIdCbteCble_Nota.FieldName = "IdCbteCble_Nota";
            this.colIdCbteCble_Nota.Name = "colIdCbteCble_Nota";
            this.colIdCbteCble_Nota.OptionsColumn.AllowEdit = false;
            this.colIdCbteCble_Nota.OptionsColumn.ReadOnly = true;
            this.colIdCbteCble_Nota.Visible = true;
            this.colIdCbteCble_Nota.VisibleIndex = 0;
            this.colIdCbteCble_Nota.Width = 81;
            // 
            // colDebCre
            // 
            this.colDebCre.Caption = "Deb/Cre";
            this.colDebCre.FieldName = "DebCre";
            this.colDebCre.Name = "colDebCre";
            this.colDebCre.OptionsColumn.AllowEdit = false;
            this.colDebCre.OptionsColumn.ReadOnly = true;
            // 
            // colnomProveedor
            // 
            this.colnomProveedor.Caption = "Proveedor";
            this.colnomProveedor.FieldName = "InfoProveedor.pr_nombre";
            this.colnomProveedor.Name = "colnomProveedor";
            this.colnomProveedor.OptionsColumn.AllowEdit = false;
            this.colnomProveedor.OptionsColumn.ReadOnly = true;
            this.colnomProveedor.Visible = true;
            this.colnomProveedor.VisibleIndex = 3;
            this.colnomProveedor.Width = 185;
            // 
            // colcn_FechaNota
            // 
            this.colcn_FechaNota.Caption = "Fecha Nota";
            this.colcn_FechaNota.FieldName = "cn_FechaNota";
            this.colcn_FechaNota.Name = "colcn_FechaNota";
            this.colcn_FechaNota.OptionsColumn.AllowEdit = false;
            this.colcn_FechaNota.OptionsColumn.ReadOnly = true;
            this.colcn_FechaNota.Width = 68;
            // 
            // colcn_fecha
            // 
            this.colcn_fecha.Caption = "Fecha";
            this.colcn_fecha.FieldName = "cn_fecha";
            this.colcn_fecha.Name = "colcn_fecha";
            this.colcn_fecha.OptionsColumn.AllowEdit = false;
            this.colcn_fecha.OptionsColumn.ReadOnly = true;
            this.colcn_fecha.Visible = true;
            this.colcn_fecha.VisibleIndex = 2;
            this.colcn_fecha.Width = 103;
            // 
            // colcn_Autorizacion
            // 
            this.colcn_Autorizacion.Caption = "Autorización";
            this.colcn_Autorizacion.FieldName = "cn_Autorizacion";
            this.colcn_Autorizacion.Name = "colcn_Autorizacion";
            this.colcn_Autorizacion.OptionsColumn.AllowEdit = false;
            this.colcn_Autorizacion.OptionsColumn.ReadOnly = true;
            this.colcn_Autorizacion.Visible = true;
            this.colcn_Autorizacion.VisibleIndex = 7;
            this.colcn_Autorizacion.Width = 137;
            // 
            // colcn_serie1
            // 
            this.colcn_serie1.Caption = "Serie 1";
            this.colcn_serie1.FieldName = "cn_serie1";
            this.colcn_serie1.Name = "colcn_serie1";
            this.colcn_serie1.OptionsColumn.AllowEdit = false;
            this.colcn_serie1.OptionsColumn.ReadOnly = true;
            this.colcn_serie1.Width = 64;
            // 
            // colcn_serie2
            // 
            this.colcn_serie2.Caption = "Serie 2";
            this.colcn_serie2.FieldName = "cn_serie2";
            this.colcn_serie2.Name = "colcn_serie2";
            this.colcn_serie2.OptionsColumn.AllowEdit = false;
            this.colcn_serie2.OptionsColumn.ReadOnly = true;
            this.colcn_serie2.Width = 64;
            // 
            // colcn_Nota
            // 
            this.colcn_Nota.Caption = "Nota";
            this.colcn_Nota.FieldName = "cn_Nota";
            this.colcn_Nota.Name = "colcn_Nota";
            this.colcn_Nota.OptionsColumn.AllowEdit = false;
            this.colcn_Nota.OptionsColumn.ReadOnly = true;
            this.colcn_Nota.Width = 64;
            // 
            // colcn_observacion
            // 
            this.colcn_observacion.Caption = "Observación";
            this.colcn_observacion.FieldName = "cn_observacion";
            this.colcn_observacion.Name = "colcn_observacion";
            this.colcn_observacion.OptionsColumn.AllowEdit = false;
            this.colcn_observacion.OptionsColumn.ReadOnly = true;
            this.colcn_observacion.Visible = true;
            this.colcn_observacion.VisibleIndex = 4;
            this.colcn_observacion.Width = 235;
            // 
            // colcn_total
            // 
            this.colcn_total.Caption = "Total";
            this.colcn_total.DisplayFormat.FormatString = "$ #,#######0.00;$ #,#######0.00";
            this.colcn_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcn_total.FieldName = "cn_total";
            this.colcn_total.Name = "colcn_total";
            this.colcn_total.OptionsColumn.AllowEdit = false;
            this.colcn_total.OptionsColumn.ReadOnly = true;
            this.colcn_total.Visible = true;
            this.colcn_total.VisibleIndex = 5;
            this.colcn_total.Width = 64;
            // 
            // colSaldo
            // 
            this.colSaldo.Caption = "Saldo";
            this.colSaldo.DisplayFormat.FormatString = "$ #,#######0.00;$ #,#######0.00";
            this.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.OptionsColumn.AllowEdit = false;
            this.colSaldo.OptionsColumn.ReadOnly = true;
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 6;
            this.colSaldo.Width = 138;
            // 
            // colIdTipoCbte_Nota
            // 
            this.colIdTipoCbte_Nota.FieldName = "IdTipoCbte_Nota";
            this.colIdTipoCbte_Nota.Name = "colIdTipoCbte_Nota";
            this.colIdTipoCbte_Nota.OptionsColumn.ReadOnly = true;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.OptionsColumn.ReadOnly = true;
            // 
            // colcn_subtotal_iva
            // 
            this.colcn_subtotal_iva.FieldName = "cn_subtotal_iva";
            this.colcn_subtotal_iva.Name = "colcn_subtotal_iva";
            this.colcn_subtotal_iva.OptionsColumn.ReadOnly = true;
            // 
            // colcn_subtotal_siniva
            // 
            this.colcn_subtotal_siniva.FieldName = "cn_subtotal_siniva";
            this.colcn_subtotal_siniva.Name = "colcn_subtotal_siniva";
            this.colcn_subtotal_siniva.OptionsColumn.ReadOnly = true;
            // 
            // colcn_baseImponible
            // 
            this.colcn_baseImponible.FieldName = "cn_baseImponible";
            this.colcn_baseImponible.Name = "colcn_baseImponible";
            this.colcn_baseImponible.OptionsColumn.ReadOnly = true;
            // 
            // colcn_Por_iva
            // 
            this.colcn_Por_iva.FieldName = "cn_Por_iva";
            this.colcn_Por_iva.Name = "colcn_Por_iva";
            this.colcn_Por_iva.OptionsColumn.ReadOnly = true;
            // 
            // colcn_valoriva
            // 
            this.colcn_valoriva.FieldName = "cn_valoriva";
            this.colcn_valoriva.Name = "colcn_valoriva";
            this.colcn_valoriva.OptionsColumn.ReadOnly = true;
            // 
            // colIdCod_ICE
            // 
            this.colIdCod_ICE.FieldName = "IdCod_ICE";
            this.colIdCod_ICE.Name = "colIdCod_ICE";
            this.colIdCod_ICE.OptionsColumn.ReadOnly = true;
            // 
            // colcn_Ice_base
            // 
            this.colcn_Ice_base.FieldName = "cn_Ice_base";
            this.colcn_Ice_base.Name = "colcn_Ice_base";
            this.colcn_Ice_base.OptionsColumn.ReadOnly = true;
            // 
            // colcn_Ice_por
            // 
            this.colcn_Ice_por.FieldName = "cn_Ice_por";
            this.colcn_Ice_por.Name = "colcn_Ice_por";
            this.colcn_Ice_por.OptionsColumn.ReadOnly = true;
            // 
            // colcn_Ice_valor
            // 
            this.colcn_Ice_valor.FieldName = "cn_Ice_valor";
            this.colcn_Ice_valor.Name = "colcn_Ice_valor";
            this.colcn_Ice_valor.OptionsColumn.ReadOnly = true;
            // 
            // colcn_Serv_por
            // 
            this.colcn_Serv_por.FieldName = "cn_Serv_por";
            this.colcn_Serv_por.Name = "colcn_Serv_por";
            this.colcn_Serv_por.OptionsColumn.ReadOnly = true;
            // 
            // colcn_Serv_valor
            // 
            this.colcn_Serv_valor.FieldName = "cn_Serv_valor";
            this.colcn_Serv_valor.Name = "colcn_Serv_valor";
            this.colcn_Serv_valor.OptionsColumn.ReadOnly = true;
            // 
            // colcn_BaseSeguro
            // 
            this.colcn_BaseSeguro.FieldName = "cn_BaseSeguro";
            this.colcn_BaseSeguro.Name = "colcn_BaseSeguro";
            this.colcn_BaseSeguro.OptionsColumn.ReadOnly = true;
            // 
            // colcn_vaCoa
            // 
            this.colcn_vaCoa.FieldName = "cn_vaCoa";
            this.colcn_vaCoa.Name = "colcn_vaCoa";
            this.colcn_vaCoa.OptionsColumn.ReadOnly = true;
            // 
            // colIdTipoServicio
            // 
            this.colIdTipoServicio.FieldName = "IdTipoServicio";
            this.colIdTipoServicio.Name = "colIdTipoServicio";
            this.colIdTipoServicio.OptionsColumn.ReadOnly = true;
            // 
            // colIdCtaCble_Acre
            // 
            this.colIdCtaCble_Acre.FieldName = "IdCtaCble_Acre";
            this.colIdCtaCble_Acre.Name = "colIdCtaCble_Acre";
            this.colIdCtaCble_Acre.OptionsColumn.ReadOnly = true;
            // 
            // colIdCtaCble_IVA
            // 
            this.colIdCtaCble_IVA.FieldName = "IdCtaCble_IVA";
            this.colIdCtaCble_IVA.Name = "colIdCtaCble_IVA";
            this.colIdCtaCble_IVA.OptionsColumn.ReadOnly = true;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.OptionsColumn.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.ReadOnly = true;
            // 
            // colMotivoAnu
            // 
            this.colMotivoAnu.FieldName = "MotivoAnu";
            this.colMotivoAnu.Name = "colMotivoAnu";
            this.colMotivoAnu.OptionsColumn.ReadOnly = true;
            // 
            // colIdCbteCble_Anulacion
            // 
            this.colIdCbteCble_Anulacion.FieldName = "IdCbteCble_Anulacion";
            this.colIdCbteCble_Anulacion.Name = "colIdCbteCble_Anulacion";
            this.colIdCbteCble_Anulacion.OptionsColumn.ReadOnly = true;
            // 
            // colIdTipoCbte_Anulacion
            // 
            this.colIdTipoCbte_Anulacion.FieldName = "IdTipoCbte_Anulacion";
            this.colIdTipoCbte_Anulacion.Name = "colIdTipoCbte_Anulacion";
            this.colIdTipoCbte_Anulacion.OptionsColumn.ReadOnly = true;
            // 
            // colcn_tipoLocacion
            // 
            this.colcn_tipoLocacion.FieldName = "cn_tipoLocacion";
            this.colcn_tipoLocacion.Name = "colcn_tipoLocacion";
            this.colcn_tipoLocacion.OptionsColumn.ReadOnly = true;
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            this.colIdCentroCosto.OptionsColumn.ReadOnly = true;
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.OptionsColumn.ReadOnly = true;
            // 
            // colIdTipoFlujo
            // 
            this.colIdTipoFlujo.FieldName = "IdTipoFlujo";
            this.colIdTipoFlujo.Name = "colIdTipoFlujo";
            this.colIdTipoFlujo.OptionsColumn.ReadOnly = true;
            // 
            // colIdIden_credito
            // 
            this.colIdIden_credito.FieldName = "IdIden_credito";
            this.colIdIden_credito.Name = "colIdIden_credito";
            this.colIdIden_credito.OptionsColumn.ReadOnly = true;
            // 
            // colPagoLocExt
            // 
            this.colPagoLocExt.FieldName = "PagoLocExt";
            this.colPagoLocExt.Name = "colPagoLocExt";
            this.colPagoLocExt.OptionsColumn.ReadOnly = true;
            // 
            // colPaisPago
            // 
            this.colPaisPago.FieldName = "PaisPago";
            this.colPaisPago.Name = "colPaisPago";
            this.colPaisPago.OptionsColumn.ReadOnly = true;
            // 
            // colConvenioTributacion
            // 
            this.colConvenioTributacion.FieldName = "ConvenioTributacion";
            this.colConvenioTributacion.Name = "colConvenioTributacion";
            this.colConvenioTributacion.OptionsColumn.ReadOnly = true;
            // 
            // colPagoSujetoRetencion
            // 
            this.colPagoSujetoRetencion.FieldName = "PagoSujetoRetencion";
            this.colPagoSujetoRetencion.Name = "colPagoSujetoRetencion";
            this.colPagoSujetoRetencion.OptionsColumn.ReadOnly = true;
            // 
            // colIdTipoNota
            // 
            this.colIdTipoNota.FieldName = "IdTipoNota";
            this.colIdTipoNota.Name = "colIdTipoNota";
            this.colIdTipoNota.OptionsColumn.ReadOnly = true;
            // 
            // colcn_num_doc_modificado
            // 
            this.colcn_num_doc_modificado.FieldName = "cn_num_doc_modificado";
            this.colcn_num_doc_modificado.Name = "colcn_num_doc_modificado";
            this.colcn_num_doc_modificado.OptionsColumn.ReadOnly = true;
            // 
            // colcn_Autorizacion_Imprenta
            // 
            this.colcn_Autorizacion_Imprenta.Caption = "gridColumn48";
            this.colcn_Autorizacion_Imprenta.FieldName = "cn_Autorizacion_Imprenta";
            this.colcn_Autorizacion_Imprenta.Name = "colcn_Autorizacion_Imprenta";
            this.colcn_Autorizacion_Imprenta.OptionsColumn.ReadOnly = true;
            // 
            // colNum_Nota
            // 
            this.colNum_Nota.Caption = "#Nota";
            this.colNum_Nota.FieldName = "Num_Nota";
            this.colNum_Nota.Name = "colNum_Nota";
            this.colNum_Nota.OptionsColumn.ReadOnly = true;
            this.colNum_Nota.Visible = true;
            this.colNum_Nota.VisibleIndex = 1;
            this.colNum_Nota.Width = 133;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlCredito);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 254);
            this.panel1.TabIndex = 3;
            // 
            // frmCP_NotaCredito_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCP_NotaCredito_Cons";
            this.Text = "Consulta Nota Crédito al Proveedor";
            this.Load += new System.EventHandler(this.frmCP_NotaCredito_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCredito)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl gridControlCredito;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCredito;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble_Nota;
        private DevExpress.XtraGrid.Columns.GridColumn colDebCre;
        private DevExpress.XtraGrid.Columns.GridColumn colnomProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_FechaNota;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_Autorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_serie1;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_serie2;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_Nota;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_total;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte_Nota;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_subtotal_iva;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_subtotal_siniva;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_baseImponible;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_Por_iva;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_valoriva;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCod_ICE;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_Ice_base;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_Ice_por;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_Ice_valor;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_Serv_por;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_Serv_valor;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_BaseSeguro;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_vaCoa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoServicio;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Acre;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_IVA;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble_Anulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte_Anulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_tipoLocacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoFlujo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdIden_credito;
        private DevExpress.XtraGrid.Columns.GridColumn colPagoLocExt;
        private DevExpress.XtraGrid.Columns.GridColumn colPaisPago;
        private DevExpress.XtraGrid.Columns.GridColumn colConvenioTributacion;
        private DevExpress.XtraGrid.Columns.GridColumn colPagoSujetoRetencion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoNota;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_num_doc_modificado;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_Autorizacion_Imprenta;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_Nota;

    }
}