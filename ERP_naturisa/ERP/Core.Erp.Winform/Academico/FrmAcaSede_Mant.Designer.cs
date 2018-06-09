namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaSede_Mant
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
            this.lblAnulado = new System.Windows.Forms.Label();
            this.lblIdSede = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigoSede = new DevExpress.XtraEditors.LabelControl();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.lblInstitucion = new DevExpress.XtraEditors.LabelControl();
            this.txtIdSede = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigoSede = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.cmbInstitucion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaInstitucionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaMoficacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpaisInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colciudadInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprovinciaInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_Sucursal_combo1 = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdSede.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoSede.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstitucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(314, 237);
            this.lblAnulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(170, 25);
            this.lblAnulado.TabIndex = 46;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // lblIdSede
            // 
            this.lblIdSede.Location = new System.Drawing.Point(47, 62);
            this.lblIdSede.Margin = new System.Windows.Forms.Padding(4);
            this.lblIdSede.Name = "lblIdSede";
            this.lblIdSede.Size = new System.Drawing.Size(49, 16);
            this.lblIdSede.TabIndex = 47;
            this.lblIdSede.Text = "Id Sede:";
            // 
            // lblCodigoSede
            // 
            this.lblCodigoSede.Location = new System.Drawing.Point(47, 91);
            this.lblCodigoSede.Margin = new System.Windows.Forms.Padding(4);
            this.lblCodigoSede.Name = "lblCodigoSede";
            this.lblCodigoSede.Size = new System.Drawing.Size(77, 16);
            this.lblCodigoSede.TabIndex = 48;
            this.lblCodigoSede.Text = "Código Sede:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(47, 155);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(70, 16);
            this.lblDescripcion.TabIndex = 49;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.Location = new System.Drawing.Point(47, 123);
            this.lblInstitucion.Margin = new System.Windows.Forms.Padding(4);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(63, 16);
            this.lblInstitucion.TabIndex = 50;
            this.lblInstitucion.Text = "Institución:";
            // 
            // txtIdSede
            // 
            this.txtIdSede.Location = new System.Drawing.Point(181, 55);
            this.txtIdSede.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdSede.Name = "txtIdSede";
            this.txtIdSede.Size = new System.Drawing.Size(191, 22);
            this.txtIdSede.TabIndex = 51;
            // 
            // txtCodigoSede
            // 
            this.txtCodigoSede.Location = new System.Drawing.Point(181, 87);
            this.txtCodigoSede.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoSede.Name = "txtCodigoSede";
            this.txtCodigoSede.Size = new System.Drawing.Size(191, 22);
            this.txtCodigoSede.TabIndex = 52;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(181, 151);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(392, 22);
            this.txtDescripcion.TabIndex = 53;
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.Location = new System.Drawing.Point(181, 119);
            this.cmbInstitucion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInstitucion.Properties.DataSource = this.acaInstitucionInfoBindingSource;
            this.cmbInstitucion.Properties.DisplayMember = "Nombre";
            this.cmbInstitucion.Properties.ReadOnly = true;
            this.cmbInstitucion.Properties.ValueMember = "IdInstitucion";
            this.cmbInstitucion.Properties.View = this.searchLookUpEdit1View;
            this.cmbInstitucion.Size = new System.Drawing.Size(392, 22);
            this.cmbInstitucion.TabIndex = 54;
            // 
            // acaInstitucionInfoBindingSource
            // 
            this.acaInstitucionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Institucion_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
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
            this.colEstado,
            this.colLogo,
            this.colUsuarioCreacion,
            this.colUsuarioModificacion,
            this.colFechaCreacion,
            this.colFechaMoficacion,
            this.colpaisInfo,
            this.colciudadInfo,
            this.colprovinciaInfo});
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
            this.colIdInstitucion.Visible = true;
            this.colIdInstitucion.VisibleIndex = 0;
            this.colIdInstitucion.Width = 116;
            // 
            // colCodInstitucion
            // 
            this.colCodInstitucion.FieldName = "CodInstitucion";
            this.colCodInstitucion.Name = "colCodInstitucion";
            this.colCodInstitucion.OptionsColumn.AllowEdit = false;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 1058;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.OptionsColumn.AllowEdit = false;
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.OptionsColumn.AllowEdit = false;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            // 
            // colRector
            // 
            this.colRector.FieldName = "Rector";
            this.colRector.Name = "colRector";
            this.colRector.OptionsColumn.AllowEdit = false;
            // 
            // colCoordinador
            // 
            this.colCoordinador.FieldName = "Coordinador";
            this.colCoordinador.Name = "colCoordinador";
            this.colCoordinador.OptionsColumn.AllowEdit = false;
            // 
            // colSecretario
            // 
            this.colSecretario.FieldName = "Secretario";
            this.colSecretario.Name = "colSecretario";
            this.colSecretario.OptionsColumn.AllowEdit = false;
            // 
            // colResolucion_Academica
            // 
            this.colResolucion_Academica.FieldName = "Resolucion_Academica";
            this.colResolucion_Academica.Name = "colResolucion_Academica";
            this.colResolucion_Academica.OptionsColumn.AllowEdit = false;
            // 
            // colSitioWeb
            // 
            this.colSitioWeb.FieldName = "SitioWeb";
            this.colSitioWeb.Name = "colSitioWeb";
            this.colSitioWeb.OptionsColumn.AllowEdit = false;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            // 
            // colLogo
            // 
            this.colLogo.FieldName = "Logo";
            this.colLogo.Name = "colLogo";
            this.colLogo.OptionsColumn.AllowEdit = false;
            // 
            // colUsuarioCreacion
            // 
            this.colUsuarioCreacion.FieldName = "UsuarioCreacion";
            this.colUsuarioCreacion.Name = "colUsuarioCreacion";
            this.colUsuarioCreacion.OptionsColumn.AllowEdit = false;
            // 
            // colUsuarioModificacion
            // 
            this.colUsuarioModificacion.FieldName = "UsuarioModificacion";
            this.colUsuarioModificacion.Name = "colUsuarioModificacion";
            this.colUsuarioModificacion.OptionsColumn.AllowEdit = false;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.OptionsColumn.AllowEdit = false;
            // 
            // colFechaMoficacion
            // 
            this.colFechaMoficacion.FieldName = "FechaMoficacion";
            this.colFechaMoficacion.Name = "colFechaMoficacion";
            this.colFechaMoficacion.OptionsColumn.AllowEdit = false;
            // 
            // colpaisInfo
            // 
            this.colpaisInfo.FieldName = "paisInfo";
            this.colpaisInfo.Name = "colpaisInfo";
            this.colpaisInfo.OptionsColumn.AllowEdit = false;
            // 
            // colciudadInfo
            // 
            this.colciudadInfo.FieldName = "ciudadInfo";
            this.colciudadInfo.Name = "colciudadInfo";
            this.colciudadInfo.OptionsColumn.AllowEdit = false;
            // 
            // colprovinciaInfo
            // 
            this.colprovinciaInfo.FieldName = "provinciaInfo";
            this.colprovinciaInfo.Name = "colprovinciaInfo";
            this.colprovinciaInfo.OptionsColumn.AllowEdit = false;
            // 
            // chkActivo
            // 
            this.chkActivo.EditValue = true;
            this.chkActivo.Location = new System.Drawing.Point(503, 234);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Size = new System.Drawing.Size(80, 21);
            this.chkActivo.TabIndex = 55;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 282);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(609, 28);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 3;
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
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(609, 39);
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
            // ucGe_Sucursal_combo1
            // 
            this.ucGe_Sucursal_combo1.Location = new System.Drawing.Point(176, 181);
            this.ucGe_Sucursal_combo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucGe_Sucursal_combo1.Name = "ucGe_Sucursal_combo1";
            this.ucGe_Sucursal_combo1.Size = new System.Drawing.Size(397, 27);
            this.ucGe_Sucursal_combo1.TabIndex = 56;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(47, 181);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 16);
            this.labelControl1.TabIndex = 57;
            this.labelControl1.Text = "Sucursal:";
            // 
            // FrmAcaSede_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 310);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ucGe_Sucursal_combo1);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.cmbInstitucion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigoSede);
            this.Controls.Add(this.txtIdSede);
            this.Controls.Add(this.lblInstitucion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodigoSede);
            this.Controls.Add(this.lblIdSede);
            this.Controls.Add(this.lblAnulado);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAcaSede_Mant";
            this.Text = "FrmAcaSede_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcaSede_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAcaSede_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdSede.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoSede.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstitucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.LabelControl lblIdSede;
        private DevExpress.XtraEditors.LabelControl lblCodigoSede;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private DevExpress.XtraEditors.LabelControl lblInstitucion;
        private DevExpress.XtraEditors.TextEdit txtIdSede;
        private DevExpress.XtraEditors.TextEdit txtCodigoSede;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbInstitucion;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private System.Windows.Forms.BindingSource acaInstitucionInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
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
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colLogo;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaMoficacion;
        private DevExpress.XtraGrid.Columns.GridColumn colpaisInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colciudadInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colprovinciaInfo;
        private Controles.UCGe_Sucursal_combo ucGe_Sucursal_combo1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}