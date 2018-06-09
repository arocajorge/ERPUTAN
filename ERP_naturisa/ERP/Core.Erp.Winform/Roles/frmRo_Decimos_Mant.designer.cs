namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Decimos_Mant
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
            this.roNominaTipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rodivisionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctAnioFiscalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roEmpleadoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbPeriodos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colpe_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbnominaTipo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColDescripcionProcesoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbnomina = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbRuta = new DevExpress.XtraEditors.ButtonEdit();
            this.lbRuta = new System.Windows.Forms.Label();
            this.CmbGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControlDecimos = new DevExpress.XtraGrid.GridControl();
            this.gridViewDecimos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Colcheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colcedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colapellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colgenero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colocupacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColcodigoIESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColdiasLaborados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTipoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colretencion_Pago_Directo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColRetencion_Acreditación_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColValor_Acumulado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roNominaTipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodivisionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctAnioFiscalInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoInfoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnominaTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRuta.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDecimos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDecimos)).BeginInit();
            this.SuspendLayout();
            // 
            // roNominaTipoInfoBindingSource
            // 
            this.roNominaTipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Nomina_Tipo_Info);
            // 
            // rodivisionInfoBindingSource
            // 
            this.rodivisionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_division_Info);
            // 
            // ctAnioFiscalInfoBindingSource
            // 
            this.ctAnioFiscalInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_AnioFiscal_Info);
            // 
            // roEmpleadoInfoBindingSource
            // 
            this.roEmpleadoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Empleado_Info);
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1202, 29);
            this.ucGe_Menu.TabIndex = 18;
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
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 429);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1202, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.cmbPeriodos);
            this.panel1.Controls.Add(this.cmbnominaTipo);
            this.panel1.Controls.Add(this.cmbnomina);
            this.panel1.Controls.Add(this.cmbRuta);
            this.panel1.Controls.Add(this.lbRuta);
            this.panel1.Controls.Add(this.CmbGenerar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 83);
            this.panel1.TabIndex = 20;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 56);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 163;
            this.labelControl3.Text = "Período:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 162;
            this.labelControl2.Text = "Proceso:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 161;
            this.labelControl1.Text = "Nómina:";
            // 
            // cmbPeriodos
            // 
            this.cmbPeriodos.Location = new System.Drawing.Point(75, 54);
            this.cmbPeriodos.Name = "cmbPeriodos";
            this.cmbPeriodos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPeriodos.Properties.DisplayMember = "pe_Descripcion";
            this.cmbPeriodos.Properties.ValueMember = "IdPeriodo";
            this.cmbPeriodos.Properties.View = this.gridView2;
            this.cmbPeriodos.Size = new System.Drawing.Size(272, 20);
            this.cmbPeriodos.TabIndex = 160;
            this.cmbPeriodos.EditValueChanged += new System.EventHandler(this.cmbPeriodos_EditValueChanged);
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
            // cmbnominaTipo
            // 
            this.cmbnominaTipo.Location = new System.Drawing.Point(75, 29);
            this.cmbnominaTipo.Name = "cmbnominaTipo";
            this.cmbnominaTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbnominaTipo.Properties.DisplayMember = "DescripcionProcesoNomina";
            this.cmbnominaTipo.Properties.ValueMember = "IdNomina_TipoLiqui";
            this.cmbnominaTipo.Properties.View = this.gridView1;
            this.cmbnominaTipo.Size = new System.Drawing.Size(272, 20);
            this.cmbnominaTipo.TabIndex = 159;
            this.cmbnominaTipo.EditValueChanged += new System.EventHandler(this.cmbnominaTipo_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColDescripcionProcesoNomina});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ColDescripcionProcesoNomina
            // 
            this.ColDescripcionProcesoNomina.Caption = "Proceso";
            this.ColDescripcionProcesoNomina.FieldName = "DescripcionProcesoNomina";
            this.ColDescripcionProcesoNomina.Name = "ColDescripcionProcesoNomina";
            this.ColDescripcionProcesoNomina.Visible = true;
            this.ColDescripcionProcesoNomina.VisibleIndex = 0;
            // 
            // cmbnomina
            // 
            this.cmbnomina.Location = new System.Drawing.Point(75, 3);
            this.cmbnomina.Name = "cmbnomina";
            this.cmbnomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbnomina.Properties.DisplayMember = "Descripcion";
            this.cmbnomina.Properties.ValueMember = "IdNomina_Tipo";
            this.cmbnomina.Properties.View = this.searchLookUpEdit1View;
            this.cmbnomina.Size = new System.Drawing.Size(272, 20);
            this.cmbnomina.TabIndex = 158;
            this.cmbnomina.EditValueChanged += new System.EventHandler(this.cmbnomina_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nomina";
            this.gridColumn1.FieldName = "Descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // cmbRuta
            // 
            this.cmbRuta.Location = new System.Drawing.Point(498, 17);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbRuta.Properties.ReadOnly = true;
            this.cmbRuta.Size = new System.Drawing.Size(444, 20);
            this.cmbRuta.TabIndex = 157;
            this.cmbRuta.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmbRuta_ButtonClick);
            // 
            // lbRuta
            // 
            this.lbRuta.AutoSize = true;
            this.lbRuta.Location = new System.Drawing.Point(353, 24);
            this.lbRuta.Name = "lbRuta";
            this.lbRuta.Size = new System.Drawing.Size(113, 13);
            this.lbRuta.TabIndex = 152;
            this.lbRuta.Text = "Guardar el Archivo en:";
            // 
            // CmbGenerar
            // 
            this.CmbGenerar.Location = new System.Drawing.Point(948, 15);
            this.CmbGenerar.Name = "CmbGenerar";
            this.CmbGenerar.Size = new System.Drawing.Size(87, 28);
            this.CmbGenerar.TabIndex = 146;
            this.CmbGenerar.Text = "Generar Archivo";
            this.CmbGenerar.Click += new System.EventHandler(this.CmbGenerar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlDecimos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1202, 317);
            this.panel2.TabIndex = 21;
            // 
            // gridControlDecimos
            // 
            this.gridControlDecimos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDecimos.Location = new System.Drawing.Point(0, 0);
            this.gridControlDecimos.MainView = this.gridViewDecimos;
            this.gridControlDecimos.Name = "gridControlDecimos";
            this.gridControlDecimos.Size = new System.Drawing.Size(1202, 317);
            this.gridControlDecimos.TabIndex = 0;
            this.gridControlDecimos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDecimos});
            this.gridControlDecimos.Click += new System.EventHandler(this.gridControlDecimos_Click);
            // 
            // gridViewDecimos
            // 
            this.gridViewDecimos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Colcheck,
            this.Colcedula,
            this.Colapellidos,
            this.Colgenero,
            this.Colocupacion,
            this.ColcodigoIESS,
            this.ColdiasLaborados,
            this.ColTipoPago,
            this.Colretencion_Pago_Directo,
            this.ColRetencion_Acreditación_Cuenta,
            this.ColValor_Acumulado});
            this.gridViewDecimos.GridControl = this.gridControlDecimos;
            this.gridViewDecimos.Name = "gridViewDecimos";
            this.gridViewDecimos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDecimos.OptionsView.ShowFooter = true;
            // 
            // Colcheck
            // 
            this.Colcheck.Caption = "*";
            this.Colcheck.FieldName = "check";
            this.Colcheck.Name = "Colcheck";
            this.Colcheck.Visible = true;
            this.Colcheck.VisibleIndex = 0;
            this.Colcheck.Width = 30;
            // 
            // Colcedula
            // 
            this.Colcedula.Caption = "Cedula";
            this.Colcedula.FieldName = "cedula";
            this.Colcedula.Name = "Colcedula";
            this.Colcedula.Visible = true;
            this.Colcedula.VisibleIndex = 1;
            this.Colcedula.Width = 100;
            // 
            // Colapellidos
            // 
            this.Colapellidos.Caption = "Apellidos";
            this.Colapellidos.FieldName = "apellidos";
            this.Colapellidos.Name = "Colapellidos";
            this.Colapellidos.Visible = true;
            this.Colapellidos.VisibleIndex = 2;
            this.Colapellidos.Width = 100;
            // 
            // Colgenero
            // 
            this.Colgenero.Caption = "Genero";
            this.Colgenero.FieldName = "genero";
            this.Colgenero.Name = "Colgenero";
            this.Colgenero.Visible = true;
            this.Colgenero.VisibleIndex = 3;
            this.Colgenero.Width = 100;
            // 
            // Colocupacion
            // 
            this.Colocupacion.Caption = "Cargo";
            this.Colocupacion.FieldName = "ocupacion";
            this.Colocupacion.Name = "Colocupacion";
            this.Colocupacion.Visible = true;
            this.Colocupacion.VisibleIndex = 4;
            this.Colocupacion.Width = 100;
            // 
            // ColcodigoIESS
            // 
            this.ColcodigoIESS.Caption = "Codigo Sectorial";
            this.ColcodigoIESS.FieldName = "codigoIESS";
            this.ColcodigoIESS.Name = "ColcodigoIESS";
            this.ColcodigoIESS.Visible = true;
            this.ColcodigoIESS.VisibleIndex = 5;
            this.ColcodigoIESS.Width = 100;
            // 
            // ColdiasLaborados
            // 
            this.ColdiasLaborados.Caption = "Dias Trabajados";
            this.ColdiasLaborados.DisplayFormat.FormatString = "F2";
            this.ColdiasLaborados.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColdiasLaborados.FieldName = "diasLaborados";
            this.ColdiasLaborados.Name = "ColdiasLaborados";
            this.ColdiasLaborados.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.ColdiasLaborados.Visible = true;
            this.ColdiasLaborados.VisibleIndex = 6;
            this.ColdiasLaborados.Width = 100;
            // 
            // ColTipoPago
            // 
            this.ColTipoPago.Caption = "Tipo Pago";
            this.ColTipoPago.FieldName = "TipoPago";
            this.ColTipoPago.Name = "ColTipoPago";
            this.ColTipoPago.Visible = true;
            this.ColTipoPago.VisibleIndex = 7;
            this.ColTipoPago.Width = 100;
            // 
            // Colretencion_Pago_Directo
            // 
            this.Colretencion_Pago_Directo.Caption = "Retencion Pago Directo";
            this.Colretencion_Pago_Directo.FieldName = "retencion_Pago_Directo";
            this.Colretencion_Pago_Directo.Name = "Colretencion_Pago_Directo";
            this.Colretencion_Pago_Directo.Width = 100;
            // 
            // ColRetencion_Acreditación_Cuenta
            // 
            this.ColRetencion_Acreditación_Cuenta.Caption = "Ret.  Acred. Cuenta";
            this.ColRetencion_Acreditación_Cuenta.FieldName = "Retencion_Acreditación_Cuenta";
            this.ColRetencion_Acreditación_Cuenta.Name = "ColRetencion_Acreditación_Cuenta";
            this.ColRetencion_Acreditación_Cuenta.Width = 100;
            // 
            // ColValor_Acumulado
            // 
            this.ColValor_Acumulado.Caption = "Total Pagar";
            this.ColValor_Acumulado.DisplayFormat.FormatString = "F2";
            this.ColValor_Acumulado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColValor_Acumulado.FieldName = "Total_ganado";
            this.ColValor_Acumulado.Name = "ColValor_Acumulado";
            this.ColValor_Acumulado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.ColValor_Acumulado.Visible = true;
            this.ColValor_Acumulado.VisibleIndex = 8;
            this.ColValor_Acumulado.Width = 108;
            // 
            // frmRo_Decimos_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRo_Decimos_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generacion de Archivos .csv para Ministerio de Trabajo del Ecuador";
            this.Load += new System.EventHandler(this.frmRo_Decimos_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roNominaTipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodivisionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctAnioFiscalInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoInfoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnominaTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRuta.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDecimos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDecimos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource roNominaTipoInfoBindingSource;
        private System.Windows.Forms.BindingSource rodivisionInfoBindingSource;
        private System.Windows.Forms.BindingSource ctAnioFiscalInfoBindingSource;
        private System.Windows.Forms.BindingSource roEmpleadoInfoBindingSource;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControlDecimos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDecimos;
        private DevExpress.XtraGrid.Columns.GridColumn Colcheck;
        private DevExpress.XtraGrid.Columns.GridColumn Colcedula;
        private DevExpress.XtraGrid.Columns.GridColumn Colapellidos;
        private DevExpress.XtraGrid.Columns.GridColumn Colgenero;
        private DevExpress.XtraGrid.Columns.GridColumn Colocupacion;
        private DevExpress.XtraGrid.Columns.GridColumn ColcodigoIESS;
        private DevExpress.XtraGrid.Columns.GridColumn ColdiasLaborados;
        private DevExpress.XtraGrid.Columns.GridColumn ColTipoPago;
        private DevExpress.XtraGrid.Columns.GridColumn Colretencion_Pago_Directo;
        private DevExpress.XtraGrid.Columns.GridColumn ColRetencion_Acreditación_Cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn ColValor_Acumulado;
        private System.Windows.Forms.Label lbRuta;
        private DevExpress.XtraEditors.SimpleButton CmbGenerar;
        private DevExpress.XtraEditors.ButtonEdit cmbRuta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbPeriodos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn Colpe_Descripcion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbnominaTipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcionProcesoNomina;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbnomina;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}