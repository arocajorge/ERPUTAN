namespace Core.Erp.Winform.CuentasxPagar
{
	partial class frmCP_ImprimirRetencion
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
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fechaEmision = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UC_Docu = new Core.Erp.Winform.Controles.UCGe_NumeroDocTrans();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(12, 34);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(91, 23);
            this.btn_Imprimir.TabIndex = 0;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(131, 34);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(102, 23);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Emision:";
            // 
            // dtp_fechaEmision
            // 
            this.dtp_fechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaEmision.Location = new System.Drawing.Point(97, 8);
            this.dtp_fechaEmision.Name = "dtp_fechaEmision";
            this.dtp_fechaEmision.Size = new System.Drawing.Size(106, 20);
            this.dtp_fechaEmision.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UC_Docu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 65);
            this.panel1.TabIndex = 33;
            // 
            // UC_Docu
            // 
            this.UC_Docu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_Docu.IdEstablecimiento = null;
            this.UC_Docu.IdPuntoEmision = null;
            this.UC_Docu.IdTipoDocumento = Core.Erp.Info.General.Cl_Enumeradores.eTipoDocumento_Talonario.RETEN;
            
            this.UC_Docu.Location = new System.Drawing.Point(250, 0);
            this.UC_Docu.Name = "UC_Docu";
            this.UC_Docu.Size = new System.Drawing.Size(538, 65);
            this.UC_Docu.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Salir);
            this.panel2.Controls.Add(this.dtp_fechaEmision);
            this.panel2.Controls.Add(this.btn_Imprimir);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 65);
            this.panel2.TabIndex = 33;
            // 
            // frmCP_ImprimirRetencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 65);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCP_ImprimirRetencion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Impresion de Retencion:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCP_ImprimirRetencion_FormClosing);
            this.Load += new System.EventHandler(this.frmCP_ImprimirRetencion_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fechaEmision;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_NumeroDocTrans UC_Docu;
        private System.Windows.Forms.Panel panel2;
	}
}