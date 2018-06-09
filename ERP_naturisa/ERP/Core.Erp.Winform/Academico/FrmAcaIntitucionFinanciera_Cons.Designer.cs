namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaIntitucionFinanciera_Cons
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
            this.ucGe_BarraEstadoInferior_Forms = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControlInstitucionFinanciera = new DevExpress.XtraGrid.GridControl();
            this.acaInstitucionFinancieraInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewInstitucionFinanciera = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdInstitucionFinanciera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoInstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreInstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCuentaCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoAlterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreAlterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorc_comision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInstitucionFinanciera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionFinancieraInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInstitucionFinanciera)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.CargarTodasBodegas = false;
            this.ucGe_Menu.CargarTodasSucursales = true;
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 4, 19, 12, 32, 33, 886);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 6, 19, 12, 32, 33, 886);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(620, 112);
            this.ucGe_Menu.TabIndex = 4;
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
            this.ucGe_Menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_event_btnAnular_ItemClick);
            this.ucGe_Menu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_event_btnImprimir_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            // 
            // ucGe_BarraEstadoInferior_Forms
            // 
            this.ucGe_BarraEstadoInferior_Forms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms.Location = new System.Drawing.Point(0, 336);
            this.ucGe_BarraEstadoInferior_Forms.Name = "ucGe_BarraEstadoInferior_Forms";
            this.ucGe_BarraEstadoInferior_Forms.Size = new System.Drawing.Size(620, 31);
            this.ucGe_BarraEstadoInferior_Forms.TabIndex = 5;
            // 
            // gridControlInstitucionFinanciera
            // 
            this.gridControlInstitucionFinanciera.DataSource = this.acaInstitucionFinancieraInfoBindingSource;
            this.gridControlInstitucionFinanciera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlInstitucionFinanciera.Location = new System.Drawing.Point(0, 112);
            this.gridControlInstitucionFinanciera.MainView = this.gridViewInstitucionFinanciera;
            this.gridControlInstitucionFinanciera.Name = "gridControlInstitucionFinanciera";
            this.gridControlInstitucionFinanciera.Size = new System.Drawing.Size(620, 224);
            this.gridControlInstitucionFinanciera.TabIndex = 6;
            this.gridControlInstitucionFinanciera.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInstitucionFinanciera});
            // 
            // acaInstitucionFinancieraInfoBindingSource
            // 
            this.acaInstitucionFinancieraInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_InstitucionFinanciera_Info);
            // 
            // gridViewInstitucionFinanciera
            // 
            this.gridViewInstitucionFinanciera.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdInstitucionFinanciera,
            this.colCodigoInstitucion,
            this.colNombreInstitucion,
            this.colIdTipoCuentaCatalogo,
            this.colCodigoAlterno,
            this.colNombreAlterno,
            this.colPorc_comision,
            this.colEstado,
            this.colFechaCreacion,
            this.colFechaModificacion,
            this.colFechaAnulacion,
            this.colUsuarioCreacion,
            this.colUsuarioModificacion,
            this.colUsuarioAnulacion,
            this.colMotivoAnulacion,
            this.ColCuenta});
            this.gridViewInstitucionFinanciera.GridControl = this.gridControlInstitucionFinanciera;
            this.gridViewInstitucionFinanciera.Name = "gridViewInstitucionFinanciera";
            this.gridViewInstitucionFinanciera.OptionsView.ShowAutoFilterRow = true;
            this.gridViewInstitucionFinanciera.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewInstitucionFinanciera_RowStyle);
            // 
            // colIdInstitucionFinanciera
            // 
            this.colIdInstitucionFinanciera.FieldName = "IdInstitucionFinanciera";
            this.colIdInstitucionFinanciera.Name = "colIdInstitucionFinanciera";
            this.colIdInstitucionFinanciera.OptionsColumn.AllowEdit = false;
            this.colIdInstitucionFinanciera.Visible = true;
            this.colIdInstitucionFinanciera.VisibleIndex = 0;
            // 
            // colCodigoInstitucion
            // 
            this.colCodigoInstitucion.FieldName = "CodigoInstitucion";
            this.colCodigoInstitucion.Name = "colCodigoInstitucion";
            this.colCodigoInstitucion.OptionsColumn.AllowEdit = false;
            this.colCodigoInstitucion.Visible = true;
            this.colCodigoInstitucion.VisibleIndex = 2;
            // 
            // colNombreInstitucion
            // 
            this.colNombreInstitucion.FieldName = "NombreInstitucion";
            this.colNombreInstitucion.Name = "colNombreInstitucion";
            this.colNombreInstitucion.OptionsColumn.AllowEdit = false;
            this.colNombreInstitucion.Visible = true;
            this.colNombreInstitucion.VisibleIndex = 3;
            // 
            // colIdTipoCuentaCatalogo
            // 
            this.colIdTipoCuentaCatalogo.FieldName = "IdTipoCuentaCatalogo";
            this.colIdTipoCuentaCatalogo.Name = "colIdTipoCuentaCatalogo";
            this.colIdTipoCuentaCatalogo.OptionsColumn.AllowEdit = false;
            // 
            // colCodigoAlterno
            // 
            this.colCodigoAlterno.FieldName = "CodigoAlterno";
            this.colCodigoAlterno.Name = "colCodigoAlterno";
            this.colCodigoAlterno.OptionsColumn.AllowEdit = false;
            this.colCodigoAlterno.Visible = true;
            this.colCodigoAlterno.VisibleIndex = 4;
            // 
            // colNombreAlterno
            // 
            this.colNombreAlterno.FieldName = "NombreAlterno";
            this.colNombreAlterno.Name = "colNombreAlterno";
            this.colNombreAlterno.OptionsColumn.AllowEdit = false;
            this.colNombreAlterno.Visible = true;
            this.colNombreAlterno.VisibleIndex = 5;
            // 
            // colPorc_comision
            // 
            this.colPorc_comision.FieldName = "Porc_comision";
            this.colPorc_comision.Name = "colPorc_comision";
            this.colPorc_comision.OptionsColumn.AllowEdit = false;
            this.colPorc_comision.Visible = true;
            this.colPorc_comision.VisibleIndex = 6;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 7;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.OptionsColumn.AllowEdit = false;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            this.colFechaModificacion.OptionsColumn.AllowEdit = false;
            // 
            // colFechaAnulacion
            // 
            this.colFechaAnulacion.FieldName = "FechaAnulacion";
            this.colFechaAnulacion.Name = "colFechaAnulacion";
            this.colFechaAnulacion.OptionsColumn.AllowEdit = false;
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
            // colUsuarioAnulacion
            // 
            this.colUsuarioAnulacion.FieldName = "UsuarioAnulacion";
            this.colUsuarioAnulacion.Name = "colUsuarioAnulacion";
            this.colUsuarioAnulacion.OptionsColumn.AllowEdit = false;
            // 
            // colMotivoAnulacion
            // 
            this.colMotivoAnulacion.FieldName = "MotivoAnulacion";
            this.colMotivoAnulacion.Name = "colMotivoAnulacion";
            this.colMotivoAnulacion.OptionsColumn.AllowEdit = false;
            // 
            // ColCuenta
            // 
            this.ColCuenta.Caption = "Tipo Cuenta";
            this.ColCuenta.FieldName = "catalogoInfo.Descripcion";
            this.ColCuenta.Name = "ColCuenta";
            this.ColCuenta.OptionsColumn.AllowEdit = false;
            this.ColCuenta.Visible = true;
            this.ColCuenta.VisibleIndex = 1;
            // 
            // FrmAcaIntitucionFinanciera_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 367);
            this.Controls.Add(this.gridControlInstitucionFinanciera);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAcaIntitucionFinanciera_Cons";
            this.Text = "FrmAca_IntitucionFinanciera_Cons";
            this.Load += new System.EventHandler(this.FrmAca_IntitucionFinanciera_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInstitucionFinanciera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionFinancieraInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInstitucionFinanciera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms;
        private DevExpress.XtraGrid.GridControl gridControlInstitucionFinanciera;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInstitucionFinanciera;
        private System.Windows.Forms.BindingSource acaInstitucionFinancieraInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdInstitucionFinanciera;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoInstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreInstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCuentaCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoAlterno;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreAlterno;
        private DevExpress.XtraGrid.Columns.GridColumn colPorc_comision;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn ColCuenta;
    }
}