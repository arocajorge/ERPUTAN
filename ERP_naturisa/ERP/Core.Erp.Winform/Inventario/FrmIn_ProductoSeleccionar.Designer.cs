namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_ProductoSeleccionar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_ProductoSeleccionar));
            this.gc_detalle = new DevExpress.XtraGrid.GridControl();
            this.gv_detalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_imagen = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gc_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_detalle
            // 
            this.gc_detalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_detalle.Location = new System.Drawing.Point(0, 0);
            this.gc_detalle.MainView = this.gv_detalle;
            this.gc_detalle.Name = "gc_detalle";
            this.gc_detalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_imagen});
            this.gc_detalle.Size = new System.Drawing.Size(822, 547);
            this.gc_detalle.TabIndex = 0;
            this.gc_detalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_detalle});
            // 
            // gv_detalle
            // 
            this.gv_detalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gv_detalle.GridControl = this.gc_detalle;
            this.gv_detalle.Images = this.imageList1;
            this.gv_detalle.Name = "gv_detalle";
            this.gv_detalle.OptionsView.ShowAutoFilterRow = true;
            this.gv_detalle.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdProducto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 147;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Producto";
            this.gridColumn2.FieldName = "pr_descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 942;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Código";
            this.gridColumn3.FieldName = "pr_codigo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 239;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Familia";
            this.gridColumn4.FieldName = "fa_Descripcion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 406;
            // 
            // gridColumn5
            // 
            this.gridColumn5.ColumnEdit = this.cmb_imagen;
            this.gridColumn5.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn5.ImageIndex = 0;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // cmb_imagen
            // 
            this.cmb_imagen.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_imagen.AutoHeight = false;
            this.cmb_imagen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_imagen.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_imagen.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, 0)});
            this.cmb_imagen.Name = "cmb_imagen";
            this.cmb_imagen.ReadOnly = true;
            this.cmb_imagen.SmallImages = this.imageList1;
            this.cmb_imagen.Click += new System.EventHandler(this.cmb_imagen_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "editar1_16x16.png");
            // 
            // FrmIn_ProductoSeleccionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 547);
            this.Controls.Add(this.gc_detalle);
            this.Name = "FrmIn_ProductoSeleccionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar producto";
            this.Load += new System.EventHandler(this.FrmIn_ProductoSeleccionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_detalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_imagen;
        private System.Windows.Forms.ImageList imageList1;
    }
}