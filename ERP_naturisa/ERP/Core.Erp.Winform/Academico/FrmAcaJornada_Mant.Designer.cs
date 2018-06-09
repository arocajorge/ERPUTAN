namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaJornada_Mant
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
            this.lblIdJornada = new DevExpress.XtraEditors.LabelControl();
            this.txtIdJornada = new DevExpress.XtraEditors.TextEdit();
            this.lblIdSede = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcionJornada = new DevExpress.XtraEditors.TextEdit();
            this.lblDescripcionJornada = new DevExpress.XtraEditors.LabelControl();
            this.txtCodJornada = new DevExpress.XtraEditors.TextEdit();
            this.lblCodJornada = new DevExpress.XtraEditors.LabelControl();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.cmbSede = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaSedeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdInstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSede = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinstitucionInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodSede = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodAlterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionSede = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.lblInstitucion = new DevExpress.XtraEditors.LabelControl();
            this.cmbInstitucion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaInstitucionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdInstitucion1 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtIdJornada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionJornada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodJornada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSede.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSedeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstitucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdJornada
            // 
            this.lblIdJornada.Location = new System.Drawing.Point(12, 54);
            this.lblIdJornada.Name = "lblIdJornada";
            this.lblIdJornada.Size = new System.Drawing.Size(56, 13);
            this.lblIdJornada.TabIndex = 3;
            this.lblIdJornada.Text = "Id Jornada:";
            // 
            // txtIdJornada
            // 
            this.txtIdJornada.Enabled = false;
            this.txtIdJornada.Location = new System.Drawing.Point(116, 51);
            this.txtIdJornada.Name = "txtIdJornada";
            this.txtIdJornada.Size = new System.Drawing.Size(88, 20);
            this.txtIdJornada.TabIndex = 4;
            // 
            // lblIdSede
            // 
            this.lblIdSede.Location = new System.Drawing.Point(12, 136);
            this.lblIdSede.Name = "lblIdSede";
            this.lblIdSede.Size = new System.Drawing.Size(28, 13);
            this.lblIdSede.TabIndex = 6;
            this.lblIdSede.Text = "Sede:";
            // 
            // txtDescripcionJornada
            // 
            this.txtDescripcionJornada.Location = new System.Drawing.Point(116, 155);
            this.txtDescripcionJornada.Name = "txtDescripcionJornada";
            this.txtDescripcionJornada.Size = new System.Drawing.Size(277, 20);
            this.txtDescripcionJornada.TabIndex = 7;
            // 
            // lblDescripcionJornada
            // 
            this.lblDescripcionJornada.Location = new System.Drawing.Point(12, 158);
            this.lblDescripcionJornada.Name = "lblDescripcionJornada";
            this.lblDescripcionJornada.Size = new System.Drawing.Size(58, 13);
            this.lblDescripcionJornada.TabIndex = 8;
            this.lblDescripcionJornada.Text = "Descripción:";
            // 
            // txtCodJornada
            // 
            this.txtCodJornada.Location = new System.Drawing.Point(116, 75);
            this.txtCodJornada.Name = "txtCodJornada";
            this.txtCodJornada.Size = new System.Drawing.Size(88, 20);
            this.txtCodJornada.TabIndex = 9;
            // 
            // lblCodJornada
            // 
            this.lblCodJornada.Location = new System.Drawing.Point(12, 82);
            this.lblCodJornada.Name = "lblCodJornada";
            this.lblCodJornada.Size = new System.Drawing.Size(79, 13);
            this.lblCodJornada.TabIndex = 10;
            this.lblCodJornada.Text = "Código Jornada:";
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(335, 181);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Size = new System.Drawing.Size(60, 19);
            this.chkActivo.TabIndex = 11;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(181, 180);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(136, 20);
            this.lblAnulado.TabIndex = 45;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // cmbSede
            // 
            this.cmbSede.Location = new System.Drawing.Point(116, 132);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSede.Properties.DataSource = this.acaSedeInfoBindingSource;
            this.cmbSede.Properties.DisplayMember = "DescripcionSede";
            this.cmbSede.Properties.ValueMember = "IdSede";
            this.cmbSede.Properties.View = this.searchLookUpEdit1View;
            this.cmbSede.Size = new System.Drawing.Size(279, 20);
            this.cmbSede.TabIndex = 46;
            this.cmbSede.EditValueChanged += new System.EventHandler(this.cmbSede_EditValueChanged);
            // 
            // acaSedeInfoBindingSource
            // 
            this.acaSedeInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Sede_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdInstitucion,
            this.colIdSede,
            this.colinstitucionInfo,
            this.colCodSede,
            this.colCodAlterno,
            this.colDescripcionSede,
            this.colEstado});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            // 
            // colIdInstitucion
            // 
            this.colIdInstitucion.FieldName = "IdInstitucion";
            this.colIdInstitucion.Name = "colIdInstitucion";
            this.colIdInstitucion.OptionsColumn.AllowEdit = false;
            // 
            // colIdSede
            // 
            this.colIdSede.FieldName = "IdSede";
            this.colIdSede.Name = "colIdSede";
            this.colIdSede.Visible = true;
            this.colIdSede.VisibleIndex = 0;
            this.colIdSede.Width = 168;
            // 
            // colinstitucionInfo
            // 
            this.colinstitucionInfo.FieldName = "institucionInfo";
            this.colinstitucionInfo.Name = "colinstitucionInfo";
            this.colinstitucionInfo.OptionsColumn.AllowEdit = false;
            // 
            // colCodSede
            // 
            this.colCodSede.FieldName = "CodSede";
            this.colCodSede.Name = "colCodSede";
            this.colCodSede.OptionsColumn.AllowEdit = false;
            // 
            // colCodAlterno
            // 
            this.colCodAlterno.FieldName = "CodAlterno";
            this.colCodAlterno.Name = "colCodAlterno";
            this.colCodAlterno.OptionsColumn.AllowEdit = false;
            // 
            // colDescripcionSede
            // 
            this.colDescripcionSede.FieldName = "DescripcionSede";
            this.colDescripcionSede.Name = "colDescripcionSede";
            this.colDescripcionSede.Visible = true;
            this.colDescripcionSede.VisibleIndex = 1;
            this.colDescripcionSede.Width = 1006;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 220);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(454, 23);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 2;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(454, 32);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
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
            // lblInstitucion
            // 
            this.lblInstitucion.Location = new System.Drawing.Point(12, 109);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(54, 13);
            this.lblInstitucion.TabIndex = 47;
            this.lblInstitucion.Text = "Institución:";
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.Location = new System.Drawing.Point(117, 106);
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInstitucion.Properties.DataSource = this.acaInstitucionInfoBindingSource;
            this.cmbInstitucion.Properties.DisplayMember = "Nombre";
            this.cmbInstitucion.Properties.ReadOnly = true;
            this.cmbInstitucion.Properties.ValueMember = "IdInstitucion";
            this.cmbInstitucion.Properties.View = this.gridView1;
            this.cmbInstitucion.Size = new System.Drawing.Size(278, 20);
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
            this.colIdInstitucion1,
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
            // colIdInstitucion1
            // 
            this.colIdInstitucion1.FieldName = "IdInstitucion";
            this.colIdInstitucion1.Name = "colIdInstitucion1";
            this.colIdInstitucion1.OptionsColumn.AllowEdit = false;
            this.colIdInstitucion1.Visible = true;
            this.colIdInstitucion1.VisibleIndex = 0;
            this.colIdInstitucion1.Width = 191;
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
            this.colNombre.Width = 983;
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
            this.colEstado1.OptionsColumn.AllowEdit = false;
            this.colEstado1.Visible = true;
            this.colEstado1.VisibleIndex = 2;
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
            // FrmAcaJornada_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 243);
            this.Controls.Add(this.cmbInstitucion);
            this.Controls.Add(this.lblInstitucion);
            this.Controls.Add(this.cmbSede);
            this.Controls.Add(this.lblAnulado);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.lblCodJornada);
            this.Controls.Add(this.txtCodJornada);
            this.Controls.Add(this.lblDescripcionJornada);
            this.Controls.Add(this.txtDescripcionJornada);
            this.Controls.Add(this.lblIdSede);
            this.Controls.Add(this.txtIdJornada);
            this.Controls.Add(this.lblIdJornada);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAcaJornada_Mant";
            this.Text = "FrmAca_Jornada_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcaJornada_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAca_Jornada_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdJornada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionJornada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodJornada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSede.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSedeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstitucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraEditors.LabelControl lblIdJornada;
        private DevExpress.XtraEditors.TextEdit txtIdJornada;
        private DevExpress.XtraEditors.LabelControl lblIdSede;
        private DevExpress.XtraEditors.TextEdit txtDescripcionJornada;
        private DevExpress.XtraEditors.LabelControl lblDescripcionJornada;
        private DevExpress.XtraEditors.TextEdit txtCodJornada;
        private DevExpress.XtraEditors.LabelControl lblCodJornada;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSede;
        private System.Windows.Forms.BindingSource acaSedeInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdInstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSede;
        private DevExpress.XtraGrid.Columns.GridColumn colinstitucionInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodSede;
        private DevExpress.XtraGrid.Columns.GridColumn colCodAlterno;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionSede;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.LabelControl lblInstitucion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbInstitucion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource acaInstitucionInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdInstitucion1;
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
    }
}