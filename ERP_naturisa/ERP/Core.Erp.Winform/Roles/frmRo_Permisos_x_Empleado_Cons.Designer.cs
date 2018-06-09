namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Permisos_x_Empleado_Cons
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
            this.gridControlPermiso = new DevExpress.XtraGrid.GridControl();
            this.ropermisoxempleadoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridViewPermiso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPermiso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoAusencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiempoAusencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormaRecuperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado_Soli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAprob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado_Apro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoAproba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario_Anu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreAprobo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTomarEnCuentaParaVacaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colem_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colpe_CedRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_FechaSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_FechaEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ropermisoxempleadoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlPermiso
            // 
            this.gridControlPermiso.DataSource = this.ropermisoxempleadoInfoBindingSource;
            this.gridControlPermiso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPermiso.Location = new System.Drawing.Point(0, 0);
            this.gridControlPermiso.MainView = this.gridViewPermiso;
            this.gridControlPermiso.Name = "gridControlPermiso";
            this.gridControlPermiso.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControlPermiso.Size = new System.Drawing.Size(992, 185);
            this.gridControlPermiso.TabIndex = 11;
            this.gridControlPermiso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPermiso});
            // 
            // ropermisoxempleadoInfoBindingSource
            // 
            this.ropermisoxempleadoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_permiso_x_empleado_Info);
            // 
            // gridViewPermiso
            // 
            this.gridViewPermiso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdPermiso,
            this.colFecha,
            this.colIdEmpleado,
            this.colMotivoAusencia,
            this.colTiempoAusencia,
            this.colFormaRecuperacion,
            this.colIdEmpleado_Soli,
            this.colIdEstadoAprob,
            this.colIdEmpleado_Apro,
            this.colMotivoAproba,
            this.colObservacion,
            this.colEstado,
            this.colIdUsuario,
            this.colIdUsuario_Anu,
            this.colFechaAnulacion,
            this.colFecha_Transac,
            this.colFecha_UltMod,
            this.colIdUsuarioUltMod,
            this.colip,
            this.colnom_pc,
            this.colMotivoAnulacion,
            this.colNombre,
            this.colNombreAprobo,
            this.colTomarEnCuentaParaVacaciones,
            this.Colem_codigo,
            this.Colpe_CedRuc,
            this.Col_FechaSalida,
            this.Col_FechaEntrada});
            this.gridViewPermiso.GridControl = this.gridControlPermiso;
            this.gridViewPermiso.Name = "gridViewPermiso";
            this.gridViewPermiso.OptionsBehavior.Editable = false;
            this.gridViewPermiso.OptionsBehavior.ReadOnly = true;
            this.gridViewPermiso.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPermiso.OptionsView.ShowGroupPanel = false;
            this.gridViewPermiso.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdEstadoAprob, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewPermiso.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewPermiso_RowCellStyle);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            // 
            // colIdPermiso
            // 
            this.colIdPermiso.Caption = "No.Permiso";
            this.colIdPermiso.FieldName = "IdPermiso";
            this.colIdPermiso.Name = "colIdPermiso";
            this.colIdPermiso.OptionsColumn.AllowEdit = false;
            this.colIdPermiso.Visible = true;
            this.colIdPermiso.VisibleIndex = 0;
            this.colIdPermiso.Width = 69;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 4;
            this.colFecha.Width = 73;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Width = 78;
            // 
            // colMotivoAusencia
            // 
            this.colMotivoAusencia.Caption = "Motivo";
            this.colMotivoAusencia.FieldName = "MotivoAusencia";
            this.colMotivoAusencia.Name = "colMotivoAusencia";
            this.colMotivoAusencia.Visible = true;
            this.colMotivoAusencia.VisibleIndex = 5;
            this.colMotivoAusencia.Width = 95;
            // 
            // colTiempoAusencia
            // 
            this.colTiempoAusencia.FieldName = "TiempoAusencia";
            this.colTiempoAusencia.Name = "colTiempoAusencia";
            this.colTiempoAusencia.Visible = true;
            this.colTiempoAusencia.VisibleIndex = 6;
            this.colTiempoAusencia.Width = 111;
            // 
            // colFormaRecuperacion
            // 
            this.colFormaRecuperacion.FieldName = "FormaRecuperacion";
            this.colFormaRecuperacion.Name = "colFormaRecuperacion";
            this.colFormaRecuperacion.Visible = true;
            this.colFormaRecuperacion.VisibleIndex = 7;
            this.colFormaRecuperacion.Width = 99;
            // 
            // colIdEmpleado_Soli
            // 
            this.colIdEmpleado_Soli.FieldName = "IdEmpleado_Soli";
            this.colIdEmpleado_Soli.Name = "colIdEmpleado_Soli";
            this.colIdEmpleado_Soli.Width = 76;
            // 
            // colIdEstadoAprob
            // 
            this.colIdEstadoAprob.FieldName = "IdEstadoAprob";
            this.colIdEstadoAprob.Name = "colIdEstadoAprob";
            this.colIdEstadoAprob.Width = 64;
            // 
            // colIdEmpleado_Apro
            // 
            this.colIdEmpleado_Apro.FieldName = "IdEmpleado_Apro";
            this.colIdEmpleado_Apro.Name = "colIdEmpleado_Apro";
            this.colIdEmpleado_Apro.Width = 57;
            // 
            // colMotivoAproba
            // 
            this.colMotivoAproba.FieldName = "MotivoAproba";
            this.colMotivoAproba.Name = "colMotivoAproba";
            this.colMotivoAproba.Width = 83;
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Width = 79;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 52;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Width = 20;
            // 
            // colIdUsuario_Anu
            // 
            this.colIdUsuario_Anu.FieldName = "IdUsuario_Anu";
            this.colIdUsuario_Anu.Name = "colIdUsuario_Anu";
            this.colIdUsuario_Anu.Width = 20;
            // 
            // colFechaAnulacion
            // 
            this.colFechaAnulacion.FieldName = "FechaAnulacion";
            this.colFechaAnulacion.Name = "colFechaAnulacion";
            this.colFechaAnulacion.Width = 20;
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            this.colFecha_Transac.Width = 20;
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            this.colFecha_UltMod.Width = 20;
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            this.colIdUsuarioUltMod.Width = 20;
            // 
            // colip
            // 
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            this.colip.Width = 20;
            // 
            // colnom_pc
            // 
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            this.colnom_pc.Width = 20;
            // 
            // colMotivoAnulacion
            // 
            this.colMotivoAnulacion.FieldName = "MotivoAnulacion";
            this.colMotivoAnulacion.Name = "colMotivoAnulacion";
            this.colMotivoAnulacion.Width = 20;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombres";
            this.colNombre.FieldName = "pe_nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 3;
            this.colNombre.Width = 201;
            // 
            // colNombreAprobo
            // 
            this.colNombreAprobo.Caption = "Aprobado por";
            this.colNombreAprobo.FieldName = "NombreAprobo";
            this.colNombreAprobo.Name = "colNombreAprobo";
            this.colNombreAprobo.OptionsColumn.AllowEdit = false;
            this.colNombreAprobo.Width = 170;
            // 
            // colTomarEnCuentaParaVacaciones
            // 
            this.colTomarEnCuentaParaVacaciones.FieldName = "TomarEnCuentaParaVacaciones";
            this.colTomarEnCuentaParaVacaciones.Name = "colTomarEnCuentaParaVacaciones";
            this.colTomarEnCuentaParaVacaciones.OptionsColumn.AllowEdit = false;
            // 
            // Colem_codigo
            // 
            this.Colem_codigo.Caption = "Codigo";
            this.Colem_codigo.FieldName = "em_codigo";
            this.Colem_codigo.Name = "Colem_codigo";
            this.Colem_codigo.OptionsColumn.AllowEdit = false;
            this.Colem_codigo.Visible = true;
            this.Colem_codigo.VisibleIndex = 1;
            // 
            // Colpe_CedRuc
            // 
            this.Colpe_CedRuc.Caption = "Cedula";
            this.Colpe_CedRuc.FieldName = "pe_cedulaRuc";
            this.Colpe_CedRuc.Name = "Colpe_CedRuc";
            this.Colpe_CedRuc.OptionsColumn.AllowEdit = false;
            this.Colpe_CedRuc.Visible = true;
            this.Colpe_CedRuc.VisibleIndex = 2;
            // 
            // Col_FechaSalida
            // 
            this.Col_FechaSalida.Caption = "Fecha Salida";
            this.Col_FechaSalida.FieldName = "FechaSalida";
            this.Col_FechaSalida.Name = "Col_FechaSalida";
            this.Col_FechaSalida.Visible = true;
            this.Col_FechaSalida.VisibleIndex = 8;
            // 
            // Col_FechaEntrada
            // 
            this.Col_FechaEntrada.Caption = "Fecha Entrada";
            this.Col_FechaEntrada.FieldName = "FechaEntrada";
            this.Col_FechaEntrada.Name = "Col_FechaEntrada";
            this.Col_FechaEntrada.Visible = true;
            this.Col_FechaEntrada.VisibleIndex = 9;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 332);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 147);
            this.panel1.TabIndex = 13;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasSucursales = true;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2017, 4, 24, 14, 32, 10, 535);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 6, 24, 14, 32, 10, 535);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(992, 144);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlPermiso);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 185);
            this.panel2.TabIndex = 14;
            // 
            // frmRo_Permisos_x_Empleado_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 354);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmRo_Permisos_x_Empleado_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Permisos";
            this.Load += new System.EventHandler(this.frmRo_Permisos_x_Empleado_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ropermisoxempleadoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlPermiso;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPermiso;
        private System.Windows.Forms.BindingSource ropermisoxempleadoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPermiso;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoAusencia;
        private DevExpress.XtraGrid.Columns.GridColumn colTiempoAusencia;
        private DevExpress.XtraGrid.Columns.GridColumn colFormaRecuperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado_Soli;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAprob;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado_Apro;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoAproba;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario_Anu;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoAnulacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreAprobo;
        private DevExpress.XtraGrid.Columns.GridColumn colTomarEnCuentaParaVacaciones;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn Colem_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Colpe_CedRuc;
        private DevExpress.XtraGrid.Columns.GridColumn Col_FechaSalida;
        private DevExpress.XtraGrid.Columns.GridColumn Col_FechaEntrada;
    }
}