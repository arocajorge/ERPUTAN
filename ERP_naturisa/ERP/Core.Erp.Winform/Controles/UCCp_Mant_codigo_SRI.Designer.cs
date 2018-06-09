namespace Core.Erp.Winform.Controles
{
    partial class UCCp_Mant_codigo_SRI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucCon_PlanCtaCmb1 = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.cmb_tipCodSRI = new System.Windows.Forms.ComboBox();
            this.dtp_valiHasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_valiDesde = new System.Windows.Forms.DateTimePicker();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cod_base = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cod_SRI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorP = new System.Windows.Forms.ErrorProvider();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ucCon_PlanCtaCmb1);
            this.panel1.Controls.Add(this.lblAnulado);
            this.panel1.Controls.Add(this.cmb_tipCodSRI);
            this.panel1.Controls.Add(this.dtp_valiHasta);
            this.panel1.Controls.Add(this.dtp_valiDesde);
            this.panel1.Controls.Add(this.chk_estado);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_descripcion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_cod_base);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_cod_SRI);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 568);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ucCon_PlanCtaCmb1
            // 
            this.ucCon_PlanCtaCmb1.Location = new System.Drawing.Point(97, 264);
            this.ucCon_PlanCtaCmb1.Name = "ucCon_PlanCtaCmb1";
            this.ucCon_PlanCtaCmb1.Size = new System.Drawing.Size(298, 26);
            this.ucCon_PlanCtaCmb1.TabIndex = 136;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(309, 82);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(115, 15);
            this.lblAnulado.TabIndex = 135;
            this.lblAnulado.Text = "*** ANULADO ***";
            this.lblAnulado.Visible = false;
            // 
            // cmb_tipCodSRI
            // 
            this.cmb_tipCodSRI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipCodSRI.FormattingEnabled = true;
            this.cmb_tipCodSRI.Location = new System.Drawing.Point(97, 52);
            this.cmb_tipCodSRI.Name = "cmb_tipCodSRI";
            this.cmb_tipCodSRI.Size = new System.Drawing.Size(206, 21);
            this.cmb_tipCodSRI.TabIndex = 1;
            // 
            // dtp_valiHasta
            // 
            this.dtp_valiHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_valiHasta.Location = new System.Drawing.Point(97, 242);
            this.dtp_valiHasta.Name = "dtp_valiHasta";
            this.dtp_valiHasta.Size = new System.Drawing.Size(206, 20);
            this.dtp_valiHasta.TabIndex = 7;
            this.dtp_valiHasta.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_valiHasta_Validating);
            // 
            // dtp_valiDesde
            // 
            this.dtp_valiDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_valiDesde.Location = new System.Drawing.Point(97, 216);
            this.dtp_valiDesde.Name = "dtp_valiDesde";
            this.dtp_valiDesde.Size = new System.Drawing.Size(206, 20);
            this.dtp_valiDesde.TabIndex = 6;
            this.dtp_valiDesde.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_valiDesde_Validating);
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(97, 303);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(15, 14);
            this.chk_estado.TabIndex = 9;
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valido hasta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Valido desde:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "% Retención:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(97, 138);
            this.txt_descripcion.MaxLength = 150;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(349, 44);
            this.txt_descripcion.TabIndex = 4;
            this.txt_descripcion.Validating += new System.ComponentModel.CancelEventHandler(this.txt_descripcion_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripción:";
            // 
            // txt_cod_base
            // 
            this.txt_cod_base.Location = new System.Drawing.Point(97, 109);
            this.txt_cod_base.MaxLength = 20;
            this.txt_cod_base.Name = "txt_cod_base";
            this.txt_cod_base.Size = new System.Drawing.Size(206, 20);
            this.txt_cod_base.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cod. Base:";
            // 
            // txt_cod_SRI
            // 
            this.txt_cod_SRI.Location = new System.Drawing.Point(97, 82);
            this.txt_cod_SRI.MaxLength = 20;
            this.txt_cod_SRI.Name = "txt_cod_SRI";
            this.txt_cod_SRI.Size = new System.Drawing.Size(206, 20);
            this.txt_cod_SRI.TabIndex = 2;
            this.txt_cod_SRI.Validating += new System.ComponentModel.CancelEventHandler(this.txt_cod_SRI_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cod. SRI:";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(97, 18);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(55, 20);
            this.txt_id.TabIndex = 2;
            this.txt_id.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Codigo SRI:";
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 137;
            this.label6.Text = "Cta. Cble.";
            // 
            // UCCp_Mant_codigo_SRI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCCp_Mant_codigo_SRI";
            this.Size = new System.Drawing.Size(486, 568);
            this.Load += new System.EventHandler(this.UCCp_Mant_codigo_SRI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cod_base;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cod_SRI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DateTimePicker dtp_valiHasta;
        private System.Windows.Forms.DateTimePicker dtp_valiDesde;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.ComboBox cmb_tipCodSRI;

        private System.Windows.Forms.Label lblAnulado;
        private UCCon_PlanCtaCmb ucCon_PlanCtaCmb1;
        private System.Windows.Forms.Label label6;


    }
}
