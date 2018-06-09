namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Credito_Mant
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ucGe_Sucursal = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.label1 = new System.Windows.Forms.Label();
            this.ucBa_TipoFlujo = new Core.Erp.Winform.Controles.UCBa_TipoFlujo();
            this.ucBa_CuentaBanco = new Core.Erp.Winform.Controles.UCBa_CuentaBanco();
            this.ucbA_TipoNota = new Core.Erp.Winform.Controles.UCBA_TipoNota();
            this.dt_fechaCbte = new System.Windows.Forms.DateTimePicker();
            this.lblCbt_TipoAnulacion = new System.Windows.Forms.Label();
            this.txt_Memo = new System.Windows.Forms.TextBox();
            this.txt_Ncomprobante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageValoresAdep = new System.Windows.Forms.TabPage();
            this.UC_Diario_x_NC = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.tabPageDiario = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControlCobros = new DevExpress.XtraGrid.GridControl();
            this.UltraGrid_Cobros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Chek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucu = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_TipoMovCaj = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCuerpo = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageValoresAdep.SuspendLayout();
            this.tabPageDiario.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCobros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_Cobros)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelCuerpo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.ucGe_Sucursal);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ucBa_TipoFlujo);
            this.panel3.Controls.Add(this.ucBa_CuentaBanco);
            this.panel3.Controls.Add(this.ucbA_TipoNota);
            this.panel3.Controls.Add(this.dt_fechaCbte);
            this.panel3.Controls.Add(this.lblCbt_TipoAnulacion);
            this.panel3.Controls.Add(this.txt_Memo);
            this.panel3.Controls.Add(this.txt_Ncomprobante);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 166);
            this.panel3.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sucursal:";
            // 
            // ucGe_Sucursal
            // 
            this.ucGe_Sucursal.Location = new System.Drawing.Point(101, 16);
            this.ucGe_Sucursal.Name = "ucGe_Sucursal";
            this.ucGe_Sucursal.Size = new System.Drawing.Size(298, 26);
            this.ucGe_Sucursal.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tipo de Flujo:";
            // 
            // ucBa_TipoFlujo
            // 
            this.ucBa_TipoFlujo.Location = new System.Drawing.Point(487, 12);
            this.ucBa_TipoFlujo.Name = "ucBa_TipoFlujo";
            this.ucBa_TipoFlujo.Size = new System.Drawing.Size(261, 26);
            this.ucBa_TipoFlujo.TabIndex = 14;
            // 
            // ucBa_CuentaBanco
            // 
            this.ucBa_CuentaBanco.Location = new System.Drawing.Point(101, 79);
            this.ucBa_CuentaBanco.Name = "ucBa_CuentaBanco";
            this.ucBa_CuentaBanco.Size = new System.Drawing.Size(362, 26);
            this.ucBa_CuentaBanco.TabIndex = 13;
            this.ucBa_CuentaBanco.event_cmb_CuentaBanco_EditValueChanged += new Core.Erp.Winform.Controles.UCBa_CuentaBanco.delegate_cmb_CuentaBanco_EditValueChanged(this.ucBa_CuentaBanco_event_cmb_CuentaBanco_EditValueChanged);
            // 
            // ucbA_TipoNota
            // 
            this.ucbA_TipoNota.Location = new System.Drawing.Point(661, 56);
            this.ucbA_TipoNota.Name = "ucbA_TipoNota";
            this.ucbA_TipoNota.Size = new System.Drawing.Size(339, 26);
            this.ucbA_TipoNota.TabIndex = 12;
            this.ucbA_TipoNota.tipoNota = Core.Erp.Info.General.Cl_Enumeradores.eTipoNotaBanco.NCBA;
            // 
            // dt_fechaCbte
            // 
            this.dt_fechaCbte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechaCbte.Location = new System.Drawing.Point(900, 12);
            this.dt_fechaCbte.Name = "dt_fechaCbte";
            this.dt_fechaCbte.Size = new System.Drawing.Size(100, 20);
            this.dt_fechaCbte.TabIndex = 2;
            this.dt_fechaCbte.Tag = "";
            // 
            // lblCbt_TipoAnulacion
            // 
            this.lblCbt_TipoAnulacion.AutoEllipsis = true;
            this.lblCbt_TipoAnulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCbt_TipoAnulacion.ForeColor = System.Drawing.Color.Red;
            this.lblCbt_TipoAnulacion.Location = new System.Drawing.Point(420, 41);
            this.lblCbt_TipoAnulacion.Name = "lblCbt_TipoAnulacion";
            this.lblCbt_TipoAnulacion.Size = new System.Drawing.Size(144, 28);
            this.lblCbt_TipoAnulacion.TabIndex = 1;
            this.lblCbt_TipoAnulacion.Text = "***ANULADO***";
            this.lblCbt_TipoAnulacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCbt_TipoAnulacion.Visible = false;
            // 
            // txt_Memo
            // 
            this.txt_Memo.Location = new System.Drawing.Point(101, 111);
            this.txt_Memo.Multiline = true;
            this.txt_Memo.Name = "txt_Memo";
            this.txt_Memo.Size = new System.Drawing.Size(895, 38);
            this.txt_Memo.TabIndex = 4;
            this.txt_Memo.TextChanged += new System.EventHandler(this.txt_Memo_TextChanged);
            // 
            // txt_Ncomprobante
            // 
            this.txt_Ncomprobante.Location = new System.Drawing.Point(101, 54);
            this.txt_Ncomprobante.Name = "txt_Ncomprobante";
            this.txt_Ncomprobante.ReadOnly = true;
            this.txt_Ncomprobante.Size = new System.Drawing.Size(105, 20);
            this.txt_Ncomprobante.TabIndex = 1;
            this.txt_Ncomprobante.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "#Movimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Motivo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Observación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(854, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(11, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cuenta Bancaria:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageValoresAdep);
            this.tabControl1.Controls.Add(this.tabPageDiario);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 307);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageValoresAdep
            // 
            this.tabPageValoresAdep.Controls.Add(this.UC_Diario_x_NC);
            this.tabPageValoresAdep.Location = new System.Drawing.Point(4, 22);
            this.tabPageValoresAdep.Name = "tabPageValoresAdep";
            this.tabPageValoresAdep.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageValoresAdep.Size = new System.Drawing.Size(1004, 281);
            this.tabPageValoresAdep.TabIndex = 0;
            this.tabPageValoresAdep.Text = "Diario Contable";
            this.tabPageValoresAdep.UseVisualStyleBackColor = true;
            // 
            // UC_Diario_x_NC
            // 
            this.UC_Diario_x_NC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_Diario_x_NC.IdCtaCble_x_Banco = null;
            this.UC_Diario_x_NC.Location = new System.Drawing.Point(3, 3);
            this.UC_Diario_x_NC.Name = "UC_Diario_x_NC";
            this.UC_Diario_x_NC.Size = new System.Drawing.Size(998, 275);
            this.UC_Diario_x_NC.TabIndex = 123;
            this.UC_Diario_x_NC.Visible_Botones = false;
            this.UC_Diario_x_NC.Visible_Cabecera = false;
            this.UC_Diario_x_NC.Visible_columna_GrupoPuntoCargo = true;
            this.UC_Diario_x_NC.Visible_columna_PuntoCargo = true;
            // 
            // tabPageDiario
            // 
            this.tabPageDiario.Controls.Add(this.panel2);
            this.tabPageDiario.Controls.Add(this.panel1);
            this.tabPageDiario.Location = new System.Drawing.Point(4, 22);
            this.tabPageDiario.Name = "tabPageDiario";
            this.tabPageDiario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDiario.Size = new System.Drawing.Size(1004, 281);
            this.tabPageDiario.TabIndex = 1;
            this.tabPageDiario.Text = "Ingresos Cuentas x Cobrar";
            this.tabPageDiario.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlCobros);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 245);
            this.panel2.TabIndex = 6;
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
            this.gridControlCobros.Size = new System.Drawing.Size(998, 245);
            this.gridControlCobros.TabIndex = 0;
            this.gridControlCobros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGrid_Cobros});
            // 
            // UltraGrid_Cobros
            // 
            this.UltraGrid_Cobros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Chek,
            this.colSucu,
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
            this.colIdCtaCble});
            this.UltraGrid_Cobros.GridControl = this.gridControlCobros;
            this.UltraGrid_Cobros.Name = "UltraGrid_Cobros";
            this.UltraGrid_Cobros.OptionsView.ShowAutoFilterRow = true;
            this.UltraGrid_Cobros.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.UltraGrid_Cobros.OptionsView.ShowGroupPanel = false;
            this.UltraGrid_Cobros.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.UltraGrid_Cobros_RowClick);
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
            // colSucu
            // 
            this.colSucu.Caption = "Sucursal";
            this.colSucu.FieldName = "nSucursal";
            this.colSucu.Name = "colSucu";
            this.colSucu.OptionsColumn.AllowEdit = false;
            this.colSucu.Visible = true;
            this.colSucu.VisibleIndex = 3;
            this.colSucu.Width = 55;
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
            this.cr_TotalCobro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cr_TotalCobro.FieldName = "cr_TotalCobro";
            this.cr_TotalCobro.Name = "cr_TotalCobro";
            this.cr_TotalCobro.OptionsColumn.AllowEdit = false;
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
            // colIdCtaCble
            // 
            this.colIdCtaCble.Caption = "IdCtaCble";
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.VisibleIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_TipoMovCaj);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 30);
            this.panel1.TabIndex = 5;
            // 
            // cmb_TipoMovCaj
            // 
            this.cmb_TipoMovCaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoMovCaj.FormattingEnabled = true;
            this.cmb_TipoMovCaj.Items.AddRange(new object[] {
            "INGRESOS",
            "EGRESOS",
            "TODOS"});
            this.cmb_TipoMovCaj.Location = new System.Drawing.Point(162, 3);
            this.cmb_TipoMovCaj.Name = "cmb_TipoMovCaj";
            this.cmb_TipoMovCaj.Size = new System.Drawing.Size(121, 21);
            this.cmb_TipoMovCaj.TabIndex = 4;
            this.cmb_TipoMovCaj.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoMovCaj_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tipo de Movimiento de Caja :";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1012, 29);
            this.ucGe_Menu.TabIndex = 5;
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
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 502);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1012, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 6;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelCuerpo);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1012, 473);
            this.panelMain.TabIndex = 7;
            // 
            // panelCuerpo
            // 
            this.panelCuerpo.Controls.Add(this.tabControl1);
            this.panelCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuerpo.Location = new System.Drawing.Point(0, 166);
            this.panelCuerpo.Name = "panelCuerpo";
            this.panelCuerpo.Size = new System.Drawing.Size(1012, 307);
            this.panelCuerpo.TabIndex = 5;
            // 
            // FrmBA_Credito_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 528);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmBA_Credito_Mant";
            this.Text = "Mantenimiento Crédito Bancario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBA_Credito_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmBA_Credito_Mant_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageValoresAdep.ResumeLayout(false);
            this.tabPageDiario.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCobros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_Cobros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelCuerpo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dt_fechaCbte;
        private System.Windows.Forms.Label lblCbt_TipoAnulacion;
        private System.Windows.Forms.TextBox txt_Memo;
        private System.Windows.Forms.TextBox txt_Ncomprobante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Controles.UCBA_TipoNota ucbA_TipoNota;
        private Controles.UCBa_CuentaBanco ucBa_CuentaBanco;
        private System.Windows.Forms.Label label1;
        private Controles.UCBa_TipoFlujo ucBa_TipoFlujo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageValoresAdep;
        private DevExpress.XtraGrid.GridControl gridControlCobros;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGrid_Cobros;
        private DevExpress.XtraGrid.Columns.GridColumn Chek;
        private DevExpress.XtraGrid.Columns.GridColumn colSucu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn cr_TotalCobro;
        private DevExpress.XtraGrid.Columns.GridColumn Caja;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn cr_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private System.Windows.Forms.TabPage tabPageDiario;
        private Controles.UCCon_GridDiarioContable UC_Diario_x_NC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_TipoMovCaj;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Sucursal_combo ucGe_Sucursal;
        private System.Windows.Forms.Label label9;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCuerpo;
    }
}