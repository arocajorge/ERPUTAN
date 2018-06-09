namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_RetencionConsulta
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
            this.gridControlConsRet = new DevExpress.XtraGrid.GridControl();
            this.gridViewConsRet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbte_CXP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte_Ogiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura_Prov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_FechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroRT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_RT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutorizacionRT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoRT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpresaRT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacionRT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colre_Tiene_RTiva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colre_Tiene_RFuente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_Prov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colserie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa_Ogiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado_Auto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaReg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsRet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsRet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlConsRet
            // 
            this.gridControlConsRet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlConsRet.Location = new System.Drawing.Point(0, 0);
            this.gridControlConsRet.MainView = this.gridViewConsRet;
            this.gridControlConsRet.Name = "gridControlConsRet";
            this.gridControlConsRet.Size = new System.Drawing.Size(1205, 236);
            this.gridControlConsRet.TabIndex = 0;
            this.gridControlConsRet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsRet});
            // 
            // gridViewConsRet
            // 
            this.gridViewConsRet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdCbte_CXP,
            this.colIdTipoCbte_Ogiro,
            this.colFactura_Prov,
            this.colco_FechaFactura,
            this.colIdRetencion,
            this.colNumeroRT,
            this.colFecha_RT,
            this.colAutorizacionRT,
            this.colEstadoRT,
            this.colImpresaRT,
            this.colobservacionRT,
            this.colre_Tiene_RTiva,
            this.colre_Tiene_RFuente,
            this.colIdProveedor,
            this.colNombre_Prov,
            this.colserie,
            this.colIdEmpresa_Ogiro,
            this.colEstado_Auto,
            this.colFechaReg});
            this.gridViewConsRet.GridControl = this.gridControlConsRet;
            this.gridViewConsRet.Name = "gridViewConsRet";
            this.gridViewConsRet.OptionsBehavior.Editable = false;
            this.gridViewConsRet.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsRet.OptionsView.ShowGroupPanel = false;
            this.gridViewConsRet.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAutorizacionRT, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewConsRet.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewConsRet_RowCellStyle);
            this.gridViewConsRet.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewConsRet_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.ReadOnly = true;
            // 
            // colIdCbte_CXP
            // 
            this.colIdCbte_CXP.Caption = "IdCbte_CXP";
            this.colIdCbte_CXP.FieldName = "IdCbteCble_Ogiro";
            this.colIdCbte_CXP.Name = "colIdCbte_CXP";
            this.colIdCbte_CXP.OptionsColumn.ReadOnly = true;
            this.colIdCbte_CXP.Width = 112;
            // 
            // colIdTipoCbte_Ogiro
            // 
            this.colIdTipoCbte_Ogiro.FieldName = "IdTipoCbte_Ogiro";
            this.colIdTipoCbte_Ogiro.Name = "colIdTipoCbte_Ogiro";
            this.colIdTipoCbte_Ogiro.OptionsColumn.ReadOnly = true;
            this.colIdTipoCbte_Ogiro.Width = 120;
            // 
            // colFactura_Prov
            // 
            this.colFactura_Prov.Caption = "#Factura";
            this.colFactura_Prov.FieldName = "Factura_Prov";
            this.colFactura_Prov.Name = "colFactura_Prov";
            this.colFactura_Prov.OptionsColumn.ReadOnly = true;
            this.colFactura_Prov.Visible = true;
            this.colFactura_Prov.VisibleIndex = 2;
            this.colFactura_Prov.Width = 161;
            // 
            // colco_FechaFactura
            // 
            this.colco_FechaFactura.Caption = "Fecha/Fact";
            this.colco_FechaFactura.FieldName = "co_FechaFactura";
            this.colco_FechaFactura.Name = "colco_FechaFactura";
            this.colco_FechaFactura.OptionsColumn.ReadOnly = true;
            this.colco_FechaFactura.Width = 187;
            // 
            // colIdRetencion
            // 
            this.colIdRetencion.Caption = "IdRetencion";
            this.colIdRetencion.FieldName = "IdRetencion";
            this.colIdRetencion.Name = "colIdRetencion";
            this.colIdRetencion.OptionsColumn.ReadOnly = true;
            this.colIdRetencion.Width = 70;
            // 
            // colNumeroRT
            // 
            this.colNumeroRT.Caption = "#Retencion";
            this.colNumeroRT.FieldName = "NumRetencion";
            this.colNumeroRT.Name = "colNumeroRT";
            this.colNumeroRT.OptionsColumn.ReadOnly = true;
            this.colNumeroRT.Visible = true;
            this.colNumeroRT.VisibleIndex = 0;
            this.colNumeroRT.Width = 116;
            // 
            // colFecha_RT
            // 
            this.colFecha_RT.Caption = "Fecha Ret.";
            this.colFecha_RT.FieldName = "fecha";
            this.colFecha_RT.Name = "colFecha_RT";
            this.colFecha_RT.OptionsColumn.ReadOnly = true;
            this.colFecha_RT.Visible = true;
            this.colFecha_RT.VisibleIndex = 1;
            this.colFecha_RT.Width = 113;
            // 
            // colAutorizacionRT
            // 
            this.colAutorizacionRT.Caption = "#Autorizacion";
            this.colAutorizacionRT.FieldName = "NAutorizacion";
            this.colAutorizacionRT.Name = "colAutorizacionRT";
            this.colAutorizacionRT.OptionsColumn.ReadOnly = true;
            this.colAutorizacionRT.Visible = true;
            this.colAutorizacionRT.VisibleIndex = 6;
            this.colAutorizacionRT.Width = 113;
            // 
            // colEstadoRT
            // 
            this.colEstadoRT.Caption = "Estado";
            this.colEstadoRT.FieldName = "Estado";
            this.colEstadoRT.Name = "colEstadoRT";
            this.colEstadoRT.OptionsColumn.ReadOnly = true;
            this.colEstadoRT.Width = 104;
            // 
            // colImpresaRT
            // 
            this.colImpresaRT.Caption = "Impresa";
            this.colImpresaRT.FieldName = "re_EstaImpresa";
            this.colImpresaRT.Name = "colImpresaRT";
            this.colImpresaRT.OptionsColumn.ReadOnly = true;
            this.colImpresaRT.Width = 51;
            // 
            // colobservacionRT
            // 
            this.colobservacionRT.Caption = "Observacion";
            this.colobservacionRT.FieldName = "observacion";
            this.colobservacionRT.Name = "colobservacionRT";
            this.colobservacionRT.OptionsColumn.ReadOnly = true;
            this.colobservacionRT.Visible = true;
            this.colobservacionRT.VisibleIndex = 4;
            this.colobservacionRT.Width = 333;
            // 
            // colre_Tiene_RTiva
            // 
            this.colre_Tiene_RTiva.Caption = "Rt/Iva";
            this.colre_Tiene_RTiva.FieldName = "re_Tiene_RTiva";
            this.colre_Tiene_RTiva.Name = "colre_Tiene_RTiva";
            this.colre_Tiene_RTiva.OptionsColumn.ReadOnly = true;
            this.colre_Tiene_RTiva.Width = 49;
            // 
            // colre_Tiene_RFuente
            // 
            this.colre_Tiene_RFuente.Caption = "RT/Fte";
            this.colre_Tiene_RFuente.FieldName = "re_Tiene_RFuente";
            this.colre_Tiene_RFuente.Name = "colre_Tiene_RFuente";
            this.colre_Tiene_RFuente.OptionsColumn.ReadOnly = true;
            this.colre_Tiene_RFuente.Width = 57;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.Caption = "IdProveedor";
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.OptionsColumn.ReadOnly = true;
            // 
            // colNombre_Prov
            // 
            this.colNombre_Prov.Caption = "Proveedor";
            this.colNombre_Prov.FieldName = "NomProveedor";
            this.colNombre_Prov.Name = "colNombre_Prov";
            this.colNombre_Prov.OptionsColumn.ReadOnly = true;
            this.colNombre_Prov.Visible = true;
            this.colNombre_Prov.VisibleIndex = 3;
            this.colNombre_Prov.Width = 205;
            // 
            // colserie
            // 
            this.colserie.Caption = "Serie";
            this.colserie.FieldName = "S_Serie";
            this.colserie.Name = "colserie";
            this.colserie.OptionsColumn.ReadOnly = true;
            // 
            // colIdEmpresa_Ogiro
            // 
            this.colIdEmpresa_Ogiro.FieldName = "IdEmpresa_Ogiro";
            this.colIdEmpresa_Ogiro.Name = "colIdEmpresa_Ogiro";
            this.colIdEmpresa_Ogiro.OptionsColumn.ReadOnly = true;
            // 
            // colEstado_Auto
            // 
            this.colEstado_Auto.Caption = "Auto";
            this.colEstado_Auto.FieldName = "Estado_Auto";
            this.colEstado_Auto.Name = "colEstado_Auto";
            this.colEstado_Auto.Visible = true;
            this.colEstado_Auto.VisibleIndex = 5;
            this.colEstado_Auto.Width = 146;
            // 
            // colFechaReg
            // 
            this.colFechaReg.Caption = "Fecha/Reg";
            this.colFechaReg.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.colFechaReg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaReg.FieldName = "Fecha_Transac";
            this.colFechaReg.Name = "colFechaReg";
            this.colFechaReg.Width = 99;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1205, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2016, 12, 27, 11, 39, 12, 869);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 2, 27, 11, 39, 12, 869);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(1205, 175);
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
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = false;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick);
            this.ucGe_Menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlConsRet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 236);
            this.panel1.TabIndex = 4;
            // 
            // frmCP_RetencionConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmCP_RetencionConsulta";
            this.Text = "Consulta Retención";
            this.Load += new System.EventHandler(this.frmCP_RetencionConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsRet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsRet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlConsRet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConsRet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbte_CXP;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte_Ogiro;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura_Prov;
        private DevExpress.XtraGrid.Columns.GridColumn colco_FechaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRetencion;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroRT;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_RT;
        private DevExpress.XtraGrid.Columns.GridColumn colAutorizacionRT;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoRT;
        private DevExpress.XtraGrid.Columns.GridColumn colImpresaRT;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacionRT;
        private DevExpress.XtraGrid.Columns.GridColumn colre_Tiene_RTiva;
        private DevExpress.XtraGrid.Columns.GridColumn colre_Tiene_RFuente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Prov;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.Columns.GridColumn colserie;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa_Ogiro;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_Auto;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaReg;
    }
}