namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_GrupoEmpresarial_Consulta
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
            this.gridControl_GrupoEmp = new DevExpress.XtraGrid.GridControl();
            this.ctGrupoEmpresarialInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UltraGrid_GrupoEmp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGrupoEmpresarial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupoEmpresarial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_GrupoEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctGrupoEmpresarialInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_GrupoEmp)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_GrupoEmp
            // 
            this.gridControl_GrupoEmp.DataSource = this.ctGrupoEmpresarialInfoBindingSource;
            this.gridControl_GrupoEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_GrupoEmp.Location = new System.Drawing.Point(0, 94);
            this.gridControl_GrupoEmp.MainView = this.UltraGrid_GrupoEmp;
            this.gridControl_GrupoEmp.Name = "gridControl_GrupoEmp";
            this.gridControl_GrupoEmp.Size = new System.Drawing.Size(496, 176);
            this.gridControl_GrupoEmp.TabIndex = 8;
            this.gridControl_GrupoEmp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGrid_GrupoEmp});
            // 
            // ctGrupoEmpresarialInfoBindingSource
            // 
            this.ctGrupoEmpresarialInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_GrupoEmpresarial_Info);
            // 
            // UltraGrid_GrupoEmp
            // 
            this.UltraGrid_GrupoEmp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGrupoEmpresarial,
            this.colGrupoEmpresarial,
            this.colEstado});
            this.UltraGrid_GrupoEmp.GridControl = this.gridControl_GrupoEmp;
            this.UltraGrid_GrupoEmp.Name = "UltraGrid_GrupoEmp";
            this.UltraGrid_GrupoEmp.OptionsView.ShowAutoFilterRow = true;
            this.UltraGrid_GrupoEmp.OptionsView.ShowGroupPanel = false;
            this.UltraGrid_GrupoEmp.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.UltraGrid_GrupoEmp_RowCellStyle);
            this.UltraGrid_GrupoEmp.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.UltraGrid_GrupoEmp_FocusedRowChanged);
            // 
            // colIdGrupoEmpresarial
            // 
            this.colIdGrupoEmpresarial.Caption = "#Grupo Empresarial";
            this.colIdGrupoEmpresarial.FieldName = "IdGrupoEmpresarial";
            this.colIdGrupoEmpresarial.Name = "colIdGrupoEmpresarial";
            this.colIdGrupoEmpresarial.OptionsColumn.AllowEdit = false;
            this.colIdGrupoEmpresarial.Visible = true;
            this.colIdGrupoEmpresarial.VisibleIndex = 0;
            this.colIdGrupoEmpresarial.Width = 103;
            // 
            // colGrupoEmpresarial
            // 
            this.colGrupoEmpresarial.FieldName = "GrupoEmpresarial";
            this.colGrupoEmpresarial.Name = "colGrupoEmpresarial";
            this.colGrupoEmpresarial.OptionsColumn.AllowEdit = false;
            this.colGrupoEmpresarial.Visible = true;
            this.colGrupoEmpresarial.VisibleIndex = 1;
            this.colGrupoEmpresarial.Width = 297;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 2;
            this.colEstado.Width = 72;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 94);
            this.panel2.TabIndex = 10;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 2, 17, 19, 22, 229);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 2, 17, 19, 22, 229);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(496, 94);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 270);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(496, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmCon_GrupoEmpresarial_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 292);
            this.Controls.Add(this.gridControl_GrupoEmp);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Name = "frmCon_GrupoEmpresarial_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grupo Empresarial Consulta";
            this.Load += new System.EventHandler(this.frmCon_GrupoEmpresarial_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_GrupoEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctGrupoEmpresarialInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_GrupoEmp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_GrupoEmp;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGrid_GrupoEmp;
        private System.Windows.Forms.BindingSource ctGrupoEmpresarialInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupoEmpresarial;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupoEmpresarial;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}