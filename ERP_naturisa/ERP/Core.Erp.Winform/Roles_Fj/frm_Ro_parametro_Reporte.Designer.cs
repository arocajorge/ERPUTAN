namespace Core.Erp.Winform.Roles_Fj
{
    partial class frm_Ro_parametro_Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ro_parametro_Reporte));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl_parametros = new DevExpress.XtraGrid.GridControl();
            this.gridView_parametros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_IdNomina_Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_nomina = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_nomina_tipo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_DescripcionProcesoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_IdRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_rubro = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_ru_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Id_Catalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_catalogo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_ca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_eliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Col_Descripcion_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmb_reporte = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_ca_desp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_parametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_parametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nomina_tipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_rubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_catalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl_parametros);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.ucGe_Menu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1025, 479);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl_parametros
            // 
            this.gridControl_parametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_parametros.Location = new System.Drawing.Point(2, 79);
            this.gridControl_parametros.MainView = this.gridView_parametros;
            this.gridControl_parametros.Name = "gridControl_parametros";
            this.gridControl_parametros.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_nomina,
            this.cmb_nomina_tipo,
            this.cmb_rubro,
            this.cmb_catalogo,
            this.repositoryItemImageComboBox1});
            this.gridControl_parametros.Size = new System.Drawing.Size(1021, 398);
            this.gridControl_parametros.TabIndex = 4;
            this.gridControl_parametros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_parametros});
            // 
            // gridView_parametros
            // 
            this.gridView_parametros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_IdNomina_Tipo,
            this.Col_proceso,
            this.Col_IdRubro,
            this.Col_Id_Catalogo,
            this.Col_Orden,
            this.Col_eliminar,
            this.Col_Descripcion_});
            this.gridView_parametros.GridControl = this.gridControl_parametros;
            this.gridView_parametros.Name = "gridView_parametros";
            this.gridView_parametros.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_parametros.OptionsView.ShowAutoFilterRow = true;
            this.gridView_parametros.OptionsView.ShowGroupPanel = false;
            this.gridView_parametros.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_parametros_FocusedRowChanged);
            // 
            // Col_IdNomina_Tipo
            // 
            this.Col_IdNomina_Tipo.Caption = "Nomina";
            this.Col_IdNomina_Tipo.ColumnEdit = this.cmb_nomina;
            this.Col_IdNomina_Tipo.FieldName = "IdNomina_Tipo";
            this.Col_IdNomina_Tipo.Name = "Col_IdNomina_Tipo";
            this.Col_IdNomina_Tipo.Visible = true;
            this.Col_IdNomina_Tipo.VisibleIndex = 1;
            this.Col_IdNomina_Tipo.Width = 128;
            // 
            // cmb_nomina
            // 
            this.cmb_nomina.AutoHeight = false;
            this.cmb_nomina.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_nomina.Name = "cmb_nomina";
            this.cmb_nomina.View = this.repositoryItemSearchLookUpEdit1View;
            this.cmb_nomina.EditValueChanged += new System.EventHandler(this.cmb_nomina_EditValueChanged);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Descripcion});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Col_Descripcion
            // 
            this.Col_Descripcion.Caption = "Nomina";
            this.Col_Descripcion.FieldName = "Descripcion";
            this.Col_Descripcion.Name = "Col_Descripcion";
            this.Col_Descripcion.Visible = true;
            this.Col_Descripcion.VisibleIndex = 0;
            // 
            // Col_proceso
            // 
            this.Col_proceso.Caption = "Proceso";
            this.Col_proceso.ColumnEdit = this.cmb_nomina_tipo;
            this.Col_proceso.FieldName = "IdNomina_tipo_Liq";
            this.Col_proceso.Name = "Col_proceso";
            this.Col_proceso.Visible = true;
            this.Col_proceso.VisibleIndex = 2;
            this.Col_proceso.Width = 181;
            // 
            // cmb_nomina_tipo
            // 
            this.cmb_nomina_tipo.AutoHeight = false;
            this.cmb_nomina_tipo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_nomina_tipo.Name = "cmb_nomina_tipo";
            this.cmb_nomina_tipo.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_DescripcionProcesoNomina});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Col_DescripcionProcesoNomina
            // 
            this.Col_DescripcionProcesoNomina.Caption = "Proceso";
            this.Col_DescripcionProcesoNomina.FieldName = "DescripcionProcesoNomina";
            this.Col_DescripcionProcesoNomina.Name = "Col_DescripcionProcesoNomina";
            this.Col_DescripcionProcesoNomina.Visible = true;
            this.Col_DescripcionProcesoNomina.VisibleIndex = 0;
            // 
            // Col_IdRubro
            // 
            this.Col_IdRubro.Caption = "Rubro";
            this.Col_IdRubro.ColumnEdit = this.cmb_rubro;
            this.Col_IdRubro.FieldName = "IdRubro";
            this.Col_IdRubro.Name = "Col_IdRubro";
            this.Col_IdRubro.Visible = true;
            this.Col_IdRubro.VisibleIndex = 3;
            this.Col_IdRubro.Width = 277;
            // 
            // cmb_rubro
            // 
            this.cmb_rubro.AutoHeight = false;
            this.cmb_rubro.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_rubro.Name = "cmb_rubro";
            this.cmb_rubro.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_ru_descripcion});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // Col_ru_descripcion
            // 
            this.Col_ru_descripcion.Caption = "Rubro";
            this.Col_ru_descripcion.FieldName = "ru_descripcion";
            this.Col_ru_descripcion.Name = "Col_ru_descripcion";
            this.Col_ru_descripcion.Visible = true;
            this.Col_ru_descripcion.VisibleIndex = 0;
            // 
            // Col_Id_Catalogo
            // 
            this.Col_Id_Catalogo.Caption = "Grupo";
            this.Col_Id_Catalogo.ColumnEdit = this.cmb_catalogo;
            this.Col_Id_Catalogo.FieldName = "Id_Catalogo";
            this.Col_Id_Catalogo.Name = "Col_Id_Catalogo";
            this.Col_Id_Catalogo.Visible = true;
            this.Col_Id_Catalogo.VisibleIndex = 5;
            this.Col_Id_Catalogo.Width = 64;
            // 
            // cmb_catalogo
            // 
            this.cmb_catalogo.AutoHeight = false;
            this.cmb_catalogo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_catalogo.Name = "cmb_catalogo";
            this.cmb_catalogo.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_ca_descripcion});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // Col_ca_descripcion
            // 
            this.Col_ca_descripcion.Caption = "Grupo";
            this.Col_ca_descripcion.FieldName = "ca_descripcion";
            this.Col_ca_descripcion.Name = "Col_ca_descripcion";
            this.Col_ca_descripcion.Visible = true;
            this.Col_ca_descripcion.VisibleIndex = 0;
            // 
            // Col_Orden
            // 
            this.Col_Orden.Caption = "Orden Columna";
            this.Col_Orden.FieldName = "Orden";
            this.Col_Orden.Name = "Col_Orden";
            this.Col_Orden.Visible = true;
            this.Col_Orden.VisibleIndex = 6;
            this.Col_Orden.Width = 94;
            // 
            // Col_eliminar
            // 
            this.Col_eliminar.Caption = "**";
            this.Col_eliminar.ColumnEdit = this.repositoryItemImageComboBox1;
            this.Col_eliminar.FieldName = "eliminar";
            this.Col_eliminar.Name = "Col_eliminar";
            this.Col_eliminar.OptionsColumn.AllowEdit = false;
            this.Col_eliminar.Visible = true;
            this.Col_eliminar.VisibleIndex = 0;
            this.Col_eliminar.Width = 35;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "anular2_32.x32png.png");
            // 
            // Col_Descripcion_
            // 
            this.Col_Descripcion_.Caption = "Descripcion";
            this.Col_Descripcion_.FieldName = "Descripcion";
            this.Col_Descripcion_.Name = "Col_Descripcion_";
            this.Col_Descripcion_.Visible = true;
            this.Col_Descripcion_.VisibleIndex = 4;
            this.Col_Descripcion_.Width = 391;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmb_reporte);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 31);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1021, 48);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Reporte";
            // 
            // cmb_reporte
            // 
            this.cmb_reporte.Location = new System.Drawing.Point(5, 24);
            this.cmb_reporte.Name = "cmb_reporte";
            this.cmb_reporte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_reporte.Properties.DisplayMember = "ca_descripcion";
            this.cmb_reporte.Properties.ValueMember = "CodCatalogo";
            this.cmb_reporte.Properties.View = this.searchLookUpEdit1View;
            this.cmb_reporte.Size = new System.Drawing.Size(282, 20);
            this.cmb_reporte.TabIndex = 2;
            this.cmb_reporte.EditValueChanged += new System.EventHandler(this.cmb_reporte_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ca_desp});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // col_ca_desp
            // 
            this.col_ca_desp.Caption = "Reporte";
            this.col_ca_desp.FieldName = "ca_descripcion";
            this.col_ca_desp.Name = "col_ca_desp";
            this.col_ca_desp.Visible = true;
            this.col_ca_desp.VisibleIndex = 0;
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
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpLote = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(2, 2);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1021, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // frm_Ro_parametro_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 479);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_Ro_parametro_Reporte";
            this.Text = "frm_Ro_parametro_Reporte";
            this.Load += new System.EventHandler(this.frm_Ro_parametro_Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_parametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_parametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nomina_tipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_rubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_catalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_reporte;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl_parametros;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_parametros;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdNomina_Tipo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_nomina;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_proceso;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_nomina_tipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_DescripcionProcesoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdRubro;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_rubro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ru_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Id_Catalogo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_catalogo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ca_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Orden;
        private DevExpress.XtraGrid.Columns.GridColumn Col_eliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Descripcion_;
        private DevExpress.XtraGrid.Columns.GridColumn col_ca_desp;
    }
}