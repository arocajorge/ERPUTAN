namespace Core.Erp.Winform.Roles
{
    partial class frmRo_ActaFiniquito_Cons
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.gridFiniquito = new DevExpress.XtraGrid.GridControl();
            this.roActaFiniquitoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewFiniquito = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdActaFiniquito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCausaTerminacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUltimaRemuneracion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngresos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEgresos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotiAnula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Apellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gridFiniquito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roActaFiniquitoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFiniquito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 8, 29, 16, 18, 27, 874);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 10, 29, 16, 18, 27, 875);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(829, 97);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 1;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // gridFiniquito
            // 
            this.gridFiniquito.DataSource = this.roActaFiniquitoInfoBindingSource;
            this.gridFiniquito.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            this.gridFiniquito.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gridFiniquito.Location = new System.Drawing.Point(0, 0);
            this.gridFiniquito.MainView = this.viewFiniquito;
            this.gridFiniquito.Name = "gridFiniquito";
            this.gridFiniquito.Size = new System.Drawing.Size(829, 366);
            this.gridFiniquito.TabIndex = 2;
            this.gridFiniquito.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewFiniquito});
            // 
            // roActaFiniquitoInfoBindingSource
            // 
            this.roActaFiniquitoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Acta_Finiquito_Info);
            // 
            // viewFiniquito
            // 
            this.viewFiniquito.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdActaFiniquito,
            this.colIdEmpleado,
            this.colIdCausaTerminacion,
            this.colIdContrato,
            this.colIdCargo,
            this.colFechaIngreso,
            this.colFechaSalida,
            this.colUltimaRemuneracion,
            this.colObservacion,
            this.colIngresos,
            this.colEgresos,
            this.colIdUsuario,
            this.colFecha_Transac,
            this.colIdUsuarioUltMod,
            this.colFecha_UltMod,
            this.colIdUsuarioUltAnu,
            this.colFecha_UltAnu,
            this.colnom_pc,
            this.colip,
            this.colEstado,
            this.colMotiAnula,
            this.colNombreCompleto,
            this.colNumDocumento,
            this.ColCodigo,
            this.ColCedula,
            this.Apellidos,
            this.ColNombres});
            this.viewFiniquito.GridControl = this.gridFiniquito;
            this.viewFiniquito.Name = "viewFiniquito";
            this.viewFiniquito.OptionsBehavior.ReadOnly = true;
            this.viewFiniquito.OptionsView.ShowAutoFilterRow = true;
            this.viewFiniquito.OptionsView.ShowGroupPanel = false;
            this.viewFiniquito.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNumDocumento, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.viewFiniquito.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.viewFiniquito_RowStyle);
            this.viewFiniquito.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.viewFiniquito_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Width = 74;
            // 
            // colIdActaFiniquito
            // 
            this.colIdActaFiniquito.FieldName = "IdActaFiniquito";
            this.colIdActaFiniquito.Name = "colIdActaFiniquito";
            this.colIdActaFiniquito.Visible = true;
            this.colIdActaFiniquito.VisibleIndex = 4;
            this.colIdActaFiniquito.Width = 95;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Width = 89;
            // 
            // colIdCausaTerminacion
            // 
            this.colIdCausaTerminacion.FieldName = "IdCausaTerminacion";
            this.colIdCausaTerminacion.Name = "colIdCausaTerminacion";
            this.colIdCausaTerminacion.Width = 89;
            // 
            // colIdContrato
            // 
            this.colIdContrato.FieldName = "IdContrato";
            this.colIdContrato.Name = "colIdContrato";
            this.colIdContrato.Width = 89;
            // 
            // colIdCargo
            // 
            this.colIdCargo.FieldName = "IdCargo";
            this.colIdCargo.Name = "colIdCargo";
            this.colIdCargo.Width = 117;
            // 
            // colFechaIngreso
            // 
            this.colFechaIngreso.FieldName = "FechaIngreso";
            this.colFechaIngreso.Name = "colFechaIngreso";
            this.colFechaIngreso.Visible = true;
            this.colFechaIngreso.VisibleIndex = 6;
            this.colFechaIngreso.Width = 99;
            // 
            // colFechaSalida
            // 
            this.colFechaSalida.FieldName = "FechaSalida";
            this.colFechaSalida.Name = "colFechaSalida";
            this.colFechaSalida.Visible = true;
            this.colFechaSalida.VisibleIndex = 7;
            this.colFechaSalida.Width = 78;
            // 
            // colUltimaRemuneracion
            // 
            this.colUltimaRemuneracion.FieldName = "UltimaRemuneracion";
            this.colUltimaRemuneracion.Name = "colUltimaRemuneracion";
            this.colUltimaRemuneracion.Visible = true;
            this.colUltimaRemuneracion.VisibleIndex = 8;
            this.colUltimaRemuneracion.Width = 121;
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 9;
            this.colObservacion.Width = 94;
            // 
            // colIngresos
            // 
            this.colIngresos.FieldName = "Ingresos";
            this.colIngresos.Name = "colIngresos";
            // 
            // colEgresos
            // 
            this.colEgresos.FieldName = "Egresos";
            this.colEgresos.Name = "colEgresos";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            this.colFecha_Transac.Width = 127;
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            // 
            // colIdUsuarioUltAnu
            // 
            this.colIdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Name = "colIdUsuarioUltAnu";
            // 
            // colFecha_UltAnu
            // 
            this.colFecha_UltAnu.FieldName = "Fecha_UltAnu";
            this.colFecha_UltAnu.Name = "colFecha_UltAnu";
            // 
            // colnom_pc
            // 
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            // 
            // colip
            // 
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 10;
            this.colEstado.Width = 50;
            // 
            // colMotiAnula
            // 
            this.colMotiAnula.FieldName = "MotiAnula";
            this.colMotiAnula.Name = "colMotiAnula";
            // 
            // colNombreCompleto
            // 
            this.colNombreCompleto.Caption = "Nombre del Empleado";
            this.colNombreCompleto.FieldName = "NombreCompleto";
            this.colNombreCompleto.Name = "colNombreCompleto";
            this.colNombreCompleto.Width = 154;
            // 
            // colNumDocumento
            // 
            this.colNumDocumento.Caption = "No.Contrato";
            this.colNumDocumento.FieldName = "NumDocumento";
            this.colNumDocumento.Name = "colNumDocumento";
            this.colNumDocumento.Visible = true;
            this.colNumDocumento.VisibleIndex = 5;
            this.colNumDocumento.Width = 84;
            // 
            // ColCodigo
            // 
            this.ColCodigo.Caption = "Codigo";
            this.ColCodigo.FieldName = "Codigo";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.Visible = true;
            this.ColCodigo.VisibleIndex = 0;
            this.ColCodigo.Width = 46;
            // 
            // ColCedula
            // 
            this.ColCedula.Caption = "Cedula";
            this.ColCedula.FieldName = "Cedula";
            this.ColCedula.Name = "ColCedula";
            this.ColCedula.Visible = true;
            this.ColCedula.VisibleIndex = 1;
            this.ColCedula.Width = 74;
            // 
            // Apellidos
            // 
            this.Apellidos.Caption = "Apellidos";
            this.Apellidos.FieldName = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Visible = true;
            this.Apellidos.VisibleIndex = 2;
            this.Apellidos.Width = 90;
            // 
            // ColNombres
            // 
            this.ColNombres.Caption = "Nombres";
            this.ColNombres.FieldName = "Nombres";
            this.ColNombres.Name = "ColNombres";
            this.ColNombres.Visible = true;
            this.ColNombres.VisibleIndex = 3;
            this.ColNombres.Width = 101;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridFiniquito);
            this.splitContainer1.Size = new System.Drawing.Size(829, 486);
            this.splitContainer1.SplitterDistance = 116;
            this.splitContainer1.TabIndex = 3;
            // 
            // frmRo_ActaFiniquito_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 486);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmRo_ActaFiniquito_Cons";
            this.Text = "Consulta - Acta de Finiquito";
            this.Load += new System.EventHandler(this.frmRo_ActaFiniquito_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFiniquito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roActaFiniquitoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFiniquito)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private DevExpress.XtraGrid.GridControl gridFiniquito;
        private DevExpress.XtraGrid.Views.Grid.GridView viewFiniquito;
        private System.Windows.Forms.BindingSource roActaFiniquitoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdActaFiniquito;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCausaTerminacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdContrato;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCargo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colUltimaRemuneracion;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIngresos;
        private DevExpress.XtraGrid.Columns.GridColumn colEgresos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colMotiAnula;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colNumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn ColCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn ColCedula;
        private DevExpress.XtraGrid.Columns.GridColumn Apellidos;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombres;
    }
}