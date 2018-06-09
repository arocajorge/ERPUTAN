namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_PlanCta_Busqueda
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.treeListPlanCta = new DevExpress.XtraTreeList.TreeList();
            this.pc_Cuenta2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCtaCble = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCtaCblePadre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCatalogo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pc_Naturaleza = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdNivelCta = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdGrupoCble = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pc_Estado = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pc_EsMovimiento = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pc_clave_corta = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPlanCta)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(816, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(71, 22);
            this.toolStripButton1.Text = "Seleccionar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // treeListPlanCta
            // 
            this.treeListPlanCta.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.pc_Cuenta2,
            this.IdCtaCble,
            this.IdCtaCblePadre,
            this.IdCatalogo,
            this.pc_Naturaleza,
            this.IdNivelCta,
            this.IdGrupoCble,
            this.pc_Estado,
            this.pc_EsMovimiento,
            this.pc_clave_corta});
            this.treeListPlanCta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListPlanCta.KeyFieldName = "IdCtaCble";
            this.treeListPlanCta.Location = new System.Drawing.Point(0, 25);
            this.treeListPlanCta.Name = "treeListPlanCta";
            this.treeListPlanCta.OptionsBehavior.AutoFocusNewNode = true;
            this.treeListPlanCta.OptionsBehavior.Editable = false;
            this.treeListPlanCta.OptionsBehavior.EnableFiltering = true;
            this.treeListPlanCta.OptionsBehavior.ExpandNodesOnIncrementalSearch = true;
            this.treeListPlanCta.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListPlanCta.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Standard;
            this.treeListPlanCta.OptionsPrint.UsePrintStyles = true;
            this.treeListPlanCta.OptionsView.ShowAutoFilterRow = true;
            this.treeListPlanCta.ParentFieldName = "IdCtaCblePadre";
            this.treeListPlanCta.Size = new System.Drawing.Size(816, 434);
            this.treeListPlanCta.TabIndex = 3;
            this.treeListPlanCta.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListPlanCta_FocusedNodeChanged);
            this.treeListPlanCta.DoubleClick += new System.EventHandler(this.treeListPlanCta_DoubleClick);
            // 
            // pc_Cuenta2
            // 
            this.pc_Cuenta2.Caption = "Cuenta Cble";
            this.pc_Cuenta2.FieldName = "pc_Cuenta2";
            this.pc_Cuenta2.Name = "pc_Cuenta2";
            this.pc_Cuenta2.Visible = true;
            this.pc_Cuenta2.VisibleIndex = 0;
            this.pc_Cuenta2.Width = 240;
            // 
            // IdCtaCble
            // 
            this.IdCtaCble.Caption = "Id Cta Cble";
            this.IdCtaCble.FieldName = "IdCtaCble";
            this.IdCtaCble.Name = "IdCtaCble";
            this.IdCtaCble.Visible = true;
            this.IdCtaCble.VisibleIndex = 1;
            this.IdCtaCble.Width = 165;
            // 
            // IdCtaCblePadre
            // 
            this.IdCtaCblePadre.Caption = "Id Cta Cble Padre";
            this.IdCtaCblePadre.FieldName = "IdCtaCblePadre";
            this.IdCtaCblePadre.Name = "IdCtaCblePadre";
            this.IdCtaCblePadre.Visible = true;
            this.IdCtaCblePadre.VisibleIndex = 2;
            this.IdCtaCblePadre.Width = 150;
            // 
            // IdCatalogo
            // 
            this.IdCatalogo.Caption = "Id Catalogo";
            this.IdCatalogo.FieldName = "IdCatalogo";
            this.IdCatalogo.Name = "IdCatalogo";
            this.IdCatalogo.Width = 28;
            // 
            // pc_Naturaleza
            // 
            this.pc_Naturaleza.Caption = "Naturaleza";
            this.pc_Naturaleza.FieldName = "pc_Naturaleza";
            this.pc_Naturaleza.Name = "pc_Naturaleza";
            this.pc_Naturaleza.Visible = true;
            this.pc_Naturaleza.VisibleIndex = 3;
            this.pc_Naturaleza.Width = 93;
            // 
            // IdNivelCta
            // 
            this.IdNivelCta.Caption = "Id Nivel Cta";
            this.IdNivelCta.FieldName = "IdNivelCta";
            this.IdNivelCta.Name = "IdNivelCta";
            this.IdNivelCta.Width = 62;
            // 
            // IdGrupoCble
            // 
            this.IdGrupoCble.Caption = "Id Grupo Cble";
            this.IdGrupoCble.FieldName = "IdGrupoCble";
            this.IdGrupoCble.Name = "IdGrupoCble";
            this.IdGrupoCble.Width = 101;
            // 
            // pc_Estado
            // 
            this.pc_Estado.Caption = "Estado";
            this.pc_Estado.FieldName = "pc_Estado";
            this.pc_Estado.Name = "pc_Estado";
            this.pc_Estado.Visible = true;
            this.pc_Estado.VisibleIndex = 4;
            this.pc_Estado.Width = 70;
            // 
            // pc_EsMovimiento
            // 
            this.pc_EsMovimiento.Caption = "Movimiento";
            this.pc_EsMovimiento.FieldName = "pc_EsMovimiento";
            this.pc_EsMovimiento.Name = "pc_EsMovimiento";
            this.pc_EsMovimiento.Width = 101;
            // 
            // pc_clave_corta
            // 
            this.pc_clave_corta.Caption = "Clave Corta";
            this.pc_clave_corta.FieldName = "pc_clave_corta";
            this.pc_clave_corta.Name = "pc_clave_corta";
            this.pc_clave_corta.Visible = true;
            this.pc_clave_corta.VisibleIndex = 5;
            this.pc_clave_corta.Width = 80;
            // 
            // frmCon_PlanCta_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 459);
            this.Controls.Add(this.treeListPlanCta);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCon_PlanCta_Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan de cuencta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCon_PlanCta_Busqueda_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPlanCta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn pc_Cuenta2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdCtaCble;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdCtaCblePadre;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdCatalogo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn pc_Naturaleza;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdNivelCta;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdGrupoCble;
        private DevExpress.XtraTreeList.Columns.TreeListColumn pc_Estado;
        private DevExpress.XtraTreeList.Columns.TreeListColumn pc_EsMovimiento;
        private DevExpress.XtraTreeList.Columns.TreeListColumn pc_clave_corta;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraTreeList.TreeList treeListPlanCta;

    }
}