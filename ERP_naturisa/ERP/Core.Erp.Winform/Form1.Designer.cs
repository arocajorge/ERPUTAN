namespace Core.Erp.Winform
{
    partial class Form1
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabPage_info_crediticia = new DevExpress.XtraTab.XtraTabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_num_oc = new DevExpress.XtraEditors.TextEdit();
            this.spinEditDiasPlazo = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTerminoPago = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDias_Vct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_Cuotas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.txt_atencion_a = new DevExpress.XtraEditors.MemoEdit();
            this.tabPage_forma_pago = new DevExpress.XtraTab.XtraTabPage();
            this.ucFa_FormaPago_x_Factura = new Core.Erp.Winform.Controles.UCFa_FormaPago_x_Factura();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucFa_FormaPago_x_Factura1 = new Core.Erp.Winform.Controles.UCFa_FormaPago_x_Factura();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabPage_info_crediticia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_oc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditDiasPlazo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTerminoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_atencion_a.Properties)).BeginInit();
            this.tabPage_forma_pago.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(512, 45);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabPage_info_crediticia;
            this.xtraTabControl1.Size = new System.Drawing.Size(571, 224);
            this.xtraTabControl1.TabIndex = 33;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPage_info_crediticia,
            this.tabPage_forma_pago});
            // 
            // tabPage_info_crediticia
            // 
            this.tabPage_info_crediticia.Controls.Add(this.label7);
            this.tabPage_info_crediticia.Controls.Add(this.label6);
            this.tabPage_info_crediticia.Controls.Add(this.txt_num_oc);
            this.tabPage_info_crediticia.Controls.Add(this.spinEditDiasPlazo);
            this.tabPage_info_crediticia.Controls.Add(this.labelControl2);
            this.tabPage_info_crediticia.Controls.Add(this.cmbTerminoPago);
            this.tabPage_info_crediticia.Controls.Add(this.label3);
            this.tabPage_info_crediticia.Controls.Add(this.label1);
            this.tabPage_info_crediticia.Controls.Add(this.label2);
            this.tabPage_info_crediticia.Controls.Add(this.dateFechaVencimiento);
            this.tabPage_info_crediticia.Controls.Add(this.dateFecha);
            this.tabPage_info_crediticia.Controls.Add(this.txt_atencion_a);
            this.tabPage_info_crediticia.Name = "tabPage_info_crediticia";
            this.tabPage_info_crediticia.Size = new System.Drawing.Size(565, 196);
            this.tabPage_info_crediticia.Text = "Información crediticio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Atención a:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "# OC:";
            // 
            // txt_num_oc
            // 
            this.txt_num_oc.Location = new System.Drawing.Point(106, 77);
            this.txt_num_oc.Name = "txt_num_oc";
            this.txt_num_oc.Properties.MaxLength = 50;
            this.txt_num_oc.Size = new System.Drawing.Size(445, 20);
            this.txt_num_oc.TabIndex = 3;
            // 
            // spinEditDiasPlazo
            // 
            this.spinEditDiasPlazo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditDiasPlazo.Location = new System.Drawing.Point(260, 48);
            this.spinEditDiasPlazo.Name = "spinEditDiasPlazo";
            this.spinEditDiasPlazo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditDiasPlazo.Properties.Mask.EditMask = "n0";
            this.spinEditDiasPlazo.Size = new System.Drawing.Size(50, 20);
            this.spinEditDiasPlazo.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Término de pago:";
            // 
            // cmbTerminoPago
            // 
            this.cmbTerminoPago.Location = new System.Drawing.Point(106, 22);
            this.cmbTerminoPago.Name = "cmbTerminoPago";
            this.cmbTerminoPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTerminoPago.Properties.DisplayMember = "nom_TerminoPago";
            this.cmbTerminoPago.Properties.NullText = "";
            this.cmbTerminoPago.Properties.ValueMember = "IdTerminoPago";
            this.cmbTerminoPago.Properties.View = this.gridView2;
            this.cmbTerminoPago.Size = new System.Drawing.Size(445, 20);
            this.cmbTerminoPago.TabIndex = 0;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion1,
            this.colDias_Vct,
            this.colIdTipoFormaPago,
            this.colNum_Cuotas});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.Caption = "Descripción";
            this.colDescripcion1.FieldName = "nom_TerminoPago";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 0;
            this.colDescripcion1.Width = 736;
            // 
            // colDias_Vct
            // 
            this.colDias_Vct.FieldName = "Dias_Vct";
            this.colDias_Vct.Name = "colDias_Vct";
            this.colDias_Vct.Visible = true;
            this.colDias_Vct.VisibleIndex = 1;
            this.colDias_Vct.Width = 151;
            // 
            // colIdTipoFormaPago
            // 
            this.colIdTipoFormaPago.FieldName = "IdTerminoPago";
            this.colIdTipoFormaPago.Name = "colIdTipoFormaPago";
            this.colIdTipoFormaPago.Visible = true;
            this.colIdTipoFormaPago.VisibleIndex = 3;
            this.colIdTipoFormaPago.Width = 149;
            // 
            // colNum_Cuotas
            // 
            this.colNum_Cuotas.FieldName = "Num_Cuotas";
            this.colNum_Cuotas.Name = "colNum_Cuotas";
            this.colNum_Cuotas.Visible = true;
            this.colNum_Cuotas.VisibleIndex = 2;
            this.colNum_Cuotas.Width = 144;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dias Plazo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha vencimiento:";
            // 
            // dateFechaVencimiento
            // 
            this.dateFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaVencimiento.Location = new System.Drawing.Point(424, 49);
            this.dateFechaVencimiento.Name = "dateFechaVencimiento";
            this.dateFechaVencimiento.Size = new System.Drawing.Size(80, 20);
            this.dateFechaVencimiento.TabIndex = 2;
            // 
            // dateFecha
            // 
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(106, 48);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(82, 20);
            this.dateFecha.TabIndex = 0;
            // 
            // txt_atencion_a
            // 
            this.txt_atencion_a.Location = new System.Drawing.Point(106, 103);
            this.txt_atencion_a.Name = "txt_atencion_a";
            this.txt_atencion_a.Properties.MaxLength = 500;
            this.txt_atencion_a.Size = new System.Drawing.Size(445, 72);
            this.txt_atencion_a.TabIndex = 5;
            // 
            // tabPage_forma_pago
            // 
            this.tabPage_forma_pago.Controls.Add(this.ucFa_FormaPago_x_Factura);
            this.tabPage_forma_pago.Name = "tabPage_forma_pago";
            this.tabPage_forma_pago.Size = new System.Drawing.Size(565, 196);
            this.tabPage_forma_pago.Text = "Forma de pago";
            // 
            // ucFa_FormaPago_x_Factura
            // 
            this.ucFa_FormaPago_x_Factura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFa_FormaPago_x_Factura.Location = new System.Drawing.Point(0, 0);
            this.ucFa_FormaPago_x_Factura.Name = "ucFa_FormaPago_x_Factura";
            this.ucFa_FormaPago_x_Factura.Size = new System.Drawing.Size(565, 196);
            this.ucFa_FormaPago_x_Factura.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucFa_FormaPago_x_Factura1);
            this.groupBox1.Controls.Add(this.searchLookUpEdit1);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(35, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 202);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condiciones de Credito...";
            // 
            // ucFa_FormaPago_x_Factura1
            // 
            this.ucFa_FormaPago_x_Factura1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucFa_FormaPago_x_Factura1.Location = new System.Drawing.Point(3, 98);
            this.ucFa_FormaPago_x_Factura1.Name = "ucFa_FormaPago_x_Factura1";
            this.ucFa_FormaPago_x_Factura1.Size = new System.Drawing.Size(450, 101);
            this.ucFa_FormaPago_x_Factura1.TabIndex = 0;
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(5, 30);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DisplayMember = "nom_TerminoPago";
            this.searchLookUpEdit1.Properties.NullText = "";
            this.searchLookUpEdit1.Properties.ValueMember = "IdTerminoPago";
            this.searchLookUpEdit1.Properties.View = this.gridView1;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(445, 20);
            this.searchLookUpEdit1.TabIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Descripción";
            this.gridColumn1.FieldName = "nom_TerminoPago";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 736;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Dias_Vct";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 151;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "IdTerminoPago";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 149;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Num_Cuotas";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 144;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Término de pago:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.spinEdit1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Location = new System.Drawing.Point(6, 56);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(444, 39);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(197, 11);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Properties.Mask.EditMask = "n0";
            this.spinEdit1.Size = new System.Drawing.Size(50, 20);
            this.spinEdit1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(358, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dias Plazo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fecha vencimiento:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(52, 11);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(153, 275);
            this.gridControl1.MainView = this.gridView3;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(527, 200);
            this.gridControl1.TabIndex = 35;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsPrint.PrintFilterInfo = true;
            this.gridView3.OptionsPrint.PrintGroupFooter = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 492);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabPage_info_crediticia.ResumeLayout(false);
            this.tabPage_info_crediticia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_oc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditDiasPlazo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTerminoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_atencion_a.Properties)).EndInit();
            this.tabPage_forma_pago.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabPage_info_crediticia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txt_num_oc;
        private DevExpress.XtraEditors.SpinEdit spinEditDiasPlazo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTerminoPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colDias_Vct;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_Cuotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dateFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private DevExpress.XtraEditors.MemoEdit txt_atencion_a;
        private DevExpress.XtraTab.XtraTabPage tabPage_forma_pago;
        private Controles.UCFa_FormaPago_x_Factura ucFa_FormaPago_x_Factura;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controles.UCFa_FormaPago_x_Factura ucFa_FormaPago_x_Factura1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;




        //private Controles.UCGe_Persona_x_Direcciones_Grid ucGe_Persona_x_Direcciones_Grid1;








    }
}