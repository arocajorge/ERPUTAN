namespace Core.Erp.Winform.Roles_Fj
{
    partial class frm_Ro_Planificacion_Descuento_Cons
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.gridControl_descuento = new DevExpress.XtraGrid.GridControl();
            this.gridView_descuento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_IdDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_cedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_nombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_ru_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Fecha_Incidente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Fecha_Transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_descuento)).BeginInit();
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 4, 5, 15, 28, 43, 983);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 6, 5, 15, 28, 43, 983);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(1042, 143);
            this.ucGe_Menu.TabIndex = 1;
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
            this.ucGe_Menu.Visible_fechas = true;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_event_btnAnular_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            this.ucGe_Menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_event_btnBuscar_Click);
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // gridControl_descuento
            // 
            this.gridControl_descuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_descuento.Location = new System.Drawing.Point(0, 143);
            this.gridControl_descuento.MainView = this.gridView_descuento;
            this.gridControl_descuento.Name = "gridControl_descuento";
            this.gridControl_descuento.Size = new System.Drawing.Size(1042, 205);
            this.gridControl_descuento.TabIndex = 2;
            this.gridControl_descuento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_descuento});
            // 
            // gridView_descuento
            // 
            this.gridView_descuento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_IdDescuento,
            this.Col_pe_cedulaRuc,
            this.Col_pe_nombreCompleto,
            this.Col_ru_descripcion,
            this.Col_Fecha_Incidente,
            this.Col_Valor,
            this.Col_Observacion,
            this.Col_Fecha_Transaccion});
            this.gridView_descuento.GridControl = this.gridControl_descuento;
            this.gridView_descuento.Name = "gridView_descuento";
            this.gridView_descuento.OptionsView.ShowAutoFilterRow = true;
            this.gridView_descuento.OptionsView.ShowGroupPanel = false;
            // 
            // Col_IdDescuento
            // 
            this.Col_IdDescuento.Caption = "Id";
            this.Col_IdDescuento.FieldName = "IdDescuento";
            this.Col_IdDescuento.Name = "Col_IdDescuento";
            this.Col_IdDescuento.OptionsColumn.AllowEdit = false;
            this.Col_IdDescuento.Visible = true;
            this.Col_IdDescuento.VisibleIndex = 0;
            this.Col_IdDescuento.Width = 38;
            // 
            // Col_pe_cedulaRuc
            // 
            this.Col_pe_cedulaRuc.Caption = "Cedula";
            this.Col_pe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.Col_pe_cedulaRuc.Name = "Col_pe_cedulaRuc";
            this.Col_pe_cedulaRuc.OptionsColumn.AllowEdit = false;
            this.Col_pe_cedulaRuc.Visible = true;
            this.Col_pe_cedulaRuc.VisibleIndex = 1;
            // 
            // Col_pe_nombreCompleto
            // 
            this.Col_pe_nombreCompleto.Caption = "Nombres";
            this.Col_pe_nombreCompleto.FieldName = "pe_nombreCompleto";
            this.Col_pe_nombreCompleto.Name = "Col_pe_nombreCompleto";
            this.Col_pe_nombreCompleto.OptionsColumn.AllowEdit = false;
            this.Col_pe_nombreCompleto.Visible = true;
            this.Col_pe_nombreCompleto.VisibleIndex = 2;
            this.Col_pe_nombreCompleto.Width = 163;
            // 
            // Col_ru_descripcion
            // 
            this.Col_ru_descripcion.Caption = "Concepto descuento";
            this.Col_ru_descripcion.FieldName = "ru_descripcion";
            this.Col_ru_descripcion.Name = "Col_ru_descripcion";
            this.Col_ru_descripcion.OptionsColumn.AllowEdit = false;
            this.Col_ru_descripcion.Visible = true;
            this.Col_ru_descripcion.VisibleIndex = 4;
            this.Col_ru_descripcion.Width = 215;
            // 
            // Col_Fecha_Incidente
            // 
            this.Col_Fecha_Incidente.Caption = "Fecha Incidente";
            this.Col_Fecha_Incidente.FieldName = "Fecha_Incidente";
            this.Col_Fecha_Incidente.Name = "Col_Fecha_Incidente";
            this.Col_Fecha_Incidente.OptionsColumn.AllowEdit = false;
            this.Col_Fecha_Incidente.Visible = true;
            this.Col_Fecha_Incidente.VisibleIndex = 5;
            this.Col_Fecha_Incidente.Width = 60;
            // 
            // Col_Valor
            // 
            this.Col_Valor.Caption = "Descuento";
            this.Col_Valor.FieldName = "Valor";
            this.Col_Valor.Name = "Col_Valor";
            this.Col_Valor.OptionsColumn.AllowEdit = false;
            this.Col_Valor.Visible = true;
            this.Col_Valor.VisibleIndex = 6;
            this.Col_Valor.Width = 54;
            // 
            // Col_Observacion
            // 
            this.Col_Observacion.Caption = "Observacion";
            this.Col_Observacion.FieldName = "Observacion";
            this.Col_Observacion.Name = "Col_Observacion";
            this.Col_Observacion.OptionsColumn.AllowEdit = false;
            this.Col_Observacion.Visible = true;
            this.Col_Observacion.VisibleIndex = 3;
            this.Col_Observacion.Width = 229;
            // 
            // Col_Fecha_Transaccion
            // 
            this.Col_Fecha_Transaccion.Caption = "Fecha registro";
            this.Col_Fecha_Transaccion.FieldName = "Fecha_Transaccion";
            this.Col_Fecha_Transaccion.Name = "Col_Fecha_Transaccion";
            this.Col_Fecha_Transaccion.OptionsColumn.AllowEdit = false;
            this.Col_Fecha_Transaccion.Visible = true;
            this.Col_Fecha_Transaccion.VisibleIndex = 7;
            // 
            // frm_Ro_Planificacion_Descuento_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 348);
            this.Controls.Add(this.gridControl_descuento);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frm_Ro_Planificacion_Descuento_Cons";
            this.Text = "PLANIFICACION DE DESCUENTO";
            this.Load += new System.EventHandler(this.frm_Ro_Planificacion_Descuento_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_descuento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraGrid.GridControl gridControl_descuento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_descuento;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_cedulaRuc;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_nombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ru_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Fecha_Incidente;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Valor;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Fecha_Transaccion;
    }
}