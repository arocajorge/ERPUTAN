namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_devol_venta_consulta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.gridConsultaCot = new DevExpress.XtraGrid.GridControl();
            this.gridView_devVta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCbteVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dv_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dv_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdDevolucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dv_seguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dv_flete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dv_interes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dv_OtroValor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dv_OtroValor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_NumFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_serie2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_serie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodDevolucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaCot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_devVta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 160);
            this.panel1.TabIndex = 24;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 12, 20, 14, 14, 13, 625);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 2, 20, 14, 14, 13, 625);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1017, 154);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            // 
            // gridConsultaCot
            // 
            this.gridConsultaCot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsultaCot.Location = new System.Drawing.Point(0, 160);
            this.gridConsultaCot.MainView = this.gridView_devVta;
            this.gridConsultaCot.Name = "gridConsultaCot";
            this.gridConsultaCot.Size = new System.Drawing.Size(1017, 240);
            this.gridConsultaCot.TabIndex = 25;
            this.gridConsultaCot.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_devVta});
            // 
            // gridView_devVta
            // 
            this.gridView_devVta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sucursal,
            this.Bodega,
            this.Cliente,
            this.Vendedor,
            this.IVA,
            this.Subtotal,
            this.Total,
            this.Estado,
            this.IdCbteVta,
            this.dv_fecha,
            this.IdEmpresa,
            this.IdSucursal,
            this.IdBodega,
            this.IdCliente,
            this.IdVendedor,
            this.dv_Observacion,
            this.IdUsuario,
            this.IdDevolucion,
            this.dv_seguro,
            this.dv_flete,
            this.dv_interes,
            this.dv_OtroValor2,
            this.dv_OtroValor1,
            this.vt_NumFactura,
            this.vt_serie2,
            this.vt_serie1,
            this.IdNota,
            this.CodDevolucion});
            this.gridView_devVta.GridControl = this.gridConsultaCot;
            this.gridView_devVta.Name = "gridView_devVta";
            this.gridView_devVta.OptionsBehavior.Editable = false;
            this.gridView_devVta.OptionsView.ShowAutoFilterRow = true;
            this.gridView_devVta.OptionsView.ShowGroupPanel = false;
            this.gridView_devVta.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.dv_fecha, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.IdDevolucion, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView_devVta.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView_devVta.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 0;
            this.Sucursal.Width = 90;
            // 
            // Bodega
            // 
            this.Bodega.Caption = "Bodega";
            this.Bodega.FieldName = "Bodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.Visible = true;
            this.Bodega.VisibleIndex = 1;
            this.Bodega.Width = 106;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 7;
            this.Cliente.Width = 58;
            // 
            // Vendedor
            // 
            this.Vendedor.Caption = "Vendedor";
            this.Vendedor.FieldName = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Visible = true;
            this.Vendedor.VisibleIndex = 8;
            this.Vendedor.Width = 56;
            // 
            // IVA
            // 
            this.IVA.Caption = "IVA";
            this.IVA.FieldName = "IVA";
            this.IVA.GroupFormat.FormatString = "n2";
            this.IVA.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.IVA.Name = "IVA";
            this.IVA.Visible = true;
            this.IVA.VisibleIndex = 11;
            this.IVA.Width = 39;
            // 
            // Subtotal
            // 
            this.Subtotal.Caption = "Subtotal";
            this.Subtotal.FieldName = "Subtotal";
            this.Subtotal.GroupFormat.FormatString = "n2";
            this.Subtotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Visible = true;
            this.Subtotal.VisibleIndex = 12;
            this.Subtotal.Width = 32;
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.FieldName = "Total";
            this.Total.GroupFormat.FormatString = "n2";
            this.Total.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Total.Name = "Total";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 13;
            this.Total.Width = 32;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 14;
            this.Estado.Width = 30;
            // 
            // IdCbteVta
            // 
            this.IdCbteVta.Caption = "Id Cbte Vta";
            this.IdCbteVta.FieldName = "IdCbteVta";
            this.IdCbteVta.Name = "IdCbteVta";
            this.IdCbteVta.Visible = true;
            this.IdCbteVta.VisibleIndex = 3;
            this.IdCbteVta.Width = 64;
            // 
            // dv_fecha
            // 
            this.dv_fecha.Caption = "Fecha";
            this.dv_fecha.FieldName = "dv_fecha";
            this.dv_fecha.Name = "dv_fecha";
            this.dv_fecha.Visible = true;
            this.dv_fecha.VisibleIndex = 10;
            this.dv_fecha.Width = 52;
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.Caption = "IdEmpresa";
            this.IdEmpresa.FieldName = "IdEmpresa";
            this.IdEmpresa.Name = "IdEmpresa";
            this.IdEmpresa.Width = 230;
            // 
            // IdSucursal
            // 
            this.IdSucursal.Caption = "IdSucursal";
            this.IdSucursal.FieldName = "IdSucursal";
            this.IdSucursal.Name = "IdSucursal";
            this.IdSucursal.Width = 208;
            // 
            // IdBodega
            // 
            this.IdBodega.Caption = "IdBodega";
            this.IdBodega.FieldName = "IdBodega";
            this.IdBodega.Name = "IdBodega";
            this.IdBodega.Width = 117;
            // 
            // IdCliente
            // 
            this.IdCliente.Caption = "IdCliente";
            this.IdCliente.FieldName = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Width = 164;
            // 
            // IdVendedor
            // 
            this.IdVendedor.Caption = "IdVendedor";
            this.IdVendedor.FieldName = "IdVendedor";
            this.IdVendedor.Name = "IdVendedor";
            this.IdVendedor.Width = 136;
            // 
            // dv_Observacion
            // 
            this.dv_Observacion.Caption = "Observacion";
            this.dv_Observacion.FieldName = "dv_Observacion";
            this.dv_Observacion.Name = "dv_Observacion";
            this.dv_Observacion.Visible = true;
            this.dv_Observacion.VisibleIndex = 9;
            this.dv_Observacion.Width = 84;
            // 
            // IdUsuario
            // 
            this.IdUsuario.Caption = "Usuario";
            this.IdUsuario.FieldName = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Visible = true;
            this.IdUsuario.VisibleIndex = 15;
            this.IdUsuario.Width = 64;
            // 
            // IdDevolucion
            // 
            this.IdDevolucion.Caption = "#Devolucion";
            this.IdDevolucion.FieldName = "IdDevolucion";
            this.IdDevolucion.Name = "IdDevolucion";
            this.IdDevolucion.Visible = true;
            this.IdDevolucion.VisibleIndex = 4;
            this.IdDevolucion.Width = 82;
            // 
            // dv_seguro
            // 
            this.dv_seguro.Caption = "dv_seguro";
            this.dv_seguro.FieldName = "dv_seguro";
            this.dv_seguro.Name = "dv_seguro";
            // 
            // dv_flete
            // 
            this.dv_flete.Caption = "dv_flete";
            this.dv_flete.FieldName = "dv_flete";
            this.dv_flete.Name = "dv_flete";
            // 
            // dv_interes
            // 
            this.dv_interes.Caption = "dv_interes";
            this.dv_interes.FieldName = "dv_interes";
            this.dv_interes.Name = "dv_interes";
            // 
            // dv_OtroValor2
            // 
            this.dv_OtroValor2.Caption = "dv_OtroValor2";
            this.dv_OtroValor2.FieldName = "dv_OtroValor2";
            this.dv_OtroValor2.Name = "dv_OtroValor2";
            // 
            // dv_OtroValor1
            // 
            this.dv_OtroValor1.Caption = "dv_OtroValor1";
            this.dv_OtroValor1.FieldName = "dv_OtroValor1";
            this.dv_OtroValor1.Name = "dv_OtroValor1";
            // 
            // vt_NumFactura
            // 
            this.vt_NumFactura.Caption = "# Factura";
            this.vt_NumFactura.FieldName = "vt_NumFactura";
            this.vt_NumFactura.Name = "vt_NumFactura";
            this.vt_NumFactura.Visible = true;
            this.vt_NumFactura.VisibleIndex = 2;
            this.vt_NumFactura.Width = 61;
            // 
            // vt_serie2
            // 
            this.vt_serie2.Caption = "vt_serie2";
            this.vt_serie2.FieldName = "vt_serie2";
            this.vt_serie2.Name = "vt_serie2";
            // 
            // vt_serie1
            // 
            this.vt_serie1.Caption = "vt_serie1";
            this.vt_serie1.FieldName = "vt_serie1";
            this.vt_serie1.Name = "vt_serie1";
            // 
            // IdNota
            // 
            this.IdNota.Caption = "# Nota";
            this.IdNota.FieldName = "IdNota";
            this.IdNota.Name = "IdNota";
            this.IdNota.Visible = true;
            this.IdNota.VisibleIndex = 6;
            this.IdNota.Width = 64;
            // 
            // CodDevolucion
            // 
            this.CodDevolucion.Caption = "Cod Devolucion";
            this.CodDevolucion.FieldName = "CodDevolucion";
            this.CodDevolucion.Name = "CodDevolucion";
            this.CodDevolucion.Visible = true;
            this.CodDevolucion.VisibleIndex = 5;
            this.CodDevolucion.Width = 85;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1017, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmFa_devol_venta_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1017, 400);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gridConsultaCot);
            this.Controls.Add(this.panel1);
            this.Name = "frmFa_devol_venta_consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Devoluviones";
            this.Load += new System.EventHandler(this.frmFA_devol_venta_consulta_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaCot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_devVta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridConsultaCot;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_devVta;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraGrid.Columns.GridColumn IVA;
        private DevExpress.XtraGrid.Columns.GridColumn Subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn IdCbteVta;
        private DevExpress.XtraGrid.Columns.GridColumn dv_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn IdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn IdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn IdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn IdVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn dv_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn IdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn IdDevolucion;
        private DevExpress.XtraGrid.Columns.GridColumn dv_seguro;
        private DevExpress.XtraGrid.Columns.GridColumn dv_flete;
        private DevExpress.XtraGrid.Columns.GridColumn dv_interes;
        private DevExpress.XtraGrid.Columns.GridColumn dv_OtroValor2;
        private DevExpress.XtraGrid.Columns.GridColumn dv_OtroValor1;
        private DevExpress.XtraGrid.Columns.GridColumn vt_NumFactura;
        private DevExpress.XtraGrid.Columns.GridColumn vt_serie2;
        private DevExpress.XtraGrid.Columns.GridColumn vt_serie1;
        private DevExpress.XtraGrid.Columns.GridColumn IdNota;
        private DevExpress.XtraGrid.Columns.GridColumn CodDevolucion;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}