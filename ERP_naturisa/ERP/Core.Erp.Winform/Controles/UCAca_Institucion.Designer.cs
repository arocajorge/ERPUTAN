namespace Core.Erp.Winform.Controles
{
    partial class UCAca_Institucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAca_Institucion));
            this.cmbInstitucion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumncolIdInstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumncolCodInstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumncolNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumncolDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumncolRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstitucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.Location = new System.Drawing.Point(3, 3);
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInstitucion.Properties.DisplayMember = "Nombre";
            this.cmbInstitucion.Properties.ValueMember = "IdInstitucion";
            this.cmbInstitucion.Properties.View = this.searchLookUpEdit1View;
            this.cmbInstitucion.Size = new System.Drawing.Size(247, 20);
            this.cmbInstitucion.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumncolIdInstitucion,
            this.gridColumncolCodInstitucion,
            this.gridColumncolNombre,
            this.gridColumncolDireccion,
            this.gridColumncolRuc});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumncolIdInstitucion
            // 
            this.gridColumncolIdInstitucion.Caption = "Id Institucion";
            this.gridColumncolIdInstitucion.FieldName = "IdInstitucion";
            this.gridColumncolIdInstitucion.Name = "gridColumncolIdInstitucion";
            this.gridColumncolIdInstitucion.Visible = true;
            this.gridColumncolIdInstitucion.VisibleIndex = 0;
            this.gridColumncolIdInstitucion.Width = 71;
            // 
            // gridColumncolCodInstitucion
            // 
            this.gridColumncolCodInstitucion.Caption = "Codigo Institucion";
            this.gridColumncolCodInstitucion.FieldName = "CodInstitucion";
            this.gridColumncolCodInstitucion.Name = "gridColumncolCodInstitucion";
            this.gridColumncolCodInstitucion.Visible = true;
            this.gridColumncolCodInstitucion.VisibleIndex = 1;
            this.gridColumncolCodInstitucion.Width = 96;
            // 
            // gridColumncolNombre
            // 
            this.gridColumncolNombre.Caption = "Nombre";
            this.gridColumncolNombre.FieldName = "Nombre";
            this.gridColumncolNombre.Name = "gridColumncolNombre";
            this.gridColumncolNombre.Visible = true;
            this.gridColumncolNombre.VisibleIndex = 2;
            this.gridColumncolNombre.Width = 377;
            // 
            // gridColumncolDireccion
            // 
            this.gridColumncolDireccion.Caption = "Direccion";
            this.gridColumncolDireccion.FieldName = "Direccion";
            this.gridColumncolDireccion.Name = "gridColumncolDireccion";
            this.gridColumncolDireccion.Visible = true;
            this.gridColumncolDireccion.VisibleIndex = 4;
            this.gridColumncolDireccion.Width = 492;
            // 
            // gridColumncolRuc
            // 
            this.gridColumncolRuc.Caption = "Ruc";
            this.gridColumncolRuc.FieldName = "Ruc";
            this.gridColumncolRuc.Name = "gridColumncolRuc";
            this.gridColumncolRuc.Visible = true;
            this.gridColumncolRuc.VisibleIndex = 3;
            this.gridColumncolRuc.Width = 132;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empleado.ico");
            this.imageList1.Images.SetKeyName(1, "nuevo_32x32.png");
            this.imageList1.Images.SetKeyName(2, "admin_32x32.png");
            this.imageList1.Images.SetKeyName(3, "downloads1.ico");
            this.imageList1.Images.SetKeyName(4, "ico_insert1.png");
            // 
            // MenuAcciones
            // 
            this.MenuAcciones.AllowDrop = true;
            this.MenuAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.MenuAcciones.Name = "MenuAcciones";
            this.MenuAcciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuAcciones.Size = new System.Drawing.Size(126, 70);
            this.MenuAcciones.Text = "Acciones";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // cmb_Acciones
            // 
            this.cmb_Acciones.ContextMenuStrip = this.MenuAcciones;
            this.cmb_Acciones.ImageIndex = 1;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(256, 3);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.ShowArrowButton = false;
            this.cmb_Acciones.Size = new System.Drawing.Size(36, 26);
            this.cmb_Acciones.TabIndex = 109;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
            // 
            // UCAca_Institucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmbInstitucion);
            this.Name = "UCAca_Institucion";
            this.Size = new System.Drawing.Size(298, 31);
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstitucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmbInstitucion;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumncolIdInstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumncolCodInstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumncolNombre;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumncolDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumncolRuc;
    }
}
