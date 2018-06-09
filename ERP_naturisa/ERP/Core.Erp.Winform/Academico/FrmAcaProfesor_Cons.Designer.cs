namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaProfesor_Cons
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
            this.Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControlProfesor = new DevExpress.XtraGrid.GridControl();
            this.acaProfesorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewProfesor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdInstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProfesor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodProfesor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersona_Info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaProfesorInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.CargarTodasBodegas = false;
            this.Menu.CargarTodasSucursales = true;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Enable_boton_anular = true;
            this.Menu.Enable_boton_CancelarCuotas = true;
            this.Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.Menu.Enable_boton_consultar = true;
            this.Menu.Enable_boton_DiseñoCheque = true;
            this.Menu.Enable_boton_DiseñoChequeComprobante = true;
            this.Menu.Enable_boton_Duplicar = true;
            this.Menu.Enable_boton_GenerarPeriodos = true;
            this.Menu.Enable_boton_GenerarXml = true;
            this.Menu.Enable_boton_Habilitar_Reg = true;
            this.Menu.Enable_boton_Importar_XML = true;
            this.Menu.Enable_boton_imprimir = true;
            this.Menu.Enable_boton_LoteCheque = true;
            this.Menu.Enable_boton_modificar = true;
            this.Menu.Enable_boton_nuevo = true;
            this.Menu.Enable_boton_NuevoCheque = true;
            this.Menu.Enable_boton_periodo = true;
            this.Menu.Enable_boton_salir = true;
            this.Menu.Enable_btnImpExcel = true;
            this.Menu.Enable_Descargar_Marca_Base_exter = true;
            this.Menu.fecha_desde = new System.DateTime(2017, 4, 19, 13, 10, 14, 4);
            this.Menu.fecha_hasta = new System.DateTime(2017, 6, 19, 13, 10, 14, 4);
            this.Menu.FormConsulta = null;
            this.Menu.FormMain = null;
            this.Menu.GridControlConsulta = null;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Perfil_x_usuario = null;
            this.Menu.Size = new System.Drawing.Size(756, 113);
            this.Menu.TabIndex = 0;
            this.Menu.Visible_bodega = false;
            this.Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_fechas = false;
            this.Menu.Visible_Grupo_Cancelaciones = true;
            this.Menu.Visible_Grupo_Diseño_Reporte = false;
            this.Menu.Visible_Grupo_filtro = true;
            this.Menu.Visible_Grupo_Impresion = true;
            this.Menu.Visible_Grupo_Otras_Trans = true;
            this.Menu.Visible_Grupo_Transacciones = true;
            this.Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.Menu.Visible_ribbon_control = true;
            this.Menu.Visible_sucursal = false;
            this.Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.Menu_event_btnNuevo_ItemClick);
            this.Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.Menu_event_btnModificar_ItemClick);
            this.Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.Menu_event_btnconsultar_ItemClick);
            this.Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.Menu_event_btnAnular_ItemClick);
            this.Menu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.Menu_event_btnImprimir_ItemClick);
            this.Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.Menu_event_btnSalir_ItemClick);
            // 
            // BarraEstado
            // 
            this.BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraEstado.Location = new System.Drawing.Point(0, 324);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(756, 26);
            this.BarraEstado.TabIndex = 1;
            // 
            // gridControlProfesor
            // 
            this.gridControlProfesor.DataSource = this.acaProfesorInfoBindingSource;
            this.gridControlProfesor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProfesor.Location = new System.Drawing.Point(0, 113);
            this.gridControlProfesor.MainView = this.gridViewProfesor;
            this.gridControlProfesor.Name = "gridControlProfesor";
            this.gridControlProfesor.Size = new System.Drawing.Size(756, 211);
            this.gridControlProfesor.TabIndex = 2;
            this.gridControlProfesor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProfesor});
            // 
            // acaProfesorInfoBindingSource
            // 
            this.acaProfesorInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Profesor_Info);
            // 
            // gridViewProfesor
            // 
            this.gridViewProfesor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdInstitucion,
            this.colIdProfesor,
            this.colCodProfesor,
            this.colIdPersona,
            this.colestado,
            this.colPersona_Info,
            this.colFechaCreacion,
            this.colFechaModificacion,
            this.colFechaAnulacion,
            this.colUsuarioCreacion,
            this.colUsuarioModificacion,
            this.colUsuarioAnulacion,
            this.coIdPersona,
            this.colTipoDocumento});
            this.gridViewProfesor.GridControl = this.gridControlProfesor;
            this.gridViewProfesor.Name = "gridViewProfesor";
            this.gridViewProfesor.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProfesor.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewProfesor_RowStyle);
            // 
            // colIdInstitucion
            // 
            this.colIdInstitucion.FieldName = "IdInstitucion";
            this.colIdInstitucion.Name = "colIdInstitucion";
            this.colIdInstitucion.OptionsColumn.AllowEdit = false;
            // 
            // colIdProfesor
            // 
            this.colIdProfesor.FieldName = "IdProfesor";
            this.colIdProfesor.Name = "colIdProfesor";
            this.colIdProfesor.OptionsColumn.AllowEdit = false;
            this.colIdProfesor.Visible = true;
            this.colIdProfesor.VisibleIndex = 0;
            // 
            // colCodProfesor
            // 
            this.colCodProfesor.FieldName = "CodProfesor";
            this.colCodProfesor.Name = "colCodProfesor";
            this.colCodProfesor.OptionsColumn.AllowEdit = false;
            this.colCodProfesor.Visible = true;
            this.colCodProfesor.VisibleIndex = 1;
            // 
            // colIdPersona
            // 
            this.colIdPersona.Caption = "Nombre ";
            this.colIdPersona.FieldName = "Persona_Info.pe_nombreCompleto";
            this.colIdPersona.Name = "colIdPersona";
            this.colIdPersona.OptionsColumn.AllowEdit = false;
            this.colIdPersona.Visible = true;
            this.colIdPersona.VisibleIndex = 3;
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 4;
            // 
            // colPersona_Info
            // 
            this.colPersona_Info.Caption = "Cédula";
            this.colPersona_Info.FieldName = "Persona_Info.pe_cedulaRuc";
            this.colPersona_Info.Name = "colPersona_Info";
            this.colPersona_Info.OptionsColumn.AllowEdit = false;
            this.colPersona_Info.Visible = true;
            this.colPersona_Info.VisibleIndex = 2;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.OptionsColumn.AllowEdit = false;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            this.colFechaModificacion.OptionsColumn.AllowEdit = false;
            // 
            // colFechaAnulacion
            // 
            this.colFechaAnulacion.FieldName = "FechaAnulacion";
            this.colFechaAnulacion.Name = "colFechaAnulacion";
            this.colFechaAnulacion.OptionsColumn.AllowEdit = false;
            // 
            // colUsuarioCreacion
            // 
            this.colUsuarioCreacion.FieldName = "UsuarioCreacion";
            this.colUsuarioCreacion.Name = "colUsuarioCreacion";
            this.colUsuarioCreacion.OptionsColumn.AllowEdit = false;
            // 
            // colUsuarioModificacion
            // 
            this.colUsuarioModificacion.FieldName = "UsuarioModificacion";
            this.colUsuarioModificacion.Name = "colUsuarioModificacion";
            this.colUsuarioModificacion.OptionsColumn.AllowEdit = false;
            // 
            // colUsuarioAnulacion
            // 
            this.colUsuarioAnulacion.FieldName = "UsuarioAnulacion";
            this.colUsuarioAnulacion.Name = "colUsuarioAnulacion";
            this.colUsuarioAnulacion.OptionsColumn.AllowEdit = false;
            // 
            // coIdPersona
            // 
            this.coIdPersona.Caption = "IdPersona";
            this.coIdPersona.FieldName = "Persona_Info.IdPersona";
            this.coIdPersona.Name = "coIdPersona";
            this.coIdPersona.OptionsColumn.AllowEdit = false;
            // 
            // colTipoDocumento
            // 
            this.colTipoDocumento.Caption = "Tipo Documento";
            this.colTipoDocumento.FieldName = "Persona_Info.IdTipoDocumento";
            this.colTipoDocumento.Name = "colTipoDocumento";
            this.colTipoDocumento.OptionsColumn.AllowEdit = false;
            // 
            // FrmAcaProfesor_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 350);
            this.Controls.Add(this.gridControlProfesor);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.Menu);
            this.Name = "FrmAcaProfesor_Cons";
            this.Text = "FrmAcaProfesor_Cons";
            this.Load += new System.EventHandler(this.FrmAcaProfesor_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaProfesorInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProfesor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms BarraEstado;
        private DevExpress.XtraGrid.GridControl gridControlProfesor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProfesor;
        private System.Windows.Forms.BindingSource acaProfesorInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdInstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProfesor;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProfesor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colPersona_Info;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn coIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoDocumento;
    }
}