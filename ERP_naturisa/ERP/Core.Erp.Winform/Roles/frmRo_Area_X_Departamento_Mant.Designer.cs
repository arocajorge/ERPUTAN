namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Area_X_Departamento_Mant
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbDivision = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDivision1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbArea = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIArea1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbDepartamento = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDepartamento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridDepartamento = new DevExpress.XtraGrid.GridControl();
            this.roAreaXDepartamentoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.viewDepartamento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdDivision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdQuitar = new System.Windows.Forms.Button();
            this.cmbDivisionD = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbAreaD = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbDepartamentoD = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDivision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roAreaXDepartamentoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDivisionD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAreaD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartamentoD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
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
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(765, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "División:";
            // 
            // cmbDivision
            // 
            this.cmbDivision.Location = new System.Drawing.Point(109, 35);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDivision.Properties.View = this.searchLookUpEdit1View;
            this.cmbDivision.Size = new System.Drawing.Size(192, 20);
            this.cmbDivision.TabIndex = 2;
            this.cmbDivision.EditValueChanged += new System.EventHandler(this.cmbDivision_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDivision1,
            this.colDescripcion1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdDivision1
            // 
            this.colIdDivision1.Caption = "Id";
            this.colIdDivision1.FieldName = "IdDivision";
            this.colIdDivision1.Name = "colIdDivision1";
            this.colIdDivision1.Visible = true;
            this.colIdDivision1.VisibleIndex = 0;
            this.colIdDivision1.Width = 80;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.Caption = "Descripcion";
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 1;
            this.colDescripcion1.Width = 858;
            // 
            // cmbArea
            // 
            this.cmbArea.Location = new System.Drawing.Point(109, 60);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbArea.Properties.View = this.gridView1;
            this.cmbArea.Size = new System.Drawing.Size(192, 20);
            this.cmbArea.TabIndex = 4;
            this.cmbArea.EditValueChanged += new System.EventHandler(this.cmbArea_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIArea1,
            this.colDescripcion2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIArea1
            // 
            this.colIArea1.Caption = "Id";
            this.colIArea1.FieldName = "IdArea";
            this.colIArea1.Name = "colIArea1";
            this.colIArea1.Visible = true;
            this.colIArea1.VisibleIndex = 0;
            this.colIArea1.Width = 71;
            // 
            // colDescripcion2
            // 
            this.colDescripcion2.Caption = "Descripcion";
            this.colDescripcion2.FieldName = "Descripcion";
            this.colDescripcion2.Name = "colDescripcion2";
            this.colDescripcion2.Visible = true;
            this.colDescripcion2.VisibleIndex = 1;
            this.colDescripcion2.Width = 867;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Area:";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Location = new System.Drawing.Point(109, 86);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDepartamento.Properties.View = this.gridView2;
            this.cmbDepartamento.Size = new System.Drawing.Size(192, 20);
            this.cmbDepartamento.TabIndex = 6;
            this.cmbDepartamento.EditValueChanged += new System.EventHandler(this.cmbDepartamento_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDepartamento1,
            this.colDescripcion3});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdDepartamento1
            // 
            this.colIdDepartamento1.Caption = "Id";
            this.colIdDepartamento1.FieldName = "IdDepartamento";
            this.colIdDepartamento1.Name = "colIdDepartamento1";
            this.colIdDepartamento1.Visible = true;
            this.colIdDepartamento1.VisibleIndex = 0;
            this.colIdDepartamento1.Width = 63;
            // 
            // colDescripcion3
            // 
            this.colDescripcion3.Caption = "Descripcion";
            this.colDescripcion3.FieldName = "de_descripcion";
            this.colDescripcion3.Name = "colDescripcion3";
            this.colDescripcion3.Visible = true;
            this.colDescripcion3.VisibleIndex = 1;
            this.colDescripcion3.Width = 875;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Departamento:";
            // 
            // gridDepartamento
            // 
            this.gridDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDepartamento.DataSource = this.roAreaXDepartamentoInfoBindingSource;
            this.gridDepartamento.Location = new System.Drawing.Point(0, 132);
            this.gridDepartamento.MainView = this.viewDepartamento;
            this.gridDepartamento.Name = "gridDepartamento";
            this.gridDepartamento.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbDivisionD,
            this.cmbAreaD,
            this.cmbDepartamentoD});
            this.gridDepartamento.Size = new System.Drawing.Size(765, 282);
            this.gridDepartamento.TabIndex = 7;
            this.gridDepartamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDepartamento});
            // 
            // roAreaXDepartamentoInfoBindingSource
            // 
            this.roAreaXDepartamentoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Area_X_Departamento_Info);
            // 
            // viewDepartamento
            // 
            this.viewDepartamento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdDivision,
            this.colIdArea,
            this.colIdDepartamento});
            this.viewDepartamento.GridControl = this.gridDepartamento;
            this.viewDepartamento.Name = "viewDepartamento";
            this.viewDepartamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewDepartamento_KeyDown);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdDivision
            // 
            this.colIdDivision.Caption = "División";
            this.colIdDivision.ColumnEdit = this.cmbDivisionD;
            this.colIdDivision.FieldName = "IdDivision";
            this.colIdDivision.Name = "colIdDivision";
            this.colIdDivision.OptionsColumn.AllowEdit = false;
            this.colIdDivision.Visible = true;
            this.colIdDivision.VisibleIndex = 0;
            this.colIdDivision.Width = 203;
            // 
            // colIdArea
            // 
            this.colIdArea.Caption = "Area";
            this.colIdArea.ColumnEdit = this.cmbAreaD;
            this.colIdArea.FieldName = "IdArea";
            this.colIdArea.Name = "colIdArea";
            this.colIdArea.OptionsColumn.AllowEdit = false;
            this.colIdArea.Visible = true;
            this.colIdArea.VisibleIndex = 1;
            this.colIdArea.Width = 225;
            // 
            // colIdDepartamento
            // 
            this.colIdDepartamento.Caption = "Departamento";
            this.colIdDepartamento.ColumnEdit = this.cmbDepartamentoD;
            this.colIdDepartamento.FieldName = "IdDepartamento";
            this.colIdDepartamento.Name = "colIdDepartamento";
            this.colIdDepartamento.OptionsColumn.AllowEdit = false;
            this.colIdDepartamento.Visible = true;
            this.colIdDepartamento.VisibleIndex = 2;
            this.colIdDepartamento.Width = 227;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(336, 41);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 8;
            this.cmdAgregar.Text = "&Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdQuitar
            // 
            this.cmdQuitar.Location = new System.Drawing.Point(336, 70);
            this.cmdQuitar.Name = "cmdQuitar";
            this.cmdQuitar.Size = new System.Drawing.Size(75, 23);
            this.cmdQuitar.TabIndex = 9;
            this.cmdQuitar.Text = "&Quitar";
            this.cmdQuitar.UseVisualStyleBackColor = true;
            this.cmdQuitar.Click += new System.EventHandler(this.cmdQuitar_Click);
            // 
            // cmbDivisionD
            // 
            this.cmbDivisionD.AutoHeight = false;
            this.cmbDivisionD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDivisionD.Name = "cmbDivisionD";
            this.cmbDivisionD.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cmbAreaD
            // 
            this.cmbAreaD.AutoHeight = false;
            this.cmbAreaD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAreaD.Name = "cmbAreaD";
            this.cmbAreaD.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // cmbDepartamentoD
            // 
            this.cmbDepartamentoD.AutoHeight = false;
            this.cmbDepartamentoD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDepartamentoD.Name = "cmbDepartamentoD";
            this.cmbDepartamentoD.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // frmRo_Area_X_Departamento_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 414);
            this.Controls.Add(this.cmdQuitar);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.gridDepartamento);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbDivision);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Area_X_Departamento_Mant";
            this.Text = "Mantenimiento - Departamento por Area";
            this.Load += new System.EventHandler(this.frmRo_Area_X_Departamento_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbDivision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roAreaXDepartamentoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDivisionD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAreaD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartamentoD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbDivision;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbArea;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbDepartamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridDepartamento;
        private System.Windows.Forms.BindingSource roAreaXDepartamentoInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDivision;
        private DevExpress.XtraGrid.Columns.GridColumn colIdArea;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDepartamento;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdQuitar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDivision1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colIArea1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDepartamento1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbDivisionD;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbAreaD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbDepartamentoD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
    }
}