namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaSeccion_Mant
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
            this.lblIdSeccion = new DevExpress.XtraEditors.LabelControl();
            this.txtIdSeccion = new DevExpress.XtraEditors.TextEdit();
            this.lblIdJornada = new DevExpress.XtraEditors.LabelControl();
            this.cmbJornada = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaJornadaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcionJornada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdJornada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSede = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblCodSeccion = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoSeccion = new DevExpress.XtraEditors.TextEdit();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.lblInstitucion = new DevExpress.XtraEditors.LabelControl();
            this.cmbInstitucion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaInstitucionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdInstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodInstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCoordinador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecretario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResolucion_Academica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSitioWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaMoficacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpaisInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colciudadInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprovinciaInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblSede = new DevExpress.XtraEditors.LabelControl();
            this.cmbSede = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaSedeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSede1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionSede = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstadoInferior_Forms = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdSeccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJornada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaJornadaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoSeccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstitucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSede.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSedeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdSeccion
            // 
            this.lblIdSeccion.Location = new System.Drawing.Point(24, 69);
            this.lblIdSeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblIdSeccion.Name = "lblIdSeccion";
            this.lblIdSeccion.Size = new System.Drawing.Size(64, 16);
            this.lblIdSeccion.TabIndex = 4;
            this.lblIdSeccion.Text = "Id Sección:";
            // 
            // txtIdSeccion
            // 
            this.txtIdSeccion.Enabled = false;
            this.txtIdSeccion.Location = new System.Drawing.Point(151, 65);
            this.txtIdSeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdSeccion.Name = "txtIdSeccion";
            this.txtIdSeccion.Size = new System.Drawing.Size(157, 22);
            this.txtIdSeccion.TabIndex = 5;
            // 
            // lblIdJornada
            // 
            this.lblIdJornada.Location = new System.Drawing.Point(24, 197);
            this.lblIdJornada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblIdJornada.Name = "lblIdJornada";
            this.lblIdJornada.Size = new System.Drawing.Size(50, 16);
            this.lblIdJornada.TabIndex = 6;
            this.lblIdJornada.Text = "Jornada:";
            // 
            // cmbJornada
            // 
            this.cmbJornada.Location = new System.Drawing.Point(151, 193);
            this.cmbJornada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbJornada.Name = "cmbJornada";
            this.cmbJornada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbJornada.Properties.DataSource = this.acaJornadaInfoBindingSource;
            this.cmbJornada.Properties.DisplayMember = "DescripcionJornada";
            this.cmbJornada.Properties.ValueMember = "IdJornada";
            this.cmbJornada.Properties.View = this.searchLookUpEdit1View;
            this.cmbJornada.Size = new System.Drawing.Size(368, 22);
            this.cmbJornada.TabIndex = 7;
            // 
            // acaJornadaInfoBindingSource
            // 
            this.acaJornadaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Jornada_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcionJornada,
            this.colIdJornada,
            this.colIdSede});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDescripcionJornada, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colDescripcionJornada
            // 
            this.colDescripcionJornada.FieldName = "DescripcionJornada";
            this.colDescripcionJornada.Name = "colDescripcionJornada";
            this.colDescripcionJornada.OptionsColumn.AllowEdit = false;
            this.colDescripcionJornada.Visible = true;
            this.colDescripcionJornada.VisibleIndex = 1;
            this.colDescripcionJornada.Width = 1037;
            // 
            // colIdJornada
            // 
            this.colIdJornada.FieldName = "IdJornada";
            this.colIdJornada.Name = "colIdJornada";
            this.colIdJornada.OptionsColumn.AllowEdit = false;
            this.colIdJornada.Visible = true;
            this.colIdJornada.VisibleIndex = 0;
            this.colIdJornada.Width = 137;
            // 
            // colIdSede
            // 
            this.colIdSede.FieldName = "IdSede";
            this.colIdSede.Name = "colIdSede";
            // 
            // lblCodSeccion
            // 
            this.lblCodSeccion.Location = new System.Drawing.Point(24, 101);
            this.lblCodSeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCodSeccion.Name = "lblCodSeccion";
            this.lblCodSeccion.Size = new System.Drawing.Size(92, 16);
            this.lblCodSeccion.TabIndex = 8;
            this.lblCodSeccion.Text = "Código Sección:";
            // 
            // txtCodigoSeccion
            // 
            this.txtCodigoSeccion.Location = new System.Drawing.Point(151, 97);
            this.txtCodigoSeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoSeccion.Name = "txtCodigoSeccion";
            this.txtCodigoSeccion.Size = new System.Drawing.Size(157, 22);
            this.txtCodigoSeccion.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(24, 229);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(70, 16);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(151, 225);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(448, 22);
            this.txtDescripcion.TabIndex = 13;
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(516, 257);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Size = new System.Drawing.Size(95, 21);
            this.chkActivo.TabIndex = 14;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(313, 260);
            this.lblAnulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(170, 25);
            this.lblAnulado.TabIndex = 46;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.Location = new System.Drawing.Point(24, 130);
            this.lblInstitucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(63, 16);
            this.lblInstitucion.TabIndex = 47;
            this.lblInstitucion.Text = "Institución:";
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.Location = new System.Drawing.Point(151, 129);
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
            this.cmbInstitucion.TabIndex = 48;
            // 
            // acaInstitucionInfoBindingSource
            // 
            this.acaInstitucionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Institucion_Info);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa1,
            this.colIdInstitucion,
            this.colCodInstitucion,
            this.colNombre,
            this.colDireccion,
            this.colTelefono,
            this.colFax,
            this.colRector,
            this.colCoordinador,
            this.colSecretario,
            this.colResolucion_Academica,
            this.colSitioWeb,
            this.colEstado1,
            this.colLogo,
            this.colUsuarioCreacion,
            this.colUsuarioModificacion,
            this.colFechaCreacion,
            this.colFechaMoficacion,
            this.colpaisInfo,
            this.colciudadInfo,
            this.colprovinciaInfo});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            // 
            // colIdInstitucion
            // 
            this.colIdInstitucion.FieldName = "IdInstitucion";
            this.colIdInstitucion.Name = "colIdInstitucion";
            this.colIdInstitucion.OptionsColumn.AllowEdit = false;
            this.colIdInstitucion.Visible = true;
            this.colIdInstitucion.VisibleIndex = 0;
            this.colIdInstitucion.Width = 160;
            // 
            // colCodInstitucion
            // 
            this.colCodInstitucion.FieldName = "CodInstitucion";
            this.colCodInstitucion.Name = "colCodInstitucion";
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 1014;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            // 
            // colRector
            // 
            this.colRector.FieldName = "Rector";
            this.colRector.Name = "colRector";
            // 
            // colCoordinador
            // 
            this.colCoordinador.FieldName = "Coordinador";
            this.colCoordinador.Name = "colCoordinador";
            // 
            // colSecretario
            // 
            this.colSecretario.FieldName = "Secretario";
            this.colSecretario.Name = "colSecretario";
            // 
            // colResolucion_Academica
            // 
            this.colResolucion_Academica.FieldName = "Resolucion_Academica";
            this.colResolucion_Academica.Name = "colResolucion_Academica";
            // 
            // colSitioWeb
            // 
            this.colSitioWeb.FieldName = "SitioWeb";
            this.colSitioWeb.Name = "colSitioWeb";
            // 
            // colEstado1
            // 
            this.colEstado1.FieldName = "Estado";
            this.colEstado1.Name = "colEstado1";
            // 
            // colLogo
            // 
            this.colLogo.FieldName = "Logo";
            this.colLogo.Name = "colLogo";
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
            // colFechaCreacion
            // 
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            // 
            // colFechaMoficacion
            // 
            this.colFechaMoficacion.FieldName = "FechaMoficacion";
            this.colFechaMoficacion.Name = "colFechaMoficacion";
            // 
            // colpaisInfo
            // 
            this.colpaisInfo.FieldName = "paisInfo";
            this.colpaisInfo.Name = "colpaisInfo";
            // 
            // colciudadInfo
            // 
            this.colciudadInfo.FieldName = "ciudadInfo";
            this.colciudadInfo.Name = "colciudadInfo";
            // 
            // colprovinciaInfo
            // 
            this.colprovinciaInfo.FieldName = "provinciaInfo";
            this.colprovinciaInfo.Name = "colprovinciaInfo";
            // 
            // lblSede
            // 
            this.lblSede.Location = new System.Drawing.Point(24, 165);
            this.lblSede.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(34, 16);
            this.lblSede.TabIndex = 49;
            this.lblSede.Text = "Sede:";
            // 
            // cmbSede
            // 
            this.cmbSede.Location = new System.Drawing.Point(151, 161);
            this.cmbSede.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSede.Properties.DataSource = this.acaSedeInfoBindingSource;
            this.cmbSede.Properties.DisplayMember = "DescripcionSede";
            this.cmbSede.Properties.ValueMember = "IdSede";
            this.cmbSede.Properties.View = this.gridView2;
            this.cmbSede.Size = new System.Drawing.Size(367, 22);
            this.cmbSede.TabIndex = 50;
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
            this.colIdSede1.FieldName = "IdSede";
            this.colIdSede1.Name = "colIdSede1";
            this.colIdSede1.OptionsColumn.AllowEdit = false;
            this.colIdSede1.Visible = true;
            this.colIdSede1.VisibleIndex = 0;
            this.colIdSede1.Width = 208;
            // 
            // colDescripcionSede
            // 
            this.colDescripcionSede.FieldName = "DescripcionSede";
            this.colDescripcionSede.Name = "colDescripcionSede";
            this.colDescripcionSede.OptionsColumn.AllowEdit = false;
            this.colDescripcionSede.Visible = true;
            this.colDescripcionSede.VisibleIndex = 1;
            this.colDescripcionSede.Width = 966;
            // 
            // ucGe_BarraEstadoInferior_Forms
            // 
            this.ucGe_BarraEstadoInferior_Forms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms.Location = new System.Drawing.Point(0, 292);
            this.ucGe_BarraEstadoInferior_Forms.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_BarraEstadoInferior_Forms.Name = "ucGe_BarraEstadoInferior_Forms";
            this.ucGe_BarraEstadoInferior_Forms.Size = new System.Drawing.Size(661, 28);
            this.ucGe_BarraEstadoInferior_Forms.TabIndex = 3;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(661, 39);
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
            // FrmAcaSeccion_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 320);
            this.Controls.Add(this.cmbSede);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.cmbInstitucion);
            this.Controls.Add(this.lblInstitucion);
            this.Controls.Add(this.lblAnulado);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtCodigoSeccion);
            this.Controls.Add(this.lblCodSeccion);
            this.Controls.Add(this.cmbJornada);
            this.Controls.Add(this.lblIdJornada);
            this.Controls.Add(this.txtIdSeccion);
            this.Controls.Add(this.lblIdSeccion);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms);
            this.Controls.Add(this.ucGe_Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAcaSeccion_Mant";
            this.Text = "FrmAcaSeccion_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcaSeccion_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAcaSeccion_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdSeccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJornada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaJornadaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoSeccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstitucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSede.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSedeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms;
        private DevExpress.XtraEditors.LabelControl lblIdSeccion;
        private DevExpress.XtraEditors.TextEdit txtIdSeccion;
        private DevExpress.XtraEditors.LabelControl lblIdJornada;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbJornada;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl lblCodSeccion;
        private DevExpress.XtraEditors.TextEdit txtCodigoSeccion;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.LabelControl lblInstitucion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbInstitucion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblSede;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSede;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource acaInstitucionInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdInstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn colCodInstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colRector;
        private DevExpress.XtraGrid.Columns.GridColumn colCoordinador;
        private DevExpress.XtraGrid.Columns.GridColumn colSecretario;
        private DevExpress.XtraGrid.Columns.GridColumn colResolucion_Academica;
        private DevExpress.XtraGrid.Columns.GridColumn colSitioWeb;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado1;
        private DevExpress.XtraGrid.Columns.GridColumn colLogo;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaMoficacion;
        private DevExpress.XtraGrid.Columns.GridColumn colpaisInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colciudadInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colprovinciaInfo;
        private System.Windows.Forms.BindingSource acaSedeInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSede1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionSede;
        private System.Windows.Forms.BindingSource acaJornadaInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionJornada;
        private DevExpress.XtraGrid.Columns.GridColumn colIdJornada;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSede;
    }
}