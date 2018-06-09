namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_MovilMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrd_MovilMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkCtrlPteGrua = new System.Windows.Forms.LinkLabel();
            this.lnkConversion = new System.Windows.Forms.LinkLabel();
            this.lnkEnsamblado = new System.Windows.Forms.LinkLabel();
            this.lnkEgInv = new System.Windows.Forms.LinkLabel();
            this.lnkAjuInv = new System.Windows.Forms.LinkLabel();
            this.lnkDespacho = new System.Windows.Forms.LinkLabel();
            this.lnkCtrlPrd = new System.Windows.Forms.LinkLabel();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btn_salir,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(224, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(224, 17);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 17);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(53, 14);
            this.btn_salir.Text = "SALIR";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.lnkCtrlPteGrua);
            this.groupBox1.Controls.Add(this.lnkConversion);
            this.groupBox1.Controls.Add(this.lnkEnsamblado);
            this.groupBox1.Controls.Add(this.lnkEgInv);
            this.groupBox1.Controls.Add(this.lnkAjuInv);
            this.groupBox1.Controls.Add(this.lnkDespacho);
            this.groupBox1.Controls.Add(this.lnkCtrlPrd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 271);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // lnkCtrlPteGrua
            // 
            this.lnkCtrlPteGrua.AutoSize = true;
            this.lnkCtrlPteGrua.Image = global::Core.Erp.Winform.Properties.Resources.Barchar;
            this.lnkCtrlPteGrua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkCtrlPteGrua.Location = new System.Drawing.Point(43, 190);
            this.lnkCtrlPteGrua.Name = "lnkCtrlPteGrua";
            this.lnkCtrlPteGrua.Size = new System.Drawing.Size(140, 13);
            this.lnkCtrlPteGrua.TabIndex = 0;
            this.lnkCtrlPteGrua.TabStop = true;
            this.lnkCtrlPteGrua.Text = "CONTROL PUENTE GRÚA";
            this.lnkCtrlPteGrua.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCtrlPteGrua_LinkClicked);
            // 
            // lnkConversion
            // 
            this.lnkConversion.AutoSize = true;
            this.lnkConversion.Image = global::Core.Erp.Winform.Properties.Resources.Barchar;
            this.lnkConversion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkConversion.Location = new System.Drawing.Point(74, 94);
            this.lnkConversion.Name = "lnkConversion";
            this.lnkConversion.Size = new System.Drawing.Size(78, 13);
            this.lnkConversion.TabIndex = 0;
            this.lnkConversion.TabStop = true;
            this.lnkConversion.Text = "CONVERSIÓN";
            this.lnkConversion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConversion_LinkClicked);
            // 
            // lnkEnsamblado
            // 
            this.lnkEnsamblado.AutoSize = true;
            this.lnkEnsamblado.Image = global::Core.Erp.Winform.Properties.Resources.Barchar;
            this.lnkEnsamblado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkEnsamblado.Location = new System.Drawing.Point(73, 126);
            this.lnkEnsamblado.Name = "lnkEnsamblado";
            this.lnkEnsamblado.Size = new System.Drawing.Size(81, 13);
            this.lnkEnsamblado.TabIndex = 0;
            this.lnkEnsamblado.TabStop = true;
            this.lnkEnsamblado.Text = "ENSAMBLADO";
            this.lnkEnsamblado.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEnsamblado_LinkClicked);
            // 
            // lnkEgInv
            // 
            this.lnkEgInv.AutoSize = true;
            this.lnkEgInv.Image = global::Core.Erp.Winform.Properties.Resources.Barchar;
            this.lnkEgInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkEgInv.Location = new System.Drawing.Point(44, 62);
            this.lnkEgInv.Name = "lnkEgInv";
            this.lnkEgInv.Size = new System.Drawing.Size(139, 13);
            this.lnkEgInv.TabIndex = 0;
            this.lnkEgInv.TabStop = true;
            this.lnkEgInv.Text = "EGRESO DE INVENTARIO";
            this.lnkEgInv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEgInv_LinkClicked);
            // 
            // lnkAjuInv
            // 
            this.lnkAjuInv.AutoSize = true;
            this.lnkAjuInv.Image = global::Core.Erp.Winform.Properties.Resources.Barchar;
            this.lnkAjuInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkAjuInv.Location = new System.Drawing.Point(42, 30);
            this.lnkAjuInv.Name = "lnkAjuInv";
            this.lnkAjuInv.Size = new System.Drawing.Size(142, 13);
            this.lnkAjuInv.TabIndex = 0;
            this.lnkAjuInv.TabStop = true;
            this.lnkAjuInv.Text = "AJUSTES DE INVENTARIO";
            this.lnkAjuInv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAjuInv_LinkClicked);
            // 
            // lnkDespacho
            // 
            this.lnkDespacho.AutoSize = true;
            this.lnkDespacho.Image = global::Core.Erp.Winform.Properties.Resources.Barchar;
            this.lnkDespacho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkDespacho.Location = new System.Drawing.Point(80, 222);
            this.lnkDespacho.Name = "lnkDespacho";
            this.lnkDespacho.Size = new System.Drawing.Size(66, 13);
            this.lnkDespacho.TabIndex = 0;
            this.lnkDespacho.TabStop = true;
            this.lnkDespacho.Text = "DESPACHO";
            this.lnkDespacho.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDespacho_LinkClicked);
            // 
            // lnkCtrlPrd
            // 
            this.lnkCtrlPrd.AutoSize = true;
            this.lnkCtrlPrd.Image = global::Core.Erp.Winform.Properties.Resources.Barchar;
            this.lnkCtrlPrd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkCtrlPrd.Location = new System.Drawing.Point(46, 158);
            this.lnkCtrlPrd.Name = "lnkCtrlPrd";
            this.lnkCtrlPrd.Size = new System.Drawing.Size(134, 13);
            this.lnkCtrlPrd.TabIndex = 0;
            this.lnkCtrlPrd.TabStop = true;
            this.lnkCtrlPrd.Text = "CONTROL PRODUCCIÓN";
            this.lnkCtrlPrd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCtrlPrd_LinkClicked);
            // 
            // FrmPrd_MovilMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(1, 1);
            this.Name = "FrmPrd_MovilMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MENÚ";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkCtrlPteGrua;
        private System.Windows.Forms.LinkLabel lnkConversion;
        private System.Windows.Forms.LinkLabel lnkEnsamblado;
        private System.Windows.Forms.LinkLabel lnkEgInv;
        private System.Windows.Forms.LinkLabel lnkAjuInv;
        private System.Windows.Forms.LinkLabel lnkDespacho;
        private System.Windows.Forms.LinkLabel lnkCtrlPrd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;


    }
}