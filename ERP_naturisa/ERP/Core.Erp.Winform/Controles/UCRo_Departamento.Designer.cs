namespace Core.Erp.Winform.Controles
{
    partial class UCRo_Departamento
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
            this.TreeListDepartamento = new DevExpress.XtraTreeList.TreeList();
            this.de_descripcion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TreeListDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeListDepartamento
            // 
            this.TreeListDepartamento.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.de_descripcion,
            this.treeListColumn1,
            this.treeListColumn2});
            this.TreeListDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeListDepartamento.KeyFieldName = "IdDepartamento";
            this.TreeListDepartamento.Location = new System.Drawing.Point(0, 0);
            this.TreeListDepartamento.Name = "TreeListDepartamento";
            this.TreeListDepartamento.OptionsPrint.UsePrintStyles = true;
            this.TreeListDepartamento.OptionsView.ShowCheckBoxes = true;
            this.TreeListDepartamento.ParentFieldName = "IdDepartamentoPadre";
            this.TreeListDepartamento.Size = new System.Drawing.Size(330, 339);
            this.TreeListDepartamento.TabIndex = 0;
            this.TreeListDepartamento.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.TreeListDepartamento_AfterCheckNode);
            this.TreeListDepartamento.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.TreeListDepartamento_FocusedNodeChanged);
            // 
            // de_descripcion
            // 
            this.de_descripcion.Caption = "Descripción";
            this.de_descripcion.FieldName = "de_descripcion";
            this.de_descripcion.MinWidth = 32;
            this.de_descripcion.Name = "de_descripcion";
            this.de_descripcion.OptionsColumn.AllowEdit = false;
            this.de_descripcion.Visible = true;
            this.de_descripcion.VisibleIndex = 0;
            this.de_descripcion.Width = 245;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "IdDepartamento";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "treeListColumn2";
            this.treeListColumn2.FieldName = "IdDepartamentoPadre";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            // 
            // UCRo_Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TreeListDepartamento);
            this.Name = "UCRo_Departamento";
            this.Size = new System.Drawing.Size(330, 339);
            this.Load += new System.EventHandler(this.UCRo_Departamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TreeListDepartamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraTreeList.TreeList TreeListDepartamento;
        private DevExpress.XtraTreeList.Columns.TreeListColumn de_descripcion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
    }
}
