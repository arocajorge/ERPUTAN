namespace Cus.Erp.Reports.Naturisa.Contabilidad
{
    partial class XCONTA_Rpt007_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XCONTA_Rpt007_frm));
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Reportes.frmEspere), true, true);
            this.cmb_imagen = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gc_balance_comp = new DevExpress.XtraGrid.GridControl();
            this.gw_balance_comp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_GrupoCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdCtaCblePadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Saldo_Inicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo_x_Movi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pc_EsMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbIcono = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colDebito_Mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCredito_Mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Generar_Reporte = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_centro_costo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.uCct_Pto_Cargo_Grupo = new Core.Erp.Reportes.Controles.UCct_Pto_Cargo_Grupo();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dt_FechaDesde = new System.Windows.Forms.DateTimePicker();
            this.chkMostrar_Cero = new System.Windows.Forms.CheckBox();
            this.lblPeriodo = new DevExpress.XtraEditors.LabelControl();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.chkMostrarCC = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_balance_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_balance_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIcono)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_imagen
            // 
            this.cmb_imagen.AutoHeight = false;
            this.cmb_imagen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_imagen.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "S", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "N", -1)});
            this.cmb_imagen.Name = "cmb_imagen";
            this.cmb_imagen.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "consultar_32x32.png");
            // 
            // gc_balance_comp
            // 
            this.gc_balance_comp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_balance_comp.Location = new System.Drawing.Point(0, 122);
            this.gc_balance_comp.MainView = this.gw_balance_comp;
            this.gc_balance_comp.Name = "gc_balance_comp";
            this.gc_balance_comp.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbIcono});
            this.gc_balance_comp.Size = new System.Drawing.Size(1114, 312);
            this.gc_balance_comp.TabIndex = 16;
            this.gc_balance_comp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gw_balance_comp});
            // 
            // gw_balance_comp
            // 
            this.gw_balance_comp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdCtaCble,
            this.col_nom_cuenta,
            this.col_GrupoCble,
            this.col_IdCtaCblePadre,
            this.col_Saldo_Inicial,
            this.col_Saldo,
            this.colSaldo_x_Movi,
            this.col_pc_EsMovimiento,
            this.colDebito_Mes,
            this.colCredito_Mes});
            this.gw_balance_comp.CustomizationFormBounds = new System.Drawing.Rectangle(597, 431, 210, 172);
            this.gw_balance_comp.GridControl = this.gc_balance_comp;
            this.gw_balance_comp.GroupCount = 1;
            this.gw_balance_comp.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo_inicial_x_Movi", this.col_Saldo_Inicial, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo_x_Movi", this.col_Saldo, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debito_Mes_x_Movi", this.colDebito_Mes, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credito_Mes_x_Movi", this.colCredito_Mes, "{0:c2}")});
            this.gw_balance_comp.Name = "gw_balance_comp";
            this.gw_balance_comp.OptionsBehavior.AutoExpandAllGroups = true;
            this.gw_balance_comp.OptionsBehavior.Editable = false;
            this.gw_balance_comp.OptionsBehavior.ReadOnly = true;
            this.gw_balance_comp.OptionsPrint.PrintHeader = false;
            this.gw_balance_comp.OptionsPrint.PrintHorzLines = false;
            this.gw_balance_comp.OptionsPrint.PrintVertLines = false;
            this.gw_balance_comp.OptionsView.ShowFooter = true;
            this.gw_balance_comp.OptionsView.ShowGroupPanel = false;
            this.gw_balance_comp.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gw_balance_comp.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gw_balance_comp.OptionsView.ShowViewCaption = true;
            this.gw_balance_comp.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_GrupoCble, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gw_balance_comp.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gw_balance_comp_RowCellClick);
            // 
            // col_IdCtaCble
            // 
            this.col_IdCtaCble.Caption = "Cuenta Contable";
            this.col_IdCtaCble.FieldName = "IdCtaCble";
            this.col_IdCtaCble.Name = "col_IdCtaCble";
            this.col_IdCtaCble.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.col_IdCtaCble.Visible = true;
            this.col_IdCtaCble.VisibleIndex = 0;
            this.col_IdCtaCble.Width = 111;
            // 
            // col_nom_cuenta
            // 
            this.col_nom_cuenta.Caption = "Cuenta";
            this.col_nom_cuenta.FieldName = "nom_cuenta";
            this.col_nom_cuenta.Name = "col_nom_cuenta";
            this.col_nom_cuenta.Visible = true;
            this.col_nom_cuenta.VisibleIndex = 1;
            this.col_nom_cuenta.Width = 506;
            // 
            // col_GrupoCble
            // 
            this.col_GrupoCble.Caption = "Grupo Ctble";
            this.col_GrupoCble.FieldName = "GrupoCble";
            this.col_GrupoCble.Name = "col_GrupoCble";
            this.col_GrupoCble.Visible = true;
            this.col_GrupoCble.VisibleIndex = 1;
            // 
            // col_IdCtaCblePadre
            // 
            this.col_IdCtaCblePadre.Caption = "Padre Ctble";
            this.col_IdCtaCblePadre.FieldName = "IdCtaCblePadre";
            this.col_IdCtaCblePadre.Name = "col_IdCtaCblePadre";
            // 
            // col_Saldo_Inicial
            // 
            this.col_Saldo_Inicial.Caption = "Saldo Inicial";
            this.col_Saldo_Inicial.DisplayFormat.FormatString = "c2";
            this.col_Saldo_Inicial.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_Saldo_Inicial.FieldName = "Saldo_Inicial";
            this.col_Saldo_Inicial.Name = "col_Saldo_Inicial";
            this.col_Saldo_Inicial.Visible = true;
            this.col_Saldo_Inicial.VisibleIndex = 2;
            this.col_Saldo_Inicial.Width = 123;
            // 
            // col_Saldo
            // 
            this.col_Saldo.Caption = "Saldo";
            this.col_Saldo.DisplayFormat.FormatString = "c2";
            this.col_Saldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_Saldo.FieldName = "Saldo";
            this.col_Saldo.Name = "col_Saldo";
            this.col_Saldo.Visible = true;
            this.col_Saldo.VisibleIndex = 5;
            this.col_Saldo.Width = 204;
            // 
            // colSaldo_x_Movi
            // 
            this.colSaldo_x_Movi.Caption = "Saldo_x_Movi";
            this.colSaldo_x_Movi.FieldName = "Saldo_x_Movi";
            this.colSaldo_x_Movi.Name = "colSaldo_x_Movi";
            // 
            // col_pc_EsMovimiento
            // 
            this.col_pc_EsMovimiento.Caption = "*";
            this.col_pc_EsMovimiento.ColumnEdit = this.cmbIcono;
            this.col_pc_EsMovimiento.FieldName = "pc_EsMovimiento";
            this.col_pc_EsMovimiento.Name = "col_pc_EsMovimiento";
            this.col_pc_EsMovimiento.Visible = true;
            this.col_pc_EsMovimiento.VisibleIndex = 6;
            this.col_pc_EsMovimiento.Width = 35;
            // 
            // cmbIcono
            // 
            this.cmbIcono.AutoHeight = false;
            this.cmbIcono.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIcono.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "S", 0)});
            this.cmbIcono.Name = "cmbIcono";
            this.cmbIcono.SmallImages = this.imageList1;
            // 
            // colDebito_Mes
            // 
            this.colDebito_Mes.Caption = "Debito Mes";
            this.colDebito_Mes.DisplayFormat.FormatString = "c2";
            this.colDebito_Mes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDebito_Mes.FieldName = "Debito_Mes";
            this.colDebito_Mes.Name = "colDebito_Mes";
            this.colDebito_Mes.Visible = true;
            this.colDebito_Mes.VisibleIndex = 3;
            this.colDebito_Mes.Width = 99;
            // 
            // colCredito_Mes
            // 
            this.colCredito_Mes.Caption = "Credito Mes";
            this.colCredito_Mes.DisplayFormat.FormatString = "c2";
            this.colCredito_Mes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCredito_Mes.FieldName = "Credito_Mes";
            this.colCredito_Mes.Name = "colCredito_Mes";
            this.colCredito_Mes.Visible = true;
            this.colCredito_Mes.VisibleIndex = 4;
            this.colCredito_Mes.Width = 102;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1114, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.chkMostrarCC);
            this.panel1.Controls.Add(this.btn_Generar_Reporte);
            this.panel1.Controls.Add(this.cmb_centro_costo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.uCct_Pto_Cargo_Grupo);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.dt_FechaDesde);
            this.panel1.Controls.Add(this.chkMostrar_Cero);
            this.panel1.Controls.Add(this.lblPeriodo);
            this.panel1.Controls.Add(this.dtpFechaHasta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 97);
            this.panel1.TabIndex = 20;
            // 
            // btn_Generar_Reporte
            // 
            this.btn_Generar_Reporte.ImageIndex = 0;
            this.btn_Generar_Reporte.ImageList = this.imageList1;
            this.btn_Generar_Reporte.Location = new System.Drawing.Point(21, 64);
            this.btn_Generar_Reporte.Name = "btn_Generar_Reporte";
            this.btn_Generar_Reporte.Size = new System.Drawing.Size(118, 27);
            this.btn_Generar_Reporte.TabIndex = 36;
            this.btn_Generar_Reporte.Text = "Generar Reporte";
            this.btn_Generar_Reporte.Click += new System.EventHandler(this.btnCargarReporte_Click);
            // 
            // cmb_centro_costo
            // 
            this.cmb_centro_costo.Location = new System.Drawing.Point(663, 17);
            this.cmb_centro_costo.Name = "cmb_centro_costo";
            this.cmb_centro_costo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_centro_costo.Properties.DisplayMember = "Centro_costo";
            this.cmb_centro_costo.Properties.ValueMember = "IdCentroCosto";
            this.cmb_centro_costo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_centro_costo.Size = new System.Drawing.Size(282, 20);
            this.cmb_centro_costo.TabIndex = 22;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCentroCosto,
            this.colCentro_costo});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.Caption = "IdCentroCosto";
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            this.colIdCentroCosto.Visible = true;
            this.colIdCentroCosto.VisibleIndex = 0;
            this.colIdCentroCosto.Width = 122;
            // 
            // colCentro_costo
            // 
            this.colCentro_costo.Caption = "Centro_costo";
            this.colCentro_costo.FieldName = "Centro_costo";
            this.colCentro_costo.Name = "colCentro_costo";
            this.colCentro_costo.Visible = true;
            this.colCentro_costo.VisibleIndex = 1;
            this.colCentro_costo.Width = 597;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Centro Costo:";
            // 
            // uCct_Pto_Cargo_Grupo
            // 
            this.uCct_Pto_Cargo_Grupo.Location = new System.Drawing.Point(586, 40);
            this.uCct_Pto_Cargo_Grupo.Name = "uCct_Pto_Cargo_Grupo";
            this.uCct_Pto_Cargo_Grupo.Size = new System.Drawing.Size(369, 54);
            this.uCct_Pto_Cargo_Grupo.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(202, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Hasta:";
            // 
            // dt_FechaDesde
            // 
            this.dt_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FechaDesde.Location = new System.Drawing.Point(87, 14);
            this.dt_FechaDesde.Name = "dt_FechaDesde";
            this.dt_FechaDesde.Size = new System.Drawing.Size(100, 20);
            this.dt_FechaDesde.TabIndex = 18;
            // 
            // chkMostrar_Cero
            // 
            this.chkMostrar_Cero.AutoSize = true;
            this.chkMostrar_Cero.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMostrar_Cero.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkMostrar_Cero.Location = new System.Drawing.Point(208, 40);
            this.chkMostrar_Cero.Name = "chkMostrar_Cero";
            this.chkMostrar_Cero.Size = new System.Drawing.Size(143, 17);
            this.chkMostrar_Cero.TabIndex = 0;
            this.chkMostrar_Cero.Text = "Mostrar registros en Cero";
            this.chkMostrar_Cero.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkMostrar_Cero.UseVisualStyleBackColor = true;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Location = new System.Drawing.Point(36, 16);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(34, 13);
            this.lblPeriodo.TabIndex = 15;
            this.lblPeriodo.Text = "Desde:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(251, 13);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaHasta.TabIndex = 9;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaCorte_ValueChanged);
            // 
            // chkMostrarCC
            // 
            this.chkMostrarCC.AutoSize = true;
            this.chkMostrarCC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMostrarCC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkMostrarCC.Location = new System.Drawing.Point(208, 63);
            this.chkMostrarCC.Name = "chkMostrarCC";
            this.chkMostrarCC.Size = new System.Drawing.Size(143, 17);
            this.chkMostrarCC.TabIndex = 37;
            this.chkMostrarCC.Text = "Mostrar centros de costo";
            this.chkMostrarCC.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkMostrarCC.UseVisualStyleBackColor = true;
            // 
            // XCONTA_Rpt007_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 434);
            this.Controls.Add(this.gc_balance_comp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "XCONTA_Rpt007_frm";
            this.Text = "Reporte Balance de Comprobación";
            this.Load += new System.EventHandler(this.XCONTA_Rpt007_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_balance_comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_balance_comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIcono)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_balance_comp;
        private DevExpress.XtraGrid.Views.Grid.GridView gw_balance_comp;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn col_GrupoCble;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdCtaCblePadre;
        private DevExpress.XtraGrid.Columns.GridColumn col_Saldo_Inicial;
        private DevExpress.XtraGrid.Columns.GridColumn col_Saldo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblPeriodo;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.CheckBox chkMostrar_Cero;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_imagen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dt_FechaDesde;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo_x_Movi;
        private DevExpress.XtraGrid.Columns.GridColumn col_pc_EsMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colDebito_Mes;
        private DevExpress.XtraGrid.Columns.GridColumn colCredito_Mes;
        private Controles.UCct_Pto_Cargo_Grupo uCct_Pto_Cargo_Grupo;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_centro_costo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_Generar_Reporte;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbIcono;
        private System.Windows.Forms.CheckBox chkMostrarCC;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}