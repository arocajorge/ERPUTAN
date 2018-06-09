namespace Core.Erp.Reportes.Roles
{
    partial class XROL_Rpt003_frm
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ucRo_Menu_Reportes = new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ucRo_Menu_Reportes);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1044, 86);
            this.splitContainerControl1.SplitterPosition = 78;
            this.splitContainerControl1.TabIndex = 10;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ucRo_Menu_Reportes
            // 
            this.ucRo_Menu_Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucRo_Menu_Reportes.EnableBotonImprimir = true;
            this.ucRo_Menu_Reportes.Location = new System.Drawing.Point(0, 0);
            this.ucRo_Menu_Reportes.Name = "ucRo_Menu_Reportes";
            this.ucRo_Menu_Reportes.Size = new System.Drawing.Size(1044, 75);
            this.ucRo_Menu_Reportes.TabIndex = 0;
            this.ucRo_Menu_Reportes.VisibleCmbCentroCosto = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu_Reportes.VisibleCmbDivision = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu_Reportes.VisibleCmbEmpleado = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu_Reportes.VisibleCmbNominaTipo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu_Reportes.VisibleCmbNominaTipoLiqui = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu_Reportes.VisibleCmbPeriodo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu_Reportes.VisibleCmbRubro = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu_Reportes.VisibleGrupoFecha = true;
            this.ucRo_Menu_Reportes.VisibleGrupoFiltro1 = true;
            this.ucRo_Menu_Reportes.VisibleGrupoFiltro2 = true;
            this.ucRo_Menu_Reportes.event_cmdCargar_ItemClick += new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes.delegate_cmdCargar_ItemClick(this.ucRo_Menu_Reportes_event_cmdCargar_ItemClick);
            this.ucRo_Menu_Reportes.event_btnsalir_ItemClick += new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes.delegate_btnsalir_ItemClick(this.ucRo_Menu_Reportes_event_btnsalir_ItemClick);
            this.ucRo_Menu_Reportes.Load += new System.EventHandler(this.ucRo_Menu_Reportes_Load);
            // 
            // XROL_Rpt003_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 86);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "XROL_Rpt003_frm";
            this.Text = "Reporte - Comprobante de Pago";
            this.Load += new System.EventHandler(this.XROL_Rpt003_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private Controles.UCRo_Menu_Reportes ucRo_Menu_Reportes;

    }
}