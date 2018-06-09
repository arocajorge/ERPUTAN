namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Cotizacion_Consulta
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gridConsultaCot = new DevExpress.XtraGrid.GridControl();
            this.gridViewConsultaCot = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cotizacionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cc_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cc_fechaVencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cc_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cc_dirigidoA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cc_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodCotizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Mantenimiento = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel_central = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaCot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsultaCot)).BeginInit();
            this.panel_central.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gridConsultaCot
            // 
            this.gridConsultaCot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsultaCot.Location = new System.Drawing.Point(0, 0);
            this.gridConsultaCot.MainView = this.gridViewConsultaCot;
            this.gridConsultaCot.Name = "gridConsultaCot";
            this.gridConsultaCot.Size = new System.Drawing.Size(1021, 243);
            this.gridConsultaCot.TabIndex = 5;
            this.gridConsultaCot.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsultaCot});
            // 
            // gridViewConsultaCot
            // 
            this.gridViewConsultaCot.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sucursal,
            this.Bodega,
            this.cotizacionId,
            this.cc_fecha,
            this.cc_fechaVencimiento,
            this.Cliente,
            this.Vendedor,
            this.cc_observacion,
            this.cc_dirigidoA,
            this.subtotal,
            this.iva,
            this.total,
            this.cc_estado,
            this.CodCotizacion,
            this.IdSucursal,
            this.IdBodega});
            this.gridViewConsultaCot.GridControl = this.gridConsultaCot;
            this.gridViewConsultaCot.Name = "gridViewConsultaCot";
            this.gridViewConsultaCot.OptionsBehavior.Editable = false;
            this.gridViewConsultaCot.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsultaCot.OptionsView.ShowGroupPanel = false;
            this.gridViewConsultaCot.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.cotizacionId, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 0;
            this.Sucursal.Width = 66;
            // 
            // Bodega
            // 
            this.Bodega.Caption = "Bodega";
            this.Bodega.FieldName = "Bodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.Visible = true;
            this.Bodega.VisibleIndex = 1;
            this.Bodega.Width = 66;
            // 
            // cotizacionId
            // 
            this.cotizacionId.Caption = "# Cotizacion";
            this.cotizacionId.FieldName = "IdCotizacion";
            this.cotizacionId.Name = "cotizacionId";
            this.cotizacionId.Visible = true;
            this.cotizacionId.VisibleIndex = 2;
            this.cotizacionId.Width = 66;
            // 
            // cc_fecha
            // 
            this.cc_fecha.Caption = "Fecha";
            this.cc_fecha.FieldName = "cc_fecha";
            this.cc_fecha.Name = "cc_fecha";
            this.cc_fecha.Visible = true;
            this.cc_fecha.VisibleIndex = 4;
            this.cc_fecha.Width = 46;
            // 
            // cc_fechaVencimiento
            // 
            this.cc_fechaVencimiento.Caption = "Fecha Vencimiento";
            this.cc_fechaVencimiento.FieldName = "cc_fechaVencimiento";
            this.cc_fechaVencimiento.Name = "cc_fechaVencimiento";
            this.cc_fechaVencimiento.Visible = true;
            this.cc_fechaVencimiento.VisibleIndex = 5;
            this.cc_fechaVencimiento.Width = 67;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 6;
            this.Cliente.Width = 67;
            // 
            // Vendedor
            // 
            this.Vendedor.Caption = "Vendedor";
            this.Vendedor.FieldName = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Visible = true;
            this.Vendedor.VisibleIndex = 7;
            this.Vendedor.Width = 67;
            // 
            // cc_observacion
            // 
            this.cc_observacion.Caption = "Observacion";
            this.cc_observacion.FieldName = "cc_observacion";
            this.cc_observacion.Name = "cc_observacion";
            this.cc_observacion.Visible = true;
            this.cc_observacion.VisibleIndex = 8;
            this.cc_observacion.Width = 67;
            // 
            // cc_dirigidoA
            // 
            this.cc_dirigidoA.Caption = "Dirigido a";
            this.cc_dirigidoA.FieldName = "cc_dirigidoA";
            this.cc_dirigidoA.Name = "cc_dirigidoA";
            this.cc_dirigidoA.Visible = true;
            this.cc_dirigidoA.VisibleIndex = 9;
            this.cc_dirigidoA.Width = 86;
            // 
            // subtotal
            // 
            this.subtotal.Caption = "subtotal";
            this.subtotal.FieldName = "subtotal";
            this.subtotal.GroupFormat.FormatString = "n2";
            this.subtotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.subtotal.Name = "subtotal";
            this.subtotal.Visible = true;
            this.subtotal.VisibleIndex = 10;
            this.subtotal.Width = 118;
            // 
            // iva
            // 
            this.iva.Caption = "iva";
            this.iva.FieldName = "iva";
            this.iva.GroupFormat.FormatString = "n2";
            this.iva.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.iva.Name = "iva";
            this.iva.Visible = true;
            this.iva.VisibleIndex = 11;
            this.iva.Width = 57;
            // 
            // total
            // 
            this.total.Caption = "total";
            this.total.FieldName = "total";
            this.total.GroupFormat.FormatString = "n2";
            this.total.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.total.Name = "total";
            this.total.Visible = true;
            this.total.VisibleIndex = 12;
            this.total.Width = 53;
            // 
            // cc_estado
            // 
            this.cc_estado.Caption = "Estado";
            this.cc_estado.FieldName = "cc_estado";
            this.cc_estado.Name = "cc_estado";
            this.cc_estado.Visible = true;
            this.cc_estado.VisibleIndex = 13;
            this.cc_estado.Width = 43;
            // 
            // CodCotizacion
            // 
            this.CodCotizacion.Caption = "Cod Cotizacion";
            this.CodCotizacion.FieldName = "CodCotizacion";
            this.CodCotizacion.Name = "CodCotizacion";
            this.CodCotizacion.Visible = true;
            this.CodCotizacion.VisibleIndex = 3;
            this.CodCotizacion.Width = 84;
            // 
            // IdSucursal
            // 
            this.IdSucursal.Caption = "IdSucursal";
            this.IdSucursal.FieldName = "IdSucursal";
            this.IdSucursal.Name = "IdSucursal";
            this.IdSucursal.Visible = true;
            this.IdSucursal.VisibleIndex = 14;
            // 
            // IdBodega
            // 
            this.IdBodega.Caption = "IdBodega";
            this.IdBodega.FieldName = "IdBodega";
            this.IdBodega.Name = "IdBodega";
            this.IdBodega.Visible = true;
            this.IdBodega.VisibleIndex = 15;
            // 
            // ucGe_Menu_Mantenimiento
            // 
            this.ucGe_Menu_Mantenimiento.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento.CargarTodasSucursales = true;
            this.ucGe_Menu_Mantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento.fecha_desde = new System.DateTime(2016, 12, 20, 14, 13, 13, 5);
            this.ucGe_Menu_Mantenimiento.fecha_hasta = new System.DateTime(2017, 2, 20, 14, 13, 13, 5);
            this.ucGe_Menu_Mantenimiento.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento.FormMain = null;
            this.ucGe_Menu_Mantenimiento.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento.Name = "ucGe_Menu_Mantenimiento";
            this.ucGe_Menu_Mantenimiento.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento.Size = new System.Drawing.Size(1021, 155);
            this.ucGe_Menu_Mantenimiento.TabIndex = 6;
            this.ucGe_Menu_Mantenimiento.Visible_bodega = true;
            this.ucGe_Menu_Mantenimiento.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento.Visible_sucursal = true;
            // 
            // panel_central
            // 
            this.panel_central.Controls.Add(this.gridConsultaCot);
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(0, 155);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(1021, 243);
            this.panel_central.TabIndex = 7;
            // 
            // frmFa_Cotizacion_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 420);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmFa_Cotizacion_Consulta";
            this.Text = "Cotizacion Consulta";
            this.Load += new System.EventHandler(this.frmCO_Cotizacion_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaCot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsultaCot)).EndInit();
            this.panel_central.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.GridControl gridConsultaCot;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConsultaCot;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraGrid.Columns.GridColumn subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn iva;
        private DevExpress.XtraGrid.Columns.GridColumn total;
        private DevExpress.XtraGrid.Columns.GridColumn cc_fechaVencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn cc_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn cc_dirigidoA;
        private DevExpress.XtraGrid.Columns.GridColumn cc_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn cotizacionId;
        private DevExpress.XtraGrid.Columns.GridColumn cc_estado;
        private DevExpress.XtraGrid.Columns.GridColumn CodCotizacion;
        private DevExpress.XtraGrid.Columns.GridColumn IdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn IdBodega;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento;
        private System.Windows.Forms.Panel panel_central;
    }
}