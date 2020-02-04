namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_GrupoEmpresarial_grupocble_Consulta
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
            this.gridControl_Grupo = new DevExpress.XtraGrid.GridControl();
            this.ctGrupoEmpresarialgrupocbleInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UltraGrid_Grupo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGrupoCble_gr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgc_GrupoCble_gr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgc_Orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgc_estado_financiero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgc_signo_operacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Grupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctGrupoEmpresarialgrupocbleInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_Grupo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_Grupo
            // 
            this.gridControl_Grupo.DataSource = this.ctGrupoEmpresarialgrupocbleInfoBindingSource;
            this.gridControl_Grupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Grupo.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Grupo.MainView = this.UltraGrid_Grupo;
            this.gridControl_Grupo.Name = "gridControl_Grupo";
            this.gridControl_Grupo.Size = new System.Drawing.Size(556, 261);
            this.gridControl_Grupo.TabIndex = 10;
            this.gridControl_Grupo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGrid_Grupo});
            // 
            // ctGrupoEmpresarialgrupocbleInfoBindingSource
            // 
            this.ctGrupoEmpresarialgrupocbleInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_GrupoEmpresarial_grupocble_Info);
            // 
            // UltraGrid_Grupo
            // 
            this.UltraGrid_Grupo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGrupoCble_gr,
            this.colgc_GrupoCble_gr,
            this.colgc_Orden,
            this.colgc_estado_financiero,
            this.colgc_signo_operacion});
            this.UltraGrid_Grupo.GridControl = this.gridControl_Grupo;
            this.UltraGrid_Grupo.Name = "UltraGrid_Grupo";
            this.UltraGrid_Grupo.OptionsView.ShowAutoFilterRow = true;
            this.UltraGrid_Grupo.OptionsView.ShowGroupPanel = false;
            this.UltraGrid_Grupo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.UltraGrid_Grupo_FocusedRowChanged);
            // 
            // colIdGrupoCble_gr
            // 
            this.colIdGrupoCble_gr.Caption = "#Grupo Cble.";
            this.colIdGrupoCble_gr.FieldName = "IdGrupoCble_gr";
            this.colIdGrupoCble_gr.Name = "colIdGrupoCble_gr";
            this.colIdGrupoCble_gr.OptionsColumn.AllowEdit = false;
            this.colIdGrupoCble_gr.Visible = true;
            this.colIdGrupoCble_gr.VisibleIndex = 0;
            this.colIdGrupoCble_gr.Width = 83;
            // 
            // colgc_GrupoCble_gr
            // 
            this.colgc_GrupoCble_gr.Caption = "Grupo Cble.";
            this.colgc_GrupoCble_gr.FieldName = "gc_GrupoCble_gr";
            this.colgc_GrupoCble_gr.Name = "colgc_GrupoCble_gr";
            this.colgc_GrupoCble_gr.OptionsColumn.AllowEdit = false;
            this.colgc_GrupoCble_gr.Visible = true;
            this.colgc_GrupoCble_gr.VisibleIndex = 1;
            this.colgc_GrupoCble_gr.Width = 216;
            // 
            // colgc_Orden
            // 
            this.colgc_Orden.Caption = "Orden";
            this.colgc_Orden.FieldName = "gc_Orden";
            this.colgc_Orden.Name = "colgc_Orden";
            this.colgc_Orden.OptionsColumn.AllowEdit = false;
            this.colgc_Orden.Visible = true;
            this.colgc_Orden.VisibleIndex = 2;
            this.colgc_Orden.Width = 60;
            // 
            // colgc_estado_financiero
            // 
            this.colgc_estado_financiero.Caption = "Estado Financiero";
            this.colgc_estado_financiero.FieldName = "gc_estado_financiero";
            this.colgc_estado_financiero.Name = "colgc_estado_financiero";
            this.colgc_estado_financiero.OptionsColumn.AllowEdit = false;
            this.colgc_estado_financiero.Visible = true;
            this.colgc_estado_financiero.VisibleIndex = 3;
            this.colgc_estado_financiero.Width = 93;
            // 
            // colgc_signo_operacion
            // 
            this.colgc_signo_operacion.Caption = "Signo Operación";
            this.colgc_signo_operacion.FieldName = "gc_signo_operacion";
            this.colgc_signo_operacion.Name = "colgc_signo_operacion";
            this.colgc_signo_operacion.OptionsColumn.AllowEdit = false;
            this.colgc_signo_operacion.Visible = true;
            this.colgc_signo_operacion.VisibleIndex = 4;
            this.colgc_signo_operacion.Width = 86;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 92);
            this.panel1.TabIndex = 11;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 2, 18, 5, 10, 445);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 2, 18, 5, 10, 445);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(556, 94);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl_Grupo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 261);
            this.panel2.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 331);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(556, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmCon_GrupoEmpresarial_grupocble_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 353);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCon_GrupoEmpresarial_grupocble_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Grupo Contable del Grupo Empresarial";
            this.Load += new System.EventHandler(this.frmCon_GrupoEmpresarial_grupocble_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Grupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctGrupoEmpresarialgrupocbleInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_Grupo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Grupo;
        private System.Windows.Forms.BindingSource ctGrupoEmpresarialgrupocbleInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGrid_Grupo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupoCble_gr;
        private DevExpress.XtraGrid.Columns.GridColumn colgc_GrupoCble_gr;
        private DevExpress.XtraGrid.Columns.GridColumn colgc_Orden;
        private DevExpress.XtraGrid.Columns.GridColumn colgc_estado_financiero;
        private DevExpress.XtraGrid.Columns.GridColumn colgc_signo_operacion;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}