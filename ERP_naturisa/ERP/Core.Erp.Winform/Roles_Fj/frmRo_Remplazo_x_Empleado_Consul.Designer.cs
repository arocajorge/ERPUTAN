namespace Core.Erp.Winform.Roles_Fj
{
    partial class frmRo_Remplazo_x_Empleado_Consul
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl_remplazo_x_empleado = new DevExpress.XtraGrid.GridControl();
            this.gridView_remplado_x_empleado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColId_remplazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFecha_Salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Fecha_Entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colpe_nombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_remplazo_x_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_remplado_x_empleado)).BeginInit();
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2016, 5, 21, 9, 39, 12, 360);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2016, 7, 21, 9, 39, 12, 360);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(896, 180);
            this.ucGe_Menu.TabIndex = 1;
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
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = true;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl_remplazo_x_empleado);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 308);
            this.panel1.TabIndex = 2;
            // 
            // gridControl_remplazo_x_empleado
            // 
            this.gridControl_remplazo_x_empleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_remplazo_x_empleado.Location = new System.Drawing.Point(0, 0);
            this.gridControl_remplazo_x_empleado.MainView = this.gridView_remplado_x_empleado;
            this.gridControl_remplazo_x_empleado.Name = "gridControl_remplazo_x_empleado";
            this.gridControl_remplazo_x_empleado.Size = new System.Drawing.Size(896, 286);
            this.gridControl_remplazo_x_empleado.TabIndex = 1;
            this.gridControl_remplazo_x_empleado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_remplado_x_empleado});
            // 
            // gridView_remplado_x_empleado
            // 
            this.gridView_remplado_x_empleado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColId_remplazo,
            this.ColFecha_Salida,
            this.Col_Fecha_Entrada,
            this.Col_Observacion,
            this.Colpe_nombreCompleto});
            this.gridView_remplado_x_empleado.GridControl = this.gridControl_remplazo_x_empleado;
            this.gridView_remplado_x_empleado.Name = "gridView_remplado_x_empleado";
            this.gridView_remplado_x_empleado.OptionsView.ShowAutoFilterRow = true;
            this.gridView_remplado_x_empleado.OptionsView.ShowGroupPanel = false;
            this.gridView_remplado_x_empleado.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_remplado_x_empleado_RowClick);
            this.gridView_remplado_x_empleado.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView_remplado_x_empleado_RowStyle);
            this.gridView_remplado_x_empleado.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_remplado_x_empleado_FocusedRowChanged);
            // 
            // ColId_remplazo
            // 
            this.ColId_remplazo.Caption = "Id";
            this.ColId_remplazo.FieldName = "Id_remplazo";
            this.ColId_remplazo.Name = "ColId_remplazo";
            this.ColId_remplazo.OptionsColumn.AllowEdit = false;
            this.ColId_remplazo.Visible = true;
            this.ColId_remplazo.VisibleIndex = 0;
            this.ColId_remplazo.Width = 50;
            // 
            // ColFecha_Salida
            // 
            this.ColFecha_Salida.Caption = "Fecha Desde";
            this.ColFecha_Salida.FieldName = "Fecha_Salida";
            this.ColFecha_Salida.Name = "ColFecha_Salida";
            this.ColFecha_Salida.OptionsColumn.AllowEdit = false;
            this.ColFecha_Salida.Visible = true;
            this.ColFecha_Salida.VisibleIndex = 3;
            this.ColFecha_Salida.Width = 111;
            // 
            // Col_Fecha_Entrada
            // 
            this.Col_Fecha_Entrada.Caption = "Fecha Hasta";
            this.Col_Fecha_Entrada.FieldName = "Fecha_Entrada";
            this.Col_Fecha_Entrada.Name = "Col_Fecha_Entrada";
            this.Col_Fecha_Entrada.OptionsColumn.AllowEdit = false;
            this.Col_Fecha_Entrada.Visible = true;
            this.Col_Fecha_Entrada.VisibleIndex = 4;
            this.Col_Fecha_Entrada.Width = 107;
            // 
            // Col_Observacion
            // 
            this.Col_Observacion.Caption = "Observacion";
            this.Col_Observacion.FieldName = "Observacion";
            this.Col_Observacion.Name = "Col_Observacion";
            this.Col_Observacion.OptionsColumn.AllowEdit = false;
            this.Col_Observacion.Visible = true;
            this.Col_Observacion.VisibleIndex = 2;
            this.Col_Observacion.Width = 531;
            // 
            // Colpe_nombreCompleto
            // 
            this.Colpe_nombreCompleto.Caption = "Empleado";
            this.Colpe_nombreCompleto.FieldName = "pe_nombreCompleto";
            this.Colpe_nombreCompleto.Name = "Colpe_nombreCompleto";
            this.Colpe_nombreCompleto.OptionsColumn.AllowEdit = false;
            this.Colpe_nombreCompleto.Visible = true;
            this.Colpe_nombreCompleto.VisibleIndex = 1;
            this.Colpe_nombreCompleto.Width = 381;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 286);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(896, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmRo_Remplazo_x_Empleado_Consul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Remplazo_x_Empleado_Consul";
            this.Text = "frmRo_Remplazo_x_Empleado_Consul";
            this.Load += new System.EventHandler(this.frmRo_Remplazo_x_Empleado_Consul_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_remplazo_x_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_remplado_x_empleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl_remplazo_x_empleado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_remplado_x_empleado;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.Columns.GridColumn ColId_remplazo;
        private DevExpress.XtraGrid.Columns.GridColumn ColFecha_Salida;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Fecha_Entrada;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn Colpe_nombreCompleto;
    }
}