namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_Kardex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrd_Kardex));
            this.inProductoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbBodegaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSucursalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.groupBoxKardex = new System.Windows.Forms.GroupBox();
            this.gridCtrlKardex = new DevExpress.XtraGrid.GridControl();
            this.gridVwKardex = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_tipo_movi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoolNomPrd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbProducto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbBodega = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbo_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbSucursal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.paneFiltro = new System.Windows.Forms.Panel();
            this.panelGrilla = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.inProductoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBodegaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSucursalInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).BeginInit();
            this.groupBoxKardex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlKardex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwKardex)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.paneFiltro.SuspendLayout();
            this.panelGrilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // inProductoInfoBindingSource
            // 
            this.inProductoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_Producto_Info);
            // 
            // tbBodegaInfoBindingSource
            // 
            this.tbBodegaInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Bodega_Info);
            // 
            // tbSucursalInfoBindingSource
            // 
            this.tbSucursalInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Sucursal_Info);
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
            this.printableComponentLink1.Landscape = true;
            this.printableComponentLink1.Owner = null;
            this.printableComponentLink1.PrintingSystem = this.printingSystem1;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            // 
            // groupBoxKardex
            // 
            this.groupBoxKardex.Controls.Add(this.gridCtrlKardex);
            this.groupBoxKardex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxKardex.Location = new System.Drawing.Point(0, 0);
            this.groupBoxKardex.Name = "groupBoxKardex";
            this.groupBoxKardex.Size = new System.Drawing.Size(936, 250);
            this.groupBoxKardex.TabIndex = 25;
            this.groupBoxKardex.TabStop = false;
            this.groupBoxKardex.Text = "Kardex";
            // 
            // gridCtrlKardex
            // 
            this.gridCtrlKardex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlKardex.Location = new System.Drawing.Point(3, 16);
            this.gridCtrlKardex.MainView = this.gridVwKardex;
            this.gridCtrlKardex.Name = "gridCtrlKardex";
            this.gridCtrlKardex.Size = new System.Drawing.Size(930, 231);
            this.gridCtrlKardex.TabIndex = 0;
            this.gridCtrlKardex.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVwKardex});
            // 
            // gridVwKardex
            // 
            this.gridVwKardex.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gridVwKardex.Appearance.ViewCaption.Options.UseFont = true;
            this.gridVwKardex.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colSucursal,
            this.colBodega,
            this.coldm_observacion,
            this.colmv_tipo_movi,
            this.colEntrada,
            this.colSalida,
            this.colCodBarra,
            this.CoolNomPrd});
            this.gridVwKardex.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.gridVwKardex.GridControl = this.gridCtrlKardex;
            this.gridVwKardex.Name = "gridVwKardex";
            this.gridVwKardex.OptionsBehavior.ReadOnly = true;
            this.gridVwKardex.OptionsView.ShowGroupPanel = false;
            this.gridVwKardex.OptionsView.ShowViewCaption = true;
            this.gridVwKardex.ViewCaption = "KARDEX";
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "cm_fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 78;
            // 
            // colSucursal
            // 
            this.colSucursal.Caption = "Sucursal";
            this.colSucursal.FieldName = "su_descripcion";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.Visible = true;
            this.colSucursal.VisibleIndex = 1;
            this.colSucursal.Width = 154;
            // 
            // colBodega
            // 
            this.colBodega.Caption = "Bodega";
            this.colBodega.FieldName = "bo_descripcion";
            this.colBodega.Name = "colBodega";
            this.colBodega.Visible = true;
            this.colBodega.VisibleIndex = 2;
            this.colBodega.Width = 146;
            // 
            // coldm_observacion
            // 
            this.coldm_observacion.Caption = "Detalle";
            this.coldm_observacion.FieldName = "dm_observacion";
            this.coldm_observacion.Name = "coldm_observacion";
            this.coldm_observacion.Visible = true;
            this.coldm_observacion.VisibleIndex = 5;
            this.coldm_observacion.Width = 266;
            // 
            // colmv_tipo_movi
            // 
            this.colmv_tipo_movi.Caption = "Tipo Mov";
            this.colmv_tipo_movi.FieldName = "mv_tipo_movi";
            this.colmv_tipo_movi.Name = "colmv_tipo_movi";
            this.colmv_tipo_movi.OptionsColumn.ShowCaption = false;
            this.colmv_tipo_movi.Visible = true;
            this.colmv_tipo_movi.VisibleIndex = 6;
            this.colmv_tipo_movi.Width = 47;
            // 
            // colEntrada
            // 
            this.colEntrada.AppearanceCell.Options.UseTextOptions = true;
            this.colEntrada.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colEntrada.AppearanceHeader.Options.UseTextOptions = true;
            this.colEntrada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEntrada.Caption = "Entrada";
            this.colEntrada.FieldName = "entrada";
            this.colEntrada.Name = "colEntrada";
            this.colEntrada.Visible = true;
            this.colEntrada.VisibleIndex = 7;
            this.colEntrada.Width = 92;
            // 
            // colSalida
            // 
            this.colSalida.AppearanceCell.Options.UseTextOptions = true;
            this.colSalida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSalida.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSalida.Caption = "Salida";
            this.colSalida.FieldName = "salida";
            this.colSalida.Name = "colSalida";
            this.colSalida.Visible = true;
            this.colSalida.VisibleIndex = 8;
            this.colSalida.Width = 90;
            // 
            // colCodBarra
            // 
            this.colCodBarra.Caption = "Código de Barra";
            this.colCodBarra.FieldName = "CodigoBarra";
            this.colCodBarra.Name = "colCodBarra";
            this.colCodBarra.Visible = true;
            this.colCodBarra.VisibleIndex = 4;
            this.colCodBarra.Width = 147;
            // 
            // CoolNomPrd
            // 
            this.CoolNomPrd.Caption = "Producto";
            this.CoolNomPrd.FieldName = "pr_descripcion";
            this.CoolNomPrd.Name = "CoolNomPrd";
            this.CoolNomPrd.Visible = true;
            this.CoolNomPrd.VisibleIndex = 3;
            this.CoolNomPrd.Width = 144;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbProducto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmbBodega);
            this.groupBox2.Controls.Add(this.cmbSucursal);
            this.groupBox2.Controls.Add(this.dtpFechaFin);
            this.groupBox2.Controls.Add(this.dtpFechaIni);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(936, 74);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos para la Búsqueda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Producto:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.Location = new System.Drawing.Point(510, 17);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducto.Properties.DataSource = this.inProductoInfoBindingSource;
            this.cmbProducto.Properties.DisplayMember = "pr_descripcion";
            this.cmbProducto.Properties.ValueMember = "IdProducto";
            this.cmbProducto.Properties.View = this.searchLookUpEdit1View;
            this.cmbProducto.Size = new System.Drawing.Size(402, 20);
            this.cmbProducto.TabIndex = 113;
            this.cmbProducto.EditValueChanged += new System.EventHandler(this.cmbProducto_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto1,
            this.colpr_codigo,
            this.colpr_descripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colpr_descripcion, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdProducto1
            // 
            this.colIdProducto1.Caption = "Id";
            this.colIdProducto1.FieldName = "IdProducto";
            this.colIdProducto1.Name = "colIdProducto1";
            this.colIdProducto1.Visible = true;
            this.colIdProducto1.VisibleIndex = 2;
            this.colIdProducto1.Width = 73;
            // 
            // colpr_codigo
            // 
            this.colpr_codigo.Caption = "Código";
            this.colpr_codigo.FieldName = "pr_codigo";
            this.colpr_codigo.Name = "colpr_codigo";
            this.colpr_codigo.Visible = true;
            this.colpr_codigo.VisibleIndex = 1;
            this.colpr_codigo.Width = 327;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Producto";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 0;
            this.colpr_descripcion.Width = 748;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-452, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "Sucursal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 114;
            this.label4.Text = "Bodega:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 114;
            this.label14.Text = "Sucursal:";
            // 
            // cmbBodega
            // 
            this.cmbBodega.Location = new System.Drawing.Point(84, 43);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBodega.Properties.DataSource = this.tbBodegaInfoBindingSource;
            this.cmbBodega.Properties.DisplayMember = "bo_Descripcion";
            this.cmbBodega.Properties.ValueMember = "IdBodega";
            this.cmbBodega.Properties.View = this.gridView3;
            this.cmbBodega.Size = new System.Drawing.Size(336, 20);
            this.cmbBodega.TabIndex = 113;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbo_Descripcion,
            this.colIdBodega1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colbo_Descripcion
            // 
            this.colbo_Descripcion.Caption = "Bodega";
            this.colbo_Descripcion.FieldName = "bo_Descripcion";
            this.colbo_Descripcion.Name = "colbo_Descripcion";
            this.colbo_Descripcion.Visible = true;
            this.colbo_Descripcion.VisibleIndex = 0;
            this.colbo_Descripcion.Width = 700;
            // 
            // colIdBodega1
            // 
            this.colIdBodega1.Caption = "Id";
            this.colIdBodega1.FieldName = "IdBodega";
            this.colIdBodega1.Name = "colIdBodega1";
            this.colIdBodega1.Visible = true;
            this.colIdBodega1.VisibleIndex = 1;
            this.colIdBodega1.Width = 64;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Location = new System.Drawing.Point(84, 17);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSucursal.Properties.DataSource = this.tbSucursalInfoBindingSource;
            this.cmbSucursal.Properties.DisplayMember = "Su_Descripcion";
            this.cmbSucursal.Properties.ValueMember = "IdSucursal";
            this.cmbSucursal.Properties.View = this.gridView2;
            this.cmbSucursal.Size = new System.Drawing.Size(336, 20);
            this.cmbSucursal.TabIndex = 113;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSu_Descripcion,
            this.colIdSucursal1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Sucursal";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 0;
            this.colSu_Descripcion.Width = 986;
            // 
            // colIdSucursal1
            // 
            this.colIdSucursal1.Caption = "Id";
            this.colIdSucursal1.FieldName = "IdSucursal";
            this.colIdSucursal1.Name = "colIdSucursal1";
            this.colIdSucursal1.Visible = true;
            this.colIdSucursal1.VisibleIndex = 1;
            this.colIdSucursal1.Width = 162;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(731, 43);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(181, 20);
            this.dtpFechaFin.TabIndex = 111;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(507, 44);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(147, 20);
            this.dtpFechaIni.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Desde:";
            // 
            // ucGe_Menu
            // 
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 6, 6, 23, 54, 0, 465);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2015, 8, 6, 23, 54, 0, 466);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(936, 117);
            this.ucGe_Menu.TabIndex = 26;
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
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_event_btnImprimir_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // paneFiltro
            // 
            this.paneFiltro.Controls.Add(this.groupBox2);
            this.paneFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneFiltro.Location = new System.Drawing.Point(0, 117);
            this.paneFiltro.Name = "paneFiltro";
            this.paneFiltro.Size = new System.Drawing.Size(936, 74);
            this.paneFiltro.TabIndex = 27;
            // 
            // panelGrilla
            // 
            this.panelGrilla.Controls.Add(this.groupBoxKardex);
            this.panelGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrilla.Location = new System.Drawing.Point(0, 191);
            this.panelGrilla.Name = "panelGrilla";
            this.panelGrilla.Size = new System.Drawing.Size(936, 250);
            this.panelGrilla.TabIndex = 28;
            // 
            // FrmPrd_Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 441);
            this.Controls.Add(this.panelGrilla);
            this.Controls.Add(this.paneFiltro);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmPrd_Kardex";
            this.Text = "Kardex";
            this.Load += new System.EventHandler(this.FrmPrd_Kardex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inProductoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBodegaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSucursalInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).EndInit();
            this.groupBoxKardex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlKardex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwKardex)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.paneFiltro.ResumeLayout(false);
            this.panelGrilla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void toolStripMain_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.BindingSource inProductoInfoBindingSource;
        private System.Windows.Forms.BindingSource tbBodegaInfoBindingSource;
        private System.Windows.Forms.BindingSource tbSucursalInfoBindingSource;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private System.Windows.Forms.GroupBox groupBoxKardex;
        private DevExpress.XtraGrid.GridControl gridCtrlKardex;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVwKardex;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colBodega;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_tipo_movi;
        private DevExpress.XtraGrid.Columns.GridColumn colEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colCodBarra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbBodega;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colbo_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn CoolNomPrd;
        private System.Windows.Forms.Panel paneFiltro;
        private System.Windows.Forms.Panel panelGrilla;
    }
}