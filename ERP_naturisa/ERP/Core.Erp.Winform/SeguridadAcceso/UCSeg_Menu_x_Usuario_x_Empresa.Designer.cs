namespace Core.Erp.Winform.SeguridadAcceso
{
    partial class UCSeg_Menu_x_Usuario_x_Empresa
    {
        public DevExpress.XtraTreeList.TreeList treeListMenu_x_Usuario_x_Empresa;
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSeg_Menu_x_Usuario_x_Empresa));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeListMenu_x_Usuario_x_Empresa = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Tiene_FormularioAsociado = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExpandir = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.btnRefrescarMenu = new DevExpress.XtraEditors.SimpleButton();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu_x_Usuario_x_Empresa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(396, 478);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeListMenu_x_Usuario_x_Empresa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 447);
            this.panel2.TabIndex = 4;
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
            this.treeListMenu_x_Usuario_x_Empresa.KeyFieldName = "IdMenu";
            this.treeListMenu_x_Usuario_x_Empresa.Location = new System.Drawing.Point(0, 0);
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
            this.treeListMenu_x_Usuario_x_Empresa.ParentFieldName = "IdMenuPadre";
            this.treeListMenu_x_Usuario_x_Empresa.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow;
            this.treeListMenu_x_Usuario_x_Empresa.Size = new System.Drawing.Size(396, 447);
            this.treeListMenu_x_Usuario_x_Empresa.TabIndex = 0;
            this.treeListMenu_x_Usuario_x_Empresa.SelectImageClick += new DevExpress.XtraTreeList.NodeClickEventHandler(this.treeListMenu_x_Usuario_x_Empresa_SelectImageClick);
            this.treeListMenu_x_Usuario_x_Empresa.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.treeListMenu_x_Usuario_x_Empresa_NodeCellStyle);
            this.treeListMenu_x_Usuario_x_Empresa.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListMenu_x_Usuario_x_Empresa_FocusedNodeChanged);
            this.treeListMenu_x_Usuario_x_Empresa.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeListMenu_x_Usuario_x_Empresa_CustomDrawNodeCell);
            this.treeListMenu_x_Usuario_x_Empresa.TreeListMenuItemClick += new DevExpress.XtraTreeList.TreeListMenuItemClickEventHandler(this.treeListMenu_x_Usuario_x_Empresa_TreeListMenuItemClick);
            this.treeListMenu_x_Usuario_x_Empresa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.treeListMenu_x_Usuario_x_Empresa_KeyUp);
            this.treeListMenu_x_Usuario_x_Empresa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeListMenu_x_Usuario_x_Empresa_MouseClick);
            this.treeListMenu_x_Usuario_x_Empresa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeListMenu_x_Usuario_x_Empresa_MouseDoubleClick);
            this.treeListMenu_x_Usuario_x_Empresa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeListMenu_x_Usuario_x_Empresa_MouseDown);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExpandir);
            this.panel1.Controls.Add(this.btnRefrescarMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 31);
            this.panel1.TabIndex = 3;
            // 
            // btnExpandir
            // 
            this.btnExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandir.ImageIndex = 7;
            this.btnExpandir.ImageList = this.imageList1;
            this.btnExpandir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExpandir.Location = new System.Drawing.Point(347, 3);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(35, 26);
            this.btnExpandir.TabIndex = 5;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "carpeta.jpg");
            this.imageList1.Images.SetKeyName(1, "Icono_mantenimiento.ico");
            this.imageList1.Images.SetKeyName(2, "formulario.png");
            this.imageList1.Images.SetKeyName(3, "sinFrom.png");
            this.imageList1.Images.SetKeyName(4, "costos.png");
            this.imageList1.Images.SetKeyName(5, "reporte.jpg");
            this.imageList1.Images.SetKeyName(6, "x.jpg");
            this.imageList1.Images.SetKeyName(7, "mas_menos.jpg");
            this.imageList1.Images.SetKeyName(8, "refrsh.png");
            // 
            // btnRefrescarMenu
            // 
            this.btnRefrescarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescarMenu.ImageIndex = 8;
            this.btnRefrescarMenu.ImageList = this.imageList1;
            this.btnRefrescarMenu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRefrescarMenu.Location = new System.Drawing.Point(306, 3);
            this.btnRefrescarMenu.Name = "btnRefrescarMenu";
            this.btnRefrescarMenu.Size = new System.Drawing.Size(35, 26);
            this.btnRefrescarMenu.TabIndex = 4;
            this.btnRefrescarMenu.Click += new System.EventHandler(this.btnRefrescarMenu_Click_1);
            // 
            // UCSeg_Menu_x_Usuario_x_Empresa
            // 
            this.Controls.Add(this.panelMenu);
            this.Name = "UCSeg_Menu_x_Usuario_x_Empresa";
            this.Size = new System.Drawing.Size(396, 478);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu_x_Usuario_x_Empresa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private DevExpress.XtraTreeList.TreeList treeListMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        public System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Tiene_FormularioAsociado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraEditors.SimpleButton btnExpandir;
        private DevExpress.XtraEditors.SimpleButton btnRefrescarMenu;
    }
}
