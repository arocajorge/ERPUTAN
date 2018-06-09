namespace Core.Erp.Winform.Controles
{
    partial class UCIN_CategoriaGeneral
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
            this.treeListCategoria = new DevExpress.XtraTreeList.TreeList();
            this.ca_Categoria = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ca_Posicion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ca_indexIcono = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Estado = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCategoria = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCategoriaPadre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeListCategoria)).BeginInit();
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
            this.treeListCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListCategoria.KeyFieldName = "IdCategoria";
            this.treeListCategoria.Location = new System.Drawing.Point(0, 0);
            this.treeListCategoria.Name = "treeListCategoria";
            this.treeListCategoria.OptionsPrint.UsePrintStyles = true;
            this.treeListCategoria.OptionsSelection.MultiSelect = true;
            this.treeListCategoria.OptionsView.ShowCheckBoxes = true;
            this.treeListCategoria.ParentFieldName = "IdCategoriaPadre";
            this.treeListCategoria.Size = new System.Drawing.Size(330, 301);
            this.treeListCategoria.TabIndex = 1;
            this.treeListCategoria.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeListCategoria_AfterCheckNode_1);
            this.treeListCategoria.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListCategoria_FocusedNodeChanged_1);
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
            // UCIN_CategoriaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeListCategoria);
            this.Name = "UCIN_CategoriaGeneral";
            this.Size = new System.Drawing.Size(330, 301);
            this.Load += new System.EventHandler(this.UCIN_CategoriaGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListCategoria)).EndInit();
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
    }
}
