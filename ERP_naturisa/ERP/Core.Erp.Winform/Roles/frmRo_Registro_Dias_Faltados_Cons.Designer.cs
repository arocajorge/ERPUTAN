namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Registro_Dias_Faltados_Cons
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
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.gridControlDiasFaltados = new DevExpress.XtraGrid.GridControl();
            this.gridViewDiasFaltados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdCatalogoTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFechaFaltaDesde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFechaFaltaHasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDiasFaltados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDiasDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFechaDescuentaRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColValorDescuentaRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colpe_apellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colpe_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colpe_cedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDiasFaltados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiasFaltados)).BeginInit();
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
            this.ucGe_Menu.Enable_boton_modificar = false;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 1, 23, 8, 37, 29, 193);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 3, 23, 8, 37, 29, 193);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(973, 176);
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
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = true;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = false;
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
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.gridControlDiasFaltados);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 176);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(973, 228);
            this.PanelPrincipal.TabIndex = 4;
            // 
            // gridControlDiasFaltados
            // 
            this.gridControlDiasFaltados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDiasFaltados.Location = new System.Drawing.Point(0, 0);
            this.gridControlDiasFaltados.MainView = this.gridViewDiasFaltados;
            this.gridControlDiasFaltados.Name = "gridControlDiasFaltados";
            this.gridControlDiasFaltados.Size = new System.Drawing.Size(973, 228);
            this.gridControlDiasFaltados.TabIndex = 0;
            this.gridControlDiasFaltados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDiasFaltados});
            // 
            // gridViewDiasFaltados
            // 
            this.gridViewDiasFaltados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdEmpleado,
            this.ColIdCatalogoTipo,
            this.ColFechaFaltaDesde,
            this.ColFechaFaltaHasta,
            this.ColDiasFaltados,
            this.ColDiasDescuento,
            this.ColFechaDescuentaRol,
            this.ColValorDescuentaRol,
            this.ColObservacion,
            this.Colpe_apellido,
            this.Colpe_nombre,
            this.Colpe_cedulaRuc});
            this.gridViewDiasFaltados.GridControl = this.gridControlDiasFaltados;
            this.gridViewDiasFaltados.Name = "gridViewDiasFaltados";
            this.gridViewDiasFaltados.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDiasFaltados.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewDiasFaltados_RowCellStyle);
            this.gridViewDiasFaltados.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDiasFaltados_FocusedRowChanged);
            // 
            // ColIdEmpleado
            // 
            this.ColIdEmpleado.Caption = "IdEmpleado";
            this.ColIdEmpleado.FieldName = "IdEmpleado";
            this.ColIdEmpleado.Name = "ColIdEmpleado";
            this.ColIdEmpleado.Visible = true;
            this.ColIdEmpleado.VisibleIndex = 0;
            this.ColIdEmpleado.Width = 76;
            // 
            // ColIdCatalogoTipo
            // 
            this.ColIdCatalogoTipo.Caption = "Id Catalogo";
            this.ColIdCatalogoTipo.FieldName = "IdCatalogo";
            this.ColIdCatalogoTipo.Name = "ColIdCatalogoTipo";
            this.ColIdCatalogoTipo.Width = 84;
            // 
            // ColFechaFaltaDesde
            // 
            this.ColFechaFaltaDesde.Caption = "Desde";
            this.ColFechaFaltaDesde.FieldName = "FechaFaltaDesde";
            this.ColFechaFaltaDesde.Name = "ColFechaFaltaDesde";
            this.ColFechaFaltaDesde.Visible = true;
            this.ColFechaFaltaDesde.VisibleIndex = 4;
            this.ColFechaFaltaDesde.Width = 86;
            // 
            // ColFechaFaltaHasta
            // 
            this.ColFechaFaltaHasta.Caption = "Hasta";
            this.ColFechaFaltaHasta.FieldName = "FechaFaltaHasta";
            this.ColFechaFaltaHasta.Name = "ColFechaFaltaHasta";
            this.ColFechaFaltaHasta.Visible = true;
            this.ColFechaFaltaHasta.VisibleIndex = 5;
            this.ColFechaFaltaHasta.Width = 86;
            // 
            // ColDiasFaltados
            // 
            this.ColDiasFaltados.Caption = "Dias Faltados";
            this.ColDiasFaltados.FieldName = "DiasFaltados";
            this.ColDiasFaltados.Name = "ColDiasFaltados";
            this.ColDiasFaltados.Visible = true;
            this.ColDiasFaltados.VisibleIndex = 6;
            this.ColDiasFaltados.Width = 86;
            // 
            // ColDiasDescuento
            // 
            this.ColDiasDescuento.Caption = "Dias Descontados";
            this.ColDiasDescuento.FieldName = "DiasDescuento";
            this.ColDiasDescuento.Name = "ColDiasDescuento";
            this.ColDiasDescuento.Width = 94;
            // 
            // ColFechaDescuentaRol
            // 
            this.ColFechaDescuentaRol.Caption = "Fecha Descuento Rol";
            this.ColFechaDescuentaRol.FieldName = "FechaDescuentaRol";
            this.ColFechaDescuentaRol.Name = "ColFechaDescuentaRol";
            this.ColFechaDescuentaRol.Width = 84;
            // 
            // ColValorDescuentaRol
            // 
            this.ColValorDescuentaRol.Caption = "Valor";
            this.ColValorDescuentaRol.FieldName = "ValorDescuentaRol";
            this.ColValorDescuentaRol.Name = "ColValorDescuentaRol";
            this.ColValorDescuentaRol.Width = 84;
            // 
            // ColObservacion
            // 
            this.ColObservacion.Caption = "Observacion";
            this.ColObservacion.FieldName = "Observacion";
            this.ColObservacion.Name = "ColObservacion";
            this.ColObservacion.Visible = true;
            this.ColObservacion.VisibleIndex = 7;
            this.ColObservacion.Width = 100;
            // 
            // Colpe_apellido
            // 
            this.Colpe_apellido.Caption = "Apellidos";
            this.Colpe_apellido.FieldName = "pe_apellido";
            this.Colpe_apellido.Name = "Colpe_apellido";
            this.Colpe_apellido.Visible = true;
            this.Colpe_apellido.VisibleIndex = 2;
            this.Colpe_apellido.Width = 86;
            // 
            // Colpe_nombre
            // 
            this.Colpe_nombre.Caption = "Nombres";
            this.Colpe_nombre.FieldName = "pe_nombre";
            this.Colpe_nombre.Name = "Colpe_nombre";
            this.Colpe_nombre.Visible = true;
            this.Colpe_nombre.VisibleIndex = 3;
            this.Colpe_nombre.Width = 86;
            // 
            // Colpe_cedulaRuc
            // 
            this.Colpe_cedulaRuc.Caption = "Cedula";
            this.Colpe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.Colpe_cedulaRuc.Name = "Colpe_cedulaRuc";
            this.Colpe_cedulaRuc.Visible = true;
            this.Colpe_cedulaRuc.VisibleIndex = 1;
            this.Colpe_cedulaRuc.Width = 86;
            // 
            // frmRo_Registro_Dias_Faltados_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 404);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Registro_Dias_Faltados_Cons";
            this.Text = "Consulta Dias Faltados";
            this.Load += new System.EventHandler(this.frmRo_Registro_Dias_Faltados_Cons_Load);
            this.PanelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDiasFaltados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiasFaltados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.Panel PanelPrincipal;
        private DevExpress.XtraGrid.GridControl gridControlDiasFaltados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDiasFaltados;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdCatalogoTipo;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaFaltaDesde;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaFaltaHasta;
        private DevExpress.XtraGrid.Columns.GridColumn ColDiasFaltados;
        private DevExpress.XtraGrid.Columns.GridColumn ColDiasDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaDescuentaRol;
        private DevExpress.XtraGrid.Columns.GridColumn ColValorDescuentaRol;
        private DevExpress.XtraGrid.Columns.GridColumn ColObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn Colpe_apellido;
        private DevExpress.XtraGrid.Columns.GridColumn Colpe_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Colpe_cedulaRuc;
    }
}