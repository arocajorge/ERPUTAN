namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Talonario_cheques_x_bancoMant
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
            this.lblCbt_TipoAnulacion = new System.Windows.Forms.Label();
            this.grbbanco = new System.Windows.Forms.GroupBox();
            this.lblctaban = new System.Windows.Forms.Label();
            this.cmbCuentaContable = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblNumDigito = new System.Windows.Forms.Label();
            this.txtdigitos = new DevExpress.XtraEditors.TextEdit();
            this.lblej = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidbanco = new DevExpress.XtraEditors.TextEdit();
            this.lblNumChq = new System.Windows.Forms.Label();
            this.txtNumChq = new DevExpress.XtraEditors.TextEdit();
            this.lblsecuencia = new System.Windows.Forms.Label();
            this.txtsecuencia = new DevExpress.XtraEditors.TextEdit();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.chkusado = new System.Windows.Forms.CheckBox();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1.SuspendLayout();
            this.grbbanco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCuentaContable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdigitos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtidbanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumChq.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsecuencia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 

            this.panel1.Controls.Add(this.lblCbt_TipoAnulacion);
            this.panel1.Controls.Add(this.grbbanco);
            this.panel1.Controls.Add(this.lblNumChq);
            this.panel1.Controls.Add(this.txtNumChq);
            this.panel1.Controls.Add(this.lblsecuencia);
            this.panel1.Controls.Add(this.txtsecuencia);
            this.panel1.Controls.Add(this.chkEstado);
            this.panel1.Controls.Add(this.chkusado);
            this.panel1.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 256);
            this.panel1.TabIndex = 1;
            // 
            // lblCbt_TipoAnulacion
            // 
            this.lblCbt_TipoAnulacion.AutoEllipsis = true;
            this.lblCbt_TipoAnulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCbt_TipoAnulacion.ForeColor = System.Drawing.Color.Red;
            this.lblCbt_TipoAnulacion.Location = new System.Drawing.Point(345, 0);
            this.lblCbt_TipoAnulacion.Name = "lblCbt_TipoAnulacion";
            this.lblCbt_TipoAnulacion.Size = new System.Drawing.Size(217, 33);
            this.lblCbt_TipoAnulacion.TabIndex = 0;
            this.lblCbt_TipoAnulacion.Text = "***ANULADO***";
            this.lblCbt_TipoAnulacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCbt_TipoAnulacion.Visible = false;
            // 
            // grbbanco
            // 
            this.grbbanco.Controls.Add(this.lblctaban);
            this.grbbanco.Controls.Add(this.cmbCuentaContable);
            this.grbbanco.Controls.Add(this.lblNumDigito);
            this.grbbanco.Controls.Add(this.txtdigitos);
            this.grbbanco.Controls.Add(this.lblej);
            this.grbbanco.Controls.Add(this.label1);
            this.grbbanco.Controls.Add(this.txtidbanco);
            this.grbbanco.Location = new System.Drawing.Point(50, 17);
            this.grbbanco.Name = "grbbanco";
            this.grbbanco.Size = new System.Drawing.Size(485, 117);
            this.grbbanco.TabIndex = 0;
            this.grbbanco.TabStop = false;
            this.grbbanco.Text = ".";
            // 
            // lblctaban
            // 
            this.lblctaban.AutoSize = true;
            this.lblctaban.Location = new System.Drawing.Point(41, 22);
            this.lblctaban.Name = "lblctaban";
            this.lblctaban.Size = new System.Drawing.Size(41, 13);
            this.lblctaban.TabIndex = 0;
            this.lblctaban.Text = "Banco:";
            // 
            // cmbCuentaContable
            // 
            this.cmbCuentaContable.Location = new System.Drawing.Point(155, 19);
            this.cmbCuentaContable.Name = "cmbCuentaContable";
            this.cmbCuentaContable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCuentaContable.Properties.DisplayMember = "ba_descripcion";
            this.cmbCuentaContable.Properties.ValueMember = "IdBanco";
            this.cmbCuentaContable.Properties.View = this.gridView9;
            this.cmbCuentaContable.Size = new System.Drawing.Size(287, 20);
            this.cmbCuentaContable.TabIndex = 0;
            this.cmbCuentaContable.EditValueChanged += new System.EventHandler(this.cmbCuentaContable_EditValueChanged_1);
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCtaCble,
            this.colba_descripcion});
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // lblNumDigito
            // 
            this.lblNumDigito.AutoSize = true;
            this.lblNumDigito.Location = new System.Drawing.Point(23, 55);
            this.lblNumDigito.Name = "lblNumDigito";
            this.lblNumDigito.Size = new System.Drawing.Size(115, 13);
            this.lblNumDigito.TabIndex = 2;
            this.lblNumDigito.Text = "N° Digitos por Cheque:";
            // 
            // txtdigitos
            // 
            this.txtdigitos.Enabled = false;
            this.txtdigitos.Location = new System.Drawing.Point(155, 52);
            this.txtdigitos.Name = "txtdigitos";
            this.txtdigitos.Size = new System.Drawing.Size(100, 20);
            this.txtdigitos.TabIndex = 1;
            // 
            // lblej
            // 
            this.lblej.AutoSize = true;
            this.lblej.Location = new System.Drawing.Point(53, 82);
            this.lblej.Name = "lblej";
            this.lblej.Size = new System.Drawing.Size(47, 13);
            this.lblej.TabIndex = 4;
            this.lblej.Text = "Ejemplo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // txtidbanco
            // 
            this.txtidbanco.Enabled = false;
            this.txtidbanco.Location = new System.Drawing.Point(448, 19);
            this.txtidbanco.Name = "txtidbanco";
            this.txtidbanco.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.txtidbanco.Properties.Appearance.Options.UseBackColor = true;
            this.txtidbanco.Size = new System.Drawing.Size(11, 20);
            this.txtidbanco.TabIndex = 6;
            this.txtidbanco.Visible = false;
            // 
            // lblNumChq
            // 
            this.lblNumChq.AutoSize = true;
            this.lblNumChq.Location = new System.Drawing.Point(60, 155);
            this.lblNumChq.Name = "lblNumChq";
            this.lblNumChq.Size = new System.Drawing.Size(57, 13);
            this.lblNumChq.TabIndex = 5;
            this.lblNumChq.Text = "# Cheque:";
            // 
            // txtNumChq1
            // 
            this.txtNumChq.Location = new System.Drawing.Point(123, 152);
            this.txtNumChq.Name = "txtNumChq";
            this.txtNumChq.Size = new System.Drawing.Size(100, 20);
            this.txtNumChq.TabIndex = 0;
            this.txtNumChq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumChq_KeyPress);
            // 
            // lblsecuencia
            // 
            this.lblsecuencia.AutoSize = true;
            this.lblsecuencia.Location = new System.Drawing.Point(322, 159);
            this.lblsecuencia.Name = "lblsecuencia";
            this.lblsecuencia.Size = new System.Drawing.Size(61, 13);
            this.lblsecuencia.TabIndex = 7;
            this.lblsecuencia.Text = "Secuencia:";
            // 
            // txtsecuencia
            // 
            this.txtsecuencia.Enabled = false;
            this.txtsecuencia.Location = new System.Drawing.Point(409, 152);
            this.txtsecuencia.Name = "txtsecuencia";
            this.txtsecuencia.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.txtsecuencia.Properties.Appearance.Options.UseBackColor = true;
            this.txtsecuencia.Size = new System.Drawing.Size(100, 20);
            this.txtsecuencia.TabIndex = 3;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(205, 188);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 2;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // chkusado
            // 
            this.chkusado.AutoSize = true;
            this.chkusado.Location = new System.Drawing.Point(63, 188);
            this.chkusado.Name = "chkusado";
            this.chkusado.Size = new System.Drawing.Size(57, 17);
            this.chkusado.TabIndex = 1;
            this.chkusado.Text = "Usado";
            this.chkusado.UseVisualStyleBackColor = true;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.Caption = "IdCtaCble";
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.VisibleIndex = 0;
            // 
            // colba_descripcion
            // 
            this.colba_descripcion.Caption = "ba_descripcion";
            this.colba_descripcion.FieldName = "ba_descripcion";
            this.colba_descripcion.Name = "colba_descripcion";
            this.colba_descripcion.Visible = true;
            this.colba_descripcion.VisibleIndex = 1;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 230);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(574, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 8;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(574, 29);
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
            // 
            // FrmBA_Talonario_cheques_x_bancoMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 285);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmBA_Talonario_cheques_x_bancoMant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBA_Talonario_cheques_x_bancoMant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBA_Talonario_cheques_x_bancoMant_FormClosing);
            this.Load += new System.EventHandler(this.FrmBA_Talonario_cheques_x_bancoMant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbbanco.ResumeLayout(false);
            this.grbbanco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCuentaContable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdigitos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtidbanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumChq.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsecuencia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtNumChq;
        private System.Windows.Forms.GroupBox grbbanco;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Label lblNumChq;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.CheckBox chkusado;
        private System.Windows.Forms.Label lblej;
        private System.Windows.Forms.Label lblNumDigito;
        private System.Windows.Forms.Label lblctaban;
        private DevExpress.XtraEditors.TextEdit txtdigitos;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCuentaContable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn colba_descripcion;
        private System.Windows.Forms.Label lblsecuencia;
        private DevExpress.XtraEditors.TextEdit txtsecuencia;
        private DevExpress.XtraEditors.TextEdit txtidbanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCbt_TipoAnulacion;
    }
}