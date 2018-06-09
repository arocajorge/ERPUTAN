namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_OrdenGiroMantenimiento_simplificada
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOG = new System.Windows.Forms.TabPage();
            this.txe_valor_restar = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_Cbte_Electronico = new System.Windows.Forms.CheckBox();
            this.label39 = new System.Windows.Forms.Label();
            this.cmb_tipoOG = new System.Windows.Forms.ComboBox();
            this.txt_NOrdeG = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txE_BaseImponible = new DevExpress.XtraEditors.TextEdit();
            this.uCct_CentroCosto1 = new Core.Erp.Reportes.Controles.UCct_CentroCosto();
            this.label2 = new System.Windows.Forms.Label();
            this.uCct_Pto_Cargo1 = new Core.Erp.Reportes.Controles.UCct_Pto_Cargo();
            this.label1 = new System.Windows.Forms.Label();
            this.ucCaj_MovEgresoCaj_cmb1 = new Core.Erp.Winform.Controles.UCCaj_MovEgresoCaj_cmb();
            this.dtp_fechaOG = new DevExpress.XtraEditors.DateEdit();
            this.uCMenu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.txE_total = new DevExpress.XtraEditors.TextEdit();
            this.label38 = new System.Windows.Forms.Label();
            this.txE_SubTotal0 = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txE_subTotalIVA_12 = new DevExpress.XtraEditors.TextEdit();
            this.txE_valorIVA = new DevExpress.XtraEditors.TextEdit();
            this.txE_IVA = new DevExpress.XtraEditors.TextEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txeIdNumAutoriza = new DevExpress.XtraEditors.TextEdit();
            this.label52 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.txeNumDocum = new DevExpress.XtraEditors.TextEdit();
            this.txeSerie = new DevExpress.XtraEditors.TextEdit();
            this.txt_observacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cmb_idtCredito = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_descriConcate_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdCodigo_SRI_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucCp_Proveedor1 = new Core.Erp.Winform.Controles.UCCp_Proveedor();
            this.cmbTipoDocu = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView14 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion_td = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTipoDocumento_td = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label22 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageDiario = new System.Windows.Forms.TabPage();
            this.UC_Diario_x_cxp = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.tabControl1.SuspendLayout();
            this.tabPageOG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txe_valor_restar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txE_BaseImponible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fechaOG.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fechaOG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txE_total.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txE_SubTotal0.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txE_subTotalIVA_12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txE_valorIVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txE_IVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeIdNumAutoriza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeNumDocum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idtCredito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoDocu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).BeginInit();
            this.tabPageDiario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOG);
            this.tabControl1.Controls.Add(this.tabPageDiario);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageOG
            // 
            this.tabPageOG.Controls.Add(this.txe_valor_restar);
            this.tabPageOG.Controls.Add(this.label4);
            this.tabPageOG.Controls.Add(this.chk_Cbte_Electronico);
            this.tabPageOG.Controls.Add(this.label39);
            this.tabPageOG.Controls.Add(this.cmb_tipoOG);
            this.tabPageOG.Controls.Add(this.txt_NOrdeG);
            this.tabPageOG.Controls.Add(this.label25);
            this.tabPageOG.Controls.Add(this.label3);
            this.tabPageOG.Controls.Add(this.txE_BaseImponible);
            this.tabPageOG.Controls.Add(this.uCct_CentroCosto1);
            this.tabPageOG.Controls.Add(this.label2);
            this.tabPageOG.Controls.Add(this.uCct_Pto_Cargo1);
            this.tabPageOG.Controls.Add(this.label1);
            this.tabPageOG.Controls.Add(this.ucCaj_MovEgresoCaj_cmb1);
            this.tabPageOG.Controls.Add(this.dtp_fechaOG);
            this.tabPageOG.Controls.Add(this.uCMenu);
            this.tabPageOG.Controls.Add(this.txE_total);
            this.tabPageOG.Controls.Add(this.label38);
            this.tabPageOG.Controls.Add(this.txE_SubTotal0);
            this.tabPageOG.Controls.Add(this.label10);
            this.tabPageOG.Controls.Add(this.txE_subTotalIVA_12);
            this.tabPageOG.Controls.Add(this.txE_valorIVA);
            this.tabPageOG.Controls.Add(this.txE_IVA);
            this.tabPageOG.Controls.Add(this.label17);
            this.tabPageOG.Controls.Add(this.label12);
            this.tabPageOG.Controls.Add(this.label9);
            this.tabPageOG.Controls.Add(this.txeIdNumAutoriza);
            this.tabPageOG.Controls.Add(this.label52);
            this.tabPageOG.Controls.Add(this.label56);
            this.tabPageOG.Controls.Add(this.label55);
            this.tabPageOG.Controls.Add(this.label54);
            this.tabPageOG.Controls.Add(this.txeNumDocum);
            this.tabPageOG.Controls.Add(this.txeSerie);
            this.tabPageOG.Controls.Add(this.txt_observacion);
            this.tabPageOG.Controls.Add(this.label8);
            this.tabPageOG.Controls.Add(this.label27);
            this.tabPageOG.Controls.Add(this.cmb_idtCredito);
            this.tabPageOG.Controls.Add(this.ucCp_Proveedor1);
            this.tabPageOG.Controls.Add(this.cmbTipoDocu);
            this.tabPageOG.Controls.Add(this.label22);
            this.tabPageOG.Controls.Add(this.label30);
            this.tabPageOG.Controls.Add(this.label7);
            this.tabPageOG.Location = new System.Drawing.Point(4, 22);
            this.tabPageOG.Name = "tabPageOG";
            this.tabPageOG.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOG.Size = new System.Drawing.Size(835, 475);
            this.tabPageOG.TabIndex = 0;
            this.tabPageOG.Text = "Factura";
            this.tabPageOG.UseVisualStyleBackColor = true;
            // 
            // txe_valor_restar
            // 
            this.txe_valor_restar.Location = new System.Drawing.Point(139, 383);
            this.txe_valor_restar.Name = "txe_valor_restar";
            this.txe_valor_restar.Properties.DisplayFormat.FormatString = "#,#######0.00 ;#,#######0.00";
            this.txe_valor_restar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txe_valor_restar.Properties.EditFormat.FormatString = "#,#######0.00 ;#,#######0.00";
            this.txe_valor_restar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txe_valor_restar.Properties.Mask.EditMask = "#,#######0.00 ;#,#######0.00 ";
            this.txe_valor_restar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txe_valor_restar.Size = new System.Drawing.Size(132, 20);
            this.txe_valor_restar.TabIndex = 173;
            this.txe_valor_restar.EditValueChanged += new System.EventHandler(this.txe_valor_restar_EditValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 172;
            this.label4.Text = "Valor a restar:";
            // 
            // chk_Cbte_Electronico
            // 
            this.chk_Cbte_Electronico.AutoSize = true;
            this.chk_Cbte_Electronico.Location = new System.Drawing.Point(393, 41);
            this.chk_Cbte_Electronico.Name = "chk_Cbte_Electronico";
            this.chk_Cbte_Electronico.Size = new System.Drawing.Size(145, 17);
            this.chk_Cbte_Electronico.TabIndex = 171;
            this.chk_Cbte_Electronico.Text = "Comprobante Electrónico";
            this.chk_Cbte_Electronico.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(225, 42);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(31, 13);
            this.label39.TabIndex = 170;
            this.label39.Text = "Tipo:";
            // 
            // cmb_tipoOG
            // 
            this.cmb_tipoOG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoOG.FormattingEnabled = true;
            this.cmb_tipoOG.Items.AddRange(new object[] {
            "BIEN",
            "SERVI",
            "AMBAS"});
            this.cmb_tipoOG.Location = new System.Drawing.Point(262, 39);
            this.cmb_tipoOG.Name = "cmb_tipoOG";
            this.cmb_tipoOG.Size = new System.Drawing.Size(125, 21);
            this.cmb_tipoOG.TabIndex = 169;
            // 
            // txt_NOrdeG
            // 
            this.txt_NOrdeG.Location = new System.Drawing.Point(138, 41);
            this.txt_NOrdeG.Name = "txt_NOrdeG";
            this.txt_NOrdeG.ReadOnly = true;
            this.txt_NOrdeG.Size = new System.Drawing.Size(75, 20);
            this.txt_NOrdeG.TabIndex = 165;
            this.txt_NOrdeG.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(32, 44);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 164;
            this.label25.Text = "#Comp CxP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 163;
            this.label3.Text = "Base imponible:";
            // 
            // txE_BaseImponible
            // 
            this.txE_BaseImponible.Location = new System.Drawing.Point(362, 357);
            this.txE_BaseImponible.Name = "txE_BaseImponible";
            this.txE_BaseImponible.Properties.DisplayFormat.FormatString = "#,#######0.00 ;#,#######0.00";
            this.txE_BaseImponible.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txE_BaseImponible.Properties.EditFormat.FormatString = "#,#######0.00 ;#,#######0.00";
            this.txE_BaseImponible.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txE_BaseImponible.Properties.Mask.EditMask = "#,#######0.00 ;#,#######0.00 ";
            this.txE_BaseImponible.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txE_BaseImponible.Properties.ReadOnly = true;
            this.txE_BaseImponible.Size = new System.Drawing.Size(138, 20);
            this.txE_BaseImponible.TabIndex = 162;
            // 
            // uCct_CentroCosto1
            // 
            this.uCct_CentroCosto1.Location = new System.Drawing.Point(508, 97);
            this.uCct_CentroCosto1.Mostrar_Registro_Todos = false;
            this.uCct_CentroCosto1.Name = "uCct_CentroCosto1";
            this.uCct_CentroCosto1.Size = new System.Drawing.Size(319, 51);
            this.uCct_CentroCosto1.TabIndex = 160;
            this.uCct_CentroCosto1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 159;
            this.label2.Text = "Punto de cargo:";
            // 
            // uCct_Pto_Cargo1
            // 
            this.uCct_Pto_Cargo1.Location = new System.Drawing.Point(132, 296);
            this.uCct_Pto_Cargo1.Mostrar_Registro_Todos = false;
            this.uCct_Pto_Cargo1.Name = "uCct_Pto_Cargo1";
            this.uCct_Pto_Cargo1.Size = new System.Drawing.Size(381, 28);
            this.uCct_Pto_Cargo1.TabIndex = 158;
            this.uCct_Pto_Cargo1.event_delegate_cmb_Pto_Cargo_EditValueChanged += new Core.Erp.Reportes.Controles.UCct_Pto_Cargo.delegate_cmb_Pto_Cargo_EditValueChanged(this.uCct_Pto_Cargo1_event_delegate_cmb_Pto_Cargo_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 157;
            this.label1.Text = "Motivo:";
            // 
            // ucCaj_MovEgresoCaj_cmb1
            // 
            this.ucCaj_MovEgresoCaj_cmb1.Location = new System.Drawing.Point(138, 146);
            this.ucCaj_MovEgresoCaj_cmb1.Name = "ucCaj_MovEgresoCaj_cmb1";
            this.ucCaj_MovEgresoCaj_cmb1.Size = new System.Drawing.Size(362, 26);
            this.ucCaj_MovEgresoCaj_cmb1.TabIndex = 156;
            this.ucCaj_MovEgresoCaj_cmb1.event_cmbTipoMoviCaja_EditValueChanged += new Core.Erp.Winform.Controles.UCCaj_MovEgresoCaj_cmb.delegate_cmbTipoMoviCaja_EditValueChanged(this.ucCaj_MovEgresoCaj_cmb1_event_cmbTipoMoviCaja_EditValueChanged);
            // 
            // dtp_fechaOG
            // 
            this.dtp_fechaOG.EditValue = new System.DateTime(2017, 4, 5, 12, 33, 38, 547);
            this.dtp_fechaOG.Location = new System.Drawing.Point(613, 67);
            this.dtp_fechaOG.Name = "dtp_fechaOG";
            this.dtp_fechaOG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_fechaOG.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtp_fechaOG.Size = new System.Drawing.Size(100, 20);
            this.dtp_fechaOG.TabIndex = 154;
            // 
            // uCMenu
            // 
            this.uCMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.uCMenu.Enabled_bnRetImprimir = true;
            this.uCMenu.Enabled_bntAnular = true;
            this.uCMenu.Enabled_bntAprobar = true;
            this.uCMenu.Enabled_bntGuardar_y_Salir = true;
            this.uCMenu.Enabled_bntImprimir = true;
            this.uCMenu.Enabled_bntImprimir_Guia = true;
            this.uCMenu.Enabled_bntLimpiar = true;
            this.uCMenu.Enabled_bntSalir = true;
            this.uCMenu.Enabled_btn_conciliacion_Auto = true;
            this.uCMenu.Enabled_btn_DiseñoReporte = true;
            this.uCMenu.Enabled_btn_Generar_XML = true;
            this.uCMenu.Enabled_btn_Imprimir_Cbte = true;
            this.uCMenu.Enabled_btn_Imprimir_Cheq = true;
            this.uCMenu.Enabled_btn_Imprimir_Reten = true;
            this.uCMenu.Enabled_btnAceptar = true;
            this.uCMenu.Enabled_btnAprobarGuardarSalir = true;
            this.uCMenu.Enabled_btnEstadosOC = true;
            this.uCMenu.Enabled_btnGuardar = true;
            this.uCMenu.Enabled_btnImpFrm = true;
            this.uCMenu.Enabled_btnImpLote = true;
            this.uCMenu.Enabled_btnImpRep = true;
            this.uCMenu.Enabled_btnImprimirSoporte = true;
            this.uCMenu.Enabled_btnproductos = true;
            this.uCMenu.Location = new System.Drawing.Point(3, 3);
            this.uCMenu.Name = "uCMenu";
            this.uCMenu.Size = new System.Drawing.Size(829, 30);
            this.uCMenu.TabIndex = 153;
            this.uCMenu.Visible_bntAnular = true;
            this.uCMenu.Visible_bntAprobar = false;
            this.uCMenu.Visible_bntDiseñoReporte = false;
            this.uCMenu.Visible_bntGuardar_y_Salir = false;
            this.uCMenu.Visible_bntImprimir = true;
            this.uCMenu.Visible_bntImprimir_Guia = false;
            this.uCMenu.Visible_bntLimpiar = true;
            this.uCMenu.Visible_bntReImprimir = false;
            this.uCMenu.Visible_bntSalir = true;
            this.uCMenu.Visible_btn_Actualizar = false;
            this.uCMenu.Visible_btn_conciliacion_Auto = false;
            this.uCMenu.Visible_btn_Generar_XML = false;
            this.uCMenu.Visible_btn_Imprimir_Cbte = false;
            this.uCMenu.Visible_btn_Imprimir_Cheq = false;
            this.uCMenu.Visible_btn_Imprimir_Reten = false;
            this.uCMenu.Visible_btnAceptar = false;
            this.uCMenu.Visible_btnAprobarGuardarSalir = false;
            this.uCMenu.Visible_btnContabilizar = false;
            this.uCMenu.Visible_btnEstadosOC = false;
            this.uCMenu.Visible_btnGuardar = true;
            this.uCMenu.Visible_btnImpFrm = false;
            this.uCMenu.Visible_btnImpLote = false;
            this.uCMenu.Visible_btnImpRep = false;
            this.uCMenu.Visible_btnImprimirSoporte = false;
            this.uCMenu.Visible_btnModificar = false;
            this.uCMenu.Visible_btnproductos = false;
            this.uCMenu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.uCMenu_event_btnGuardar_Click);
            this.uCMenu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.uCMenu_event_btnGuardar_y_Salir_Click);
            this.uCMenu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.uCMenu_event_btnSalir_Click);
            // 
            // txE_total
            // 
            this.txE_total.Location = new System.Drawing.Point(140, 409);
            this.txE_total.Name = "txE_total";
            this.txE_total.Properties.DisplayFormat.FormatString = "#,#######0.00 ;#,#######0.00";
            this.txE_total.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txE_total.Properties.EditFormat.FormatString = "#,#######0.00 ;#,#######0.00";
            this.txE_total.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txE_total.Properties.Mask.EditMask = "#,#######0.00 ;#,#######0.00 ";
            this.txE_total.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txE_total.Properties.ReadOnly = true;
            this.txE_total.Size = new System.Drawing.Size(131, 20);
            this.txE_total.TabIndex = 152;
            this.txE_total.EditValueChanged += new System.EventHandler(this.txE_total_EditValueChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label38.Location = new System.Drawing.Point(37, 412);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(40, 13);
            this.label38.TabIndex = 151;
            this.label38.Text = "Total:";
            // 
            // txE_SubTotal0
            // 
            this.txE_SubTotal0.Location = new System.Drawing.Point(362, 331);
            this.txE_SubTotal0.Name = "txE_SubTotal0";
            this.txE_SubTotal0.Properties.DisplayFormat.FormatString = "#,#######0.00 ;#,#######0.00";
            this.txE_SubTotal0.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txE_SubTotal0.Properties.EditFormat.FormatString = "#,#######0.00 ;#,#######0.00";
            this.txE_SubTotal0.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txE_SubTotal0.Properties.Mask.EditMask = "#,#######0.00 ;#,#######0.00 ";
            this.txE_SubTotal0.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txE_SubTotal0.Size = new System.Drawing.Size(138, 20);
            this.txE_SubTotal0.TabIndex = 150;
            this.txE_SubTotal0.EditValueChanged += new System.EventHandler(this.txE_SubTotal0_EditValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 149;
            this.label10.Text = "SubTotal 0:";
            // 
            // txE_subTotalIVA_12
            // 
            this.txE_subTotalIVA_12.Location = new System.Drawing.Point(139, 331);
            this.txE_subTotalIVA_12.Name = "txE_subTotalIVA_12";
            this.txE_subTotalIVA_12.Properties.DisplayFormat.FormatString = "#,#######0.00 ;#,#######0.00";
            this.txE_subTotalIVA_12.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txE_subTotalIVA_12.Properties.EditFormat.FormatString = "#,#######0.00 ;#,#######0.00";
            this.txE_subTotalIVA_12.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txE_subTotalIVA_12.Properties.Mask.EditMask = "#,#######0.00 ;#,#######0.00 ";
            this.txE_subTotalIVA_12.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txE_subTotalIVA_12.Size = new System.Drawing.Size(132, 20);
            this.txE_subTotalIVA_12.TabIndex = 148;
            this.txE_subTotalIVA_12.EditValueChanged += new System.EventHandler(this.txE_subTotalIVA_12_EditValueChanged);
            // 
            // txE_valorIVA
            // 
            this.txE_valorIVA.Location = new System.Drawing.Point(140, 357);
            this.txE_valorIVA.Name = "txE_valorIVA";
            this.txE_valorIVA.Properties.DisplayFormat.FormatString = "#,#######0.00 ;#,#######0.00 ";
            this.txE_valorIVA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txE_valorIVA.Properties.EditFormat.FormatString = "#,#######0.00 ;#,#######0.00 ";
            this.txE_valorIVA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txE_valorIVA.Properties.Mask.EditMask = "#,#######0.00 ;#,#######0.00 ";
            this.txE_valorIVA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txE_valorIVA.Properties.ReadOnly = true;
            this.txE_valorIVA.Size = new System.Drawing.Size(131, 20);
            this.txE_valorIVA.TabIndex = 147;
            // 
            // txE_IVA
            // 
            this.txE_IVA.Location = new System.Drawing.Point(70, 357);
            this.txE_IVA.Name = "txE_IVA";
            this.txE_IVA.Size = new System.Drawing.Size(40, 20);
            this.txE_IVA.TabIndex = 146;
            this.txE_IVA.EditValueChanged += new System.EventHandler(this.txE_IVA_EditValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(118, 360);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 13);
            this.label17.TabIndex = 145;
            this.label17.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 144;
            this.label12.Text = "IVA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 143;
            this.label9.Text = "SubTotal IVA:";
            // 
            // txeIdNumAutoriza
            // 
            this.txeIdNumAutoriza.Location = new System.Drawing.Point(134, 216);
            this.txeIdNumAutoriza.Name = "txeIdNumAutoriza";
            this.txeIdNumAutoriza.Properties.Mask.EditMask = "\\d{0,49}";
            this.txeIdNumAutoriza.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txeIdNumAutoriza.Properties.MaxLength = 49;
            this.txeIdNumAutoriza.Size = new System.Drawing.Size(361, 20);
            this.txeIdNumAutoriza.TabIndex = 142;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(32, 219);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(96, 13);
            this.label52.TabIndex = 141;
            this.label52.Text = "#Autorizacion SRI:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(240, 175);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(72, 13);
            this.label56.TabIndex = 140;
            this.label56.Text = "# Documento";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(135, 175);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(31, 13);
            this.label55.TabIndex = 139;
            this.label55.Text = "Serie";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(32, 193);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(65, 13);
            this.label54.TabIndex = 138;
            this.label54.Text = "Documento:";
            // 
            // txeNumDocum
            // 
            this.txeNumDocum.Location = new System.Drawing.Point(243, 190);
            this.txeNumDocum.Name = "txeNumDocum";
            this.txeNumDocum.Properties.Mask.EditMask = "\\d{0,9}";
            this.txeNumDocum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txeNumDocum.Size = new System.Drawing.Size(252, 20);
            this.txeNumDocum.TabIndex = 137;
            this.txeNumDocum.EditValueChanged += new System.EventHandler(this.txeNumDocum_EditValueChanged);
            // 
            // txeSerie
            // 
            this.txeSerie.Location = new System.Drawing.Point(135, 190);
            this.txeSerie.Name = "txeSerie";
            this.txeSerie.Properties.Mask.EditMask = "\\d\\d\\d-\\d\\d\\d";
            this.txeSerie.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txeSerie.Size = new System.Drawing.Size(99, 20);
            this.txeSerie.TabIndex = 136;
            // 
            // txt_observacion
            // 
            this.txt_observacion.Location = new System.Drawing.Point(134, 242);
            this.txt_observacion.Multiline = true;
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(361, 48);
            this.txt_observacion.TabIndex = 134;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 135;
            this.label8.Text = "Concepto:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(552, 69);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(46, 13);
            this.label27.TabIndex = 133;
            this.label27.Text = "Fecha:";
            // 
            // cmb_idtCredito
            // 
            this.cmb_idtCredito.Location = new System.Drawing.Point(138, 94);
            this.cmb_idtCredito.Name = "cmb_idtCredito";
            this.cmb_idtCredito.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_idtCredito.Properties.View = this.gridView7;
            this.cmb_idtCredito.Size = new System.Drawing.Size(357, 20);
            this.cmb_idtCredito.TabIndex = 125;
            this.cmb_idtCredito.EditValueChanged += new System.EventHandler(this.cmb_idtCredito_EditValueChanged);
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_descriConcate_,
            this.col_IdCodigo_SRI_});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // col_descriConcate_
            // 
            this.col_descriConcate_.Caption = "Descripcion";
            this.col_descriConcate_.FieldName = "descriConcate";
            this.col_descriConcate_.Name = "col_descriConcate_";
            this.col_descriConcate_.Visible = true;
            this.col_descriConcate_.VisibleIndex = 0;
            // 
            // col_IdCodigo_SRI_
            // 
            this.col_IdCodigo_SRI_.Caption = "ID";
            this.col_IdCodigo_SRI_.FieldName = "IdCodigo_SRI";
            this.col_IdCodigo_SRI_.Name = "col_IdCodigo_SRI_";
            // 
            // ucCp_Proveedor1
            // 
            this.ucCp_Proveedor1.Location = new System.Drawing.Point(135, 67);
            this.ucCp_Proveedor1.Name = "ucCp_Proveedor1";
            this.ucCp_Proveedor1.Size = new System.Drawing.Size(360, 26);
            this.ucCp_Proveedor1.TabIndex = 124;
            // 
            // cmbTipoDocu
            // 
            this.cmbTipoDocu.Location = new System.Drawing.Point(138, 120);
            this.cmbTipoDocu.Name = "cmbTipoDocu";
            this.cmbTipoDocu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoDocu.Properties.View = this.gridView14;
            this.cmbTipoDocu.Size = new System.Drawing.Size(357, 20);
            this.cmbTipoDocu.TabIndex = 123;
            // 
            // gridView14
            // 
            this.gridView14.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion_td,
            this.colCodTipoDocumento_td});
            this.gridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView14.Name = "gridView14";
            this.gridView14.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView14.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion_td
            // 
            this.colDescripcion_td.Caption = "Descripción";
            this.colDescripcion_td.FieldName = "Descripcion";
            this.colDescripcion_td.Name = "colDescripcion_td";
            this.colDescripcion_td.Visible = true;
            this.colDescripcion_td.VisibleIndex = 0;
            this.colDescripcion_td.Width = 885;
            // 
            // colCodTipoDocumento_td
            // 
            this.colCodTipoDocumento_td.Caption = "Código";
            this.colCodTipoDocumento_td.FieldName = "CodTipoDocumento";
            this.colCodTipoDocumento_td.Name = "colCodTipoDocumento_td";
            this.colCodTipoDocumento_td.Visible = true;
            this.colCodTipoDocumento_td.VisibleIndex = 1;
            this.colCodTipoDocumento_td.Width = 295;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(32, 97);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 13);
            this.label22.TabIndex = 122;
            this.label22.Text = "Sustento Tributario:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(32, 124);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(104, 13);
            this.label30.TabIndex = 121;
            this.label30.Text = "Tipo de Documento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "Proveedor:";
            // 
            // tabPageDiario
            // 
            this.tabPageDiario.Controls.Add(this.UC_Diario_x_cxp);
            this.tabPageDiario.Location = new System.Drawing.Point(4, 22);
            this.tabPageDiario.Name = "tabPageDiario";
            this.tabPageDiario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDiario.Size = new System.Drawing.Size(835, 475);
            this.tabPageDiario.TabIndex = 1;
            this.tabPageDiario.Text = "Diario";
            this.tabPageDiario.UseVisualStyleBackColor = true;
            // 
            // UC_Diario_x_cxp
            // 
            this.UC_Diario_x_cxp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_Diario_x_cxp.IdCtaCble_x_Banco = null;
            this.UC_Diario_x_cxp.Location = new System.Drawing.Point(3, 3);
            this.UC_Diario_x_cxp.Name = "UC_Diario_x_cxp";
            this.UC_Diario_x_cxp.Size = new System.Drawing.Size(829, 469);
            this.UC_Diario_x_cxp.TabIndex = 37;
            this.UC_Diario_x_cxp.Visible_Botones = false;
            this.UC_Diario_x_cxp.Visible_Cabecera = false;
            this.UC_Diario_x_cxp.Visible_columna_GrupoPuntoCargo = true;
            this.UC_Diario_x_cxp.Visible_columna_PuntoCargo = true;
            // 
            // frmCP_OrdenGiroMantenimiento_simplificada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 501);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCP_OrdenGiroMantenimiento_simplificada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura por proveedor";
            this.Load += new System.EventHandler(this.frmCP_OrdenGiroMantenimiento_simplificada_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOG.ResumeLayout(false);
            this.tabPageOG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txe_valor_restar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txE_BaseImponible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fechaOG.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fechaOG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txE_total.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txE_SubTotal0.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txE_subTotalIVA_12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txE_valorIVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txE_IVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeIdNumAutoriza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeNumDocum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idtCredito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoDocu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).EndInit();
            this.tabPageDiario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOG;
        private System.Windows.Forms.TabPage tabPageDiario;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_idtCredito;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn col_descriConcate_;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdCodigo_SRI_;
        private Controles.UCCp_Proveedor ucCp_Proveedor1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipoDocu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView14;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_td;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTipoDocumento_td;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txt_observacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private DevExpress.XtraEditors.TextEdit txeNumDocum;
        private DevExpress.XtraEditors.TextEdit txeSerie;
        private DevExpress.XtraEditors.TextEdit txeIdNumAutoriza;
        private System.Windows.Forms.Label label52;
        private DevExpress.XtraEditors.TextEdit txE_subTotalIVA_12;
        private DevExpress.XtraEditors.TextEdit txE_valorIVA;
        private DevExpress.XtraEditors.TextEdit txE_IVA;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txE_SubTotal0;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txE_total;
        private System.Windows.Forms.Label label38;
        private Controles.UCGe_Menu_Superior_Mant uCMenu;
        private DevExpress.XtraEditors.DateEdit dtp_fechaOG;
        private Controles.UCCaj_MovEgresoCaj_cmb ucCaj_MovEgresoCaj_cmb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Reportes.Controles.UCct_Pto_Cargo uCct_Pto_Cargo1;
        private Reportes.Controles.UCct_CentroCosto uCct_CentroCosto1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txE_BaseImponible;
        private Controles.UCCon_GridDiarioContable UC_Diario_x_cxp;
        private System.Windows.Forms.TextBox txt_NOrdeG;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox cmb_tipoOG;
        private System.Windows.Forms.CheckBox chk_Cbte_Electronico;
        private DevExpress.XtraEditors.TextEdit txe_valor_restar;
        private System.Windows.Forms.Label label4;
    }
}