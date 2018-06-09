namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_OrdenTallerMantenimiento
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbProductos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_PesoTotal = new DevExpress.XtraEditors.TextEdit();
            this.txt_PesoUnit = new DevExpress.XtraEditors.TextEdit();
            this.txt_Cantidad = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Observacion = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbListadoDiseno = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_IdListadoDiseno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_TipoListadoDiseno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_ListadoDiseno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.ucFa_Cliente_Facturacion1 = new Core.Erp.Winform.Controles.UCFa_Cliente_Facturacion();
            this.ucGe_Sucursal = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.txt_CodigoOT = new System.Windows.Forms.TextBox();
            this.PanelObra = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_IDOT = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.errorProviderValidaTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProductos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PesoTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PesoUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cantidad.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbListadoDiseno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidaTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 591);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 569);
            this.panel2.TabIndex = 67;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 259);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(679, 310);
            this.panel5.TabIndex = 73;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.CmbProductos);
            this.groupBox1.Controls.Add(this.txt_PesoTotal);
            this.groupBox1.Controls.Add(this.txt_PesoUnit);
            this.groupBox1.Controls.Add(this.txt_Cantidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Observacion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 310);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // CmbProductos
            // 
            this.CmbProductos.Location = new System.Drawing.Point(117, 19);
            this.CmbProductos.Name = "CmbProductos";
            this.CmbProductos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbProductos.Properties.DisplayMember = "pr_descripcion";
            this.CmbProductos.Properties.ValueMember = "IdProducto";
            this.CmbProductos.Properties.View = this.searchLookUpEdit1View;
            this.CmbProductos.Size = new System.Drawing.Size(484, 20);
            this.CmbProductos.TabIndex = 5;
            this.CmbProductos.EditValueChanged += new System.EventHandler(this.CmbProductos_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pr_codigo,
            this.pr_descripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // pr_codigo
            // 
            this.pr_codigo.Caption = "pr_codigo";
            this.pr_codigo.FieldName = "pr_codigo";
            this.pr_codigo.Name = "pr_codigo";
            this.pr_codigo.Visible = true;
            this.pr_codigo.VisibleIndex = 0;
            this.pr_codigo.Width = 194;
            // 
            // pr_descripcion
            // 
            this.pr_descripcion.Caption = "pr_descripcion";
            this.pr_descripcion.FieldName = "pr_descripcion";
            this.pr_descripcion.Name = "pr_descripcion";
            this.pr_descripcion.Visible = true;
            this.pr_descripcion.VisibleIndex = 1;
            this.pr_descripcion.Width = 881;
            // 
            // txt_PesoTotal
            // 
            this.txt_PesoTotal.Location = new System.Drawing.Point(117, 74);
            this.txt_PesoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PesoTotal.Name = "txt_PesoTotal";
            this.txt_PesoTotal.Properties.Mask.EditMask = "f";
            this.txt_PesoTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_PesoTotal.Size = new System.Drawing.Size(86, 20);
            this.txt_PesoTotal.TabIndex = 65;
            // 
            // txt_PesoUnit
            // 
            this.txt_PesoUnit.Location = new System.Drawing.Point(312, 47);
            this.txt_PesoUnit.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PesoUnit.Name = "txt_PesoUnit";
            this.txt_PesoUnit.Properties.Mask.EditMask = "f";
            this.txt_PesoUnit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_PesoUnit.Size = new System.Drawing.Size(86, 20);
            this.txt_PesoUnit.TabIndex = 7;
            this.txt_PesoUnit.TextChanged += new System.EventHandler(this.txt_PesoUnit_TextChanged);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(117, 48);
            this.txt_Cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Properties.Mask.EditMask = "f";
            this.txt_Cantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Cantidad.Size = new System.Drawing.Size(86, 20);
            this.txt_Cantidad.TabIndex = 6;
            this.txt_Cantidad.TextChanged += new System.EventHandler(this.txt_Cantidad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Producto Terminado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Peso Unit.Kg.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Peso Total Kg:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Observación:";
            // 
            // txt_Observacion
            // 
            this.txt_Observacion.Location = new System.Drawing.Point(6, 116);
            this.txt_Observacion.MaxLength = 150;
            this.txt_Observacion.Multiline = true;
            this.txt_Observacion.Name = "txt_Observacion";
            this.txt_Observacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Observacion.Size = new System.Drawing.Size(595, 46);
            this.txt_Observacion.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel4.Controls.Add(this.cmbListadoDiseno);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.ucFa_Cliente_Facturacion1);
            this.panel4.Controls.Add(this.ucGe_Sucursal);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.TxtDescripcion);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.panel4.Controls.Add(this.lblAnulado);
            this.panel4.Controls.Add(this.txt_CodigoOT);
            this.panel4.Controls.Add(this.PanelObra);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txt_IDOT);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(679, 259);
            this.panel4.TabIndex = 72;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // cmbListadoDiseno
            // 
            this.cmbListadoDiseno.Location = new System.Drawing.Point(101, 189);
            this.cmbListadoDiseno.Name = "cmbListadoDiseno";
            this.cmbListadoDiseno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbListadoDiseno.Properties.DisplayMember = "DetalleListadoDiseno";
            this.cmbListadoDiseno.Properties.ValueMember = "IdListadoDiseno";
            this.cmbListadoDiseno.Properties.View = this.gridView1;
            this.cmbListadoDiseno.Size = new System.Drawing.Size(308, 20);
            this.cmbListadoDiseno.TabIndex = 3;
            this.cmbListadoDiseno.EditValueChanged += new System.EventHandler(this.cmbListadoDiseno_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_IdListadoDiseno,
            this.Col_TipoListadoDiseno,
            this.Col_ListadoDiseno});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Col_IdListadoDiseno
            // 
            this.Col_IdListadoDiseno.Caption = "IdListadoDiseno";
            this.Col_IdListadoDiseno.FieldName = "IdListadoDiseno";
            this.Col_IdListadoDiseno.Name = "Col_IdListadoDiseno";
            this.Col_IdListadoDiseno.Visible = true;
            this.Col_IdListadoDiseno.VisibleIndex = 0;
            // 
            // Col_TipoListadoDiseno
            // 
            this.Col_TipoListadoDiseno.Caption = "TipoListadoDiseno";
            this.Col_TipoListadoDiseno.FieldName = "TipoListadoDiseno";
            this.Col_TipoListadoDiseno.Name = "Col_TipoListadoDiseno";
            this.Col_TipoListadoDiseno.Visible = true;
            this.Col_TipoListadoDiseno.VisibleIndex = 2;
            // 
            // Col_ListadoDiseno
            // 
            this.Col_ListadoDiseno.Caption = "Listado Diseño";
            this.Col_ListadoDiseno.FieldName = "lm_Observacion";
            this.Col_ListadoDiseno.Name = "Col_ListadoDiseno";
            this.Col_ListadoDiseno.Visible = true;
            this.Col_ListadoDiseno.VisibleIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Listado Diseno:";
            // 
            // ucFa_Cliente_Facturacion1
            // 
            this.ucFa_Cliente_Facturacion1.Location = new System.Drawing.Point(18, 153);
            this.ucFa_Cliente_Facturacion1.Name = "ucFa_Cliente_Facturacion1";
            this.ucFa_Cliente_Facturacion1.Size = new System.Drawing.Size(352, 26);
            this.ucFa_Cliente_Facturacion1.TabIndex = 82;
            this.ucFa_Cliente_Facturacion1.Load += new System.EventHandler(this.ucFa_Cliente_Facturacion1_Load_1);
            // 
            // ucGe_Sucursal
            // 
            this.ucGe_Sucursal.Location = new System.Drawing.Point(101, 94);
            this.ucGe_Sucursal.Name = "ucGe_Sucursal";
            this.ucGe_Sucursal.Size = new System.Drawing.Size(242, 22);
            this.ucGe_Sucursal.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 81;
            this.label12.Text = "Sucursal:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Enabled = false;
            this.TxtDescripcion.Location = new System.Drawing.Point(82, 215);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(519, 37);
            this.TxtDescripcion.TabIndex = 4;
            this.TxtDescripcion.TextChanged += new System.EventHandler(this.TxtDescripcion_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 78;
            this.label11.Text = "Descripcion:";
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
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(679, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 74;
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
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
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
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            this.ucGe_Menu_Superior_Mant1.Load += new System.EventHandler(this.ucGe_Menu_Superior_Mant1_Load);
            // 
            // lblAnulado
            // 
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(425, 35);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(162, 27);
            this.lblAnulado.TabIndex = 52;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_CodigoOT
            // 
            this.txt_CodigoOT.Location = new System.Drawing.Point(101, 63);
            this.txt_CodigoOT.MaxLength = 20;
            this.txt_CodigoOT.Name = "txt_CodigoOT";
            this.txt_CodigoOT.Size = new System.Drawing.Size(308, 20);
            this.txt_CodigoOT.TabIndex = 0;
            // 
            // PanelObra
            // 
            this.PanelObra.Location = new System.Drawing.Point(12, 119);
            this.PanelObra.Name = "PanelObra";
            this.PanelObra.Size = new System.Drawing.Size(442, 28);
            this.PanelObra.TabIndex = 2;
            this.PanelObra.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelObra_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(300, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "# Orden Taller:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "# Registro:";
            // 
            // txt_IDOT
            // 
            this.txt_IDOT.Enabled = false;
            this.txt_IDOT.Location = new System.Drawing.Point(101, 35);
            this.txt_IDOT.Name = "txt_IDOT";
            this.txt_IDOT.Size = new System.Drawing.Size(109, 20);
            this.txt_IDOT.TabIndex = 48;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(679, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // errorProviderValidaTxt
            // 
            this.errorProviderValidaTxt.ContainerControl = this;
            // 
            // FrmPrd_OrdenTallerMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 591);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrd_OrdenTallerMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Órdenes de Taller por Obra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrd_OrdenTallerMantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrd_RegOrdenTaller_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProductos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PesoTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PesoUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cantidad.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbListadoDiseno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidaTxt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Observacion;
        private System.Windows.Forms.TextBox txt_IDOT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CodigoOT;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txt_PesoUnit;
        private DevExpress.XtraEditors.TextEdit txt_Cantidad;
        private DevExpress.XtraEditors.TextEdit txt_PesoTotal;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private DevExpress.XtraEditors.SearchLookUpEdit CmbProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private DevExpress.XtraGrid.Columns.GridColumn pr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn pr_descripcion;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProviderValidaTxt;
        private Controles.UCGe_Sucursal_combo ucGe_Sucursal;
        private Controles.UCFa_Cliente_Facturacion ucFa_Cliente_Facturacion1;
        private System.Windows.Forms.Panel PanelObra;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbListadoDiseno;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdListadoDiseno;
        private DevExpress.XtraGrid.Columns.GridColumn Col_TipoListadoDiseno;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ListadoDiseno;
    }
}