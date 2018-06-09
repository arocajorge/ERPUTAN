namespace Cus.Erp.Reports.Talme.Roles
{
    partial class XROL_TALME_Rpt001_frm
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
            this.ucRo_Menu_Reportes = new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes();
            this.SuspendLayout();
            // 
            // ucRo_Menu_Reportes
            // 
            this.ucRo_Menu_Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucRo_Menu_Reportes.EnableBotonImprimir = true;
            this.ucRo_Menu_Reportes.Location = new System.Drawing.Point(0, 0);
            this.ucRo_Menu_Reportes.Name = "ucRo_Menu_Reportes";
            this.ucRo_Menu_Reportes.Size = new System.Drawing.Size(1051, 97);
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
            // XROL_TALME_Rpt001_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 94);
            this.Controls.Add(this.ucRo_Menu_Reportes);
            this.Name = "XROL_TALME_Rpt001_frm";
            this.Text = "XROL_TALME_Rpt001_frm";
            this.Load += new System.EventHandler(this.XROL_TALME_Rpt001_frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Core.Erp.Reportes.Controles.UCRo_Menu_Reportes ucRo_Menu_Reportes;

    }
}