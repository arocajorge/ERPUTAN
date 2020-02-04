namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_XML_DocumentosNoContabilizados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCP_XML_DocumentosNoContabilizados));
            this.gcDetalle = new DevExpress.XtraGrid.GridControl();
            this.gvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescarga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbImagen = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDetalle
            // 
            this.gcDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDetalle.Location = new System.Drawing.Point(0, 0);
            this.gcDetalle.MainView = this.gvDetalle;
            this.gcDetalle.Name = "gcDetalle";
            this.gcDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbImagen});
            this.gcDetalle.Size = new System.Drawing.Size(974, 613);
            this.gcDetalle.TabIndex = 4;
            this.gcDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalle});
            // 
            // gvDetalle
            // 
            this.gvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.colDescarga});
            this.gvDetalle.GridControl = this.gcDetalle;
            this.gvDetalle.Images = this.imageList1;
            this.gvDetalle.Name = "gvDetalle";
            this.gvDetalle.OptionsBehavior.ReadOnly = true;
            this.gvDetalle.OptionsView.ShowAutoFilterRow = true;
            this.gvDetalle.OptionsView.ShowFooter = true;
            this.gvDetalle.OptionsView.ShowGroupPanel = false;
            this.gvDetalle.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvDetalle_RowStyle);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Proveedor";
            this.gridColumn1.FieldName = "emi_RazonSocial";
            this.gridColumn1.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 356;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ruc ";
            this.gridColumn2.FieldName = "emi_Ruc";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 140;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "XML";
            this.gridColumn3.FieldName = "XML";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 159;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Subtotal 0%";
            this.gridColumn4.DisplayFormat.FormatString = "n2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "Subtotal0";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 103;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Subtotal IVA";
            this.gridColumn5.DisplayFormat.FormatString = "n2";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "SubtotalIVA";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 98;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "IVA";
            this.gridColumn6.DisplayFormat.FormatString = "n2";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "ValorIVA";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Width = 81;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Total";
            this.gridColumn7.DisplayFormat.FormatString = "n2";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "Total";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 112;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Comprobante";
            this.gridColumn8.FieldName = "Comprobante";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 143;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "ID";
            this.gridColumn9.FieldName = "IdDocumento";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            this.gridColumn9.Width = 82;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "# Retención";
            this.gridColumn10.FieldName = "ret_NumeroDocumento";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            this.gridColumn10.Width = 124;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "# Autorización";
            this.gridColumn11.FieldName = "ret_NumeroAutorizacion";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 6;
            this.gridColumn11.Width = 139;
            // 
            // colDescarga
            // 
            this.colDescarga.ColumnEdit = this.cmbImagen;
            this.colDescarga.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colDescarga.ImageIndex = 0;
            this.colDescarga.Name = "colDescarga";
            this.colDescarga.Visible = true;
            this.colDescarga.VisibleIndex = 7;
            // 
            // cmbImagen
            // 
            this.cmbImagen.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmbImagen.AutoHeight = false;
            this.cmbImagen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImagen.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmbImagen.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, 0)});
            this.cmbImagen.LargeImages = this.imageList1;
            this.cmbImagen.Name = "cmbImagen";
            this.cmbImagen.ReadOnly = true;
            this.cmbImagen.SmallImages = this.imageList1;
            this.cmbImagen.Click += new System.EventHandler(this.cmbImagen_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1455847200_178_Download.png");
            // 
            // frmCP_XML_DocumentosNoContabilizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 613);
            this.Controls.Add(this.gcDetalle);
            this.Name = "frmCP_XML_DocumentosNoContabilizados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos no contabilizados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCP_XML_DocumentosNoContabilizados_FormClosing);
            this.Load += new System.EventHandler(this.frmCP_XML_DocumentosNoContabilizados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn colDescarga;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImagen;
        private System.Windows.Forms.ImageList imageList1;

    }
}