namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaMatricula_Mant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcaMatricula_Mant));
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.deFechaMatricula = new DevExpress.XtraEditors.DateEdit();
            this.lblFechaMatricula = new DevExpress.XtraEditors.LabelControl();
            this.lblEstudiante = new DevExpress.XtraEditors.LabelControl();
            this.lblObservacion = new DevExpress.XtraEditors.LabelControl();
            this.chkEstado = new DevExpress.XtraEditors.CheckEdit();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.ucAca_Estudiante = new Core.Erp.Winform.Controles.UCAca_Estudiante();
            this.cmbAnioLectivo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaPeriodoLectivoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdInstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPeriodoLectivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblPeriodoLectivo = new DevExpress.XtraEditors.LabelControl();
            this.lblCodMatricula = new DevExpress.XtraEditors.LabelControl();
            this.lblIdMatricula = new DevExpress.XtraEditors.LabelControl();
            this.txtCodMatricula = new DevExpress.XtraEditors.TextEdit();
            this.txtIdMatricula = new DevExpress.XtraEditors.TextEdit();
            this.txtObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.xtraTabControlMatricula = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageAsignacionDeClases = new DevExpress.XtraTab.XtraTabPage();
            this.lblParalelo = new DevExpress.XtraEditors.LabelControl();
            this.lblCurso = new DevExpress.XtraEditors.LabelControl();
            this.lblSeccion = new DevExpress.XtraEditors.LabelControl();
            this.lblJornada = new DevExpress.XtraEditors.LabelControl();
            this.lblSede = new DevExpress.XtraEditors.LabelControl();
            this.ucAca_SedeJornadaSeccionCurso = new Core.Erp.Winform.Controles.UCAca_SedeJornadaSeccionCurso();
            this.xtraTabPagePadre = new DevExpress.XtraTab.XtraTabPage();
            this.ucAca_Familiar_x_EstudiantePadre = new Core.Erp.Winform.Controles.UCAca_Familiar_x_Estudiante();
            this.xtraTabPageMadre = new DevExpress.XtraTab.XtraTabPage();
            this.ucAca_Familiar_x_EstudianteMadre = new Core.Erp.Winform.Controles.UCAca_Familiar_x_Estudiante();
            this.xtraTabPageRepresentanteLegal = new DevExpress.XtraTab.XtraTabPage();
            this.ucAca_Familiar_x_EstudianteRL = new Core.Erp.Winform.Controles.UCAca_Familiar_x_Estudiante();
            this.xtraTabPageRespresentanteEco = new DevExpress.XtraTab.XtraTabPage();
            this.ucAca_Familiar_x_EstudianteRE = new Core.Erp.Winform.Controles.UCAca_Familiar_x_Estudiante();
            this.xtraTabPageDocBancRepEco = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_Dco_bancario = new DevExpress.XtraGrid.GridControl();
            this.gridView_Dco_bancario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_IdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_banco = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_ba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_forma_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_forma_pago = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Tipo_documento_cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_tipo_Doc = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Numero_Documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Fecha_Expiracion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.xtraTabPageAcuerdos = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdb_Si_estoy_deacuerdo_foto = new System.Windows.Forms.RadioButton();
            this.rdb_No_estoy_deacuerdo_foto = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCodConvivencia = new DevExpress.XtraEditors.LabelControl();
            this.lblDeclaracion = new DevExpress.XtraEditors.LabelControl();
            this.chkCodigoConvivencia = new DevExpress.XtraEditors.CheckEdit();
            this.xtraTabPageDocumentos = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlMatriculaDocumentos = new DevExpress.XtraGrid.GridControl();
            this.acaMatriculaxDocumentoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewMatriculaDocumento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdInstitucion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSede = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Link = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.colFechaAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArchivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExiste_en_Base = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPageSistemaDual = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageSistemaDualRepEco = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPorecentajeDual = new DevExpress.XtraEditors.TextEdit();
            this.txtNumDocumentoBancario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaExpiracion = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTipoMecanismoPago = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColId_tipo_meca_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTIpoMecanismo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColId_tb_banco_x_mgbanco_tipo_mecanismo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstadoTipoMecanismoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTipoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColForma_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbInstitucionFinanciera = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColId_tb_banco_x_mgbanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdBanco_Erp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdBanco_Academico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColInstitucionFinanciera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblCliente = new DevExpress.XtraEditors.LabelControl();
            this.ucFa_ClienteCmb1 = new Core.Erp.Winform.Controles.UCFa_ClienteCmb();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaMatricula.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaMatricula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnioLectivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaPeriodoLectivoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodMatricula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdMatricula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMatricula)).BeginInit();
            this.xtraTabControlMatricula.SuspendLayout();
            this.xtraTabPageAsignacionDeClases.SuspendLayout();
            this.xtraTabPagePadre.SuspendLayout();
            this.xtraTabPageMadre.SuspendLayout();
            this.xtraTabPageRepresentanteLegal.SuspendLayout();
            this.xtraTabPageRespresentanteEco.SuspendLayout();
            this.xtraTabPageDocBancRepEco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Dco_bancario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Dco_bancario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_forma_pago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_Doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            this.xtraTabPageAcuerdos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCodigoConvivencia.Properties)).BeginInit();
            this.xtraTabPageDocumentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMatriculaDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaMatriculaxDocumentoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMatriculaDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Link)).BeginInit();
            this.xtraTabPageSistemaDual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageSistemaDualRepEco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorecentajeDual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDocumentoBancario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaExpiracion.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaExpiracion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoMecanismoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstitucionFinanciera.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(801, 32);
            this.ucGe_Menu.TabIndex = 3;
            this.ucGe_Menu.Visible_bntAnular = true;
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
            this.ucGe_BarraEstadoInferior_Forms.Location = new System.Drawing.Point(0, 573);
            this.ucGe_BarraEstadoInferior_Forms.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_BarraEstadoInferior_Forms.Name = "ucGe_BarraEstadoInferior_Forms";
            this.ucGe_BarraEstadoInferior_Forms.Size = new System.Drawing.Size(801, 23);
            this.ucGe_BarraEstadoInferior_Forms.TabIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.deFechaMatricula);
            this.panelControl1.Controls.Add(this.lblFechaMatricula);
            this.panelControl1.Controls.Add(this.lblEstudiante);
            this.panelControl1.Controls.Add(this.lblObservacion);
            this.panelControl1.Controls.Add(this.chkEstado);
            this.panelControl1.Controls.Add(this.lblAnulado);
            this.panelControl1.Controls.Add(this.ucAca_Estudiante);
            this.panelControl1.Controls.Add(this.cmbAnioLectivo);
            this.panelControl1.Controls.Add(this.lblPeriodoLectivo);
            this.panelControl1.Controls.Add(this.lblCodMatricula);
            this.panelControl1.Controls.Add(this.lblIdMatricula);
            this.panelControl1.Controls.Add(this.txtCodMatricula);
            this.panelControl1.Controls.Add(this.txtIdMatricula);
            this.panelControl1.Controls.Add(this.txtObservacion);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 32);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(801, 131);
            this.panelControl1.TabIndex = 5;
            // 
            // deFechaMatricula
            // 
            this.deFechaMatricula.EditValue = null;
            this.deFechaMatricula.Location = new System.Drawing.Point(427, 43);
            this.deFechaMatricula.Name = "deFechaMatricula";
            this.deFechaMatricula.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaMatricula.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaMatricula.Size = new System.Drawing.Size(136, 20);
            this.deFechaMatricula.TabIndex = 17;
            // 
            // lblFechaMatricula
            // 
            this.lblFechaMatricula.Location = new System.Drawing.Point(342, 46);
            this.lblFechaMatricula.Name = "lblFechaMatricula";
            this.lblFechaMatricula.Size = new System.Drawing.Size(79, 13);
            this.lblFechaMatricula.TabIndex = 16;
            this.lblFechaMatricula.Text = "Fecha Matricula:";
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.Location = new System.Drawing.Point(8, 69);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(55, 13);
            this.lblEstudiante.TabIndex = 15;
            this.lblEstudiante.Text = "Estudiante:";
            // 
            // lblObservacion
            // 
            this.lblObservacion.Location = new System.Drawing.Point(8, 94);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(64, 13);
            this.lblObservacion.TabIndex = 13;
            this.lblObservacion.Text = "Observación:";
            // 
            // chkEstado
            // 
            this.chkEstado.Location = new System.Drawing.Point(722, 66);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Properties.Caption = "Activo";
            this.chkEstado.Size = new System.Drawing.Size(64, 19);
            this.chkEstado.TabIndex = 12;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(580, 66);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(136, 20);
            this.lblAnulado.TabIndex = 11;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // ucAca_Estudiante
            // 
            this.ucAca_Estudiante.Location = new System.Drawing.Point(101, 63);
            this.ucAca_Estudiante.Margin = new System.Windows.Forms.Padding(4);
            this.ucAca_Estudiante.Name = "ucAca_Estudiante";
            this.ucAca_Estudiante.Size = new System.Drawing.Size(280, 26);
            this.ucAca_Estudiante.TabIndex = 10;
            // 
            // cmbAnioLectivo
            // 
            this.cmbAnioLectivo.Location = new System.Drawing.Point(104, 43);
            this.cmbAnioLectivo.Name = "cmbAnioLectivo";
            this.cmbAnioLectivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAnioLectivo.Properties.DataSource = this.acaPeriodoLectivoInfoBindingSource;
            this.cmbAnioLectivo.Properties.DisplayMember = "Descripcion";
            this.cmbAnioLectivo.Properties.ValueMember = "IdPeriodoLectivo";
            this.cmbAnioLectivo.Properties.View = this.searchLookUpEdit1View;
            this.cmbAnioLectivo.Size = new System.Drawing.Size(193, 20);
            this.cmbAnioLectivo.TabIndex = 5;
            // 
            // acaPeriodoLectivoInfoBindingSource
            // 
            this.acaPeriodoLectivoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Anio_Lectivo_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdInstitucion,
            this.colIdPeriodoLectivo,
            this.colDescripcion,
            this.colFechaInicio,
            this.colFechaFin,
            this.colEstado});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdInstitucion
            // 
            this.colIdInstitucion.FieldName = "IdInstitucion";
            this.colIdInstitucion.Name = "colIdInstitucion";
            this.colIdInstitucion.OptionsColumn.AllowEdit = false;
            // 
            // colIdPeriodoLectivo
            // 
            this.colIdPeriodoLectivo.FieldName = "IdPeriodoLectivo";
            this.colIdPeriodoLectivo.Name = "colIdPeriodoLectivo";
            this.colIdPeriodoLectivo.OptionsColumn.AllowEdit = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 1061;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.FieldName = "FechaInicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.OptionsColumn.AllowEdit = false;
            // 
            // colFechaFin
            // 
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.OptionsColumn.AllowEdit = false;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 1;
            this.colEstado.Width = 97;
            // 
            // lblPeriodoLectivo
            // 
            this.lblPeriodoLectivo.Location = new System.Drawing.Point(8, 46);
            this.lblPeriodoLectivo.Name = "lblPeriodoLectivo";
            this.lblPeriodoLectivo.Size = new System.Drawing.Size(60, 13);
            this.lblPeriodoLectivo.TabIndex = 4;
            this.lblPeriodoLectivo.Text = "Año Lectivo:";
            // 
            // lblCodMatricula
            // 
            this.lblCodMatricula.Location = new System.Drawing.Point(8, 20);
            this.lblCodMatricula.Name = "lblCodMatricula";
            this.lblCodMatricula.Size = new System.Drawing.Size(58, 13);
            this.lblCodMatricula.TabIndex = 3;
            this.lblCodMatricula.Text = "# Matricula:";
            // 
            // lblIdMatricula
            // 
            this.lblIdMatricula.Location = new System.Drawing.Point(668, 20);
            this.lblIdMatricula.Name = "lblIdMatricula";
            this.lblIdMatricula.Size = new System.Drawing.Size(60, 13);
            this.lblIdMatricula.TabIndex = 2;
            this.lblIdMatricula.Text = "Id Matricula:";
            // 
            // txtCodMatricula
            // 
            this.txtCodMatricula.EditValue = "";
            this.txtCodMatricula.Location = new System.Drawing.Point(104, 17);
            this.txtCodMatricula.Name = "txtCodMatricula";
            this.txtCodMatricula.Size = new System.Drawing.Size(192, 20);
            this.txtCodMatricula.TabIndex = 1;
            // 
            // txtIdMatricula
            // 
            this.txtIdMatricula.EditValue = "0";
            this.txtIdMatricula.Location = new System.Drawing.Point(734, 13);
            this.txtIdMatricula.Name = "txtIdMatricula";
            this.txtIdMatricula.Size = new System.Drawing.Size(52, 20);
            this.txtIdMatricula.TabIndex = 0;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(104, 94);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(682, 31);
            this.txtObservacion.TabIndex = 14;
            // 
            // xtraTabControlMatricula
            // 
            this.xtraTabControlMatricula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlMatricula.Location = new System.Drawing.Point(0, 163);
            this.xtraTabControlMatricula.Name = "xtraTabControlMatricula";
            this.xtraTabControlMatricula.SelectedTabPage = this.xtraTabPageAsignacionDeClases;
            this.xtraTabControlMatricula.Size = new System.Drawing.Size(801, 410);
            this.xtraTabControlMatricula.TabIndex = 6;
            this.xtraTabControlMatricula.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageAsignacionDeClases,
            this.xtraTabPagePadre,
            this.xtraTabPageMadre,
            this.xtraTabPageRepresentanteLegal,
            this.xtraTabPageRespresentanteEco,
            this.xtraTabPageDocBancRepEco,
            this.xtraTabPageAcuerdos,
            this.xtraTabPageDocumentos,
            this.xtraTabPageSistemaDual});
            // 
            // xtraTabPageAsignacionDeClases
            // 
            this.xtraTabPageAsignacionDeClases.Controls.Add(this.lblParalelo);
            this.xtraTabPageAsignacionDeClases.Controls.Add(this.lblCurso);
            this.xtraTabPageAsignacionDeClases.Controls.Add(this.lblSeccion);
            this.xtraTabPageAsignacionDeClases.Controls.Add(this.lblJornada);
            this.xtraTabPageAsignacionDeClases.Controls.Add(this.lblSede);
            this.xtraTabPageAsignacionDeClases.Controls.Add(this.ucAca_SedeJornadaSeccionCurso);
            this.xtraTabPageAsignacionDeClases.Name = "xtraTabPageAsignacionDeClases";
            this.xtraTabPageAsignacionDeClases.Size = new System.Drawing.Size(795, 382);
            this.xtraTabPageAsignacionDeClases.Text = "Asignación de Clases";
            // 
            // lblParalelo
            // 
            this.lblParalelo.Location = new System.Drawing.Point(33, 154);
            this.lblParalelo.Name = "lblParalelo";
            this.lblParalelo.Size = new System.Drawing.Size(42, 13);
            this.lblParalelo.TabIndex = 20;
            this.lblParalelo.Text = "Paralelo:";
            // 
            // lblCurso
            // 
            this.lblCurso.Location = new System.Drawing.Point(33, 130);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(32, 13);
            this.lblCurso.TabIndex = 19;
            this.lblCurso.Text = "Curso:";
            // 
            // lblSeccion
            // 
            this.lblSeccion.Location = new System.Drawing.Point(33, 103);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(40, 13);
            this.lblSeccion.TabIndex = 18;
            this.lblSeccion.Text = "Sección:";
            // 
            // lblJornada
            // 
            this.lblJornada.Location = new System.Drawing.Point(30, 75);
            this.lblJornada.Name = "lblJornada";
            this.lblJornada.Size = new System.Drawing.Size(43, 13);
            this.lblJornada.TabIndex = 17;
            this.lblJornada.Text = "Jornada:";
            // 
            // lblSede
            // 
            this.lblSede.Location = new System.Drawing.Point(32, 49);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(28, 13);
            this.lblSede.TabIndex = 16;
            this.lblSede.Text = "Sede:";
            // 
            // ucAca_SedeJornadaSeccionCurso
            // 
            this.ucAca_SedeJornadaSeccionCurso.Location = new System.Drawing.Point(103, 42);
            this.ucAca_SedeJornadaSeccionCurso.Margin = new System.Windows.Forms.Padding(4);
            this.ucAca_SedeJornadaSeccionCurso.Name = "ucAca_SedeJornadaSeccionCurso";
            this.ucAca_SedeJornadaSeccionCurso.Size = new System.Drawing.Size(416, 132);
            this.ucAca_SedeJornadaSeccionCurso.TabIndex = 12;
            // 
            // xtraTabPagePadre
            // 
            this.xtraTabPagePadre.Controls.Add(this.ucAca_Familiar_x_EstudiantePadre);
            this.xtraTabPagePadre.Name = "xtraTabPagePadre";
            this.xtraTabPagePadre.Size = new System.Drawing.Size(795, 382);
            this.xtraTabPagePadre.Text = "Padre";
            // 
            // ucAca_Familiar_x_EstudiantePadre
            // 
            this.ucAca_Familiar_x_EstudiantePadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAca_Familiar_x_EstudiantePadre.IdEstudiante = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudiantePadre.IdFamiliar = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudiantePadre.IdParentestoFamiliar = "PADR";
            this.ucAca_Familiar_x_EstudiantePadre.Location = new System.Drawing.Point(0, 0);
            this.ucAca_Familiar_x_EstudiantePadre.Margin = new System.Windows.Forms.Padding(4);
            this.ucAca_Familiar_x_EstudiantePadre.matriculaInfo = null;
            this.ucAca_Familiar_x_EstudiantePadre.Mostrar_historico = false;
            this.ucAca_Familiar_x_EstudiantePadre.Name = "ucAca_Familiar_x_EstudiantePadre";
            this.ucAca_Familiar_x_EstudiantePadre.Size = new System.Drawing.Size(795, 382);
            this.ucAca_Familiar_x_EstudiantePadre.TabIndex = 0;
            this.ucAca_Familiar_x_EstudiantePadre.Visible_Page_InfoFinanciera = false;
            // 
            // xtraTabPageMadre
            // 
            this.xtraTabPageMadre.Controls.Add(this.ucAca_Familiar_x_EstudianteMadre);
            this.xtraTabPageMadre.Name = "xtraTabPageMadre";
            this.xtraTabPageMadre.Size = new System.Drawing.Size(795, 382);
            this.xtraTabPageMadre.Text = "Madre";
            // 
            // ucAca_Familiar_x_EstudianteMadre
            // 
            this.ucAca_Familiar_x_EstudianteMadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAca_Familiar_x_EstudianteMadre.IdEstudiante = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudianteMadre.IdFamiliar = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudianteMadre.IdParentestoFamiliar = "MADR";
            this.ucAca_Familiar_x_EstudianteMadre.Location = new System.Drawing.Point(0, 0);
            this.ucAca_Familiar_x_EstudianteMadre.Margin = new System.Windows.Forms.Padding(4);
            this.ucAca_Familiar_x_EstudianteMadre.matriculaInfo = null;
            this.ucAca_Familiar_x_EstudianteMadre.Mostrar_historico = false;
            this.ucAca_Familiar_x_EstudianteMadre.Name = "ucAca_Familiar_x_EstudianteMadre";
            this.ucAca_Familiar_x_EstudianteMadre.Size = new System.Drawing.Size(795, 382);
            this.ucAca_Familiar_x_EstudianteMadre.TabIndex = 0;
            this.ucAca_Familiar_x_EstudianteMadre.Visible_Page_InfoFinanciera = false;
            // 
            // xtraTabPageRepresentanteLegal
            // 
            this.xtraTabPageRepresentanteLegal.Controls.Add(this.ucAca_Familiar_x_EstudianteRL);
            this.xtraTabPageRepresentanteLegal.Name = "xtraTabPageRepresentanteLegal";
            this.xtraTabPageRepresentanteLegal.Size = new System.Drawing.Size(795, 382);
            this.xtraTabPageRepresentanteLegal.Text = "Representante Legal";
            // 
            // ucAca_Familiar_x_EstudianteRL
            // 
            this.ucAca_Familiar_x_EstudianteRL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAca_Familiar_x_EstudianteRL.IdEstudiante = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudianteRL.IdFamiliar = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudianteRL.IdParentestoFamiliar = "REP_LEGAL";
            this.ucAca_Familiar_x_EstudianteRL.Location = new System.Drawing.Point(0, 0);
            this.ucAca_Familiar_x_EstudianteRL.Margin = new System.Windows.Forms.Padding(4);
            this.ucAca_Familiar_x_EstudianteRL.matriculaInfo = null;
            this.ucAca_Familiar_x_EstudianteRL.Mostrar_historico = true;
            this.ucAca_Familiar_x_EstudianteRL.Name = "ucAca_Familiar_x_EstudianteRL";
            this.ucAca_Familiar_x_EstudianteRL.Size = new System.Drawing.Size(795, 382);
            this.ucAca_Familiar_x_EstudianteRL.TabIndex = 0;
            this.ucAca_Familiar_x_EstudianteRL.Visible_Page_InfoFinanciera = false;
            this.ucAca_Familiar_x_EstudianteRL.Load += new System.EventHandler(this.ucAca_Familiar_x_EstudianteRL_Load);
            // 
            // xtraTabPageRespresentanteEco
            // 
            this.xtraTabPageRespresentanteEco.Controls.Add(this.ucAca_Familiar_x_EstudianteRE);
            this.xtraTabPageRespresentanteEco.Name = "xtraTabPageRespresentanteEco";
            this.xtraTabPageRespresentanteEco.Size = new System.Drawing.Size(795, 382);
            this.xtraTabPageRespresentanteEco.Text = "Representante Economico";
            // 
            // ucAca_Familiar_x_EstudianteRE
            // 
            this.ucAca_Familiar_x_EstudianteRE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAca_Familiar_x_EstudianteRE.IdEstudiante = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudianteRE.IdFamiliar = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudianteRE.IdParentestoFamiliar = "REP_ECO";
            this.ucAca_Familiar_x_EstudianteRE.Location = new System.Drawing.Point(0, 0);
            this.ucAca_Familiar_x_EstudianteRE.Margin = new System.Windows.Forms.Padding(4);
            this.ucAca_Familiar_x_EstudianteRE.matriculaInfo = null;
            this.ucAca_Familiar_x_EstudianteRE.Mostrar_historico = true;
            this.ucAca_Familiar_x_EstudianteRE.Name = "ucAca_Familiar_x_EstudianteRE";
            this.ucAca_Familiar_x_EstudianteRE.Size = new System.Drawing.Size(795, 382);
            this.ucAca_Familiar_x_EstudianteRE.TabIndex = 0;
            this.ucAca_Familiar_x_EstudianteRE.Visible_Page_InfoFinanciera = false;
            this.ucAca_Familiar_x_EstudianteRE.Load += new System.EventHandler(this.ucAca_Familiar_x_EstudianteRE_Load);
            // 
            // xtraTabPageDocBancRepEco
            // 
            this.xtraTabPageDocBancRepEco.Controls.Add(this.gridControl_Dco_bancario);
            this.xtraTabPageDocBancRepEco.Name = "xtraTabPageDocBancRepEco";
            this.xtraTabPageDocBancRepEco.Size = new System.Drawing.Size(795, 382);
            this.xtraTabPageDocBancRepEco.Text = "Doc. Bancario Rep. Economico";
            // 
            // gridControl_Dco_bancario
            // 
            this.gridControl_Dco_bancario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Dco_bancario.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Dco_bancario.MainView = this.gridView_Dco_bancario;
            this.gridControl_Dco_bancario.Name = "gridControl_Dco_bancario";
            this.gridControl_Dco_bancario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.cmb_banco,
            this.cmb_tipo_Doc,
            this.repositoryItemCheckEdit1,
            this.cmb_forma_pago});
            this.gridControl_Dco_bancario.Size = new System.Drawing.Size(795, 382);
            this.gridControl_Dco_bancario.TabIndex = 2;
            this.gridControl_Dco_bancario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Dco_bancario});
            // 
            // gridView_Dco_bancario
            // 
            this.gridView_Dco_bancario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_IdBanco,
            this.col_forma_pago,
            this.Col_Tipo_documento_cat,
            this.Col_Numero_Documento,
            this.Col_Fecha_Expiracion,
            this.Col_Observacion,
            this.Col_check});
            this.gridView_Dco_bancario.GridControl = this.gridControl_Dco_bancario;
            this.gridView_Dco_bancario.Name = "gridView_Dco_bancario";
            this.gridView_Dco_bancario.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView_Dco_bancario.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_Dco_bancario.OptionsView.ShowGroupPanel = false;
            this.gridView_Dco_bancario.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_Dco_bancario_CellValueChanging);
            // 
            // Col_IdBanco
            // 
            this.Col_IdBanco.Caption = "Banco";
            this.Col_IdBanco.ColumnEdit = this.cmb_banco;
            this.Col_IdBanco.FieldName = "Id_tb_banco_x_mgbanco";
            this.Col_IdBanco.Name = "Col_IdBanco";
            this.Col_IdBanco.OptionsColumn.AllowEdit = false;
            this.Col_IdBanco.Visible = true;
            this.Col_IdBanco.VisibleIndex = 1;
            this.Col_IdBanco.Width = 187;
            // 
            // cmb_banco
            // 
            this.cmb_banco.AutoHeight = false;
            this.cmb_banco.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_banco.Name = "cmb_banco";
            this.cmb_banco.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_ba_descripcion});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Col_ba_descripcion
            // 
            this.Col_ba_descripcion.Caption = "Banco";
            this.Col_ba_descripcion.FieldName = "nombre";
            this.Col_ba_descripcion.Name = "Col_ba_descripcion";
            this.Col_ba_descripcion.Visible = true;
            this.Col_ba_descripcion.VisibleIndex = 0;
            // 
            // col_forma_pago
            // 
            this.col_forma_pago.Caption = "Forma Pago";
            this.col_forma_pago.ColumnEdit = this.cmb_forma_pago;
            this.col_forma_pago.FieldName = "Id_tipo_meca_pago";
            this.col_forma_pago.Name = "col_forma_pago";
            this.col_forma_pago.OptionsColumn.AllowEdit = false;
            this.col_forma_pago.Visible = true;
            this.col_forma_pago.VisibleIndex = 2;
            this.col_forma_pago.Width = 145;
            // 
            // cmb_forma_pago
            // 
            this.cmb_forma_pago.AutoHeight = false;
            this.cmb_forma_pago.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_forma_pago.Name = "cmb_forma_pago";
            this.cmb_forma_pago.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_nombre});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Col_nombre
            // 
            this.Col_nombre.Caption = "Nombre";
            this.Col_nombre.FieldName = "nombre";
            this.Col_nombre.Name = "Col_nombre";
            this.Col_nombre.Visible = true;
            this.Col_nombre.VisibleIndex = 0;
            // 
            // Col_Tipo_documento_cat
            // 
            this.Col_Tipo_documento_cat.Caption = "Tipo Documento";
            this.Col_Tipo_documento_cat.ColumnEdit = this.cmb_tipo_Doc;
            this.Col_Tipo_documento_cat.FieldName = "Tipo_documento_cat";
            this.Col_Tipo_documento_cat.Name = "Col_Tipo_documento_cat";
            this.Col_Tipo_documento_cat.OptionsColumn.AllowEdit = false;
            this.Col_Tipo_documento_cat.Width = 149;
            // 
            // cmb_tipo_Doc
            // 
            this.cmb_tipo_Doc.AutoHeight = false;
            this.cmb_tipo_Doc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipo_Doc.Name = "cmb_tipo_Doc";
            this.cmb_tipo_Doc.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Descripcion});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Col_Descripcion
            // 
            this.Col_Descripcion.Caption = "Tipo Documento";
            this.Col_Descripcion.FieldName = "Descripcion";
            this.Col_Descripcion.Name = "Col_Descripcion";
            this.Col_Descripcion.Visible = true;
            this.Col_Descripcion.VisibleIndex = 0;
            // 
            // Col_Numero_Documento
            // 
            this.Col_Numero_Documento.Caption = "#Documento";
            this.Col_Numero_Documento.FieldName = "Numero_Documento";
            this.Col_Numero_Documento.Name = "Col_Numero_Documento";
            this.Col_Numero_Documento.OptionsColumn.AllowEdit = false;
            this.Col_Numero_Documento.Visible = true;
            this.Col_Numero_Documento.VisibleIndex = 3;
            this.Col_Numero_Documento.Width = 261;
            // 
            // Col_Fecha_Expiracion
            // 
            this.Col_Fecha_Expiracion.Caption = "Fecha Caducidad";
            this.Col_Fecha_Expiracion.FieldName = "Fecha_Expiracion";
            this.Col_Fecha_Expiracion.Name = "Col_Fecha_Expiracion";
            this.Col_Fecha_Expiracion.OptionsColumn.AllowEdit = false;
            this.Col_Fecha_Expiracion.Visible = true;
            this.Col_Fecha_Expiracion.VisibleIndex = 4;
            this.Col_Fecha_Expiracion.Width = 141;
            // 
            // Col_Observacion
            // 
            this.Col_Observacion.Caption = "Observacion";
            this.Col_Observacion.FieldName = "Observacion";
            this.Col_Observacion.Name = "Col_Observacion";
            this.Col_Observacion.OptionsColumn.AllowEdit = false;
            this.Col_Observacion.Visible = true;
            this.Col_Observacion.VisibleIndex = 5;
            this.Col_Observacion.Width = 408;
            // 
            // Col_check
            // 
            this.Col_check.Caption = "*";
            this.Col_check.ColumnEdit = this.repositoryItemCheckEdit1;
            this.Col_check.FieldName = "check";
            this.Col_check.Name = "Col_check";
            this.Col_check.Visible = true;
            this.Col_check.VisibleIndex = 0;
            this.Col_check.Width = 38;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // xtraTabPageAcuerdos
            // 
            this.xtraTabPageAcuerdos.Appearance.PageClient.BackColor = System.Drawing.Color.Gray;
            this.xtraTabPageAcuerdos.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPageAcuerdos.Controls.Add(this.groupControl1);
            this.xtraTabPageAcuerdos.Controls.Add(this.textBox3);
            this.xtraTabPageAcuerdos.Controls.Add(this.lblCodConvivencia);
            this.xtraTabPageAcuerdos.Controls.Add(this.lblDeclaracion);
            this.xtraTabPageAcuerdos.Controls.Add(this.chkCodigoConvivencia);
            this.xtraTabPageAcuerdos.Name = "xtraTabPageAcuerdos";
            this.xtraTabPageAcuerdos.Size = new System.Drawing.Size(795, 382);
            this.xtraTabPageAcuerdos.Text = "Acuerdos";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.rdb_Si_estoy_deacuerdo_foto);
            this.groupControl1.Controls.Add(this.rdb_No_estoy_deacuerdo_foto);
            this.groupControl1.Controls.Add(this.textBox2);
            this.groupControl1.Controls.Add(this.textBox1);
            this.groupControl1.Location = new System.Drawing.Point(16, 78);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(776, 132);
            this.groupControl1.TabIndex = 13;
            // 
            // rdb_Si_estoy_deacuerdo_foto
            // 
            this.rdb_Si_estoy_deacuerdo_foto.AutoSize = true;
            this.rdb_Si_estoy_deacuerdo_foto.Location = new System.Drawing.Point(16, 24);
            this.rdb_Si_estoy_deacuerdo_foto.Name = "rdb_Si_estoy_deacuerdo_foto";
            this.rdb_Si_estoy_deacuerdo_foto.Size = new System.Drawing.Size(14, 13);
            this.rdb_Si_estoy_deacuerdo_foto.TabIndex = 11;
            this.rdb_Si_estoy_deacuerdo_foto.TabStop = true;
            this.rdb_Si_estoy_deacuerdo_foto.UseVisualStyleBackColor = true;
            // 
            // rdb_No_estoy_deacuerdo_foto
            // 
            this.rdb_No_estoy_deacuerdo_foto.AutoSize = true;
            this.rdb_No_estoy_deacuerdo_foto.Location = new System.Drawing.Point(16, 92);
            this.rdb_No_estoy_deacuerdo_foto.Name = "rdb_No_estoy_deacuerdo_foto";
            this.rdb_No_estoy_deacuerdo_foto.Size = new System.Drawing.Size(14, 13);
            this.rdb_No_estoy_deacuerdo_foto.TabIndex = 12;
            this.rdb_No_estoy_deacuerdo_foto.TabStop = true;
            this.rdb_No_estoy_deacuerdo_foto.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(36, 92);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(713, 24);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "No estoy de acuerdo y no deseo que se utilicen fotos o video de ningún tipo para " +
    "ni uno de los canales anteriormente descritos.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(36, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(713, 50);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(41, 246);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(744, 65);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // lblCodConvivencia
            // 
            this.lblCodConvivencia.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCodConvivencia.Location = new System.Drawing.Point(19, 216);
            this.lblCodConvivencia.Name = "lblCodConvivencia";
            this.lblCodConvivencia.Size = new System.Drawing.Size(126, 13);
            this.lblCodConvivencia.TabIndex = 5;
            this.lblCodConvivencia.Text = "Código de Convivencia";
            // 
            // lblDeclaracion
            // 
            this.lblDeclaracion.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDeclaracion.Location = new System.Drawing.Point(19, 53);
            this.lblDeclaracion.Name = "lblDeclaracion";
            this.lblDeclaracion.Size = new System.Drawing.Size(345, 13);
            this.lblDeclaracion.TabIndex = 4;
            this.lblDeclaracion.Text = "Declaración de consentimiento de información de multimedia";
            // 
            // chkCodigoConvivencia
            // 
            this.chkCodigoConvivencia.Location = new System.Drawing.Point(14, 244);
            this.chkCodigoConvivencia.Name = "chkCodigoConvivencia";
            this.chkCodigoConvivencia.Properties.Caption = "";
            this.chkCodigoConvivencia.Size = new System.Drawing.Size(21, 19);
            this.chkCodigoConvivencia.TabIndex = 2;
            // 
            // xtraTabPageDocumentos
            // 
            this.xtraTabPageDocumentos.Controls.Add(this.gridControlMatriculaDocumentos);
            this.xtraTabPageDocumentos.Name = "xtraTabPageDocumentos";
            this.xtraTabPageDocumentos.Size = new System.Drawing.Size(795, 382);
            this.xtraTabPageDocumentos.Text = "Documentos";
            // 
            // gridControlMatriculaDocumentos
            // 
            this.gridControlMatriculaDocumentos.DataSource = this.acaMatriculaxDocumentoInfoBindingSource;
            this.gridControlMatriculaDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMatriculaDocumentos.Location = new System.Drawing.Point(0, 0);
            this.gridControlMatriculaDocumentos.MainView = this.gridViewMatriculaDocumento;
            this.gridControlMatriculaDocumentos.Name = "gridControlMatriculaDocumentos";
            this.gridControlMatriculaDocumentos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Link});
            this.gridControlMatriculaDocumentos.Size = new System.Drawing.Size(795, 382);
            this.gridControlMatriculaDocumentos.TabIndex = 0;
            this.gridControlMatriculaDocumentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMatriculaDocumento});
            // 
            // acaMatriculaxDocumentoInfoBindingSource
            // 
            this.acaMatriculaxDocumentoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Matricula_x_Documento_Info);
            // 
            // gridViewMatriculaDocumento
            // 
            this.gridViewMatriculaDocumento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdInstitucion1,
            this.colIdSede,
            this.colIdMatricula,
            this.colIdTipoDocumento,
            this.colObservacion,
            this.colEstado1,
            this.colFechaCreacion,
            this.colFechaModificacion,
            this.colLink,
            this.colFechaAnulacion,
            this.colUsuarioCreacion,
            this.colUsuarioModificacion,
            this.colUsuarioAnulacion,
            this.colArchivo,
            this.colExiste_en_Base});
            this.gridViewMatriculaDocumento.GridControl = this.gridControlMatriculaDocumentos;
            this.gridViewMatriculaDocumento.Name = "gridViewMatriculaDocumento";
            // 
            // colIdInstitucion1
            // 
            this.colIdInstitucion1.FieldName = "IdInstitucion";
            this.colIdInstitucion1.Name = "colIdInstitucion1";
            // 
            // colIdSede
            // 
            this.colIdSede.FieldName = "IdSede";
            this.colIdSede.Name = "colIdSede";
            // 
            // colIdMatricula
            // 
            this.colIdMatricula.FieldName = "IdMatricula";
            this.colIdMatricula.Name = "colIdMatricula";
            // 
            // colIdTipoDocumento
            // 
            this.colIdTipoDocumento.Caption = "Código Documento";
            this.colIdTipoDocumento.FieldName = "IdTipoDocumento";
            this.colIdTipoDocumento.Name = "colIdTipoDocumento";
            this.colIdTipoDocumento.OptionsColumn.AllowEdit = false;
            this.colIdTipoDocumento.Width = 197;
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Descripción Documento";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.OptionsColumn.AllowEdit = false;
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 0;
            this.colObservacion.Width = 635;
            // 
            // colEstado1
            // 
            this.colEstado1.FieldName = "Estado";
            this.colEstado1.Name = "colEstado1";
            this.colEstado1.OptionsColumn.AllowEdit = false;
            this.colEstado1.Width = 302;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            // 
            // colLink
            // 
            this.colLink.ColumnEdit = this.Link;
            this.colLink.FieldName = "sLink";
            this.colLink.Name = "colLink";
            this.colLink.Visible = true;
            this.colLink.VisibleIndex = 1;
            this.colLink.Width = 326;
            // 
            // Link
            // 
            this.Link.AutoHeight = false;
            this.Link.Name = "Link";
            // 
            // colFechaAnulacion
            // 
            this.colFechaAnulacion.FieldName = "FechaAnulacion";
            this.colFechaAnulacion.Name = "colFechaAnulacion";
            // 
            // colUsuarioCreacion
            // 
            this.colUsuarioCreacion.FieldName = "UsuarioCreacion";
            this.colUsuarioCreacion.Name = "colUsuarioCreacion";
            // 
            // colUsuarioModificacion
            // 
            this.colUsuarioModificacion.FieldName = "UsuarioModificacion";
            this.colUsuarioModificacion.Name = "colUsuarioModificacion";
            // 
            // colUsuarioAnulacion
            // 
            this.colUsuarioAnulacion.FieldName = "UsuarioAnulacion";
            this.colUsuarioAnulacion.Name = "colUsuarioAnulacion";
            // 
            // colArchivo
            // 
            this.colArchivo.FieldName = "Archivo";
            this.colArchivo.Name = "colArchivo";
            // 
            // colExiste_en_Base
            // 
            this.colExiste_en_Base.FieldName = "Existe_en_Base";
            this.colExiste_en_Base.Name = "colExiste_en_Base";
            // 
            // xtraTabPageSistemaDual
            // 
            this.xtraTabPageSistemaDual.Controls.Add(this.xtraTabControl1);
            this.xtraTabPageSistemaDual.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPageSistemaDual.Name = "xtraTabPageSistemaDual";
            this.xtraTabPageSistemaDual.Size = new System.Drawing.Size(795, 382);
            this.xtraTabPageSistemaDual.Text = "Sistema Dual";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageSistemaDualRepEco;
            this.xtraTabControl1.Size = new System.Drawing.Size(795, 382);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageSistemaDualRepEco});
            // 
            // xtraTabPageSistemaDualRepEco
            // 
            this.xtraTabPageSistemaDualRepEco.Controls.Add(this.labelControl5);
            this.xtraTabPageSistemaDualRepEco.Controls.Add(this.txtPorecentajeDual);
            this.xtraTabPageSistemaDualRepEco.Controls.Add(this.txtNumDocumentoBancario);
            this.xtraTabPageSistemaDualRepEco.Controls.Add(this.labelControl4);
            this.xtraTabPageSistemaDualRepEco.Controls.Add(this.dtFechaExpiracion);
            this.xtraTabPageSistemaDualRepEco.Controls.Add(this.labelControl3);
            this.xtraTabPageSistemaDualRepEco.Controls.Add(this.labelControl2);
            this.xtraTabPageSistemaDualRepEco.Controls.Add(this.cmbTipoMecanismoPago);
            this.xtraTabPageSistemaDualRepEco.Controls.Add(this.labelControl1);
            this.xtraTabPageSistemaDualRepEco.Controls.Add(this.cmbInstitucionFinanciera);
            this.xtraTabPageSistemaDualRepEco.Controls.Add(this.lblCliente);
            this.xtraTabPageSistemaDualRepEco.Controls.Add(this.ucFa_ClienteCmb1);
            this.xtraTabPageSistemaDualRepEco.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPageSistemaDualRepEco.Name = "xtraTabPageSistemaDualRepEco";
            this.xtraTabPageSistemaDualRepEco.Size = new System.Drawing.Size(789, 354);
            this.xtraTabPageSistemaDualRepEco.Text = "Representante Economico Sistema Dual";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(372, 138);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 13);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Porcentaje Dual";
            // 
            // txtPorecentajeDual
            // 
            this.txtPorecentajeDual.Location = new System.Drawing.Point(475, 135);
            this.txtPorecentajeDual.Name = "txtPorecentajeDual";
            this.txtPorecentajeDual.Properties.Mask.EditMask = "P0";
            this.txtPorecentajeDual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPorecentajeDual.Size = new System.Drawing.Size(125, 20);
            this.txtPorecentajeDual.TabIndex = 21;
            // 
            // txtNumDocumentoBancario
            // 
            this.txtNumDocumentoBancario.Location = new System.Drawing.Point(143, 100);
            this.txtNumDocumentoBancario.Name = "txtNumDocumentoBancario";
            this.txtNumDocumentoBancario.Size = new System.Drawing.Size(457, 20);
            this.txtNumDocumentoBancario.TabIndex = 20;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 142);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 13);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Fecha Expiracion";
            // 
            // dtFechaExpiracion
            // 
            this.dtFechaExpiracion.EditValue = null;
            this.dtFechaExpiracion.Location = new System.Drawing.Point(143, 135);
            this.dtFechaExpiracion.Name = "dtFechaExpiracion";
            this.dtFechaExpiracion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaExpiracion.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFechaExpiracion.Size = new System.Drawing.Size(159, 20);
            this.dtFechaExpiracion.TabIndex = 18;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 98);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Num. Documento";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 72);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mecanismo Pago";
            // 
            // cmbTipoMecanismoPago
            // 
            this.cmbTipoMecanismoPago.Location = new System.Drawing.Point(143, 70);
            this.cmbTipoMecanismoPago.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoMecanismoPago.Name = "cmbTipoMecanismoPago";
            this.cmbTipoMecanismoPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoMecanismoPago.Properties.View = this.gridView3;
            this.cmbTipoMecanismoPago.Size = new System.Drawing.Size(457, 20);
            this.cmbTipoMecanismoPago.TabIndex = 4;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColId_tipo_meca_pago,
            this.ColTIpoMecanismo,
            this.ColId_tb_banco_x_mgbanco_tipo_mecanismo,
            this.ColEstadoTipoMecanismoPago,
            this.ColTipoCuenta,
            this.ColForma_pago});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // ColId_tipo_meca_pago
            // 
            this.ColId_tipo_meca_pago.Caption = "Id Mecanismo Pago";
            this.ColId_tipo_meca_pago.FieldName = "Id_tipo_meca_pago";
            this.ColId_tipo_meca_pago.Name = "ColId_tipo_meca_pago";
            this.ColId_tipo_meca_pago.Visible = true;
            this.ColId_tipo_meca_pago.VisibleIndex = 0;
            // 
            // ColTIpoMecanismo
            // 
            this.ColTIpoMecanismo.Caption = "Tipo Mecanismo";
            this.ColTIpoMecanismo.FieldName = "nombre";
            this.ColTIpoMecanismo.Name = "ColTIpoMecanismo";
            this.ColTIpoMecanismo.Visible = true;
            this.ColTIpoMecanismo.VisibleIndex = 1;
            // 
            // ColId_tb_banco_x_mgbanco_tipo_mecanismo
            // 
            this.ColId_tb_banco_x_mgbanco_tipo_mecanismo.Caption = "Id_tb_banco_x_mgbanco";
            this.ColId_tb_banco_x_mgbanco_tipo_mecanismo.FieldName = "Id_tb_banco_x_mgbanco";
            this.ColId_tb_banco_x_mgbanco_tipo_mecanismo.Name = "ColId_tb_banco_x_mgbanco_tipo_mecanismo";
            // 
            // ColEstadoTipoMecanismoPago
            // 
            this.ColEstadoTipoMecanismoPago.Caption = "Estado";
            this.ColEstadoTipoMecanismoPago.FieldName = "Estado";
            this.ColEstadoTipoMecanismoPago.Name = "ColEstadoTipoMecanismoPago";
            // 
            // ColTipoCuenta
            // 
            this.ColTipoCuenta.Caption = "Tipo Cuenta";
            this.ColTipoCuenta.FieldName = "Tipo_Cuenta";
            this.ColTipoCuenta.Name = "ColTipoCuenta";
            // 
            // ColForma_pago
            // 
            this.ColForma_pago.Caption = "Forma Pago";
            this.ColForma_pago.FieldName = "Forma_pago";
            this.ColForma_pago.Name = "ColForma_pago";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 46);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Institucion Financiera";
            // 
            // cmbInstitucionFinanciera
            // 
            this.cmbInstitucionFinanciera.Location = new System.Drawing.Point(143, 43);
            this.cmbInstitucionFinanciera.Margin = new System.Windows.Forms.Padding(2);
            this.cmbInstitucionFinanciera.Name = "cmbInstitucionFinanciera";
            this.cmbInstitucionFinanciera.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInstitucionFinanciera.Properties.View = this.gridView2;
            this.cmbInstitucionFinanciera.Size = new System.Drawing.Size(457, 20);
            this.cmbInstitucionFinanciera.TabIndex = 2;
            this.cmbInstitucionFinanciera.EditValueChanged += new System.EventHandler(this.cmbInstitucionFinanciera_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColId_tb_banco_x_mgbanco,
            this.ColIdBanco_Erp,
            this.ColIdBanco_Academico,
            this.ColInstitucionFinanciera});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ColId_tb_banco_x_mgbanco
            // 
            this.ColId_tb_banco_x_mgbanco.Caption = "Id Banco";
            this.ColId_tb_banco_x_mgbanco.FieldName = "Id_tb_banco_x_mgbanco";
            this.ColId_tb_banco_x_mgbanco.Name = "ColId_tb_banco_x_mgbanco";
            this.ColId_tb_banco_x_mgbanco.Visible = true;
            this.ColId_tb_banco_x_mgbanco.VisibleIndex = 0;
            // 
            // ColIdBanco_Erp
            // 
            this.ColIdBanco_Erp.Caption = "IdBanco_Erp";
            this.ColIdBanco_Erp.FieldName = "IdBanco_Erp";
            this.ColIdBanco_Erp.Name = "ColIdBanco_Erp";
            // 
            // ColIdBanco_Academico
            // 
            this.ColIdBanco_Academico.Caption = "IdBanco_Academico";
            this.ColIdBanco_Academico.FieldName = "IdBanco_Academico";
            this.ColIdBanco_Academico.Name = "ColIdBanco_Academico";
            // 
            // ColInstitucionFinanciera
            // 
            this.ColInstitucionFinanciera.Caption = "Institucion Financiera";
            this.ColInstitucionFinanciera.FieldName = "nombre";
            this.ColInstitucionFinanciera.Name = "ColInstitucionFinanciera";
            this.ColInstitucionFinanciera.Visible = true;
            this.ColInstitucionFinanciera.VisibleIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(14, 18);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(125, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Representante Economico";
            // 
            // ucFa_ClienteCmb1
            // 
            this.ucFa_ClienteCmb1.Location = new System.Drawing.Point(143, 9);
            this.ucFa_ClienteCmb1.Name = "ucFa_ClienteCmb1";
            this.ucFa_ClienteCmb1.Size = new System.Drawing.Size(467, 26);
            this.ucFa_ClienteCmb1.TabIndex = 0;
            // 
            // FrmAcaMatricula_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 596);
            this.Controls.Add(this.xtraTabControlMatricula);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAcaMatricula_Mant";
            this.Text = "FrmAcaMatricula_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcaMatricula_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAcaMatricula_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaMatricula.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaMatricula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnioLectivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaPeriodoLectivoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodMatricula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdMatricula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMatricula)).EndInit();
            this.xtraTabControlMatricula.ResumeLayout(false);
            this.xtraTabPageAsignacionDeClases.ResumeLayout(false);
            this.xtraTabPageAsignacionDeClases.PerformLayout();
            this.xtraTabPagePadre.ResumeLayout(false);
            this.xtraTabPageMadre.ResumeLayout(false);
            this.xtraTabPageRepresentanteLegal.ResumeLayout(false);
            this.xtraTabPageRespresentanteEco.ResumeLayout(false);
            this.xtraTabPageDocBancRepEco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Dco_bancario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Dco_bancario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_forma_pago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_Doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            this.xtraTabPageAcuerdos.ResumeLayout(false);
            this.xtraTabPageAcuerdos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCodigoConvivencia.Properties)).EndInit();
            this.xtraTabPageDocumentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMatriculaDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaMatriculaxDocumentoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMatriculaDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Link)).EndInit();
            this.xtraTabPageSistemaDual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageSistemaDualRepEco.ResumeLayout(false);
            this.xtraTabPageSistemaDualRepEco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorecentajeDual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDocumentoBancario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaExpiracion.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaExpiracion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoMecanismoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstitucionFinanciera.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblCodMatricula;
        private DevExpress.XtraEditors.LabelControl lblIdMatricula;
        private DevExpress.XtraEditors.TextEdit txtCodMatricula;
        private DevExpress.XtraEditors.TextEdit txtIdMatricula;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbAnioLectivo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl lblPeriodoLectivo;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMatricula;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageRespresentanteEco;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageRepresentanteLegal;
        private Controles.UCAca_Familiar_x_Estudiante ucAca_Familiar_x_EstudianteRE;
        private Controles.UCAca_Familiar_x_Estudiante ucAca_Familiar_x_EstudianteRL;
        private System.Windows.Forms.BindingSource acaPeriodoLectivoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdInstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPeriodoLectivo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageAsignacionDeClases;
        private Controles.UCAca_SedeJornadaSeccionCurso ucAca_SedeJornadaSeccionCurso;
        private DevExpress.XtraEditors.CheckEdit chkEstado;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.LabelControl lblObservacion;
        private DevExpress.XtraEditors.MemoEdit txtObservacion;
        private DevExpress.XtraEditors.LabelControl lblEstudiante;
        private DevExpress.XtraEditors.LabelControl lblCurso;
        private DevExpress.XtraEditors.LabelControl lblSeccion;
        private DevExpress.XtraEditors.LabelControl lblJornada;
        private DevExpress.XtraEditors.LabelControl lblSede;
        private Controles.UCAca_Estudiante ucAca_Estudiante;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageAcuerdos;
        private DevExpress.XtraEditors.LabelControl lblCodConvivencia;
        private DevExpress.XtraEditors.LabelControl lblDeclaracion;
        private DevExpress.XtraEditors.CheckEdit chkCodigoConvivencia;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton rdb_No_estoy_deacuerdo_foto;
        private System.Windows.Forms.RadioButton rdb_Si_estoy_deacuerdo_foto;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagePadre;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMadre;
        private Controles.UCAca_Familiar_x_Estudiante ucAca_Familiar_x_EstudiantePadre;
        private Controles.UCAca_Familiar_x_Estudiante ucAca_Familiar_x_EstudianteMadre;
        private DevExpress.XtraEditors.LabelControl lblParalelo;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDocumentos;
        private DevExpress.XtraGrid.GridControl gridControlMatriculaDocumentos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMatriculaDocumento;
        private System.Windows.Forms.BindingSource acaMatriculaxDocumentoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdInstitucion1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSede;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMatricula;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colArchivo;
        private DevExpress.XtraGrid.Columns.GridColumn colExiste_en_Base;
        private DevExpress.XtraGrid.Columns.GridColumn colLink;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Link;
        private DevExpress.XtraEditors.DateEdit deFechaMatricula;
        private DevExpress.XtraEditors.LabelControl lblFechaMatricula;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDocBancRepEco;
        private DevExpress.XtraGrid.GridControl gridControl_Dco_bancario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Dco_bancario;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdBanco;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cmb_banco;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ba_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Tipo_documento_cat;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_tipo_Doc;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Numero_Documento;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Fecha_Expiracion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Observacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_check;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn col_forma_pago;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_forma_pago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_nombre;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageSistemaDual;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageSistemaDualRepEco;
        private DevExpress.XtraEditors.LabelControl lblCliente;
        private Controles.UCFa_ClienteCmb ucFa_ClienteCmb1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipoMecanismoPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbInstitucionFinanciera;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ColId_tb_banco_x_mgbanco;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdBanco_Erp;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdBanco_Academico;
        private DevExpress.XtraGrid.Columns.GridColumn ColInstitucionFinanciera;
        private DevExpress.XtraGrid.Columns.GridColumn ColId_tipo_meca_pago;
        private DevExpress.XtraGrid.Columns.GridColumn ColId_tb_banco_x_mgbanco_tipo_mecanismo;
        private DevExpress.XtraGrid.Columns.GridColumn ColTIpoMecanismo;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstadoTipoMecanismoPago;
        private DevExpress.XtraGrid.Columns.GridColumn ColTipoCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn ColForma_pago;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dtFechaExpiracion;
        private DevExpress.XtraEditors.TextEdit txtPorecentajeDual;
        private DevExpress.XtraEditors.TextEdit txtNumDocumentoBancario;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}