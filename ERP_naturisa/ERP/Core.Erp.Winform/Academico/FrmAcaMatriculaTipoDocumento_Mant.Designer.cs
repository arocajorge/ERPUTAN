namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaMatriculaTipoDocumento_Mant
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Form = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.chkEstado = new DevExpress.XtraEditors.CheckEdit();
            this.lblIdTipoDocumento = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigoTipoDocumento = new DevExpress.XtraEditors.LabelControl();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.txtIdTipoDocumento = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigoTipoDocumento = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdTipoDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoTipoDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(514, 29);
            this.ucGe_Menu.TabIndex = 2;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
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
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Form
            // 
            this.ucGe_BarraEstadoInferior_Form.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Form.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Form.Location = new System.Drawing.Point(0, 184);
            this.ucGe_BarraEstadoInferior_Form.Name = "ucGe_BarraEstadoInferior_Form";
            this.ucGe_BarraEstadoInferior_Form.Size = new System.Drawing.Size(514, 26);
            this.ucGe_BarraEstadoInferior_Form.TabIndex = 3;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(294, 136);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(136, 20);
            this.lblAnulado.TabIndex = 59;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // chkEstado
            // 
            this.chkEstado.EditValue = true;
            this.chkEstado.Location = new System.Drawing.Point(436, 134);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Properties.Caption = "Activo";
            this.chkEstado.Size = new System.Drawing.Size(64, 19);
            this.chkEstado.TabIndex = 58;
            // 
            // lblIdTipoDocumento
            // 
            this.lblIdTipoDocumento.Location = new System.Drawing.Point(13, 59);
            this.lblIdTipoDocumento.Name = "lblIdTipoDocumento";
            this.lblIdTipoDocumento.Size = new System.Drawing.Size(94, 13);
            this.lblIdTipoDocumento.TabIndex = 60;
            this.lblIdTipoDocumento.Text = "Id Tipo Documento:";
            // 
            // lblCodigoTipoDocumento
            // 
            this.lblCodigoTipoDocumento.Location = new System.Drawing.Point(13, 85);
            this.lblCodigoTipoDocumento.Name = "lblCodigoTipoDocumento";
            this.lblCodigoTipoDocumento.Size = new System.Drawing.Size(117, 13);
            this.lblCodigoTipoDocumento.TabIndex = 61;
            this.lblCodigoTipoDocumento.Text = "Código Tipo Documento:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(13, 111);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(58, 13);
            this.lblDescripcion.TabIndex = 62;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtIdTipoDocumento
            // 
            this.txtIdTipoDocumento.EditValue = "0";
            this.txtIdTipoDocumento.Enabled = false;
            this.txtIdTipoDocumento.Location = new System.Drawing.Point(154, 56);
            this.txtIdTipoDocumento.Name = "txtIdTipoDocumento";
            this.txtIdTipoDocumento.Size = new System.Drawing.Size(156, 20);
            this.txtIdTipoDocumento.TabIndex = 63;
            // 
            // txtCodigoTipoDocumento
            // 
            this.txtCodigoTipoDocumento.Location = new System.Drawing.Point(154, 82);
            this.txtCodigoTipoDocumento.Name = "txtCodigoTipoDocumento";
            this.txtCodigoTipoDocumento.Size = new System.Drawing.Size(156, 20);
            this.txtCodigoTipoDocumento.TabIndex = 64;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(154, 108);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(346, 20);
            this.txtDescripcion.TabIndex = 65;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmAcaMatriculaTipoDocumento_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 210);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigoTipoDocumento);
            this.Controls.Add(this.txtIdTipoDocumento);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodigoTipoDocumento);
            this.Controls.Add(this.lblIdTipoDocumento);
            this.Controls.Add(this.lblAnulado);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Form);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAcaMatriculaTipoDocumento_Mant";
            this.Text = "FrmAcaMatricula_x_Documento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcaMatriculaTipoDocumento_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAcaMatriculaTipoDocumento_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdTipoDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoTipoDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Form;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.CheckEdit chkEstado;
        private DevExpress.XtraEditors.LabelControl lblIdTipoDocumento;
        private DevExpress.XtraEditors.LabelControl lblCodigoTipoDocumento;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private DevExpress.XtraEditors.TextEdit txtIdTipoDocumento;
        private DevExpress.XtraEditors.TextEdit txtCodigoTipoDocumento;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}