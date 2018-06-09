namespace Core.Erp.Winform.Controles
{
    partial class UCRo_NominaTipo
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
            this.cmbNominaTipo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdNomina_Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNominaTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNominaTipo
            // 
            this.cmbNominaTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbNominaTipo.Location = new System.Drawing.Point(0, 0);
            this.cmbNominaTipo.Name = "cmbNominaTipo";
            this.cmbNominaTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNominaTipo.Properties.DisplayMember = "Descripcion";
            this.cmbNominaTipo.Properties.ValueMember = "IdNomina_Tipo";
            this.cmbNominaTipo.Properties.View = this.searchLookUpEdit1View;
            this.cmbNominaTipo.Size = new System.Drawing.Size(400, 20);
            this.cmbNominaTipo.TabIndex = 0;
            this.cmbNominaTipo.EditValueChanged += new System.EventHandler(this.cmbNominaTipo_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdNomina_Tipo,
            this.colDescripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdNomina_Tipo
            // 
            this.colIdNomina_Tipo.Caption = "IdNomina_Tipo";
            this.colIdNomina_Tipo.FieldName = "IdNomina_Tipo";
            this.colIdNomina_Tipo.Name = "colIdNomina_Tipo";
            this.colIdNomina_Tipo.Width = 126;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripcion";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 725;
            // 
            // UCRo_NominaTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbNominaTipo);
            this.Name = "UCRo_NominaTipo";
            this.Size = new System.Drawing.Size(400, 20);
            this.Load += new System.EventHandler(this.UCRo_NominaTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbNominaTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmbNominaTipo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNomina_Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
    }
}
