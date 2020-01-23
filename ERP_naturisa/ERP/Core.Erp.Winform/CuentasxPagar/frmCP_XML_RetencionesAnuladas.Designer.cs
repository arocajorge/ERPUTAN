namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_XML_RetencionesAnuladas
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
            this.gcDetalle = new DevExpress.XtraGrid.GridControl();
            this.gvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbImagen = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.cmbImagenD = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagenD)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcDetalle
            // 
            this.gcDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDetalle.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcDetalle.Location = new System.Drawing.Point(0, 25);
            this.gcDetalle.MainView = this.gvDetalle;
            this.gcDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.gcDetalle.Name = "gcDetalle";
            this.gcDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbImagen,
            this.cmbImagenD});
            this.gcDetalle.Size = new System.Drawing.Size(1347, 628);
            this.gcDetalle.TabIndex = 4;
            this.gcDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalle});
            // 
            // gvDetalle
            // 
            this.gvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn15});
            this.gvDetalle.GridControl = this.gcDetalle;
            this.gvDetalle.Name = "gvDetalle";
            this.gvDetalle.OptionsBehavior.ReadOnly = true;
            this.gvDetalle.OptionsView.ShowAutoFilterRow = true;
            this.gvDetalle.OptionsView.ShowFooter = true;
            this.gvDetalle.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Proveedor";
            this.gridColumn1.FieldName = "emi_RazonSocial";
            this.gridColumn1.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 428;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ruc ";
            this.gridColumn2.FieldName = "emi_Ruc";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 167;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Comprobante";
            this.gridColumn8.FieldName = "Comprobante";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            this.gridColumn8.Width = 177;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "ID";
            this.gridColumn9.FieldName = "IdDocumento";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            this.gridColumn9.Width = 101;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "# Retención";
            this.gridColumn10.FieldName = "ret_NumeroDocumento";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            this.gridColumn10.Width = 149;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "# Autorización";
            this.gridColumn11.FieldName = "ret_NumeroAutorizacion";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 6;
            this.gridColumn11.Width = 166;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Fecha";
            this.gridColumn15.DisplayFormat.FormatString = "d";
            this.gridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn15.FieldName = "FechaEmision";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 1;
            this.gridColumn15.Width = 135;
            // 
            // cmbImagen
            // 
            this.cmbImagen.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmbImagen.AutoHeight = false;
            this.cmbImagen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImagen.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmbImagen.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.cmbImagen.Name = "cmbImagen";
            this.cmbImagen.ReadOnly = true;
            // 
            // cmbImagenD
            // 
            this.cmbImagenD.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmbImagenD.AutoHeight = false;
            this.cmbImagenD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImagenD.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmbImagenD.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, 1)});
            this.cmbImagenD.Name = "cmbImagenD";
            this.cmbImagenD.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1347, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Core.Erp.Winform.Properties.Resources.imprimir_32x32;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmCP_XML_RetencionesAnuladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 653);
            this.Controls.Add(this.gcDetalle);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCP_XML_RetencionesAnuladas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retenciones anuladas";
            this.Load += new System.EventHandler(this.frmCP_XML_RetencionesAnuladas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagenD)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImagen;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImagenD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnImprimir;
    }
}