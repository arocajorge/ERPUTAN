namespace Core.Erp.Winform.Controles
{
    partial class UCAca_Anio_Lectivo
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
            this.UC_Anio_Lectivo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LbAnio_Lectivo = new System.Windows.Forms.Label();
            this.IdAnioLectivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UC_Anio_Lectivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // UC_Anio_Lectivo
            // 
            this.UC_Anio_Lectivo.Location = new System.Drawing.Point(112, 4);
            this.UC_Anio_Lectivo.Margin = new System.Windows.Forms.Padding(4);
            this.UC_Anio_Lectivo.Name = "UC_Anio_Lectivo";
            this.UC_Anio_Lectivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UC_Anio_Lectivo.Properties.DisplayMember = "Descripcion";
            this.UC_Anio_Lectivo.Properties.ValueMember = "IdAnio_Lectivo";
            this.UC_Anio_Lectivo.Properties.View = this.searchLookUpEdit1View;
            this.UC_Anio_Lectivo.Size = new System.Drawing.Size(227, 22);
            this.UC_Anio_Lectivo.TabIndex = 1;
            this.UC_Anio_Lectivo.EditValueChanged += new System.EventHandler(this.UC_Anio_Lectivo_EditValueChanged_1);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdAnioLectivo,
            this.Descripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // LbAnio_Lectivo
            // 
            this.LbAnio_Lectivo.AutoSize = true;
            this.LbAnio_Lectivo.Location = new System.Drawing.Point(4, 9);
            this.LbAnio_Lectivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbAnio_Lectivo.Name = "LbAnio_Lectivo";
            this.LbAnio_Lectivo.Size = new System.Drawing.Size(82, 17);
            this.LbAnio_Lectivo.TabIndex = 2;
            this.LbAnio_Lectivo.Text = "Año Lectivo";
            // 
            // IdAnioLectivo
            // 
            this.IdAnioLectivo.Caption = "IdAnioLectivo";
            this.IdAnioLectivo.FieldName = "IdAnioLectivo";
            this.IdAnioLectivo.Name = "IdAnioLectivo";
            this.IdAnioLectivo.Visible = true;
            this.IdAnioLectivo.VisibleIndex = 0;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 1;
            // 
            // UCAca_Anio_Lectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbAnio_Lectivo);
            this.Controls.Add(this.UC_Anio_Lectivo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCAca_Anio_Lectivo";
            this.Size = new System.Drawing.Size(346, 33);
            this.Load += new System.EventHandler(this.UCAca_Anio_Lectivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UC_Anio_Lectivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SearchLookUpEdit UC_Anio_Lectivo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn IdAnio_Lectivo;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private System.Windows.Forms.Label LbAnio_Lectivo;
        private DevExpress.XtraGrid.Columns.GridColumn IdAnioLectivo;
    }
}
