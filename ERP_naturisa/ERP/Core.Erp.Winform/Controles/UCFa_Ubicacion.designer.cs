namespace Core.Erp.Winform.Controles
{
    partial class UCFa_Ubicacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treelist_Ubicacion = new DevExpress.XtraTreeList.TreeList();
            this.Ubicacion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdUbicacion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Nivel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Pos = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treelist_Ubicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treelist_Ubicacion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // treelist_Ubicacion
            // 
            this.treelist_Ubicacion.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.treelist_Ubicacion.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treelist_Ubicacion.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.Ubicacion,
            this.IdUbicacion,
            this.Nivel,
            this.Pos});
            this.treelist_Ubicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treelist_Ubicacion.KeyFieldName = "IdUbicacion";
            this.treelist_Ubicacion.Location = new System.Drawing.Point(3, 16);
            this.treelist_Ubicacion.Name = "treelist_Ubicacion";
            this.treelist_Ubicacion.OptionsPrint.PrintAllNodes = true;
            this.treelist_Ubicacion.OptionsPrint.UsePrintStyles = true;
            this.treelist_Ubicacion.OptionsSelection.MultiSelect = true;
            this.treelist_Ubicacion.OptionsView.ShowIndentAsRowStyle = true;
            this.treelist_Ubicacion.ParentFieldName = "IdUbicacion_Padre";
            this.treelist_Ubicacion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.treelist_Ubicacion.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow;
            this.treelist_Ubicacion.Size = new System.Drawing.Size(245, 155);
            this.treelist_Ubicacion.TabIndex = 28;
            
            // 
            // Ubicacion
            // 
            this.Ubicacion.Caption = "Ubicación";
            this.Ubicacion.FieldName = "ub_descripcion";
            this.Ubicacion.MinWidth = 32;
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.OptionsColumn.AllowEdit = false;
            this.Ubicacion.OptionsColumn.ReadOnly = true;
            this.Ubicacion.Visible = true;
            this.Ubicacion.VisibleIndex = 0;
            this.Ubicacion.Width = 278;
            // 
            // IdUbicacion
            // 
            this.IdUbicacion.Caption = "IdUbicacion";
            this.IdUbicacion.FieldName = "IdUbicacion";
            this.IdUbicacion.Name = "IdUbicacion";
            this.IdUbicacion.OptionsColumn.AllowEdit = false;
            // 
            // Nivel
            // 
            this.Nivel.Caption = "Nivel";
            this.Nivel.FieldName = "ub_nivel";
            this.Nivel.Name = "Nivel";
            this.Nivel.OptionsColumn.AllowEdit = false;
            // 
            // Pos
            // 
            this.Pos.Caption = "Pos";
            this.Pos.FieldName = "ub_posicion";
            this.Pos.Name = "Pos";
            this.Pos.OptionsColumn.AllowEdit = false;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AllowGrayed = true;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // UCFac_Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCFac_Ubicacion";
            this.Size = new System.Drawing.Size(251, 174);
            
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treelist_Ubicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraTreeList.TreeList treelist_Ubicacion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Ubicacion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdUbicacion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Nivel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Pos;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}
