namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_TipoNota_Mant
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.txt_nemonico = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.chk_declara = new System.Windows.Forms.CheckBox();
            this.chk_interno = new System.Windows.Forms.CheckBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_id_tipo_nota = new System.Windows.Forms.Label();
            this.lbl_title_tipos_notas = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.txt_nemonico);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.chk_estado);
            this.groupBox1.Controls.Add(this.chk_declara);
            this.groupBox1.Controls.Add(this.chk_interno);
            this.groupBox1.Controls.Add(this.cmb_tipo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_id_tipo_nota);
            this.groupBox1.Controls.Add(this.lbl_title_tipos_notas);
            this.groupBox1.Location = new System.Drawing.Point(1, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblEstado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(233, 26);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(156, 33);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "**Anulado**";
            this.lblEstado.Visible = false;
            // 
            // txt_nemonico
            // 
            this.txt_nemonico.Location = new System.Drawing.Point(280, 72);
            this.txt_nemonico.MaxLength = 15;
            this.txt_nemonico.Name = "txt_nemonico";
            this.txt_nemonico.Size = new System.Drawing.Size(81, 20);
            this.txt_nemonico.TabIndex = 5;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(115, 101);
            this.txt_descripcion.MaxLength = 150;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(246, 20);
            this.txt_descripcion.TabIndex = 2;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(115, 71);
            this.txt_codigo.MaxLength = 15;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Checked = true;
            this.chk_estado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_estado.Enabled = false;
            this.chk_estado.Location = new System.Drawing.Point(63, 209);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(59, 17);
            this.chk_estado.TabIndex = 8;
            this.chk_estado.Text = "Estado";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // chk_declara
            // 
            this.chk_declara.AutoSize = true;
            this.chk_declara.Location = new System.Drawing.Point(195, 176);
            this.chk_declara.Name = "chk_declara";
            this.chk_declara.Size = new System.Drawing.Size(84, 17);
            this.chk_declara.TabIndex = 7;
            this.chk_declara.Text = "Declara SRI";
            this.chk_declara.UseVisualStyleBackColor = true;
            // 
            // chk_interno
            // 
            this.chk_interno.AutoSize = true;
            this.chk_interno.Location = new System.Drawing.Point(63, 176);
            this.chk_interno.Name = "chk_interno";
            this.chk_interno.Size = new System.Drawing.Size(99, 17);
            this.chk_interno.TabIndex = 6;
            this.chk_interno.Text = "Interno Sistema";
            this.chk_interno.UseVisualStyleBackColor = true;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(115, 131);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(100, 21);
            this.cmb_tipo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nemonico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo Tipo Nota:";
            // 
            // lbl_id_tipo_nota
            // 
            this.lbl_id_tipo_nota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_id_tipo_nota.Location = new System.Drawing.Point(115, 37);
            this.lbl_id_tipo_nota.Name = "lbl_id_tipo_nota";
            this.lbl_id_tipo_nota.Size = new System.Drawing.Size(100, 23);
            this.lbl_id_tipo_nota.TabIndex = 0;
            this.lbl_id_tipo_nota.Text = "0";
            this.lbl_id_tipo_nota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_title_tipos_notas
            // 
            this.lbl_title_tipos_notas.AutoSize = true;
            this.lbl_title_tipos_notas.Location = new System.Drawing.Point(16, 47);
            this.lbl_title_tipos_notas.Name = "lbl_title_tipos_notas";
            this.lbl_title_tipos_notas.Size = new System.Drawing.Size(69, 13);
            this.lbl_title_tipos_notas.TabIndex = 0;
            this.lbl_title_tipos_notas.Text = "Id Tipo Nota:";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(479, 29);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
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
            // frmFa_TipoNota_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(479, 267);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmFa_TipoNota_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Tipos Notas";
            this.Load += new System.EventHandler(this.frmFA_TipoNota_Mant_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_id_tipo_nota;
        private System.Windows.Forms.Label lbl_title_tipos_notas;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.CheckBox chk_declara;
        private System.Windows.Forms.CheckBox chk_interno;
        private System.Windows.Forms.TextBox txt_nemonico;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_codigo;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.LabelControl lblEstado;
    }
}