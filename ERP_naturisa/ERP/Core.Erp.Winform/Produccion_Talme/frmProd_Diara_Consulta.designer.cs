namespace Core.Erp.Winform.Produccion_Talme
{
    partial class frmProd_Diara_Consulta
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Sucursal", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdBodega", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Bodega", 2);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPedido", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente", 4);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente", 6);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVendedor", 7);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Vendedor", 8);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cp_fecha", 9);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cp_diasPlazo", 10);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cp_fechaVencimiento", 11);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cp_observacion", 12);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cp_tipopago", 13);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoAprobacion", 14);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoAprobacion", 15);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado", 16);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 17);
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.gridControlOrdeCompra = new DevExpress.XtraGrid.GridControl();
            this.prodGestionProductivaLaminadoCusTalmeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGestionProductiva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_Orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEficienciaProduccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_JefeTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_turno_ini = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_turno_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.uGrid_Pedido = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.btn_consultar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdeCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodGestionProductivaLaminadoCusTalmeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uGrid_Pedido)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
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
            this.splitContainer1.Panel1.Controls.Add(this.btn_buscar);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaFin);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaIni);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControlOrdeCompra);
            this.splitContainer1.Panel2.Controls.Add(this.uGrid_Pedido);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 414);
            this.splitContainer1.SplitterDistance = 38;
            this.splitContainer1.TabIndex = 14;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = global::Core.Erp.Winform.Properties.Resources.buscar;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(380, 6);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(88, 28);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha de Inicio:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(262, 12);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaFin.TabIndex = 9;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(93, 13);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaIni.TabIndex = 8;
            // 
            // gridControlOrdeCompra
            // 
            this.gridControlOrdeCompra.DataSource = this.prodGestionProductivaLaminadoCusTalmeInfoBindingSource;
            this.gridControlOrdeCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrdeCompra.Location = new System.Drawing.Point(0, 0);
            this.gridControlOrdeCompra.MainView = this.gridView;
            this.gridControlOrdeCompra.Name = "gridControlOrdeCompra";
            this.gridControlOrdeCompra.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControlOrdeCompra.Size = new System.Drawing.Size(1061, 372);
            this.gridControlOrdeCompra.TabIndex = 8;
            this.gridControlOrdeCompra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // prodGestionProductivaLaminadoCusTalmeInfoBindingSource
            // 
            this.prodGestionProductivaLaminadoCusTalmeInfoBindingSource.DataSource = typeof(Core.Erp.Info.Produccion_Talme.prod_GestionProductivaLaminado_CusTalme_Info);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGestionProductiva,
            this.colNum_Orden,
            this.colEficienciaProduccion,
            this.colEstado,
            this.colFecha,
            this.colNombre_JefeTurno,
            this.colDescripcion,
            this.colhora_turno_ini,
            this.colhora_turno_fin});
            this.gridView.GridControl = this.gridControlOrdeCompra;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_RowCellClick);
            //this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // colIdGestionProductiva
            // 
            this.colIdGestionProductiva.Caption = "Id Gestion Productiva";
            this.colIdGestionProductiva.FieldName = "IdGestionProductiva";
            this.colIdGestionProductiva.Name = "colIdGestionProductiva";
            this.colIdGestionProductiva.Visible = true;
            this.colIdGestionProductiva.VisibleIndex = 0;
            this.colIdGestionProductiva.Width = 46;
            // 
            // colNum_Orden
            // 
            this.colNum_Orden.Caption = "Num. Orden";
            this.colNum_Orden.FieldName = "Num_Orden";
            this.colNum_Orden.Name = "colNum_Orden";
            this.colNum_Orden.Visible = true;
            this.colNum_Orden.VisibleIndex = 1;
            this.colNum_Orden.Width = 85;
            // 
            // colEficienciaProduccion
            // 
            this.colEficienciaProduccion.Caption = "Eficiencia Produccion";
            this.colEficienciaProduccion.FieldName = "EficienciaProduccion";
            this.colEficienciaProduccion.Name = "colEficienciaProduccion";
            this.colEficienciaProduccion.Visible = true;
            this.colEficienciaProduccion.VisibleIndex = 6;
            this.colEficienciaProduccion.Width = 133;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 8;
            this.colEstado.Width = 147;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 7;
            this.colFecha.Width = 133;
            // 
            // colNombre_JefeTurno
            // 
            this.colNombre_JefeTurno.Caption = "Jefe De Turno";
            this.colNombre_JefeTurno.FieldName = "Nombre_JefeTurno";
            this.colNombre_JefeTurno.Name = "colNombre_JefeTurno";
            this.colNombre_JefeTurno.Visible = true;
            this.colNombre_JefeTurno.VisibleIndex = 2;
            this.colNombre_JefeTurno.Width = 154;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Turno";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 3;
            this.colDescripcion.Width = 154;
            // 
            // colhora_turno_ini
            // 
            this.colhora_turno_ini.Caption = "Hora Inicio Turno";
            this.colhora_turno_ini.FieldName = "hora_turno_ini";
            this.colhora_turno_ini.Name = "colhora_turno_ini";
            this.colhora_turno_ini.Visible = true;
            this.colhora_turno_ini.VisibleIndex = 4;
            this.colhora_turno_ini.Width = 101;
            // 
            // colhora_turno_fin
            // 
            this.colhora_turno_fin.Caption = "Hora Fin Turno";
            this.colhora_turno_fin.FieldName = "hora_turno_fin";
            this.colhora_turno_fin.Name = "colhora_turno_fin";
            this.colhora_turno_fin.Visible = true;
            this.colhora_turno_fin.VisibleIndex = 5;
            this.colhora_turno_fin.Width = 90;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.AppearanceReadOnly.Image = global::Core.Erp.Winform.Properties.Resources.imprimir;
            this.repositoryItemPictureEdit1.AppearanceReadOnly.Options.UseImage = true;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.ReadOnly = true;
            this.repositoryItemPictureEdit1.ShowScrollBars = true;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // uGrid_Pedido
            // 
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn10.Header.VisiblePosition = 1;
            ultraGridColumn11.Header.VisiblePosition = 2;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn12.Header.VisiblePosition = 3;
            ultraGridColumn13.Header.VisiblePosition = 4;
            ultraGridColumn14.Header.VisiblePosition = 6;
            ultraGridColumn14.Hidden = true;
            ultraGridColumn15.Header.VisiblePosition = 7;
            ultraGridColumn15.Hidden = true;
            ultraGridColumn16.Header.VisiblePosition = 8;
            ultraGridColumn17.Header.VisiblePosition = 9;
            ultraGridColumn17.Hidden = true;
            ultraGridColumn18.Header.VisiblePosition = 10;
            ultraGridColumn19.Header.Caption = "Fecha";
            ultraGridColumn19.Header.VisiblePosition = 11;
            ultraGridColumn20.Header.Caption = "Días de Plazo";
            ultraGridColumn20.Header.VisiblePosition = 12;
            ultraGridColumn21.Header.Caption = "Fecha Venc.";
            ultraGridColumn21.Header.VisiblePosition = 13;
            ultraGridColumn22.Header.Caption = "Observacion";
            ultraGridColumn22.Header.VisiblePosition = 14;
            ultraGridColumn23.Header.Caption = "Tipo de Pago";
            ultraGridColumn23.Header.VisiblePosition = 15;
            ultraGridColumn24.DataType = typeof(bool);
            ultraGridColumn24.Header.VisiblePosition = 16;
            ultraGridColumn24.Hidden = true;
            ultraGridColumn25.Header.Caption = "Estado de Aprobación";
            ultraGridColumn25.Header.VisiblePosition = 17;
            ultraGridColumn26.Header.Caption = "Estado del Pedido";
            ultraGridColumn26.Header.VisiblePosition = 18;
            ultraGridColumn2.Header.VisiblePosition = 5;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25,
            ultraGridColumn26,
            ultraGridColumn2});
            this.uGrid_Pedido.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.uGrid_Pedido.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.uGrid_Pedido.DisplayLayout.Override.MaxSelectedCells = 0;
            this.uGrid_Pedido.DisplayLayout.Override.MaxSelectedRows = 1;
            this.uGrid_Pedido.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.uGrid_Pedido.Location = new System.Drawing.Point(0, 0);
            this.uGrid_Pedido.Name = "uGrid_Pedido";
            this.uGrid_Pedido.Size = new System.Drawing.Size(1011, 128);
            this.uGrid_Pedido.TabIndex = 7;
            this.uGrid_Pedido.Text = "Facturación: Consulta de Pedidos";
            this.uGrid_Pedido.Visible = false;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Image = global::Core.Erp.Winform.Properties.Resources.buscar;
            this.btn_consultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(78, 22);
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.toolStripSeparator2,
            this.btn_consultar,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator5,
            this.btn_salir,
            this.toolStripLabel1,
            this.toolStripSeparator6,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1061, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Image = global::Core.Erp.Winform.Properties.Resources.nuevo;
            this.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(62, 22);
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Core.Erp.Winform.Properties.Resources.imprimir;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton2.Text = "Imprimir";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(166, 22);
            this.toolStripLabel1.Text = "                                                     ";
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
            // frmProd_Diara_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 439);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmProd_Diara_Consulta";
            this.Text = "Gestion Productiva Laminados Consulta";
            this.Load += new System.EventHandler(this.frmProd_Diara_Consulta_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdeCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodGestionProductivaLaminadoCusTalmeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uGrid_Pedido)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private DevExpress.XtraGrid.GridControl gridControlOrdeCompra;
        private System.Windows.Forms.BindingSource prodGestionProductivaLaminadoCusTalmeInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGestionProductiva;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_Orden;
        private DevExpress.XtraGrid.Columns.GridColumn colEficienciaProduccion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGrid_Pedido;
        private System.Windows.Forms.ToolStripButton btn_consultar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_JefeTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_turno_ini;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_turno_fin;
    }
}