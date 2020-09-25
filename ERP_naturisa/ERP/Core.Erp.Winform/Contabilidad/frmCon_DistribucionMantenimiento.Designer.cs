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
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefrescarMenu = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
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
            this.panel1.Size = new System.Drawing.Size(383, 597);
            this.panel1.TabIndex = 1;
            // 
            // treeListMenu_x_Usuario_x_Empresa
            // 
            this.treeListMenu_x_Usuario_x_Empresa.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.Tiene_FormularioAsociado,
            this.treeListColumn3});
            this.treeListMenu_x_Usuario_x_Empresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMenu_x_Usuario_x_Empresa.ImageIndexFieldName = "icono";
            this.treeListMenu_x_Usuario_x_Empresa.KeyFieldName = "IdCtaCble";
            this.treeListMenu_x_Usuario_x_Empresa.Location = new System.Drawing.Point(0, 31);
            this.treeListMenu_x_Usuario_x_Empresa.Name = "treeListMenu_x_Usuario_x_Empresa";
            this.treeListMenu_x_Usuario_x_Empresa.OptionsBehavior.Editable = false;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsBehavior.EnableFiltering = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsPrint.PrintAllNodes = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsPrint.PrintFilledTreeIndent = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsPrint.UsePrintStyles = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsSelection.UseIndicatorForSelection = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowAutoFilterRow = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowColumns = false;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.ShowAlways;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowHorzLines = false;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowIndicator = false;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowPreview = true;
            this.treeListMenu_x_Usuario_x_Empresa.ParentFieldName = "IdCtaCblePadre";
            this.treeListMenu_x_Usuario_x_Empresa.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow;
            this.treeListMenu_x_Usuario_x_Empresa.Size = new System.Drawing.Size(383, 566);
            this.treeListMenu_x_Usuario_x_Empresa.TabIndex = 1;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Descripcion";
            this.treeListColumn1.FieldName = "DescripcionMenu";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "id";
            this.treeListColumn2.FieldName = "IdMenu";
            this.treeListColumn2.Name = "treeListColumn2";
            // 
            // Tiene_FormularioAsociado
            // 
            this.Tiene_FormularioAsociado.Caption = "treeListColumn3";
            this.Tiene_FormularioAsociado.FieldName = "Tiene_FormularioAsociado";
            this.Tiene_FormularioAsociado.Name = "Tiene_FormularioAsociado";
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "PosicionMenu";
            this.treeListColumn3.FieldName = "PosicionMenu";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefrescarMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 31);
            this.panel2.TabIndex = 4;
            // 
            // btnRefrescarMenu
            // 
            this.btnRefrescarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescarMenu.Image = global::Core.Erp.Winform.Properties.Resources.re_hacer_16x16;
            this.btnRefrescarMenu.ImageIndex = 8;
            this.btnRefrescarMenu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRefrescarMenu.Location = new System.Drawing.Point(345, 3);
            this.btnRefrescarMenu.Name = "btnRefrescarMenu";
            this.btnRefrescarMenu.Size = new System.Drawing.Size(35, 26);
            this.btnRefrescarMenu.TabIndex = 4;
            this.btnRefrescarMenu.Click += new System.EventHandler(this.btnRefrescarMenu_Click);
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
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1442, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por distribuir";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 43);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Observacion";
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
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucMenu;
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraTreeList.TreeList treeListMenu_x_Usuario_x_Empresa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Tiene_FormularioAsociado;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnRefrescarMenu;
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
    }
}