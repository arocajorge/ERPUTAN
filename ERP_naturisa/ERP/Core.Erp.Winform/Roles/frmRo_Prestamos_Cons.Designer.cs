namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Prestamos_Cons
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
            this.gridControlCons = new DevExpress.XtraGrid.GridControl();
            this.gridViewCons = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnIdPrestamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnpe_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMotivoPrestamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTipoPrestamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnInteres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCuotas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTotalPrestamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTotalCobrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSaldoPrestamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMotiAnula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Col_Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCons)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlCons
            // 
            this.gridControlCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCons.Location = new System.Drawing.Point(0, 0);
            this.gridControlCons.MainView = this.gridViewCons;
            this.gridControlCons.Name = "gridControlCons";
            this.gridControlCons.Size = new System.Drawing.Size(874, 243);
            this.gridControlCons.TabIndex = 1;
            this.gridControlCons.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCons});
            // 
            // gridViewCons
            // 
            this.gridViewCons.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnIdPrestamo,
            this.gridColumnpe_nombre,
            this.gridColumnMotivoPrestamo,
            this.gridColumnTipoPrestamo,
            this.gridColumnMonto,
            this.gridColumnInteres,
            this.gridColumnCuotas,
            this.gridColumnFormaPago,
            this.gridColumnTotalPrestamo,
            this.gridColumnTotalCobrado,
            this.gridColumnSaldoPrestamo,
            this.gridColumnEstado,
            this.ColMotiAnula,
            this.ColCedula,
            this.ColObservacion,
            this.Col_Fecha});
            this.gridViewCons.GridControl = this.gridControlCons;
            this.gridViewCons.Name = "gridViewCons";
            this.gridViewCons.OptionsBehavior.ReadOnly = true;
            this.gridViewCons.OptionsFind.AlwaysVisible = true;
            this.gridViewCons.OptionsView.ColumnAutoWidth = false;
            this.gridViewCons.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCons.OptionsView.ShowGroupPanel = false;
            this.gridViewCons.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumnIdPrestamo, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewCons.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewCons_RowCellStyle);
            this.gridViewCons.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCons_FocusedRowChanged_1);
            // 
            // gridColumnIdPrestamo
            // 
            this.gridColumnIdPrestamo.Caption = "# Préstamo";
            this.gridColumnIdPrestamo.FieldName = "IdPrestamo";
            this.gridColumnIdPrestamo.Name = "gridColumnIdPrestamo";
            this.gridColumnIdPrestamo.OptionsColumn.AllowEdit = false;
            this.gridColumnIdPrestamo.Visible = true;
            this.gridColumnIdPrestamo.VisibleIndex = 0;
            this.gridColumnIdPrestamo.Width = 99;
            // 
            // gridColumnpe_nombre
            // 
            this.gridColumnpe_nombre.Caption = "Nombre";
            this.gridColumnpe_nombre.FieldName = "pe_nombre";
            this.gridColumnpe_nombre.Name = "gridColumnpe_nombre";
            this.gridColumnpe_nombre.OptionsColumn.AllowEdit = false;
            this.gridColumnpe_nombre.Visible = true;
            this.gridColumnpe_nombre.VisibleIndex = 2;
            this.gridColumnpe_nombre.Width = 221;
            // 
            // gridColumnMotivoPrestamo
            // 
            this.gridColumnMotivoPrestamo.Caption = "Motivo préstamo";
            this.gridColumnMotivoPrestamo.FieldName = "ca_descripcion";
            this.gridColumnMotivoPrestamo.Name = "gridColumnMotivoPrestamo";
            this.gridColumnMotivoPrestamo.Visible = true;
            this.gridColumnMotivoPrestamo.VisibleIndex = 4;
            this.gridColumnMotivoPrestamo.Width = 111;
            // 
            // gridColumnTipoPrestamo
            // 
            this.gridColumnTipoPrestamo.Caption = "Tipo préstamo";
            this.gridColumnTipoPrestamo.FieldName = "ru_descripcion";
            this.gridColumnTipoPrestamo.Name = "gridColumnTipoPrestamo";
            this.gridColumnTipoPrestamo.Visible = true;
            this.gridColumnTipoPrestamo.VisibleIndex = 5;
            this.gridColumnTipoPrestamo.Width = 96;
            // 
            // gridColumnMonto
            // 
            this.gridColumnMonto.Caption = "Monto solicitado";
            this.gridColumnMonto.FieldName = "MontoSol";
            this.gridColumnMonto.Name = "gridColumnMonto";
            this.gridColumnMonto.Visible = true;
            this.gridColumnMonto.VisibleIndex = 6;
            this.gridColumnMonto.Width = 99;
            // 
            // gridColumnInteres
            // 
            this.gridColumnInteres.Caption = "Interés";
            this.gridColumnInteres.FieldName = "TasaInteres";
            this.gridColumnInteres.Name = "gridColumnInteres";
            this.gridColumnInteres.Width = 60;
            // 
            // gridColumnCuotas
            // 
            this.gridColumnCuotas.Caption = "# de cuotas";
            this.gridColumnCuotas.FieldName = "NumCuotas";
            this.gridColumnCuotas.Name = "gridColumnCuotas";
            this.gridColumnCuotas.Visible = true;
            this.gridColumnCuotas.VisibleIndex = 7;
            this.gridColumnCuotas.Width = 78;
            // 
            // gridColumnFormaPago
            // 
            this.gridColumnFormaPago.Caption = "Forma de pago";
            this.gridColumnFormaPago.FieldName = "peri_pago";
            this.gridColumnFormaPago.Name = "gridColumnFormaPago";
            this.gridColumnFormaPago.Visible = true;
            this.gridColumnFormaPago.VisibleIndex = 8;
            this.gridColumnFormaPago.Width = 107;
            // 
            // gridColumnTotalPrestamo
            // 
            this.gridColumnTotalPrestamo.Caption = "Total Préstamo";
            this.gridColumnTotalPrestamo.FieldName = "TotalPrestamo";
            this.gridColumnTotalPrestamo.Name = "gridColumnTotalPrestamo";
            this.gridColumnTotalPrestamo.OptionsColumn.AllowEdit = false;
            this.gridColumnTotalPrestamo.Visible = true;
            this.gridColumnTotalPrestamo.VisibleIndex = 9;
            this.gridColumnTotalPrestamo.Width = 95;
            // 
            // gridColumnTotalCobrado
            // 
            this.gridColumnTotalCobrado.Caption = "Total cobrado";
            this.gridColumnTotalCobrado.FieldName = "TotalCobrado";
            this.gridColumnTotalCobrado.Name = "gridColumnTotalCobrado";
            this.gridColumnTotalCobrado.Visible = true;
            this.gridColumnTotalCobrado.VisibleIndex = 10;
            this.gridColumnTotalCobrado.Width = 105;
            // 
            // gridColumnSaldoPrestamo
            // 
            this.gridColumnSaldoPrestamo.Caption = "Saldo préstamo";
            this.gridColumnSaldoPrestamo.FieldName = "SaldoPrestamo";
            this.gridColumnSaldoPrestamo.Name = "gridColumnSaldoPrestamo";
            this.gridColumnSaldoPrestamo.Visible = true;
            this.gridColumnSaldoPrestamo.VisibleIndex = 11;
            this.gridColumnSaldoPrestamo.Width = 102;
            // 
            // gridColumnEstado
            // 
            this.gridColumnEstado.Caption = "Estado";
            this.gridColumnEstado.FieldName = "Estado";
            this.gridColumnEstado.Name = "gridColumnEstado";
            this.gridColumnEstado.OptionsColumn.AllowEdit = false;
            this.gridColumnEstado.Width = 59;
            // 
            // ColMotiAnula
            // 
            this.ColMotiAnula.Caption = "Motivo Anula";
            this.ColMotiAnula.FieldName = "MotiAnula";
            this.ColMotiAnula.Name = "ColMotiAnula";
            // 
            // ColCedula
            // 
            this.ColCedula.Caption = "Cedula";
            this.ColCedula.FieldName = "Cedula";
            this.ColCedula.Name = "ColCedula";
            this.ColCedula.Visible = true;
            this.ColCedula.VisibleIndex = 1;
            this.ColCedula.Width = 83;
            // 
            // ColObservacion
            // 
            this.ColObservacion.Caption = "Observacion";
            this.ColObservacion.FieldName = "Observacion";
            this.ColObservacion.Name = "ColObservacion";
            this.ColObservacion.Visible = true;
            this.ColObservacion.VisibleIndex = 3;
            this.ColObservacion.Width = 282;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(874, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 156);
            this.panel1.TabIndex = 8;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2017, 4, 7, 19, 34, 35, 46);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 6, 7, 19, 34, 35, 46);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(874, 155);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlCons);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 243);
            this.panel2.TabIndex = 9;
            // 
            // Col_Fecha
            // 
            this.Col_Fecha.Caption = "Fecha Prestamo";
            this.Col_Fecha.FieldName = "Fecha";
            this.Col_Fecha.Name = "Col_Fecha";
            this.Col_Fecha.Visible = true;
            this.Col_Fecha.VisibleIndex = 12;
            // 
            // frmRo_Prestamos_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 421);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmRo_Prestamos_Cons";
            this.Text = "frmRo_Prestamos_Cons";
            this.Load += new System.EventHandler(this.frmRo_Prestamos_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCons)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCons;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCons;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIdPrestamo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnpe_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTotalPrestamo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEstado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTipoPrestamo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMonto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnInteres;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCuotas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMotivoPrestamo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTotalCobrado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaldoPrestamo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn ColMotiAnula;
        private DevExpress.XtraGrid.Columns.GridColumn ColCedula;
        private DevExpress.XtraGrid.Columns.GridColumn ColObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Fecha;
    }
}