namespace Core.Erp.Winform.Produc_Cirdesus
{
    //version 240620013
    partial class FrmPrd_GrupoTrabajoConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrd_GrupoTrabajoConsulta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlGrupoTrabajo = new DevExpress.XtraGrid.GridControl();
            this.prdGrupoTrabajoInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewGrupoTrabajo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdGrupoTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescripModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreEtapa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pe_nombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Su_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Mantenimiento_x_usuario1 = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.prdGrupoTrabajoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGrupoTrabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdGrupoTrabajoInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGrupoTrabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdGrupoTrabajoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlGrupoTrabajo);
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 400);
            this.panel1.TabIndex = 0;
            // 
            // gridControlGrupoTrabajo
            // 
            this.gridControlGrupoTrabajo.DataSource = this.prdGrupoTrabajoInfoBindingSource1;
            this.gridControlGrupoTrabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGrupoTrabajo.Location = new System.Drawing.Point(0, 96);
            this.gridControlGrupoTrabajo.MainView = this.gridViewGrupoTrabajo;
            this.gridControlGrupoTrabajo.Name = "gridControlGrupoTrabajo";
            this.gridControlGrupoTrabajo.Size = new System.Drawing.Size(798, 304);
            this.gridControlGrupoTrabajo.TabIndex = 13;
            this.gridControlGrupoTrabajo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGrupoTrabajo});
            // 
            // prdGrupoTrabajoInfoBindingSource1
            // 
            this.prdGrupoTrabajoInfoBindingSource1.DataSource = typeof(Core.Erp.Info.Produc_Cirdesus.prd_GrupoTrabajo_Info);
            // 
            // gridViewGrupoTrabajo
            // 
            this.gridViewGrupoTrabajo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdGrupoTrabajo,
            this.Descripcion,
            this.Estado,
            this.DescripModelo,
            this.NombreEtapa,
            this.pe_nombreCompleto,
            this.Codigo,
            this.CodCentroCosto,
            this.Centro_costo,
            this.Su_Descripcion,
            this.colFechaCreacion});
            this.gridViewGrupoTrabajo.GridControl = this.gridControlGrupoTrabajo;
            this.gridViewGrupoTrabajo.Name = "gridViewGrupoTrabajo";
            this.gridViewGrupoTrabajo.OptionsBehavior.Editable = false;
            this.gridViewGrupoTrabajo.OptionsFind.AlwaysVisible = true;
            this.gridViewGrupoTrabajo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewGrupoTrabajo.OptionsView.ShowFooter = true;
            this.gridViewGrupoTrabajo.OptionsView.ShowIndicator = false;
            this.gridViewGrupoTrabajo.OptionsView.ShowViewCaption = true;
            this.gridViewGrupoTrabajo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Centro_costo, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.IdGrupoTrabajo, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewGrupoTrabajo.ViewCaption = "Listado de Grupos de Trabajo";
            this.gridViewGrupoTrabajo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewGrupoTrabajo_RowCellStyle);
            // 
            // IdGrupoTrabajo
            // 
            this.IdGrupoTrabajo.AppearanceCell.Options.UseTextOptions = true;
            this.IdGrupoTrabajo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdGrupoTrabajo.AppearanceHeader.Options.UseTextOptions = true;
            this.IdGrupoTrabajo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdGrupoTrabajo.Caption = "Reg #";
            this.IdGrupoTrabajo.FieldName = "IdGrupoTrabajo";
            this.IdGrupoTrabajo.Name = "IdGrupoTrabajo";
            this.IdGrupoTrabajo.OptionsColumn.AllowEdit = false;
            this.IdGrupoTrabajo.Visible = true;
            this.IdGrupoTrabajo.VisibleIndex = 2;
            this.IdGrupoTrabajo.Width = 55;
            // 
            // Descripcion
            // 
            this.Descripcion.AppearanceCell.Options.UseTextOptions = true;
            this.Descripcion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Descripcion.AppearanceHeader.Options.UseTextOptions = true;
            this.Descripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Descripcion.Caption = "Grupo";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.OptionsColumn.AllowEdit = false;
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 3;
            this.Descripcion.Width = 129;
            // 
            // Estado
            // 
            this.Estado.AppearanceCell.Options.UseTextOptions = true;
            this.Estado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Estado.AppearanceHeader.Options.UseTextOptions = true;
            this.Estado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.OptionsColumn.AllowEdit = false;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 9;
            this.Estado.Width = 69;
            // 
            // DescripModelo
            // 
            this.DescripModelo.AppearanceCell.Options.UseTextOptions = true;
            this.DescripModelo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DescripModelo.AppearanceHeader.Options.UseTextOptions = true;
            this.DescripModelo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DescripModelo.Caption = "Modelo Producción";
            this.DescripModelo.FieldName = "DescripModelo";
            this.DescripModelo.Name = "DescripModelo";
            this.DescripModelo.OptionsColumn.AllowEdit = false;
            this.DescripModelo.Visible = true;
            this.DescripModelo.VisibleIndex = 6;
            this.DescripModelo.Width = 38;
            // 
            // NombreEtapa
            // 
            this.NombreEtapa.AppearanceCell.Options.UseTextOptions = true;
            this.NombreEtapa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NombreEtapa.AppearanceHeader.Options.UseTextOptions = true;
            this.NombreEtapa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NombreEtapa.Caption = "Etapa Producción";
            this.NombreEtapa.FieldName = "NombreEtapa";
            this.NombreEtapa.Name = "NombreEtapa";
            this.NombreEtapa.OptionsColumn.AllowEdit = false;
            this.NombreEtapa.Visible = true;
            this.NombreEtapa.VisibleIndex = 7;
            this.NombreEtapa.Width = 67;
            // 
            // pe_nombreCompleto
            // 
            this.pe_nombreCompleto.AppearanceCell.Options.UseTextOptions = true;
            this.pe_nombreCompleto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pe_nombreCompleto.AppearanceHeader.Options.UseTextOptions = true;
            this.pe_nombreCompleto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pe_nombreCompleto.Caption = "Líder";
            this.pe_nombreCompleto.FieldName = "pe_nombreCompleto";
            this.pe_nombreCompleto.Name = "pe_nombreCompleto";
            this.pe_nombreCompleto.OptionsColumn.AllowEdit = false;
            this.pe_nombreCompleto.Visible = true;
            this.pe_nombreCompleto.VisibleIndex = 4;
            this.pe_nombreCompleto.Width = 140;
            // 
            // Codigo
            // 
            this.Codigo.AppearanceCell.Options.UseTextOptions = true;
            this.Codigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Codigo.AppearanceHeader.Options.UseTextOptions = true;
            this.Codigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Codigo.Caption = "OT";
            this.Codigo.FieldName = "DetOT";
            this.Codigo.Name = "Codigo";
            this.Codigo.OptionsColumn.AllowEdit = false;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 8;
            this.Codigo.Width = 69;
            // 
            // CodCentroCosto
            // 
            this.CodCentroCosto.AppearanceCell.Options.UseTextOptions = true;
            this.CodCentroCosto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CodCentroCosto.AppearanceHeader.Options.UseTextOptions = true;
            this.CodCentroCosto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CodCentroCosto.Caption = "Cod Obra";
            this.CodCentroCosto.FieldName = "CodObra";
            this.CodCentroCosto.Name = "CodCentroCosto";
            this.CodCentroCosto.OptionsColumn.AllowEdit = false;
            this.CodCentroCosto.Width = 47;
            // 
            // Centro_costo
            // 
            this.Centro_costo.AppearanceCell.Options.UseTextOptions = true;
            this.Centro_costo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Centro_costo.AppearanceHeader.Options.UseTextOptions = true;
            this.Centro_costo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Centro_costo.Caption = "Obra";
            this.Centro_costo.FieldName = "ob_descripcion";
            this.Centro_costo.Name = "Centro_costo";
            this.Centro_costo.OptionsColumn.AllowEdit = false;
            this.Centro_costo.Visible = true;
            this.Centro_costo.VisibleIndex = 5;
            this.Centro_costo.Width = 103;
            // 
            // Su_Descripcion
            // 
            this.Su_Descripcion.AppearanceCell.Options.UseTextOptions = true;
            this.Su_Descripcion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Su_Descripcion.AppearanceHeader.Options.UseTextOptions = true;
            this.Su_Descripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Su_Descripcion.Caption = "Sucursal";
            this.Su_Descripcion.FieldName = "Su_Descripcion";
            this.Su_Descripcion.Name = "Su_Descripcion";
            this.Su_Descripcion.OptionsColumn.AllowEdit = false;
            this.Su_Descripcion.Visible = true;
            this.Su_Descripcion.VisibleIndex = 1;
            this.Su_Descripcion.Width = 40;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.Caption = "Fecha";
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.Visible = true;
            this.colFechaCreacion.VisibleIndex = 0;
            this.colFechaCreacion.Width = 69;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario1
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde = new System.DateTime(2014, 9, 28, 14, 41, 35, 836);
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta = new System.DateTime(2014, 11, 28, 14, 41, 35, 836);
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario1.Name = "ucGe_Menu_Mantenimiento_x_usuario1";
            this.ucGe_Menu_Mantenimiento_x_usuario1.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Size = new System.Drawing.Size(798, 96);
            this.ucGe_Menu_Mantenimiento_x_usuario1.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_sucursal = false;
            // 
            // prdGrupoTrabajoInfoBindingSource
            // 
            this.prdGrupoTrabajoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Produc_Cirdesus.prd_GrupoTrabajo_Info);
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
            this.statusStrip1.Size = new System.Drawing.Size(798, 22);
            this.statusStrip1.TabIndex = 12;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 7, 9, 51, 47, 435);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 7, 9, 51, 47, 435);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(781, 94);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 13;
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
            // 
            // FrmPrd_GrupoTrabajoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmPrd_GrupoTrabajoConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Grupos de Trabajo";
            this.Load += new System.EventHandler(this.FrmPrd_GrupoTrabajoConsulta_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGrupoTrabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdGrupoTrabajoInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGrupoTrabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdGrupoTrabajoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource prdGrupoTrabajoInfoBindingSource;
        private System.Windows.Forms.BindingSource prdGrupoTrabajoInfoBindingSource1;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private DevExpress.XtraGrid.GridControl gridControlGrupoTrabajo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGrupoTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn IdGrupoTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn DescripModelo;
        private DevExpress.XtraGrid.Columns.GridColumn NombreEtapa;
        private DevExpress.XtraGrid.Columns.GridColumn pe_nombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn CodCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn Centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn Su_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario1;
    }
}