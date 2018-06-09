namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaAspirante_Cons
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
            this.gridControlAspirante = new DevExpress.XtraGrid.GridControl();
            this.acaAspiranteInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewAspirante = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdAspirante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodAspirante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersona_Info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLugar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarrio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodAlterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPais_Info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAspirante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaAspiranteInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAspirante)).BeginInit();
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 4, 19, 12, 31, 16, 47);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 6, 19, 12, 31, 16, 47);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(749, 112);
            this.ucGe_Menu.TabIndex = 2;
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
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 386);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(749, 31);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 3;
            // 
            // gridControlAspirante
            // 
            this.gridControlAspirante.DataSource = this.acaAspiranteInfoBindingSource;
            this.gridControlAspirante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAspirante.Location = new System.Drawing.Point(0, 112);
            this.gridControlAspirante.MainView = this.gridViewAspirante;
            this.gridControlAspirante.Name = "gridControlAspirante";
            this.gridControlAspirante.Size = new System.Drawing.Size(749, 274);
            this.gridControlAspirante.TabIndex = 4;
            this.gridControlAspirante.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAspirante});
            // 
            // acaAspiranteInfoBindingSource
            // 
            this.acaAspiranteInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Aspirante_Info);
            // 
            // gridViewAspirante
            // 
            this.gridViewAspirante.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdAspirante,
            this.colCodAspirante,
            this.colCedula,
            this.colPersona_Info,
            this.colApellido,
            this.colLugar,
            this.colBarrio,
            this.colFoto,
            this.colEstado,
            this.colCodAlterno,
            this.colPais_Info,
            this.colFechaModificacion,
            this.colFechaCreacion,
            this.colUsuarioModificacion,
            this.colUsuarioCreacion});
            this.gridViewAspirante.GridControl = this.gridControlAspirante;
            this.gridViewAspirante.Name = "gridViewAspirante";
            this.gridViewAspirante.OptionsView.ShowAutoFilterRow = true;
            this.gridViewAspirante.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewAspirante_RowCellStyle);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            this.colIdEmpresa.Width = 92;
            // 
            // colIdAspirante
            // 
            this.colIdAspirante.FieldName = "IdAspirante";
            this.colIdAspirante.Name = "colIdAspirante";
            this.colIdAspirante.OptionsColumn.AllowEdit = false;
            this.colIdAspirante.Visible = true;
            this.colIdAspirante.VisibleIndex = 0;
            this.colIdAspirante.Width = 69;
            // 
            // colCodAspirante
            // 
            this.colCodAspirante.FieldName = "CodAspirante";
            this.colCodAspirante.Name = "colCodAspirante";
            this.colCodAspirante.OptionsColumn.AllowEdit = false;
            this.colCodAspirante.Visible = true;
            this.colCodAspirante.VisibleIndex = 1;
            this.colCodAspirante.Width = 81;
            // 
            // colCedula
            // 
            this.colCedula.Caption = "Cédula";
            this.colCedula.FieldName = "Persona_Info.pe_cedulaRuc";
            this.colCedula.Name = "colCedula";
            this.colCedula.OptionsColumn.AllowEdit = false;
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 2;
            this.colCedula.Width = 132;
            // 
            // colPersona_Info
            // 
            this.colPersona_Info.Caption = "Nombre";
            this.colPersona_Info.FieldName = "Persona_Info.pe_nombre";
            this.colPersona_Info.Name = "colPersona_Info";
            this.colPersona_Info.OptionsColumn.AllowEdit = false;
            this.colPersona_Info.Visible = true;
            this.colPersona_Info.VisibleIndex = 3;
            this.colPersona_Info.Width = 140;
            // 
            // colApellido
            // 
            this.colApellido.Caption = "Apellido";
            this.colApellido.FieldName = "Persona_Info.pe_apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.OptionsColumn.AllowEdit = false;
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 4;
            this.colApellido.Width = 351;
            // 
            // colLugar
            // 
            this.colLugar.FieldName = "Lugar";
            this.colLugar.Name = "colLugar";
            this.colLugar.OptionsColumn.AllowEdit = false;
            this.colLugar.Visible = true;
            this.colLugar.VisibleIndex = 5;
            this.colLugar.Width = 120;
            // 
            // colBarrio
            // 
            this.colBarrio.FieldName = "Barrio";
            this.colBarrio.Name = "colBarrio";
            this.colBarrio.OptionsColumn.AllowEdit = false;
            this.colBarrio.Visible = true;
            this.colBarrio.VisibleIndex = 6;
            this.colBarrio.Width = 85;
            // 
            // colFoto
            // 
            this.colFoto.FieldName = "Foto";
            this.colFoto.Name = "colFoto";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 8;
            this.colEstado.Width = 58;
            // 
            // colCodAlterno
            // 
            this.colCodAlterno.FieldName = "CodAlterno";
            this.colCodAlterno.Name = "colCodAlterno";
            this.colCodAlterno.OptionsColumn.AllowEdit = false;
            // 
            // colPais_Info
            // 
            this.colPais_Info.Caption = "Nacionalidad";
            this.colPais_Info.FieldName = "Pais_Info.Nacionalidad";
            this.colPais_Info.Name = "colPais_Info";
            this.colPais_Info.OptionsColumn.AllowEdit = false;
            this.colPais_Info.Visible = true;
            this.colPais_Info.VisibleIndex = 7;
            this.colPais_Info.Width = 122;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            // 
            // colUsuarioModificacion
            // 
            this.colUsuarioModificacion.FieldName = "UsuarioModificacion";
            this.colUsuarioModificacion.Name = "colUsuarioModificacion";
            // 
            // colUsuarioCreacion
            // 
            this.colUsuarioCreacion.FieldName = "UsuarioCreacion";
            this.colUsuarioCreacion.Name = "colUsuarioCreacion";
            // 
            // FrmAcaAspirante_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 417);
            this.Controls.Add(this.gridControlAspirante);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAcaAspirante_Cons";
            this.Text = "FrmAcaAspirante_Cons";
            this.Load += new System.EventHandler(this.FrmAcaAspirante_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAspirante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaAspiranteInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAspirante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl gridControlAspirante;
        private System.Windows.Forms.BindingSource acaAspiranteInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAspirante;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAspirante;
        private DevExpress.XtraGrid.Columns.GridColumn colCodAspirante;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colPersona_Info;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colLugar;
        private DevExpress.XtraGrid.Columns.GridColumn colBarrio;
        private DevExpress.XtraGrid.Columns.GridColumn colFoto;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colCodAlterno;
        private DevExpress.XtraGrid.Columns.GridColumn colPais_Info;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;


    }
}