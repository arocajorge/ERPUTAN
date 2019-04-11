namespace Core.Erp.Reportes.Contabilidad
{
    partial class XCONTA_Rpt023_frm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition1 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            this.col_SaldoNaturaleza = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotBalance = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField7 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.uCct_Menu_Reportes1 = new Core.Erp.Reportes.Controles.UCct_Menu_Reportes();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Reportes.frmEspere), true, true);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_imprimir = new System.Windows.Forms.ToolStripButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.pivotBalance)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // col_SaldoNaturaleza
            // 
            this.col_SaldoNaturaleza.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.col_SaldoNaturaleza.AreaIndex = 0;
            this.col_SaldoNaturaleza.Caption = "Saldo";
            this.col_SaldoNaturaleza.FieldName = "SaldoNaturaleza";
            this.col_SaldoNaturaleza.Name = "col_SaldoNaturaleza";
            // 
            // pivotBalance
            // 
            this.pivotBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotBalance.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.col_SaldoNaturaleza,
            this.pivotGridField4,
            this.pivotGridField5,
            this.pivotGridField3,
            this.pivotGridField6,
            this.pivotGridField7});
            pivotGridStyleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pivotGridStyleFormatCondition1.Appearance.Options.UseFont = true;
            pivotGridStyleFormatCondition1.Expression = "[EsCuentaMovimiento] = True";
            pivotGridStyleFormatCondition1.Field = this.col_SaldoNaturaleza;
            pivotGridStyleFormatCondition1.FieldName = "col_SaldoNaturaleza";
            this.pivotBalance.FormatConditions.AddRange(new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition[] {
            pivotGridStyleFormatCondition1});
            this.pivotBalance.Location = new System.Drawing.Point(0, 128);
            this.pivotBalance.Name = "pivotBalance";
            this.pivotBalance.OptionsBehavior.BestFitConsiderCustomAppearance = true;
            this.pivotBalance.OptionsBehavior.BestFitMode = ((DevExpress.XtraPivotGrid.PivotGridBestFitMode)((DevExpress.XtraPivotGrid.PivotGridBestFitMode.FieldValue | DevExpress.XtraPivotGrid.PivotGridBestFitMode.Cell)));
            this.pivotBalance.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotBalance.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotBalance.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotBalance.OptionsPrint.PrintUnusedFilterFields = false;
            this.pivotBalance.OptionsView.ShowColumnTotals = false;
            this.pivotBalance.OptionsView.ShowRowGrandTotals = false;
            this.pivotBalance.Size = new System.Drawing.Size(1272, 472);
            this.pivotBalance.TabIndex = 1;
            this.pivotBalance.CustomAppearance += new DevExpress.XtraPivotGrid.PivotCustomAppearanceEventHandler(this.pivotBalance_CustomAppearance);
            this.pivotBalance.CustomDrawFieldValue += new DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventHandler(this.pivotBalance_CustomDrawFieldValue);
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "IdCtaCble";
            this.pivotGridField1.FieldName = "IdCtaCble";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Width = 200;
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField2.AreaIndex = 1;
            this.pivotGridField2.Caption = "Cuenta contable";
            this.pivotGridField2.FieldName = "NombreCuenta";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.Width = 300;
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField4.AreaIndex = 0;
            this.pivotGridField4.Caption = "IdCentroCosto";
            this.pivotGridField4.FieldName = "IdCentroCosto";
            this.pivotGridField4.Name = "pivotGridField4";
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField5.AreaIndex = 1;
            this.pivotGridField5.Caption = "Centro de costo";
            this.pivotGridField5.FieldName = "NombreCentroCosto";
            this.pivotGridField5.Name = "pivotGridField5";
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.AreaIndex = 1;
            this.pivotGridField3.Caption = "Tipo Cuenta";
            this.pivotGridField3.FieldName = "TipoCuenta";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.AreaIndex = 0;
            this.pivotGridField6.Caption = "Es cuenta movimiento";
            this.pivotGridField6.FieldName = "EsCuentaMovimiento";
            this.pivotGridField6.Name = "pivotGridField6";
            // 
            // pivotGridField7
            // 
            this.pivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField7.AreaIndex = 2;
            this.pivotGridField7.Caption = "Nivel";
            this.pivotGridField7.FieldName = "NivelCuenta";
            this.pivotGridField7.Name = "pivotGridField7";
            this.pivotGridField7.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // uCct_Menu_Reportes1
            // 
            this.uCct_Menu_Reportes1.caption_bei_Check = "Mostrar saldo 0";
            this.uCct_Menu_Reportes1.caption_bei_Check2 = "Mostrar saldo 0";
            this.uCct_Menu_Reportes1.caption_bei_Check3 = "Check";
            this.uCct_Menu_Reportes1.caption_bei_Check4 = "Check";
            this.uCct_Menu_Reportes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uCct_Menu_Reportes1.Location = new System.Drawing.Point(0, 0);
            this.uCct_Menu_Reportes1.Margin = new System.Windows.Forms.Padding(4);
            this.uCct_Menu_Reportes1.Name = "uCct_Menu_Reportes1";
            this.uCct_Menu_Reportes1.Size = new System.Drawing.Size(1272, 101);
            this.uCct_Menu_Reportes1.TabIndex = 0;
            this.uCct_Menu_Reportes1.Visible_bei_Centro_costo = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_Centro_costo_chk = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes1.Visible_bei_Centro_costo_sub_centro_costo = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_Check2 = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_Check3 = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_Check4 = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_CtaCble = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_Desde = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_GrupoCble = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_GrupoCble_chk = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_Hasta = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes1.Visible_bei_Nivel = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes1.Visible_bei_punto_cargo = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_btn_Mostrar_en_tabla = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_Grupo_centro_costo = true;
            this.uCct_Menu_Reportes1.Visible_Grupo_Check = true;
            this.uCct_Menu_Reportes1.Visible_Grupo_cuentas = true;
            this.uCct_Menu_Reportes1.Visible_Grupo_Punto_cargo = false;
            this.uCct_Menu_Reportes1.event_btnConsultar_ItemClick += new Core.Erp.Reportes.Controles.UCct_Menu_Reportes.delegate_btnConsultar_ItemClick(this.uCct_Menu_Reportes1_event_btnConsultar_ItemClick);
            this.uCct_Menu_Reportes1.event_btnSalir_ItemClick += new Core.Erp.Reportes.Controles.UCct_Menu_Reportes.delegate_btnSalir_ItemClick(this.uCct_Menu_Reportes1_event_btnSalir_ItemClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_imprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 101);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1272, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Image = global::Core.Erp.Reportes.Properties.Resources.imprimir5_64x64;
            this.btn_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(86, 24);
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarControl1.Location = new System.Drawing.Point(0, 600);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(1272, 18);
            this.progressBarControl1.TabIndex = 3;
            // 
            // XCONTA_Rpt023_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 618);
            this.Controls.Add(this.pivotBalance);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.uCct_Menu_Reportes1);
            this.Controls.Add(this.progressBarControl1);
            this.Name = "XCONTA_Rpt023_frm";
            this.Text = "XCONTA_Rpt023_frm";
            this.Load += new System.EventHandler(this.XCONTA_Rpt023_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotBalance)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCct_Menu_Reportes uCct_Menu_Reportes1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotBalance;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField col_SaldoNaturaleza;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_imprimir;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField7;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}