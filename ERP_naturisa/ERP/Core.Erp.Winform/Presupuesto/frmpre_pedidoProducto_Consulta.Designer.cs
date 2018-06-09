namespace Core.Erp.Winform.Presupuesto
{
    partial class frmpre_pedidoProducto_Consulta
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
            this.gridControl_pedidoXpresupuesto = new DevExpress.XtraGrid.GridControl();
            this.prePedidoXPresupuestoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UltraGrid_pedidoXpresupuesto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPedidoXPre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit_departamento = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.roDepartamentoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDpto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colro_Dpto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit_Prove = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.cpproveedorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProveedor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_pedidoXpresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prePedidoXPresupuestoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_pedidoXpresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_departamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roDepartamentoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_Prove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_pedidoXpresupuesto
            // 
            this.gridControl_pedidoXpresupuesto.DataSource = this.prePedidoXPresupuestoInfoBindingSource;
            this.gridControl_pedidoXpresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_pedidoXpresupuesto.Location = new System.Drawing.Point(0, 0);
            this.gridControl_pedidoXpresupuesto.MainView = this.UltraGrid_pedidoXpresupuesto;
            this.gridControl_pedidoXpresupuesto.Name = "gridControl_pedidoXpresupuesto";
            this.gridControl_pedidoXpresupuesto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit_departamento,
            this.repositoryItemSearchLookUpEdit_Prove});
            this.gridControl_pedidoXpresupuesto.Size = new System.Drawing.Size(1022, 231);
            this.gridControl_pedidoXpresupuesto.TabIndex = 15;
            this.gridControl_pedidoXpresupuesto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGrid_pedidoXpresupuesto});
            // 
            // prePedidoXPresupuestoInfoBindingSource
            // 
            this.prePedidoXPresupuestoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Presupuesto.pre_PedidoXPresupuesto_Info);
            // 
            // UltraGrid_pedidoXpresupuesto
            // 
            this.UltraGrid_pedidoXpresupuesto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdPedidoXPre,
            this.colIdDepartamento,
            this.colFecha,
            this.colObservacion,
            this.colIdProveedor1,
            this.colIdProveedor2,
            this.colIdProveedor3,
            this.colIdUsuario,
            this.colFecha_Transac,
            this.colIdUsuarioUltMod,
            this.colFecha_UltMod,
            this.colIdUsuarioUltAnu,
            this.colFecha_UltAnu,
            this.colnom_pc,
            this.colip,
            this.colEstado});
            this.UltraGrid_pedidoXpresupuesto.CustomizationFormBounds = new System.Drawing.Rectangle(519, 397, 216, 178);
            this.UltraGrid_pedidoXpresupuesto.GridControl = this.gridControl_pedidoXpresupuesto;
            this.UltraGrid_pedidoXpresupuesto.Name = "UltraGrid_pedidoXpresupuesto";
            this.UltraGrid_pedidoXpresupuesto.OptionsView.ShowAutoFilterRow = true;
            this.UltraGrid_pedidoXpresupuesto.OptionsView.ShowGroupPanel = false;
            this.UltraGrid_pedidoXpresupuesto.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.UltraGrid_pedidoXpresupuesto_RowCellStyle);
            this.UltraGrid_pedidoXpresupuesto.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.UltraGrid_pedidoXpresupuesto_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            // 
            // colIdPedidoXPre
            // 
            this.colIdPedidoXPre.Caption = "#PedidoXPre";
            this.colIdPedidoXPre.FieldName = "IdPedidoXPre";
            this.colIdPedidoXPre.Name = "colIdPedidoXPre";
            this.colIdPedidoXPre.OptionsColumn.AllowEdit = false;
            this.colIdPedidoXPre.Visible = true;
            this.colIdPedidoXPre.VisibleIndex = 0;
            this.colIdPedidoXPre.Width = 74;
            // 
            // colIdDepartamento
            // 
            this.colIdDepartamento.Caption = "Departamento";
            this.colIdDepartamento.ColumnEdit = this.repositoryItemSearchLookUpEdit_departamento;
            this.colIdDepartamento.FieldName = "IdDepartamento";
            this.colIdDepartamento.Name = "colIdDepartamento";
            this.colIdDepartamento.OptionsColumn.AllowEdit = false;
            this.colIdDepartamento.Visible = true;
            this.colIdDepartamento.VisibleIndex = 1;
            this.colIdDepartamento.Width = 125;
            // 
            // repositoryItemSearchLookUpEdit_departamento
            // 
            this.repositoryItemSearchLookUpEdit_departamento.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit_departamento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit_departamento.DataSource = this.roDepartamentoInfoBindingSource;
            this.repositoryItemSearchLookUpEdit_departamento.DisplayMember = "ro_Dpto";
            this.repositoryItemSearchLookUpEdit_departamento.Name = "repositoryItemSearchLookUpEdit_departamento";
            this.repositoryItemSearchLookUpEdit_departamento.ValueMember = "IdDpto";
            this.repositoryItemSearchLookUpEdit_departamento.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // roDepartamentoInfoBindingSource
            // 
            this.roDepartamentoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Departamento_Info);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDpto,
            this.colro_Dpto});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdDpto
            // 
            this.colIdDpto.FieldName = "IdDpto";
            this.colIdDpto.Name = "colIdDpto";
            this.colIdDpto.Visible = true;
            this.colIdDpto.VisibleIndex = 0;
            // 
            // colro_Dpto
            // 
            this.colro_Dpto.FieldName = "ro_Dpto";
            this.colro_Dpto.Name = "colro_Dpto";
            this.colro_Dpto.Visible = true;
            this.colro_Dpto.VisibleIndex = 1;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            this.colFecha.Width = 70;
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.OptionsColumn.AllowEdit = false;
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 3;
            this.colObservacion.Width = 133;
            // 
            // colIdProveedor1
            // 
            this.colIdProveedor1.Caption = "Proveedor1";
            this.colIdProveedor1.ColumnEdit = this.repositoryItemSearchLookUpEdit_Prove;
            this.colIdProveedor1.FieldName = "IdProveedor1";
            this.colIdProveedor1.Name = "colIdProveedor1";
            this.colIdProveedor1.OptionsColumn.AllowEdit = false;
            this.colIdProveedor1.Visible = true;
            this.colIdProveedor1.VisibleIndex = 4;
            this.colIdProveedor1.Width = 206;
            // 
            // repositoryItemSearchLookUpEdit_Prove
            // 
            this.repositoryItemSearchLookUpEdit_Prove.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit_Prove.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit_Prove.DataSource = this.cpproveedorInfoBindingSource;
            this.repositoryItemSearchLookUpEdit_Prove.DisplayMember = "pr_nombre2";
            this.repositoryItemSearchLookUpEdit_Prove.Name = "repositoryItemSearchLookUpEdit_Prove";
            this.repositoryItemSearchLookUpEdit_Prove.ValueMember = "IdProveedor";
            this.repositoryItemSearchLookUpEdit_Prove.View = this.gridView1;
            // 
            // cpproveedorInfoBindingSource
            // 
            this.cpproveedorInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_proveedor_Info);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProveedor2
            // 
            this.colIdProveedor2.Caption = "Proveedor2";
            this.colIdProveedor2.ColumnEdit = this.repositoryItemSearchLookUpEdit_Prove;
            this.colIdProveedor2.FieldName = "IdProveedor2";
            this.colIdProveedor2.Name = "colIdProveedor2";
            this.colIdProveedor2.OptionsColumn.AllowEdit = false;
            this.colIdProveedor2.Visible = true;
            this.colIdProveedor2.VisibleIndex = 5;
            this.colIdProveedor2.Width = 177;
            // 
            // colIdProveedor3
            // 
            this.colIdProveedor3.Caption = "Proveedor3";
            this.colIdProveedor3.ColumnEdit = this.repositoryItemSearchLookUpEdit_Prove;
            this.colIdProveedor3.FieldName = "IdProveedor3";
            this.colIdProveedor3.Name = "colIdProveedor3";
            this.colIdProveedor3.OptionsColumn.AllowEdit = false;
            this.colIdProveedor3.Visible = true;
            this.colIdProveedor3.VisibleIndex = 6;
            this.colIdProveedor3.Width = 157;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.OptionsColumn.AllowEdit = false;
            this.colIdUsuario.Visible = true;
            this.colIdUsuario.VisibleIndex = 7;
            this.colIdUsuario.Width = 86;
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            this.colFecha_Transac.OptionsColumn.AllowEdit = false;
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            this.colIdUsuarioUltMod.OptionsColumn.AllowEdit = false;
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            this.colFecha_UltMod.OptionsColumn.AllowEdit = false;
            // 
            // colIdUsuarioUltAnu
            // 
            this.colIdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Name = "colIdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.OptionsColumn.AllowEdit = false;
            // 
            // colFecha_UltAnu
            // 
            this.colFecha_UltAnu.FieldName = "Fecha_UltAnu";
            this.colFecha_UltAnu.Name = "colFecha_UltAnu";
            this.colFecha_UltAnu.OptionsColumn.AllowEdit = false;
            // 
            // colnom_pc
            // 
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            this.colnom_pc.OptionsColumn.AllowEdit = false;
            // 
            // colip
            // 
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            this.colip.OptionsColumn.AllowEdit = false;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 8;
            this.colEstado.Width = 66;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl_pedidoXpresupuesto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 231);
            this.panel1.TabIndex = 16;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 6, 11, 46, 35, 665);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 6, 11, 46, 35, 665);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1022, 96);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 17;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 327);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1022, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmpre_pedidoProducto_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "frmpre_pedidoProducto_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Pedido de Producto";
            this.Load += new System.EventHandler(this.frmpre_pedidoProducto_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_pedidoXpresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prePedidoXPresupuestoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_pedidoXpresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_departamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roDepartamentoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_Prove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_pedidoXpresupuesto;
        private System.Windows.Forms.BindingSource prePedidoXPresupuestoInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGrid_pedidoXpresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPedidoXPre;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit_departamento;
        private System.Windows.Forms.BindingSource roDepartamentoInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDpto;
        private DevExpress.XtraGrid.Columns.GridColumn colro_Dpto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit_Prove;
        private System.Windows.Forms.BindingSource cpproveedorInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}