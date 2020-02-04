namespace Core.Erp.Winform.Controles
{
    partial class UCCon_Periodo
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
            this.de_Hasta = new DevExpress.XtraEditors.DateEdit();
            this.de_Desde = new DevExpress.XtraEditors.DateEdit();
            this.lblHasta = new DevExpress.XtraEditors.LabelControl();
            this.lblDesde = new DevExpress.XtraEditors.LabelControl();
            this.cmb_Periodo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre_Periodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdanioFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_FechaIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_FechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblPeriodo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.de_Hasta.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Hasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Desde.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Desde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Periodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // de_Hasta
            // 
            this.de_Hasta.EditValue = null;
            this.de_Hasta.Location = new System.Drawing.Point(234, 30);
            this.de_Hasta.Name = "de_Hasta";
            this.de_Hasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Hasta.Properties.ReadOnly = true;
            this.de_Hasta.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_Hasta.Size = new System.Drawing.Size(100, 20);
            this.de_Hasta.TabIndex = 11;
            this.de_Hasta.EditValueChanged += new System.EventHandler(this.de_Hasta_EditValueChanged);
            // 
            // de_Desde
            // 
            this.de_Desde.EditValue = null;
            this.de_Desde.Location = new System.Drawing.Point(78, 30);
            this.de_Desde.Name = "de_Desde";
            this.de_Desde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Desde.Properties.ReadOnly = true;
            this.de_Desde.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_Desde.Size = new System.Drawing.Size(100, 20);
            this.de_Desde.TabIndex = 10;
            this.de_Desde.EditValueChanged += new System.EventHandler(this.de_Desde_EditValueChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.Location = new System.Drawing.Point(196, 33);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(32, 13);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.Location = new System.Drawing.Point(10, 33);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(34, 13);
            this.lblDesde.TabIndex = 8;
            this.lblDesde.Text = "Desde:";
            // 
            // cmb_Periodo
            // 
            this.cmb_Periodo.Location = new System.Drawing.Point(78, 4);
            this.cmb_Periodo.Name = "cmb_Periodo";
            this.cmb_Periodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Periodo.Properties.DisplayMember = "nom_periodo";
            this.cmb_Periodo.Properties.ValueMember = "IdPeriodo";
            this.cmb_Periodo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_Periodo.Size = new System.Drawing.Size(256, 20);
            this.cmb_Periodo.TabIndex = 7;
            this.cmb_Periodo.EditValueChanged += new System.EventHandler(this.cmb_Periodo_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre_Periodo,
            this.colIdanioFiscal,
            this.colpe_FechaIni,
            this.colpe_FechaFin,
            this.colpe_mes});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colNombre_Periodo
            // 
            this.colNombre_Periodo.Caption = "Periodo";
            this.colNombre_Periodo.FieldName = "nom_periodo";
            this.colNombre_Periodo.Name = "colNombre_Periodo";
            this.colNombre_Periodo.Visible = true;
            this.colNombre_Periodo.VisibleIndex = 0;
            this.colNombre_Periodo.Width = 156;
            // 
            // colIdanioFiscal
            // 
            this.colIdanioFiscal.Caption = "Año fiscal";
            this.colIdanioFiscal.FieldName = "IdanioFiscal";
            this.colIdanioFiscal.Name = "colIdanioFiscal";
            this.colIdanioFiscal.Visible = true;
            this.colIdanioFiscal.VisibleIndex = 1;
            this.colIdanioFiscal.Width = 84;
            // 
            // colpe_FechaIni
            // 
            this.colpe_FechaIni.Caption = "Desde";
            this.colpe_FechaIni.FieldName = "pe_FechaIni";
            this.colpe_FechaIni.Name = "colpe_FechaIni";
            this.colpe_FechaIni.Visible = true;
            this.colpe_FechaIni.VisibleIndex = 3;
            this.colpe_FechaIni.Width = 84;
            // 
            // colpe_FechaFin
            // 
            this.colpe_FechaFin.Caption = "Hasta";
            this.colpe_FechaFin.FieldName = "pe_FechaFin";
            this.colpe_FechaFin.Name = "colpe_FechaFin";
            this.colpe_FechaFin.Visible = true;
            this.colpe_FechaFin.VisibleIndex = 4;
            this.colpe_FechaFin.Width = 90;
            // 
            // colpe_mes
            // 
            this.colpe_mes.Caption = "Mes";
            this.colpe_mes.FieldName = "pe_mes";
            this.colpe_mes.Name = "colpe_mes";
            this.colpe_mes.Visible = true;
            this.colpe_mes.VisibleIndex = 2;
            this.colpe_mes.Width = 84;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Location = new System.Drawing.Point(10, 7);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(40, 13);
            this.lblPeriodo.TabIndex = 6;
            this.lblPeriodo.Text = "Periodo:";
            // 
            // UCCon_Periodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.de_Hasta);
            this.Controls.Add(this.de_Desde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.cmb_Periodo);
            this.Controls.Add(this.lblPeriodo);
            this.Name = "UCCon_Periodo";
            this.Size = new System.Drawing.Size(342, 56);
            ((System.ComponentModel.ISupportInitialize)(this.de_Hasta.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Hasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Desde.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Desde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Periodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit de_Hasta;
        private DevExpress.XtraEditors.DateEdit de_Desde;
        private DevExpress.XtraEditors.LabelControl lblHasta;
        private DevExpress.XtraEditors.LabelControl lblDesde;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_Periodo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl lblPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Periodo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdanioFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_FechaIni;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_FechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_mes;
    }
}
