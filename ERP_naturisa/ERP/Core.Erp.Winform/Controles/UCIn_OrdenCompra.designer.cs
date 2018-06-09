namespace Core.Erp.Winform.Controles
{
    partial class UCIn_OrdenCompra
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
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbOrdCompra = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coloc_NumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrdCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackgroundImage = global::Core.Erp.Winform.Properties.Resources.buscar;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.Location = new System.Drawing.Point(184, 2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(25, 23);
            this.btn_Buscar.TabIndex = 13;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbOrdCompra);
            this.panel1.Controls.Add(this.btn_Buscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 30);
            this.panel1.TabIndex = 14;
            // 
            // cmbOrdCompra
            // 
            this.cmbOrdCompra.Location = new System.Drawing.Point(3, 4);
            this.cmbOrdCompra.Name = "cmbOrdCompra";
            this.cmbOrdCompra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOrdCompra.Properties.View = this.searchLookUpEdit1View;
            this.cmbOrdCompra.Size = new System.Drawing.Size(175, 20);
            this.cmbOrdCompra.TabIndex = 14;
            this.cmbOrdCompra.EditValueChanged += new System.EventHandler(this.cmbOrdCompra_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coloc_NumDocumento,
            this.colIdOrdenCompra});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // coloc_NumDocumento
            // 
            this.coloc_NumDocumento.Caption = "# Documeno";
            this.coloc_NumDocumento.FieldName = "oc_NumDocumento";
            this.coloc_NumDocumento.Name = "coloc_NumDocumento";
            this.coloc_NumDocumento.Visible = true;
            this.coloc_NumDocumento.VisibleIndex = 0;
            this.coloc_NumDocumento.Width = 925;
            // 
            // colIdOrdenCompra
            // 
            this.colIdOrdenCompra.Caption = "IdOrdenCompra";
            this.colIdOrdenCompra.FieldName = "IdOrdenCompra";
            this.colIdOrdenCompra.Name = "colIdOrdenCompra";
            this.colIdOrdenCompra.Visible = true;
            this.colIdOrdenCompra.VisibleIndex = 1;
            this.colIdOrdenCompra.Width = 255;
            // 
            // UCIn_OrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCIn_OrdenCompra";
            this.Size = new System.Drawing.Size(254, 30);
            this.Load += new System.EventHandler(this.UCIn_OrdenCompra_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrdCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbOrdCompra;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_NumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenCompra;
    }
}
