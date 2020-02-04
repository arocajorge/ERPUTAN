namespace Core.Erp.Winform.Controles
{
    partial class UCIn_Categorias
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCIn_Categorias));
            this.treeListCategoria = new DevExpress.XtraTreeList.TreeList();
            this.ca_Categoria = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ca_Posicion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ca_indexIcono = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Estado = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCategoria = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCategoriaPadre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeListCategoria)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeListCategoria
            // 
            this.treeListCategoria.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.ca_Categoria,
            this.ca_Posicion,
            this.ca_indexIcono,
            this.Estado,
            this.IdCategoria,
            this.IdCategoriaPadre});
            this.treeListCategoria.KeyFieldName = "IdCategoria";
            this.treeListCategoria.Location = new System.Drawing.Point(0, 0);
            this.treeListCategoria.Name = "treeListCategoria";
            this.treeListCategoria.OptionsPrint.UsePrintStyles = true;
            this.treeListCategoria.OptionsSelection.MultiSelect = true;
            this.treeListCategoria.OptionsView.ShowCheckBoxes = true;
            this.treeListCategoria.ParentFieldName = "IdCategoriaPadre";
            this.treeListCategoria.Size = new System.Drawing.Size(268, 166);
            this.treeListCategoria.TabIndex = 0;
            this.treeListCategoria.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeListCategoria_AfterCheckNode);
            this.treeListCategoria.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListCategoria_FocusedNodeChanged);
            // 
            // ca_Categoria
            // 
            this.ca_Categoria.Caption = "Categoria";
            this.ca_Categoria.FieldName = "ca_Categoria";
            this.ca_Categoria.MinWidth = 32;
            this.ca_Categoria.Name = "ca_Categoria";
            this.ca_Categoria.OptionsColumn.AllowEdit = false;
            this.ca_Categoria.Visible = true;
            this.ca_Categoria.VisibleIndex = 0;
            this.ca_Categoria.Width = 269;
            // 
            // ca_Posicion
            // 
            this.ca_Posicion.Caption = "Posicion";
            this.ca_Posicion.FieldName = "ca_Posicion";
            this.ca_Posicion.Name = "ca_Posicion";
            this.ca_Posicion.OptionsColumn.AllowEdit = false;
            this.ca_Posicion.Visible = true;
            this.ca_Posicion.VisibleIndex = 1;
            this.ca_Posicion.Width = 29;
            // 
            // ca_indexIcono
            // 
            this.ca_indexIcono.Caption = "indexIcono";
            this.ca_indexIcono.FieldName = "ca_indexIcono";
            this.ca_indexIcono.Name = "ca_indexIcono";
            this.ca_indexIcono.OptionsColumn.AllowEdit = false;
            this.ca_indexIcono.Width = 27;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.OptionsColumn.AllowEdit = false;
            this.Estado.Width = 20;
            // 
            // IdCategoria
            // 
            this.IdCategoria.Caption = "IdCategoria";
            this.IdCategoria.FieldName = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.OptionsColumn.AllowEdit = false;
            this.IdCategoria.Visible = true;
            this.IdCategoria.VisibleIndex = 2;
            this.IdCategoria.Width = 20;
            // 
            // IdCategoriaPadre
            // 
            this.IdCategoriaPadre.Caption = "IdCategoriaPadre";
            this.IdCategoriaPadre.FieldName = "IdCategoriaPadre";
            this.IdCategoriaPadre.Name = "IdCategoriaPadre";
            this.IdCategoriaPadre.OptionsColumn.AllowEdit = false;
            this.IdCategoriaPadre.Width = 20;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empleado.ico");
            this.imageList1.Images.SetKeyName(1, "nuevo_32x32.png");
            this.imageList1.Images.SetKeyName(2, "admin_32x32.png");
            this.imageList1.Images.SetKeyName(3, "downloads1.ico");
            this.imageList1.Images.SetKeyName(4, "ico_insert1.png");
            this.imageList1.Images.SetKeyName(5, "agregar2.png");
            // 
            // MenuAcciones
            // 
            this.MenuAcciones.AllowDrop = true;
            this.MenuAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.MenuAcciones.Name = "MenuAcciones";
            this.MenuAcciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuAcciones.Size = new System.Drawing.Size(126, 70);
            this.MenuAcciones.Text = "Acciones";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // cmb_Acciones
            // 
            this.cmb_Acciones.ContextMenuStrip = this.MenuAcciones;
            this.cmb_Acciones.ImageIndex = 1;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(274, 145);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.ShowArrowButton = false;
            this.cmb_Acciones.Size = new System.Drawing.Size(36, 22);
            this.cmb_Acciones.TabIndex = 2;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
            // 
            // UCIn_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.treeListCategoria);
            this.Name = "UCIn_Categorias";
            this.Size = new System.Drawing.Size(315, 169);
            this.Load += new System.EventHandler(this.UCIN_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListCategoria)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraTreeList.TreeList treeListCategoria;
        public DevExpress.XtraTreeList.Columns.TreeListColumn ca_Categoria;
        public DevExpress.XtraTreeList.Columns.TreeListColumn ca_Posicion;
        public DevExpress.XtraTreeList.Columns.TreeListColumn ca_indexIcono;
        public DevExpress.XtraTreeList.Columns.TreeListColumn Estado;
        public DevExpress.XtraTreeList.Columns.TreeListColumn IdCategoria;
        public DevExpress.XtraTreeList.Columns.TreeListColumn IdCategoriaPadre;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
    }
}
