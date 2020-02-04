namespace Core.Erp.Winform.Controles
{
    partial class UCAf_Activo_Fijo_Grupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAf_Activo_Fijo_Grupo));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificartoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultartoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            this.cmb_Activo_fijo_Grupo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGrupoActivoFijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodGrupoActivoFijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAf_Grupo_Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MenuAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Activo_fijo_Grupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "agregar2.png");
            this.imageList1.Images.SetKeyName(1, "buscar1_128x128.png");
            this.imageList1.Images.SetKeyName(2, "editar1_64x64.png");
            this.imageList1.Images.SetKeyName(3, "nuevo5_64x64.png");
            // 
            // MenuAcciones
            // 
            this.MenuAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem,
            this.modificartoolStripMenuItem,
            this.consultartoolStripMenuItem});
            this.MenuAcciones.Name = "contextMenuStrip1";
            this.MenuAcciones.Size = new System.Drawing.Size(126, 70);
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.Image = global::Core.Erp.Winform.Properties.Resources.agregar2;
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.insertarToolStripMenuItem.Text = "Nuevo";
            this.insertarToolStripMenuItem.Click += new System.EventHandler(this.insertarToolStripMenuItem_Click);
            // 
            // modificartoolStripMenuItem
            // 
            this.modificartoolStripMenuItem.Image = global::Core.Erp.Winform.Properties.Resources.editar1_64x64;
            this.modificartoolStripMenuItem.Name = "modificartoolStripMenuItem";
            this.modificartoolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificartoolStripMenuItem.Text = "Modificar";
            this.modificartoolStripMenuItem.Click += new System.EventHandler(this.modificartoolStripMenuItem_Click);
            // 
            // consultartoolStripMenuItem
            // 
            this.consultartoolStripMenuItem.Image = global::Core.Erp.Winform.Properties.Resources.Buscar1_32X32;
            this.consultartoolStripMenuItem.Name = "consultartoolStripMenuItem";
            this.consultartoolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultartoolStripMenuItem.Text = "Consultar";
            this.consultartoolStripMenuItem.Click += new System.EventHandler(this.consultartoolStripMenuItem_Click);
            // 
            // cmb_Acciones
            // 
            this.cmb_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones.Appearance.Image = global::Core.Erp.Winform.Properties.Resources.nuevo_128x128;
            this.cmb_Acciones.Appearance.Options.UseImage = true;
            this.cmb_Acciones.ContextMenuStrip = this.MenuAcciones;
            this.cmb_Acciones.ImageIndex = 3;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmb_Acciones.Location = new System.Drawing.Point(277, 3);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Acciones.ShowArrowButton = false;
            this.cmb_Acciones.Size = new System.Drawing.Size(33, 23);
            this.cmb_Acciones.TabIndex = 3;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
            // 
            // cmb_Activo_fijo_Grupo
            // 
            this.cmb_Activo_fijo_Grupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Activo_fijo_Grupo.Location = new System.Drawing.Point(6, 6);
            this.cmb_Activo_fijo_Grupo.Name = "cmb_Activo_fijo_Grupo";
            this.cmb_Activo_fijo_Grupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Activo_fijo_Grupo.Properties.DisplayMember = "Af_Grupo_Nombre";
            this.cmb_Activo_fijo_Grupo.Properties.ValueMember = "IdGrupoActivoFijo";
            this.cmb_Activo_fijo_Grupo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_Activo_fijo_Grupo.Size = new System.Drawing.Size(265, 20);
            this.cmb_Activo_fijo_Grupo.TabIndex = 2;
            this.cmb_Activo_fijo_Grupo.EditValueChanged += new System.EventHandler(this.cmb_Activo_fijo_Grupo_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGrupoActivoFijo,
            this.colcodGrupoActivoFijo,
            this.colAf_Grupo_Nombre});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdGrupoActivoFijo
            // 
            this.colIdGrupoActivoFijo.Caption = "IdGrupoActivoFijo";
            this.colIdGrupoActivoFijo.FieldName = "IdGrupoActivoFijo";
            this.colIdGrupoActivoFijo.Name = "colIdGrupoActivoFijo";
            this.colIdGrupoActivoFijo.Visible = true;
            this.colIdGrupoActivoFijo.VisibleIndex = 0;
            this.colIdGrupoActivoFijo.Width = 235;
            // 
            // colcodGrupoActivoFijo
            // 
            this.colcodGrupoActivoFijo.Caption = "Código";
            this.colcodGrupoActivoFijo.FieldName = "codGrupoActivoFijo";
            this.colcodGrupoActivoFijo.Name = "colcodGrupoActivoFijo";
            // 
            // colAf_Grupo_Nombre
            // 
            this.colAf_Grupo_Nombre.Caption = "Nombre";
            this.colAf_Grupo_Nombre.FieldName = "Af_Grupo_Nombre";
            this.colAf_Grupo_Nombre.Name = "colAf_Grupo_Nombre";
            this.colAf_Grupo_Nombre.Visible = true;
            this.colAf_Grupo_Nombre.VisibleIndex = 1;
            this.colAf_Grupo_Nombre.Width = 945;
            // 
            // UCAf_Activo_Fijo_Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmb_Activo_fijo_Grupo);
            this.Name = "UCAf_Activo_Fijo_Grupo";
            this.Size = new System.Drawing.Size(315, 31);
            this.Load += new System.EventHandler(this.UCAf_Activo_Fijo_Grupo_Load);
            this.MenuAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Activo_fijo_Grupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificartoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultartoolStripMenuItem;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_Activo_fijo_Grupo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupoActivoFijo;
        private DevExpress.XtraGrid.Columns.GridColumn colAf_Grupo_Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcodGrupoActivoFijo;
    }
}
