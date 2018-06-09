namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_MantenimientoCheques
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.gridControlMantenimientoCheques = new DevExpress.XtraGrid.GridControl();
            this.gridViewMantenimientoCheques = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltc_TipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbteCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Cheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_giradoA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado_cbte_ban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Estado_cbt_ban = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModificado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstado_Conciliacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dteHasta = new DevExpress.XtraEditors.DateEdit();
            this.dteDesde = new DevExpress.XtraEditors.DateEdit();
            this.cmb_Sucursal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Estado = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_cta_ban = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCtaBancaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_cbte_tipo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelPrincipal.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMantenimientoCheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMantenimientoCheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Estado_cbt_ban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteHasta.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDesde.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Sucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Estado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cta_ban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cbte_tipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelDetalle);
            this.panelPrincipal.Controls.Add(this.panelCabecera);
            this.panelPrincipal.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.panelPrincipal.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(896, 511);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelDetalle
            // 
            this.panelDetalle.Controls.Add(this.gridControlMantenimientoCheques);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalle.Location = new System.Drawing.Point(0, 114);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(896, 371);
            this.panelDetalle.TabIndex = 3;
            // 
            // gridControlMantenimientoCheques
            // 
            this.gridControlMantenimientoCheques.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMantenimientoCheques.Location = new System.Drawing.Point(0, 0);
            this.gridControlMantenimientoCheques.MainView = this.gridViewMantenimientoCheques;
            this.gridControlMantenimientoCheques.Name = "gridControlMantenimientoCheques";
            this.gridControlMantenimientoCheques.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_Estado_cbt_ban});
            this.gridControlMantenimientoCheques.Size = new System.Drawing.Size(896, 371);
            this.gridControlMantenimientoCheques.TabIndex = 0;
            this.gridControlMantenimientoCheques.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMantenimientoCheques});
            // 
            // gridViewMantenimientoCheques
            // 
            this.gridViewMantenimientoCheques.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltc_TipoCbte,
            this.colIdCbteCble,
            this.colcb_Cheque,
            this.colba_descripcion,
            this.colcb_giradoA,
            this.colcb_Fecha,
            this.colcb_Observacion,
            this.colcb_Valor,
            this.colIdEstado_cbte_ban,
            this.colModificado,
            this.ColEstado_Conciliacion});
            this.gridViewMantenimientoCheques.GridControl = this.gridControlMantenimientoCheques;
            this.gridViewMantenimientoCheques.Name = "gridViewMantenimientoCheques";
            this.gridViewMantenimientoCheques.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMantenimientoCheques.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewMantenimientoCheques_CellValueChanged);
            // 
            // coltc_TipoCbte
            // 
            this.coltc_TipoCbte.Caption = "Tipo cbte";
            this.coltc_TipoCbte.FieldName = "tc_TipoCbte";
            this.coltc_TipoCbte.Name = "coltc_TipoCbte";
            this.coltc_TipoCbte.Visible = true;
            this.coltc_TipoCbte.VisibleIndex = 0;
            this.coltc_TipoCbte.Width = 59;
            // 
            // colIdCbteCble
            // 
            this.colIdCbteCble.Caption = "# cbte";
            this.colIdCbteCble.FieldName = "IdCbteCble";
            this.colIdCbteCble.Name = "colIdCbteCble";
            this.colIdCbteCble.Visible = true;
            this.colIdCbteCble.VisibleIndex = 1;
            this.colIdCbteCble.Width = 46;
            // 
            // colcb_Cheque
            // 
            this.colcb_Cheque.Caption = "# cheque";
            this.colcb_Cheque.FieldName = "cb_Cheque";
            this.colcb_Cheque.Name = "colcb_Cheque";
            this.colcb_Cheque.Visible = true;
            this.colcb_Cheque.VisibleIndex = 2;
            this.colcb_Cheque.Width = 108;
            // 
            // colba_descripcion
            // 
            this.colba_descripcion.Caption = "cta Bancaria";
            this.colba_descripcion.FieldName = "ba_descripcion";
            this.colba_descripcion.Name = "colba_descripcion";
            this.colba_descripcion.Visible = true;
            this.colba_descripcion.VisibleIndex = 3;
            this.colba_descripcion.Width = 108;
            // 
            // colcb_giradoA
            // 
            this.colcb_giradoA.Caption = "Beneficiario";
            this.colcb_giradoA.FieldName = "cb_giradoA";
            this.colcb_giradoA.Name = "colcb_giradoA";
            this.colcb_giradoA.Visible = true;
            this.colcb_giradoA.VisibleIndex = 4;
            this.colcb_giradoA.Width = 143;
            // 
            // colcb_Fecha
            // 
            this.colcb_Fecha.Caption = "Fecha";
            this.colcb_Fecha.FieldName = "cb_Fecha";
            this.colcb_Fecha.Name = "colcb_Fecha";
            this.colcb_Fecha.Visible = true;
            this.colcb_Fecha.VisibleIndex = 5;
            this.colcb_Fecha.Width = 86;
            // 
            // colcb_Observacion
            // 
            this.colcb_Observacion.Caption = "Observación";
            this.colcb_Observacion.FieldName = "cb_Observacion";
            this.colcb_Observacion.Name = "colcb_Observacion";
            this.colcb_Observacion.Visible = true;
            this.colcb_Observacion.VisibleIndex = 6;
            this.colcb_Observacion.Width = 151;
            // 
            // colcb_Valor
            // 
            this.colcb_Valor.Caption = "Valor";
            this.colcb_Valor.FieldName = "cb_Valor";
            this.colcb_Valor.Name = "colcb_Valor";
            this.colcb_Valor.Visible = true;
            this.colcb_Valor.VisibleIndex = 7;
            this.colcb_Valor.Width = 80;
            // 
            // colIdEstado_cbte_ban
            // 
            this.colIdEstado_cbte_ban.Caption = "Estado";
            this.colIdEstado_cbte_ban.ColumnEdit = this.cmb_Estado_cbt_ban;
            this.colIdEstado_cbte_ban.FieldName = "IdEstado_Cbte_Ban_cat";
            this.colIdEstado_cbte_ban.Name = "colIdEstado_cbte_ban";
            this.colIdEstado_cbte_ban.Visible = true;
            this.colIdEstado_cbte_ban.VisibleIndex = 8;
            this.colIdEstado_cbte_ban.Width = 97;
            // 
            // cmb_Estado_cbt_ban
            // 
            this.cmb_Estado_cbt_ban.AutoHeight = false;
            this.cmb_Estado_cbt_ban.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Estado_cbt_ban.Name = "cmb_Estado_cbt_ban";
            this.cmb_Estado_cbt_ban.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNombre});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "IdEstado_cbte_ban";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 118;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Estado";
            this.colNombre.FieldName = "ca_descripcion";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 380;
            // 
            // colModificado
            // 
            this.colModificado.Caption = "*";
            this.colModificado.FieldName = "Modificado";
            this.colModificado.Name = "colModificado";
            // 
            // ColEstado_Conciliacion
            // 
            this.ColEstado_Conciliacion.Caption = "Estado Cheq.";
            this.ColEstado_Conciliacion.FieldName = "Estado_Conciliacion";
            this.ColEstado_Conciliacion.Name = "ColEstado_Conciliacion";
            this.ColEstado_Conciliacion.OptionsColumn.AllowEdit = false;
            this.ColEstado_Conciliacion.Visible = true;
            this.ColEstado_Conciliacion.VisibleIndex = 9;
            // 
            // panelCabecera
            // 
            this.panelCabecera.Controls.Add(this.btnBuscar);
            this.panelCabecera.Controls.Add(this.labelControl6);
            this.panelCabecera.Controls.Add(this.labelControl5);
            this.panelCabecera.Controls.Add(this.labelControl3);
            this.panelCabecera.Controls.Add(this.labelControl4);
            this.panelCabecera.Controls.Add(this.labelControl2);
            this.panelCabecera.Controls.Add(this.labelControl1);
            this.panelCabecera.Controls.Add(this.dteHasta);
            this.panelCabecera.Controls.Add(this.dteDesde);
            this.panelCabecera.Controls.Add(this.cmb_Sucursal);
            this.panelCabecera.Controls.Add(this.cmb_Estado);
            this.panelCabecera.Controls.Add(this.cmb_cta_ban);
            this.panelCabecera.Controls.Add(this.cmb_cbte_tipo);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 23);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(896, 91);
            this.panelCabecera.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(655, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 40);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 9);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Sucursal:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(283, 61);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Estado:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(283, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Cuenta bancaria:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(283, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Tipo cbte:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Hasta:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Desde:";
            // 
            // dteHasta
            // 
            this.dteHasta.EditValue = null;
            this.dteHasta.Location = new System.Drawing.Point(66, 58);
            this.dteHasta.Name = "dteHasta";
            this.dteHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteHasta.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteHasta.Size = new System.Drawing.Size(172, 20);
            this.dteHasta.TabIndex = 5;
            // 
            // dteDesde
            // 
            this.dteDesde.EditValue = null;
            this.dteDesde.Location = new System.Drawing.Point(66, 32);
            this.dteDesde.Name = "dteDesde";
            this.dteDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDesde.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteDesde.Size = new System.Drawing.Size(172, 20);
            this.dteDesde.TabIndex = 4;
            // 
            // cmb_Sucursal
            // 
            this.cmb_Sucursal.Location = new System.Drawing.Point(66, 6);
            this.cmb_Sucursal.Name = "cmb_Sucursal";
            this.cmb_Sucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Sucursal.Properties.DisplayMember = "Su_Descripcion2";
            this.cmb_Sucursal.Properties.NullText = "Todas";
            this.cmb_Sucursal.Properties.ValueMember = "IdSucursal";
            this.cmb_Sucursal.Properties.View = this.gridView4;
            this.cmb_Sucursal.Size = new System.Drawing.Size(172, 20);
            this.cmb_Sucursal.TabIndex = 3;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSucursal,
            this.colDescripcionSucursal});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.Caption = "ID";
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.Visible = true;
            this.colIdSucursal.VisibleIndex = 0;
            // 
            // colDescripcionSucursal
            // 
            this.colDescripcionSucursal.Caption = "Sucursal";
            this.colDescripcionSucursal.FieldName = "Su_Descripcion2";
            this.colDescripcionSucursal.Name = "colDescripcionSucursal";
            this.colDescripcionSucursal.Visible = true;
            this.colDescripcionSucursal.VisibleIndex = 1;
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.Location = new System.Drawing.Point(388, 58);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Estado.Properties.NullText = "Todos";
            this.cmb_Estado.Properties.View = this.gridView3;
            this.cmb_Estado.Size = new System.Drawing.Size(221, 20);
            this.cmb_Estado.TabIndex = 2;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEstado,
            this.colNombreEstado});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEstado
            // 
            this.colIdEstado.Caption = "ID";
            this.colIdEstado.FieldName = "IdEstado_cbte_ban";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 0;
            this.colIdEstado.Width = 247;
            // 
            // colNombreEstado
            // 
            this.colNombreEstado.Caption = "Estado";
            this.colNombreEstado.FieldName = "ca_descripcion";
            this.colNombreEstado.Name = "colNombreEstado";
            this.colNombreEstado.Visible = true;
            this.colNombreEstado.VisibleIndex = 1;
            this.colNombreEstado.Width = 933;
            // 
            // cmb_cta_ban
            // 
            this.cmb_cta_ban.Location = new System.Drawing.Point(388, 32);
            this.cmb_cta_ban.Name = "cmb_cta_ban";
            this.cmb_cta_ban.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_cta_ban.Properties.NullText = "Todas";
            this.cmb_cta_ban.Properties.View = this.gridView2;
            this.cmb_cta_ban.Size = new System.Drawing.Size(221, 20);
            this.cmb_cta_ban.TabIndex = 1;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdBanco,
            this.colCtaBancaria});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdBanco
            // 
            this.colIdBanco.Caption = "ID";
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.Visible = true;
            this.colIdBanco.VisibleIndex = 0;
            this.colIdBanco.Width = 184;
            // 
            // colCtaBancaria
            // 
            this.colCtaBancaria.Caption = "Cuenta bancaria";
            this.colCtaBancaria.FieldName = "ba_descripcion";
            this.colCtaBancaria.Name = "colCtaBancaria";
            this.colCtaBancaria.Visible = true;
            this.colCtaBancaria.VisibleIndex = 1;
            this.colCtaBancaria.Width = 996;
            // 
            // cmb_cbte_tipo
            // 
            this.cmb_cbte_tipo.Location = new System.Drawing.Point(388, 6);
            this.cmb_cbte_tipo.Name = "cmb_cbte_tipo";
            this.cmb_cbte_tipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_cbte_tipo.Properties.NullText = "Todos";
            this.cmb_cbte_tipo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_cbte_tipo.Size = new System.Drawing.Size(221, 20);
            this.cmb_cbte_tipo.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCbte,
            this.colComprobante});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCbte
            // 
            this.colIdCbte.Caption = "ID";
            this.colIdCbte.FieldName = "CodTipoCbteBan";
            this.colIdCbte.Name = "colIdCbte";
            this.colIdCbte.Visible = true;
            this.colIdCbte.VisibleIndex = 0;
            this.colIdCbte.Width = 230;
            // 
            // colComprobante
            // 
            this.colComprobante.Caption = "Comprobante";
            this.colComprobante.FieldName = "Descripcion";
            this.colComprobante.Name = "colComprobante";
            this.colComprobante.Visible = true;
            this.colComprobante.VisibleIndex = 1;
            this.colComprobante.Width = 950;
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
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(896, 23);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 1;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
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
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 485);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(896, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
            // 
            // FrmBA_MantenimientoCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 511);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "FrmBA_MantenimientoCheques";
            this.Text = "Mantenimiento de cheques";
            this.Load += new System.EventHandler(this.FrmBA_MantenimientoCheques_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMantenimientoCheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMantenimientoCheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Estado_cbt_ban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteHasta.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDesde.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Sucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Estado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cta_ban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cbte_tipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Panel panelCabecera;
        private DevExpress.XtraGrid.GridControl gridControlMantenimientoCheques;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMantenimientoCheques;
        private DevExpress.XtraEditors.DateEdit dteHasta;
        private DevExpress.XtraEditors.DateEdit dteDesde;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_Sucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_Estado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_cta_ban;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_cbte_tipo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_TipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Cheque;
        private DevExpress.XtraGrid.Columns.GridColumn colba_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_giradoA;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Valor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado_cbte_ban;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_Estado_cbt_ban;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colCtaBancaria;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colModificado;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstado_Conciliacion;
    }
}