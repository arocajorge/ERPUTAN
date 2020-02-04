namespace Core.Erp.Winform.SeguridadAcceso
{
    partial class FrmSeg_Menu_x_Empresa
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.searchLookUpEditEmpresa = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.chkCheckearTodo = new System.Windows.Forms.CheckBox();
            this.treeListMenu = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.UCGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitContainerMenu = new System.Windows.Forms.SplitContainer();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenu)).BeginInit();
            this.splitContainerMenu.Panel1.SuspendLayout();
            this.splitContainerMenu.Panel2.SuspendLayout();
            this.splitContainerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.searchLookUpEditEmpresa);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(804, 39);
            this.panelTop.TabIndex = 4;
            // 
            // searchLookUpEditEmpresa
            // 
            this.searchLookUpEditEmpresa.Location = new System.Drawing.Point(74, 13);
            this.searchLookUpEditEmpresa.Name = "searchLookUpEditEmpresa";
            this.searchLookUpEditEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditEmpresa.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEditEmpresa.Size = new System.Drawing.Size(227, 20);
            this.searchLookUpEditEmpresa.TabIndex = 1;
            this.searchLookUpEditEmpresa.EditValueChanged += new System.EventHandler(this.searchLookUpEditEmpresa_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.gridColumn2.Caption = "Id";
            this.gridColumn2.FieldName = "IdEmpresa";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa: ";
            // 
            // chkCheckearTodo
            // 
            this.chkCheckearTodo.AutoSize = true;
            this.chkCheckearTodo.Location = new System.Drawing.Point(16, 7);
            this.chkCheckearTodo.Name = "chkCheckearTodo";
            this.chkCheckearTodo.Size = new System.Drawing.Size(106, 17);
            this.chkCheckearTodo.TabIndex = 2;
            this.chkCheckearTodo.Text = "Seleccionar todo";
            this.chkCheckearTodo.UseVisualStyleBackColor = true;
            this.chkCheckearTodo.CheckedChanged += new System.EventHandler(this.chkCheckearTodo_CheckedChanged);
            // 
            // treeListMenu
            // 
            this.treeListMenu.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4});
            this.treeListMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMenu.KeyFieldName = "IdMenu";
            this.treeListMenu.Location = new System.Drawing.Point(0, 0);
            this.treeListMenu.Name = "treeListMenu";
            this.treeListMenu.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.treeListMenu.OptionsBehavior.EnableFiltering = true;
            this.treeListMenu.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treeListMenu.OptionsPrint.UsePrintStyles = true;
            this.treeListMenu.OptionsView.ShowAutoFilterRow = true;
            this.treeListMenu.OptionsView.ShowCheckBoxes = true;
            this.treeListMenu.ParentFieldName = "IdMenuPadre";
            this.treeListMenu.Size = new System.Drawing.Size(804, 388);
            this.treeListMenu.TabIndex = 5;
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
            this.treeListColumn1.Width = 372;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Nombre Formulario";
            this.treeListColumn2.FieldName = "NomFormulario_x_Emp";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 205;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Nombre del ensamblado";
            this.treeListColumn3.FieldName = "NombreAsambly_x_Emp";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 181;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "SeModificoValor";
            this.treeListColumn4.FieldName = "SeModificoValor";
            this.treeListColumn4.Name = "treeListColumn4";
            // 
            // UCGe_Menu
            // 
            this.UCGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.UCGe_Menu.Enabled_bnRetImprimir = true;
            this.UCGe_Menu.Enabled_bntAnular = true;
            this.UCGe_Menu.Enabled_bntAprobar = true;
            this.UCGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.UCGe_Menu.Enabled_bntImprimir = true;
            this.UCGe_Menu.Enabled_bntImprimir_Guia = true;
            this.UCGe_Menu.Enabled_bntLimpiar = true;
            this.UCGe_Menu.Enabled_bntSalir = true;
            this.UCGe_Menu.Enabled_btn_conciliacion_Auto = true;
            this.UCGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.UCGe_Menu.Enabled_btn_Generar_XML = true;
            this.UCGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.UCGe_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.UCGe_Menu.Enabled_btn_Imprimir_Reten = true;
            this.UCGe_Menu.Enabled_btnAceptar = true;
            this.UCGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.UCGe_Menu.Enabled_btnEstadosOC = true;
            this.UCGe_Menu.Enabled_btnGuardar = true;
            this.UCGe_Menu.Enabled_btnImpFrm = true;
            this.UCGe_Menu.Enabled_btnImpLote = true;
            this.UCGe_Menu.Enabled_btnImpRep = true;
            this.UCGe_Menu.Enabled_btnImprimirSoporte = true;
            this.UCGe_Menu.Enabled_btnproductos = true;
            this.UCGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.UCGe_Menu.Name = "UCGe_Menu";
            this.UCGe_Menu.Size = new System.Drawing.Size(804, 29);
            this.UCGe_Menu.TabIndex = 6;
            this.UCGe_Menu.Visible_bntAnular = false;
            this.UCGe_Menu.Visible_bntAprobar = false;
            this.UCGe_Menu.Visible_bntDiseñoReporte = false;
            this.UCGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.UCGe_Menu.Visible_bntImprimir = true;
            this.UCGe_Menu.Visible_bntImprimir_Guia = false;
            this.UCGe_Menu.Visible_bntLimpiar = false;
            this.UCGe_Menu.Visible_bntReImprimir = false;
            this.UCGe_Menu.Visible_bntSalir = true;
            this.UCGe_Menu.Visible_btn_Actualizar = false;
            this.UCGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.UCGe_Menu.Visible_btn_Generar_XML = false;
            this.UCGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.UCGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.UCGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.UCGe_Menu.Visible_btnAceptar = false;
            this.UCGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.UCGe_Menu.Visible_btnContabilizar = false;
            this.UCGe_Menu.Visible_btnEstadosOC = false;
            this.UCGe_Menu.Visible_btnGuardar = true;
            this.UCGe_Menu.Visible_btnImpFrm = false;
            this.UCGe_Menu.Visible_btnImpLote = false;
            this.UCGe_Menu.Visible_btnImpRep = false;
            this.UCGe_Menu.Visible_btnImprimirSoporte = false;
            this.UCGe_Menu.Visible_btnModificar = false;
            this.UCGe_Menu.Visible_btnproductos = false;
            this.UCGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.UCGe_Menu_event_btnGuardar_Click);
            this.UCGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.UCGe_Menu_event_btnImprimir_Click);
            this.UCGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.UCGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 485);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(804, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 8;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.splitContainerMenu);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(804, 456);
            this.panelMain.TabIndex = 9;
            // 
            // splitContainerMenu
            // 
            this.splitContainerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMenu.Location = new System.Drawing.Point(0, 39);
            this.splitContainerMenu.Name = "splitContainerMenu";
            this.splitContainerMenu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMenu.Panel1
            // 
            this.splitContainerMenu.Panel1.Controls.Add(this.chkCheckearTodo);
            // 
            // splitContainerMenu.Panel2
            // 
            this.splitContainerMenu.Panel2.Controls.Add(this.treeListMenu);
            this.splitContainerMenu.Size = new System.Drawing.Size(804, 417);
            this.splitContainerMenu.SplitterDistance = 25;
            this.splitContainerMenu.TabIndex = 6;
            // 
            // FrmSeg_Menu_x_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.UCGe_Menu);
            this.Name = "FrmSeg_Menu_x_Empresa";
            this.Text = "Menu por empresa";
            this.Load += new System.EventHandler(this.FrmSeg_Menu_x_Empresa_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.splitContainerMenu.Panel1.ResumeLayout(false);
            this.splitContainerMenu.Panel1.PerformLayout();
            this.splitContainerMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenu)).EndInit();
            this.splitContainerMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditEmpresa;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTreeList.TreeList treeListMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.CheckBox chkCheckearTodo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private Controles.UCGe_Menu_Superior_Mant UCGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.SplitContainer splitContainerMenu;
    }
}