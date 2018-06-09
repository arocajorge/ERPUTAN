namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_CentroCosto_SubCentroCosto_Mant
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
            this.ctCentrocostoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.groupbox_datos = new System.Windows.Forms.GroupBox();
            this.cmbCentroCosto = new Core.Erp.Winform.Controles.UCCon_CentroCosto_ctas_Movi();
            this.cmb_ctacble = new Core.Erp.Winform.Controles.UCCon_Plan_de_Cuenta_x_Movimiento();
            this.ckbActivo = new System.Windows.Forms.CheckBox();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.txtCentroCosto = new DevExpress.XtraEditors.TextEdit();
            this.txtIdSubCentro = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.ctCentrocostoInfoBindingSource)).BeginInit();
            this.groupbox_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCentroCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdSubCentro.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctCentrocostoInfoBindingSource
            // 
            this.ctCentrocostoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Centro_costo_Info);
            // 
            // groupbox_datos
            // 
            this.groupbox_datos.Controls.Add(this.cmbCentroCosto);
            this.groupbox_datos.Controls.Add(this.cmb_ctacble);
            this.groupbox_datos.Controls.Add(this.ckbActivo);
            this.groupbox_datos.Controls.Add(this.lblAnulado);
            this.groupbox_datos.Controls.Add(this.txtCentroCosto);
            this.groupbox_datos.Controls.Add(this.txtIdSubCentro);
            this.groupbox_datos.Controls.Add(this.label4);
            this.groupbox_datos.Controls.Add(this.label3);
            this.groupbox_datos.Controls.Add(this.label2);
            this.groupbox_datos.Controls.Add(this.label1);
            this.groupbox_datos.Location = new System.Drawing.Point(2, 28);
            this.groupbox_datos.Name = "groupbox_datos";
            this.groupbox_datos.Size = new System.Drawing.Size(533, 180);
            this.groupbox_datos.TabIndex = 16;
            this.groupbox_datos.TabStop = false;
            this.groupbox_datos.Text = "Datos Sub Centro Costo";
            // 
            // cmbCentroCosto
            // 
            this.cmbCentroCosto.IdCentroCostoPadre = null;
            this.cmbCentroCosto.InfoCentroCosto = null;
            this.cmbCentroCosto.Location = new System.Drawing.Point(123, 12);
            this.cmbCentroCosto.Name = "cmbCentroCosto";
            this.cmbCentroCosto.Size = new System.Drawing.Size(402, 30);
            this.cmbCentroCosto.TabIndex = 26;
            // 
            // cmb_ctacble
            // 
            this.cmb_ctacble.Location = new System.Drawing.Point(123, 100);
            this.cmb_ctacble.Name = "cmb_ctacble";
            this.cmb_ctacble.Size = new System.Drawing.Size(405, 29);
            this.cmb_ctacble.TabIndex = 25;
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Checked = true;
            this.ckbActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbActivo.Location = new System.Drawing.Point(13, 150);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Size = new System.Drawing.Size(56, 17);
            this.ckbActivo.TabIndex = 24;
            this.ckbActivo.Text = "Activo";
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(237, 153);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(136, 24);
            this.lblAnulado.TabIndex = 23;
            this.lblAnulado.Text = "***Anulado***";
            this.lblAnulado.Visible = false;
            // 
            // txtCentroCosto
            // 
            this.txtCentroCosto.Location = new System.Drawing.Point(123, 74);
            this.txtCentroCosto.Name = "txtCentroCosto";
            this.txtCentroCosto.Size = new System.Drawing.Size(323, 20);
            this.txtCentroCosto.TabIndex = 21;
            // 
            // txtIdSubCentro
            // 
            this.txtIdSubCentro.Enabled = false;
            this.txtIdSubCentro.Location = new System.Drawing.Point(123, 48);
            this.txtIdSubCentro.Name = "txtIdSubCentro";
            this.txtIdSubCentro.Size = new System.Drawing.Size(176, 20);
            this.txtIdSubCentro.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cuenta Contable:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre SubCentro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "IdSubCentroCosto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Centro Costo:";
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
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(539, 29);
            this.ucGe_Menu.TabIndex = 15;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
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
            // frmCon_CentroCosto_SubCentroCosto_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 213);
            this.Controls.Add(this.groupbox_datos);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCon_CentroCosto_SubCentroCosto_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub centro de costo";
            this.Load += new System.EventHandler(this.frmCon_CentroCosto_SubCentroCosto_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctCentrocostoInfoBindingSource)).EndInit();
            this.groupbox_datos.ResumeLayout(false);
            this.groupbox_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCentroCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdSubCentro.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ctCentrocostoInfoBindingSource;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.GroupBox groupbox_datos;
        private System.Windows.Forms.CheckBox ckbActivo;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.TextEdit txtCentroCosto;
        private DevExpress.XtraEditors.TextEdit txtIdSubCentro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controles.UCCon_Plan_de_Cuenta_x_Movimiento cmb_ctacble;
        private Controles.UCCon_CentroCosto_ctas_Movi cmbCentroCosto;
    }
}