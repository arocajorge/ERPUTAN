namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxcMantenimiento_Cheques_Multa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCxcMantenimiento_Cheques_Multa));
            this.label1 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnProtestar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_salir = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProtestar = new System.Windows.Forms.TextBox();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.cxccobroInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDeposito = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_NumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txeMonto = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNCh = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtCta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCtaBanco = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txeMulta = new DevExpress.XtraEditors.TextEdit();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeposito)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCtaBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeMulta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multa";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(133, 127);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(83, 20);
            this.dtFecha.TabIndex = 60;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(133, 183);
            this.txtObservacion.MaxLength = 200;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(370, 66);
            this.txtObservacion.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de Protesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Observacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cta. Banco Debito";
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProtestar,
            this.toolStripLabel1,
            this.toolStripSeparator7,
            this.mnu_salir});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(703, 25);
            this.toolStripMain.TabIndex = 63;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // btnProtestar
            // 
            this.btnProtestar.Image = global::Core.Erp.Winform.Properties.Resources.Guardar1;
            this.btnProtestar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProtestar.Name = "btnProtestar";
            this.btnProtestar.Size = new System.Drawing.Size(118, 22);
            this.btnProtestar.Text = "Protestar Cheque";
            this.btnProtestar.Click += new System.EventHandler(this.btnProtestar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(145, 22);
            this.toolStripLabel1.Text = "                                              ";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // mnu_salir
            // 
            this.mnu_salir.Image = ((System.Drawing.Image)(resources.GetObject("mnu_salir.Image")));
            this.mnu_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_salir.Name = "mnu_salir";
            this.mnu_salir.Size = new System.Drawing.Size(49, 22);
            this.mnu_salir.Text = "&Salir";
            this.mnu_salir.Click += new System.EventHandler(this.mnu_salir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Detalle del Deposito";
            // 
            // lblProtestar
            // 
            this.lblProtestar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblProtestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtestar.ForeColor = System.Drawing.Color.Red;
            this.lblProtestar.Location = new System.Drawing.Point(133, 341);
            this.lblProtestar.MaxLength = 200;
            this.lblProtestar.Multiline = true;
            this.lblProtestar.Name = "lblProtestar";
            this.lblProtestar.ReadOnly = true;
            this.lblProtestar.Size = new System.Drawing.Size(558, 66);
            this.lblProtestar.TabIndex = 61;
            this.lblProtestar.Text = "***No se puede Protestar, por que el Cheque no esta depositado***";
            this.lblProtestar.Visible = false;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.cxccobroInfoBindingSource1;
            this.gridControl.Location = new System.Drawing.Point(133, 260);
            this.gridControl.MainView = this.gridViewDeposito;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(558, 75);
            this.gridControl.TabIndex = 65;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDeposito});
            // 
            // cxccobroInfoBindingSource1
            // 
            this.cxccobroInfoBindingSource1.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_cobro_Info);
            // 
            // gridViewDeposito
            // 
            this.gridViewDeposito.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCobro,
            this.colIdCobro_tipo,
            this.colcr_observacion,
            this.colcr_Banco,
            this.colcr_cuenta,
            this.colcr_NumDocumento,
            this.Banco,
            this.Sucursal,
            this.Cliente});
            this.gridViewDeposito.GridControl = this.gridControl;
            this.gridViewDeposito.Name = "gridViewDeposito";
            this.gridViewDeposito.OptionsBehavior.Editable = false;
            this.gridViewDeposito.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCobro
            // 
            this.colIdCobro.FieldName = "IdCobro";
            this.colIdCobro.Name = "colIdCobro";
            this.colIdCobro.Visible = true;
            this.colIdCobro.VisibleIndex = 3;
            this.colIdCobro.Width = 58;
            // 
            // colIdCobro_tipo
            // 
            this.colIdCobro_tipo.FieldName = "IdCobro_tipo";
            this.colIdCobro_tipo.Name = "colIdCobro_tipo";
            this.colIdCobro_tipo.Visible = true;
            this.colIdCobro_tipo.VisibleIndex = 4;
            this.colIdCobro_tipo.Width = 70;
            // 
            // colcr_observacion
            // 
            this.colcr_observacion.Caption = "Observacion";
            this.colcr_observacion.FieldName = "cr_observacion";
            this.colcr_observacion.Name = "colcr_observacion";
            this.colcr_observacion.Visible = true;
            this.colcr_observacion.VisibleIndex = 8;
            this.colcr_observacion.Width = 69;
            // 
            // colcr_Banco
            // 
            this.colcr_Banco.Caption = "Banco CHQ";
            this.colcr_Banco.FieldName = "cr_Banco";
            this.colcr_Banco.Name = "colcr_Banco";
            this.colcr_Banco.Visible = true;
            this.colcr_Banco.VisibleIndex = 2;
            this.colcr_Banco.Width = 58;
            // 
            // colcr_cuenta
            // 
            this.colcr_cuenta.Caption = "#Cuenta";
            this.colcr_cuenta.FieldName = "cr_cuenta";
            this.colcr_cuenta.Name = "colcr_cuenta";
            this.colcr_cuenta.Visible = true;
            this.colcr_cuenta.VisibleIndex = 5;
            this.colcr_cuenta.Width = 54;
            // 
            // colcr_NumDocumento
            // 
            this.colcr_NumDocumento.Caption = "#Tarjeta";
            this.colcr_NumDocumento.FieldName = "cr_NumDocumento";
            this.colcr_NumDocumento.Name = "colcr_NumDocumento";
            this.colcr_NumDocumento.Visible = true;
            this.colcr_NumDocumento.VisibleIndex = 6;
            this.colcr_NumDocumento.Width = 54;
            // 
            // Banco
            // 
            this.Banco.Caption = "Banco Dep.";
            this.Banco.FieldName = "BancoCuenta.ba_descripcion";
            this.Banco.Name = "Banco";
            this.Banco.Visible = true;
            this.Banco.VisibleIndex = 7;
            this.Banco.Width = 48;
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "nSucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 0;
            this.Sucursal.Width = 58;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "nCliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 1;
            this.Cliente.Width = 58;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txeMonto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNCh);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.txtCta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBanco);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(374, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 132);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Cheque";
            // 
            // txeMonto
            // 
            this.txeMonto.Location = new System.Drawing.Point(163, 12);
            this.txeMonto.Name = "txeMonto";
            this.txeMonto.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeMonto.Size = new System.Drawing.Size(100, 20);
            this.txeMonto.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Monto del Cheque";
            // 
            // txtNCh
            // 
            this.txtNCh.Location = new System.Drawing.Point(163, 97);
            this.txtNCh.Name = "txtNCh";
            this.txtNCh.Size = new System.Drawing.Size(100, 20);
            this.txtNCh.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(35, 101);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(84, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Numero Cheque";
            // 
            // txtCta
            // 
            this.txtCta.Location = new System.Drawing.Point(163, 70);
            this.txtCta.Name = "txtCta";
            this.txtCta.Size = new System.Drawing.Size(100, 20);
            this.txtCta.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cuenta";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(163, 44);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(100, 20);
            this.txtBanco.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Banco";
            // 
            // cmbCtaBanco
            // 
            this.cmbCtaBanco.Location = new System.Drawing.Point(133, 88);
            this.cmbCtaBanco.Name = "cmbCtaBanco";
            this.cmbCtaBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCtaBanco.Properties.View = this.searchLookUpEdit1View;
            this.cmbCtaBanco.Size = new System.Drawing.Size(208, 20);
            this.cmbCtaBanco.TabIndex = 67;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txeMulta
            // 
            this.txeMulta.Location = new System.Drawing.Point(133, 47);
            this.txeMulta.Name = "txeMulta";
            this.txeMulta.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeMulta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeMulta.Size = new System.Drawing.Size(100, 20);
            this.txeMulta.TabIndex = 68;
            // 
            // frmCxcMantenimiento_Cheques_Multa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(703, 417);
            this.ControlBox = false;
            this.Controls.Add(this.txeMulta);
            this.Controls.Add(this.cmbCtaBanco);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.lblProtestar);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCxcMantenimiento_Cheques_Multa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Multa de Protesto de Cheque";
            this.Load += new System.EventHandler(this.frmCo_cxcMantenimiento_Cheques_Multa_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeposito)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCtaBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeMulta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnProtestar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton mnu_salir;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.TextBox txtObservacion;
        public System.Windows.Forms.TextBox lblProtestar;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDeposito;
        private System.Windows.Forms.BindingSource cxccobroInfoBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Banco;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_NumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn Banco;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtNCh;
        public System.Windows.Forms.TextBox txtCta;
        public System.Windows.Forms.TextBox txtBanco;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCtaBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txeMulta;
        private DevExpress.XtraEditors.TextEdit txeMonto;
    }
}