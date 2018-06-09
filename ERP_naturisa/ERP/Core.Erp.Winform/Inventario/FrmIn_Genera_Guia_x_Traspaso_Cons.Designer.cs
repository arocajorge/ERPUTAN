namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Genera_Guia_x_Traspaso_Cons
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.colNumDocumento_Guia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGuiaCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGuiaCons)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario1
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasSucursales = true;
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
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde = new System.DateTime(2017, 1, 24, 8, 48, 17, 820);
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta = new System.DateTime(2017, 3, 24, 8, 48, 17, 820);
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario1.Name = "ucGe_Menu_Mantenimiento_x_usuario1";
            this.ucGe_Menu_Mantenimiento_x_usuario1.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Size = new System.Drawing.Size(1029, 155);
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
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario1_Load);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1029, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlGuiaCons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 321);
            this.panel1.TabIndex = 2;
            // 
            // gridControlGuiaCons
            // 
            this.gridControlGuiaCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGuiaCons.Location = new System.Drawing.Point(0, 0);
            this.gridControlGuiaCons.MainView = this.gridViewGuiaCons;
            this.gridControlGuiaCons.Name = "gridControlGuiaCons";
            this.gridControlGuiaCons.Size = new System.Drawing.Size(1029, 321);
            this.gridControlGuiaCons.TabIndex = 0;
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
            this.colFecha_llegada,
            this.colNumDocumento_Guia});
            this.gridViewGuiaCons.GridControl = this.gridControlGuiaCons;
            this.gridViewGuiaCons.Name = "gridViewGuiaCons";
            this.gridViewGuiaCons.OptionsView.ShowAutoFilterRow = true;
            this.gridViewGuiaCons.OptionsView.ShowGroupPanel = false;
            this.gridViewGuiaCons.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdGuia, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewGuiaCons.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewGuiaCons_RowClick);
            this.gridViewGuiaCons.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewGuiaCons_RowCellStyle);
            this.gridViewGuiaCons.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewGuiaCons_FocusedRowChanged);
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
            this.colIdGuia.Width = 48;
            // 
            // colNumGuia
            // 
            this.colNumGuia.Caption = "# Guía";
            this.colNumGuia.FieldName = "NumGuia";
            this.colNumGuia.Name = "colNumGuia";
            this.colNumGuia.OptionsColumn.AllowEdit = false;
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
            this.colSu_Descripcion.VisibleIndex = 1;
            this.colSu_Descripcion.Width = 178;
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
            this.colSu_Descripcion_Llegada.VisibleIndex = 2;
            this.colSu_Descripcion_Llegada.Width = 196;
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
            this.colFecha.VisibleIndex = 3;
            this.colFecha.Width = 123;
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
            this.colEstado.Width = 91;
            // 
            // colFecha_Traslado
            // 
            this.colFecha_Traslado.Caption = "Fecha Traslado";
            this.colFecha_Traslado.FieldName = "Fecha_Traslado";
            this.colFecha_Traslado.Name = "colFecha_Traslado";
            this.colFecha_Traslado.OptionsColumn.AllowEdit = false;
            this.colFecha_Traslado.Visible = true;
            this.colFecha_Traslado.VisibleIndex = 4;
            this.colFecha_Traslado.Width = 120;
            // 
            // colFecha_llegada
            // 
            this.colFecha_llegada.Caption = "Fecha Llegada";
            this.colFecha_llegada.FieldName = "Fecha_llegada";
            this.colFecha_llegada.Name = "colFecha_llegada";
            this.colFecha_llegada.OptionsColumn.AllowEdit = false;
            this.colFecha_llegada.Visible = true;
            this.colFecha_llegada.VisibleIndex = 5;
            this.colFecha_llegada.Width = 98;
            // 
            // colNumDocumento_Guia
            // 
            this.colNumDocumento_Guia.Caption = "#Docu. Guia Auto";
            this.colNumDocumento_Guia.FieldName = "NumDocumento_Guia";
            this.colNumDocumento_Guia.Name = "colNumDocumento_Guia";
            this.colNumDocumento_Guia.Visible = true;
            this.colNumDocumento_Guia.VisibleIndex = 6;
            this.colNumDocumento_Guia.Width = 157;
            // 
            // FrmIn_Genera_Guia_x_Traspaso_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario1);
            this.Name = "FrmIn_Genera_Guia_x_Traspaso_Cons";
            this.Text = "Consulta de Guías por Traspaso";
            this.Load += new System.EventHandler(this.FrmIn_Genera_Guia_x_Traspaso_Cons_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGuiaCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGuiaCons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colNumDocumento_Guia;
    }
}