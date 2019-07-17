namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_OrdenPedidoCotizacionConfirma
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
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.gc_detalle = new DevExpress.XtraGrid.GridControl();
            this.gv_detalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Sucursal = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Proveedor = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_TerminoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_TerminoPago = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtFocus = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Sucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Proveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_TerminoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFocus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Superior_Mant1
            // 
            this.ucGe_Menu_Superior_Mant1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant1.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant1.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(1658, 28);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnAprobarGuardarSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAprobarGuardarSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnAprobarGuardarSalir_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // gc_detalle
            // 
            this.gc_detalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_detalle.Location = new System.Drawing.Point(0, 28);
            this.gc_detalle.MainView = this.gv_detalle;
            this.gc_detalle.Name = "gc_detalle";
            this.gc_detalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_TerminoPago,
            this.cmb_Sucursal,
            this.cmb_Proveedor});
            this.gc_detalle.Size = new System.Drawing.Size(1658, 583);
            this.gc_detalle.TabIndex = 1;
            this.gc_detalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_detalle});
            // 
            // gv_detalle
            // 
            this.gv_detalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.col_TerminoPago,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn9,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16});
            this.gv_detalle.GridControl = this.gc_detalle;
            this.gv_detalle.Name = "gv_detalle";
            this.gv_detalle.OptionsView.ShowAutoFilterRow = true;
            this.gv_detalle.OptionsView.ShowDetailButtons = false;
            this.gv_detalle.OptionsView.ShowFooter = true;
            this.gv_detalle.OptionsView.ShowGroupPanel = false;
            this.gv_detalle.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_detalle_CellValueChanged);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Sucursal";
            this.gridColumn7.ColumnEdit = this.cmb_Sucursal;
            this.gridColumn7.FieldName = "IdSucursal";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 174;
            // 
            // cmb_Sucursal
            // 
            this.cmb_Sucursal.AutoHeight = false;
            this.cmb_Sucursal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Sucursal.DisplayMember = "codigo";
            this.cmb_Sucursal.Name = "cmb_Sucursal";
            this.cmb_Sucursal.ValueMember = "IdSucursal";
            this.cmb_Sucursal.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID";
            this.gridColumn4.FieldName = "IdSucursal";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 321;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Código";
            this.gridColumn5.FieldName = "Codigo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 294;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Sucursal";
            this.gridColumn6.FieldName = "Su_Descripcion";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 1119;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Proveedor";
            this.gridColumn8.ColumnEdit = this.cmb_Proveedor;
            this.gridColumn8.FieldName = "IdProveedor";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 385;
            // 
            // cmb_Proveedor
            // 
            this.cmb_Proveedor.AutoHeight = false;
            this.cmb_Proveedor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Proveedor.DisplayMember = "pe_nombreCompleto";
            this.cmb_Proveedor.Name = "cmb_Proveedor";
            this.cmb_Proveedor.ValueMember = "IdProveedor";
            this.cmb_Proveedor.View = this.repositoryItemSearchLookUpEdit2View;
            // 
            // repositoryItemSearchLookUpEdit2View
            // 
            this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // col_TerminoPago
            // 
            this.col_TerminoPago.Caption = "Término pago";
            this.col_TerminoPago.ColumnEdit = this.cmb_TerminoPago;
            this.col_TerminoPago.FieldName = "IdTerminoPago";
            this.col_TerminoPago.Name = "col_TerminoPago";
            this.col_TerminoPago.Visible = true;
            this.col_TerminoPago.VisibleIndex = 4;
            this.col_TerminoPago.Width = 206;
            // 
            // cmb_TerminoPago
            // 
            this.cmb_TerminoPago.AutoHeight = false;
            this.cmb_TerminoPago.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_TerminoPago.DisplayMember = "Descripcion";
            this.cmb_TerminoPago.Name = "cmb_TerminoPago";
            this.cmb_TerminoPago.ValueMember = "IdTerminoPago";
            this.cmb_TerminoPago.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdTerminoPago";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 237;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Término pago";
            this.gridColumn2.FieldName = "Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 1278;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Plazo";
            this.gridColumn3.FieldName = "Dias";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 219;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Plazo";
            this.gridColumn10.FieldName = "cp_Plazo";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            this.gridColumn10.Width = 91;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Observación";
            this.gridColumn11.FieldName = "cp_Observacion";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 7;
            this.gridColumn11.Width = 240;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Entrega";
            this.gridColumn9.FieldName = "cp_PlazoEntrega";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            this.gridColumn9.Width = 78;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Correo";
            this.gridColumn12.FieldName = "pe_correo";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 3;
            this.gridColumn12.Width = 227;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Subtotal";
            this.gridColumn13.DisplayFormat.FormatString = "n2";
            this.gridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn13.FieldName = "Subtotal";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Subtotal", "{0:n2}")});
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 8;
            this.gridColumn13.Width = 84;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "I.V.A.";
            this.gridColumn14.DisplayFormat.FormatString = "n2";
            this.gridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn14.FieldName = "IVA";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", "{0:n2}")});
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 9;
            this.gridColumn14.Width = 84;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Total";
            this.gridColumn15.DisplayFormat.FormatString = "n2";
            this.gridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn15.FieldName = "Total";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}")});
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 10;
            this.gridColumn15.Width = 101;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "# Pedido";
            this.gridColumn16.FieldName = "IdOrdenPedido";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 0;
            this.gridColumn16.Width = 64;
            // 
            // txtFocus
            // 
            this.txtFocus.Location = new System.Drawing.Point(390, 1);
            this.txtFocus.Name = "txtFocus";
            this.txtFocus.Properties.ReadOnly = true;
            this.txtFocus.Size = new System.Drawing.Size(100, 22);
            this.txtFocus.TabIndex = 2;
            // 
            // FrmCom_OrdenPedidoCotizacionConfirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 611);
            this.Controls.Add(this.txtFocus);
            this.Controls.Add(this.gc_detalle);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "FrmCom_OrdenPedidoCotizacionConfirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar cotizaciones";
            this.Load += new System.EventHandler(this.FrmCom_OrdenPedidoCotizacionConfirma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Sucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Proveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_TerminoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFocus.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private DevExpress.XtraGrid.GridControl gc_detalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_Sucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_Proveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn col_TerminoPago;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_TerminoPago;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.TextEdit txtFocus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
    }
}