

namespace Core.Erp.Winform.Compras_cidersus
{
    partial class FrmCom_GeneracionOrdenCompraMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCom_GeneracionOrdenCompraMantenimiento));
            this.ChKGrabar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemPictureEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.cmbEstadoAprob = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.comCatalogoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cpproveedorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cpproveedorInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cpproveedorGridInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCodigo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.groupBoxCabecera = new System.Windows.Forms.GroupBox();
            this.ucCom_TerminoPagoCmb1 = new Core.Erp.Winform.Controles.UCCom_TerminoPagoCmb();
            this.ucCom_Comprador1 = new Core.Erp.Winform.Controles.UCCom_Comprador();
            this.label17 = new System.Windows.Forms.Label();
            this.ucCp_Proveedor1 = new Core.Erp.Winform.Controles.UCCp_Proveedor();
            this.ucGe_Sucursal_combo1 = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtPlazo = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.dTPFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumOC = new System.Windows.Forms.TextBox();
            this.txtIdOC = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.gridControlOrdenCompra = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrdenCompra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProductoCodigo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_ManejaIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_costo_promedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_precio_publico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_pedidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCantidad = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPrecio = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPorc_Descuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtporcDesc = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCod_Impuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTipoImpuesto1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_nom_impuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_IdCod_Impuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPor_Iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txeSTotal = new DevExpress.XtraEditors.TextEdit();
            this.txeSTotaliva = new DevExpress.XtraEditors.TextEdit();
            this.txeSsubtotal = new DevExpress.XtraEditors.TextEdit();
            this.txeDesc = new DevExpress.XtraEditors.TextEdit();
            this.txeIva = new DevExpress.XtraEditors.TextEdit();
            this.txeSsubtotal0 = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxGrilla = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChKGrabar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoAprob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comCatalogoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorGridInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).BeginInit();
            this.groupBoxCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlazo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdenCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductoCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtporcDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoImpuesto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeSTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeSTotaliva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeSsubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeIva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeSsubtotal0.Properties)).BeginInit();
            this.groupBoxGrilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChKGrabar
            // 
            this.ChKGrabar.AutoHeight = false;
            this.ChKGrabar.Name = "ChKGrabar";
            // 
            // repositoryItemPictureEdit3
            // 
            this.repositoryItemPictureEdit3.InitialImage = global::Core.Erp.Winform.Properties.Resources.FormEdit;
            this.repositoryItemPictureEdit3.Name = "repositoryItemPictureEdit3";
            // 
            // cmbEstadoAprob
            // 
            this.cmbEstadoAprob.AutoHeight = false;
            this.cmbEstadoAprob.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstadoAprob.DisplayMember = "descripcion";
            this.cmbEstadoAprob.Name = "cmbEstadoAprob";
            this.cmbEstadoAprob.ShowPopupShadow = false;
            this.cmbEstadoAprob.ValueMember = "Codigo";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // comCatalogoInfoBindingSource
            // 
            this.comCatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Compras.com_Catalogo_Info);
            // 
            // cpproveedorInfoBindingSource
            // 
            this.cpproveedorInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_proveedor_Info);
            // 
            // cpproveedorInfoBindingSource1
            // 
            this.cpproveedorInfoBindingSource1.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_proveedor_Info);
            // 
            // cpproveedorGridInfoBindingSource
            // 
            this.cpproveedorGridInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_proveedor_Info);
            // 
            // colCodigo1
            // 
            this.colCodigo1.Caption = "Codigo";
            this.colCodigo1.FieldName = "Codigo";
            this.colCodigo1.Name = "colCodigo1";
            this.colCodigo1.Visible = true;
            this.colCodigo1.VisibleIndex = 0;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "buscar.jpg");
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
            // groupBoxCabecera
            // 
            this.groupBoxCabecera.Controls.Add(this.ucCom_TerminoPagoCmb1);
            this.groupBoxCabecera.Controls.Add(this.ucCom_Comprador1);
            this.groupBoxCabecera.Controls.Add(this.label17);
            this.groupBoxCabecera.Controls.Add(this.ucCp_Proveedor1);
            this.groupBoxCabecera.Controls.Add(this.ucGe_Sucursal_combo1);
            this.groupBoxCabecera.Controls.Add(this.label21);
            this.groupBoxCabecera.Controls.Add(this.dtpFechaEntrega);
            this.groupBoxCabecera.Controls.Add(this.txtPlazo);
            this.groupBoxCabecera.Controls.Add(this.label14);
            this.groupBoxCabecera.Controls.Add(this.dTPFecha);
            this.groupBoxCabecera.Controls.Add(this.label5);
            this.groupBoxCabecera.Controls.Add(this.label4);
            this.groupBoxCabecera.Controls.Add(this.label8);
            this.groupBoxCabecera.Controls.Add(this.label7);
            this.groupBoxCabecera.Controls.Add(this.label2);
            this.groupBoxCabecera.Controls.Add(this.label6);
            this.groupBoxCabecera.Controls.Add(this.label1);
            this.groupBoxCabecera.Controls.Add(this.txtNumOC);
            this.groupBoxCabecera.Controls.Add(this.txtIdOC);
            this.groupBoxCabecera.Controls.Add(this.txtObservacion);
            this.groupBoxCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCabecera.Location = new System.Drawing.Point(0, 27);
            this.groupBoxCabecera.Name = "groupBoxCabecera";
            this.groupBoxCabecera.Size = new System.Drawing.Size(1088, 111);
            this.groupBoxCabecera.TabIndex = 3;
            this.groupBoxCabecera.TabStop = false;
            this.groupBoxCabecera.Text = "Datos de la Orden de Compra:";
            // 
            // ucCom_TerminoPagoCmb1
            // 
            this.ucCom_TerminoPagoCmb1.Location = new System.Drawing.Point(841, 12);
            this.ucCom_TerminoPagoCmb1.Name = "ucCom_TerminoPagoCmb1";
            this.ucCom_TerminoPagoCmb1.Size = new System.Drawing.Size(225, 28);
            this.ucCom_TerminoPagoCmb1.TabIndex = 124;
            // 
            // ucCom_Comprador1
            // 
            this.ucCom_Comprador1.Location = new System.Drawing.Point(841, 68);
            this.ucCom_Comprador1.Name = "ucCom_Comprador1";
            this.ucCom_Comprador1.Size = new System.Drawing.Size(189, 26);
            this.ucCom_Comprador1.TabIndex = 122;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(753, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 121;
            this.label17.Text = "Comprador:";
            // 
            // ucCp_Proveedor1
            // 
            this.ucCp_Proveedor1.Location = new System.Drawing.Point(76, 42);
            this.ucCp_Proveedor1.Name = "ucCp_Proveedor1";
            this.ucCp_Proveedor1.Size = new System.Drawing.Size(293, 32);
            this.ucCp_Proveedor1.TabIndex = 119;
            // 
            // ucGe_Sucursal_combo1
            // 
            this.ucGe_Sucursal_combo1.Location = new System.Drawing.Point(449, 18);
            this.ucGe_Sucursal_combo1.Name = "ucGe_Sucursal_combo1";
            this.ucGe_Sucursal_combo1.Size = new System.Drawing.Size(287, 22);
            this.ucGe_Sucursal_combo1.TabIndex = 118;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(563, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 13);
            this.label21.TabIndex = 113;
            this.label21.Text = "Fecha Entrega:";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(641, 46);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaEntrega.TabIndex = 112;
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(841, 42);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Properties.Mask.EditMask = "###0 ds";
            this.txtPlazo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPlazo.Size = new System.Drawing.Size(189, 20);
            this.txtPlazo.TabIndex = 100;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 92;
            this.label14.Text = "Observacion:";
            // 
            // dTPFecha
            // 
            this.dTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPFecha.Location = new System.Drawing.Point(449, 46);
            this.dTPFecha.Name = "dTPFecha";
            this.dTPFecha.Size = new System.Drawing.Size(108, 20);
            this.dTPFecha.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Fecha O/C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(751, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Plazo O/C:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Sucursal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Termino de Pago:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "# O/C:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "#Reg:";
            // 
            // txtNumOC
            // 
            this.txtNumOC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNumOC.Location = new System.Drawing.Point(202, 20);
            this.txtNumOC.MaxLength = 50;
            this.txtNumOC.Name = "txtNumOC";
            this.txtNumOC.Size = new System.Drawing.Size(167, 20);
            this.txtNumOC.TabIndex = 1;
            // 
            // txtIdOC
            // 
            this.txtIdOC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIdOC.Location = new System.Drawing.Point(82, 20);
            this.txtIdOC.Name = "txtIdOC";
            this.txtIdOC.ReadOnly = true;
            this.txtIdOC.Size = new System.Drawing.Size(67, 20);
            this.txtIdOC.TabIndex = 1;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(80, 75);
            this.txtObservacion.MaxLength = 1000;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(660, 27);
            this.txtObservacion.TabIndex = 93;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1088, 27);
            this.ucGe_Menu.TabIndex = 4;
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
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            this.ucGe_Menu.event_btnAceptar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAceptar_Click(this.ucGe_Menu_event_btnAceptar_Click);
            // 
            // gridControlOrdenCompra
            // 
            this.gridControlOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrdenCompra.Location = new System.Drawing.Point(3, 16);
            this.gridControlOrdenCompra.MainView = this.gridViewOrdenCompra;
            this.gridControlOrdenCompra.Name = "gridControlOrdenCompra";
            this.gridControlOrdenCompra.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProductoCodigo,
            this.txtCantidad,
            this.txtPrecio,
            this.txtporcDesc,
            this.repositoryItemCheckEdit1,
            this.cmbTipoImpuesto1});
            this.gridControlOrdenCompra.Size = new System.Drawing.Size(1082, 360);
            this.gridControlOrdenCompra.TabIndex = 1;
            this.gridControlOrdenCompra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrdenCompra,
            this.gridView1});
            this.gridControlOrdenCompra.Click += new System.EventHandler(this.gridControlOrdenCompra_Click);
            // 
            // gridViewOrdenCompra
            // 
            this.gridViewOrdenCompra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo_Producto,
            this.colPeso,
            this.colCantidad,
            this.colPrecio,
            this.colPorc_Descuento,
            this.colDescuento,
            this.colPrecioFinal,
            this.colSubtotal,
            this.colIva,
            this.colTotal,
            this.colIdCod_Impuesto,
            this.colPor_Iva});
            this.gridViewOrdenCompra.GridControl = this.gridControlOrdenCompra;
            this.gridViewOrdenCompra.Name = "gridViewOrdenCompra";
            this.gridViewOrdenCompra.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewOrdenCompra.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewOrdenCompra_CellValueChanged);
            this.gridViewOrdenCompra.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewOrdenCompra_CellValueChanging);
            this.gridViewOrdenCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewOrdenCompra_KeyDown);
            // 
            // colCodigo_Producto
            // 
            this.colCodigo_Producto.Caption = "Item";
            this.colCodigo_Producto.ColumnEdit = this.cmbProductoCodigo;
            this.colCodigo_Producto.FieldName = "IdProducto";
            this.colCodigo_Producto.Name = "colCodigo_Producto";
            this.colCodigo_Producto.OptionsColumn.AllowSize = false;
            this.colCodigo_Producto.Visible = true;
            this.colCodigo_Producto.VisibleIndex = 0;
            this.colCodigo_Producto.Width = 164;
            // 
            // cmbProductoCodigo
            // 
            this.cmbProductoCodigo.AutoHeight = false;
            this.cmbProductoCodigo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbProductoCodigo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProductoCodigo.DisplayMember = "pr_descripcion";
            this.cmbProductoCodigo.Name = "cmbProductoCodigo";
            this.cmbProductoCodigo.ValueMember = "IdProducto";
            this.cmbProductoCodigo.View = this.repositoryItemSearchLookUpEdit1View;
            this.cmbProductoCodigo.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cmbProductoCodigo_EditValueChanging);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdProducto1,
            this.colpr_stock,
            this.colpr_codigo,
            this.colpr_ManejaIva,
            this.colpr_peso,
            this.colpr_costo_promedio,
            this.colpr_precio_publico,
            this.colpr_pedidos,
            this.colDisponible,
            this.colpr_descripcion1});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            // colIdProducto1
            // 
            this.colIdProducto1.FieldName = "IdProducto";
            this.colIdProducto1.Name = "colIdProducto1";
            // 
            // colpr_stock
            // 
            this.colpr_stock.Caption = "Stock";
            this.colpr_stock.FieldName = "pr_stock";
            this.colpr_stock.Name = "colpr_stock";
            this.colpr_stock.Visible = true;
            this.colpr_stock.VisibleIndex = 6;
            this.colpr_stock.Width = 124;
            // 
            // colpr_codigo
            // 
            this.colpr_codigo.Caption = "Código Producto";
            this.colpr_codigo.FieldName = "pr_codigo";
            this.colpr_codigo.Name = "colpr_codigo";
            this.colpr_codigo.Visible = true;
            this.colpr_codigo.VisibleIndex = 0;
            this.colpr_codigo.Width = 117;
            // 
            // colpr_ManejaIva
            // 
            this.colpr_ManejaIva.Caption = "Maneja Iva";
            this.colpr_ManejaIva.FieldName = "pr_ManejaIva";
            this.colpr_ManejaIva.Name = "colpr_ManejaIva";
            this.colpr_ManejaIva.Visible = true;
            this.colpr_ManejaIva.VisibleIndex = 8;
            this.colpr_ManejaIva.Width = 140;
            // 
            // colpr_peso
            // 
            this.colpr_peso.Caption = "Peso";
            this.colpr_peso.FieldName = "pr_peso";
            this.colpr_peso.Name = "colpr_peso";
            this.colpr_peso.Visible = true;
            this.colpr_peso.VisibleIndex = 4;
            this.colpr_peso.Width = 124;
            // 
            // colpr_costo_promedio
            // 
            this.colpr_costo_promedio.Caption = "Costo Promedio";
            this.colpr_costo_promedio.FieldName = "pr_costo_promedio";
            this.colpr_costo_promedio.Name = "colpr_costo_promedio";
            this.colpr_costo_promedio.Visible = true;
            this.colpr_costo_promedio.VisibleIndex = 7;
            this.colpr_costo_promedio.Width = 124;
            // 
            // colpr_precio_publico
            // 
            this.colpr_precio_publico.Caption = "Precio Público";
            this.colpr_precio_publico.FieldName = "pr_precio_publico";
            this.colpr_precio_publico.Name = "colpr_precio_publico";
            this.colpr_precio_publico.Visible = true;
            this.colpr_precio_publico.VisibleIndex = 5;
            this.colpr_precio_publico.Width = 124;
            // 
            // colpr_pedidos
            // 
            this.colpr_pedidos.Caption = "Pedidos";
            this.colpr_pedidos.FieldName = "pr_pedidos";
            this.colpr_pedidos.Name = "colpr_pedidos";
            this.colpr_pedidos.Visible = true;
            this.colpr_pedidos.VisibleIndex = 3;
            this.colpr_pedidos.Width = 124;
            // 
            // colDisponible
            // 
            this.colDisponible.Caption = "Disponibles";
            this.colDisponible.FieldName = "Disponible";
            this.colDisponible.Name = "colDisponible";
            this.colDisponible.Visible = true;
            this.colDisponible.VisibleIndex = 2;
            this.colDisponible.Width = 130;
            // 
            // colpr_descripcion1
            // 
            this.colpr_descripcion1.Caption = "Descripción";
            this.colpr_descripcion1.FieldName = "pr_descripcion";
            this.colpr_descripcion1.Name = "colpr_descripcion1";
            this.colpr_descripcion1.Visible = true;
            this.colpr_descripcion1.VisibleIndex = 1;
            this.colpr_descripcion1.Width = 173;
            // 
            // colPeso
            // 
            this.colPeso.Caption = "Peso";
            this.colPeso.FieldName = "do_peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.OptionsColumn.AllowEdit = false;
            this.colPeso.Visible = true;
            this.colPeso.VisibleIndex = 1;
            this.colPeso.Width = 49;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.ColumnEdit = this.txtCantidad;
            this.colCantidad.FieldName = "do_Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 2;
            this.colCantidad.Width = 54;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoHeight = false;
            this.txtCantidad.Mask.EditMask = "f";
            this.txtCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCantidad.Mask.ShowPlaceHolders = false;
            this.txtCantidad.Name = "txtCantidad";
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "Precio";
            this.colPrecio.ColumnEdit = this.txtPrecio;
            this.colPrecio.FieldName = "do_precioCompra";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 3;
            this.colPrecio.Width = 40;
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoHeight = false;
            this.txtPrecio.Mask.EditMask = "$ #,#######0.000000;$ #,#######0.000000";
            this.txtPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecio.Name = "txtPrecio";
            // 
            // colPorc_Descuento
            // 
            this.colPorc_Descuento.Caption = "% Desc.";
            this.colPorc_Descuento.ColumnEdit = this.txtporcDesc;
            this.colPorc_Descuento.FieldName = "do_porc_des";
            this.colPorc_Descuento.Name = "colPorc_Descuento";
            this.colPorc_Descuento.Visible = true;
            this.colPorc_Descuento.VisibleIndex = 4;
            this.colPorc_Descuento.Width = 40;
            // 
            // txtporcDesc
            // 
            this.txtporcDesc.AutoHeight = false;
            this.txtporcDesc.Mask.EditMask = "C";
            this.txtporcDesc.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtporcDesc.Name = "txtporcDesc";
            // 
            // colDescuento
            // 
            this.colDescuento.FieldName = "do_descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.OptionsColumn.AllowEdit = false;
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 5;
            this.colDescuento.Width = 40;
            // 
            // colPrecioFinal
            // 
            this.colPrecioFinal.Caption = "Precio Final";
            this.colPrecioFinal.FieldName = "do_precioFinal";
            this.colPrecioFinal.Name = "colPrecioFinal";
            this.colPrecioFinal.OptionsColumn.AllowEdit = false;
            this.colPrecioFinal.Visible = true;
            this.colPrecioFinal.VisibleIndex = 6;
            this.colPrecioFinal.Width = 40;
            // 
            // colSubtotal
            // 
            this.colSubtotal.Caption = "SubTotal";
            this.colSubtotal.FieldName = "do_subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.OptionsColumn.AllowEdit = false;
            this.colSubtotal.Visible = true;
            this.colSubtotal.VisibleIndex = 7;
            this.colSubtotal.Width = 40;
            // 
            // colIva
            // 
            this.colIva.Caption = "$Imp";
            this.colIva.FieldName = "do_iva";
            this.colIva.Name = "colIva";
            this.colIva.OptionsColumn.AllowEdit = false;
            this.colIva.Visible = true;
            this.colIva.VisibleIndex = 8;
            this.colIva.Width = 40;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.FieldName = "do_total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 9;
            this.colTotal.Width = 40;
            // 
            // colIdCod_Impuesto
            // 
            this.colIdCod_Impuesto.Caption = "%Imp.";
            this.colIdCod_Impuesto.ColumnEdit = this.cmbTipoImpuesto1;
            this.colIdCod_Impuesto.FieldName = "IdCod_Impuesto";
            this.colIdCod_Impuesto.Name = "colIdCod_Impuesto";
            this.colIdCod_Impuesto.Visible = true;
            this.colIdCod_Impuesto.VisibleIndex = 10;
            this.colIdCod_Impuesto.Width = 40;
            // 
            // cmbTipoImpuesto1
            // 
            this.cmbTipoImpuesto1.AutoHeight = false;
            this.cmbTipoImpuesto1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoImpuesto1.Name = "cmbTipoImpuesto1";
            this.cmbTipoImpuesto1.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_nom_impuesto,
            this.Col_IdCod_Impuesto});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // Col_nom_impuesto
            // 
            this.Col_nom_impuesto.Caption = "Impuesto";
            this.Col_nom_impuesto.FieldName = "nom_impuesto";
            this.Col_nom_impuesto.Name = "Col_nom_impuesto";
            this.Col_nom_impuesto.Visible = true;
            this.Col_nom_impuesto.VisibleIndex = 1;
            this.Col_nom_impuesto.Width = 898;
            // 
            // Col_IdCod_Impuesto
            // 
            this.Col_IdCod_Impuesto.Caption = "Cod Imp";
            this.Col_IdCod_Impuesto.FieldName = "IdCod_Impuesto";
            this.Col_IdCod_Impuesto.Name = "Col_IdCod_Impuesto";
            this.Col_IdCod_Impuesto.Visible = true;
            this.Col_IdCod_Impuesto.VisibleIndex = 0;
            this.Col_IdCod_Impuesto.Width = 456;
            // 
            // colPor_Iva
            // 
            this.colPor_Iva.Caption = "%Imp";
            this.colPor_Iva.FieldName = "Por_Iva";
            this.colPor_Iva.Name = "colPor_Iva";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlOrdenCompra;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txeSTotal);
            this.groupBox3.Controls.Add(this.txeSTotaliva);
            this.groupBox3.Controls.Add(this.txeSsubtotal);
            this.groupBox3.Controls.Add(this.txeDesc);
            this.groupBox3.Controls.Add(this.txeIva);
            this.groupBox3.Controls.Add(this.txeSsubtotal0);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 517);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1088, 85);
            this.groupBox3.TabIndex = 122;
            this.groupBox3.TabStop = false;
            // 
            // txeSTotal
            // 
            this.txeSTotal.Location = new System.Drawing.Point(841, 49);
            this.txeSTotal.Name = "txeSTotal";
            this.txeSTotal.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeSTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeSTotal.Properties.ReadOnly = true;
            this.txeSTotal.Size = new System.Drawing.Size(145, 20);
            this.txeSTotal.TabIndex = 123;
            // 
            // txeSTotaliva
            // 
            this.txeSTotaliva.Location = new System.Drawing.Point(841, 20);
            this.txeSTotaliva.Name = "txeSTotaliva";
            this.txeSTotaliva.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeSTotaliva.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeSTotaliva.Properties.ReadOnly = true;
            this.txeSTotaliva.Size = new System.Drawing.Size(145, 20);
            this.txeSTotaliva.TabIndex = 122;
            // 
            // txeSsubtotal
            // 
            this.txeSsubtotal.Location = new System.Drawing.Point(535, 51);
            this.txeSsubtotal.Name = "txeSsubtotal";
            this.txeSsubtotal.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeSsubtotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeSsubtotal.Properties.ReadOnly = true;
            this.txeSsubtotal.Size = new System.Drawing.Size(147, 20);
            this.txeSsubtotal.TabIndex = 121;
            // 
            // txeDesc
            // 
            this.txeDesc.Location = new System.Drawing.Point(535, 22);
            this.txeDesc.Name = "txeDesc";
            this.txeDesc.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeDesc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeDesc.Properties.ReadOnly = true;
            this.txeDesc.Size = new System.Drawing.Size(147, 20);
            this.txeDesc.TabIndex = 120;
            // 
            // txeIva
            // 
            this.txeIva.Location = new System.Drawing.Point(158, 50);
            this.txeIva.Name = "txeIva";
            this.txeIva.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeIva.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeIva.Size = new System.Drawing.Size(145, 20);
            this.txeIva.TabIndex = 119;
            // 
            // txeSsubtotal0
            // 
            this.txeSsubtotal0.Location = new System.Drawing.Point(158, 21);
            this.txeSsubtotal0.Name = "txeSsubtotal0";
            this.txeSsubtotal0.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeSsubtotal0.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeSsubtotal0.Properties.ReadOnly = true;
            this.txeSsubtotal0.Size = new System.Drawing.Size(145, 20);
            this.txeSsubtotal0.TabIndex = 118;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(430, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 16);
            this.label15.TabIndex = 91;
            this.label15.Text = "Subtotal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 91;
            this.label11.Text = "Subtotal 0%:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(738, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 91;
            this.label12.Text = "Total IVA:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(738, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 91;
            this.label13.Text = "TOTAL:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 91;
            this.label10.Text = "Subtotal IVA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(405, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 16);
            this.label9.TabIndex = 91;
            this.label9.Text = "Total descuento:";
            // 
            // groupBoxGrilla
            // 
            this.groupBoxGrilla.Controls.Add(this.gridControlOrdenCompra);
            this.groupBoxGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGrilla.Location = new System.Drawing.Point(0, 138);
            this.groupBoxGrilla.Name = "groupBoxGrilla";
            this.groupBoxGrilla.Size = new System.Drawing.Size(1088, 379);
            this.groupBoxGrilla.TabIndex = 123;
            this.groupBoxGrilla.TabStop = false;
            this.groupBoxGrilla.Text = "Listados de Productos";
            // 
            // FrmCom_GeneracionOrdenCompraMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 602);
            this.Controls.Add(this.groupBoxGrilla);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxCabecera);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmCom_GeneracionOrdenCompraMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Compra";
            this.Load += new System.EventHandler(this.FrmCom_GeneracionOrdenCompraMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChKGrabar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoAprob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comCatalogoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorGridInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).EndInit();
            this.groupBoxCabecera.ResumeLayout(false);
            this.groupBoxCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlazo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdenCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductoCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtporcDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoImpuesto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeSTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeSTotaliva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeSsubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeIva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeSsubtotal0.Properties)).EndInit();
            this.groupBoxGrilla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource cpproveedorGridInfoBindingSource;
        private System.Windows.Forms.BindingSource comCatalogoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private System.Windows.Forms.BindingSource cpproveedorInfoBindingSource;
        private System.Windows.Forms.BindingSource cpproveedorInfoBindingSource1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ChKGrabar;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cmbEstadoAprob;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.GroupBox groupBoxCabecera;
        private Controles.UCCp_Proveedor ucCp_Proveedor1;
        private Controles.UCGe_Sucursal_combo ucGe_Sucursal_combo1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private DevExpress.XtraEditors.TextEdit txtPlazo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dTPFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumOC;
        private System.Windows.Forms.TextBox txtIdOC;
        private System.Windows.Forms.TextBox txtObservacion;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraGrid.GridControl gridControlOrdenCompra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo_Producto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProductoCodigo;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_stock;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_ManejaIva;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_peso;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_costo_promedio;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_precio_publico;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_pedidos;
        private DevExpress.XtraGrid.Columns.GridColumn colDisponible;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colPeso;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colPorc_Descuento;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtporcDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioFinal;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIva;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCod_Impuesto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.TextEdit txeSTotal;
        private DevExpress.XtraEditors.TextEdit txeSTotaliva;
        private DevExpress.XtraEditors.TextEdit txeSsubtotal;
        private DevExpress.XtraEditors.TextEdit txeDesc;
        private DevExpress.XtraEditors.TextEdit txeIva;
        private DevExpress.XtraEditors.TextEdit txeSsubtotal0;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxGrilla;
        private Controles.UCCom_Comprador ucCom_Comprador1;
        private System.Windows.Forms.Label label17;
        private Controles.UCCom_TerminoPagoCmb ucCom_TerminoPagoCmb1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbTipoImpuesto1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Col_nom_impuesto;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdCod_Impuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colPor_Iva;

    }
}