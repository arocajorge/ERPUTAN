namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Devolucion_Inven_Cons
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
            this.UCMenu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gridControlDevol_Inven = new DevExpress.XtraGrid.GridControl();
            this.gridViewDevol_Inven = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDev_Inven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovi_inven_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNumMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDevol_Inven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDevol_Inven)).BeginInit();
            this.SuspendLayout();
            // 
            // UCMenu
            // 
            this.UCMenu.CargarTodasBodegas = false;
            this.UCMenu.CargarTodasSucursales = true;
            this.UCMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.UCMenu.Enable_boton_anular = true;
            this.UCMenu.Enable_boton_CancelarCuotas = true;
            this.UCMenu.Enable_boton_CargaMarcaciónExcel = true;
            this.UCMenu.Enable_boton_consultar = true;
            this.UCMenu.Enable_boton_DiseñoCheque = true;
            this.UCMenu.Enable_boton_DiseñoChequeComprobante = true;
            this.UCMenu.Enable_boton_Duplicar = true;
            this.UCMenu.Enable_boton_GenerarPeriodos = true;
            this.UCMenu.Enable_boton_GenerarXml = true;
            this.UCMenu.Enable_boton_Habilitar_Reg = true;
            this.UCMenu.Enable_boton_Importar_XML = true;
            this.UCMenu.Enable_boton_imprimir = true;
            this.UCMenu.Enable_boton_LoteCheque = true;
            this.UCMenu.Enable_boton_modificar = true;
            this.UCMenu.Enable_boton_nuevo = true;
            this.UCMenu.Enable_boton_NuevoCheque = true;
            this.UCMenu.Enable_boton_periodo = true;
            this.UCMenu.Enable_boton_salir = true;
            this.UCMenu.Enable_btnImpExcel = true;
            this.UCMenu.Enable_Descargar_Marca_Base_exter = true;
            this.UCMenu.fecha_desde = new System.DateTime(2017, 4, 27, 13, 39, 43, 928);
            this.UCMenu.fecha_hasta = new System.DateTime(2017, 6, 27, 13, 39, 43, 928);
            this.UCMenu.FormConsulta = null;
            this.UCMenu.FormMain = null;
            this.UCMenu.GridControlConsulta = null;
            this.UCMenu.Location = new System.Drawing.Point(0, 0);
            this.UCMenu.Name = "UCMenu";
            this.UCMenu.Perfil_x_usuario = null;
            this.UCMenu.Size = new System.Drawing.Size(907, 155);
            this.UCMenu.TabIndex = 15;
            this.UCMenu.Visible_bodega = true;
            this.UCMenu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.UCMenu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.UCMenu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.UCMenu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.UCMenu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.UCMenu.Visible_fechas = true;
            this.UCMenu.Visible_Grupo_Cancelaciones = true;
            this.UCMenu.Visible_Grupo_Diseño_Reporte = false;
            this.UCMenu.Visible_Grupo_filtro = true;
            this.UCMenu.Visible_Grupo_Impresion = true;
            this.UCMenu.Visible_Grupo_Otras_Trans = true;
            this.UCMenu.Visible_Grupo_Transacciones = true;
            this.UCMenu.Visible_Pie_fechas_Boton_buscar = true;
            this.UCMenu.Visible_ribbon_control = true;
            this.UCMenu.Visible_sucursal = false;
            this.UCMenu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick);
            this.UCMenu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick);
            this.UCMenu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick);
            this.UCMenu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick);
            this.UCMenu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick);
            this.UCMenu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick);
            this.UCMenu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // ucGe_BarraEstadoInferior
            // 
            this.ucGe_BarraEstadoInferior.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior.Location = new System.Drawing.Point(0, 447);
            this.ucGe_BarraEstadoInferior.Name = "ucGe_BarraEstadoInferior";
            this.ucGe_BarraEstadoInferior.Size = new System.Drawing.Size(907, 26);
            this.ucGe_BarraEstadoInferior.TabIndex = 16;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gridControlDevol_Inven);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 155);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(907, 292);
            this.panelMain.TabIndex = 17;
            // 
            // gridControlDevol_Inven
            // 
            this.gridControlDevol_Inven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDevol_Inven.Location = new System.Drawing.Point(0, 0);
            this.gridControlDevol_Inven.MainView = this.gridViewDevol_Inven;
            this.gridControlDevol_Inven.Name = "gridControlDevol_Inven";
            this.gridControlDevol_Inven.Size = new System.Drawing.Size(907, 292);
            this.gridControlDevol_Inven.TabIndex = 0;
            this.gridControlDevol_Inven.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDevol_Inven});
            // 
            // gridViewDevol_Inven
            // 
            this.gridViewDevol_Inven.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDev_Inven,
            this.colFecha,
            this.colestado,
            this.colIdMovi_inven_tipo,
            this.colIdNumMovi,
            this.colobservacion,
            this.colnom_sucursal});
            this.gridViewDevol_Inven.GridControl = this.gridControlDevol_Inven;
            this.gridViewDevol_Inven.Name = "gridViewDevol_Inven";
            this.gridViewDevol_Inven.OptionsBehavior.Editable = false;
            this.gridViewDevol_Inven.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDevol_Inven.OptionsView.ShowGroupPanel = false;
            this.gridViewDevol_Inven.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewDevol_Inven_RowCellStyle);
            this.gridViewDevol_Inven.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDevol_Inven_FocusedRowChanged);
            // 
            // colIdDev_Inven
            // 
            this.colIdDev_Inven.Caption = "IdDev_Inven";
            this.colIdDev_Inven.FieldName = "IdDev_Inven";
            this.colIdDev_Inven.Name = "colIdDev_Inven";
            this.colIdDev_Inven.Visible = true;
            this.colIdDev_Inven.VisibleIndex = 1;
            this.colIdDev_Inven.Width = 115;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            this.colFecha.Width = 250;
            // 
            // colestado
            // 
            this.colestado.Caption = "estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 4;
            this.colestado.Width = 194;
            // 
            // colIdMovi_inven_tipo
            // 
            this.colIdMovi_inven_tipo.Caption = "IdMovi_inven_tipo";
            this.colIdMovi_inven_tipo.FieldName = "IdMovi_inven_tipo";
            this.colIdMovi_inven_tipo.Name = "colIdMovi_inven_tipo";
            this.colIdMovi_inven_tipo.Visible = true;
            this.colIdMovi_inven_tipo.VisibleIndex = 6;
            this.colIdMovi_inven_tipo.Width = 202;
            // 
            // colIdNumMovi
            // 
            this.colIdNumMovi.Caption = "IdNumMovi";
            this.colIdNumMovi.FieldName = "IdNumMovi";
            this.colIdNumMovi.Name = "colIdNumMovi";
            this.colIdNumMovi.Visible = true;
            this.colIdNumMovi.VisibleIndex = 5;
            this.colIdNumMovi.Width = 194;
            // 
            // colobservacion
            // 
            this.colobservacion.Caption = "Observacion";
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.Visible = true;
            this.colobservacion.VisibleIndex = 3;
            this.colobservacion.Width = 420;
            // 
            // colnom_sucursal
            // 
            this.colnom_sucursal.Caption = "Sucursal";
            this.colnom_sucursal.FieldName = "nom_sucursal";
            this.colnom_sucursal.Name = "colnom_sucursal";
            this.colnom_sucursal.Visible = true;
            this.colnom_sucursal.VisibleIndex = 0;
            this.colnom_sucursal.Width = 359;
            // 
            // FrmIn_Devolucion_Inven_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 473);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstadoInferior);
            this.Controls.Add(this.UCMenu);
            this.Name = "FrmIn_Devolucion_Inven_Cons";
            this.Text = "Devolucion de Inventario";
            this.Load += new System.EventHandler(this.FrmIn_Devolucion_Inven_Cons_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDevol_Inven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDevol_Inven)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario UCMenu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraGrid.GridControl gridControlDevol_Inven;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDevol_Inven;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDev_Inven;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovi_inven_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNumMovi;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_sucursal;
    }
}