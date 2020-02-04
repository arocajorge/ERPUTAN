namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Genera_Guia_x_Traspaso_Cons_Fj
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
            this.gridControlGuiaCons = new DevExpress.XtraGrid.GridControl();
            this.gridViewGuiaCons = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGuia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumGuia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal_Partida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal_Llegada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion_Llegada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirec_sucu_Partida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirec_sucu_Llegada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTransportista = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMotivo_Traslado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Traslado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_llegada = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGuiaCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGuiaCons)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.CargarTodasBodegas = false;
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2016, 1, 3, 18, 38, 24, 634);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2016, 3, 3, 18, 38, 24, 635);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(1062, 155);
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
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = true;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = true;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_event_btnAnular_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            this.ucGe_Menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_event_btnBuscar_Click);
            // 
            // gridControlGuiaCons
            // 
            this.gridControlGuiaCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGuiaCons.Location = new System.Drawing.Point(0, 155);
            this.gridControlGuiaCons.MainView = this.gridViewGuiaCons;
            this.gridControlGuiaCons.Name = "gridControlGuiaCons";
            this.gridControlGuiaCons.Size = new System.Drawing.Size(1062, 288);
            this.gridControlGuiaCons.TabIndex = 2;
            this.gridControlGuiaCons.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGuiaCons});
            // 
            // gridViewGuiaCons
            // 
            this.gridViewGuiaCons.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdGuia,
            this.colNumGuia,
            this.colIdSucursal_Partida,
            this.colSu_Descripcion,
            this.colIdSucursal_Llegada,
            this.colSu_Descripcion_Llegada,
            this.colDirec_sucu_Partida,
            this.colDirec_sucu_Llegada,
            this.colIdTransportista,
            this.colFecha,
            this.colIdMotivo_Traslado,
            this.colEstado,
            this.colFecha_Traslado,
            this.colFecha_llegada});
            this.gridViewGuiaCons.GridControl = this.gridControlGuiaCons;
            this.gridViewGuiaCons.Name = "gridViewGuiaCons";
            this.gridViewGuiaCons.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewGuiaCons_RowCellStyle);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.Caption = "IdEmpresa";
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdGuia
            // 
            this.colIdGuia.Caption = "IdGuia";
            this.colIdGuia.FieldName = "IdGuia";
            this.colIdGuia.Name = "colIdGuia";
            this.colIdGuia.OptionsColumn.AllowEdit = false;
            this.colIdGuia.Visible = true;
            this.colIdGuia.VisibleIndex = 0;
            this.colIdGuia.Width = 57;
            // 
            // colNumGuia
            // 
            this.colNumGuia.Caption = "# Guía";
            this.colNumGuia.FieldName = "NumGuia";
            this.colNumGuia.Name = "colNumGuia";
            this.colNumGuia.OptionsColumn.AllowEdit = false;
            this.colNumGuia.Visible = true;
            this.colNumGuia.VisibleIndex = 1;
            this.colNumGuia.Width = 83;
            // 
            // colIdSucursal_Partida
            // 
            this.colIdSucursal_Partida.Caption = "gridColumn4";
            this.colIdSucursal_Partida.FieldName = "IdSucursal_Partida";
            this.colIdSucursal_Partida.Name = "colIdSucursal_Partida";
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Sucursal Partida";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.OptionsColumn.AllowEdit = false;
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 2;
            this.colSu_Descripcion.Width = 310;
            // 
            // colIdSucursal_Llegada
            // 
            this.colIdSucursal_Llegada.Caption = "gridColumn6";
            this.colIdSucursal_Llegada.FieldName = "IdSucursal_Llegada";
            this.colIdSucursal_Llegada.Name = "colIdSucursal_Llegada";
            // 
            // colSu_Descripcion_Llegada
            // 
            this.colSu_Descripcion_Llegada.Caption = "Sucursal Llegada";
            this.colSu_Descripcion_Llegada.FieldName = "Su_Descripcion_Llegada";
            this.colSu_Descripcion_Llegada.Name = "colSu_Descripcion_Llegada";
            this.colSu_Descripcion_Llegada.OptionsColumn.AllowEdit = false;
            this.colSu_Descripcion_Llegada.Visible = true;
            this.colSu_Descripcion_Llegada.VisibleIndex = 3;
            this.colSu_Descripcion_Llegada.Width = 312;
            // 
            // colDirec_sucu_Partida
            // 
            this.colDirec_sucu_Partida.Caption = "gridColumn8";
            this.colDirec_sucu_Partida.FieldName = "Direc_sucu_Partida";
            this.colDirec_sucu_Partida.Name = "colDirec_sucu_Partida";
            // 
            // colDirec_sucu_Llegada
            // 
            this.colDirec_sucu_Llegada.Caption = "gridColumn9";
            this.colDirec_sucu_Llegada.FieldName = "Direc_sucu_Llegada";
            this.colDirec_sucu_Llegada.Name = "colDirec_sucu_Llegada";
            // 
            // colIdTransportista
            // 
            this.colIdTransportista.Caption = "gridColumn10";
            this.colIdTransportista.FieldName = "IdTransportista";
            this.colIdTransportista.Name = "colIdTransportista";
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 4;
            this.colFecha.Width = 107;
            // 
            // colIdMotivo_Traslado
            // 
            this.colIdMotivo_Traslado.Caption = "gridColumn12";
            this.colIdMotivo_Traslado.FieldName = "IdMotivo_Traslado";
            this.colIdMotivo_Traslado.Name = "colIdMotivo_Traslado";
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 7;
            this.colEstado.Width = 66;
            // 
            // colFecha_Traslado
            // 
            this.colFecha_Traslado.Caption = "Fecha Traslado";
            this.colFecha_Traslado.FieldName = "Fecha_Traslado";
            this.colFecha_Traslado.Name = "colFecha_Traslado";
            this.colFecha_Traslado.OptionsColumn.AllowEdit = false;
            this.colFecha_Traslado.Visible = true;
            this.colFecha_Traslado.VisibleIndex = 5;
            this.colFecha_Traslado.Width = 129;
            // 
            // colFecha_llegada
            // 
            this.colFecha_llegada.Caption = "Fecha Llegada";
            this.colFecha_llegada.FieldName = "Fecha_llegada";
            this.colFecha_llegada.Name = "colFecha_llegada";
            this.colFecha_llegada.OptionsColumn.AllowEdit = false;
            this.colFecha_llegada.Visible = true;
            this.colFecha_llegada.VisibleIndex = 6;
            this.colFecha_llegada.Width = 116;
            // 
            // FrmIn_Genera_Guia_x_Traspaso_Cons_Fj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 443);
            this.Controls.Add(this.gridControlGuiaCons);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmIn_Genera_Guia_x_Traspaso_Cons_Fj";
            this.Text = "FrmIn_Genera_Guia_x_Traspaso_Cons_Fj";
            this.Load += new System.EventHandler(this.FrmIn_Genera_Guia_x_Traspaso_Cons_Fj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGuiaCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGuiaCons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraGrid.GridControl gridControlGuiaCons;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGuiaCons;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGuia;
        private DevExpress.XtraGrid.Columns.GridColumn colNumGuia;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal_Partida;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal_Llegada;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion_Llegada;
        private DevExpress.XtraGrid.Columns.GridColumn colDirec_sucu_Partida;
        private DevExpress.XtraGrid.Columns.GridColumn colDirec_sucu_Llegada;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTransportista;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotivo_Traslado;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Traslado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_llegada;

    }
}