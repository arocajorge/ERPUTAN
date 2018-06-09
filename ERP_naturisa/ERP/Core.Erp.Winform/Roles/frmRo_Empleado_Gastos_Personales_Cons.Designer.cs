namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Empleado_Gastos_Personales_Cons
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
            this.gridControlGastosPersonales = new DevExpress.XtraGrid.GridControl();
            this.roempleadogastospersoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewGastosPersonales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnio_fiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo_Iden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_Identificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidos_Nombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcalle_prin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIntersecion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProvincia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCidudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGastosPersonales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roempleadogastospersoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGastosPersonales)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlGastosPersonales
            // 
            this.gridControlGastosPersonales.DataSource = this.roempleadogastospersoInfoBindingSource;
            this.gridControlGastosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGastosPersonales.Location = new System.Drawing.Point(0, 0);
            this.gridControlGastosPersonales.MainView = this.gridViewGastosPersonales;
            this.gridControlGastosPersonales.Name = "gridControlGastosPersonales";
            this.gridControlGastosPersonales.Size = new System.Drawing.Size(1112, 145);
            this.gridControlGastosPersonales.TabIndex = 13;
            this.gridControlGastosPersonales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGastosPersonales});
            // 
            // roempleadogastospersoInfoBindingSource
            // 
            this.roempleadogastospersoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_empleado_gastos_perso_Info);
            // 
            // gridViewGastosPersonales
            // 
            this.gridViewGastosPersonales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdEmpleado,
            this.colAnio_fiscal,
            this.colfecha,
            this.colobservacion,
            this.colEstado,
            this.colTipo_Iden,
            this.colNum_Identificacion,
            this.colApellidos_Nombres,
            this.coltelefono,
            this.colcalle_prin,
            this.colNumero,
            this.colIntersecion,
            this.colIdProvincia,
            this.colIdCidudad,
            this.colcheck});
            this.gridViewGastosPersonales.GridControl = this.gridControlGastosPersonales;
            this.gridViewGastosPersonales.Name = "gridViewGastosPersonales";
            this.gridViewGastosPersonales.OptionsView.ShowAutoFilterRow = true;
            this.gridViewGastosPersonales.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewGastosPersonales_RowCellStyle);
            this.gridViewGastosPersonales.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewGastosPersonales_FocusedRowChanged);
            this.gridViewGastosPersonales.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewGastosPersonales_CellValueChanging);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.Caption = "IdEmpleado";
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.OptionsColumn.AllowEdit = false;
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 2;
            this.colIdEmpleado.Width = 78;
            // 
            // colAnio_fiscal
            // 
            this.colAnio_fiscal.Caption = "Año";
            this.colAnio_fiscal.FieldName = "Anio_fiscal";
            this.colAnio_fiscal.Name = "colAnio_fiscal";
            this.colAnio_fiscal.OptionsColumn.AllowEdit = false;
            this.colAnio_fiscal.Visible = true;
            this.colAnio_fiscal.VisibleIndex = 1;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 3;
            // 
            // colobservacion
            // 
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.Width = 77;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 7;
            // 
            // colTipo_Iden
            // 
            this.colTipo_Iden.Caption = "Tipo de Identificación";
            this.colTipo_Iden.FieldName = "Tipo_Iden";
            this.colTipo_Iden.Name = "colTipo_Iden";
            this.colTipo_Iden.Width = 121;
            // 
            // colNum_Identificacion
            // 
            this.colNum_Identificacion.Caption = "Numero de Identificación";
            this.colNum_Identificacion.FieldName = "Num_Identificacion";
            this.colNum_Identificacion.Name = "colNum_Identificacion";
            this.colNum_Identificacion.OptionsColumn.AllowEdit = false;
            this.colNum_Identificacion.Visible = true;
            this.colNum_Identificacion.VisibleIndex = 4;
            this.colNum_Identificacion.Width = 138;
            // 
            // colApellidos_Nombres
            // 
            this.colApellidos_Nombres.Caption = "Nombre Completo";
            this.colApellidos_Nombres.FieldName = "Apellidos_Nombres";
            this.colApellidos_Nombres.Name = "colApellidos_Nombres";
            this.colApellidos_Nombres.OptionsColumn.AllowEdit = false;
            this.colApellidos_Nombres.Visible = true;
            this.colApellidos_Nombres.VisibleIndex = 5;
            this.colApellidos_Nombres.Width = 109;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Telefono";
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.OptionsColumn.AllowEdit = false;
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 6;
            // 
            // colcalle_prin
            // 
            this.colcalle_prin.FieldName = "calle_prin";
            this.colcalle_prin.Name = "colcalle_prin";
            // 
            // colNumero
            // 
            this.colNumero.FieldName = "Numero";
            this.colNumero.Name = "colNumero";
            // 
            // colIntersecion
            // 
            this.colIntersecion.FieldName = "Intersecion";
            this.colIntersecion.Name = "colIntersecion";
            // 
            // colIdProvincia
            // 
            this.colIdProvincia.FieldName = "IdProvincia";
            this.colIdProvincia.Name = "colIdProvincia";
            // 
            // colIdCidudad
            // 
            this.colIdCidudad.FieldName = "IdCidudad";
            this.colIdCidudad.Name = "colIdCidudad";
            // 
            // colcheck
            // 
            this.colcheck.FieldName = "check";
            this.colcheck.Name = "colcheck";
            this.colcheck.OptionsColumn.ShowCaption = false;
            this.colcheck.Visible = true;
            this.colcheck.VisibleIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(69, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 7, 14, 39, 38, 570);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 7, 14, 39, 38, 570);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1112, 95);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 16;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1112, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.gridControlGastosPersonales);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 145);
            this.panel1.TabIndex = 18;
            // 
            // frmRo_Empleado_Gastos_Personales_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "frmRo_Empleado_Gastos_Personales_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Gastos Personales de Empleado";
            this.Load += new System.EventHandler(this.frmRo_Empleado_Gastos_Personales_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGastosPersonales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roempleadogastospersoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGastosPersonales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlGastosPersonales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGastosPersonales;
        private System.Windows.Forms.BindingSource roempleadogastospersoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colAnio_fiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo_Iden;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_Identificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidos_Nombres;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colcalle_prin;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero;
        private DevExpress.XtraGrid.Columns.GridColumn colIntersecion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProvincia;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCidudad;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}