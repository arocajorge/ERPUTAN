namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_DepositoBancario_Mant
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridControlCobros = new DevExpress.XtraGrid.GridControl();
            this.UltraGrid_Cobros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Chek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cr_TotalCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Caja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cr_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageValoresAdep = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chk_Seleccionar_visibles = new DevExpress.XtraEditors.CheckEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_TipoMovCaj = new System.Windows.Forms.ComboBox();
            this.tabPageDiario = new System.Windows.Forms.TabPage();
            this.ucCon_GridDiarioDeposito = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.label43 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txe_totalIngreso = new DevExpress.XtraEditors.TextEdit();
            this.txe_totalDepositar = new DevExpress.XtraEditors.TextEdit();
            this.txe_totalEgreso = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UCSucursal = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.ucBa_CuentaBanco = new Core.Erp.Winform.Controles.UCBa_CuentaBanco();
            this.label1 = new System.Windows.Forms.Label();
            this.ucBa_TipoFlujo = new Core.Erp.Winform.Controles.UCBa_TipoFlujo();
            this.lblCbt_TipoAnulacion = new System.Windows.Forms.Label();
            this.lb_Anulado = new System.Windows.Forms.Label();
            this.dt_fechaCbte = new System.Windows.Forms.DateTimePicker();
            this.txt_Ncomprobante = new System.Windows.Forms.TextBox();
            this.txt_Memo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.baBancoCuentaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCobros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_Cobros)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageValoresAdep.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Seleccionar_visibles.Properties)).BeginInit();
            this.tabPageDiario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txe_totalIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_totalDepositar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_totalEgreso.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baBancoCuentaInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCobros
            // 
            this.gridControlCobros.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlCobros.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlCobros.Location = new System.Drawing.Point(0, 0);
            this.gridControlCobros.MainView = this.UltraGrid_Cobros;
            this.gridControlCobros.Name = "gridControlCobros";
            this.gridControlCobros.Size = new System.Drawing.Size(1079, 249);
            this.gridControlCobros.TabIndex = 0;
            this.gridControlCobros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGrid_Cobros});
            this.gridControlCobros.Click += new System.EventHandler(this.gridControlCobros_Click);
            // 
            // UltraGrid_Cobros
            // 
            this.UltraGrid_Cobros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Chek,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn22,
            this.gridColumn3,
            this.gridColumn1,
            this.cr_TotalCobro,
            this.Caja,
            this.Tipo,
            this.cr_fecha,
            this.gridColumnIdCtaCble});
            this.UltraGrid_Cobros.GridControl = this.gridControlCobros;
            this.UltraGrid_Cobros.Name = "UltraGrid_Cobros";
            this.UltraGrid_Cobros.OptionsView.ShowAutoFilterRow = true;
            this.UltraGrid_Cobros.OptionsView.ShowFooter = true;
            this.UltraGrid_Cobros.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.UltraGrid_Cobros.OptionsView.ShowGroupPanel = false;
            this.UltraGrid_Cobros.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.UltraGrid_Cobros_RowClick);
            this.UltraGrid_Cobros.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.UltraGrid_Cobros_CellValueChanged);
            // 
            // Chek
            // 
            this.Chek.Caption = "*";
            this.Chek.FieldName = "chek";
            this.Chek.Name = "Chek";
            this.Chek.OptionsColumn.AllowEdit = false;
            this.Chek.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.Chek.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Chek.Visible = true;
            this.Chek.VisibleIndex = 0;
            this.Chek.Width = 36;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Sucursal";
            this.gridColumn2.FieldName = "nSucursal";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 55;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cliente/Beneficiario";
            this.gridColumn4.FieldName = "nCliente";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 123;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Observación";
            this.gridColumn5.FieldName = "cr_observacion";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 132;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "F. Cobro";
            this.gridColumn7.FieldName = "cr_fechaCobro";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            this.gridColumn7.Width = 67;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "# Cheque";
            this.gridColumn8.FieldName = "cr_NumDocumento";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 9;
            this.gridColumn8.Width = 72;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Banco";
            this.gridColumn9.FieldName = "cr_Banco";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 10;
            this.gridColumn9.Width = 83;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "# Cuenta";
            this.gridColumn10.FieldName = "cr_cuenta";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 11;
            this.gridColumn10.Width = 79;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "# Recibo";
            this.gridColumn22.FieldName = "cr_recibo";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.OptionsColumn.AllowEdit = false;
            this.gridColumn22.Width = 68;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "#Cobro/ #Movi. Caja";
            this.gridColumn3.FieldName = "IdCobro";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 56;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tipo Cobro";
            this.gridColumn1.FieldName = "IdCobro_tipo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 12;
            this.gridColumn1.Width = 67;
            // 
            // cr_TotalCobro
            // 
            this.cr_TotalCobro.Caption = "T. Cobro";
            this.cr_TotalCobro.FieldName = "cr_TotalCobro";
            this.cr_TotalCobro.Name = "cr_TotalCobro";
            this.cr_TotalCobro.OptionsColumn.AllowEdit = false;
            this.cr_TotalCobro.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.cr_TotalCobro.Visible = true;
            this.cr_TotalCobro.VisibleIndex = 13;
            this.cr_TotalCobro.Width = 78;
            // 
            // Caja
            // 
            this.Caja.Caption = "Caja";
            this.Caja.FieldName = "Caja";
            this.Caja.Name = "Caja";
            this.Caja.Visible = true;
            this.Caja.VisibleIndex = 2;
            this.Caja.Width = 70;
            // 
            // Tipo
            // 
            this.Tipo.Caption = "Tipo";
            this.Tipo.FieldName = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Visible = true;
            this.Tipo.VisibleIndex = 1;
            this.Tipo.Width = 70;
            // 
            // cr_fecha
            // 
            this.cr_fecha.Caption = "Fecha";
            this.cr_fecha.FieldName = "cr_fecha";
            this.cr_fecha.Name = "cr_fecha";
            this.cr_fecha.Visible = true;
            this.cr_fecha.VisibleIndex = 7;
            // 
            // gridColumnIdCtaCble
            // 
            this.gridColumnIdCtaCble.Caption = "IdCtaCble";
            this.gridColumnIdCtaCble.FieldName = "IdCtaCble";
            this.gridColumnIdCtaCble.Name = "gridColumnIdCtaCble";
            this.gridColumnIdCtaCble.Visible = true;
            this.gridColumnIdCtaCble.VisibleIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageValoresAdep);
            this.tabControl1.Controls.Add(this.tabPageDiario);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1093, 314);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageValoresAdep
            // 
            this.tabPageValoresAdep.Controls.Add(this.panel3);
            this.tabPageValoresAdep.Controls.Add(this.panel2);
            this.tabPageValoresAdep.Location = new System.Drawing.Point(4, 22);
            this.tabPageValoresAdep.Name = "tabPageValoresAdep";
            this.tabPageValoresAdep.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageValoresAdep.Size = new System.Drawing.Size(1085, 288);
            this.tabPageValoresAdep.TabIndex = 0;
            this.tabPageValoresAdep.Text = "Movimientos de Caja";
            this.tabPageValoresAdep.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControlCobros);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1079, 249);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chk_Seleccionar_visibles);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmb_TipoMovCaj);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 33);
            this.panel2.TabIndex = 3;
            // 
            // chk_Seleccionar_visibles
            // 
            this.chk_Seleccionar_visibles.Location = new System.Drawing.Point(311, 6);
            this.chk_Seleccionar_visibles.Name = "chk_Seleccionar_visibles";
            this.chk_Seleccionar_visibles.Properties.Caption = "Seleccionar visibles";
            this.chk_Seleccionar_visibles.Size = new System.Drawing.Size(127, 19);
            this.chk_Seleccionar_visibles.TabIndex = 4;
            this.chk_Seleccionar_visibles.CheckedChanged += new System.EventHandler(this.chk_Seleccionar_visibles_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Movimiento de Caja :";
            // 
            // cmb_TipoMovCaj
            // 
            this.cmb_TipoMovCaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoMovCaj.FormattingEnabled = true;
            this.cmb_TipoMovCaj.Items.AddRange(new object[] {
            "INGRESOS",
            "EGRESOS",
            "TODOS"});
            this.cmb_TipoMovCaj.Location = new System.Drawing.Point(154, 4);
            this.cmb_TipoMovCaj.Name = "cmb_TipoMovCaj";
            this.cmb_TipoMovCaj.Size = new System.Drawing.Size(121, 21);
            this.cmb_TipoMovCaj.TabIndex = 2;
            this.cmb_TipoMovCaj.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoMovCaj_SelectedIndexChanged);
            // 
            // tabPageDiario
            // 
            this.tabPageDiario.Controls.Add(this.ucCon_GridDiarioDeposito);
            this.tabPageDiario.Location = new System.Drawing.Point(4, 22);
            this.tabPageDiario.Name = "tabPageDiario";
            this.tabPageDiario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDiario.Size = new System.Drawing.Size(1085, 288);
            this.tabPageDiario.TabIndex = 1;
            this.tabPageDiario.Text = "Diario Contable";
            this.tabPageDiario.UseVisualStyleBackColor = true;
            // 
            // ucCon_GridDiarioDeposito
            // 
            this.ucCon_GridDiarioDeposito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCon_GridDiarioDeposito.Location = new System.Drawing.Point(3, 3);
            this.ucCon_GridDiarioDeposito.Name = "ucCon_GridDiarioDeposito";
            this.ucCon_GridDiarioDeposito.Size = new System.Drawing.Size(1079, 282);
            this.ucCon_GridDiarioDeposito.TabIndex = 123;
            this.ucCon_GridDiarioDeposito.Visible_Botones = false;
            this.ucCon_GridDiarioDeposito.Visible_Cabecera = false;
            this.ucCon_GridDiarioDeposito.Visible_columna_GrupoPuntoCargo = true;
            this.ucCon_GridDiarioDeposito.Visible_columna_PuntoCargo = true;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(311, 49);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(91, 13);
            this.label43.TabIndex = 37;
            this.label43.Text = "Total a Depositar:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(11, 53);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(70, 13);
            this.label41.TabIndex = 35;
            this.label41.Text = "Total Egreso:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(11, 26);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(72, 13);
            this.label38.TabIndex = 33;
            this.label38.Text = "Total Ingreso:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 687);
            this.panel1.TabIndex = 64;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1105, 555);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(1099, 536);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.TabIndex = 123;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1099, 333);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valores a Despositar";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txe_totalIngreso);
            this.groupBox4.Controls.Add(this.label43);
            this.groupBox4.Controls.Add(this.label38);
            this.groupBox4.Controls.Add(this.txe_totalDepositar);
            this.groupBox4.Controls.Add(this.txe_totalEgreso);
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Location = new System.Drawing.Point(484, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(606, 72);
            this.groupBox4.TabIndex = 123;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resumen";
            // 
            // txe_totalIngreso
            // 
            this.txe_totalIngreso.Location = new System.Drawing.Point(99, 19);
            this.txe_totalIngreso.Name = "txe_totalIngreso";
            this.txe_totalIngreso.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txe_totalIngreso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txe_totalIngreso.Properties.ReadOnly = true;
            this.txe_totalIngreso.Size = new System.Drawing.Size(188, 20);
            this.txe_totalIngreso.TabIndex = 120;
            this.txe_totalIngreso.EditValueChanged += new System.EventHandler(this.txe_totalIngreso_EditValueChanged);
            // 
            // txe_totalDepositar
            // 
            this.txe_totalDepositar.Location = new System.Drawing.Point(408, 46);
            this.txe_totalDepositar.Name = "txe_totalDepositar";
            this.txe_totalDepositar.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txe_totalDepositar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txe_totalDepositar.Size = new System.Drawing.Size(188, 20);
            this.txe_totalDepositar.TabIndex = 122;
            // 
            // txe_totalEgreso
            // 
            this.txe_totalEgreso.Location = new System.Drawing.Point(99, 50);
            this.txe_totalEgreso.Name = "txe_totalEgreso";
            this.txe_totalEgreso.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txe_totalEgreso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txe_totalEgreso.Properties.ReadOnly = true;
            this.txe_totalEgreso.Size = new System.Drawing.Size(188, 20);
            this.txe_totalEgreso.TabIndex = 121;
            this.txe_totalEgreso.EditValueChanged += new System.EventHandler(this.txe_totalEgreso_EditValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.UCSucursal);
            this.groupBox2.Controls.Add(this.ucBa_CuentaBanco);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ucBa_TipoFlujo);
            this.groupBox2.Controls.Add(this.lblCbt_TipoAnulacion);
            this.groupBox2.Controls.Add(this.lb_Anulado);
            this.groupBox2.Controls.Add(this.dt_fechaCbte);
            this.groupBox2.Controls.Add(this.txt_Ncomprobante);
            this.groupBox2.Controls.Add(this.txt_Memo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1105, 132);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Principales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(619, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sucursal:";
            // 
            // UCSucursal
            // 
            this.UCSucursal.Location = new System.Drawing.Point(676, 17);
            this.UCSucursal.Name = "UCSucursal";
            this.UCSucursal.Size = new System.Drawing.Size(298, 26);
            this.UCSucursal.TabIndex = 12;
            // 
            // ucBa_CuentaBanco
            // 
            this.ucBa_CuentaBanco.Location = new System.Drawing.Point(126, 49);
            this.ucBa_CuentaBanco.Name = "ucBa_CuentaBanco";
            this.ucBa_CuentaBanco.Size = new System.Drawing.Size(351, 27);
            this.ucBa_CuentaBanco.TabIndex = 11;
            this.ucBa_CuentaBanco.event_cmb_CuentaBanco_EditValueChanged += new Core.Erp.Winform.Controles.UCBa_CuentaBanco.delegate_cmb_CuentaBanco_EditValueChanged(this.ucBa_CuentaBanco_event_cmb_CuentaBanco_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(484, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo de Flujo:";
            // 
            // ucBa_TipoFlujo
            // 
            this.ucBa_TipoFlujo.Location = new System.Drawing.Point(591, 50);
            this.ucBa_TipoFlujo.Name = "ucBa_TipoFlujo";
            this.ucBa_TipoFlujo.Size = new System.Drawing.Size(298, 26);
            this.ucBa_TipoFlujo.TabIndex = 9;
            // 
            // lblCbt_TipoAnulacion
            // 
            this.lblCbt_TipoAnulacion.AutoEllipsis = true;
            this.lblCbt_TipoAnulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCbt_TipoAnulacion.ForeColor = System.Drawing.Color.Red;
            this.lblCbt_TipoAnulacion.Location = new System.Drawing.Point(843, 52);
            this.lblCbt_TipoAnulacion.Name = "lblCbt_TipoAnulacion";
            this.lblCbt_TipoAnulacion.Size = new System.Drawing.Size(240, 20);
            this.lblCbt_TipoAnulacion.TabIndex = 5;
            this.lblCbt_TipoAnulacion.Text = "***ANULADO***";
            this.lblCbt_TipoAnulacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCbt_TipoAnulacion.Visible = false;
            // 
            // lb_Anulado
            // 
            this.lb_Anulado.AutoSize = true;
            this.lb_Anulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Anulado.ForeColor = System.Drawing.Color.Red;
            this.lb_Anulado.Location = new System.Drawing.Point(451, 16);
            this.lb_Anulado.Name = "lb_Anulado";
            this.lb_Anulado.Size = new System.Drawing.Size(104, 16);
            this.lb_Anulado.TabIndex = 4;
            this.lb_Anulado.Text = "**ANULADO**";
            this.lb_Anulado.Visible = false;
            this.lb_Anulado.Click += new System.EventHandler(this.lb_Anulado_Click);
            // 
            // dt_fechaCbte
            // 
            this.dt_fechaCbte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechaCbte.Location = new System.Drawing.Point(312, 20);
            this.dt_fechaCbte.Name = "dt_fechaCbte";
            this.dt_fechaCbte.Size = new System.Drawing.Size(98, 20);
            this.dt_fechaCbte.TabIndex = 1;
            this.dt_fechaCbte.Tag = "";
            // 
            // txt_Ncomprobante
            // 
            this.txt_Ncomprobante.Location = new System.Drawing.Point(126, 23);
            this.txt_Ncomprobante.Name = "txt_Ncomprobante";
            this.txt_Ncomprobante.ReadOnly = true;
            this.txt_Ncomprobante.Size = new System.Drawing.Size(139, 20);
            this.txt_Ncomprobante.TabIndex = 0;
            this.txt_Ncomprobante.Text = "0";
            // 
            // txt_Memo
            // 
            this.txt_Memo.Location = new System.Drawing.Point(126, 82);
            this.txt_Memo.Multiline = true;
            this.txt_Memo.Name = "txt_Memo";
            this.txt_Memo.Size = new System.Drawing.Size(957, 38);
            this.txt_Memo.TabIndex = 3;
            this.txt_Memo.TextChanged += new System.EventHandler(this.txt_Memo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Observación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(18, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cuenta Bancaria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "#Movimiento:";
            // 
            // baBancoCuentaInfoBindingSource
            // 
            this.baBancoCuentaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Bancos.ba_Banco_Cuenta_Info);
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1105, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
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
            // FrmBA_DepositoBancario_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 589);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBA_DepositoBancario_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Depositos Bancarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBA_DepositoBancario_FormClosing);
            this.Load += new System.EventHandler(this.FrmBA_DepositoBancario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCobros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_Cobros)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageValoresAdep.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Seleccionar_visibles.Properties)).EndInit();
            this.tabPageDiario.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txe_totalIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_totalDepositar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_totalEgreso.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baBancoCuentaInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCobros;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGrid_Cobros;
        private DevExpress.XtraGrid.Columns.GridColumn Chek;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn cr_TotalCobro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageValoresAdep;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.TextBox txt_Memo;
        private System.Windows.Forms.TextBox txt_Ncomprobante;
        private System.Windows.Forms.DateTimePicker dt_fechaCbte;
        private System.Windows.Forms.Label lb_Anulado;
        private System.Windows.Forms.Label lblCbt_TipoAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn Caja;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn cr_fecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controles.UCCon_GridDiarioContable ucCon_GridDiarioDeposito;
        private System.Windows.Forms.BindingSource baBancoCuentaInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIdCtaCble;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.TextEdit txe_totalIngreso;
        private DevExpress.XtraEditors.TextEdit txe_totalEgreso;
        private DevExpress.XtraEditors.TextEdit txe_totalDepositar;
        private System.Windows.Forms.TabPage tabPageDiario;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private Controles.UCBa_TipoFlujo ucBa_TipoFlujo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_TipoMovCaj;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCBa_CuentaBanco ucBa_CuentaBanco;
        private System.Windows.Forms.Label label3;
        private Controles.UCGe_Sucursal_combo UCSucursal;
        private DevExpress.XtraEditors.CheckEdit chk_Seleccionar_visibles;
    }
}