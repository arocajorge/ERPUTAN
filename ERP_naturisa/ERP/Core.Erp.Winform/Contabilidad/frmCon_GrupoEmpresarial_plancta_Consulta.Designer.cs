namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_GrupoEmpresarial_plancta_Consulta
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
            this.ctGrupoEmpresarialplanctaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeListPlanCta = new DevExpress.XtraTreeList.TreeList();
            this.colpc_Cuenta_gr1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colpc_Naturaleza1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdCuenta_gr1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdNivelCta_gr1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdGrupoCble_gr1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colpc_EsMovimiento1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colpc_Estado1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdCuentaPadre_gr1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.ctGrupoEmpresarialplanctaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPlanCta)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctGrupoEmpresarialplanctaInfoBindingSource
            // 
            this.ctGrupoEmpresarialplanctaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_GrupoEmpresarial_plancta_Info);
            // 
            // treeListPlanCta
            // 
            this.treeListPlanCta.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colpc_Cuenta_gr1,
            this.colpc_Naturaleza1,
            this.colIdCuenta_gr1,
            this.colIdNivelCta_gr1,
            this.colIdGrupoCble_gr1,
            this.colpc_EsMovimiento1,
            this.colpc_Estado1,
            this.colIdCuentaPadre_gr1});
            this.treeListPlanCta.DataSource = this.ctGrupoEmpresarialplanctaInfoBindingSource;
            this.treeListPlanCta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListPlanCta.KeyFieldName = "IdCuenta_gr";
            this.treeListPlanCta.Location = new System.Drawing.Point(0, 0);
            this.treeListPlanCta.Name = "treeListPlanCta";
            this.treeListPlanCta.OptionsBehavior.AutoFocusNewNode = true;
            this.treeListPlanCta.OptionsBehavior.EnableFiltering = true;
            this.treeListPlanCta.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treeListPlanCta.OptionsPrint.PrintAllNodes = true;
            this.treeListPlanCta.OptionsPrint.UsePrintStyles = true;
            this.treeListPlanCta.OptionsView.ShowAutoFilterRow = true;
            this.treeListPlanCta.ParentFieldName = "IdCuentaPadre_gr";
            this.treeListPlanCta.Size = new System.Drawing.Size(829, 251);
            this.treeListPlanCta.TabIndex = 10;
            this.treeListPlanCta.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListPlanCta_FocusedNodeChanged);
            // 
            // colpc_Cuenta_gr1
            // 
            this.colpc_Cuenta_gr1.Caption = "Cuenta";
            this.colpc_Cuenta_gr1.FieldName = "pc_Cuenta_gr";
            this.colpc_Cuenta_gr1.Name = "colpc_Cuenta_gr1";
            this.colpc_Cuenta_gr1.Visible = true;
            this.colpc_Cuenta_gr1.VisibleIndex = 1;
            this.colpc_Cuenta_gr1.Width = 225;
            // 
            // colpc_Naturaleza1
            // 
            this.colpc_Naturaleza1.Caption = "Naturaleza";
            this.colpc_Naturaleza1.FieldName = "pc_Naturaleza";
            this.colpc_Naturaleza1.Name = "colpc_Naturaleza1";
            this.colpc_Naturaleza1.Visible = true;
            this.colpc_Naturaleza1.VisibleIndex = 3;
            this.colpc_Naturaleza1.Width = 72;
            // 
            // colIdCuenta_gr1
            // 
            this.colIdCuenta_gr1.Caption = "#Cuenta";
            this.colIdCuenta_gr1.FieldName = "IdCuenta_gr";
            this.colIdCuenta_gr1.Name = "colIdCuenta_gr1";
            this.colIdCuenta_gr1.Visible = true;
            this.colIdCuenta_gr1.VisibleIndex = 0;
            this.colIdCuenta_gr1.Width = 94;
            // 
            // colIdNivelCta_gr1
            // 
            this.colIdNivelCta_gr1.Caption = "Nivel cta.";
            this.colIdNivelCta_gr1.FieldName = "IdNivelCta_gr";
            this.colIdNivelCta_gr1.Name = "colIdNivelCta_gr1";
            this.colIdNivelCta_gr1.Visible = true;
            this.colIdNivelCta_gr1.VisibleIndex = 4;
            this.colIdNivelCta_gr1.Width = 66;
            // 
            // colIdGrupoCble_gr1
            // 
            this.colIdGrupoCble_gr1.Caption = "Grupo";
            this.colIdGrupoCble_gr1.FieldName = "IdGrupoCble_gr";
            this.colIdGrupoCble_gr1.Name = "colIdGrupoCble_gr1";
            this.colIdGrupoCble_gr1.Visible = true;
            this.colIdGrupoCble_gr1.VisibleIndex = 5;
            this.colIdGrupoCble_gr1.Width = 65;
            // 
            // colpc_EsMovimiento1
            // 
            this.colpc_EsMovimiento1.Caption = "Movimiento";
            this.colpc_EsMovimiento1.FieldName = "pc_EsMovimiento";
            this.colpc_EsMovimiento1.Name = "colpc_EsMovimiento1";
            this.colpc_EsMovimiento1.Visible = true;
            this.colpc_EsMovimiento1.VisibleIndex = 6;
            this.colpc_EsMovimiento1.Width = 91;
            // 
            // colpc_Estado1
            // 
            this.colpc_Estado1.Caption = "Estado";
            this.colpc_Estado1.FieldName = "pc_Estado";
            this.colpc_Estado1.Name = "colpc_Estado1";
            this.colpc_Estado1.Visible = true;
            this.colpc_Estado1.VisibleIndex = 7;
            this.colpc_Estado1.Width = 56;
            // 
            // colIdCuentaPadre_gr1
            // 
            this.colIdCuentaPadre_gr1.Caption = "#Cuenta Padre";
            this.colIdCuentaPadre_gr1.FieldName = "IdCuentaPadre_gr";
            this.colIdCuentaPadre_gr1.Name = "colIdCuentaPadre_gr1";
            this.colIdCuentaPadre_gr1.Visible = true;
            this.colIdCuentaPadre_gr1.VisibleIndex = 2;
            this.colIdCuentaPadre_gr1.Width = 142;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 94);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeListPlanCta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 251);
            this.panel2.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(829, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 2, 17, 25, 27, 670);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 2, 17, 25, 27, 670);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(829, 94);
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
            // frmCon_GrupoEmpresarial_plancta_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 345);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCon_GrupoEmpresarial_plancta_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plan de Cuenta del Grupo Empresarial Consulta";
            this.Load += new System.EventHandler(this.frmCon_GrupoEmpresarial_plancta_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctGrupoEmpresarialplanctaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPlanCta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ctGrupoEmpresarialplanctaInfoBindingSource;
        private DevExpress.XtraTreeList.TreeList treeListPlanCta;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colpc_Cuenta_gr1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colpc_Naturaleza1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdNivelCta_gr1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdGrupoCble_gr1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colpc_EsMovimiento1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colpc_Estado1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdCuenta_gr1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdCuentaPadre_gr1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}