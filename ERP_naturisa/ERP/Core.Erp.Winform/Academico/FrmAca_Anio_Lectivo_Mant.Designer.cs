namespace Core.Erp.Winform.Academico
{
    partial class FrmAca_Anio_Lectivo_Mant
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
            this.grbAnioLectivo = new DevExpress.XtraEditors.GroupControl();
            this.dtFechaFinalClase = new DevExpress.XtraEditors.DateEdit();
            this.dtFechaInicioClase = new DevExpress.XtraEditors.DateEdit();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.txtIdAnioLectivo = new DevExpress.XtraEditors.TextEdit();
            this.lblAnioFin = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaInicio = new DevExpress.XtraEditors.LabelControl();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.lblIdPeriodoLectivo = new DevExpress.XtraEditors.LabelControl();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu_Superior_Mant = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.grbAnioLectivo)).BeginInit();
            this.grbAnioLectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFinalClase.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFinalClase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicioClase.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicioClase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAnioLectivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAnioLectivo
            // 
            this.grbAnioLectivo.Controls.Add(this.dtFechaFinalClase);
            this.grbAnioLectivo.Controls.Add(this.dtFechaInicioClase);
            this.grbAnioLectivo.Controls.Add(this.lblAnulado);
            this.grbAnioLectivo.Controls.Add(this.chkActivo);
            this.grbAnioLectivo.Controls.Add(this.txtDescripcion);
            this.grbAnioLectivo.Controls.Add(this.txtIdAnioLectivo);
            this.grbAnioLectivo.Controls.Add(this.lblAnioFin);
            this.grbAnioLectivo.Controls.Add(this.lblFechaInicio);
            this.grbAnioLectivo.Controls.Add(this.lblDescripcion);
            this.grbAnioLectivo.Controls.Add(this.lblIdPeriodoLectivo);
            this.grbAnioLectivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbAnioLectivo.Location = new System.Drawing.Point(0, 36);
            this.grbAnioLectivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbAnioLectivo.Name = "grbAnioLectivo";
            this.grbAnioLectivo.Size = new System.Drawing.Size(679, 230);
            this.grbAnioLectivo.TabIndex = 2;
            this.grbAnioLectivo.Text = "Año Lectivo";
            // 
            // dtFechaFinalClase
            // 
            this.dtFechaFinalClase.EditValue = null;
            this.dtFechaFinalClase.Location = new System.Drawing.Point(207, 162);
            this.dtFechaFinalClase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaFinalClase.Name = "dtFechaFinalClase";
            this.dtFechaFinalClase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaFinalClase.Properties.Mask.BeepOnError = true;
            this.dtFechaFinalClase.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFechaFinalClase.Size = new System.Drawing.Size(261, 22);
            this.dtFechaFinalClase.TabIndex = 51;
            this.dtFechaFinalClase.Leave += new System.EventHandler(this.dtFechaFinalClase_Leave);
            // 
            // dtFechaInicioClase
            // 
            this.dtFechaInicioClase.EditValue = null;
            this.dtFechaInicioClase.Location = new System.Drawing.Point(207, 129);
            this.dtFechaInicioClase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaInicioClase.Name = "dtFechaInicioClase";
            this.dtFechaInicioClase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaInicioClase.Properties.Mask.BeepOnError = true;
            this.dtFechaInicioClase.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFechaInicioClase.Size = new System.Drawing.Size(261, 22);
            this.dtFechaInicioClase.TabIndex = 50;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(481, 185);
            this.lblAnulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(170, 25);
            this.lblAnulado.TabIndex = 49;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // chkActivo
            // 
            this.chkActivo.EditValue = true;
            this.chkActivo.Location = new System.Drawing.Point(561, 158);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Size = new System.Drawing.Size(111, 21);
            this.chkActivo.TabIndex = 48;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(207, 92);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(437, 22);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtIdAnioLectivo
            // 
            this.txtIdAnioLectivo.Location = new System.Drawing.Point(207, 60);
            this.txtIdAnioLectivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdAnioLectivo.Name = "txtIdAnioLectivo";
            this.txtIdAnioLectivo.Size = new System.Drawing.Size(148, 22);
            this.txtIdAnioLectivo.TabIndex = 4;
            // 
            // lblAnioFin
            // 
            this.lblAnioFin.Location = new System.Drawing.Point(52, 165);
            this.lblAnioFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblAnioFin.Name = "lblAnioFin";
            this.lblAnioFin.Size = new System.Drawing.Size(129, 16);
            this.lblAnioFin.TabIndex = 3;
            this.lblAnioFin.Text = "Fecha Final de Clases:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Location = new System.Drawing.Point(52, 133);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(132, 16);
            this.lblFechaInicio.TabIndex = 2;
            this.lblFechaInicio.Text = "Fecha Inicio de Clases:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(52, 96);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(70, 16);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblIdPeriodoLectivo
            // 
            this.lblIdPeriodoLectivo.Location = new System.Drawing.Point(52, 69);
            this.lblIdPeriodoLectivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblIdPeriodoLectivo.Name = "lblIdPeriodoLectivo";
            this.lblIdPeriodoLectivo.Size = new System.Drawing.Size(85, 16);
            this.lblIdPeriodoLectivo.TabIndex = 0;
            this.lblIdPeriodoLectivo.Text = "Id Año Lectivo:";
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 266);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(679, 36);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // ucGe_Menu_Superior_Mant
            // 
            this.ucGe_Menu_Superior_Mant.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant.Enabled_bnRetImprimir = false;
            this.ucGe_Menu_Superior_Mant.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant.Enabled_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant.Enabled_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_DiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant.Enabled_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant.Enabled_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant.Enabled_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant.Enabled_btnproductos = false;
            this.ucGe_Menu_Superior_Mant.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_Menu_Superior_Mant.Name = "ucGe_Menu_Superior_Mant";
            this.ucGe_Menu_Superior_Mant.Size = new System.Drawing.Size(679, 36);
            this.ucGe_Menu_Superior_Mant.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant.Visible_bntAnular = true;
            this.ucGe_Menu_Superior_Mant.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_Superior_Mant_event_btnGuardar_Click);
            this.ucGe_Menu_Superior_Mant.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu_Superior_Mant.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_Superior_Mant_event_btnAnular_Click);
            this.ucGe_Menu_Superior_Mant.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant_event_btnSalir_Click);
            // 
            // FrmAca_Anio_Lectivo_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 302);
            this.Controls.Add(this.grbAnioLectivo);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAca_Anio_Lectivo_Mant";
            this.Text = "Mantenimiento de Año Lectivo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAca_Anio_Lectivo_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAca_Anio_Lectivo_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grbAnioLectivo)).EndInit();
            this.grbAnioLectivo.ResumeLayout(false);
            this.grbAnioLectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFinalClase.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFinalClase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicioClase.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicioClase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAnioLectivo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraEditors.GroupControl grbAnioLectivo;
        private DevExpress.XtraEditors.DateEdit dtFechaFinalClase;
        private DevExpress.XtraEditors.DateEdit dtFechaInicioClase;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.TextEdit txtIdAnioLectivo;
        private DevExpress.XtraEditors.LabelControl lblAnioFin;
        private DevExpress.XtraEditors.LabelControl lblFechaInicio;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private DevExpress.XtraEditors.LabelControl lblIdPeriodoLectivo;

    }
}