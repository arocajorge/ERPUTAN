namespace Core.Erp.Winform.Roles_Fj
{
    partial class frmRo_Empleado_x_Turno_Consu
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
            this.gridControl_Planificacion = new DevExpress.XtraGrid.GridControl();
            this.gridView_Planificacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_IdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Observación = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Esta_Proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pe_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Planificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Planificacion)).BeginInit();
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2016, 9, 5, 11, 25, 36, 654);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2016, 11, 5, 11, 25, 36, 654);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(763, 183);
            this.ucGe_Menu.TabIndex = 4;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = true;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = false;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_event_btnAnular_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            this.ucGe_Menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_event_btnBuscar_Click);
            // 
            // gridControl_Planificacion
            // 
            this.gridControl_Planificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Planificacion.Location = new System.Drawing.Point(0, 183);
            this.gridControl_Planificacion.MainView = this.gridView_Planificacion;
            this.gridControl_Planificacion.Name = "gridControl_Planificacion";
            this.gridControl_Planificacion.Size = new System.Drawing.Size(763, 265);
            this.gridControl_Planificacion.TabIndex = 5;
            this.gridControl_Planificacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Planificacion});
            // 
            // gridView_Planificacion
            // 
            this.gridView_Planificacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_IdPeriodo,
            this.Col_Observación,
            this.Col_Esta_Proceso,
            this.col_pe_descripcion});
            this.gridView_Planificacion.GridControl = this.gridControl_Planificacion;
            this.gridView_Planificacion.Name = "gridView_Planificacion";
            this.gridView_Planificacion.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Planificacion.OptionsView.ShowGroupPanel = false;
            this.gridView_Planificacion.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Planificacion_RowClick);
            // 
            // Col_IdPeriodo
            // 
            this.Col_IdPeriodo.Caption = "Id Periodo";
            this.Col_IdPeriodo.FieldName = "IdPeriodo";
            this.Col_IdPeriodo.Name = "Col_IdPeriodo";
            this.Col_IdPeriodo.Visible = true;
            this.Col_IdPeriodo.VisibleIndex = 0;
            this.Col_IdPeriodo.Width = 73;
            // 
            // Col_Observación
            // 
            this.Col_Observación.Caption = "Observaccion";
            this.Col_Observación.FieldName = "Observación";
            this.Col_Observación.Name = "Col_Observación";
            this.Col_Observación.Visible = true;
            this.Col_Observación.VisibleIndex = 2;
            this.Col_Observación.Width = 565;
            // 
            // Col_Esta_Proceso
            // 
            this.Col_Esta_Proceso.Caption = "Estado";
            this.Col_Esta_Proceso.FieldName = "Esta_Proceso";
            this.Col_Esta_Proceso.Name = "Col_Esta_Proceso";
            this.Col_Esta_Proceso.Visible = true;
            this.Col_Esta_Proceso.VisibleIndex = 3;
            this.Col_Esta_Proceso.Width = 161;
            // 
            // col_pe_descripcion
            // 
            this.col_pe_descripcion.Caption = "Periodo";
            this.col_pe_descripcion.FieldName = "pe_descripcion";
            this.col_pe_descripcion.Name = "col_pe_descripcion";
            this.col_pe_descripcion.Visible = true;
            this.col_pe_descripcion.VisibleIndex = 1;
            this.col_pe_descripcion.Width = 362;
            // 
            // frmRo_Empleado_x_Turno_Consu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 448);
            this.Controls.Add(this.gridControl_Planificacion);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Empleado_x_Turno_Consu";
            this.Text = "frmRo_Empleado_x_Turno_Consu";
            this.Load += new System.EventHandler(this.frmRo_Empleado_x_Turno_Consu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Planificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Planificacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraGrid.GridControl gridControl_Planificacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Planificacion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Observación;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Esta_Proceso;
        private DevExpress.XtraGrid.Columns.GridColumn col_pe_descripcion;
    }
}