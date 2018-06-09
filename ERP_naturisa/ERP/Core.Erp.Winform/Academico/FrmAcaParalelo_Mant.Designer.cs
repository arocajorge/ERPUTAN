namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaParalelo_Mant
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.lblIdParalelo = new DevExpress.XtraEditors.LabelControl();
            this.lblCodParalelo = new DevExpress.XtraEditors.LabelControl();
            this.lblIDCurso = new DevExpress.XtraEditors.LabelControl();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.txtIdParalelo = new DevExpress.XtraEditors.TextEdit();
            this.txtCodParalelo = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.cmbCurso = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaCursoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionCurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.lblSede = new DevExpress.XtraEditors.LabelControl();
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
            this.colEstado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblInstitucion = new DevExpress.XtraEditors.LabelControl();
            this.cmbJornada = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaJornadaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdJornada1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionJornada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblIdJornada = new DevExpress.XtraEditors.LabelControl();
            this.cmbSeccion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaSeccionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSeccion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionSeccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblIdSeccion = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdParalelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodParalelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCursoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSede.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSedeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstitucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJornada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaJornadaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSeccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSeccionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(684, 39);
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
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 410);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(684, 28);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 3;
            // 
            // lblIdParalelo
            // 
            this.lblIdParalelo.Location = new System.Drawing.Point(33, 90);
            this.lblIdParalelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblIdParalelo.Name = "lblIdParalelo";
            this.lblIdParalelo.Size = new System.Drawing.Size(66, 16);
            this.lblIdParalelo.TabIndex = 4;
            this.lblIdParalelo.Text = "Id Paralelo:";
            // 
            // lblCodParalelo
            // 
            this.lblCodParalelo.Location = new System.Drawing.Point(33, 122);
            this.lblCodParalelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCodParalelo.Name = "lblCodParalelo";
            this.lblCodParalelo.Size = new System.Drawing.Size(94, 16);
            this.lblCodParalelo.TabIndex = 5;
            this.lblCodParalelo.Text = "Código Paralelo:";
            // 
            // lblIDCurso
            // 
            this.lblIDCurso.Location = new System.Drawing.Point(36, 287);
            this.lblIDCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblIDCurso.Name = "lblIDCurso";
            this.lblIDCurso.Size = new System.Drawing.Size(38, 16);
            this.lblIDCurso.TabIndex = 6;
            this.lblIDCurso.Text = "Curso:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(36, 314);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(70, 16);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(549, 380);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Size = new System.Drawing.Size(75, 21);
            this.chkActivo.TabIndex = 8;
            // 
            // txtIdParalelo
            // 
            this.txtIdParalelo.Location = new System.Drawing.Point(149, 86);
            this.txtIdParalelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdParalelo.Name = "txtIdParalelo";
            this.txtIdParalelo.Size = new System.Drawing.Size(299, 22);
            this.txtIdParalelo.TabIndex = 9;
            // 
            // txtCodParalelo
            // 
            this.txtCodParalelo.Location = new System.Drawing.Point(149, 118);
            this.txtCodParalelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodParalelo.Name = "txtCodParalelo";
            this.txtCodParalelo.Size = new System.Drawing.Size(299, 22);
            this.txtCodParalelo.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(149, 310);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(494, 22);
            this.txtDescripcion.TabIndex = 11;
            // 
            // cmbCurso
            // 
            this.cmbCurso.Location = new System.Drawing.Point(149, 278);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCurso.Properties.DataSource = this.acaCursoInfoBindingSource;
            this.cmbCurso.Properties.DisplayMember = "DescripcionCurso";
            this.cmbCurso.Properties.ValueMember = "IdCurso";
            this.cmbCurso.Properties.View = this.searchLookUpEdit1View;
            this.cmbCurso.Size = new System.Drawing.Size(299, 22);
            this.cmbCurso.TabIndex = 12;
            // 
            // acaCursoInfoBindingSource
            // 
            this.acaCursoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Curso_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCurso,
            this.colDescripcionCurso});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCurso
            // 
            this.colIdCurso.Caption = "Código";
            this.colIdCurso.FieldName = "IdCurso";
            this.colIdCurso.Name = "colIdCurso";
            this.colIdCurso.OptionsColumn.AllowEdit = false;
            this.colIdCurso.Visible = true;
            this.colIdCurso.VisibleIndex = 0;
            this.colIdCurso.Width = 136;
            // 
            // colDescripcionCurso
            // 
            this.colDescripcionCurso.Caption = "Descripción";
            this.colDescripcionCurso.FieldName = "DescripcionCurso";
            this.colDescripcionCurso.Name = "colDescripcionCurso";
            this.colDescripcionCurso.OptionsColumn.AllowEdit = false;
            this.colDescripcionCurso.Visible = true;
            this.colDescripcionCurso.VisibleIndex = 1;
            this.colDescripcionCurso.Width = 1038;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(354, 380);
            this.lblAnulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(170, 25);
            this.lblAnulado.TabIndex = 46;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // lblSede
            // 
            this.lblSede.Location = new System.Drawing.Point(33, 186);
            this.lblSede.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(34, 16);
            this.lblSede.TabIndex = 72;
            this.lblSede.Text = "Sede:";
            // 
            // cmbSede
            // 
            this.cmbSede.Location = new System.Drawing.Point(149, 182);
            this.cmbSede.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSede.Properties.DataSource = this.acaSedeInfoBindingSource;
            this.cmbSede.Properties.DisplayMember = "DescripcionSede";
            this.cmbSede.Properties.ValueMember = "IdSede";
            this.cmbSede.Properties.View = this.gridView2;
            this.cmbSede.Size = new System.Drawing.Size(299, 22);
            this.cmbSede.TabIndex = 71;
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
            this.colIdSede1.Width = 152;
            // 
            // colDescripcionSede
            // 
            this.colDescripcionSede.Caption = "Descripción";
            this.colDescripcionSede.FieldName = "DescripcionSede";
            this.colDescripcionSede.Name = "colDescripcionSede";
            this.colDescripcionSede.OptionsColumn.AllowEdit = false;
            this.colDescripcionSede.Visible = true;
            this.colDescripcionSede.VisibleIndex = 1;
            this.colDescripcionSede.Width = 1022;
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.Location = new System.Drawing.Point(149, 150);
            this.cmbInstitucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInstitucion.Properties.DataSource = this.acaInstitucionInfoBindingSource;
            this.cmbInstitucion.Properties.DisplayMember = "Nombre";
            this.cmbInstitucion.Properties.ReadOnly = true;
            this.cmbInstitucion.Properties.ValueMember = "IdInstitucion";
            this.cmbInstitucion.Properties.View = this.gridView1;
            this.cmbInstitucion.Size = new System.Drawing.Size(299, 22);
            this.cmbInstitucion.TabIndex = 70;
            // 
            // acaInstitucionInfoBindingSource
            // 
            this.acaInstitucionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Institucion_Info);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdInstitucion,
            this.colNombre,
            this.colEstado1});
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
            this.colIdInstitucion.Width = 179;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 995;
            // 
            // colEstado1
            // 
            this.colEstado1.FieldName = "Estado";
            this.colEstado1.Name = "colEstado1";
            this.colEstado1.OptionsColumn.AllowEdit = false;
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.Location = new System.Drawing.Point(33, 151);
            this.lblInstitucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(63, 16);
            this.lblInstitucion.TabIndex = 69;
            this.lblInstitucion.Text = "Institución:";
            // 
            // cmbJornada
            // 
            this.cmbJornada.Location = new System.Drawing.Point(149, 214);
            this.cmbJornada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbJornada.Name = "cmbJornada";
            this.cmbJornada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbJornada.Properties.DataSource = this.acaJornadaInfoBindingSource;
            this.cmbJornada.Properties.DisplayMember = "DescripcionJornada";
            this.cmbJornada.Properties.ValueMember = "IdJornada";
            this.cmbJornada.Properties.View = this.gridView3;
            this.cmbJornada.Size = new System.Drawing.Size(299, 22);
            this.cmbJornada.TabIndex = 68;
            this.cmbJornada.EditValueChanged += new System.EventHandler(this.cmbJornada_EditValueChanged);
            // 
            // acaJornadaInfoBindingSource
            // 
            this.acaJornadaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Jornada_Info);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdJornada1,
            this.colDescripcionJornada});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdJornada1
            // 
            this.colIdJornada1.Caption = "Código";
            this.colIdJornada1.FieldName = "IdJornada";
            this.colIdJornada1.Name = "colIdJornada1";
            this.colIdJornada1.OptionsColumn.AllowEdit = false;
            this.colIdJornada1.Visible = true;
            this.colIdJornada1.VisibleIndex = 0;
            this.colIdJornada1.Width = 164;
            // 
            // colDescripcionJornada
            // 
            this.colDescripcionJornada.Caption = "Descripción";
            this.colDescripcionJornada.FieldName = "DescripcionJornada";
            this.colDescripcionJornada.Name = "colDescripcionJornada";
            this.colDescripcionJornada.OptionsColumn.AllowEdit = false;
            this.colDescripcionJornada.Visible = true;
            this.colDescripcionJornada.VisibleIndex = 1;
            this.colDescripcionJornada.Width = 1010;
            // 
            // lblIdJornada
            // 
            this.lblIdJornada.Location = new System.Drawing.Point(33, 218);
            this.lblIdJornada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblIdJornada.Name = "lblIdJornada";
            this.lblIdJornada.Size = new System.Drawing.Size(50, 16);
            this.lblIdJornada.TabIndex = 67;
            this.lblIdJornada.Text = "Jornada:";
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.Location = new System.Drawing.Point(149, 246);
            this.cmbSeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSeccion.Properties.DataSource = this.acaSeccionInfoBindingSource;
            this.cmbSeccion.Properties.DisplayMember = "DescripcionSeccion";
            this.cmbSeccion.Properties.ValueMember = "IdSeccion";
            this.cmbSeccion.Properties.View = this.gridView4;
            this.cmbSeccion.Size = new System.Drawing.Size(299, 22);
            this.cmbSeccion.TabIndex = 66;
            this.cmbSeccion.EditValueChanged += new System.EventHandler(this.cmbSeccion_EditValueChanged);
            // 
            // acaSeccionInfoBindingSource
            // 
            this.acaSeccionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Seccion_Info);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSeccion1,
            this.colDescripcionSeccion});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSeccion1
            // 
            this.colIdSeccion1.Caption = "Código";
            this.colIdSeccion1.FieldName = "IdSeccion";
            this.colIdSeccion1.Name = "colIdSeccion1";
            this.colIdSeccion1.OptionsColumn.AllowEdit = false;
            this.colIdSeccion1.Visible = true;
            this.colIdSeccion1.VisibleIndex = 0;
            this.colIdSeccion1.Width = 143;
            // 
            // colDescripcionSeccion
            // 
            this.colDescripcionSeccion.Caption = "Descripción";
            this.colDescripcionSeccion.FieldName = "DescripcionSeccion";
            this.colDescripcionSeccion.Name = "colDescripcionSeccion";
            this.colDescripcionSeccion.OptionsColumn.AllowEdit = false;
            this.colDescripcionSeccion.Visible = true;
            this.colDescripcionSeccion.VisibleIndex = 1;
            this.colDescripcionSeccion.Width = 1031;
            // 
            // lblIdSeccion
            // 
            this.lblIdSeccion.Location = new System.Drawing.Point(33, 255);
            this.lblIdSeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblIdSeccion.Name = "lblIdSeccion";
            this.lblIdSeccion.Size = new System.Drawing.Size(49, 16);
            this.lblIdSeccion.TabIndex = 65;
            this.lblIdSeccion.Text = "Sección:";
            // 
            // FrmAcaParalelo_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 438);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.cmbSede);
            this.Controls.Add(this.cmbInstitucion);
            this.Controls.Add(this.lblInstitucion);
            this.Controls.Add(this.cmbJornada);
            this.Controls.Add(this.lblIdJornada);
            this.Controls.Add(this.cmbSeccion);
            this.Controls.Add(this.lblIdSeccion);
            this.Controls.Add(this.lblAnulado);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodParalelo);
            this.Controls.Add(this.txtIdParalelo);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblIDCurso);
            this.Controls.Add(this.lblCodParalelo);
            this.Controls.Add(this.lblIdParalelo);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAcaParalelo_Mant";
            this.Text = "FrmAcaParalelo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcaParalelo_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAcaParalelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdParalelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodParalelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCursoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSede.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSedeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstitucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJornada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaJornadaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSeccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSeccionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraEditors.LabelControl lblIdParalelo;
        private DevExpress.XtraEditors.LabelControl lblCodParalelo;
        private DevExpress.XtraEditors.LabelControl lblIDCurso;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private DevExpress.XtraEditors.TextEdit txtIdParalelo;
        private DevExpress.XtraEditors.TextEdit txtCodParalelo;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCurso;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.LabelControl lblSede;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSede;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbInstitucion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblInstitucion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbJornada;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl lblIdJornada;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSeccion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.LabelControl lblIdSeccion;
        private System.Windows.Forms.BindingSource acaInstitucionInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdInstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado1;
        private System.Windows.Forms.BindingSource acaSedeInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSede1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionSede;
        private System.Windows.Forms.BindingSource acaJornadaInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdJornada1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionJornada;
        private System.Windows.Forms.BindingSource acaSeccionInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSeccion1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionSeccion;
        private System.Windows.Forms.BindingSource acaCursoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCurso;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionCurso;
    }
}