namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Transferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBA_Transferencia));
            this.barra = new System.Windows.Forms.ToolStrip();
            this.btn_grabar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_grabarysalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_monto = new DevExpress.XtraEditors.TextEdit();
            this.ultraCmbE_empresaDest = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ultraCmbE_empresaOrig = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblCbt_TipoAnulacion = new System.Windows.Forms.Label();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NTransferencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_fechaCbte = new System.Windows.Forms.DateTimePicker();
            this.txt_Memo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_ND = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPage_NC = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ucBa_TipoFlujo_origen = new Core.Erp.Winform.Controles.UCBa_TipoFlujo();
            this.ucBa_CuentaBanco_Destino = new Core.Erp.Winform.Controles.UCBa_CuentaBanco();
            this.ucBa_CuentaBanco_Origen = new Core.Erp.Winform.Controles.UCBa_CuentaBanco();
            this.em_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucBa_TipoFlujo_destino = new Core.Erp.Winform.Controles.UCBa_TipoFlujo();
            this.UC_DiarioND = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.UC_DiarioNC = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.ucbA_Tipo_NCBA = new Core.Erp.Winform.Controles.UCBA_TipoNota();
            this.ucbA_Tipo_NDBA = new Core.Erp.Winform.Controles.UCBA_TipoNota();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.barra.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_empresaDest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_empresaOrig.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_ND.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage_NC.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_grabar,
            this.toolStripSeparator1,
            this.btn_grabarysalir,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.btnAnular,
            this.btnSalir});
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(1041, 25);
            this.barra.TabIndex = 0;
            this.barra.Text = "Barra";
            // 
            // btn_grabar
            // 
            this.btn_grabar.Image = ((System.Drawing.Image)(resources.GetObject("btn_grabar.Image")));
            this.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(62, 22);
            this.btn_grabar.Tag = "2";
            this.btn_grabar.Text = "Grabar";
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_grabarysalir
            // 
            this.btn_grabarysalir.Image = ((System.Drawing.Image)(resources.GetObject("btn_grabarysalir.Image")));
            this.btn_grabarysalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_grabarysalir.Name = "btn_grabarysalir";
            this.btn_grabarysalir.Size = new System.Drawing.Size(96, 22);
            this.btn_grabarysalir.Tag = "3";
            this.btn_grabarysalir.Text = "Grabar y Salir";
            this.btn_grabarysalir.Click += new System.EventHandler(this.btn_grabarysalir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Text = "Imprimir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAnular
            // 
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(62, 22);
            this.btnAnular.Tag = "7";
            this.btnAnular.Text = "Anular";
            this.btnAnular.Visible = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Tag = "8";
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ucbA_Tipo_NDBA);
            this.groupBox2.Controls.Add(this.ucbA_Tipo_NCBA);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ucBa_TipoFlujo_origen);
            this.groupBox2.Controls.Add(this.ucBa_CuentaBanco_Destino);
            this.groupBox2.Controls.Add(this.ucBa_CuentaBanco_Origen);
            this.groupBox2.Controls.Add(this.txt_monto);
            this.groupBox2.Controls.Add(this.ultraCmbE_empresaDest);
            this.groupBox2.Controls.Add(this.ultraCmbE_empresaOrig);
            this.groupBox2.Controls.Add(this.lblCbt_TipoAnulacion);
            this.groupBox2.Controls.Add(this.lblAnulado);
            this.groupBox2.Controls.Add(this.label43);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_NTransferencia);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dt_fechaCbte);
            this.groupBox2.Controls.Add(this.txt_Memo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ucBa_TipoFlujo_destino);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1027, 298);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Principales";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(102, 184);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Properties.Mask.EditMask = "c3";
            this.txt_monto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_monto.Size = new System.Drawing.Size(100, 20);
            this.txt_monto.TabIndex = 17;
            this.txt_monto.EditValueChanged += new System.EventHandler(this.txt_monto_EditValueChanged);
            // 
            // ultraCmbE_empresaDest
            // 
            this.ultraCmbE_empresaDest.Location = new System.Drawing.Point(591, 64);
            this.ultraCmbE_empresaDest.Name = "ultraCmbE_empresaDest";
            this.ultraCmbE_empresaDest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraCmbE_empresaDest.Properties.DisplayMember = "em_nombre";
            this.ultraCmbE_empresaDest.Properties.ValueMember = "IdEmpresa";
            this.ultraCmbE_empresaDest.Properties.View = this.gridView4;
            this.ultraCmbE_empresaDest.Size = new System.Drawing.Size(343, 20);
            this.ultraCmbE_empresaDest.TabIndex = 5;
            this.ultraCmbE_empresaDest.EditValueChanged += new System.EventHandler(this.ultraCmbE_empresaDest_EditValueChanged);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.em_nombre});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // ultraCmbE_empresaOrig
            // 
            this.ultraCmbE_empresaOrig.Location = new System.Drawing.Point(120, 58);
            this.ultraCmbE_empresaOrig.Name = "ultraCmbE_empresaOrig";
            this.ultraCmbE_empresaOrig.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraCmbE_empresaOrig.Properties.DisplayMember = "em_nombre";
            this.ultraCmbE_empresaOrig.Properties.ValueMember = "IdEmpresa";
            this.ultraCmbE_empresaOrig.Properties.View = this.gridView2;
            this.ultraCmbE_empresaOrig.Size = new System.Drawing.Size(310, 20);
            this.ultraCmbE_empresaOrig.TabIndex = 2;
            this.ultraCmbE_empresaOrig.EditValueChanged += new System.EventHandler(this.ultraCmbE_empresaOrig_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colem_nombre});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // lblCbt_TipoAnulacion
            // 
            this.lblCbt_TipoAnulacion.AutoEllipsis = true;
            this.lblCbt_TipoAnulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCbt_TipoAnulacion.ForeColor = System.Drawing.Color.Red;
            this.lblCbt_TipoAnulacion.Location = new System.Drawing.Point(465, 29);
            this.lblCbt_TipoAnulacion.Name = "lblCbt_TipoAnulacion";
            this.lblCbt_TipoAnulacion.Size = new System.Drawing.Size(411, 22);
            this.lblCbt_TipoAnulacion.TabIndex = 1;
            this.lblCbt_TipoAnulacion.Text = "***ANULADO***";
            this.lblCbt_TipoAnulacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCbt_TipoAnulacion.Visible = false;
            // 
            // lblAnulado
            // 
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(465, 10);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(381, 18);
            this.lblAnulado.TabIndex = 0;
            this.lblAnulado.Text = "**ANULADO**";
            this.lblAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnulado.Visible = false;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(18, 181);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(40, 13);
            this.label43.TabIndex = 14;
            this.label43.Text = "Monto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(501, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Empresa Destino:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(501, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cta. Ban. Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "#Transferencia:";
            // 
            // txt_NTransferencia
            // 
            this.txt_NTransferencia.Location = new System.Drawing.Point(102, 27);
            this.txt_NTransferencia.Name = "txt_NTransferencia";
            this.txt_NTransferencia.ReadOnly = true;
            this.txt_NTransferencia.Size = new System.Drawing.Size(139, 20);
            this.txt_NTransferencia.TabIndex = 0;
            this.txt_NTransferencia.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Empresa Origen:";
            // 
            // dt_fechaCbte
            // 
            this.dt_fechaCbte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechaCbte.Location = new System.Drawing.Point(347, 28);
            this.dt_fechaCbte.Name = "dt_fechaCbte";
            this.dt_fechaCbte.Size = new System.Drawing.Size(98, 20);
            this.dt_fechaCbte.TabIndex = 1;
            this.dt_fechaCbte.Tag = "";
            // 
            // txt_Memo
            // 
            this.txt_Memo.Location = new System.Drawing.Point(102, 217);
            this.txt_Memo.Multiline = true;
            this.txt_Memo.Name = "txt_Memo";
            this.txt_Memo.Size = new System.Drawing.Size(832, 70);
            this.txt_Memo.TabIndex = 7;
            this.txt_Memo.TextChanged += new System.EventHandler(this.txt_Memo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Observación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(18, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cta. Ban. Origen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_ND);
            this.tabControl1.Controls.Add(this.tabPage_NC);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1027, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_ND
            // 
            this.tabPage_ND.Controls.Add(this.panel3);
            this.tabPage_ND.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ND.Name = "tabPage_ND";
            this.tabPage_ND.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ND.Size = new System.Drawing.Size(1019, 260);
            this.tabPage_ND.TabIndex = 0;
            this.tabPage_ND.Text = "N/D";
            this.tabPage_ND.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UC_DiarioND);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1013, 254);
            this.panel3.TabIndex = 36;
            // 
            // tabPage_NC
            // 
            this.tabPage_NC.Controls.Add(this.panel4);
            this.tabPage_NC.Location = new System.Drawing.Point(4, 22);
            this.tabPage_NC.Name = "tabPage_NC";
            this.tabPage_NC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NC.Size = new System.Drawing.Size(1019, 260);
            this.tabPage_NC.TabIndex = 1;
            this.tabPage_NC.Text = "N/C";
            this.tabPage_NC.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.UC_DiarioNC);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1013, 254);
            this.panel4.TabIndex = 40;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 25);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1041, 330);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1033, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Transferencia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1033, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(18, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Flujo origen:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(501, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Flujo destino:";
            // 
            // ucBa_TipoFlujo_origen
            // 
            this.ucBa_TipoFlujo_origen.Location = new System.Drawing.Point(117, 114);
            this.ucBa_TipoFlujo_origen.Name = "ucBa_TipoFlujo_origen";
            this.ucBa_TipoFlujo_origen.Size = new System.Drawing.Size(362, 26);
            this.ucBa_TipoFlujo_origen.TabIndex = 20;
            // 
            // ucBa_CuentaBanco_Destino
            // 
            this.ucBa_CuentaBanco_Destino.Location = new System.Drawing.Point(589, 89);
            this.ucBa_CuentaBanco_Destino.Name = "ucBa_CuentaBanco_Destino";
            this.ucBa_CuentaBanco_Destino.Size = new System.Drawing.Size(396, 27);
            this.ucBa_CuentaBanco_Destino.TabIndex = 19;
            this.ucBa_CuentaBanco_Destino.event_cmb_CuentaBanco_EditValueChanged += new Core.Erp.Winform.Controles.UCBa_CuentaBanco.delegate_cmb_CuentaBanco_EditValueChanged(this.ucBa_CuentaBanco_Destino_event_cmb_CuentaBanco_EditValueChanged);
            // 
            // ucBa_CuentaBanco_Origen
            // 
            this.ucBa_CuentaBanco_Origen.Location = new System.Drawing.Point(117, 85);
            this.ucBa_CuentaBanco_Origen.Name = "ucBa_CuentaBanco_Origen";
            this.ucBa_CuentaBanco_Origen.Size = new System.Drawing.Size(362, 27);
            this.ucBa_CuentaBanco_Origen.TabIndex = 18;
            this.ucBa_CuentaBanco_Origen.event_cmb_CuentaBanco_EditValueChanged += new Core.Erp.Winform.Controles.UCBa_CuentaBanco.delegate_cmb_CuentaBanco_EditValueChanged(this.ucBa_CuentaBanco_Origen_event_cmb_CuentaBanco_EditValueChanged);
            // 
            // em_nombre
            // 
            this.em_nombre.Caption = "Nombre";
            this.em_nombre.FieldName = "em_nombre";
            this.em_nombre.Name = "em_nombre";
            this.em_nombre.Visible = true;
            this.em_nombre.VisibleIndex = 0;
            // 
            // colem_nombre
            // 
            this.colem_nombre.Caption = "Nombre";
            this.colem_nombre.FieldName = "em_nombre";
            this.colem_nombre.Name = "colem_nombre";
            this.colem_nombre.Visible = true;
            this.colem_nombre.VisibleIndex = 0;
            // 
            // ucBa_TipoFlujo_destino
            // 
            this.ucBa_TipoFlujo_destino.Location = new System.Drawing.Point(589, 117);
            this.ucBa_TipoFlujo_destino.Name = "ucBa_TipoFlujo_destino";
            this.ucBa_TipoFlujo_destino.Size = new System.Drawing.Size(395, 26);
            this.ucBa_TipoFlujo_destino.TabIndex = 22;
            // 
            // UC_DiarioND
            // 
            this.UC_DiarioND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_DiarioND.Location = new System.Drawing.Point(0, 0);
            this.UC_DiarioND.Name = "UC_DiarioND";
            this.UC_DiarioND.Size = new System.Drawing.Size(1013, 254);
            this.UC_DiarioND.TabIndex = 0;
            this.UC_DiarioND.Visible_Botones = false;
            this.UC_DiarioND.Visible_Cabecera = false;
            this.UC_DiarioND.Visible_columna_GrupoPuntoCargo = true;
            this.UC_DiarioND.Visible_columna_PuntoCargo = true;
            // 
            // UC_DiarioNC
            // 
            this.UC_DiarioNC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_DiarioNC.Location = new System.Drawing.Point(0, 0);
            this.UC_DiarioNC.Name = "UC_DiarioNC";
            this.UC_DiarioNC.Size = new System.Drawing.Size(1013, 254);
            this.UC_DiarioNC.TabIndex = 1;
            this.UC_DiarioNC.Visible_Botones = false;
            this.UC_DiarioNC.Visible_Cabecera = false;
            this.UC_DiarioNC.Visible_columna_GrupoPuntoCargo = true;
            this.UC_DiarioNC.Visible_columna_PuntoCargo = true;
            // 
            // ucbA_Tipo_NCBA
            // 
            this.ucbA_Tipo_NCBA.Location = new System.Drawing.Point(590, 144);
            this.ucbA_Tipo_NCBA.Name = "ucbA_Tipo_NCBA";
            this.ucbA_Tipo_NCBA.Size = new System.Drawing.Size(396, 26);
            this.ucbA_Tipo_NCBA.TabIndex = 24;
            this.ucbA_Tipo_NCBA.tipoNota = Core.Erp.Info.General.Cl_Enumeradores.eTipoNotaBanco.NCBA;
            // 
            // ucbA_Tipo_NDBA
            // 
            this.ucbA_Tipo_NDBA.Location = new System.Drawing.Point(117, 143);
            this.ucbA_Tipo_NDBA.Name = "ucbA_Tipo_NDBA";
            this.ucbA_Tipo_NDBA.Size = new System.Drawing.Size(365, 26);
            this.ucbA_Tipo_NDBA.TabIndex = 25;
            this.ucbA_Tipo_NDBA.tipoNota = Core.Erp.Info.General.Cl_Enumeradores.eTipoNotaBanco.NDBA;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(501, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tipo NC destino:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(18, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Tipo ND origen:";
            // 
            // FrmBA_Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 355);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.barra);
            this.Name = "FrmBA_Transferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transferencia Bancaria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBA_Transferencia_FormClosing);
            this.Load += new System.EventHandler(this.FrmBA_Transferencia_Load);
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_empresaDest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_empresaOrig.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_ND.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabPage_NC.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barra;
        private System.Windows.Forms.ToolStripButton btn_grabar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_grabarysalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dt_fechaCbte;
        private System.Windows.Forms.TextBox txt_Memo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NTransferencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_ND;
        private System.Windows.Forms.TabPage tabPage_NC;
        private System.Windows.Forms.Panel panel3;
        private Controles.UCCon_GridDiarioContable UC_DiarioND;
        private System.Windows.Forms.Panel panel4;
        private Controles.UCCon_GridDiarioContable UC_DiarioNC;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.Label lblCbt_TipoAnulacion;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.SearchLookUpEdit ultraCmbE_empresaDest;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.SearchLookUpEdit ultraCmbE_empresaOrig;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn em_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colem_nombre;
        private DevExpress.XtraEditors.TextEdit txt_monto;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Controles.UCBa_CuentaBanco ucBa_CuentaBanco_Destino;
        private Controles.UCBa_CuentaBanco ucBa_CuentaBanco_Origen;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Controles.UCBa_TipoFlujo ucBa_TipoFlujo_origen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private Controles.UCBa_TipoFlujo ucBa_TipoFlujo_destino;
        private Controles.UCBA_TipoNota ucbA_Tipo_NCBA;
        private Controles.UCBA_TipoNota ucbA_Tipo_NDBA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}