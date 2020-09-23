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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu_x_Usuario_x_Empresa)).BeginInit();
            this.panel2.SuspendLayout();
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeListMenu_x_Usuario_x_Empresa);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 729);
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
            this.treeListMenu_x_Usuario_x_Empresa.Size = new System.Drawing.Size(383, 698);
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
            // 
            // frmCon_DistribucionMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 758);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCon_DistribucionMantenimiento";
            this.Text = "frmCon_DistribucionMantenimiento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCon_DistribucionMantenimiento_FormClosed);
            this.Load += new System.EventHandler(this.frmCon_DistribucionMantenimiento_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu_x_Usuario_x_Empresa)).EndInit();
            this.panel2.ResumeLayout(false);
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
    }
}