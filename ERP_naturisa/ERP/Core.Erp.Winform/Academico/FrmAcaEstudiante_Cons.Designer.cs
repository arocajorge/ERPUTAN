namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaEstudiante_Cons
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
            this.gridControlEstudiante = new DevExpress.XtraGrid.GridControl();
            this.gridViewEstudiante = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdInstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_estudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collugar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarrio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersona_Info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPais_Info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_alterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Codigo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.acaEstudianteInfoBindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaEstudianteInfoBindingSource)).BeginInit();
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 5, 2, 16, 52, 16, 382);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 7, 2, 16, 52, 16, 382);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(895, 97);
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
            this.ucGe_Menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_event_btnAnular_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            this.ucGe_Menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_event_btnBuscar_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 362);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(895, 21);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // gridControlEstudiante
            // 
            this.gridControlEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEstudiante.Location = new System.Drawing.Point(0, 97);
            this.gridControlEstudiante.MainView = this.gridViewEstudiante;
            this.gridControlEstudiante.Name = "gridControlEstudiante";
            this.gridControlEstudiante.Size = new System.Drawing.Size(895, 265);
            this.gridControlEstudiante.TabIndex = 2;
            this.gridControlEstudiante.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEstudiante});
            // 
            // gridViewEstudiante
            // 
            this.gridViewEstudiante.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdInstitucion,
            this.colIdEstudiante,
            this.colcod_estudiante,
            this.collugar,
            this.colbarrio,
            this.colfoto,
            this.colestado,
            this.colPersona_Info,
            this.colNombre,
            this.colApellido,
            this.colPais_Info,
            this.colDireccion,
            this.colcod_alterno,
            this.colFechaModificacion,
            this.colFechaCreacion,
            this.colUsuarioCreacion,
            this.colUsuarioModificacion,
            this.Col_Codigo2});
            this.gridViewEstudiante.GridControl = this.gridControlEstudiante;
            this.gridViewEstudiante.Name = "gridViewEstudiante";
            this.gridViewEstudiante.OptionsView.ShowAutoFilterRow = true;
            this.gridViewEstudiante.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewEstudiante_RowCellStyle);
            // 
            // colIdInstitucion
            // 
            this.colIdInstitucion.FieldName = "IdInstitucion";
            this.colIdInstitucion.Name = "colIdInstitucion";
            this.colIdInstitucion.OptionsColumn.AllowEdit = false;
            // 
            // colIdEstudiante
            // 
            this.colIdEstudiante.FieldName = "IdEstudiante";
            this.colIdEstudiante.Name = "colIdEstudiante";
            this.colIdEstudiante.OptionsColumn.AllowEdit = false;
            this.colIdEstudiante.Visible = true;
            this.colIdEstudiante.VisibleIndex = 0;
            this.colIdEstudiante.Width = 120;
            // 
            // colcod_estudiante
            // 
            this.colcod_estudiante.FieldName = "cod_estudiante";
            this.colcod_estudiante.Name = "colcod_estudiante";
            this.colcod_estudiante.OptionsColumn.AllowEdit = false;
            this.colcod_estudiante.Visible = true;
            this.colcod_estudiante.VisibleIndex = 1;
            this.colcod_estudiante.Width = 147;
            // 
            // collugar
            // 
            this.collugar.FieldName = "lugar";
            this.collugar.Name = "collugar";
            this.collugar.OptionsColumn.AllowEdit = false;
            // 
            // colbarrio
            // 
            this.colbarrio.FieldName = "barrio";
            this.colbarrio.Name = "colbarrio";
            this.colbarrio.OptionsColumn.AllowEdit = false;
            // 
            // colfoto
            // 
            this.colfoto.FieldName = "foto";
            this.colfoto.Name = "colfoto";
            this.colfoto.OptionsColumn.AllowEdit = false;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 7;
            this.colestado.Width = 86;
            // 
            // colPersona_Info
            // 
            this.colPersona_Info.Caption = "Cedula ";
            this.colPersona_Info.FieldName = "Persona_Info.pe_cedulaRuc";
            this.colPersona_Info.Name = "colPersona_Info";
            this.colPersona_Info.OptionsColumn.AllowEdit = false;
            this.colPersona_Info.Visible = true;
            this.colPersona_Info.VisibleIndex = 2;
            this.colPersona_Info.Width = 147;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Persona_Info.pe_nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 3;
            this.colNombre.Width = 147;
            // 
            // colApellido
            // 
            this.colApellido.Caption = "Apellido";
            this.colApellido.FieldName = "Persona_Info.pe_apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.OptionsColumn.AllowEdit = false;
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 4;
            this.colApellido.Width = 147;
            // 
            // colPais_Info
            // 
            this.colPais_Info.Caption = "Nacionalidad";
            this.colPais_Info.FieldName = "Pais_Info.Nacionalidad";
            this.colPais_Info.Name = "colPais_Info";
            this.colPais_Info.OptionsColumn.AllowEdit = false;
            this.colPais_Info.Visible = true;
            this.colPais_Info.VisibleIndex = 6;
            this.colPais_Info.Width = 217;
            // 
            // colDireccion
            // 
            this.colDireccion.Caption = "Dirección";
            this.colDireccion.FieldName = "Info_Persona.pe_direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.OptionsColumn.AllowEdit = false;
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 5;
            this.colDireccion.Width = 147;
            // 
            // colcod_alterno
            // 
            this.colcod_alterno.FieldName = "cod_alterno";
            this.colcod_alterno.Name = "colcod_alterno";
            this.colcod_alterno.OptionsColumn.AllowEdit = false;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            this.colFechaModificacion.OptionsColumn.AllowEdit = false;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.OptionsColumn.AllowEdit = false;
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
            // Col_Codigo2
            // 
            this.Col_Codigo2.Caption = "Codigo2";
            this.Col_Codigo2.FieldName = "cod_estudiante2";
            this.Col_Codigo2.Name = "Col_Codigo2";
            this.Col_Codigo2.OptionsColumn.AllowEdit = false;
            this.Col_Codigo2.Visible = true;
            this.Col_Codigo2.VisibleIndex = 8;
            // 
            // acaEstudianteInfoBindingSource
            // 
            this.acaEstudianteInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Estudiante_Info);
            // 
            // FrmAcaEstudiante_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 383);
            this.Controls.Add(this.gridControlEstudiante);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAcaEstudiante_Cons";
            this.Text = "FrmAcaEstudiante_Cons";
            this.Load += new System.EventHandler(this.FrmAcaEstudiante_Cons_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaEstudianteInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        ////private DevExpress.XtraGrid.GridControl gridControlEstudiante;
        ////private DevExpress.XtraGrid.Views.Grid.GridView gridViewEstudiante;
        private System.Windows.Forms.BindingSource acaEstudianteInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdInstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_estudiante;
        private DevExpress.XtraGrid.Columns.GridColumn collugar;
        private DevExpress.XtraGrid.Columns.GridColumn colbarrio;
        private DevExpress.XtraGrid.Columns.GridColumn colfoto;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colPersona_Info;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colPais_Info;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_alterno;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Codigo2;
    }
}