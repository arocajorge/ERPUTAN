namespace Core.Erp.Winform.Controles
{
    partial class UCCon_SubCentroCosto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCon_SubCentroCosto));
            this.cmb_SubCentroCosto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.colCentro_costo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto_sub_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SubCentroCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_SubCentroCosto
            // 
            this.cmb_SubCentroCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_SubCentroCosto.Location = new System.Drawing.Point(3, 3);
            this.cmb_SubCentroCosto.Name = "cmb_SubCentroCosto";
            this.cmb_SubCentroCosto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_SubCentroCosto.Properties.View = this.searchLookUpEdit1View;
            this.cmb_SubCentroCosto.Size = new System.Drawing.Size(279, 20);
            this.cmb_SubCentroCosto.TabIndex = 0;
            this.cmb_SubCentroCosto.EditValueChanged += new System.EventHandler(this.cmb_SubCentroCosto_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCentro_costo2,
            this.colIdCentroCosto_sub_centro_costo});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cmb_Acciones
            // 
            this.cmb_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones.ImageIndex = 0;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(286, 3);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.Size = new System.Drawing.Size(41, 23);
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
            this.MenuAcciones.Size = new System.Drawing.Size(126, 70);
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
            // colCentro_costo2
            // 
            this.colCentro_costo2.Caption = "Sub Centro Costo";
            this.colCentro_costo2.FieldName = "Centro_costo2";
            this.colCentro_costo2.Name = "colCentro_costo2";
            this.colCentro_costo2.Visible = true;
            this.colCentro_costo2.VisibleIndex = 0;
            this.colCentro_costo2.Width = 888;
            // 
            // colIdCentroCosto_sub_centro_costo
            // 
            this.colIdCentroCosto_sub_centro_costo.Caption = "ID";
            this.colIdCentroCosto_sub_centro_costo.FieldName = "IdCentroCosto_sub_centro_costo";
            this.colIdCentroCosto_sub_centro_costo.Name = "colIdCentroCosto_sub_centro_costo";
            this.colIdCentroCosto_sub_centro_costo.Visible = true;
            this.colIdCentroCosto_sub_centro_costo.VisibleIndex = 1;
            this.colIdCentroCosto_sub_centro_costo.Width = 292;
            // 
            // UCCon_SubCentroCosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmb_SubCentroCosto);
            this.Name = "UCCon_SubCentroCosto";
            this.Size = new System.Drawing.Size(330, 29);
            this.Load += new System.EventHandler(this.UCCon_SubCentroCosto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SubCentroCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmb_SubCentroCosto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem btn_Nuevo;
        private System.Windows.Forms.ToolStripMenuItem btn_Modificar;
        private System.Windows.Forms.ToolStripMenuItem btn_Consultar;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_sub_centro_costo;
    }
}
