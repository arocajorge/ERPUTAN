namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Generacion_Utilidades_Mant
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
            this.ucGe_Menu_Superior_Mant = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRuta = new DevExpress.XtraEditors.ButtonEdit();
            this.lbRuta = new System.Windows.Forms.Label();
            this.CmbGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtUtilidadRepartir = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtLimiteDistribucionUtilidad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.txtUtilidadPorCargaFamiliar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtUtilidadPorDerechoIndividual = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCargarEmpleado = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridEmpleados = new DevExpress.XtraGrid.GridControl();
            this.viewEmpleados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasTrab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlicuotaIndividual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotalIndividual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCargas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasTrabAnual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactorA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlicuotaCarga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotalCarga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExedenteIESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalRecibir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPeriodos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colpe_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRuta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUtilidadRepartir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteDistribucionUtilidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidadPorCargaFamiliar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidadPorDerechoIndividual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Superior_Mant
            // 
            this.ucGe_Menu_Superior_Mant.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant.Name = "ucGe_Menu_Superior_Mant";
            this.ucGe_Menu_Superior_Mant.Size = new System.Drawing.Size(1159, 29);
            this.ucGe_Menu_Superior_Mant.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnproductos = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPeriodos);
            this.groupBox1.Controls.Add(this.cmbRuta);
            this.groupBox1.Controls.Add(this.lbRuta);
            this.groupBox1.Controls.Add(this.CmbGenerar);
            this.groupBox1.Controls.Add(this.groupControl1);
            this.groupBox1.Controls.Add(this.TxtUtilidadRepartir);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.txtLimiteDistribucionUtilidad);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.cmdCalcular);
            this.groupBox1.Controls.Add(this.txtUtilidadPorCargaFamiliar);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.txtUtilidadPorDerechoIndividual);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.cmdCargarEmpleado);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbRuta
            // 
            this.cmbRuta.Location = new System.Drawing.Point(102, 100);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbRuta.Properties.ReadOnly = true;
            this.cmbRuta.Size = new System.Drawing.Size(493, 20);
            this.cmbRuta.TabIndex = 160;
            this.cmbRuta.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmbRuta_ButtonClick);
            // 
            // lbRuta
            // 
            this.lbRuta.AutoSize = true;
            this.lbRuta.Location = new System.Drawing.Point(4, 102);
            this.lbRuta.Name = "lbRuta";
            this.lbRuta.Size = new System.Drawing.Size(92, 13);
            this.lbRuta.TabIndex = 159;
            this.lbRuta.Text = "Ruta Plantilla .csv";
            // 
            // CmbGenerar
            // 
            this.CmbGenerar.Location = new System.Drawing.Point(621, 95);
            this.CmbGenerar.Name = "CmbGenerar";
            this.CmbGenerar.Size = new System.Drawing.Size(87, 28);
            this.CmbGenerar.TabIndex = 158;
            this.CmbGenerar.Text = "Generar Archivo";
            this.CmbGenerar.Click += new System.EventHandler(this.CmbGenerar_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textBox1);
            this.groupControl1.Location = new System.Drawing.Point(6, 46);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(702, 45);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "Observación";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(2, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(698, 22);
            this.textBox1.TabIndex = 0;
            // 
            // TxtUtilidadRepartir
            // 
            this.TxtUtilidadRepartir.EditValue = "0";
            this.TxtUtilidadRepartir.Location = new System.Drawing.Point(865, 46);
            this.TxtUtilidadRepartir.Name = "TxtUtilidadRepartir";
            this.TxtUtilidadRepartir.Properties.DisplayFormat.FormatString = "N2";
            this.TxtUtilidadRepartir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtUtilidadRepartir.Properties.EditFormat.FormatString = "N2";
            this.TxtUtilidadRepartir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtUtilidadRepartir.Properties.MaxLength = 15;
            this.TxtUtilidadRepartir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtUtilidadRepartir.Size = new System.Drawing.Size(100, 20);
            this.TxtUtilidadRepartir.TabIndex = 17;
            this.TxtUtilidadRepartir.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.TxtUtilidadRepartir_EditValueChanging);
            this.TxtUtilidadRepartir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUtilidadRepartir_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(714, 53);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(104, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Valor Total de Utilidad";
            // 
            // txtLimiteDistribucionUtilidad
            // 
            this.txtLimiteDistribucionUtilidad.EditValue = "0";
            this.txtLimiteDistribucionUtilidad.Location = new System.Drawing.Point(865, 71);
            this.txtLimiteDistribucionUtilidad.Name = "txtLimiteDistribucionUtilidad";
            this.txtLimiteDistribucionUtilidad.Properties.DisplayFormat.FormatString = "N2";
            this.txtLimiteDistribucionUtilidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtLimiteDistribucionUtilidad.Properties.EditFormat.FormatString = "N2";
            this.txtLimiteDistribucionUtilidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtLimiteDistribucionUtilidad.Properties.MaxLength = 15;
            this.txtLimiteDistribucionUtilidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLimiteDistribucionUtilidad.Size = new System.Drawing.Size(100, 20);
            this.txtLimiteDistribucionUtilidad.TabIndex = 15;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(714, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(142, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Límite de Distribución Utilidad:";
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Location = new System.Drawing.Point(971, 68);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(115, 23);
            this.cmdCalcular.TabIndex = 13;
            this.cmdCalcular.Text = "C&alcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // txtUtilidadPorCargaFamiliar
            // 
            this.txtUtilidadPorCargaFamiliar.EditValue = "0";
            this.txtUtilidadPorCargaFamiliar.Enabled = false;
            this.txtUtilidadPorCargaFamiliar.Location = new System.Drawing.Point(421, 17);
            this.txtUtilidadPorCargaFamiliar.Name = "txtUtilidadPorCargaFamiliar";
            this.txtUtilidadPorCargaFamiliar.Properties.DisplayFormat.FormatString = "N2";
            this.txtUtilidadPorCargaFamiliar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUtilidadPorCargaFamiliar.Properties.EditFormat.FormatString = "N2";
            this.txtUtilidadPorCargaFamiliar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUtilidadPorCargaFamiliar.Properties.MaxLength = 15;
            this.txtUtilidadPorCargaFamiliar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUtilidadPorCargaFamiliar.Size = new System.Drawing.Size(100, 20);
            this.txtUtilidadPorCargaFamiliar.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(283, 21);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(129, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Utilidad por Carga Familiar:";
            // 
            // txtUtilidadPorDerechoIndividual
            // 
            this.txtUtilidadPorDerechoIndividual.EditValue = "0";
            this.txtUtilidadPorDerechoIndividual.Enabled = false;
            this.txtUtilidadPorDerechoIndividual.Location = new System.Drawing.Point(162, 14);
            this.txtUtilidadPorDerechoIndividual.Name = "txtUtilidadPorDerechoIndividual";
            this.txtUtilidadPorDerechoIndividual.Properties.DisplayFormat.FormatString = "N2";
            this.txtUtilidadPorDerechoIndividual.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUtilidadPorDerechoIndividual.Properties.EditFormat.FormatString = "N2";
            this.txtUtilidadPorDerechoIndividual.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUtilidadPorDerechoIndividual.Properties.MaxLength = 15;
            this.txtUtilidadPorDerechoIndividual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUtilidadPorDerechoIndividual.Size = new System.Drawing.Size(100, 20);
            this.txtUtilidadPorDerechoIndividual.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(150, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Utilidad por Derecho Individual:";
            // 
            // cmdCargarEmpleado
            // 
            this.cmdCargarEmpleado.Location = new System.Drawing.Point(971, 19);
            this.cmdCargarEmpleado.Name = "cmdCargarEmpleado";
            this.cmdCargarEmpleado.Size = new System.Drawing.Size(115, 23);
            this.cmdCargarEmpleado.TabIndex = 4;
            this.cmdCargarEmpleado.Text = "&Cargar Empleados";
            this.cmdCargarEmpleado.UseVisualStyleBackColor = true;
            this.cmdCargarEmpleado.Click += new System.EventHandler(this.cmdCargarEmpleado_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(621, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Período:";
            // 
            // gridEmpleados
            // 
            this.gridEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmpleados.Location = new System.Drawing.Point(0, 155);
            this.gridEmpleados.MainView = this.viewEmpleados;
            this.gridEmpleados.Name = "gridEmpleados";
            this.gridEmpleados.Size = new System.Drawing.Size(1159, 328);
            this.gridEmpleados.TabIndex = 2;
            this.gridEmpleados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewEmpleados});
            // 
            // viewEmpleados
            // 
            this.viewEmpleados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpleado,
            this.colCedula,
            this.colNombreCompleto,
            this.colCargo,
            this.colSexo,
            this.colDiasTrab,
            this.colAlicuotaIndividual,
            this.colSubTotalIndividual,
            this.colCargas,
            this.colDiasTrabAnual,
            this.colFactorA,
            this.colAlicuotaCarga,
            this.colSubTotalCarga,
            this.colExedenteIESS,
            this.colTotalRecibir});
            this.viewEmpleados.GridControl = this.gridEmpleados;
            this.viewEmpleados.Name = "viewEmpleados";
            this.viewEmpleados.OptionsView.ShowAutoFilterRow = true;
            this.viewEmpleados.OptionsView.ShowFooter = true;
            this.viewEmpleados.OptionsView.ShowGroupPanel = false;
            this.viewEmpleados.OptionsView.ShowIndicator = false;
            this.viewEmpleados.OptionsView.ShowViewCaption = true;
            this.viewEmpleados.ViewCaption = "Listado de Empleados";
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.Caption = "IdEmpleado";
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.OptionsColumn.AllowEdit = false;
            this.colIdEmpleado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdEmpleado", "{0} Registros")});
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 0;
            this.colIdEmpleado.Width = 86;
            // 
            // colCedula
            // 
            this.colCedula.Caption = "Cédula";
            this.colCedula.FieldName = "InfoPersona.pe_cedulaRuc";
            this.colCedula.Name = "colCedula";
            this.colCedula.OptionsColumn.AllowEdit = false;
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 1;
            this.colCedula.Width = 87;
            // 
            // colNombreCompleto
            // 
            this.colNombreCompleto.Caption = "Nombre del Empleado";
            this.colNombreCompleto.FieldName = "InfoPersona.pe_nombreCompleto";
            this.colNombreCompleto.Name = "colNombreCompleto";
            this.colNombreCompleto.OptionsColumn.AllowEdit = false;
            this.colNombreCompleto.Visible = true;
            this.colNombreCompleto.VisibleIndex = 2;
            this.colNombreCompleto.Width = 253;
            // 
            // colCargo
            // 
            this.colCargo.Caption = "Cargo";
            this.colCargo.FieldName = "cargo_Descripcion";
            this.colCargo.Name = "colCargo";
            this.colCargo.OptionsColumn.AllowEdit = false;
            this.colCargo.Visible = true;
            this.colCargo.VisibleIndex = 3;
            this.colCargo.Width = 139;
            // 
            // colSexo
            // 
            this.colSexo.Caption = "Sexo";
            this.colSexo.FieldName = "InfoPersona.pe_sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.OptionsColumn.AllowEdit = false;
            this.colSexo.Width = 34;
            // 
            // colDiasTrab
            // 
            this.colDiasTrab.Caption = "Días Trabajados";
            this.colDiasTrab.FieldName = "diasTrabajo";
            this.colDiasTrab.Name = "colDiasTrab";
            this.colDiasTrab.OptionsColumn.AllowEdit = false;
            this.colDiasTrab.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colDiasTrab.Visible = true;
            this.colDiasTrab.VisibleIndex = 4;
            this.colDiasTrab.Width = 66;
            // 
            // colAlicuotaIndividual
            // 
            this.colAlicuotaIndividual.Caption = "AlicuotaIndividual";
            this.colAlicuotaIndividual.DisplayFormat.FormatString = "N4";
            this.colAlicuotaIndividual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlicuotaIndividual.FieldName = "alicuotaIndividual";
            this.colAlicuotaIndividual.Name = "colAlicuotaIndividual";
            this.colAlicuotaIndividual.OptionsColumn.AllowEdit = false;
            this.colAlicuotaIndividual.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "alicuotaIndividual", "{0:N2}")});
            this.colAlicuotaIndividual.Visible = true;
            this.colAlicuotaIndividual.VisibleIndex = 5;
            this.colAlicuotaIndividual.Width = 53;
            // 
            // colSubTotalIndividual
            // 
            this.colSubTotalIndividual.Caption = "SubTotalIndividual";
            this.colSubTotalIndividual.DisplayFormat.FormatString = "N2";
            this.colSubTotalIndividual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotalIndividual.FieldName = "subTotalIndividual";
            this.colSubTotalIndividual.Name = "colSubTotalIndividual";
            this.colSubTotalIndividual.OptionsColumn.AllowEdit = false;
            this.colSubTotalIndividual.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "subTotalIndividual", "{0:N2}")});
            this.colSubTotalIndividual.Visible = true;
            this.colSubTotalIndividual.VisibleIndex = 6;
            this.colSubTotalIndividual.Width = 63;
            // 
            // colCargas
            // 
            this.colCargas.Caption = "Cargas";
            this.colCargas.FieldName = "cargas";
            this.colCargas.Name = "colCargas";
            this.colCargas.OptionsColumn.AllowEdit = false;
            this.colCargas.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colCargas.Visible = true;
            this.colCargas.VisibleIndex = 7;
            this.colCargas.Width = 56;
            // 
            // colDiasTrabAnual
            // 
            this.colDiasTrabAnual.Caption = "Anual";
            this.colDiasTrabAnual.FieldName = "diasTrabAnual";
            this.colDiasTrabAnual.Name = "colDiasTrabAnual";
            this.colDiasTrabAnual.OptionsColumn.AllowEdit = false;
            this.colDiasTrabAnual.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colDiasTrabAnual.Width = 50;
            // 
            // colFactorA
            // 
            this.colFactorA.Caption = "Factor A";
            this.colFactorA.DisplayFormat.FormatString = "N2";
            this.colFactorA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFactorA.FieldName = "factorA";
            this.colFactorA.Name = "colFactorA";
            this.colFactorA.OptionsColumn.AllowEdit = false;
            this.colFactorA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "factorA", "{0:N2}")});
            this.colFactorA.Visible = true;
            this.colFactorA.VisibleIndex = 8;
            this.colFactorA.Width = 65;
            // 
            // colAlicuotaCarga
            // 
            this.colAlicuotaCarga.Caption = "AlicuotaCarga";
            this.colAlicuotaCarga.DisplayFormat.FormatString = "N4";
            this.colAlicuotaCarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlicuotaCarga.FieldName = "alicuotaCarga";
            this.colAlicuotaCarga.Name = "colAlicuotaCarga";
            this.colAlicuotaCarga.OptionsColumn.AllowEdit = false;
            this.colAlicuotaCarga.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "alicuotaCarga", "{0:N2}")});
            this.colAlicuotaCarga.Visible = true;
            this.colAlicuotaCarga.VisibleIndex = 9;
            this.colAlicuotaCarga.Width = 49;
            // 
            // colSubTotalCarga
            // 
            this.colSubTotalCarga.Caption = "SubTotalCarga";
            this.colSubTotalCarga.DisplayFormat.FormatString = "N2";
            this.colSubTotalCarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotalCarga.FieldName = "subTotalCarga";
            this.colSubTotalCarga.Name = "colSubTotalCarga";
            this.colSubTotalCarga.OptionsColumn.AllowEdit = false;
            this.colSubTotalCarga.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "subTotalCarga", "{0:N2}")});
            this.colSubTotalCarga.Visible = true;
            this.colSubTotalCarga.VisibleIndex = 10;
            this.colSubTotalCarga.Width = 69;
            // 
            // colExedenteIESS
            // 
            this.colExedenteIESS.Caption = "Exedente IESS";
            this.colExedenteIESS.DisplayFormat.FormatString = "N2";
            this.colExedenteIESS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colExedenteIESS.FieldName = "exedenteIESS";
            this.colExedenteIESS.Name = "colExedenteIESS";
            this.colExedenteIESS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "exedenteIESS", "{0:N2}")});
            this.colExedenteIESS.Visible = true;
            this.colExedenteIESS.VisibleIndex = 11;
            this.colExedenteIESS.Width = 69;
            // 
            // colTotalRecibir
            // 
            this.colTotalRecibir.Caption = "Total a Recibir";
            this.colTotalRecibir.DisplayFormat.FormatString = "N2";
            this.colTotalRecibir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalRecibir.FieldName = "valorEntregar";
            this.colTotalRecibir.Name = "colTotalRecibir";
            this.colTotalRecibir.OptionsColumn.AllowEdit = false;
            this.colTotalRecibir.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valorEntregar", "{0:N2}")});
            this.colTotalRecibir.Visible = true;
            this.colTotalRecibir.VisibleIndex = 12;
            this.colTotalRecibir.Width = 102;
            // 
            // cmbPeriodos
            // 
            this.cmbPeriodos.Location = new System.Drawing.Point(703, 19);
            this.cmbPeriodos.Name = "cmbPeriodos";
            this.cmbPeriodos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPeriodos.Properties.DisplayMember = "pe_Descripcion";
            this.cmbPeriodos.Properties.ValueMember = "IdPeriodo";
            this.cmbPeriodos.Properties.View = this.gridView2;
            this.cmbPeriodos.Size = new System.Drawing.Size(262, 20);
            this.cmbPeriodos.TabIndex = 161;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdPeriodo,
            this.Colpe_Descripcion});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdPeriodo
            // 
            this.ColIdPeriodo.Caption = "Id Periodo";
            this.ColIdPeriodo.FieldName = "IdPeriodo";
            this.ColIdPeriodo.Name = "ColIdPeriodo";
            this.ColIdPeriodo.Visible = true;
            this.ColIdPeriodo.VisibleIndex = 0;
            this.ColIdPeriodo.Width = 168;
            // 
            // Colpe_Descripcion
            // 
            this.Colpe_Descripcion.Caption = "Descripcion";
            this.Colpe_Descripcion.FieldName = "pe_Descripcion";
            this.Colpe_Descripcion.Name = "Colpe_Descripcion";
            this.Colpe_Descripcion.Visible = true;
            this.Colpe_Descripcion.VisibleIndex = 1;
            this.Colpe_Descripcion.Width = 984;
            // 
            // frmRo_Generacion_Utilidades_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 483);
            this.Controls.Add(this.gridEmpleados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant);
            this.Name = "frmRo_Generacion_Utilidades_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso - Generación de Utilidades";
            this.Load += new System.EventHandler(this.frmRo_Generacion_Utilidades_Mant_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRuta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUtilidadRepartir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteDistribucionUtilidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidadPorCargaFamiliar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidadPorDerechoIndividual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button cmdCargarEmpleado;
        private DevExpress.XtraGrid.GridControl gridEmpleados;
        private DevExpress.XtraGrid.Views.Grid.GridView viewEmpleados;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colCargo;
        private DevExpress.XtraGrid.Columns.GridColumn colSexo;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasTrab;
        private DevExpress.XtraGrid.Columns.GridColumn colAlicuotaIndividual;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotalIndividual;
        private DevExpress.XtraGrid.Columns.GridColumn colCargas;
        private DevExpress.XtraEditors.TextEdit txtUtilidadPorCargaFamiliar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUtilidadPorDerechoIndividual;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button cmdCalcular;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasTrabAnual;
        private DevExpress.XtraGrid.Columns.GridColumn colFactorA;
        private DevExpress.XtraGrid.Columns.GridColumn colAlicuotaCarga;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotalCarga;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalRecibir;
        private DevExpress.XtraEditors.TextEdit txtLimiteDistribucionUtilidad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colExedenteIESS;
        private DevExpress.XtraEditors.TextEdit TxtUtilidadRepartir;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.ButtonEdit cmbRuta;
        private System.Windows.Forms.Label lbRuta;
        private DevExpress.XtraEditors.SimpleButton CmbGenerar;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbPeriodos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn Colpe_Descripcion;
    }
}