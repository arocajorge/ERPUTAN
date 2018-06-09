namespace Cus.Erp.Reports.Naturisa.CuentasxCobrar
{
    partial class XCXC_NATU_Rpt001_frm
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
            this.uccxC_MenuReportes1 = new Core.Erp.Reportes.Controles.UCCXC_MenuReportes();
            this.gridControlDinardap = new DevExpress.XtraGrid.GridControl();
            this.gridViewDinardap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDinardap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDinardap)).BeginInit();
            this.SuspendLayout();
            // 
            // uccxC_MenuReportes1
            // 
            this.uccxC_MenuReportes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uccxC_MenuReportes1.EnableBotonGenerar = true;
            this.uccxC_MenuReportes1.EnableBotonImprimir = true;
            this.uccxC_MenuReportes1.EnableBotonSalir = true;
            this.uccxC_MenuReportes1.Location = new System.Drawing.Point(0, 0);
            this.uccxC_MenuReportes1.Name = "uccxC_MenuReportes1";
            this.uccxC_MenuReportes1.set_get_btnGenerar_File_txt_Caption = "Generar Txt";
            this.uccxC_MenuReportes1.Size = new System.Drawing.Size(963, 95);
            this.uccxC_MenuReportes1.TabIndex = 0;
            this.uccxC_MenuReportes1.TextCheck = "Check";
            this.uccxC_MenuReportes1.VisiblebeiDiasCredito = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uccxC_MenuReportes1.VisibleBtnGenerar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uccxC_MenuReportes1.VisibleBtnGenerar_txt = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uccxC_MenuReportes1.VisibleBtnImprimir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uccxC_MenuReportes1.VisibleBtnSalir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uccxC_MenuReportes1.VisibleCmbCliente = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uccxC_MenuReportes1.VisibleCmbPeriodo = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uccxC_MenuReportes1.VisibleCmbSucursal = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uccxC_MenuReportes1.VisibleCmbTipoCliente = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uccxC_MenuReportes1.VisibleCmbTipoCobro = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uccxC_MenuReportes1.VisibleCmbVendedor = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uccxC_MenuReportes1.VisibleFechaDesde = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uccxC_MenuReportes1.VisibleFechaHasta = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uccxC_MenuReportes1.VisibleGrupoBusqueda = true;
            this.uccxC_MenuReportes1.VisibleGrupoCheck = false;
            this.uccxC_MenuReportes1.VisibleGrupoFecha = true;
            this.uccxC_MenuReportes1.VisibleGrupoSucursal = false;
            this.uccxC_MenuReportes1.VisibleGrupoTipo = false;
            this.uccxC_MenuReportes1.VisibleGrupoVendedorCliente = false;
            this.uccxC_MenuReportes1.VisibleRbtFiltro = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uccxC_MenuReportes1.VisibleTipoCobro = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uccxC_MenuReportes1.event_btnConsultar_ItemClick += new Core.Erp.Reportes.Controles.UCCXC_MenuReportes.delegate_btnConsultar_ItemClick(this.uccxC_MenuReportes1_event_btnConsultar_ItemClick);
            this.uccxC_MenuReportes1.event_btnSalir_ItemClick += new Core.Erp.Reportes.Controles.UCCXC_MenuReportes.delegate_btnSalir_ItemClick(this.uccxC_MenuReportes1_event_btnSalir_ItemClick);
            this.uccxC_MenuReportes1.event_btnGenerar_File_txt_ItemClick += new Core.Erp.Reportes.Controles.UCCXC_MenuReportes.delegate_btnGenerar_File_txt_ItemClick(this.uccxC_MenuReportes1_event_btnGenerar_File_txt_ItemClick);
            // 
            // gridControlDinardap
            // 
            this.gridControlDinardap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDinardap.Location = new System.Drawing.Point(0, 95);
            this.gridControlDinardap.MainView = this.gridViewDinardap;
            this.gridControlDinardap.Name = "gridControlDinardap";
            this.gridControlDinardap.Size = new System.Drawing.Size(963, 338);
            this.gridControlDinardap.TabIndex = 1;
            this.gridControlDinardap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDinardap});
            // 
            // gridViewDinardap
            // 
            this.gridViewDinardap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridViewDinardap.GridControl = this.gridControlDinardap;
            this.gridViewDinardap.GroupCount = 1;
            this.gridViewDinardap.GroupFormat = "[#image]{1} {2}";
            this.gridViewDinardap.Name = "gridViewDinardap";
            this.gridViewDinardap.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewDinardap.OptionsBehavior.ReadOnly = true;
            this.gridViewDinardap.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDinardap.OptionsView.ShowFooter = true;
            this.gridViewDinardap.OptionsView.ShowGroupPanel = false;
            this.gridViewDinardap.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cliente";
            this.gridColumn1.FieldName = "pe_nombreCompleto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 287;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tipo documento";
            this.gridColumn2.FieldName = "IdTipoDocumento";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 96;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "# Documento";
            this.gridColumn3.FieldName = "pe_cedulaRuc";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 101;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ciudad";
            this.gridColumn5.FieldName = "Descripcion_Ciudad";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 135;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Provincia";
            this.gridColumn6.FieldName = "Descripcion_Prov";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 121;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "# Factura";
            this.gridColumn7.FieldName = "num_factura";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 109;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Valor operación";
            this.gridColumn8.DisplayFormat.FormatString = "n2";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "Valor_operacion";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 96;
            // 
            // XCXC_NATU_Rpt001_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 433);
            this.Controls.Add(this.gridControlDinardap);
            this.Controls.Add(this.uccxC_MenuReportes1);
            this.Name = "XCXC_NATU_Rpt001_frm";
            this.Text = "XCXC_NATU_Rpt001_frm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDinardap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDinardap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Core.Erp.Reportes.Controles.UCCXC_MenuReportes uccxC_MenuReportes1;
        private DevExpress.XtraGrid.GridControl gridControlDinardap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDinardap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}