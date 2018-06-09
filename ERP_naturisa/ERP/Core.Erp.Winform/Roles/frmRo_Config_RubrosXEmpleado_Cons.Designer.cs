namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Config_RubrosXEmpleado_Cons
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
            this.btnDerechaTodos = new DevExpress.XtraEditors.SimpleButton();
            this.btnDerechaUno = new DevExpress.XtraEditors.SimpleButton();
            this.btnIzquierdaUno = new DevExpress.XtraEditors.SimpleButton();
            this.BtnIzquierdaTodos = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlRubroG = new DevExpress.XtraGrid.GridControl();
            this.gridViewRubroG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRu_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colru_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControlRubroE = new DevExpress.XtraGrid.GridControl();
            this.gridViewRubroE = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdRubroE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRu_descripcionE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btndown = new DevExpress.XtraEditors.SimpleButton();
            this.btnUp = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucGe_Menu_Superior_Mant = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRubroG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubroG)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRubroE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubroE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDerechaTodos
            // 
            this.btnDerechaTodos.Location = new System.Drawing.Point(390, 167);
            this.btnDerechaTodos.Name = "btnDerechaTodos";
            this.btnDerechaTodos.Size = new System.Drawing.Size(78, 28);
            this.btnDerechaTodos.TabIndex = 47;
            this.btnDerechaTodos.Text = ">>";
            this.btnDerechaTodos.Click += new System.EventHandler(this.btnDerechaTodos_Click);
            // 
            // btnDerechaUno
            // 
            this.btnDerechaUno.Location = new System.Drawing.Point(390, 131);
            this.btnDerechaUno.Name = "btnDerechaUno";
            this.btnDerechaUno.Size = new System.Drawing.Size(78, 28);
            this.btnDerechaUno.TabIndex = 48;
            this.btnDerechaUno.Text = ">";
            this.btnDerechaUno.Click += new System.EventHandler(this.btnDerechaUno_Click);
            // 
            // btnIzquierdaUno
            // 
            this.btnIzquierdaUno.Location = new System.Drawing.Point(390, 239);
            this.btnIzquierdaUno.Name = "btnIzquierdaUno";
            this.btnIzquierdaUno.Size = new System.Drawing.Size(78, 28);
            this.btnIzquierdaUno.TabIndex = 50;
            this.btnIzquierdaUno.Text = "<";
            this.btnIzquierdaUno.Click += new System.EventHandler(this.btnIzquierdaUno_Click);
            // 
            // BtnIzquierdaTodos
            // 
            this.BtnIzquierdaTodos.Location = new System.Drawing.Point(390, 203);
            this.BtnIzquierdaTodos.Name = "BtnIzquierdaTodos";
            this.BtnIzquierdaTodos.Size = new System.Drawing.Size(78, 28);
            this.BtnIzquierdaTodos.TabIndex = 51;
            this.BtnIzquierdaTodos.Text = "<<";
            this.BtnIzquierdaTodos.Click += new System.EventHandler(this.BtnIzquierdaTodos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.gridControlRubroG);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 388);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // gridControlRubroG
            // 
            this.gridControlRubroG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRubroG.Location = new System.Drawing.Point(3, 16);
            this.gridControlRubroG.MainView = this.gridViewRubroG;
            this.gridControlRubroG.Name = "gridControlRubroG";
            this.gridControlRubroG.Size = new System.Drawing.Size(378, 369);
            this.gridControlRubroG.TabIndex = 47;
            this.gridControlRubroG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRubroG});
            // 
            // gridViewRubroG
            // 
            this.gridViewRubroG.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 10.3F);
            this.gridViewRubroG.Appearance.ViewCaption.Options.UseFont = true;
            this.gridViewRubroG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdRubro,
            this.colRu_descripcion,
            this.ColTipo,
            this.colru_estado});
            this.gridViewRubroG.GridControl = this.gridControlRubroG;
            this.gridViewRubroG.Name = "gridViewRubroG";
            this.gridViewRubroG.OptionsBehavior.Editable = false;
            this.gridViewRubroG.OptionsView.ShowAutoFilterRow = true;
            this.gridViewRubroG.OptionsView.ShowGroupPanel = false;
            this.gridViewRubroG.OptionsView.ShowViewCaption = true;
            this.gridViewRubroG.ViewCaption = "Listado General de Rubros";
            this.gridViewRubroG.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewRubroG_FocusedRowChanged);
            // 
            // colIdRubro
            // 
            this.colIdRubro.Caption = "Id";
            this.colIdRubro.FieldName = "IdRubro";
            this.colIdRubro.Name = "colIdRubro";
            this.colIdRubro.Visible = true;
            this.colIdRubro.VisibleIndex = 0;
            this.colIdRubro.Width = 84;
            // 
            // colRu_descripcion
            // 
            this.colRu_descripcion.Caption = "Rubro";
            this.colRu_descripcion.FieldName = "ru_descripcion";
            this.colRu_descripcion.Name = "colRu_descripcion";
            this.colRu_descripcion.Visible = true;
            this.colRu_descripcion.VisibleIndex = 1;
            this.colRu_descripcion.Width = 220;
            // 
            // ColTipo
            // 
            this.ColTipo.Caption = "Tipo";
            this.ColTipo.FieldName = "ru_tipo";
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.Visible = true;
            this.ColTipo.VisibleIndex = 2;
            // 
            // colru_estado
            // 
            this.colru_estado.Caption = "Estado";
            this.colru_estado.FieldName = "ru_estado";
            this.colru_estado.Name = "colru_estado";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.gridControlRubroE);
            this.groupBox2.Location = new System.Drawing.Point(474, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 388);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // gridControlRubroE
            // 
            this.gridControlRubroE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRubroE.Location = new System.Drawing.Point(3, 16);
            this.gridControlRubroE.MainView = this.gridViewRubroE;
            this.gridControlRubroE.Name = "gridControlRubroE";
            this.gridControlRubroE.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit1,
            this.repositoryItemTextEdit1});
            this.gridControlRubroE.Size = new System.Drawing.Size(313, 369);
            this.gridControlRubroE.TabIndex = 50;
            this.gridControlRubroE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRubroE});
            // 
            // gridViewRubroE
            // 
            this.gridViewRubroE.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 10.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewRubroE.Appearance.ViewCaption.Options.UseFont = true;
            this.gridViewRubroE.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdRubroE,
            this.colRu_descripcionE,
            this.col1});
            this.gridViewRubroE.GridControl = this.gridControlRubroE;
            this.gridViewRubroE.Name = "gridViewRubroE";
            this.gridViewRubroE.OptionsBehavior.Editable = false;
            this.gridViewRubroE.OptionsView.ShowAutoFilterRow = true;
            this.gridViewRubroE.OptionsView.ShowGroupPanel = false;
            this.gridViewRubroE.OptionsView.ShowViewCaption = true;
            this.gridViewRubroE.ViewCaption = "Rubros Préstamos";
            this.gridViewRubroE.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewRubroE_FocusedRowChanged);
            // 
            // colIdRubroE
            // 
            this.colIdRubroE.Caption = "Id";
            this.colIdRubroE.FieldName = "IdRubro";
            this.colIdRubroE.Name = "colIdRubroE";
            this.colIdRubroE.Visible = true;
            this.colIdRubroE.VisibleIndex = 0;
            // 
            // colRu_descripcionE
            // 
            this.colRu_descripcionE.Caption = "Rubro";
            this.colRu_descripcionE.FieldName = "ru_descripcion";
            this.colRu_descripcionE.Name = "colRu_descripcionE";
            this.colRu_descripcionE.Visible = true;
            this.colRu_descripcionE.VisibleIndex = 1;
            this.colRu_descripcionE.Width = 258;
            // 
            // col1
            // 
            this.col1.Caption = "#";
            this.col1.FieldName = "ru_orden";
            this.col1.Name = "col1";
            this.col1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "1", "", 1)});
            this.col1.Visible = true;
            this.col1.VisibleIndex = 2;
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // btndown
            // 
            this.btndown.Location = new System.Drawing.Point(794, 205);
            this.btndown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(75, 28);
            this.btndown.TabIndex = 81;
            this.btndown.Text = "v";
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(794, 167);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 28);
            this.btnUp.TabIndex = 80;
            this.btnUp.Text = "^";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btndown);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Controls.Add(this.btnDerechaUno);
            this.panel1.Controls.Add(this.BtnIzquierdaTodos);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnIzquierdaUno);
            this.panel1.Controls.Add(this.btnDerechaTodos);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 413);
            this.panel1.TabIndex = 54;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(890, 22);
            this.statusStrip1.TabIndex = 55;
            this.statusStrip1.Text = "statusStrip1";
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
            this.ucGe_Menu_Superior_Mant.Size = new System.Drawing.Size(890, 29);
            this.ucGe_Menu_Superior_Mant.TabIndex = 56;
            this.ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnproductos = false;
            // 
            // frmRo_Config_RubrosXEmpleado_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 448);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmRo_Config_RubrosXEmpleado_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento - Configuración Rubros por Empleado";
            this.Load += new System.EventHandler(this.frmRo_Config_RubrosXEmpleado_Cons_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_Config_RubrosXEmpleado_Cons_KeyPress);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRubroG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubroG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRubroE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubroE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDerechaTodos;
        private DevExpress.XtraEditors.SimpleButton btnDerechaUno;
        private DevExpress.XtraEditors.SimpleButton btnIzquierdaUno;
        private DevExpress.XtraEditors.SimpleButton BtnIzquierdaTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlRubroG;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRubroG;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colRu_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn ColTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colru_estado;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControlRubroE;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRubroE;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRubroE;
        private DevExpress.XtraGrid.Columns.GridColumn colRu_descripcionE;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton btndown;
        private DevExpress.XtraEditors.SimpleButton btnUp;
        private DevExpress.XtraGrid.Columns.GridColumn col1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant;
    }
}