namespace Core.Erp.Winform.Academico
{
    partial class FrmAca_RubroGrupoFE_Mant
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtNomRubroGrupo = new DevExpress.XtraEditors.TextEdit();
            this.txtCodRubroGrupo = new DevExpress.XtraEditors.TextEdit();
            this.txtIdRubroGrupo = new DevExpress.XtraEditors.TextEdit();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.lbNomRubroGrupo = new System.Windows.Forms.Label();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.lbIdRubroGrupo = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomRubroGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodRubroGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdRubroGrupo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbEstado);
            this.panel1.Controls.Add(this.txtNomRubroGrupo);
            this.panel1.Controls.Add(this.txtCodRubroGrupo);
            this.panel1.Controls.Add(this.txtIdRubroGrupo);
            this.panel1.Controls.Add(this.chkEstado);
            this.panel1.Controls.Add(this.lbNomRubroGrupo);
            this.panel1.Controls.Add(this.lbcodigo);
            this.panel1.Controls.Add(this.lbIdRubroGrupo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 137);
            this.panel1.TabIndex = 2;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.ForeColor = System.Drawing.Color.Red;
            this.lbEstado.Location = new System.Drawing.Point(156, 100);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(174, 25);
            this.lbEstado.TabIndex = 7;
            this.lbEstado.Text = "***ANULADO***";
            this.lbEstado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbEstado.Visible = false;
            // 
            // txtNomRubroGrupo
            // 
            this.txtNomRubroGrupo.Location = new System.Drawing.Point(161, 66);
            this.txtNomRubroGrupo.Name = "txtNomRubroGrupo";
            this.txtNomRubroGrupo.Size = new System.Drawing.Size(253, 20);
            this.txtNomRubroGrupo.TabIndex = 6;
            // 
            // txtCodRubroGrupo
            // 
            this.txtCodRubroGrupo.Location = new System.Drawing.Point(161, 40);
            this.txtCodRubroGrupo.Name = "txtCodRubroGrupo";
            this.txtCodRubroGrupo.Size = new System.Drawing.Size(126, 20);
            this.txtCodRubroGrupo.TabIndex = 5;
            // 
            // txtIdRubroGrupo
            // 
            this.txtIdRubroGrupo.Location = new System.Drawing.Point(161, 14);
            this.txtIdRubroGrupo.Name = "txtIdRubroGrupo";
            this.txtIdRubroGrupo.Size = new System.Drawing.Size(126, 20);
            this.txtIdRubroGrupo.TabIndex = 4;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(358, 17);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 3;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lbNomRubroGrupo
            // 
            this.lbNomRubroGrupo.AutoSize = true;
            this.lbNomRubroGrupo.Location = new System.Drawing.Point(15, 69);
            this.lbNomRubroGrupo.Name = "lbNomRubroGrupo";
            this.lbNomRubroGrupo.Size = new System.Drawing.Size(140, 13);
            this.lbNomRubroGrupo.TabIndex = 2;
            this.lbNomRubroGrupo.Text = "Nombre del Rubro de Grupo";
            this.lbNomRubroGrupo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Location = new System.Drawing.Point(19, 43);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(136, 13);
            this.lbcodigo.TabIndex = 1;
            this.lbcodigo.Text = "Codigo del Rubro de Grupo";
            this.lbcodigo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbIdRubroGrupo
            // 
            this.lbIdRubroGrupo.AutoSize = true;
            this.lbIdRubroGrupo.Location = new System.Drawing.Point(75, 17);
            this.lbIdRubroGrupo.Name = "lbIdRubroGrupo";
            this.lbIdRubroGrupo.Size = new System.Drawing.Size(80, 13);
            this.lbIdRubroGrupo.TabIndex = 0;
            this.lbIdRubroGrupo.Text = "Id Rubro Grupo";
            this.lbIdRubroGrupo.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(515, 29);
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
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
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
            this.ucGe_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_event_btnlimpiar_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 166);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(515, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
            // 
            // FrmAca_RubroGrupoFE_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 192);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmAca_RubroGrupoFE_Mant";
            this.Text = "FrmAca_RubroGrupoFE_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAca_RubroGrupoFE_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAca_RubroGrupoFE_Mant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomRubroGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodRubroGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdRubroGrupo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label lbNomRubroGrupo;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.Label lbIdRubroGrupo;
        private System.Windows.Forms.Label lbEstado;
        private DevExpress.XtraEditors.TextEdit txtNomRubroGrupo;
        private DevExpress.XtraEditors.TextEdit txtCodRubroGrupo;
        private DevExpress.XtraEditors.TextEdit txtIdRubroGrupo;
    }
}