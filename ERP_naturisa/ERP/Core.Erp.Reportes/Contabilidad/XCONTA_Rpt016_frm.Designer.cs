namespace Core.Erp.Reportes.Contabilidad
{
    partial class XCONTA_Rpt016_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XCONTA_Rpt016_frm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkList_Periodos = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.chkMostrarCC = new DevExpress.XtraEditors.CheckEdit();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.cmb_nivel = new System.Windows.Forms.ComboBox();
            this.lbl_nivel = new System.Windows.Forms.Label();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Reportes.frmEspere), true, true);
            this.chkMostrar_Reg_Cero = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkList_Periodos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostrarCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostrar_Reg_Cero.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkList_Periodos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 390);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodos a Mostrar";
            // 
            // chkList_Periodos
            // 
            this.chkList_Periodos.CheckOnClick = true;
            this.chkList_Periodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkList_Periodos.Location = new System.Drawing.Point(3, 16);
            this.chkList_Periodos.Name = "chkList_Periodos";
            this.chkList_Periodos.Size = new System.Drawing.Size(331, 371);
            this.chkList_Periodos.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(620, 25);
            this.toolStrip1.TabIndex = 26;
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
            // chkMostrarCC
            // 
            this.chkMostrarCC.Location = new System.Drawing.Point(343, 95);
            this.chkMostrarCC.Name = "chkMostrarCC";
            this.chkMostrarCC.Properties.Caption = "Mostrar centro de costo";
            this.chkMostrarCC.Size = new System.Drawing.Size(149, 19);
            this.chkMostrarCC.TabIndex = 27;
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Items.AddRange(new object[] {
            "CUENTAS DE RESULTADO POR TIPO DE GASTO",
            "CUENTAS DE INGRESO",
            "CUENTAS DE MATERIA PRIMA"});
            this.cmb_Estado.Location = new System.Drawing.Point(340, 41);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(267, 21);
            this.cmb_Estado.TabIndex = 30;
            this.cmb_Estado.SelectedIndexChanged += new System.EventHandler(this.cmb_Estado_SelectedIndexChanged);
            // 
            // cmb_nivel
            // 
            this.cmb_nivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nivel.FormattingEnabled = true;
            this.cmb_nivel.Location = new System.Drawing.Point(461, 68);
            this.cmb_nivel.Name = "cmb_nivel";
            this.cmb_nivel.Size = new System.Drawing.Size(146, 21);
            this.cmb_nivel.TabIndex = 29;
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.Location = new System.Drawing.Point(340, 71);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(113, 13);
            this.lbl_nivel.TabIndex = 28;
            this.lbl_nivel.Text = "Mostrar desde el nivel:";
            // 
            // chkMostrar_Reg_Cero
            // 
            this.chkMostrar_Reg_Cero.Location = new System.Drawing.Point(343, 120);
            this.chkMostrar_Reg_Cero.Name = "chkMostrar_Reg_Cero";
            this.chkMostrar_Reg_Cero.Properties.Caption = "Mostrar registros en cero";
            this.chkMostrar_Reg_Cero.Size = new System.Drawing.Size(149, 19);
            this.chkMostrar_Reg_Cero.TabIndex = 31;
            // 
            // XCONTA_Rpt016_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 415);
            this.Controls.Add(this.chkMostrar_Reg_Cero);
            this.Controls.Add(this.cmb_Estado);
            this.Controls.Add(this.cmb_nivel);
            this.Controls.Add(this.lbl_nivel);
            this.Controls.Add(this.chkMostrarCC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "XCONTA_Rpt016_frm";
            this.Text = "XCONTA_Rpt016_frm";
            this.Load += new System.EventHandler(this.XCONTA_Rpt016_frm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkList_Periodos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostrarCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostrar_Reg_Cero.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.CheckedListBoxControl chkList_Periodos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraEditors.CheckEdit chkMostrarCC;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.ComboBox cmb_nivel;
        private System.Windows.Forms.Label lbl_nivel;
        private DevExpress.XtraEditors.CheckEdit chkMostrar_Reg_Cero;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}