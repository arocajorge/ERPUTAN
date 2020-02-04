namespace Core.Erp.Winform.Inventario
{
    partial class frmIn_Ajuste_Inventario_fisico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIn_Ajuste_Inventario_fisico));
            this.TspMenu = new System.Windows.Forms.ToolStrip();
            this.btn_ok = new System.Windows.Forms.ToolStripButton();
            this.btnGrabarySalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnAprobar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewAjusteInventario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RutaPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cod_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockFisico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CantidadAjustada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Calculada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEstadoAprob = new System.Windows.Forms.ComboBox();
            this.inCatalogoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAnulado = new System.Windows.Forms.Label();
            this.grbMovEgreso = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumMoviAjustEgreso = new System.Windows.Forms.TextBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbMovIngres = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoviAjustIngreso = new System.Windows.Forms.TextBox();
            this.pnlSucBod = new System.Windows.Forms.Panel();
            this.txtNumAjusteFisico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.TspMenu.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAjusteInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inCatalogoInfoBindingSource)).BeginInit();
            this.grbMovEgreso.SuspendLayout();
            this.grbMovIngres.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // TspMenu
            // 
            this.TspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ok,
            this.btnGrabarySalir,
            this.toolStripButton1,
            this.btn_salir,
            this.btnImprimir,
            this.btnAprobar});
            this.TspMenu.Location = new System.Drawing.Point(0, 0);
            this.TspMenu.Name = "TspMenu";
            this.TspMenu.Size = new System.Drawing.Size(911, 25);
            this.TspMenu.TabIndex = 24;
            this.TspMenu.Text = "toolStrip1";
            this.TspMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TspMenu_ItemClicked);
            // 
            // btn_ok
            // 
            this.btn_ok.Image = global::Core.Erp.Winform.Properties.Resources.FormEdit;
            this.btn_ok.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(114, 22);
            this.btn_ok.Text = "toolStripButton1";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btnGrabarySalir
            // 
            this.btnGrabarySalir.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabarySalir.Image")));
            this.btnGrabarySalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrabarySalir.Name = "btnGrabarySalir";
            this.btnGrabarySalir.Size = new System.Drawing.Size(96, 22);
            this.btnGrabarySalir.Text = "Grabar y Salir";
            this.btnGrabarySalir.Click += new System.EventHandler(this.btnGrabarySalir_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Core.Erp.Winform.Properties.Resources.eliminar;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton1.Text = "Anular";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "&Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Core.Erp.Winform.Properties.Resources.imprimir;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnAprobar
            // 
            this.btnAprobar.Image = global::Core.Erp.Winform.Properties.Resources._1366257834_20418;
            this.btnAprobar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(70, 22);
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(911, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Controls.Add(this.groupBox3);
            this.pnlGeneral.Controls.Add(this.groupBox1);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(0, 25);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(911, 547);
            this.pnlGeneral.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridControl1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(911, 338);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 16);
            this.gridControl1.MainView = this.gridViewAjusteInventario;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gridControl1.Size = new System.Drawing.Size(905, 319);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAjusteInventario});
            // 
            // gridViewAjusteInventario
            // 
            this.gridViewAjusteInventario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RutaPadre,
            this.Cod_producto,
            this.Producto,
            this.Marca,
            this.pr_stock,
            this.StockFisico,
            this.CantidadAjustada,
            this.IdProducto,
            this.Calculada});
            this.gridViewAjusteInventario.GridControl = this.gridControl1;
            this.gridViewAjusteInventario.Name = "gridViewAjusteInventario";
            this.gridViewAjusteInventario.OptionsView.ShowAutoFilterRow = true;
            this.gridViewAjusteInventario.OptionsView.ShowFooter = true;
            this.gridViewAjusteInventario.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridViewAjusteInventario.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewAjusteInventario_CellValueChanged);
            this.gridViewAjusteInventario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewAjusteInventario_KeyDown);
            // 
            // RutaPadre
            // 
            this.RutaPadre.Caption = "Categoria";
            this.RutaPadre.FieldName = "RutaPadre";
            this.RutaPadre.Name = "RutaPadre";
            this.RutaPadre.OptionsColumn.AllowEdit = false;
            this.RutaPadre.Visible = true;
            this.RutaPadre.VisibleIndex = 2;
            // 
            // Cod_producto
            // 
            this.Cod_producto.Caption = "Cod. Producto";
            this.Cod_producto.FieldName = "pr_codigo";
            this.Cod_producto.Name = "Cod_producto";
            this.Cod_producto.OptionsColumn.AllowEdit = false;
            this.Cod_producto.Visible = true;
            this.Cod_producto.VisibleIndex = 0;
            this.Cod_producto.Width = 47;
            // 
            // Producto
            // 
            this.Producto.Caption = "Producto";
            this.Producto.FieldName = "pr_descripcion";
            this.Producto.Name = "Producto";
            this.Producto.OptionsColumn.AllowEdit = false;
            this.Producto.Visible = true;
            this.Producto.VisibleIndex = 1;
            this.Producto.Width = 182;
            // 
            // Marca
            // 
            this.Marca.Caption = "Marca";
            this.Marca.FieldName = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.OptionsColumn.AllowEdit = false;
            this.Marca.Visible = true;
            this.Marca.VisibleIndex = 3;
            this.Marca.Width = 74;
            // 
            // pr_stock
            // 
            this.pr_stock.Caption = "Stock Sistema";
            this.pr_stock.FieldName = "pr_stock";
            this.pr_stock.Name = "pr_stock";
            this.pr_stock.OptionsColumn.AllowEdit = false;
            this.pr_stock.Visible = true;
            this.pr_stock.VisibleIndex = 5;
            this.pr_stock.Width = 190;
            // 
            // StockFisico
            // 
            this.StockFisico.Caption = "Stock Fisico";
            this.StockFisico.ColumnEdit = this.repositoryItemTextEdit2;
            this.StockFisico.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.StockFisico.FieldName = "StockFisico";
            this.StockFisico.Name = "StockFisico";
            this.StockFisico.Visible = true;
            this.StockFisico.VisibleIndex = 4;
            this.StockFisico.Width = 190;
            // 
            // CantidadAjustada
            // 
            this.CantidadAjustada.Caption = "Cantidad Ajustada";
            this.CantidadAjustada.FieldName = "CantidadAjustada";
            this.CantidadAjustada.Name = "CantidadAjustada";
            this.CantidadAjustada.OptionsColumn.AllowEdit = false;
            this.CantidadAjustada.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.CantidadAjustada.Visible = true;
            this.CantidadAjustada.VisibleIndex = 6;
            this.CantidadAjustada.Width = 204;
            // 
            // IdProducto
            // 
            this.IdProducto.Caption = "IdProducto";
            this.IdProducto.FieldName = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            // 
            // Calculada
            // 
            this.Calculada.Caption = "Calculada";
            this.Calculada.FieldName = "Calculada";
            this.Calculada.Name = "Calculada";
            this.Calculada.UnboundExpression = "[StockFisico]-[pr_stock]";
            this.Calculada.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEstadoAprob);
            this.groupBox1.Controls.Add(this.lblAnulado);
            this.groupBox1.Controls.Add(this.grbMovEgreso);
            this.groupBox1.Controls.Add(this.dtp_fecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.grbMovIngres);
            this.groupBox1.Controls.Add(this.pnlSucBod);
            this.groupBox1.Controls.Add(this.txtNumAjusteFisico);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbEstadoAprob
            // 
            this.cmbEstadoAprob.DataSource = this.inCatalogoInfoBindingSource;
            this.cmbEstadoAprob.DisplayMember = "Nombre";
            this.cmbEstadoAprob.FormattingEnabled = true;
            this.cmbEstadoAprob.Location = new System.Drawing.Point(532, 56);
            this.cmbEstadoAprob.Name = "cmbEstadoAprob";
            this.cmbEstadoAprob.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoAprob.TabIndex = 14;
            this.cmbEstadoAprob.ValueMember = "IdCatalogo";
            // 
            // inCatalogoInfoBindingSource
            // 
            this.inCatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_Catalogo_Info);
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(474, 16);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(179, 31);
            this.lblAnulado.TabIndex = 13;
            this.lblAnulado.Text = "***Anulado***";
            this.lblAnulado.Visible = false;
            // 
            // grbMovEgreso
            // 
            this.grbMovEgreso.Controls.Add(this.label3);
            this.grbMovEgreso.Controls.Add(this.txtNumMoviAjustEgreso);
            this.grbMovEgreso.Location = new System.Drawing.Point(458, 83);
            this.grbMovEgreso.Name = "grbMovEgreso";
            this.grbMovEgreso.Size = new System.Drawing.Size(444, 63);
            this.grbMovEgreso.TabIndex = 1;
            this.grbMovEgreso.TabStop = false;
            this.grbMovEgreso.Text = "Movimiento x Egreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(121, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "# Ajuste x Egreso";
            // 
            // txtNumMoviAjustEgreso
            // 
            this.txtNumMoviAjustEgreso.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumMoviAjustEgreso.Location = new System.Drawing.Point(227, 40);
            this.txtNumMoviAjustEgreso.Name = "txtNumMoviAjustEgreso";
            this.txtNumMoviAjustEgreso.ReadOnly = true;
            this.txtNumMoviAjustEgreso.Size = new System.Drawing.Size(60, 20);
            this.txtNumMoviAjustEgreso.TabIndex = 3;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(779, 46);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(120, 20);
            this.dtp_fecha.TabIndex = 5;
            this.dtp_fecha.ValueChanged += new System.EventHandler(this.dtp_fecha_ValueChanged);
            this.dtp_fecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtp_fecha_KeyPress);
            this.dtp_fecha.Leave += new System.EventHandler(this.dtp_fecha_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha";
            // 
            // grbMovIngres
            // 
            this.grbMovIngres.Controls.Add(this.label4);
            this.grbMovIngres.Controls.Add(this.txtMoviAjustIngreso);
            this.grbMovIngres.Location = new System.Drawing.Point(6, 83);
            this.grbMovIngres.Name = "grbMovIngres";
            this.grbMovIngres.Size = new System.Drawing.Size(433, 63);
            this.grbMovIngres.TabIndex = 1;
            this.grbMovIngres.TabStop = false;
            this.grbMovIngres.Text = "Movimiento x Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(133, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "# Ajuste x Ingreso";
            // 
            // txtMoviAjustIngreso
            // 
            this.txtMoviAjustIngreso.BackColor = System.Drawing.SystemColors.Window;
            this.txtMoviAjustIngreso.Location = new System.Drawing.Point(239, 40);
            this.txtMoviAjustIngreso.Name = "txtMoviAjustIngreso";
            this.txtMoviAjustIngreso.ReadOnly = true;
            this.txtMoviAjustIngreso.Size = new System.Drawing.Size(60, 20);
            this.txtMoviAjustIngreso.TabIndex = 3;
            // 
            // pnlSucBod
            // 
            this.pnlSucBod.Location = new System.Drawing.Point(6, 6);
            this.pnlSucBod.Name = "pnlSucBod";
            this.pnlSucBod.Size = new System.Drawing.Size(462, 71);
            this.pnlSucBod.TabIndex = 0;
            // 
            // txtNumAjusteFisico
            // 
            this.txtNumAjusteFisico.Location = new System.Drawing.Point(779, 15);
            this.txtNumAjusteFisico.Name = "txtNumAjusteFisico";
            this.txtNumAjusteFisico.Size = new System.Drawing.Size(120, 20);
            this.txtNumAjusteFisico.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "# Ajuste Fisico";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObservacion);
            this.groupBox2.Location = new System.Drawing.Point(6, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 52);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Observacion";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacion.Location = new System.Drawing.Point(3, 16);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(893, 33);
            this.txtObservacion.TabIndex = 0;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = "[0-9]+[,]?[0-9]{2}?";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit2.Mask.ShowPlaceHolders = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // frmIn_Ajuste_Inventario_fisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(911, 594);
            this.Controls.Add(this.pnlGeneral);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TspMenu);
            this.Name = "frmIn_Ajuste_Inventario_fisico";
            this.Text = "Mantenimiento Ajuste Inventario fisico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIn_Ajuste_Inventario_fisico_FormClosing);
            this.Load += new System.EventHandler(this.frmIn_Ajuste_Inventario_fisico_Load);
            this.TspMenu.ResumeLayout(false);
            this.TspMenu.PerformLayout();
            this.pnlGeneral.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAjusteInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inCatalogoInfoBindingSource)).EndInit();
            this.grbMovEgreso.ResumeLayout(false);
            this.grbMovEgreso.PerformLayout();
            this.grbMovIngres.ResumeLayout(false);
            this.grbMovIngres.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TspMenu;
        private System.Windows.Forms.ToolStripButton btn_ok;
        private System.Windows.Forms.ToolStripButton btnGrabarySalir;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Panel pnlSucBod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbMovEgreso;
        private System.Windows.Forms.GroupBox grbMovIngres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumAjusteFisico;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.TextBox txtNumMoviAjustEgreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMoviAjustIngreso;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAjusteInventario;
        private DevExpress.XtraGrid.Columns.GridColumn Cod_producto;
        private DevExpress.XtraGrid.Columns.GridColumn Producto;
        private DevExpress.XtraGrid.Columns.GridColumn Marca;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.Columns.GridColumn pr_stock;
        private DevExpress.XtraGrid.Columns.GridColumn StockFisico;
        private DevExpress.XtraGrid.Columns.GridColumn CantidadAjustada;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Calculada;
        private DevExpress.XtraGrid.Columns.GridColumn RutaPadre;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ComboBox cmbEstadoAprob;
        private System.Windows.Forms.BindingSource inCatalogoInfoBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton btnAprobar;
        private DevExpress.XtraGrid.Columns.GridColumn IdProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
    }
}