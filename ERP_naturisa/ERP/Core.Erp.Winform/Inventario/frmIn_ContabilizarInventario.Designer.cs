namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_ContabilizarInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_ContabilizarInventario));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TimerBuscar = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_contabilizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.ucIn_Sucursal_Bodega = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.gridControlMoviInven = new DevExpress.XtraGrid.GridControl();
            this.gridViewMoviInven = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnom_sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNumMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_tipo_mov_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_tipo_movi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbSucursalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbBodegaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inmoviinventipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colChek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMoviInven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMoviInven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSucursalInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBodegaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinventipoInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_contabilizar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1166, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_contabilizar
            // 
            this.btn_contabilizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_contabilizar.Image")));
            this.btn_contabilizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_contabilizar.Name = "btn_contabilizar";
            this.btn_contabilizar.Size = new System.Drawing.Size(90, 22);
            this.btn_contabilizar.Text = "Contabilizar";
            //this.btn_contabilizar.Click += new System.EventHandler(this.btn_contabilizar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(205, 22);
            this.toolStripLabel1.Text = "                                                                  ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtpHasta);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDesde);
            this.splitContainer1.Panel1.Controls.Add(this.btn_buscar);
            this.splitContainer1.Panel1.Controls.Add(this.ucIn_Sucursal_Bodega);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControlMoviInven);
            this.splitContainer1.Size = new System.Drawing.Size(1166, 486);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 1;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(565, 40);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(119, 20);
            this.dtpHasta.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(565, 14);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(119, 20);
            this.dtpDesde.TabIndex = 2;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(954, 36);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(123, 32);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // ucIn_Sucursal_Bodega
            // 
            this.ucIn_Sucursal_Bodega.Location = new System.Drawing.Point(12, 15);
            this.ucIn_Sucursal_Bodega.Name = "ucIn_Sucursal_Bodega";
            this.ucIn_Sucursal_Bodega.Size = new System.Drawing.Size(412, 53);
            this.ucIn_Sucursal_Bodega.TabIndex = 0;
            this.ucIn_Sucursal_Bodega.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.todos;
            // 
            // gridControlMoviInven
            // 
            this.gridControlMoviInven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMoviInven.Location = new System.Drawing.Point(0, 0);
            this.gridControlMoviInven.MainView = this.gridViewMoviInven;
            this.gridControlMoviInven.Name = "gridControlMoviInven";
            this.gridControlMoviInven.Size = new System.Drawing.Size(1166, 407);
            this.gridControlMoviInven.TabIndex = 0;
            this.gridControlMoviInven.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMoviInven});
            // 
            // gridViewMoviInven
            // 
            this.gridViewMoviInven.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnom_sucursal,
            this.colnom_bodega,
            this.colIdNumMovi,
            this.colnom_tipo_mov_inv,
            this.colmv_tipo_movi,
            this.colIdProducto,
            this.colcod_producto,
            this.colnom_producto,
            this.coldm_cantidad,
            this.colmv_costo,
            this.colcm_fecha,
            this.colsubtotal,
            this.colChek});
            this.gridViewMoviInven.GridControl = this.gridControlMoviInven;
            this.gridViewMoviInven.Name = "gridViewMoviInven";
            this.gridViewMoviInven.OptionsBehavior.Editable = false;
            this.gridViewMoviInven.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMoviInven.OptionsView.ShowGroupPanel = false;
            // 
            // colnom_sucursal
            // 
            this.colnom_sucursal.Caption = "Sucursal";
            this.colnom_sucursal.FieldName = "nom_sucursal";
            this.colnom_sucursal.Name = "colnom_sucursal";
            this.colnom_sucursal.Visible = true;
            this.colnom_sucursal.VisibleIndex = 1;
            this.colnom_sucursal.Width = 147;
            // 
            // colnom_bodega
            // 
            this.colnom_bodega.Caption = "Bodega";
            this.colnom_bodega.FieldName = "nom_bodega";
            this.colnom_bodega.Name = "colnom_bodega";
            this.colnom_bodega.Visible = true;
            this.colnom_bodega.VisibleIndex = 2;
            this.colnom_bodega.Width = 89;
            // 
            // colIdNumMovi
            // 
            this.colIdNumMovi.Caption = "IdNumMovi";
            this.colIdNumMovi.FieldName = "IdNumMovi";
            this.colIdNumMovi.Name = "colIdNumMovi";
            this.colIdNumMovi.Visible = true;
            this.colIdNumMovi.VisibleIndex = 4;
            this.colIdNumMovi.Width = 89;
            // 
            // colnom_tipo_mov_inv
            // 
            this.colnom_tipo_mov_inv.Caption = "nom_tipo_mov_inv";
            this.colnom_tipo_mov_inv.FieldName = "nom_tipo_mov_inv";
            this.colnom_tipo_mov_inv.Name = "colnom_tipo_mov_inv";
            this.colnom_tipo_mov_inv.Visible = true;
            this.colnom_tipo_mov_inv.VisibleIndex = 5;
            this.colnom_tipo_mov_inv.Width = 89;
            // 
            // colmv_tipo_movi
            // 
            this.colmv_tipo_movi.Caption = "colmv_tipo_movi";
            this.colmv_tipo_movi.FieldName = "mv_tipo_movi";
            this.colmv_tipo_movi.Name = "colmv_tipo_movi";
            this.colmv_tipo_movi.Visible = true;
            this.colmv_tipo_movi.VisibleIndex = 6;
            this.colmv_tipo_movi.Width = 89;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "IdProducto";
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 7;
            this.colIdProducto.Width = 89;
            // 
            // colcod_producto
            // 
            this.colcod_producto.Caption = "cod_producto";
            this.colcod_producto.FieldName = "cod_producto";
            this.colcod_producto.Name = "colcod_producto";
            this.colcod_producto.Visible = true;
            this.colcod_producto.VisibleIndex = 8;
            this.colcod_producto.Width = 89;
            // 
            // colnom_producto
            // 
            this.colnom_producto.Caption = "nom_producto";
            this.colnom_producto.FieldName = "nom_producto";
            this.colnom_producto.Name = "colnom_producto";
            this.colnom_producto.Visible = true;
            this.colnom_producto.VisibleIndex = 9;
            this.colnom_producto.Width = 89;
            // 
            // coldm_cantidad
            // 
            this.coldm_cantidad.Caption = "dm_cantidad";
            this.coldm_cantidad.FieldName = "dm_cantidad";
            this.coldm_cantidad.Name = "coldm_cantidad";
            this.coldm_cantidad.Visible = true;
            this.coldm_cantidad.VisibleIndex = 10;
            this.coldm_cantidad.Width = 89;
            // 
            // colmv_costo
            // 
            this.colmv_costo.Caption = "mv_costo";
            this.colmv_costo.FieldName = "mv_costo";
            this.colmv_costo.Name = "colmv_costo";
            this.colmv_costo.Visible = true;
            this.colmv_costo.VisibleIndex = 11;
            this.colmv_costo.Width = 89;
            // 
            // colcm_fecha
            // 
            this.colcm_fecha.Caption = "cm_fecha";
            this.colcm_fecha.FieldName = "cm_fecha";
            this.colcm_fecha.Name = "colcm_fecha";
            this.colcm_fecha.Visible = true;
            this.colcm_fecha.VisibleIndex = 3;
            this.colcm_fecha.Width = 89;
            // 
            // colsubtotal
            // 
            this.colsubtotal.Caption = "subtotal";
            this.colsubtotal.FieldName = "subtotal";
            this.colsubtotal.Name = "colsubtotal";
            this.colsubtotal.Visible = true;
            this.colsubtotal.VisibleIndex = 12;
            this.colsubtotal.Width = 113;
            // 
            // tbSucursalInfoBindingSource
            // 
            this.tbSucursalInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Sucursal_Info);
            // 
            // tbBodegaInfoBindingSource
            // 
            this.tbBodegaInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Bodega_Info);
            // 
            // inmoviinventipoInfoBindingSource
            // 
            this.inmoviinventipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_movi_inven_tipo_Info);
            // 
            // colChek
            // 
            this.colChek.Caption = "*";
            this.colChek.FieldName = "check";
            this.colChek.Name = "colChek";
            this.colChek.Visible = true;
            this.colChek.VisibleIndex = 0;
            this.colChek.Width = 30;
            // 
            // FrmIn_ContabilizarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 511);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmIn_ContabilizarInventario";
            this.Load += new System.EventHandler(this.frmIn_ContabilizarInventario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMoviInven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMoviInven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSucursalInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBodegaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinventipoInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tbSucursalInfoBindingSource;
        private System.Windows.Forms.BindingSource tbBodegaInfoBindingSource;
        private System.Windows.Forms.BindingSource inmoviinventipoInfoBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer TimerBuscar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_buscar;
        private Controles.UCIn_Sucursal_Bodega ucIn_Sucursal_Bodega;
        private System.Windows.Forms.ToolStripButton btn_contabilizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private DevExpress.XtraGrid.GridControl gridControlMoviInven;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMoviInven;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNumMovi;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_tipo_mov_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_tipo_movi;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_producto;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_producto;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colsubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colChek;
    }
}