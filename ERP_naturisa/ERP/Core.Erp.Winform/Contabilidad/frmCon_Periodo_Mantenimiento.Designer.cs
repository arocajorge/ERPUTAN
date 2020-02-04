namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_Periodo_Mantenimiento
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucgE_Mes1 = new Core.Erp.Winform.Controles.UCGe_Mes();
            this.ucgE_Aniof1 = new Core.Erp.Winform.Controles.UCGe_Aniof();
            this.label1 = new System.Windows.Forms.Label();
            this.txtperiodo = new System.Windows.Forms.MaskedTextBox();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chk_activo = new DevExpress.XtraEditors.CheckEdit();
            this.chk_cerrado = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_activo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_cerrado.Properties)).BeginInit();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(444, 29);
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
            // ucgE_Mes1
            // 
            this.ucgE_Mes1.Location = new System.Drawing.Point(144, 78);
            this.ucgE_Mes1.Name = "ucgE_Mes1";
            this.ucgE_Mes1.Size = new System.Drawing.Size(123, 22);
            this.ucgE_Mes1.TabIndex = 2;
            this.ucgE_Mes1.Event_cmbmes_SelectedIndexChanged += new Core.Erp.Winform.Controles.UCGe_Mes.delegatecmbmes_SelectedIndexChanged(this.ucgE_Mes1_Event_cmbmes_SelectedIndexChanged);
            // 
            // ucgE_Aniof1
            // 
            this.ucgE_Aniof1.Location = new System.Drawing.Point(144, 50);
            this.ucgE_Aniof1.Name = "ucgE_Aniof1";
            this.ucgE_Aniof1.Size = new System.Drawing.Size(102, 22);
            this.ucgE_Aniof1.TabIndex = 1;
            this.ucgE_Aniof1.Event_cmbanio_SelectedIndexChanged += new Core.Erp.Winform.Controles.UCGe_Aniof.delegatecmbanio_SelectedIndexChanged(this.ucgE_Aniof1_Event_cmbanio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mes:";
            // 
            // txtperiodo
            // 
            this.txtperiodo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtperiodo.Location = new System.Drawing.Point(144, 24);
            this.txtperiodo.Mask = "########";
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.Size = new System.Drawing.Size(63, 20);
            this.txtperiodo.TabIndex = 0;
            this.txtperiodo.Validating += new System.ComponentModel.CancelEventHandler(this.txtperiodo_Validating);
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(142, 142);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(125, 20);
            this.dtFechaFin.TabIndex = 4;
            this.dtFechaFin.Validating += new System.ComponentModel.CancelEventHandler(this.dtFechaFin_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha Final:";
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(142, 106);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(125, 20);
            this.dtFechaIni.TabIndex = 3;
            this.dtFechaIni.Validating += new System.ComponentModel.CancelEventHandler(this.dtFechaIni_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fecha Inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Año Fiscal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Periodo:";
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(124, 3);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(136, 24);
            this.lblAnulado.TabIndex = 32;
            this.lblAnulado.Text = "***Anulado***";
            this.lblAnulado.Visible = false;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.lblAnulado);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(444, 283);
            this.panelControl1.TabIndex = 33;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chk_activo);
            this.groupControl1.Controls.Add(this.chk_cerrado);
            this.groupControl1.Controls.Add(this.ucgE_Mes1);
            this.groupControl1.Controls.Add(this.txtperiodo);
            this.groupControl1.Controls.Add(this.dtFechaFin);
            this.groupControl1.Controls.Add(this.ucgE_Aniof1);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.dtFechaIni);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(369, 240);
            this.groupControl1.TabIndex = 33;
            this.groupControl1.Text = "Periodos";
            // 
            // chk_activo
            // 
            this.chk_activo.Location = new System.Drawing.Point(144, 210);
            this.chk_activo.Name = "chk_activo";
            this.chk_activo.Properties.Caption = "Activo";
            this.chk_activo.Size = new System.Drawing.Size(75, 19);
            this.chk_activo.TabIndex = 27;
            // 
            // chk_cerrado
            // 
            this.chk_cerrado.Location = new System.Drawing.Point(144, 184);
            this.chk_cerrado.Name = "chk_cerrado";
            this.chk_cerrado.Properties.Caption = "Cerrado";
            this.chk_cerrado.Size = new System.Drawing.Size(75, 19);
            this.chk_cerrado.TabIndex = 26;
            // 
            // frmCon_Periodo_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 312);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCon_Periodo_Mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCon_Periodo_Mantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCon_Periodo_Mantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.frmCon_Periodo_Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_activo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_cerrado.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_Mes ucgE_Mes1;
        private Controles.UCGe_Aniof ucgE_Aniof1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtperiodo;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.ErrorProvider error;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chk_activo;
        private DevExpress.XtraEditors.CheckEdit chk_cerrado;
    }
}