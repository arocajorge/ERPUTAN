namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaInstitucion_Cons
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControlInstitucion = new DevExpress.XtraGrid.GridControl();
            this.acaInstitucionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gviewInstitucion = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.colFoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaMoficacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coNombrePais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreProvincia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpaisInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colciudadInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprovinciaInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInstitucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gviewInstitucion)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_anular = true;
            this.ucGe_Menu.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu.Enable_boton_consultar = true;
            this.ucGe_Menu.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu.Enable_boton_Duplicar = true;
            this.ucGe_Menu.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu.Enable_boton_GenerarXml = true;
            this.ucGe_Menu.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu.Enable_boton_Importar_XML = true;
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 7, 11, 9, 38, 24, 393);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2015, 9, 11, 9, 38, 24, 393);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(746, 117);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = true;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_event_btnAnular_ItemClick);
            this.ucGe_Menu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_event_btnImprimir_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            // 
            // ucGe_Mant_Menu1
            // 
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 358);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(746, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 2;
            // 
            // gridControlInstitucion
            // 
            this.gridControlInstitucion.DataSource = this.acaInstitucionInfoBindingSource;
            this.gridControlInstitucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlInstitucion.Location = new System.Drawing.Point(0, 117);
            this.gridControlInstitucion.MainView = this.gviewInstitucion;
            this.gridControlInstitucion.Name = "gridControlInstitucion";
            this.gridControlInstitucion.Size = new System.Drawing.Size(746, 241);
            this.gridControlInstitucion.TabIndex = 3;
            this.gridControlInstitucion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gviewInstitucion});
            // 
            // acaInstitucionInfoBindingSource
            // 
            this.acaInstitucionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Institucion_Info);
            // 
            // gviewInstitucion
            // 
            this.gviewInstitucion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.colFoto,
            this.colUsuarioCreacion,
            this.colUsuarioModificacion,
            this.colFechaCreacion,
            this.colFechaMoficacion,
            this.coNombrePais,
            this.colNombreProvincia,
            this.colNombreCiudad,
            this.colpaisInfo,
            this.colciudadInfo,
            this.colprovinciaInfo});
            this.gviewInstitucion.GridControl = this.gridControlInstitucion;
            this.gviewInstitucion.Name = "gviewInstitucion";
            this.gviewInstitucion.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gviewInstitucion_RowStyle);
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
            this.colIdInstitucion.Width = 77;
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
            this.colNombre.Width = 169;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.OptionsColumn.AllowEdit = false;
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 2;
            this.colDireccion.Width = 236;
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.OptionsColumn.AllowEdit = false;
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 3;
            this.colTelefono.Width = 84;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 4;
            this.colFax.Width = 84;
            // 
            // colRector
            // 
            this.colRector.FieldName = "Rector";
            this.colRector.Name = "colRector";
            this.colRector.OptionsColumn.AllowEdit = false;
            this.colRector.Visible = true;
            this.colRector.VisibleIndex = 5;
            this.colRector.Width = 84;
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
            this.colSitioWeb.Visible = true;
            this.colSitioWeb.VisibleIndex = 6;
            this.colSitioWeb.Width = 84;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 10;
            this.colEstado.Width = 84;
            // 
            // colFoto
            // 
            this.colFoto.FieldName = "Foto";
            this.colFoto.Name = "colFoto";
            this.colFoto.OptionsColumn.AllowEdit = false;
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
            // coNombrePais
            // 
            this.coNombrePais.Caption = "Pais";
            this.coNombrePais.FieldName = "paisInfo.Nombre";
            this.coNombrePais.Name = "coNombrePais";
            this.coNombrePais.OptionsColumn.AllowEdit = false;
            this.coNombrePais.Visible = true;
            this.coNombrePais.VisibleIndex = 7;
            this.coNombrePais.Width = 84;
            // 
            // colNombreProvincia
            // 
            this.colNombreProvincia.Caption = "Provincia";
            this.colNombreProvincia.FieldName = "provinciaInfo.Descripcion";
            this.colNombreProvincia.Name = "colNombreProvincia";
            this.colNombreProvincia.OptionsColumn.AllowEdit = false;
            this.colNombreProvincia.Visible = true;
            this.colNombreProvincia.VisibleIndex = 8;
            this.colNombreProvincia.Width = 84;
            // 
            // colNombreCiudad
            // 
            this.colNombreCiudad.Caption = "Ciudad";
            this.colNombreCiudad.FieldName = "ciudadInfo.Descripcion";
            this.colNombreCiudad.Name = "colNombreCiudad";
            this.colNombreCiudad.OptionsColumn.AllowEdit = false;
            this.colNombreCiudad.Visible = true;
            this.colNombreCiudad.VisibleIndex = 9;
            this.colNombreCiudad.Width = 104;
            // 
            // colpaisInfo
            // 
            this.colpaisInfo.Caption = "Id Pais";
            this.colpaisInfo.FieldName = "paisInfo.IdPais";
            this.colpaisInfo.Name = "colpaisInfo";
            this.colpaisInfo.OptionsColumn.AllowEdit = false;
            // 
            // colciudadInfo
            // 
            this.colciudadInfo.Caption = "Id Ciudad";
            this.colciudadInfo.FieldName = "ciudadInfo.IdCiudad";
            this.colciudadInfo.Name = "colciudadInfo";
            this.colciudadInfo.OptionsColumn.AllowEdit = false;
            // 
            // colprovinciaInfo
            // 
            this.colprovinciaInfo.Caption = "Id Provincia";
            this.colprovinciaInfo.FieldName = "provinciaInfo.IdProvincia";
            this.colprovinciaInfo.Name = "colprovinciaInfo";
            this.colprovinciaInfo.OptionsColumn.AllowEdit = false;
            // 
            // FrmAcaInstitucion_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 384);
            this.Controls.Add(this.gridControlInstitucion);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAcaInstitucion_Cons";
            this.Text = "FrmInstitucion_Cons";
            this.Load += new System.EventHandler(this.FrmInstitucion_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInstitucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gviewInstitucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl gridControlInstitucion;
        private DevExpress.XtraGrid.Views.Grid.GridView gviewInstitucion;
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
        private DevExpress.XtraGrid.Columns.GridColumn colFoto;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaMoficacion;
        private DevExpress.XtraGrid.Columns.GridColumn coNombrePais;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreProvincia;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn colpaisInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colciudadInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colprovinciaInfo;
    }
}