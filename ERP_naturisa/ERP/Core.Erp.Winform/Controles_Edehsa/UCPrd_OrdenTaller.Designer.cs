namespace Core.Erp.Winform.Controles
{
    partial class UCPrd_OrdenTaller
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
            this.UC_OrdenTaller = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdOrdenTaller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LbOrdenTaller = new System.Windows.Forms.Label();
            this.ColListadoDiseno = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UC_OrdenTaller.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // UC_OrdenTaller
            // 
            this.UC_OrdenTaller.Location = new System.Drawing.Point(84, 3);
            this.UC_OrdenTaller.Name = "UC_OrdenTaller";
            this.UC_OrdenTaller.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UC_OrdenTaller.Properties.DisplayMember = "Codigo";
            this.UC_OrdenTaller.Properties.ValueMember = "IdOrdenTaller";
            this.UC_OrdenTaller.Properties.View = this.searchLookUpEdit1View;
            this.UC_OrdenTaller.Size = new System.Drawing.Size(350, 20);
            this.UC_OrdenTaller.TabIndex = 1;
            this.UC_OrdenTaller.EditValueChanged += new System.EventHandler(this.UC_OrdenTaller_EditValueChanged_1);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdOrdenTaller,
            this.Codigo,
            this.ColListadoDiseno});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // IdOrdenTaller
            // 
            this.IdOrdenTaller.Caption = "IdOrdenTaller";
            this.IdOrdenTaller.FieldName = "IdOrdenTaller";
            this.IdOrdenTaller.Name = "IdOrdenTaller";
            this.IdOrdenTaller.Visible = true;
            this.IdOrdenTaller.VisibleIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 1;
            // 
            // LbOrdenTaller
            // 
            this.LbOrdenTaller.AutoSize = true;
            this.LbOrdenTaller.Location = new System.Drawing.Point(3, 7);
            this.LbOrdenTaller.Name = "LbOrdenTaller";
            this.LbOrdenTaller.Size = new System.Drawing.Size(62, 13);
            this.LbOrdenTaller.TabIndex = 2;
            this.LbOrdenTaller.Text = "OrdenTaller";
            // 
            // ColListadoDiseno
            // 
            this.ColListadoDiseno.Caption = "Listado Diseno";
            this.ColListadoDiseno.FieldName = "ListadoDiseno";
            this.ColListadoDiseno.Name = "ColListadoDiseno";
            this.ColListadoDiseno.Visible = true;
            this.ColListadoDiseno.VisibleIndex = 2;
            // 
            // UCPrd_OrdenTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbOrdenTaller);
            this.Controls.Add(this.UC_OrdenTaller);
            this.Name = "UCPrd_OrdenTaller";
            this.Size = new System.Drawing.Size(442, 27);
            ((System.ComponentModel.ISupportInitialize)(this.UC_OrdenTaller.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SearchLookUpEdit UC_OrdenTaller;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn IdOrdenTaller;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private System.Windows.Forms.Label LbOrdenTaller;
        private DevExpress.XtraGrid.Columns.GridColumn ColListadoDiseno;
    }
}
