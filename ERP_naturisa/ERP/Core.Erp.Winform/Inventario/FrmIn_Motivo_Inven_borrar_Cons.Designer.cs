namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Motivo_Inven_borrar_Cons
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlMovi_inve_tipo = new DevExpress.XtraGrid.GridControl();
            this.gridViewTipoInve = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtRan_inicial = new System.Windows.Forms.TextBox();
            this.txtRan_final = new System.Windows.Forms.TextBox();
            this.lblRan_inicial = new System.Windows.Forms.Label();
            this.lblRan_final = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMovi_inve_tipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoInve)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 389);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(854, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_anular = true;
            this.ucGe_Menu.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu.Enable_boton_consultar = true;
            this.ucGe_Menu.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu.Enable_boton_Duplicar = true;
            this.ucGe_Menu.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu.Enable_boton_GenerarXml = true;
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2014, 9, 1, 16, 54, 0, 348);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2014, 11, 1, 16, 54, 0, 348);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(854, 155);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlMovi_inve_tipo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 234);
            this.panel1.TabIndex = 2;
            // 
            // gridControlMovi_inve_tipo
            // 
            this.gridControlMovi_inve_tipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMovi_inve_tipo.Location = new System.Drawing.Point(0, 0);
            this.gridControlMovi_inve_tipo.MainView = this.gridViewTipoInve;
            this.gridControlMovi_inve_tipo.Name = "gridControlMovi_inve_tipo";
            this.gridControlMovi_inve_tipo.Size = new System.Drawing.Size(854, 234);
            this.gridControlMovi_inve_tipo.TabIndex = 0;
            this.gridControlMovi_inve_tipo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTipoInve});
            // 
            // gridViewTipoInve
            // 
            this.gridViewTipoInve.GridControl = this.gridControlMovi_inve_tipo;
            this.gridViewTipoInve.Name = "gridViewTipoInve";
            // 
            // txtRan_inicial
            // 
            this.txtRan_inicial.Location = new System.Drawing.Point(125, 111);
            this.txtRan_inicial.Name = "txtRan_inicial";
            this.txtRan_inicial.Size = new System.Drawing.Size(100, 20);
            this.txtRan_inicial.TabIndex = 3;
            // 
            // txtRan_final
            // 
            this.txtRan_final.Location = new System.Drawing.Point(338, 111);
            this.txtRan_final.Name = "txtRan_final";
            this.txtRan_final.Size = new System.Drawing.Size(100, 20);
            this.txtRan_final.TabIndex = 4;
            // 
            // lblRan_inicial
            // 
            this.lblRan_inicial.AutoSize = true;
            this.lblRan_inicial.Location = new System.Drawing.Point(47, 114);
            this.lblRan_inicial.Name = "lblRan_inicial";
            this.lblRan_inicial.Size = new System.Drawing.Size(72, 13);
            this.lblRan_inicial.TabIndex = 5;
            this.lblRan_inicial.Text = "Rango Inicial:";
            // 
            // lblRan_final
            // 
            this.lblRan_final.AutoSize = true;
            this.lblRan_final.Location = new System.Drawing.Point(265, 114);
            this.lblRan_final.Name = "lblRan_final";
            this.lblRan_final.Size = new System.Drawing.Size(67, 13);
            this.lblRan_final.TabIndex = 6;
            this.lblRan_final.Text = "Rango Final:";
            // 
            // FrmIn_Motivo_Inven_borrar_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 415);
            this.Controls.Add(this.lblRan_final);
            this.Controls.Add(this.lblRan_inicial);
            this.Controls.Add(this.txtRan_final);
            this.Controls.Add(this.txtRan_inicial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmIn_Motivo_Inven_borrar_Cons";
            this.Text = "FrmIn_Motivo_Inven_borrar_Cons";
            this.Load += new System.EventHandler(this.FrmIn_Motivo_Inven_borrar_Cons_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMovi_inve_tipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoInve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlMovi_inve_tipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTipoInve;
        private System.Windows.Forms.TextBox txtRan_inicial;
        private System.Windows.Forms.TextBox txtRan_final;
        private System.Windows.Forms.Label lblRan_inicial;
        private System.Windows.Forms.Label lblRan_final;

    }
}