namespace Core.Erp.Reportes.Contabilidad
{
    partial class XCONTA_Rpt001_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XCONTA_Rpt001_frm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkMostrar_CC = new System.Windows.Forms.CheckBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkMostrar_Reg_Cero = new System.Windows.Forms.CheckBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.uCct_Pto_Cargo_Grupo = new Core.Erp.Reportes.Controles.UCct_Pto_Cargo_Grupo();
            this.cmb_Periodo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblPeriodo = new DevExpress.XtraEditors.LabelControl();
            this.cmb_Mostrar_a = new System.Windows.Forms.ComboBox();
            this.cmb_centro_costo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_nivel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gc_balance = new DevExpress.XtraGrid.GridControl();
            this.gw_balance_comp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdNivelCta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_GrupoCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_OrderGrupoCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdCtaCblePadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Saldo_Inicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo_x_Movi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebito_Mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCredito_Mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pc_EsMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbIcono = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Reportes.frmEspere), true, true);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btn_imprimir_grilla = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Periodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_balance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_balance_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIcono)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkMostrar_CC);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.dtpFechaDesde);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.chkMostrar_Reg_Cero);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.uCct_Pto_Cargo_Grupo);
            this.panel1.Controls.Add(this.cmb_Periodo);
            this.panel1.Controls.Add(this.lblPeriodo);
            this.panel1.Controls.Add(this.cmb_Mostrar_a);
            this.panel1.Controls.Add(this.cmb_centro_costo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_nivel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFechaHasta);
            this.panel1.Controls.Add(this.lblFechaFin);
            this.panel1.Controls.Add(this.lblFechaIni);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 101);
            this.panel1.TabIndex = 6;
            // 
            // chkMostrar_CC
            // 
            this.chkMostrar_CC.AutoSize = true;
            this.chkMostrar_CC.Location = new System.Drawing.Point(475, 6);
            this.chkMostrar_CC.Name = "chkMostrar_CC";
            this.chkMostrar_CC.Size = new System.Drawing.Size(143, 17);
            this.chkMostrar_CC.TabIndex = 23;
            this.chkMostrar_CC.Text = "Mostrar centros de costo";
            this.chkMostrar_CC.UseVisualStyleBackColor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(341, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Hasta:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(239, 29);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(82, 20);
            this.dtpFechaDesde.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(199, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Desde:";
            // 
            // chkMostrar_Reg_Cero
            // 
            this.chkMostrar_Reg_Cero.AutoSize = true;
            this.chkMostrar_Reg_Cero.Location = new System.Drawing.Point(475, 29);
            this.chkMostrar_Reg_Cero.Name = "chkMostrar_Reg_Cero";
            this.chkMostrar_Reg_Cero.Size = new System.Drawing.Size(148, 17);
            this.chkMostrar_Reg_Cero.TabIndex = 19;
            this.chkMostrar_Reg_Cero.Text = "Mostrar Registros en Cero";
            this.chkMostrar_Reg_Cero.UseVisualStyleBackColor = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageIndex = 0;
            this.simpleButton1.ImageList = this.imageList1;
            this.simpleButton1.Location = new System.Drawing.Point(12, 53);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(118, 27);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Text = "Generar Reporte";
            this.simpleButton1.Click += new System.EventHandler(this.btnCargarReporte_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "report_ventas_128x128.png");
            // 
            // uCct_Pto_Cargo_Grupo
            // 
            this.uCct_Pto_Cargo_Grupo.Location = new System.Drawing.Point(642, 32);
            this.uCct_Pto_Cargo_Grupo.Name = "uCct_Pto_Cargo_Grupo";
            this.uCct_Pto_Cargo_Grupo.Size = new System.Drawing.Size(369, 54);
            this.uCct_Pto_Cargo_Grupo.TabIndex = 17;
            // 
            // cmb_Periodo
            // 
            this.cmb_Periodo.Location = new System.Drawing.Point(245, 3);
            this.cmb_Periodo.Name = "cmb_Periodo";
            this.cmb_Periodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Periodo.Properties.View = this.gridView1;
            this.cmb_Periodo.Size = new System.Drawing.Size(224, 20);
            this.cmb_Periodo.TabIndex = 16;
            this.cmb_Periodo.Visible = false;
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
            this.lblPeriodo.Location = new System.Drawing.Point(199, 8);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(40, 13);
            this.lblPeriodo.TabIndex = 15;
            this.lblPeriodo.Text = "Periodo:";
            this.lblPeriodo.Visible = false;
            // 
            // cmb_Mostrar_a
            // 
            this.cmb_Mostrar_a.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Mostrar_a.FormattingEnabled = true;
            this.cmb_Mostrar_a.Items.AddRange(new object[] {
            "Mes actual",
            "Mes anterior",
            "Todo el año",
            "Año pasado",
            "Por periodo"});
            this.cmb_Mostrar_a.Location = new System.Drawing.Point(71, 3);
            this.cmb_Mostrar_a.Name = "cmb_Mostrar_a";
            this.cmb_Mostrar_a.Size = new System.Drawing.Size(121, 21);
            this.cmb_Mostrar_a.TabIndex = 14;
            this.cmb_Mostrar_a.SelectedValueChanged += new System.EventHandler(this.cmb_Mostrar_a_SelectedValueChanged);
            // 
            // cmb_centro_costo
            // 
            this.cmb_centro_costo.Location = new System.Drawing.Point(719, 10);
            this.cmb_centro_costo.Name = "cmb_centro_costo";
            this.cmb_centro_costo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_centro_costo.Properties.DisplayMember = "Centro_costo";
            this.cmb_centro_costo.Properties.ValueMember = "IdCentroCosto";
            this.cmb_centro_costo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_centro_costo.Size = new System.Drawing.Size(286, 20);
            this.cmb_centro_costo.TabIndex = 13;
            this.cmb_centro_costo.EditValueChanged += new System.EventHandler(this.cmb_centro_costo_EditValueChanged);
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
            this.label4.Location = new System.Drawing.Point(647, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Centro Costo:";
            // 
            // cmb_nivel
            // 
            this.cmb_nivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nivel.FormattingEnabled = true;
            this.cmb_nivel.Location = new System.Drawing.Point(309, 63);
            this.cmb_nivel.Name = "cmb_nivel";
            this.cmb_nivel.Size = new System.Drawing.Size(121, 21);
            this.cmb_nivel.TabIndex = 11;
            this.cmb_nivel.SelectedValueChanged += new System.EventHandler(this.cmb_nivel_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mostrar desde el nivel:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(383, 29);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaHasta.TabIndex = 9;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaCorte_ValueChanged);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(279, 1);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(0, 13);
            this.lblFechaFin.TabIndex = 8;
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Location = new System.Drawing.Point(106, 67);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(0, 13);
            this.lblFechaIni.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mostrar a:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gc_balance);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 294);
            this.panel2.TabIndex = 7;
            // 
            // gc_balance
            // 
            this.gc_balance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_balance.Location = new System.Drawing.Point(0, 0);
            this.gc_balance.MainView = this.gw_balance_comp;
            this.gc_balance.Name = "gc_balance";
            this.gc_balance.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbIcono});
            this.gc_balance.Size = new System.Drawing.Size(1168, 294);
            this.gc_balance.TabIndex = 17;
            this.gc_balance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gw_balance_comp});
            // 
            // gw_balance_comp
            // 
            this.gw_balance_comp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdCtaCble,
            this.col_nom_cuenta,
            this.col_IdNivelCta,
            this.col_GrupoCble,
            this.col_OrderGrupoCble,
            this.col_IdCtaCblePadre,
            this.col_Saldo_Inicial,
            this.col_Saldo,
            this.colSaldo_x_Movi,
            this.colDebito_Mes,
            this.colCredito_Mes,
            this.col_pc_EsMovimiento});
            this.gw_balance_comp.CustomizationFormBounds = new System.Drawing.Rectangle(597, 431, 210, 172);
            this.gw_balance_comp.GridControl = this.gc_balance;
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
            this.col_IdCtaCble.Width = 107;
            // 
            // col_nom_cuenta
            // 
            this.col_nom_cuenta.Caption = "Cuenta";
            this.col_nom_cuenta.FieldName = "nom_cuenta";
            this.col_nom_cuenta.Name = "col_nom_cuenta";
            this.col_nom_cuenta.Visible = true;
            this.col_nom_cuenta.VisibleIndex = 1;
            this.col_nom_cuenta.Width = 487;
            // 
            // col_IdNivelCta
            // 
            this.col_IdNivelCta.Caption = "Nivel";
            this.col_IdNivelCta.FieldName = "IdNivelCta";
            this.col_IdNivelCta.Name = "col_IdNivelCta";
            // 
            // col_GrupoCble
            // 
            this.col_GrupoCble.Caption = "Grupo Ctble";
            this.col_GrupoCble.FieldName = "GrupoCble";
            this.col_GrupoCble.Name = "col_GrupoCble";
            this.col_GrupoCble.Visible = true;
            this.col_GrupoCble.VisibleIndex = 1;
            // 
            // col_OrderGrupoCble
            // 
            this.col_OrderGrupoCble.Caption = "OrderGrupoCble";
            this.col_OrderGrupoCble.FieldName = "OrderGrupoCble";
            this.col_OrderGrupoCble.Name = "col_OrderGrupoCble";
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
            this.col_Saldo_Inicial.Width = 118;
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
            this.col_Saldo.Width = 212;
            // 
            // colSaldo_x_Movi
            // 
            this.colSaldo_x_Movi.Caption = "Saldo_x_Movi";
            this.colSaldo_x_Movi.FieldName = "Saldo_x_Movi";
            this.colSaldo_x_Movi.Name = "colSaldo_x_Movi";
            this.colSaldo_x_Movi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
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
            this.colDebito_Mes.Width = 95;
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
            this.colCredito_Mes.Width = 98;
            // 
            // col_pc_EsMovimiento
            // 
            this.col_pc_EsMovimiento.Caption = "*";
            this.col_pc_EsMovimiento.ColumnEdit = this.cmbIcono;
            this.col_pc_EsMovimiento.FieldName = "pc_EsMovimiento";
            this.col_pc_EsMovimiento.Name = "col_pc_EsMovimiento";
            this.col_pc_EsMovimiento.Visible = true;
            this.col_pc_EsMovimiento.VisibleIndex = 6;
            this.col_pc_EsMovimiento.Width = 63;
            // 
            // cmbIcono
            // 
            this.cmbIcono.AutoHeight = false;
            this.cmbIcono.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIcono.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "S", 0)});
            this.cmbIcono.LargeImages = this.imageList1;
            this.cmbIcono.Name = "cmbIcono";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir,
            this.btn_imprimir_grilla,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1168, 25);
            this.toolStrip1.TabIndex = 8;
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
            // btn_imprimir_grilla
            // 
            this.btn_imprimir_grilla.Image = global::Core.Erp.Reportes.Properties.Resources.imprimir5_64x64;
            this.btn_imprimir_grilla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir_grilla.Name = "btn_imprimir_grilla";
            this.btn_imprimir_grilla.Size = new System.Drawing.Size(102, 22);
            this.btn_imprimir_grilla.Text = "Imprimir tabla";
            this.btn_imprimir_grilla.Click += new System.EventHandler(this.btn_imprimir_grilla_Click);
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
            // XCONTA_Rpt001_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 420);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "XCONTA_Rpt001_frm";
            this.Text = "Balance General";
            this.Load += new System.EventHandler(this.XCONTA_Rpt001_frm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Periodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_balance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_balance_comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIcono)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.ComboBox cmb_nivel;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_centro_costo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        private System.Windows.Forms.ComboBox cmb_Mostrar_a;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_Periodo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private Controles.UCct_Pto_Cargo_Grupo uCct_Pto_Cargo_Grupo;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.CheckBox chkMostrar_Reg_Cero;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gc_balance;
        private DevExpress.XtraGrid.Views.Grid.GridView gw_balance_comp;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdNivelCta;
        private DevExpress.XtraGrid.Columns.GridColumn col_GrupoCble;
        private DevExpress.XtraGrid.Columns.GridColumn col_OrderGrupoCble;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdCtaCblePadre;
        private DevExpress.XtraGrid.Columns.GridColumn col_Saldo_Inicial;
        private DevExpress.XtraGrid.Columns.GridColumn col_Saldo;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo_x_Movi;
        private DevExpress.XtraGrid.Columns.GridColumn col_pc_EsMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colDebito_Mes;
        private DevExpress.XtraGrid.Columns.GridColumn colCredito_Mes;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbIcono;
        private DevExpress.XtraEditors.LabelControl lblPeriodo;
        private System.Windows.Forms.CheckBox chkMostrar_CC;
        private System.Windows.Forms.ToolStripButton btn_imprimir_grilla;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}