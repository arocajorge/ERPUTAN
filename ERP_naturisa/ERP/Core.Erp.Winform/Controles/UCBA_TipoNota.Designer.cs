namespace Core.Erp.Winform.Controles
{
    partial class UCBA_TipoNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBA_TipoNota));
            this.cmb_TipoNota = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip();
            this.btn_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_TipoNota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_TipoNota
            // 
            this.cmb_TipoNota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_TipoNota.Location = new System.Drawing.Point(3, 3);
            this.cmb_TipoNota.Name = "cmb_TipoNota";
            this.cmb_TipoNota.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_TipoNota.Properties.View = this.searchLookUpEdit1View;
            this.cmb_TipoNota.Size = new System.Drawing.Size(284, 20);
            this.cmb_TipoNota.TabIndex = 0;
            this.cmb_TipoNota.EditValueChanged += new System.EventHandler(this.cmb_TipoNota_EditValueChanged);
            this.cmb_TipoNota.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_TipoNota_Validating);
            this.cmb_TipoNota.Validated += new System.EventHandler(this.cmb_TipoNota_Validated);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion,
            this.colIdTipoNota,
            this.colIdCtaCble,
            this.colIdCentroCosto,
            this.colTipo});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cmb_Acciones
            // 
            this.cmb_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones.ContextMenuStrip = this.MenuAcciones;
            this.cmb_Acciones.ImageIndex = 0;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(293, 0);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.Size = new System.Drawing.Size(40, 23);
            this.cmb_Acciones.TabIndex = 1;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
            // 
            // MenuAcciones
            // 
            this.MenuAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Nuevo,
            this.btn_Modificar,
            this.btn_Consultar});
            this.MenuAcciones.Name = "contextMenuStrip1";
            this.MenuAcciones.Size = new System.Drawing.Size(126, 70);
            this.MenuAcciones.Opening += new System.ComponentModel.CancelEventHandler(this.MenuAcciones_Opening);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Image")));
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(125, 22);
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(125, 22);
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Consultar.Image")));
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(125, 22);
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "nuevo5_64x64.png");
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 646;
            // 
            // colIdTipoNota
            // 
            this.colIdTipoNota.Caption = "ID";
            this.colIdTipoNota.FieldName = "IdTipoNota";
            this.colIdTipoNota.Name = "colIdTipoNota";
            this.colIdTipoNota.Visible = true;
            this.colIdTipoNota.VisibleIndex = 1;
            this.colIdTipoNota.Width = 44;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.Caption = "ID Cta. Cble.";
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.VisibleIndex = 2;
            this.colIdCtaCble.Width = 153;
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.Caption = "ID Centro de Costo";
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            this.colIdCentroCosto.Visible = true;
            this.colIdCentroCosto.VisibleIndex = 3;
            this.colIdCentroCosto.Width = 228;
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 4;
            this.colTipo.Width = 93;
            // 
            // UCBA_TipoNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmb_TipoNota);
            this.Name = "UCBA_TipoNota";
            this.Size = new System.Drawing.Size(339, 26);
            this.Load += new System.EventHandler(this.UCBA_TipoNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_TipoNota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmb_TipoNota;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem btn_Nuevo;
        private System.Windows.Forms.ToolStripMenuItem btn_Modificar;
        private System.Windows.Forms.ToolStripMenuItem btn_Consultar;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoNota;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
    }
}
