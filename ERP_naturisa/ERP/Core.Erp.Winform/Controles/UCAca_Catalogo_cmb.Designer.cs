namespace Core.Erp.Winform.Controles
{
    partial class UCAca_Catalogo_cmb
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
            this.components = new System.ComponentModel.Container();
            this.cmb_catalogo_aca = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ddb_Menu = new DevExpress.XtraEditors.DropDownButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_consultar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_catalogo_aca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_catalogo_aca
            // 
            this.cmb_catalogo_aca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_catalogo_aca.Location = new System.Drawing.Point(3, 3);
            this.cmb_catalogo_aca.Name = "cmb_catalogo_aca";
            this.cmb_catalogo_aca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_catalogo_aca.Properties.DisplayMember = "Descripcion2";
            this.cmb_catalogo_aca.Properties.ValueMember = "IdCatalogo";
            this.cmb_catalogo_aca.Properties.View = this.searchLookUpEdit1View;
            this.cmb_catalogo_aca.Size = new System.Drawing.Size(333, 20);
            this.cmb_catalogo_aca.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ddb_Menu
            // 
            this.ddb_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddb_Menu.Image = global::Core.Erp.Winform.Properties.Resources.editar1_16x16;
            this.ddb_Menu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ddb_Menu.Location = new System.Drawing.Point(341, 1);
            this.ddb_Menu.Name = "ddb_Menu";
            this.ddb_Menu.ShowArrowButton = false;
            this.ddb_Menu.Size = new System.Drawing.Size(40, 23);
            this.ddb_Menu.TabIndex = 1;
            this.ddb_Menu.Click += new System.EventHandler(this.ddb_Menu_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdCatalogo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 256;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descripción";
            this.gridColumn2.FieldName = "Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 1478;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.btn_modificar,
            this.btn_consultar});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(126, 70);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Image = global::Core.Erp.Winform.Properties.Resources.Add_16_x_16;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(152, 22);
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = global::Core.Erp.Winform.Properties.Resources.editar1_16x16;
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(152, 22);
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Image = global::Core.Erp.Winform.Properties.Resources.Buscar_docu_16x16;
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(152, 22);
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // UCAca_Catalogo_cmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ddb_Menu);
            this.Controls.Add(this.cmb_catalogo_aca);
            this.Name = "UCAca_Catalogo_cmb";
            this.Size = new System.Drawing.Size(386, 27);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_catalogo_aca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmb_catalogo_aca;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DropDownButton ddb_Menu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem btn_nuevo;
        private System.Windows.Forms.ToolStripMenuItem btn_modificar;
        private System.Windows.Forms.ToolStripMenuItem btn_consultar;
    }
}
