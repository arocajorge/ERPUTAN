namespace Core.Erp.Winform.Controles
{
    partial class UCIn_Categoria_Linea
    {
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
            this.lbllinea = new System.Windows.Forms.Label();
            this.lblgrupo = new System.Windows.Forms.Label();
            this.lblsubgrupo = new System.Windows.Forms.Label();
            this.cmb_linea = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdLinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_grupo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidgrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_subgrupo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidsubgrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_subgrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_categoria = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_linea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subgrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_categoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllinea
            // 
            this.lbllinea.AutoSize = true;
            this.lbllinea.Location = new System.Drawing.Point(14, 47);
            this.lbllinea.Name = "lbllinea";
            this.lbllinea.Size = new System.Drawing.Size(36, 13);
            this.lbllinea.TabIndex = 0;
            this.lbllinea.Text = "Linea:";
            // 
            // lblgrupo
            // 
            this.lblgrupo.AutoSize = true;
            this.lblgrupo.Location = new System.Drawing.Point(14, 75);
            this.lblgrupo.Name = "lblgrupo";
            this.lblgrupo.Size = new System.Drawing.Size(39, 13);
            this.lblgrupo.TabIndex = 1;
            this.lblgrupo.Text = "Grupo:";
            // 
            // lblsubgrupo
            // 
            this.lblsubgrupo.AutoSize = true;
            this.lblsubgrupo.Location = new System.Drawing.Point(14, 101);
            this.lblsubgrupo.Name = "lblsubgrupo";
            this.lblsubgrupo.Size = new System.Drawing.Size(61, 13);
            this.lblsubgrupo.TabIndex = 2;
            this.lblsubgrupo.Text = "Sub Grupo:";
            // 
            // cmb_linea
            // 
            this.cmb_linea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_linea.Location = new System.Drawing.Point(78, 40);
            this.cmb_linea.Name = "cmb_linea";
            this.cmb_linea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_linea.Properties.DisplayMember = "nom_linea";
            this.cmb_linea.Properties.ValueMember = "IdLinea";
            this.cmb_linea.Properties.View = this.searchLookUpEdit1View;
            this.cmb_linea.Size = new System.Drawing.Size(256, 20);
            this.cmb_linea.TabIndex = 2;
            this.cmb_linea.EditValueChanged += new System.EventHandler(this.cmb_linea_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdLinea,
            this.colnom_linea});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdLinea
            // 
            this.colIdLinea.Caption = "IdLinea";
            this.colIdLinea.FieldName = "IdLinea";
            this.colIdLinea.Name = "colIdLinea";
            this.colIdLinea.Visible = true;
            this.colIdLinea.VisibleIndex = 0;
            this.colIdLinea.Width = 155;
            // 
            // colnom_linea
            // 
            this.colnom_linea.Caption = "nombre";
            this.colnom_linea.FieldName = "nom_linea";
            this.colnom_linea.Name = "colnom_linea";
            this.colnom_linea.Visible = true;
            this.colnom_linea.VisibleIndex = 1;
            this.colnom_linea.Width = 1025;
            // 
            // cmb_grupo
            // 
            this.cmb_grupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_grupo.Location = new System.Drawing.Point(78, 68);
            this.cmb_grupo.Name = "cmb_grupo";
            this.cmb_grupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_grupo.Properties.DisplayMember = "nom_grupo";
            this.cmb_grupo.Properties.ValueMember = "IdGrupo";
            this.cmb_grupo.Properties.View = this.gridView1;
            this.cmb_grupo.Size = new System.Drawing.Size(256, 20);
            this.cmb_grupo.TabIndex = 3;
            this.cmb_grupo.EditValueChanged += new System.EventHandler(this.cmb_grupo_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidgrupo,
            this.colnom_grupo});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colidgrupo
            // 
            this.colidgrupo.Caption = "IdGrupo";
            this.colidgrupo.FieldName = "IdGrupo";
            this.colidgrupo.Name = "colidgrupo";
            this.colidgrupo.Visible = true;
            this.colidgrupo.VisibleIndex = 0;
            this.colidgrupo.Width = 147;
            // 
            // colnom_grupo
            // 
            this.colnom_grupo.Caption = "nombre";
            this.colnom_grupo.FieldName = "nom_grupo";
            this.colnom_grupo.Name = "colnom_grupo";
            this.colnom_grupo.Visible = true;
            this.colnom_grupo.VisibleIndex = 1;
            this.colnom_grupo.Width = 1033;
            // 
            // cmb_subgrupo
            // 
            this.cmb_subgrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_subgrupo.Location = new System.Drawing.Point(78, 94);
            this.cmb_subgrupo.Name = "cmb_subgrupo";
            this.cmb_subgrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_subgrupo.Properties.DisplayMember = "nom_subgrupo";
            this.cmb_subgrupo.Properties.ValueMember = "IdSubgrupo";
            this.cmb_subgrupo.Properties.View = this.gridView2;
            this.cmb_subgrupo.Size = new System.Drawing.Size(256, 20);
            this.cmb_subgrupo.TabIndex = 4;
            this.cmb_subgrupo.EditValueChanged += new System.EventHandler(this.cmb_subgrupo_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidsubgrupo,
            this.colnom_subgrupo});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colidsubgrupo
            // 
            this.colidsubgrupo.Caption = "IdSubgrupo";
            this.colidsubgrupo.FieldName = "IdSubgrupo";
            this.colidsubgrupo.Name = "colidsubgrupo";
            this.colidsubgrupo.Visible = true;
            this.colidsubgrupo.VisibleIndex = 0;
            this.colidsubgrupo.Width = 114;
            // 
            // colnom_subgrupo
            // 
            this.colnom_subgrupo.Caption = "nombre";
            this.colnom_subgrupo.FieldName = "nom_subgrupo";
            this.colnom_subgrupo.Name = "colnom_subgrupo";
            this.colnom_subgrupo.Visible = true;
            this.colnom_subgrupo.VisibleIndex = 1;
            this.colnom_subgrupo.Width = 1066;
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_categoria.Location = new System.Drawing.Point(78, 14);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_categoria.Properties.DisplayMember = "ca_Categoria";
            this.cmb_categoria.Properties.ValueMember = "IdCategoria";
            this.cmb_categoria.Properties.View = this.gridView3;
            this.cmb_categoria.Size = new System.Drawing.Size(256, 20);
            this.cmb_categoria.TabIndex = 1;
            this.cmb_categoria.EditValueChanged += new System.EventHandler(this.cmb_categoria_EditValueChanged);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCategoria,
            this.colnom_categoria});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCategoria
            // 
            this.colIdCategoria.Caption = "IdCategoria";
            this.colIdCategoria.FieldName = "IdCategoria";
            this.colIdCategoria.Name = "colIdCategoria";
            this.colIdCategoria.Visible = true;
            this.colIdCategoria.VisibleIndex = 0;
            this.colIdCategoria.Width = 164;
            // 
            // colnom_categoria
            // 
            this.colnom_categoria.Caption = "nombre";
            this.colnom_categoria.FieldName = "ca_Categoria";
            this.colnom_categoria.Name = "colnom_categoria";
            this.colnom_categoria.Visible = true;
            this.colnom_categoria.VisibleIndex = 1;
            this.colnom_categoria.Width = 1016;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Categoria:";
            // 
            // UCIn_Categoria_Linea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_subgrupo);
            this.Controls.Add(this.cmb_grupo);
            this.Controls.Add(this.cmb_linea);
            this.Controls.Add(this.lblsubgrupo);
            this.Controls.Add(this.lblgrupo);
            this.Controls.Add(this.lbllinea);
            this.Name = "UCIn_Categoria_Linea";
            this.Size = new System.Drawing.Size(337, 122);
            this.Load += new System.EventHandler(this.UCIn_Categoria_Linea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_linea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subgrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_categoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllinea;
        private System.Windows.Forms.Label lblgrupo;
        private System.Windows.Forms.Label lblsubgrupo;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_linea;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_grupo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_subgrupo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_categoria;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLinea;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_linea;
        private DevExpress.XtraGrid.Columns.GridColumn colidgrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_grupo;
        private DevExpress.XtraGrid.Columns.GridColumn colidsubgrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_subgrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_categoria;
    }
}
