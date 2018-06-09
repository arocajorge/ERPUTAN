namespace Core.Erp.Winform.Roles
{
    partial class FrmRo_Solicitud_Tarjetas_Rol_Electronico_Cons
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
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControlSolicitud = new DevExpress.XtraGrid.GridControl();
            this.gridViewSolicitud = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProceso_bancario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrigen_Archivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCod_Empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_Archivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoArchivo_cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivo_anulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_proceso_bancario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_EstadoArchivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 1, 25, 15, 58, 1, 772);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 2, 26, 15, 58, 1, 772);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(679, 115);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 484);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(679, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // gridControlSolicitud
            // 
            this.gridControlSolicitud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSolicitud.Location = new System.Drawing.Point(0, 115);
            this.gridControlSolicitud.MainView = this.gridViewSolicitud;
            this.gridControlSolicitud.Name = "gridControlSolicitud";
            this.gridControlSolicitud.Size = new System.Drawing.Size(679, 369);
            this.gridControlSolicitud.TabIndex = 2;
            this.gridControlSolicitud.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSolicitud});
            // 
            // gridViewSolicitud
            // 
            this.gridViewSolicitud.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdBanco,
            this.colIdProceso_bancario,
            this.colOrigen_Archivo,
            this.colCod_Empresa,
            this.colNom_Archivo,
            this.colFecha,
            this.colIdEstadoArchivo_cat,
            this.colMotivo_anulacion,
            this.colnom_banco,
            this.colnom_proceso_bancario,
            this.colnom_EstadoArchivo});
            this.gridViewSolicitud.GridControl = this.gridControlSolicitud;
            this.gridViewSolicitud.Name = "gridViewSolicitud";
            this.gridViewSolicitud.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSolicitud.OptionsView.ShowGroupPanel = false;
            // 
            // colIdBanco
            // 
            this.colIdBanco.Caption = "Id Banco";
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            // 
            // colIdProceso_bancario
            // 
            this.colIdProceso_bancario.Caption = "Id Proceso Bancario";
            this.colIdProceso_bancario.FieldName = "IdProceso_bancario";
            this.colIdProceso_bancario.Name = "colIdProceso_bancario";
            // 
            // colOrigen_Archivo
            // 
            this.colOrigen_Archivo.Caption = "Origen del Archivo";
            this.colOrigen_Archivo.FieldName = "Origen_Archivo";
            this.colOrigen_Archivo.Name = "colOrigen_Archivo";
            this.colOrigen_Archivo.Visible = true;
            this.colOrigen_Archivo.VisibleIndex = 2;
            this.colOrigen_Archivo.Width = 195;
            // 
            // colCod_Empresa
            // 
            this.colCod_Empresa.Caption = "Código de Empresa ";
            this.colCod_Empresa.FieldName = "Cod_Empresa";
            this.colCod_Empresa.Name = "colCod_Empresa";
            // 
            // colNom_Archivo
            // 
            this.colNom_Archivo.Caption = "Nombre del Archivo";
            this.colNom_Archivo.FieldName = "Nom_Archivo";
            this.colNom_Archivo.Name = "colNom_Archivo";
            this.colNom_Archivo.Visible = true;
            this.colNom_Archivo.VisibleIndex = 1;
            this.colNom_Archivo.Width = 303;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 3;
            this.colFecha.Width = 166;
            // 
            // colIdEstadoArchivo_cat
            // 
            this.colIdEstadoArchivo_cat.Caption = "IdEstadoArchivo_cat";
            this.colIdEstadoArchivo_cat.FieldName = "IdEstadoArchivo_cat";
            this.colIdEstadoArchivo_cat.Name = "colIdEstadoArchivo_cat";
            // 
            // colMotivo_anulacion
            // 
            this.colMotivo_anulacion.Caption = "Motivo del Anulación";
            this.colMotivo_anulacion.FieldName = "Motivo_anulacion";
            this.colMotivo_anulacion.Name = "colMotivo_anulacion";
            // 
            // colnom_banco
            // 
            this.colnom_banco.Caption = "Nombre del Banco";
            this.colnom_banco.FieldName = "nom_banco";
            this.colnom_banco.Name = "colnom_banco";
            this.colnom_banco.Visible = true;
            this.colnom_banco.VisibleIndex = 0;
            this.colnom_banco.Width = 203;
            // 
            // colnom_proceso_bancario
            // 
            this.colnom_proceso_bancario.Caption = "Proceso Bancario";
            this.colnom_proceso_bancario.FieldName = "nom_proceso_bancario";
            this.colnom_proceso_bancario.Name = "colnom_proceso_bancario";
            // 
            // colnom_EstadoArchivo
            // 
            this.colnom_EstadoArchivo.Caption = "Estado del Archivo";
            this.colnom_EstadoArchivo.FieldName = "nom_EstadoArchivo";
            this.colnom_EstadoArchivo.Name = "colnom_EstadoArchivo";
            this.colnom_EstadoArchivo.Visible = true;
            this.colnom_EstadoArchivo.VisibleIndex = 4;
            this.colnom_EstadoArchivo.Width = 160;
            // 
            // FrmRo_Solicitud_Tarjetas_Rol_Electronico_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 510);
            this.Controls.Add(this.gridControlSolicitud);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "FrmRo_Solicitud_Tarjetas_Rol_Electronico_Cons";
            this.Text = "FrmRo_Solicitud_Tarjetas_Rol_Electronico_Cons";
            this.Load += new System.EventHandler(this.FrmRo_Solicitud_Tarjetas_Rol_Electronico_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl gridControlSolicitud;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSolicitud;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProceso_bancario;
        private DevExpress.XtraGrid.Columns.GridColumn colOrigen_Archivo;
        private DevExpress.XtraGrid.Columns.GridColumn colCod_Empresa;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_Archivo;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoArchivo_cat;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivo_anulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_banco;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_proceso_bancario;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_EstadoArchivo;
    }
}