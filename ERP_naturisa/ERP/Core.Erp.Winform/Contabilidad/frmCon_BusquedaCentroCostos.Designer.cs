namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_BusquedaCentroCostos
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSeleccionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.treeList_CentroCosto = new DevExpress.XtraTreeList.TreeList();
            this.Centro_costo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList_CentroCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSeleccionar,
            this.toolStripLabel1,
            this.toolStripSeparator5,
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(653, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSeleccionar
            // 
            this.toolStripButtonSeleccionar.Image = global::Core.Erp.Winform.Properties.Resources.nuevo;
            this.toolStripButtonSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSeleccionar.Name = "toolStripButtonSeleccionar";
            this.toolStripButtonSeleccionar.Size = new System.Drawing.Size(87, 22);
            this.toolStripButtonSeleccionar.Text = "Seleccionar";
            this.toolStripButtonSeleccionar.Click += new System.EventHandler(this.toolStripButtonSeleccionar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(97, 22);
            this.toolStripLabel1.Text = "                              ";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "&Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // treeList_CentroCosto
            // 
            this.treeList_CentroCosto.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.Centro_costo,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn1});
            this.treeList_CentroCosto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList_CentroCosto.KeyFieldName = "IdCentroCosto";
            this.treeList_CentroCosto.Location = new System.Drawing.Point(0, 25);
            this.treeList_CentroCosto.Name = "treeList_CentroCosto";
            this.treeList_CentroCosto.OptionsBehavior.Editable = false;
            this.treeList_CentroCosto.OptionsBehavior.EnableFiltering = true;
            this.treeList_CentroCosto.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treeList_CentroCosto.OptionsFilter.ShowAllValuesInFilterPopup = true;
            this.treeList_CentroCosto.OptionsPrint.UsePrintStyles = true;
            this.treeList_CentroCosto.OptionsView.ShowAutoFilterRow = true;
            this.treeList_CentroCosto.ParentFieldName = "IdCentroCostoPadre";
            this.treeList_CentroCosto.Size = new System.Drawing.Size(653, 406);
            this.treeList_CentroCosto.TabIndex = 8;
            this.treeList_CentroCosto.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList_CentroCosto_FocusedNodeChanged);
            this.treeList_CentroCosto.DoubleClick += new System.EventHandler(this.treeList_CentroCosto_DoubleClick);
            // 
            // Centro_costo
            // 
            this.Centro_costo.Caption = "Centro_costo";
            this.Centro_costo.FieldName = "Centro_costo";
            this.Centro_costo.Name = "Centro_costo";
            this.Centro_costo.OptionsColumn.AllowEdit = false;
            this.Centro_costo.Visible = true;
            this.Centro_costo.VisibleIndex = 0;
            this.Centro_costo.Width = 159;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Centro  de costo Padre";
            this.treeListColumn2.FieldName = "Centro_costoPadre";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 265;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "id";
            this.treeListColumn3.FieldName = "IdCentroCosto";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 106;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "IdCtaCble";
            this.treeListColumn1.FieldName = "IdCtaCble";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 3;
            this.treeListColumn1.Width = 105;
            // 
            // frmCon_BusquedaCentroCostos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 431);
            this.Controls.Add(this.treeList_CentroCosto);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCon_BusquedaCentroCostos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Centro de Costo";
            this.Load += new System.EventHandler(this.frmCon_BusquedaCentroCostos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList_CentroCosto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSeleccionar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private DevExpress.XtraTreeList.TreeList treeList_CentroCosto;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Centro_costo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
    }
}