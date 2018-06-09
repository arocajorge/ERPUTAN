namespace Core.Erp.Winform.Produccion_Talme
{
    partial class frmProd_AsignacionProductosXModeloProduccion
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.CmbModeloProduccion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdModeloProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlProductoMateriaPrima = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductoMateriaPrima = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr_codigo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr_descripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbModeloProduccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductoMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductoMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGuardar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(863, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = global::Core.Erp.Winform.Properties.Resources.Guardar1;
            this.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(69, 22);
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CmbModeloProduccion
            // 
            this.CmbModeloProduccion.Location = new System.Drawing.Point(443, 15);
            this.CmbModeloProduccion.Name = "CmbModeloProduccion";
            this.CmbModeloProduccion.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.CmbModeloProduccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbModeloProduccion.Properties.DisplayMember = "Descripcion";
            this.CmbModeloProduccion.Properties.ValueMember = "IdModeloProd";
            this.CmbModeloProduccion.Properties.View = this.searchLookUpEdit1View;
            this.CmbModeloProduccion.Size = new System.Drawing.Size(156, 20);
            this.CmbModeloProduccion.TabIndex = 16;
            this.CmbModeloProduccion.EditValueChanged += new System.EventHandler(this.cmbModeloProduccion_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Descripcion,
            this.IdModeloProd});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 0;
            // 
            // IdModeloProd
            // 
            this.IdModeloProd.Caption = "IdModeloProd";
            this.IdModeloProd.FieldName = "IdModeloProd";
            this.IdModeloProd.Name = "IdModeloProd";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(311, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Modelo de Produccion";
            // 
            // gridControlProductoMateriaPrima
            // 
            this.gridControlProductoMateriaPrima.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductoMateriaPrima.Location = new System.Drawing.Point(2, 2);
            this.gridControlProductoMateriaPrima.MainView = this.gridViewProductoMateriaPrima;
            this.gridControlProductoMateriaPrima.Name = "gridControlProductoMateriaPrima";
            this.gridControlProductoMateriaPrima.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemSearchLookUpEdit1});
            this.gridControlProductoMateriaPrima.Size = new System.Drawing.Size(411, 406);
            this.gridControlProductoMateriaPrima.TabIndex = 18;
            this.gridControlProductoMateriaPrima.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductoMateriaPrima});
            // 
            // gridViewProductoMateriaPrima
            // 
            this.gridViewProductoMateriaPrima.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdProducto,
            this.pr_codigo,
            this.pr_descripcion});
            this.gridViewProductoMateriaPrima.GridControl = this.gridControlProductoMateriaPrima;
            this.gridViewProductoMateriaPrima.Name = "gridViewProductoMateriaPrima";
            this.gridViewProductoMateriaPrima.OptionsFind.AlwaysVisible = true;
            this.gridViewProductoMateriaPrima.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewProductoMateriaPrima.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewProductoMateriaPrima.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridViewProductoMateriaPrima.OptionsView.ShowGroupPanel = false;
            this.gridViewProductoMateriaPrima.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewProductoMateriaPrima_RowClick);
            this.gridViewProductoMateriaPrima.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewProductoMateriaPrima_CellValueChanging);
            this.gridViewProductoMateriaPrima.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewProductoMateriaPrima_ValidateRow);
            this.gridViewProductoMateriaPrima.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewProductoMateriaPrima_KeyDown);
            // 
            // IdProducto
            // 
            this.IdProducto.Caption = "Descripcion";
            this.IdProducto.ColumnEdit = this.repositoryItemSearchLookUpEdit1;
            this.IdProducto.FieldName = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = true;
            this.IdProducto.VisibleIndex = 1;
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.DisplayMember = "pr_descripcion";
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.ValueMember = "IdProducto";
            this.repositoryItemSearchLookUpEdit1.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colpr_codigo,
            this.colpr_descripcion});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            // 
            // colpr_codigo
            // 
            this.colpr_codigo.Caption = "Codigo";
            this.colpr_codigo.FieldName = "pr_codigo";
            this.colpr_codigo.Name = "colpr_codigo";
            this.colpr_codigo.Visible = true;
            this.colpr_codigo.VisibleIndex = 0;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Descripcion";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 1;
            // 
            // pr_codigo
            // 
            this.pr_codigo.Caption = "Codigo";
            this.pr_codigo.FieldName = "pr_codigo";
            this.pr_codigo.Name = "pr_codigo";
            this.pr_codigo.OptionsColumn.AllowEdit = false;
            this.pr_codigo.Visible = true;
            this.pr_codigo.VisibleIndex = 0;
            this.pr_codigo.Width = 64;
            // 
            // pr_descripcion
            // 
            this.pr_descripcion.Caption = "Descripcion";
            this.pr_descripcion.FieldName = "pr_descripcion";
            this.pr_descripcion.Name = "pr_descripcion";
            this.pr_descripcion.Width = 312;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.CmbModeloProduccion);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(863, 47);
            this.panelControl1.TabIndex = 19;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.labelControl2.Location = new System.Drawing.Point(778, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 15);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Producto Terminado";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.labelControl3.Location = new System.Drawing.Point(5, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 15);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Materia Prima";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlProductoMateriaPrima);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 72);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(415, 410);
            this.panelControl2.TabIndex = 20;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControl);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(424, 72);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(439, 410);
            this.panelControl3.TabIndex = 21;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 2);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit2});
            this.gridControl.Size = new System.Drawing.Size(435, 406);
            this.gridControl.TabIndex = 18;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdProducto1,
            this.pr_codigo1,
            this.pr_descripcion1});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            this.gridView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanging);
            this.gridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_KeyDown);
            // 
            // IdProducto1
            // 
            this.IdProducto1.Caption = "Descripcion";
            this.IdProducto1.ColumnEdit = this.repositoryItemSearchLookUpEdit2;
            this.IdProducto1.FieldName = "IdProducto";
            this.IdProducto1.Name = "IdProducto1";
            this.IdProducto1.OptionsFilter.AllowFilter = false;
            this.IdProducto1.Visible = true;
            this.IdProducto1.VisibleIndex = 1;
            // 
            // repositoryItemSearchLookUpEdit2
            // 
            this.repositoryItemSearchLookUpEdit2.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit2.DisplayMember = "pr_descripcion";
            this.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2";
            this.repositoryItemSearchLookUpEdit2.ValueMember = "IdProducto";
            this.repositoryItemSearchLookUpEdit2.View = this.repositoryItemSearchLookUpEdit2View;
            // 
            // repositoryItemSearchLookUpEdit2View
            // 
            this.repositoryItemSearchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto1,
            this.colpr_codigo1,
            this.colpr_descripcion1});
            this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto1
            // 
            this.colIdProducto1.FieldName = "IdProducto";
            this.colIdProducto1.Name = "colIdProducto1";
            // 
            // colpr_codigo1
            // 
            this.colpr_codigo1.Caption = "Codigo";
            this.colpr_codigo1.FieldName = "pr_codigo";
            this.colpr_codigo1.Name = "colpr_codigo1";
            this.colpr_codigo1.Visible = true;
            this.colpr_codigo1.VisibleIndex = 1;
            // 
            // colpr_descripcion1
            // 
            this.colpr_descripcion1.Caption = "Descripcion";
            this.colpr_descripcion1.FieldName = "pr_descripcion";
            this.colpr_descripcion1.Name = "colpr_descripcion1";
            this.colpr_descripcion1.Visible = true;
            this.colpr_descripcion1.VisibleIndex = 0;
            // 
            // pr_codigo1
            // 
            this.pr_codigo1.Caption = "Codigo";
            this.pr_codigo1.FieldName = "pr_codigo";
            this.pr_codigo1.Name = "pr_codigo1";
            this.pr_codigo1.Visible = true;
            this.pr_codigo1.VisibleIndex = 0;
            this.pr_codigo1.Width = 67;
            // 
            // pr_descripcion1
            // 
            this.pr_descripcion1.Caption = "pr_descripcion";
            this.pr_descripcion1.FieldName = "pr_descripcion";
            this.pr_descripcion1.Name = "pr_descripcion1";
            this.pr_descripcion1.Width = 300;
            // 
            // frmProd_AsignacionProductosXModeloProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 482);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmProd_AsignacionProductosXModeloProduccion";
            this.Text = "Asignacion Materia Prima A Modelos De Produccion";
            this.Load += new System.EventHandler(this.frmProd_AsignacionProductosXModeloProduccion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbModeloProduccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductoMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductoMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnGuardar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraEditors.SearchLookUpEdit CmbModeloProduccion;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlProductoMateriaPrima;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductoMateriaPrima;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn IdModeloProd;
        private DevExpress.XtraGrid.Columns.GridColumn IdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn pr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn pr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn IdProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn pr_codigo1;
        private DevExpress.XtraGrid.Columns.GridColumn pr_descripcion1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo1;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}