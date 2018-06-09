namespace Core.Erp.Winform.Controles
{
    partial class UCRo_NominaTipoLiqui
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
            this.cmbNominaTipoLiqui = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdNomina_Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNomina_TipoLiqui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionProcesoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNominaTipoLiqui.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNominaTipoLiqui
            // 
            this.cmbNominaTipoLiqui.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbNominaTipoLiqui.Location = new System.Drawing.Point(0, 0);
            this.cmbNominaTipoLiqui.Name = "cmbNominaTipoLiqui";
            this.cmbNominaTipoLiqui.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNominaTipoLiqui.Properties.DisplayMember = "DescripcionProcesoNomina";
            this.cmbNominaTipoLiqui.Properties.ValueMember = "IdNomina_TipoLiqui";
            this.cmbNominaTipoLiqui.Properties.View = this.searchLookUpEdit1View;
            this.cmbNominaTipoLiqui.Size = new System.Drawing.Size(400, 20);
            this.cmbNominaTipoLiqui.TabIndex = 0;
            this.cmbNominaTipoLiqui.EditValueChanged += new System.EventHandler(this.cmbNominaTipoLiqui_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdNomina_Tipo,
            this.colIdNomina_TipoLiqui,
            this.colDescripcionProcesoNomina});
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
            this.colIdNomina_Tipo.Width = 90;
            // 
            // colIdNomina_TipoLiqui
            // 
            this.colIdNomina_TipoLiqui.Caption = "IdNomina_TipoLiqui";
            this.colIdNomina_TipoLiqui.FieldName = "IdNomina_TipoLiqui";
            this.colIdNomina_TipoLiqui.Name = "colIdNomina_TipoLiqui";
            this.colIdNomina_TipoLiqui.Width = 108;
            // 
            // colDescripcionProcesoNomina
            // 
            this.colDescripcionProcesoNomina.Caption = "Descripción";
            this.colDescripcionProcesoNomina.FieldName = "DescripcionProcesoNomina";
            this.colDescripcionProcesoNomina.Name = "colDescripcionProcesoNomina";
            this.colDescripcionProcesoNomina.Visible = true;
            this.colDescripcionProcesoNomina.VisibleIndex = 0;
            this.colDescripcionProcesoNomina.Width = 653;
            // 
            // UCRo_NominaTipoLiqui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbNominaTipoLiqui);
            this.Name = "UCRo_NominaTipoLiqui";
            this.Size = new System.Drawing.Size(400, 20);
            this.Load += new System.EventHandler(this.UCRo_NominaTipoLiqui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbNominaTipoLiqui.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmbNominaTipoLiqui;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNomina_Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNomina_TipoLiqui;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionProcesoNomina;
    }
}
