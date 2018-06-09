namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_EnsambladoProductoFinal_Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrd_EnsambladoProductoFinal_Consulta));
            this.gridCtrlEnsamblado = new DevExpress.XtraGrid.GridControl();
            this.gridViewEnsamblado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsu_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colob_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgt_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbo_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaTransac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEnsamblado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGrupoTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenTaller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlEnsamblado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEnsamblado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCtrlEnsamblado
            // 
            this.gridCtrlEnsamblado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlEnsamblado.Location = new System.Drawing.Point(0, 0);
            this.gridCtrlEnsamblado.MainView = this.gridViewEnsamblado;
            this.gridCtrlEnsamblado.Name = "gridCtrlEnsamblado";
            this.gridCtrlEnsamblado.Size = new System.Drawing.Size(877, 304);
            this.gridCtrlEnsamblado.TabIndex = 14;
            this.gridCtrlEnsamblado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEnsamblado});
            // 
            // gridViewEnsamblado
            // 
            this.gridViewEnsamblado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colsu_descripcion,
            this.colob_descripcion,
            this.colCodOT,
            this.colgt_descripcion,
            this.colbo_descripcion,
            this.colProducto,
            this.colFechaTransac,
            this.colIdBodega,
            this.colIdEnsamblado,
            this.colIdGrupoTrabajo,
            this.colIdOrdenTaller,
            this.colIdProducto,
            this.colObservacion,
            this.colCodObra,
            this.colEstado});
            this.gridViewEnsamblado.GridControl = this.gridCtrlEnsamblado;
            this.gridViewEnsamblado.Name = "gridViewEnsamblado";
            this.gridViewEnsamblado.OptionsBehavior.Editable = false;
            this.gridViewEnsamblado.OptionsFind.AlwaysVisible = true;
            this.gridViewEnsamblado.OptionsView.ShowAutoFilterRow = true;
            this.gridViewEnsamblado.OptionsView.ShowViewCaption = true;
            this.gridViewEnsamblado.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdEnsamblado, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFechaTransac, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewEnsamblado.ViewCaption = "Listado de Registros de Ensamblado de Productos";
            this.gridViewEnsamblado.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_RowCellStyle);
            this.gridViewEnsamblado.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            // 
            // colsu_descripcion
            // 
            this.colsu_descripcion.Caption = "Sucursal";
            this.colsu_descripcion.FieldName = "su_descripcion";
            this.colsu_descripcion.Name = "colsu_descripcion";
            this.colsu_descripcion.Visible = true;
            this.colsu_descripcion.VisibleIndex = 1;
            this.colsu_descripcion.Width = 69;
            // 
            // colob_descripcion
            // 
            this.colob_descripcion.Caption = "Obra";
            this.colob_descripcion.FieldName = "ob_descripcion";
            this.colob_descripcion.Name = "colob_descripcion";
            this.colob_descripcion.Visible = true;
            this.colob_descripcion.VisibleIndex = 4;
            this.colob_descripcion.Width = 88;
            // 
            // colCodOT
            // 
            this.colCodOT.Caption = "OT";
            this.colCodOT.FieldName = "CodOT";
            this.colCodOT.Name = "colCodOT";
            this.colCodOT.Visible = true;
            this.colCodOT.VisibleIndex = 5;
            this.colCodOT.Width = 89;
            // 
            // colgt_descripcion
            // 
            this.colgt_descripcion.Caption = "Grupo de Trabajo";
            this.colgt_descripcion.FieldName = "gt_descripcion";
            this.colgt_descripcion.Name = "colgt_descripcion";
            this.colgt_descripcion.Visible = true;
            this.colgt_descripcion.VisibleIndex = 6;
            this.colgt_descripcion.Width = 92;
            // 
            // colbo_descripcion
            // 
            this.colbo_descripcion.Caption = "Bodega";
            this.colbo_descripcion.FieldName = "bo_descripcion";
            this.colbo_descripcion.Name = "colbo_descripcion";
            this.colbo_descripcion.Visible = true;
            this.colbo_descripcion.VisibleIndex = 3;
            this.colbo_descripcion.Width = 89;
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Producto Terminado";
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 7;
            this.colProducto.Width = 94;
            // 
            // colFechaTransac
            // 
            this.colFechaTransac.Caption = "Fecha";
            this.colFechaTransac.FieldName = "FechaTransac";
            this.colFechaTransac.Name = "colFechaTransac";
            this.colFechaTransac.Visible = true;
            this.colFechaTransac.VisibleIndex = 0;
            this.colFechaTransac.Width = 85;
            // 
            // colIdBodega
            // 
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            // 
            // colIdEnsamblado
            // 
            this.colIdEnsamblado.Caption = "#Reg Ensamblado";
            this.colIdEnsamblado.FieldName = "IdEnsamblado";
            this.colIdEnsamblado.Name = "colIdEnsamblado";
            this.colIdEnsamblado.Visible = true;
            this.colIdEnsamblado.VisibleIndex = 2;
            this.colIdEnsamblado.Width = 86;
            // 
            // colIdGrupoTrabajo
            // 
            this.colIdGrupoTrabajo.FieldName = "IdGrupoTrabajo";
            this.colIdGrupoTrabajo.Name = "colIdGrupoTrabajo";
            // 
            // colIdOrdenTaller
            // 
            this.colIdOrdenTaller.FieldName = "IdOrdenTaller";
            this.colIdOrdenTaller.Name = "colIdOrdenTaller";
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 8;
            this.colObservacion.Width = 100;
            // 
            // colCodObra
            // 
            this.colCodObra.FieldName = "CodObra";
            this.colCodObra.Name = "colCodObra";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 9;
            this.colEstado.Width = 67;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(877, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridCtrlEnsamblado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 304);
            this.panel1.TabIndex = 16;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 7, 9, 29, 24, 679);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 7, 9, 29, 24, 679);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(877, 96);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 17;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // FrmPrd_EnsambladoProductoFinal_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmPrd_EnsambladoProductoFinal_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ensamblado Consulta";
            this.Load += new System.EventHandler(this.FrmPrd_EnsambladoProductoFinal_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlEnsamblado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEnsamblado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCtrlEnsamblado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEnsamblado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colsu_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colob_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCodOT;
        private DevExpress.XtraGrid.Columns.GridColumn colgt_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colbo_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaTransac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEnsamblado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupoTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenTaller;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colCodObra;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
    }
}