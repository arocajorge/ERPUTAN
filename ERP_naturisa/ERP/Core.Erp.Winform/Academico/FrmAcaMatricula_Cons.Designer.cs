namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaMatricula_Cons
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControlMatriculaEstudiante = new DevExpress.XtraGrid.GridControl();
            this.acaMatriculaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewMatriculaEstudiante = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMatriucla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodMatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaMatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPeriodoLectivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFamiliar_repre_legal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFamiliar_repre_econ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSi_estoy_deacuerdo_foto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo_estoy_deacuerdo_foto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCod_convivencia_doy_fe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestudianteInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcursoInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEstudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoEstudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdJornada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSeccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSede = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMatriculaEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaMatriculaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMatriculaEstudiante)).BeginInit();
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 4, 19, 12, 32, 46, 534);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 6, 19, 12, 32, 46, 534);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(689, 112);
            this.ucGe_Menu.TabIndex = 4;
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
            this.ucGe_Menu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_event_btnImprimir_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            // 
            // ucGe_BarraEstadoInferior_Forms
            // 
            this.ucGe_BarraEstadoInferior_Forms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms.Location = new System.Drawing.Point(0, 374);
            this.ucGe_BarraEstadoInferior_Forms.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_BarraEstadoInferior_Forms.Name = "ucGe_BarraEstadoInferior_Forms";
            this.ucGe_BarraEstadoInferior_Forms.Size = new System.Drawing.Size(689, 31);
            this.ucGe_BarraEstadoInferior_Forms.TabIndex = 5;
            // 
            // gridControlMatriculaEstudiante
            // 
            this.gridControlMatriculaEstudiante.DataSource = this.acaMatriculaInfoBindingSource;
            this.gridControlMatriculaEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMatriculaEstudiante.Location = new System.Drawing.Point(0, 112);
            this.gridControlMatriculaEstudiante.MainView = this.gridViewMatriculaEstudiante;
            this.gridControlMatriculaEstudiante.Name = "gridControlMatriculaEstudiante";
            this.gridControlMatriculaEstudiante.Size = new System.Drawing.Size(689, 262);
            this.gridControlMatriculaEstudiante.TabIndex = 6;
            this.gridControlMatriculaEstudiante.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMatriculaEstudiante});
            // 
            // acaMatriculaInfoBindingSource
            // 
            this.acaMatriculaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Matricula_Info);
            // 
            // gridViewMatriculaEstudiante
            // 
            this.gridViewMatriculaEstudiante.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdMatriucla,
            this.colCodMatricula,
            this.colFechaMatricula,
            this.colIdEstudiante,
            this.colIdPeriodoLectivo,
            this.colIdFamiliar_repre_legal,
            this.colIdFamiliar_repre_econ,
            this.colObservacion,
            this.colSi_estoy_deacuerdo_foto,
            this.colNo_estoy_deacuerdo_foto,
            this.colCod_convivencia_doy_fe,
            this.colEstado,
            this.colFechaCreacion,
            this.colFechaModificacion,
            this.colFechaAnulacion,
            this.colUsuarioCreacion,
            this.colUsuarioModificacion,
            this.colUsuarioAnulacion,
            this.colestudianteInfo,
            this.colcursoInfo,
            this.colNombreEstudiante,
            this.colApellidoEstudiante,
            this.colIdJornada,
            this.colIdMatricula,
            this.colIdSeccion,
            this.colIdSede});
            this.gridViewMatriculaEstudiante.GridControl = this.gridControlMatriculaEstudiante;
            this.gridViewMatriculaEstudiante.Name = "gridViewMatriculaEstudiante";
            this.gridViewMatriculaEstudiante.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMatriculaEstudiante.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewMatriculaEstudiante_RowStyle);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            // 
            // colIdMatriucla
            // 
            this.colIdMatriucla.Caption = "Id Matricula";
            this.colIdMatriucla.FieldName = "IdMatricula";
            this.colIdMatriucla.Name = "colIdMatriucla";
            this.colIdMatriucla.OptionsColumn.AllowEdit = false;
            this.colIdMatriucla.Visible = true;
            this.colIdMatriucla.VisibleIndex = 1;
            // 
            // colCodMatricula
            // 
            this.colCodMatricula.FieldName = "CodMatricula";
            this.colCodMatricula.Name = "colCodMatricula";
            this.colCodMatricula.OptionsColumn.AllowEdit = false;
            this.colCodMatricula.Visible = true;
            this.colCodMatricula.VisibleIndex = 2;
            // 
            // colFechaMatricula
            // 
            this.colFechaMatricula.FieldName = "FechaMatricula";
            this.colFechaMatricula.Name = "colFechaMatricula";
            this.colFechaMatricula.OptionsColumn.AllowEdit = false;
            this.colFechaMatricula.Visible = true;
            this.colFechaMatricula.VisibleIndex = 6;
            // 
            // colIdEstudiante
            // 
            this.colIdEstudiante.Caption = "Cédula";
            this.colIdEstudiante.FieldName = "estudianteInfo.Persona_Info.pe_cedulaRuc";
            this.colIdEstudiante.Name = "colIdEstudiante";
            this.colIdEstudiante.OptionsColumn.AllowEdit = false;
            this.colIdEstudiante.Visible = true;
            this.colIdEstudiante.VisibleIndex = 3;
            // 
            // colIdPeriodoLectivo
            // 
            this.colIdPeriodoLectivo.FieldName = "IdAnioLectivo";
            this.colIdPeriodoLectivo.Name = "colIdPeriodoLectivo";
            this.colIdPeriodoLectivo.OptionsColumn.AllowEdit = false;
            this.colIdPeriodoLectivo.Visible = true;
            this.colIdPeriodoLectivo.VisibleIndex = 0;
            // 
            // colIdFamiliar_repre_legal
            // 
            this.colIdFamiliar_repre_legal.FieldName = "IdFamiliar_repre_legal";
            this.colIdFamiliar_repre_legal.Name = "colIdFamiliar_repre_legal";
            this.colIdFamiliar_repre_legal.OptionsColumn.AllowEdit = false;
            // 
            // colIdFamiliar_repre_econ
            // 
            this.colIdFamiliar_repre_econ.FieldName = "IdFamiliar_repre_econ";
            this.colIdFamiliar_repre_econ.Name = "colIdFamiliar_repre_econ";
            this.colIdFamiliar_repre_econ.OptionsColumn.AllowEdit = false;
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.OptionsColumn.AllowEdit = false;
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 7;
            // 
            // colSi_estoy_deacuerdo_foto
            // 
            this.colSi_estoy_deacuerdo_foto.FieldName = "Si_estoy_deacuerdo_foto";
            this.colSi_estoy_deacuerdo_foto.Name = "colSi_estoy_deacuerdo_foto";
            this.colSi_estoy_deacuerdo_foto.OptionsColumn.AllowEdit = false;
            // 
            // colNo_estoy_deacuerdo_foto
            // 
            this.colNo_estoy_deacuerdo_foto.FieldName = "No_estoy_deacuerdo_foto";
            this.colNo_estoy_deacuerdo_foto.Name = "colNo_estoy_deacuerdo_foto";
            this.colNo_estoy_deacuerdo_foto.OptionsColumn.AllowEdit = false;
            // 
            // colCod_convivencia_doy_fe
            // 
            this.colCod_convivencia_doy_fe.FieldName = "Cod_convivencia_doy_fe";
            this.colCod_convivencia_doy_fe.Name = "colCod_convivencia_doy_fe";
            this.colCod_convivencia_doy_fe.OptionsColumn.AllowEdit = false;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 8;
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
            // colestudianteInfo
            // 
            this.colestudianteInfo.FieldName = "estudianteInfo";
            this.colestudianteInfo.Name = "colestudianteInfo";
            this.colestudianteInfo.OptionsColumn.AllowEdit = false;
            // 
            // colcursoInfo
            // 
            this.colcursoInfo.FieldName = "cursoInfo";
            this.colcursoInfo.Name = "colcursoInfo";
            this.colcursoInfo.OptionsColumn.AllowEdit = false;
            // 
            // colNombreEstudiante
            // 
            this.colNombreEstudiante.Caption = "Nombre Estudiante";
            this.colNombreEstudiante.FieldName = "estudianteInfo.Persona_Info.pe_nombre";
            this.colNombreEstudiante.Name = "colNombreEstudiante";
            this.colNombreEstudiante.OptionsColumn.AllowEdit = false;
            this.colNombreEstudiante.Visible = true;
            this.colNombreEstudiante.VisibleIndex = 4;
            // 
            // colApellidoEstudiante
            // 
            this.colApellidoEstudiante.Caption = "Apellido Estudiante";
            this.colApellidoEstudiante.FieldName = "estudianteInfo.Persona_Info.pe_apellido";
            this.colApellidoEstudiante.Name = "colApellidoEstudiante";
            this.colApellidoEstudiante.OptionsColumn.AllowEdit = false;
            this.colApellidoEstudiante.Visible = true;
            this.colApellidoEstudiante.VisibleIndex = 5;
            // 
            // colIdJornada
            // 
            this.colIdJornada.FieldName = "IdJornada";
            this.colIdJornada.Name = "colIdJornada";
            this.colIdJornada.OptionsColumn.AllowEdit = false;
            // 
            // colIdMatricula
            // 
            this.colIdMatricula.FieldName = "IdMatricula";
            this.colIdMatricula.Name = "colIdMatricula";
            this.colIdMatricula.OptionsColumn.AllowEdit = false;
            // 
            // colIdSeccion
            // 
            this.colIdSeccion.FieldName = "IdSeccion";
            this.colIdSeccion.Name = "colIdSeccion";
            this.colIdSeccion.OptionsColumn.AllowEdit = false;
            // 
            // colIdSede
            // 
            this.colIdSede.FieldName = "IdSede";
            this.colIdSede.Name = "colIdSede";
            this.colIdSede.OptionsColumn.AllowEdit = false;
            // 
            // FrmAcaMatricula_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 405);
            this.Controls.Add(this.gridControlMatriculaEstudiante);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAcaMatricula_Cons";
            this.Text = "FrmAcaMatricula";
            this.Load += new System.EventHandler(this.FrmAcaMatricula_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMatriculaEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaMatriculaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMatriculaEstudiante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms;
        private DevExpress.XtraGrid.GridControl gridControlMatriculaEstudiante;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMatriculaEstudiante;
        private System.Windows.Forms.BindingSource acaMatriculaInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMatriucla;
        private DevExpress.XtraGrid.Columns.GridColumn colCodMatricula;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaMatricula;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPeriodoLectivo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFamiliar_repre_legal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFamiliar_repre_econ;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colSi_estoy_deacuerdo_foto;
        private DevExpress.XtraGrid.Columns.GridColumn colNo_estoy_deacuerdo_foto;
        private DevExpress.XtraGrid.Columns.GridColumn colCod_convivencia_doy_fe;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colestudianteInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colcursoInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEstudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoEstudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colIdJornada;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMatricula;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSeccion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSede;
    }
}