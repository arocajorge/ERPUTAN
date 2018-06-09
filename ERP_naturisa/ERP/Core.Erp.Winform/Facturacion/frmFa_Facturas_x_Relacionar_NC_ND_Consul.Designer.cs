namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Facturas_x_Relacionar_NC_ND_Consul
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlFacturas = new DevExpress.XtraGrid.GridControl();
            this.gridViewFacturas = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.colvt_fech_venc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoAUX = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlFacturas);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1072, 348);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControlFacturas
            // 
            this.gridControlFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFacturas.Location = new System.Drawing.Point(2, 2);
            this.gridControlFacturas.MainView = this.gridViewFacturas;
            this.gridControlFacturas.Name = "gridControlFacturas";
            this.gridControlFacturas.Size = new System.Drawing.Size(1068, 344);
            this.gridControlFacturas.TabIndex = 2;
            this.gridControlFacturas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFacturas});
            // 
            // gridViewFacturas
            // 
            this.gridViewFacturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.colvt_fech_venc,
            this.colplazo,
            this.colobservacion,
            this.colNomCliente,
            this.colSaldoAUX});
            this.gridViewFacturas.GridControl = this.gridControlFacturas;
            this.gridViewFacturas.Name = "gridViewFacturas";
            this.gridViewFacturas.OptionsView.ShowAutoFilterRow = true;
            this.gridViewFacturas.OptionsView.ShowGroupPanel = false;
            this.gridViewFacturas.DoubleClick += new System.EventHandler(this.gridViewFacturas_DoubleClick);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.Caption = "Sucursal";
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.Width = 99;
            // 
            // colIdBodega
            // 
            this.colIdBodega.Caption = "Bodega";
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            this.colIdBodega.Width = 99;
            // 
            // colvt_tipoDoc
            // 
            this.colvt_tipoDoc.FieldName = "vt_tipoDoc";
            this.colvt_tipoDoc.Name = "colvt_tipoDoc";
            // 
            // colvt_NunDocumento
            // 
            this.colvt_NunDocumento.Caption = "# Documento";
            this.colvt_NunDocumento.FieldName = "vt_NunDocumento";
            this.colvt_NunDocumento.Name = "colvt_NunDocumento";
            this.colvt_NunDocumento.Visible = true;
            this.colvt_NunDocumento.VisibleIndex = 4;
            this.colvt_NunDocumento.Width = 202;
            // 
            // colReferencia
            // 
            this.colReferencia.Caption = "Referencia";
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.OptionsColumn.AllowEdit = false;
            this.colReferencia.Visible = true;
            this.colReferencia.VisibleIndex = 3;
            this.colReferencia.Width = 122;
            // 
            // colIdComprobante
            // 
            this.colIdComprobante.FieldName = "IdComprobante";
            this.colIdComprobante.Name = "colIdComprobante";
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
            this.colSu_Descripcion.OptionsColumn.AllowEdit = false;
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 0;
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
            this.colvt_fecha.OptionsColumn.AllowEdit = false;
            this.colvt_fecha.Visible = true;
            this.colvt_fecha.VisibleIndex = 5;
            this.colvt_fecha.Width = 76;
            // 
            // colvt_total
            // 
            this.colvt_total.Caption = "Total";
            this.colvt_total.FieldName = "vt_total";
            this.colvt_total.Name = "colvt_total";
            this.colvt_total.OptionsColumn.AllowEdit = false;
            this.colvt_total.Visible = true;
            this.colvt_total.VisibleIndex = 7;
            this.colvt_total.Width = 81;
            // 
            // colSaldo
            // 
            this.colSaldo.Caption = "Saldo";
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.OptionsColumn.AllowEdit = false;
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 8;
            this.colSaldo.Width = 108;
            // 
            // colTotalxCobrado
            // 
            this.colTotalxCobrado.FieldName = "TotalxCobrado";
            this.colTotalxCobrado.Name = "colTotalxCobrado";
            // 
            // colBodega
            // 
            this.colBodega.Caption = "Bodega";
            this.colBodega.FieldName = "Bodega";
            this.colBodega.Name = "colBodega";
            this.colBodega.OptionsColumn.AllowEdit = false;
            this.colBodega.Visible = true;
            this.colBodega.VisibleIndex = 1;
            this.colBodega.Width = 101;
            // 
            // colvt_Subtotal
            // 
            this.colvt_Subtotal.FieldName = "vt_Subtotal";
            this.colvt_Subtotal.Name = "colvt_Subtotal";
            // 
            // colvt_iva
            // 
            this.colvt_iva.FieldName = "vt_iva";
            this.colvt_iva.Name = "colvt_iva";
            // 
            // colpe_nombreCompleto
            // 
            this.colpe_nombreCompleto.Caption = "Cliente";
            this.colpe_nombreCompleto.FieldName = "pe_nombreCompleto";
            this.colpe_nombreCompleto.Name = "colpe_nombreCompleto";
            this.colpe_nombreCompleto.OptionsColumn.AllowEdit = false;
            this.colpe_nombreCompleto.Width = 199;
            // 
            // colvt_fech_venc
            // 
            this.colvt_fech_venc.Caption = "Fecha de vencimiento";
            this.colvt_fech_venc.FieldName = "vt_fech_venc";
            this.colvt_fech_venc.Name = "colvt_fech_venc";
            this.colvt_fech_venc.OptionsColumn.AllowEdit = false;
            this.colvt_fech_venc.Visible = true;
            this.colvt_fech_venc.VisibleIndex = 6;
            this.colvt_fech_venc.Width = 93;
            // 
            // colplazo
            // 
            this.colplazo.Caption = "Plazo";
            this.colplazo.FieldName = "plazo";
            this.colplazo.Name = "colplazo";
            this.colplazo.Width = 70;
            // 
            // colobservacion
            // 
            this.colobservacion.Caption = "Observación";
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.Width = 124;
            // 
            // colNomCliente
            // 
            this.colNomCliente.Caption = "Cliente";
            this.colNomCliente.FieldName = "NomCliente";
            this.colNomCliente.Name = "colNomCliente";
            this.colNomCliente.Visible = true;
            this.colNomCliente.VisibleIndex = 2;
            this.colNomCliente.Width = 192;
            // 
            // colSaldoAUX
            // 
            this.colSaldoAUX.FieldName = "SaldoAUX";
            this.colSaldoAUX.Name = "colSaldoAUX";
            // 
            // frmFa_Facturas_x_Relacionar_NC_ND_Consul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 348);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmFa_Facturas_x_Relacionar_NC_ND_Consul";
            this.Text = "frmFa_Facturas_x_Relacionar_NC_ND_Consul";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlFacturas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFacturas;
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
        private DevExpress.XtraGrid.Columns.GridColumn colvt_fech_venc;
        private DevExpress.XtraGrid.Columns.GridColumn colplazo;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNomCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoAUX;
    }
}