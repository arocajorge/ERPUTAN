namespace Core.Erp.Winform.Roles
{
    partial class FrmRo_Asignacion_Implemento_x_Empleado_Mant
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
            this.groupBoxDetalle = new System.Windows.Forms.GroupBox();
            this.gridControlAsignacion = new DevExpress.XtraGrid.GridControl();
            this.gridViewAsignacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colImplemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Producto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_IdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVida_Util = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_fecha_fin_vida_util = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_estado_Implemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_catalogo = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtDetalle = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucRo_Empleado1 = new Core.Erp.Winform.Controles.UCRo_Empleado();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdAsignación = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.txtObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rbt_Egreso = new System.Windows.Forms.RadioButton();
            this.rbt_ingreso = new System.Windows.Forms.RadioButton();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.txt_cargo = new DevExpress.XtraEditors.TextEdit();
            this.txt_lugar_trabajo = new DevExpress.XtraEditors.LabelControl();
            this.txt_equipo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.Col_ca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAsignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAsignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_catalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAsignación.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cargo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDetalle
            // 
            this.groupBoxDetalle.Controls.Add(this.gridControlAsignacion);
            this.groupBoxDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetalle.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDetalle.Name = "groupBoxDetalle";
            this.groupBoxDetalle.Size = new System.Drawing.Size(1064, 225);
            this.groupBoxDetalle.TabIndex = 0;
            this.groupBoxDetalle.TabStop = false;
            this.groupBoxDetalle.Text = "Detalle de Implementos entregados";
            // 
            // gridControlAsignacion
            // 
            this.gridControlAsignacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAsignacion.Location = new System.Drawing.Point(3, 16);
            this.gridControlAsignacion.MainView = this.gridViewAsignacion;
            this.gridControlAsignacion.Name = "gridControlAsignacion";
            this.gridControlAsignacion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_Producto,
            this.txtDetalle,
            this.cmb_catalogo});
            this.gridControlAsignacion.Size = new System.Drawing.Size(1058, 206);
            this.gridControlAsignacion.TabIndex = 0;
            this.gridControlAsignacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAsignacion});
            // 
            // gridViewAsignacion
            // 
            this.gridViewAsignacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colImplemento,
            this.colCantidad,
            this.colVida_Util,
            this.gridColumnColDetalle,
            this.Col_fecha_fin_vida_util,
            this.Col_estado_Implemento});
            this.gridViewAsignacion.GridControl = this.gridControlAsignacion;
            this.gridViewAsignacion.Name = "gridViewAsignacion";
            this.gridViewAsignacion.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewAsignacion.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewAsignacion.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewAsignacion.OptionsView.ShowGroupPanel = false;
            this.gridViewAsignacion.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewAsignacion_CellValueChanged);
            this.gridViewAsignacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewAsignacion_KeyDown);
            // 
            // colImplemento
            // 
            this.colImplemento.Caption = "Implemento";
            this.colImplemento.ColumnEdit = this.cmb_Producto;
            this.colImplemento.FieldName = "IdProducto";
            this.colImplemento.Name = "colImplemento";
            this.colImplemento.Visible = true;
            this.colImplemento.VisibleIndex = 0;
            this.colImplemento.Width = 210;
            // 
            // cmb_Producto
            // 
            this.cmb_Producto.AutoHeight = false;
            this.cmb_Producto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Producto.Name = "cmb_Producto";
            this.cmb_Producto.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_IdProducto,
            this.Col_pr_codigo,
            this.Col_pr_descripcion});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Col_IdProducto
            // 
            this.Col_IdProducto.Caption = "Id";
            this.Col_IdProducto.FieldName = "IdProducto";
            this.Col_IdProducto.Name = "Col_IdProducto";
            this.Col_IdProducto.Visible = true;
            this.Col_IdProducto.VisibleIndex = 0;
            this.Col_IdProducto.Width = 73;
            // 
            // Col_pr_codigo
            // 
            this.Col_pr_codigo.Caption = "Codigo";
            this.Col_pr_codigo.FieldName = "pr_codigo";
            this.Col_pr_codigo.Name = "Col_pr_codigo";
            this.Col_pr_codigo.Visible = true;
            this.Col_pr_codigo.VisibleIndex = 1;
            this.Col_pr_codigo.Width = 130;
            // 
            // Col_pr_descripcion
            // 
            this.Col_pr_descripcion.Caption = "Implemento";
            this.Col_pr_descripcion.FieldName = "pr_descripcion";
            this.Col_pr_descripcion.Name = "Col_pr_descripcion";
            this.Col_pr_descripcion.Visible = true;
            this.Col_pr_descripcion.VisibleIndex = 2;
            this.Col_pr_descripcion.Width = 964;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 1;
            this.colCantidad.Width = 76;
            // 
            // colVida_Util
            // 
            this.colVida_Util.Caption = "Vida útil (días)";
            this.colVida_Util.FieldName = "Vida_Util";
            this.colVida_Util.Name = "colVida_Util";
            this.colVida_Util.Visible = true;
            this.colVida_Util.VisibleIndex = 2;
            this.colVida_Util.Width = 110;
            // 
            // gridColumnColDetalle
            // 
            this.gridColumnColDetalle.Caption = "Detalle/Motivo";
            this.gridColumnColDetalle.FieldName = "Detalle";
            this.gridColumnColDetalle.Name = "gridColumnColDetalle";
            this.gridColumnColDetalle.Visible = true;
            this.gridColumnColDetalle.VisibleIndex = 4;
            this.gridColumnColDetalle.Width = 538;
            // 
            // Col_fecha_fin_vida_util
            // 
            this.Col_fecha_fin_vida_util.Caption = "Fecha Caducidad";
            this.Col_fecha_fin_vida_util.FieldName = "Fecha_Caducidad";
            this.Col_fecha_fin_vida_util.Name = "Col_fecha_fin_vida_util";
            this.Col_fecha_fin_vida_util.Visible = true;
            this.Col_fecha_fin_vida_util.VisibleIndex = 3;
            this.Col_fecha_fin_vida_util.Width = 117;
            // 
            // Col_estado_Implemento
            // 
            this.Col_estado_Implemento.Caption = "Estado Implemento";
            this.Col_estado_Implemento.ColumnEdit = this.cmb_catalogo;
            this.Col_estado_Implemento.FieldName = "Estado_implemnto";
            this.Col_estado_Implemento.Name = "Col_estado_Implemento";
            this.Col_estado_Implemento.Visible = true;
            this.Col_estado_Implemento.VisibleIndex = 5;
            this.Col_estado_Implemento.Width = 116;
            // 
            // cmb_catalogo
            // 
            this.cmb_catalogo.AutoHeight = false;
            this.cmb_catalogo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_catalogo.Name = "cmb_catalogo";
            this.cmb_catalogo.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_ca_descripcion});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtDetalle
            // 
            this.txtDetalle.AutoHeight = false;
            this.txtDetalle.Name = "txtDetalle";
            // 
            // ucGe_Menu_Superior_Mant1
            // 
            this.ucGe_Menu_Superior_Mant1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant1.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(1064, 26);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 1;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            // 
            // ucRo_Empleado1
            // 
            this.ucRo_Empleado1.Location = new System.Drawing.Point(111, 36);
            this.ucRo_Empleado1.Name = "ucRo_Empleado1";
            this.ucRo_Empleado1.Size = new System.Drawing.Size(345, 26);
            this.ucRo_Empleado1.TabIndex = 2;
            this.ucRo_Empleado1.Visible_cmb_Acciones = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Empleado:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "# Asignación:";
            // 
            // txtIdAsignación
            // 
            this.txtIdAsignación.Location = new System.Drawing.Point(111, 10);
            this.txtIdAsignación.Name = "txtIdAsignación";
            this.txtIdAsignación.Properties.ReadOnly = true;
            this.txtIdAsignación.Size = new System.Drawing.Size(100, 20);
            this.txtIdAsignación.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(495, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Fecha Transaccion:";
            // 
            // deFecha
            // 
            this.deFecha.EditValue = null;
            this.deFecha.Location = new System.Drawing.Point(607, 7);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFecha.Size = new System.Drawing.Size(137, 20);
            this.deFecha.TabIndex = 7;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacion.Location = new System.Drawing.Point(2, 21);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(1060, 34);
            this.txtObservacion.TabIndex = 8;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 464);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1064, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 10;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelBody);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 26);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1064, 438);
            this.panelMain.TabIndex = 11;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.groupBoxDetalle);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 213);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1064, 225);
            this.panelBody.TabIndex = 11;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupControl2);
            this.panelTop.Controls.Add(this.textEdit3);
            this.panelTop.Controls.Add(this.textEdit2);
            this.panelTop.Controls.Add(this.txt_cargo);
            this.panelTop.Controls.Add(this.txt_lugar_trabajo);
            this.panelTop.Controls.Add(this.txt_equipo);
            this.panelTop.Controls.Add(this.labelControl4);
            this.panelTop.Controls.Add(this.groupControl1);
            this.panelTop.Controls.Add(this.labelControl5);
            this.panelTop.Controls.Add(this.dateEdit1);
            this.panelTop.Controls.Add(this.lblAnulado);
            this.panelTop.Controls.Add(this.txtIdAsignación);
            this.panelTop.Controls.Add(this.labelControl2);
            this.panelTop.Controls.Add(this.labelControl1);
            this.panelTop.Controls.Add(this.labelControl3);
            this.panelTop.Controls.Add(this.ucRo_Empleado1);
            this.panelTop.Controls.Add(this.deFecha);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1064, 213);
            this.panelTop.TabIndex = 10;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rbt_Egreso);
            this.groupControl2.Controls.Add(this.rbt_ingreso);
            this.groupControl2.Location = new System.Drawing.Point(750, 1);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(292, 61);
            this.groupControl2.TabIndex = 152;
            this.groupControl2.Text = "Movimiento de Inventario";
            // 
            // rbt_Egreso
            // 
            this.rbt_Egreso.AutoSize = true;
            this.rbt_Egreso.Location = new System.Drawing.Point(175, 33);
            this.rbt_Egreso.Name = "rbt_Egreso";
            this.rbt_Egreso.Size = new System.Drawing.Size(58, 17);
            this.rbt_Egreso.TabIndex = 1;
            this.rbt_Egreso.TabStop = true;
            this.rbt_Egreso.Text = "Egreso";
            this.rbt_Egreso.UseVisualStyleBackColor = true;
            // 
            // rbt_ingreso
            // 
            this.rbt_ingreso.AutoSize = true;
            this.rbt_ingreso.Location = new System.Drawing.Point(21, 31);
            this.rbt_ingreso.Name = "rbt_ingreso";
            this.rbt_ingreso.Size = new System.Drawing.Size(60, 17);
            this.rbt_ingreso.TabIndex = 0;
            this.rbt_ingreso.TabStop = true;
            this.rbt_ingreso.Text = "Ingreso";
            this.rbt_ingreso.UseVisualStyleBackColor = true;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(111, 117);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(345, 20);
            this.textEdit3.TabIndex = 151;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(111, 91);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(345, 20);
            this.textEdit2.TabIndex = 150;
            // 
            // txt_cargo
            // 
            this.txt_cargo.Location = new System.Drawing.Point(111, 68);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(345, 20);
            this.txt_cargo.TabIndex = 149;
            // 
            // txt_lugar_trabajo
            // 
            this.txt_lugar_trabajo.Location = new System.Drawing.Point(9, 94);
            this.txt_lugar_trabajo.Name = "txt_lugar_trabajo";
            this.txt_lugar_trabajo.Size = new System.Drawing.Size(84, 13);
            this.txt_lugar_trabajo.TabIndex = 148;
            this.txt_lugar_trabajo.Text = "Lugar de trabajo:";
            // 
            // txt_equipo
            // 
            this.txt_equipo.Location = new System.Drawing.Point(12, 120);
            this.txt_equipo.Name = "txt_equipo";
            this.txt_equipo.Size = new System.Drawing.Size(36, 13);
            this.txt_equipo.TabIndex = 147;
            this.txt_equipo.Text = "Equipo:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 71);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 146;
            this.labelControl4.Text = "Cargo:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtObservacion);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 156);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1064, 57);
            this.groupControl1.TabIndex = 145;
            this.groupControl1.Text = "Observacion";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(495, 36);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 13);
            this.labelControl5.TabIndex = 143;
            this.labelControl5.Text = "Fecha Entrega:";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(607, 33);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(137, 20);
            this.dateEdit1.TabIndex = 144;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(237, 7);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(117, 20);
            this.lblAnulado.TabIndex = 142;
            this.lblAnulado.Text = "***Anulado***";
            this.lblAnulado.Visible = false;
            // 
            // Col_ca_descripcion
            // 
            this.Col_ca_descripcion.Caption = "Estado";
            this.Col_ca_descripcion.FieldName = "ca_descripcion";
            this.Col_ca_descripcion.Name = "Col_ca_descripcion";
            this.Col_ca_descripcion.Visible = true;
            this.Col_ca_descripcion.VisibleIndex = 0;
            // 
            // FrmRo_Asignacion_Implemento_x_Empleado_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 490);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "FrmRo_Asignacion_Implemento_x_Empleado_Mant";
            this.Text = "FrmRo_Asignacion_Implemento_x_Empleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRo_Asignacion_Implemento_x_Empleado_FormClosing);
            this.Load += new System.EventHandler(this.FrmRo_Asignacion_Implemento_x_Empleado_Load);
            this.groupBoxDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAsignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAsignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_catalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAsignación.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cargo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDetalle;
        private DevExpress.XtraGrid.GridControl gridControlAsignacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAsignacion;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private Controles.UCRo_Empleado ucRo_Empleado1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtIdAsignación;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private DevExpress.XtraEditors.MemoEdit txtObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colImplemento;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colVida_Util;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelTop;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_Producto;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColDetalle;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraGrid.Columns.GridColumn Col_fecha_fin_vida_util;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit txt_cargo;
        private DevExpress.XtraEditors.LabelControl txt_lugar_trabajo;
        private DevExpress.XtraEditors.LabelControl txt_equipo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn Col_estado_Implemento;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pr_descripcion;
        private System.Windows.Forms.RadioButton rbt_Egreso;
        private System.Windows.Forms.RadioButton rbt_ingreso;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cmb_catalogo;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ca_descripcion;
    }
}