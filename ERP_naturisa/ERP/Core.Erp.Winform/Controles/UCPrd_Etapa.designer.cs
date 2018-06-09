namespace Core
{
    partial class UCPrd_EtapaProduccion
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
            this.components = new System.ComponentModel.Container();
            this.lblEtapa = new System.Windows.Forms.Label();
            this.lblporc = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_idEtapaAnt = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEtapa
            // 
            this.lblEtapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapa.Location = new System.Drawing.Point(0, 0);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(107, 56);
            this.lblEtapa.TabIndex = 1;
            this.lblEtapa.Text = "Etapa # :";
            this.lblEtapa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.lblEtapa, "Presione Doble clic para editar");
            this.lblEtapa.DoubleClick += new System.EventHandler(this.lblEtapa_DoubleClick);
            // 
            // lblporc
            // 
            this.lblporc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblporc.Location = new System.Drawing.Point(10, 36);
            this.lblporc.Name = "lblporc";
            this.lblporc.Size = new System.Drawing.Size(85, 15);
            this.lblporc.TabIndex = 2;
            this.lblporc.Text = "(0%)";
            this.lblporc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(107, 56);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.Location = new System.Drawing.Point(2, 4);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(102, 47);
            this.rectangleShape1.Tag = "";
            // 
            // lbl_idEtapaAnt
            // 
            this.lbl_idEtapaAnt.AutoSize = true;
            this.lbl_idEtapaAnt.Location = new System.Drawing.Point(10, 19);
            this.lbl_idEtapaAnt.Name = "lbl_idEtapaAnt";
            this.lbl_idEtapaAnt.Size = new System.Drawing.Size(59, 13);
            this.lbl_idEtapaAnt.TabIndex = 3;
            this.lbl_idEtapaAnt.Text = "idEtapaAnt";
            this.lbl_idEtapaAnt.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(67, 39);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            this.lblEstado.Visible = false;
            // 
            // UserControlEtapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lbl_idEtapaAnt);
            this.Controls.Add(this.lblporc);
            this.Controls.Add(this.lblEtapa);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "UserControlEtapa";
            this.Size = new System.Drawing.Size(107, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtapa;
        private System.Windows.Forms.Label lblporc;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_idEtapaAnt;
        private System.Windows.Forms.Label lblEstado;

    }
}
