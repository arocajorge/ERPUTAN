namespace Core.Erp.Winform.Academico
{
    partial class FrmAca_Rubros_Asigandos_x_Estudiante_x_Periodo
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
            this.ucAca_Estudiante1 = new Core.Erp.Winform.Controles.UCAca_Estudiante();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoEstudiante = new System.Windows.Forms.TextBox();
            this.cmbEstado = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeriodo = new DevExpress.XtraEditors.TextEdit();
            this.txtAnioLectivo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridCtrlRubros_x_Estudiante = new DevExpress.XtraGrid.GridControl();
            this.gridvwRubro_x_Estudiante = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_CodRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.gridCtrlEstudiantes = new DevExpress.XtraGrid.GridControl();
            this.gridvwEstudiantes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Chequeo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Apellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Seccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Curso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Paralelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnioLectivo.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlRubros_x_Estudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvwRubro_x_Estudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvwEstudiantes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucAca_Estudiante1
            // 
            this.ucAca_Estudiante1.Location = new System.Drawing.Point(76, 9);
            this.ucAca_Estudiante1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucAca_Estudiante1.Name = "ucAca_Estudiante1";
            this.ucAca_Estudiante1.Size = new System.Drawing.Size(206, 27);
            this.ucAca_Estudiante1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(495, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(444, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelControl1);
            this.groupBox5.Controls.Add(this.ucAca_Estudiante1);
            this.groupBox5.Controls.Add(this.txtSeccion);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtCodigoEstudiante);
            this.groupBox5.Controls.Add(this.cmbEstado);
            this.groupBox5.Controls.Add(this.labelControl2);
            this.groupBox5.Controls.Add(this.labelControl3);
            this.groupBox5.Controls.Add(this.txtCurso);
            this.groupBox5.Location = new System.Drawing.Point(14, 85);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(301, 151);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 17);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Estudiante";
            // 
            // txtSeccion
            // 
            this.txtSeccion.Enabled = false;
            this.txtSeccion.Location = new System.Drawing.Point(78, 58);
            this.txtSeccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(200, 20);
            this.txtSeccion.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seccion";
            // 
            // txtCodigoEstudiante
            // 
            this.txtCodigoEstudiante.Enabled = false;
            this.txtCodigoEstudiante.Location = new System.Drawing.Point(78, 36);
            this.txtCodigoEstudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigoEstudiante.Name = "txtCodigoEstudiante";
            this.txtCodigoEstudiante.Size = new System.Drawing.Size(200, 20);
            this.txtCodigoEstudiante.TabIndex = 3;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(78, 119);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.View = this.searchLookUpEdit1View;
            this.cmbEstado.Size = new System.Drawing.Size(75, 20);
            this.cmbEstado.TabIndex = 7;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(4, 89);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Grado/Curso";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(4, 121);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Estado Actual";
            // 
            // txtCurso
            // 
            this.txtCurso.Enabled = false;
            this.txtCurso.Location = new System.Drawing.Point(78, 89);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(200, 20);
            this.txtCurso.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelControl5);
            this.groupBox4.Controls.Add(this.txtPeriodo);
            this.groupBox4.Controls.Add(this.txtAnioLectivo);
            this.groupBox4.Controls.Add(this.labelControl4);
            this.groupBox4.Location = new System.Drawing.Point(14, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(301, 65);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Año/Periodo Activo";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(4, 17);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Año Lectivo";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Enabled = false;
            this.txtPeriodo.Location = new System.Drawing.Point(74, 41);
            this.txtPeriodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(168, 20);
            this.txtPeriodo.TabIndex = 7;
            // 
            // txtAnioLectivo
            // 
            this.txtAnioLectivo.Enabled = false;
            this.txtAnioLectivo.Location = new System.Drawing.Point(74, 15);
            this.txtAnioLectivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnioLectivo.Name = "txtAnioLectivo";
            this.txtAnioLectivo.Size = new System.Drawing.Size(168, 20);
            this.txtAnioLectivo.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(4, 44);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Periodo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridCtrlRubros_x_Estudiante);
            this.groupBox2.Location = new System.Drawing.Point(495, 267);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(448, 345);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Rubros por Estudiante";
            // 
            // gridCtrlRubros_x_Estudiante
            // 
            this.gridCtrlRubros_x_Estudiante.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridCtrlRubros_x_Estudiante.Location = new System.Drawing.Point(4, 17);
            this.gridCtrlRubros_x_Estudiante.MainView = this.gridvwRubro_x_Estudiante;
            this.gridCtrlRubros_x_Estudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridCtrlRubros_x_Estudiante.Name = "gridCtrlRubros_x_Estudiante";
            this.gridCtrlRubros_x_Estudiante.Size = new System.Drawing.Size(440, 323);
            this.gridCtrlRubros_x_Estudiante.TabIndex = 0;
            this.gridCtrlRubros_x_Estudiante.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridvwRubro_x_Estudiante});
            // 
            // gridvwRubro_x_Estudiante
            // 
            this.gridvwRubro_x_Estudiante.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_CodRubro,
            this.Col_Descripcion,
            this.Col_Valor});
            this.gridvwRubro_x_Estudiante.GridControl = this.gridCtrlRubros_x_Estudiante;
            this.gridvwRubro_x_Estudiante.Name = "gridvwRubro_x_Estudiante";
            this.gridvwRubro_x_Estudiante.OptionsView.ShowFooter = true;
            // 
            // Col_CodRubro
            // 
            this.Col_CodRubro.Caption = "Codigo Rubro";
            this.Col_CodRubro.FieldName = "IdRubro";
            this.Col_CodRubro.Name = "Col_CodRubro";
            this.Col_CodRubro.OptionsColumn.AllowEdit = false;
            // 
            // Col_Descripcion
            // 
            this.Col_Descripcion.Caption = "Rubro";
            this.Col_Descripcion.FieldName = "Descripcion_rubro";
            this.Col_Descripcion.Name = "Col_Descripcion";
            this.Col_Descripcion.OptionsColumn.AllowEdit = false;
            this.Col_Descripcion.Visible = true;
            this.Col_Descripcion.VisibleIndex = 0;
            // 
            // Col_Valor
            // 
            this.Col_Valor.Caption = "Valor";
            this.Col_Valor.FieldName = "Valor";
            this.Col_Valor.Name = "Col_Valor";
            this.Col_Valor.OptionsColumn.AllowEdit = false;
            this.Col_Valor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.Col_Valor.Visible = true;
            this.Col_Valor.VisibleIndex = 1;
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
            this.ucGe_Menu_Superior_Mant1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(952, 29);
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
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            // 
            // gridCtrlEstudiantes
            // 
            this.gridCtrlEstudiantes.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridCtrlEstudiantes.Location = new System.Drawing.Point(8, 17);
            this.gridCtrlEstudiantes.MainView = this.gridvwEstudiantes;
            this.gridCtrlEstudiantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridCtrlEstudiantes.Name = "gridCtrlEstudiantes";
            this.gridCtrlEstudiantes.Size = new System.Drawing.Size(469, 561);
            this.gridCtrlEstudiantes.TabIndex = 4;
            this.gridCtrlEstudiantes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridvwEstudiantes});
            // 
            // gridvwEstudiantes
            // 
            this.gridvwEstudiantes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Chequeo,
            this.Col_Nombre,
            this.Col_Apellido,
            this.Col_Seccion,
            this.Col_Curso,
            this.Col_Paralelo});
            this.gridvwEstudiantes.GridControl = this.gridCtrlEstudiantes;
            this.gridvwEstudiantes.Name = "gridvwEstudiantes";
            this.gridvwEstudiantes.OptionsBehavior.Editable = false;
            this.gridvwEstudiantes.OptionsBehavior.ReadOnly = true;
            this.gridvwEstudiantes.OptionsView.ShowAutoFilterRow = true;
            this.gridvwEstudiantes.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridvwEstudiantes_RowClick);
            this.gridvwEstudiantes.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridvwEstudiantes_RowCellClick);
            // 
            // Col_Chequeo
            // 
            this.Col_Chequeo.Caption = "*";
            this.Col_Chequeo.FieldName = "chequeo";
            this.Col_Chequeo.Name = "Col_Chequeo";
            this.Col_Chequeo.Visible = true;
            this.Col_Chequeo.VisibleIndex = 0;
            // 
            // Col_Nombre
            // 
            this.Col_Nombre.Caption = "Nombre";
            this.Col_Nombre.FieldName = "pe_nombre";
            this.Col_Nombre.Name = "Col_Nombre";
            this.Col_Nombre.Visible = true;
            this.Col_Nombre.VisibleIndex = 1;
            this.Col_Nombre.Width = 271;
            // 
            // Col_Apellido
            // 
            this.Col_Apellido.Caption = "Apellido";
            this.Col_Apellido.FieldName = "pe_apellido";
            this.Col_Apellido.Name = "Col_Apellido";
            this.Col_Apellido.Visible = true;
            this.Col_Apellido.VisibleIndex = 2;
            this.Col_Apellido.Width = 288;
            // 
            // Col_Seccion
            // 
            this.Col_Seccion.Caption = "Seccion";
            this.Col_Seccion.FieldName = "Seccion";
            this.Col_Seccion.Name = "Col_Seccion";
            this.Col_Seccion.Width = 389;
            // 
            // Col_Curso
            // 
            this.Col_Curso.Caption = "Curso";
            this.Col_Curso.FieldName = "Curso";
            this.Col_Curso.Name = "Col_Curso";
            this.Col_Curso.Width = 395;
            // 
            // Col_Paralelo
            // 
            this.Col_Paralelo.Caption = "Paralelo";
            this.Col_Paralelo.FieldName = "Paralelo";
            this.Col_Paralelo.Name = "Col_Paralelo";
            this.Col_Paralelo.Visible = true;
            this.Col_Paralelo.VisibleIndex = 3;
            this.Col_Paralelo.Width = 391;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridCtrlEstudiantes);
            this.groupBox3.Location = new System.Drawing.Point(9, 29);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(482, 583);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista Estudiantes";
            // 
            // FrmAca_Rubros_Asigandos_x_Estudiante_x_Periodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 602);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAca_Rubros_Asigandos_x_Estudiante_x_Periodo";
            this.Text = "FrmRubros_Asigandos_x_Estudiante_x_Periodo";
            this.Load += new System.EventHandler(this.FrmRubros_Asigandos_x_Estudiante_x_Periodo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnioLectivo.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlRubros_x_Estudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvwRubro_x_Estudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvwEstudiantes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCAca_Estudiante ucAca_Estudiante1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtCurso;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtCodigoEstudiante;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridCtrlRubros_x_Estudiante;
        private DevExpress.XtraGrid.Views.Grid.GridView gridvwRubro_x_Estudiante;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn Col_CodRubro;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Valor;
        private DevExpress.XtraGrid.GridControl gridCtrlEstudiantes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridvwEstudiantes;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Apellido;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Seccion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Curso;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Paralelo;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtAnioLectivo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Chequeo;
    }
}