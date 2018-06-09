namespace Core.Erp.Winform.Inventario
{
    partial class Frm_Cat_Line_Grup_SubGrup_Mant
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCatetegoria = new System.Windows.Forms.ToolStripButton();
            this.btnLinea = new System.Windows.Forms.ToolStripButton();
            this.btnGrupo = new System.Windows.Forms.ToolStripButton();
            this.btnSubGrupo = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeListLinGruSub = new DevExpress.XtraTreeList.TreeList();
            this.descripcion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IDPadre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Estado = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCategoria = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdLinea = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdGrupo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdSubGrupo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.menuCategorias = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMenuItemNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItemModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItemConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItemAnular = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLinGruSub)).BeginInit();
            this.menuCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCatetegoria,
            this.btnLinea,
            this.btnGrupo,
            this.btnSubGrupo,
            this.btnImprimir,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(931, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCatetegoria
            // 
            this.btnCatetegoria.Image = global::Core.Erp.Winform.Properties.Resources.nuevo;
            this.btnCatetegoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCatetegoria.Name = "btnCatetegoria";
            this.btnCatetegoria.Size = new System.Drawing.Size(115, 22);
            this.btnCatetegoria.Text = "Nueva Categoría";
            this.btnCatetegoria.Click += new System.EventHandler(this.btnCatetegoria_Click);
            // 
            // btnLinea
            // 
            this.btnLinea.Image = global::Core.Erp.Winform.Properties.Resources.nuevo;
            this.btnLinea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(92, 22);
            this.btnLinea.Text = "Nueva Linea";
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnGrupo
            // 
            this.btnGrupo.Image = global::Core.Erp.Winform.Properties.Resources.nuevo;
            this.btnGrupo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(98, 22);
            this.btnGrupo.Text = "Nuevo Grupo";
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // btnSubGrupo
            // 
            this.btnSubGrupo.Image = global::Core.Erp.Winform.Properties.Resources.nuevo;
            this.btnSubGrupo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSubGrupo.Name = "btnSubGrupo";
            this.btnSubGrupo.Size = new System.Drawing.Size(121, 22);
            this.btnSubGrupo.Text = "Nuevo Sub Grupo";
            this.btnSubGrupo.Click += new System.EventHandler(this.btnSubGrupo_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Core.Erp.Winform.Properties.Resources.imprimir;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.treeListLinGruSub);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 374);
            this.panel2.TabIndex = 2;
            // 
            // treeListLinGruSub
            // 
            this.treeListLinGruSub.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.descripcion,
            this.ID,
            this.IDPadre,
            this.Estado,
            this.IdCategoria,
            this.IdLinea,
            this.IdGrupo,
            this.IdSubGrupo});
            this.treeListLinGruSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListLinGruSub.Location = new System.Drawing.Point(0, 0);
            this.treeListLinGruSub.Name = "treeListLinGruSub";
            this.treeListLinGruSub.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListLinGruSub.OptionsPrint.UsePrintStyles = true;
            this.treeListLinGruSub.ParentFieldName = "IDPadre";
            this.treeListLinGruSub.Size = new System.Drawing.Size(931, 374);
            this.treeListLinGruSub.TabIndex = 0;
            this.treeListLinGruSub.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.treeListLinGruSub_NodeCellStyle);
            this.treeListLinGruSub.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListLinGruSub_FocusedNodeChanged);
            this.treeListLinGruSub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeListLinGruSub_MouseUp);
            // 
            // descripcion
            // 
            this.descripcion.Caption = "Descripción";
            this.descripcion.FieldName = "descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.OptionsColumn.AllowEdit = false;
            this.descripcion.Visible = true;
            this.descripcion.VisibleIndex = 0;
            this.descripcion.Width = 173;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 1;
            this.ID.Width = 79;
            // 
            // IDPadre
            // 
            this.IDPadre.Caption = "IDPadre";
            this.IDPadre.FieldName = "IDPadre";
            this.IDPadre.Name = "IDPadre";
            this.IDPadre.OptionsColumn.AllowEdit = false;
            this.IDPadre.Visible = true;
            this.IDPadre.VisibleIndex = 2;
            this.IDPadre.Width = 79;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.OptionsColumn.AllowEdit = false;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 3;
            this.Estado.Width = 79;
            // 
            // IdCategoria
            // 
            this.IdCategoria.Caption = "IdCategoria";
            this.IdCategoria.FieldName = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.OptionsColumn.AllowEdit = false;
            this.IdCategoria.Visible = true;
            this.IdCategoria.VisibleIndex = 4;
            this.IdCategoria.Width = 79;
            // 
            // IdLinea
            // 
            this.IdLinea.Caption = "IdLinea";
            this.IdLinea.FieldName = "IdLinea";
            this.IdLinea.Name = "IdLinea";
            this.IdLinea.OptionsColumn.AllowEdit = false;
            this.IdLinea.Visible = true;
            this.IdLinea.VisibleIndex = 5;
            // 
            // IdGrupo
            // 
            this.IdGrupo.Caption = "IdGrupo";
            this.IdGrupo.FieldName = "IdGrupo";
            this.IdGrupo.Name = "IdGrupo";
            this.IdGrupo.OptionsColumn.AllowEdit = false;
            this.IdGrupo.Visible = true;
            this.IdGrupo.VisibleIndex = 6;
            // 
            // IdSubGrupo
            // 
            this.IdSubGrupo.Caption = "IdSubGrupo";
            this.IdSubGrupo.FieldName = "IdSubGrupo";
            this.IdSubGrupo.Name = "IdSubGrupo";
            this.IdSubGrupo.OptionsColumn.AllowEdit = false;
            this.IdSubGrupo.Visible = true;
            this.IdSubGrupo.VisibleIndex = 7;
            // 
            // menuCategorias
            // 
            this.menuCategorias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuItemNuevo,
            this.btnMenuItemModificar,
            this.btnMenuItemConsulta,
            this.btnMenuItemAnular});
            this.menuCategorias.Name = "menuCategorias";
            this.menuCategorias.Size = new System.Drawing.Size(180, 92);
            // 
            // btnMenuItemNuevo
            // 
            this.btnMenuItemNuevo.Name = "btnMenuItemNuevo";
            this.btnMenuItemNuevo.Size = new System.Drawing.Size(179, 22);
            this.btnMenuItemNuevo.Text = "Nueva Categoría";
            this.btnMenuItemNuevo.Click += new System.EventHandler(this.btnMenuItemNuevo_Click);
            // 
            // btnMenuItemModificar
            // 
            this.btnMenuItemModificar.Name = "btnMenuItemModificar";
            this.btnMenuItemModificar.Size = new System.Drawing.Size(179, 22);
            this.btnMenuItemModificar.Text = "Modificar Categoría";
            this.btnMenuItemModificar.Click += new System.EventHandler(this.btnMenuItemModificar_Click);
            // 
            // btnMenuItemConsulta
            // 
            this.btnMenuItemConsulta.Name = "btnMenuItemConsulta";
            this.btnMenuItemConsulta.Size = new System.Drawing.Size(179, 22);
            this.btnMenuItemConsulta.Text = "Consultar Categoría";
            this.btnMenuItemConsulta.Click += new System.EventHandler(this.btnMenuItemConsulta_Click);
            // 
            // btnMenuItemAnular
            // 
            this.btnMenuItemAnular.Name = "btnMenuItemAnular";
            this.btnMenuItemAnular.Size = new System.Drawing.Size(179, 22);
            this.btnMenuItemAnular.Text = "Anular Categoría";
            this.btnMenuItemAnular.Click += new System.EventHandler(this.btnMenuItemAnular_Click);
            // 
            // Frm_Cat_Line_Grup_SubGrup_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 399);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_Cat_Line_Grup_SubGrup_Mant";
            this.Text = "Mantenimiento Categoría - Linea - Grupo - SubGrupo";
            this.Load += new System.EventHandler(this.Frm_Cat_Line_Grup_SubGrup_Mant_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListLinGruSub)).EndInit();
            this.menuCategorias.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCatetegoria;
        private System.Windows.Forms.ToolStripButton btnLinea;
        private System.Windows.Forms.ToolStripButton btnGrupo;
        private System.Windows.Forms.ToolStripButton btnSubGrupo;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip menuCategorias;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemNuevo;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemModificar;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemConsulta;
        private DevExpress.XtraTreeList.TreeList treeListLinGruSub;
        private DevExpress.XtraTreeList.Columns.TreeListColumn descripcion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IDPadre;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Estado;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdCategoria;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdLinea;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdGrupo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdSubGrupo;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemAnular;
    }
}