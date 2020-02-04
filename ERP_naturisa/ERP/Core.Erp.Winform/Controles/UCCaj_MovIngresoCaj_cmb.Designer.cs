namespace Core.Erp.Winform.Controles
{
    partial class UCCaj_MovIngresoCaj_cmb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCaj_MovIngresoCaj_cmb));
            this.cmb_CajMovIngreso = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltm_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngEgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Consultar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CajMovIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_CajMovIngreso
            // 
            this.cmb_CajMovIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_CajMovIngreso.Location = new System.Drawing.Point(3, 3);
            this.cmb_CajMovIngreso.Name = "cmb_CajMovIngreso";
            this.cmb_CajMovIngreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_CajMovIngreso.Properties.View = this.searchLookUpEdit1View;
            this.cmb_CajMovIngreso.Size = new System.Drawing.Size(278, 20);
            this.cmb_CajMovIngreso.TabIndex = 0;
            this.cmb_CajMovIngreso.EditValueChanged += new System.EventHandler(this.cmb_CajMovIngreso_EditValueChanged);
            this.cmb_CajMovIngreso.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_CajMovIngreso_Validating);
            this.cmb_CajMovIngreso.Validated += new System.EventHandler(this.cmb_CajMovIngreso_Validated);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltm_descripcion,
            this.colIdTipoMovi,
            this.colIngEgr});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // coltm_descripcion
            // 
            this.coltm_descripcion.Caption = "Motivo";
            this.coltm_descripcion.FieldName = "tm_descripcion";
            this.coltm_descripcion.Name = "coltm_descripcion";
            this.coltm_descripcion.Visible = true;
            this.coltm_descripcion.VisibleIndex = 0;
            this.coltm_descripcion.Width = 704;
            // 
            // colIdTipoMovi
            // 
            this.colIdTipoMovi.Caption = "ID";
            this.colIdTipoMovi.FieldName = "IdTipoMovi";
            this.colIdTipoMovi.Name = "colIdTipoMovi";
            this.colIdTipoMovi.Visible = true;
            this.colIdTipoMovi.VisibleIndex = 1;
            this.colIdTipoMovi.Width = 194;
            // 
            // colIngEgr
            // 
            this.colIngEgr.Caption = "Tipo";
            this.colIngEgr.FieldName = "IngEgr";
            this.colIngEgr.Name = "colIngEgr";
            this.colIngEgr.Visible = true;
            this.colIngEgr.VisibleIndex = 2;
            this.colIngEgr.Width = 196;
            // 
            // cmb_Acciones
            // 
            this.cmb_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones.ImageIndex = 0;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(287, 0);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.Size = new System.Drawing.Size(39, 23);
            this.cmb_Acciones.TabIndex = 1;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "nuevo_128x128.png");
            // 
            // MenuAcciones
            // 
            this.MenuAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Nuevo,
            this.btn_Modificar,
            this.btn_Consultar});
            this.MenuAcciones.Name = "MenuAcciones";
            this.MenuAcciones.Size = new System.Drawing.Size(153, 92);
            this.MenuAcciones.Text = "Acciones";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Image")));
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(152, 22);
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(152, 22);
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Image = global::Core.Erp.Winform.Properties.Resources.busqueda;
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(152, 22);
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // UCCaj_MovIngresoCaj_cmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmb_CajMovIngreso);
            this.Name = "UCCaj_MovIngresoCaj_cmb";
            this.Size = new System.Drawing.Size(332, 27);
            this.Load += new System.EventHandler(this.UCCaj_MovIngresoCaj_cmb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CajMovIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmb_CajMovIngreso;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem btn_Nuevo;
        private System.Windows.Forms.ToolStripMenuItem btn_Modificar;
        private System.Windows.Forms.ToolStripMenuItem btn_Consultar;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMovi;
        private DevExpress.XtraGrid.Columns.GridColumn colIngEgr;
    }
}
