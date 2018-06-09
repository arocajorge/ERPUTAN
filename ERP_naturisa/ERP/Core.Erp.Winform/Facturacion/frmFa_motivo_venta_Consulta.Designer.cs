namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_motivo_venta_Consulta
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
            this.ucGe_Menu_Mantenimiento_MotivoVenta = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControl_MotivoVenta = new DevExpress.XtraGrid.GridControl();
            this.gridViewMotivoVenta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMotivo_Vta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodMotivo_Vta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_motivo_vta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_MotivoVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMotivoVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_MotivoVenta
            // 
            this.ucGe_Menu_Mantenimiento_MotivoVenta.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.fecha_desde = new System.DateTime(2015, 10, 13, 10, 40, 2, 346);
            this.ucGe_Menu_Mantenimiento_MotivoVenta.fecha_hasta = new System.DateTime(2015, 12, 13, 10, 40, 2, 347);
            this.ucGe_Menu_Mantenimiento_MotivoVenta.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.FormMain = null;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Name = "ucGe_Menu_Mantenimiento_MotivoVenta";
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Size = new System.Drawing.Size(767, 116);
            this.ucGe_Menu_Mantenimiento_MotivoVenta.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_MotivoVenta.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_MotivoVenta_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_MotivoVenta.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_MotivoVenta_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_MotivoVenta.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_MotivoVenta_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_MotivoVenta.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_MotivoVenta_event_btnAnular_ItemClick);
            this.ucGe_Menu_Mantenimiento_MotivoVenta.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_MotivoVenta_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_MotivoVenta.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_MotivoVenta_event_btnSalir_ItemClick);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 384);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(767, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // gridControl_MotivoVenta
            // 
            this.gridControl_MotivoVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_MotivoVenta.Location = new System.Drawing.Point(0, 116);
            this.gridControl_MotivoVenta.MainView = this.gridViewMotivoVenta;
            this.gridControl_MotivoVenta.Name = "gridControl_MotivoVenta";
            this.gridControl_MotivoVenta.Size = new System.Drawing.Size(767, 268);
            this.gridControl_MotivoVenta.TabIndex = 2;
            this.gridControl_MotivoVenta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMotivoVenta});
            // 
            // gridViewMotivoVenta
            // 
            this.gridViewMotivoVenta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMotivo_Vta,
            this.colcodMotivo_Vta,
            this.coldescripcion_motivo_vta,
            this.colEstado,
            this.colFechaModificacion,
            this.colFechaCreacion,
            this.colUsuarioModificacion,
            this.colUsuarioCreacion,
            this.colFechaAnulacion,
            this.colUsuarioAnulacion,
            this.colMotivoAnulacion});
            this.gridViewMotivoVenta.GridControl = this.gridControl_MotivoVenta;
            this.gridViewMotivoVenta.Name = "gridViewMotivoVenta";
            this.gridViewMotivoVenta.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewMotivoVenta_RowStyle);
            // 
            // colIdMotivo_Vta
            // 
            this.colIdMotivo_Vta.Caption = "Id Motivo de Venta";
            this.colIdMotivo_Vta.FieldName = "IdMotivo_Vta";
            this.colIdMotivo_Vta.Name = "colIdMotivo_Vta";
            this.colIdMotivo_Vta.Visible = true;
            this.colIdMotivo_Vta.VisibleIndex = 0;
            this.colIdMotivo_Vta.Width = 107;
            // 
            // colcodMotivo_Vta
            // 
            this.colcodMotivo_Vta.Caption = "Código Motivo Venta";
            this.colcodMotivo_Vta.FieldName = "codMotivo_Vta";
            this.colcodMotivo_Vta.Name = "colcodMotivo_Vta";
            this.colcodMotivo_Vta.Visible = true;
            this.colcodMotivo_Vta.VisibleIndex = 1;
            this.colcodMotivo_Vta.Width = 120;
            // 
            // coldescripcion_motivo_vta
            // 
            this.coldescripcion_motivo_vta.Caption = "Descripcion Motivo Venta";
            this.coldescripcion_motivo_vta.FieldName = "descripcion_motivo_vta";
            this.coldescripcion_motivo_vta.Name = "coldescripcion_motivo_vta";
            this.coldescripcion_motivo_vta.Visible = true;
            this.coldescripcion_motivo_vta.VisibleIndex = 2;
            this.coldescripcion_motivo_vta.Width = 488;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 3;
            this.colEstado.Width = 465;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.Caption = "Fecha Modificacion";
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.Caption = "Fecha Creacion";
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            // 
            // colUsuarioModificacion
            // 
            this.colUsuarioModificacion.Caption = "Usuario Modificacion";
            this.colUsuarioModificacion.FieldName = "UsuarioModificacion";
            this.colUsuarioModificacion.Name = "colUsuarioModificacion";
            // 
            // colUsuarioCreacion
            // 
            this.colUsuarioCreacion.Caption = "Usuario Creacion";
            this.colUsuarioCreacion.FieldName = "UsuarioCreacion";
            this.colUsuarioCreacion.Name = "colUsuarioCreacion";
            // 
            // colFechaAnulacion
            // 
            this.colFechaAnulacion.Caption = "Fecha Anulacion";
            this.colFechaAnulacion.FieldName = "FechaAnulacion";
            this.colFechaAnulacion.Name = "colFechaAnulacion";
            // 
            // colUsuarioAnulacion
            // 
            this.colUsuarioAnulacion.Caption = "Usuario Anulacion";
            this.colUsuarioAnulacion.FieldName = "UsuarioAnulacion";
            this.colUsuarioAnulacion.Name = "colUsuarioAnulacion";
            // 
            // colMotivoAnulacion
            // 
            this.colMotivoAnulacion.Caption = "Motivo Anulacion";
            this.colMotivoAnulacion.FieldName = "MotivoAnulacion";
            this.colMotivoAnulacion.Name = "colMotivoAnulacion";
            // 
            // frmFa_motivo_venta_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 410);
            this.Controls.Add(this.gridControl_MotivoVenta);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_MotivoVenta);
            this.Name = "frmFa_motivo_venta_Consulta";
            this.Text = "frmFa_motivo_venta_Consulta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFa_motivo_venta_Consulta_FormClosing);
            this.Load += new System.EventHandler(this.frmFa_motivo_venta_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_MotivoVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMotivoVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_MotivoVenta;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl gridControl_MotivoVenta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMotivoVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotivo_Vta;
        private DevExpress.XtraGrid.Columns.GridColumn colcodMotivo_Vta;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_motivo_vta;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoAnulacion;
    }
}