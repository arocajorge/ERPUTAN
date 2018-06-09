namespace Core.Erp.Winform.Produccion_Edehsa
{
    partial class FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraConsulta));
            this.gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra = new DevExpress.XtraGrid.GridControl();
            this.comListadoMaterialesDisponibles_PreAsignado_a_ObraDetInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCodigoBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaReg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsu_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colot_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colob_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collm_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liberar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.comListadoMaterialesDisponibles_PreAsignado_a_ObraInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prdListadoMaterialesDisponibles_PreAsignado_a_ObraInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comListadoMaterialesDisponibles_PreAsignado_a_ObraDetInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comListadoMaterialesDisponibles_PreAsignado_a_ObraInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdListadoMaterialesDisponibles_PreAsignado_a_ObraInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra
            // 
            this.gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra.DataSource = this.comListadoMaterialesDisponibles_PreAsignado_a_ObraDetInfoBindingSource;
            this.gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra.Location = new System.Drawing.Point(0, 0);
            this.gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra.MainView = this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra;
            this.gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra.Name = "gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra";
            this.gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckedComboBoxEdit1});
            this.gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra.Size = new System.Drawing.Size(746, 297);
            this.gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra.TabIndex = 13;
            this.gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra});
            // 
            // comListadoMaterialesDisponibles_PreAsignado_a_ObraDetInfoBindingSource
            // 
            this.comListadoMaterialesDisponibles_PreAsignado_a_ObraDetInfoBindingSource.DataSource = typeof(Core.Erp.Info.Compras_Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info);
            // 
            // gridViewListMaterialesDisponibles_PreAsignado_a_Obra
            // 
            this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.ColIdProducto,
            this.ColProducto,
            this.ColCodigoBarra,
            this.colCodObra,
            this.ColObra,
            this.colFechaReg,
            this.colEstado,
            this.colsu_descripcion,
            this.colot_descripcion,
            this.colob_descripcion,
            this.collm_Observacion,
            this.Liberar});
            this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra.GridControl = this.gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra;
            this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra.Name = "gridViewListMaterialesDisponibles_PreAsignado_a_Obra";
            this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra.OptionsFind.AlwaysVisible = true;
            this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra.OptionsView.ShowAutoFilterRow = true;
            this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra.OptionsView.ShowViewCaption = true;
            this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra.ViewCaption = "Listado de Requerimientos de MaterialesDisponibles_PreAsignado_a_Obra";
            this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra_RowCellStyle);
            this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.OptionsColumn.AllowEdit = false;
            // 
            // ColIdProducto
            // 
            this.ColIdProducto.Caption = "IdProducto";
            this.ColIdProducto.FieldName = "IdProducto";
            this.ColIdProducto.Name = "ColIdProducto";
            this.ColIdProducto.OptionsColumn.AllowEdit = false;
            // 
            // ColProducto
            // 
            this.ColProducto.Caption = "Producto";
            this.ColProducto.FieldName = "pr_descripcion";
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.OptionsColumn.AllowEdit = false;
            this.ColProducto.Visible = true;
            this.ColProducto.VisibleIndex = 2;
            this.ColProducto.Width = 197;
            // 
            // ColCodigoBarra
            // 
            this.ColCodigoBarra.Caption = "CodigoBarra";
            this.ColCodigoBarra.FieldName = "CodigoBarra";
            this.ColCodigoBarra.Name = "ColCodigoBarra";
            this.ColCodigoBarra.OptionsColumn.AllowEdit = false;
            this.ColCodigoBarra.Visible = true;
            this.ColCodigoBarra.VisibleIndex = 3;
            this.ColCodigoBarra.Width = 197;
            // 
            // colCodObra
            // 
            this.colCodObra.Caption = "CodObra";
            this.colCodObra.FieldName = "CodObra";
            this.colCodObra.Name = "colCodObra";
            this.colCodObra.OptionsColumn.AllowEdit = false;
            // 
            // ColObra
            // 
            this.ColObra.Caption = "Obra Pre-Asignada";
            this.ColObra.FieldName = "Obra";
            this.ColObra.Name = "ColObra";
            this.ColObra.OptionsColumn.AllowEdit = false;
            this.ColObra.Visible = true;
            this.ColObra.VisibleIndex = 1;
            this.ColObra.Width = 197;
            // 
            // colFechaReg
            // 
            this.colFechaReg.FieldName = "FechaReg";
            this.colFechaReg.Name = "colFechaReg";
            this.colFechaReg.OptionsColumn.AllowEdit = false;
            this.colFechaReg.Visible = true;
            this.colFechaReg.VisibleIndex = 5;
            this.colFechaReg.Width = 205;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 6;
            this.colEstado.Width = 271;
            // 
            // colsu_descripcion
            // 
            this.colsu_descripcion.Caption = "Sucursal";
            this.colsu_descripcion.FieldName = "su_descripcion";
            this.colsu_descripcion.Name = "colsu_descripcion";
            this.colsu_descripcion.Width = 115;
            // 
            // colot_descripcion
            // 
            this.colot_descripcion.Name = "colot_descripcion";
            // 
            // colob_descripcion
            // 
            this.colob_descripcion.Caption = "Obra";
            this.colob_descripcion.FieldName = "ob_descripcion";
            this.colob_descripcion.Name = "colob_descripcion";
            this.colob_descripcion.Width = 146;
            // 
            // collm_Observacion
            // 
            this.collm_Observacion.Caption = "Observación";
            this.collm_Observacion.FieldName = "lm_Observacion";
            this.collm_Observacion.Name = "collm_Observacion";
            this.collm_Observacion.OptionsColumn.AllowEdit = false;
            this.collm_Observacion.Visible = true;
            this.collm_Observacion.VisibleIndex = 4;
            this.collm_Observacion.Width = 231;
            // 
            // Liberar
            // 
            this.Liberar.Caption = "Liberar";
            this.Liberar.FieldName = "liberar";
            this.Liberar.Name = "Liberar";
            this.Liberar.Visible = true;
            this.Liberar.VisibleIndex = 0;
            this.Liberar.Width = 56;
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // comListadoMaterialesDisponibles_PreAsignado_a_ObraInfoBindingSource
            // 
            this.comListadoMaterialesDisponibles_PreAsignado_a_ObraInfoBindingSource.DataSource = typeof(Core.Erp.Info.Compras_Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info);
            // 
            // prdListadoMaterialesDisponibles_PreAsignado_a_ObraInfoBindingSource
            // 
            this.prdListadoMaterialesDisponibles_PreAsignado_a_ObraInfoBindingSource.DataSource = typeof(Core.Erp.Info.Compras_Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 297);
            this.panel1.TabIndex = 14;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasSucursales = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 11, 9, 12, 12, 3, 172);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 1, 9, 12, 12, 3, 172);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(746, 99);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 15;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(746, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Requerimiento de MaterialesDisponibles_PreAsignado_a_Obra Consulta";
            this.Load += new System.EventHandler(this.FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comListadoMaterialesDisponibles_PreAsignado_a_ObraDetInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListMaterialesDisponibles_PreAsignado_a_Obra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comListadoMaterialesDisponibles_PreAsignado_a_ObraInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdListadoMaterialesDisponibles_PreAsignado_a_ObraInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra;
        private System.Windows.Forms.BindingSource prdListadoMaterialesDisponibles_PreAsignado_a_ObraInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colCodObra;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaReg;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colsu_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colot_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colob_descripcion;
        private System.Windows.Forms.BindingSource comListadoMaterialesDisponibles_PreAsignado_a_ObraInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewListMaterialesDisponibles_PreAsignado_a_Obra;
        private DevExpress.XtraGrid.Columns.GridColumn collm_Observacion;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.BindingSource comListadoMaterialesDisponibles_PreAsignado_a_ObraDetInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn ColProducto;
        private DevExpress.XtraGrid.Columns.GridColumn ColCodigoBarra;
        private DevExpress.XtraGrid.Columns.GridColumn ColObra;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Liberar;
    }
}