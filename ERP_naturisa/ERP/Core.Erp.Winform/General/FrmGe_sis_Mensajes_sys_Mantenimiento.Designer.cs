namespace Core.Erp.Winform.General
{
    partial class FrmGe_sis_Mensajes_sys_Mantenimiento
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
            this.components = new System.ComponentModel.Container();
            this.txtMensajeI = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbsisMensajessysInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbsisMensajessysInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMensaje = new DevExpress.XtraEditors.MRUEdit();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.txtMensajeI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisMensajessysInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisMensajessysInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMensaje.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMensajeI
            // 
            this.txtMensajeI.Location = new System.Drawing.Point(138, 111);
            this.txtMensajeI.Name = "txtMensajeI";
            this.txtMensajeI.Size = new System.Drawing.Size(293, 20);
            this.txtMensajeI.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(138, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(293, 20);
            this.txtId.TabIndex = 1;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Checked = true;
            this.cbxEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxEstado.Location = new System.Drawing.Point(138, 143);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(56, 17);
            this.cbxEstado.TabIndex = 4;
            this.cbxEstado.Text = "Activo";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEstado.Location = new System.Drawing.Point(169, 27);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(120, 25);
            this.lblEstado.TabIndex = 35;
            this.lblEstado.Text = "**Anulado**";
            this.lblEstado.Visible = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(36, 118);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 13);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Message in English";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(37, 86);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 13);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Mensaje en Español";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Codigo";
            // 
            // tbsisMensajessysInfoBindingSource
            // 
            this.tbsisMensajessysInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_sis_Mensajes_sys_Info);
            // 
            // tbsisMensajessysInfoBindingSource1
            // 
            this.tbsisMensajessysInfoBindingSource1.DataSource = typeof(Core.Erp.Info.General.tb_sis_Mensajes_sys_Info);
            // 
            // cmbMensaje
            // 
            this.cmbMensaje.Location = new System.Drawing.Point(138, 79);
            this.cmbMensaje.Name = "cmbMensaje";
            this.cmbMensaje.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMensaje.Properties.DropDownRows = 6;
            this.cmbMensaje.Properties.ShowPopupShadow = false;
            this.cmbMensaje.Properties.Sorted = true;
            this.cmbMensaje.Size = new System.Drawing.Size(293, 20);
            this.cmbMensaje.TabIndex = 2;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(456, 29);
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
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_event_btnlimpiar_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // FrmGe_sis_Mensajes_sys_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 168);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.txtMensajeI);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbMensaje);
            this.Name = "FrmGe_sis_Mensajes_sys_Mantenimiento";
            this.Text = "Mantenimiento de Mensajes..";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.FrmGe_sis_Mensajes_sys_Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMensajeI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisMensajessysInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisMensajessysInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMensaje.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tbsisMensajessysInfoBindingSource;
        private DevExpress.XtraEditors.TextEdit txtMensajeI;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.CheckBox cbxEstado;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource tbsisMensajessysInfoBindingSource1;
        private DevExpress.XtraEditors.MRUEdit cmbMensaje;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
    }
}