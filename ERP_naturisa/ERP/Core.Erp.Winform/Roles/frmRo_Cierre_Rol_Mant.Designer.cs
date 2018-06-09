namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Cierre_Rol_Mant
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
            this.roNominaTipoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.roNominaTipoliquiInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.roperiodoxroNominaTipoLiquiInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer();
            this.roperiodoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.rodivisionInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.cmbPeriodo = new Core.Erp.Winform.Controles.UCRo_PeriodoXNomina();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmdCierreRol = new DevExpress.XtraEditors.SimpleButton();
            this.cmdReversoRol = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.roNominaTipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roNominaTipoliquiInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roperiodoxroNominaTipoLiquiInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roperiodoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodivisionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roNominaTipoInfoBindingSource
            // 
            this.roNominaTipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Nomina_Tipo_Info);
            // 
            // roNominaTipoliquiInfoBindingSource
            // 
            this.roNominaTipoliquiInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Nomina_Tipoliqui_Info);
            // 
            // roperiodoxroNominaTipoLiquiInfoBindingSource
            // 
            this.roperiodoxroNominaTipoLiquiInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_periodo_x_ro_Nomina_TipoLiqui_Info);
            // 
            // roperiodoInfoBindingSource
            // 
            this.roperiodoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_periodo_Info);
            // 
            // rodivisionInfoBindingSource
            // 
            this.rodivisionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_division_Info);
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.Location = new System.Drawing.Point(30, 21);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(365, 70);
            this.cmbPeriodo.TabIndex = 15;
            this.cmbPeriodo.event_cmbPeriodo_EditValueChanged += new Core.Erp.Winform.Controles.UCRo_PeriodoXNomina.delegate_cmbPeriodo_EditValueChanged(this.cmbPeriodo_event_cmbPeriodo_EditValueChanged);
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
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(551, 29);
            this.ucGe_Menu.TabIndex = 14;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmdReversoRol);
            this.panelControl1.Controls.Add(this.cmdCierreRol);
            this.panelControl1.Controls.Add(this.cmbPeriodo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(551, 109);
            this.panelControl1.TabIndex = 16;
            // 
            // cmdCierreRol
            // 
            this.cmdCierreRol.Location = new System.Drawing.Point(407, 27);
            this.cmdCierreRol.Name = "cmdCierreRol";
            this.cmdCierreRol.Size = new System.Drawing.Size(109, 23);
            this.cmdCierreRol.TabIndex = 16;
            this.cmdCierreRol.Text = "Cierre Rol";
            this.cmdCierreRol.Click += new System.EventHandler(this.cmdCierreRol_Click_1);
            // 
            // cmdReversoRol
            // 
            this.cmdReversoRol.Location = new System.Drawing.Point(407, 56);
            this.cmdReversoRol.Name = "cmdReversoRol";
            this.cmdReversoRol.Size = new System.Drawing.Size(109, 23);
            this.cmdReversoRol.TabIndex = 17;
            this.cmdReversoRol.Text = "Reverso Rol";
            this.cmdReversoRol.Click += new System.EventHandler(this.cmdReversoRol_Click_1);
            // 
            // frmRo_Cierre_Rol_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 138);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRo_Cierre_Rol_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso - Cierre de Rol";
            this.Load += new System.EventHandler(this.frmRo_Cierre_Rol_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roNominaTipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roNominaTipoliquiInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roperiodoxroNominaTipoLiquiInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roperiodoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodivisionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource roNominaTipoInfoBindingSource;
        private System.Windows.Forms.BindingSource roNominaTipoliquiInfoBindingSource;
        private System.Windows.Forms.BindingSource roperiodoInfoBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource roperiodoxroNominaTipoLiquiInfoBindingSource;
        private System.Windows.Forms.BindingSource rodivisionInfoBindingSource;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCRo_PeriodoXNomina cmbPeriodo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdReversoRol;
        private DevExpress.XtraEditors.SimpleButton cmdCierreRol;
    }
}