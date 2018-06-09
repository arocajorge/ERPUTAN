namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Clientes_consul
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridControl_Clientes = new DevExpress.XtraGrid.GridControl();
            this.gridView_Clientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail_Principal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_sexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_Naturaleza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoCivil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ColCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Clientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_Clientes
            // 
            this.gridControl_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl_Clientes.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl_Clientes.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Clientes.MainView = this.gridView_Clientes;
            this.gridControl_Clientes.Name = "gridControl_Clientes";
            this.gridControl_Clientes.Size = new System.Drawing.Size(1070, 274);
            this.gridControl_Clientes.TabIndex = 27;
            this.gridControl_Clientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Clientes});
            // 
            // gridView_Clientes
            // 
            this.gridView_Clientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColSucursal,
            this.ColApellido,
            this.colNombre,
            this.colRazonSocial,
            this.colCedula,
            this.colDireccion,
            this.colTelefono,
            this.colFax,
            this.colEstado,
            this.colIdCliente,
            this.colMail_Principal,
            this.colpe_sexo,
            this.colpe_Naturaleza,
            this.colIdEstadoCivil,
            this.ColCodigo});
            this.gridView_Clientes.GridControl = this.gridControl_Clientes;
            this.gridView_Clientes.Name = "gridView_Clientes";
            this.gridView_Clientes.OptionsBehavior.Editable = false;
            this.gridView_Clientes.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Clientes.OptionsView.ShowGroupPanel = false;
            this.gridView_Clientes.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEstado, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView_Clientes.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Clientes_RowClick);
            this.gridView_Clientes.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_Clientes_RowCellStyle);
            this.gridView_Clientes.DoubleClick += new System.EventHandler(this.gridView_Clientes_DoubleClick);
            // 
            // ColSucursal
            // 
            this.ColSucursal.Caption = "Sucursal";
            this.ColSucursal.FieldName = "nomSucursal";
            this.ColSucursal.Name = "ColSucursal";
            this.ColSucursal.OptionsColumn.AllowEdit = false;
            this.ColSucursal.Visible = true;
            this.ColSucursal.VisibleIndex = 0;
            this.ColSucursal.Width = 141;
            // 
            // ColApellido
            // 
            this.ColApellido.Caption = "Apellido";
            this.ColApellido.FieldName = "Persona_Info.pe_apellido";
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.OptionsColumn.AllowEdit = false;
            this.ColApellido.Visible = true;
            this.ColApellido.VisibleIndex = 2;
            this.ColApellido.Width = 129;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Persona_Info.pe_nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 3;
            this.colNombre.Width = 131;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.Caption = "Razon Social";
            this.colRazonSocial.FieldName = "Persona_Info.pe_razonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.OptionsColumn.AllowEdit = false;
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 4;
            this.colRazonSocial.Width = 109;
            // 
            // colCedula
            // 
            this.colCedula.Caption = "Cedula/Ruc";
            this.colCedula.FieldName = "Persona_Info.pe_cedulaRuc";
            this.colCedula.Name = "colCedula";
            this.colCedula.OptionsColumn.AllowEdit = false;
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 5;
            this.colCedula.Width = 86;
            // 
            // colDireccion
            // 
            this.colDireccion.Caption = "Dirección";
            this.colDireccion.FieldName = "Persona_Info.pe_direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.OptionsColumn.AllowEdit = false;
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 6;
            this.colDireccion.Width = 81;
            // 
            // colTelefono
            // 
            this.colTelefono.Caption = "Telefono";
            this.colTelefono.FieldName = "Persona_Info.pe_telefonoCasa";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.OptionsColumn.AllowEdit = false;
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 7;
            this.colTelefono.Width = 81;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "cl_fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 8;
            this.colFax.Width = 72;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 9;
            this.colEstado.Width = 61;
            // 
            // colIdCliente
            // 
            this.colIdCliente.Caption = "IdCliente";
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.Visible = true;
            this.colIdCliente.VisibleIndex = 12;
            this.colIdCliente.Width = 71;
            // 
            // colMail_Principal
            // 
            this.colMail_Principal.Caption = "Mail Principal";
            this.colMail_Principal.FieldName = "Mail_Principal";
            this.colMail_Principal.Name = "colMail_Principal";
            this.colMail_Principal.Visible = true;
            this.colMail_Principal.VisibleIndex = 10;
            this.colMail_Principal.Width = 74;
            // 
            // colpe_sexo
            // 
            this.colpe_sexo.Caption = "Sexo";
            this.colpe_sexo.FieldName = "Persona_Info.pe_sexo";
            this.colpe_sexo.Name = "colpe_sexo";
            this.colpe_sexo.Width = 62;
            // 
            // colpe_Naturaleza
            // 
            this.colpe_Naturaleza.Caption = "Naturaleza";
            this.colpe_Naturaleza.FieldName = "Persona_Info.pe_Naturaleza";
            this.colpe_Naturaleza.Name = "colpe_Naturaleza";
            this.colpe_Naturaleza.Visible = true;
            this.colpe_Naturaleza.VisibleIndex = 11;
            this.colpe_Naturaleza.Width = 86;
            // 
            // colIdEstadoCivil
            // 
            this.colIdEstadoCivil.Caption = "Estado Civil";
            this.colIdEstadoCivil.FieldName = "Persona_Info.IdEstadoCivil";
            this.colIdEstadoCivil.Name = "colIdEstadoCivil";
            this.colIdEstadoCivil.Width = 78;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 178);
            this.panel1.TabIndex = 29;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 1, 25, 12, 14, 42, 725);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 2, 26, 12, 14, 42, 725);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1070, 175);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Always;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl_Clientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 274);
            this.panel2.TabIndex = 30;
            // 
            // ColCodigo
            // 
            this.ColCodigo.Caption = "Codigo";
            this.ColCodigo.FieldName = "Codigo";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.Visible = true;
            this.ColCodigo.VisibleIndex = 1;
            this.ColCodigo.Width = 58;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 452);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1070, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 30;
            // 
            // frmFa_Clientes_consul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.panel1);
            this.Name = "frmFa_Clientes_consul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Clientes";
            this.Load += new System.EventHandler(this.frmFA_Clientes_General_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Clientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Clientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Clientes;
        private DevExpress.XtraGrid.Columns.GridColumn ColSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn ColApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn colMail_Principal;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_sexo;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_Naturaleza;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoCivil;
        private DevExpress.XtraGrid.Columns.GridColumn ColCodigo;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
    }
}