namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class frmfa_liquidacion_gastos_Mant
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
            this.ucGe_Menu_Superior_Mant = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Observacion = new System.Windows.Forms.TextBox();
            this.dt_fecha_liqui = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Codigo = new DevExpress.XtraEditors.TextEdit();
            this.txt_Id = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.ucFa_ClienteCmb = new Core.Erp.Winform.Controles.UCFa_ClienteCmb();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Detalle = new System.Windows.Forms.TabPage();
            this.gc_Liquidacion_detalle = new DevExpress.XtraGrid.GridControl();
            this.gw_Liquidacion_detalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdLiquidacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Liquidacion_Producto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto_Liqui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_producto_Liqui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_secuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdProducto_Liqui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_detalle_x_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_precio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_aplica_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_por_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_valor_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Total_liq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tab_Historico = new System.Windows.Forms.TabPage();
            this.gc_det_historico = new DevExpress.XtraGrid.GridControl();
            this.gw_det_historico = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_productos_ = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Codigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Liquidacion_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_Liquidacion_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Liquidacion_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.tab_Historico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_det_historico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_det_historico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_productos_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Superior_Mant
            // 
            this.ucGe_Menu_Superior_Mant.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant.Name = "ucGe_Menu_Superior_Mant";
            this.ucGe_Menu_Superior_Mant.Size = new System.Drawing.Size(1086, 29);
            this.ucGe_Menu_Superior_Mant.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant.Visible_bntAnular = true;
            this.ucGe_Menu_Superior_Mant.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_Superior_Mant_event_btnGuardar_Click);
            this.ucGe_Menu_Superior_Mant.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu_Superior_Mant.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_Superior_Mant_event_btnlimpiar_Click);
            this.ucGe_Menu_Superior_Mant.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_Superior_Mant_event_btnImprimir_Click);
            this.ucGe_Menu_Superior_Mant.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_Superior_Mant_event_btnAnular_Click);
            this.ucGe_Menu_Superior_Mant.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 449);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1086, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Observacion);
            this.splitContainer1.Panel1.Controls.Add(this.dt_fecha_liqui);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Codigo);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Id);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.ucFa_ClienteCmb);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1086, 420);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Observación";
            // 
            // txt_Observacion
            // 
            this.txt_Observacion.Location = new System.Drawing.Point(85, 67);
            this.txt_Observacion.Multiline = true;
            this.txt_Observacion.Name = "txt_Observacion";
            this.txt_Observacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Observacion.Size = new System.Drawing.Size(913, 37);
            this.txt_Observacion.TabIndex = 5;
            // 
            // dt_fecha_liqui
            // 
            this.dt_fecha_liqui.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_liqui.Location = new System.Drawing.Point(340, 13);
            this.dt_fecha_liqui.Name = "dt_fecha_liqui";
            this.dt_fecha_liqui.Size = new System.Drawing.Size(95, 20);
            this.dt_fecha_liqui.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(211, 13);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(74, 20);
            this.txt_Codigo.TabIndex = 2;
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Location = new System.Drawing.Point(85, 13);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(74, 20);
            this.txt_Id.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cliente";
            // 
            // ucFa_ClienteCmb
            // 
            this.ucFa_ClienteCmb.Location = new System.Drawing.Point(85, 39);
            this.ucFa_ClienteCmb.Name = "ucFa_ClienteCmb";
            this.ucFa_ClienteCmb.Size = new System.Drawing.Size(401, 26);
            this.ucFa_ClienteCmb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Detalle);
            this.tabControl1.Controls.Add(this.tab_Historico);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 305);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_Detalle
            // 
            this.tab_Detalle.Controls.Add(this.gc_Liquidacion_detalle);
            this.tab_Detalle.Location = new System.Drawing.Point(4, 22);
            this.tab_Detalle.Name = "tab_Detalle";
            this.tab_Detalle.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Detalle.Size = new System.Drawing.Size(1078, 279);
            this.tab_Detalle.TabIndex = 0;
            this.tab_Detalle.Text = "Detalle";
            this.tab_Detalle.UseVisualStyleBackColor = true;
            // 
            // gc_Liquidacion_detalle
            // 
            this.gc_Liquidacion_detalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Liquidacion_detalle.Location = new System.Drawing.Point(3, 3);
            this.gc_Liquidacion_detalle.MainView = this.gw_Liquidacion_detalle;
            this.gc_Liquidacion_detalle.Name = "gc_Liquidacion_detalle";
            this.gc_Liquidacion_detalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_Liquidacion_Producto});
            this.gc_Liquidacion_detalle.Size = new System.Drawing.Size(1072, 273);
            this.gc_Liquidacion_detalle.TabIndex = 0;
            this.gc_Liquidacion_detalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gw_Liquidacion_detalle});
            // 
            // gw_Liquidacion_detalle
            // 
            this.gw_Liquidacion_detalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdLiquidacion,
            this.col_secuencia,
            this.col_IdProducto_Liqui,
            this.col_detalle_x_producto,
            this.col_cantidad,
            this.col_precio,
            this.col_subtotal,
            this.col_aplica_iva,
            this.col_por_iva,
            this.col_valor_iva,
            this.col_Total_liq});
            this.gw_Liquidacion_detalle.GridControl = this.gc_Liquidacion_detalle;
            this.gw_Liquidacion_detalle.Name = "gw_Liquidacion_detalle";
            this.gw_Liquidacion_detalle.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gw_Liquidacion_detalle.OptionsView.ShowFooter = true;
            this.gw_Liquidacion_detalle.OptionsView.ShowGroupPanel = false;
            this.gw_Liquidacion_detalle.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gw_Liquidacion_detalle_CellValueChanged);
            this.gw_Liquidacion_detalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gw_Liquidacion_detalle_KeyDown);
            // 
            // col_IdLiquidacion
            // 
            this.col_IdLiquidacion.Caption = "IdLiquidacion";
            this.col_IdLiquidacion.ColumnEdit = this.cmb_Liquidacion_Producto;
            this.col_IdLiquidacion.FieldName = "IdLiquidacion";
            this.col_IdLiquidacion.Name = "col_IdLiquidacion";
            // 
            // cmb_Liquidacion_Producto
            // 
            this.cmb_Liquidacion_Producto.AutoHeight = false;
            this.cmb_Liquidacion_Producto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Liquidacion_Producto.DisplayMember = "nom_producto_Liqui";
            this.cmb_Liquidacion_Producto.Name = "cmb_Liquidacion_Producto";
            this.cmb_Liquidacion_Producto.ValueMember = "IdProducto_Liqui";
            this.cmb_Liquidacion_Producto.View = this.repositoryItemSearchLookUpEdit1View;
            this.cmb_Liquidacion_Producto.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cmb_Liquidacion_Producto_EditValueChanging);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto_Liqui,
            this.col_nom_producto_Liqui});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto_Liqui
            // 
            this.colIdProducto_Liqui.Caption = "IdProducto_Liqui";
            this.colIdProducto_Liqui.FieldName = "IdProducto_Liqui";
            this.colIdProducto_Liqui.Name = "colIdProducto_Liqui";
            this.colIdProducto_Liqui.Visible = true;
            this.colIdProducto_Liqui.VisibleIndex = 1;
            this.colIdProducto_Liqui.Width = 106;
            // 
            // col_nom_producto_Liqui
            // 
            this.col_nom_producto_Liqui.Caption = "Nombre Producto Liquidacion";
            this.col_nom_producto_Liqui.FieldName = "nom_producto_Liqui";
            this.col_nom_producto_Liqui.Name = "col_nom_producto_Liqui";
            this.col_nom_producto_Liqui.Visible = true;
            this.col_nom_producto_Liqui.VisibleIndex = 0;
            this.col_nom_producto_Liqui.Width = 1035;
            // 
            // col_secuencia
            // 
            this.col_secuencia.Caption = "Secuencia";
            this.col_secuencia.FieldName = "secuencia";
            this.col_secuencia.Name = "col_secuencia";
            this.col_secuencia.Visible = true;
            this.col_secuencia.VisibleIndex = 0;
            this.col_secuencia.Width = 40;
            // 
            // col_IdProducto_Liqui
            // 
            this.col_IdProducto_Liqui.Caption = "Producto Liquidacion";
            this.col_IdProducto_Liqui.ColumnEdit = this.cmb_Liquidacion_Producto;
            this.col_IdProducto_Liqui.FieldName = "IdProducto_Liqui";
            this.col_IdProducto_Liqui.Name = "col_IdProducto_Liqui";
            this.col_IdProducto_Liqui.Visible = true;
            this.col_IdProducto_Liqui.VisibleIndex = 1;
            this.col_IdProducto_Liqui.Width = 349;
            // 
            // col_detalle_x_producto
            // 
            this.col_detalle_x_producto.Caption = "Detalle x Producto";
            this.col_detalle_x_producto.FieldName = "detalle_x_producto";
            this.col_detalle_x_producto.Name = "col_detalle_x_producto";
            this.col_detalle_x_producto.Visible = true;
            this.col_detalle_x_producto.VisibleIndex = 2;
            this.col_detalle_x_producto.Width = 226;
            // 
            // col_cantidad
            // 
            this.col_cantidad.Caption = "Cantidad";
            this.col_cantidad.FieldName = "cantidad";
            this.col_cantidad.Name = "col_cantidad";
            this.col_cantidad.Visible = true;
            this.col_cantidad.VisibleIndex = 3;
            this.col_cantidad.Width = 59;
            // 
            // col_precio
            // 
            this.col_precio.Caption = "Precio";
            this.col_precio.FieldName = "precio";
            this.col_precio.Name = "col_precio";
            this.col_precio.Visible = true;
            this.col_precio.VisibleIndex = 4;
            this.col_precio.Width = 54;
            // 
            // col_subtotal
            // 
            this.col_subtotal.Caption = "Subtotal";
            this.col_subtotal.FieldName = "subtotal";
            this.col_subtotal.Name = "col_subtotal";
            this.col_subtotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.col_subtotal.Visible = true;
            this.col_subtotal.VisibleIndex = 5;
            this.col_subtotal.Width = 62;
            // 
            // col_aplica_iva
            // 
            this.col_aplica_iva.Caption = "Tiene Iva";
            this.col_aplica_iva.FieldName = "aplica_iva";
            this.col_aplica_iva.Name = "col_aplica_iva";
            this.col_aplica_iva.Visible = true;
            this.col_aplica_iva.VisibleIndex = 6;
            this.col_aplica_iva.Width = 36;
            // 
            // col_por_iva
            // 
            this.col_por_iva.Caption = "% Iva";
            this.col_por_iva.FieldName = "por_iva";
            this.col_por_iva.Name = "col_por_iva";
            this.col_por_iva.Visible = true;
            this.col_por_iva.VisibleIndex = 7;
            this.col_por_iva.Width = 44;
            // 
            // col_valor_iva
            // 
            this.col_valor_iva.Caption = "Iva";
            this.col_valor_iva.FieldName = "valor_iva";
            this.col_valor_iva.Name = "col_valor_iva";
            this.col_valor_iva.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.col_valor_iva.Visible = true;
            this.col_valor_iva.VisibleIndex = 8;
            this.col_valor_iva.Width = 45;
            // 
            // col_Total_liq
            // 
            this.col_Total_liq.Caption = "Total Liquidacion";
            this.col_Total_liq.FieldName = "Total_liq";
            this.col_Total_liq.Name = "col_Total_liq";
            this.col_Total_liq.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.col_Total_liq.Visible = true;
            this.col_Total_liq.VisibleIndex = 9;
            this.col_Total_liq.Width = 147;
            // 
            // tab_Historico
            // 
            this.tab_Historico.Controls.Add(this.gc_det_historico);
            this.tab_Historico.Location = new System.Drawing.Point(4, 22);
            this.tab_Historico.Name = "tab_Historico";
            this.tab_Historico.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Historico.Size = new System.Drawing.Size(1078, 240);
            this.tab_Historico.TabIndex = 1;
            this.tab_Historico.Text = "Historico";
            this.tab_Historico.UseVisualStyleBackColor = true;
            // 
            // gc_det_historico
            // 
            this.gc_det_historico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_det_historico.Location = new System.Drawing.Point(3, 3);
            this.gc_det_historico.MainView = this.gw_det_historico;
            this.gc_det_historico.Name = "gc_det_historico";
            this.gc_det_historico.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_productos_});
            this.gc_det_historico.Size = new System.Drawing.Size(1072, 234);
            this.gc_det_historico.TabIndex = 1;
            this.gc_det_historico.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gw_det_historico});
            // 
            // gw_det_historico
            // 
            this.gw_det_historico.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13});
            this.gw_det_historico.GridControl = this.gc_det_historico;
            this.gw_det_historico.Name = "gw_det_historico";
            this.gw_det_historico.OptionsBehavior.ReadOnly = true;
            this.gw_det_historico.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gw_det_historico.OptionsView.ShowFooter = true;
            this.gw_det_historico.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IdLiquidacion";
            this.gridColumn1.ColumnEdit = this.cmb_productos_;
            this.gridColumn1.FieldName = "IdLiquidacion";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // cmb_productos_
            // 
            this.cmb_productos_.AutoHeight = false;
            this.cmb_productos_.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_productos_.DisplayMember = "nom_producto_Liqui";
            this.cmb_productos_.Name = "cmb_productos_";
            this.cmb_productos_.ValueMember = "IdProducto_Liqui";
            this.cmb_productos_.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "IdProducto_Liqui";
            this.gridColumn2.FieldName = "IdProducto_Liqui";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 106;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nombre Producto Liquidacion";
            this.gridColumn3.FieldName = "nom_producto_Liqui";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 1035;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Secuencia";
            this.gridColumn4.FieldName = "secuencia";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 40;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Producto Liquidacion";
            this.gridColumn5.ColumnEdit = this.cmb_productos_;
            this.gridColumn5.FieldName = "IdProducto_Liqui";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 349;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Detalle x Producto";
            this.gridColumn6.FieldName = "detalle_x_producto";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 226;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Cantidad";
            this.gridColumn7.FieldName = "cantidad";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 59;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Precio";
            this.gridColumn8.FieldName = "precio";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 54;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Subtotal";
            this.gridColumn9.FieldName = "subtotal";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            this.gridColumn9.Width = 62;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Tiene Iva";
            this.gridColumn10.FieldName = "aplica_iva";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            this.gridColumn10.Width = 36;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "% Iva";
            this.gridColumn11.FieldName = "por_iva";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 7;
            this.gridColumn11.Width = 44;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Iva";
            this.gridColumn12.FieldName = "valor_iva";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 8;
            this.gridColumn12.Width = 45;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Total Liquidacion";
            this.gridColumn13.FieldName = "Total_liq";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 9;
            this.gridColumn13.Width = 147;
            // 
            // frmfa_liquidacion_gastos_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 475);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant);
            this.Name = "frmfa_liquidacion_gastos_Mant";
            this.Text = "frmfa_liquidacion_gastos_producto_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmfa_liquidacion_gastos_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmfa_liquidacion_gastos_Mant_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Codigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab_Detalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Liquidacion_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_Liquidacion_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Liquidacion_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.tab_Historico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_det_historico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_det_historico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_productos_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_Observacion;
        private System.Windows.Forms.DateTimePicker dt_fecha_liqui;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_Codigo;
        private DevExpress.XtraEditors.TextEdit txt_Id;
        private System.Windows.Forms.Label label3;
        private Controles.UCFa_ClienteCmb ucFa_ClienteCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gc_Liquidacion_detalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gw_Liquidacion_detalle;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdLiquidacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_Liquidacion_Producto;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto_Liqui;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_producto_Liqui;
        private DevExpress.XtraGrid.Columns.GridColumn col_secuencia;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdProducto_Liqui;
        private DevExpress.XtraGrid.Columns.GridColumn col_detalle_x_producto;
        private DevExpress.XtraGrid.Columns.GridColumn col_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn col_precio;
        private DevExpress.XtraGrid.Columns.GridColumn col_subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn col_por_iva;
        private DevExpress.XtraGrid.Columns.GridColumn col_valor_iva;
        private DevExpress.XtraGrid.Columns.GridColumn col_Total_liq;
        private DevExpress.XtraGrid.Columns.GridColumn col_aplica_iva;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Detalle;
        private System.Windows.Forms.TabPage tab_Historico;
        private DevExpress.XtraGrid.GridControl gc_det_historico;
        private DevExpress.XtraGrid.Views.Grid.GridView gw_det_historico;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_productos_;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
    }
}