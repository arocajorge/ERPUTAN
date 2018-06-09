namespace Core.Erp.Reportes.Controles
{
    partial class UCct_Pto_Cargo
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_Pto_Cargo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodPunto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_punto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Pto_Cargo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Pto_Cargo
            // 
            this.cmb_Pto_Cargo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Pto_Cargo.Location = new System.Drawing.Point(3, 3);
            this.cmb_Pto_Cargo.Name = "cmb_Pto_Cargo";
            this.cmb_Pto_Cargo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Pto_Cargo.Properties.DisplayMember = "nom_punto_cargo";
            this.cmb_Pto_Cargo.Properties.ValueMember = "IdPunto_cargo";
            this.cmb_Pto_Cargo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_Pto_Cargo.Size = new System.Drawing.Size(118, 20);
            this.cmb_Pto_Cargo.TabIndex = 0;
            this.cmb_Pto_Cargo.EditValueChanged += new System.EventHandler(this.cmb_Pto_Cargo_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodPunto_cargo,
            this.colnom_punto_cargo});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colcodPunto_cargo
            // 
            this.colcodPunto_cargo.Caption = "Punto de Cargo";
            this.colcodPunto_cargo.FieldName = "codPunto_cargo";
            this.colcodPunto_cargo.Name = "colcodPunto_cargo";
            this.colcodPunto_cargo.Visible = true;
            this.colcodPunto_cargo.VisibleIndex = 0;
            this.colcodPunto_cargo.Width = 161;
            // 
            // colnom_punto_cargo
            // 
            this.colnom_punto_cargo.Caption = "Nombre Pto de Cargo";
            this.colnom_punto_cargo.FieldName = "nom_punto_cargo";
            this.colnom_punto_cargo.Name = "colnom_punto_cargo";
            this.colnom_punto_cargo.Visible = true;
            this.colnom_punto_cargo.VisibleIndex = 1;
            this.colnom_punto_cargo.Width = 1019;
            // 
            // UCct_Pto_Cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Pto_Cargo);
            this.Name = "UCct_Pto_Cargo";
            this.Size = new System.Drawing.Size(135, 28);
            this.Load += new System.EventHandler(this.UCct_Pto_Cargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Pto_Cargo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmb_Pto_Cargo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colcodPunto_cargo;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_punto_cargo;
    }
}
