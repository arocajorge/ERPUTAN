namespace Core.Erp.Winform.Controles
{
    partial class UCCaj_Parametros
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
            this.components = new System.ComponentModel.Container();
            this.ctCbtecbletipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ultraCmbE_TipoCbte_AnulaEgreso = new Core.Erp.Winform.Controles.UCCon_TipoCbteCble();
            this.ultraCmbE_TipoCbte_Egreso = new Core.Erp.Winform.Controles.UCCon_TipoCbteCble();
            this.ultraCmbE_TipoCbte_AnulaIngreso = new Core.Erp.Winform.Controles.UCCon_TipoCbteCble();
            this.ultraCmbE_TipoCbte_Ingreso = new Core.Erp.Winform.Controles.UCCon_TipoCbteCble();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControl_tipoXCta = new DevExpress.XtraGrid.GridControl();
            this.cajCajaMovimientoTipoxCtaCbleInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_tipoXCta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit_TipoMovi = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.cajCajaMovimientoTipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoMovi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit_Cta = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.ctPlanctaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCuentaPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Cuenta2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_clave_corta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uccaj_tipo_movi_ingreso = new Core.Erp.Winform.Controles.UCCaj_MovIngresoCaj_cmb();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_tipoXCta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajCajaMovimientoTipoxCtaCbleInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_tipoXCta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_TipoMovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajCajaMovimientoTipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_Cta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctCbtecbletipoInfoBindingSource
            // 
            this.ctCbtecbletipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Cbtecble_tipo_Info);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Comprobante Contable para Ingreso de Caja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Comprobante Contable para Anular  Ingreso de Caja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Comprobante Contable para  Egreso de Caja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Comprobante Contable para Anular Egreso de Caja";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 325);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.uccaj_tipo_movi_ingreso);
            this.tabPage1.Controls.Add(this.ultraCmbE_TipoCbte_AnulaEgreso);
            this.tabPage1.Controls.Add(this.ultraCmbE_TipoCbte_Egreso);
            this.tabPage1.Controls.Add(this.ultraCmbE_TipoCbte_AnulaIngreso);
            this.tabPage1.Controls.Add(this.ultraCmbE_TipoCbte_Ingreso);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(707, 299);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tipo de Cbte. Cble.";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ultraCmbE_TipoCbte_AnulaEgreso
            // 
            this.ultraCmbE_TipoCbte_AnulaEgreso.Location = new System.Drawing.Point(306, 114);
            this.ultraCmbE_TipoCbte_AnulaEgreso.Name = "ultraCmbE_TipoCbte_AnulaEgreso";
            this.ultraCmbE_TipoCbte_AnulaEgreso.Size = new System.Drawing.Size(298, 26);
            this.ultraCmbE_TipoCbte_AnulaEgreso.TabIndex = 20;
            // 
            // ultraCmbE_TipoCbte_Egreso
            // 
            this.ultraCmbE_TipoCbte_Egreso.Location = new System.Drawing.Point(306, 81);
            this.ultraCmbE_TipoCbte_Egreso.Name = "ultraCmbE_TipoCbte_Egreso";
            this.ultraCmbE_TipoCbte_Egreso.Size = new System.Drawing.Size(298, 26);
            this.ultraCmbE_TipoCbte_Egreso.TabIndex = 19;
            // 
            // ultraCmbE_TipoCbte_AnulaIngreso
            // 
            this.ultraCmbE_TipoCbte_AnulaIngreso.Location = new System.Drawing.Point(306, 49);
            this.ultraCmbE_TipoCbte_AnulaIngreso.Name = "ultraCmbE_TipoCbte_AnulaIngreso";
            this.ultraCmbE_TipoCbte_AnulaIngreso.Size = new System.Drawing.Size(298, 26);
            this.ultraCmbE_TipoCbte_AnulaIngreso.TabIndex = 18;
            // 
            // ultraCmbE_TipoCbte_Ingreso
            // 
            this.ultraCmbE_TipoCbte_Ingreso.Location = new System.Drawing.Point(306, 16);
            this.ultraCmbE_TipoCbte_Ingreso.Name = "ultraCmbE_TipoCbte_Ingreso";
            this.ultraCmbE_TipoCbte_Ingreso.Size = new System.Drawing.Size(298, 26);
            this.ultraCmbE_TipoCbte_Ingreso.TabIndex = 17;
            this.ultraCmbE_TipoCbte_Ingreso.Load += new System.EventHandler(this.ultraCmbE_TipoCbte_Ingreso_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridControl_tipoXCta);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(707, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asignación de Cuenta al tipo de movimiento de Caja";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridControl_tipoXCta
            // 
            this.gridControl_tipoXCta.DataSource = this.cajCajaMovimientoTipoxCtaCbleInfoBindingSource;
            this.gridControl_tipoXCta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_tipoXCta.Location = new System.Drawing.Point(3, 3);
            this.gridControl_tipoXCta.MainView = this.gridView_tipoXCta;
            this.gridControl_tipoXCta.Name = "gridControl_tipoXCta";
            this.gridControl_tipoXCta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit_TipoMovi,
            this.repositoryItemSearchLookUpEdit_Cta});
            this.gridControl_tipoXCta.Size = new System.Drawing.Size(701, 319);
            this.gridControl_tipoXCta.TabIndex = 0;
            this.gridControl_tipoXCta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_tipoXCta});
            // 
            // cajCajaMovimientoTipoxCtaCbleInfoBindingSource
            // 
            this.cajCajaMovimientoTipoxCtaCbleInfoBindingSource.DataSource = typeof(Core.Erp.Info.Caja.caj_Caja_Movimiento_Tipo_x_CtaCble_Info);
            // 
            // gridView_tipoXCta
            // 
            this.gridView_tipoXCta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdTipoMovi,
            this.colIdCtaCble});
            this.gridView_tipoXCta.GridControl = this.gridControl_tipoXCta;
            this.gridView_tipoXCta.Name = "gridView_tipoXCta";
            this.gridView_tipoXCta.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Width = 72;
            // 
            // colIdTipoMovi
            // 
            this.colIdTipoMovi.ColumnEdit = this.repositoryItemSearchLookUpEdit_TipoMovi;
            this.colIdTipoMovi.FieldName = "IdTipoMovi";
            this.colIdTipoMovi.Name = "colIdTipoMovi";
            this.colIdTipoMovi.OptionsColumn.AllowEdit = false;
            this.colIdTipoMovi.Visible = true;
            this.colIdTipoMovi.VisibleIndex = 0;
            this.colIdTipoMovi.Width = 277;
            // 
            // repositoryItemSearchLookUpEdit_TipoMovi
            // 
            this.repositoryItemSearchLookUpEdit_TipoMovi.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit_TipoMovi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit_TipoMovi.DataSource = this.cajCajaMovimientoTipoInfoBindingSource;
            this.repositoryItemSearchLookUpEdit_TipoMovi.DisplayMember = "tm_descripcion";
            this.repositoryItemSearchLookUpEdit_TipoMovi.Name = "repositoryItemSearchLookUpEdit_TipoMovi";
            this.repositoryItemSearchLookUpEdit_TipoMovi.ValueMember = "IdTipoMovi";
            this.repositoryItemSearchLookUpEdit_TipoMovi.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // cajCajaMovimientoTipoInfoBindingSource
            // 
            this.cajCajaMovimientoTipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Caja.caj_Caja_Movimiento_Tipo_Info);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoMovi1,
            this.coltm_descripcion});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTipoMovi1
            // 
            this.colIdTipoMovi1.FieldName = "IdTipoMovi";
            this.colIdTipoMovi1.Name = "colIdTipoMovi1";
            this.colIdTipoMovi1.Visible = true;
            this.colIdTipoMovi1.VisibleIndex = 1;
            this.colIdTipoMovi1.Width = 122;
            // 
            // coltm_descripcion
            // 
            this.coltm_descripcion.FieldName = "tm_descripcion";
            this.coltm_descripcion.Name = "coltm_descripcion";
            this.coltm_descripcion.Visible = true;
            this.coltm_descripcion.VisibleIndex = 0;
            this.coltm_descripcion.Width = 1048;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.ColumnEdit = this.repositoryItemSearchLookUpEdit_Cta;
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.VisibleIndex = 1;
            this.colIdCtaCble.Width = 406;
            // 
            // repositoryItemSearchLookUpEdit_Cta
            // 
            this.repositoryItemSearchLookUpEdit_Cta.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit_Cta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit_Cta.DataSource = this.ctPlanctaInfoBindingSource;
            this.repositoryItemSearchLookUpEdit_Cta.DisplayMember = "pc_Cuenta2";
            this.repositoryItemSearchLookUpEdit_Cta.Name = "repositoryItemSearchLookUpEdit_Cta";
            this.repositoryItemSearchLookUpEdit_Cta.ValueMember = "IdCtaCble";
            this.repositoryItemSearchLookUpEdit_Cta.View = this.gridView1;
            // 
            // ctPlanctaInfoBindingSource
            // 
            this.ctPlanctaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Plancta_Info);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCuentaPadre,
            this.colIdCtaCble1,
            this.colpc_Cuenta2,
            this.colpc_clave_corta});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCuentaPadre
            // 
            this.colCuentaPadre.FieldName = "CuentaPadre";
            this.colCuentaPadre.Name = "colCuentaPadre";
            this.colCuentaPadre.Visible = true;
            this.colCuentaPadre.VisibleIndex = 0;
            // 
            // colIdCtaCble1
            // 
            this.colIdCtaCble1.FieldName = "IdCtaCble";
            this.colIdCtaCble1.Name = "colIdCtaCble1";
            this.colIdCtaCble1.Visible = true;
            this.colIdCtaCble1.VisibleIndex = 1;
            // 
            // colpc_Cuenta2
            // 
            this.colpc_Cuenta2.FieldName = "pc_Cuenta2";
            this.colpc_Cuenta2.Name = "colpc_Cuenta2";
            this.colpc_Cuenta2.Visible = true;
            this.colpc_Cuenta2.VisibleIndex = 2;
            // 
            // colpc_clave_corta
            // 
            this.colpc_clave_corta.FieldName = "pc_clave_corta";
            this.colpc_clave_corta.Name = "colpc_clave_corta";
            this.colpc_clave_corta.Visible = true;
            this.colpc_clave_corta.VisibleIndex = 3;
            // 
            // uccaj_tipo_movi_ingreso
            // 
            this.uccaj_tipo_movi_ingreso.Location = new System.Drawing.Point(306, 146);
            this.uccaj_tipo_movi_ingreso.Name = "uccaj_tipo_movi_ingreso";
            this.uccaj_tipo_movi_ingreso.Size = new System.Drawing.Size(298, 27);
            this.uccaj_tipo_movi_ingreso.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Comprobante Contable para Anular Egreso de Caja";
            // 
            // UCCaj_Parametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UCCaj_Parametros";
            this.Size = new System.Drawing.Size(715, 325);
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_tipoXCta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajCajaMovimientoTipoxCtaCbleInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_tipoXCta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_TipoMovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajCajaMovimientoTipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_Cta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource ctCbtecbletipoInfoBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl_tipoXCta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_tipoXCta;
        private System.Windows.Forms.BindingSource cajCajaMovimientoTipoxCtaCbleInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMovi;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit_TipoMovi;
        private System.Windows.Forms.BindingSource cajCajaMovimientoTipoInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit_Cta;
        private System.Windows.Forms.BindingSource ctPlanctaInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaPadre;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble1;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta2;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_clave_corta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMovi1;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_descripcion;
        private UCCon_TipoCbteCble ultraCmbE_TipoCbte_AnulaEgreso;
        private UCCon_TipoCbteCble ultraCmbE_TipoCbte_Egreso;
        private UCCon_TipoCbteCble ultraCmbE_TipoCbte_AnulaIngreso;
        private UCCon_TipoCbteCble ultraCmbE_TipoCbte_Ingreso;
        private System.Windows.Forms.Label label5;
        private UCCaj_MovIngresoCaj_cmb uccaj_tipo_movi_ingreso;
    }
}
