namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_NumDocumento
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
            this.ucfA_NumeroDocTrans = new Core.Erp.Winform.Controles.UCGe_NumeroDocTrans();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucfA_NumeroDocTrans
            // 
            //this.ucfA_NumeroDocTrans.Autorizacion = null;
            //this.ucfA_NumeroDocTrans.FechaCaducidad = new System.DateTime(((long)(0)));
            this.ucfA_NumeroDocTrans.Location = new System.Drawing.Point(23, 12);
            this.ucfA_NumeroDocTrans.Name = "ucfA_NumeroDocTrans";
            //this.ucfA_NumeroDocTrans.numDoc = null;
            //this.ucfA_NumeroDocTrans.Serie1 = null;
            //this.ucfA_NumeroDocTrans.Serie2 = null;
            this.ucfA_NumeroDocTrans.Size = new System.Drawing.Size(398, 42);
            this.ucfA_NumeroDocTrans.TabIndex = 0;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(120, 60);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(237, 60);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frmFa_NumDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 100);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.ucfA_NumeroDocTrans);
            this.Name = "frmFa_NumDocumento";
            this.Text = "Impresion Documento";
            this.Load += new System.EventHandler(this.frmFa_NumDocumento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_NumeroDocTrans ucfA_NumeroDocTrans;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btn_Salir;
    }
}