namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Ajuste_Inven_fisico_Mant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_Ajuste_Inven_fisico_Mant));
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.xtraTabControl_producto = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_detalle = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_producto = new DevExpress.XtraGrid.GridControl();
            this.gridViewAjusteInventario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RutaPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cod_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockFisico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colCantidadAjustada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Calculada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluni_medida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_CentroCosto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ucIn_Catalogos_Cmb1 = new Core.Erp.Winform.Controles.UCIn_Catalogos_Cmb();
            this.Ctrl_SucBod = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.grbMovEgreso = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumMoviAjustEgreso = new System.Windows.Forms.TextBox();
            this.Ctrl_MoviEgreso = new Core.Erp.Winform.Controles.UCIn_TipoMoviInv_Cmb();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grbMovIngres = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoviAjustIngreso = new System.Windows.Forms.TextBox();
            this.Ctrl_MoviIngreso = new Core.Erp.Winform.Controles.UCIn_TipoMoviInv_Cmb();
            this.txtNumAjusteFisico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.inCatalogoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList_iconos = new System.Windows.Forms.ImageList(this.components);
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlGeneral.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_producto)).BeginInit();
            this.xtraTabControl_producto.SuspendLayout();
            this.xtraTabPage_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAjusteInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CentroCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbMovEgreso.SuspendLayout();
            this.grbMovIngres.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inCatalogoInfoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Controls.Add(this.groupBox3);
            this.pnlGeneral.Controls.Add(this.groupBox1);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(0, 0);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(1159, 539);
            this.pnlGeneral.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.xtraTabControl_producto);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1159, 334);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // xtraTabControl_producto
            // 
            this.xtraTabControl_producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl_producto.Location = new System.Drawing.Point(3, 16);
            this.xtraTabControl_producto.Name = "xtraTabControl_producto";
            this.xtraTabControl_producto.SelectedTabPage = this.xtraTabPage_detalle;
            this.xtraTabControl_producto.Size = new System.Drawing.Size(1153, 315);
            this.xtraTabControl_producto.TabIndex = 5;
            this.xtraTabControl_producto.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_detalle});
            // 
            // xtraTabPage_detalle
            // 
            this.xtraTabPage_detalle.Controls.Add(this.gridControl_producto);
            this.xtraTabPage_detalle.Name = "xtraTabPage_detalle";
            this.xtraTabPage_detalle.Size = new System.Drawing.Size(1147, 287);
            this.xtraTabPage_detalle.Text = "detalle";
            // 
            // gridControl_producto
            // 
            this.gridControl_producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_producto.Location = new System.Drawing.Point(0, 0);
            this.gridControl_producto.MainView = this.gridViewAjusteInventario;
            this.gridControl_producto.Name = "gridControl_producto";
            this.gridControl_producto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.cmb_CentroCosto});
            this.gridControl_producto.Size = new System.Drawing.Size(1147, 287);
            this.gridControl_producto.TabIndex = 4;
            this.gridControl_producto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAjusteInventario,
            this.gridView2});
            // 
            // gridViewAjusteInventario
            // 
            this.gridViewAjusteInventario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RutaPadre,
            this.Cod_producto,
            this.Producto,
            this.pr_stock,
            this.colStockFisico,
            this.colCantidadAjustada,
            this.IdProducto,
            this.Calculada,
            this.col_nom_linea,
            this.coluni_medida,
            this.colCentro_costo});
            this.gridViewAjusteInventario.GridControl = this.gridControl_producto;
            this.gridViewAjusteInventario.Name = "gridViewAjusteInventario";
            this.gridViewAjusteInventario.OptionsView.ShowAutoFilterRow = true;
            this.gridViewAjusteInventario.OptionsView.ShowFooter = true;
            this.gridViewAjusteInventario.OptionsView.ShowGroupPanel = false;
            this.gridViewAjusteInventario.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewAjusteInventario_RowCellStyle);
            this.gridViewAjusteInventario.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridViewAjusteInventario.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewAjusteInventario_CellValueChanged);
            this.gridViewAjusteInventario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewAjusteInventario_KeyDown);
            // 
            // RutaPadre
            // 
            this.RutaPadre.Caption = "Categoría";
            this.RutaPadre.FieldName = "nom_Categoria";
            this.RutaPadre.Name = "RutaPadre";
            this.RutaPadre.OptionsColumn.AllowEdit = false;
            this.RutaPadre.Visible = true;
            this.RutaPadre.VisibleIndex = 2;
            this.RutaPadre.Width = 157;
            // 
            // Cod_producto
            // 
            this.Cod_producto.Caption = "Cod. Producto";
            this.Cod_producto.FieldName = "pr_codigo";
            this.Cod_producto.Name = "Cod_producto";
            this.Cod_producto.OptionsColumn.AllowEdit = false;
            this.Cod_producto.Visible = true;
            this.Cod_producto.VisibleIndex = 0;
            this.Cod_producto.Width = 65;
            // 
            // Producto
            // 
            this.Producto.Caption = "Producto";
            this.Producto.FieldName = "pr_descripcion";
            this.Producto.Name = "Producto";
            this.Producto.OptionsColumn.AllowEdit = false;
            this.Producto.Visible = true;
            this.Producto.VisibleIndex = 1;
            this.Producto.Width = 348;
            // 
            // pr_stock
            // 
            this.pr_stock.Caption = "Stock Sistema";
            this.pr_stock.FieldName = "pr_stock";
            this.pr_stock.Name = "pr_stock";
            this.pr_stock.OptionsColumn.AllowEdit = false;
            this.pr_stock.Visible = true;
            this.pr_stock.VisibleIndex = 5;
            this.pr_stock.Width = 86;
            // 
            // colStockFisico
            // 
            this.colStockFisico.Caption = "Stock Fisico";
            this.colStockFisico.FieldName = "StockFisico";
            this.colStockFisico.Name = "colStockFisico";
            this.colStockFisico.Visible = true;
            this.colStockFisico.VisibleIndex = 4;
            this.colStockFisico.Width = 90;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = "[0-9]+[,]?[0-9]{2}?";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit2.Mask.ShowPlaceHolders = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // colCantidadAjustada
            // 
            this.colCantidadAjustada.Caption = "Cant. Ajustada";
            this.colCantidadAjustada.FieldName = "CantidadAjustada";
            this.colCantidadAjustada.Name = "colCantidadAjustada";
            this.colCantidadAjustada.OptionsColumn.AllowEdit = false;
            this.colCantidadAjustada.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colCantidadAjustada.Visible = true;
            this.colCantidadAjustada.VisibleIndex = 6;
            this.colCantidadAjustada.Width = 117;
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
            this.Calculada.OptionsColumn.AllowEdit = false;
            this.Calculada.UnboundExpression = "[StockFisico]-[pr_stock]";
            this.Calculada.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // col_nom_linea
            // 
            this.col_nom_linea.Caption = "Línea";
            this.col_nom_linea.FieldName = "nom_Linea";
            this.col_nom_linea.Name = "col_nom_linea";
            this.col_nom_linea.OptionsColumn.AllowEdit = false;
            this.col_nom_linea.Visible = true;
            this.col_nom_linea.VisibleIndex = 3;
            this.col_nom_linea.Width = 130;
            // 
            // coluni_medida
            // 
            this.coluni_medida.Caption = "Unidad de medida";
            this.coluni_medida.FieldName = "nom_UnidadMedida";
            this.coluni_medida.Name = "coluni_medida";
            this.coluni_medida.OptionsColumn.AllowEdit = false;
            this.coluni_medida.Width = 102;
            // 
            // colCentro_costo
            // 
            this.colCentro_costo.Caption = "Centro de costo";
            this.colCentro_costo.ColumnEdit = this.cmb_CentroCosto;
            this.colCentro_costo.FieldName = "IdCentroCosto";
            this.colCentro_costo.Name = "colCentro_costo";
            this.colCentro_costo.Visible = true;
            this.colCentro_costo.VisibleIndex = 7;
            this.colCentro_costo.Width = 136;
            // 
            // cmb_CentroCosto
            // 
            this.cmb_CentroCosto.AutoHeight = false;
            this.cmb_CentroCosto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_CentroCosto.DisplayMember = "Centro_costo2";
            this.cmb_CentroCosto.Name = "cmb_CentroCosto";
            this.cmb_CentroCosto.ValueMember = "IdCentroCosto";
            this.cmb_CentroCosto.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "IdCentroCosto";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 146;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Centro de costo";
            this.gridColumn3.FieldName = "Centro_costo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 1034;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl_producto;
            this.gridView2.Name = "gridView2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ucIn_Catalogos_Cmb1);
            this.groupBox1.Controls.Add(this.Ctrl_SucBod);
            this.groupBox1.Controls.Add(this.lblAnulado);
            this.groupBox1.Controls.Add(this.grbMovEgreso);
            this.groupBox1.Controls.Add(this.dtp_fecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.grbMovIngres);
            this.groupBox1.Controls.Add(this.txtNumAjusteFisico);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Estado de aprobación:";
            // 
            // ucIn_Catalogos_Cmb1
            // 
            this.ucIn_Catalogos_Cmb1.Location = new System.Drawing.Point(668, 50);
            this.ucIn_Catalogos_Cmb1.Name = "ucIn_Catalogos_Cmb1";
            this.ucIn_Catalogos_Cmb1.Size = new System.Drawing.Size(231, 29);
            this.ucIn_Catalogos_Cmb1.TabIndex = 16;
            this.ucIn_Catalogos_Cmb1.Visible_btn_acciones = true;
            // 
            // Ctrl_SucBod
            // 
            this.Ctrl_SucBod.Location = new System.Drawing.Point(10, 33);
            this.Ctrl_SucBod.Name = "Ctrl_SucBod";
            this.Ctrl_SucBod.Size = new System.Drawing.Size(467, 51);
            this.Ctrl_SucBod.TabIndex = 15;
            this.Ctrl_SucBod.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
            this.Ctrl_SucBod.Event_cmb_sucursal1_EditValueChanged += new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega.delegate_cmb_sucursal1_EditValueChanged(this.Ctrl_SucBod_Event_cmb_sucursal1_EditValueChanged);
            this.Ctrl_SucBod.Event_cmb_bodega1_EditValueChanged += new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega.delegate_cmb_bodega1_EditValueChanged(this.Ctrl_SucBod_Event_cmb_bodega1_EditValueChanged);
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(483, 13);
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
            this.grbMovEgreso.Controls.Add(this.Ctrl_MoviEgreso);
            this.grbMovEgreso.Location = new System.Drawing.Point(458, 87);
            this.grbMovEgreso.Name = "grbMovEgreso";
            this.grbMovEgreso.Size = new System.Drawing.Size(444, 64);
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
            // Ctrl_MoviEgreso
            // 
            this.Ctrl_MoviEgreso.Location = new System.Drawing.Point(6, 14);
            this.Ctrl_MoviEgreso.Name = "Ctrl_MoviEgreso";
            this.Ctrl_MoviEgreso.Size = new System.Drawing.Size(416, 33);
            this.Ctrl_MoviEgreso.TabIndex = 6;
            this.Ctrl_MoviEgreso.Visible_buton_Acciones = true;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(725, 24);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(120, 20);
            this.dtp_fecha.TabIndex = 5;
            this.dtp_fecha.ValueChanged += new System.EventHandler(this.dtp_fecha_ValueChanged);
            this.dtp_fecha.Leave += new System.EventHandler(this.dtp_fecha_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha";
            // 
            // grbMovIngres
            // 
            this.grbMovIngres.Controls.Add(this.label4);
            this.grbMovIngres.Controls.Add(this.txtMoviAjustIngreso);
            this.grbMovIngres.Controls.Add(this.Ctrl_MoviIngreso);
            this.grbMovIngres.Location = new System.Drawing.Point(6, 85);
            this.grbMovIngres.Name = "grbMovIngres";
            this.grbMovIngres.Size = new System.Drawing.Size(433, 66);
            this.grbMovIngres.TabIndex = 1;
            this.grbMovIngres.TabStop = false;
            this.grbMovIngres.Text = "Movimiento x Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(110, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "# Ajuste x Ingreso";
            // 
            // txtMoviAjustIngreso
            // 
            this.txtMoviAjustIngreso.BackColor = System.Drawing.SystemColors.Window;
            this.txtMoviAjustIngreso.Location = new System.Drawing.Point(216, 39);
            this.txtMoviAjustIngreso.Name = "txtMoviAjustIngreso";
            this.txtMoviAjustIngreso.ReadOnly = true;
            this.txtMoviAjustIngreso.Size = new System.Drawing.Size(60, 20);
            this.txtMoviAjustIngreso.TabIndex = 3;
            // 
            // Ctrl_MoviIngreso
            // 
            this.Ctrl_MoviIngreso.Location = new System.Drawing.Point(19, 13);
            this.Ctrl_MoviIngreso.Name = "Ctrl_MoviIngreso";
            this.Ctrl_MoviIngreso.Size = new System.Drawing.Size(408, 33);
            this.Ctrl_MoviIngreso.TabIndex = 6;
            this.Ctrl_MoviIngreso.Visible_buton_Acciones = true;
            // 
            // txtNumAjusteFisico
            // 
            this.txtNumAjusteFisico.Location = new System.Drawing.Point(93, 12);
            this.txtNumAjusteFisico.Name = "txtNumAjusteFisico";
            this.txtNumAjusteFisico.ReadOnly = true;
            this.txtNumAjusteFisico.Size = new System.Drawing.Size(59, 20);
            this.txtNumAjusteFisico.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "# Ajuste físico:";
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
            // inCatalogoInfoBindingSource
            // 
            this.inCatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_Catalogo_Info);
            // 
            // imageList_iconos
            // 
            this.imageList_iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_iconos.ImageStream")));
            this.imageList_iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_iconos.Images.SetKeyName(0, "buscar_doc_64x64.png");
            this.imageList_iconos.Images.SetKeyName(1, "historial_128x128.png");
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpLote = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1159, 29);
            this.ucGe_Menu.TabIndex = 27;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_event_btnlimpiar_Click);
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            this.ucGe_Menu.event_btnAprobar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAprobar_Click(this.ucGe_Menu_event_btnAprobar_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 568);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1159, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlGeneral);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 539);
            this.panel1.TabIndex = 29;
            // 
            // FrmIn_Ajuste_Inven_fisico_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1159, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmIn_Ajuste_Inven_fisico_Mant";
            this.Text = "Mantenimiento Ajuste Inventario fisico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIn_Ajuste_Inventario_fisico_FormClosing);
            this.Load += new System.EventHandler(this.frmIn_Ajuste_Inventario_fisico_Load);
            this.pnlGeneral.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_producto)).EndInit();
            this.xtraTabControl_producto.ResumeLayout(false);
            this.xtraTabPage_detalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAjusteInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CentroCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbMovEgreso.ResumeLayout(false);
            this.grbMovEgreso.PerformLayout();
            this.grbMovIngres.ResumeLayout(false);
            this.grbMovIngres.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inCatalogoInfoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbMovEgreso;
        private System.Windows.Forms.GroupBox grbMovIngres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumAjusteFisico;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.TextBox txtNumMoviAjustEgreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMoviAjustIngreso;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource inCatalogoInfoBindingSource;
        private Controles.UCIn_Sucursal_Bodega Ctrl_SucBod;
        //private DataSet.DataSetmContabilidad dataSetmContabilidad1;
        private System.Windows.Forms.ImageList imageList_iconos;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCIn_TipoMoviInv_Cmb Ctrl_MoviEgreso;
        private Controles.UCIn_TipoMoviInv_Cmb Ctrl_MoviIngreso;
        public System.Windows.Forms.TextBox txtObservacion;
        private Controles.UCIn_Catalogos_Cmb ucIn_Catalogos_Cmb1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl_producto;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_detalle;
        private DevExpress.XtraGrid.GridControl gridControl_producto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAjusteInventario;
        private DevExpress.XtraGrid.Columns.GridColumn RutaPadre;
        private DevExpress.XtraGrid.Columns.GridColumn Cod_producto;
        private DevExpress.XtraGrid.Columns.GridColumn Producto;
        private DevExpress.XtraGrid.Columns.GridColumn pr_stock;
        private DevExpress.XtraGrid.Columns.GridColumn colStockFisico;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadAjustada;
        private DevExpress.XtraGrid.Columns.GridColumn IdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn Calculada;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_linea;
        private DevExpress.XtraGrid.Columns.GridColumn coluni_medida;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_CentroCosto;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}