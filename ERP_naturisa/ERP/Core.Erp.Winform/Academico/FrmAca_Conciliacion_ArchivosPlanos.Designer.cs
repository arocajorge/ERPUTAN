namespace Core.Erp.Winform.Academico
{
    partial class FrmAca_Conciliacion_ArchivosPlanos
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_caja = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Co_ca_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ucAca_SedeJornadaSeccionCurso = new Core.Erp.Winform.Controles.UCAca_SedeJornadaSeccionCurso();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.cmb_periodo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColDescripcionProcesoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_anio_lectivo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ucBa_Proceso = new Core.Erp.Winform.Controles.UCBa_Proceso_x_Banco();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_pre_fac = new DevExpress.XtraGrid.GridControl();
            this.gridView_pre_fac = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_cedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_nombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_observacion_det = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_vt_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_valor_debitado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_estado = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_ca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_CodigoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Documento_excel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_valor_Procesado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_EstadoRespuesta = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_caja.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_periodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_anio_lectivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_pre_fac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_pre_fac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
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
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1365, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
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
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 460);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1365, 28);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cmb_caja);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.ucAca_SedeJornadaSeccionCurso);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtObservacion);
            this.groupControl1.Controls.Add(this.cmb_periodo);
            this.groupControl1.Controls.Add(this.cmb_anio_lectivo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.ucBa_Proceso);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1365, 124);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Parametros";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(485, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 175;
            this.labelControl3.Text = "Observacion:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(485, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 174;
            this.labelControl2.Text = "Caja:";
            // 
            // cmb_caja
            // 
            this.cmb_caja.Location = new System.Drawing.Point(558, 72);
            this.cmb_caja.Name = "cmb_caja";
            this.cmb_caja.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_caja.Properties.DisplayMember = "ca_Descripcion";
            this.cmb_caja.Properties.ValueMember = "IdCaja";
            this.cmb_caja.Properties.View = this.gridView2;
            this.cmb_caja.Size = new System.Drawing.Size(227, 20);
            this.cmb_caja.TabIndex = 173;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Co_ca_Descripcion});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // Co_ca_Descripcion
            // 
            this.Co_ca_Descripcion.Caption = "Caja";
            this.Co_ca_Descripcion.FieldName = "ca_Descripcion";
            this.Co_ca_Descripcion.Name = "Co_ca_Descripcion";
            this.Co_ca_Descripcion.Visible = true;
            this.Co_ca_Descripcion.VisibleIndex = 0;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(2, 97);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(32, 13);
            this.labelControl10.TabIndex = 172;
            this.labelControl10.Text = "Curso:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(2, 75);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(40, 13);
            this.labelControl9.TabIndex = 171;
            this.labelControl9.Text = "Secciòn:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(2, 53);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 13);
            this.labelControl8.TabIndex = 170;
            this.labelControl8.Text = "Jornada:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(2, 33);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 13);
            this.labelControl7.TabIndex = 169;
            this.labelControl7.Text = "Sede:";
            // 
            // ucAca_SedeJornadaSeccionCurso
            // 
            this.ucAca_SedeJornadaSeccionCurso.Location = new System.Drawing.Point(73, 23);
            this.ucAca_SedeJornadaSeccionCurso.Name = "ucAca_SedeJornadaSeccionCurso";
            this.ucAca_SedeJornadaSeccionCurso.Size = new System.Drawing.Size(366, 88);
            this.ucAca_SedeJornadaSeccionCurso.TabIndex = 168;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(706, 25);
            this.txtId.Name = "txtId";
            this.txtId.Properties.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(70, 20);
            this.txtId.TabIndex = 161;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(643, 28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 13);
            this.labelControl4.TabIndex = 160;
            this.labelControl4.Text = "Id Registro:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(558, 97);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(566, 22);
            this.txtObservacion.TabIndex = 156;
            // 
            // cmb_periodo
            // 
            this.cmb_periodo.Location = new System.Drawing.Point(560, 46);
            this.cmb_periodo.Name = "cmb_periodo";
            this.cmb_periodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_periodo.Properties.DisplayMember = "pe_Descripcion";
            this.cmb_periodo.Properties.ReadOnly = true;
            this.cmb_periodo.Properties.ValueMember = "IdPeriodo";
            this.cmb_periodo.Properties.View = this.gridView1;
            this.cmb_periodo.Size = new System.Drawing.Size(216, 20);
            this.cmb_periodo.TabIndex = 153;
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
            this.ColDescripcionProcesoNomina.FieldName = "pe_Descripcion";
            this.ColDescripcionProcesoNomina.Name = "ColDescripcionProcesoNomina";
            this.ColDescripcionProcesoNomina.Visible = true;
            this.ColDescripcionProcesoNomina.VisibleIndex = 0;
            // 
            // cmb_anio_lectivo
            // 
            this.cmb_anio_lectivo.Location = new System.Drawing.Point(558, 25);
            this.cmb_anio_lectivo.Name = "cmb_anio_lectivo";
            this.cmb_anio_lectivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_anio_lectivo.Properties.DisplayMember = "Descripcion";
            this.cmb_anio_lectivo.Properties.ReadOnly = true;
            this.cmb_anio_lectivo.Properties.ValueMember = "IdAnioLectivo";
            this.cmb_anio_lectivo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_anio_lectivo.Size = new System.Drawing.Size(79, 20);
            this.cmb_anio_lectivo.TabIndex = 152;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColDescripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.Caption = "Nomina";
            this.ColDescripcion.FieldName = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.Visible = true;
            this.ColDescripcion.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(485, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 151;
            this.labelControl1.Text = "Periodo:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(485, 32);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 13);
            this.labelControl5.TabIndex = 149;
            this.labelControl5.Text = "Año Lectivo:";
            // 
            // ucBa_Proceso
            // 
            this.ucBa_Proceso.Location = new System.Drawing.Point(791, 25);
            this.ucBa_Proceso.Name = "ucBa_Proceso";
            this.ucBa_Proceso.Size = new System.Drawing.Size(335, 48);
            this.ucBa_Proceso.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl_pre_fac);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 153);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1365, 307);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Detalle";
            // 
            // gridControl_pre_fac
            // 
            this.gridControl_pre_fac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_pre_fac.Location = new System.Drawing.Point(2, 21);
            this.gridControl_pre_fac.MainView = this.gridView_pre_fac;
            this.gridControl_pre_fac.Name = "gridControl_pre_fac";
            this.gridControl_pre_fac.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_estado});
            this.gridControl_pre_fac.Size = new System.Drawing.Size(1361, 284);
            this.gridControl_pre_fac.TabIndex = 2;
            this.gridControl_pre_fac.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_pre_fac});
            // 
            // gridView_pre_fac
            // 
            this.gridView_pre_fac.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView_pre_fac.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView_pre_fac.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView_pre_fac.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView_pre_fac.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView_pre_fac.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView_pre_fac.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView_pre_fac.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gridView_pre_fac.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView_pre_fac.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView_pre_fac.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView_pre_fac.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView_pre_fac.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView_pre_fac.Appearance.Empty.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gridView_pre_fac.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_pre_fac.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView_pre_fac.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView_pre_fac.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView_pre_fac.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView_pre_fac.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView_pre_fac.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView_pre_fac.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridView_pre_fac.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView_pre_fac.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gridView_pre_fac.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView_pre_fac.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView_pre_fac.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gridView_pre_fac.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView_pre_fac.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView_pre_fac.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView_pre_fac.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView_pre_fac.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_pre_fac.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView_pre_fac.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView_pre_fac.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView_pre_fac.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView_pre_fac.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView_pre_fac.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView_pre_fac.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView_pre_fac.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView_pre_fac.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView_pre_fac.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView_pre_fac.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridView_pre_fac.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView_pre_fac.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView_pre_fac.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView_pre_fac.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView_pre_fac.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_pre_fac.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView_pre_fac.Appearance.GroupRow.Options.UseFont = true;
            this.gridView_pre_fac.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView_pre_fac.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView_pre_fac.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView_pre_fac.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_pre_fac.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView_pre_fac.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView_pre_fac.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gridView_pre_fac.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gridView_pre_fac.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridView_pre_fac.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView_pre_fac.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_pre_fac.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gridView_pre_fac.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gridView_pre_fac.Appearance.Preview.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.Preview.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView_pre_fac.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView_pre_fac.Appearance.Row.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.Row.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView_pre_fac.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gridView_pre_fac.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView_pre_fac.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView_pre_fac.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView_pre_fac.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridView_pre_fac.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView_pre_fac.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Factura,
            this.Col_pe_cedulaRuc,
            this.Col_pe_nombreCompleto,
            this.Col_observacion_det,
            this.Col_vt_total,
            this.Col_Documento,
            this.Col_valor_debitado,
            this.Col_Estado,
            this.Col_CodigoCliente,
            this.Col_Documento_excel,
            this.Col_valor_Procesado,
            this.Col_EstadoRespuesta});
            this.gridView_pre_fac.GridControl = this.gridControl_pre_fac;
            this.gridView_pre_fac.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "vt_Precio", this.Col_vt_total, "{0:C}")});
            this.gridView_pre_fac.Name = "gridView_pre_fac";
            this.gridView_pre_fac.OptionsView.ColumnAutoWidth = false;
            this.gridView_pre_fac.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView_pre_fac.OptionsView.EnableAppearanceOddRow = true;
            this.gridView_pre_fac.OptionsView.ShowAutoFilterRow = true;
            this.gridView_pre_fac.OptionsView.ShowFooter = true;
            this.gridView_pre_fac.OptionsView.ShowGroupedColumns = true;
            this.gridView_pre_fac.OptionsView.ShowGroupPanel = false;
            this.gridView_pre_fac.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_pre_fac_KeyDown);
            // 
            // Col_Factura
            // 
            this.Col_Factura.Caption = "#Factura";
            this.Col_Factura.FieldName = "Factura";
            this.Col_Factura.Name = "Col_Factura";
            this.Col_Factura.OptionsColumn.AllowEdit = false;
            this.Col_Factura.Visible = true;
            this.Col_Factura.VisibleIndex = 0;
            this.Col_Factura.Width = 87;
            // 
            // Col_pe_cedulaRuc
            // 
            this.Col_pe_cedulaRuc.Caption = "Cedula";
            this.Col_pe_cedulaRuc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_pe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.Col_pe_cedulaRuc.Name = "Col_pe_cedulaRuc";
            this.Col_pe_cedulaRuc.OptionsColumn.AllowEdit = false;
            this.Col_pe_cedulaRuc.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.Col_pe_cedulaRuc.Visible = true;
            this.Col_pe_cedulaRuc.VisibleIndex = 1;
            this.Col_pe_cedulaRuc.Width = 80;
            // 
            // Col_pe_nombreCompleto
            // 
            this.Col_pe_nombreCompleto.Caption = " Estudiante";
            this.Col_pe_nombreCompleto.FieldName = "Nombre";
            this.Col_pe_nombreCompleto.Name = "Col_pe_nombreCompleto";
            this.Col_pe_nombreCompleto.OptionsColumn.AllowEdit = false;
            this.Col_pe_nombreCompleto.Visible = true;
            this.Col_pe_nombreCompleto.VisibleIndex = 2;
            this.Col_pe_nombreCompleto.Width = 205;
            // 
            // Col_observacion_det
            // 
            this.Col_observacion_det.Caption = "Rubro";
            this.Col_observacion_det.FieldName = "observacion_det";
            this.Col_observacion_det.Name = "Col_observacion_det";
            this.Col_observacion_det.OptionsColumn.AllowEdit = false;
            this.Col_observacion_det.Visible = true;
            this.Col_observacion_det.VisibleIndex = 3;
            this.Col_observacion_det.Width = 180;
            // 
            // Col_vt_total
            // 
            this.Col_vt_total.Caption = "Valor Enviado";
            this.Col_vt_total.DisplayFormat.FormatString = "{0:C}";
            this.Col_vt_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_vt_total.FieldName = "vt_Precio";
            this.Col_vt_total.Name = "Col_vt_total";
            this.Col_vt_total.OptionsColumn.AllowEdit = false;
            this.Col_vt_total.Visible = true;
            this.Col_vt_total.VisibleIndex = 4;
            this.Col_vt_total.Width = 90;
            // 
            // Col_Documento
            // 
            this.Col_Documento.Caption = "#Doc. Debita";
            this.Col_Documento.FieldName = "Numero_Documento";
            this.Col_Documento.Name = "Col_Documento";
            this.Col_Documento.OptionsColumn.AllowEdit = false;
            this.Col_Documento.Visible = true;
            this.Col_Documento.VisibleIndex = 5;
            this.Col_Documento.Width = 86;
            // 
            // Col_valor_debitado
            // 
            this.Col_valor_debitado.Caption = "Valor Acreditado";
            this.Col_valor_debitado.FieldName = "Valor";
            this.Col_valor_debitado.Name = "Col_valor_debitado";
            this.Col_valor_debitado.OptionsColumn.AllowEdit = false;
            this.Col_valor_debitado.Visible = true;
            this.Col_valor_debitado.VisibleIndex = 6;
            this.Col_valor_debitado.Width = 93;
            // 
            // Col_Estado
            // 
            this.Col_Estado.Caption = "Estado Actual";
            this.Col_Estado.ColumnEdit = this.cmb_estado;
            this.Col_Estado.FieldName = "IdEstadoRegistro_cat";
            this.Col_Estado.Name = "Col_Estado";
            this.Col_Estado.OptionsColumn.AllowEdit = false;
            this.Col_Estado.Visible = true;
            this.Col_Estado.VisibleIndex = 7;
            this.Col_Estado.Width = 94;
            // 
            // cmb_estado
            // 
            this.cmb_estado.AutoHeight = false;
            this.cmb_estado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_ca_descripcion});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Col_ca_descripcion
            // 
            this.Col_ca_descripcion.Caption = "Estado";
            this.Col_ca_descripcion.FieldName = "ca_descripcion";
            this.Col_ca_descripcion.Name = "Col_ca_descripcion";
            this.Col_ca_descripcion.Visible = true;
            this.Col_ca_descripcion.VisibleIndex = 0;
            // 
            // Col_CodigoCliente
            // 
            this.Col_CodigoCliente.Caption = "Cod. Cliente";
            this.Col_CodigoCliente.FieldName = "CodigoCliente";
            this.Col_CodigoCliente.Name = "Col_CodigoCliente";
            this.Col_CodigoCliente.Visible = true;
            this.Col_CodigoCliente.VisibleIndex = 8;
            // 
            // Col_Documento_excel
            // 
            this.Col_Documento_excel.Caption = "T-C /#Cuenta";
            this.Col_Documento_excel.FieldName = "NumCuenta_Respuesta";
            this.Col_Documento_excel.Name = "Col_Documento_excel";
            this.Col_Documento_excel.Visible = true;
            this.Col_Documento_excel.VisibleIndex = 9;
            this.Col_Documento_excel.Width = 94;
            // 
            // Col_valor_Procesado
            // 
            this.Col_valor_Procesado.Caption = "Valor Procesado";
            this.Col_valor_Procesado.FieldName = "Valor_procesado";
            this.Col_valor_Procesado.Name = "Col_valor_Procesado";
            this.Col_valor_Procesado.Visible = true;
            this.Col_valor_Procesado.VisibleIndex = 11;
            this.Col_valor_Procesado.Width = 109;
            // 
            // Col_EstadoRespuesta
            // 
            this.Col_EstadoRespuesta.Caption = "Estado respuesta";
            this.Col_EstadoRespuesta.FieldName = "EstadoRespuesta";
            this.Col_EstadoRespuesta.Name = "Col_EstadoRespuesta";
            this.Col_EstadoRespuesta.Visible = true;
            this.Col_EstadoRespuesta.VisibleIndex = 10;
            this.Col_EstadoRespuesta.Width = 93;
            // 
            // FrmAca_Conciliacion_ArchivosPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 488);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAca_Conciliacion_ArchivosPlanos";
            this.Text = "FrmAca_Conciliacion_ArchivosPlanos";
            this.Load += new System.EventHandler(this.FrmAca_Conciliacion_ArchivosPlanos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_caja.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_periodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_anio_lectivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_pre_fac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_pre_fac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Controles.UCAca_SedeJornadaSeccionCurso ucAca_SedeJornadaSeccionCurso;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtObservacion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_periodo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcionProcesoNomina;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_anio_lectivo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Controles.UCBa_Proceso_x_Banco ucBa_Proceso;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl_pre_fac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_pre_fac;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_cedulaRuc;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_nombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn Col_observacion_det;
        private DevExpress.XtraGrid.Columns.GridColumn Col_vt_total;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Documento;
        private DevExpress.XtraGrid.Columns.GridColumn Col_valor_debitado;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Documento_excel;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Col_valor_Procesado;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Factura;
        private DevExpress.XtraGrid.Columns.GridColumn Col_CodigoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn Col_EstadoRespuesta;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_estado;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ca_descripcion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_caja;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Co_ca_Descripcion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}