namespace Core.Erp.Winform.Contabilidad_FJ
{
    partial class frmCon_distribucion_gastos_x_punto_cargo_mant
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
            this.gridControl_punto_cargo = new DevExpress.XtraGrid.GridControl();
            this.gridView_punto_cargo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_check_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.de_fecha = new DevExpress.XtraEditors.DateEdit();
            this.txt_IdDistribucion = new DevExpress.XtraEditors.TextEdit();
            this.btn_buscar = new DevExpress.XtraEditors.SimpleButton();
            this.ucCon_Periodo1 = new Core.Erp.Winform.Controles.UCCon_Periodo();
            this.txt_observacion = new DevExpress.XtraEditors.MemoEdit();
            this.gridControl_saldo_cuentas = new DevExpress.XtraGrid.GridControl();
            this.gridView_saldo_cuentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_punto_cargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_punto_cargo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdDistribucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_saldo_cuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_saldo_cuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_punto_cargo
            // 
            this.gridControl_punto_cargo.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl_punto_cargo.Location = new System.Drawing.Point(0, 108);
            this.gridControl_punto_cargo.MainView = this.gridView_punto_cargo;
            this.gridControl_punto_cargo.Name = "gridControl_punto_cargo";
            this.gridControl_punto_cargo.Size = new System.Drawing.Size(494, 403);
            this.gridControl_punto_cargo.TabIndex = 0;
            this.gridControl_punto_cargo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_punto_cargo});
            // 
            // gridView_punto_cargo
            // 
            this.gridView_punto_cargo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.col_check_pc});
            this.gridView_punto_cargo.GridControl = this.gridControl_punto_cargo;
            this.gridView_punto_cargo.Name = "gridView_punto_cargo";
            this.gridView_punto_cargo.OptionsView.ShowAutoFilterRow = true;
            this.gridView_punto_cargo.OptionsView.ShowFooter = true;
            this.gridView_punto_cargo.OptionsView.ShowGroupPanel = false;
            this.gridView_punto_cargo.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_punto_cargo_CellValueChanged);
            this.gridView_punto_cargo.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_punto_cargo_CellValueChanging);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdPunto_cargo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 40;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Punto de cargo";
            this.gridColumn2.FieldName = "nom_punto_cargo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 343;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "%";
            this.gridColumn3.FieldName = "Porcentaje";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 60;
            // 
            // col_check_pc
            // 
            this.col_check_pc.Caption = "*";
            this.col_check_pc.FieldName = "Checked";
            this.col_check_pc.Name = "col_check_pc";
            this.col_check_pc.Visible = true;
            this.col_check_pc.VisibleIndex = 0;
            this.col_check_pc.Width = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.de_fecha);
            this.panel1.Controls.Add(this.txt_IdDistribucion);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.ucCon_Periodo1);
            this.panel1.Controls.Add(this.txt_observacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 79);
            this.panel1.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Observación";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "# Distribución";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(353, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Fecha";
            // 
            // de_fecha
            // 
            this.de_fecha.EditValue = null;
            this.de_fecha.Location = new System.Drawing.Point(388, 10);
            this.de_fecha.Name = "de_fecha";
            this.de_fecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_fecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_fecha.Size = new System.Drawing.Size(100, 20);
            this.de_fecha.TabIndex = 4;
            // 
            // txt_IdDistribucion
            // 
            this.txt_IdDistribucion.Location = new System.Drawing.Point(96, 10);
            this.txt_IdDistribucion.Name = "txt_IdDistribucion";
            this.txt_IdDistribucion.Properties.ReadOnly = true;
            this.txt_IdDistribucion.Size = new System.Drawing.Size(100, 20);
            this.txt_IdDistribucion.TabIndex = 2;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(842, 13);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(87, 36);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // ucCon_Periodo1
            // 
            this.ucCon_Periodo1.Enabled_cmb_Periodo = true;
            this.ucCon_Periodo1.Enabled_de_Desde = true;
            this.ucCon_Periodo1.Enabled_de_Hasta = true;
            this.ucCon_Periodo1.Location = new System.Drawing.Point(494, 6);
            this.ucCon_Periodo1.Name = "ucCon_Periodo1";
            this.ucCon_Periodo1.ReadOnly_cmb_Periodo = false;
            this.ucCon_Periodo1.ReadOnly_de_Desde = true;
            this.ucCon_Periodo1.ReadOnly_de_Hasta = true;
            this.ucCon_Periodo1.Size = new System.Drawing.Size(342, 56);
            this.ucCon_Periodo1.TabIndex = 0;
            this.ucCon_Periodo1.Visible_cmb_Periodo = true;
            this.ucCon_Periodo1.Visible_de_Desde = true;
            this.ucCon_Periodo1.Visible_de_Hasta = true;
            this.ucCon_Periodo1.Visible_lblDesde = true;
            this.ucCon_Periodo1.Visible_lblHasta = true;
            this.ucCon_Periodo1.Visible_lblPeriodo = true;
            // 
            // txt_observacion
            // 
            this.txt_observacion.Location = new System.Drawing.Point(96, 37);
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(392, 36);
            this.txt_observacion.TabIndex = 3;
            // 
            // gridControl_saldo_cuentas
            // 
            this.gridControl_saldo_cuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_saldo_cuentas.Location = new System.Drawing.Point(494, 108);
            this.gridControl_saldo_cuentas.MainView = this.gridView_saldo_cuentas;
            this.gridControl_saldo_cuentas.Name = "gridControl_saldo_cuentas";
            this.gridControl_saldo_cuentas.Size = new System.Drawing.Size(500, 403);
            this.gridControl_saldo_cuentas.TabIndex = 2;
            this.gridControl_saldo_cuentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_saldo_cuentas});
            // 
            // gridView_saldo_cuentas
            // 
            this.gridView_saldo_cuentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView_saldo_cuentas.GridControl = this.gridControl_saldo_cuentas;
            this.gridView_saldo_cuentas.Name = "gridView_saldo_cuentas";
            this.gridView_saldo_cuentas.OptionsView.ShowAutoFilterRow = true;
            this.gridView_saldo_cuentas.OptionsView.ShowFooter = true;
            this.gridView_saldo_cuentas.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Código";
            this.gridColumn5.FieldName = "IdCtaCble";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 95;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Cuenta";
            this.gridColumn6.FieldName = "pc_Cuenta";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 290;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Saldo";
            this.gridColumn7.FieldName = "Saldo";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo", "{0:n2}")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 74;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "*";
            this.gridColumn8.FieldName = "Checked";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 31;
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
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(994, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 3;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
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
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_Superior_Mant1_event_btnGuardar_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_Superior_Mant1_event_btnAnular_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // frmCon_distribucion_gastos_x_punto_cargo_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 511);
            this.Controls.Add(this.gridControl_saldo_cuentas);
            this.Controls.Add(this.gridControl_punto_cargo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "frmCon_distribucion_gastos_x_punto_cargo_mant";
            this.Text = "frmCon_distribucion_gastos_x_punto_cargo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed);
            this.Load += new System.EventHandler(this.frmCon_distribucion_gastos_x_punto_cargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_punto_cargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_punto_cargo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdDistribucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_saldo_cuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_saldo_cuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_punto_cargo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_punto_cargo;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl_saldo_cuentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_saldo_cuentas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn col_check_pc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private Controles.UCCon_Periodo ucCon_Periodo1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private DevExpress.XtraEditors.SimpleButton btn_buscar;
        private DevExpress.XtraEditors.TextEdit txt_IdDistribucion;
        private DevExpress.XtraEditors.MemoEdit txt_observacion;
        private DevExpress.XtraEditors.DateEdit de_fecha;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}