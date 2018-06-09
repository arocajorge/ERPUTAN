namespace Core.Erp.Winform.Roles
{
    partial class frmRo_calculo_vacacionesActafiniquito
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
            this.roEmpleadoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.rohistoricovacacionesxempleadoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roCatalogoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridVacaciones = new DevExpress.XtraGrid.GridControl();
            this.viewVacaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasGanados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasTomados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasPendientes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Remuneracion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_vacaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rohistoricovacacionesxempleadoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roCatalogoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVacaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewVacaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roEmpleadoInfoBindingSource
            // 
            this.roEmpleadoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Empleado_Info);
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = false;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpLote = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(717, 29);
            this.ucGe_Menu.TabIndex = 47;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            // 
            // rohistoricovacacionesxempleadoInfoBindingSource
            // 
            this.rohistoricovacacionesxempleadoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_historico_vacaciones_x_empleado_Info);
            // 
            // roCatalogoInfoBindingSource
            // 
            this.roCatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Catalogo_Info);
            // 
            // gridVacaciones
            // 
            this.gridVacaciones.DataSource = this.rohistoricovacacionesxempleadoInfoBindingSource;
            this.gridVacaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVacaciones.Location = new System.Drawing.Point(2, 21);
            this.gridVacaciones.MainView = this.viewVacaciones;
            this.gridVacaciones.Name = "gridVacaciones";
            this.gridVacaciones.Size = new System.Drawing.Size(713, 299);
            this.gridVacaciones.TabIndex = 52;
            this.gridVacaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewVacaciones,
            this.gridView1});
            // 
            // viewVacaciones
            // 
            this.viewVacaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFechaInicio,
            this.colFechaFin,
            this.colDiasGanados,
            this.colDiasTomados,
            this.colDiasPendientes,
            this.Col_Remuneracion,
            this.Col_vacaciones});
            this.viewVacaciones.GridControl = this.gridVacaciones;
            this.viewVacaciones.Name = "viewVacaciones";
            this.viewVacaciones.OptionsView.ShowGroupPanel = false;
            this.viewVacaciones.OptionsView.ShowIndicator = false;
            this.viewVacaciones.OptionsView.ShowViewCaption = true;
            this.viewVacaciones.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFechaInicio, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.viewVacaciones.ViewCaption = "Histórico de Vacaciones";
            this.viewVacaciones.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.viewVacaciones_CellValueChanged);
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.FieldName = "FechaInicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.OptionsColumn.AllowEdit = false;
            this.colFechaInicio.Visible = true;
            this.colFechaInicio.VisibleIndex = 0;
            this.colFechaInicio.Width = 95;
            // 
            // colFechaFin
            // 
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.OptionsColumn.AllowEdit = false;
            this.colFechaFin.Visible = true;
            this.colFechaFin.VisibleIndex = 1;
            this.colFechaFin.Width = 148;
            // 
            // colDiasGanados
            // 
            this.colDiasGanados.Caption = "Ganados";
            this.colDiasGanados.FieldName = "DiasGanados";
            this.colDiasGanados.Name = "colDiasGanados";
            this.colDiasGanados.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colDiasGanados.Visible = true;
            this.colDiasGanados.VisibleIndex = 2;
            this.colDiasGanados.Width = 112;
            // 
            // colDiasTomados
            // 
            this.colDiasTomados.Caption = "Tomados";
            this.colDiasTomados.FieldName = "DiasTomados";
            this.colDiasTomados.Name = "colDiasTomados";
            this.colDiasTomados.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colDiasTomados.Visible = true;
            this.colDiasTomados.VisibleIndex = 3;
            this.colDiasTomados.Width = 90;
            // 
            // colDiasPendientes
            // 
            this.colDiasPendientes.Caption = "Pendientes";
            this.colDiasPendientes.FieldName = "DiasPendientes";
            this.colDiasPendientes.Name = "colDiasPendientes";
            this.colDiasPendientes.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colDiasPendientes.Visible = true;
            this.colDiasPendientes.VisibleIndex = 4;
            this.colDiasPendientes.Width = 76;
            // 
            // Col_Remuneracion
            // 
            this.Col_Remuneracion.Caption = "Remuneracion anual";
            this.Col_Remuneracion.FieldName = "RemuneracionAnual";
            this.Col_Remuneracion.Name = "Col_Remuneracion";
            this.Col_Remuneracion.Visible = true;
            this.Col_Remuneracion.VisibleIndex = 5;
            this.Col_Remuneracion.Width = 152;
            // 
            // Col_vacaciones
            // 
            this.Col_vacaciones.Caption = "Vacaciones";
            this.Col_vacaciones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_vacaciones.FieldName = "Vacaciones";
            this.Col_vacaciones.Name = "Col_vacaciones";
            this.Col_vacaciones.Visible = true;
            this.Col_vacaciones.VisibleIndex = 6;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFechaInicio,
            this.colFechaFin,
            this.colDiasGanados,
            this.colDiasTomados,
            this.colDiasPendientes,
            this.colcheck,
            this.colIdEmpresa,
            this.colIdEmpleado});
            this.gridView1.GridControl = this.gridVacaciones;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFechaInicio, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colcheck
            // 
            this.colcheck.FieldName = "check";
            this.colcheck.Name = "colcheck";
            this.colcheck.Visible = true;
            this.colcheck.VisibleIndex = 5;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 6;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 7;
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.groupControl1.Controls.Add(this.gridVacaciones);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(717, 322);
            this.groupControl1.TabIndex = 60;
            this.groupControl1.Text = "Vacaciones pendientes";
            // 
            // frmRo_calculo_vacacionesActafiniquito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 351);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRo_calculo_vacacionesActafiniquito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transacción - Solicitud de Vacaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRo_Solicitud_Vacaciones_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmRo_Solicitud_Vacaciones_Mant_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_Solicitud_Vacaciones_Mant_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rohistoricovacacionesxempleadoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roCatalogoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVacaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewVacaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource roEmpleadoInfoBindingSource;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.BindingSource roCatalogoInfoBindingSource;
        private System.Windows.Forms.BindingSource rohistoricovacacionesxempleadoInfoBindingSource;
        private DevExpress.XtraGrid.GridControl gridVacaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView viewVacaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasGanados;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasTomados;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasPendientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Remuneracion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_vacaciones;
    }
}