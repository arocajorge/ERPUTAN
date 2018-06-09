namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Ajuste_Inventario_Mant
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMotivoInv = new Core.Erp.Winform.Controles.UCIn_MotivoInvCmb();
            this.label7 = new System.Windows.Forms.Label();
            this.UCSucurBod = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.txtcodigoAjuste = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtNumAjuste = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucIn_TipoMoviInv_Cmb1 = new Core.Erp.Winform.Controles.UCIn_TipoMoviInv_Cmb();
            this.label3 = new System.Windows.Forms.Label();
            this.opt_egreso = new System.Windows.Forms.RadioButton();
            this.opt_ingreso = new System.Windows.Forms.RadioButton();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.tabControl_detalle = new System.Windows.Forms.TabControl();
            this.tabProducto = new System.Windows.Forms.TabPage();
            this.panelDetalleProducto = new System.Windows.Forms.Panel();
            this.gridControlProductos = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProducto_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_precio_publico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_pedidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_ManejaIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_costo_promedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad_sinConversion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUnidadMedida_sinConversion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbUnidadMedida = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_costo_sinConversion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCentroCosto_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCentroCosto_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRegistro_subcentro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbSubcentro_costo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSubcentro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad_convertida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_costo_convertido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUnidadMedida_convertida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabContabilidad = new System.Windows.Forms.TabPage();
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1 = new Core.Erp.Winform.Controles.UCInv_GridCbte_Cble_x_Ing_Egr_Inv();
            this.TmHilo = new System.Windows.Forms.Timer();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlantilla = new System.Windows.Forms.LinkLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.tabControl_detalle.SuspendLayout();
            this.tabProducto.SuspendLayout();
            this.panelDetalleProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubcentro_costo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabContabilidad.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPlantilla);
            this.groupBox1.Controls.Add(this.cmbMotivoInv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.UCSucurBod);
            this.groupBox1.Controls.Add(this.lblAnulado);
            this.groupBox1.Controls.Add(this.txtcodigoAjuste);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtNumAjuste);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1057, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Principales de Ajuste";
            // 
            // cmbMotivoInv
            // 
            this.cmbMotivoInv.Location = new System.Drawing.Point(652, 105);
            this.cmbMotivoInv.Name = "cmbMotivoInv";
            this.cmbMotivoInv.Size = new System.Drawing.Size(360, 26);
            this.cmbMotivoInv.TabIndex = 17;
            this.cmbMotivoInv.Tipo_Ing_Egr = ein_Tipo_Ing_Egr.ING;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Motivo Inv:";
            // 
            // UCSucurBod
            // 
            this.UCSucurBod.Location = new System.Drawing.Point(18, 46);
            this.UCSucurBod.Name = "UCSucurBod";
            this.UCSucurBod.Size = new System.Drawing.Size(467, 51);
            this.UCSucurBod.TabIndex = 15;
            this.UCSucurBod.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
            this.UCSucurBod.Event_cmb_bodega_SelectionChangeCommitted += new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectionChangeCommitted(this.UCSucurBod_Event_cmb_bodega_SelectionChangeCommitted_1);
            this.UCSucurBod.Event_cmb_sucursal1_EditValueChanged += new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega.delegate_cmb_sucursal1_EditValueChanged(this.UCSucurBod_Event_cmb_sucursal1_EditValueChanged);
            this.UCSucurBod.Event_cmb_bodega1_EditValueChanged += new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega.delegate_cmb_bodega1_EditValueChanged(this.UCSucurBod_Event_cmb_bodega1_EditValueChanged);
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(520, 16);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(123, 20);
            this.lblAnulado.TabIndex = 14;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // txtcodigoAjuste
            // 
            this.txtcodigoAjuste.Location = new System.Drawing.Point(344, 22);
            this.txtcodigoAjuste.Name = "txtcodigoAjuste";
            this.txtcodigoAjuste.Size = new System.Drawing.Size(157, 20);
            this.txtcodigoAjuste.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo Ajuste:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtObservacion);
            this.groupBox4.Location = new System.Drawing.Point(15, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1027, 73);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Observacion";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacion.Location = new System.Drawing.Point(3, 16);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(1021, 54);
            this.txtObservacion.TabIndex = 8;
            // 
            // txtNumAjuste
            // 
            this.txtNumAjuste.Enabled = false;
            this.txtNumAjuste.Location = new System.Drawing.Point(83, 22);
            this.txtNumAjuste.Name = "txtNumAjuste";
            this.txtNumAjuste.Size = new System.Drawing.Size(157, 20);
            this.txtNumAjuste.TabIndex = 10;
            this.txtNumAjuste.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "#Ajuste:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(931, 16);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(108, 20);
            this.dtpFecha.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(885, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ucIn_TipoMoviInv_Cmb1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.opt_egreso);
            this.groupBox2.Controls.Add(this.opt_ingreso);
            this.groupBox2.Location = new System.Drawing.Point(515, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 59);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Movimiento";
            // 
            // ucIn_TipoMoviInv_Cmb1
            // 
            this.ucIn_TipoMoviInv_Cmb1.Location = new System.Drawing.Point(137, 20);
            this.ucIn_TipoMoviInv_Cmb1.Name = "ucIn_TipoMoviInv_Cmb1";
            this.ucIn_TipoMoviInv_Cmb1.Size = new System.Drawing.Size(360, 33);
            this.ucIn_TipoMoviInv_Cmb1.TabIndex = 6;
            this.ucIn_TipoMoviInv_Cmb1.Visible_buton_Acciones = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Concepto";
            // 
            // opt_egreso
            // 
            this.opt_egreso.AutoSize = true;
            this.opt_egreso.Location = new System.Drawing.Point(15, 39);
            this.opt_egreso.Name = "opt_egreso";
            this.opt_egreso.Size = new System.Drawing.Size(58, 17);
            this.opt_egreso.TabIndex = 1;
            this.opt_egreso.Text = "Egreso";
            this.opt_egreso.UseVisualStyleBackColor = true;
            this.opt_egreso.CheckedChanged += new System.EventHandler(this.opt_egreso_CheckedChanged);
            // 
            // opt_ingreso
            // 
            this.opt_ingreso.AutoSize = true;
            this.opt_ingreso.Checked = true;
            this.opt_ingreso.Location = new System.Drawing.Point(15, 19);
            this.opt_ingreso.Name = "opt_ingreso";
            this.opt_ingreso.Size = new System.Drawing.Size(60, 17);
            this.opt_ingreso.TabIndex = 0;
            this.opt_ingreso.TabStop = true;
            this.opt_ingreso.Text = "Ingreso";
            this.opt_ingreso.UseVisualStyleBackColor = true;
            this.opt_ingreso.CheckedChanged += new System.EventHandler(this.opt_ingreso_CheckedChanged);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.tabControl_detalle);
            this.panelPrincipal.Controls.Add(this.groupBox1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1057, 554);
            this.panelPrincipal.TabIndex = 8;
            // 
            // tabControl_detalle
            // 
            this.tabControl_detalle.Controls.Add(this.tabProducto);
            this.tabControl_detalle.Controls.Add(this.tabContabilidad);
            this.tabControl_detalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_detalle.Location = new System.Drawing.Point(0, 204);
            this.tabControl_detalle.Name = "tabControl_detalle";
            this.tabControl_detalle.SelectedIndex = 0;
            this.tabControl_detalle.Size = new System.Drawing.Size(1057, 350);
            this.tabControl_detalle.TabIndex = 4;
            // 
            // tabProducto
            // 
            this.tabProducto.Controls.Add(this.panelDetalleProducto);
            this.tabProducto.Location = new System.Drawing.Point(4, 22);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducto.Size = new System.Drawing.Size(1049, 324);
            this.tabProducto.TabIndex = 0;
            this.tabProducto.Text = "Productos";
            this.tabProducto.UseVisualStyleBackColor = true;
            // 
            // panelDetalleProducto
            // 
            this.panelDetalleProducto.Controls.Add(this.gridControlProductos);
            this.panelDetalleProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalleProducto.Location = new System.Drawing.Point(3, 3);
            this.panelDetalleProducto.Name = "panelDetalleProducto";
            this.panelDetalleProducto.Size = new System.Drawing.Size(1043, 318);
            this.panelDetalleProducto.TabIndex = 0;
            // 
            // gridControlProductos
            // 
            this.gridControlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductos.Location = new System.Drawing.Point(0, 0);
            this.gridControlProductos.MainView = this.gridViewProductos;
            this.gridControlProductos.Name = "gridControlProductos";
            this.gridControlProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProducto_grid,
            this.cmbCentroCosto_grid,
            this.cmbSubcentro_costo,
            this.cmbUnidadMedida});
            this.gridControlProductos.Size = new System.Drawing.Size(1043, 318);
            this.gridControlProductos.TabIndex = 1;
            this.gridControlProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductos});
            // 
            // gridViewProductos
            // 
            this.gridViewProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colcod_producto,
            this.coldm_cantidad_sinConversion,
            this.colIdUnidadMedida_sinConversion,
            this.coldm_observacion,
            this.colmv_costo_sinConversion,
            this.colIdCentroCosto_grid,
            this.colIdRegistro_subcentro,
            this.colIdSubcentro,
            this.coldm_cantidad_convertida,
            this.colmv_costo_convertido,
            this.colIdUnidadMedida_convertida});
            this.gridViewProductos.GridControl = this.gridControlProductos;
            this.gridViewProductos.Name = "gridViewProductos";
            this.gridViewProductos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewProductos.OptionsView.ShowGroupPanel = false;
            this.gridViewProductos.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewProductos_RowCellStyle);
            this.gridViewProductos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProductos_FocusedRowChanged);
            this.gridViewProductos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewProductos_CellValueChanged);
            this.gridViewProductos.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewProductos_CellValueChanging);
            this.gridViewProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewProductos_KeyDown);
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "Producto";
            this.colIdProducto.ColumnEdit = this.cmbProducto_grid;
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 1;
            this.colIdProducto.Width = 234;
            // 
            // cmbProducto_grid
            // 
            this.cmbProducto_grid.AutoHeight = false;
            this.cmbProducto_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducto_grid.Name = "cmbProducto_grid";
            this.cmbProducto_grid.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto_cmbgrid,
            this.colpr_codigo_cmbgrid,
            this.colpr_descripcion,
            this.colpr_precio_publico,
            this.colpr_stock,
            this.colpr_pedidos,
            this.colpr_ManejaIva,
            this.colpr_costo_promedio,
            this.colpr_peso});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto_cmbgrid
            // 
            this.colIdProducto_cmbgrid.Caption = "IdProducto";
            this.colIdProducto_cmbgrid.FieldName = "IdProducto";
            this.colIdProducto_cmbgrid.Name = "colIdProducto_cmbgrid";
            this.colIdProducto_cmbgrid.Width = 98;
            // 
            // colpr_codigo_cmbgrid
            // 
            this.colpr_codigo_cmbgrid.Caption = "Código";
            this.colpr_codigo_cmbgrid.FieldName = "pr_codigo";
            this.colpr_codigo_cmbgrid.Name = "colpr_codigo_cmbgrid";
            this.colpr_codigo_cmbgrid.Visible = true;
            this.colpr_codigo_cmbgrid.VisibleIndex = 0;
            this.colpr_codigo_cmbgrid.Width = 175;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Descripción";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 1;
            this.colpr_descripcion.Width = 808;
            // 
            // colpr_precio_publico
            // 
            this.colpr_precio_publico.Caption = "P.V.P.";
            this.colpr_precio_publico.FieldName = "pr_precio_publico";
            this.colpr_precio_publico.Name = "colpr_precio_publico";
            this.colpr_precio_publico.Width = 77;
            // 
            // colpr_stock
            // 
            this.colpr_stock.Caption = "Stock";
            this.colpr_stock.FieldName = "pr_stock_Bodega";
            this.colpr_stock.Name = "colpr_stock";
            this.colpr_stock.Width = 101;
            // 
            // colpr_pedidos
            // 
            this.colpr_pedidos.Caption = "Pedidos";
            this.colpr_pedidos.FieldName = "pr_pedidos";
            this.colpr_pedidos.Name = "colpr_pedidos";
            this.colpr_pedidos.Width = 101;
            // 
            // colpr_ManejaIva
            // 
            this.colpr_ManejaIva.Caption = "Maneja Iva";
            this.colpr_ManejaIva.FieldName = "pr_ManejaIva";
            this.colpr_ManejaIva.Name = "colpr_ManejaIva";
            this.colpr_ManejaIva.Width = 101;
            // 
            // colpr_costo_promedio
            // 
            this.colpr_costo_promedio.Caption = "Costo";
            this.colpr_costo_promedio.FieldName = "pr_costo_promedio";
            this.colpr_costo_promedio.Name = "colpr_costo_promedio";
            this.colpr_costo_promedio.Visible = true;
            this.colpr_costo_promedio.VisibleIndex = 2;
            this.colpr_costo_promedio.Width = 197;
            // 
            // colpr_peso
            // 
            this.colpr_peso.Caption = "Peso";
            this.colpr_peso.FieldName = "pr_peso";
            this.colpr_peso.Name = "colpr_peso";
            this.colpr_peso.Width = 101;
            // 
            // colcod_producto
            // 
            this.colcod_producto.Caption = "Código";
            this.colcod_producto.FieldName = "cod_producto";
            this.colcod_producto.Name = "colcod_producto";
            this.colcod_producto.OptionsColumn.AllowEdit = false;
            this.colcod_producto.Visible = true;
            this.colcod_producto.VisibleIndex = 0;
            this.colcod_producto.Width = 100;
            // 
            // coldm_cantidad_sinConversion
            // 
            this.coldm_cantidad_sinConversion.Caption = "Cantidad";
            this.coldm_cantidad_sinConversion.FieldName = "dm_cantidad_sinConversion";
            this.coldm_cantidad_sinConversion.Name = "coldm_cantidad_sinConversion";
            this.coldm_cantidad_sinConversion.Visible = true;
            this.coldm_cantidad_sinConversion.VisibleIndex = 3;
            this.coldm_cantidad_sinConversion.Width = 93;
            // 
            // colIdUnidadMedida_sinConversion
            // 
            this.colIdUnidadMedida_sinConversion.Caption = "U. medida";
            this.colIdUnidadMedida_sinConversion.ColumnEdit = this.cmbUnidadMedida;
            this.colIdUnidadMedida_sinConversion.FieldName = "IdUnidadMedida_sinConversion";
            this.colIdUnidadMedida_sinConversion.Name = "colIdUnidadMedida_sinConversion";
            this.colIdUnidadMedida_sinConversion.Visible = true;
            this.colIdUnidadMedida_sinConversion.VisibleIndex = 2;
            this.colIdUnidadMedida_sinConversion.Width = 118;
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmbUnidadMedida.AutoHeight = false;
            this.cmbUnidadMedida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUnidadMedida.DisplayMember = "Descripcion";
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.ReadOnly = true;
            this.cmbUnidadMedida.ValueMember = "IdUnidadMedida";
            this.cmbUnidadMedida.View = this.gridView3;
            this.cmbUnidadMedida.Click += new System.EventHandler(this.cmbUnidadMedida_Click);
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // coldm_observacion
            // 
            this.coldm_observacion.Caption = "Observación por Producto";
            this.coldm_observacion.FieldName = "dm_observacion";
            this.coldm_observacion.Name = "coldm_observacion";
            this.coldm_observacion.Visible = true;
            this.coldm_observacion.VisibleIndex = 5;
            this.coldm_observacion.Width = 294;
            // 
            // colmv_costo_sinConversion
            // 
            this.colmv_costo_sinConversion.Caption = "Costo";
            this.colmv_costo_sinConversion.FieldName = "mv_costo_sinConversion";
            this.colmv_costo_sinConversion.Name = "colmv_costo_sinConversion";
            this.colmv_costo_sinConversion.Visible = true;
            this.colmv_costo_sinConversion.VisibleIndex = 4;
            this.colmv_costo_sinConversion.Width = 101;
            // 
            // colIdCentroCosto_grid
            // 
            this.colIdCentroCosto_grid.Caption = "Centro de Costo";
            this.colIdCentroCosto_grid.ColumnEdit = this.cmbCentroCosto_grid;
            this.colIdCentroCosto_grid.FieldName = "IdCentroCosto";
            this.colIdCentroCosto_grid.Name = "colIdCentroCosto_grid";
            this.colIdCentroCosto_grid.Visible = true;
            this.colIdCentroCosto_grid.VisibleIndex = 6;
            this.colIdCentroCosto_grid.Width = 121;
            // 
            // cmbCentroCosto_grid
            // 
            this.cmbCentroCosto_grid.AutoHeight = false;
            this.cmbCentroCosto_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCentroCosto_grid.DisplayMember = "Centro_costo2";
            this.cmbCentroCosto_grid.Name = "cmbCentroCosto_grid";
            this.cmbCentroCosto_grid.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCentroCosto_cmbgrid,
            this.colCentro_costo,
            this.colpc_Estado});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCentroCosto_cmbgrid
            // 
            this.colIdCentroCosto_cmbgrid.Caption = "Código";
            this.colIdCentroCosto_cmbgrid.FieldName = "IdCentroCosto";
            this.colIdCentroCosto_cmbgrid.Name = "colIdCentroCosto_cmbgrid";
            this.colIdCentroCosto_cmbgrid.Visible = true;
            this.colIdCentroCosto_cmbgrid.VisibleIndex = 1;
            this.colIdCentroCosto_cmbgrid.Width = 179;
            // 
            // colCentro_costo
            // 
            this.colCentro_costo.Caption = "Descripción";
            this.colCentro_costo.FieldName = "Centro_costo";
            this.colCentro_costo.Name = "colCentro_costo";
            this.colCentro_costo.Visible = true;
            this.colCentro_costo.VisibleIndex = 0;
            this.colCentro_costo.Width = 820;
            // 
            // colpc_Estado
            // 
            this.colpc_Estado.Caption = "Estado";
            this.colpc_Estado.FieldName = "pc_Estado";
            this.colpc_Estado.Name = "colpc_Estado";
            this.colpc_Estado.Visible = true;
            this.colpc_Estado.VisibleIndex = 2;
            this.colpc_Estado.Width = 181;
            // 
            // colIdRegistro_subcentro
            // 
            this.colIdRegistro_subcentro.Caption = "Subcentro de costo";
            this.colIdRegistro_subcentro.ColumnEdit = this.cmbSubcentro_costo;
            this.colIdRegistro_subcentro.FieldName = "IdRegistro";
            this.colIdRegistro_subcentro.Name = "colIdRegistro_subcentro";
            this.colIdRegistro_subcentro.Visible = true;
            this.colIdRegistro_subcentro.VisibleIndex = 7;
            this.colIdRegistro_subcentro.Width = 119;
            // 
            // cmbSubcentro_costo
            // 
            this.cmbSubcentro_costo.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmbSubcentro_costo.AutoHeight = false;
            this.cmbSubcentro_costo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSubcentro_costo.DisplayMember = "Centro_costo2";
            this.cmbSubcentro_costo.Name = "cmbSubcentro_costo";
            this.cmbSubcentro_costo.ReadOnly = true;
            this.cmbSubcentro_costo.ValueMember = "IdRegistro";
            this.cmbSubcentro_costo.View = this.gridView2;
            this.cmbSubcentro_costo.Click += new System.EventHandler(this.cmbSubcentro_costo_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Subcentro de costo";
            this.gridColumn1.FieldName = "Centro_costo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 982;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "IdCentroCosto_sub_centro_costo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 198;
            // 
            // colIdSubcentro
            // 
            this.colIdSubcentro.Caption = "IdSubcentro";
            this.colIdSubcentro.FieldName = "IdCentroCosto_sub_centro_costo";
            this.colIdSubcentro.Name = "colIdSubcentro";
            this.colIdSubcentro.OptionsColumn.AllowEdit = false;
            // 
            // coldm_cantidad_convertida
            // 
            this.coldm_cantidad_convertida.Caption = "Cant. convertida";
            this.coldm_cantidad_convertida.FieldName = "dm_cantidad";
            this.coldm_cantidad_convertida.Name = "coldm_cantidad_convertida";
            this.coldm_cantidad_convertida.OptionsColumn.AllowEdit = false;
            // 
            // colmv_costo_convertido
            // 
            this.colmv_costo_convertido.Caption = "Costo convertido";
            this.colmv_costo_convertido.FieldName = "mv_costo";
            this.colmv_costo_convertido.Name = "colmv_costo_convertido";
            this.colmv_costo_convertido.OptionsColumn.AllowEdit = false;
            // 
            // colIdUnidadMedida_convertida
            // 
            this.colIdUnidadMedida_convertida.Caption = "U. medida convertida";
            this.colIdUnidadMedida_convertida.ColumnEdit = this.cmbUnidadMedida;
            this.colIdUnidadMedida_convertida.FieldName = "IdUnidadMedida";
            this.colIdUnidadMedida_convertida.Name = "colIdUnidadMedida_convertida";
            this.colIdUnidadMedida_convertida.OptionsColumn.AllowEdit = false;
            // 
            // tabContabilidad
            // 
            this.tabContabilidad.Controls.Add(this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1);
            this.tabContabilidad.Location = new System.Drawing.Point(4, 22);
            this.tabContabilidad.Name = "tabContabilidad";
            this.tabContabilidad.Padding = new System.Windows.Forms.Padding(3);
            this.tabContabilidad.Size = new System.Drawing.Size(1049, 324);
            this.tabContabilidad.TabIndex = 1;
            this.tabContabilidad.Text = "Diario Contable";
            this.tabContabilidad.UseVisualStyleBackColor = true;
            // 
            // ucInv_GridCbte_Cble_x_Ing_Egr_Inv1
            // 
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.Location = new System.Drawing.Point(3, 3);
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.Name = "ucInv_GridCbte_Cble_x_Ing_Egr_Inv1";
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.Size = new System.Drawing.Size(1043, 318);
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.TabIndex = 0;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpLote = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1057, 29);
            this.ucGe_Menu.TabIndex = 9;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_event_btnlimpiar_Click);
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 583);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1057, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 554);
            this.panel1.TabIndex = 11;
            // 
            // lblPlantilla
            // 
            this.lblPlantilla.AutoSize = true;
            this.lblPlantilla.Location = new System.Drawing.Point(29, 105);
            this.lblPlantilla.Name = "lblPlantilla";
            this.lblPlantilla.Size = new System.Drawing.Size(254, 13);
            this.lblPlantilla.TabIndex = 18;
            this.lblPlantilla.TabStop = true;
            this.lblPlantilla.Text = "Descargar plantilla para funcionalidad copiar y pegar";
            this.lblPlantilla.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPlantilla_LinkClicked);
            // 
            // FrmIn_Ajuste_Inventario_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmIn_Ajuste_Inventario_Mant";
            this.Text = "Ajuste de Inventario (Ingresos /Egresos)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIn_AjustesInven_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmIn_AjustesInven_Mant_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.tabControl_detalle.ResumeLayout(false);
            this.tabProducto.ResumeLayout(false);
            this.panelDetalleProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubcentro_costo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabContabilidad.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton opt_egreso;
        private System.Windows.Forms.RadioButton opt_ingreso;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtNumAjuste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl_detalle;
        private System.Windows.Forms.TabPage tabProducto;
        private System.Windows.Forms.TabPage tabContabilidad;
        private System.Windows.Forms.Panel panelDetalleProducto;
        private System.Windows.Forms.TextBox txtcodigoAjuste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.Timer TmHilo;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private Controles.UCIn_Sucursal_Bodega UCSucurBod;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCIn_TipoMoviInv_Cmb ucIn_TipoMoviInv_Cmb1;
        private Controles.UCIn_MotivoInvCmb cmbMotivoInv;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.GridControl gridControlProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProducto_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_precio_publico;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_stock;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_pedidos;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_ManejaIva;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_costo_promedio;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_peso;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_producto;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad_sinConversion;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_costo_sinConversion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_grid;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbCentroCosto_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Estado;
        private Controles.UCInv_GridCbte_Cble_x_Ing_Egr_Inv ucInv_GridCbte_Cble_x_Ing_Egr_Inv1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbSubcentro_costo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRegistro_subcentro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSubcentro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida_sinConversion;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad_convertida;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_costo_convertido;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida_convertida;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbUnidadMedida;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.LinkLabel lblPlantilla;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}