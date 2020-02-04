namespace Core.Erp.Winform.Controles
{
    partial class UCIn_TipoMoviInventario
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
            this.ultraComboTipoMoviInven = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tm_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdMovi_inven_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cm_tipo_movi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboTipoMoviInven.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraComboTipoMoviInven
            // 
            this.ultraComboTipoMoviInven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraComboTipoMoviInven.Location = new System.Drawing.Point(0, 0);
            this.ultraComboTipoMoviInven.Name = "ultraComboTipoMoviInven";
            this.ultraComboTipoMoviInven.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraComboTipoMoviInven.Properties.View = this.searchLookUpEdit1View;
            this.ultraComboTipoMoviInven.Size = new System.Drawing.Size(305, 20);
            this.ultraComboTipoMoviInven.TabIndex = 0;
            this.ultraComboTipoMoviInven.EditValueChanged += new System.EventHandler(this.ultraComboTipoMoviInven_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tm_descripcion,
            this.IdMovi_inven_tipo,
            this.cm_tipo_movi});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // tm_descripcion
            // 
            this.tm_descripcion.Caption = "Descripcion";
            this.tm_descripcion.FieldName = "tm_descripcion";
            this.tm_descripcion.Name = "tm_descripcion";
            this.tm_descripcion.Visible = true;
            this.tm_descripcion.VisibleIndex = 1;
            this.tm_descripcion.Width = 1036;
            // 
            // IdMovi_inven_tipo
            // 
            this.IdMovi_inven_tipo.Caption = "Id";
            this.IdMovi_inven_tipo.FieldName = "IdMovi_inven_tipo";
            this.IdMovi_inven_tipo.Name = "IdMovi_inven_tipo";
            this.IdMovi_inven_tipo.Visible = true;
            this.IdMovi_inven_tipo.VisibleIndex = 0;
            this.IdMovi_inven_tipo.Width = 70;
            // 
            // cm_tipo_movi
            // 
            this.cm_tipo_movi.Caption = "Signo/Tipo";
            this.cm_tipo_movi.FieldName = "cm_tipo_movi";
            this.cm_tipo_movi.Name = "cm_tipo_movi";
            this.cm_tipo_movi.Visible = true;
            this.cm_tipo_movi.VisibleIndex = 2;
            this.cm_tipo_movi.Width = 74;
            // 
            // UCIn_TipoMoviInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ultraComboTipoMoviInven);
            this.Name = "UCIn_TipoMoviInventario";
            this.Size = new System.Drawing.Size(305, 22);
            this.Load += new System.EventHandler(this.UCIn_TipoMoviInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboTipoMoviInven.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SearchLookUpEdit ultraComboTipoMoviInven;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn tm_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn IdMovi_inven_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn cm_tipo_movi;




    }
}
