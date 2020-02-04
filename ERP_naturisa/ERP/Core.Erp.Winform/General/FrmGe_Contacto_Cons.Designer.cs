namespace Core.Erp.Winform.General
{
    partial class FrmGe_Contacto_Cons
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
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControlContactos = new DevExpress.XtraGrid.GridControl();
            this.gridViewContacto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrganizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoChequeComprobante = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Habilitar_Reg = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Importar_XML = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_btnImpExcel = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_Descargar_Marca_Base_exter = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 2, 1, 11, 19, 10, 875);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 3, 2, 11, 19, 10, 875);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(746, 177);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 4;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms
            // 
            this.ucGe_BarraEstadoInferior_Forms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms.Location = new System.Drawing.Point(0, 348);
            this.ucGe_BarraEstadoInferior_Forms.Name = "ucGe_BarraEstadoInferior_Forms";
            this.ucGe_BarraEstadoInferior_Forms.Size = new System.Drawing.Size(746, 34);
            this.ucGe_BarraEstadoInferior_Forms.TabIndex = 5;
            // 
            // gridControlContactos
            // 
            this.gridControlContactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlContactos.Location = new System.Drawing.Point(0, 177);
            this.gridControlContactos.MainView = this.gridViewContacto;
            this.gridControlContactos.Name = "gridControlContactos";
            this.gridControlContactos.Size = new System.Drawing.Size(746, 171);
            this.gridControlContactos.TabIndex = 6;
            this.gridControlContactos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewContacto});
            // 
            // gridViewContacto
            // 
            this.gridViewContacto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPersona,
            this.colIdContacto,
            this.colCedula,
            this.colNombre,
            this.colApellido,
            this.colNombreCompleto,
            this.colTelefono,
            this.colCelular,
            this.colDireccion,
            this.colOrganizacion,
            this.colCargo});
            this.gridViewContacto.GridControl = this.gridControlContactos;
            this.gridViewContacto.Name = "gridViewContacto";
            this.gridViewContacto.OptionsView.ShowAutoFilterRow = true;
            this.gridViewContacto.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewContacto_RowStyle);
            this.gridViewContacto.DoubleClick += new System.EventHandler(this.gridViewContacto_DoubleClick);
            // 
            // colIdPersona
            // 
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            this.colIdPersona.OptionsColumn.AllowEdit = false;
            this.colIdPersona.Visible = true;
            this.colIdPersona.VisibleIndex = 8;
            this.colIdPersona.Width = 76;
            // 
            // colIdContacto
            // 
            this.colIdContacto.Caption = "Identificador";
            this.colIdContacto.FieldName = "IdContacto";
            this.colIdContacto.Name = "colIdContacto";
            this.colIdContacto.OptionsColumn.AllowEdit = false;
            this.colIdContacto.Visible = true;
            this.colIdContacto.VisibleIndex = 0;
            this.colIdContacto.Width = 61;
            // 
            // colCedula
            // 
            this.colCedula.Caption = "Cedula";
            this.colCedula.FieldName = "Persona_Info.pe_cedulaRuc";
            this.colCedula.Name = "colCedula";
            this.colCedula.OptionsColumn.AllowEdit = false;
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 4;
            this.colCedula.Width = 127;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombres";
            this.colNombre.FieldName = "Persona_Info.pe_nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 140;
            // 
            // colApellido
            // 
            this.colApellido.Caption = "Apellidos";
            this.colApellido.FieldName = "Persona_Info.pe_apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.OptionsColumn.AllowEdit = false;
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 2;
            this.colApellido.Width = 141;
            // 
            // colNombreCompleto
            // 
            this.colNombreCompleto.Caption = "Nombre Completo";
            this.colNombreCompleto.FieldName = "Persona_Info.pe_nombreCompleto";
            this.colNombreCompleto.Name = "colNombreCompleto";
            this.colNombreCompleto.OptionsColumn.AllowEdit = false;
            this.colNombreCompleto.Visible = true;
            this.colNombreCompleto.VisibleIndex = 3;
            this.colNombreCompleto.Width = 211;
            // 
            // colTelefono
            // 
            this.colTelefono.Caption = "Teléfono Convencional";
            this.colTelefono.FieldName = "Persona_Info.pe_telefonoCasa";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.OptionsColumn.AllowEdit = false;
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 7;
            this.colTelefono.Width = 128;
            // 
            // colCelular
            // 
            this.colCelular.Caption = "Celular";
            this.colCelular.FieldName = "Persona_Info.pe_celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.OptionsColumn.AllowEdit = false;
            this.colCelular.Visible = true;
            this.colCelular.VisibleIndex = 6;
            // 
            // colDireccion
            // 
            this.colDireccion.Caption = "Dirección";
            this.colDireccion.FieldName = "Persona_Info.pe_direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.OptionsColumn.AllowEdit = false;
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 5;
            this.colDireccion.Width = 221;
            // 
            // colOrganizacion
            // 
            this.colOrganizacion.FieldName = "Organizacion";
            this.colOrganizacion.Name = "colOrganizacion";
            this.colOrganizacion.Width = 157;
            // 
            // colCargo
            // 
            this.colCargo.FieldName = "Cargo";
            this.colCargo.Name = "colCargo";
            this.colCargo.Width = 157;
            // 
            // FrmGe_Contacto_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 382);
            this.Controls.Add(this.gridControlContactos);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "FrmGe_Contacto_Cons";
            this.Text = "Consulta Contactos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGe_Contacto_Cons_FormClosing);
            this.Load += new System.EventHandler(this.FormGe_Contacto_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContacto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms;
        private DevExpress.XtraGrid.GridControl gridControlContactos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colIdContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colCelular;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colOrganizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colCargo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
    }
}