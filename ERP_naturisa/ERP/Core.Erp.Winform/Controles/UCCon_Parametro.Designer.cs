namespace Core.Erp.Winform.Controles
{
    partial class UCCon_Parametro
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSaldoInicial = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ctCbtecbletipoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tc_TipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCierreAnual = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoCbte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_TipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSaldoInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCierreAnual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(360, 156);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 32);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 53);
            this.label1.MaximumSize = new System.Drawing.Size(150, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Comprobante Contable para saldo Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.MaximumSize = new System.Drawing.Size(150, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Comprobante Contable para Cierre Anual:";
            // 
            // cmbSaldoInicial
            // 
            this.cmbSaldoInicial.Location = new System.Drawing.Point(204, 58);
            this.cmbSaldoInicial.Name = "cmbSaldoInicial";
            this.cmbSaldoInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSaldoInicial.Properties.DataSource = this.ctCbtecbletipoInfoBindingSource;
            this.cmbSaldoInicial.Properties.DisplayMember = "tc_TipoCbte";
            this.cmbSaldoInicial.Properties.NullText = "";
            this.cmbSaldoInicial.Properties.PopupSizeable = false;
            this.cmbSaldoInicial.Properties.ValueMember = "IdTipoCbte";
            this.cmbSaldoInicial.Properties.View = this.searchLookUpEdit1View;
            this.cmbSaldoInicial.Size = new System.Drawing.Size(231, 20);
            this.cmbSaldoInicial.TabIndex = 3;
            // 
            // ctCbtecbletipoInfoBindingSource
            // 
            this.ctCbtecbletipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Cbtecble_tipo_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoCbte,
            this.tc_TipoCbte});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTipoCbte
            // 
            this.colIdTipoCbte.FieldName = "IdTipoCbte";
            this.colIdTipoCbte.Name = "colIdTipoCbte";
            this.colIdTipoCbte.Visible = true;
            this.colIdTipoCbte.VisibleIndex = 0;
            this.colIdTipoCbte.Width = 317;
            // 
            // tc_TipoCbte
            // 
            this.tc_TipoCbte.Caption = "Descripción";
            this.tc_TipoCbte.FieldName = "tc_TipoCbte";
            this.tc_TipoCbte.Name = "tc_TipoCbte";
            this.tc_TipoCbte.Visible = true;
            this.tc_TipoCbte.VisibleIndex = 1;
            this.tc_TipoCbte.Width = 809;
            // 
            // cmbCierreAnual
            // 
            this.cmbCierreAnual.Location = new System.Drawing.Point(204, 101);
            this.cmbCierreAnual.Name = "cmbCierreAnual";
            this.cmbCierreAnual.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCierreAnual.Properties.DataSource = this.ctCbtecbletipoInfoBindingSource;
            this.cmbCierreAnual.Properties.DisplayMember = "tc_TipoCbte";
            this.cmbCierreAnual.Properties.NullText = "";
            this.cmbCierreAnual.Properties.PopupSizeable = false;
            this.cmbCierreAnual.Properties.ValueMember = "IdTipoCbte";
            this.cmbCierreAnual.Properties.View = this.gridView1;
            this.cmbCierreAnual.Size = new System.Drawing.Size(231, 20);
            this.cmbCierreAnual.TabIndex = 4;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoCbte1,
            this.coltc_TipoCbte});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTipoCbte1
            // 
            this.colIdTipoCbte1.FieldName = "IdTipoCbte";
            this.colIdTipoCbte1.Name = "colIdTipoCbte1";
            this.colIdTipoCbte1.Visible = true;
            this.colIdTipoCbte1.VisibleIndex = 0;
            this.colIdTipoCbte1.Width = 214;
            // 
            // coltc_TipoCbte
            // 
            this.coltc_TipoCbte.Caption = "Descripción";
            this.coltc_TipoCbte.FieldName = "tc_TipoCbte";
            this.coltc_TipoCbte.Name = "coltc_TipoCbte";
            this.coltc_TipoCbte.Visible = true;
            this.coltc_TipoCbte.VisibleIndex = 1;
            this.coltc_TipoCbte.Width = 912;
            // 
            // UCCon_Parametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.cmbSaldoInicial);
            this.Controls.Add(this.cmbCierreAnual);
            this.Name = "UCCon_Parametro";
            this.Size = new System.Drawing.Size(452, 197);
            this.Load += new System.EventHandler(this.UCCon_Parametro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbSaldoInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCierreAnual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSaldoInicial;
        private System.Windows.Forms.BindingSource ctCbtecbletipoInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCierreAnual;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn tc_TipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte1;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_TipoCbte;
    }
}
