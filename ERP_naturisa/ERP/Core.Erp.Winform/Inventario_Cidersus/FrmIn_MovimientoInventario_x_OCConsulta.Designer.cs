namespace Core.Erp.Winform.Inventario_Cidersus
{
    partial class FrmIn_MovimientoInventario_x_OCConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_MovimientoInventario_x_OCConsulta));
            this.inmoviinveInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridCtrlListRepcMat = new DevExpress.XtraGrid.GridControl();
            this.gridViewRepcMat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumDocumentoRelacionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProvedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprov_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNumMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinveInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlListRepcMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRepcMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCtrlListRepcMat
            // 
            this.gridCtrlListRepcMat.DataSource = this.inmoviinveInfoBindingSource;
            this.gridCtrlListRepcMat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlListRepcMat.Location = new System.Drawing.Point(0, 0);
            this.gridCtrlListRepcMat.MainView = this.gridViewRepcMat;
            this.gridCtrlListRepcMat.Name = "gridCtrlListRepcMat";
            this.gridCtrlListRepcMat.Size = new System.Drawing.Size(1109, 444);
            this.gridCtrlListRepcMat.TabIndex = 20;
            this.gridCtrlListRepcMat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRepcMat});
            // 
            // gridViewRepcMat
            // 
            this.gridViewRepcMat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstado,
            this.colFecha_Transac,
            this.colcm_observacion,
            this.colNumDocumentoRelacionado,
            this.colIdProvedor,
            this.colprov_nombre,
            this.colIdNumMovi,
            this.colNomSucursal,
            this.colNomBodega,
            this.colNumFactura});
            this.gridViewRepcMat.GridControl = this.gridCtrlListRepcMat;
            this.gridViewRepcMat.Name = "gridViewRepcMat";
            this.gridViewRepcMat.OptionsBehavior.Editable = false;
            this.gridViewRepcMat.OptionsFind.AlwaysVisible = true;
            this.gridViewRepcMat.OptionsView.ShowAutoFilterRow = true;
            this.gridViewRepcMat.OptionsView.ShowViewCaption = true;
            this.gridViewRepcMat.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdNumMovi, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewRepcMat.ViewCaption = "Listado de Recepciones de Material";
            this.gridViewRepcMat.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewRepcMat_RowCellStyle);
            this.gridViewRepcMat.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewRepcMat_FocusedRowChanged);
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 8;
            this.colEstado.Width = 60;
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.Caption = "Fecha";
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            this.colFecha_Transac.OptionsColumn.AllowEdit = false;
            this.colFecha_Transac.Visible = true;
            this.colFecha_Transac.VisibleIndex = 4;
            this.colFecha_Transac.Width = 90;
            // 
            // colcm_observacion
            // 
            this.colcm_observacion.Caption = "Observación";
            this.colcm_observacion.FieldName = "cm_observacion";
            this.colcm_observacion.Name = "colcm_observacion";
            this.colcm_observacion.OptionsColumn.AllowEdit = false;
            this.colcm_observacion.Visible = true;
            this.colcm_observacion.VisibleIndex = 7;
            this.colcm_observacion.Width = 315;
            // 
            // colNumDocumentoRelacionado
            // 
            this.colNumDocumentoRelacionado.Caption = "#Guia de Despacho";
            this.colNumDocumentoRelacionado.FieldName = "NumDocumentoRelacionado";
            this.colNumDocumentoRelacionado.Name = "colNumDocumentoRelacionado";
            this.colNumDocumentoRelacionado.OptionsColumn.AllowEdit = false;
            this.colNumDocumentoRelacionado.Visible = true;
            this.colNumDocumentoRelacionado.VisibleIndex = 5;
            this.colNumDocumentoRelacionado.Width = 130;
            // 
            // colIdProvedor
            // 
            this.colIdProvedor.FieldName = "IdProvedor";
            this.colIdProvedor.Name = "colIdProvedor";
            // 
            // colprov_nombre
            // 
            this.colprov_nombre.Caption = "Proveedor";
            this.colprov_nombre.FieldName = "prov_nombre";
            this.colprov_nombre.Name = "colprov_nombre";
            this.colprov_nombre.OptionsColumn.AllowEdit = false;
            this.colprov_nombre.Visible = true;
            this.colprov_nombre.VisibleIndex = 3;
            this.colprov_nombre.Width = 156;
            // 
            // colIdNumMovi
            // 
            this.colIdNumMovi.Caption = "#Recepción";
            this.colIdNumMovi.FieldName = "IdNumMovi";
            this.colIdNumMovi.Name = "colIdNumMovi";
            this.colIdNumMovi.OptionsColumn.AllowEdit = false;
            this.colIdNumMovi.Visible = true;
            this.colIdNumMovi.VisibleIndex = 2;
            this.colIdNumMovi.Width = 93;
            // 
            // colNomSucursal
            // 
            this.colNomSucursal.Caption = "Sucursal";
            this.colNomSucursal.FieldName = "NomSucursal";
            this.colNomSucursal.Name = "colNomSucursal";
            this.colNomSucursal.Visible = true;
            this.colNomSucursal.VisibleIndex = 0;
            this.colNomSucursal.Width = 76;
            // 
            // colNomBodega
            // 
            this.colNomBodega.Caption = "Bodega";
            this.colNomBodega.FieldName = "NomBodega";
            this.colNomBodega.Name = "colNomBodega";
            this.colNomBodega.Visible = true;
            this.colNomBodega.VisibleIndex = 1;
            this.colNomBodega.Width = 65;
            // 
            // colNumFactura
            // 
            this.colNumFactura.Caption = "#Factura";
            this.colNumFactura.FieldName = "NumFactura";
            this.colNumFactura.Name = "colNumFactura";
            this.colNumFactura.Visible = true;
            this.colNumFactura.VisibleIndex = 6;
            this.colNumFactura.Width = 106;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            // 
            // 
            // 
            this.printableComponentLink1.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream")));
            this.printableComponentLink1.Owner = null;
            this.printableComponentLink1.PrintingSystem = this.printingSystem1;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 603);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1109, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 159);
            this.panel1.TabIndex = 22;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 3, 21, 17, 58, 18, 765);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 5, 21, 17, 58, 18, 765);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1109, 155);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridCtrlListRepcMat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 444);
            this.panel2.TabIndex = 23;
            // 
            // FrmIn_MovimientoInventario_x_OCConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1109, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmIn_MovimientoInventario_x_OCConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Recepcion de Materiales";
            this.Load += new System.EventHandler(this.FrmIn_MovimientoInventario_x_OCConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinveInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlListRepcMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRepcMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource inmoviinveInfoBindingSource;
        private DevExpress.XtraGrid.GridControl gridCtrlListRepcMat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRepcMat;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNumDocumentoRelacionado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProvedor;
        private DevExpress.XtraGrid.Columns.GridColumn colprov_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNumMovi;
        private DevExpress.XtraGrid.Columns.GridColumn colNomSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colNomBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colNumFactura;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
    }
}