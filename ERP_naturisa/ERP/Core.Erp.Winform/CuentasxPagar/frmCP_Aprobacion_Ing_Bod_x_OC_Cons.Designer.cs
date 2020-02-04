namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_Aprobacion_Ing_Bod_x_OC_Cons
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
            this.gridControlConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_aprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa_Ogiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbteCble_Ogiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte_Ogiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_auto_Proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_auto_Imprenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_subtotal_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_subtotal_siniva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_baseImponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_valoriva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrden_giro_Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdIden_credito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie2 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde = new System.DateTime(2016, 12, 10, 11, 37, 41, 742);
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta = new System.DateTime(2017, 2, 10, 11, 37, 41, 742);
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario1.Name = "ucGe_Menu_Mantenimiento_x_usuario1";
            this.ucGe_Menu_Mantenimiento_x_usuario1.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Size = new System.Drawing.Size(795, 155);
            this.ucGe_Menu_Mantenimiento_x_usuario1.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_bodega = false;
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
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 398);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(795, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // gridControlConsulta
            // 
            this.gridControlConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlConsulta.Location = new System.Drawing.Point(0, 155);
            this.gridControlConsulta.MainView = this.gridViewConsulta;
            this.gridControlConsulta.Name = "gridControlConsulta";
            this.gridControlConsulta.Size = new System.Drawing.Size(795, 243);
            this.gridControlConsulta.TabIndex = 2;
            this.gridControlConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsulta});
            // 
            // gridViewConsulta
            // 
            this.gridViewConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAprobacion,
            this.colFecha_aprobacion,
            this.colnom_proveedor,
            this.colObservacion,
            this.colco_total,
            this.colIdEmpresa,
            this.colIdEmpresa_Ogiro,
            this.colIdCbteCble_Ogiro,
            this.colIdTipoCbte_Ogiro,
            this.colIdProveedor,
            this.colSerie,
            this.colnum_documento,
            this.colnum_auto_Proveedor,
            this.colnum_auto_Imprenta,
            this.colFecha_Factura,
            this.colco_subtotal_iva,
            this.colco_subtotal_siniva,
            this.colDescuento,
            this.colco_baseImponible,
            this.colco_valoriva,
            this.colIdOrden_giro_Tipo,
            this.colIdIden_credito,
            this.colSerie2});
            this.gridViewConsulta.GridControl = this.gridControlConsulta;
            this.gridViewConsulta.Name = "gridViewConsulta";
            this.gridViewConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsulta.OptionsView.ShowGroupPanel = false;
            // 
            // colIdAprobacion
            // 
            this.colIdAprobacion.Caption = "# Apobación";
            this.colIdAprobacion.FieldName = "IdAprobacion";
            this.colIdAprobacion.Name = "colIdAprobacion";
            this.colIdAprobacion.OptionsColumn.AllowEdit = false;
            this.colIdAprobacion.OptionsColumn.ReadOnly = true;
            this.colIdAprobacion.Visible = true;
            this.colIdAprobacion.VisibleIndex = 0;
            this.colIdAprobacion.Width = 104;
            // 
            // colFecha_aprobacion
            // 
            this.colFecha_aprobacion.Caption = "Fecha Aprobación";
            this.colFecha_aprobacion.FieldName = "Fecha_aprobacion";
            this.colFecha_aprobacion.Name = "colFecha_aprobacion";
            this.colFecha_aprobacion.OptionsColumn.AllowEdit = false;
            this.colFecha_aprobacion.OptionsColumn.ReadOnly = true;
            this.colFecha_aprobacion.Visible = true;
            this.colFecha_aprobacion.VisibleIndex = 1;
            this.colFecha_aprobacion.Width = 195;
            // 
            // colnom_proveedor
            // 
            this.colnom_proveedor.Caption = "Proveedor";
            this.colnom_proveedor.FieldName = "nom_proveedor";
            this.colnom_proveedor.Name = "colnom_proveedor";
            this.colnom_proveedor.OptionsColumn.AllowEdit = false;
            this.colnom_proveedor.OptionsColumn.ReadOnly = true;
            this.colnom_proveedor.Visible = true;
            this.colnom_proveedor.VisibleIndex = 2;
            this.colnom_proveedor.Width = 248;
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observación";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.OptionsColumn.AllowEdit = false;
            this.colObservacion.OptionsColumn.ReadOnly = true;
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 3;
            this.colObservacion.Width = 461;
            // 
            // colco_total
            // 
            this.colco_total.Caption = "Total";
            this.colco_total.FieldName = "co_total";
            this.colco_total.Name = "colco_total";
            this.colco_total.OptionsColumn.AllowEdit = false;
            this.colco_total.OptionsColumn.ReadOnly = true;
            this.colco_total.Visible = true;
            this.colco_total.VisibleIndex = 4;
            this.colco_total.Width = 172;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.ReadOnly = true;
            // 
            // colIdEmpresa_Ogiro
            // 
            this.colIdEmpresa_Ogiro.FieldName = "IdEmpresa_Ogiro";
            this.colIdEmpresa_Ogiro.Name = "colIdEmpresa_Ogiro";
            this.colIdEmpresa_Ogiro.OptionsColumn.ReadOnly = true;
            // 
            // colIdCbteCble_Ogiro
            // 
            this.colIdCbteCble_Ogiro.FieldName = "IdCbteCble_Ogiro";
            this.colIdCbteCble_Ogiro.Name = "colIdCbteCble_Ogiro";
            this.colIdCbteCble_Ogiro.OptionsColumn.ReadOnly = true;
            // 
            // colIdTipoCbte_Ogiro
            // 
            this.colIdTipoCbte_Ogiro.FieldName = "IdTipoCbte_Ogiro";
            this.colIdTipoCbte_Ogiro.Name = "colIdTipoCbte_Ogiro";
            this.colIdTipoCbte_Ogiro.OptionsColumn.ReadOnly = true;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.OptionsColumn.ReadOnly = true;
            // 
            // colSerie
            // 
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.OptionsColumn.ReadOnly = true;
            // 
            // colnum_documento
            // 
            this.colnum_documento.FieldName = "num_documento";
            this.colnum_documento.Name = "colnum_documento";
            this.colnum_documento.OptionsColumn.ReadOnly = true;
            // 
            // colnum_auto_Proveedor
            // 
            this.colnum_auto_Proveedor.FieldName = "num_auto_Proveedor";
            this.colnum_auto_Proveedor.Name = "colnum_auto_Proveedor";
            this.colnum_auto_Proveedor.OptionsColumn.ReadOnly = true;
            // 
            // colnum_auto_Imprenta
            // 
            this.colnum_auto_Imprenta.FieldName = "num_auto_Imprenta";
            this.colnum_auto_Imprenta.Name = "colnum_auto_Imprenta";
            this.colnum_auto_Imprenta.OptionsColumn.ReadOnly = true;
            // 
            // colFecha_Factura
            // 
            this.colFecha_Factura.FieldName = "Fecha_Factura";
            this.colFecha_Factura.Name = "colFecha_Factura";
            this.colFecha_Factura.OptionsColumn.ReadOnly = true;
            // 
            // colco_subtotal_iva
            // 
            this.colco_subtotal_iva.FieldName = "co_subtotal_iva";
            this.colco_subtotal_iva.Name = "colco_subtotal_iva";
            this.colco_subtotal_iva.OptionsColumn.ReadOnly = true;
            // 
            // colco_subtotal_siniva
            // 
            this.colco_subtotal_siniva.FieldName = "co_subtotal_siniva";
            this.colco_subtotal_siniva.Name = "colco_subtotal_siniva";
            this.colco_subtotal_siniva.OptionsColumn.ReadOnly = true;
            // 
            // colDescuento
            // 
            this.colDescuento.FieldName = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.OptionsColumn.ReadOnly = true;
            // 
            // colco_baseImponible
            // 
            this.colco_baseImponible.FieldName = "co_baseImponible";
            this.colco_baseImponible.Name = "colco_baseImponible";
            this.colco_baseImponible.OptionsColumn.ReadOnly = true;
            // 
            // colco_valoriva
            // 
            this.colco_valoriva.FieldName = "co_valoriva";
            this.colco_valoriva.Name = "colco_valoriva";
            this.colco_valoriva.OptionsColumn.ReadOnly = true;
            // 
            // colIdOrden_giro_Tipo
            // 
            this.colIdOrden_giro_Tipo.FieldName = "IdOrden_giro_Tipo";
            this.colIdOrden_giro_Tipo.Name = "colIdOrden_giro_Tipo";
            this.colIdOrden_giro_Tipo.OptionsColumn.ReadOnly = true;
            // 
            // colIdIden_credito
            // 
            this.colIdIden_credito.FieldName = "IdIden_credito";
            this.colIdIden_credito.Name = "colIdIden_credito";
            this.colIdIden_credito.OptionsColumn.ReadOnly = true;
            // 
            // colSerie2
            // 
            this.colSerie2.FieldName = "Serie2";
            this.colSerie2.Name = "colSerie2";
            this.colSerie2.OptionsColumn.ReadOnly = true;
            // 
            // frmCP_Aprobacion_Ing_Bod_x_OC_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 424);
            this.Controls.Add(this.gridControlConsulta);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario1);
            this.Name = "frmCP_Aprobacion_Ing_Bod_x_OC_Cons";
            this.Text = "Consulta Aprobación Ingeso Bodega por Orden Compra";
            this.Load += new System.EventHandler(this.frmCP_Aprobacion_Ing_Bod_x_OC_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl gridControlConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_aprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colco_total;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa_Ogiro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble_Ogiro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte_Ogiro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_documento;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_auto_Proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_auto_Imprenta;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Factura;
        private DevExpress.XtraGrid.Columns.GridColumn colco_subtotal_iva;
        private DevExpress.XtraGrid.Columns.GridColumn colco_subtotal_siniva;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colco_baseImponible;
        private DevExpress.XtraGrid.Columns.GridColumn colco_valoriva;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrden_giro_Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdIden_credito;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie2;
    }
}