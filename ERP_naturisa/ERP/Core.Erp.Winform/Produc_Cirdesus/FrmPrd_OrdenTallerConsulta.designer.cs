namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_OrdenTallerConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrd_OrdenTallerConsulta));
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridCtrlOrdenTaller = new DevExpress.XtraGrid.GridControl();
            this.prdOrdenTallerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewOrdenTaller = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenTaller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadPieza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colob_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaReg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_categorias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlOrdenTaller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdOrdenTallerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenTaller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridCtrlOrdenTaller);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 281);
            this.panel2.TabIndex = 11;
            // 
            // gridCtrlOrdenTaller
            // 
            this.gridCtrlOrdenTaller.DataSource = this.prdOrdenTallerInfoBindingSource;
            this.gridCtrlOrdenTaller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlOrdenTaller.Location = new System.Drawing.Point(0, 0);
            this.gridCtrlOrdenTaller.MainView = this.gridViewOrdenTaller;
            this.gridCtrlOrdenTaller.Name = "gridCtrlOrdenTaller";
            this.gridCtrlOrdenTaller.Size = new System.Drawing.Size(936, 281);
            this.gridCtrlOrdenTaller.TabIndex = 11;
            this.gridCtrlOrdenTaller.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrdenTaller});
            // 
            // prdOrdenTallerInfoBindingSource
            // 
            this.prdOrdenTallerInfoBindingSource.DataSource = typeof(Core.Erp.Info.Produc_Cirdesus.prd_OrdenTaller_Info);
            // 
            // gridViewOrdenTaller
            // 
            this.gridViewOrdenTaller.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdOrdenTaller,
            this.colCodObra,
            this.colNumeroOT,
            this.colIdProducto,
            this.colCantidadPieza,
            this.colTotalPeso,
            this.colEstado,
            this.colObservacion,
            this.colCodigo,
            this.colPesoUnitario,
            this.colNomProducto,
            this.colob_descripcion,
            this.colNomSucursal,
            this.colReferencia,
            this.colFechaReg,
            this.colca_categorias});
            this.gridViewOrdenTaller.GridControl = this.gridCtrlOrdenTaller;
            this.gridViewOrdenTaller.Name = "gridViewOrdenTaller";
            this.gridViewOrdenTaller.OptionsBehavior.ReadOnly = true;
            this.gridViewOrdenTaller.OptionsFind.AlwaysVisible = true;
            this.gridViewOrdenTaller.OptionsView.ShowAutoFilterRow = true;
            this.gridViewOrdenTaller.OptionsView.ShowViewCaption = true;
            this.gridViewOrdenTaller.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdOrdenTaller, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewOrdenTaller.ViewCaption = "Listado de Ordenes de Taller";
            this.gridViewOrdenTaller.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.Caption = "Sucursal";
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.Width = 65;
            // 
            // colIdOrdenTaller
            // 
            this.colIdOrdenTaller.Caption = "#Registro";
            this.colIdOrdenTaller.FieldName = "IdOrdenTaller";
            this.colIdOrdenTaller.Name = "colIdOrdenTaller";
            this.colIdOrdenTaller.Visible = true;
            this.colIdOrdenTaller.VisibleIndex = 2;
            this.colIdOrdenTaller.Width = 50;
            // 
            // colCodObra
            // 
            this.colCodObra.FieldName = "CodObra";
            this.colCodObra.Name = "colCodObra";
            // 
            // colNumeroOT
            // 
            this.colNumeroOT.FieldName = "NumeroOT";
            this.colNumeroOT.Name = "colNumeroOT";
            this.colNumeroOT.Width = 103;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Width = 52;
            // 
            // colCantidadPieza
            // 
            this.colCantidadPieza.Caption = "Cantidad";
            this.colCantidadPieza.FieldName = "CantidadPieza";
            this.colCantidadPieza.Name = "colCantidadPieza";
            this.colCantidadPieza.Visible = true;
            this.colCantidadPieza.VisibleIndex = 7;
            this.colCantidadPieza.Width = 52;
            // 
            // colTotalPeso
            // 
            this.colTotalPeso.Caption = "Total Peso Kg";
            this.colTotalPeso.FieldName = "TotalPeso";
            this.colTotalPeso.Name = "colTotalPeso";
            this.colTotalPeso.Visible = true;
            this.colTotalPeso.VisibleIndex = 9;
            this.colTotalPeso.Width = 84;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 11;
            this.colEstado.Width = 54;
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observación";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 10;
            this.colObservacion.Width = 126;
            // 
            // colCodigo
            // 
            this.colCodigo.Caption = "OT";
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 3;
            this.colCodigo.Width = 71;
            // 
            // colPesoUnitario
            // 
            this.colPesoUnitario.Caption = "Peso Unitario";
            this.colPesoUnitario.FieldName = "PesoUnitario";
            this.colPesoUnitario.Name = "colPesoUnitario";
            this.colPesoUnitario.Visible = true;
            this.colPesoUnitario.VisibleIndex = 8;
            this.colPesoUnitario.Width = 82;
            // 
            // colNomProducto
            // 
            this.colNomProducto.Caption = "Producto Terminado";
            this.colNomProducto.FieldName = "NomProducto";
            this.colNomProducto.Name = "colNomProducto";
            this.colNomProducto.Visible = true;
            this.colNomProducto.VisibleIndex = 6;
            this.colNomProducto.Width = 86;
            // 
            // colob_descripcion
            // 
            this.colob_descripcion.FieldName = "ob_descripcion";
            this.colob_descripcion.Name = "colob_descripcion";
            this.colob_descripcion.Width = 52;
            // 
            // colNomSucursal
            // 
            this.colNomSucursal.Caption = "Sucursal";
            this.colNomSucursal.FieldName = "NomSucursal";
            this.colNomSucursal.Name = "colNomSucursal";
            this.colNomSucursal.Visible = true;
            this.colNomSucursal.VisibleIndex = 1;
            this.colNomSucursal.Width = 86;
            // 
            // colReferencia
            // 
            this.colReferencia.Caption = "Obra";
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.Visible = true;
            this.colReferencia.VisibleIndex = 4;
            this.colReferencia.Width = 115;
            // 
            // colFechaReg
            // 
            this.colFechaReg.Caption = "Fecha";
            this.colFechaReg.FieldName = "FechaReg";
            this.colFechaReg.Name = "colFechaReg";
            this.colFechaReg.Visible = true;
            this.colFechaReg.VisibleIndex = 0;
            this.colFechaReg.Width = 47;
            // 
            // colca_categorias
            // 
            this.colca_categorias.Caption = "Categoría";
            this.colca_categorias.FieldName = "ca_categorias";
            this.colca_categorias.Name = "colca_categorias";
            this.colca_categorias.Visible = true;
            this.colca_categorias.VisibleIndex = 5;
            this.colca_categorias.Width = 65;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(936, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 9, 7, 14, 55, 53, 795);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 11, 7, 14, 55, 53, 795);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(936, 96);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 8;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // FrmPrd_OrdenTallerConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 399);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmPrd_OrdenTallerConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Ordenes de Taller";
            this.Load += new System.EventHandler(this.FrmPrd_OrdenTallerConsulta_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlOrdenTaller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdOrdenTallerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenTaller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridCtrlOrdenTaller;
        private System.Windows.Forms.BindingSource prdOrdenTallerInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrdenTaller;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenTaller;
        private DevExpress.XtraGrid.Columns.GridColumn colCodObra;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroOT;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadPieza;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPeso;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colNomProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colob_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colNomSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaReg;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private DevExpress.XtraGrid.Columns.GridColumn colca_categorias;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
    }
}