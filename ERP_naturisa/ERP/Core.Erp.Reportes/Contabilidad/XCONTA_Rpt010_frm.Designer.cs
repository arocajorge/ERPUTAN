namespace Core.Erp.Reportes.Contabilidad
{
    partial class XCONTA_Rpt010_frm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XCONTA_Rpt010_frm));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.cmb_Periodo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblPeriodo = new DevExpress.XtraEditors.LabelControl();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.uCct_Pto_Cargo_Grupo = new Core.Erp.Reportes.Controles.UCct_Pto_Cargo_Grupo();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Reportes.frmEspere), true, true);
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gbperiodo = new System.Windows.Forms.GroupBox();
            this.chkMostrar_Saldo_cero = new System.Windows.Forms.CheckBox();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Periodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbFecha.SuspendLayout();
            this.gbperiodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir,
            this.btnSalir});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(388, 25);
            this.toolStripMenu.TabIndex = 9;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Core.Erp.Reportes.Properties.Resources.salir_64x64;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "report_ventas_128x128.png");
            // 
            // cmb_Periodo
            // 
            this.cmb_Periodo.Location = new System.Drawing.Point(73, 19);
            this.cmb_Periodo.Name = "cmb_Periodo";
            this.cmb_Periodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Periodo.Properties.View = this.gridView1;
            this.cmb_Periodo.Size = new System.Drawing.Size(271, 20);
            this.cmb_Periodo.TabIndex = 16;
            this.cmb_Periodo.EditValueChanged += new System.EventHandler(this.cmb_Periodo_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdPeriodo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 103;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Periodo";
            this.gridColumn2.FieldName = "nom_periodo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 642;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Desde";
            this.gridColumn3.FieldName = "pe_FechaIni";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 217;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Hasta";
            this.gridColumn4.FieldName = "pe_FechaFin";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 218;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Location = new System.Drawing.Point(18, 26);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(40, 13);
            this.lblPeriodo.TabIndex = 15;
            this.lblPeriodo.Text = "Periodo:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(223, 19);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaFin.TabIndex = 9;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(336, 58);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(0, 13);
            this.lblFechaFin.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Location = new System.Drawing.Point(106, 81);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(0, 13);
            this.lblFechaIni.TabIndex = 7;
            // 
            // uCct_Pto_Cargo_Grupo
            // 
            this.uCct_Pto_Cargo_Grupo.Location = new System.Drawing.Point(12, 178);
            this.uCct_Pto_Cargo_Grupo.Name = "uCct_Pto_Cargo_Grupo";
            this.uCct_Pto_Cargo_Grupo.Size = new System.Drawing.Size(364, 32);
            this.uCct_Pto_Cargo_Grupo.TabIndex = 17;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 212);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(388, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.labelControl2);
            this.gbFecha.Controls.Add(this.dtpFechaIni);
            this.gbFecha.Controls.Add(this.labelControl1);
            this.gbFecha.Controls.Add(this.dtpFechaFin);
            this.gbFecha.Location = new System.Drawing.Point(19, 44);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(325, 48);
            this.gbFecha.TabIndex = 19;
            this.gbFecha.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Inicio:";
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(46, 18);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(109, 20);
            this.dtpFechaIni.TabIndex = 17;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(199, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Fin:";
            // 
            // gbperiodo
            // 
            this.gbperiodo.Controls.Add(this.cmb_Periodo);
            this.gbperiodo.Controls.Add(this.lblPeriodo);
            this.gbperiodo.Controls.Add(this.gbFecha);
            this.gbperiodo.Location = new System.Drawing.Point(12, 28);
            this.gbperiodo.Name = "gbperiodo";
            this.gbperiodo.Size = new System.Drawing.Size(364, 98);
            this.gbperiodo.TabIndex = 20;
            this.gbperiodo.TabStop = false;
            // 
            // chkMostrar_Saldo_cero
            // 
            this.chkMostrar_Saldo_cero.AutoSize = true;
            this.chkMostrar_Saldo_cero.Location = new System.Drawing.Point(226, 155);
            this.chkMostrar_Saldo_cero.Name = "chkMostrar_Saldo_cero";
            this.chkMostrar_Saldo_cero.Size = new System.Drawing.Size(150, 17);
            this.chkMostrar_Saldo_cero.TabIndex = 21;
            this.chkMostrar_Saldo_cero.Text = "Mostrar Saldos con CERO";
            this.chkMostrar_Saldo_cero.UseVisualStyleBackColor = true;
            // 
            // XCONTA_Rpt010_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 234);
            this.Controls.Add(this.chkMostrar_Saldo_cero);
            this.Controls.Add(this.gbperiodo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.uCct_Pto_Cargo_Grupo);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFechaIni);
            this.Name = "XCONTA_Rpt010_frm";
            this.Text = "XCONTA_Rpt010_frm";
            this.Load += new System.EventHandler(this.XCONTA_Rpt010_frm_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Periodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            this.gbperiodo.ResumeLayout(false);
            this.gbperiodo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ImageList imageList;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_Periodo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl lblPeriodo;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label label5;
        private Controles.UCct_Pto_Cargo_Grupo uCct_Pto_Cargo_Grupo;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox gbFecha;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox gbperiodo;
        private System.Windows.Forms.CheckBox chkMostrar_Saldo_cero;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}