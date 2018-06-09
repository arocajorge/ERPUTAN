namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Contabilizar_Rol
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
            this.roperiodoxroNominaTipoLiquiInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dteFechaContabilidad = new DevExpress.XtraEditors.DateEdit();
            this.cmdReversoContabilidad = new DevExpress.XtraEditors.SimpleButton();
            this.cmdContabilizar = new DevExpress.XtraEditors.SimpleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.roperiodoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ucRo_Periodo = new Core.Erp.Winform.Controles.UCRo_PeriodoXNomina();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.roperiodoxroNominaTipoLiquiInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaContabilidad.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaContabilidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roperiodoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // roperiodoxroNominaTipoLiquiInfoBindingSource
            // 
            this.roperiodoxroNominaTipoLiquiInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_periodo_x_ro_Nomina_TipoLiqui_Info);
            // 
            // dteFechaContabilidad
            // 
            this.dteFechaContabilidad.EditValue = null;
            this.dteFechaContabilidad.Location = new System.Drawing.Point(131, 113);
            this.dteFechaContabilidad.Name = "dteFechaContabilidad";
            this.dteFechaContabilidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFechaContabilidad.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteFechaContabilidad.Size = new System.Drawing.Size(113, 20);
            this.dteFechaContabilidad.TabIndex = 124;
            // 
            // cmdReversoContabilidad
            // 
            this.cmdReversoContabilidad.Location = new System.Drawing.Point(484, 81);
            this.cmdReversoContabilidad.Name = "cmdReversoContabilidad";
            this.cmdReversoContabilidad.Size = new System.Drawing.Size(148, 24);
            this.cmdReversoContabilidad.TabIndex = 3;
            this.cmdReversoContabilidad.Text = "Reverso Contabilizacion";
            // 
            // cmdContabilizar
            // 
            this.cmdContabilizar.Location = new System.Drawing.Point(484, 51);
            this.cmdContabilizar.Name = "cmdContabilizar";
            this.cmdContabilizar.Size = new System.Drawing.Size(148, 24);
            this.cmdContabilizar.TabIndex = 2;
            this.cmdContabilizar.Text = "Contabilizar";
            this.cmdContabilizar.Click += new System.EventHandler(this.cmdContabilizar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(718, 22);
            this.statusStrip1.TabIndex = 125;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // roperiodoInfoBindingSource
            // 
            this.roperiodoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_periodo_Info);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.ucRo_Periodo);
            this.groupControl1.Controls.Add(this.cmdReversoContabilidad);
            this.groupControl1.Controls.Add(this.cmdContabilizar);
            this.groupControl1.Controls.Add(this.dteFechaContabilidad);
            this.groupControl1.Location = new System.Drawing.Point(0, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(715, 143);
            this.groupControl1.TabIndex = 129;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 115);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.TabIndex = 126;
            this.labelControl1.Text = "Fecha Contabilidad:";
            // 
            // ucRo_Periodo
            // 
            this.ucRo_Periodo.Location = new System.Drawing.Point(80, 40);
            this.ucRo_Periodo.Name = "ucRo_Periodo";
            this.ucRo_Periodo.Size = new System.Drawing.Size(365, 70);
            this.ucRo_Periodo.TabIndex = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 182);
            this.dataGridView1.TabIndex = 0;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(718, 29);
            this.ucGe_Menu.TabIndex = 128;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // frmRo_Contabilizar_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 411);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRo_Contabilizar_Rol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contabilizar Rol";
            this.Load += new System.EventHandler(this.frmRo_Contabilizar_Rol_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_Contabilizar_Rol_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.roperiodoxroNominaTipoLiquiInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaContabilidad.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaContabilidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roperiodoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dteFechaContabilidad;
        private DevExpress.XtraEditors.SimpleButton cmdReversoContabilidad;
        private DevExpress.XtraEditors.SimpleButton cmdContabilizar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.BindingSource roperiodoxroNominaTipoLiquiInfoBindingSource;
        private System.Windows.Forms.BindingSource roperiodoInfoBindingSource;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Controles.UCRo_PeriodoXNomina ucRo_Periodo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}