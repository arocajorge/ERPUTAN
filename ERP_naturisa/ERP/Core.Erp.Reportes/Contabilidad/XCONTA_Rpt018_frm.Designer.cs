namespace Core.Erp.Reportes.Contabilidad
{
    partial class XCONTA_Rpt018_frm
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
            this.Menu = new Core.Erp.Reportes.Controles.UCct_Menu_Reportes();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.caption_bei_Check = "Mostrar detalle:";
            this.Menu.caption_bei_Check2 = "Check";
            this.Menu.caption_bei_Check3 = "Check";
            this.Menu.caption_bei_Check4 = "Check";
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1473, 101);
            this.Menu.TabIndex = 0;
            this.Menu.Visible_bei_Centro_costo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_bei_Centro_costo_chk = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_bei_Centro_costo_sub_centro_costo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_bei_Check2 = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_bei_Check3 = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_bei_Check4 = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_bei_CtaCble = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_bei_Desde = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_bei_GrupoCble = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_bei_GrupoCble_chk = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_bei_Hasta = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_bei_Nivel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_bei_punto_cargo = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_btn_Mostrar_en_tabla = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_Grupo_centro_costo = false;
            this.Menu.Visible_Grupo_Check = true;
            this.Menu.Visible_Grupo_cuentas = false;
            this.Menu.Visible_Grupo_Punto_cargo = true;
            this.Menu.event_btnConsultar_ItemClick += new Core.Erp.Reportes.Controles.UCct_Menu_Reportes.delegate_btnConsultar_ItemClick(this.Menu_event_btnConsultar_ItemClick);
            this.Menu.event_btnSalir_ItemClick += new Core.Erp.Reportes.Controles.UCct_Menu_Reportes.delegate_btnSalir_ItemClick(this.Menu_event_btnSalir_ItemClick);
            // 
            // XCONTA_Rpt018_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 507);
            this.Controls.Add(this.Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "XCONTA_Rpt018_frm";
            this.Text = "XCONTA_Rpt018_frm";
            this.Load += new System.EventHandler(this.XCONTA_Rpt018_frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCct_Menu_Reportes Menu;
    }
}