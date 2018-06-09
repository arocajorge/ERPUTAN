namespace Core.Erp.Winform.Controles
{
    partial class UCGe_Pais
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
            this.cmbPais = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colub_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUbicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPais.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPais
            // 
            this.cmbPais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPais.Location = new System.Drawing.Point(0, 0);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPais.Properties.View = this.searchLookUpEdit1View;
            this.cmbPais.Size = new System.Drawing.Size(163, 20);
            this.cmbPais.TabIndex = 1;
            this.cmbPais.EditValueChanged += new System.EventHandler(this.cmbPais_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colub_descripcion,
            this.colIdUbicacion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colub_descripcion
            // 
            this.colub_descripcion.Caption = "Pais";
            this.colub_descripcion.FieldName = "ub_descripcion";
            this.colub_descripcion.Name = "colub_descripcion";
            this.colub_descripcion.Visible = true;
            this.colub_descripcion.VisibleIndex = 0;
            this.colub_descripcion.Width = 871;
            // 
            // colIdUbicacion
            // 
            this.colIdUbicacion.Caption = "ID";
            this.colIdUbicacion.FieldName = "IdUbicacion";
            this.colIdUbicacion.Name = "colIdUbicacion";
            this.colIdUbicacion.Visible = true;
            this.colIdUbicacion.VisibleIndex = 1;
            this.colIdUbicacion.Width = 309;
            // 
            // UCGe_Pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbPais);
            this.Name = "UCGe_Pais";
            this.Size = new System.Drawing.Size(163, 28);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPais.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmbPais;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colub_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUbicacion;
    }
}
