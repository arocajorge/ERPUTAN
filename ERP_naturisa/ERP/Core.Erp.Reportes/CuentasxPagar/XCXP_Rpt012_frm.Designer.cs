namespace Core.Erp.Reportes.CuentasxPagar
{
    partial class XCXP_Rpt012_frm
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XCXP_Rpt012_frm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pgcCXP = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldIdCbteCbleOgiro1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDocumento1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnomtipodoc1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFecha1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnomproveedor1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldObservacion1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldValorAPagar1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTotalPagado1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSaldo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMes = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAnio = new DevExpress.XtraPivotGrid.PivotGridField();
            this.chartControlCXP = new DevExpress.XtraCharts.ChartControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.ucCp_Menu_Reportes1 = new Core.Erp.Reportes.Controles.UCCp_Menu_Reportes();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgcCXP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlCXP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 408);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pgcCXP);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chartControlCXP);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(891, 408);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 0;
            // 
            // pgcCXP
            // 
            this.pgcCXP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgcCXP.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldIdCbteCbleOgiro1,
            this.fieldDocumento1,
            this.fieldnomtipodoc1,
            this.fieldFecha1,
            this.fieldnomproveedor1,
            this.fieldObservacion1,
            this.fieldValorAPagar1,
            this.fieldTotalPagado1,
            this.fieldSaldo,
            this.fieldMes,
            this.fieldAnio});
            this.pgcCXP.Location = new System.Drawing.Point(0, 0);
            this.pgcCXP.Name = "pgcCXP";
            this.pgcCXP.Size = new System.Drawing.Size(891, 186);
            this.pgcCXP.TabIndex = 0;
            // 
            // fieldIdCbteCbleOgiro1
            // 
            this.fieldIdCbteCbleOgiro1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldIdCbteCbleOgiro1.AreaIndex = 2;
            this.fieldIdCbteCbleOgiro1.Caption = "Id Cbte Cble Ogiro";
            this.fieldIdCbteCbleOgiro1.FieldName = "IdCbteCble_Ogiro";
            this.fieldIdCbteCbleOgiro1.Name = "fieldIdCbteCbleOgiro1";
            // 
            // fieldDocumento1
            // 
            this.fieldDocumento1.AreaIndex = 0;
            this.fieldDocumento1.Caption = "Documento#";
            this.fieldDocumento1.FieldName = "Documento";
            this.fieldDocumento1.Name = "fieldDocumento1";
            this.fieldDocumento1.Width = 200;
            // 
            // fieldnomtipodoc1
            // 
            this.fieldnomtipodoc1.AreaIndex = 3;
            this.fieldnomtipodoc1.Caption = "Tipo de documento";
            this.fieldnomtipodoc1.FieldName = "nom_tipo_doc";
            this.fieldnomtipodoc1.Name = "fieldnomtipodoc1";
            // 
            // fieldFecha1
            // 
            this.fieldFecha1.AreaIndex = 1;
            this.fieldFecha1.Caption = "Fecha";
            this.fieldFecha1.FieldName = "Fecha";
            this.fieldFecha1.Name = "fieldFecha1";
            // 
            // fieldnomproveedor1
            // 
            this.fieldnomproveedor1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldnomproveedor1.AreaIndex = 0;
            this.fieldnomproveedor1.Caption = "Proveedor";
            this.fieldnomproveedor1.FieldName = "nom_proveedor";
            this.fieldnomproveedor1.Name = "fieldnomproveedor1";
            // 
            // fieldObservacion1
            // 
            this.fieldObservacion1.AreaIndex = 2;
            this.fieldObservacion1.Caption = "Observacion";
            this.fieldObservacion1.FieldName = "Observacion";
            this.fieldObservacion1.Name = "fieldObservacion1";
            // 
            // fieldValorAPagar1
            // 
            this.fieldValorAPagar1.AreaIndex = 4;
            this.fieldValorAPagar1.Caption = "Valor APagar";
            this.fieldValorAPagar1.FieldName = "ValorAPagar";
            this.fieldValorAPagar1.Name = "fieldValorAPagar1";
            // 
            // fieldTotalPagado1
            // 
            this.fieldTotalPagado1.AreaIndex = 5;
            this.fieldTotalPagado1.Caption = "Total Pagado";
            this.fieldTotalPagado1.FieldName = "TotalPagado";
            this.fieldTotalPagado1.Name = "fieldTotalPagado1";
            // 
            // fieldSaldo
            // 
            this.fieldSaldo.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSaldo.AreaIndex = 0;
            this.fieldSaldo.Caption = "Saldo";
            this.fieldSaldo.FieldName = "Saldo";
            this.fieldSaldo.Name = "fieldSaldo";
            // 
            // fieldMes
            // 
            this.fieldMes.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldMes.AreaIndex = 1;
            this.fieldMes.Caption = "Mes";
            this.fieldMes.FieldName = "NombreMes";
            this.fieldMes.Name = "fieldMes";
            // 
            // fieldAnio
            // 
            this.fieldAnio.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldAnio.AreaIndex = 0;
            this.fieldAnio.Caption = "Año";
            this.fieldAnio.FieldName = "AnioFiscal";
            this.fieldAnio.Name = "fieldAnio";
            // 
            // chartControlCXP
            // 
            this.chartControlCXP.DataSource = this.pgcCXP;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlCXP.Diagram = xyDiagram1;
            this.chartControlCXP.Legend.MaxHorizontalPercentage = 30D;
            this.chartControlCXP.Location = new System.Drawing.Point(0, 25);
            this.chartControlCXP.Name = "chartControlCXP";
            this.chartControlCXP.SeriesDataMember = "Series";
            this.chartControlCXP.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControlCXP.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControlCXP.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            sideBySideBarSeriesLabel1.LineVisible = true;
            this.chartControlCXP.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControlCXP.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControlCXP.Size = new System.Drawing.Size(891, 193);
            this.chartControlCXP.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(891, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsbImprimir.Image")));
            this.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(23, 22);
            this.tsbImprimir.Text = "toolStripButton1";
            this.tsbImprimir.Click += new System.EventHandler(this.tsbImprimir_Click);
            // 
            // ucCp_Menu_Reportes1
            // 
            this.ucCp_Menu_Reportes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucCp_Menu_Reportes1.Location = new System.Drawing.Point(0, 0);
            this.ucCp_Menu_Reportes1.Name = "ucCp_Menu_Reportes1";
            this.ucCp_Menu_Reportes1.Size = new System.Drawing.Size(891, 96);
            this.ucCp_Menu_Reportes1.TabIndex = 0;
            this.ucCp_Menu_Reportes1.Visible_Imprimir = true;
            this.ucCp_Menu_Reportes1.event_btnRefrescar_ItemClick += new Core.Erp.Reportes.Controles.UCCp_Menu_Reportes.delegate_btnRefrescar_ItemClick(this.ucCp_Menu_Reportes1_event_btnRefrescar_ItemClick);
            this.ucCp_Menu_Reportes1.event_btnimprimir_ItemClick += new Core.Erp.Reportes.Controles.UCCp_Menu_Reportes.delegate_btnimprimir_ItemClick(this.ucCp_Menu_Reportes1_event_btnimprimir_ItemClick);
            // 
            // XCXP_Rpt012_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucCp_Menu_Reportes1);
            this.Name = "XCXP_Rpt012_frm";
            this.Text = "XCXP_Rpt012_frm";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pgcCXP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlCXP)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCCp_Menu_Reportes ucCp_Menu_Reportes1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraPivotGrid.PivotGridControl pgcCXP;
        private DevExpress.XtraCharts.ChartControl chartControlCXP;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIdCbteCbleOgiro1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDocumento1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnomtipodoc1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFecha1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnomproveedor1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldObservacion1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldValorAPagar1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTotalPagado1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSaldo;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMes;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAnio;
    }
}