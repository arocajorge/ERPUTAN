namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Horario_Cons
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
            this.gridControlCons = new DevExpress.XtraGrid.GridControl();
            this.roHorarioInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCons = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHorario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToleranciaEnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToleranciaSal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInicioEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInicioSal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinalEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinalSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalLunch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegLunch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMin_Almuerzo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.roTurnoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ColMotiAnula = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roHorarioInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roTurnoInfoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlCons
            // 
            this.gridControlCons.DataSource = this.roHorarioInfoBindingSource;
            this.gridControlCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCons.Location = new System.Drawing.Point(0, 0);
            this.gridControlCons.MainView = this.gridViewCons;
            this.gridControlCons.Name = "gridControlCons";
            this.gridControlCons.Size = new System.Drawing.Size(1058, 247);
            this.gridControlCons.TabIndex = 1;
            this.gridControlCons.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCons});
            // 
            // roHorarioInfoBindingSource
            // 
            this.roHorarioInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Horario_Info);
            // 
            // gridViewCons
            // 
            this.gridViewCons.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdHorario,
            this.colDescripcion,
            this.colHoraIni,
            this.colHoraFin,
            this.colToleranciaEnt,
            this.colToleranciaSal,
            this.colInicioEntrada,
            this.colInicioSal,
            this.colFinalEntrada,
            this.colFinalSalida,
            this.colSalLunch,
            this.colRegLunch,
            this.colMin_Almuerzo,
            this.colEstado,
            this.ColMotiAnula});
            this.gridViewCons.GridControl = this.gridControlCons;
            this.gridViewCons.Name = "gridViewCons";
            this.gridViewCons.OptionsBehavior.Editable = false;
            this.gridViewCons.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCons.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colInicioSal, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewCons.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewCons_RowCellStyle);
            this.gridViewCons.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCons_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdHorario
            // 
            this.colIdHorario.Caption = "Id";
            this.colIdHorario.FieldName = "IdHorario";
            this.colIdHorario.Name = "colIdHorario";
            this.colIdHorario.Visible = true;
            this.colIdHorario.VisibleIndex = 0;
            this.colIdHorario.Width = 43;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 105;
            // 
            // colHoraIni
            // 
            this.colHoraIni.Caption = "HoraInicio";
            this.colHoraIni.FieldName = "HoraIni";
            this.colHoraIni.Name = "colHoraIni";
            this.colHoraIni.Visible = true;
            this.colHoraIni.VisibleIndex = 2;
            this.colHoraIni.Width = 71;
            // 
            // colHoraFin
            // 
            this.colHoraFin.Caption = "HoraFin";
            this.colHoraFin.FieldName = "HoraFin";
            this.colHoraFin.Name = "colHoraFin";
            this.colHoraFin.Visible = true;
            this.colHoraFin.VisibleIndex = 3;
            this.colHoraFin.Width = 57;
            // 
            // colToleranciaEnt
            // 
            this.colToleranciaEnt.Caption = "ToleranciaEntrada";
            this.colToleranciaEnt.FieldName = "ToleranciaEnt";
            this.colToleranciaEnt.Name = "colToleranciaEnt";
            this.colToleranciaEnt.Visible = true;
            this.colToleranciaEnt.VisibleIndex = 4;
            this.colToleranciaEnt.Width = 94;
            // 
            // colToleranciaSal
            // 
            this.colToleranciaSal.Caption = "ToleranciaSalida";
            this.colToleranciaSal.FieldName = "ToleranciaSal";
            this.colToleranciaSal.Name = "colToleranciaSal";
            this.colToleranciaSal.Visible = true;
            this.colToleranciaSal.VisibleIndex = 5;
            this.colToleranciaSal.Width = 96;
            // 
            // colInicioEntrada
            // 
            this.colInicioEntrada.Caption = "InicioEntrada";
            this.colInicioEntrada.FieldName = "InicioEntrada";
            this.colInicioEntrada.Name = "colInicioEntrada";
            this.colInicioEntrada.Visible = true;
            this.colInicioEntrada.VisibleIndex = 6;
            this.colInicioEntrada.Width = 78;
            // 
            // colInicioSal
            // 
            this.colInicioSal.Caption = "InicioSalida";
            this.colInicioSal.FieldName = "InicioSal";
            this.colInicioSal.Name = "colInicioSal";
            this.colInicioSal.Visible = true;
            this.colInicioSal.VisibleIndex = 8;
            // 
            // colFinalEntrada
            // 
            this.colFinalEntrada.Caption = "FinalEntrada";
            this.colFinalEntrada.FieldName = "FinalEntrada";
            this.colFinalEntrada.Name = "colFinalEntrada";
            this.colFinalEntrada.Visible = true;
            this.colFinalEntrada.VisibleIndex = 7;
            this.colFinalEntrada.Width = 74;
            // 
            // colFinalSalida
            // 
            this.colFinalSalida.Caption = "FinalSalida";
            this.colFinalSalida.FieldName = "FinalSalida";
            this.colFinalSalida.Name = "colFinalSalida";
            this.colFinalSalida.Visible = true;
            this.colFinalSalida.VisibleIndex = 9;
            this.colFinalSalida.Width = 70;
            // 
            // colSalLunch
            // 
            this.colSalLunch.Caption = "SalidaLunch";
            this.colSalLunch.FieldName = "SalLunch";
            this.colSalLunch.Name = "colSalLunch";
            this.colSalLunch.Visible = true;
            this.colSalLunch.VisibleIndex = 11;
            this.colSalLunch.Width = 79;
            // 
            // colRegLunch
            // 
            this.colRegLunch.Caption = "RegresoLunch";
            this.colRegLunch.FieldName = "RegLunch";
            this.colRegLunch.Name = "colRegLunch";
            this.colRegLunch.Visible = true;
            this.colRegLunch.VisibleIndex = 10;
            this.colRegLunch.Width = 79;
            // 
            // colMin_Almuerzo
            // 
            this.colMin_Almuerzo.Caption = "MinutosLunch";
            this.colMin_Almuerzo.FieldName = "Min_Almuerzo";
            this.colMin_Almuerzo.Name = "colMin_Almuerzo";
            this.colMin_Almuerzo.Visible = true;
            this.colMin_Almuerzo.VisibleIndex = 12;
            this.colMin_Almuerzo.Width = 81;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 13;
            this.colEstado.Width = 63;
            // 
            // roTurnoInfoBindingSource
            // 
            this.roTurnoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Horario_Info);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 343);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1058, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 96);
            this.panel1.TabIndex = 3;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 8, 14, 9, 55, 8, 166);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 10, 14, 9, 55, 8, 166);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1058, 97);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlCons);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 247);
            this.panel2.TabIndex = 4;
            // 
            // ColMotiAnula
            // 
            this.ColMotiAnula.Caption = "Motivo Anulacion";
            this.ColMotiAnula.FieldName = "MotiAnula";
            this.ColMotiAnula.Name = "ColMotiAnula";
            // 
            // frmRo_Horario_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 365);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmRo_Horario_Cons";
            this.Text = "Consulta de Horarios";
            this.Load += new System.EventHandler(this.frmRo_Turno_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roHorarioInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roTurnoInfoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCons;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCons;
        private System.Windows.Forms.BindingSource roTurnoInfoBindingSource;
        private System.Windows.Forms.BindingSource roHorarioInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFinalEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colFinalSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraFin;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraIni;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHorario;
        private DevExpress.XtraGrid.Columns.GridColumn colInicioEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colInicioSal;
        private DevExpress.XtraGrid.Columns.GridColumn colMin_Almuerzo;
        private DevExpress.XtraGrid.Columns.GridColumn colToleranciaEnt;
        private DevExpress.XtraGrid.Columns.GridColumn colToleranciaSal;
        private DevExpress.XtraGrid.Columns.GridColumn colSalLunch;
        private DevExpress.XtraGrid.Columns.GridColumn colRegLunch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn ColMotiAnula;
    }
}