namespace Core.Erp.Winform.Roles
{
    partial class frmRo_RDEP_Cons
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
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.chkTodos = new DevExpress.XtraEditors.CheckEdit();
            this.cmbAnioFiscal = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridRDEP = new DevExpress.XtraGrid.GridControl();
            this.roRdepInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewRDEP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkOpcion = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnioFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIngresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkTodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRDEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roRdepInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRDEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOpcion)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 5, 8, 17, 38, 12, 471);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 7, 8, 17, 38, 12, 471);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(925, 151);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 1;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 151);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.chkTodos);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmbAnioFiscal);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridRDEP);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(925, 280);
            this.splitContainerControl1.SplitterPosition = 35;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // chkTodos
            // 
            this.chkTodos.Location = new System.Drawing.Point(16, 9);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Properties.Caption = "Seleccionar Todos";
            this.chkTodos.Size = new System.Drawing.Size(129, 19);
            this.chkTodos.TabIndex = 67;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // cmbAnioFiscal
            // 
            this.cmbAnioFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnioFiscal.FormattingEnabled = true;
            this.cmbAnioFiscal.Location = new System.Drawing.Point(300, 8);
            this.cmbAnioFiscal.Name = "cmbAnioFiscal";
            this.cmbAnioFiscal.Size = new System.Drawing.Size(116, 21);
            this.cmbAnioFiscal.TabIndex = 66;
            this.cmbAnioFiscal.SelectedIndexChanged += new System.EventHandler(this.cmbAnioFiscal_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(218, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 65;
            this.labelControl2.Text = "Período Fiscal:";
            // 
            // gridRDEP
            // 
            this.gridRDEP.DataSource = this.roRdepInfoBindingSource;
            this.gridRDEP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRDEP.Location = new System.Drawing.Point(0, 0);
            this.gridRDEP.MainView = this.viewRDEP;
            this.gridRDEP.Name = "gridRDEP";
            this.gridRDEP.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkOpcion});
            this.gridRDEP.Size = new System.Drawing.Size(925, 240);
            this.gridRDEP.TabIndex = 0;
            this.gridRDEP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewRDEP});
            // 
            // roRdepInfoBindingSource
            // 
            this.roRdepInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Rdep_Info);
            // 
            // viewRDEP
            // 
            this.viewRDEP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheck,
            this.colIdEmpleado,
            this.colApellido,
            this.colNombre,
            this.colCedulaRuc,
            this.colCargo,
            this.colDepartamento,
            this.colAnioFiscal,
            this.colFechaIngresa,
            this.colEstado});
            this.viewRDEP.GridControl = this.gridRDEP;
            this.viewRDEP.Name = "viewRDEP";
            this.viewRDEP.OptionsView.ShowAutoFilterRow = true;
            this.viewRDEP.OptionsView.ShowDetailButtons = false;
            this.viewRDEP.OptionsView.ShowGroupPanel = false;
            this.viewRDEP.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.viewRDEP_RowStyle);
            // 
            // colCheck
            // 
            this.colCheck.Caption = "...";
            this.colCheck.ColumnEdit = this.chkOpcion;
            this.colCheck.FieldName = "Check";
            this.colCheck.Name = "colCheck";
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 0;
            this.colCheck.Width = 20;
            // 
            // chkOpcion
            // 
            this.chkOpcion.AutoHeight = false;
            this.chkOpcion.Name = "chkOpcion";
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.OptionsColumn.AllowEdit = false;
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 1;
            this.colIdEmpleado.Width = 84;
            // 
            // colApellido
            // 
            this.colApellido.FieldName = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.OptionsColumn.AllowEdit = false;
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 3;
            this.colApellido.Width = 236;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 4;
            this.colNombre.Width = 267;
            // 
            // colCedulaRuc
            // 
            this.colCedulaRuc.FieldName = "CedulaRuc";
            this.colCedulaRuc.Name = "colCedulaRuc";
            this.colCedulaRuc.OptionsColumn.AllowEdit = false;
            this.colCedulaRuc.Visible = true;
            this.colCedulaRuc.VisibleIndex = 2;
            this.colCedulaRuc.Width = 80;
            // 
            // colCargo
            // 
            this.colCargo.FieldName = "Cargo";
            this.colCargo.Name = "colCargo";
            this.colCargo.OptionsColumn.AllowEdit = false;
            this.colCargo.Visible = true;
            this.colCargo.VisibleIndex = 5;
            this.colCargo.Width = 208;
            // 
            // colDepartamento
            // 
            this.colDepartamento.FieldName = "Departamento";
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.OptionsColumn.AllowEdit = false;
            this.colDepartamento.Width = 135;
            // 
            // colAnioFiscal
            // 
            this.colAnioFiscal.FieldName = "AnioFiscal";
            this.colAnioFiscal.Name = "colAnioFiscal";
            this.colAnioFiscal.OptionsColumn.AllowEdit = false;
            this.colAnioFiscal.Visible = true;
            this.colAnioFiscal.VisibleIndex = 6;
            this.colAnioFiscal.Width = 60;
            // 
            // colFechaIngresa
            // 
            this.colFechaIngresa.Caption = "Fecha";
            this.colFechaIngresa.FieldName = "FechaIngresa";
            this.colFechaIngresa.Name = "colFechaIngresa";
            this.colFechaIngresa.OptionsColumn.AllowEdit = false;
            this.colFechaIngresa.Visible = true;
            this.colFechaIngresa.VisibleIndex = 7;
            this.colFechaIngresa.Width = 71;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 8;
            this.colEstado.Width = 99;
            // 
            // frmRo_RDEP_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 431);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "frmRo_RDEP_Cons";
            this.Text = "Anexo de Retención en la Fuente bajo Relación de Dependencia - RDEP";
            this.Load += new System.EventHandler(this.frmRo_RDEP_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkTodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRDEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roRdepInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRDEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOpcion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridRDEP;
        private DevExpress.XtraGrid.Views.Grid.GridView viewRDEP;
        private System.Windows.Forms.BindingSource roRdepInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCedulaRuc;
        private DevExpress.XtraGrid.Columns.GridColumn colCargo;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colAnioFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIngresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkOpcion;
        private System.Windows.Forms.ComboBox cmbAnioFiscal;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chkTodos;

    }
}