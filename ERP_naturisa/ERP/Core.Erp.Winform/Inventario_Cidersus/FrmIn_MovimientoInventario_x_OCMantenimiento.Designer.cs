namespace Core.Erp.Winform.Inventario_Cidersus
{
    partial class FrmIn_MovimientoInventario_x_OCMantenimiento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.tabControlDetalle = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridCtrlMoviInvDet = new DevExpress.XtraGrid.GridControl();
            this.gridVwMoviInvDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldm_cantidadsolicitada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad_pendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colocObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_NumDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_CodObra_preasignada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdOrdenTaller_preasignada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridCtrlMov = new DevExpress.XtraGrid.GridControl();
            this.vwInMoviInvenCusCiderCabInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridVwMov = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovi_inven_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodMoviInven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProvedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNumMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbo_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.groupBoxOpciones = new System.Windows.Forms.GroupBox();
            this.ucCp_Proveedor = new Core.Erp.Winform.Controles.UCCp_Proveedor();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtFact = new System.Windows.Forms.TextBox();
            this.txtGuiaDesp = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtPfecha = new System.Windows.Forms.DateTimePicker();
            this.PanelSuc_bodega = new System.Windows.Forms.Panel();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.inmoviinvedetalleCusCidersusInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inmoviinveInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            this.tabControlDetalle.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlMoviInvDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwMoviInvDet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlMov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwInMoviInvenCusCiderCabInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwMov)).BeginInit();
            this.panelOpciones.SuspendLayout();
            this.groupBoxOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinvedetalleCusCidersusInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinveInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelDetalle);
            this.panel1.Controls.Add(this.panelOpciones);
            this.panel1.Controls.Add(this.ucGe_Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 603);
            this.panel1.TabIndex = 0;
            // 
            // panelDetalle
            // 
            this.panelDetalle.Controls.Add(this.tabControlDetalle);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalle.Location = new System.Drawing.Point(0, 237);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(859, 366);
            this.panelDetalle.TabIndex = 48;
            // 
            // tabControlDetalle
            // 
            this.tabControlDetalle.Controls.Add(this.tabPage1);
            this.tabControlDetalle.Controls.Add(this.tabPage2);
            this.tabControlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDetalle.Location = new System.Drawing.Point(0, 0);
            this.tabControlDetalle.Name = "tabControlDetalle";
            this.tabControlDetalle.SelectedIndex = 0;
            this.tabControlDetalle.Size = new System.Drawing.Size(859, 366);
            this.tabControlDetalle.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(851, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recepcion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.gridCtrlMoviInvDet);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenes de Compra Pendientes por recibir:";
            // 
            // gridCtrlMoviInvDet
            // 
            this.gridCtrlMoviInvDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlMoviInvDet.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridCtrlMoviInvDet.Location = new System.Drawing.Point(3, 16);
            this.gridCtrlMoviInvDet.MainView = this.gridVwMoviInvDet;
            this.gridCtrlMoviInvDet.Name = "gridCtrlMoviInvDet";
            this.gridCtrlMoviInvDet.Size = new System.Drawing.Size(839, 315);
            this.gridCtrlMoviInvDet.TabIndex = 0;
            this.gridCtrlMoviInvDet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVwMoviInvDet});
            // 
            // gridVwMoviInvDet
            // 
            this.gridVwMoviInvDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldm_cantidadsolicitada,
            this.coldm_cantidad_pendiente,
            this.coldm_observacion,
            this.coldm_cantidad,
            this.colProducto,
            this.coldm_cantidad1,
            this.colocObservacion,
            this.coloc_NumDoc,
            this.coloc_fecha,
            this.col_CodObra_preasignada,
            this.col_IdOrdenTaller_preasignada});
            this.gridVwMoviInvDet.GridControl = this.gridCtrlMoviInvDet;
            this.gridVwMoviInvDet.Name = "gridVwMoviInvDet";
            this.gridVwMoviInvDet.OptionsView.ShowAutoFilterRow = true;
            this.gridVwMoviInvDet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridVwMoviInvDet_KeyDown);
            // 
            // coldm_cantidadsolicitada
            // 
            this.coldm_cantidadsolicitada.Caption = "Cant. Solic.";
            this.coldm_cantidadsolicitada.FieldName = "do_CantidadOC";
            this.coldm_cantidadsolicitada.Name = "coldm_cantidadsolicitada";
            this.coldm_cantidadsolicitada.OptionsColumn.ReadOnly = true;
            this.coldm_cantidadsolicitada.Visible = true;
            this.coldm_cantidadsolicitada.VisibleIndex = 4;
            this.coldm_cantidadsolicitada.Width = 86;
            // 
            // coldm_cantidad_pendiente
            // 
            this.coldm_cantidad_pendiente.Caption = "Saldo x Recibir";
            this.coldm_cantidad_pendiente.FieldName = "SaldoxRecibir";
            this.coldm_cantidad_pendiente.Name = "coldm_cantidad_pendiente";
            this.coldm_cantidad_pendiente.OptionsColumn.ReadOnly = true;
            this.coldm_cantidad_pendiente.Visible = true;
            this.coldm_cantidad_pendiente.VisibleIndex = 5;
            this.coldm_cantidad_pendiente.Width = 78;
            // 
            // coldm_observacion
            // 
            this.coldm_observacion.Caption = "Observacion";
            this.coldm_observacion.FieldName = "mv_observacion";
            this.coldm_observacion.Name = "coldm_observacion";
            this.coldm_observacion.Visible = true;
            this.coldm_observacion.VisibleIndex = 8;
            this.coldm_observacion.Width = 106;
            // 
            // coldm_cantidad
            // 
            this.coldm_cantidad.Caption = "Cant. Recibidas";
            this.coldm_cantidad.FieldName = "dm_cantidad_Inv";
            this.coldm_cantidad.Name = "coldm_cantidad";
            this.coldm_cantidad.OptionsColumn.ReadOnly = true;
            this.coldm_cantidad.Visible = true;
            this.coldm_cantidad.VisibleIndex = 6;
            this.coldm_cantidad.Width = 73;
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Producto";
            this.colProducto.FieldName = "producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.ReadOnly = true;
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 3;
            this.colProducto.Width = 241;
            // 
            // coldm_cantidad1
            // 
            this.coldm_cantidad1.Caption = "Cant a recibir";
            this.coldm_cantidad1.FieldName = "dm_cantidad";
            this.coldm_cantidad1.Name = "coldm_cantidad1";
            this.coldm_cantidad1.Visible = true;
            this.coldm_cantidad1.VisibleIndex = 7;
            this.coldm_cantidad1.Width = 96;
            // 
            // colocObservacion
            // 
            this.colocObservacion.Caption = "Observación O/C";
            this.colocObservacion.FieldName = "oc_observacion";
            this.colocObservacion.Name = "colocObservacion";
            this.colocObservacion.OptionsColumn.ReadOnly = true;
            this.colocObservacion.Visible = true;
            this.colocObservacion.VisibleIndex = 2;
            this.colocObservacion.Width = 388;
            // 
            // coloc_NumDoc
            // 
            this.coloc_NumDoc.Caption = "O/C Nº";
            this.coloc_NumDoc.FieldName = "IdOrdenCompra";
            this.coloc_NumDoc.Name = "coloc_NumDoc";
            this.coloc_NumDoc.OptionsColumn.ReadOnly = true;
            this.coloc_NumDoc.Visible = true;
            this.coloc_NumDoc.VisibleIndex = 1;
            this.coloc_NumDoc.Width = 46;
            // 
            // coloc_fecha
            // 
            this.coloc_fecha.Caption = "Fecha O/C";
            this.coloc_fecha.FieldName = "oc_fecha";
            this.coloc_fecha.Name = "coloc_fecha";
            this.coloc_fecha.OptionsColumn.ReadOnly = true;
            this.coloc_fecha.Visible = true;
            this.coloc_fecha.VisibleIndex = 0;
            this.coloc_fecha.Width = 50;
            // 
            // col_CodObra_preasignada
            // 
            this.col_CodObra_preasignada.Caption = "CodObra_preasignada";
            this.col_CodObra_preasignada.FieldName = "CodObra_preasignada";
            this.col_CodObra_preasignada.Name = "col_CodObra_preasignada";
            // 
            // col_IdOrdenTaller_preasignada
            // 
            this.col_IdOrdenTaller_preasignada.Caption = "IdOrdenTaller_preasignada";
            this.col_IdOrdenTaller_preasignada.FieldName = "IdOrdenTaller_preasignada";
            this.col_IdOrdenTaller_preasignada.Name = "col_IdOrdenTaller_preasignada";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridCtrlMov);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(851, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movimientos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridCtrlMov
            // 
            this.gridCtrlMov.DataSource = this.vwInMoviInvenCusCiderCabInfoBindingSource;
            this.gridCtrlMov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlMov.Location = new System.Drawing.Point(3, 3);
            this.gridCtrlMov.MainView = this.gridVwMov;
            this.gridCtrlMov.Name = "gridCtrlMov";
            this.gridCtrlMov.Size = new System.Drawing.Size(845, 334);
            this.gridCtrlMov.TabIndex = 0;
            this.gridCtrlMov.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVwMov});
            // 
            // vwInMoviInvenCusCiderCabInfoBindingSource
            // 
            this.vwInMoviInvenCusCiderCabInfoBindingSource.DataSource = typeof(Core.Erp.Info.Produc_Cirdesus.vwIn_Movi_Inven_CusCider_Cab_Info);
            // 
            // gridVwMov
            // 
            this.gridVwMov.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa1,
            this.colIdMovi_inven_tipo,
            this.colIdBodega,
            this.colIdSucursal1,
            this.colCodMoviInven,
            this.colcm_tipo,
            this.colcm_observacion,
            this.colcm_fecha,
            this.colFecha_Transac,
            this.colIdProvedor,
            this.colIdNumMovi,
            this.colSu_Descripcion,
            this.colbo_Descripcion,
            this.colCodigo,
            this.coltm_descripcion,
            this.colpr_nombre});
            this.gridVwMov.GridControl = this.gridCtrlMov;
            this.gridVwMov.Name = "gridVwMov";
            this.gridVwMov.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            // 
            // colIdMovi_inven_tipo
            // 
            this.colIdMovi_inven_tipo.FieldName = "IdMovi_inven_tipo";
            this.colIdMovi_inven_tipo.Name = "colIdMovi_inven_tipo";
            // 
            // colIdBodega
            // 
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            // 
            // colIdSucursal1
            // 
            this.colIdSucursal1.FieldName = "IdSucursal";
            this.colIdSucursal1.Name = "colIdSucursal1";
            // 
            // colCodMoviInven
            // 
            this.colCodMoviInven.Caption = "Código";
            this.colCodMoviInven.FieldName = "CodMoviInven";
            this.colCodMoviInven.Name = "colCodMoviInven";
            this.colCodMoviInven.Visible = true;
            this.colCodMoviInven.VisibleIndex = 1;
            this.colCodMoviInven.Width = 117;
            // 
            // colcm_tipo
            // 
            this.colcm_tipo.FieldName = "cm_tipo";
            this.colcm_tipo.Name = "colcm_tipo";
            // 
            // colcm_observacion
            // 
            this.colcm_observacion.Caption = "Observación";
            this.colcm_observacion.FieldName = "cm_observacion";
            this.colcm_observacion.Name = "colcm_observacion";
            this.colcm_observacion.Visible = true;
            this.colcm_observacion.VisibleIndex = 4;
            this.colcm_observacion.Width = 305;
            // 
            // colcm_fecha
            // 
            this.colcm_fecha.FieldName = "cm_fecha";
            this.colcm_fecha.Name = "colcm_fecha";
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.Caption = "Fecha";
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            this.colFecha_Transac.Visible = true;
            this.colFecha_Transac.VisibleIndex = 0;
            this.colFecha_Transac.Width = 91;
            // 
            // colIdProvedor
            // 
            this.colIdProvedor.FieldName = "IdProvedor";
            this.colIdProvedor.Name = "colIdProvedor";
            // 
            // colIdNumMovi
            // 
            this.colIdNumMovi.Caption = "Movimiento No.";
            this.colIdNumMovi.FieldName = "IdNumMovi";
            this.colIdNumMovi.Name = "colIdNumMovi";
            this.colIdNumMovi.Visible = true;
            this.colIdNumMovi.VisibleIndex = 2;
            this.colIdNumMovi.Width = 94;
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Sucursal";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            // 
            // colbo_Descripcion
            // 
            this.colbo_Descripcion.FieldName = "bo_Descripcion";
            this.colbo_Descripcion.Name = "colbo_Descripcion";
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            // 
            // coltm_descripcion
            // 
            this.coltm_descripcion.Caption = "Tipo Movimiento";
            this.coltm_descripcion.FieldName = "tm_descripcion";
            this.coltm_descripcion.Name = "coltm_descripcion";
            this.coltm_descripcion.Visible = true;
            this.coltm_descripcion.VisibleIndex = 3;
            this.coltm_descripcion.Width = 285;
            // 
            // colpr_nombre
            // 
            this.colpr_nombre.FieldName = "pr_nombre";
            this.colpr_nombre.Name = "colpr_nombre";
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.groupBoxOpciones);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpciones.Location = new System.Drawing.Point(0, 29);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(859, 208);
            this.panelOpciones.TabIndex = 47;
            // 
            // groupBoxOpciones
            // 
            this.groupBoxOpciones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxOpciones.Controls.Add(this.ucCp_Proveedor);
            this.groupBoxOpciones.Controls.Add(this.lblAnulado);
            this.groupBoxOpciones.Controls.Add(this.checkBox1);
            this.groupBoxOpciones.Controls.Add(this.label5);
            this.groupBoxOpciones.Controls.Add(this.label6);
            this.groupBoxOpciones.Controls.Add(this.label3);
            this.groupBoxOpciones.Controls.Add(this.label2);
            this.groupBoxOpciones.Controls.Add(this.label4);
            this.groupBoxOpciones.Controls.Add(this.label1);
            this.groupBoxOpciones.Controls.Add(this.txtObservacion);
            this.groupBoxOpciones.Controls.Add(this.txtFact);
            this.groupBoxOpciones.Controls.Add(this.txtGuiaDesp);
            this.groupBoxOpciones.Controls.Add(this.txtID);
            this.groupBoxOpciones.Controls.Add(this.dtPfecha);
            this.groupBoxOpciones.Controls.Add(this.PanelSuc_bodega);
            this.groupBoxOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxOpciones.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOpciones.Name = "groupBoxOpciones";
            this.groupBoxOpciones.Size = new System.Drawing.Size(859, 210);
            this.groupBoxOpciones.TabIndex = 0;
            this.groupBoxOpciones.TabStop = false;
            // 
            // ucCp_Proveedor
            // 
            this.ucCp_Proveedor.Location = new System.Drawing.Point(96, 91);
            this.ucCp_Proveedor.Name = "ucCp_Proveedor";
            this.ucCp_Proveedor.Size = new System.Drawing.Size(371, 29);
            this.ucCp_Proveedor.TabIndex = 112;
            this.ucCp_Proveedor.event_cmb_proveedor_EditValueChanged += new Core.Erp.Winform.Controles.UCCp_Proveedor.delegate_cmb_proveedor_EditValueChanged(this.ucCp_Proveedor_event_cmb_proveedor_EditValueChanged);
            // 
            // lblAnulado
            // 
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(357, 157);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(151, 24);
            this.lblAnulado.TabIndex = 107;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnulado.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(530, 97);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 111;
            this.checkBox1.Text = "Entrega Completa";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "Observación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "# Factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 109;
            this.label3.Text = "# Guia de Despacho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "Parte de Recpcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 109;
            this.label1.Text = "Fecha:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(31, 142);
            this.txtObservacion.MaxLength = 980;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(805, 59);
            this.txtObservacion.TabIndex = 108;
            // 
            // txtFact
            // 
            this.txtFact.Location = new System.Drawing.Point(643, 64);
            this.txtFact.MaxLength = 25;
            this.txtFact.Name = "txtFact";
            this.txtFact.Size = new System.Drawing.Size(204, 20);
            this.txtFact.TabIndex = 107;
            // 
            // txtGuiaDesp
            // 
            this.txtGuiaDesp.Location = new System.Drawing.Point(643, 38);
            this.txtGuiaDesp.MaxLength = 25;
            this.txtGuiaDesp.Name = "txtGuiaDesp";
            this.txtGuiaDesp.Size = new System.Drawing.Size(204, 20);
            this.txtGuiaDesp.TabIndex = 107;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtID.Location = new System.Drawing.Point(136, 13);
            this.txtID.MaxLength = 15;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 107;
            // 
            // dtPfecha
            // 
            this.dtPfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPfecha.Location = new System.Drawing.Point(643, 14);
            this.dtPfecha.Name = "dtPfecha";
            this.dtPfecha.Size = new System.Drawing.Size(204, 20);
            this.dtPfecha.TabIndex = 106;
            // 
            // PanelSuc_bodega
            // 
            this.PanelSuc_bodega.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelSuc_bodega.Location = new System.Drawing.Point(29, 38);
            this.PanelSuc_bodega.Name = "PanelSuc_bodega";
            this.PanelSuc_bodega.Size = new System.Drawing.Size(479, 51);
            this.PanelSuc_bodega.TabIndex = 105;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(859, 29);
            this.ucGe_Menu.TabIndex = 46;
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
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // inmoviinveInfoBindingSource
            // 
            this.inmoviinveInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_movi_inve_Info);
            // 
            // FrmIn_MovimientoInventario_x_OCMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 603);
            this.Controls.Add(this.panel1);
            this.Name = "FrmIn_MovimientoInventario_x_OCMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Recepción de Materiales Mantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_MovientoInventario_x_OCMantenimiento_Load);
            this.panel1.ResumeLayout(false);
            this.panelDetalle.ResumeLayout(false);
            this.tabControlDetalle.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlMoviInvDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwMoviInvDet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlMov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwInMoviInvenCusCiderCabInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwMov)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.groupBoxOpciones.ResumeLayout(false);
            this.groupBoxOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinvedetalleCusCidersusInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinveInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxOpciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtGuiaDesp;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtPfecha;
        private System.Windows.Forms.Panel PanelSuc_bodega;
        private DevExpress.XtraGrid.GridControl gridCtrlMoviInvDet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVwMoviInvDet;
        private System.Windows.Forms.BindingSource inmoviinvedetalleCusCidersusInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidadsolicitada;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad_pendiente;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFact;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabControl tabControlDetalle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridCtrlMov;
        private System.Windows.Forms.BindingSource vwInMoviInvenCusCiderCabInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVwMov;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovi_inven_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodMoviInven;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProvedor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNumMovi;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colbo_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_nombre;
        private System.Windows.Forms.BindingSource inmoviinveInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colocObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_NumDoc;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_fecha;
        private System.Windows.Forms.Label lblAnulado;
        private Controles.UCCp_Proveedor ucCp_Proveedor;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Panel panelOpciones;
        private DevExpress.XtraGrid.Columns.GridColumn col_CodObra_preasignada;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdOrdenTaller_preasignada;
    }
}