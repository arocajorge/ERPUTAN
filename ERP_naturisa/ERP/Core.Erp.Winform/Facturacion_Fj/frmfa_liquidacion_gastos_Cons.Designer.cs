namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class frmfa_liquidacion_gastos_Cons
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
            this.ucGe_Menu_Mantenimiento_x_usuario1 = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gc_Liquidacion_Gastos = new DevExpress.XtraGrid.GridControl();
            this.gw_Liquidacion_Gastos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdLiquidacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cod_liquidacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_fecha_liqui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_MotivoAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pe_apellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pe_razonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pe_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pe_cedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pe_direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pe_telefonoCasa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Liquidacion_Gastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_Liquidacion_Gastos)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario1
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde = new System.DateTime(2016, 4, 24, 17, 14, 17, 375);
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta = new System.DateTime(2016, 5, 25, 17, 14, 17, 376);
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario1.Name = "ucGe_Menu_Mantenimiento_x_usuario1";
            this.ucGe_Menu_Mantenimiento_x_usuario1.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Size = new System.Drawing.Size(776, 180);
            this.ucGe_Menu_Mantenimiento_x_usuario1.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 458);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(776, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // gc_Liquidacion_Gastos
            // 
            this.gc_Liquidacion_Gastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Liquidacion_Gastos.Location = new System.Drawing.Point(0, 180);
            this.gc_Liquidacion_Gastos.MainView = this.gw_Liquidacion_Gastos;
            this.gc_Liquidacion_Gastos.Name = "gc_Liquidacion_Gastos";
            this.gc_Liquidacion_Gastos.Size = new System.Drawing.Size(776, 278);
            this.gc_Liquidacion_Gastos.TabIndex = 2;
            this.gc_Liquidacion_Gastos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gw_Liquidacion_Gastos});
            // 
            // gw_Liquidacion_Gastos
            // 
            this.gw_Liquidacion_Gastos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdLiquidacion,
            this.col_IdPeriodo,
            this.col_cod_liquidacion,
            this.col_IdCliente,
            this.col_fecha_liqui,
            this.col_Observacion,
            this.col_estado,
            this.col_IdUsuario,
            this.col_MotivoAnulacion,
            this.col_pe_apellido,
            this.col_pe_razonSocial,
            this.col_pe_nombre,
            this.col_pe_cedulaRuc,
            this.col_pe_direccion,
            this.col_pe_telefonoCasa});
            this.gw_Liquidacion_Gastos.GridControl = this.gc_Liquidacion_Gastos;
            this.gw_Liquidacion_Gastos.Name = "gw_Liquidacion_Gastos";
            this.gw_Liquidacion_Gastos.OptionsView.ShowAutoFilterRow = true;
            this.gw_Liquidacion_Gastos.OptionsView.ShowGroupPanel = false;
            this.gw_Liquidacion_Gastos.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gw_Liquidacion_Gastos_RowCellStyle);
            this.gw_Liquidacion_Gastos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gw_Liquidacion_Gastos_FocusedRowChanged);
            // 
            // col_IdLiquidacion
            // 
            this.col_IdLiquidacion.Caption = "IdLiquidacion";
            this.col_IdLiquidacion.FieldName = "IdLiquidacion";
            this.col_IdLiquidacion.Name = "col_IdLiquidacion";
            this.col_IdLiquidacion.Visible = true;
            this.col_IdLiquidacion.VisibleIndex = 0;
            this.col_IdLiquidacion.Width = 69;
            // 
            // col_IdPeriodo
            // 
            this.col_IdPeriodo.Caption = "IdPeriodo";
            this.col_IdPeriodo.FieldName = "IdPeriodo";
            this.col_IdPeriodo.Name = "col_IdPeriodo";
            this.col_IdPeriodo.Visible = true;
            this.col_IdPeriodo.VisibleIndex = 1;
            this.col_IdPeriodo.Width = 63;
            // 
            // col_cod_liquidacion
            // 
            this.col_cod_liquidacion.Caption = "cod_liquidacion";
            this.col_cod_liquidacion.FieldName = "cod_liquidacion";
            this.col_cod_liquidacion.Name = "col_cod_liquidacion";
            // 
            // col_IdCliente
            // 
            this.col_IdCliente.Caption = "IdCliente";
            this.col_IdCliente.FieldName = "IdCliente";
            this.col_IdCliente.Name = "col_IdCliente";
            this.col_IdCliente.Visible = true;
            this.col_IdCliente.VisibleIndex = 2;
            this.col_IdCliente.Width = 70;
            // 
            // col_fecha_liqui
            // 
            this.col_fecha_liqui.Caption = "fecha_liqui";
            this.col_fecha_liqui.FieldName = "fecha_liqui";
            this.col_fecha_liqui.Name = "col_fecha_liqui";
            this.col_fecha_liqui.Visible = true;
            this.col_fecha_liqui.VisibleIndex = 3;
            this.col_fecha_liqui.Width = 73;
            // 
            // col_Observacion
            // 
            this.col_Observacion.Caption = "Observacion";
            this.col_Observacion.FieldName = "Observacion";
            this.col_Observacion.Name = "col_Observacion";
            this.col_Observacion.Visible = true;
            this.col_Observacion.VisibleIndex = 5;
            this.col_Observacion.Width = 597;
            // 
            // col_estado
            // 
            this.col_estado.Caption = "estado";
            this.col_estado.FieldName = "estado";
            this.col_estado.Name = "col_estado";
            this.col_estado.Visible = true;
            this.col_estado.VisibleIndex = 6;
            this.col_estado.Width = 82;
            // 
            // col_IdUsuario
            // 
            this.col_IdUsuario.Caption = "IdUsuario";
            this.col_IdUsuario.FieldName = "IdUsuario";
            this.col_IdUsuario.Name = "col_IdUsuario";
            // 
            // col_MotivoAnulacion
            // 
            this.col_MotivoAnulacion.Caption = "MotivoAnulacion";
            this.col_MotivoAnulacion.FieldName = "MotivoAnulacion";
            this.col_MotivoAnulacion.Name = "col_MotivoAnulacion";
            // 
            // col_pe_apellido
            // 
            this.col_pe_apellido.Caption = "Apellido";
            this.col_pe_apellido.FieldName = "pe_apellido";
            this.col_pe_apellido.Name = "col_pe_apellido";
            this.col_pe_apellido.Width = 114;
            // 
            // col_pe_razonSocial
            // 
            this.col_pe_razonSocial.Caption = "Razon Social";
            this.col_pe_razonSocial.FieldName = "pe_razonSocial";
            this.col_pe_razonSocial.Name = "col_pe_razonSocial";
            this.col_pe_razonSocial.Visible = true;
            this.col_pe_razonSocial.VisibleIndex = 4;
            this.col_pe_razonSocial.Width = 187;
            // 
            // col_pe_nombre
            // 
            this.col_pe_nombre.Caption = "Nombre";
            this.col_pe_nombre.FieldName = "pe_nombre";
            this.col_pe_nombre.Name = "col_pe_nombre";
            this.col_pe_nombre.Width = 111;
            // 
            // col_pe_cedulaRuc
            // 
            this.col_pe_cedulaRuc.Caption = "Cedula/Ruc";
            this.col_pe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.col_pe_cedulaRuc.Name = "col_pe_cedulaRuc";
            this.col_pe_cedulaRuc.Width = 95;
            // 
            // col_pe_direccion
            // 
            this.col_pe_direccion.Caption = "Direccion";
            this.col_pe_direccion.FieldName = "pe_direccion";
            this.col_pe_direccion.Name = "col_pe_direccion";
            // 
            // col_pe_telefonoCasa
            // 
            this.col_pe_telefonoCasa.Caption = "Telefono";
            this.col_pe_telefonoCasa.FieldName = "pe_telefonoCasa";
            this.col_pe_telefonoCasa.Name = "col_pe_telefonoCasa";
            // 
            // frmfa_liquidacion_gastos_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 484);
            this.Controls.Add(this.gc_Liquidacion_Gastos);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario1);
            this.Name = "frmfa_liquidacion_gastos_Cons";
            this.Text = "frmfa_liquidacion_gastos_producto_Cons";
            this.Load += new System.EventHandler(this.frmfa_liquidacion_gastos_producto_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Liquidacion_Gastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_Liquidacion_Gastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl gc_Liquidacion_Gastos;
        private DevExpress.XtraGrid.Views.Grid.GridView gw_Liquidacion_Gastos;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdLiquidacion;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn col_cod_liquidacion;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn col_fecha_liqui;
        private DevExpress.XtraGrid.Columns.GridColumn col_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn col_estado;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn col_MotivoAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn col_pe_apellido;
        private DevExpress.XtraGrid.Columns.GridColumn col_pe_razonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn col_pe_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn col_pe_cedulaRuc;
        private DevExpress.XtraGrid.Columns.GridColumn col_pe_direccion;
        private DevExpress.XtraGrid.Columns.GridColumn col_pe_telefonoCasa;
    }
}