namespace Core.Erp.Winform.Academico
{
    partial class FrmAca_Generar_Periodo
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dt_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAnio = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAnioLectivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dt_FechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPeriodo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumncolDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumncolIdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlPeriodo = new DevExpress.XtraGrid.GridControl();
            this.gridViewPeriodo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnIdperiodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAnio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFechaIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIdAniLectivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox2);
            this.panelControl1.Controls.Add(this.cmbPeriodo);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(523, 126);
            this.panelControl1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dt_FechaFin);
            this.groupBox2.Controls.Add(this.btnGenerar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbAnio);
            this.groupBox2.Controls.Add(this.dt_FechaDesde);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(20, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 77);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // dt_FechaFin
            // 
            this.dt_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FechaFin.Location = new System.Drawing.Point(284, 47);
            this.dt_FechaFin.Name = "dt_FechaFin";
            this.dt_FechaFin.Size = new System.Drawing.Size(97, 20);
            this.dt_FechaFin.TabIndex = 10;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(409, 35);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(76, 30);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha Hasta:";
            // 
            // cmbAnio
            // 
            this.cmbAnio.Location = new System.Drawing.Point(115, 19);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAnio.Properties.DisplayMember = "IdAnioLectivo";
            this.cmbAnio.Properties.ValueMember = "Descripcion";
            this.cmbAnio.Properties.View = this.searchLookUpEdit2View;
            this.cmbAnio.Size = new System.Drawing.Size(266, 20);
            this.cmbAnio.TabIndex = 3;
            this.cmbAnio.EditValueChanged += new System.EventHandler(this.cmbAnio_EditValueChanged);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAnioLectivo,
            this.colFechaInicial,
            this.colFechaFin});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdAnioLectivo
            // 
            this.colIdAnioLectivo.FieldName = "IdAnioLectivo";
            this.colIdAnioLectivo.Name = "colIdAnioLectivo";
            this.colIdAnioLectivo.Visible = true;
            this.colIdAnioLectivo.VisibleIndex = 0;
            // 
            // colFechaInicial
            // 
            this.colFechaInicial.FieldName = "FechaInicio";
            this.colFechaInicial.Name = "colFechaInicial";
            this.colFechaInicial.Visible = true;
            this.colFechaInicial.VisibleIndex = 1;
            // 
            // colFechaFin
            // 
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.Visible = true;
            this.colFechaFin.VisibleIndex = 2;
            // 
            // dt_FechaDesde
            // 
            this.dt_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FechaDesde.Location = new System.Drawing.Point(83, 47);
            this.dt_FechaDesde.Name = "dt_FechaDesde";
            this.dt_FechaDesde.Size = new System.Drawing.Size(97, 20);
            this.dt_FechaDesde.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año Lectivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha Desde:";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.Location = new System.Drawing.Point(115, 12);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPeriodo.Properties.DisplayMember = "Descripcion";
            this.cmbPeriodo.Properties.ValueMember = "IdCatalogo";
            this.cmbPeriodo.Properties.View = this.searchLookUpEdit1View;
            this.cmbPeriodo.Size = new System.Drawing.Size(147, 20);
            this.cmbPeriodo.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumncolDescripcion,
            this.gridColumncolIdCatalogo});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumncolDescripcion
            // 
            this.gridColumncolDescripcion.Caption = "Descripcion";
            this.gridColumncolDescripcion.FieldName = "Descripcion";
            this.gridColumncolDescripcion.Name = "gridColumncolDescripcion";
            this.gridColumncolDescripcion.Visible = true;
            this.gridColumncolDescripcion.VisibleIndex = 1;
            this.gridColumncolDescripcion.Width = 1049;
            // 
            // gridColumncolIdCatalogo
            // 
            this.gridColumncolIdCatalogo.Caption = "Id Catalogo";
            this.gridColumncolIdCatalogo.FieldName = "IdCatalogo";
            this.gridColumncolIdCatalogo.Name = "gridColumncolIdCatalogo";
            this.gridColumncolIdCatalogo.Visible = true;
            this.gridColumncolIdCatalogo.VisibleIndex = 0;
            this.gridColumncolIdCatalogo.Width = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Periodo:";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(523, 29);
            this.ucGe_Menu.TabIndex = 9;
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
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControlPeriodo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 348);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos previos:";
            // 
            // gridControlPeriodo
            // 
            this.gridControlPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPeriodo.Location = new System.Drawing.Point(3, 16);
            this.gridControlPeriodo.MainView = this.gridViewPeriodo;
            this.gridControlPeriodo.Name = "gridControlPeriodo";
            this.gridControlPeriodo.Size = new System.Drawing.Size(517, 329);
            this.gridControlPeriodo.TabIndex = 0;
            this.gridControlPeriodo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPeriodo});
            // 
            // gridViewPeriodo
            // 
            this.gridViewPeriodo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnIdperiodo,
            this.gridColumnMes,
            this.gridColumnAnio,
            this.gridColumnFechaIni,
            this.gridColumnFechaFin,
            this.gridColumnIdAniLectivo});
            this.gridViewPeriodo.GridControl = this.gridControlPeriodo;
            this.gridViewPeriodo.Name = "gridViewPeriodo";
            this.gridViewPeriodo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPeriodo.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewPeriodo.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnIdperiodo
            // 
            this.gridColumnIdperiodo.Caption = "IdPeriodo";
            this.gridColumnIdperiodo.FieldName = "IdPeriodo";
            this.gridColumnIdperiodo.Name = "gridColumnIdperiodo";
            this.gridColumnIdperiodo.OptionsColumn.AllowEdit = false;
            this.gridColumnIdperiodo.Visible = true;
            this.gridColumnIdperiodo.VisibleIndex = 1;
            // 
            // gridColumnMes
            // 
            this.gridColumnMes.Caption = "Mes";
            this.gridColumnMes.FieldName = "pe_mes";
            this.gridColumnMes.Name = "gridColumnMes";
            this.gridColumnMes.OptionsColumn.AllowEdit = false;
            this.gridColumnMes.Visible = true;
            this.gridColumnMes.VisibleIndex = 2;
            // 
            // gridColumnAnio
            // 
            this.gridColumnAnio.Caption = "Año";
            this.gridColumnAnio.FieldName = "pe_anio";
            this.gridColumnAnio.Name = "gridColumnAnio";
            this.gridColumnAnio.OptionsColumn.AllowEdit = false;
            this.gridColumnAnio.Visible = true;
            this.gridColumnAnio.VisibleIndex = 3;
            // 
            // gridColumnFechaIni
            // 
            this.gridColumnFechaIni.Caption = "Fecha Inicial";
            this.gridColumnFechaIni.FieldName = "pe_FechaIni";
            this.gridColumnFechaIni.Name = "gridColumnFechaIni";
            this.gridColumnFechaIni.Visible = true;
            this.gridColumnFechaIni.VisibleIndex = 4;
            // 
            // gridColumnFechaFin
            // 
            this.gridColumnFechaFin.Caption = "Fecha Final";
            this.gridColumnFechaFin.FieldName = "pe_FechaFin";
            this.gridColumnFechaFin.Name = "gridColumnFechaFin";
            this.gridColumnFechaFin.Visible = true;
            this.gridColumnFechaFin.VisibleIndex = 5;
            // 
            // gridColumnIdAniLectivo
            // 
            this.gridColumnIdAniLectivo.Caption = "Año Lectivo";
            this.gridColumnIdAniLectivo.FieldName = "IdAnioLectivo";
            this.gridColumnIdAniLectivo.Name = "gridColumnIdAniLectivo";
            this.gridColumnIdAniLectivo.OptionsColumn.AllowEdit = false;
            this.gridColumnIdAniLectivo.Visible = true;
            this.gridColumnIdAniLectivo.VisibleIndex = 0;
            // 
            // FrmAca_Generar_Periodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 502);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAca_Generar_Periodo";
            this.Text = "Generar Periodo(Academico)";
            this.Load += new System.EventHandler(this.FrmAca_Generar_Periodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPeriodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGenerar;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbPeriodo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumncolDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumncolIdCatalogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbAnio;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlPeriodo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIdperiodo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAnio;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFechaIni;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFechaFin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dt_FechaFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_FechaDesde;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAnioLectivo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicial;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIdAniLectivo;
    }
}