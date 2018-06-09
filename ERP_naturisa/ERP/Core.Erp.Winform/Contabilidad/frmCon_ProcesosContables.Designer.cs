namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_ProcesosContables
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
            this.lblfechaFin = new System.Windows.Forms.Label();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_anioF = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_periodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.TimerMayorizacion = new System.Windows.Forms.Timer();
            this.TimerReverso = new System.Windows.Forms.Timer();
            this.TimerCierre = new System.Windows.Forms.Timer();
            this.PbarEstado = new DevExpress.XtraEditors.ProgressBarControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btn_salir = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ReversoMayo = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cierre = new DevExpress.XtraEditors.SimpleButton();
            this.btn_mayorizar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PbarEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblfechaFin
            // 
            this.lblfechaFin.BackColor = System.Drawing.Color.White;
            this.lblfechaFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfechaFin.ForeColor = System.Drawing.Color.Black;
            this.lblfechaFin.Location = new System.Drawing.Point(140, 139);
            this.lblfechaFin.Name = "lblfechaFin";
            this.lblfechaFin.Size = new System.Drawing.Size(164, 23);
            this.lblfechaFin.TabIndex = 10;
            this.lblfechaFin.Text = "01/01/2012";
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.BackColor = System.Drawing.Color.White;
            this.lblFechaIni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechaIni.ForeColor = System.Drawing.Color.Black;
            this.lblFechaIni.Location = new System.Drawing.Point(140, 115);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(164, 23);
            this.lblFechaIni.TabIndex = 9;
            this.lblFechaIni.Text = "01/01/2012";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha Inicio:";
            // 
            // cmb_anioF
            // 
            this.cmb_anioF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_anioF.FormattingEnabled = true;
            this.cmb_anioF.Location = new System.Drawing.Point(68, 46);
            this.cmb_anioF.Name = "cmb_anioF";
            this.cmb_anioF.Size = new System.Drawing.Size(236, 21);
            this.cmb_anioF.TabIndex = 4;
            this.cmb_anioF.SelectedIndexChanged += new System.EventHandler(this.cmb_anioF_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Año Fiscal:";
            // 
            // cmb_periodo
            // 
            this.cmb_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_periodo.FormattingEnabled = true;
            this.cmb_periodo.Location = new System.Drawing.Point(68, 81);
            this.cmb_periodo.Name = "cmb_periodo";
            this.cmb_periodo.Size = new System.Drawing.Size(236, 21);
            this.cmb_periodo.TabIndex = 1;
            this.cmb_periodo.SelectedIndexChanged += new System.EventHandler(this.cmb_periodo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodo:";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // TimerMayorizacion
            // 
            this.TimerMayorizacion.Tick += new System.EventHandler(this.TimerMayorizacion_Tick);
            // 
            // TimerReverso
            // 
            this.TimerReverso.Tick += new System.EventHandler(this.TimerReverso_Tick);
            // 
            // TimerCierre
            // 
            this.TimerCierre.Tick += new System.EventHandler(this.TimerCierre_Tick);
            // 
            // PbarEstado
            // 
            this.PbarEstado.Location = new System.Drawing.Point(7, 212);
            this.PbarEstado.Name = "PbarEstado";
            this.PbarEstado.Size = new System.Drawing.Size(304, 23);
            this.PbarEstado.TabIndex = 11;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(0, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 257);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(5, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.PbarEstado);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmb_anioF);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblfechaFin);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblFechaIni);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmb_periodo);
            this.splitContainerControl1.Panel1.Controls.Add(this.label4);
            this.splitContainerControl1.Panel1.Controls.Add(this.label2);
            this.splitContainerControl1.Panel1.Controls.Add(this.label3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.btn_salir);
            this.splitContainerControl1.Panel2.Controls.Add(this.btn_cancelar);
            this.splitContainerControl1.Panel2.Controls.Add(this.btn_ReversoMayo);
            this.splitContainerControl1.Panel2.Controls.Add(this.btn_cierre);
            this.splitContainerControl1.Panel2.Controls.Add(this.btn_mayorizar);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(519, 257);
            this.splitContainerControl1.SplitterPosition = 321;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(23, 212);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(130, 23);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(23, 183);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(130, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // btn_ReversoMayo
            // 
            this.btn_ReversoMayo.Location = new System.Drawing.Point(23, 87);
            this.btn_ReversoMayo.Name = "btn_ReversoMayo";
            this.btn_ReversoMayo.Size = new System.Drawing.Size(130, 29);
            this.btn_ReversoMayo.TabIndex = 2;
            this.btn_ReversoMayo.Text = "Reverso de Periodo";
            this.btn_ReversoMayo.Click += new System.EventHandler(this.btn_ReversoMayo_Click_1);
            // 
            // btn_cierre
            // 
            this.btn_cierre.Location = new System.Drawing.Point(23, 54);
            this.btn_cierre.Name = "btn_cierre";
            this.btn_cierre.Size = new System.Drawing.Size(130, 23);
            this.btn_cierre.TabIndex = 1;
            this.btn_cierre.Text = "Cierre de Periodo";
            this.btn_cierre.Click += new System.EventHandler(this.btn_cierre_Click_1);
            // 
            // btn_mayorizar
            // 
            this.btn_mayorizar.Location = new System.Drawing.Point(23, 16);
            this.btn_mayorizar.Name = "btn_mayorizar";
            this.btn_mayorizar.Size = new System.Drawing.Size(130, 32);
            this.btn_mayorizar.TabIndex = 0;
            this.btn_mayorizar.Text = "Mayorizacion Periodo";
            this.btn_mayorizar.Visible = false;
            this.btn_mayorizar.Click += new System.EventHandler(this.btn_mayorizar_Click_1);
            // 
            // frmCon_ProcesosContables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 257);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.splitterControl1);
            this.MaximizeBox = false;
            this.Name = "frmCon_ProcesosContables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayorizacion , Cierre Periodo , Reverso Mayorizacion";
            this.Load += new System.EventHandler(this.frmCon_ProcesosContables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbarEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_periodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_anioF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblfechaFin;
        private System.Windows.Forms.Label lblFechaIni;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Timer TimerMayorizacion;
        private System.Windows.Forms.Timer TimerReverso;
        private System.Windows.Forms.Timer TimerCierre;
        private DevExpress.XtraEditors.ProgressBarControl PbarEstado;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btn_salir;
        private DevExpress.XtraEditors.SimpleButton btn_cancelar;
        private DevExpress.XtraEditors.SimpleButton btn_ReversoMayo;
        private DevExpress.XtraEditors.SimpleButton btn_cierre;
        private DevExpress.XtraEditors.SimpleButton btn_mayorizar;
    }
}