namespace Core.Erp.Reportes.Contabilidad
{
    partial class XCONTA_Rpt012_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XCONTA_Rpt012_frm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.chkMostrar_Reg_Cero = new System.Windows.Forms.CheckBox();
            this.cmb_nivel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkList_Periodos = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.chkMostrarCC = new DevExpress.XtraEditors.CheckEdit();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Reportes.frmEspere), true, true);
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkList_Periodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostrarCC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(930, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Core.Erp.Reportes.Properties.Resources.salir_64x64;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkMostrar_Reg_Cero
            // 
            this.chkMostrar_Reg_Cero.AutoSize = true;
            this.chkMostrar_Reg_Cero.Location = new System.Drawing.Point(473, 110);
            this.chkMostrar_Reg_Cero.Name = "chkMostrar_Reg_Cero";
            this.chkMostrar_Reg_Cero.Size = new System.Drawing.Size(148, 17);
            this.chkMostrar_Reg_Cero.TabIndex = 19;
            this.chkMostrar_Reg_Cero.Text = "Mostrar Registros en Cero";
            this.chkMostrar_Reg_Cero.UseVisualStyleBackColor = true;
            // 
            // cmb_nivel
            // 
            this.cmb_nivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nivel.FormattingEnabled = true;
            this.cmb_nivel.Location = new System.Drawing.Point(473, 80);
            this.cmb_nivel.Name = "cmb_nivel";
            this.cmb_nivel.Size = new System.Drawing.Size(146, 21);
            this.cmb_nivel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mostrar desde el nivel:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkList_Periodos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 421);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodos a Mostrar";
            // 
            // chkList_Periodos
            // 
            this.chkList_Periodos.CheckOnClick = true;
            this.chkList_Periodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkList_Periodos.Location = new System.Drawing.Point(3, 16);
            this.chkList_Periodos.Name = "chkList_Periodos";
            this.chkList_Periodos.Size = new System.Drawing.Size(331, 402);
            this.chkList_Periodos.TabIndex = 0;
            // 
            // chkMostrarCC
            // 
            this.chkMostrarCC.Location = new System.Drawing.Point(470, 133);
            this.chkMostrarCC.Name = "chkMostrarCC";
            this.chkMostrarCC.Properties.Caption = "Mostrar centro de costo";
            this.chkMostrarCC.Size = new System.Drawing.Size(149, 19);
            this.chkMostrarCC.TabIndex = 26;
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Items.AddRange(new object[] {
            "ESTADO DE RESULTADO",
            "BALANCE GENERAL"});
            this.cmb_Estado.Location = new System.Drawing.Point(354, 53);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(267, 21);
            this.cmb_Estado.TabIndex = 27;
            // 
            // XCONTA_Rpt012_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 446);
            this.Controls.Add(this.cmb_Estado);
            this.Controls.Add(this.chkMostrarCC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkMostrar_Reg_Cero);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmb_nivel);
            this.Controls.Add(this.label2);
            this.Name = "XCONTA_Rpt012_frm";
            this.Text = "XCONTA_Rpt012_frm";
            this.Load += new System.EventHandler(this.XCONTA_Rpt012_frm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkList_Periodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostrarCC.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.CheckBox chkMostrar_Reg_Cero;
        private System.Windows.Forms.ComboBox cmb_nivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.CheckedListBoxControl chkList_Periodos;
        private DevExpress.XtraEditors.CheckEdit chkMostrarCC;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private System.Windows.Forms.ComboBox cmb_Estado;
    }
}