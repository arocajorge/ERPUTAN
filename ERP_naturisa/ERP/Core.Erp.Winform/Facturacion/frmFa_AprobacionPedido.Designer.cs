namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_AprobacionPedido
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAprobar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.gridControlPedido = new DevExpress.XtraGrid.GridControl();
            this.fapedidoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.colChek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fapedidoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAprobar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1043, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAprobar
            // 
            this.btnAprobar.Image = global::Core.Erp.Winform.Properties.Resources._1366257834_20418;
            this.btnAprobar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(70, 22);
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Controls.Add(this.dtpFechaIni);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 70);
            this.panel1.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = global::Core.Erp.Winform.Properties.Resources.buscar;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(873, 14);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(88, 33);
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(659, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha de Inicio:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(748, 28);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaFin.TabIndex = 15;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(748, 8);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaIni.TabIndex = 14;
            // 
            // gridControlPedido
            // 
            this.gridControlPedido.DataSource = this.fapedidoInfoBindingSource;
            this.gridControlPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPedido.Location = new System.Drawing.Point(0, 95);
            this.gridControlPedido.MainView = this.gridViewPedidos;
            this.gridControlPedido.Name = "gridControlPedido";
            this.gridControlPedido.Size = new System.Drawing.Size(1043, 212);
            this.gridControlPedido.TabIndex = 9;
            this.gridControlPedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPedidos});
            // 
            // fapedidoInfoBindingSource
            // 
            this.fapedidoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Facturacion.fa_pedido_Info);
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
            this.colChek});
            this.gridViewPedidos.GridControl = this.gridControlPedido;
            this.gridViewPedidos.Name = "gridViewPedidos";
            this.gridViewPedidos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPedidos.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.IdPedido, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.OptionsColumn.AllowEdit = false;
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 1;
            this.Sucursal.Width = 99;
            // 
            // Bodega
            // 
            this.Bodega.Caption = "Bodega";
            this.Bodega.FieldName = "Bodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.OptionsColumn.AllowEdit = false;
            this.Bodega.Visible = true;
            this.Bodega.VisibleIndex = 2;
            this.Bodega.Width = 99;
            // 
            // IdPedido
            // 
            this.IdPedido.Caption = "IdPedido";
            this.IdPedido.FieldName = "IdPedido";
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.OptionsColumn.AllowEdit = false;
            this.IdPedido.Visible = true;
            this.IdPedido.VisibleIndex = 3;
            this.IdPedido.Width = 99;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.OptionsColumn.AllowEdit = false;
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 4;
            this.Cliente.Width = 99;
            // 
            // Vendedor
            // 
            this.Vendedor.Caption = "Vendedor";
            this.Vendedor.FieldName = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.OptionsColumn.AllowEdit = false;
            this.Vendedor.Visible = true;
            this.Vendedor.VisibleIndex = 5;
            this.Vendedor.Width = 99;
            // 
            // cp_fecha
            // 
            this.cp_fecha.Caption = "Fecha";
            this.cp_fecha.FieldName = "cp_fecha";
            this.cp_fecha.Name = "cp_fecha";
            this.cp_fecha.OptionsColumn.AllowEdit = false;
            this.cp_fecha.Visible = true;
            this.cp_fecha.VisibleIndex = 6;
            this.cp_fecha.Width = 99;
            // 
            // cp_diasPlazo
            // 
            this.cp_diasPlazo.Caption = "Dias Plazo";
            this.cp_diasPlazo.FieldName = "cp_diasPlazo";
            this.cp_diasPlazo.Name = "cp_diasPlazo";
            this.cp_diasPlazo.OptionsColumn.AllowEdit = false;
            this.cp_diasPlazo.Visible = true;
            this.cp_diasPlazo.VisibleIndex = 7;
            this.cp_diasPlazo.Width = 99;
            // 
            // cp_fechaVencimiento
            // 
            this.cp_fechaVencimiento.Caption = "Fecha Vencimiento";
            this.cp_fechaVencimiento.FieldName = "cp_fechaVencimiento";
            this.cp_fechaVencimiento.Name = "cp_fechaVencimiento";
            this.cp_fechaVencimiento.OptionsColumn.AllowEdit = false;
            this.cp_fechaVencimiento.Visible = true;
            this.cp_fechaVencimiento.VisibleIndex = 8;
            this.cp_fechaVencimiento.Width = 99;
            // 
            // cp_observacion
            // 
            this.cp_observacion.Caption = "Observacion";
            this.cp_observacion.FieldName = "cp_observacion";
            this.cp_observacion.Name = "cp_observacion";
            this.cp_observacion.OptionsColumn.AllowEdit = false;
            this.cp_observacion.Visible = true;
            this.cp_observacion.VisibleIndex = 9;
            this.cp_observacion.Width = 99;
            // 
            // EstadoAprobacion
            // 
            this.EstadoAprobacion.Caption = "Estado Aprobacion";
            this.EstadoAprobacion.FieldName = "EstadoAprobacion";
            this.EstadoAprobacion.Name = "EstadoAprobacion";
            this.EstadoAprobacion.OptionsColumn.AllowEdit = false;
            this.EstadoAprobacion.Visible = true;
            this.EstadoAprobacion.VisibleIndex = 10;
            this.EstadoAprobacion.Width = 99;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.OptionsColumn.AllowEdit = false;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 11;
            this.Estado.Width = 103;
            // 
            // colChek
            // 
            this.colChek.FieldName = "Chek";
            this.colChek.Name = "colChek";
            this.colChek.Visible = true;
            this.colChek.VisibleIndex = 0;
            this.colChek.Width = 38;
            // 
            // frmFa_AprobacionPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 307);
            this.Controls.Add(this.gridControlPedido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmFa_AprobacionPedido";
            this.Text = "frmFa_AprobacionPedido";
            this.Load += new System.EventHandler(this.frmFa_AprobacionPedido_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fapedidoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAprobar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private DevExpress.XtraGrid.GridControl gridControlPedido;
        private System.Windows.Forms.BindingSource fapedidoInfoBindingSource;
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
        private DevExpress.XtraGrid.Columns.GridColumn colChek;

    }
}