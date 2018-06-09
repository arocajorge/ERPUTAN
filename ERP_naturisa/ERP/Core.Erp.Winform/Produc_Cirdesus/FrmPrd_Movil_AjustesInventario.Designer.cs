namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_Movil_AjustesInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrd_Movil_AjustesInventario));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_tipoMoviInven = new System.Windows.Forms.ComboBox();
            this.opt_egreso = new System.Windows.Forms.RadioButton();
            this.opt_ingreso = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigoAjuste = new System.Windows.Forms.TextBox();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UCSucBod = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumAjuste = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControlAjustes = new DevExpress.XtraGrid.GridControl();
            this.gridViewAjustes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovi_inven_tipo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNumMovi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_tipo_movi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProducto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_ManejaSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_stock_ante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_stock_actu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodMoviInven1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTipoMoviInven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoMoviInven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIcoCodBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colIcoProdCons = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colIcoProdNuevo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridCtrlDespacho = new DevExpress.XtraGrid.GridControl();
            this.gridVwDespacho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdDespacho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenTaller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoBarraMaestro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colot_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGrabar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlDespacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwDespacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(20, 14);
            this.tabControl1.Location = new System.Drawing.Point(0, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(224, 267);
            this.tabControl1.TabIndex = 125;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 18);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(216, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DATOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtcodigoAjuste);
            this.panel1.Controls.Add(this.lblAnulado);
            this.panel1.Controls.Add(this.txtObservacion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.UCSucBod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNumAjuste);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 239);
            this.panel1.TabIndex = 124;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_tipoMoviInven);
            this.groupBox2.Controls.Add(this.opt_egreso);
            this.groupBox2.Controls.Add(this.opt_ingreso);
            this.groupBox2.Location = new System.Drawing.Point(7, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 73);
            this.groupBox2.TabIndex = 133;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TIPO DE MOVIMIENTO";
            // 
            // cmb_tipoMoviInven
            // 
            this.cmb_tipoMoviInven.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoMoviInven.FormattingEnabled = true;
            this.cmb_tipoMoviInven.Location = new System.Drawing.Point(13, 43);
            this.cmb_tipoMoviInven.Name = "cmb_tipoMoviInven";
            this.cmb_tipoMoviInven.Size = new System.Drawing.Size(180, 20);
            this.cmb_tipoMoviInven.TabIndex = 3;
            this.cmb_tipoMoviInven.SelectedIndexChanged += new System.EventHandler(this.cmb_tipoMoviInven_SelectedIndexChanged);
            // 
            // opt_egreso
            // 
            this.opt_egreso.AutoSize = true;
            this.opt_egreso.Location = new System.Drawing.Point(113, 21);
            this.opt_egreso.Name = "opt_egreso";
            this.opt_egreso.Size = new System.Drawing.Size(62, 16);
            this.opt_egreso.TabIndex = 1;
            this.opt_egreso.Text = "EGRESO";
            this.opt_egreso.UseVisualStyleBackColor = true;
            this.opt_egreso.CheckedChanged += new System.EventHandler(this.opt_egreso_CheckedChanged);
            // 
            // opt_ingreso
            // 
            this.opt_ingreso.AutoSize = true;
            this.opt_ingreso.Checked = true;
            this.opt_ingreso.Location = new System.Drawing.Point(17, 21);
            this.opt_ingreso.Name = "opt_ingreso";
            this.opt_ingreso.Size = new System.Drawing.Size(66, 16);
            this.opt_ingreso.TabIndex = 0;
            this.opt_ingreso.TabStop = true;
            this.opt_ingreso.Text = "INGRESO";
            this.opt_ingreso.UseVisualStyleBackColor = true;
            this.opt_ingreso.CheckedChanged += new System.EventHandler(this.opt_ingreso_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 132;
            this.label2.Text = "COD:";
            // 
            // txtcodigoAjuste
            // 
            this.txtcodigoAjuste.Location = new System.Drawing.Point(50, 26);
            this.txtcodigoAjuste.Name = "txtcodigoAjuste";
            this.txtcodigoAjuste.Size = new System.Drawing.Size(157, 17);
            this.txtcodigoAjuste.TabIndex = 131;
            // 
            // lblAnulado
            // 
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(46, 199);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(95, 15);
            this.lblAnulado.TabIndex = 128;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnulado.Visible = false;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.txtObservacion.Location = new System.Drawing.Point(30, 177);
            this.txtObservacion.MaxLength = 1000;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(170, 53);
            this.txtObservacion.TabIndex = 130;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label8.Location = new System.Drawing.Point(0, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 12);
            this.label8.TabIndex = 129;
            this.label8.Text = "OBS:";
            // 
            // UCSucBod
            // 
            this.UCSucBod.Location = new System.Drawing.Point(3, 46);
            this.UCSucBod.Name = "UCSucBod";
            this.UCSucBod.Size = new System.Drawing.Size(204, 45);
            this.UCSucBod.TabIndex = 125;
            this.UCSucBod.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label1.Location = new System.Drawing.Point(89, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 116;
            this.label1.Text = "FEC:";
            // 
            // txtNumAjuste
            // 
            this.txtNumAjuste.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNumAjuste.Enabled = false;
            this.txtNumAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.txtNumAjuste.Location = new System.Drawing.Point(36, 6);
            this.txtNumAjuste.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumAjuste.MaximumSize = new System.Drawing.Size(30, 15);
            this.txtNumAjuste.Name = "txtNumAjuste";
            this.txtNumAjuste.ReadOnly = true;
            this.txtNumAjuste.Size = new System.Drawing.Size(30, 17);
            this.txtNumAjuste.TabIndex = 115;
            this.txtNumAjuste.Text = "0";
            this.txtNumAjuste.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label6.Location = new System.Drawing.Point(4, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 114;
            this.label6.Text = "N#";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(120, 6);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.MaximumSize = new System.Drawing.Size(80, 15);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(80, 15);
            this.dtpFecha.TabIndex = 117;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.gridControlAjustes);
            this.tabPage2.Controls.Add(this.gridCtrlDespacho);
            this.tabPage2.Location = new System.Drawing.Point(4, 18);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(216, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DETALLE";
            // 
            // gridControlAjustes
            // 
            this.gridControlAjustes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAjustes.Location = new System.Drawing.Point(3, 3);
            this.gridControlAjustes.MainView = this.gridViewAjustes;
            this.gridControlAjustes.Name = "gridControlAjustes";
            this.gridControlAjustes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProducto,
            this.repositoryItemPictureEdit1,
            this.repositoryItemPictureEdit2,
            this.repositoryItemPictureEdit3});
            this.gridControlAjustes.Size = new System.Drawing.Size(210, 239);
            this.gridControlAjustes.TabIndex = 72;
            this.gridControlAjustes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAjustes});
            // 
            // gridViewAjustes
            // 
            this.gridViewAjustes.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAjustes.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewAjustes.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.gridViewAjustes.Appearance.Row.Options.UseFont = true;
            this.gridViewAjustes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colIdBodega1,
            this.colIdMovi_inven_tipo1,
            this.colIdNumMovi1,
            this.gridColumn3,
            this.colmv_tipo_movi,
            this.gridColumn4,
            this.coldm_cantidad,
            this.coldm_stock_ante,
            this.coldm_stock_actu,
            this.coldm_observacion,
            this.colCodMoviInven1,
            this.colCodTipoMoviInven,
            this.colTipoMoviInven,
            this.colCodBarra,
            this.colIcoCodBarra,
            this.colIcoProdCons,
            this.colIcoProdNuevo});
            this.gridViewAjustes.GridControl = this.gridControlAjustes;
            this.gridViewAjustes.Name = "gridViewAjustes";
            this.gridViewAjustes.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewAjustes.OptionsView.ShowGroupPanel = false;
            this.gridViewAjustes.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldm_cantidad, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewAjustes.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewAjustes_RowCellClick);
            this.gridViewAjustes.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewAjustes_CellValueChanged);
            this.gridViewAjustes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewAjustes_KeyDown);
            this.gridViewAjustes.RowCountChanged += new System.EventHandler(this.gridViewAjustes_RowCountChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdEmpresa";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "IdSucursal";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // colIdBodega1
            // 
            this.colIdBodega1.FieldName = "IdBodega";
            this.colIdBodega1.Name = "colIdBodega1";
            // 
            // colIdMovi_inven_tipo1
            // 
            this.colIdMovi_inven_tipo1.FieldName = "IdMovi_inven_tipo";
            this.colIdMovi_inven_tipo1.Name = "colIdMovi_inven_tipo1";
            // 
            // colIdNumMovi1
            // 
            this.colIdNumMovi1.FieldName = "IdNumMovi";
            this.colIdNumMovi1.Name = "colIdNumMovi1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "mv_Secuencia";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // colmv_tipo_movi
            // 
            this.colmv_tipo_movi.FieldName = "mv_tipo_movi";
            this.colmv_tipo_movi.Name = "colmv_tipo_movi";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "PROD";
            this.gridColumn4.ColumnEdit = this.cmbProducto;
            this.gridColumn4.FieldName = "IdProducto";
            this.gridColumn4.MinWidth = 120;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 260;
            // 
            // cmbProducto
            // 
            this.cmbProducto.AutoHeight = false;
            this.cmbProducto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducto.DisplayMember = "pr_descripcion";
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.ValueMember = "IdProducto";
            this.cmbProducto.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto1,
            this.gridColumn5,
            this.colcod_producto,
            this.colpr_ManejaSerie});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto1
            // 
            this.colIdProducto1.Caption = "Id";
            this.colIdProducto1.FieldName = "IdProducto";
            this.colIdProducto1.Name = "colIdProducto1";
            this.colIdProducto1.Visible = true;
            this.colIdProducto1.VisibleIndex = 2;
            this.colIdProducto1.Width = 64;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Producto";
            this.gridColumn5.FieldName = "pr_descripcion";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 820;
            // 
            // colcod_producto
            // 
            this.colcod_producto.Caption = "Código";
            this.colcod_producto.FieldName = "pr_codigo";
            this.colcod_producto.Name = "colcod_producto";
            this.colcod_producto.Visible = true;
            this.colcod_producto.VisibleIndex = 1;
            this.colcod_producto.Width = 283;
            // 
            // colpr_ManejaSerie
            // 
            this.colpr_ManejaSerie.Caption = "Trazabilidad";
            this.colpr_ManejaSerie.FieldName = "pr_ManejaSeries";
            this.colpr_ManejaSerie.Name = "colpr_ManejaSerie";
            this.colpr_ManejaSerie.Visible = true;
            this.colpr_ManejaSerie.VisibleIndex = 3;
            this.colpr_ManejaSerie.Width = 70;
            // 
            // coldm_cantidad
            // 
            this.coldm_cantidad.Caption = "CANTIDAD";
            this.coldm_cantidad.FieldName = "dm_cantidad";
            this.coldm_cantidad.Name = "coldm_cantidad";
            this.coldm_cantidad.Visible = true;
            this.coldm_cantidad.VisibleIndex = 5;
            this.coldm_cantidad.Width = 76;
            // 
            // coldm_stock_ante
            // 
            this.coldm_stock_ante.FieldName = "dm_stock_ante";
            this.coldm_stock_ante.Name = "coldm_stock_ante";
            // 
            // coldm_stock_actu
            // 
            this.coldm_stock_actu.FieldName = "dm_stock_actu";
            this.coldm_stock_actu.Name = "coldm_stock_actu";
            // 
            // coldm_observacion
            // 
            this.coldm_observacion.Caption = "OBSERVACIÓN";
            this.coldm_observacion.FieldName = "dm_observacion";
            this.coldm_observacion.MinWidth = 120;
            this.coldm_observacion.Name = "coldm_observacion";
            this.coldm_observacion.Visible = true;
            this.coldm_observacion.VisibleIndex = 6;
            this.coldm_observacion.Width = 292;
            // 
            // colCodMoviInven1
            // 
            this.colCodMoviInven1.FieldName = "CodMoviInven";
            this.colCodMoviInven1.Name = "colCodMoviInven1";
            // 
            // colCodTipoMoviInven
            // 
            this.colCodTipoMoviInven.FieldName = "CodTipoMoviInven";
            this.colCodTipoMoviInven.Name = "colCodTipoMoviInven";
            // 
            // colTipoMoviInven
            // 
            this.colTipoMoviInven.FieldName = "TipoMoviInven";
            this.colTipoMoviInven.Name = "colTipoMoviInven";
            // 
            // colCodBarra
            // 
            this.colCodBarra.Caption = "CB";
            this.colCodBarra.FieldName = "CodigoBarra";
            this.colCodBarra.MinWidth = 120;
            this.colCodBarra.Name = "colCodBarra";
            this.colCodBarra.Visible = true;
            this.colCodBarra.VisibleIndex = 0;
            this.colCodBarra.Width = 282;
            // 
            // colIcoCodBarra
            // 
            this.colIcoCodBarra.Caption = "|||";
            this.colIcoCodBarra.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colIcoCodBarra.FieldName = "IcoCodBarra";
            this.colIcoCodBarra.Name = "colIcoCodBarra";
            this.colIcoCodBarra.OptionsColumn.AllowEdit = false;
            this.colIcoCodBarra.OptionsColumn.ReadOnly = true;
            this.colIcoCodBarra.Visible = true;
            this.colIcoCodBarra.VisibleIndex = 1;
            this.colIcoCodBarra.Width = 20;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // colIcoProdCons
            // 
            this.colIcoProdCons.Caption = "...";
            this.colIcoProdCons.ColumnEdit = this.repositoryItemPictureEdit2;
            this.colIcoProdCons.FieldName = "IcoProdCons";
            this.colIcoProdCons.Name = "colIcoProdCons";
            this.colIcoProdCons.OptionsColumn.AllowEdit = false;
            this.colIcoProdCons.OptionsColumn.ReadOnly = true;
            this.colIcoProdCons.Visible = true;
            this.colIcoProdCons.VisibleIndex = 3;
            this.colIcoProdCons.Width = 25;
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            // 
            // colIcoProdNuevo
            // 
            this.colIcoProdNuevo.Caption = "*-*";
            this.colIcoProdNuevo.ColumnEdit = this.repositoryItemPictureEdit3;
            this.colIcoProdNuevo.FieldName = "IcoProdNuevo";
            this.colIcoProdNuevo.Name = "colIcoProdNuevo";
            this.colIcoProdNuevo.OptionsColumn.AllowEdit = false;
            this.colIcoProdNuevo.OptionsColumn.ReadOnly = true;
            this.colIcoProdNuevo.Visible = true;
            this.colIcoProdNuevo.VisibleIndex = 4;
            this.colIcoProdNuevo.Width = 27;
            // 
            // repositoryItemPictureEdit3
            // 
            this.repositoryItemPictureEdit3.Name = "repositoryItemPictureEdit3";
            // 
            // gridCtrlDespacho
            // 
            this.gridCtrlDespacho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlDespacho.Location = new System.Drawing.Point(3, 3);
            this.gridCtrlDespacho.MainView = this.gridVwDespacho;
            this.gridCtrlDespacho.Name = "gridCtrlDespacho";
            this.gridCtrlDespacho.Size = new System.Drawing.Size(210, 239);
            this.gridCtrlDespacho.TabIndex = 71;
            this.gridCtrlDespacho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVwDespacho,
            this.gridView2});
            // 
            // gridVwDespacho
            // 
            this.gridVwDespacho.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold);
            this.gridVwDespacho.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridVwDespacho.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.gridVwDespacho.Appearance.Row.Options.UseFont = true;
            this.gridVwDespacho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdDespacho,
            this.colSecuencia,
            this.colIdOrdenTaller,
            this.colHora,
            this.colIdProducto,
            this.colCodigoBarraMaestro,
            this.colCodigoBarra,
            this.colCantidad,
            this.colObservacion,
            this.colot_descripcion,
            this.colpr_descripcion});
            this.gridVwDespacho.GridControl = this.gridCtrlDespacho;
            this.gridVwDespacho.Name = "gridVwDespacho";
            this.gridVwDespacho.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridVwDespacho.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridVwDespacho.OptionsView.ShowGroupPanel = false;
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
            // colIdDespacho
            // 
            this.colIdDespacho.FieldName = "IdDespacho";
            this.colIdDespacho.Name = "colIdDespacho";
            // 
            // colSecuencia
            // 
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            // 
            // colIdOrdenTaller
            // 
            this.colIdOrdenTaller.FieldName = "IdOrdenTaller";
            this.colIdOrdenTaller.Name = "colIdOrdenTaller";
            // 
            // colHora
            // 
            this.colHora.Caption = "HORA";
            this.colHora.FieldName = "Hora";
            this.colHora.MinWidth = 40;
            this.colHora.Name = "colHora";
            this.colHora.OptionsColumn.AllowEdit = false;
            this.colHora.OptionsColumn.ReadOnly = true;
            this.colHora.Visible = true;
            this.colHora.VisibleIndex = 3;
            this.colHora.Width = 218;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            // 
            // colCodigoBarraMaestro
            // 
            this.colCodigoBarraMaestro.Caption = "MAESTRO";
            this.colCodigoBarraMaestro.FieldName = "CodigoBarra";
            this.colCodigoBarraMaestro.MinWidth = 120;
            this.colCodigoBarraMaestro.Name = "colCodigoBarraMaestro";
            this.colCodigoBarraMaestro.OptionsColumn.AllowEdit = false;
            this.colCodigoBarraMaestro.OptionsColumn.ReadOnly = true;
            this.colCodigoBarraMaestro.Visible = true;
            this.colCodigoBarraMaestro.VisibleIndex = 1;
            this.colCodigoBarraMaestro.Width = 196;
            // 
            // colCodigoBarra
            // 
            this.colCodigoBarra.Caption = "CB";
            this.colCodigoBarra.FieldName = "CodigoBarraMaestro";
            this.colCodigoBarra.MinWidth = 120;
            this.colCodigoBarra.Name = "colCodigoBarra";
            this.colCodigoBarra.Visible = true;
            this.colCodigoBarra.VisibleIndex = 0;
            this.colCodigoBarra.Width = 190;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "OBSERVACIÓN";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.MinWidth = 120;
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 2;
            this.colObservacion.Width = 202;
            // 
            // colot_descripcion
            // 
            this.colot_descripcion.Caption = "OT";
            this.colot_descripcion.FieldName = "ot_descripcion";
            this.colot_descripcion.MinWidth = 120;
            this.colot_descripcion.Name = "colot_descripcion";
            this.colot_descripcion.OptionsColumn.AllowEdit = false;
            this.colot_descripcion.OptionsColumn.ReadOnly = true;
            this.colot_descripcion.Visible = true;
            this.colot_descripcion.VisibleIndex = 5;
            this.colot_descripcion.Width = 196;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "PRD";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.MinWidth = 120;
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.OptionsColumn.AllowEdit = false;
            this.colpr_descripcion.OptionsColumn.ReadOnly = true;
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 4;
            this.colpr_descripcion.Width = 178;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridCtrlDespacho;
            this.gridView2.Name = "gridView2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnGrabar,
            this.toolStripSeparator2,
            this.btnSalir,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(224, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(224, 17);
            this.toolStrip1.TabIndex = 124;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(74, 14);
            this.btnGrabar.Text = "GUARDAR";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 17);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 14);
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "buscar.jpg");
            this.imageList1.Images.SetKeyName(1, "FormEdit.png");
            this.imageList1.Images.SetKeyName(2, "codbarra.png");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 17);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 17);
            // 
            // FrmPrd_Movil_AjustesInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(224, 284);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPrd_Movil_AjustesInventario";
            this.Text = "Ajustes de Inventario";
            this.Load += new System.EventHandler(this.FrmIn_AjustesInventario_Mant_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlDespacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwDespacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label8;
        private Controles.UCIn_Sucursal_Bodega UCSucBod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumAjuste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridCtrlDespacho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVwDespacho;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDespacho;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenTaller;
        private DevExpress.XtraGrid.Columns.GridColumn colHora;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBarraMaestro;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBarra;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colot_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGrabar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraGrid.GridControl gridControlAjustes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAjustes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovi_inven_tipo1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNumMovi1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_tipo_movi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_producto;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_ManejaSerie;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_stock_ante;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_stock_actu;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colCodMoviInven1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTipoMoviInven;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoMoviInven;
        private DevExpress.XtraGrid.Columns.GridColumn colCodBarra;
        private DevExpress.XtraGrid.Columns.GridColumn colIcoCodBarra;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colIcoProdCons;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colIcoProdNuevo;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit3;
        private System.Windows.Forms.TextBox txtcodigoAjuste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_tipoMoviInven;
        private System.Windows.Forms.RadioButton opt_egreso;
        private System.Windows.Forms.RadioButton opt_ingreso;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}