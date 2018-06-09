namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaRubroTipo_Cons
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
            this.gridControlRubroTipo = new DevExpress.XtraGrid.GridControl();
            this.acaRubroTipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewRubroTipo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTipoRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionTipoRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRubroTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaRubroTipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubroTipo)).BeginInit();
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
            this.Menu.fecha_desde = new System.DateTime(2017, 4, 19, 13, 10, 57, 659);
            this.Menu.fecha_hasta = new System.DateTime(2017, 6, 19, 13, 10, 57, 659);
            this.Menu.FormConsulta = null;
            this.Menu.FormMain = null;
            this.Menu.GridControlConsulta = null;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Perfil_x_usuario = null;
            this.Menu.Size = new System.Drawing.Size(709, 113);
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
            this.BarraEstado.Location = new System.Drawing.Point(0, 377);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(709, 26);
            this.BarraEstado.TabIndex = 2;
            // 
            // gridControlRubroTipo
            // 
            this.gridControlRubroTipo.DataSource = this.acaRubroTipoInfoBindingSource;
            this.gridControlRubroTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRubroTipo.Location = new System.Drawing.Point(0, 113);
            this.gridControlRubroTipo.MainView = this.gridViewRubroTipo;
            this.gridControlRubroTipo.Name = "gridControlRubroTipo";
            this.gridControlRubroTipo.Size = new System.Drawing.Size(709, 264);
            this.gridControlRubroTipo.TabIndex = 3;
            this.gridControlRubroTipo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRubroTipo});
            // 
            // acaRubroTipoInfoBindingSource
            // 
            this.acaRubroTipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_RubroTipo_Info);
            // 
            // gridViewRubroTipo
            // 
            this.gridViewRubroTipo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoRubro,
            this.colCodTipoRubro,
            this.colDescripcionTipoRubro,
            this.colEstado,
            this.colFechaCreacion,
            this.colFechaModificacion,
            this.colFechaAnulacion,
            this.colUsuarioCreacion,
            this.colUsuarioModificacion,
            this.colUsuarioAnulacion});
            this.gridViewRubroTipo.GridControl = this.gridControlRubroTipo;
            this.gridViewRubroTipo.Name = "gridViewRubroTipo";
            this.gridViewRubroTipo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewRubroTipo.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewRubroTipo_RowStyle);
            // 
            // colIdTipoRubro
            // 
            this.colIdTipoRubro.FieldName = "IdTipoRubro";
            this.colIdTipoRubro.Name = "colIdTipoRubro";
            this.colIdTipoRubro.OptionsColumn.AllowEdit = false;
            this.colIdTipoRubro.Visible = true;
            this.colIdTipoRubro.VisibleIndex = 0;
            // 
            // colCodTipoRubro
            // 
            this.colCodTipoRubro.Caption = "Código Tipo Rubro";
            this.colCodTipoRubro.FieldName = "CodTipoRubro";
            this.colCodTipoRubro.Name = "colCodTipoRubro";
            this.colCodTipoRubro.OptionsColumn.AllowEdit = false;
            this.colCodTipoRubro.Visible = true;
            this.colCodTipoRubro.VisibleIndex = 1;
            // 
            // colDescripcionTipoRubro
            // 
            this.colDescripcionTipoRubro.Caption = "Descripción";
            this.colDescripcionTipoRubro.FieldName = "DescripcionTipoRubro";
            this.colDescripcionTipoRubro.Name = "colDescripcionTipoRubro";
            this.colDescripcionTipoRubro.OptionsColumn.AllowEdit = false;
            this.colDescripcionTipoRubro.Visible = true;
            this.colDescripcionTipoRubro.VisibleIndex = 2;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 3;
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
            // FrmAcaRubroTipo_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 403);
            this.Controls.Add(this.gridControlRubroTipo);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.Menu);
            this.Name = "FrmAcaRubroTipo_Cons";
            this.Text = "FrmAcaRubroTipo_Cons";
            this.Load += new System.EventHandler(this.FrmAcaRubroTipo_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRubroTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaRubroTipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubroTipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms BarraEstado;
        private DevExpress.XtraGrid.GridControl gridControlRubroTipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRubroTipo;
        private System.Windows.Forms.BindingSource acaRubroTipoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTipoRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionTipoRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioAnulacion;
    }
}