namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_OrdenCompra_Sin_Guia_Cons
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_sucursal = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControlConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdOrdenCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_NumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(919, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_sucursal);
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Controls.Add(this.dtpFechaIni);
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 62);
            this.panel1.TabIndex = 1;
            // 
            // cmb_sucursal
            // 
            this.cmb_sucursal.Location = new System.Drawing.Point(95, 6);
            this.cmb_sucursal.Name = "cmb_sucursal";
            this.cmb_sucursal.Size = new System.Drawing.Size(332, 26);
            this.cmb_sucursal.TabIndex = 13;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(288, 34);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(139, 20);
            this.dtpFechaFin.TabIndex = 12;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(95, 34);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(139, 20);
            this.dtpFechaIni.TabIndex = 11;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(433, 23);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(105, 30);
            this.btnConsulta.TabIndex = 10;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sucursal:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlConsulta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 311);
            this.panel2.TabIndex = 2;
            // 
            // gridControlConsulta
            // 
            this.gridControlConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlConsulta.Location = new System.Drawing.Point(0, 0);
            this.gridControlConsulta.MainView = this.gridViewConsulta;
            this.gridControlConsulta.Name = "gridControlConsulta";
            this.gridControlConsulta.Size = new System.Drawing.Size(919, 311);
            this.gridControlConsulta.TabIndex = 0;
            this.gridControlConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsulta});
            // 
            // gridViewConsulta
            // 
            this.gridViewConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdOrdenCompra,
            this.coloc_fecha,
            this.coloc_observacion,
            this.colnom_proveedor,
            this.colSu_Descripcion_grid,
            this.colIdEstadoAprobacion,
            this.coloc_NumDocumento,
            this.colIdEmpresa,
            this.colIdSucursal});
            this.gridViewConsulta.GridControl = this.gridControlConsulta;
            this.gridViewConsulta.Name = "gridViewConsulta";
            this.gridViewConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsulta.OptionsView.ShowGroupPanel = false;
            this.gridViewConsulta.DoubleClick += new System.EventHandler(this.gridViewConsulta_DoubleClick);
            // 
            // colIdOrdenCompra
            // 
            this.colIdOrdenCompra.Caption = "# O/C";
            this.colIdOrdenCompra.FieldName = "IdOrdenCompra";
            this.colIdOrdenCompra.Name = "colIdOrdenCompra";
            this.colIdOrdenCompra.OptionsColumn.AllowEdit = false;
            this.colIdOrdenCompra.Visible = true;
            this.colIdOrdenCompra.VisibleIndex = 0;
            this.colIdOrdenCompra.Width = 69;
            // 
            // coloc_fecha
            // 
            this.coloc_fecha.Caption = "Fecha";
            this.coloc_fecha.FieldName = "oc_fecha";
            this.coloc_fecha.Name = "coloc_fecha";
            this.coloc_fecha.OptionsColumn.AllowEdit = false;
            this.coloc_fecha.Visible = true;
            this.coloc_fecha.VisibleIndex = 2;
            this.coloc_fecha.Width = 101;
            // 
            // coloc_observacion
            // 
            this.coloc_observacion.Caption = "Observación";
            this.coloc_observacion.FieldName = "oc_observacion";
            this.coloc_observacion.Name = "coloc_observacion";
            this.coloc_observacion.OptionsColumn.AllowEdit = false;
            this.coloc_observacion.Visible = true;
            this.coloc_observacion.VisibleIndex = 3;
            this.coloc_observacion.Width = 357;
            // 
            // colnom_proveedor
            // 
            this.colnom_proveedor.Caption = "Proveedor";
            this.colnom_proveedor.FieldName = "nom_proveedor";
            this.colnom_proveedor.Name = "colnom_proveedor";
            this.colnom_proveedor.OptionsColumn.AllowEdit = false;
            this.colnom_proveedor.Visible = true;
            this.colnom_proveedor.VisibleIndex = 1;
            this.colnom_proveedor.Width = 238;
            // 
            // colSu_Descripcion_grid
            // 
            this.colSu_Descripcion_grid.Caption = "Sucursal";
            this.colSu_Descripcion_grid.FieldName = "Su_Descripcion";
            this.colSu_Descripcion_grid.Name = "colSu_Descripcion_grid";
            this.colSu_Descripcion_grid.OptionsColumn.AllowEdit = false;
            this.colSu_Descripcion_grid.Width = 240;
            // 
            // colIdEstadoAprobacion
            // 
            this.colIdEstadoAprobacion.Caption = "Estado";
            this.colIdEstadoAprobacion.FieldName = "IdEstadoAprobacion";
            this.colIdEstadoAprobacion.Name = "colIdEstadoAprobacion";
            this.colIdEstadoAprobacion.OptionsColumn.AllowEdit = false;
            this.colIdEstadoAprobacion.Visible = true;
            this.colIdEstadoAprobacion.VisibleIndex = 4;
            this.colIdEstadoAprobacion.Width = 70;
            // 
            // coloc_NumDocumento
            // 
            this.coloc_NumDocumento.Caption = "Ref. Factura";
            this.coloc_NumDocumento.FieldName = "oc_NumDocumento";
            this.coloc_NumDocumento.Name = "coloc_NumDocumento";
            this.coloc_NumDocumento.OptionsColumn.AllowEdit = false;
            this.coloc_NumDocumento.Width = 105;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.Caption = "IdEmpresa";
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.Caption = "IdSucursal";
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            // 
            // FrmCom_OrdenCompra_Sin_Guia_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 395);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmCom_OrdenCompra_Sin_Guia_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Orden Compra sin Guia por Traspaso a Bodega";
            this.Load += new System.EventHandler(this.FrmCom_OrdenCompra_Sin_Guia_Cons_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControlConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_NumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private Controles.UCGe_Sucursal_combo cmb_sucursal;
    }
}