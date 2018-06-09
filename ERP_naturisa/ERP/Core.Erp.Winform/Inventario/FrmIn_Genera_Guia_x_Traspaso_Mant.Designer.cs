namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Genera_Guia_x_Traspaso_Mant
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
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cmbTrasnportador = new Core.Erp.Winform.Controles.UCGe_Transportista_Cmb();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDirPuntoLlega = new System.Windows.Forms.TextBox();
            this.txtDirPuntoPart = new System.Windows.Forms.TextBox();
            this.cmbPuntoLlega = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSucursal_llega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion2_llega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado_llega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPuntoPartida = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSucursal_part = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion2_part = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado_part = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNumGuia = new System.Windows.Forms.TextBox();
            this.txtIdGuia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbx_Fechas = new System.Windows.Forms.GroupBox();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.timeHoraLlegada = new DevExpress.XtraEditors.TimeEdit();
            this.timeHoraTraslado = new DevExpress.XtraEditors.TimeEdit();
            this.dtpFechaLlega = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaTras = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.cmbMotivoTras = new Core.Erp.Winform.Controles.UCIn_Catalogos_Cmb();
            this.label10 = new System.Windows.Forms.Label();
            this.ucGe_Doc_talo_x_Guia = new Core.Erp.Winform.Controles.UCGe_NumeroDocTrans();
            this.txtNumOC_Quitar = new DevExpress.XtraEditors.TextEdit();
            this.btnQuitarOC = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlConOrdComp = new DevExpress.XtraGrid.GridControl();
            this.gridViewConOrdComp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdOrdenCompra_OC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCant_Pedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad_enviar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo_Aux = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlSinOrdComp = new DevExpress.XtraGrid.GridControl();
            this.gridViewSinOrdComp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNum_Fact_sin_oc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor_sin_oc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProveedor_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProveedor_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_nombre_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_Estado_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto_sin_oc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProducto_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_stock_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad_enviar_sin_oc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion_sin_oc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar_OC = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_num_registros_sin_OC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_num_registros_con_OC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuntoLlega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuntoPartida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.gbx_Fechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeHoraLlegada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeHoraTraslado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumOC_Quitar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConOrdComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConOrdComp)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSinOrdComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSinOrdComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_registros_sin_OC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_registros_con_OC.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Superior_Mant1
            // 
            this.ucGe_Menu_Superior_Mant1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant1.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(1064, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btn_Generar_XML_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btn_Generar_XML_Click(this.ucGe_Menu_Superior_Mant1_event_btn_Generar_XML_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1064, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cmbTrasnportador
            // 
            this.cmbTrasnportador.Location = new System.Drawing.Point(134, 140);
            this.cmbTrasnportador.Name = "cmbTrasnportador";
            this.cmbTrasnportador.Size = new System.Drawing.Size(329, 27);
            this.cmbTrasnportador.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Transportador:";
            // 
            // txtDirPuntoLlega
            // 
            this.txtDirPuntoLlega.Location = new System.Drawing.Point(142, 118);
            this.txtDirPuntoLlega.Name = "txtDirPuntoLlega";
            this.txtDirPuntoLlega.Size = new System.Drawing.Size(274, 20);
            this.txtDirPuntoLlega.TabIndex = 20;
            // 
            // txtDirPuntoPart
            // 
            this.txtDirPuntoPart.Location = new System.Drawing.Point(142, 63);
            this.txtDirPuntoPart.Name = "txtDirPuntoPart";
            this.txtDirPuntoPart.Size = new System.Drawing.Size(274, 20);
            this.txtDirPuntoPart.TabIndex = 19;
            // 
            // cmbPuntoLlega
            // 
            this.cmbPuntoLlega.Location = new System.Drawing.Point(142, 89);
            this.cmbPuntoLlega.Name = "cmbPuntoLlega";
            this.cmbPuntoLlega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPuntoLlega.Properties.DisplayMember = "Su_Descripcion2";
            this.cmbPuntoLlega.Properties.ValueMember = "IdSucursal";
            this.cmbPuntoLlega.Properties.View = this.gridView1;
            this.cmbPuntoLlega.Size = new System.Drawing.Size(274, 20);
            this.cmbPuntoLlega.TabIndex = 18;
            this.cmbPuntoLlega.EditValueChanged += new System.EventHandler(this.cmbPuntoLlega_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSucursal_llega,
            this.colSu_Descripcion2_llega,
            this.colEstado_llega});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSucursal_llega
            // 
            this.colIdSucursal_llega.Caption = "Código";
            this.colIdSucursal_llega.FieldName = "IdSucursal";
            this.colIdSucursal_llega.Name = "colIdSucursal_llega";
            this.colIdSucursal_llega.Visible = true;
            this.colIdSucursal_llega.VisibleIndex = 1;
            this.colIdSucursal_llega.Width = 204;
            // 
            // colSu_Descripcion2_llega
            // 
            this.colSu_Descripcion2_llega.Caption = "Descripción";
            this.colSu_Descripcion2_llega.FieldName = "Su_Descripcion2";
            this.colSu_Descripcion2_llega.Name = "colSu_Descripcion2_llega";
            this.colSu_Descripcion2_llega.Visible = true;
            this.colSu_Descripcion2_llega.VisibleIndex = 0;
            this.colSu_Descripcion2_llega.Width = 771;
            // 
            // colEstado_llega
            // 
            this.colEstado_llega.Caption = "Estado";
            this.colEstado_llega.FieldName = "Estado";
            this.colEstado_llega.Name = "colEstado_llega";
            this.colEstado_llega.Visible = true;
            this.colEstado_llega.VisibleIndex = 2;
            this.colEstado_llega.Width = 205;
            // 
            // cmbPuntoPartida
            // 
            this.cmbPuntoPartida.Location = new System.Drawing.Point(144, 39);
            this.cmbPuntoPartida.Name = "cmbPuntoPartida";
            this.cmbPuntoPartida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPuntoPartida.Properties.DisplayMember = "Su_Descripcion2";
            this.cmbPuntoPartida.Properties.ValueMember = "IdSucursal";
            this.cmbPuntoPartida.Properties.View = this.searchLookUpEdit1View;
            this.cmbPuntoPartida.Size = new System.Drawing.Size(272, 20);
            this.cmbPuntoPartida.TabIndex = 17;
            this.cmbPuntoPartida.EditValueChanged += new System.EventHandler(this.cmbPuntoPartida_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSucursal_part,
            this.colSu_Descripcion2_part,
            this.colEstado_part});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSucursal_part
            // 
            this.colIdSucursal_part.Caption = "Código";
            this.colIdSucursal_part.FieldName = "IdSucursal";
            this.colIdSucursal_part.Name = "colIdSucursal_part";
            this.colIdSucursal_part.Visible = true;
            this.colIdSucursal_part.VisibleIndex = 1;
            this.colIdSucursal_part.Width = 207;
            // 
            // colSu_Descripcion2_part
            // 
            this.colSu_Descripcion2_part.Caption = "Descripción";
            this.colSu_Descripcion2_part.FieldName = "Su_Descripcion2";
            this.colSu_Descripcion2_part.Name = "colSu_Descripcion2_part";
            this.colSu_Descripcion2_part.Visible = true;
            this.colSu_Descripcion2_part.VisibleIndex = 0;
            this.colSu_Descripcion2_part.Width = 764;
            // 
            // colEstado_part
            // 
            this.colEstado_part.Caption = "Estado";
            this.colEstado_part.FieldName = "Estado";
            this.colEstado_part.Name = "colEstado_part";
            this.colEstado_part.Visible = true;
            this.colEstado_part.VisibleIndex = 2;
            this.colEstado_part.Width = 209;
            // 
            // txtNumGuia
            // 
            this.txtNumGuia.Location = new System.Drawing.Point(316, 14);
            this.txtNumGuia.Name = "txtNumGuia";
            this.txtNumGuia.Size = new System.Drawing.Size(100, 20);
            this.txtNumGuia.TabIndex = 16;
            // 
            // txtIdGuia
            // 
            this.txtIdGuia.Location = new System.Drawing.Point(144, 12);
            this.txtIdGuia.Name = "txtIdGuia";
            this.txtIdGuia.Size = new System.Drawing.Size(100, 20);
            this.txtIdGuia.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "IdGuía:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dirección Punto Llegada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Punto de Llegada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dirección Punto Partida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Punto de Partida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "# Guía:";
            // 
            // gbx_Fechas
            // 
            this.gbx_Fechas.Controls.Add(this.lblAnulado);
            this.gbx_Fechas.Controls.Add(this.timeHoraLlegada);
            this.gbx_Fechas.Controls.Add(this.timeHoraTraslado);
            this.gbx_Fechas.Controls.Add(this.dtpFechaLlega);
            this.gbx_Fechas.Controls.Add(this.dtpFechaTras);
            this.gbx_Fechas.Controls.Add(this.dtpFecha);
            this.gbx_Fechas.Controls.Add(this.label6);
            this.gbx_Fechas.Controls.Add(this.label7);
            this.gbx_Fechas.Controls.Add(this.label8);
            this.gbx_Fechas.Controls.Add(this.shapeContainer1);
            this.gbx_Fechas.Location = new System.Drawing.Point(5, 8);
            this.gbx_Fechas.Name = "gbx_Fechas";
            this.gbx_Fechas.Size = new System.Drawing.Size(487, 81);
            this.gbx_Fechas.TabIndex = 0;
            this.gbx_Fechas.TabStop = false;
            this.gbx_Fechas.Text = "Fechas:";
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(16, 44);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(117, 20);
            this.lblAnulado.TabIndex = 1;
            this.lblAnulado.Text = "***Anulado***";
            this.lblAnulado.Visible = false;
            // 
            // timeHoraLlegada
            // 
            this.timeHoraLlegada.EditValue = new System.DateTime(2015, 12, 1, 0, 0, 0, 0);
            this.timeHoraLlegada.Location = new System.Drawing.Point(375, 53);
            this.timeHoraLlegada.Name = "timeHoraLlegada";
            this.timeHoraLlegada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeHoraLlegada.Size = new System.Drawing.Size(100, 20);
            this.timeHoraLlegada.TabIndex = 12;
            // 
            // timeHoraTraslado
            // 
            this.timeHoraTraslado.EditValue = new System.DateTime(2015, 12, 1, 0, 0, 0, 0);
            this.timeHoraTraslado.Location = new System.Drawing.Point(375, 16);
            this.timeHoraTraslado.Name = "timeHoraTraslado";
            this.timeHoraTraslado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeHoraTraslado.Size = new System.Drawing.Size(100, 20);
            this.timeHoraTraslado.TabIndex = 11;
            // 
            // dtpFechaLlega
            // 
            this.dtpFechaLlega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLlega.Location = new System.Drawing.Point(279, 53);
            this.dtpFechaLlega.Name = "dtpFechaLlega";
            this.dtpFechaLlega.Size = new System.Drawing.Size(90, 20);
            this.dtpFechaLlega.TabIndex = 10;
            // 
            // dtpFechaTras
            // 
            this.dtpFechaTras.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTras.Location = new System.Drawing.Point(288, 16);
            this.dtpFechaTras.Name = "dtpFechaTras";
            this.dtpFechaTras.Size = new System.Drawing.Size(81, 20);
            this.dtpFechaTras.TabIndex = 9;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(52, 13);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(81, 20);
            this.dtpFecha.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha y Hora de Traslado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha y Hora de Llegada:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(481, 62);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 151;
            this.lineShape1.X2 = 478;
            this.lineShape1.Y1 = 23;
            this.lineShape1.Y2 = 23;
            // 
            // cmbMotivoTras
            // 
            this.cmbMotivoTras.Location = new System.Drawing.Point(110, 95);
            this.cmbMotivoTras.Name = "cmbMotivoTras";
            this.cmbMotivoTras.Size = new System.Drawing.Size(323, 29);
            this.cmbMotivoTras.TabIndex = 19;
            this.cmbMotivoTras.Visible_btn_acciones = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Motivo del Traslado:";
            // 
            // ucGe_Doc_talo_x_Guia
            // 
            this.ucGe_Doc_talo_x_Guia.IdEstablecimiento = null;
            this.ucGe_Doc_talo_x_Guia.IdPuntoEmision = null;
            this.ucGe_Doc_talo_x_Guia.IdTipoDocumento = Core.Erp.Info.General.Cl_Enumeradores.eTipoDocumento_Talonario.GUIA;
            this.ucGe_Doc_talo_x_Guia.Location = new System.Drawing.Point(14, 130);
            this.ucGe_Doc_talo_x_Guia.Name = "ucGe_Doc_talo_x_Guia";
            this.ucGe_Doc_talo_x_Guia.Size = new System.Drawing.Size(378, 46);
            this.ucGe_Doc_talo_x_Guia.TabIndex = 0;
            // 
            // txtNumOC_Quitar
            // 
            this.txtNumOC_Quitar.Location = new System.Drawing.Point(127, 184);
            this.txtNumOC_Quitar.Name = "txtNumOC_Quitar";
            this.txtNumOC_Quitar.Properties.Mask.EditMask = "d";
            this.txtNumOC_Quitar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNumOC_Quitar.Size = new System.Drawing.Size(100, 20);
            this.txtNumOC_Quitar.TabIndex = 2;
            // 
            // btnQuitarOC
            // 
            this.btnQuitarOC.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnQuitarOC.Location = new System.Drawing.Point(19, 182);
            this.btnQuitarOC.Name = "btnQuitarOC";
            this.btnQuitarOC.Size = new System.Drawing.Size(89, 23);
            this.btnQuitarOC.TabIndex = 1;
            this.btnQuitarOC.Text = "Quitar O/C #:";
            this.btnQuitarOC.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1064, 404);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControlConOrdComp);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1058, 376);
            this.xtraTabPage1.Text = "Productos con Orden de Compras";
            // 
            // gridControlConOrdComp
            // 
            this.gridControlConOrdComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlConOrdComp.Location = new System.Drawing.Point(0, 0);
            this.gridControlConOrdComp.MainView = this.gridViewConOrdComp;
            this.gridControlConOrdComp.Name = "gridControlConOrdComp";
            this.gridControlConOrdComp.Size = new System.Drawing.Size(1058, 376);
            this.gridControlConOrdComp.TabIndex = 0;
            this.gridControlConOrdComp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConOrdComp});
            // 
            // gridViewConOrdComp
            // 
            this.gridViewConOrdComp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdOrdenCompra_OC,
            this.colpr_nombre,
            this.colIdProducto,
            this.colpr_descripcion,
            this.col_observacion,
            this.colCheck,
            this.colCant_Pedida,
            this.colSaldo,
            this.colCantidad_enviar,
            this.colSaldo_Aux,
            this.colReferencia});
            this.gridViewConOrdComp.GridControl = this.gridControlConOrdComp;
            this.gridViewConOrdComp.Name = "gridViewConOrdComp";
            this.gridViewConOrdComp.OptionsView.ShowGroupPanel = false;
            this.gridViewConOrdComp.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewConOrdComp_CellValueChanged);
            this.gridViewConOrdComp.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewConOrdComp_CellValueChanging);
            this.gridViewConOrdComp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewConOrdComp_KeyDown);
            this.gridViewConOrdComp.RowCountChanged += new System.EventHandler(this.gridViewConOrdComp_RowCountChanged);
            // 
            // colIdOrdenCompra_OC
            // 
            this.colIdOrdenCompra_OC.Caption = "# O/C";
            this.colIdOrdenCompra_OC.FieldName = "IdOrdenCompra_OC";
            this.colIdOrdenCompra_OC.Name = "colIdOrdenCompra_OC";
            this.colIdOrdenCompra_OC.OptionsColumn.AllowEdit = false;
            this.colIdOrdenCompra_OC.Visible = true;
            this.colIdOrdenCompra_OC.VisibleIndex = 2;
            this.colIdOrdenCompra_OC.Width = 51;
            // 
            // colpr_nombre
            // 
            this.colpr_nombre.Caption = "Proveedor";
            this.colpr_nombre.FieldName = "pr_nombre";
            this.colpr_nombre.Name = "colpr_nombre";
            this.colpr_nombre.OptionsColumn.AllowEdit = false;
            this.colpr_nombre.Width = 138;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "Código";
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.OptionsColumn.AllowEdit = false;
            this.colIdProducto.Width = 93;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Descripción";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.OptionsColumn.AllowEdit = false;
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 3;
            this.colpr_descripcion.Width = 171;
            // 
            // col_observacion
            // 
            this.col_observacion.Caption = "Observación";
            this.col_observacion.FieldName = "observacion";
            this.col_observacion.Name = "col_observacion";
            this.col_observacion.Visible = true;
            this.col_observacion.VisibleIndex = 4;
            this.col_observacion.Width = 368;
            // 
            // colCheck
            // 
            this.colCheck.Caption = "*";
            this.colCheck.FieldName = "Check_OG";
            this.colCheck.Name = "colCheck";
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 0;
            this.colCheck.Width = 20;
            // 
            // colCant_Pedida
            // 
            this.colCant_Pedida.Caption = "Cant. OC";
            this.colCant_Pedida.FieldName = "Cantidad_OC";
            this.colCant_Pedida.Name = "colCant_Pedida";
            this.colCant_Pedida.OptionsColumn.AllowEdit = false;
            this.colCant_Pedida.Visible = true;
            this.colCant_Pedida.VisibleIndex = 5;
            this.colCant_Pedida.Width = 47;
            // 
            // colSaldo
            // 
            this.colSaldo.Caption = "Saldo";
            this.colSaldo.FieldName = "Cantidad_Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.OptionsColumn.AllowEdit = false;
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 7;
            this.colSaldo.Width = 60;
            // 
            // colCantidad_enviar
            // 
            this.colCantidad_enviar.Caption = "Cant. a Enviar";
            this.colCantidad_enviar.FieldName = "Cantidad_enviar";
            this.colCantidad_enviar.Name = "colCantidad_enviar";
            this.colCantidad_enviar.Visible = true;
            this.colCantidad_enviar.VisibleIndex = 6;
            this.colCantidad_enviar.Width = 67;
            // 
            // colSaldo_Aux
            // 
            this.colSaldo_Aux.Caption = "Saldo_Aux";
            this.colSaldo_Aux.FieldName = "Cantidad_Saldo_Auxi";
            this.colSaldo_Aux.Name = "colSaldo_Aux";
            this.colSaldo_Aux.Width = 115;
            // 
            // colReferencia
            // 
            this.colReferencia.Caption = "Referencia";
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colReferencia.Visible = true;
            this.colReferencia.VisibleIndex = 1;
            this.colReferencia.Width = 72;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControlSinOrdComp);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1058, 376);
            this.xtraTabPage2.Text = "Productos sin Orden de compra";
            // 
            // gridControlSinOrdComp
            // 
            this.gridControlSinOrdComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSinOrdComp.Location = new System.Drawing.Point(0, 0);
            this.gridControlSinOrdComp.MainView = this.gridViewSinOrdComp;
            this.gridControlSinOrdComp.Name = "gridControlSinOrdComp";
            this.gridControlSinOrdComp.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProveedor_grid,
            this.cmbProducto_grid});
            this.gridControlSinOrdComp.Size = new System.Drawing.Size(1058, 376);
            this.gridControlSinOrdComp.TabIndex = 0;
            this.gridControlSinOrdComp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSinOrdComp});
            // 
            // gridViewSinOrdComp
            // 
            this.gridViewSinOrdComp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNum_Fact_sin_oc,
            this.colIdProveedor_sin_oc,
            this.colIdProducto_sin_oc,
            this.colCantidad_enviar_sin_oc,
            this.colobservacion_sin_oc,
            this.colNomProveedor,
            this.colnomProducto});
            this.gridViewSinOrdComp.GridControl = this.gridControlSinOrdComp;
            this.gridViewSinOrdComp.Name = "gridViewSinOrdComp";
            this.gridViewSinOrdComp.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewSinOrdComp.OptionsView.ShowGroupPanel = false;
            this.gridViewSinOrdComp.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewSinOrdComp_CellValueChanged);
            this.gridViewSinOrdComp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewSinOrdComp_KeyDown);
            this.gridViewSinOrdComp.RowCountChanged += new System.EventHandler(this.gridViewSinOrdComp_RowCountChanged);
            // 
            // colNum_Fact_sin_oc
            // 
            this.colNum_Fact_sin_oc.Caption = "Ref. Factura";
            this.colNum_Fact_sin_oc.FieldName = "Num_Fact";
            this.colNum_Fact_sin_oc.Name = "colNum_Fact_sin_oc";
            this.colNum_Fact_sin_oc.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colNum_Fact_sin_oc.Visible = true;
            this.colNum_Fact_sin_oc.VisibleIndex = 0;
            this.colNum_Fact_sin_oc.Width = 70;
            // 
            // colIdProveedor_sin_oc
            // 
            this.colIdProveedor_sin_oc.Caption = "Código proveedor";
            this.colIdProveedor_sin_oc.ColumnEdit = this.cmbProveedor_grid;
            this.colIdProveedor_sin_oc.FieldName = "IdProveedor";
            this.colIdProveedor_sin_oc.Name = "colIdProveedor_sin_oc";
            this.colIdProveedor_sin_oc.Visible = true;
            this.colIdProveedor_sin_oc.VisibleIndex = 1;
            this.colIdProveedor_sin_oc.Width = 148;
            // 
            // cmbProveedor_grid
            // 
            this.cmbProveedor_grid.AutoHeight = false;
            this.cmbProveedor_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProveedor_grid.DisplayMember = "pr_nombre";
            this.cmbProveedor_grid.Name = "cmbProveedor_grid";
            this.cmbProveedor_grid.ValueMember = "IdProveedor";
            this.cmbProveedor_grid.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProveedor_grid,
            this.colpr_nombre_grid,
            this.colpr_Estado_grid});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProveedor_grid
            // 
            this.colIdProveedor_grid.Caption = "Código";
            this.colIdProveedor_grid.FieldName = "IdProveedor";
            this.colIdProveedor_grid.Name = "colIdProveedor_grid";
            this.colIdProveedor_grid.Visible = true;
            this.colIdProveedor_grid.VisibleIndex = 1;
            this.colIdProveedor_grid.Width = 176;
            // 
            // colpr_nombre_grid
            // 
            this.colpr_nombre_grid.Caption = "Nombre";
            this.colpr_nombre_grid.FieldName = "pr_nombre";
            this.colpr_nombre_grid.Name = "colpr_nombre_grid";
            this.colpr_nombre_grid.Visible = true;
            this.colpr_nombre_grid.VisibleIndex = 0;
            this.colpr_nombre_grid.Width = 826;
            // 
            // colpr_Estado_grid
            // 
            this.colpr_Estado_grid.Caption = "Estado";
            this.colpr_Estado_grid.FieldName = "pr_Estado";
            this.colpr_Estado_grid.Name = "colpr_Estado_grid";
            this.colpr_Estado_grid.Visible = true;
            this.colpr_Estado_grid.VisibleIndex = 2;
            this.colpr_Estado_grid.Width = 178;
            // 
            // colIdProducto_sin_oc
            // 
            this.colIdProducto_sin_oc.Caption = "Código producto";
            this.colIdProducto_sin_oc.ColumnEdit = this.cmbProducto_grid;
            this.colIdProducto_sin_oc.FieldName = "IdProducto";
            this.colIdProducto_sin_oc.Name = "colIdProducto_sin_oc";
            this.colIdProducto_sin_oc.Visible = true;
            this.colIdProducto_sin_oc.VisibleIndex = 3;
            this.colIdProducto_sin_oc.Width = 139;
            // 
            // cmbProducto_grid
            // 
            this.cmbProducto_grid.AutoHeight = false;
            this.cmbProducto_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducto_grid.DisplayMember = "pr_descripcion";
            this.cmbProducto_grid.Name = "cmbProducto_grid";
            this.cmbProducto_grid.ValueMember = "IdProducto";
            this.cmbProducto_grid.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto_grid,
            this.colpr_codigo_grid,
            this.colpr_descripcion_grid,
            this.colpr_stock_grid,
            this.colEstado_grid});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto_grid
            // 
            this.colIdProducto_grid.Caption = "IdProducto";
            this.colIdProducto_grid.FieldName = "IdProducto";
            this.colIdProducto_grid.Name = "colIdProducto_grid";
            this.colIdProducto_grid.Visible = true;
            this.colIdProducto_grid.VisibleIndex = 2;
            this.colIdProducto_grid.Width = 190;
            // 
            // colpr_codigo_grid
            // 
            this.colpr_codigo_grid.Caption = "Código";
            this.colpr_codigo_grid.FieldName = "pr_codigo";
            this.colpr_codigo_grid.Name = "colpr_codigo_grid";
            this.colpr_codigo_grid.Visible = true;
            this.colpr_codigo_grid.VisibleIndex = 1;
            this.colpr_codigo_grid.Width = 149;
            // 
            // colpr_descripcion_grid
            // 
            this.colpr_descripcion_grid.Caption = "Nombre";
            this.colpr_descripcion_grid.FieldName = "pr_descripcion";
            this.colpr_descripcion_grid.Name = "colpr_descripcion_grid";
            this.colpr_descripcion_grid.Visible = true;
            this.colpr_descripcion_grid.VisibleIndex = 0;
            this.colpr_descripcion_grid.Width = 529;
            // 
            // colpr_stock_grid
            // 
            this.colpr_stock_grid.Caption = "Stock";
            this.colpr_stock_grid.FieldName = "pr_stock";
            this.colpr_stock_grid.Name = "colpr_stock_grid";
            this.colpr_stock_grid.Visible = true;
            this.colpr_stock_grid.VisibleIndex = 3;
            this.colpr_stock_grid.Width = 153;
            // 
            // colEstado_grid
            // 
            this.colEstado_grid.Caption = "Estado";
            this.colEstado_grid.FieldName = "Estado";
            this.colEstado_grid.Name = "colEstado_grid";
            this.colEstado_grid.Visible = true;
            this.colEstado_grid.VisibleIndex = 4;
            this.colEstado_grid.Width = 159;
            // 
            // colCantidad_enviar_sin_oc
            // 
            this.colCantidad_enviar_sin_oc.Caption = "Cant. a Enviar";
            this.colCantidad_enviar_sin_oc.FieldName = "Cantidad_enviar";
            this.colCantidad_enviar_sin_oc.Name = "colCantidad_enviar_sin_oc";
            this.colCantidad_enviar_sin_oc.Visible = true;
            this.colCantidad_enviar_sin_oc.VisibleIndex = 5;
            this.colCantidad_enviar_sin_oc.Width = 71;
            // 
            // colobservacion_sin_oc
            // 
            this.colobservacion_sin_oc.Caption = "Observación";
            this.colobservacion_sin_oc.FieldName = "observacion";
            this.colobservacion_sin_oc.Name = "colobservacion_sin_oc";
            this.colobservacion_sin_oc.Visible = true;
            this.colobservacion_sin_oc.VisibleIndex = 6;
            this.colobservacion_sin_oc.Width = 318;
            // 
            // colNomProveedor
            // 
            this.colNomProveedor.Caption = "Proveedor";
            this.colNomProveedor.FieldName = "nom_proveedor";
            this.colNomProveedor.Name = "colNomProveedor";
            this.colNomProveedor.Visible = true;
            this.colNomProveedor.VisibleIndex = 2;
            this.colNomProveedor.Width = 209;
            // 
            // colnomProducto
            // 
            this.colnomProducto.Caption = "Producto";
            this.colnomProducto.FieldName = "nom_producto";
            this.colnomProducto.Name = "colnomProducto";
            this.colnomProducto.Visible = true;
            this.colnomProducto.VisibleIndex = 4;
            this.colnomProducto.Width = 169;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar_OC);
            this.groupBox1.Controls.Add(this.txtIdGuia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDirPuntoLlega);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDirPuntoPart);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtNumGuia);
            this.groupBox1.Controls.Add(this.cmbPuntoLlega);
            this.groupBox1.Controls.Add(this.cmbPuntoPartida);
            this.groupBox1.Controls.Add(this.cmbTrasnportador);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 212);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregar_OC
            // 
            this.btnAgregar_OC.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAgregar_OC.Location = new System.Drawing.Point(12, 181);
            this.btnAgregar_OC.Name = "btnAgregar_OC";
            this.btnAgregar_OC.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar_OC.TabIndex = 24;
            this.btnAgregar_OC.Text = "Agregar OC";
            this.btnAgregar_OC.Click += new System.EventHandler(this.btnAgregar_OC_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumOC_Quitar);
            this.groupBox2.Controls.Add(this.cmbMotivoTras);
            this.groupBox2.Controls.Add(this.btnQuitarOC);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.gbx_Fechas);
            this.groupBox2.Controls.Add(this.ucGe_Doc_talo_x_Guia);
            this.groupBox2.Location = new System.Drawing.Point(504, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 212);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1064, 231);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 682);
            this.panel1.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 447);
            this.panel3.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.xtraTabControl1);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1064, 447);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_num_registros_sin_OC);
            this.panel4.Controls.Add(this.labelControl2);
            this.panel4.Controls.Add(this.txt_num_registros_con_OC);
            this.panel4.Controls.Add(this.labelControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 404);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1064, 43);
            this.panel4.TabIndex = 1;
            // 
            // txt_num_registros_sin_OC
            // 
            this.txt_num_registros_sin_OC.Location = new System.Drawing.Point(483, 12);
            this.txt_num_registros_sin_OC.Name = "txt_num_registros_sin_OC";
            this.txt_num_registros_sin_OC.Properties.ReadOnly = true;
            this.txt_num_registros_sin_OC.Size = new System.Drawing.Size(121, 20);
            this.txt_num_registros_sin_OC.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(314, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(148, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Registros sin OC seleccionados";
            // 
            // txt_num_registros_con_OC
            // 
            this.txt_num_registros_con_OC.Location = new System.Drawing.Point(183, 12);
            this.txt_num_registros_con_OC.Name = "txt_num_registros_con_OC";
            this.txt_num_registros_con_OC.Properties.ReadOnly = true;
            this.txt_num_registros_con_OC.Size = new System.Drawing.Size(117, 20);
            this.txt_num_registros_con_OC.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(152, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Registros con OC seleccionados";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 235);
            this.panel2.TabIndex = 28;
            // 
            // FrmIn_Genera_Guia_x_Traspaso_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "FrmIn_Genera_Guia_x_Traspaso_Mant";
            this.Text = "Generación de Guías por Traspaso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Genera_Guia_x_Traspaso_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_Genera_Guia_x_Traspaso_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuntoLlega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuntoPartida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.gbx_Fechas.ResumeLayout(false);
            this.gbx_Fechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeHoraLlegada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeHoraTraslado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumOC_Quitar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConOrdComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConOrdComp)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSinOrdComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSinOrdComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_registros_sin_OC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_registros_con_OC.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtDirPuntoLlega;
        private System.Windows.Forms.TextBox txtDirPuntoPart;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbPuntoLlega;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbPuntoPartida;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.TextBox txtNumGuia;
        private System.Windows.Forms.TextBox txtIdGuia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbx_Fechas;
        private System.Windows.Forms.DateTimePicker dtpFechaLlega;
        private System.Windows.Forms.DateTimePicker dtpFechaTras;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraGrid.GridControl gridControlConOrdComp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConOrdComp;
        private DevExpress.XtraGrid.GridControl gridControlSinOrdComp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSinOrdComp;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal_llega;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion2_llega;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_llega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal_part;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion2_part;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_part;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenCompra_OC;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn col_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad_enviar;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_Fact_sin_oc;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor_sin_oc;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto_sin_oc;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad_enviar_sin_oc;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion_sin_oc;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProveedor_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_nombre_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_Estado_grid;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProducto_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_stock_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_grid;
        private System.Windows.Forms.Label lblAnulado;
        private Controles.UCGe_Transportista_Cmb cmbTrasnportador;
        private Controles.UCIn_Catalogos_Cmb cmbMotivoTras;
        private DevExpress.XtraEditors.TextEdit txtNumOC_Quitar;
        private DevExpress.XtraEditors.SimpleButton btnQuitarOC;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.TimeEdit timeHoraLlegada;
        private DevExpress.XtraEditors.TimeEdit timeHoraTraslado;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private DevExpress.XtraGrid.Columns.GridColumn colCant_Pedida;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo_Aux;
        private DevExpress.XtraGrid.Columns.GridColumn colNomProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colnomProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private Controles.UCGe_NumeroDocTrans ucGe_Doc_talo_x_Guia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnAgregar_OC;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_num_registros_con_OC;
        private DevExpress.XtraEditors.TextEdit txt_num_registros_sin_OC;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}