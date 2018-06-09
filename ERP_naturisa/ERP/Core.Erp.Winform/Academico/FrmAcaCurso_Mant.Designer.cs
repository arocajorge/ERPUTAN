namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaCurso_Mant
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.lblCodCurso = new DevExpress.XtraEditors.LabelControl();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.lblIdSeccion = new DevExpress.XtraEditors.LabelControl();
            this.txtIdCurso = new DevExpress.XtraEditors.TextEdit();
            this.lblIdCurso = new DevExpress.XtraEditors.LabelControl();
            this.txtCodCurso = new DevExpress.XtraEditors.TextEdit();
            this.cmbSeccion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaSeccionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSeccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionSeccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.cmbSede = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaSedeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSede1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionSede = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbInstitucion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaInstitucionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdInstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblInstitucion = new DevExpress.XtraEditors.LabelControl();
            this.cmbJornada = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaJornadaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSede = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdJornada1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionJornada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblIdJornada = new DevExpress.XtraEditors.LabelControl();
            this.lblSede = new DevExpress.XtraEditors.LabelControl();
            this.chk_SistemaDual = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCurso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodCurso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSeccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSeccionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSede.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSedeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstitucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJornada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaJornadaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_SistemaDual.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(651, 39);
            this.ucGe_Menu.TabIndex = 2;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
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
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms
            // 
            this.ucGe_BarraEstadoInferior_Forms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms.Location = new System.Drawing.Point(0, 346);
            this.ucGe_BarraEstadoInferior_Forms.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_BarraEstadoInferior_Forms.Name = "ucGe_BarraEstadoInferior_Forms";
            this.ucGe_BarraEstadoInferior_Forms.Size = new System.Drawing.Size(651, 28);
            this.ucGe_BarraEstadoInferior_Forms.TabIndex = 3;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(218, 294);
            this.lblAnulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(170, 25);
            this.lblAnulado.TabIndex = 55;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(30, 292);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Size = new System.Drawing.Size(80, 21);
            this.chkActivo.TabIndex = 54;
            // 
            // lblCodCurso
            // 
            this.lblCodCurso.Location = new System.Drawing.Point(32, 95);
            this.lblCodCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCodCurso.Name = "lblCodCurso";
            this.lblCodCurso.Size = new System.Drawing.Size(81, 16);
            this.lblCodCurso.TabIndex = 53;
            this.lblCodCurso.Text = "Código Curso:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(32, 254);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(70, 16);
            this.lblDescripcion.TabIndex = 51;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblIdSeccion
            // 
            this.lblIdSeccion.Location = new System.Drawing.Point(32, 228);
            this.lblIdSeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblIdSeccion.Name = "lblIdSeccion";
            this.lblIdSeccion.Size = new System.Drawing.Size(49, 16);
            this.lblIdSeccion.TabIndex = 49;
            this.lblIdSeccion.Text = "Sección:";
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Enabled = false;
            this.txtIdCurso.Location = new System.Drawing.Point(148, 62);
            this.txtIdCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(117, 22);
            this.txtIdCurso.TabIndex = 47;
            // 
            // lblIdCurso
            // 
            this.lblIdCurso.Location = new System.Drawing.Point(32, 65);
            this.lblIdCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblIdCurso.Name = "lblIdCurso";
            this.lblIdCurso.Size = new System.Drawing.Size(53, 16);
            this.lblIdCurso.TabIndex = 46;
            this.lblIdCurso.Text = "Id Curso:";
            // 
            // txtCodCurso
            // 
            this.txtCodCurso.Enabled = false;
            this.txtCodCurso.Location = new System.Drawing.Point(148, 91);
            this.txtCodCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodCurso.Name = "txtCodCurso";
            this.txtCodCurso.Size = new System.Drawing.Size(117, 22);
            this.txtCodCurso.TabIndex = 56;
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.Location = new System.Drawing.Point(151, 219);
            this.cmbSeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSeccion.Properties.DataSource = this.acaSeccionInfoBindingSource;
            this.cmbSeccion.Properties.DisplayMember = "DescripcionSeccion";
            this.cmbSeccion.Properties.ValueMember = "IdSeccion";
            this.cmbSeccion.Properties.View = this.searchLookUpEdit1View;
            this.cmbSeccion.Size = new System.Drawing.Size(365, 22);
            this.cmbSeccion.TabIndex = 57;
            // 
            // acaSeccionInfoBindingSource
            // 
            this.acaSeccionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Seccion_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSeccion,
            this.colDescripcionSeccion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSeccion
            // 
            this.colIdSeccion.Caption = "Código";
            this.colIdSeccion.FieldName = "IdSeccion";
            this.colIdSeccion.Name = "colIdSeccion";
            this.colIdSeccion.OptionsColumn.AllowEdit = false;
            this.colIdSeccion.Visible = true;
            this.colIdSeccion.VisibleIndex = 0;
            this.colIdSeccion.Width = 126;
            // 
            // colDescripcionSeccion
            // 
            this.colDescripcionSeccion.Caption = "Descripción";
            this.colDescripcionSeccion.FieldName = "DescripcionSeccion";
            this.colDescripcionSeccion.Name = "colDescripcionSeccion";
            this.colDescripcionSeccion.OptionsColumn.AllowEdit = false;
            this.colDescripcionSeccion.Visible = true;
            this.colDescripcionSeccion.VisibleIndex = 1;
            this.colDescripcionSeccion.Width = 1048;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(151, 250);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(455, 22);
            this.txtDescripcion.TabIndex = 58;
            // 
            // cmbSede
            // 
            this.cmbSede.Location = new System.Drawing.Point(148, 155);
            this.cmbSede.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSede.Properties.DataSource = this.acaSedeInfoBindingSource;
            this.cmbSede.Properties.DisplayMember = "DescripcionSede";
            this.cmbSede.Properties.ValueMember = "IdSede";
            this.cmbSede.Properties.View = this.gridView2;
            this.cmbSede.Size = new System.Drawing.Size(367, 22);
            this.cmbSede.TabIndex = 63;
            this.cmbSede.EditValueChanged += new System.EventHandler(this.cmbSede_EditValueChanged);
            // 
            // acaSedeInfoBindingSource
            // 
            this.acaSedeInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Sede_Info);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSede1,
            this.colDescripcionSede});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSede1
            // 
            this.colIdSede1.Caption = "Código";
            this.colIdSede1.FieldName = "IdSede";
            this.colIdSede1.Name = "colIdSede1";
            this.colIdSede1.OptionsColumn.AllowEdit = false;
            this.colIdSede1.Visible = true;
            this.colIdSede1.VisibleIndex = 0;
            this.colIdSede1.Width = 132;
            // 
            // colDescripcionSede
            // 
            this.colDescripcionSede.Caption = "Descripción";
            this.colDescripcionSede.FieldName = "DescripcionSede";
            this.colDescripcionSede.Name = "colDescripcionSede";
            this.colDescripcionSede.OptionsColumn.AllowEdit = false;
            this.colDescripcionSede.Visible = true;
            this.colDescripcionSede.VisibleIndex = 1;
            this.colDescripcionSede.Width = 1042;
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.Location = new System.Drawing.Point(148, 123);
            this.cmbInstitucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInstitucion.Properties.DataSource = this.acaInstitucionInfoBindingSource;
            this.cmbInstitucion.Properties.DisplayMember = "Nombre";
            this.cmbInstitucion.Properties.ReadOnly = true;
            this.cmbInstitucion.Properties.ValueMember = "IdInstitucion";
            this.cmbInstitucion.Properties.View = this.gridView1;
            this.cmbInstitucion.Size = new System.Drawing.Size(367, 22);
            this.cmbInstitucion.TabIndex = 62;
            // 
            // acaInstitucionInfoBindingSource
            // 
            this.acaInstitucionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Institucion_Info);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdInstitucion,
            this.colNombre});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdInstitucion
            // 
            this.colIdInstitucion.FieldName = "IdInstitucion";
            this.colIdInstitucion.Name = "colIdInstitucion";
            this.colIdInstitucion.OptionsColumn.AllowEdit = false;
            this.colIdInstitucion.Visible = true;
            this.colIdInstitucion.VisibleIndex = 0;
            this.colIdInstitucion.Width = 154;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 1020;
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.Location = new System.Drawing.Point(32, 124);
            this.lblInstitucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(63, 16);
            this.lblInstitucion.TabIndex = 61;
            this.lblInstitucion.Text = "Institución:";
            // 
            // cmbJornada
            // 
            this.cmbJornada.Location = new System.Drawing.Point(148, 187);
            this.cmbJornada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbJornada.Name = "cmbJornada";
            this.cmbJornada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbJornada.Properties.DataSource = this.acaJornadaInfoBindingSource;
            this.cmbJornada.Properties.DisplayMember = "DescripcionJornada";
            this.cmbJornada.Properties.ValueMember = "IdJornada";
            this.cmbJornada.Properties.View = this.gridView3;
            this.cmbJornada.Size = new System.Drawing.Size(368, 22);
            this.cmbJornada.TabIndex = 60;
            this.cmbJornada.EditValueChanged += new System.EventHandler(this.cmbJornada_EditValueChanged);
            // 
            // acaJornadaInfoBindingSource
            // 
            this.acaJornadaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Jornada_Info);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSede,
            this.colIdJornada1,
            this.colDescripcionJornada});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSede
            // 
            this.colIdSede.FieldName = "IdSede";
            this.colIdSede.Name = "colIdSede";
            // 
            // colIdJornada1
            // 
            this.colIdJornada1.Caption = "Código";
            this.colIdJornada1.FieldName = "IdJornada";
            this.colIdJornada1.Name = "colIdJornada1";
            this.colIdJornada1.OptionsColumn.AllowEdit = false;
            this.colIdJornada1.Visible = true;
            this.colIdJornada1.VisibleIndex = 0;
            this.colIdJornada1.Width = 85;
            // 
            // colDescripcionJornada
            // 
            this.colDescripcionJornada.Caption = "Descripción";
            this.colDescripcionJornada.FieldName = "DescripcionJornada";
            this.colDescripcionJornada.Name = "colDescripcionJornada";
            this.colDescripcionJornada.OptionsColumn.AllowEdit = false;
            this.colDescripcionJornada.Visible = true;
            this.colDescripcionJornada.VisibleIndex = 1;
            this.colDescripcionJornada.Width = 1089;
            // 
            // lblIdJornada
            // 
            this.lblIdJornada.Location = new System.Drawing.Point(32, 191);
            this.lblIdJornada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblIdJornada.Name = "lblIdJornada";
            this.lblIdJornada.Size = new System.Drawing.Size(50, 16);
            this.lblIdJornada.TabIndex = 59;
            this.lblIdJornada.Text = "Jornada:";
            // 
            // lblSede
            // 
            this.lblSede.Location = new System.Drawing.Point(32, 159);
            this.lblSede.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(34, 16);
            this.lblSede.TabIndex = 64;
            this.lblSede.Text = "Sede:";
            // 
            // chk_SistemaDual
            // 
            this.chk_SistemaDual.Location = new System.Drawing.Point(477, 292);
            this.chk_SistemaDual.Margin = new System.Windows.Forms.Padding(4);
            this.chk_SistemaDual.Name = "chk_SistemaDual";
            this.chk_SistemaDual.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_SistemaDual.Properties.Appearance.Options.UseFont = true;
            this.chk_SistemaDual.Properties.Caption = "Sistema Dual";
            this.chk_SistemaDual.Size = new System.Drawing.Size(129, 26);
            this.chk_SistemaDual.TabIndex = 65;
            // 
            // FrmAcaCurso_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 374);
            this.Controls.Add(this.chk_SistemaDual);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.cmbSede);
            this.Controls.Add(this.cmbInstitucion);
            this.Controls.Add(this.lblInstitucion);
            this.Controls.Add(this.cmbJornada);
            this.Controls.Add(this.lblIdJornada);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmbSeccion);
            this.Controls.Add(this.txtCodCurso);
            this.Controls.Add(this.lblAnulado);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.lblCodCurso);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblIdSeccion);
            this.Controls.Add(this.txtIdCurso);
            this.Controls.Add(this.lblIdCurso);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms);
            this.Controls.Add(this.ucGe_Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAcaCurso_Mant";
            this.Text = "FrmAcaCurso_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcaCurso_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAcaCurso_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCurso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodCurso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSeccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSeccionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSede.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSedeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstitucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJornada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaJornadaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_SistemaDual.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private DevExpress.XtraEditors.LabelControl lblCodCurso;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private DevExpress.XtraEditors.LabelControl lblIdSeccion;
        private DevExpress.XtraEditors.TextEdit txtIdCurso;
        private DevExpress.XtraEditors.LabelControl lblIdCurso;
        private DevExpress.XtraEditors.TextEdit txtCodCurso;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSeccion;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSede;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbInstitucion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblInstitucion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbJornada;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl lblIdJornada;
        private DevExpress.XtraEditors.LabelControl lblSede;
        private System.Windows.Forms.BindingSource acaInstitucionInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdInstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private System.Windows.Forms.BindingSource acaSedeInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSede1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionSede;
        private System.Windows.Forms.BindingSource acaJornadaInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSede;
        private DevExpress.XtraGrid.Columns.GridColumn colIdJornada1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionJornada;
        private System.Windows.Forms.BindingSource acaSeccionInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSeccion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionSeccion;
        private DevExpress.XtraEditors.CheckEdit chk_SistemaDual;
    }
}