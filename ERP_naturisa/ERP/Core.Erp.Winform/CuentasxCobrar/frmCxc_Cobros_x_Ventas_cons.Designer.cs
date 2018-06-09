namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxc_Cobros_x_Ventas_cons
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
            this.gridControl_fac = new DevExpress.XtraGrid.GridControl();
            this.vwcxccarteraxcobrarInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView_fac = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvt_tipoDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvt_NunDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvt_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvt_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalxCobrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvt_Subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvt_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_nombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.Coldc_ValorRetFu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldc_ValorRetIva = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_fac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcxccarteraxcobrarInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_fac)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_fac
            // 
            this.gridControl_fac.DataSource = this.vwcxccarteraxcobrarInfoBindingSource;
            this.gridControl_fac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_fac.Location = new System.Drawing.Point(0, 0);
            this.gridControl_fac.MainView = this.gridView_fac;
            this.gridControl_fac.Name = "gridControl_fac";
            this.gridControl_fac.Size = new System.Drawing.Size(1049, 225);
            this.gridControl_fac.TabIndex = 5;
            this.gridControl_fac.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_fac});
            // 
            // vwcxccarteraxcobrarInfoBindingSource
            // 
            this.vwcxccarteraxcobrarInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.vwcxc_cartera_x_cobrar_Info);
            // 
            // gridView_fac
            // 
            this.gridView_fac.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdBodega,
            this.colvt_tipoDoc,
            this.colvt_NunDocumento,
            this.colReferencia,
            this.colIdComprobante,
            this.colCodComprobante,
            this.colSu_Descripcion,
            this.colIdCliente,
            this.colvt_fecha,
            this.colvt_total,
            this.colSaldo,
            this.colTotalxCobrado,
            this.colBodega,
            this.colvt_Subtotal,
            this.colvt_iva,
            this.colpe_nombreCompleto,
            this.Coldc_ValorRetFu,
            this.coldc_ValorRetIva});
            this.gridView_fac.GridControl = this.gridControl_fac;
            this.gridView_fac.Name = "gridView_fac";
            this.gridView_fac.OptionsBehavior.Editable = false;
            this.gridView_fac.OptionsView.ShowAutoFilterRow = true;
            this.gridView_fac.OptionsView.ShowGroupPanel = false;
            this.gridView_fac.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_fac_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            // 
            // colIdBodega
            // 
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            // 
            // colvt_tipoDoc
            // 
            this.colvt_tipoDoc.FieldName = "vt_tipoDoc";
            this.colvt_tipoDoc.Name = "colvt_tipoDoc";
            // 
            // colvt_NunDocumento
            // 
            this.colvt_NunDocumento.Caption = "# Doc.";
            this.colvt_NunDocumento.FieldName = "vt_NunDocumento";
            this.colvt_NunDocumento.Name = "colvt_NunDocumento";
            this.colvt_NunDocumento.Visible = true;
            this.colvt_NunDocumento.VisibleIndex = 2;
            this.colvt_NunDocumento.Width = 156;
            // 
            // colReferencia
            // 
            this.colReferencia.Caption = "Observación";
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.Visible = true;
            this.colReferencia.VisibleIndex = 4;
            this.colReferencia.Width = 67;
            // 
            // colIdComprobante
            // 
            this.colIdComprobante.Caption = "IdCbte";
            this.colIdComprobante.FieldName = "IdComprobante";
            this.colIdComprobante.Name = "colIdComprobante";
            this.colIdComprobante.Visible = true;
            this.colIdComprobante.VisibleIndex = 8;
            this.colIdComprobante.Width = 88;
            // 
            // colCodComprobante
            // 
            this.colCodComprobante.FieldName = "CodComprobante";
            this.colCodComprobante.Name = "colCodComprobante";
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Sucursal";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 0;
            this.colSu_Descripcion.Width = 57;
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colvt_fecha
            // 
            this.colvt_fecha.Caption = "Fecha";
            this.colvt_fecha.FieldName = "vt_fecha";
            this.colvt_fecha.Name = "colvt_fecha";
            this.colvt_fecha.Visible = true;
            this.colvt_fecha.VisibleIndex = 5;
            this.colvt_fecha.Width = 73;
            // 
            // colvt_total
            // 
            this.colvt_total.Caption = "Total";
            this.colvt_total.FieldName = "vt_total";
            this.colvt_total.Name = "colvt_total";
            this.colvt_total.Visible = true;
            this.colvt_total.VisibleIndex = 6;
            this.colvt_total.Width = 101;
            // 
            // colSaldo
            // 
            this.colSaldo.Caption = "Saldo";
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 7;
            this.colSaldo.Width = 115;
            // 
            // colTotalxCobrado
            // 
            this.colTotalxCobrado.FieldName = "TotalxCobrado";
            this.colTotalxCobrado.Name = "colTotalxCobrado";
            this.colTotalxCobrado.Visible = true;
            this.colTotalxCobrado.VisibleIndex = 11;
            this.colTotalxCobrado.Width = 102;
            // 
            // colBodega
            // 
            this.colBodega.Caption = "Bodega";
            this.colBodega.FieldName = "Bodega";
            this.colBodega.Name = "colBodega";
            this.colBodega.Visible = true;
            this.colBodega.VisibleIndex = 1;
            this.colBodega.Width = 65;
            // 
            // colvt_Subtotal
            // 
            this.colvt_Subtotal.Caption = "Subtotal";
            this.colvt_Subtotal.FieldName = "vt_Subtotal";
            this.colvt_Subtotal.Name = "colvt_Subtotal";
            this.colvt_Subtotal.Width = 64;
            // 
            // colvt_iva
            // 
            this.colvt_iva.Caption = "Iva";
            this.colvt_iva.FieldName = "vt_iva";
            this.colvt_iva.Name = "colvt_iva";
            this.colvt_iva.Width = 64;
            // 
            // colpe_nombreCompleto
            // 
            this.colpe_nombreCompleto.Caption = "Cliente";
            this.colpe_nombreCompleto.FieldName = "pe_nombreCompleto";
            this.colpe_nombreCompleto.Name = "colpe_nombreCompleto";
            this.colpe_nombreCompleto.Visible = true;
            this.colpe_nombreCompleto.VisibleIndex = 3;
            this.colpe_nombreCompleto.Width = 195;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl_fac);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 225);
            this.panel1.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1049, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasSucursales = false;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 6, 4, 16, 32, 57, 209);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 8, 4, 16, 32, 57, 209);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1049, 181);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 8;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevoChq_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevoChq_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevoChq_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // Coldc_ValorRetFu
            // 
            this.Coldc_ValorRetFu.Caption = "Ret/Fte";
            this.Coldc_ValorRetFu.FieldName = "dc_ValorRetFu";
            this.Coldc_ValorRetFu.Name = "Coldc_ValorRetFu";
            this.Coldc_ValorRetFu.Visible = true;
            this.Coldc_ValorRetFu.VisibleIndex = 9;
            this.Coldc_ValorRetFu.Width = 61;
            // 
            // coldc_ValorRetIva
            // 
            this.coldc_ValorRetIva.Caption = "Ret/FIva";
            this.coldc_ValorRetIva.FieldName = "dc_ValorRetIva";
            this.coldc_ValorRetIva.Name = "coldc_ValorRetIva";
            this.coldc_ValorRetIva.Visible = true;
            this.coldc_ValorRetIva.VisibleIndex = 10;
            this.coldc_ValorRetIva.Width = 61;
            // 
            // frmCxc_Cobros_x_Ventas_cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmCxc_Cobros_x_Ventas_cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cobros por Ventas";
            this.Load += new System.EventHandler(this.frmcxc_cobrosXventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_fac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcxccarteraxcobrarInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_fac)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_fac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_fac;
        private System.Windows.Forms.BindingSource vwcxccarteraxcobrarInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colvt_tipoDoc;
        private DevExpress.XtraGrid.Columns.GridColumn colvt_NunDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colIdComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colCodComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colvt_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colvt_total;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalxCobrado;
        private DevExpress.XtraGrid.Columns.GridColumn colBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colvt_Subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colvt_iva;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_nombreCompleto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn Coldc_ValorRetFu;
        private DevExpress.XtraGrid.Columns.GridColumn coldc_ValorRetIva;

    }
}