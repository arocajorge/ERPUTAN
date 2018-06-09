namespace Core.Erp.Winform.ActivoFijo
{
    partial class frmAF_BajaActivo_Mant
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbModelo = new Core.Erp.Winform.Controles.UCAF_Catalogos();
            this.cmbMarca = new Core.Erp.Winform.Controles.UCAF_Catalogos();
            this.cmbUbicacion = new Core.Erp.Winform.Controles.UCAF_Catalogos();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.txtCodMejora = new DevExpress.XtraEditors.TextEdit();
            this.txtIdmejora = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSerie = new DevExpress.XtraEditors.TextEdit();
            this.txtDepreciacion = new DevExpress.XtraEditors.TextEdit();
            this.txtCostoActivo = new DevExpress.XtraEditors.TextEdit();
            this.txtVidaUtil = new DevExpress.XtraEditors.TextEdit();
            this.cmbActivoFijo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridActivoFijo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpc_Cuenta2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_title_id_tipo = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.cmbProveedor = new Core.Erp.Winform.Controles.UCCp_Proveedor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComrobante = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMotivoMejora = new DevExpress.XtraEditors.TextEdit();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtValorMejora = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.ucCon_GridDiarioContable = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodMejora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdmejora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepreciacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVidaUtil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbActivoFijo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridActivoFijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComrobante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoMejora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorMejora.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.ucGe_Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 522);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(816, 493);
            this.splitContainer1.SplitterDistance = 235;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbModelo);
            this.groupBox1.Controls.Add(this.cmbMarca);
            this.groupBox1.Controls.Add(this.cmbUbicacion);
            this.groupBox1.Controls.Add(this.lblAnulado);
            this.groupBox1.Controls.Add(this.txtCodMejora);
            this.groupBox1.Controls.Add(this.txtIdmejora);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.txtDepreciacion);
            this.groupBox1.Controls.Add(this.txtCostoActivo);
            this.groupBox1.Controls.Add(this.txtVidaUtil);
            this.groupBox1.Controls.Add(this.cmbActivoFijo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_title_id_tipo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Activo Fijo";
            // 
            // cmbModelo
            // 
            this.cmbModelo.Enabled = false;
            this.cmbModelo.Enabled_btn_Accion = true;
            this.cmbModelo.Location = new System.Drawing.Point(560, 181);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.ReadOnly_cmbCatalogo = false;
            this.cmbModelo.Size = new System.Drawing.Size(248, 26);
            this.cmbModelo.TabIndex = 130;
            this.cmbModelo.Visible_btn_Accion = true;
            // 
            // cmbMarca
            // 
            this.cmbMarca.Enabled = false;
            this.cmbMarca.Enabled_btn_Accion = true;
            this.cmbMarca.Location = new System.Drawing.Point(560, 148);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.ReadOnly_cmbCatalogo = false;
            this.cmbMarca.Size = new System.Drawing.Size(247, 26);
            this.cmbMarca.TabIndex = 129;
            this.cmbMarca.Visible_btn_Accion = true;
            // 
            // cmbUbicacion
            // 
            this.cmbUbicacion.Enabled = false;
            this.cmbUbicacion.Enabled_btn_Accion = true;
            this.cmbUbicacion.Location = new System.Drawing.Point(108, 142);
            this.cmbUbicacion.Name = "cmbUbicacion";
            this.cmbUbicacion.ReadOnly_cmbCatalogo = false;
            this.cmbUbicacion.Size = new System.Drawing.Size(298, 26);
            this.cmbUbicacion.TabIndex = 128;
            this.cmbUbicacion.Visible_btn_Accion = true;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(513, 23);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(156, 25);
            this.lblAnulado.TabIndex = 127;
            this.lblAnulado.Text = "**ANULADO**";
            this.lblAnulado.Visible = false;
            // 
            // txtCodMejora
            // 
            this.txtCodMejora.Location = new System.Drawing.Point(328, 28);
            this.txtCodMejora.Name = "txtCodMejora";
            this.txtCodMejora.Properties.MaxLength = 20;
            this.txtCodMejora.Size = new System.Drawing.Size(109, 20);
            this.txtCodMejora.TabIndex = 1;
            // 
            // txtIdmejora
            // 
            this.txtIdmejora.Location = new System.Drawing.Point(110, 28);
            this.txtIdmejora.Name = "txtIdmejora";
            this.txtIdmejora.Properties.ReadOnly = true;
            this.txtIdmejora.Size = new System.Drawing.Size(98, 20);
            this.txtIdmejora.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Id Mejora:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(229, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Codigo de Mejora:";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(110, 209);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Properties.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(169, 20);
            this.txtSerie.TabIndex = 10;
            // 
            // txtDepreciacion
            // 
            this.txtDepreciacion.Location = new System.Drawing.Point(563, 114);
            this.txtDepreciacion.Name = "txtDepreciacion";
            this.txtDepreciacion.Properties.ReadOnly = true;
            this.txtDepreciacion.Size = new System.Drawing.Size(169, 20);
            this.txtDepreciacion.TabIndex = 7;
            // 
            // txtCostoActivo
            // 
            this.txtCostoActivo.Location = new System.Drawing.Point(110, 178);
            this.txtCostoActivo.Name = "txtCostoActivo";
            this.txtCostoActivo.Properties.ReadOnly = true;
            this.txtCostoActivo.Size = new System.Drawing.Size(160, 20);
            this.txtCostoActivo.TabIndex = 6;
            // 
            // txtVidaUtil
            // 
            this.txtVidaUtil.Location = new System.Drawing.Point(110, 114);
            this.txtVidaUtil.Name = "txtVidaUtil";
            this.txtVidaUtil.Properties.ReadOnly = true;
            this.txtVidaUtil.Size = new System.Drawing.Size(160, 20);
            this.txtVidaUtil.TabIndex = 4;
            // 
            // cmbActivoFijo
            // 
            this.cmbActivoFijo.Location = new System.Drawing.Point(110, 80);
            this.cmbActivoFijo.Name = "cmbActivoFijo";
            this.cmbActivoFijo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbActivoFijo.Properties.DisplayMember = "Af_Nombre";
            this.cmbActivoFijo.Properties.ValueMember = "IdActivoFijo";
            this.cmbActivoFijo.Properties.View = this.gridActivoFijo;
            this.cmbActivoFijo.Size = new System.Drawing.Size(327, 20);
            this.cmbActivoFijo.TabIndex = 2;
            this.cmbActivoFijo.EditValueChanged += new System.EventHandler(this.cmbActivoFijo_EditValueChanged);
            this.cmbActivoFijo.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cmbActivoFijo_EditValueChanging);
            // 
            // gridActivoFijo
            // 
            this.gridActivoFijo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpc_Cuenta2,
            this.colIdCtaCble,
            this.gridColumn3,
            this.gridColumn4});
            this.gridActivoFijo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridActivoFijo.Name = "gridActivoFijo";
            this.gridActivoFijo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridActivoFijo.OptionsView.ShowAutoFilterRow = true;
            this.gridActivoFijo.OptionsView.ShowGroupPanel = false;
            // 
            // colpc_Cuenta2
            // 
            this.colpc_Cuenta2.Caption = "IdActivo Fijo";
            this.colpc_Cuenta2.FieldName = "Af_Nombre";
            this.colpc_Cuenta2.Name = "colpc_Cuenta2";
            this.colpc_Cuenta2.Visible = true;
            this.colpc_Cuenta2.VisibleIndex = 1;
            this.colpc_Cuenta2.Width = 881;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.Caption = "Codigo";
            this.colIdCtaCble.FieldName = "CodActivoFijo";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.VisibleIndex = 0;
            this.colIdCtaCble.Width = 277;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Id";
            this.gridColumn3.FieldName = "IdActivoFijo";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Encargado";
            this.gridColumn4.FieldName = "Encargado";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Costo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Vida Util:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(476, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "% Depreciacion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ubicacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Serie:";
            // 
            // lbl_title_id_tipo
            // 
            this.lbl_title_id_tipo.AutoSize = true;
            this.lbl_title_id_tipo.Location = new System.Drawing.Point(32, 83);
            this.lbl_title_id_tipo.Name = "lbl_title_id_tipo";
            this.lbl_title_id_tipo.Size = new System.Drawing.Size(61, 13);
            this.lbl_title_id_tipo.TabIndex = 1;
            this.lbl_title_id_tipo.Text = "Activo Fijo:";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(816, 254);
            this.xtraTabControl1.TabIndex = 73;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.cmbProveedor);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.txtComrobante);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.label16);
            this.xtraTabPage1.Controls.Add(this.label7);
            this.xtraTabPage1.Controls.Add(this.label15);
            this.xtraTabPage1.Controls.Add(this.txtMotivoMejora);
            this.xtraTabPage1.Controls.Add(this.dtpFecha);
            this.xtraTabPage1.Controls.Add(this.txtValorMejora);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(810, 226);
            this.xtraTabPage1.Text = "Datos de la Baja";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.Location = new System.Drawing.Point(140, 16);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(298, 26);
            this.cmbProveedor.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Proveedor:";
            // 
            // txtComrobante
            // 
            this.txtComrobante.Location = new System.Drawing.Point(142, 53);
            this.txtComrobante.Name = "txtComrobante";
            this.txtComrobante.Properties.MaxLength = 50;
            this.txtComrobante.Size = new System.Drawing.Size(294, 20);
            this.txtComrobante.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Motivo de Baja:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 13);
            this.label16.TabIndex = 72;
            this.label16.Text = "Comprobante de Baja:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Valor de Baja:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(475, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 70;
            this.label15.Text = "Fecha de Baja:";
            // 
            // txtMotivoMejora
            // 
            this.txtMotivoMejora.Location = new System.Drawing.Point(142, 89);
            this.txtMotivoMejora.Name = "txtMotivoMejora";
            this.txtMotivoMejora.Properties.MaxLength = 500;
            this.txtMotivoMejora.Size = new System.Drawing.Size(589, 20);
            this.txtMotivoMejora.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(557, 24);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(97, 21);
            this.dtpFecha.TabIndex = 4;
            // 
            // txtValorMejora
            // 
            this.txtValorMejora.Location = new System.Drawing.Point(142, 120);
            this.txtValorMejora.Name = "txtValorMejora";
            this.txtValorMejora.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txtValorMejora.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorMejora.Size = new System.Drawing.Size(127, 20);
            this.txtValorMejora.TabIndex = 3;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.ucCon_GridDiarioContable);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(810, 226);
            this.xtraTabPage2.Text = "Diario Contable";
            // 
            // ucCon_GridDiarioContable
            // 
            this.ucCon_GridDiarioContable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCon_GridDiarioContable.Location = new System.Drawing.Point(0, 0);
            this.ucCon_GridDiarioContable.Name = "ucCon_GridDiarioContable";
            this.ucCon_GridDiarioContable.Size = new System.Drawing.Size(810, 226);
            this.ucCon_GridDiarioContable.TabIndex = 0;
            this.ucCon_GridDiarioContable.Visible_Botones = true;
            this.ucCon_GridDiarioContable.Visible_Cabecera = false;
            this.ucCon_GridDiarioContable.Visible_columna_GrupoPuntoCargo = true;
            this.ucCon_GridDiarioContable.Visible_columna_PuntoCargo = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(816, 29);
            this.ucGe_Menu.TabIndex = 0;
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
            // 
            // frmAF_BajaActivo_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 522);
            this.Controls.Add(this.panel1);
            this.Name = "frmAF_BajaActivo_Mant";
            this.Text = "frmAF_BajaActivo_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAF_BajaActivo_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmAF_BajaActivo_Mant_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodMejora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdmejora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepreciacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVidaUtil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbActivoFijo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridActivoFijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComrobante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoMejora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorMejora.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.TextEdit txtCodMejora;
        private DevExpress.XtraEditors.TextEdit txtIdmejora;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.TextEdit txtSerie;
        private DevExpress.XtraEditors.TextEdit txtDepreciacion;
        private DevExpress.XtraEditors.TextEdit txtCostoActivo;
        private DevExpress.XtraEditors.TextEdit txtVidaUtil;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbActivoFijo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridActivoFijo;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_title_id_tipo;
        private DevExpress.XtraEditors.TextEdit txtComrobante;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private DevExpress.XtraEditors.TextEdit txtValorMejora;
        private DevExpress.XtraEditors.TextEdit txtMotivoMejora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Controles.UCCon_GridDiarioContable ucCon_GridDiarioContable;
        private Controles.UCAF_Catalogos cmbModelo;
        private Controles.UCAF_Catalogos cmbMarca;
        private Controles.UCAF_Catalogos cmbUbicacion;
        private Controles.UCCp_Proveedor cmbProveedor;
    }
}