namespace Core.Erp.Winform.Presupuesto
{
    partial class frmpre_presupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpre_presupuesto));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.prepresupuestoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.banedDatos = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.PREIdEmpresa = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.PREIdPresupuesto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.PRESecuencia = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.PRECodigoPresupuesto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.check = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.PREIdAnio = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.PREIdCtaCble = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridLookUpEditCtaCtble = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.ctPlanctaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCTA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Cuenta2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCblePadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Naturaleza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNivelCta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGrupoCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_EsMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_es_flujo_efectivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_clave_corta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Plancta_nivel_Info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREIdCentroCosto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridLookUpEditCentroCosto = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.ctCentrocostoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridCentroCosto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCostoPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costoPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PREIdTipoRubro = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridLookUpEditTipoRubro = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.prepresupuestotipoRubroInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridTipoRubro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PRECodRubro = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.PRENombreRubro = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.textEditNombreRubro = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.NombreRubro = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridLookUpEditNombreRubro = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.preNombreRubroInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridviewNombre = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.banedMeses = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colEnero = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.textValores = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colfebrero = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMarzo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAbril = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMayo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colJunio = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colJulio = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAgosto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSeptiembre = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOctubre = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNoviembre = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDiciembre = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTotal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.menuTipo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoRubroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.barra = new System.Windows.Forms.ToolStrip();
            this.btn_grabar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_grabarysalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnespacio2 = new System.Windows.Forms.ToolStripLabel();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtFocus = new System.Windows.Forms.TextBox();
            this.chConValores = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdPresupuesto = new System.Windows.Forms.TextBox();
            this.ultraCmb_Ano = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ultraCmb_Presupuesto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdanioFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepresupuestoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditCtaCtble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditCentroCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCentrocostoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCentroCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditTipoRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepresupuestotipoRubroInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNombreRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditNombreRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preNombreRubroInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textValores)).BeginInit();
            this.menuTipo.SuspendLayout();
            this.barra.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmb_Ano.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmb_Presupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.prepresupuestoInfoBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 91);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.GridLookUpEditCtaCtble,
            this.GridLookUpEditCentroCosto,
            this.GridLookUpEditTipoRubro,
            this.GridLookUpEditNombreRubro,
            this.textValores,
            this.textEditNombreRubro});
            this.gridControl.Size = new System.Drawing.Size(1112, 359);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridControl_MouseUp);
            // 
            // prepresupuestoInfoBindingSource
            // 
            this.prepresupuestoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Presupuesto.pre_presupuesto_Info);
            // 
            // gridView
            // 
            this.gridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.banedDatos,
            this.banedMeses});
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.PREIdEmpresa,
            this.PREIdPresupuesto,
            this.PREIdAnio,
            this.PRESecuencia,
            this.PRECodigoPresupuesto,
            this.PREIdCtaCble,
            this.PREIdCentroCosto,
            this.PREIdTipoRubro,
            this.PRECodRubro,
            this.PRENombreRubro,
            this.colEnero,
            this.colfebrero,
            this.colMarzo,
            this.colAbril,
            this.colMayo,
            this.colJunio,
            this.colJulio,
            this.colAgosto,
            this.colSeptiembre,
            this.colOctubre,
            this.colNoviembre,
            this.colDiciembre,
            this.colTotal,
            this.NombreRubro,
            this.check});
            this.gridView.CustomizationFormBounds = new System.Drawing.Rectangle(940, 405, 222, 214);
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsCustomization.AllowFilter = false;
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsMenu.EnableFooterMenu = false;
            this.gridView.OptionsPrint.AutoWidth = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.PREIdCtaCble, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.PREIdCentroCosto, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            this.gridView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanging);
            this.gridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView_MouseUp);
            // 
            // banedDatos
            // 
            this.banedDatos.Caption = "DATOS";
            this.banedDatos.Columns.Add(this.PREIdEmpresa);
            this.banedDatos.Columns.Add(this.PREIdPresupuesto);
            this.banedDatos.Columns.Add(this.PRESecuencia);
            this.banedDatos.Columns.Add(this.PRECodigoPresupuesto);
            this.banedDatos.Columns.Add(this.check);
            this.banedDatos.Columns.Add(this.PREIdAnio);
            this.banedDatos.Columns.Add(this.PREIdCtaCble);
            this.banedDatos.Columns.Add(this.PREIdCentroCosto);
            this.banedDatos.Columns.Add(this.PREIdTipoRubro);
            this.banedDatos.Columns.Add(this.PRECodRubro);
            this.banedDatos.Columns.Add(this.PRENombreRubro);
            this.banedDatos.Columns.Add(this.NombreRubro);
            this.banedDatos.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.banedDatos.Name = "banedDatos";
            this.banedDatos.Width = 761;
            // 
            // PREIdEmpresa
            // 
            this.PREIdEmpresa.FieldName = "IdEmpresa";
            this.PREIdEmpresa.Name = "PREIdEmpresa";
            this.PREIdEmpresa.OptionsColumn.AllowEdit = false;
            // 
            // PREIdPresupuesto
            // 
            this.PREIdPresupuesto.FieldName = "IdPresupuesto";
            this.PREIdPresupuesto.Name = "PREIdPresupuesto";
            this.PREIdPresupuesto.OptionsColumn.AllowEdit = false;
            this.PREIdPresupuesto.Width = 82;
            // 
            // PRESecuencia
            // 
            this.PRESecuencia.FieldName = "Secuencia";
            this.PRESecuencia.Name = "PRESecuencia";
            this.PRESecuencia.OptionsColumn.AllowEdit = false;
            // 
            // PRECodigoPresupuesto
            // 
            this.PRECodigoPresupuesto.FieldName = "CodigoPresupuesto";
            this.PRECodigoPresupuesto.Name = "PRECodigoPresupuesto";
            this.PRECodigoPresupuesto.OptionsColumn.AllowEdit = false;
            this.PRECodigoPresupuesto.Width = 105;
            // 
            // check
            // 
            this.check.Caption = "[-]";
            this.check.FieldName = "check";
            this.check.Name = "check";
            this.check.Visible = true;
            this.check.Width = 20;
            // 
            // PREIdAnio
            // 
            this.PREIdAnio.FieldName = "IdAnio";
            this.PREIdAnio.Name = "PREIdAnio";
            this.PREIdAnio.OptionsColumn.AllowEdit = false;
            this.PREIdAnio.Visible = true;
            // 
            // PREIdCtaCble
            // 
            this.PREIdCtaCble.ColumnEdit = this.GridLookUpEditCtaCtble;
            this.PREIdCtaCble.FieldName = "IdCtaCble";
            this.PREIdCtaCble.Name = "PREIdCtaCble";
            this.PREIdCtaCble.OptionsColumn.AllowEdit = false;
            this.PREIdCtaCble.Visible = true;
            this.PREIdCtaCble.Width = 159;
            // 
            // GridLookUpEditCtaCtble
            // 
            this.GridLookUpEditCtaCtble.AutoHeight = false;
            this.GridLookUpEditCtaCtble.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridLookUpEditCtaCtble.DataSource = this.ctPlanctaInfoBindingSource;
            this.GridLookUpEditCtaCtble.DisplayMember = "pc_Cuenta";
            this.GridLookUpEditCtaCtble.Name = "GridLookUpEditCtaCtble";
            this.GridLookUpEditCtaCtble.ValueMember = "IdCtaCble";
            this.GridLookUpEditCtaCtble.View = this.gridViewCTA;
            // 
            // ctPlanctaInfoBindingSource
            // 
            this.ctPlanctaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Plancta_Info);
            // 
            // gridViewCTA
            // 
            this.gridViewCTA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colpc_Cuenta,
            this.colpc_Cuenta2,
            this.colIdCtaCblePadre,
            this.colIdCatalogo,
            this.colpc_Naturaleza,
            this.colIdNivelCta,
            this.colIdGrupoCble,
            this.colpc_Estado,
            this.colpc_EsMovimiento,
            this.colpc_es_flujo_efectivo,
            this.colpc_clave_corta,
            this.col_Plancta_nivel_Info,
            this.colCuentaPadre});
            this.gridViewCTA.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewCTA.Name = "gridViewCTA";
            this.gridViewCTA.OptionsBehavior.Editable = false;
            this.gridViewCTA.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCTA.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCTA.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdEmpresa";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "IdCtaCble";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // colpc_Cuenta
            // 
            this.colpc_Cuenta.FieldName = "pc_Cuenta";
            this.colpc_Cuenta.Name = "colpc_Cuenta";
            this.colpc_Cuenta.Visible = true;
            this.colpc_Cuenta.VisibleIndex = 1;
            // 
            // colpc_Cuenta2
            // 
            this.colpc_Cuenta2.FieldName = "pc_Cuenta2";
            this.colpc_Cuenta2.Name = "colpc_Cuenta2";
            // 
            // colIdCtaCblePadre
            // 
            this.colIdCtaCblePadre.FieldName = "IdCtaCblePadre";
            this.colIdCtaCblePadre.Name = "colIdCtaCblePadre";
            // 
            // colIdCatalogo
            // 
            this.colIdCatalogo.FieldName = "IdCatalogo";
            this.colIdCatalogo.Name = "colIdCatalogo";
            // 
            // colpc_Naturaleza
            // 
            this.colpc_Naturaleza.FieldName = "pc_Naturaleza";
            this.colpc_Naturaleza.Name = "colpc_Naturaleza";
            // 
            // colIdNivelCta
            // 
            this.colIdNivelCta.FieldName = "IdNivelCta";
            this.colIdNivelCta.Name = "colIdNivelCta";
            // 
            // colIdGrupoCble
            // 
            this.colIdGrupoCble.FieldName = "IdGrupoCble";
            this.colIdGrupoCble.Name = "colIdGrupoCble";
            this.colIdGrupoCble.Visible = true;
            this.colIdGrupoCble.VisibleIndex = 2;
            // 
            // colpc_Estado
            // 
            this.colpc_Estado.FieldName = "pc_Estado";
            this.colpc_Estado.Name = "colpc_Estado";
            // 
            // colpc_EsMovimiento
            // 
            this.colpc_EsMovimiento.FieldName = "pc_EsMovimiento";
            this.colpc_EsMovimiento.Name = "colpc_EsMovimiento";
            // 
            // colpc_es_flujo_efectivo
            // 
            this.colpc_es_flujo_efectivo.FieldName = "pc_es_flujo_efectivo";
            this.colpc_es_flujo_efectivo.Name = "colpc_es_flujo_efectivo";
            // 
            // colpc_clave_corta
            // 
            this.colpc_clave_corta.FieldName = "pc_clave_corta";
            this.colpc_clave_corta.Name = "colpc_clave_corta";
            this.colpc_clave_corta.Visible = true;
            this.colpc_clave_corta.VisibleIndex = 3;
            // 
            // col_Plancta_nivel_Info
            // 
            this.col_Plancta_nivel_Info.FieldName = "_Plancta_nivel_Info";
            this.col_Plancta_nivel_Info.Name = "col_Plancta_nivel_Info";
            // 
            // colCuentaPadre
            // 
            this.colCuentaPadre.FieldName = "CuentaPadre";
            this.colCuentaPadre.Name = "colCuentaPadre";
            // 
            // PREIdCentroCosto
            // 
            this.PREIdCentroCosto.ColumnEdit = this.GridLookUpEditCentroCosto;
            this.PREIdCentroCosto.FieldName = "IdCentroCosto";
            this.PREIdCentroCosto.Name = "PREIdCentroCosto";
            this.PREIdCentroCosto.Visible = true;
            this.PREIdCentroCosto.Width = 129;
            // 
            // GridLookUpEditCentroCosto
            // 
            this.GridLookUpEditCentroCosto.AutoHeight = false;
            this.GridLookUpEditCentroCosto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridLookUpEditCentroCosto.DataSource = this.ctCentrocostoInfoBindingSource;
            this.GridLookUpEditCentroCosto.DisplayMember = "Centro_costo";
            this.GridLookUpEditCentroCosto.Name = "GridLookUpEditCentroCosto";
            this.GridLookUpEditCentroCosto.ValueMember = "IdCentroCosto";
            this.GridLookUpEditCentroCosto.View = this.gridCentroCosto;
            // 
            // ctCentrocostoInfoBindingSource
            // 
            this.ctCentrocostoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Centro_costo_Info);
            // 
            // gridCentroCosto
            // 
            this.gridCentroCosto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.colCentro_costo,
            this.colCentro_costo2,
            this.colIdCentroCostoPadre,
            this.gridColumn5,
            this.gridColumn6,
            this.colIdNivel,
            this.gridColumn7,
            this.colCodCentroCosto,
            this.colCentro_costoPadre,
            this.gridColumn8});
            this.gridCentroCosto.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridCentroCosto.Name = "gridCentroCosto";
            this.gridCentroCosto.OptionsBehavior.Editable = false;
            this.gridCentroCosto.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridCentroCosto.OptionsView.ShowAutoFilterRow = true;
            this.gridCentroCosto.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "IdEmpresa";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Id Centro Costo";
            this.gridColumn4.FieldName = "IdCentroCosto";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // colCentro_costo
            // 
            this.colCentro_costo.Caption = "Centro Costo";
            this.colCentro_costo.FieldName = "Centro_costo";
            this.colCentro_costo.Name = "colCentro_costo";
            this.colCentro_costo.Visible = true;
            this.colCentro_costo.VisibleIndex = 1;
            // 
            // colCentro_costo2
            // 
            this.colCentro_costo2.FieldName = "Centro_costo2";
            this.colCentro_costo2.Name = "colCentro_costo2";
            this.colCentro_costo2.Visible = true;
            this.colCentro_costo2.VisibleIndex = 2;
            // 
            // colIdCentroCostoPadre
            // 
            this.colIdCentroCostoPadre.FieldName = "IdCentroCostoPadre";
            this.colIdCentroCostoPadre.Name = "colIdCentroCostoPadre";
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "IdCatalogo";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "pc_EsMovimiento";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // colIdNivel
            // 
            this.colIdNivel.FieldName = "IdNivel";
            this.colIdNivel.Name = "colIdNivel";
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "pc_Estado";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // colCodCentroCosto
            // 
            this.colCodCentroCosto.FieldName = "CodCentroCosto";
            this.colCodCentroCosto.Name = "colCodCentroCosto";
            this.colCodCentroCosto.Visible = true;
            this.colCodCentroCosto.VisibleIndex = 3;
            // 
            // colCentro_costoPadre
            // 
            this.colCentro_costoPadre.FieldName = "Centro_costoPadre";
            this.colCentro_costoPadre.Name = "colCentro_costoPadre";
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "IdCtaCble";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // PREIdTipoRubro
            // 
            this.PREIdTipoRubro.Caption = "Tipo Rubro";
            this.PREIdTipoRubro.ColumnEdit = this.GridLookUpEditTipoRubro;
            this.PREIdTipoRubro.FieldName = "IdTipoRubro";
            this.PREIdTipoRubro.Name = "PREIdTipoRubro";
            this.PREIdTipoRubro.OptionsColumn.AllowEdit = false;
            this.PREIdTipoRubro.Visible = true;
            this.PREIdTipoRubro.Width = 67;
            // 
            // GridLookUpEditTipoRubro
            // 
            this.GridLookUpEditTipoRubro.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridLookUpEditTipoRubro.DataSource = this.prepresupuestotipoRubroInfoBindingSource;
            this.GridLookUpEditTipoRubro.DisplayMember = "Descripcion";
            this.GridLookUpEditTipoRubro.Name = "GridLookUpEditTipoRubro";
            this.GridLookUpEditTipoRubro.ValueMember = "IdTipoRubro";
            this.GridLookUpEditTipoRubro.View = this.gridTipoRubro;
            this.GridLookUpEditTipoRubro.EditValueChanged += new System.EventHandler(this.GridLookUpEditTipoRubro_EditValueChanged);
            // 
            // prepresupuestotipoRubroInfoBindingSource
            // 
            this.prepresupuestotipoRubroInfoBindingSource.DataSource = typeof(Core.Erp.Info.Presupuesto.pre_presupuesto_tipoRubro_Info);
            // 
            // gridTipoRubro
            // 
            this.gridTipoRubro.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridTipoRubro.Name = "gridTipoRubro";
            this.gridTipoRubro.OptionsBehavior.Editable = false;
            this.gridTipoRubro.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridTipoRubro.OptionsView.ShowGroupPanel = false;
            this.gridTipoRubro.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridTipoRubro_RowClick);
            // 
            // PRECodRubro
            // 
            this.PRECodRubro.FieldName = "CodRubro";
            this.PRECodRubro.Name = "PRECodRubro";
            this.PRECodRubro.OptionsColumn.AllowEdit = false;
            this.PRECodRubro.Visible = true;
            this.PRECodRubro.Width = 61;
            // 
            // PRENombreRubro
            // 
            this.PRENombreRubro.ColumnEdit = this.textEditNombreRubro;
            this.PRENombreRubro.FieldName = "NombreRubro";
            this.PRENombreRubro.Name = "PRENombreRubro";
            this.PRENombreRubro.Visible = true;
            this.PRENombreRubro.Width = 230;
            // 
            // textEditNombreRubro
            // 
            this.textEditNombreRubro.AutoHeight = false;
            this.textEditNombreRubro.Mask.EditMask = ".{0,50}";
            this.textEditNombreRubro.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditNombreRubro.Mask.ShowPlaceHolders = false;
            this.textEditNombreRubro.Name = "textEditNombreRubro";
            // 
            // NombreRubro
            // 
            this.NombreRubro.AppearanceCell.BackColor = System.Drawing.Color.Black;
            this.NombreRubro.AppearanceCell.BackColor2 = System.Drawing.Color.Black;
            this.NombreRubro.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.NombreRubro.AppearanceCell.Options.UseBackColor = true;
            this.NombreRubro.AppearanceCell.Options.UseForeColor = true;
            this.NombreRubro.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.NombreRubro.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.NombreRubro.AppearanceHeader.BorderColor = System.Drawing.Color.White;
            this.NombreRubro.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.NombreRubro.AppearanceHeader.Options.UseBackColor = true;
            this.NombreRubro.AppearanceHeader.Options.UseBorderColor = true;
            this.NombreRubro.AppearanceHeader.Options.UseForeColor = true;
            this.NombreRubro.Caption = "*.*";
            this.NombreRubro.ColumnEdit = this.GridLookUpEditNombreRubro;
            this.NombreRubro.Name = "NombreRubro";
            this.NombreRubro.OptionsColumn.AllowSize = false;
            this.NombreRubro.Visible = true;
            this.NombreRubro.Width = 20;
            // 
            // GridLookUpEditNombreRubro
            // 
            this.GridLookUpEditNombreRubro.Appearance.BackColor = System.Drawing.Color.Black;
            this.GridLookUpEditNombreRubro.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.GridLookUpEditNombreRubro.Appearance.BorderColor = System.Drawing.Color.Black;
            this.GridLookUpEditNombreRubro.Appearance.ForeColor = System.Drawing.Color.Black;
            this.GridLookUpEditNombreRubro.Appearance.Options.UseBackColor = true;
            this.GridLookUpEditNombreRubro.Appearance.Options.UseBorderColor = true;
            this.GridLookUpEditNombreRubro.Appearance.Options.UseForeColor = true;
            this.GridLookUpEditNombreRubro.AutoHeight = false;
            this.GridLookUpEditNombreRubro.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridLookUpEditNombreRubro.DataSource = this.preNombreRubroInfoBindingSource;
            this.GridLookUpEditNombreRubro.DisplayMember = "NombreCompleto";
            this.GridLookUpEditNombreRubro.Name = "GridLookUpEditNombreRubro";
            this.GridLookUpEditNombreRubro.ValueMember = "NombreCompleto";
            this.GridLookUpEditNombreRubro.View = this.gridviewNombre;
            // 
            // preNombreRubroInfoBindingSource
            // 
            this.preNombreRubroInfoBindingSource.DataSource = typeof(Core.Erp.Info.Presupuesto.pre_NombreRubro_Info);
            // 
            // gridviewNombre
            // 
            this.gridviewNombre.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.colId,
            this.colNombreCompleto});
            this.gridviewNombre.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridviewNombre.Name = "gridviewNombre";
            this.gridviewNombre.OptionsBehavior.Editable = false;
            this.gridviewNombre.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridviewNombre.OptionsView.ShowAutoFilterRow = true;
            this.gridviewNombre.OptionsView.ShowGroupPanel = false;
            this.gridviewNombre.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridviewNombre_RowClick);
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "IdEmpresa";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 40;
            // 
            // colNombreCompleto
            // 
            this.colNombreCompleto.FieldName = "NombreCompleto";
            this.colNombreCompleto.Name = "colNombreCompleto";
            this.colNombreCompleto.Visible = true;
            this.colNombreCompleto.VisibleIndex = 1;
            this.colNombreCompleto.Width = 344;
            // 
            // banedMeses
            // 
            this.banedMeses.AutoFillDown = false;
            this.banedMeses.Caption = "MESES";
            this.banedMeses.Columns.Add(this.colEnero);
            this.banedMeses.Columns.Add(this.colfebrero);
            this.banedMeses.Columns.Add(this.colMarzo);
            this.banedMeses.Columns.Add(this.colAbril);
            this.banedMeses.Columns.Add(this.colMayo);
            this.banedMeses.Columns.Add(this.colJunio);
            this.banedMeses.Columns.Add(this.colJulio);
            this.banedMeses.Columns.Add(this.colAgosto);
            this.banedMeses.Columns.Add(this.colSeptiembre);
            this.banedMeses.Columns.Add(this.colOctubre);
            this.banedMeses.Columns.Add(this.colNoviembre);
            this.banedMeses.Columns.Add(this.colDiciembre);
            this.banedMeses.Columns.Add(this.colTotal);
            this.banedMeses.Name = "banedMeses";
            this.banedMeses.Width = 664;
            // 
            // colEnero
            // 
            this.colEnero.ColumnEdit = this.textValores;
            this.colEnero.FieldName = "Enero";
            this.colEnero.Name = "colEnero";
            this.colEnero.Visible = true;
            this.colEnero.Width = 44;
            // 
            // textValores
            // 
            this.textValores.AutoHeight = false;
            this.textValores.Mask.EditMask = "c2";
            this.textValores.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textValores.Name = "textValores";
            // 
            // colfebrero
            // 
            this.colfebrero.ColumnEdit = this.textValores;
            this.colfebrero.FieldName = "febrero";
            this.colfebrero.Name = "colfebrero";
            this.colfebrero.Visible = true;
            this.colfebrero.Width = 45;
            // 
            // colMarzo
            // 
            this.colMarzo.ColumnEdit = this.textValores;
            this.colMarzo.FieldName = "Marzo";
            this.colMarzo.Name = "colMarzo";
            this.colMarzo.Visible = true;
            this.colMarzo.Width = 44;
            // 
            // colAbril
            // 
            this.colAbril.ColumnEdit = this.textValores;
            this.colAbril.FieldName = "Abril";
            this.colAbril.Name = "colAbril";
            this.colAbril.Visible = true;
            this.colAbril.Width = 44;
            // 
            // colMayo
            // 
            this.colMayo.ColumnEdit = this.textValores;
            this.colMayo.FieldName = "Mayo";
            this.colMayo.Name = "colMayo";
            this.colMayo.Visible = true;
            this.colMayo.Width = 44;
            // 
            // colJunio
            // 
            this.colJunio.ColumnEdit = this.textValores;
            this.colJunio.FieldName = "Junio";
            this.colJunio.Name = "colJunio";
            this.colJunio.Visible = true;
            this.colJunio.Width = 44;
            // 
            // colJulio
            // 
            this.colJulio.ColumnEdit = this.textValores;
            this.colJulio.FieldName = "Julio";
            this.colJulio.Name = "colJulio";
            this.colJulio.Visible = true;
            this.colJulio.Width = 44;
            // 
            // colAgosto
            // 
            this.colAgosto.ColumnEdit = this.textValores;
            this.colAgosto.FieldName = "Agosto";
            this.colAgosto.Name = "colAgosto";
            this.colAgosto.Visible = true;
            this.colAgosto.Width = 44;
            // 
            // colSeptiembre
            // 
            this.colSeptiembre.ColumnEdit = this.textValores;
            this.colSeptiembre.FieldName = "Septiembre";
            this.colSeptiembre.Name = "colSeptiembre";
            this.colSeptiembre.Visible = true;
            this.colSeptiembre.Width = 63;
            // 
            // colOctubre
            // 
            this.colOctubre.ColumnEdit = this.textValores;
            this.colOctubre.FieldName = "Octubre";
            this.colOctubre.Name = "colOctubre";
            this.colOctubre.Visible = true;
            this.colOctubre.Width = 48;
            // 
            // colNoviembre
            // 
            this.colNoviembre.ColumnEdit = this.textValores;
            this.colNoviembre.FieldName = "Noviembre";
            this.colNoviembre.Name = "colNoviembre";
            this.colNoviembre.Visible = true;
            this.colNoviembre.Width = 60;
            // 
            // colDiciembre
            // 
            this.colDiciembre.ColumnEdit = this.textValores;
            this.colDiciembre.FieldName = "Diciembre";
            this.colDiciembre.Name = "colDiciembre";
            this.colDiciembre.Visible = true;
            this.colDiciembre.Width = 55;
            // 
            // colTotal
            // 
            this.colTotal.ColumnEdit = this.textValores;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.Visible = true;
            this.colTotal.Width = 85;
            // 
            // menuTipo
            // 
            this.menuTipo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRubroToolStripMenuItem});
            this.menuTipo.Name = "menuTipo";
            this.menuTipo.Size = new System.Drawing.Size(145, 26);
            // 
            // nuevoRubroToolStripMenuItem
            // 
            this.nuevoRubroToolStripMenuItem.Name = "nuevoRubroToolStripMenuItem";
            this.nuevoRubroToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.nuevoRubroToolStripMenuItem.Text = "Nuevo Rubro";
            this.nuevoRubroToolStripMenuItem.Click += new System.EventHandler(this.nuevoRubroToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Presupuesto:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(655, 45);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 16;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // barra
            // 
            this.barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_grabar,
            this.toolStripSeparator1,
            this.btn_grabarysalir,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripLabel1,
            this.btnespacio2,
            this.btnSalir,
            this.toolStripSeparator3,
            this.toolStripLabel2});
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(1112, 25);
            this.barra.TabIndex = 17;
            this.barra.Text = "Barra";
            // 
            // btn_grabar
            // 
            this.btn_grabar.Image = ((System.Drawing.Image)(resources.GetObject("btn_grabar.Image")));
            this.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(62, 22);
            this.btn_grabar.Tag = "2";
            this.btn_grabar.Text = "Grabar";
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_grabarysalir
            // 
            this.btn_grabarysalir.Image = ((System.Drawing.Image)(resources.GetObject("btn_grabarysalir.Image")));
            this.btn_grabarysalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_grabarysalir.Name = "btn_grabarysalir";
            this.btn_grabarysalir.Size = new System.Drawing.Size(96, 22);
            this.btn_grabarysalir.Tag = "3";
            this.btn_grabarysalir.Text = "Grabar y Salir";
            this.btn_grabarysalir.Click += new System.EventHandler(this.btn_grabarysalir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Core.Erp.Winform.Properties.Resources.FormEdit;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(97, 22);
            this.toolStripButton1.Text = "Nuevo Rubro";
            this.toolStripButton1.Click += new System.EventHandler(this.nuevoRubroToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(121, 22);
            this.toolStripLabel1.Text = "                                      ";
            // 
            // btnespacio2
            // 
            this.btnespacio2.Name = "btnespacio2";
            this.btnespacio2.Size = new System.Drawing.Size(73, 22);
            this.btnespacio2.Text = "                      ";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Tag = "8";
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(584, 22);
            this.toolStripLabel2.Text = "                                                                                 " +
    "                                                                                " +
    "   V 05092013 1001";
            // 
            // txtFocus
            // 
            this.txtFocus.Location = new System.Drawing.Point(488, -31);
            this.txtFocus.Name = "txtFocus";
            this.txtFocus.Size = new System.Drawing.Size(100, 20);
            this.txtFocus.TabIndex = 19;
            // 
            // chConValores
            // 
            this.chConValores.AutoSize = true;
            this.chConValores.Location = new System.Drawing.Point(752, 48);
            this.chConValores.Name = "chConValores";
            this.chConValores.Size = new System.Drawing.Size(120, 17);
            this.chConValores.TabIndex = 20;
            this.chConValores.Text = "Mostrar con Valores";
            this.chConValores.UseVisualStyleBackColor = true;
            this.chConValores.CheckedChanged += new System.EventHandler(this.chConValores_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ultraCmb_Presupuesto);
            this.panel1.Controls.Add(this.ultraCmb_Ano);
            this.panel1.Controls.Add(this.txtIdPresupuesto);
            this.panel1.Controls.Add(this.chConValores);
            this.panel1.Controls.Add(this.txtFocus);
            this.panel1.Controls.Add(this.barra);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 91);
            this.panel1.TabIndex = 0;
            // 
            // txtIdPresupuesto
            // 
            this.txtIdPresupuesto.Location = new System.Drawing.Point(629, -29);
            this.txtIdPresupuesto.Name = "txtIdPresupuesto";
            this.txtIdPresupuesto.ReadOnly = true;
            this.txtIdPresupuesto.Size = new System.Drawing.Size(100, 20);
            this.txtIdPresupuesto.TabIndex = 23;
            // 
            // ultraCmb_Ano
            // 
            this.ultraCmb_Ano.Location = new System.Drawing.Point(87, 47);
            this.ultraCmb_Ano.Name = "ultraCmb_Ano";
            this.ultraCmb_Ano.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraCmb_Ano.Properties.DisplayMember = "IdanioFiscal";
            this.ultraCmb_Ano.Properties.ValueMember = "IdanioFiscal";
            this.ultraCmb_Ano.Properties.View = this.searchLookUpEdit1View;
            this.ultraCmb_Ano.Size = new System.Drawing.Size(181, 20);
            this.ultraCmb_Ano.TabIndex = 24;
            this.ultraCmb_Ano.EditValueChanged += new System.EventHandler(this.ultraCmb_Ano_EditValueChanged);
            this.ultraCmb_Ano.Validating += new System.ComponentModel.CancelEventHandler(this.ultraCmb_Ano_Validating_1);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdanioFiscal});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ultraCmb_Presupuesto
            // 
            this.ultraCmb_Presupuesto.Location = new System.Drawing.Point(369, 48);
            this.ultraCmb_Presupuesto.Name = "ultraCmb_Presupuesto";
            this.ultraCmb_Presupuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraCmb_Presupuesto.Properties.DisplayMember = "IdPresupuesto";
            this.ultraCmb_Presupuesto.Properties.ValueMember = "IdPresupuesto";
            this.ultraCmb_Presupuesto.Properties.View = this.gridView1;
            this.ultraCmb_Presupuesto.Size = new System.Drawing.Size(181, 20);
            this.ultraCmb_Presupuesto.TabIndex = 25;
            this.ultraCmb_Presupuesto.Validating += new System.ComponentModel.CancelEventHandler(this.ultraCmb_Presupuesto_Validating_1);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPresupuesto});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdanioFiscal
            // 
            this.colIdanioFiscal.Caption = "Id";
            this.colIdanioFiscal.FieldName = "IdanioFiscal";
            this.colIdanioFiscal.Name = "colIdanioFiscal";
            this.colIdanioFiscal.Visible = true;
            this.colIdanioFiscal.VisibleIndex = 0;
            // 
            // colIdPresupuesto
            // 
            this.colIdPresupuesto.Caption = "Id";
            this.colIdPresupuesto.FieldName = "IdPresupuesto";
            this.colIdPresupuesto.Name = "colIdPresupuesto";
            this.colIdPresupuesto.Visible = true;
            this.colIdPresupuesto.VisibleIndex = 0;
            // 
            // frmpre_presupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 450);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panel1);
            this.Name = "frmpre_presupuesto";
            this.Text = "Presupuesto por Año";
            this.Load += new System.EventHandler(this.frmpre_presupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepresupuestoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditCtaCtble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditCentroCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCentrocostoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCentroCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditTipoRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepresupuestotipoRubroInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNombreRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditNombreRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preNombreRubroInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textValores)).EndInit();
            this.menuTipo.ResumeLayout(false);
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmb_Ano.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmb_Presupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.BindingSource prepresupuestoInfoBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit GridLookUpEditCtaCtble;
        private System.Windows.Forms.BindingSource ctPlanctaInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCTA;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCblePadre;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Naturaleza;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNivelCta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupoCble;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_EsMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_es_flujo_efectivo;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_clave_corta;
        private DevExpress.XtraGrid.Columns.GridColumn col_Plancta_nivel_Info;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaPadre;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit GridLookUpEditCentroCosto;
        private System.Windows.Forms.BindingSource ctCentrocostoInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCostoPadre;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNivel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn colCodCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costoPadre;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit GridLookUpEditTipoRubro;
        private System.Windows.Forms.BindingSource prepresupuestotipoRubroInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTipoRubro;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit GridLookUpEditNombreRubro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridviewNombre;
        private System.Windows.Forms.BindingSource preNombreRubroInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompleto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridView;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn PREIdEmpresa;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn PREIdPresupuesto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn PREIdAnio;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn PRESecuencia;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn PRECodigoPresupuesto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn PREIdCtaCble;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn PREIdCentroCosto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn PREIdTipoRubro;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn PRECodRubro;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn PRENombreRubro;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEnero;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colfebrero;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMarzo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAbril;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMayo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colJunio;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colJulio;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAgosto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSeptiembre;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOctubre;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNoviembre;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDiciembre;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTotal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn NombreRubro;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn check;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand banedDatos;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand banedMeses;
        private System.Windows.Forms.ContextMenuStrip menuTipo;
        private System.Windows.Forms.ToolStripMenuItem nuevoRubroToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ToolStrip barra;
        private System.Windows.Forms.ToolStripButton btn_grabar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_grabarysalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel btnespacio2;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.TextBox txtFocus;
        private System.Windows.Forms.CheckBox chConValores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdPresupuesto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textValores;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditNombreRubro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private DevExpress.XtraEditors.SearchLookUpEdit ultraCmb_Presupuesto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit ultraCmb_Ano;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdanioFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupuesto;
    }
}