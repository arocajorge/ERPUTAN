namespace Core.Erp.Winform.Inventario
{
    partial class frmIn_AjusteFisico_Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIn_AjusteFisico_Consulta));
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdAjusteFisico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bo_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.su_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvAjustes_Cabecera = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DescripcionIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNumMovi_Ing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescripcionEngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNumMovi_Egr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdEstadoAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.mnu_salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_consultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNuevo = new System.Windows.Forms.ToolStripButton();
            this.panelSucursal = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.panelTop = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gvAjustes_Cabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            this.toolStripMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.OptionsColumn.AllowEdit = false;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 10;
            this.Estado.Width = 51;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.DisplayFormat.FormatString = "d";
            this.Fecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.OptionsColumn.AllowEdit = false;
            this.Fecha.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 8;
            this.Fecha.Width = 61;
            // 
            // IdAjusteFisico
            // 
            this.IdAjusteFisico.Caption = "#AJuste";
            this.IdAjusteFisico.FieldName = "IdAjusteFisico";
            this.IdAjusteFisico.Name = "IdAjusteFisico";
            this.IdAjusteFisico.OptionsColumn.AllowEdit = false;
            this.IdAjusteFisico.Visible = true;
            this.IdAjusteFisico.VisibleIndex = 2;
            this.IdAjusteFisico.Width = 48;
            // 
            // bo_descripcion
            // 
            this.bo_descripcion.Caption = "Bodega";
            this.bo_descripcion.FieldName = "bo_descripcion";
            this.bo_descripcion.Name = "bo_descripcion";
            this.bo_descripcion.OptionsColumn.AllowEdit = false;
            this.bo_descripcion.Visible = true;
            this.bo_descripcion.VisibleIndex = 1;
            this.bo_descripcion.Width = 52;
            // 
            // su_Descripcion
            // 
            this.su_Descripcion.Caption = "Sucursal";
            this.su_Descripcion.FieldName = "su_Descripcion";
            this.su_Descripcion.Name = "su_Descripcion";
            this.su_Descripcion.Visible = true;
            this.su_Descripcion.VisibleIndex = 0;
            this.su_Descripcion.Width = 53;
            // 
            // gvAjustes_Cabecera
            // 
            this.gvAjustes_Cabecera.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.su_Descripcion,
            this.bo_descripcion,
            this.IdAjusteFisico,
            this.DescripcionIngreso,
            this.IdNumMovi_Ing,
            this.DescripcionEngreso,
            this.IdNumMovi_Egr,
            this.Fecha,
            this.Observacion,
            this.IdEstadoAprobacion,
            this.Estado});
            this.gvAjustes_Cabecera.GridControl = this.gridControl;
            this.gvAjustes_Cabecera.Name = "gvAjustes_Cabecera";
            this.gvAjustes_Cabecera.OptionsBehavior.Editable = false;
            this.gvAjustes_Cabecera.OptionsView.ShowAutoFilterRow = true;
            this.gvAjustes_Cabecera.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvAjustes_Cabecera_RowClick);
            // 
            // DescripcionIngreso
            // 
            this.DescripcionIngreso.Caption = "Tipo movimiento Ingreso";
            this.DescripcionIngreso.FieldName = "DescripcionIngreso";
            this.DescripcionIngreso.Name = "DescripcionIngreso";
            this.DescripcionIngreso.Visible = true;
            this.DescripcionIngreso.VisibleIndex = 3;
            this.DescripcionIngreso.Width = 117;
            // 
            // IdNumMovi_Ing
            // 
            this.IdNumMovi_Ing.Caption = "# Mov. Ingreso";
            this.IdNumMovi_Ing.FieldName = "IdNumMovi_Ing";
            this.IdNumMovi_Ing.Name = "IdNumMovi_Ing";
            this.IdNumMovi_Ing.Visible = true;
            this.IdNumMovi_Ing.VisibleIndex = 4;
            this.IdNumMovi_Ing.Width = 84;
            // 
            // DescripcionEngreso
            // 
            this.DescripcionEngreso.Caption = "Tipo movimiento Egreso";
            this.DescripcionEngreso.FieldName = "DescripcionEngreso";
            this.DescripcionEngreso.Name = "DescripcionEngreso";
            this.DescripcionEngreso.Visible = true;
            this.DescripcionEngreso.VisibleIndex = 5;
            this.DescripcionEngreso.Width = 119;
            // 
            // IdNumMovi_Egr
            // 
            this.IdNumMovi_Egr.Caption = "# Movi. Egreso";
            this.IdNumMovi_Egr.FieldName = "IdNumMovi_Egr";
            this.IdNumMovi_Egr.Name = "IdNumMovi_Egr";
            this.IdNumMovi_Egr.Visible = true;
            this.IdNumMovi_Egr.VisibleIndex = 6;
            this.IdNumMovi_Egr.Width = 95;
            // 
            // Observacion
            // 
            this.Observacion.Caption = "Observacion";
            this.Observacion.FieldName = "Observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.OptionsColumn.AllowEdit = false;
            this.Observacion.Visible = true;
            this.Observacion.VisibleIndex = 7;
            this.Observacion.Width = 224;
            // 
            // IdEstadoAprobacion
            // 
            this.IdEstadoAprobacion.Caption = "Estado Aprobación";
            this.IdEstadoAprobacion.FieldName = "IdEstadoAprobacion";
            this.IdEstadoAprobacion.Name = "IdEstadoAprobacion";
            this.IdEstadoAprobacion.Visible = true;
            this.IdEstadoAprobacion.VisibleIndex = 9;
            this.IdEstadoAprobacion.Width = 108;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 119);
            this.gridControl.MainView = this.gvAjustes_Cabecera;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1030, 275);
            this.gridControl.TabIndex = 15;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAjustes_Cabecera});
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(873, 36);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(133, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(612, 37);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(133, 20);
            this.dtpDesde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha desde:";
            // 
            // mnu_salir
            // 
            this.mnu_salir.Image = ((System.Drawing.Image)(resources.GetObject("mnu_salir.Image")));
            this.mnu_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_salir.Name = "mnu_salir";
            this.mnu_salir.Size = new System.Drawing.Size(49, 22);
            this.mnu_salir.Text = "&Salir";
            this.mnu_salir.Click += new System.EventHandler(this.mnu_salir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // mnu_consultar
            // 
            this.mnu_consultar.Image = ((System.Drawing.Image)(resources.GetObject("mnu_consultar.Image")));
            this.mnu_consultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_consultar.Name = "mnu_consultar";
            this.mnu_consultar.Size = new System.Drawing.Size(78, 22);
            this.mnu_consultar.Text = "Consultar";
            this.mnu_consultar.Click += new System.EventHandler(this.mnu_consultar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuNuevo
            // 
            this.mnuNuevo.Image = ((System.Drawing.Image)(resources.GetObject("mnuNuevo.Image")));
            this.mnuNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuNuevo.Name = "mnuNuevo";
            this.mnuNuevo.Size = new System.Drawing.Size(62, 22);
            this.mnuNuevo.Text = "Nuevo";
            this.mnuNuevo.Click += new System.EventHandler(this.mnuNuevo_Click);
            // 
            // panelSucursal
            // 
            this.panelSucursal.Location = new System.Drawing.Point(12, 28);
            this.panelSucursal.Name = "panelSucursal";
            this.panelSucursal.Size = new System.Drawing.Size(472, 85);
            this.panelSucursal.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(873, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevo,
            this.toolStripSeparator1,
            this.mnu_consultar,
            this.toolStripSeparator3,
            this.mnu_salir});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1030, 25);
            this.toolStripMain.TabIndex = 5;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelSucursal);
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Controls.Add(this.toolStripMain);
            this.panelTop.Controls.Add(this.dtpHasta);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.dtpDesde);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1030, 119);
            this.panelTop.TabIndex = 14;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1030, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmIn_AjusteFisico_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 416);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmIn_AjusteFisico_Consulta";
            this.Text = "Consulta Ajuste Fisico";
            this.Load += new System.EventHandler(this.frmIn_AjusteFisico_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAjustes_Cabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn IdAjusteFisico;
        private DevExpress.XtraGrid.Columns.GridColumn bo_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn su_Descripcion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAjustes_Cabecera;
        private DevExpress.XtraGrid.Columns.GridColumn Observacion;
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton mnu_salir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton mnu_consultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnuNuevo;
        private System.Windows.Forms.Panel panelSucursal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.Columns.GridColumn DescripcionIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn DescripcionEngreso;
        private DevExpress.XtraGrid.Columns.GridColumn IdNumMovi_Ing;
        private DevExpress.XtraGrid.Columns.GridColumn IdNumMovi_Egr;
        private DevExpress.XtraGrid.Columns.GridColumn IdEstadoAprobacion;
    }
}