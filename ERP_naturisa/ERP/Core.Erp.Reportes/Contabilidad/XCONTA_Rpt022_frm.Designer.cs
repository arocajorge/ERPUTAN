﻿namespace Core.Erp.Reportes.Contabilidad
{
    partial class XCONTA_Rpt022_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XCONTA_Rpt022_frm));
            this.uCct_Menu_Reportes1 = new Core.Erp.Reportes.Controles.UCct_Menu_Reportes();
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Reportes.frmGe_Esperar), true, true);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_imprimir_grilla = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_balance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_balance_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIcono)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uCct_Menu_Reportes1
            // 
            this.uCct_Menu_Reportes1.caption_bei_Check = "Mostrar cuentas con saldo 0";
            this.uCct_Menu_Reportes1.caption_bei_Check2 = "Mostrar centro de costo";
            this.uCct_Menu_Reportes1.caption_bei_Check3 = "Considerar asiento de cierre";
            this.uCct_Menu_Reportes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uCct_Menu_Reportes1.Location = new System.Drawing.Point(0, 0);
            this.uCct_Menu_Reportes1.Name = "uCct_Menu_Reportes1";
            this.uCct_Menu_Reportes1.Size = new System.Drawing.Size(1221, 94);
            this.uCct_Menu_Reportes1.TabIndex = 0;
            this.uCct_Menu_Reportes1.Visible_bei_Check2 = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes1.Visible_bei_Check3 = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes1.Visible_bei_CtaCble = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_Desde = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes1.Visible_bei_GrupoCble = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_GrupoCble_chk = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_Hasta = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes1.Visible_bei_Nivel = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes1.Visible_bei_punto_cargo = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_btn_Mostrar_en_tabla = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes1.Visible_Grupo_centro_costo = true;
            this.uCct_Menu_Reportes1.Visible_Grupo_Check = true;
            this.uCct_Menu_Reportes1.Visible_Grupo_cuentas = true;
            this.uCct_Menu_Reportes1.Visible_Grupo_Punto_cargo = false;
            this.uCct_Menu_Reportes1.event_btnConsultar_ItemClick += new Core.Erp.Reportes.Controles.UCct_Menu_Reportes.delegate_btnConsultar_ItemClick(this.uCct_Menu_Reportes1_event_btnConsultar_ItemClick);
            this.uCct_Menu_Reportes1.event_btnSalir_ItemClick += new Core.Erp.Reportes.Controles.UCct_Menu_Reportes.delegate_btnSalir_ItemClick(this.uCct_Menu_Reportes1_event_btnSalir_ItemClick);
            this.uCct_Menu_Reportes1.event_btn_Mostrar_en_tabla_ItemClick += new Core.Erp.Reportes.Controles.UCct_Menu_Reportes.delegate_btn_Mostrar_en_tabla_ItemClick(this.uCct_Menu_Reportes1_event_btn_Mostrar_en_tabla_ItemClick);
            // 
            // gc_balance
            // 
            this.gc_balance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_balance.Location = new System.Drawing.Point(0, 119);
            this.gc_balance.MainView = this.gw_balance_comp;
            this.gc_balance.Name = "gc_balance";
            this.gc_balance.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbIcono});
            this.gc_balance.Size = new System.Drawing.Size(1221, 343);
            this.gc_balance.TabIndex = 18;
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
            this.col_IdCtaCble.Width = 148;
            // 
            // col_nom_cuenta
            // 
            this.col_nom_cuenta.Caption = "Cuenta";
            this.col_nom_cuenta.FieldName = "nom_cuenta";
            this.col_nom_cuenta.Name = "col_nom_cuenta";
            this.col_nom_cuenta.Visible = true;
            this.col_nom_cuenta.VisibleIndex = 1;
            this.col_nom_cuenta.Width = 841;
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
            this.col_Saldo.VisibleIndex = 2;
            this.col_Saldo.Width = 164;
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
            this.colDebito_Mes.Width = 95;
            // 
            // colCredito_Mes
            // 
            this.colCredito_Mes.Caption = "Credito Mes";
            this.colCredito_Mes.DisplayFormat.FormatString = "c2";
            this.colCredito_Mes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCredito_Mes.FieldName = "Credito_Mes";
            this.colCredito_Mes.Name = "colCredito_Mes";
            this.colCredito_Mes.Width = 98;
            // 
            // col_pc_EsMovimiento
            // 
            this.col_pc_EsMovimiento.Caption = "*";
            this.col_pc_EsMovimiento.ColumnEdit = this.cmbIcono;
            this.col_pc_EsMovimiento.FieldName = "pc_EsMovimiento";
            this.col_pc_EsMovimiento.Name = "col_pc_EsMovimiento";
            this.col_pc_EsMovimiento.Visible = true;
            this.col_pc_EsMovimiento.VisibleIndex = 3;
            this.col_pc_EsMovimiento.Width = 50;
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "report_ventas_128x128.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_imprimir_grilla});
            this.toolStrip1.Location = new System.Drawing.Point(0, 94);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1221, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_imprimir_grilla
            // 
            this.btn_imprimir_grilla.Image = global::Core.Erp.Reportes.Properties.Resources.imprimir5_64x64;
            this.btn_imprimir_grilla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir_grilla.Name = "btn_imprimir_grilla";
            this.btn_imprimir_grilla.Size = new System.Drawing.Size(76, 22);
            this.btn_imprimir_grilla.Text = "Imprimir ";
            this.btn_imprimir_grilla.Click += new System.EventHandler(this.btn_imprimir_grilla_Click);
            // 
            // XCONTA_Rpt022_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 462);
            this.Controls.Add(this.gc_balance);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.uCct_Menu_Reportes1);
            this.Name = "XCONTA_Rpt022_frm";
            this.Text = "XCONTA_Rpt022_frm";
            this.Load += new System.EventHandler(this.XCONTA_Rpt022_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_balance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_balance_comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIcono)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCct_Menu_Reportes uCct_Menu_Reportes1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colDebito_Mes;
        private DevExpress.XtraGrid.Columns.GridColumn colCredito_Mes;
        private DevExpress.XtraGrid.Columns.GridColumn col_pc_EsMovimiento;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbIcono;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_imprimir_grilla;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}