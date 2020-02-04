namespace Core.Erp.Seguridad_Acceso.Winform_Controls
{
    partial class UCMenu_x_Usuario_x_Empresa
    {
        private DevExpress.XtraTreeList.TreeList treeListMenu_x_Usuario_x_Empresa;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMenu_x_Usuario_x_Empresa));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExpandir = new System.Windows.Forms.Button();
            this.btnContraer = new System.Windows.Forms.Button();
            this.treeListMenu_x_Usuario_x_Empresa = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Tiene_FormularioAsociado = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu_x_Usuario_x_Empresa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnExpandir);
            this.panelMenu.Controls.Add(this.btnContraer);
            this.panelMenu.Controls.Add(this.treeListMenu_x_Usuario_x_Empresa);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(422, 478);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnExpandir
            // 
            this.btnExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandir.BackgroundImage = global::Core.Erp.Seguridad_Acceso.Properties.Resources.menos;
            this.btnExpandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpandir.Location = new System.Drawing.Point(374, 1);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(48, 26);
            this.btnExpandir.TabIndex = 2;
            this.btnExpandir.UseVisualStyleBackColor = true;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
            // 
            // btnContraer
            // 
            this.btnContraer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContraer.BackgroundImage = global::Core.Erp.Seguridad_Acceso.Properties.Resources.mas;
            this.btnContraer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContraer.Location = new System.Drawing.Point(327, 1);
            this.btnContraer.Name = "btnContraer";
            this.btnContraer.Size = new System.Drawing.Size(48, 26);
            this.btnContraer.TabIndex = 1;
            this.btnContraer.UseVisualStyleBackColor = true;
            this.btnContraer.Click += new System.EventHandler(this.btnContraer_Click);
            // 
            // treeListMenu_x_Usuario_x_Empresa
            // 
            this.treeListMenu_x_Usuario_x_Empresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListMenu_x_Usuario_x_Empresa.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.Tiene_FormularioAsociado});
            this.treeListMenu_x_Usuario_x_Empresa.ImageIndexFieldName = "icono";
            this.treeListMenu_x_Usuario_x_Empresa.KeyFieldName = "IdMenu";
            this.treeListMenu_x_Usuario_x_Empresa.Location = new System.Drawing.Point(0, 27);
            this.treeListMenu_x_Usuario_x_Empresa.Name = "treeListMenu_x_Usuario_x_Empresa";
            this.treeListMenu_x_Usuario_x_Empresa.OptionsBehavior.Editable = false;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsBehavior.EnableFiltering = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsPrint.PrintHorzLines = false;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsPrint.PrintVertLines = false;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsPrint.UsePrintStyles = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsSelection.UseIndicatorForSelection = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowAutoFilterRow = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowButtons = false;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowColumns = false;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.ShowAlways;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowHorzLines = false;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowIndicator = false;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowPreview = true;
            this.treeListMenu_x_Usuario_x_Empresa.ParentFieldName = "IdMenuPadre";
            this.treeListMenu_x_Usuario_x_Empresa.Size = new System.Drawing.Size(422, 448);
            this.treeListMenu_x_Usuario_x_Empresa.TabIndex = 0;
            this.treeListMenu_x_Usuario_x_Empresa.SelectImageClick += new DevExpress.XtraTreeList.NodeClickEventHandler(this.treeListMenu_x_Usuario_x_Empresa_SelectImageClick);
            this.treeListMenu_x_Usuario_x_Empresa.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListMenu_x_Usuario_x_Empresa_FocusedNodeChanged);
            this.treeListMenu_x_Usuario_x_Empresa.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeListMenu_x_Usuario_x_Empresa_CustomDrawNodeCell);
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
            // 
            // UCMenu_x_Usuario_x_Empresa
            // 
            this.Controls.Add(this.panelMenu);
            this.Name = "UCMenu_x_Usuario_x_Empresa";
            this.Size = new System.Drawing.Size(422, 478);
            this.Load += new System.EventHandler(this.UCMenu_x_Usuario_x_Empresa_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu_x_Usuario_x_Empresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private DevExpress.XtraTreeList.TreeList treeListMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Tiene_FormularioAsociado;
        private System.Windows.Forms.Button btnExpandir;
        private System.Windows.Forms.Button btnContraer;
    }
}
