namespace Core.Erp.Winform.Inventario
{
    partial class frmIn_CategoriaConsulta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIn_CategoriaConsulta));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeListCategorias = new DevExpress.XtraTreeList.TreeList();
            this.ca_Categoria = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Posicion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ca_indexIcono = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Estado = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCategoria = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCategoriaPadre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.contextMenuStripMant = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListCategorias)).BeginInit();
            this.contextMenuStripMant.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(705, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.toolStripSeparator1,
            this.btnModificar,
            this.toolStripSeparator2,
            this.btnConsultar,
            this.toolStripSeparator3,
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(705, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(62, 22);
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 22);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(705, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeListCategorias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 363);
            this.panel1.TabIndex = 4;
            // 
            // treeListCategorias
            // 
            this.treeListCategorias.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.ca_Categoria,
            this.Posicion,
            this.ca_indexIcono,
            this.Estado,
            this.IdCategoria,
            this.IdCategoriaPadre});
            this.treeListCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListCategorias.KeyFieldName = "IdCategoria";
            this.treeListCategorias.Location = new System.Drawing.Point(0, 0);
            this.treeListCategorias.Name = "treeListCategorias";
            this.treeListCategorias.OptionsPrint.UsePrintStyles = true;
            this.treeListCategorias.ParentFieldName = "IdCategoriaPadre";
            this.treeListCategorias.Size = new System.Drawing.Size(705, 363);
            this.treeListCategorias.TabIndex = 0;
            this.treeListCategorias.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListCategorias_FocusedNodeChanged);
            this.treeListCategorias.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeListCategorias_MouseUp);
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
            this.ca_Categoria.Width = 432;
            // 
            // Posicion
            // 
            this.Posicion.Caption = "Posicion";
            this.Posicion.FieldName = "ca_Posicion";
            this.Posicion.Name = "Posicion";
            this.Posicion.OptionsColumn.AllowEdit = false;
            this.Posicion.Visible = true;
            this.Posicion.VisibleIndex = 1;
            this.Posicion.Width = 60;
            // 
            // ca_indexIcono
            // 
            this.ca_indexIcono.Caption = "IndexIcono";
            this.ca_indexIcono.FieldName = "ca_indexIcono";
            this.ca_indexIcono.Name = "ca_indexIcono";
            this.ca_indexIcono.OptionsColumn.AllowEdit = false;
            this.ca_indexIcono.Visible = true;
            this.ca_indexIcono.VisibleIndex = 2;
            this.ca_indexIcono.Width = 57;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.OptionsColumn.AllowEdit = false;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 3;
            this.Estado.Width = 50;
            // 
            // IdCategoria
            // 
            this.IdCategoria.Caption = "IdCategoria";
            this.IdCategoria.FieldName = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.OptionsColumn.AllowEdit = false;
            this.IdCategoria.Visible = true;
            this.IdCategoria.VisibleIndex = 4;
            this.IdCategoria.Width = 88;
            // 
            // IdCategoriaPadre
            // 
            this.IdCategoriaPadre.Caption = "IdCategoriaPadre";
            this.IdCategoriaPadre.FieldName = "IdCategoriaPadre";
            this.IdCategoriaPadre.Name = "IdCategoriaPadre";
            this.IdCategoriaPadre.OptionsColumn.AllowEdit = false;
            // 
            // contextMenuStripMant
            // 
            this.contextMenuStripMant.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.contextMenuStripMant.Name = "contextMenuStripMant";
            this.contextMenuStripMant.Size = new System.Drawing.Size(126, 48);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // frmIn_CategoriaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmIn_CategoriaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Categorias";
            this.Load += new System.EventHandler(this.frmIn_CategoriaConsulta_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListCategorias)).EndInit();
            this.contextMenuStripMant.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraTreeList.TreeList treeListCategorias;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMant;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        
        private DevExpress.XtraTreeList.Columns.TreeListColumn ca_Categoria;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Posicion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ca_indexIcono;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Estado;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdCategoria;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdCategoriaPadre;
    }
}