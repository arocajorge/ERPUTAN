namespace Core.Erp.Winform.ActivoFijo
{
    partial class frmAF_Tipo_Depreciacion
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
            this.lblIdTipoDepreciacion = new System.Windows.Forms.Label();
            this.lblcod_tipo_depreciacion = new System.Windows.Forms.Label();
            this.lblnom_tipo_depreciacion = new System.Windows.Forms.Label();
            this.txtIdTipoDepreciacion = new System.Windows.Forms.TextBox();
            this.txtcod_tipo_depreciacion = new System.Windows.Forms.TextBox();
            this.txtnom_tipo_depreciacion = new System.Windows.Forms.TextBox();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lblIdTipoDepreciacion
            // 
            this.lblIdTipoDepreciacion.AutoSize = true;
            this.lblIdTipoDepreciacion.Location = new System.Drawing.Point(46, 66);
            this.lblIdTipoDepreciacion.Name = "lblIdTipoDepreciacion";
            this.lblIdTipoDepreciacion.Size = new System.Drawing.Size(21, 13);
            this.lblIdTipoDepreciacion.TabIndex = 8;
            this.lblIdTipoDepreciacion.Text = "Id:";
            // 
            // lblcod_tipo_depreciacion
            // 
            this.lblcod_tipo_depreciacion.AutoSize = true;
            this.lblcod_tipo_depreciacion.Location = new System.Drawing.Point(46, 91);
            this.lblcod_tipo_depreciacion.Name = "lblcod_tipo_depreciacion";
            this.lblcod_tipo_depreciacion.Size = new System.Drawing.Size(44, 13);
            this.lblcod_tipo_depreciacion.TabIndex = 9;
            this.lblcod_tipo_depreciacion.Text = "Codigo:";
            // 
            // lblnom_tipo_depreciacion
            // 
            this.lblnom_tipo_depreciacion.AutoSize = true;
            this.lblnom_tipo_depreciacion.Location = new System.Drawing.Point(46, 124);
            this.lblnom_tipo_depreciacion.Name = "lblnom_tipo_depreciacion";
            this.lblnom_tipo_depreciacion.Size = new System.Drawing.Size(48, 13);
            this.lblnom_tipo_depreciacion.TabIndex = 10;
            this.lblnom_tipo_depreciacion.Text = "Nombre:";
            // 
            // txtIdTipoDepreciacion
            // 
            this.txtIdTipoDepreciacion.Location = new System.Drawing.Point(147, 58);
            this.txtIdTipoDepreciacion.Name = "txtIdTipoDepreciacion";
            this.txtIdTipoDepreciacion.Size = new System.Drawing.Size(100, 21);
            this.txtIdTipoDepreciacion.TabIndex = 1;
            // 
            // txtcod_tipo_depreciacion
            // 
            this.txtcod_tipo_depreciacion.Location = new System.Drawing.Point(147, 91);
            this.txtcod_tipo_depreciacion.Name = "txtcod_tipo_depreciacion";
            this.txtcod_tipo_depreciacion.Size = new System.Drawing.Size(100, 21);
            this.txtcod_tipo_depreciacion.TabIndex = 2;
            // 
            // txtnom_tipo_depreciacion
            // 
            this.txtnom_tipo_depreciacion.Location = new System.Drawing.Point(147, 124);
            this.txtnom_tipo_depreciacion.Name = "txtnom_tipo_depreciacion";
            this.txtnom_tipo_depreciacion.Size = new System.Drawing.Size(295, 21);
            this.txtnom_tipo_depreciacion.TabIndex = 3;
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Checked = true;
            this.chk_estado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_estado.Location = new System.Drawing.Point(49, 155);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(56, 17);
            this.chk_estado.TabIndex = 4;
            this.chk_estado.Text = "Activo";
            this.chk_estado.UseVisualStyleBackColor = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(475, 29);
            this.ucGe_Menu.TabIndex = 0;
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
            // lblEstado
            // 
            this.lblEstado.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(322, 64);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(120, 25);
            this.lblEstado.TabIndex = 37;
            this.lblEstado.Text = "**Anulado**";
            this.lblEstado.Visible = false;
            // 
            // frmAF_Tipo_Depreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 190);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.chk_estado);
            this.Controls.Add(this.txtnom_tipo_depreciacion);
            this.Controls.Add(this.txtcod_tipo_depreciacion);
            this.Controls.Add(this.txtIdTipoDepreciacion);
            this.Controls.Add(this.lblnom_tipo_depreciacion);
            this.Controls.Add(this.lblcod_tipo_depreciacion);
            this.Controls.Add(this.lblIdTipoDepreciacion);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmAF_Tipo_Depreciacion";
            this.Text = "frmAF_Tipo_Depreciacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAF_Tipo_Depreciacion_FormClosing);
            this.Load += new System.EventHandler(this.frmAF_Tipo_Depreciacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Label lblIdTipoDepreciacion;
        private System.Windows.Forms.Label lblcod_tipo_depreciacion;
        private System.Windows.Forms.Label lblnom_tipo_depreciacion;
        private System.Windows.Forms.TextBox txtIdTipoDepreciacion;
        private System.Windows.Forms.TextBox txtcod_tipo_depreciacion;
        private System.Windows.Forms.TextBox txtnom_tipo_depreciacion;
        private System.Windows.Forms.CheckBox chk_estado;
        private DevExpress.XtraEditors.LabelControl lblEstado;
    }
}