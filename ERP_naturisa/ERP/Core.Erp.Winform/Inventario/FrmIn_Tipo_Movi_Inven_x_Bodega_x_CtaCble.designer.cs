namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Tipo_Movi_Inven_x_Bodega_x_CtaCble
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
            this.tbBodegaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colbo_Descripcion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colip = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.cmbCuentaContable = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.ctPlanctaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpc_Cuenta2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl_movi_inven = new DevExpress.XtraGrid.GridControl();
            this.inmoviinventipoInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_movi_inven = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colChek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovi_inven_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTipoMovi = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.inmoviinventipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inmoviinventipoxtbbodegaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.tbBodegaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCuentaContable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_movi_inven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinventipoInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_movi_inven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoMovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinventipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinventipoxtbbodegaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBodegaInfoBindingSource
            // 
            this.tbBodegaInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Bodega_Info);
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colbo_Descripcion,
            this.colip});
            this.treeList1.DataSource = this.tbBodegaInfoBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "IdBodega";
            this.treeList1.Location = new System.Drawing.Point(0, 13);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsPrint.UsePrintStyles = true;
            this.treeList1.ParentFieldName = "IdSucursal";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit1});
            this.treeList1.Size = new System.Drawing.Size(764, 358);
            this.treeList1.TabIndex = 73;
            this.treeList1.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.treeList1_BeforeCheckNode);
            this.treeList1.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeList1_AfterCheckNode);
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            // 
            // colbo_Descripcion
            // 
            this.colbo_Descripcion.Caption = "Sucursal/Bodega";
            this.colbo_Descripcion.FieldName = "bo_Descripcion";
            this.colbo_Descripcion.MinWidth = 32;
            this.colbo_Descripcion.Name = "colbo_Descripcion";
            this.colbo_Descripcion.Visible = true;
            this.colbo_Descripcion.VisibleIndex = 0;
            this.colbo_Descripcion.Width = 221;
            // 
            // colip
            // 
            this.colip.Caption = "Cta. Contable /Bodega";
            this.colip.ColumnEdit = this.cmbCuentaContable;
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            this.colip.Visible = true;
            this.colip.VisibleIndex = 1;
            this.colip.Width = 484;
            // 
            // cmbCuentaContable
            // 
            this.cmbCuentaContable.AutoHeight = false;
            this.cmbCuentaContable.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCuentaContable.DataSource = this.ctPlanctaInfoBindingSource;
            this.cmbCuentaContable.DisplayMember = "pc_Cuenta";
            this.cmbCuentaContable.Name = "cmbCuentaContable";
            this.cmbCuentaContable.ValueMember = "IdCtaCble";
            this.cmbCuentaContable.View = this.gridView2;
            // 
            // ctPlanctaInfoBindingSource
            // 
            this.ctPlanctaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Plancta_Info);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpc_Cuenta2});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colpc_Cuenta2
            // 
            this.colpc_Cuenta2.Caption = "Descripcion";
            this.colpc_Cuenta2.FieldName = "pc_Cuenta2";
            this.colpc_Cuenta2.Name = "colpc_Cuenta2";
            this.colpc_Cuenta2.Visible = true;
            this.colpc_Cuenta2.VisibleIndex = 0;
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl_movi_inven
            // 
            this.gridControl_movi_inven.DataSource = this.inmoviinventipoInfoBindingSource1;
            this.gridControl_movi_inven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_movi_inven.Location = new System.Drawing.Point(0, 0);
            this.gridControl_movi_inven.MainView = this.gridView_movi_inven;
            this.gridControl_movi_inven.Name = "gridControl_movi_inven";
            this.gridControl_movi_inven.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbTipoMovi,
            this.cmbCuentaContable});
            this.gridControl_movi_inven.Size = new System.Drawing.Size(383, 371);
            this.gridControl_movi_inven.TabIndex = 74;
            this.gridControl_movi_inven.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_movi_inven});
            // 
            // inmoviinventipoInfoBindingSource1
            // 
            this.inmoviinventipoInfoBindingSource1.DataSource = typeof(Core.Erp.Info.Inventario.in_movi_inven_tipo_Info);
            // 
            // gridView_movi_inven
            // 
            this.gridView_movi_inven.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colChek,
            this.colIdMovi_inven_tipo,
            this.coltm_descripcion});
            this.gridView_movi_inven.GridControl = this.gridControl_movi_inven;
            this.gridView_movi_inven.Name = "gridView_movi_inven";
            this.gridView_movi_inven.OptionsBehavior.Editable = false;
            this.gridView_movi_inven.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_movi_inven.OptionsView.ShowAutoFilterRow = true;
            this.gridView_movi_inven.OptionsView.ShowGroupPanel = false;
            this.gridView_movi_inven.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colChek
            // 
            this.colChek.Caption = "*";
            this.colChek.FieldName = "Chek";
            this.colChek.Name = "colChek";
            this.colChek.Visible = true;
            this.colChek.VisibleIndex = 0;
            this.colChek.Width = 20;
            // 
            // colIdMovi_inven_tipo
            // 
            this.colIdMovi_inven_tipo.Caption = "Id";
            this.colIdMovi_inven_tipo.FieldName = "IdMovi_inven_tipo";
            this.colIdMovi_inven_tipo.Name = "colIdMovi_inven_tipo";
            this.colIdMovi_inven_tipo.Visible = true;
            this.colIdMovi_inven_tipo.VisibleIndex = 1;
            this.colIdMovi_inven_tipo.Width = 34;
            // 
            // coltm_descripcion
            // 
            this.coltm_descripcion.Caption = "Descripcion";
            this.coltm_descripcion.FieldName = "tm_descripcion";
            this.coltm_descripcion.Name = "coltm_descripcion";
            this.coltm_descripcion.Visible = true;
            this.coltm_descripcion.VisibleIndex = 2;
            this.coltm_descripcion.Width = 344;
            // 
            // cmbTipoMovi
            // 
            this.cmbTipoMovi.AutoHeight = false;
            this.cmbTipoMovi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoMovi.DataSource = this.inmoviinventipoInfoBindingSource;
            this.cmbTipoMovi.DisplayMember = "tm_descripcion";
            this.cmbTipoMovi.Name = "cmbTipoMovi";
            this.cmbTipoMovi.ValueMember = "IdMovi_inven_tipo";
            this.cmbTipoMovi.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // inmoviinventipoInfoBindingSource
            // 
            this.inmoviinventipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_movi_inven_tipo_Info);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // inmoviinventipoxtbbodegaInfoBindingSource
            // 
            this.inmoviinventipoxtbbodegaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_movi_inven_tipo_x_tb_bodega_Info);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt.ForeColor = System.Drawing.Color.Blue;
            this.txt.Location = new System.Drawing.Point(0, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(371, 13);
            this.txt.TabIndex = 0;
            this.txt.Text = "Nota: Solo se puede asignar la cuenta contable a la bodega no a la sucursal ";
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpLote = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1151, 29);
            this.ucGe_Menu.TabIndex = 75;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 400);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1151, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 76;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridControl_movi_inven);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeList1);
            this.splitContainer1.Panel2.Controls.Add(this.txt);
            this.splitContainer1.Size = new System.Drawing.Size(1151, 371);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.TabIndex = 77;
            // 
            // FrmIn_Tipo_Movi_Inven_x_Bodega_x_CtaCble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 426);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmIn_Tipo_Movi_Inven_x_Bodega_x_CtaCble";
            this.Text = "Tipo Movimiento Inventario Por Bodega";
            this.Load += new System.EventHandler(this.frmIN_MovimientoInventarioTipoXBodegaxCtaCtble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbBodegaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCuentaContable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_movi_inven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinventipoInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_movi_inven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoMovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinventipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinventipoxtbbodegaInfoBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tbBodegaInfoBindingSource;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colbo_Descripcion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colip;
        private DevExpress.XtraGrid.GridControl gridControl_movi_inven;
        private System.Windows.Forms.BindingSource inmoviinventipoxtbbodegaInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_movi_inven;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbCuentaContable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbTipoMovi;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private System.Windows.Forms.BindingSource ctPlanctaInfoBindingSource;
        private System.Windows.Forms.BindingSource inmoviinventipoInfoBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource inmoviinventipoInfoBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colChek;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovi_inven_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta2;
        private System.Windows.Forms.Label txt;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}