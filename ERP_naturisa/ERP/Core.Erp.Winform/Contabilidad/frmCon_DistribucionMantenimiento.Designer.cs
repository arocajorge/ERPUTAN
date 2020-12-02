namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_DistribucionMantenimiento
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
            this.ucMenu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeListMenu_x_Usuario_x_Empresa = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Tiene_FormularioAsociado = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDistribuir = new DevExpress.XtraEditors.SimpleButton();
            this.btnCargarCuentas = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaCorte = new DevExpress.XtraEditors.DateEdit();
            this.txtObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.txtIdDistribucion = new DevExpress.XtraEditors.TextEdit();
            this.cmbTipoCbte = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gcDetalle = new DevExpress.XtraGrid.GridControl();
            this.gvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCuenta = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCentroCosto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbSubCentro = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu_x_Usuario_x_Empresa)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCorte.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCorte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdDistribucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCbte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubCentro)).BeginInit();
            this.SuspendLayout();
            // 
            // ucMenu
            // 
            this.ucMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucMenu.Enabled_bnRetImprimir = true;
            this.ucMenu.Enabled_bntAnular = true;
            this.ucMenu.Enabled_bntAprobar = true;
            this.ucMenu.Enabled_bntGuardar_y_Salir = true;
            this.ucMenu.Enabled_bntImprimir = true;
            this.ucMenu.Enabled_bntImprimir_Guia = true;
            this.ucMenu.Enabled_bntLimpiar = true;
            this.ucMenu.Enabled_bntSalir = true;
            this.ucMenu.Enabled_btn_conciliacion_Auto = true;
            this.ucMenu.Enabled_btn_DiseñoReporte = true;
            this.ucMenu.Enabled_btn_Generar_XML = true;
            this.ucMenu.Enabled_btn_Imprimir_Cbte = true;
            this.ucMenu.Enabled_btn_Imprimir_Cheq = true;
            this.ucMenu.Enabled_btn_Imprimir_Reten = true;
            this.ucMenu.Enabled_btnAceptar = true;
            this.ucMenu.Enabled_btnAprobarGuardarSalir = true;
            this.ucMenu.Enabled_btnEstadosOC = true;
            this.ucMenu.Enabled_btnGuardar = true;
            this.ucMenu.Enabled_btnImpFrm = true;
            this.ucMenu.Enabled_btnImpLote = true;
            this.ucMenu.Enabled_btnImpRep = true;
            this.ucMenu.Enabled_btnImprimirSoporte = true;
            this.ucMenu.Enabled_btnproductos = true;
            this.ucMenu.Location = new System.Drawing.Point(0, 0);
            this.ucMenu.Name = "ucMenu";
            this.ucMenu.Size = new System.Drawing.Size(1450, 29);
            this.ucMenu.TabIndex = 0;
            this.ucMenu.Visible_bntAnular = false;
            this.ucMenu.Visible_bntAprobar = false;
            this.ucMenu.Visible_bntDiseñoReporte = false;
            this.ucMenu.Visible_bntGuardar_y_Salir = false;
            this.ucMenu.Visible_bntImprimir = false;
            this.ucMenu.Visible_bntImprimir_Guia = false;
            this.ucMenu.Visible_bntLimpiar = false;
            this.ucMenu.Visible_bntReImprimir = false;
            this.ucMenu.Visible_bntSalir = true;
            this.ucMenu.Visible_btn_Actualizar = false;
            this.ucMenu.Visible_btn_conciliacion_Auto = false;
            this.ucMenu.Visible_btn_Generar_XML = false;
            this.ucMenu.Visible_btn_Imprimir_Cbte = false;
            this.ucMenu.Visible_btn_Imprimir_Cheq = false;
            this.ucMenu.Visible_btn_Imprimir_Reten = false;
            this.ucMenu.Visible_btnAceptar = false;
            this.ucMenu.Visible_btnAprobarGuardarSalir = false;
            this.ucMenu.Visible_btnContabilizar = false;
            this.ucMenu.Visible_btnEstadosOC = false;
            this.ucMenu.Visible_btnGuardar = false;
            this.ucMenu.Visible_btnImpFrm = false;
            this.ucMenu.Visible_btnImpLote = false;
            this.ucMenu.Visible_btnImpRep = false;
            this.ucMenu.Visible_btnImprimirSoporte = false;
            this.ucMenu.Visible_btnModificar = false;
            this.ucMenu.Visible_btnproductos = false;
            this.ucMenu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucMenu_event_btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeListMenu_x_Usuario_x_Empresa);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 597);
            this.panel1.TabIndex = 1;
            // 
            // treeListMenu_x_Usuario_x_Empresa
            // 
            this.treeListMenu_x_Usuario_x_Empresa.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.Tiene_FormularioAsociado,
            this.treeListColumn4});
            this.treeListMenu_x_Usuario_x_Empresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMenu_x_Usuario_x_Empresa.ImageIndexFieldName = "icono";
            this.treeListMenu_x_Usuario_x_Empresa.KeyFieldName = "IdCtaCble";
            this.treeListMenu_x_Usuario_x_Empresa.Location = new System.Drawing.Point(0, 31);
            this.treeListMenu_x_Usuario_x_Empresa.Name = "treeListMenu_x_Usuario_x_Empresa";
            this.treeListMenu_x_Usuario_x_Empresa.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsBehavior.EnableFiltering = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsPrint.PrintAllNodes = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsPrint.PrintFilledTreeIndent = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsPrint.UsePrintStyles = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsSelection.UseIndicatorForSelection = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowAutoFilterRow = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowCheckBoxes = true;
            this.treeListMenu_x_Usuario_x_Empresa.ParentFieldName = "IdCtaCblePadre";
            this.treeListMenu_x_Usuario_x_Empresa.Size = new System.Drawing.Size(800, 566);
            this.treeListMenu_x_Usuario_x_Empresa.TabIndex = 1;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Descripcion";
            this.treeListColumn1.FieldName = "pc_Cuenta";
            this.treeListColumn1.MinWidth = 32;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 350;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "id";
            this.treeListColumn2.FieldName = "IdCtaCble";
            this.treeListColumn2.Name = "treeListColumn2";
            // 
            // Tiene_FormularioAsociado
            // 
            this.Tiene_FormularioAsociado.Caption = "treeListColumn3";
            this.Tiene_FormularioAsociado.FieldName = "Tiene_FormularioAsociado";
            this.Tiene_FormularioAsociado.Name = "Tiene_FormularioAsociado";
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.FieldName = "Saldo";
            this.treeListColumn4.Format.FormatString = "n2";
            this.treeListColumn4.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDistribuir);
            this.panel2.Controls.Add(this.btnCargarCuentas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 31);
            this.panel2.TabIndex = 4;
            // 
            // btnDistribuir
            // 
            this.btnDistribuir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDistribuir.Image = global::Core.Erp.Winform.Properties.Resources.Distribuir_16x16;
            this.btnDistribuir.ImageIndex = 8;
            this.btnDistribuir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDistribuir.Location = new System.Drawing.Point(761, 3);
            this.btnDistribuir.Name = "btnDistribuir";
            this.btnDistribuir.Size = new System.Drawing.Size(35, 26);
            this.btnDistribuir.TabIndex = 5;
            this.btnDistribuir.Click += new System.EventHandler(this.btnDistribuir_Click);
            // 
            // btnCargarCuentas
            // 
            this.btnCargarCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarCuentas.Image = global::Core.Erp.Winform.Properties.Resources.re_hacer_16x16;
            this.btnCargarCuentas.ImageIndex = 8;
            this.btnCargarCuentas.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCargarCuentas.Location = new System.Drawing.Point(720, 3);
            this.btnCargarCuentas.Name = "btnCargarCuentas";
            this.btnCargarCuentas.Size = new System.Drawing.Size(35, 26);
            this.btnCargarCuentas.TabIndex = 4;
            this.btnCargarCuentas.Click += new System.EventHandler(this.btnCargarCuentas_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelControl4);
            this.panel3.Controls.Add(this.labelControl3);
            this.panel3.Controls.Add(this.labelControl2);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Controls.Add(this.deFechaCorte);
            this.panel3.Controls.Add(this.txtObservacion);
            this.panel3.Controls.Add(this.txtIdDistribucion);
            this.panel3.Controls.Add(this.cmbTipoCbte);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1450, 100);
            this.panel3.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 43);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Observacion";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(11, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(285, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Tipo comprobante";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(858, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Fecha corte:";
            // 
            // deFechaCorte
            // 
            this.deFechaCorte.EditValue = null;
            this.deFechaCorte.Location = new System.Drawing.Point(951, 14);
            this.deFechaCorte.Name = "deFechaCorte";
            this.deFechaCorte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaCorte.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaCorte.Size = new System.Drawing.Size(117, 20);
            this.deFechaCorte.TabIndex = 7;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(100, 40);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(968, 54);
            this.txtObservacion.TabIndex = 9;
            // 
            // txtIdDistribucion
            // 
            this.txtIdDistribucion.Location = new System.Drawing.Point(100, 14);
            this.txtIdDistribucion.Name = "txtIdDistribucion";
            this.txtIdDistribucion.Properties.ReadOnly = true;
            this.txtIdDistribucion.Size = new System.Drawing.Size(120, 20);
            this.txtIdDistribucion.TabIndex = 10;
            // 
            // cmbTipoCbte
            // 
            this.cmbTipoCbte.Location = new System.Drawing.Point(381, 14);
            this.cmbTipoCbte.Name = "cmbTipoCbte";
            this.cmbTipoCbte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoCbte.Properties.DisplayMember = "tc_TipoCbte2";
            this.cmbTipoCbte.Properties.NullText = "";
            this.cmbTipoCbte.Properties.ValueMember = "IdTipoCbte";
            this.cmbTipoCbte.Properties.View = this.searchLookUpEdit1View;
            this.cmbTipoCbte.Size = new System.Drawing.Size(408, 20);
            this.cmbTipoCbte.TabIndex = 11;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tipo comprobante";
            this.gridColumn1.FieldName = "tc_TipoCbte";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 1514;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "IdTipoCbte";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 220;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 129);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1450, 629);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gcDetalle);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1442, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por distribuir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gcDetalle
            // 
            this.gcDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDetalle.Location = new System.Drawing.Point(803, 3);
            this.gcDetalle.MainView = this.gvDetalle;
            this.gcDetalle.Name = "gcDetalle";
            this.gcDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbCuenta,
            this.cmbCentroCosto,
            this.cmbSubCentro});
            this.gcDetalle.Size = new System.Drawing.Size(636, 597);
            this.gcDetalle.TabIndex = 2;
            this.gcDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalle});
            // 
            // gvDetalle
            // 
            this.gvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvDetalle.GridControl = this.gcDetalle;
            this.gvDetalle.Name = "gvDetalle";
            this.gvDetalle.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvDetalle.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvDetalle.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDetalle.OptionsView.ShowGroupPanel = false;
            this.gvDetalle.ShownEditor += new System.EventHandler(this.gvDetalle_ShownEditor);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cuenta";
            this.gridColumn3.ColumnEdit = this.cmbCuenta;
            this.gridColumn3.FieldName = "IdCtaCble";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 447;
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.AutoHeight = false;
            this.cmbCuenta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCuenta.DisplayMember = "pc_Cuenta2";
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.ValueMember = "IdCtaCble";
            this.cmbCuenta.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "ID";
            this.gridColumn9.FieldName = "IdCtaCble";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            this.gridColumn9.Width = 339;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Cuenta";
            this.gridColumn10.FieldName = "pc_Cuenta";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            this.gridColumn10.Width = 1107;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Codigo";
            this.gridColumn11.FieldName = "pc_clave_corta";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 288;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Centro de costo";
            this.gridColumn4.ColumnEdit = this.cmbCentroCosto;
            this.gridColumn4.FieldName = "IdCentroCosto";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 332;
            // 
            // cmbCentroCosto
            // 
            this.cmbCentroCosto.AutoHeight = false;
            this.cmbCentroCosto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCentroCosto.DisplayMember = "Centro_costo2";
            this.cmbCentroCosto.Name = "cmbCentroCosto";
            this.cmbCentroCosto.ValueMember = "IdCentroCosto";
            this.cmbCentroCosto.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn13});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "ID";
            this.gridColumn12.FieldName = "IdCentroCosto";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            this.gridColumn12.Width = 149;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Centro de costo";
            this.gridColumn13.FieldName = "Centro_costo";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            this.gridColumn13.Width = 454;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "SubCentro";
            this.gridColumn5.ColumnEdit = this.cmbSubCentro;
            this.gridColumn5.FieldName = "IdRegistro";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 303;
            // 
            // cmbSubCentro
            // 
            this.cmbSubCentro.AutoHeight = false;
            this.cmbSubCentro.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSubCentro.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdCentroCosto_sub_centro_costo", 50, "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Centro_costo", 200, "Subcentro ")});
            this.cmbSubCentro.DisplayMember = "Centro_costo2";
            this.cmbSubCentro.Name = "cmbSubCentro";
            this.cmbSubCentro.ValueMember = "IdRegistro";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "F1";
            this.gridColumn6.FieldName = "F1";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 216;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "F2";
            this.gridColumn7.FieldName = "F2";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 216;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1442, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Distribuido";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1442, 603);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DiarioContable";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // frmCon_DistribucionMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 758);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ucMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCon_DistribucionMantenimiento";
            this.Text = "frmCon_DistribucionMantenimiento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCon_DistribucionMantenimiento_FormClosed);
            this.Load += new System.EventHandler(this.frmCon_DistribucionMantenimiento_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu_x_Usuario_x_Empresa)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCorte.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCorte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdDistribucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCbte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubCentro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucMenu;
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraTreeList.TreeList treeListMenu_x_Usuario_x_Empresa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Tiene_FormularioAsociado;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnCargarCuentas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraEditors.DateEdit deFechaCorte;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtObservacion;
        private DevExpress.XtraEditors.TextEdit txtIdDistribucion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipoCbte;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraEditors.SimpleButton btnDistribuir;
        private DevExpress.XtraGrid.GridControl gcDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbCuenta;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbCentroCosto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbSubCentro;
    }
}