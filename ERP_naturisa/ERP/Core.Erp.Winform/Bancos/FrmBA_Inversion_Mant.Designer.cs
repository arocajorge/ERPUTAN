namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Inversion_Mant
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBanco = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.baBancoCuentaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Num_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblIdInversion = new System.Windows.Forms.Label();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpFecha = new DevExpress.XtraEditors.DateEdit();
            this.txtOtros = new DevExpress.XtraEditors.TextEdit();
            this.txtPlazo = new DevExpress.XtraEditors.TextEdit();
            this.txtPRetencion = new DevExpress.XtraEditors.TextEdit();
            this.txtTasa = new DevExpress.XtraEditors.TextEdit();
            this.txtMonto = new DevExpress.XtraEditors.TextEdit();
            this.dtpFVcto = new DevExpress.XtraEditors.DateEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.txtRetencion = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baBancoCuentaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlazo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPRetencion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFVcto.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFVcto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cmbBanco);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.lblIdInversion);
            this.groupBox2.Controls.Add(this.lblAnulado);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(3, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cmbBanco
            // 
            this.cmbBanco.Location = new System.Drawing.Point(76, 61);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBanco.Properties.DataSource = this.baBancoCuentaInfoBindingSource;
            this.cmbBanco.Properties.DisplayMember = "ba_descripcion";
            this.cmbBanco.Properties.ValueMember = "IdBanco";
            this.cmbBanco.Properties.View = this.searchLookUpEdit1View;
            this.cmbBanco.Size = new System.Drawing.Size(205, 20);
            this.cmbBanco.TabIndex = 1;
            // 
            // baBancoCuentaInfoBindingSource
            // 
            this.baBancoCuentaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Bancos.ba_Banco_Cuenta_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colba_descripcion,
            this.colba_Num_Cuenta,
            this.colIdBanco});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colba_descripcion
            // 
            this.colba_descripcion.Caption = "Banco";
            this.colba_descripcion.FieldName = "ba_descripcion";
            this.colba_descripcion.Name = "colba_descripcion";
            this.colba_descripcion.Visible = true;
            this.colba_descripcion.VisibleIndex = 0;
            this.colba_descripcion.Width = 543;
            // 
            // colba_Num_Cuenta
            // 
            this.colba_Num_Cuenta.Caption = "Cuenta N#";
            this.colba_Num_Cuenta.FieldName = "ba_Num_Cuenta";
            this.colba_Num_Cuenta.Name = "colba_Num_Cuenta";
            this.colba_Num_Cuenta.Visible = true;
            this.colba_Num_Cuenta.VisibleIndex = 1;
            this.colba_Num_Cuenta.Width = 497;
            // 
            // colIdBanco
            // 
            this.colIdBanco.Caption = "ID";
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.Visible = true;
            this.colIdBanco.VisibleIndex = 2;
            this.colIdBanco.Width = 140;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(76, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(177, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblIdInversion
            // 
            this.lblIdInversion.AutoSize = true;
            this.lblIdInversion.Location = new System.Drawing.Point(76, 18);
            this.lblIdInversion.Name = "lblIdInversion";
            this.lblIdInversion.Size = new System.Drawing.Size(10, 13);
            this.lblIdInversion.TabIndex = 5;
            this.lblIdInversion.Text = "-";
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(387, 36);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(106, 17);
            this.lblAnulado.TabIndex = 4;
            this.lblAnulado.Text = "**ANULADO**";
            this.lblAnulado.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Banco:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtOtros);
            this.groupBox1.Controls.Add(this.txtPlazo);
            this.groupBox1.Controls.Add(this.txtPRetencion);
            this.groupBox1.Controls.Add(this.txtTasa);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.dtpFVcto);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtCapital);
            this.groupBox1.Controls.Add(this.txtInteres);
            this.groupBox1.Controls.Add(this.txtRetencion);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Location = new System.Drawing.Point(3, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 276);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(312, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Fecha de Inversión";
            // 
            // dtpFecha
            // 
            this.dtpFecha.EditValue = null;
            this.dtpFecha.Location = new System.Drawing.Point(417, 20);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpFecha.Size = new System.Drawing.Size(117, 20);
            this.dtpFecha.TabIndex = 9;
            this.dtpFecha.EditValueChanged += new System.EventHandler(this.dtpFecha_EditValueChanged);
            // 
            // txtOtros
            // 
            this.txtOtros.Location = new System.Drawing.Point(104, 102);
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Properties.Mask.EditMask = "c";
            this.txtOtros.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtOtros.Size = new System.Drawing.Size(159, 20);
            this.txtOtros.TabIndex = 4;
            this.txtOtros.EditValueChanged += new System.EventHandler(this.txtOtros_EditValueChanged);
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(417, 46);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Properties.Mask.EditMask = "[0-9]+";
            this.txtPlazo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtPlazo.Properties.MaxLength = 5;
            this.txtPlazo.Size = new System.Drawing.Size(74, 20);
            this.txtPlazo.TabIndex = 10;
            this.txtPlazo.EditValueChanged += new System.EventHandler(this.txtPlazo_EditValueChanged);
            // 
            // txtPRetencion
            // 
            this.txtPRetencion.Location = new System.Drawing.Point(104, 74);
            this.txtPRetencion.Name = "txtPRetencion";
            this.txtPRetencion.Properties.Mask.EditMask = "p";
            this.txtPRetencion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPRetencion.Size = new System.Drawing.Size(65, 20);
            this.txtPRetencion.TabIndex = 2;
            this.txtPRetencion.EditValueChanged += new System.EventHandler(this.txtPRetencion_EditValueChanged);
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(106, 47);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Properties.Mask.EditMask = "p";
            this.txtTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTasa.Size = new System.Drawing.Size(159, 20);
            this.txtTasa.TabIndex = 1;
            this.txtTasa.EditValueChanged += new System.EventHandler(this.txtTasa_EditValueChanged);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(106, 20);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Properties.Mask.EditMask = "c";
            this.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMonto.Size = new System.Drawing.Size(159, 20);
            this.txtMonto.TabIndex = 0;
            this.txtMonto.EditValueChanged += new System.EventHandler(this.txtMonto_EditValueChanged);
            // 
            // dtpFVcto
            // 
            this.dtpFVcto.EditValue = null;
            this.dtpFVcto.Enabled = false;
            this.dtpFVcto.Location = new System.Drawing.Point(417, 75);
            this.dtpFVcto.Name = "dtpFVcto";
            this.dtpFVcto.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtpFVcto.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.dtpFVcto.Properties.Appearance.Options.UseBackColor = true;
            this.dtpFVcto.Properties.Appearance.Options.UseForeColor = true;
            this.dtpFVcto.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.dtpFVcto.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.dtpFVcto.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.dtpFVcto.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.dtpFVcto.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White;
            this.dtpFVcto.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black;
            this.dtpFVcto.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.dtpFVcto.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.dtpFVcto.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White;
            this.dtpFVcto.Properties.AppearanceDropDownHeader.ForeColor = System.Drawing.Color.Black;
            this.dtpFVcto.Properties.AppearanceDropDownHeader.Options.UseBackColor = true;
            this.dtpFVcto.Properties.AppearanceDropDownHeader.Options.UseForeColor = true;
            this.dtpFVcto.Properties.AppearanceDropDownHeaderHighlight.BackColor = System.Drawing.Color.White;
            this.dtpFVcto.Properties.AppearanceDropDownHeaderHighlight.ForeColor = System.Drawing.Color.Black;
            this.dtpFVcto.Properties.AppearanceDropDownHeaderHighlight.Options.UseBackColor = true;
            this.dtpFVcto.Properties.AppearanceDropDownHeaderHighlight.Options.UseForeColor = true;
            this.dtpFVcto.Properties.AppearanceDropDownHighlight.BackColor = System.Drawing.Color.White;
            this.dtpFVcto.Properties.AppearanceDropDownHighlight.ForeColor = System.Drawing.Color.Black;
            this.dtpFVcto.Properties.AppearanceDropDownHighlight.Options.UseBackColor = true;
            this.dtpFVcto.Properties.AppearanceDropDownHighlight.Options.UseForeColor = true;
            this.dtpFVcto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White;
            this.dtpFVcto.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black;
            this.dtpFVcto.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.dtpFVcto.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.dtpFVcto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.dtpFVcto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.dtpFVcto.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.dtpFVcto.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.dtpFVcto.Properties.AppearanceWeekNumber.BackColor = System.Drawing.Color.White;
            this.dtpFVcto.Properties.AppearanceWeekNumber.ForeColor = System.Drawing.Color.Black;
            this.dtpFVcto.Properties.AppearanceWeekNumber.Options.UseBackColor = true;
            this.dtpFVcto.Properties.AppearanceWeekNumber.Options.UseForeColor = true;
            this.dtpFVcto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFVcto.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpFVcto.Size = new System.Drawing.Size(117, 20);
            this.dtpFVcto.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(312, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Vencimiento:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(513, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "ds.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(312, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Plazo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Observación:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Total a Recibir:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Capital:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "(-) Interes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "(+/-) Otros:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "(-) Retención:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tasa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Monto:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(104, 218);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(400, 55);
            this.txtObservacion.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotal.Location = new System.Drawing.Point(104, 191);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(161, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // txtCapital
            // 
            this.txtCapital.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCapital.Location = new System.Drawing.Point(104, 164);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.ReadOnly = true;
            this.txtCapital.Size = new System.Drawing.Size(161, 20);
            this.txtCapital.TabIndex = 6;
            // 
            // txtInteres
            // 
            this.txtInteres.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInteres.Location = new System.Drawing.Point(104, 128);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.ReadOnly = true;
            this.txtInteres.Size = new System.Drawing.Size(161, 20);
            this.txtInteres.TabIndex = 5;
            this.txtInteres.TextChanged += new System.EventHandler(this.txtInteres_TextChanged);
            // 
            // txtRetencion
            // 
            this.txtRetencion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRetencion.Location = new System.Drawing.Point(175, 74);
            this.txtRetencion.Name = "txtRetencion";
            this.txtRetencion.ReadOnly = true;
            this.txtRetencion.Size = new System.Drawing.Size(90, 20);
            this.txtRetencion.TabIndex = 3;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(552, 257);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 5;
            this.lineShape1.X2 = 597;
            this.lineShape1.Y1 = 139;
            this.lineShape1.Y2 = 139;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(565, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
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
            // FrmBA_Inversion_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 400);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBA_Inversion_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inversión Mantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBA_Inversion_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmBA_Inversion_Mant_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baBancoCuentaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlazo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPRetencion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFVcto.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFVcto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblIdInversion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DateEdit dtpFVcto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.TextBox txtRetencion;
        private DevExpress.XtraEditors.TextEdit txtPlazo;
        private DevExpress.XtraEditors.TextEdit txtPRetencion;
        private DevExpress.XtraEditors.TextEdit txtTasa;
        private DevExpress.XtraEditors.TextEdit txtMonto;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private DevExpress.XtraEditors.TextEdit txtOtros;
        private System.Windows.Forms.BindingSource baBancoCuentaInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colba_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colba_Num_Cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.DateEdit dtpFecha;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
    }
}