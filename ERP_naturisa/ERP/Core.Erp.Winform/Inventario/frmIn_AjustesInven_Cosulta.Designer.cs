namespace Core.Erp.Winform.Inventario
{
    partial class frmIn_AjustesInven_Cosulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIn_AjustesInven_Cosulta));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelTop = new System.Windows.Forms.Panel();
            this.cmbTipoMoviInven = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSucursal = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.mnuNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_consultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAnular = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gvAjustes_Cabecera = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodMoviInven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodNomTipoMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdAjustes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReferenciaOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelTop.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAjustes_Cabecera)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 397);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1027, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cmbTipoMoviInven);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.panelSucursal);
            this.panelTop.Controls.Add(this.btnBuscar);
            this.panelTop.Controls.Add(this.toolStripMain);
            this.panelTop.Controls.Add(this.dtpHasta);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.dtpDesde);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1027, 114);
            this.panelTop.TabIndex = 11;
            // 
            // cmbTipoMoviInven
            // 
            this.cmbTipoMoviInven.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMoviInven.FormattingEnabled = true;
            this.cmbTipoMoviInven.Location = new System.Drawing.Point(612, 28);
            this.cmbTipoMoviInven.Name = "cmbTipoMoviInven";
            this.cmbTipoMoviInven.Size = new System.Drawing.Size(394, 21);
            this.cmbTipoMoviInven.TabIndex = 11;
            this.cmbTipoMoviInven.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMoviInven_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo Movimiento:";
            // 
            // panelSucursal
            // 
            this.panelSucursal.Location = new System.Drawing.Point(12, 28);
            this.panelSucursal.Name = "panelSucursal";
            this.panelSucursal.Size = new System.Drawing.Size(472, 74);
            this.panelSucursal.TabIndex = 9;
            this.panelSucursal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSucursal_Paint);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(873, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 28);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevo,
            this.toolStripSeparator1,
            this.mnu_Modificar,
            this.toolStripSeparator2,
            this.mnu_consultar,
            this.toolStripSeparator3,
            this.btnImprimir,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.btnAnular,
            this.toolStripSeparator4,
            this.mnu_salir,
            this.toolStripTextBox1});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1027, 25);
            this.toolStripMain.TabIndex = 5;
            this.toolStripMain.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnu_Modificar
            // 
            this.mnu_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("mnu_Modificar.Image")));
            this.mnu_Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_Modificar.Name = "mnu_Modificar";
            this.mnu_Modificar.Size = new System.Drawing.Size(78, 22);
            this.mnu_Modificar.Text = "Modificar";
            this.mnu_Modificar.Visible = false;
            this.mnu_Modificar.Click += new System.EventHandler(this.mnu_Modificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Visible = false;
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Core.Erp.Winform.Properties.Resources.imprimir;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAnular
            // 
            this.btnAnular.Image = global::Core.Erp.Winform.Properties.Resources.eliminar;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(58, 22);
            this.btnAnular.Text = "Anular";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.Text = "26022014 13:06 KF";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(873, 54);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(133, 20);
            this.dtpHasta.TabIndex = 3;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(612, 55);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(133, 20);
            this.dtpDesde.TabIndex = 1;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha desde:";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 114);
            this.gridControl.MainView = this.gvAjustes_Cabecera;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1027, 283);
            this.gridControl.TabIndex = 12;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAjustes_Cabecera});
            this.gridControl.Click += new System.EventHandler(this.gridControl_Click);
            // 
            // gvAjustes_Cabecera
            // 
            this.gvAjustes_Cabecera.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sucursal,
            this.Bodega,
            this.CodMoviInven,
            this.CodNomTipoMovi,
            this.IdAjustes,
            this.Fecha,
            this.Tipo,
            this.Estado,
            this.ReferenciaOC});
            this.gvAjustes_Cabecera.GridControl = this.gridControl;
            this.gvAjustes_Cabecera.Name = "gvAjustes_Cabecera";
            this.gvAjustes_Cabecera.OptionsBehavior.Editable = false;
            this.gvAjustes_Cabecera.OptionsView.ShowAutoFilterRow = true;
            this.gvAjustes_Cabecera.OptionsView.ShowViewCaption = true;
            this.gvAjustes_Cabecera.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvAjustes_Cabecera_RowClick);
            this.gvAjustes_Cabecera.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvAjustes_Cabecera_RowCellStyle);
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "NomSucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 0;
            this.Sucursal.Width = 97;
            // 
            // Bodega
            // 
            this.Bodega.Caption = "Bodega";
            this.Bodega.FieldName = "NomBodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.OptionsColumn.AllowEdit = false;
            this.Bodega.Visible = true;
            this.Bodega.VisibleIndex = 1;
            this.Bodega.Width = 146;
            // 
            // CodMoviInven
            // 
            this.CodMoviInven.Caption = "Codigo";
            this.CodMoviInven.FieldName = "CodMoviInven";
            this.CodMoviInven.Name = "CodMoviInven";
            this.CodMoviInven.Width = 55;
            // 
            // CodNomTipoMovi
            // 
            this.CodNomTipoMovi.Caption = "Tipo Ajuste";
            this.CodNomTipoMovi.FieldName = "CodNomTipoMovi";
            this.CodNomTipoMovi.Name = "CodNomTipoMovi";
            this.CodNomTipoMovi.OptionsColumn.AllowEdit = false;
            this.CodNomTipoMovi.Visible = true;
            this.CodNomTipoMovi.VisibleIndex = 3;
            this.CodNomTipoMovi.Width = 186;
            // 
            // IdAjustes
            // 
            this.IdAjustes.Caption = "#AJuste";
            this.IdAjustes.FieldName = "IdNumMovi";
            this.IdAjustes.Name = "IdAjustes";
            this.IdAjustes.OptionsColumn.AllowEdit = false;
            this.IdAjustes.Visible = true;
            this.IdAjustes.VisibleIndex = 2;
            this.IdAjustes.Width = 55;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.DisplayFormat.FormatString = "d";
            this.Fecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Fecha.FieldName = "cm_fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.OptionsColumn.AllowEdit = false;
            this.Fecha.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 4;
            // 
            // Tipo
            // 
            this.Tipo.Caption = "tipo";
            this.Tipo.FieldName = "cm_tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.OptionsColumn.AllowEdit = false;
            this.Tipo.Visible = true;
            this.Tipo.VisibleIndex = 5;
            this.Tipo.Width = 30;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.OptionsColumn.AllowEdit = false;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 7;
            this.Estado.Width = 69;
            // 
            // ReferenciaOC
            // 
            this.ReferenciaOC.AppearanceCell.Options.UseTextOptions = true;
            this.ReferenciaOC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ReferenciaOC.AppearanceHeader.Options.UseTextOptions = true;
            this.ReferenciaOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReferenciaOC.Caption = "ReferenciaOC";
            this.ReferenciaOC.FieldName = "ReferenciaOC";
            this.ReferenciaOC.Name = "ReferenciaOC";
            this.ReferenciaOC.OptionsColumn.AllowEdit = false;
            this.ReferenciaOC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ReferenciaOC.Visible = true;
            this.ReferenciaOC.VisibleIndex = 6;
            this.ReferenciaOC.Width = 399;
            // 
            // frmIn_AjustesInven_Cosulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 419);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmIn_AjustesInven_Cosulta";
            this.Text = "Consulta de Ajustes de Inventario";
            this.Load += new System.EventHandler(this.frmIn_AjustesInven_Cosulta_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAjustes_Cabecera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton mnuNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnu_Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton mnu_consultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton mnu_salir;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSucursal;
        private System.Windows.Forms.ComboBox cmbTipoMoviInven;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAjustes_Cabecera;
        private DevExpress.XtraGrid.Columns.GridColumn Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn CodNomTipoMovi;
        private DevExpress.XtraGrid.Columns.GridColumn IdAjustes;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn CodMoviInven;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel btnAnular;
        private DevExpress.XtraGrid.Columns.GridColumn ReferenciaOC;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}