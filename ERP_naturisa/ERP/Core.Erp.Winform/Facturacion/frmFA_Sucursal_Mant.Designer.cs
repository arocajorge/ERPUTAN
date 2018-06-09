namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Sucursal_Mant
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
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEstablecimiento = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtJefeSucursal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodSucursal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_vendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_id_sucursal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_title_id_sucursal = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chk_estado = new DevExpress.XtraEditors.CheckEdit();
            this.chk_es_Establecimiento = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstablecimiento.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_estado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_es_Establecimiento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(129, 175);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.Mask.EditMask = "(\\d?\\d?\\d?)\\d\\d\\d\\d-\\d\\d\\d";
            this.txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefono.Size = new System.Drawing.Size(263, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(129, 250);
            this.txtUbicacion.MaxLength = 20;
            this.txtUbicacion.Multiline = true;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUbicacion.Size = new System.Drawing.Size(263, 43);
            this.txtUbicacion.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(129, 201);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccion.Size = new System.Drawing.Size(263, 43);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtEstablecimiento
            // 
            this.txtEstablecimiento.Location = new System.Drawing.Point(129, 123);
            this.txtEstablecimiento.Name = "txtEstablecimiento";
            this.txtEstablecimiento.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEstablecimiento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtEstablecimiento.Properties.Mask.BeepOnError = true;
            this.txtEstablecimiento.Properties.Mask.SaveLiteral = false;
            this.txtEstablecimiento.Properties.MaxLength = 3;
            this.txtEstablecimiento.Size = new System.Drawing.Size(98, 20);
            this.txtEstablecimiento.TabIndex = 4;
            this.txtEstablecimiento.Validating += new System.ComponentModel.CancelEventHandler(this.txtEstablecimiento_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Establecimiento:";
            // 
            // txtJefeSucursal
            // 
            this.txtJefeSucursal.Location = new System.Drawing.Point(129, 149);
            this.txtJefeSucursal.MaxLength = 100;
            this.txtJefeSucursal.Name = "txtJefeSucursal";
            this.txtJefeSucursal.Size = new System.Drawing.Size(263, 20);
            this.txtJefeSucursal.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ubicación:";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(129, 95);
            this.txtRuc.MaxLength = 15;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(263, 20);
            this.txtRuc.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Dirección:";
            // 
            // txtCodSucursal
            // 
            this.txtCodSucursal.Location = new System.Drawing.Point(129, 47);
            this.txtCodSucursal.MaxLength = 5;
            this.txtCodSucursal.Name = "txtCodSucursal";
            this.txtCodSucursal.Size = new System.Drawing.Size(170, 20);
            this.txtCodSucursal.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Jefe Sucursal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Teléfono:";
            // 
            // txt_vendedor
            // 
            this.txt_vendedor.Location = new System.Drawing.Point(129, 69);
            this.txt_vendedor.MaxLength = 60;
            this.txt_vendedor.Name = "txt_vendedor";
            this.txt_vendedor.Size = new System.Drawing.Size(263, 20);
            this.txt_vendedor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "RUC:";
            // 
            // lbl_id_sucursal
            // 
            this.lbl_id_sucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_id_sucursal.Location = new System.Drawing.Point(129, 21);
            this.lbl_id_sucursal.Name = "lbl_id_sucursal";
            this.lbl_id_sucursal.Size = new System.Drawing.Size(100, 23);
            this.lbl_id_sucursal.TabIndex = 0;
            this.lbl_id_sucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_id_sucursal.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sucursal:";
            // 
            // lbl_title_id_sucursal
            // 
            this.lbl_title_id_sucursal.AutoSize = true;
            this.lbl_title_id_sucursal.Location = new System.Drawing.Point(45, 26);
            this.lbl_title_id_sucursal.Name = "lbl_title_id_sucursal";
            this.lbl_title_id_sucursal.Size = new System.Drawing.Size(63, 13);
            this.lbl_title_id_sucursal.TabIndex = 0;
            this.lbl_title_id_sucursal.Text = "Id Sucursal:";
            this.lbl_title_id_sucursal.Visible = false;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(486, 35);
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
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 322);
            this.panel1.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chk_es_Establecimiento);
            this.groupControl1.Controls.Add(this.chk_estado);
            this.groupControl1.Controls.Add(this.lbl_id_sucursal);
            this.groupControl1.Controls.Add(this.txtTelefono);
            this.groupControl1.Controls.Add(this.txtCodSucursal);
            this.groupControl1.Controls.Add(this.txtUbicacion);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txtDireccion);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.lbl_title_id_sucursal);
            this.groupControl1.Controls.Add(this.txtRuc);
            this.groupControl1.Controls.Add(this.txtEstablecimiento);
            this.groupControl1.Controls.Add(this.txt_vendedor);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtJefeSucursal);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(486, 322);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Datos de la Sucursal";
            // 
            // chk_estado
            // 
            this.chk_estado.Location = new System.Drawing.Point(336, 25);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Properties.Caption = "Activo";
            this.chk_estado.Size = new System.Drawing.Size(75, 19);
            this.chk_estado.TabIndex = 11;
            // 
            // chk_es_Establecimiento
            // 
            this.chk_es_Establecimiento.Location = new System.Drawing.Point(336, 44);
            this.chk_es_Establecimiento.Name = "chk_es_Establecimiento";
            this.chk_es_Establecimiento.Properties.Caption = "Es establecimiento SRI";
            this.chk_es_Establecimiento.Size = new System.Drawing.Size(138, 19);
            this.chk_es_Establecimiento.TabIndex = 12;
            // 
            // frmFa_Sucursal_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmFa_Sucursal_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Sucursales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFA_Sucursal_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmFA_Sucursal_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstablecimiento.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_estado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_es_Establecimiento.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_vendedor;
        private System.Windows.Forms.Label lbl_id_sucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_title_id_sucursal;
        private System.Windows.Forms.TextBox txtCodSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJefeSucursal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtEstablecimiento;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chk_estado;
        private DevExpress.XtraEditors.CheckEdit chk_es_Establecimiento;

    }
}