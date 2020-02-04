namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Familia_Mantenimiento
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ID = new DevExpress.XtraEditors.TextEdit();
            this.txt_Descripcion = new DevExpress.XtraEditors.TextEdit();
            this.txt_Codigo = new DevExpress.XtraEditors.TextEdit();
            this.uc_menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.lbl_Estado = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Descripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Codigo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(48, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Código";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(48, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Familia";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(126, 62);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Properties.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(100, 22);
            this.txt_ID.TabIndex = 3;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(126, 118);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(352, 22);
            this.txt_Descripcion.TabIndex = 4;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(126, 90);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(352, 22);
            this.txt_Codigo.TabIndex = 5;
            // 
            // uc_menu
            // 
            this.uc_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_menu.Enabled_bnRetImprimir = true;
            this.uc_menu.Enabled_bntAnular = true;
            this.uc_menu.Enabled_bntAprobar = true;
            this.uc_menu.Enabled_bntGuardar_y_Salir = true;
            this.uc_menu.Enabled_bntImprimir = true;
            this.uc_menu.Enabled_bntImprimir_Guia = true;
            this.uc_menu.Enabled_bntLimpiar = true;
            this.uc_menu.Enabled_bntSalir = true;
            this.uc_menu.Enabled_btn_conciliacion_Auto = true;
            this.uc_menu.Enabled_btn_DiseñoReporte = true;
            this.uc_menu.Enabled_btn_Generar_XML = true;
            this.uc_menu.Enabled_btn_Imprimir_Cbte = true;
            this.uc_menu.Enabled_btn_Imprimir_Cheq = true;
            this.uc_menu.Enabled_btn_Imprimir_Reten = true;
            this.uc_menu.Enabled_btnAceptar = true;
            this.uc_menu.Enabled_btnAprobarGuardarSalir = true;
            this.uc_menu.Enabled_btnEstadosOC = true;
            this.uc_menu.Enabled_btnGuardar = true;
            this.uc_menu.Enabled_btnImpFrm = true;
            this.uc_menu.Enabled_btnImpLote = true;
            this.uc_menu.Enabled_btnImpRep = true;
            this.uc_menu.Enabled_btnImprimirSoporte = true;
            this.uc_menu.Enabled_btnproductos = true;
            this.uc_menu.Location = new System.Drawing.Point(0, 0);
            this.uc_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uc_menu.Name = "uc_menu";
            this.uc_menu.Size = new System.Drawing.Size(621, 27);
            this.uc_menu.TabIndex = 6;
            this.uc_menu.Visible_bntAnular = true;
            this.uc_menu.Visible_bntAprobar = false;
            this.uc_menu.Visible_bntDiseñoReporte = false;
            this.uc_menu.Visible_bntGuardar_y_Salir = true;
            this.uc_menu.Visible_bntImprimir = false;
            this.uc_menu.Visible_bntImprimir_Guia = false;
            this.uc_menu.Visible_bntLimpiar = true;
            this.uc_menu.Visible_bntReImprimir = false;
            this.uc_menu.Visible_bntSalir = true;
            this.uc_menu.Visible_btn_Actualizar = false;
            this.uc_menu.Visible_btn_conciliacion_Auto = false;
            this.uc_menu.Visible_btn_Generar_XML = false;
            this.uc_menu.Visible_btn_Imprimir_Cbte = false;
            this.uc_menu.Visible_btn_Imprimir_Cheq = false;
            this.uc_menu.Visible_btn_Imprimir_Reten = false;
            this.uc_menu.Visible_btnAceptar = false;
            this.uc_menu.Visible_btnAprobarGuardarSalir = false;
            this.uc_menu.Visible_btnContabilizar = false;
            this.uc_menu.Visible_btnEstadosOC = false;
            this.uc_menu.Visible_btnGuardar = true;
            this.uc_menu.Visible_btnImpFrm = false;
            this.uc_menu.Visible_btnImpLote = false;
            this.uc_menu.Visible_btnImpRep = false;
            this.uc_menu.Visible_btnImprimirSoporte = false;
            this.uc_menu.Visible_btnModificar = false;
            this.uc_menu.Visible_btnproductos = false;
            this.uc_menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.uc_menu_event_btnGuardar_Click);
            this.uc_menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.uc_menu_event_btnGuardar_y_Salir_Click);
            this.uc_menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.uc_menu_event_btnlimpiar_Click);
            this.uc_menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.uc_menu_event_btnAnular_Click);
            this.uc_menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.uc_menu_event_btnSalir_Click);
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_Estado.Location = new System.Drawing.Point(297, 53);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(115, 28);
            this.lbl_Estado.TabIndex = 7;
            this.lbl_Estado.Text = "ANULADO";
            // 
            // FrmIn_Familia_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 197);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.uc_menu);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmIn_Familia_Mantenimiento";
            this.Text = "Familia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Familia_Mantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_Familia_Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Descripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Codigo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_ID;
        private DevExpress.XtraEditors.TextEdit txt_Descripcion;
        private DevExpress.XtraEditors.TextEdit txt_Codigo;
        private Controles.UCGe_Menu_Superior_Mant uc_menu;
        private DevExpress.XtraEditors.LabelControl lbl_Estado;
    }
}