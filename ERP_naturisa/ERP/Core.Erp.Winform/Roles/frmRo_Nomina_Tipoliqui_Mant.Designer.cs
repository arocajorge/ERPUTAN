namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Nomina_Tipoliqui_Mant
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ronominatipoliquiordenInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rorubrotipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxEstado = new DevExpress.XtraEditors.CheckEdit();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbNomina = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridListado = new DevExpress.XtraGrid.GridControl();
            this.viewListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNominaTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNominaTipoLiqui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbRubro = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colru_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrub_tipcal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTipoCalc = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Formula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditarFormula = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colrub_concep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsVisible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkEsVisible = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIngresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioIngresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModifica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModifica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditar = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cmbTipoCalculo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ronominatipoliquiordenInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rorubrotipoInfoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditarFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEsVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCalculo)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1205, 29);
            this.ucGe_Menu.TabIndex = 9;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // ronominatipoliquiordenInfoBindingSource
            // 
            this.ronominatipoliquiordenInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_nomina_tipo_liqui_orden_Info);
            // 
            // rorubrotipoInfoBindingSource
            // 
            this.rorubrotipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_rubro_tipo_Info);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxEstado);
            this.groupBox1.Controls.Add(this.grid);
            this.groupBox1.Controls.Add(this.cmbNomina);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblAnulado);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1205, 111);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.Location = new System.Drawing.Point(265, 15);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Properties.Caption = "Activo";
            this.checkBoxEstado.Size = new System.Drawing.Size(58, 19);
            this.checkBoxEstado.TabIndex = 73;
            // 
            // grid
            // 
            this.grid.Location = new System.Drawing.Point(703, 20);
            this.grid.MainView = this.view;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(78, 63);
            this.grid.TabIndex = 72;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            this.grid.Visible = false;
            // 
            // view
            // 
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // cmbNomina
            // 
            this.cmbNomina.Location = new System.Drawing.Point(86, 43);
            this.cmbNomina.Name = "cmbNomina";
            this.cmbNomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNomina.Properties.DisplayMember = "Descripcion";
            this.cmbNomina.Properties.ValueMember = "IdNomina_Tipo";
            this.cmbNomina.Properties.View = this.gridLookUpEdit1View;
            this.cmbNomina.Size = new System.Drawing.Size(234, 20);
            this.cmbNomina.TabIndex = 70;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Tipo de Nomina";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDescripcion.Location = new System.Drawing.Point(86, 69);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(234, 34);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo/ Nómina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(86, 17);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(65, 20);
            this.txtId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // lblAnulado
            // 
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(370, 16);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(162, 24);
            this.lblAnulado.TabIndex = 71;
            this.lblAnulado.Text = "***Anulado***";
            this.lblAnulado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridListado);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1205, 465);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // gridListado
            // 
            this.gridListado.DataSource = this.ronominatipoliquiordenInfoBindingSource;
            this.gridListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListado.Location = new System.Drawing.Point(3, 16);
            this.gridListado.MainView = this.viewListado;
            this.gridListado.Name = "gridListado";
            this.gridListado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbRubro,
            this.chkEsVisible,
            this.cmdEditarFormula,
            this.cmdEditar,
            this.cmbTipoCalculo,
            this.cmbTipoCalc});
            this.gridListado.Size = new System.Drawing.Size(1199, 446);
            this.gridListado.TabIndex = 0;
            this.gridListado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewListado});
            // 
            // viewListado
            // 
            this.viewListado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdNominaTipo,
            this.colIdNominaTipoLiqui,
            this.colOrden,
            this.colIdRubro,
            this.colrub_tipcal,
            this.Formula,
            this.colrub_concep,
            this.colEsVisible,
            this.gridColumn1,
            this.colFechaIngresa,
            this.colUsuarioIngresa,
            this.colFechaModifica,
            this.colUsuarioModifica});
            this.viewListado.GridControl = this.gridListado;
            this.viewListado.Name = "viewListado";
            this.viewListado.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.viewListado.OptionsView.ShowAutoFilterRow = true;
            this.viewListado.OptionsView.ShowGroupPanel = false;
            this.viewListado.OptionsView.ShowViewCaption = true;
            this.viewListado.ViewCaption = "Orden de Ejecución de Rubros";
            this.viewListado.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.viewListado_CellValueChanged);
            this.viewListado.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.viewListado_InvalidRowException);
            this.viewListado.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.viewListado_ValidateRow);
            this.viewListado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewListado_KeyDown);
            this.viewListado.Click += new System.EventHandler(this.viewListado_Click);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Width = 63;
            // 
            // colIdNominaTipo
            // 
            this.colIdNominaTipo.FieldName = "IdNominaTipo";
            this.colIdNominaTipo.Name = "colIdNominaTipo";
            this.colIdNominaTipo.Width = 79;
            // 
            // colIdNominaTipoLiqui
            // 
            this.colIdNominaTipoLiqui.FieldName = "IdNominaTipoLiqui";
            this.colIdNominaTipoLiqui.Name = "colIdNominaTipoLiqui";
            this.colIdNominaTipoLiqui.Width = 54;
            // 
            // colOrden
            // 
            this.colOrden.FieldName = "Orden";
            this.colOrden.Name = "colOrden";
            this.colOrden.Visible = true;
            this.colOrden.VisibleIndex = 0;
            this.colOrden.Width = 39;
            // 
            // colIdRubro
            // 
            this.colIdRubro.Caption = "Rubro";
            this.colIdRubro.ColumnEdit = this.cmbRubro;
            this.colIdRubro.FieldName = "IdRubro";
            this.colIdRubro.Name = "colIdRubro";
            this.colIdRubro.Visible = true;
            this.colIdRubro.VisibleIndex = 1;
            this.colIdRubro.Width = 111;
            // 
            // cmbRubro
            // 
            this.cmbRubro.AutoHeight = false;
            this.cmbRubro.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRubro.DataSource = this.rorubrotipoInfoBindingSource;
            this.cmbRubro.DisplayMember = "ru_codRolGen";
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.ValueMember = "IdRubro";
            this.cmbRubro.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colru_descripcion});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colru_descripcion
            // 
            this.colru_descripcion.FieldName = "ru_descripcion";
            this.colru_descripcion.Name = "colru_descripcion";
            this.colru_descripcion.Visible = true;
            this.colru_descripcion.VisibleIndex = 0;
            // 
            // colrub_tipcal
            // 
            this.colrub_tipcal.Caption = "Tipo Cálculo";
            this.colrub_tipcal.ColumnEdit = this.cmbTipoCalc;
            this.colrub_tipcal.FieldName = "rub_tipcal";
            this.colrub_tipcal.Name = "colrub_tipcal";
            this.colrub_tipcal.OptionsColumn.AllowEdit = false;
            this.colrub_tipcal.Visible = true;
            this.colrub_tipcal.VisibleIndex = 2;
            this.colrub_tipcal.Width = 92;
            // 
            // cmbTipoCalc
            // 
            this.cmbTipoCalc.AutoHeight = false;
            this.cmbTipoCalc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoCalc.Name = "cmbTipoCalc";
            this.cmbTipoCalc.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Formula
            // 
            this.Formula.Caption = "Formula";
            this.Formula.ColumnEdit = this.cmdEditarFormula;
            this.Formula.FieldName = "Formula";
            this.Formula.Name = "Formula";
            this.Formula.Visible = true;
            this.Formula.VisibleIndex = 3;
            this.Formula.Width = 456;
            // 
            // cmdEditarFormula
            // 
            this.cmdEditarFormula.AutoHeight = false;
            this.cmdEditarFormula.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmdEditarFormula.Name = "cmdEditarFormula";
            this.cmdEditarFormula.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdEditarFormula_ButtonClick);
            // 
            // colrub_concep
            // 
            this.colrub_concep.Caption = "Concepto";
            this.colrub_concep.FieldName = "rub_concep";
            this.colrub_concep.Name = "colrub_concep";
            this.colrub_concep.OptionsColumn.ReadOnly = true;
            this.colrub_concep.Visible = true;
            this.colrub_concep.VisibleIndex = 4;
            this.colrub_concep.Width = 55;
            // 
            // colEsVisible
            // 
            this.colEsVisible.Caption = "Visible";
            this.colEsVisible.ColumnEdit = this.chkEsVisible;
            this.colEsVisible.FieldName = "EsVisible";
            this.colEsVisible.Name = "colEsVisible";
            this.colEsVisible.Visible = true;
            this.colEsVisible.VisibleIndex = 5;
            this.colEsVisible.Width = 61;
            // 
            // chkEsVisible
            // 
            this.chkEsVisible.AutoHeight = false;
            this.chkEsVisible.Name = "chkEsVisible";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 271;
            // 
            // colFechaIngresa
            // 
            this.colFechaIngresa.FieldName = "FechaIngresa";
            this.colFechaIngresa.Name = "colFechaIngresa";
            // 
            // colUsuarioIngresa
            // 
            this.colUsuarioIngresa.FieldName = "UsuarioIngresa";
            this.colUsuarioIngresa.Name = "colUsuarioIngresa";
            // 
            // colFechaModifica
            // 
            this.colFechaModifica.FieldName = "FechaModifica";
            this.colFechaModifica.Name = "colFechaModifica";
            // 
            // colUsuarioModifica
            // 
            this.colUsuarioModifica.FieldName = "UsuarioModifica";
            this.colUsuarioModifica.Name = "colUsuarioModifica";
            // 
            // cmdEditar
            // 
            this.cmdEditar.AutoHeight = false;
            this.cmdEditar.Name = "cmdEditar";
            // 
            // cmbTipoCalculo
            // 
            this.cmbTipoCalculo.AutoHeight = false;
            this.cmbTipoCalculo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoCalculo.Name = "cmbTipoCalculo";
            // 
            // frmRo_Nomina_Tipoliqui_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 605);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucGe_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmRo_Nomina_Tipoliqui_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento - Tipo de Liquidación de Nómina ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRo_Nomina_Tipoliqui_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmRo_Nomina_Tipoliqui_Mant_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_Nomina_Tipoliqui_Mant_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ronominatipoliquiordenInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rorubrotipoInfoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditarFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEsVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCalculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.BindingSource rorubrotipoInfoBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.GridLookUpEdit cmbNomina;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource ronominatipoliquiordenInfoBindingSource;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView view;
        private DevExpress.XtraEditors.CheckEdit checkBoxEstado;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridListado;
        private DevExpress.XtraGrid.Views.Grid.GridView viewListado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNominaTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNominaTipoLiqui;
        private DevExpress.XtraGrid.Columns.GridColumn colOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRubro;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbRubro;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colru_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colrub_tipcal;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbTipoCalc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Formula;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditarFormula;
        private DevExpress.XtraGrid.Columns.GridColumn colrub_concep;
        private DevExpress.XtraGrid.Columns.GridColumn colEsVisible;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkEsVisible;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIngresa;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioIngresa;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModifica;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModifica;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit cmdEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmbTipoCalculo;
    }
}