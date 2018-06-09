namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Solicitud_Vacaciones_Cons
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
            this.rosolicitudPermisoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControlVacaciones = new DevExpress.XtraGrid.GridControl();
            this.gridViewVacaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSolicitudVaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnioServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDias_q_Corresponde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDias_a_disfrutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDias_pendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Desde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Hasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Retorno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario_Anu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_nombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rosolicitudPermisoInfoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVacaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVacaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // rosolicitudPermisoInfoBindingSource
            // 
            this.rosolicitudPermisoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_SolicitudVacaciones_Info);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1072, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 177);
            this.panel1.TabIndex = 14;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 8, 7, 9, 16, 5, 475);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 10, 7, 9, 16, 5, 475);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1072, 175);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick_1);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick_1);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick_1);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick_1);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlVacaciones);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 273);
            this.panel2.TabIndex = 16;
            // 
            // gridControlVacaciones
            // 
            this.gridControlVacaciones.DataSource = this.rosolicitudPermisoInfoBindingSource;
            this.gridControlVacaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlVacaciones.Location = new System.Drawing.Point(0, 0);
            this.gridControlVacaciones.MainView = this.gridViewVacaciones;
            this.gridControlVacaciones.Name = "gridControlVacaciones";
            this.gridControlVacaciones.Size = new System.Drawing.Size(1072, 273);
            this.gridControlVacaciones.TabIndex = 12;
            this.gridControlVacaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVacaciones});
            // 
            // gridViewVacaciones
            // 
            this.gridViewVacaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSolicitudVaca,
            this.colFecha,
            this.colIdEmpleado,
            this.colAnioServicio,
            this.colDias_q_Corresponde,
            this.colDias_a_disfrutar,
            this.colDias_pendiente,
            this.colFecha_Desde,
            this.colFecha_Hasta,
            this.colFecha_Retorno,
            this.colObservacion,
            this.colIdUsuario,
            this.colIdUsuario_Anu,
            this.colFechaAnulacion,
            this.colFecha_Transac,
            this.colFecha_UltMod,
            this.colIdUsuarioUltMod,
            this.colEstado,
            this.colMotivoAnulacion,
            this.colip,
            this.colnom_pc,
            this.colpe_nombreCompleto,
            this.colIdEstadoAprobacion});
            this.gridViewVacaciones.GridControl = this.gridControlVacaciones;
            this.gridViewVacaciones.Name = "gridViewVacaciones";
            this.gridViewVacaciones.OptionsBehavior.Editable = false;
            this.gridViewVacaciones.OptionsBehavior.ReadOnly = true;
            this.gridViewVacaciones.OptionsView.ShowAutoFilterRow = true;
            this.gridViewVacaciones.OptionsView.ShowGroupPanel = false;
            this.gridViewVacaciones.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewVacaciones_RowCellStyle);
            this.gridViewVacaciones.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewVacaciones_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Width = 73;
            // 
            // colIdSolicitudVaca
            // 
            this.colIdSolicitudVaca.Caption = "Id.";
            this.colIdSolicitudVaca.FieldName = "IdSolicitudVaca";
            this.colIdSolicitudVaca.Name = "colIdSolicitudVaca";
            this.colIdSolicitudVaca.OptionsColumn.AllowEdit = false;
            this.colIdSolicitudVaca.Visible = true;
            this.colIdSolicitudVaca.VisibleIndex = 0;
            this.colIdSolicitudVaca.Width = 59;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha Solicitud";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 1;
            this.colFecha.Width = 96;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Width = 78;
            // 
            // colAnioServicio
            // 
            this.colAnioServicio.FieldName = "AnioServicio";
            this.colAnioServicio.Name = "colAnioServicio";
            this.colAnioServicio.Width = 80;
            // 
            // colDias_q_Corresponde
            // 
            this.colDias_q_Corresponde.FieldName = "Dias_q_Corresponde";
            this.colDias_q_Corresponde.Name = "colDias_q_Corresponde";
            this.colDias_q_Corresponde.Width = 119;
            // 
            // colDias_a_disfrutar
            // 
            this.colDias_a_disfrutar.Caption = "Días";
            this.colDias_a_disfrutar.FieldName = "Dias_a_disfrutar";
            this.colDias_a_disfrutar.Name = "colDias_a_disfrutar";
            this.colDias_a_disfrutar.Visible = true;
            this.colDias_a_disfrutar.VisibleIndex = 3;
            this.colDias_a_disfrutar.Width = 50;
            // 
            // colDias_pendiente
            // 
            this.colDias_pendiente.FieldName = "Dias_pendiente";
            this.colDias_pendiente.Name = "colDias_pendiente";
            this.colDias_pendiente.Width = 93;
            // 
            // colFecha_Desde
            // 
            this.colFecha_Desde.Caption = "Fecha Inicial";
            this.colFecha_Desde.FieldName = "Fecha_Desde";
            this.colFecha_Desde.Name = "colFecha_Desde";
            this.colFecha_Desde.OptionsColumn.AllowEdit = false;
            this.colFecha_Desde.Visible = true;
            this.colFecha_Desde.VisibleIndex = 4;
            this.colFecha_Desde.Width = 76;
            // 
            // colFecha_Hasta
            // 
            this.colFecha_Hasta.Caption = "Fecha Final";
            this.colFecha_Hasta.FieldName = "Fecha_Hasta";
            this.colFecha_Hasta.Name = "colFecha_Hasta";
            this.colFecha_Hasta.OptionsColumn.AllowEdit = false;
            this.colFecha_Hasta.Visible = true;
            this.colFecha_Hasta.VisibleIndex = 5;
            this.colFecha_Hasta.Width = 67;
            // 
            // colFecha_Retorno
            // 
            this.colFecha_Retorno.Caption = "Fecha Retorno";
            this.colFecha_Retorno.FieldName = "Fecha_Retorno";
            this.colFecha_Retorno.Name = "colFecha_Retorno";
            this.colFecha_Retorno.Visible = true;
            this.colFecha_Retorno.VisibleIndex = 6;
            this.colFecha_Retorno.Width = 86;
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.OptionsColumn.AllowEdit = false;
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 9;
            this.colObservacion.Width = 267;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Width = 68;
            // 
            // colIdUsuario_Anu
            // 
            this.colIdUsuario_Anu.FieldName = "IdUsuario_Anu";
            this.colIdUsuario_Anu.Name = "colIdUsuario_Anu";
            this.colIdUsuario_Anu.Width = 93;
            // 
            // colFechaAnulacion
            // 
            this.colFechaAnulacion.FieldName = "FechaAnulacion";
            this.colFechaAnulacion.Name = "colFechaAnulacion";
            this.colFechaAnulacion.Width = 97;
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            this.colFecha_Transac.Width = 92;
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            this.colFecha_UltMod.Width = 90;
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            this.colIdUsuarioUltMod.Width = 107;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 7;
            this.colEstado.Width = 66;
            // 
            // colMotivoAnulacion
            // 
            this.colMotivoAnulacion.FieldName = "MotivoAnulacion";
            this.colMotivoAnulacion.Name = "colMotivoAnulacion";
            this.colMotivoAnulacion.Width = 100;
            // 
            // colip
            // 
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            this.colip.Width = 27;
            // 
            // colnom_pc
            // 
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            this.colnom_pc.Width = 96;
            // 
            // colpe_nombreCompleto
            // 
            this.colpe_nombreCompleto.Caption = "Nombre del Empleado";
            this.colpe_nombreCompleto.FieldName = "pe_nombreCompleto";
            this.colpe_nombreCompleto.Name = "colpe_nombreCompleto";
            this.colpe_nombreCompleto.OptionsColumn.AllowEdit = false;
            this.colpe_nombreCompleto.Visible = true;
            this.colpe_nombreCompleto.VisibleIndex = 2;
            this.colpe_nombreCompleto.Width = 312;
            // 
            // colIdEstadoAprobacion
            // 
            this.colIdEstadoAprobacion.Caption = "Estado Solicitud";
            this.colIdEstadoAprobacion.FieldName = "IdEstadoAprobacion";
            this.colIdEstadoAprobacion.Name = "colIdEstadoAprobacion";
            this.colIdEstadoAprobacion.OptionsColumn.AllowEdit = false;
            this.colIdEstadoAprobacion.Visible = true;
            this.colIdEstadoAprobacion.VisibleIndex = 8;
            this.colIdEstadoAprobacion.Width = 101;
            // 
            // frmRo_Solicitud_Vacaciones_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmRo_Solicitud_Vacaciones_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Solicitud de Vacaciones";
            this.Load += new System.EventHandler(this.frmRo_Solicitud_Vacaciones_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rosolicitudPermisoInfoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVacaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVacaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource rosolicitudPermisoInfoBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControlVacaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVacaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudVaca;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colAnioServicio;
        private DevExpress.XtraGrid.Columns.GridColumn colDias_q_Corresponde;
        private DevExpress.XtraGrid.Columns.GridColumn colDias_a_disfrutar;
        private DevExpress.XtraGrid.Columns.GridColumn colDias_pendiente;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Desde;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Hasta;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Retorno;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario_Anu;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_nombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAprobacion;
    }
}