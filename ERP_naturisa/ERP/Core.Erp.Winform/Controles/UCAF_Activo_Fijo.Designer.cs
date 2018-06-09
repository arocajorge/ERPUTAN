namespace Core.Erp.Winform.Controles
{
    partial class UCAF_Activo_Fijo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAF_Activo_Fijo));
            this.cmb_Activo_fijo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificartoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultartoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Activo_fijo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Activo_fijo
            // 
            this.cmb_Activo_fijo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Activo_fijo.Location = new System.Drawing.Point(3, 3);
            this.cmb_Activo_fijo.Name = "cmb_Activo_fijo";
            this.cmb_Activo_fijo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Activo_fijo.Properties.DisplayMember = "Af_Nombre";
            this.cmb_Activo_fijo.Properties.ValueMember = "IdActivoFijo";
            this.cmb_Activo_fijo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_Activo_fijo.Size = new System.Drawing.Size(282, 20);
            this.cmb_Activo_fijo.TabIndex = 0;
            this.cmb_Activo_fijo.EditValueChanged += new System.EventHandler(this.cmb_Activo_fijo_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "CodActivoFijo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 235;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre";
            this.gridColumn2.FieldName = "Af_Nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 945;
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
            this.cmb_Acciones.Location = new System.Drawing.Point(292, 0);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Acciones.ShowArrowButton = false;
            this.cmb_Acciones.Size = new System.Drawing.Size(33, 23);
            this.cmb_Acciones.TabIndex = 1;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "agregar2.png");
            this.imageList1.Images.SetKeyName(1, "buscar1_128x128.png");
            this.imageList1.Images.SetKeyName(2, "editar1_64x64.png");
            this.imageList1.Images.SetKeyName(3, "nuevo5_64x64.png");
            // 
            // UCAF_Activo_Fijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmb_Activo_fijo);
            this.Name = "UCAF_Activo_Fijo";
            this.Size = new System.Drawing.Size(329, 27);
            this.Load += new System.EventHandler(this.UCAF_Activo_Fijo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Activo_fijo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmb_Activo_fijo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificartoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultartoolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}
