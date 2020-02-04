namespace Core.Erp.Winform.Controles
{
    partial class UCBa_TipoFlujo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBa_TipoFlujo));
            this.cmbTipoFlujo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoFlujo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_flujo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoFlujo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoFlujo
            // 
            this.cmbTipoFlujo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoFlujo.Location = new System.Drawing.Point(3, 3);
            this.cmbTipoFlujo.Name = "cmbTipoFlujo";
            this.cmbTipoFlujo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoFlujo.Properties.DisplayMember = "Descricion2";
            this.cmbTipoFlujo.Properties.ValueMember = "IdTipoFlujo";
            this.cmbTipoFlujo.Properties.View = this.gridView1;
            this.cmbTipoFlujo.Size = new System.Drawing.Size(245, 20);
            this.cmbTipoFlujo.TabIndex = 20;
            this.cmbTipoFlujo.EditValueChanged += new System.EventHandler(this.cmbTipoFlujo_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion,
            this.colIdTipoFlujo,
            this.colcod_flujo,
            this.gridColumn1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.imageList1.Images.SetKeyName(5, "agregar2.png");
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
            this.MenuAcciones.Opening += new System.ComponentModel.CancelEventHandler(this.MenuAcciones_Opening);
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
            this.cmb_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones.ContextMenuStrip = this.MenuAcciones;
            this.cmb_Acciones.ImageIndex = 1;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(252, 2);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.ShowArrowButton = false;
            this.cmb_Acciones.Size = new System.Drawing.Size(43, 22);
            this.cmb_Acciones.TabIndex = 22;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Tipo Flujo";
            this.colDescripcion.FieldName = "Descricion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 768;
            // 
            // colIdTipoFlujo
            // 
            this.colIdTipoFlujo.Caption = "Id";
            this.colIdTipoFlujo.FieldName = "IdTipoFlujo";
            this.colIdTipoFlujo.Name = "colIdTipoFlujo";
            this.colIdTipoFlujo.Visible = true;
            this.colIdTipoFlujo.VisibleIndex = 2;
            this.colIdTipoFlujo.Width = 222;
            // 
            // colcod_flujo
            // 
            this.colcod_flujo.Caption = "Codigo";
            this.colcod_flujo.FieldName = "cod_flujo";
            this.colcod_flujo.Name = "colcod_flujo";
            this.colcod_flujo.Visible = true;
            this.colcod_flujo.VisibleIndex = 0;
            this.colcod_flujo.Width = 80;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tipo";
            this.gridColumn1.FieldName = "Tipo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // UCBa_TipoFlujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmbTipoFlujo);
            this.Name = "UCBa_TipoFlujo";
            this.Size = new System.Drawing.Size(298, 26);
            this.Load += new System.EventHandler(this.UCBa_TipoFlujo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoFlujo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipoFlujo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoFlujo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_flujo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}
