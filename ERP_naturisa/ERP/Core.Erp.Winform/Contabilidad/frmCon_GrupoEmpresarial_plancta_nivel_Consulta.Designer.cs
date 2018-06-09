namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_GrupoEmpresarial_plancta_nivel_Consulta
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
            this.gridControl_Nivel = new DevExpress.XtraGrid.GridControl();
            this.ctGrupoEmpresarialplanctanivelInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UltraGrid_Nivel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdNivelCta_gr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnv_NumDigitos_gr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnv_Descripcion_gr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Nivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctGrupoEmpresarialplanctanivelInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_Nivel)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_Nivel
            // 
            this.gridControl_Nivel.DataSource = this.ctGrupoEmpresarialplanctanivelInfoBindingSource;
            this.gridControl_Nivel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Nivel.Location = new System.Drawing.Point(0, 94);
            this.gridControl_Nivel.MainView = this.UltraGrid_Nivel;
            this.gridControl_Nivel.Name = "gridControl_Nivel";
            this.gridControl_Nivel.Size = new System.Drawing.Size(473, 182);
            this.gridControl_Nivel.TabIndex = 9;
            this.gridControl_Nivel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGrid_Nivel});
            this.gridControl_Nivel.Click += new System.EventHandler(this.gridControl_Nivel_Click);
            // 
            // ctGrupoEmpresarialplanctanivelInfoBindingSource
            // 
            this.ctGrupoEmpresarialplanctanivelInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_GrupoEmpresarial_plancta_nivel_Info);
            // 
            // UltraGrid_Nivel
            // 
            this.UltraGrid_Nivel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdNivelCta_gr,
            this.colnv_NumDigitos_gr,
            this.colnv_Descripcion_gr});
            this.UltraGrid_Nivel.GridControl = this.gridControl_Nivel;
            this.UltraGrid_Nivel.Name = "UltraGrid_Nivel";
            this.UltraGrid_Nivel.OptionsView.ShowAutoFilterRow = true;
            this.UltraGrid_Nivel.OptionsView.ShowGroupPanel = false;
            this.UltraGrid_Nivel.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.UltraGrid_Nivel_RowCellStyle);
            this.UltraGrid_Nivel.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.UltraGrid_Nivel_FocusedRowChanged);
            // 
            // colIdNivelCta_gr
            // 
            this.colIdNivelCta_gr.Caption = "#Nivel";
            this.colIdNivelCta_gr.FieldName = "IdNivelCta_gr";
            this.colIdNivelCta_gr.Name = "colIdNivelCta_gr";
            this.colIdNivelCta_gr.OptionsColumn.AllowEdit = false;
            this.colIdNivelCta_gr.Visible = true;
            this.colIdNivelCta_gr.VisibleIndex = 0;
            this.colIdNivelCta_gr.Width = 78;
            // 
            // colnv_NumDigitos_gr
            // 
            this.colnv_NumDigitos_gr.Caption = "Digitos";
            this.colnv_NumDigitos_gr.FieldName = "nv_NumDigitos_gr";
            this.colnv_NumDigitos_gr.Name = "colnv_NumDigitos_gr";
            this.colnv_NumDigitos_gr.OptionsColumn.AllowEdit = false;
            this.colnv_NumDigitos_gr.Visible = true;
            this.colnv_NumDigitos_gr.VisibleIndex = 2;
            this.colnv_NumDigitos_gr.Width = 85;
            // 
            // colnv_Descripcion_gr
            // 
            this.colnv_Descripcion_gr.Caption = "Nivel";
            this.colnv_Descripcion_gr.FieldName = "nv_Descripcion_gr";
            this.colnv_Descripcion_gr.Name = "colnv_Descripcion_gr";
            this.colnv_Descripcion_gr.OptionsColumn.AllowEdit = false;
            this.colnv_Descripcion_gr.Visible = true;
            this.colnv_Descripcion_gr.VisibleIndex = 1;
            this.colnv_Descripcion_gr.Width = 237;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 94);
            this.panel2.TabIndex = 11;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 2, 17, 38, 11, 91);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 2, 17, 38, 11, 92);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(473, 97);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Never;
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(473, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmCon_GrupoEmpresarial_plancta_nivel_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 298);
            this.Controls.Add(this.gridControl_Nivel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Name = "frmCon_GrupoEmpresarial_plancta_nivel_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nivel del Plan de Cuenta del Grupo Empresarial Consulta";
            this.Load += new System.EventHandler(this.frmCon_GrupoEmpresarial_plancta_nivel_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Nivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctGrupoEmpresarialplanctanivelInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_Nivel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Nivel;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGrid_Nivel;
        private System.Windows.Forms.BindingSource ctGrupoEmpresarialplanctanivelInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNivelCta_gr;
        private DevExpress.XtraGrid.Columns.GridColumn colnv_NumDigitos_gr;
        private DevExpress.XtraGrid.Columns.GridColumn colnv_Descripcion_gr;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}