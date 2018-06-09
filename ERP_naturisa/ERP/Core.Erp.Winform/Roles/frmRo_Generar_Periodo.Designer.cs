namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Generar_Periodo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPeriodo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCa_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbAnio = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlPeriodo = new DevExpress.XtraGrid.GridControl();
            this.gridViewPeriodo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnIdperiodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAnio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFechaIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año:";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.Location = new System.Drawing.Point(107, 12);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPeriodo.Properties.DisplayMember = "ca_descripcion";
            this.cmbPeriodo.Properties.ValueMember = "CodCatalogo";
            this.cmbPeriodo.Properties.View = this.searchLookUpEdit1View;
            this.cmbPeriodo.Size = new System.Drawing.Size(147, 20);
            this.cmbPeriodo.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCa_descripcion,
            this.gridColumnCodCatalogo});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnCa_descripcion
            // 
            this.gridColumnCa_descripcion.Caption = "Descripcion";
            this.gridColumnCa_descripcion.FieldName = "ca_descripcion";
            this.gridColumnCa_descripcion.Name = "gridColumnCa_descripcion";
            this.gridColumnCa_descripcion.Visible = true;
            this.gridColumnCa_descripcion.VisibleIndex = 0;
            this.gridColumnCa_descripcion.Width = 837;
            // 
            // gridColumnCodCatalogo
            // 
            this.gridColumnCodCatalogo.Caption = "Código";
            this.gridColumnCodCatalogo.FieldName = "CodCatalogo";
            this.gridColumnCodCatalogo.Name = "gridColumnCodCatalogo";
            this.gridColumnCodCatalogo.Visible = true;
            this.gridColumnCodCatalogo.VisibleIndex = 1;
            this.gridColumnCodCatalogo.Width = 337;
            // 
            // cmbAnio
            // 
            this.cmbAnio.Location = new System.Drawing.Point(107, 38);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAnio.Properties.DisplayMember = "ca_descripcion";
            this.cmbAnio.Properties.ValueMember = "IdCatalogo";
            this.cmbAnio.Properties.View = this.searchLookUpEdit2View;
            this.cmbAnio.Size = new System.Drawing.Size(147, 20);
            this.cmbAnio.TabIndex = 3;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col,
            this.Colca_descripcion});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // Col
            // 
            this.Col.Caption = "Id Catalogo";
            this.Col.FieldName = "IdCatalogo";
            this.Col.Name = "Col";
            this.Col.Visible = true;
            this.Col.VisibleIndex = 0;
            this.Col.Width = 199;
            // 
            // Colca_descripcion
            // 
            this.Colca_descripcion.Caption = "Año Fiscal";
            this.Colca_descripcion.FieldName = "ca_descripcion";
            this.Colca_descripcion.Name = "Colca_descripcion";
            this.Colca_descripcion.Visible = true;
            this.Colca_descripcion.VisibleIndex = 1;
            this.Colca_descripcion.Width = 733;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControlPeriodo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 360);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos previos:";
            // 
            // gridControlPeriodo
            // 
            this.gridControlPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPeriodo.Location = new System.Drawing.Point(3, 16);
            this.gridControlPeriodo.MainView = this.gridViewPeriodo;
            this.gridControlPeriodo.Name = "gridControlPeriodo";
            this.gridControlPeriodo.Size = new System.Drawing.Size(517, 341);
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
            this.gridColumnFechaFin});
            this.gridViewPeriodo.GridControl = this.gridControlPeriodo;
            this.gridViewPeriodo.Name = "gridViewPeriodo";
            // 
            // gridColumnIdperiodo
            // 
            this.gridColumnIdperiodo.Caption = "IdPeriodo";
            this.gridColumnIdperiodo.FieldName = "IdPeriodo";
            this.gridColumnIdperiodo.Name = "gridColumnIdperiodo";
            this.gridColumnIdperiodo.Visible = true;
            this.gridColumnIdperiodo.VisibleIndex = 0;
            // 
            // gridColumnMes
            // 
            this.gridColumnMes.Caption = "Mes";
            this.gridColumnMes.FieldName = "pe_mes";
            this.gridColumnMes.Name = "gridColumnMes";
            this.gridColumnMes.Visible = true;
            this.gridColumnMes.VisibleIndex = 1;
            // 
            // gridColumnAnio
            // 
            this.gridColumnAnio.Caption = "Año";
            this.gridColumnAnio.FieldName = "pe_anio";
            this.gridColumnAnio.Name = "gridColumnAnio";
            this.gridColumnAnio.Visible = true;
            this.gridColumnAnio.VisibleIndex = 2;
            // 
            // gridColumnFechaIni
            // 
            this.gridColumnFechaIni.Caption = "Fecha Inicial";
            this.gridColumnFechaIni.FieldName = "pe_FechaIni";
            this.gridColumnFechaIni.Name = "gridColumnFechaIni";
            this.gridColumnFechaIni.Visible = true;
            this.gridColumnFechaIni.VisibleIndex = 3;
            // 
            // gridColumnFechaFin
            // 
            this.gridColumnFechaFin.Caption = "Fecha Final";
            this.gridColumnFechaFin.FieldName = "pe_FechaFin";
            this.gridColumnFechaFin.Name = "gridColumnFechaFin";
            this.gridColumnFechaFin.Visible = true;
            this.gridColumnFechaFin.VisibleIndex = 4;
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
            this.ucGe_Menu.TabIndex = 5;
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
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(326, 17);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(121, 30);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnGenerar);
            this.panelControl1.Controls.Add(this.cmbPeriodo);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.cmbAnio);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(523, 70);
            this.panelControl1.TabIndex = 7;
            // 
            // frmRo_Generar_Periodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 465);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRo_Generar_Periodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Periodo";
            this.Load += new System.EventHandler(this.frmRo_Generar_Periodo_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_Generar_Periodo_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbPeriodo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbAnio;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlPeriodo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCa_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIdperiodo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAnio;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFechaIni;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFechaFin;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.SimpleButton btnGenerar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Col;
        private DevExpress.XtraGrid.Columns.GridColumn Colca_descripcion;
    }
}