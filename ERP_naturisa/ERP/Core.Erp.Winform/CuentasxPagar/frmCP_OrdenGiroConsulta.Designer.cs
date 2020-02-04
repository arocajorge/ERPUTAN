namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_OrdenGiroConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCP_OrdenGiroConsulta));
            this.gridControlOG = new DevExpress.XtraGrid.GridControl();
            this.UltraGrid_OrdenGiro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCbteCble_Ogiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_fechaOg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_FechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_subtotal_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_subtotal_siniva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_baseImponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colre_NumRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado_Cancelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_valoriva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_Retencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tipo_flujo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_tipo_flujo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tiene_ingresos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_tiene_ingresos = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.lst_img = new System.Windows.Forms.ImageList(this.components);
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_imprimir = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Winform.frmGe_Esperar), true, true);
            this.ucGe_Menu_Mantenimiento_x_usuario1 = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_OrdenGiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_flujo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tiene_ingresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlOG
            // 
            this.gridControlOG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOG.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlOG.Location = new System.Drawing.Point(2, 2);
            this.gridControlOG.MainView = this.UltraGrid_OrdenGiro;
            this.gridControlOG.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlOG.Name = "gridControlOG";
            this.gridControlOG.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_tipo_flujo,
            this.cmb_tiene_ingresos,
            this.cmb_imprimir});
            this.gridControlOG.Size = new System.Drawing.Size(1599, 337);
            this.gridControlOG.TabIndex = 14;
            this.gridControlOG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGrid_OrdenGiro});
            // 
            // UltraGrid_OrdenGiro
            // 
            this.UltraGrid_OrdenGiro.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCbteCble_Ogiro,
            this.colco_fechaOg,
            this.colco_factura,
            this.colco_FechaFactura,
            this.colNomProveedor,
            this.colco_observacion,
            this.colco_subtotal_iva,
            this.colco_subtotal_siniva,
            this.colco_baseImponible,
            this.colEstado,
            this.colre_NumRetencion,
            this.colEstado_Cancelacion,
            this.colTotal,
            this.colSaldo,
            this.colco_valoriva,
            this.colTotal_Retencion,
            this.col_tipo_flujo,
            this.gridColumn5,
            this.col_tiene_ingresos,
            this.gridColumn6,
            this.gridColumn7});
            this.UltraGrid_OrdenGiro.CustomizationFormBounds = new System.Drawing.Rectangle(519, 397, 216, 178);
            this.UltraGrid_OrdenGiro.GridControl = this.gridControlOG;
            this.UltraGrid_OrdenGiro.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "co_total", this.colTotal, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "saldo", this.colSaldo, "{0:c2}")});
            this.UltraGrid_OrdenGiro.Images = this.lst_img;
            this.UltraGrid_OrdenGiro.Name = "UltraGrid_OrdenGiro";
            this.UltraGrid_OrdenGiro.OptionsView.ShowAutoFilterRow = true;
            this.UltraGrid_OrdenGiro.OptionsView.ShowGroupPanel = false;
            this.UltraGrid_OrdenGiro.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdCbteCble_Ogiro, DevExpress.Data.ColumnSortOrder.Descending)});
            this.UltraGrid_OrdenGiro.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.UltraGrid_OrdenGiro_RowCellClick);
            this.UltraGrid_OrdenGiro.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.UltraGrid_OrdenGiro_RowCellStyle);
            this.UltraGrid_OrdenGiro.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.UltraGrid_OrdenGiro_FocusedRowChanged);
            this.UltraGrid_OrdenGiro.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.UltraGrid_OrdenGiro_CellValueChanged);
            this.UltraGrid_OrdenGiro.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.UltraGrid_OrdenGiro_CellValueChanging);
            // 
            // colIdCbteCble_Ogiro
            // 
            this.colIdCbteCble_Ogiro.Caption = "#Cbte";
            this.colIdCbteCble_Ogiro.FieldName = "IdCbteCble_Ogiro";
            this.colIdCbteCble_Ogiro.Name = "colIdCbteCble_Ogiro";
            this.colIdCbteCble_Ogiro.OptionsColumn.AllowEdit = false;
            this.colIdCbteCble_Ogiro.OptionsColumn.ReadOnly = true;
            this.colIdCbteCble_Ogiro.OptionsFilter.AllowFilter = false;
            this.colIdCbteCble_Ogiro.Visible = true;
            this.colIdCbteCble_Ogiro.VisibleIndex = 0;
            this.colIdCbteCble_Ogiro.Width = 70;
            // 
            // colco_fechaOg
            // 
            this.colco_fechaOg.Caption = "Fecha Comp. CxP";
            this.colco_fechaOg.FieldName = "co_fechaOg";
            this.colco_fechaOg.Name = "colco_fechaOg";
            this.colco_fechaOg.OptionsColumn.AllowEdit = false;
            this.colco_fechaOg.OptionsColumn.ReadOnly = true;
            this.colco_fechaOg.Width = 110;
            // 
            // colco_factura
            // 
            this.colco_factura.Caption = "# Documento";
            this.colco_factura.FieldName = "co_factura";
            this.colco_factura.Name = "colco_factura";
            this.colco_factura.OptionsColumn.AllowEdit = false;
            this.colco_factura.OptionsColumn.ReadOnly = true;
            this.colco_factura.Visible = true;
            this.colco_factura.VisibleIndex = 1;
            this.colco_factura.Width = 131;
            // 
            // colco_FechaFactura
            // 
            this.colco_FechaFactura.Caption = "Fecha Documento";
            this.colco_FechaFactura.FieldName = "co_FechaFactura";
            this.colco_FechaFactura.Name = "colco_FechaFactura";
            this.colco_FechaFactura.OptionsColumn.AllowEdit = false;
            this.colco_FechaFactura.OptionsColumn.ReadOnly = true;
            this.colco_FechaFactura.Visible = true;
            this.colco_FechaFactura.VisibleIndex = 2;
            this.colco_FechaFactura.Width = 131;
            // 
            // colNomProveedor
            // 
            this.colNomProveedor.Caption = "Proveedor";
            this.colNomProveedor.FieldName = "pr_nombre";
            this.colNomProveedor.Name = "colNomProveedor";
            this.colNomProveedor.OptionsColumn.AllowEdit = false;
            this.colNomProveedor.OptionsColumn.ReadOnly = true;
            this.colNomProveedor.Visible = true;
            this.colNomProveedor.VisibleIndex = 3;
            this.colNomProveedor.Width = 196;
            // 
            // colco_observacion
            // 
            this.colco_observacion.Caption = "Observación";
            this.colco_observacion.FieldName = "co_observacion";
            this.colco_observacion.Name = "colco_observacion";
            this.colco_observacion.OptionsColumn.AllowEdit = false;
            this.colco_observacion.OptionsColumn.ReadOnly = true;
            this.colco_observacion.Visible = true;
            this.colco_observacion.VisibleIndex = 4;
            this.colco_observacion.Width = 261;
            // 
            // colco_subtotal_iva
            // 
            this.colco_subtotal_iva.Caption = "Subtotal IVA";
            this.colco_subtotal_iva.DisplayFormat.FormatString = "n2";
            this.colco_subtotal_iva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colco_subtotal_iva.FieldName = "co_subtotal_iva";
            this.colco_subtotal_iva.Name = "colco_subtotal_iva";
            this.colco_subtotal_iva.OptionsColumn.AllowEdit = false;
            this.colco_subtotal_iva.OptionsColumn.ReadOnly = true;
            this.colco_subtotal_iva.Width = 81;
            // 
            // colco_subtotal_siniva
            // 
            this.colco_subtotal_siniva.Caption = "Subtotal sin IVA";
            this.colco_subtotal_siniva.DisplayFormat.FormatString = "n2";
            this.colco_subtotal_siniva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colco_subtotal_siniva.FieldName = "co_subtotal_siniva";
            this.colco_subtotal_siniva.Name = "colco_subtotal_siniva";
            this.colco_subtotal_siniva.OptionsColumn.AllowEdit = false;
            this.colco_subtotal_siniva.OptionsColumn.ReadOnly = true;
            this.colco_subtotal_siniva.Width = 101;
            // 
            // colco_baseImponible
            // 
            this.colco_baseImponible.Caption = "Base Imponible";
            this.colco_baseImponible.DisplayFormat.FormatString = "n2";
            this.colco_baseImponible.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colco_baseImponible.FieldName = "co_baseImponible";
            this.colco_baseImponible.Name = "colco_baseImponible";
            this.colco_baseImponible.OptionsColumn.AllowEdit = false;
            this.colco_baseImponible.OptionsColumn.ReadOnly = true;
            this.colco_baseImponible.Width = 91;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.ReadOnly = true;
            this.colEstado.Width = 84;
            // 
            // colre_NumRetencion
            // 
            this.colre_NumRetencion.FieldName = "re_NumRetencion";
            this.colre_NumRetencion.Name = "colre_NumRetencion";
            this.colre_NumRetencion.OptionsColumn.ReadOnly = true;
            // 
            // colEstado_Cancelacion
            // 
            this.colEstado_Cancelacion.Caption = "Estado de Cancelacion";
            this.colEstado_Cancelacion.FieldName = "Estado_Cancelacion";
            this.colEstado_Cancelacion.Name = "colEstado_Cancelacion";
            this.colEstado_Cancelacion.OptionsColumn.ReadOnly = true;
            this.colEstado_Cancelacion.Visible = true;
            this.colEstado_Cancelacion.VisibleIndex = 8;
            this.colEstado_Cancelacion.Width = 68;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "n2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "co_total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 88;
            // 
            // colSaldo
            // 
            this.colSaldo.Caption = "Saldo";
            this.colSaldo.DisplayFormat.FormatString = "n2";
            this.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaldo.FieldName = "saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.OptionsColumn.ReadOnly = true;
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 6;
            this.colSaldo.Width = 98;
            // 
            // colco_valoriva
            // 
            this.colco_valoriva.Caption = "IVA";
            this.colco_valoriva.DisplayFormat.FormatString = "n2";
            this.colco_valoriva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colco_valoriva.FieldName = "co_valoriva";
            this.colco_valoriva.Name = "colco_valoriva";
            // 
            // colTotal_Retencion
            // 
            this.colTotal_Retencion.Caption = "Total Reten.";
            this.colTotal_Retencion.DisplayFormat.FormatString = "n2";
            this.colTotal_Retencion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal_Retencion.FieldName = "Total_Retencion";
            this.colTotal_Retencion.Name = "colTotal_Retencion";
            this.colTotal_Retencion.Visible = true;
            this.colTotal_Retencion.VisibleIndex = 7;
            this.colTotal_Retencion.Width = 80;
            // 
            // col_tipo_flujo
            // 
            this.col_tipo_flujo.Caption = "Tipo flujo";
            this.col_tipo_flujo.ColumnEdit = this.cmb_tipo_flujo;
            this.col_tipo_flujo.FieldName = "IdTipoFlujo";
            this.col_tipo_flujo.Name = "col_tipo_flujo";
            this.col_tipo_flujo.Visible = true;
            this.col_tipo_flujo.VisibleIndex = 9;
            this.col_tipo_flujo.Width = 244;
            // 
            // cmb_tipo_flujo
            // 
            this.cmb_tipo_flujo.AutoHeight = false;
            this.cmb_tipo_flujo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipo_flujo.DisplayMember = "Descricion2";
            this.cmb_tipo_flujo.Name = "cmb_tipo_flujo";
            this.cmb_tipo_flujo.ValueMember = "IdTipoFlujo";
            this.cmb_tipo_flujo.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdTipoFlujo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 93;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Flujo";
            this.gridColumn2.FieldName = "Descricion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 798;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tipo";
            this.gridColumn3.FieldName = "Tipo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 170;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Código";
            this.gridColumn4.FieldName = "cod_flujo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 119;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Clase proveedor";
            this.gridColumn5.FieldName = "descripcion_clas_prove";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // col_tiene_ingresos
            // 
            this.col_tiene_ingresos.Caption = "Ingresos";
            this.col_tiene_ingresos.ColumnEdit = this.cmb_tiene_ingresos;
            this.col_tiene_ingresos.FieldName = "Tiene_ingresos";
            this.col_tiene_ingresos.Name = "col_tiene_ingresos";
            this.col_tiene_ingresos.Width = 65;
            // 
            // cmb_tiene_ingresos
            // 
            this.cmb_tiene_ingresos.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_tiene_ingresos.AutoHeight = false;
            this.cmb_tiene_ingresos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tiene_ingresos.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_tiene_ingresos.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.cmb_tiene_ingresos.Name = "cmb_tiene_ingresos";
            this.cmb_tiene_ingresos.ReadOnly = true;
            this.cmb_tiene_ingresos.SmallImages = this.lst_img;
            this.cmb_tiene_ingresos.Click += new System.EventHandler(this.cmb_tiene_ingresos_Click);
            // 
            // lst_img
            // 
            this.lst_img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lst_img.ImageStream")));
            this.lst_img.TransparentColor = System.Drawing.Color.Transparent;
            this.lst_img.Images.SetKeyName(0, "1388723697_1710.ico");
            this.lst_img.Images.SetKeyName(1, "imprimir_16x16.png");
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "De caja";
            this.gridColumn6.ColumnEdit = this.cmb_tiene_ingresos;
            this.gridColumn6.FieldName = "En_conciliacion";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Width = 61;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Imprimir";
            this.gridColumn7.ColumnEdit = this.cmb_imprimir;
            this.gridColumn7.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn7.ImageIndex = 1;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 10;
            this.gridColumn7.Width = 88;
            // 
            // cmb_imprimir
            // 
            this.cmb_imprimir.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_imprimir.AutoHeight = false;
            this.cmb_imprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_imprimir.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_imprimir.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, 1)});
            this.cmb_imprimir.LargeImages = this.lst_img;
            this.cmb_imprimir.Name = "cmb_imprimir";
            this.cmb_imprimir.ReadOnly = true;
            this.cmb_imprimir.Click += new System.EventHandler(this.cmb_imprimir_Click);
            // 
            // ucGe_Menu_Mantenimiento_x_usuario1
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasSucursales = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde = new System.DateTime(2018, 7, 3, 17, 12, 13, 918);
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta = new System.DateTime(2018, 9, 3, 17, 12, 13, 918);
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Location = new System.Drawing.Point(2, 2);
            this.ucGe_Menu_Mantenimiento_x_usuario1.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_Menu_Mantenimiento_x_usuario1.Name = "ucGe_Menu_Mantenimiento_x_usuario1";
            this.ucGe_Menu_Mantenimiento_x_usuario1.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Size = new System.Drawing.Size(1599, 181);
            this.ucGe_Menu_Mantenimiento_x_usuario1.TabIndex = 17;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1603, 185);
            this.panelControl1.TabIndex = 18;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlOG);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 185);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1603, 341);
            this.panelControl2.TabIndex = 19;
            // 
            // frmCP_OrdenGiroConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 526);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCP_OrdenGiroConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Facturas de Proveedores";
            this.Load += new System.EventHandler(this.frmCP_OrdenGiroConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_OrdenGiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_flujo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tiene_ingresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

      
        private DevExpress.XtraGrid.GridControl gridControlOG;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGrid_OrdenGiro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble_Ogiro;
        private DevExpress.XtraGrid.Columns.GridColumn colNomProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colco_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colco_FechaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colco_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colco_subtotal_iva;
        private DevExpress.XtraGrid.Columns.GridColumn colco_subtotal_siniva;
        private DevExpress.XtraGrid.Columns.GridColumn colco_baseImponible;
        private DevExpress.XtraGrid.Columns.GridColumn colco_fechaOg;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colre_NumRetencion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_Cancelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colco_valoriva;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_Retencion;
        private DevExpress.XtraGrid.Columns.GridColumn col_tipo_flujo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_tipo_flujo;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn col_tiene_ingresos;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_tiene_ingresos;
        private System.Windows.Forms.ImageList lst_img;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_imprimir;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}