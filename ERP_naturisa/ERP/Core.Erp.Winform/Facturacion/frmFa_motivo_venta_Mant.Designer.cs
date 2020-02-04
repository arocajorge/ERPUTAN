namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_motivo_venta_Mant
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.txt_IdMotivo = new DevExpress.XtraEditors.TextEdit();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdMotivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Motivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(124, 69);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(130, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(124, 98);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(239, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // txt_IdMotivo
            // 
            this.txt_IdMotivo.EditValue = "0";
            this.txt_IdMotivo.Enabled = false;
            this.txt_IdMotivo.Location = new System.Drawing.Point(124, 40);
            this.txt_IdMotivo.Name = "txt_IdMotivo";
            this.txt_IdMotivo.Size = new System.Drawing.Size(130, 20);
            this.txt_IdMotivo.TabIndex = 8;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(307, 42);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 9;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.ForeColor = System.Drawing.Color.Red;
            this.lbl_Estado.Location = new System.Drawing.Point(135, 130);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(150, 20);
            this.lbl_Estado.TabIndex = 10;
            this.lbl_Estado.Text = "****ANULADO****";
            this.lbl_Estado.Visible = false;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 172);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(416, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // ucGe_Menu_Superior_Mant1
            // 
            this.ucGe_Menu_Superior_Mant1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant1.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(416, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_Superior_Mant1_event_btnGuardar_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_Superior_Mant1_event_btnAnular_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // frmFa_motivo_venta_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 198);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.txt_IdMotivo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "frmFa_motivo_venta_Mant";
            this.Text = "frmFa_motivo_venta_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFa_motivo_venta_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmFa_motivo_venta_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdMotivo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.TextEdit txt_IdMotivo;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label lbl_Estado;
    }
}