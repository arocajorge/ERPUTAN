namespace Core.Erp.Winform.Controles
{
    partial class UCPrd_Obra
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
            this.UC_Obra = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LbObra = new System.Windows.Forms.Label();
            this.CodObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UC_Obra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // UC_Obra
            // 
            this.UC_Obra.Location = new System.Drawing.Point(109, 4);
            this.UC_Obra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UC_Obra.Name = "UC_Obra";
            this.UC_Obra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UC_Obra.Properties.DisplayMember = "DetalleObra";
            this.UC_Obra.Properties.ValueMember = "CodObra";
            this.UC_Obra.Properties.View = this.searchLookUpEdit1View;
            this.UC_Obra.Size = new System.Drawing.Size(467, 22);
            this.UC_Obra.TabIndex = 1;
            this.UC_Obra.EditValueChanged += new System.EventHandler(this.UC_Obra_EditValueChanged_1);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CodObra,
            this.Descripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // LbObra
            // 
            this.LbObra.AutoSize = true;
            this.LbObra.Location = new System.Drawing.Point(4, 9);
            this.LbObra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbObra.Name = "LbObra";
            this.LbObra.Size = new System.Drawing.Size(40, 17);
            this.LbObra.TabIndex = 2;
            this.LbObra.Text = "Obra";
            // 
            // CodObra
            // 
            this.CodObra.Caption = "CodObra";
            this.CodObra.FieldName = "CodObra";
            this.CodObra.Name = "CodObra";
            this.CodObra.Visible = true;
            this.CodObra.VisibleIndex = 0;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 1;
            // 
            // UCPrd_Obra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbObra);
            this.Controls.Add(this.UC_Obra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCPrd_Obra";
            this.Size = new System.Drawing.Size(580, 33);
            ((System.ComponentModel.ISupportInitialize)(this.UC_Obra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SearchLookUpEdit UC_Obra;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn CodObra;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private System.Windows.Forms.Label LbObra;



    }
}
