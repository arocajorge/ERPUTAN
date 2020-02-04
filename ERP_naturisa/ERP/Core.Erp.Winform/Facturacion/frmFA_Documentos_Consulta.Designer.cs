namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Documentos_Consulta
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lblFchIni = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.gridConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaVenc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_flete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_interes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_OtroValor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_OtroValor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_seguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Numero_Factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFechaIni);
            this.panel1.Controls.Add(this.lblFchIni);
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 73);
            this.panel1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 46);
            this.button1.TabIndex = 24;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha Final";
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(327, 14);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIni.TabIndex = 20;
            // 
            // lblFchIni
            // 
            this.lblFchIni.AutoSize = true;
            this.lblFchIni.Location = new System.Drawing.Point(262, 20);
            this.lblFchIni.Name = "lblFchIni";
            this.lblFchIni.Size = new System.Drawing.Size(67, 13);
            this.lblFchIni.TabIndex = 22;
            this.lblFchIni.Text = "Fecha Inicial";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(327, 40);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 21;
            // 
            // gridConsulta
            // 
            this.gridConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsulta.Location = new System.Drawing.Point(0, 73);
            this.gridConsulta.MainView = this.gridViewConsulta;
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.Size = new System.Drawing.Size(1254, 233);
            this.gridConsulta.TabIndex = 20;
            this.gridConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsulta});
            // 
            // gridViewConsulta
            // 
            this.gridViewConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sucursal,
            this.Bodega,
            this.Cliente,
            this.Vendedor,
            this.IVA,
            this.Subtotal,
            this.Total,
            this.ID,
            this.Observacion,
            this.Fecha,
            this.FechaVenc,
            this.IdVendedor,
            this.IdCliente,
            this.vt_flete,
            this.vt_interes,
            this.vt_OtroValor1,
            this.vt_OtroValor2,
            this.vt_seguro,
            this.Numero_Factura});
            this.gridViewConsulta.GridControl = this.gridConsulta;
            this.gridViewConsulta.Name = "gridViewConsulta";
            this.gridViewConsulta.OptionsBehavior.Editable = false;
            this.gridViewConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsulta.OptionsView.ShowGroupPanel = false;
            this.gridViewConsulta.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Sucursal, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Bodega, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewConsulta.DoubleClick += new System.EventHandler(this.gridViewConsulta_DoubleClick);
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 1;
            this.Sucursal.Width = 110;
            // 
            // Bodega
            // 
            this.Bodega.Caption = "Bodega";
            this.Bodega.FieldName = "Bodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.Visible = true;
            this.Bodega.VisibleIndex = 2;
            this.Bodega.Width = 130;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 3;
            this.Cliente.Width = 87;
            // 
            // Vendedor
            // 
            this.Vendedor.Caption = "Vendedor";
            this.Vendedor.FieldName = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Visible = true;
            this.Vendedor.VisibleIndex = 4;
            this.Vendedor.Width = 84;
            // 
            // IVA
            // 
            this.IVA.Caption = "IVA";
            this.IVA.FieldName = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.Visible = true;
            this.IVA.VisibleIndex = 8;
            this.IVA.Width = 26;
            // 
            // Subtotal
            // 
            this.Subtotal.Caption = "Subtotal";
            this.Subtotal.FieldName = "SubTotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Visible = true;
            this.Subtotal.VisibleIndex = 9;
            this.Subtotal.Width = 34;
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 10;
            this.Total.Width = 32;
            // 
            // ID
            // 
            this.ID.Caption = "ID Documento";
            this.ID.FieldName = "Id";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // Observacion
            // 
            this.Observacion.Caption = "Observacion";
            this.Observacion.FieldName = "Observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.Visible = true;
            this.Observacion.VisibleIndex = 5;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 6;
            // 
            // FechaVenc
            // 
            this.FechaVenc.Caption = "Fecha Venc.";
            this.FechaVenc.FieldName = "FechaVenc";
            this.FechaVenc.Name = "FechaVenc";
            this.FechaVenc.Visible = true;
            this.FechaVenc.VisibleIndex = 7;
            // 
            // IdVendedor
            // 
            this.IdVendedor.Caption = "IdVendedor";
            this.IdVendedor.FieldName = "IdVendedor";
            this.IdVendedor.Name = "IdVendedor";
            // 
            // IdCliente
            // 
            this.IdCliente.Caption = "IdCliente";
            this.IdCliente.FieldName = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            // 
            // vt_flete
            // 
            this.vt_flete.Caption = "vt_flete";
            this.vt_flete.FieldName = "vt_flete";
            this.vt_flete.Name = "vt_flete";
            // 
            // vt_interes
            // 
            this.vt_interes.Caption = "vt_interes";
            this.vt_interes.FieldName = "vt_interes";
            this.vt_interes.Name = "vt_interes";
            // 
            // vt_OtroValor1
            // 
            this.vt_OtroValor1.Caption = "vt_OtroValor1";
            this.vt_OtroValor1.FieldName = "vt_OtroValor1";
            this.vt_OtroValor1.Name = "vt_OtroValor1";
            // 
            // vt_OtroValor2
            // 
            this.vt_OtroValor2.Caption = "vt_OtroValor2";
            this.vt_OtroValor2.FieldName = "vt_OtroValor2";
            this.vt_OtroValor2.Name = "vt_OtroValor2";
            // 
            // vt_seguro
            // 
            this.vt_seguro.Caption = "vt_seguro";
            this.vt_seguro.FieldName = "vt_seguro";
            this.vt_seguro.Name = "vt_seguro";
            // 
            // Numero_Factura
            // 
            this.Numero_Factura.Caption = "Numero_Factura";
            this.Numero_Factura.FieldName = "Numero_Factura";
            this.Numero_Factura.Name = "Numero_Factura";
            // 
            // frmFa_Documentos_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 306);
            this.Controls.Add(this.gridConsulta);
            this.Controls.Add(this.panel1);
            this.Name = "frmFa_Documentos_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Documentos";
            this.Load += new System.EventHandler(this.frmFA_Documentos_Consulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label lblFchIni;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraGrid.Columns.GridColumn IVA;
        private DevExpress.XtraGrid.Columns.GridColumn Subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn FechaVenc;
        public DevExpress.XtraGrid.GridControl gridConsulta;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn IdVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn IdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn vt_flete;
        private DevExpress.XtraGrid.Columns.GridColumn vt_interes;
        private DevExpress.XtraGrid.Columns.GridColumn vt_OtroValor1;
        private DevExpress.XtraGrid.Columns.GridColumn vt_OtroValor2;
        private DevExpress.XtraGrid.Columns.GridColumn vt_seguro;
        private DevExpress.XtraGrid.Columns.GridColumn Numero_Factura;
    }
}