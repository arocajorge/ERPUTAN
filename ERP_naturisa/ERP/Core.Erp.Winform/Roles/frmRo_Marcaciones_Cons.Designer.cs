namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Marcaciones_Cons
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
            this.gridControlMarcacion = new DevExpress.XtraGrid.GridControl();
            this.romarcacionesxempleadoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewMarcacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoMarcaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_Hora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_fechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_anio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_semana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_dia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_sdia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_idDia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_EsActualizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo_Biometrico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexisteerror = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoMarcaciones_Biometrico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMarcacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.romarcacionesxempleadoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMarcacion)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlMarcacion
            // 
            this.gridControlMarcacion.DataSource = this.romarcacionesxempleadoInfoBindingSource;
            this.gridControlMarcacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMarcacion.Location = new System.Drawing.Point(0, 0);
            this.gridControlMarcacion.MainView = this.gridViewMarcacion;
            this.gridControlMarcacion.Name = "gridControlMarcacion";
            this.gridControlMarcacion.Size = new System.Drawing.Size(865, 246);
            this.gridControlMarcacion.TabIndex = 1;
            this.gridControlMarcacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMarcacion});
            // 
            // romarcacionesxempleadoInfoBindingSource
            // 
            this.romarcacionesxempleadoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_marcaciones_x_empleado_Info);
            // 
            // gridViewMarcacion
            // 
            this.gridViewMarcacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdTipoMarcaciones,
            this.coles_Hora,
            this.coles_fechaRegistro,
            this.coles_anio,
            this.coles_mes,
            this.coles_semana,
            this.coles_dia,
            this.coles_sdia,
            this.coles_idDia,
            this.coles_EsActualizacion,
            this.colNomCompleto,
            this.colem_codigo,
            this.colCodigo_Biometrico,
            this.colexisteerror,
            this.colIdTipoMarcaciones_Biometrico,
            this.colIdRegistro,
            this.colnomEmpleado,
            this.ColObservacion,
            this.colcedula});
            this.gridViewMarcacion.GridControl = this.gridControlMarcacion;
            this.gridViewMarcacion.Name = "gridViewMarcacion";
            this.gridViewMarcacion.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMarcacion.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNomCompleto, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewMarcacion.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewMarcacion_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdTipoMarcaciones
            // 
            this.colIdTipoMarcaciones.Caption = "Marcaciones";
            this.colIdTipoMarcaciones.FieldName = "IdTipoMarcaciones";
            this.colIdTipoMarcaciones.Name = "colIdTipoMarcaciones";
            this.colIdTipoMarcaciones.Visible = true;
            this.colIdTipoMarcaciones.VisibleIndex = 4;
            this.colIdTipoMarcaciones.Width = 103;
            // 
            // coles_Hora
            // 
            this.coles_Hora.Caption = "Hora";
            this.coles_Hora.FieldName = "es_Hora";
            this.coles_Hora.Name = "coles_Hora";
            this.coles_Hora.Visible = true;
            this.coles_Hora.VisibleIndex = 9;
            this.coles_Hora.Width = 56;
            // 
            // coles_fechaRegistro
            // 
            this.coles_fechaRegistro.Caption = "Fecha/Registro";
            this.coles_fechaRegistro.FieldName = "es_fechaRegistro";
            this.coles_fechaRegistro.Name = "coles_fechaRegistro";
            this.coles_fechaRegistro.Visible = true;
            this.coles_fechaRegistro.VisibleIndex = 5;
            this.coles_fechaRegistro.Width = 107;
            // 
            // coles_anio
            // 
            this.coles_anio.Caption = "Año";
            this.coles_anio.FieldName = "es_anio";
            this.coles_anio.Name = "coles_anio";
            this.coles_anio.Visible = true;
            this.coles_anio.VisibleIndex = 6;
            this.coles_anio.Width = 56;
            // 
            // coles_mes
            // 
            this.coles_mes.Caption = "Mes";
            this.coles_mes.FieldName = "es_mes";
            this.coles_mes.Name = "coles_mes";
            this.coles_mes.Visible = true;
            this.coles_mes.VisibleIndex = 7;
            this.coles_mes.Width = 68;
            // 
            // coles_semana
            // 
            this.coles_semana.Caption = "Semana";
            this.coles_semana.FieldName = "es_semana";
            this.coles_semana.Name = "coles_semana";
            this.coles_semana.Width = 85;
            // 
            // coles_dia
            // 
            this.coles_dia.Caption = "Dia";
            this.coles_dia.FieldName = "es_dia";
            this.coles_dia.Name = "coles_dia";
            this.coles_dia.Width = 85;
            // 
            // coles_sdia
            // 
            this.coles_sdia.FieldName = "es_sdia";
            this.coles_sdia.Name = "coles_sdia";
            this.coles_sdia.Visible = true;
            this.coles_sdia.VisibleIndex = 8;
            this.coles_sdia.Width = 85;
            // 
            // coles_idDia
            // 
            this.coles_idDia.FieldName = "es_idDia";
            this.coles_idDia.Name = "coles_idDia";
            this.coles_idDia.Width = 85;
            // 
            // coles_EsActualizacion
            // 
            this.coles_EsActualizacion.FieldName = "es_EsActualizacion";
            this.coles_EsActualizacion.Name = "coles_EsActualizacion";
            this.coles_EsActualizacion.Width = 97;
            // 
            // colNomCompleto
            // 
            this.colNomCompleto.FieldName = "NomCompleto";
            this.colNomCompleto.Name = "colNomCompleto";
            this.colNomCompleto.Width = 97;
            // 
            // colem_codigo
            // 
            this.colem_codigo.Caption = "Codigo";
            this.colem_codigo.FieldName = "em_codigo";
            this.colem_codigo.Name = "colem_codigo";
            this.colem_codigo.Visible = true;
            this.colem_codigo.VisibleIndex = 1;
            this.colem_codigo.Width = 79;
            // 
            // colCodigo_Biometrico
            // 
            this.colCodigo_Biometrico.FieldName = "Codigo_Biometrico";
            this.colCodigo_Biometrico.Name = "colCodigo_Biometrico";
            this.colCodigo_Biometrico.Width = 84;
            // 
            // colexisteerror
            // 
            this.colexisteerror.FieldName = "existeerror";
            this.colexisteerror.Name = "colexisteerror";
            this.colexisteerror.Width = 52;
            // 
            // colIdTipoMarcaciones_Biometrico
            // 
            this.colIdTipoMarcaciones_Biometrico.FieldName = "IdTipoMarcaciones_Biometrico";
            this.colIdTipoMarcaciones_Biometrico.Name = "colIdTipoMarcaciones_Biometrico";
            // 
            // colIdRegistro
            // 
            this.colIdRegistro.Caption = "IdRegistro";
            this.colIdRegistro.FieldName = "IdRegistro";
            this.colIdRegistro.Name = "colIdRegistro";
            this.colIdRegistro.Visible = true;
            this.colIdRegistro.VisibleIndex = 0;
            this.colIdRegistro.Width = 119;
            // 
            // colnomEmpleado
            // 
            this.colnomEmpleado.Caption = "Empleado";
            this.colnomEmpleado.FieldName = "NomCompleto";
            this.colnomEmpleado.Name = "colnomEmpleado";
            this.colnomEmpleado.Visible = true;
            this.colnomEmpleado.VisibleIndex = 3;
            this.colnomEmpleado.Width = 274;
            // 
            // ColObservacion
            // 
            this.ColObservacion.Caption = "Observacion";
            this.ColObservacion.FieldName = "Observacion";
            this.ColObservacion.Name = "ColObservacion";
            this.ColObservacion.Visible = true;
            this.ColObservacion.VisibleIndex = 10;
            this.ColObservacion.Width = 182;
            // 
            // colcedula
            // 
            this.colcedula.Caption = "Cedula";
            this.colcedula.FieldName = "cedula";
            this.colcedula.Name = "colcedula";
            this.colcedula.Visible = true;
            this.colcedula.VisibleIndex = 2;
            this.colcedula.Width = 95;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlMarcacion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 246);
            this.panel2.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 401);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(865, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 11, 3, 15, 12, 0, 386);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 1, 3, 15, 12, 0, 387);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(865, 155);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 10;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Always;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnDescargar_Marca_Base_exter_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnDescargar_Marca_Base_exter_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnDescargar_Marca_Base_exter_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // frmRo_Marcaciones_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmRo_Marcaciones_Cons";
            this.Text = "Marcaciones";
            this.Load += new System.EventHandler(this.frmRo_Marcaciones_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMarcacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.romarcacionesxempleadoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMarcacion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMarcacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMarcacion;
        private System.Windows.Forms.BindingSource romarcacionesxempleadoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMarcaciones;
        private DevExpress.XtraGrid.Columns.GridColumn coles_Hora;
        private DevExpress.XtraGrid.Columns.GridColumn coles_fechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn coles_anio;
        private DevExpress.XtraGrid.Columns.GridColumn coles_mes;
        private DevExpress.XtraGrid.Columns.GridColumn coles_semana;
        private DevExpress.XtraGrid.Columns.GridColumn coles_dia;
        private DevExpress.XtraGrid.Columns.GridColumn coles_sdia;
        private DevExpress.XtraGrid.Columns.GridColumn coles_idDia;
        private DevExpress.XtraGrid.Columns.GridColumn coles_EsActualizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNomCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colem_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo_Biometrico;
        private DevExpress.XtraGrid.Columns.GridColumn colexisteerror;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMarcaciones_Biometrico;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRegistro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colnomEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn ColObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcedula;
    }
}