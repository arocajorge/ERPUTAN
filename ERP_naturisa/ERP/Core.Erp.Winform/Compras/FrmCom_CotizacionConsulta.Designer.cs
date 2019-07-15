namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_CotizacionConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCom_CotizacionConsulta));
            this.gc_consulta = new DevExpress.XtraGrid.GridControl();
            this.gv_consulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_imagen = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_consulta
            // 
            this.gc_consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_consulta.Location = new System.Drawing.Point(0, 0);
            this.gc_consulta.MainView = this.gv_consulta;
            this.gc_consulta.Name = "gc_consulta";
            this.gc_consulta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_imagen});
            this.gc_consulta.Size = new System.Drawing.Size(1365, 593);
            this.gc_consulta.TabIndex = 0;
            this.gc_consulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_consulta});
            // 
            // gv_consulta
            // 
            this.gv_consulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gv_consulta.GridControl = this.gc_consulta;
            this.gv_consulta.Images = this.imageList1;
            this.gv_consulta.Name = "gv_consulta";
            this.gv_consulta.OptionsView.ShowAutoFilterRow = true;
            this.gv_consulta.OptionsView.ShowGroupPanel = false;
            this.gv_consulta.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gv_consulta_RowStyle);
            this.gv_consulta.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_consulta_FocusedRowChanged);
            this.gv_consulta.DoubleClick += new System.EventHandler(this.gv_consulta_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "# Cotización";
            this.gridColumn1.FieldName = "IdCotizacion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 113;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Sucursal";
            this.gridColumn2.FieldName = "Su_Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 319;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Proveedor";
            this.gridColumn3.FieldName = "pe_nombreCompleto";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 540;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Comprador";
            this.gridColumn4.FieldName = "Comprador";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 192;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Solicitante";
            this.gridColumn5.FieldName = "nom_solicitante";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 285;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Fecha";
            this.gridColumn6.FieldName = "cp_Fecha";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 108;
            // 
            // gridColumn7
            // 
            this.gridColumn7.ColumnEdit = this.cmb_imagen;
            this.gridColumn7.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn7.ImageIndex = 0;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 72;
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
            // gridColumn8
            // 
            this.gridColumn8.Caption = "# Pedido";
            this.gridColumn8.FieldName = "opd_IdOrdenPedido";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 105;
            // 
            // FrmCom_CotizacionConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 593);
            this.Controls.Add(this.gc_consulta);
            this.Name = "FrmCom_CotizacionConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizaciones";
            this.Load += new System.EventHandler(this.FrmCom_CotizacionConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_consulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_consulta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_imagen;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}