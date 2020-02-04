namespace Core.Erp.Winform.Compras
{
    partial class frmCom_OrdenPedidoPlantillaAsignar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCom_OrdenPedidoPlantillaAsignar));
            this.gc_Consulta = new DevExpress.XtraGrid.GridControl();
            this.gv_Consulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmb_Imagen = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Consulta
            // 
            this.gc_Consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Consulta.Location = new System.Drawing.Point(0, 0);
            this.gc_Consulta.MainView = this.gv_Consulta;
            this.gc_Consulta.Name = "gc_Consulta";
            this.gc_Consulta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_Imagen});
            this.gc_Consulta.Size = new System.Drawing.Size(1115, 539);
            this.gc_Consulta.TabIndex = 1;
            this.gc_Consulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Consulta});
            // 
            // gv_Consulta
            // 
            this.gv_Consulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn7,
            this.gridColumn2});
            this.gv_Consulta.GridControl = this.gc_Consulta;
            this.gv_Consulta.Images = this.imageList1;
            this.gv_Consulta.Name = "gv_Consulta";
            this.gv_Consulta.OptionsBehavior.ReadOnly = true;
            this.gv_Consulta.OptionsView.ShowAutoFilterRow = true;
            this.gv_Consulta.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "# Plantilla";
            this.gridColumn1.FieldName = "IdPlantilla";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 129;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Observación";
            this.gridColumn3.FieldName = "op_Observacion";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 560;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Departamento";
            this.gridColumn4.FieldName = "nom_departamento";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 269;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Cargo";
            this.gridColumn7.FieldName = "nom_punto_cargo";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 278;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "editar1_16x16.png");
            // 
            // cmb_Imagen
            // 
            this.cmb_Imagen.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_Imagen.AutoHeight = false;
            this.cmb_Imagen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Imagen.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_Imagen.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, 0)});
            this.cmb_Imagen.Name = "cmb_Imagen";
            this.cmb_Imagen.ReadOnly = true;
            this.cmb_Imagen.SmallImages = this.imageList1;
            this.cmb_Imagen.DoubleClick += new System.EventHandler(this.cmb_Imagen_DoubleClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.ColumnEdit = this.cmb_Imagen;
            this.gridColumn2.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn2.ImageIndex = 0;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 108;
            // 
            // frmCom_OrdenPedidoPlantillaAsignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 539);
            this.Controls.Add(this.gc_Consulta);
            this.Name = "frmCom_OrdenPedidoPlantillaAsignar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de pedido";
            this.Load += new System.EventHandler(this.frmCom_OrdenPedidoPlantillaAsignar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Consulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Consulta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_Imagen;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}