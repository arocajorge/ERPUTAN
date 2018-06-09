namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Devolucion_Inven_Mant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_Devolucion_Inven_Mant));
            this.ucGe_Menu_Superior = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.UcGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.chkDevolver_toda_trans = new System.Windows.Forms.CheckBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdMovi_Inv = new DevExpress.XtraEditors.TextEdit();
            this.btnBusquedaAvanza = new System.Windows.Forms.Button();
            this.imageListIconos = new System.Windows.Forms.ImageList(this.components);
            this.btnImportar = new System.Windows.Forms.Button();
            this.ucIn_TipoMoviInv_Cmb = new Core.Erp.Winform.Controles.UCIn_TipoMoviInv_Cmb();
            this.txtCodDev = new System.Windows.Forms.TextBox();
            this.ucIn_Sucursal_Bodega = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.txtidDev = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gridDevolucion_det = new DevExpress.XtraGrid.GridControl();
            this.gridView_devol_inven = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColCodProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colnom_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCant_Inven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCantDevuel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCant_a_devol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdDev_Inven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdEmpresa_movi_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdSucursal_movi_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdBodega_movi_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdMovi_inven_tipo_movi_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdNumMovi_movi_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSecuencia_movi_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProducto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdMovi_Inv.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevolucion_det)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_devol_inven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Superior
            // 
            this.ucGe_Menu_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior.Name = "ucGe_Menu_Superior";
            this.ucGe_Menu_Superior.Size = new System.Drawing.Size(1006, 29);
            this.ucGe_Menu_Superior.TabIndex = 0;
            this.ucGe_Menu_Superior.Visible_bntAnular = true;
            this.ucGe_Menu_Superior.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior.Visible_bntLimpiar = true;
            this.ucGe_Menu_Superior.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior.Visible_bntSalir = true;
            this.ucGe_Menu_Superior.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior.Visible_btnModificar = false;
            this.ucGe_Menu_Superior.Visible_btnproductos = false;
            this.ucGe_Menu_Superior.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_Superior_event_btnGuardar_Click);
            this.ucGe_Menu_Superior.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_Superior_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu_Superior.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_Superior_event_btnlimpiar_Click);
            this.ucGe_Menu_Superior.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_Superior_event_btnAnular_Click);
            this.ucGe_Menu_Superior.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_event_btnSalir_Click);
            // 
            // UcGe_BarraEstado
            // 
            this.UcGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UcGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UcGe_BarraEstado.Location = new System.Drawing.Point(0, 434);
            this.UcGe_BarraEstado.Name = "UcGe_BarraEstado";
            this.UcGe_BarraEstado.Size = new System.Drawing.Size(1006, 26);
            this.UcGe_BarraEstado.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainerMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 405);
            this.panel1.TabIndex = 2;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.chkDevolver_toda_trans);
            this.splitContainerMain.Panel1.Controls.Add(this.txtObservacion);
            this.splitContainerMain.Panel1.Controls.Add(this.label3);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBox3);
            this.splitContainerMain.Panel1.Controls.Add(this.txtCodDev);
            this.splitContainerMain.Panel1.Controls.Add(this.ucIn_Sucursal_Bodega);
            this.splitContainerMain.Panel1.Controls.Add(this.txtidDev);
            this.splitContainerMain.Panel1.Controls.Add(this.dtpFecha);
            this.splitContainerMain.Panel1.Controls.Add(this.label2);
            this.splitContainerMain.Panel1.Controls.Add(this.label1);
            this.splitContainerMain.Panel1.Controls.Add(this.label18);
            this.splitContainerMain.Panel1.Controls.Add(this.lblAnulado);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tabControl1);
            this.splitContainerMain.Size = new System.Drawing.Size(1006, 405);
            this.splitContainerMain.SplitterDistance = 189;
            this.splitContainerMain.TabIndex = 36;
            // 
            // chkDevolver_toda_trans
            // 
            this.chkDevolver_toda_trans.AutoSize = true;
            this.chkDevolver_toda_trans.Location = new System.Drawing.Point(332, 109);
            this.chkDevolver_toda_trans.Name = "chkDevolver_toda_trans";
            this.chkDevolver_toda_trans.Size = new System.Drawing.Size(170, 17);
            this.chkDevolver_toda_trans.TabIndex = 28;
            this.chkDevolver_toda_trans.Text = "Devolver Toda la Transaccion";
            this.chkDevolver_toda_trans.UseVisualStyleBackColor = true;
            this.chkDevolver_toda_trans.CheckedChanged += new System.EventHandler(this.chkDevolver_toda_trans_CheckedChanged);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(12, 145);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(983, 41);
            this.txtObservacion.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Observacion";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtIdMovi_Inv);
            this.groupBox3.Controls.Add(this.btnBusquedaAvanza);
            this.groupBox3.Controls.Add(this.btnImportar);
            this.groupBox3.Controls.Add(this.ucIn_TipoMoviInv_Cmb);
            this.groupBox3.Location = new System.Drawing.Point(508, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 96);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar transaccion de inventario a devolver";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(288, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "#:";
            // 
            // txtIdMovi_Inv
            // 
            this.txtIdMovi_Inv.EditValue = "0";
            this.txtIdMovi_Inv.Location = new System.Drawing.Point(314, 64);
            this.txtIdMovi_Inv.Name = "txtIdMovi_Inv";
            this.txtIdMovi_Inv.Properties.Mask.EditMask = "\\d{0,10}";
            this.txtIdMovi_Inv.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtIdMovi_Inv.Size = new System.Drawing.Size(103, 20);
            this.txtIdMovi_Inv.TabIndex = 4;
            this.txtIdMovi_Inv.Tag = "F";
            this.txtIdMovi_Inv.ToolTip = "Ingrese todos los digitos de la Factura Incluyendo \r\nlos Ceros...";
            this.txtIdMovi_Inv.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // btnBusquedaAvanza
            // 
            this.btnBusquedaAvanza.ImageIndex = 0;
            this.btnBusquedaAvanza.ImageList = this.imageListIconos;
            this.btnBusquedaAvanza.Location = new System.Drawing.Point(314, 19);
            this.btnBusquedaAvanza.Name = "btnBusquedaAvanza";
            this.btnBusquedaAvanza.Size = new System.Drawing.Size(164, 24);
            this.btnBusquedaAvanza.TabIndex = 13;
            this.btnBusquedaAvanza.Text = "Busqueda Avanzada";
            this.btnBusquedaAvanza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusquedaAvanza.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanza.Click += new System.EventHandler(this.btnBusquedaAvanza_Click);
            // 
            // imageListIconos
            // 
            this.imageListIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIconos.ImageStream")));
            this.imageListIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIconos.Images.SetKeyName(0, "Buscar1_32X32.png");
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(423, 61);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(55, 23);
            this.btnImportar.TabIndex = 13;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // ucIn_TipoMoviInv_Cmb
            // 
            this.ucIn_TipoMoviInv_Cmb.Location = new System.Drawing.Point(6, 61);
            this.ucIn_TipoMoviInv_Cmb.Name = "ucIn_TipoMoviInv_Cmb";
            this.ucIn_TipoMoviInv_Cmb.Size = new System.Drawing.Size(328, 33);
            this.ucIn_TipoMoviInv_Cmb.TabIndex = 16;
            this.ucIn_TipoMoviInv_Cmb.Visible_buton_Acciones = false;
            // 
            // txtCodDev
            // 
            this.txtCodDev.Location = new System.Drawing.Point(111, 39);
            this.txtCodDev.MaxLength = 20;
            this.txtCodDev.Name = "txtCodDev";
            this.txtCodDev.Size = new System.Drawing.Size(109, 20);
            this.txtCodDev.TabIndex = 7;
            this.txtCodDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ucIn_Sucursal_Bodega
            // 
            this.ucIn_Sucursal_Bodega.Location = new System.Drawing.Point(16, 72);
            this.ucIn_Sucursal_Bodega.Name = "ucIn_Sucursal_Bodega";
            this.ucIn_Sucursal_Bodega.Size = new System.Drawing.Size(475, 54);
            this.ucIn_Sucursal_Bodega.TabIndex = 11;
            this.ucIn_Sucursal_Bodega.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.todos;
            this.ucIn_Sucursal_Bodega.Visible_cmb_bodega = false;
            // 
            // txtidDev
            // 
            this.txtidDev.Location = new System.Drawing.Point(111, 13);
            this.txtidDev.Name = "txtidDev";
            this.txtidDev.ReadOnly = true;
            this.txtidDev.Size = new System.Drawing.Size(109, 20);
            this.txtidDev.TabIndex = 8;
            this.txtidDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(905, 13);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(82, 20);
            this.dtpFecha.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cod. Devolucion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(859, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Id. Devolucion:";
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAnulado.Location = new System.Drawing.Point(260, 19);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(242, 24);
            this.lblAnulado.TabIndex = 6;
            this.lblAnulado.Text = "** Devolución Anulada **";
            this.lblAnulado.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 212);
            this.tabControl1.TabIndex = 36;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.xtraScrollableControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 186);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.gridDevolucion_det);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(3, 3);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(992, 180);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // gridDevolucion_det
            // 
            this.gridDevolucion_det.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDevolucion_det.Location = new System.Drawing.Point(0, 0);
            this.gridDevolucion_det.MainView = this.gridView_devol_inven;
            this.gridDevolucion_det.Name = "gridDevolucion_det";
            this.gridDevolucion_det.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProducto});
            this.gridDevolucion_det.Size = new System.Drawing.Size(992, 180);
            this.gridDevolucion_det.TabIndex = 0;
            this.gridDevolucion_det.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_devol_inven});
            // 
            // gridView_devol_inven
            // 
            this.gridView_devol_inven.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColCodProducto,
            this.Colnom_producto,
            this.ColCant_Inven,
            this.ColCantDevuel,
            this.ColCant_a_devol,
            this.ColIdDev_Inven,
            this.ColCosto,
            this.ColSecuencia,
            this.ColIdEmpresa_movi_inv,
            this.ColIdSucursal_movi_inv,
            this.ColIdBodega_movi_inv,
            this.ColIdMovi_inven_tipo_movi_inv,
            this.ColIdNumMovi_movi_inv,
            this.ColSecuencia_movi_inv,
            this.ColCheck,
            this.gridColumn1});
            this.gridView_devol_inven.GridControl = this.gridDevolucion_det;
            this.gridView_devol_inven.Name = "gridView_devol_inven";
            this.gridView_devol_inven.OptionsView.ShowGroupPanel = false;
            this.gridView_devol_inven.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_devol_inven_CellValueChanged);
            this.gridView_devol_inven.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_devol_inven_CellValueChanging);
            // 
            // ColCodProducto
            // 
            this.ColCodProducto.Caption = "Codigo";
            this.ColCodProducto.FieldName = "cod_producto";
            this.ColCodProducto.Name = "ColCodProducto";
            this.ColCodProducto.OptionsColumn.AllowEdit = false;
            this.ColCodProducto.Visible = true;
            this.ColCodProducto.VisibleIndex = 1;
            this.ColCodProducto.Width = 129;
            // 
            // Colnom_producto
            // 
            this.Colnom_producto.Caption = "Producto";
            this.Colnom_producto.FieldName = "nom_producto";
            this.Colnom_producto.Name = "Colnom_producto";
            this.Colnom_producto.OptionsColumn.AllowEdit = false;
            this.Colnom_producto.Visible = true;
            this.Colnom_producto.VisibleIndex = 2;
            this.Colnom_producto.Width = 431;
            // 
            // ColCant_Inven
            // 
            this.ColCant_Inven.Caption = "Cant. Egresada";
            this.ColCant_Inven.FieldName = "cantidad_egresada";
            this.ColCant_Inven.Name = "ColCant_Inven";
            this.ColCant_Inven.OptionsColumn.AllowEdit = false;
            this.ColCant_Inven.Visible = true;
            this.ColCant_Inven.VisibleIndex = 3;
            this.ColCant_Inven.Width = 149;
            // 
            // ColCantDevuel
            // 
            this.ColCantDevuel.Caption = "Cant. Devuelta";
            this.ColCantDevuel.FieldName = "cantidad_devuelta";
            this.ColCantDevuel.Name = "ColCantDevuel";
            this.ColCantDevuel.OptionsColumn.AllowEdit = false;
            this.ColCantDevuel.Visible = true;
            this.ColCantDevuel.VisibleIndex = 4;
            this.ColCantDevuel.Width = 135;
            // 
            // ColCant_a_devol
            // 
            this.ColCant_a_devol.Caption = "Cant. A Devolver";
            this.ColCant_a_devol.FieldName = "cantidad_a_devolver";
            this.ColCant_a_devol.Name = "ColCant_a_devol";
            this.ColCant_a_devol.Visible = true;
            this.ColCant_a_devol.VisibleIndex = 5;
            this.ColCant_a_devol.Width = 159;
            // 
            // ColIdDev_Inven
            // 
            this.ColIdDev_Inven.Caption = "IdDev_Inven";
            this.ColIdDev_Inven.FieldName = "IdDev_Inven";
            this.ColIdDev_Inven.Name = "ColIdDev_Inven";
            this.ColIdDev_Inven.Width = 79;
            // 
            // ColCosto
            // 
            this.ColCosto.Caption = "Costo Uni.";
            this.ColCosto.FieldName = "Costo_Inv";
            this.ColCosto.Name = "ColCosto";
            // 
            // ColSecuencia
            // 
            this.ColSecuencia.Caption = "Secuencia";
            this.ColSecuencia.FieldName = "secuencia";
            this.ColSecuencia.Name = "ColSecuencia";
            this.ColSecuencia.Width = 45;
            // 
            // ColIdEmpresa_movi_inv
            // 
            this.ColIdEmpresa_movi_inv.Caption = "IdEmpresa_movi_inv";
            this.ColIdEmpresa_movi_inv.FieldName = "IdEmpresa_movi_inv";
            this.ColIdEmpresa_movi_inv.Name = "ColIdEmpresa_movi_inv";
            this.ColIdEmpresa_movi_inv.Width = 51;
            // 
            // ColIdSucursal_movi_inv
            // 
            this.ColIdSucursal_movi_inv.Caption = "IdSucursal_movi_inv";
            this.ColIdSucursal_movi_inv.FieldName = "IdSucursal_movi_inv";
            this.ColIdSucursal_movi_inv.Name = "ColIdSucursal_movi_inv";
            this.ColIdSucursal_movi_inv.Width = 51;
            // 
            // ColIdBodega_movi_inv
            // 
            this.ColIdBodega_movi_inv.Caption = "IdBodega_movi_inv";
            this.ColIdBodega_movi_inv.FieldName = "IdBodega_movi_inv";
            this.ColIdBodega_movi_inv.Name = "ColIdBodega_movi_inv";
            this.ColIdBodega_movi_inv.Width = 51;
            // 
            // ColIdMovi_inven_tipo_movi_inv
            // 
            this.ColIdMovi_inven_tipo_movi_inv.Caption = "IdMovi_inven_tipo_movi_inv";
            this.ColIdMovi_inven_tipo_movi_inv.FieldName = "IdMovi_inven_tipo_movi_inv";
            this.ColIdMovi_inven_tipo_movi_inv.Name = "ColIdMovi_inven_tipo_movi_inv";
            this.ColIdMovi_inven_tipo_movi_inv.Width = 51;
            // 
            // ColIdNumMovi_movi_inv
            // 
            this.ColIdNumMovi_movi_inv.Caption = "IdNumMovi_movi_inv";
            this.ColIdNumMovi_movi_inv.FieldName = "IdNumMovi_movi_inv";
            this.ColIdNumMovi_movi_inv.Name = "ColIdNumMovi_movi_inv";
            this.ColIdNumMovi_movi_inv.Width = 51;
            // 
            // ColSecuencia_movi_inv
            // 
            this.ColSecuencia_movi_inv.Caption = "Secuencia_movi_inv";
            this.ColSecuencia_movi_inv.FieldName = "Secuencia_movi_inv";
            this.ColSecuencia_movi_inv.Name = "ColSecuencia_movi_inv";
            this.ColSecuencia_movi_inv.Width = 85;
            // 
            // ColCheck
            // 
            this.ColCheck.Caption = "*";
            this.ColCheck.FieldName = "Checked";
            this.ColCheck.Name = "ColCheck";
            this.ColCheck.Visible = true;
            this.ColCheck.VisibleIndex = 0;
            this.ColCheck.Width = 32;
            // 
            // cmbProducto
            // 
            this.cmbProducto.AutoHeight = false;
            this.cmbProducto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducto.DisplayMember = "pr_descripcion";
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.ValueMember = "IdProducto";
            this.cmbProducto.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Punto de cargo";
            this.gridColumn1.FieldName = "nom_punto_cargo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 145;
            // 
            // FrmIn_Devolucion_Inven_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UcGe_BarraEstado);
            this.Controls.Add(this.ucGe_Menu_Superior);
            this.Name = "FrmIn_Devolucion_Inven_Mant";
            this.Text = "FrmIn_Devolucion_Inven_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Devolucion_Inven_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_Devolucion_Inven_Mant_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdMovi_Inv.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDevolucion_det)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_devol_inven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior;
        private Controles.UCGe_BarraEstadoInferior_Forms UcGe_BarraEstado;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtCodDev;
        public System.Windows.Forms.TextBox txtidDev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private Controles.UCIn_Sucursal_Bodega ucIn_Sucursal_Bodega;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkDevolver_toda_trans;
        public DevExpress.XtraEditors.TextEdit txtIdMovi_Inv;
        private System.Windows.Forms.Button btnBusquedaAvanza;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraGrid.GridControl gridDevolucion_det;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_devol_inven;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageListIconos;
        private DevExpress.XtraGrid.Columns.GridColumn ColCodProducto;
        private DevExpress.XtraGrid.Columns.GridColumn Colnom_producto;
        private DevExpress.XtraGrid.Columns.GridColumn ColCant_Inven;
        private DevExpress.XtraGrid.Columns.GridColumn ColCantDevuel;
        private DevExpress.XtraGrid.Columns.GridColumn ColCant_a_devol;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdDev_Inven;
        private DevExpress.XtraGrid.Columns.GridColumn ColCosto;
        private DevExpress.XtraGrid.Columns.GridColumn ColSecuencia;
        private Controles.UCIn_TipoMoviInv_Cmb ucIn_TipoMoviInv_Cmb;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdEmpresa_movi_inv;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdSucursal_movi_inv;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdBodega_movi_inv;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdMovi_inven_tipo_movi_inv;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdNumMovi_movi_inv;
        private DevExpress.XtraGrid.Columns.GridColumn ColSecuencia_movi_inv;
        private DevExpress.XtraGrid.Columns.GridColumn ColCheck;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}