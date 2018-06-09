namespace Core.Erp.Winform.SeguridadAcceso
{
    partial class FrmSeg_Menu_x_Empresa_x_Usuario
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
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.searchLookUpEditUsuario = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchLookUpEditEmpresa = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSeleccionarTodo = new System.Windows.Forms.CheckBox();
            this.treeListMenu = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.chkLectura = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.chkEscritura = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.chkEliminacion = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UcMenu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLectura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEscritura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEliminacion)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFiltro
            // 
            this.panelFiltro.Controls.Add(this.searchLookUpEditUsuario);
            this.panelFiltro.Controls.Add(this.searchLookUpEditEmpresa);
            this.panelFiltro.Controls.Add(this.label2);
            this.panelFiltro.Controls.Add(this.label1);
            this.panelFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltro.Location = new System.Drawing.Point(0, 0);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(768, 41);
            this.panelFiltro.TabIndex = 1;
            // 
            // searchLookUpEditUsuario
            // 
            this.searchLookUpEditUsuario.Location = new System.Drawing.Point(394, 7);
            this.searchLookUpEditUsuario.Name = "searchLookUpEditUsuario";
            this.searchLookUpEditUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditUsuario.Properties.View = this.gridView1;
            this.searchLookUpEditUsuario.Size = new System.Drawing.Size(237, 20);
            this.searchLookUpEditUsuario.TabIndex = 3;
            this.searchLookUpEditUsuario.EditValueChanged += new System.EventHandler(this.searchLookUpEditUsuario_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn5});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Usuario";
            this.gridColumn6.FieldName = "IdUsuario";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Nombre";
            this.gridColumn5.FieldName = "Nombre";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // searchLookUpEditEmpresa
            // 
            this.searchLookUpEditEmpresa.Location = new System.Drawing.Point(68, 7);
            this.searchLookUpEditEmpresa.Name = "searchLookUpEditEmpresa";
            this.searchLookUpEditEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditEmpresa.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEditEmpresa.Size = new System.Drawing.Size(237, 20);
            this.searchLookUpEditEmpresa.TabIndex = 2;
            this.searchLookUpEditEmpresa.EditValueChanged += new System.EventHandler(this.searchLookUpEditEmpresa_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn7});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Descripcion";
            this.gridColumn4.FieldName = "em_nombre";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Id";
            this.gridColumn7.FieldName = "IdEmpresa";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // chkSeleccionarTodo
            // 
            this.chkSeleccionarTodo.AutoSize = true;
            this.chkSeleccionarTodo.Location = new System.Drawing.Point(12, 3);
            this.chkSeleccionarTodo.Name = "chkSeleccionarTodo";
            this.chkSeleccionarTodo.Size = new System.Drawing.Size(106, 17);
            this.chkSeleccionarTodo.TabIndex = 4;
            this.chkSeleccionarTodo.Text = "Seleccionar todo";
            this.chkSeleccionarTodo.UseVisualStyleBackColor = true;
            this.chkSeleccionarTodo.CheckedChanged += new System.EventHandler(this.chkSeleccionarTodo_CheckedChanged);
            // 
            // treeListMenu
            // 
            this.treeListMenu.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn5,
            this.treeListColumn4});
            this.treeListMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMenu.KeyFieldName = "IdMenu";
            this.treeListMenu.Location = new System.Drawing.Point(0, 0);
            this.treeListMenu.Name = "treeListMenu";
            this.treeListMenu.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.treeListMenu.OptionsBehavior.EnableFiltering = true;
            this.treeListMenu.OptionsPrint.UsePrintStyles = true;
            this.treeListMenu.OptionsView.ShowAutoFilterRow = true;
            this.treeListMenu.OptionsView.ShowCheckBoxes = true;
            this.treeListMenu.ParentFieldName = "IdMenuPadre";
            this.treeListMenu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkLectura,
            this.chkEscritura,
            this.chkEliminacion});
            this.treeListMenu.Size = new System.Drawing.Size(768, 359);
            this.treeListMenu.TabIndex = 6;
            this.treeListMenu.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeListMenu_AfterCheckNode);
            this.treeListMenu.CellValueChanging += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeListMenu_CellValueChanging);
            this.treeListMenu.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeListMenu_CellValueChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Descripcion";
            this.treeListColumn1.FieldName = "DescripcionMenu";
            this.treeListColumn1.MinWidth = 32;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 369;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Lectura";
            this.treeListColumn2.ColumnEdit = this.chkLectura;
            this.treeListColumn2.FieldName = "Lectura";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // chkLectura
            // 
            this.chkLectura.AutoHeight = false;
            this.chkLectura.Name = "chkLectura";
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Escritura";
            this.treeListColumn3.ColumnEdit = this.chkEscritura;
            this.treeListColumn3.FieldName = "Escritura";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            // 
            // chkEscritura
            // 
            this.chkEscritura.AutoHeight = false;
            this.chkEscritura.Name = "chkEscritura";
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Eliminacion";
            this.treeListColumn5.ColumnEdit = this.chkEliminacion;
            this.treeListColumn5.FieldName = "Eliminacion";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 3;
            // 
            // chkEliminacion
            // 
            this.chkEliminacion.AutoHeight = false;
            this.chkEliminacion.Name = "chkEliminacion";
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "SeModificoValor";
            this.treeListColumn4.FieldName = "SeModificoValor";
            this.treeListColumn4.Name = "treeListColumn4";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Descripcion";
            this.gridColumn1.FieldName = "em_nombre";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Login";
            this.gridColumn2.FieldName = "IdUsuario";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nombre";
            this.gridColumn3.FieldName = "Nombre";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // UcMenu
            // 
            this.UcMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.UcMenu.Enabled_bnRetImprimir = true;
            this.UcMenu.Enabled_bntAnular = true;
            this.UcMenu.Enabled_bntAprobar = true;
            this.UcMenu.Enabled_bntGuardar_y_Salir = true;
            this.UcMenu.Enabled_bntImprimir = true;
            this.UcMenu.Enabled_bntImprimir_Guia = true;
            this.UcMenu.Enabled_bntLimpiar = true;
            this.UcMenu.Enabled_bntSalir = true;
            this.UcMenu.Enabled_btn_conciliacion_Auto = true;
            this.UcMenu.Enabled_btn_DiseñoReporte = true;
            this.UcMenu.Enabled_btn_Generar_XML = true;
            this.UcMenu.Enabled_btn_Imprimir_Cbte = true;
            this.UcMenu.Enabled_btn_Imprimir_Cheq = true;
            this.UcMenu.Enabled_btn_Imprimir_Reten = true;
            this.UcMenu.Enabled_btnAceptar = true;
            this.UcMenu.Enabled_btnAprobarGuardarSalir = true;
            this.UcMenu.Enabled_btnEstadosOC = true;
            this.UcMenu.Enabled_btnGuardar = true;
            this.UcMenu.Enabled_btnImpFrm = true;
            this.UcMenu.Enabled_btnImpLote = true;
            this.UcMenu.Enabled_btnImpRep = true;
            this.UcMenu.Enabled_btnImprimirSoporte = true;
            this.UcMenu.Enabled_btnproductos = true;
            this.UcMenu.Location = new System.Drawing.Point(0, 0);
            this.UcMenu.Name = "UcMenu";
            this.UcMenu.Size = new System.Drawing.Size(768, 29);
            this.UcMenu.TabIndex = 7;
            this.UcMenu.Visible_bntAnular = false;
            this.UcMenu.Visible_bntAprobar = false;
            this.UcMenu.Visible_bntDiseñoReporte = false;
            this.UcMenu.Visible_bntGuardar_y_Salir = false;
            this.UcMenu.Visible_bntImprimir = true;
            this.UcMenu.Visible_bntImprimir_Guia = false;
            this.UcMenu.Visible_bntLimpiar = false;
            this.UcMenu.Visible_bntReImprimir = false;
            this.UcMenu.Visible_bntSalir = true;
            this.UcMenu.Visible_btn_Actualizar = false;
            this.UcMenu.Visible_btn_conciliacion_Auto = false;
            this.UcMenu.Visible_btn_Generar_XML = false;
            this.UcMenu.Visible_btn_Imprimir_Cbte = false;
            this.UcMenu.Visible_btn_Imprimir_Cheq = false;
            this.UcMenu.Visible_btn_Imprimir_Reten = false;
            this.UcMenu.Visible_btnAceptar = false;
            this.UcMenu.Visible_btnAprobarGuardarSalir = false;
            this.UcMenu.Visible_btnContabilizar = false;
            this.UcMenu.Visible_btnEstadosOC = false;
            this.UcMenu.Visible_btnGuardar = true;
            this.UcMenu.Visible_btnImpFrm = false;
            this.UcMenu.Visible_btnImpLote = false;
            this.UcMenu.Visible_btnImpRep = false;
            this.UcMenu.Visible_btnImprimirSoporte = false;
            this.UcMenu.Visible_btnModificar = false;
            this.UcMenu.Visible_btnproductos = false;
            this.UcMenu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.UcMenu_event_btnGuardar_Click);
            this.UcMenu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.UcMenu_event_btnImprimir_Click);
            this.UcMenu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.UcMenu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 458);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(768, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 9;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.splitContainerMain);
            this.panelMain.Controls.Add(this.panelFiltro);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(768, 429);
            this.panelMain.TabIndex = 10;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 41);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.chkSeleccionarTodo);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.treeListMenu);
            this.splitContainerMain.Size = new System.Drawing.Size(768, 388);
            this.splitContainerMain.SplitterDistance = 25;
            this.splitContainerMain.TabIndex = 7;
            // 
            // FrmSeg_Menu_x_Empresa_x_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 484);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.UcMenu);
            this.Name = "FrmSeg_Menu_x_Empresa_x_Usuario";
            this.Text = "Menu por Empresa por Usuario";
            this.Load += new System.EventHandler(this.FrmSeg_Menu_x_Empresa_x_Usuario_Load);
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLectura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEscritura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEliminacion)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFiltro;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditEmpresa;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTreeList.TreeList treeListMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkLectura;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkEscritura;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkEliminacion;
        private System.Windows.Forms.CheckBox chkSeleccionarTodo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private Controles.UCGe_Menu_Superior_Mant UcMenu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.SplitContainer splitContainerMain;
    }
}