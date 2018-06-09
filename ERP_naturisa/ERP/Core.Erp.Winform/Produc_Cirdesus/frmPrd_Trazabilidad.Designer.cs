namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class frmPrd_Trazabilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrd_Trazabilidad));
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridCtrlTrazabilidad = new DevExpress.XtraGrid.GridControl();
            this.gridVwTrazabilidad = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CoolIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CollIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdNumMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCodigoBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoolmovilidadProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Coolpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Collob_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Collcm_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpr_descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBodega = new System.Windows.Forms.TextBox();
            this.lbBodega = new System.Windows.Forms.Label();
            this.TxtSucursal = new System.Windows.Forms.TextBox();
            this.LbSucursal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlTrazabilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwTrazabilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Generar_XML = true;
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
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(880, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 18;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridCtrlTrazabilidad);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(880, 262);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trazabilidad";
            // 
            // gridCtrlTrazabilidad
            // 
            this.gridCtrlTrazabilidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlTrazabilidad.Location = new System.Drawing.Point(3, 16);
            this.gridCtrlTrazabilidad.MainView = this.gridVwTrazabilidad;
            this.gridCtrlTrazabilidad.Name = "gridCtrlTrazabilidad";
            this.gridCtrlTrazabilidad.Size = new System.Drawing.Size(874, 243);
            this.gridCtrlTrazabilidad.TabIndex = 0;
            this.gridCtrlTrazabilidad.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVwTrazabilidad,
            this.gridView1});
            // 
            // gridVwTrazabilidad
            // 
            this.gridVwTrazabilidad.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.gridVwTrazabilidad.Appearance.ViewCaption.Options.UseFont = true;
            this.gridVwTrazabilidad.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CoolIdEmpresa,
            this.CollIdSucursal,
            this.ColIdNumMovi,
            this.ColCodigoBarra,
            this.CoolmovilidadProducto,
            this.Coolpr_descripcion,
            this.Collob_descripcion,
            this.Collcm_fecha});
            this.gridVwTrazabilidad.GridControl = this.gridCtrlTrazabilidad;
            this.gridVwTrazabilidad.Name = "gridVwTrazabilidad";
            this.gridVwTrazabilidad.OptionsBehavior.ReadOnly = true;
            this.gridVwTrazabilidad.OptionsView.ShowGroupPanel = false;
            this.gridVwTrazabilidad.OptionsView.ShowViewCaption = true;
            this.gridVwTrazabilidad.ViewCaption = "TRAZABILIDAD";
            // 
            // CoolIdEmpresa
            // 
            this.CoolIdEmpresa.Caption = "IdEmpresa";
            this.CoolIdEmpresa.FieldName = "IdEmpresa";
            this.CoolIdEmpresa.Name = "CoolIdEmpresa";
            this.CoolIdEmpresa.Visible = true;
            this.CoolIdEmpresa.VisibleIndex = 0;
            this.CoolIdEmpresa.Width = 69;
            // 
            // CollIdSucursal
            // 
            this.CollIdSucursal.Caption = "Id Sucursal";
            this.CollIdSucursal.FieldName = "IdSucursal";
            this.CollIdSucursal.Name = "CollIdSucursal";
            this.CollIdSucursal.Visible = true;
            this.CollIdSucursal.VisibleIndex = 1;
            this.CollIdSucursal.Width = 65;
            // 
            // ColIdNumMovi
            // 
            this.ColIdNumMovi.Caption = "Id Movimiento";
            this.ColIdNumMovi.FieldName = "IdNumMovi";
            this.ColIdNumMovi.Name = "ColIdNumMovi";
            this.ColIdNumMovi.Visible = true;
            this.ColIdNumMovi.VisibleIndex = 2;
            this.ColIdNumMovi.Width = 77;
            // 
            // ColCodigoBarra
            // 
            this.ColCodigoBarra.Caption = "Codigo Barra";
            this.ColCodigoBarra.FieldName = "CodigoBarra";
            this.ColCodigoBarra.Name = "ColCodigoBarra";
            this.ColCodigoBarra.Visible = true;
            this.ColCodigoBarra.VisibleIndex = 3;
            this.ColCodigoBarra.Width = 137;
            // 
            // CoolmovilidadProducto
            // 
            this.CoolmovilidadProducto.Caption = "movilidad Producto";
            this.CoolmovilidadProducto.FieldName = "movilidadProducto";
            this.CoolmovilidadProducto.Name = "CoolmovilidadProducto";
            this.CoolmovilidadProducto.Visible = true;
            this.CoolmovilidadProducto.VisibleIndex = 4;
            this.CoolmovilidadProducto.Width = 301;
            // 
            // Coolpr_descripcion
            // 
            this.Coolpr_descripcion.Caption = "Producto";
            this.Coolpr_descripcion.FieldName = "pr_descripcion";
            this.Coolpr_descripcion.Name = "Coolpr_descripcion";
            this.Coolpr_descripcion.Visible = true;
            this.Coolpr_descripcion.VisibleIndex = 5;
            this.Coolpr_descripcion.Width = 165;
            // 
            // Collob_descripcion
            // 
            this.Collob_descripcion.Caption = "Observacion";
            this.Collob_descripcion.FieldName = "ob_descripcion";
            this.Collob_descripcion.Name = "Collob_descripcion";
            this.Collob_descripcion.Visible = true;
            this.Collob_descripcion.VisibleIndex = 6;
            this.Collob_descripcion.Width = 246;
            // 
            // Collcm_fecha
            // 
            this.Collcm_fecha.Caption = "Fecha";
            this.Collcm_fecha.FieldName = "cm_fecha";
            this.Collcm_fecha.Name = "Collcm_fecha";
            this.Collcm_fecha.Visible = true;
            this.Collcm_fecha.VisibleIndex = 7;
            this.Collcm_fecha.Width = 104;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridCtrlTrazabilidad;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.TxtSucursal);
            this.groupBox2.Controls.Add(this.LbSucursal);
            this.groupBox2.Controls.Add(this.txtBodega);
            this.groupBox2.Controls.Add(this.lbBodega);
            this.groupBox2.Controls.Add(this.txtObservacion);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCategoria);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTipo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtpr_descripcion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPeso);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMarca);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 164);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Básicos del Producto";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtObservacion.Enabled = false;
            this.txtObservacion.Location = new System.Drawing.Point(98, 123);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(447, 36);
            this.txtObservacion.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Observación:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(98, 69);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(450, 20);
            this.txtCategoria.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Categoria:";
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(98, 44);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(450, 20);
            this.txtTipo.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tipo:";
            // 
            // txtpr_descripcion
            // 
            this.txtpr_descripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtpr_descripcion.Enabled = false;
            this.txtpr_descripcion.Location = new System.Drawing.Point(98, 94);
            this.txtpr_descripcion.Name = "txtpr_descripcion";
            this.txtpr_descripcion.Size = new System.Drawing.Size(447, 20);
            this.txtpr_descripcion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción:";
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPeso.Enabled = false;
            this.txtPeso.Location = new System.Drawing.Point(314, 16);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(63, 20);
            this.txtPeso.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Peso:";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(419, 15);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(129, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Marca:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(192, 17);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(78, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Código:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(98, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txtCodigoBarra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 50);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto a Consultar";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(656, 15);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodigoBarra.Location = new System.Drawing.Point(229, 16);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(416, 20);
            this.txtCodigoBarra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el Código de Barra del Producto:";
            // 
            // txtBodega
            // 
            this.txtBodega.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBodega.Enabled = false;
            this.txtBodega.Location = new System.Drawing.Point(618, 16);
            this.txtBodega.Name = "txtBodega";
            this.txtBodega.Size = new System.Drawing.Size(250, 20);
            this.txtBodega.TabIndex = 4;
            // 
            // lbBodega
            // 
            this.lbBodega.AutoSize = true;
            this.lbBodega.Location = new System.Drawing.Point(557, 18);
            this.lbBodega.Name = "lbBodega";
            this.lbBodega.Size = new System.Drawing.Size(47, 13);
            this.lbBodega.TabIndex = 3;
            this.lbBodega.Text = "Bodega:";
            // 
            // TxtSucursal
            // 
            this.TxtSucursal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtSucursal.Enabled = false;
            this.TxtSucursal.Location = new System.Drawing.Point(618, 44);
            this.TxtSucursal.Name = "TxtSucursal";
            this.TxtSucursal.Size = new System.Drawing.Size(250, 20);
            this.TxtSucursal.TabIndex = 6;
            // 
            // LbSucursal
            // 
            this.LbSucursal.AutoSize = true;
            this.LbSucursal.Location = new System.Drawing.Point(557, 46);
            this.LbSucursal.Name = "LbSucursal";
            this.LbSucursal.Size = new System.Drawing.Size(51, 13);
            this.LbSucursal.TabIndex = 5;
            this.LbSucursal.Text = "Sucursal:";
            // 
            // frmPrd_Trazabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(880, 505);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "frmPrd_Trazabilidad";
            this.Text = "Historial de Trazabilidad por Producto ";
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlTrazabilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwTrazabilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gridCtrlTrazabilidad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVwTrazabilidad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpr_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn CoolIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn CollIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdNumMovi;
        private DevExpress.XtraGrid.Columns.GridColumn ColCodigoBarra;
        private DevExpress.XtraGrid.Columns.GridColumn CoolmovilidadProducto;
        private DevExpress.XtraGrid.Columns.GridColumn Coolpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Collob_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Collcm_fecha;
        private System.Windows.Forms.TextBox TxtSucursal;
        private System.Windows.Forms.Label LbSucursal;
        private System.Windows.Forms.TextBox txtBodega;
        private System.Windows.Forms.Label lbBodega;

    }
}