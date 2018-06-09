namespace Core.Erp.Winform.Facturacion_Grafinpren
{
    partial class frmfa_Equipo_graf_Cons
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
            this.ucGe_Menu_Mantenimiento_x_usuario1 = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gc_Equipo = new DevExpress.XtraGrid.GridControl();
            this.gw_Equipo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdEquipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_Equipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Fecha_Transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUsuarioUltModi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Fecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Fecha_UltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_MotivoAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ip = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Equipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_Equipo)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario1
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde = new System.DateTime(2016, 4, 25, 18, 40, 7, 3);
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta = new System.DateTime(2016, 6, 25, 18, 40, 7, 3);
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario1.Name = "ucGe_Menu_Mantenimiento_x_usuario1";
            this.ucGe_Menu_Mantenimiento_x_usuario1.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Size = new System.Drawing.Size(802, 158);
            this.ucGe_Menu_Mantenimiento_x_usuario1.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 435);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(802, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // gc_Equipo
            // 
            this.gc_Equipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Equipo.Location = new System.Drawing.Point(0, 158);
            this.gc_Equipo.MainView = this.gw_Equipo;
            this.gc_Equipo.Name = "gc_Equipo";
            this.gc_Equipo.Size = new System.Drawing.Size(802, 277);
            this.gc_Equipo.TabIndex = 2;
            this.gc_Equipo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gw_Equipo});
            // 
            // gw_Equipo
            // 
            this.gw_Equipo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdEquipo,
            this.col_nom_Equipo,
            this.col_estado,
            this.col_IdUsuario,
            this.col_Fecha_Transaccion,
            this.col_IdUsuarioUltModi,
            this.col_Fecha_UltMod,
            this.col_IdUsuarioUltAnu,
            this.col_Fecha_UltAnu,
            this.col_MotivoAnulacion,
            this.col_nom_pc,
            this.col_ip});
            this.gw_Equipo.GridControl = this.gc_Equipo;
            this.gw_Equipo.Name = "gw_Equipo";
            this.gw_Equipo.OptionsBehavior.ReadOnly = true;
            this.gw_Equipo.OptionsView.ShowAutoFilterRow = true;
            this.gw_Equipo.OptionsView.ShowGroupPanel = false;
            this.gw_Equipo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gw_Equipo_RowCellStyle);
            this.gw_Equipo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gw_Equipo_FocusedRowChanged);
            // 
            // col_IdEquipo
            // 
            this.col_IdEquipo.Caption = "IdEquipo";
            this.col_IdEquipo.FieldName = "IdEquipo";
            this.col_IdEquipo.Name = "col_IdEquipo";
            this.col_IdEquipo.Visible = true;
            this.col_IdEquipo.VisibleIndex = 0;
            this.col_IdEquipo.Width = 89;
            // 
            // col_nom_Equipo
            // 
            this.col_nom_Equipo.Caption = "Nombre Equipo";
            this.col_nom_Equipo.FieldName = "nom_Equipo";
            this.col_nom_Equipo.Name = "col_nom_Equipo";
            this.col_nom_Equipo.Visible = true;
            this.col_nom_Equipo.VisibleIndex = 1;
            this.col_nom_Equipo.Width = 925;
            // 
            // col_estado
            // 
            this.col_estado.Caption = "Estado";
            this.col_estado.FieldName = "estado";
            this.col_estado.Name = "col_estado";
            this.col_estado.Visible = true;
            this.col_estado.VisibleIndex = 2;
            this.col_estado.Width = 127;
            // 
            // col_IdUsuario
            // 
            this.col_IdUsuario.Caption = "IdUsuario";
            this.col_IdUsuario.FieldName = "IdUsuario";
            this.col_IdUsuario.Name = "col_IdUsuario";
            // 
            // col_Fecha_Transaccion
            // 
            this.col_Fecha_Transaccion.Caption = "Fecha_Transaccion";
            this.col_Fecha_Transaccion.FieldName = "Fecha_Transaccion";
            this.col_Fecha_Transaccion.Name = "col_Fecha_Transaccion";
            // 
            // col_IdUsuarioUltModi
            // 
            this.col_IdUsuarioUltModi.Caption = "IdUsuarioUltModi";
            this.col_IdUsuarioUltModi.FieldName = "IdUsuarioUltModi";
            this.col_IdUsuarioUltModi.Name = "col_IdUsuarioUltModi";
            // 
            // col_Fecha_UltMod
            // 
            this.col_Fecha_UltMod.Caption = "Fecha_UltMod";
            this.col_Fecha_UltMod.FieldName = "Fecha_UltMod";
            this.col_Fecha_UltMod.Name = "col_Fecha_UltMod";
            // 
            // col_IdUsuarioUltAnu
            // 
            this.col_IdUsuarioUltAnu.Caption = "IdUsuarioUltAnu";
            this.col_IdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.col_IdUsuarioUltAnu.Name = "col_IdUsuarioUltAnu";
            // 
            // col_Fecha_UltAnu
            // 
            this.col_Fecha_UltAnu.Caption = "Fecha_UltAnu";
            this.col_Fecha_UltAnu.FieldName = "Fecha_UltAnu";
            this.col_Fecha_UltAnu.Name = "col_Fecha_UltAnu";
            // 
            // col_MotivoAnulacion
            // 
            this.col_MotivoAnulacion.Caption = "MotivoAnulacion";
            this.col_MotivoAnulacion.FieldName = "MotivoAnulacion";
            this.col_MotivoAnulacion.Name = "col_MotivoAnulacion";
            // 
            // col_nom_pc
            // 
            this.col_nom_pc.Caption = "nom_pc";
            this.col_nom_pc.FieldName = "nom_pc";
            this.col_nom_pc.Name = "col_nom_pc";
            // 
            // col_ip
            // 
            this.col_ip.Caption = "ip";
            this.col_ip.FieldName = "ip";
            this.col_ip.Name = "col_ip";
            // 
            // frmfa_Equipo_graf_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 461);
            this.Controls.Add(this.gc_Equipo);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario1);
            this.Name = "frmfa_Equipo_graf_Cons";
            this.Text = "frmfa_Equipo_graf_Cons";
            this.Load += new System.EventHandler(this.frmfa_Equipo_graf_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Equipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_Equipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl gc_Equipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gw_Equipo;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdEquipo;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_Equipo;
        private DevExpress.XtraGrid.Columns.GridColumn col_estado;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn col_Fecha_Transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUsuarioUltModi;
        private DevExpress.XtraGrid.Columns.GridColumn col_Fecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn col_Fecha_UltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn col_MotivoAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn col_ip;
    }
}