namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_ConciliacionBancaria_Mant
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ultraCmbE_periodo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname_periodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ultraCmbCtaBanco = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_nombreCta = new System.Windows.Forms.TextBox();
            this.txt_observacion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_NConciliacion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_CtaCble = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cargarMovimientos = new System.Windows.Forms.Button();
            this.lb_Anulado = new System.Windows.Forms.Label();
            this.gpB_Resumen = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Saldo_anterior_banco = new DevExpress.XtraEditors.TextEdit();
            this.txe_diferencia = new DevExpress.XtraEditors.TextEdit();
            this.txe_saldoBanco = new DevExpress.XtraEditors.TextEdit();
            this.txe_saldoConciliado = new DevExpress.XtraEditors.TextEdit();
            this.txe_egreso = new DevExpress.XtraEditors.TextEdit();
            this.txe_ingresos = new DevExpress.XtraEditors.TextEdit();
            this.txe_SaldoCtbleAnterior = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridControl_Ingresos = new DevExpress.XtraGrid.GridControl();
            this.gridView_Ingresos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCbteCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_IdTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridControl_Egresos = new DevExpress.XtraGrid.GridControl();
            this.gridView_Egresos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcheck2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCbteCble2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_IdTipoCbte2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenciaCbte2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheque2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.lb_EstadoConciliacion = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ConManual = new System.Windows.Forms.TabPage();
            this.ConAutomatica = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnConciliar = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCargaExcel = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.gridControlSistema = new DevExpress.XtraGrid.GridControl();
            this.gridViewSistema = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkcolum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gridControlExcel = new DevExpress.XtraGrid.GridControl();
            this.gridViewExcel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_imprimir_ingresos = new System.Windows.Forms.ToolStripButton();
            this.btn_imprimir_egresos = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_periodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbCtaBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.gpB_Resumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Saldo_anterior_banco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_diferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_saldoBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_saldoConciliado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_egreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_ingresos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_SaldoCtbleAnterior.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Ingresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Ingresos)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Egresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Egresos)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ConManual.SuspendLayout();
            this.ConAutomatica.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSistema)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExcel)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ultraCmbE_periodo);
            this.groupBox1.Controls.Add(this.ultraCmbCtaBanco);
            this.groupBox1.Controls.Add(this.txt_nombreCta);
            this.groupBox1.Controls.Add(this.txt_observacion);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_NConciliacion);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_CtaCble);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_hasta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_desde);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(1, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ultraCmbE_periodo
            // 
            this.ultraCmbE_periodo.Location = new System.Drawing.Point(79, 119);
            this.ultraCmbE_periodo.Name = "ultraCmbE_periodo";
            this.ultraCmbE_periodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraCmbE_periodo.Properties.DisplayMember = "nom_periodo";
            this.ultraCmbE_periodo.Properties.ValueMember = "IdPeriodo";
            this.ultraCmbE_periodo.Properties.View = this.gridView1;
            this.ultraCmbE_periodo.Size = new System.Drawing.Size(216, 20);
            this.ultraCmbE_periodo.TabIndex = 5;
            this.ultraCmbE_periodo.EditValueChanged += new System.EventHandler(this.ultraCmbE_periodo_SelectionChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname_periodo});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colname_periodo
            // 
            this.colname_periodo.Caption = "Periodo";
            this.colname_periodo.FieldName = "nom_periodo";
            this.colname_periodo.Name = "colname_periodo";
            this.colname_periodo.Visible = true;
            this.colname_periodo.VisibleIndex = 0;
            // 
            // ultraCmbCtaBanco
            // 
            this.ultraCmbCtaBanco.Location = new System.Drawing.Point(75, 36);
            this.ultraCmbCtaBanco.Name = "ultraCmbCtaBanco";
            this.ultraCmbCtaBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraCmbCtaBanco.Properties.DisplayMember = "ba_descripcion";
            this.ultraCmbCtaBanco.Properties.ValueMember = "IdBanco";
            this.ultraCmbCtaBanco.Properties.View = this.gridView3;
            this.ultraCmbCtaBanco.Size = new System.Drawing.Size(220, 20);
            this.ultraCmbCtaBanco.TabIndex = 2;
            this.ultraCmbCtaBanco.EditValueChanged += new System.EventHandler(this.ultraCmbCtaBanco_EditValueChanged);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colba_descripcion,
            this.col_IdCtaCble});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colba_descripcion
            // 
            this.colba_descripcion.Caption = "Descripcion";
            this.colba_descripcion.FieldName = "ba_descripcion";
            this.colba_descripcion.Name = "colba_descripcion";
            this.colba_descripcion.Visible = true;
            this.colba_descripcion.VisibleIndex = 0;
            // 
            // col_IdCtaCble
            // 
            this.col_IdCtaCble.Caption = "Cta Cble";
            this.col_IdCtaCble.FieldName = "IdCtaCble";
            this.col_IdCtaCble.Name = "col_IdCtaCble";
            this.col_IdCtaCble.Visible = true;
            this.col_IdCtaCble.VisibleIndex = 1;
            // 
            // txt_nombreCta
            // 
            this.txt_nombreCta.Location = new System.Drawing.Point(14, 88);
            this.txt_nombreCta.Multiline = true;
            this.txt_nombreCta.Name = "txt_nombreCta";
            this.txt_nombreCta.ReadOnly = true;
            this.txt_nombreCta.Size = new System.Drawing.Size(281, 25);
            this.txt_nombreCta.TabIndex = 4;
            this.txt_nombreCta.TextChanged += new System.EventHandler(this.txt_nombreCta_TextChanged);
            // 
            // txt_observacion
            // 
            this.txt_observacion.Location = new System.Drawing.Point(12, 182);
            this.txt_observacion.Multiline = true;
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(287, 92);
            this.txt_observacion.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Observación :";
            // 
            // txt_NConciliacion
            // 
            this.txt_NConciliacion.Location = new System.Drawing.Point(76, 15);
            this.txt_NConciliacion.Name = "txt_NConciliacion";
            this.txt_NConciliacion.ReadOnly = true;
            this.txt_NConciliacion.Size = new System.Drawing.Size(108, 20);
            this.txt_NConciliacion.TabIndex = 0;
            this.txt_NConciliacion.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(5, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "# Conciliación :";
            // 
            // txt_CtaCble
            // 
            this.txt_CtaCble.Location = new System.Drawing.Point(76, 62);
            this.txt_CtaCble.Name = "txt_CtaCble";
            this.txt_CtaCble.ReadOnly = true;
            this.txt_CtaCble.Size = new System.Drawing.Size(219, 20);
            this.txt_CtaCble.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(11, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "# Cta. Cble:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(8, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Periodo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Desde:";
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hasta.Location = new System.Drawing.Point(208, 142);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(92, 20);
            this.dtp_hasta.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hasta:";
            // 
            // dtp_desde
            // 
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_desde.Location = new System.Drawing.Point(60, 142);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(98, 20);
            this.dtp_desde.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(5, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cta. Bancaria:";
            // 
            // btn_cargarMovimientos
            // 
            this.btn_cargarMovimientos.Location = new System.Drawing.Point(187, 314);
            this.btn_cargarMovimientos.Name = "btn_cargarMovimientos";
            this.btn_cargarMovimientos.Size = new System.Drawing.Size(114, 41);
            this.btn_cargarMovimientos.TabIndex = 0;
            this.btn_cargarMovimientos.Text = "Cargar &Movimientos";
            this.btn_cargarMovimientos.UseVisualStyleBackColor = true;
            this.btn_cargarMovimientos.Click += new System.EventHandler(this.btn_cargarMovimientos_Click);
            // 
            // lb_Anulado
            // 
            this.lb_Anulado.AutoSize = true;
            this.lb_Anulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Anulado.ForeColor = System.Drawing.Color.Red;
            this.lb_Anulado.Location = new System.Drawing.Point(6, 320);
            this.lb_Anulado.Name = "lb_Anulado";
            this.lb_Anulado.Size = new System.Drawing.Size(168, 24);
            this.lb_Anulado.TabIndex = 1;
            this.lb_Anulado.Text = "*** ANULADO ***";
            this.lb_Anulado.Visible = false;
            // 
            // gpB_Resumen
            // 
            this.gpB_Resumen.Controls.Add(this.label15);
            this.gpB_Resumen.Controls.Add(this.txt_Saldo_anterior_banco);
            this.gpB_Resumen.Controls.Add(this.txe_diferencia);
            this.gpB_Resumen.Controls.Add(this.txe_saldoBanco);
            this.gpB_Resumen.Controls.Add(this.txe_saldoConciliado);
            this.gpB_Resumen.Controls.Add(this.txe_egreso);
            this.gpB_Resumen.Controls.Add(this.txe_ingresos);
            this.gpB_Resumen.Controls.Add(this.txe_SaldoCtbleAnterior);
            this.gpB_Resumen.Controls.Add(this.label7);
            this.gpB_Resumen.Controls.Add(this.label8);
            this.gpB_Resumen.Controls.Add(this.label9);
            this.gpB_Resumen.Controls.Add(this.label6);
            this.gpB_Resumen.Controls.Add(this.label5);
            this.gpB_Resumen.Controls.Add(this.label4);
            this.gpB_Resumen.Location = new System.Drawing.Point(3, 361);
            this.gpB_Resumen.Name = "gpB_Resumen";
            this.gpB_Resumen.Size = new System.Drawing.Size(300, 221);
            this.gpB_Resumen.TabIndex = 3;
            this.gpB_Resumen.TabStop = false;
            this.gpB_Resumen.Text = "Resumen";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(9, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Saldo banco mes Anterior (+) :";
            // 
            // txt_Saldo_anterior_banco
            // 
            this.txt_Saldo_anterior_banco.Location = new System.Drawing.Point(195, 45);
            this.txt_Saldo_anterior_banco.Name = "txt_Saldo_anterior_banco";
            this.txt_Saldo_anterior_banco.Properties.DisplayFormat.FormatString = "n2";
            this.txt_Saldo_anterior_banco.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_Saldo_anterior_banco.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txt_Saldo_anterior_banco.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Saldo_anterior_banco.Size = new System.Drawing.Size(100, 20);
            this.txt_Saldo_anterior_banco.TabIndex = 16;
            this.txt_Saldo_anterior_banco.EditValueChanged += new System.EventHandler(this.txt_Saldo_anterior_banco_EditValueChanged);
            // 
            // txe_diferencia
            // 
            this.txe_diferencia.Location = new System.Drawing.Point(195, 174);
            this.txe_diferencia.Name = "txe_diferencia";
            this.txe_diferencia.Properties.DisplayFormat.FormatString = "n2";
            this.txe_diferencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txe_diferencia.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txe_diferencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txe_diferencia.Properties.ReadOnly = true;
            this.txe_diferencia.Size = new System.Drawing.Size(100, 20);
            this.txe_diferencia.TabIndex = 5;
            // 
            // txe_saldoBanco
            // 
            this.txe_saldoBanco.Location = new System.Drawing.Point(195, 148);
            this.txe_saldoBanco.Name = "txe_saldoBanco";
            this.txe_saldoBanco.Properties.DisplayFormat.FormatString = "n2";
            this.txe_saldoBanco.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txe_saldoBanco.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txe_saldoBanco.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txe_saldoBanco.Size = new System.Drawing.Size(100, 20);
            this.txe_saldoBanco.TabIndex = 4;
            this.txe_saldoBanco.EditValueChanged += new System.EventHandler(this.txe_saldoBanco_EditValueChanged);
            // 
            // txe_saldoConciliado
            // 
            this.txe_saldoConciliado.Location = new System.Drawing.Point(195, 122);
            this.txe_saldoConciliado.Name = "txe_saldoConciliado";
            this.txe_saldoConciliado.Properties.DisplayFormat.FormatString = "n2";
            this.txe_saldoConciliado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txe_saldoConciliado.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txe_saldoConciliado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txe_saldoConciliado.Properties.ReadOnly = true;
            this.txe_saldoConciliado.Size = new System.Drawing.Size(100, 20);
            this.txe_saldoConciliado.TabIndex = 3;
            // 
            // txe_egreso
            // 
            this.txe_egreso.Location = new System.Drawing.Point(195, 97);
            this.txe_egreso.Name = "txe_egreso";
            this.txe_egreso.Properties.DisplayFormat.FormatString = "n2";
            this.txe_egreso.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txe_egreso.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txe_egreso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txe_egreso.Properties.ReadOnly = true;
            this.txe_egreso.Size = new System.Drawing.Size(100, 20);
            this.txe_egreso.TabIndex = 2;
            // 
            // txe_ingresos
            // 
            this.txe_ingresos.Location = new System.Drawing.Point(195, 71);
            this.txe_ingresos.Name = "txe_ingresos";
            this.txe_ingresos.Properties.DisplayFormat.FormatString = "n2";
            this.txe_ingresos.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txe_ingresos.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txe_ingresos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txe_ingresos.Properties.ReadOnly = true;
            this.txe_ingresos.Size = new System.Drawing.Size(100, 20);
            this.txe_ingresos.TabIndex = 1;
            // 
            // txe_SaldoCtbleAnterior
            // 
            this.txe_SaldoCtbleAnterior.Location = new System.Drawing.Point(195, 19);
            this.txe_SaldoCtbleAnterior.Name = "txe_SaldoCtbleAnterior";
            this.txe_SaldoCtbleAnterior.Properties.DisplayFormat.FormatString = "n2";
            this.txe_SaldoCtbleAnterior.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txe_SaldoCtbleAnterior.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txe_SaldoCtbleAnterior.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txe_SaldoCtbleAnterior.Properties.ReadOnly = true;
            this.txe_SaldoCtbleAnterior.Size = new System.Drawing.Size(100, 20);
            this.txe_SaldoCtbleAnterior.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(9, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Diferencia :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(9, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Saldo Banco :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CadetBlue;
            this.label9.Location = new System.Drawing.Point(9, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "∑ Saldo Conciliado :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(9, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Egreso (-) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(9, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Ingresos (+) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Saldo contable mes Anterior :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridControl_Ingresos);
            this.groupBox3.Controls.Add(this.toolStrip1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 533);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INGRESOS";
            // 
            // gridControl_Ingresos
            // 
            this.gridControl_Ingresos.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl_Ingresos.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl_Ingresos.Location = new System.Drawing.Point(3, 41);
            this.gridControl_Ingresos.MainView = this.gridView_Ingresos;
            this.gridControl_Ingresos.Name = "gridControl_Ingresos";
            this.gridControl_Ingresos.Size = new System.Drawing.Size(442, 489);
            this.gridControl_Ingresos.TabIndex = 0;
            this.gridControl_Ingresos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Ingresos});
            this.gridControl_Ingresos.Click += new System.EventHandler(this.gridControl_Ingresos_Click);
            // 
            // gridView_Ingresos
            // 
            this.gridView_Ingresos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheck,
            this.colCbteCble,
            this.colFecha,
            this.colObservacion,
            this.colCheque,
            this.colValor,
            this.colnom_IdTipoCbte});
            this.gridView_Ingresos.GridControl = this.gridControl_Ingresos;
            this.gridView_Ingresos.Name = "gridView_Ingresos";
            this.gridView_Ingresos.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Ingresos.OptionsView.ShowFooter = true;
            this.gridView_Ingresos.OptionsView.ShowGroupPanel = false;
            this.gridView_Ingresos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_Ingresos_CellValueChanged);
            this.gridView_Ingresos.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_Ingresos_CellValueChanging);
            // 
            // colCheck
            // 
            this.colCheck.Caption = "*";
            this.colCheck.FieldName = "chk";
            this.colCheck.Name = "colCheck";
            this.colCheck.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 0;
            this.colCheck.Width = 29;
            // 
            // colCbteCble
            // 
            this.colCbteCble.Caption = "# CbteCble";
            this.colCbteCble.FieldName = "IdCbteCble";
            this.colCbteCble.Name = "colCbteCble";
            this.colCbteCble.OptionsColumn.AllowEdit = false;
            this.colCbteCble.Visible = true;
            this.colCbteCble.VisibleIndex = 1;
            this.colCbteCble.Width = 65;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "cb_Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 3;
            this.colFecha.Width = 65;
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observación";
            this.colObservacion.FieldName = "ReferenciaCbte";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.OptionsColumn.AllowEdit = false;
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 4;
            this.colObservacion.Width = 65;
            // 
            // colCheque
            // 
            this.colCheque.Caption = "# Cheque";
            this.colCheque.FieldName = "cb_Cheque";
            this.colCheque.Name = "colCheque";
            this.colCheque.OptionsColumn.AllowEdit = false;
            this.colCheque.Width = 65;
            // 
            // colValor
            // 
            this.colValor.Caption = "Valor";
            this.colValor.DisplayFormat.FormatString = "n2";
            this.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValor.FieldName = "dc_Valor";
            this.colValor.Name = "colValor";
            this.colValor.OptionsColumn.AllowEdit = false;
            this.colValor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dc_Valor", "{0:n2}")});
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 5;
            this.colValor.Width = 77;
            // 
            // colnom_IdTipoCbte
            // 
            this.colnom_IdTipoCbte.Caption = "Tipo Cbte Cble";
            this.colnom_IdTipoCbte.FieldName = "nom_IdTipoCbte";
            this.colnom_IdTipoCbte.Name = "colnom_IdTipoCbte";
            this.colnom_IdTipoCbte.OptionsColumn.AllowEdit = false;
            this.colnom_IdTipoCbte.Visible = true;
            this.colnom_IdTipoCbte.VisibleIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(521, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "*** PERIODO***";
            this.label14.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gridControl_Egresos);
            this.groupBox4.Controls.Add(this.toolStrip2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 533);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "EGRESOS";
            // 
            // gridControl_Egresos
            // 
            this.gridControl_Egresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Egresos.Location = new System.Drawing.Point(3, 41);
            this.gridControl_Egresos.MainView = this.gridView_Egresos;
            this.gridControl_Egresos.Name = "gridControl_Egresos";
            this.gridControl_Egresos.Size = new System.Drawing.Size(400, 489);
            this.gridControl_Egresos.TabIndex = 0;
            this.gridControl_Egresos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Egresos});
            // 
            // gridView_Egresos
            // 
            this.gridView_Egresos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcheck2,
            this.colCbteCble2,
            this.colnom_IdTipoCbte2,
            this.colFecha2,
            this.colReferenciaCbte2,
            this.colcheque2,
            this.colValor2});
            this.gridView_Egresos.GridControl = this.gridControl_Egresos;
            this.gridView_Egresos.Name = "gridView_Egresos";
            this.gridView_Egresos.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Egresos.OptionsView.ShowFooter = true;
            this.gridView_Egresos.OptionsView.ShowGroupPanel = false;
            this.gridView_Egresos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_Egresos_CellValueChanged);
            this.gridView_Egresos.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_Egresos_CellValueChanging);
            // 
            // colcheck2
            // 
            this.colcheck2.Caption = "*";
            this.colcheck2.FieldName = "chk";
            this.colcheck2.Name = "colcheck2";
            this.colcheck2.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colcheck2.Visible = true;
            this.colcheck2.VisibleIndex = 0;
            this.colcheck2.Width = 29;
            // 
            // colCbteCble2
            // 
            this.colCbteCble2.Caption = "# CbteCble";
            this.colCbteCble2.FieldName = "IdCbteCble";
            this.colCbteCble2.Name = "colCbteCble2";
            this.colCbteCble2.OptionsColumn.AllowEdit = false;
            this.colCbteCble2.Visible = true;
            this.colCbteCble2.VisibleIndex = 1;
            this.colCbteCble2.Width = 65;
            // 
            // colnom_IdTipoCbte2
            // 
            this.colnom_IdTipoCbte2.Caption = "Tipo Cbte Cble";
            this.colnom_IdTipoCbte2.FieldName = "nom_IdTipoCbte";
            this.colnom_IdTipoCbte2.Name = "colnom_IdTipoCbte2";
            this.colnom_IdTipoCbte2.OptionsColumn.AllowEdit = false;
            this.colnom_IdTipoCbte2.Visible = true;
            this.colnom_IdTipoCbte2.VisibleIndex = 2;
            this.colnom_IdTipoCbte2.Width = 65;
            // 
            // colFecha2
            // 
            this.colFecha2.Caption = "Fecha";
            this.colFecha2.FieldName = "cb_Fecha";
            this.colFecha2.Name = "colFecha2";
            this.colFecha2.OptionsColumn.AllowEdit = false;
            this.colFecha2.Visible = true;
            this.colFecha2.VisibleIndex = 3;
            this.colFecha2.Width = 65;
            // 
            // colReferenciaCbte2
            // 
            this.colReferenciaCbte2.Caption = "Observación";
            this.colReferenciaCbte2.FieldName = "dc_Observacion";
            this.colReferenciaCbte2.Name = "colReferenciaCbte2";
            this.colReferenciaCbte2.OptionsColumn.AllowEdit = false;
            this.colReferenciaCbte2.Visible = true;
            this.colReferenciaCbte2.VisibleIndex = 4;
            this.colReferenciaCbte2.Width = 65;
            // 
            // colcheque2
            // 
            this.colcheque2.Caption = "# Cheque";
            this.colcheque2.FieldName = "cb_Cheque";
            this.colcheque2.Name = "colcheque2";
            this.colcheque2.OptionsColumn.AllowEdit = false;
            this.colcheque2.Visible = true;
            this.colcheque2.VisibleIndex = 5;
            this.colcheque2.Width = 65;
            // 
            // colValor2
            // 
            this.colValor2.Caption = "Valor";
            this.colValor2.DisplayFormat.FormatString = "n2";
            this.colValor2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValor2.FieldName = "dc_Valor";
            this.colValor2.Name = "colValor2";
            this.colValor2.OptionsColumn.AllowEdit = false;
            this.colValor2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dc_Valor", "{0:n2}")});
            this.colValor2.Visible = true;
            this.colValor2.VisibleIndex = 6;
            this.colValor2.Width = 77;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.splitContainer5);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(864, 588);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 16);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.lb_EstadoConciliacion);
            this.splitContainer5.Panel1.Controls.Add(this.label14);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer5.Size = new System.Drawing.Size(858, 569);
            this.splitContainer5.SplitterDistance = 32;
            this.splitContainer5.TabIndex = 9;
            // 
            // lb_EstadoConciliacion
            // 
            this.lb_EstadoConciliacion.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EstadoConciliacion.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lb_EstadoConciliacion.Location = new System.Drawing.Point(196, 4);
            this.lb_EstadoConciliacion.Name = "lb_EstadoConciliacion";
            this.lb_EstadoConciliacion.Size = new System.Drawing.Size(154, 19);
            this.lb_EstadoConciliacion.TabIndex = 2;
            this.lb_EstadoConciliacion.Text = "Estado conciliacion";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(858, 533);
            this.splitContainer1.SplitterDistance = 448;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.splitContainer2.Panel1.Controls.Add(this.gpB_Resumen);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.btn_cargarMovimientos);
            this.splitContainer2.Panel1.Controls.Add(this.lb_Anulado);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(1187, 620);
            this.splitContainer2.SplitterDistance = 305;
            this.splitContainer2.TabIndex = 1;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 594);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(305, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ConManual);
            this.tabControl1.Controls.Add(this.ConAutomatica);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(878, 620);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // ConManual
            // 
            this.ConManual.Controls.Add(this.groupBox5);
            this.ConManual.Location = new System.Drawing.Point(4, 22);
            this.ConManual.Name = "ConManual";
            this.ConManual.Padding = new System.Windows.Forms.Padding(3);
            this.ConManual.Size = new System.Drawing.Size(870, 594);
            this.ConManual.TabIndex = 0;
            this.ConManual.Text = "Conciliacion Bancaria Manual";
            this.ConManual.UseVisualStyleBackColor = true;
            // 
            // ConAutomatica
            // 
            this.ConAutomatica.Controls.Add(this.groupBox2);
            this.ConAutomatica.Location = new System.Drawing.Point(4, 22);
            this.ConAutomatica.Name = "ConAutomatica";
            this.ConAutomatica.Padding = new System.Windows.Forms.Padding(3);
            this.ConAutomatica.Size = new System.Drawing.Size(870, 594);
            this.ConAutomatica.TabIndex = 1;
            this.ConAutomatica.Text = "Conciliacion Bancaria Automatica(Carga Trans. Bancarias)";
            this.ConAutomatica.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(864, 588);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 16);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnConciliar);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox8);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(858, 569);
            this.splitContainer3.SplitterDistance = 283;
            this.splitContainer3.TabIndex = 8;
            // 
            // btnConciliar
            // 
            this.btnConciliar.Location = new System.Drawing.Point(18, 10);
            this.btnConciliar.Name = "btnConciliar";
            this.btnConciliar.Size = new System.Drawing.Size(131, 23);
            this.btnConciliar.TabIndex = 8;
            this.btnConciliar.Text = "Verificar";
            this.btnConciliar.UseVisualStyleBackColor = true;
            this.btnConciliar.Click += new System.EventHandler(this.btnConciliar_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button1);
            this.groupBox8.Controls.Add(this.btnCargaExcel);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox8.Location = new System.Drawing.Point(315, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(543, 283);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "<<-- Exportar N/C , N/D";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCargaExcel
            // 
            this.btnCargaExcel.Location = new System.Drawing.Point(448, 10);
            this.btnCargaExcel.Name = "btnCargaExcel";
            this.btnCargaExcel.Size = new System.Drawing.Size(89, 23);
            this.btnCargaExcel.TabIndex = 0;
            this.btnCargaExcel.Text = "Buscar Excel..";
            this.btnCargaExcel.UseVisualStyleBackColor = true;
            this.btnCargaExcel.Click += new System.EventHandler(this.btnCargaExcel_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBox7);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer4.Size = new System.Drawing.Size(858, 282);
            this.splitContainer4.SplitterDistance = 414;
            this.splitContainer4.TabIndex = 8;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.gridControlSistema);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(414, 282);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "INGRESOS Y EGRESOS DEL SISTEMA";
            // 
            // gridControlSistema
            // 
            this.gridControlSistema.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.gridControlSistema.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControlSistema.Location = new System.Drawing.Point(3, 16);
            this.gridControlSistema.MainView = this.gridViewSistema;
            this.gridControlSistema.Name = "gridControlSistema";
            this.gridControlSistema.Size = new System.Drawing.Size(408, 263);
            this.gridControlSistema.TabIndex = 9;
            this.gridControlSistema.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSistema});
            // 
            // gridViewSistema
            // 
            this.gridViewSistema.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn32,
            this.gridColumn29,
            this.chkcolum,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn25,
            this.gridColumn26,
            this.gridColumn27,
            this.gridColumn28,
            this.Orden});
            this.gridViewSistema.GridControl = this.gridControlSistema;
            this.gridViewSistema.Name = "gridViewSistema";
            this.gridViewSistema.OptionsBehavior.Editable = false;
            this.gridViewSistema.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSistema.OptionsView.ShowGroupPanel = false;
            this.gridViewSistema.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewSistema_RowCellClick);
            this.gridViewSistema.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewSistema_CellValueChanging);
            // 
            // gridColumn32
            // 
            this.gridColumn32.Caption = "Reg";
            this.gridColumn32.FieldName = "SecuenciaConciliacion";
            this.gridColumn32.Name = "gridColumn32";
            this.gridColumn32.Visible = true;
            this.gridColumn32.VisibleIndex = 1;
            this.gridColumn32.Width = 74;
            // 
            // gridColumn29
            // 
            this.gridColumn29.Caption = "Reg Relacionado";
            this.gridColumn29.FieldName = "SecuenciaRelacionado";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.Visible = true;
            this.gridColumn29.VisibleIndex = 2;
            this.gridColumn29.Width = 36;
            // 
            // chkcolum
            // 
            this.chkcolum.Caption = "*";
            this.chkcolum.FieldName = "chk";
            this.chkcolum.Name = "chkcolum";
            this.chkcolum.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.chkcolum.Visible = true;
            this.chkcolum.VisibleIndex = 0;
            this.chkcolum.Width = 55;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "# CbteCble";
            this.gridColumn19.FieldName = "IdCbteCble";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 3;
            this.gridColumn19.Width = 151;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Fecha";
            this.gridColumn20.FieldName = "cb_Fecha";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.AllowEdit = false;
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 5;
            this.gridColumn20.Width = 151;
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "Observación";
            this.gridColumn25.FieldName = "cb_Observacion";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.OptionsColumn.AllowEdit = false;
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 6;
            this.gridColumn25.Width = 151;
            // 
            // gridColumn26
            // 
            this.gridColumn26.Caption = "# Cheque";
            this.gridColumn26.FieldName = "cb_Cheque";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.OptionsColumn.AllowEdit = false;
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 7;
            this.gridColumn26.Width = 151;
            // 
            // gridColumn27
            // 
            this.gridColumn27.Caption = "Valor";
            this.gridColumn27.FieldName = "dc_Valor";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.OptionsColumn.AllowEdit = false;
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 8;
            this.gridColumn27.Width = 190;
            // 
            // gridColumn28
            // 
            this.gridColumn28.Caption = "Tipo Cbte Cble";
            this.gridColumn28.FieldName = "ReferenciaCbte";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.OptionsColumn.AllowEdit = false;
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 4;
            this.gridColumn28.Width = 174;
            // 
            // Orden
            // 
            this.Orden.Caption = "Orden";
            this.Orden.FieldName = "Orden";
            this.Orden.Name = "Orden";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.gridControlExcel);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(440, 282);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DATOS EXCEL";
            // 
            // gridControlExcel
            // 
            this.gridControlExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode3.RelationName = "Level1";
            this.gridControlExcel.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            this.gridControlExcel.Location = new System.Drawing.Point(3, 16);
            this.gridControlExcel.MainView = this.gridViewExcel;
            this.gridControlExcel.Name = "gridControlExcel";
            this.gridControlExcel.Size = new System.Drawing.Size(434, 263);
            this.gridControlExcel.TabIndex = 8;
            this.gridControlExcel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewExcel});
            // 
            // gridViewExcel
            // 
            this.gridViewExcel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn30,
            this.gridColumn31});
            this.gridViewExcel.CustomizationFormBounds = new System.Drawing.Rectangle(1015, 346, 216, 178);
            this.gridViewExcel.GridControl = this.gridControlExcel;
            this.gridViewExcel.Name = "gridViewExcel";
            this.gridViewExcel.OptionsView.ShowAutoFilterRow = true;
            this.gridViewExcel.OptionsView.ShowGroupPanel = false;
            this.gridViewExcel.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn30, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "*";
            this.gridColumn2.FieldName = "chk";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 20;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "CodTipoCbteBan";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 65;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Fecha";
            this.gridColumn4.FieldName = "cb_Fecha";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 56;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Observación";
            this.gridColumn5.FieldName = "cb_Observacion";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 56;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "# Documento";
            this.gridColumn6.FieldName = "cb_Cheque";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 56;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Monto";
            this.gridColumn7.FieldName = "dc_Valor";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 83;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tipo";
            this.gridColumn8.FieldName = "CodTipoCbte";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            this.gridColumn8.Width = 67;
            // 
            // gridColumn30
            // 
            this.gridColumn30.Caption = "Reg Relacionado";
            this.gridColumn30.FieldName = "SecuenciaRelacionado";
            this.gridColumn30.Name = "gridColumn30";
            this.gridColumn30.Width = 28;
            // 
            // gridColumn31
            // 
            this.gridColumn31.Caption = "Reg";
            this.gridColumn31.FieldName = "SecuenciaConciliacion";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.Visible = true;
            this.gridColumn31.VisibleIndex = 1;
            this.gridColumn31.Width = 24;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1187, 29);
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
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btn_conciliacion_Auto_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btn_conciliacion_Auto_Click(this.ucGe_Menu_event_btn_conciliacion_Auto_Click);
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_imprimir_ingresos});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(442, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_imprimir_egresos});
            this.toolStrip2.Location = new System.Drawing.Point(3, 16);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(400, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_imprimir_ingresos
            // 
            this.btn_imprimir_ingresos.Image = global::Core.Erp.Winform.Properties.Resources.imprimir_32x32;
            this.btn_imprimir_ingresos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir_ingresos.Name = "btn_imprimir_ingresos";
            this.btn_imprimir_ingresos.Size = new System.Drawing.Size(73, 22);
            this.btn_imprimir_ingresos.Text = "Imprimir";
            this.btn_imprimir_ingresos.Click += new System.EventHandler(this.btn_imprimir_ingresos_Click);
            // 
            // btn_imprimir_egresos
            // 
            this.btn_imprimir_egresos.Image = global::Core.Erp.Winform.Properties.Resources.imprimir_32x32;
            this.btn_imprimir_egresos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir_egresos.Name = "btn_imprimir_egresos";
            this.btn_imprimir_egresos.Size = new System.Drawing.Size(73, 22);
            this.btn_imprimir_egresos.Text = "Imprimir";
            this.btn_imprimir_egresos.Click += new System.EventHandler(this.btn_imprimir_egresos_Click);
            // 
            // FrmBA_ConciliacionBancaria_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 620);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.splitContainer2);
            this.Name = "FrmBA_ConciliacionBancaria_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conciliacion Bancaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBa_ConciliacionBancaria_FormClosing);
            this.Load += new System.EventHandler(this.FrmBa_ConciliacionBancaria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_periodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbCtaBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.gpB_Resumen.ResumeLayout(false);
            this.gpB_Resumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Saldo_anterior_banco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_diferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_saldoBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_saldoConciliado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_egreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_ingresos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_SaldoCtbleAnterior.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Ingresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Ingresos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Egresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Egresos)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ConManual.ResumeLayout(false);
            this.ConAutomatica.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSistema)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExcel)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Button btn_cargarMovimientos;
        private System.Windows.Forms.GroupBox gpB_Resumen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gridControl_Egresos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Egresos;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck2;
        private DevExpress.XtraGrid.Columns.GridColumn colCbteCble2;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_IdTipoCbte2;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha2;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenciaCbte2;
        private DevExpress.XtraGrid.Columns.GridColumn colcheque2;
        private DevExpress.XtraGrid.Columns.GridColumn colValor2;
        private DevExpress.XtraGrid.GridControl gridControl_Ingresos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Ingresos;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colCbteCble;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_IdTipoCbte;
        private System.Windows.Forms.TextBox txt_CtaCble;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_NConciliacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_Anulado;
        private System.Windows.Forms.TextBox txt_observacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txt_nombreCta;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ConManual;
        private System.Windows.Forms.TabPage ConAutomatica;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnCargaExcel;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevExpress.XtraGrid.GridControl gridControlExcel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewExcel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.GridControl gridControlSistema;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSistema;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn chkcolum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private System.Windows.Forms.Button btnConciliar;
        private DevExpress.XtraGrid.Columns.GridColumn Orden;
        private DevExpress.XtraEditors.SearchLookUpEdit ultraCmbCtaBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colba_descripcion;
        private DevExpress.XtraEditors.SearchLookUpEdit ultraCmbE_periodo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colname_periodo;
        private DevExpress.XtraEditors.TextEdit txe_SaldoCtbleAnterior;
        private DevExpress.XtraEditors.TextEdit txe_ingresos;
        private DevExpress.XtraEditors.TextEdit txe_egreso;
        private DevExpress.XtraEditors.TextEdit txe_saldoConciliado;
        private DevExpress.XtraEditors.TextEdit txe_saldoBanco;
        private DevExpress.XtraEditors.TextEdit txe_diferencia;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdCtaCble;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private DevExpress.XtraEditors.LabelControl lb_EstadoConciliacion;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.TextEdit txt_Saldo_anterior_banco;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_imprimir_ingresos;
        private System.Windows.Forms.ToolStripButton btn_imprimir_egresos;
    }
}