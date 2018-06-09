namespace Core.Erp.Winform.Academico
{
    partial class FrmAca_Rubro_x_Aca_Periodo_Lectivo_Cons
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
            this.Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControlRubros = new DevExpress.XtraGrid.GridControl();
            this.acaRubroInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewRubro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion_rubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodAlterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroCoutas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeb_cred = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaRubroInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubro)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.CargarTodasBodegas = false;
            this.Menu.CargarTodasSucursales = true;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Enable_boton_anular = true;
            this.Menu.Enable_boton_CancelarCuotas = true;
            this.Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.Menu.Enable_boton_consultar = true;
            this.Menu.Enable_boton_DiseñoCheque = true;
            this.Menu.Enable_boton_DiseñoChequeComprobante = true;
            this.Menu.Enable_boton_Duplicar = true;
            this.Menu.Enable_boton_GenerarPeriodos = true;
            this.Menu.Enable_boton_GenerarXml = true;
            this.Menu.Enable_boton_Habilitar_Reg = true;
            this.Menu.Enable_boton_Importar_XML = true;
            this.Menu.Enable_boton_imprimir = true;
            this.Menu.Enable_boton_LoteCheque = true;
            this.Menu.Enable_boton_modificar = true;
            this.Menu.Enable_boton_nuevo = true;
            this.Menu.Enable_boton_NuevoCheque = true;
            this.Menu.Enable_boton_periodo = true;
            this.Menu.Enable_boton_salir = true;
            this.Menu.Enable_btnImpExcel = true;
            this.Menu.Enable_Descargar_Marca_Base_exter = true;
            this.Menu.fecha_desde = new System.DateTime(2017, 4, 19, 12, 27, 36, 664);
            this.Menu.fecha_hasta = new System.DateTime(2017, 6, 19, 12, 27, 36, 664);
            this.Menu.FormConsulta = null;
            this.Menu.FormMain = null;
            this.Menu.GridControlConsulta = null;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Perfil_x_usuario = null;
            this.Menu.Size = new System.Drawing.Size(631, 113);
            this.Menu.TabIndex = 1;
            this.Menu.Visible_bodega = false;
            this.Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_fechas = false;
            this.Menu.Visible_Grupo_Cancelaciones = true;
            this.Menu.Visible_Grupo_Diseño_Reporte = false;
            this.Menu.Visible_Grupo_filtro = true;
            this.Menu.Visible_Grupo_Impresion = true;
            this.Menu.Visible_Grupo_Otras_Trans = true;
            this.Menu.Visible_Grupo_Transacciones = true;
            this.Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.Menu.Visible_ribbon_control = true;
            this.Menu.Visible_sucursal = false;
            this.Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.Menu_event_btnNuevo_ItemClick);
            this.Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.Menu_event_btnModificar_ItemClick);
            this.Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.Menu_event_btnconsultar_ItemClick);
            this.Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.Menu_event_btnAnular_ItemClick);
            this.Menu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.Menu_event_btnImprimir_ItemClick);
            this.Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.Menu_event_btnSalir_ItemClick);
            // 
            // BarraEstado
            // 
            this.BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraEstado.Location = new System.Drawing.Point(0, 385);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(631, 26);
            this.BarraEstado.TabIndex = 2;
            // 
            // gridControlRubros
            // 
            this.gridControlRubros.DataSource = this.acaRubroInfoBindingSource;
            this.gridControlRubros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRubros.Location = new System.Drawing.Point(0, 113);
            this.gridControlRubros.MainView = this.gridViewRubro;
            this.gridControlRubros.Name = "gridControlRubros";
            this.gridControlRubros.Size = new System.Drawing.Size(631, 272);
            this.gridControlRubros.TabIndex = 3;
            this.gridControlRubros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRubro});
            // 
            // acaRubroInfoBindingSource
            // 
            this.acaRubroInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Rubro_Info);
            // 
            // gridViewRubro
            // 
            this.gridViewRubro.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdRubro,
            this.colCodRubro,
            this.colDescripcion_rubro,
            this.colEstado,
            this.colCodAlterno,
            this.colIdTipoServicio,
            this.colIdTipoRubro,
            this.colNumeroCoutas,
            this.colDeb_cred,
            this.colFechaCreacion,
            this.colFechaModificacion,
            this.colFechaAnulacion,
            this.colUsuarioCreacion,
            this.colUsuarioModificacion,
            this.colUsuarioAnulacion});
            this.gridViewRubro.GridControl = this.gridControlRubros;
            this.gridViewRubro.Name = "gridViewRubro";
            this.gridViewRubro.OptionsView.ShowAutoFilterRow = true;
            this.gridViewRubro.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewRubro_RowStyle);
            // 
            // colIdRubro
            // 
            this.colIdRubro.FieldName = "IdRubro";
            this.colIdRubro.Name = "colIdRubro";
            this.colIdRubro.OptionsColumn.AllowEdit = false;
            this.colIdRubro.Visible = true;
            this.colIdRubro.VisibleIndex = 0;
            this.colIdRubro.Width = 231;
            // 
            // colCodRubro
            // 
            this.colCodRubro.FieldName = "CodRubro";
            this.colCodRubro.Name = "colCodRubro";
            this.colCodRubro.OptionsColumn.AllowEdit = false;
            this.colCodRubro.Visible = true;
            this.colCodRubro.VisibleIndex = 1;
            this.colCodRubro.Width = 231;
            // 
            // colDescripcion_rubro
            // 
            this.colDescripcion_rubro.Caption = "Descripcion";
            this.colDescripcion_rubro.FieldName = "Descripcion_rubro";
            this.colDescripcion_rubro.Name = "colDescripcion_rubro";
            this.colDescripcion_rubro.OptionsColumn.AllowEdit = false;
            this.colDescripcion_rubro.Visible = true;
            this.colDescripcion_rubro.VisibleIndex = 2;
            this.colDescripcion_rubro.Width = 362;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 4;
            this.colEstado.Width = 169;
            // 
            // colCodAlterno
            // 
            this.colCodAlterno.FieldName = "CodAlterno";
            this.colCodAlterno.Name = "colCodAlterno";
            this.colCodAlterno.OptionsColumn.AllowEdit = false;
            // 
            // colIdTipoServicio
            // 
            this.colIdTipoServicio.FieldName = "IdTipoServicio";
            this.colIdTipoServicio.Name = "colIdTipoServicio";
            this.colIdTipoServicio.OptionsColumn.AllowEdit = false;
            // 
            // colIdTipoRubro
            // 
            this.colIdTipoRubro.FieldName = "IdTipoRubro";
            this.colIdTipoRubro.Name = "colIdTipoRubro";
            this.colIdTipoRubro.OptionsColumn.AllowEdit = false;
            // 
            // colNumeroCoutas
            // 
            this.colNumeroCoutas.FieldName = "NumeroCoutas";
            this.colNumeroCoutas.Name = "colNumeroCoutas";
            this.colNumeroCoutas.OptionsColumn.AllowEdit = false;
            this.colNumeroCoutas.Visible = true;
            this.colNumeroCoutas.VisibleIndex = 3;
            this.colNumeroCoutas.Width = 165;
            // 
            // colDeb_cred
            // 
            this.colDeb_cred.FieldName = "Deb_cred";
            this.colDeb_cred.Name = "colDeb_cred";
            this.colDeb_cred.OptionsColumn.AllowEdit = false;
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
            // FrmAca_Rubro_x_Aca_Periodo_Lectivo_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 411);
            this.Controls.Add(this.gridControlRubros);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.Menu);
            this.Name = "FrmAca_Rubro_x_Aca_Periodo_Lectivo_Cons";
            this.Text = "FrmAcaRubro_x_Aca_Periodo_Lectivo_Cons";
            this.Load += new System.EventHandler(this.FrmAcaRubro_x_Aca_Periodo_Lectivo_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaRubroInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms BarraEstado;
        private DevExpress.XtraGrid.GridControl gridControlRubros;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRubro;
        private System.Windows.Forms.BindingSource acaRubroInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colCodRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_rubro;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colCodAlterno;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoServicio;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroCoutas;
        private DevExpress.XtraGrid.Columns.GridColumn colDeb_cred;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioAnulacion;
    }
}