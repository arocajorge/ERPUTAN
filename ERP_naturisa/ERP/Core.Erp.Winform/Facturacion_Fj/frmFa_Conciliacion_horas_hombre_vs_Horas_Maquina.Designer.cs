namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class frmFa_Conciliacion_horas_hombre_vs_Horas_Maquina
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
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_AF = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Af_Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_periodo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_nom_periodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gc_Conciliacion_horas = new DevExpress.XtraGrid.GridControl();
            this.gw_Conciliacion_horas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Af_Nombre_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Horas_Trabajada_x_Af = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_hora_trabajada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_nombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_IdActivoFijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbIcono = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.chek_imprimir = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_AF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_periodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Conciliacion_horas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_Conciliacion_horas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chek_imprimir.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
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
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1155, 29);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = true;
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
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chek_imprimir);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.cmb_AF);
            this.groupControl1.Controls.Add(this.cmb_periodo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1155, 104);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Filtros";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(346, 76);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 153;
            this.simpleButton1.Text = "Procesar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 54);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 152;
            this.labelControl4.Text = "Activo Fijo:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(8, 30);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 151;
            this.labelControl5.Text = "Periodo:";
            // 
            // cmb_AF
            // 
            this.cmb_AF.Location = new System.Drawing.Point(74, 50);
            this.cmb_AF.Name = "cmb_AF";
            this.cmb_AF.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_AF.Properties.DisplayMember = "Af_Nombre";
            this.cmb_AF.Properties.ValueMember = "IdActivoFijo";
            this.cmb_AF.Properties.View = this.gridView1;
            this.cmb_AF.Size = new System.Drawing.Size(347, 20);
            this.cmb_AF.TabIndex = 150;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Af_Nombre});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Col_Af_Nombre
            // 
            this.Col_Af_Nombre.Caption = "Activo Fijo";
            this.Col_Af_Nombre.FieldName = "Af_Nombre";
            this.Col_Af_Nombre.Name = "Col_Af_Nombre";
            this.Col_Af_Nombre.Visible = true;
            this.Col_Af_Nombre.VisibleIndex = 0;
            // 
            // cmb_periodo
            // 
            this.cmb_periodo.Location = new System.Drawing.Point(74, 24);
            this.cmb_periodo.Name = "cmb_periodo";
            this.cmb_periodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_periodo.Properties.DisplayMember = "nom_periodo";
            this.cmb_periodo.Properties.ValueMember = "IdPeriodo";
            this.cmb_periodo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_periodo.Size = new System.Drawing.Size(347, 20);
            this.cmb_periodo.TabIndex = 149;
            this.cmb_periodo.EditValueChanged += new System.EventHandler(this.cmb_periodo_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_nom_periodo});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Col_nom_periodo
            // 
            this.Col_nom_periodo.Caption = "Periodo";
            this.Col_nom_periodo.FieldName = "nom_periodo";
            this.Col_nom_periodo.Name = "Col_nom_periodo";
            this.Col_nom_periodo.Visible = true;
            this.Col_nom_periodo.VisibleIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_Conciliacion_horas);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 133);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1155, 367);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Detalle";
            // 
            // gc_Conciliacion_horas
            // 
            this.gc_Conciliacion_horas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Conciliacion_horas.Location = new System.Drawing.Point(2, 21);
            this.gc_Conciliacion_horas.MainView = this.gw_Conciliacion_horas;
            this.gc_Conciliacion_horas.Name = "gc_Conciliacion_horas";
            this.gc_Conciliacion_horas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbIcono});
            this.gc_Conciliacion_horas.Size = new System.Drawing.Size(1151, 344);
            this.gc_Conciliacion_horas.TabIndex = 18;
            this.gc_Conciliacion_horas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gw_Conciliacion_horas});
            // 
            // gw_Conciliacion_horas
            // 
            this.gw_Conciliacion_horas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Af_Nombre_,
            this.Col_Horas_Trabajada_x_Af,
            this.Col_hora_trabajada,
            this.Col_pe_nombreCompleto,
            this.Col_IdActivoFijo});
            this.gw_Conciliacion_horas.CustomizationFormBounds = new System.Drawing.Rectangle(597, 431, 210, 172);
            this.gw_Conciliacion_horas.GridControl = this.gc_Conciliacion_horas;
            this.gw_Conciliacion_horas.GroupCount = 1;
            this.gw_Conciliacion_horas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "Horas_Trabajada_x_Af", this.Col_Af_Nombre_, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "hora_trabajada", this.Col_pe_nombreCompleto, "")});
            this.gw_Conciliacion_horas.Name = "gw_Conciliacion_horas";
            this.gw_Conciliacion_horas.OptionsBehavior.AutoExpandAllGroups = true;
            this.gw_Conciliacion_horas.OptionsBehavior.Editable = false;
            this.gw_Conciliacion_horas.OptionsBehavior.ReadOnly = true;
            this.gw_Conciliacion_horas.OptionsPrint.PrintHorzLines = false;
            this.gw_Conciliacion_horas.OptionsPrint.PrintVertLines = false;
            this.gw_Conciliacion_horas.OptionsView.ShowFooter = true;
            this.gw_Conciliacion_horas.OptionsView.ShowGroupedColumns = true;
            this.gw_Conciliacion_horas.OptionsView.ShowGroupPanel = false;
            this.gw_Conciliacion_horas.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gw_Conciliacion_horas.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gw_Conciliacion_horas.OptionsView.ShowViewCaption = true;
            this.gw_Conciliacion_horas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Col_Af_Nombre_, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // Col_Af_Nombre_
            // 
            this.Col_Af_Nombre_.Caption = "Activo Fijo";
            this.Col_Af_Nombre_.FieldName = "Af_Nombre";
            this.Col_Af_Nombre_.Name = "Col_Af_Nombre_";
            this.Col_Af_Nombre_.Visible = true;
            this.Col_Af_Nombre_.VisibleIndex = 0;
            this.Col_Af_Nombre_.Width = 444;
            // 
            // Col_Horas_Trabajada_x_Af
            // 
            this.Col_Horas_Trabajada_x_Af.Caption = "Horas Trabajada AF";
            this.Col_Horas_Trabajada_x_Af.FieldName = "Horas_Trabajada_x_Af";
            this.Col_Horas_Trabajada_x_Af.Name = "Col_Horas_Trabajada_x_Af";
            this.Col_Horas_Trabajada_x_Af.Width = 237;
            // 
            // Col_hora_trabajada
            // 
            this.Col_hora_trabajada.Caption = "Horas Hombres";
            this.Col_hora_trabajada.FieldName = "hora_trabajada";
            this.Col_hora_trabajada.Name = "Col_hora_trabajada";
            this.Col_hora_trabajada.Visible = true;
            this.Col_hora_trabajada.VisibleIndex = 2;
            this.Col_hora_trabajada.Width = 246;
            // 
            // Col_pe_nombreCompleto
            // 
            this.Col_pe_nombreCompleto.Caption = "Empleado";
            this.Col_pe_nombreCompleto.FieldName = "pe_nombreCompleto";
            this.Col_pe_nombreCompleto.Name = "Col_pe_nombreCompleto";
            this.Col_pe_nombreCompleto.Visible = true;
            this.Col_pe_nombreCompleto.VisibleIndex = 1;
            this.Col_pe_nombreCompleto.Width = 237;
            // 
            // Col_IdActivoFijo
            // 
            this.Col_IdActivoFijo.Caption = "Id Activo fijo";
            this.Col_IdActivoFijo.FieldName = "IdActivoFijo";
            this.Col_IdActivoFijo.Name = "Col_IdActivoFijo";
            // 
            // cmbIcono
            // 
            this.cmbIcono.AutoHeight = false;
            this.cmbIcono.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIcono.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "S", 0)});
            this.cmbIcono.Name = "cmbIcono";
            // 
            // chek_imprimir
            // 
            this.chek_imprimir.Location = new System.Drawing.Point(444, 24);
            this.chek_imprimir.Name = "chek_imprimir";
            this.chek_imprimir.Properties.Caption = "Imprimir reporte detallado";
            this.chek_imprimir.Size = new System.Drawing.Size(151, 19);
            this.chek_imprimir.TabIndex = 154;
            // 
            // frmFa_Conciliacion_horas_hombre_vs_Horas_Maquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 500);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmFa_Conciliacion_horas_hombre_vs_Horas_Maquina";
            this.Text = "frmFa_Conciliacion_horas_hombre_vs_Horas_Maquina";
            this.Load += new System.EventHandler(this.frmFa_Conciliacion_horas_hombre_vs_Horas_Maquina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_AF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_periodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Conciliacion_horas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_Conciliacion_horas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chek_imprimir.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_AF;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Af_Nombre;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_periodo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Col_nom_periodo;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gc_Conciliacion_horas;
        private DevExpress.XtraGrid.Views.Grid.GridView gw_Conciliacion_horas;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Af_Nombre_;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbIcono;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Horas_Trabajada_x_Af;
        private DevExpress.XtraGrid.Columns.GridColumn Col_hora_trabajada;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_nombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdActivoFijo;
        private DevExpress.XtraEditors.CheckEdit chek_imprimir;

    }
}