namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Pedido_consu
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlPedido = new DevExpress.XtraGrid.GridControl();
            this.gridViewPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cp_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cp_diasPlazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cp_fechaVencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cp_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstadoAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xtraTabControl_data = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_Data = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage_grafic = new DevExpress.XtraTab.XtraTabPage();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_data)).BeginInit();
            this.xtraTabControl_data.SuspendLayout();
            this.xtraTabPage_Data.SuspendLayout();
            this.xtraTabPage_grafic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Core.Erp.Info.Facturacion.fa_pedido_Info);
            // 
            // gridControlPedido
            // 
            this.gridControlPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPedido.Location = new System.Drawing.Point(0, 0);
            this.gridControlPedido.MainView = this.gridViewPedidos;
            this.gridControlPedido.Name = "gridControlPedido";
            this.gridControlPedido.Size = new System.Drawing.Size(945, 319);
            this.gridControlPedido.TabIndex = 8;
            this.gridControlPedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPedidos});
            // 
            // gridViewPedidos
            // 
            this.gridViewPedidos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sucursal,
            this.Bodega,
            this.IdPedido,
            this.Cliente,
            this.Vendedor,
            this.cp_fecha,
            this.cp_diasPlazo,
            this.cp_fechaVencimiento,
            this.cp_observacion,
            this.EstadoAprobacion,
            this.Estado,
            this.subtotal,
            this.total});
            this.gridViewPedidos.GridControl = this.gridControlPedido;
            this.gridViewPedidos.Name = "gridViewPedidos";
            this.gridViewPedidos.OptionsBehavior.Editable = false;
            this.gridViewPedidos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPedidos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewPedidos_RowClick);
            this.gridViewPedidos.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewPedidos_RowStyle);
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 0;
            // 
            // Bodega
            // 
            this.Bodega.Caption = "Bodega";
            this.Bodega.FieldName = "Bodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.Visible = true;
            this.Bodega.VisibleIndex = 1;
            // 
            // IdPedido
            // 
            this.IdPedido.Caption = "IdPedido";
            this.IdPedido.FieldName = "IdPedido";
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.Visible = true;
            this.IdPedido.VisibleIndex = 2;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 3;
            // 
            // Vendedor
            // 
            this.Vendedor.Caption = "Vendedor";
            this.Vendedor.FieldName = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Visible = true;
            this.Vendedor.VisibleIndex = 4;
            // 
            // cp_fecha
            // 
            this.cp_fecha.Caption = "Fecha";
            this.cp_fecha.FieldName = "cp_fecha";
            this.cp_fecha.Name = "cp_fecha";
            this.cp_fecha.Visible = true;
            this.cp_fecha.VisibleIndex = 5;
            // 
            // cp_diasPlazo
            // 
            this.cp_diasPlazo.Caption = "Dias Plazo";
            this.cp_diasPlazo.FieldName = "cp_diasPlazo";
            this.cp_diasPlazo.Name = "cp_diasPlazo";
            this.cp_diasPlazo.Visible = true;
            this.cp_diasPlazo.VisibleIndex = 6;
            // 
            // cp_fechaVencimiento
            // 
            this.cp_fechaVencimiento.Caption = "Fecha Vencimiento";
            this.cp_fechaVencimiento.FieldName = "cp_fechaVencimiento";
            this.cp_fechaVencimiento.Name = "cp_fechaVencimiento";
            this.cp_fechaVencimiento.Visible = true;
            this.cp_fechaVencimiento.VisibleIndex = 7;
            // 
            // cp_observacion
            // 
            this.cp_observacion.Caption = "Observacion";
            this.cp_observacion.FieldName = "cp_observacion";
            this.cp_observacion.Name = "cp_observacion";
            this.cp_observacion.Visible = true;
            this.cp_observacion.VisibleIndex = 8;
            // 
            // EstadoAprobacion
            // 
            this.EstadoAprobacion.Caption = "Estado Aprobacion";
            this.EstadoAprobacion.FieldName = "EstadoAprobacion";
            this.EstadoAprobacion.Name = "EstadoAprobacion";
            this.EstadoAprobacion.Visible = true;
            this.EstadoAprobacion.VisibleIndex = 9;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 10;
            // 
            // subtotal
            // 
            this.subtotal.Caption = "subtotal";
            this.subtotal.FieldName = "dp_subtotal";
            this.subtotal.GroupFormat.FormatString = "n2";
            this.subtotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.subtotal.Name = "subtotal";
            this.subtotal.Visible = true;
            this.subtotal.VisibleIndex = 11;
            // 
            // total
            // 
            this.total.Caption = "total";
            this.total.FieldName = "dp_total";
            this.total.GroupFormat.FormatString = "n2";
            this.total.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.total.Name = "total";
            this.total.Visible = true;
            this.total.VisibleIndex = 12;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 12, 20, 14, 16, 47, 983);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 2, 20, 14, 16, 47, 983);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(973, 158);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 11;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = true;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xtraTabControl_data);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 325);
            this.panel2.TabIndex = 12;
            // 
            // xtraTabControl_data
            // 
            this.xtraTabControl_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl_data.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl_data.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Vertical;
            this.xtraTabControl_data.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl_data.Name = "xtraTabControl_data";
            this.xtraTabControl_data.SelectedTabPage = this.xtraTabPage_Data;
            this.xtraTabControl_data.Size = new System.Drawing.Size(973, 325);
            this.xtraTabControl_data.TabIndex = 9;
            this.xtraTabControl_data.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_Data,
            this.xtraTabPage_grafic});
            // 
            // xtraTabPage_Data
            // 
            this.xtraTabPage_Data.Controls.Add(this.gridControlPedido);
            this.xtraTabPage_Data.Name = "xtraTabPage_Data";
            this.xtraTabPage_Data.Size = new System.Drawing.Size(945, 319);
            this.xtraTabPage_Data.Text = "Datos";
            // 
            // xtraTabPage_grafic
            // 
            this.xtraTabPage_grafic.Controls.Add(this.chartControl1);
            this.xtraTabPage_grafic.Name = "xtraTabPage_grafic";
            this.xtraTabPage_grafic.Size = new System.Drawing.Size(945, 319);
            this.xtraTabPage_grafic.Text = "grafico";
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.DataSource = this.bindingSource1;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Location = new System.Drawing.Point(0, 3);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Sucursal";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "EstadoAprobacion";
            sideBySideBarSeriesLabel1.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "TOTAL";
            this.chartControl1.Size = new System.Drawing.Size(938, 267);
            this.chartControl1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(973, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmFa_Pedido_consu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 483);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmFa_Pedido_consu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Pedidos";
            this.Load += new System.EventHandler(this.frmFA_Pedido_General_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_data)).EndInit();
            this.xtraTabControl_data.ResumeLayout(false);
            this.xtraTabPage_Data.ResumeLayout(false);
            this.xtraTabPage_grafic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlPedido;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPedidos;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn IdPedido;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraGrid.Columns.GridColumn cp_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn cp_diasPlazo;
        private DevExpress.XtraGrid.Columns.GridColumn cp_fechaVencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn cp_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn EstadoAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl_data;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_Data;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_grafic;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn total;
    }
}