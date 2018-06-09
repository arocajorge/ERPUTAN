namespace Core.Erp.Winform.Controles
{
    partial class UCRo_PeriodoXNomina
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
            this.cmbPeriodo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCerrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcesado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContabilizado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTipoNomina = new Core.Erp.Winform.Controles.UCRo_NominaTipo();
            this.cmbNominaLiqui = new Core.Erp.Winform.Controles.UCRo_NominaTipoLiqui();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPeriodo.Location = new System.Drawing.Point(50, 49);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPeriodo.Properties.DisplayMember = "pe_Descripcion";
            this.cmbPeriodo.Properties.ValueMember = "IdPeriodo";
            this.cmbPeriodo.Properties.View = this.searchLookUpEdit1View;
            this.cmbPeriodo.Size = new System.Drawing.Size(315, 20);
            this.cmbPeriodo.TabIndex = 3;
            this.cmbPeriodo.EditValueChanged += new System.EventHandler(this.cmbPeriodo_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPeriodo,
            this.colFechaIni,
            this.colFechaFinal,
            this.colCerrado,
            this.colProcesado,
            this.colContabilizado});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPeriodo
            // 
            this.colIdPeriodo.Caption = "Periodo";
            this.colIdPeriodo.FieldName = "IdPeriodo";
            this.colIdPeriodo.Name = "colIdPeriodo";
            this.colIdPeriodo.OptionsColumn.AllowEdit = false;
            this.colIdPeriodo.Width = 50;
            // 
            // colFechaIni
            // 
            this.colFechaIni.Caption = "Fecha Inicial";
            this.colFechaIni.FieldName = "pe_FechaIni";
            this.colFechaIni.Name = "colFechaIni";
            this.colFechaIni.OptionsColumn.AllowEdit = false;
            this.colFechaIni.Visible = true;
            this.colFechaIni.VisibleIndex = 0;
            this.colFechaIni.Width = 123;
            // 
            // colFechaFinal
            // 
            this.colFechaFinal.Caption = "Fecha Final";
            this.colFechaFinal.FieldName = "pe_FechaFin";
            this.colFechaFinal.Name = "colFechaFinal";
            this.colFechaFinal.OptionsColumn.AllowEdit = false;
            this.colFechaFinal.Visible = true;
            this.colFechaFinal.VisibleIndex = 1;
            this.colFechaFinal.Width = 154;
            // 
            // colCerrado
            // 
            this.colCerrado.Caption = "Cerrado";
            this.colCerrado.FieldName = "Cerrado";
            this.colCerrado.Name = "colCerrado";
            this.colCerrado.OptionsColumn.AllowEdit = false;
            this.colCerrado.Visible = true;
            this.colCerrado.VisibleIndex = 2;
            this.colCerrado.Width = 160;
            // 
            // colProcesado
            // 
            this.colProcesado.Caption = "Procesado";
            this.colProcesado.FieldName = "Procesado";
            this.colProcesado.Name = "colProcesado";
            this.colProcesado.OptionsColumn.AllowEdit = false;
            this.colProcesado.Visible = true;
            this.colProcesado.VisibleIndex = 3;
            this.colProcesado.Width = 202;
            // 
            // colContabilizado
            // 
            this.colContabilizado.Caption = "Contabilizado";
            this.colContabilizado.FieldName = "Contabilizado";
            this.colContabilizado.Name = "colContabilizado";
            this.colContabilizado.OptionsColumn.AllowEdit = false;
            this.colContabilizado.Visible = true;
            this.colContabilizado.VisibleIndex = 4;
            this.colContabilizado.Width = 254;
            // 
            // cmbTipoNomina
            // 
            this.cmbTipoNomina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoNomina.Location = new System.Drawing.Point(50, 2);
            this.cmbTipoNomina.Name = "cmbTipoNomina";
            this.cmbTipoNomina.Size = new System.Drawing.Size(315, 20);
            this.cmbTipoNomina.TabIndex = 1;
            this.cmbTipoNomina.event_cmbNominaTipo_EditValueChanged += new Core.Erp.Winform.Controles.UCRo_NominaTipo.delegate_cmbNominaTipo_EditValueChanged(this.cmbNominaTipo_event_cmbNominaTipo_EditValueChanged);
            this.cmbTipoNomina.Load += new System.EventHandler(this.cmbTipoNomina_Load);
            // 
            // cmbNominaLiqui
            // 
            this.cmbNominaLiqui.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNominaLiqui.Location = new System.Drawing.Point(50, 26);
            this.cmbNominaLiqui.Name = "cmbNominaLiqui";
            this.cmbNominaLiqui.Size = new System.Drawing.Size(315, 20);
            this.cmbNominaLiqui.TabIndex = 2;
            this.cmbNominaLiqui.event_cmbNominaTipoLiqui_EditValueChanged += new Core.Erp.Winform.Controles.UCRo_NominaTipoLiqui.delegate_cmbNominaTipoLiqui_EditValueChanged(this.cmbNominaTipoLiqui_event_cmbNominaTipoLiqui_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Nómina:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Proceso:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Período:";
            // 
            // UCRo_PeriodoXNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbNominaLiqui);
            this.Controls.Add(this.cmbTipoNomina);
            this.Controls.Add(this.cmbPeriodo);
            this.Name = "UCRo_PeriodoXNomina";
            this.Size = new System.Drawing.Size(365, 70);
            this.Load += new System.EventHandler(this.UCRo_PeriodoXNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmbPeriodo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIni;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFinal;
        private DevExpress.XtraGrid.Columns.GridColumn colCerrado;
        private DevExpress.XtraGrid.Columns.GridColumn colProcesado;
        private DevExpress.XtraGrid.Columns.GridColumn colContabilizado;
        private UCRo_NominaTipo cmbTipoNomina;
        private UCRo_NominaTipoLiqui cmbNominaLiqui;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;


    }
}
