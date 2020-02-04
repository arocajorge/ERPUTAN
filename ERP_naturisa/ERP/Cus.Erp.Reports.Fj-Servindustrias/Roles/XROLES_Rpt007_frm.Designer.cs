namespace Cus.Erp.Reports.FJ.Roles
{
    partial class XROLES_Rpt007_frm
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
            this.ucRo_Menu = new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grid_control = new DevExpress.XtraGrid.GridControl();
            this.grid_view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_zo_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_em_fecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_pe_FechaIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_ca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_pe_cedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_nombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_SUELDOACTUAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_DIAS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Falta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_VACACIONES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_PERMISO_IESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_DIA_TRABAJADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_DIAS_EFECTIVOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_SUELDO_X_DIAS_TRABAJADOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_HORAS_25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_HORAS_50 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_HORAS_100 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_TOTAL_SOBRETIEMPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_TRANSPORTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_ALIMENTACION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_BONIFICACIÓN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_TOTAL_INGRESO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_T_MAS_BENEFICIOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_TOTAL_MO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_fu_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbIcono = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // ucRo_Menu
            // 
            this.ucRo_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucRo_Menu.EnableBotonImprimir = true;
            this.ucRo_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucRo_Menu.Name = "ucRo_Menu";
            this.ucRo_Menu.Size = new System.Drawing.Size(1148, 74);
            this.ucRo_Menu.TabIndex = 146;
            this.ucRo_Menu.VisibleCmbCentroCosto = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleCmbDivision = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleCmbEmpleado = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleCmbNominaTipo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu.VisibleCmbNominaTipoLiqui = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu.VisibleCmbPeriodo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu.VisibleCmbRubro = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleGrupoFecha = false;
            this.ucRo_Menu.VisibleGrupoFiltro1 = true;
            this.ucRo_Menu.VisibleGrupoFiltro2 = false;
            this.ucRo_Menu.event_cmdCargar_ItemClick += new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes.delegate_cmdCargar_ItemClick(this.ucRo_Menu_event_cmdCargar_ItemClick);
            this.ucRo_Menu.event_btnsalir_ItemClick += new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes.delegate_btnsalir_ItemClick(this.ucRo_Menu_event_btnsalir_ItemClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.grid_control);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 74);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1148, 357);
            this.panelControl1.TabIndex = 147;
            // 
            // grid_control
            // 
            this.grid_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_control.Location = new System.Drawing.Point(2, 2);
            this.grid_control.MainView = this.grid_view;
            this.grid_control.Name = "grid_control";
            this.grid_control.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbIcono});
            this.grid_control.Size = new System.Drawing.Size(1144, 353);
            this.grid_control.TabIndex = 17;
            this.grid_control.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid_view});
            this.grid_control.Click += new System.EventHandler(this.grid_control_Click);
            // 
            // grid_view
            // 
            this.grid_view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_zo_descripcion,
            this.cOL_em_fecha_ingreso,
            this.cOL_pe_FechaIni,
            this.cOL_ca_descripcion,
            this.cOL_pe_cedulaRuc,
            this.Col_pe_nombres,
            this.Col_Cargo,
            this.Col_SUELDOACTUAL,
            this.Col_DIAS,
            this.Col_Falta,
            this.Col_VACACIONES,
            this.Col_PERMISO_IESS,
            this.cOL_DIA_TRABAJADO,
            this.Col_DIAS_EFECTIVOS,
            this.Col_SUELDO_X_DIAS_TRABAJADOS,
            this.cOL_HORAS_25,
            this.cOL_HORAS_50,
            this.cOL_HORAS_100,
            this.cOL_TOTAL_SOBRETIEMPO,
            this.cOL_TRANSPORTE,
            this.cOL_ALIMENTACION,
            this.cOL_BONIFICACIÓN,
            this.cOL_TOTAL_INGRESO,
            this.cOL_T_MAS_BENEFICIOS,
            this.cOL_TOTAL_MO,
            this.Col_fu_descripcion});
            this.grid_view.CustomizationFormBounds = new System.Drawing.Rectangle(597, 431, 210, 172);
            this.grid_view.GridControl = this.grid_control;
            this.grid_view.GroupCount = 1;
            this.grid_view.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_MO", this.Col_fu_descripcion, "")});
            this.grid_view.Name = "grid_view";
            this.grid_view.OptionsBehavior.AutoExpandAllGroups = true;
            this.grid_view.OptionsBehavior.Editable = false;
            this.grid_view.OptionsBehavior.ReadOnly = true;
            this.grid_view.OptionsPrint.PrintHorzLines = false;
            this.grid_view.OptionsPrint.PrintVertLines = false;
            this.grid_view.OptionsView.ColumnAutoWidth = false;
            this.grid_view.OptionsView.ShowFooter = true;
            this.grid_view.OptionsView.ShowGroupedColumns = true;
            this.grid_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.grid_view.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.grid_view.OptionsView.ShowViewCaption = true;
            this.grid_view.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Col_fu_descripcion, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // Col_zo_descripcion
            // 
            this.Col_zo_descripcion.Caption = "SECTOR";
            this.Col_zo_descripcion.FieldName = "zo_descripcion";
            this.Col_zo_descripcion.Name = "Col_zo_descripcion";
            this.Col_zo_descripcion.Visible = true;
            this.Col_zo_descripcion.VisibleIndex = 1;
            this.Col_zo_descripcion.Width = 64;
            // 
            // cOL_em_fecha_ingreso
            // 
            this.cOL_em_fecha_ingreso.Caption = "FECHA DE INGRESO";
            this.cOL_em_fecha_ingreso.FieldName = "em_fecha_ingreso";
            this.cOL_em_fecha_ingreso.Name = "cOL_em_fecha_ingreso";
            this.cOL_em_fecha_ingreso.Visible = true;
            this.cOL_em_fecha_ingreso.VisibleIndex = 2;
            this.cOL_em_fecha_ingreso.Width = 106;
            // 
            // cOL_pe_FechaIni
            // 
            this.cOL_pe_FechaIni.Caption = "FECHA MES";
            this.cOL_pe_FechaIni.FieldName = "pe_FechaIni";
            this.cOL_pe_FechaIni.Name = "cOL_pe_FechaIni";
            this.cOL_pe_FechaIni.Visible = true;
            this.cOL_pe_FechaIni.VisibleIndex = 3;
            this.cOL_pe_FechaIni.Width = 78;
            // 
            // cOL_ca_descripcion
            // 
            this.cOL_ca_descripcion.Caption = "FECHA SALIDA";
            this.cOL_ca_descripcion.FieldName = "ca_descripcion";
            this.cOL_ca_descripcion.Name = "cOL_ca_descripcion";
            this.cOL_ca_descripcion.Visible = true;
            this.cOL_ca_descripcion.VisibleIndex = 4;
            this.cOL_ca_descripcion.Width = 55;
            // 
            // cOL_pe_cedulaRuc
            // 
            this.cOL_pe_cedulaRuc.Caption = "CEDULA";
            this.cOL_pe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.cOL_pe_cedulaRuc.Name = "cOL_pe_cedulaRuc";
            this.cOL_pe_cedulaRuc.Visible = true;
            this.cOL_pe_cedulaRuc.VisibleIndex = 5;
            this.cOL_pe_cedulaRuc.Width = 64;
            // 
            // Col_pe_nombres
            // 
            this.Col_pe_nombres.Caption = "APELLIDOS Y NOMBRES";
            this.Col_pe_nombres.FieldName = "pe_nombre";
            this.Col_pe_nombres.Name = "Col_pe_nombres";
            this.Col_pe_nombres.Visible = true;
            this.Col_pe_nombres.VisibleIndex = 6;
            this.Col_pe_nombres.Width = 189;
            // 
            // Col_Cargo
            // 
            this.Col_Cargo.Caption = "CARGO";
            this.Col_Cargo.FieldName = "Cargo";
            this.Col_Cargo.Name = "Col_Cargo";
            this.Col_Cargo.Visible = true;
            this.Col_Cargo.VisibleIndex = 7;
            this.Col_Cargo.Width = 82;
            // 
            // Col_SUELDOACTUAL
            // 
            this.Col_SUELDOACTUAL.Caption = "SUELDO";
            this.Col_SUELDOACTUAL.FieldName = "SUELDOACTUAL";
            this.Col_SUELDOACTUAL.Name = "Col_SUELDOACTUAL";
            this.Col_SUELDOACTUAL.Visible = true;
            this.Col_SUELDOACTUAL.VisibleIndex = 8;
            this.Col_SUELDOACTUAL.Width = 68;
            // 
            // Col_DIAS
            // 
            this.Col_DIAS.Caption = "DIAS";
            this.Col_DIAS.FieldName = "DIAS";
            this.Col_DIAS.Name = "Col_DIAS";
            this.Col_DIAS.Visible = true;
            this.Col_DIAS.VisibleIndex = 9;
            this.Col_DIAS.Width = 52;
            // 
            // Col_Falta
            // 
            this.Col_Falta.Caption = "FALTAS";
            this.Col_Falta.FieldName = "Falta";
            this.Col_Falta.Name = "Col_Falta";
            this.Col_Falta.Visible = true;
            this.Col_Falta.VisibleIndex = 10;
            this.Col_Falta.Width = 77;
            // 
            // Col_VACACIONES
            // 
            this.Col_VACACIONES.Caption = "VACACIONES";
            this.Col_VACACIONES.FieldName = "VACACIONES";
            this.Col_VACACIONES.Name = "Col_VACACIONES";
            this.Col_VACACIONES.Visible = true;
            this.Col_VACACIONES.VisibleIndex = 11;
            this.Col_VACACIONES.Width = 82;
            // 
            // Col_PERMISO_IESS
            // 
            this.Col_PERMISO_IESS.Caption = "PERMISO IESS";
            this.Col_PERMISO_IESS.FieldName = "PERMISO_IESS";
            this.Col_PERMISO_IESS.Name = "Col_PERMISO_IESS";
            this.Col_PERMISO_IESS.Visible = true;
            this.Col_PERMISO_IESS.VisibleIndex = 12;
            this.Col_PERMISO_IESS.Width = 92;
            // 
            // cOL_DIA_TRABAJADO
            // 
            this.cOL_DIA_TRABAJADO.Caption = "DIA TRABAJADO";
            this.cOL_DIA_TRABAJADO.FieldName = "DIA_TRABAJADO";
            this.cOL_DIA_TRABAJADO.Name = "cOL_DIA_TRABAJADO";
            this.cOL_DIA_TRABAJADO.Visible = true;
            this.cOL_DIA_TRABAJADO.VisibleIndex = 13;
            this.cOL_DIA_TRABAJADO.Width = 112;
            // 
            // Col_DIAS_EFECTIVOS
            // 
            this.Col_DIAS_EFECTIVOS.Caption = "DIAS EFECTIVOS";
            this.Col_DIAS_EFECTIVOS.FieldName = "DIAS_EFECTIVOS";
            this.Col_DIAS_EFECTIVOS.Name = "Col_DIAS_EFECTIVOS";
            this.Col_DIAS_EFECTIVOS.Visible = true;
            this.Col_DIAS_EFECTIVOS.VisibleIndex = 14;
            this.Col_DIAS_EFECTIVOS.Width = 101;
            // 
            // Col_SUELDO_X_DIAS_TRABAJADOS
            // 
            this.Col_SUELDO_X_DIAS_TRABAJADOS.Caption = "SUELDO POR DIAS TRABAJADOS";
            this.Col_SUELDO_X_DIAS_TRABAJADOS.FieldName = "SUELDO_X_DIAS_TRABAJADOS";
            this.Col_SUELDO_X_DIAS_TRABAJADOS.Name = "Col_SUELDO_X_DIAS_TRABAJADOS";
            this.Col_SUELDO_X_DIAS_TRABAJADOS.Visible = true;
            this.Col_SUELDO_X_DIAS_TRABAJADOS.VisibleIndex = 15;
            this.Col_SUELDO_X_DIAS_TRABAJADOS.Width = 171;
            // 
            // cOL_HORAS_25
            // 
            this.cOL_HORAS_25.Caption = "HORAS 25%";
            this.cOL_HORAS_25.FieldName = "HORAS_25";
            this.cOL_HORAS_25.Name = "cOL_HORAS_25";
            this.cOL_HORAS_25.Visible = true;
            this.cOL_HORAS_25.VisibleIndex = 16;
            this.cOL_HORAS_25.Width = 74;
            // 
            // cOL_HORAS_50
            // 
            this.cOL_HORAS_50.Caption = "HORAS 50%";
            this.cOL_HORAS_50.FieldName = "HORAS_50";
            this.cOL_HORAS_50.Name = "cOL_HORAS_50";
            this.cOL_HORAS_50.Visible = true;
            this.cOL_HORAS_50.VisibleIndex = 17;
            this.cOL_HORAS_50.Width = 76;
            // 
            // cOL_HORAS_100
            // 
            this.cOL_HORAS_100.Caption = "HORAS 100%";
            this.cOL_HORAS_100.FieldName = "HORAS_100";
            this.cOL_HORAS_100.Name = "cOL_HORAS_100";
            this.cOL_HORAS_100.Visible = true;
            this.cOL_HORAS_100.VisibleIndex = 18;
            this.cOL_HORAS_100.Width = 77;
            // 
            // cOL_TOTAL_SOBRETIEMPO
            // 
            this.cOL_TOTAL_SOBRETIEMPO.Caption = "TOTAL SOBRETIEMPO";
            this.cOL_TOTAL_SOBRETIEMPO.FieldName = "TOTAL_SOBRETIEMPO";
            this.cOL_TOTAL_SOBRETIEMPO.Name = "cOL_TOTAL_SOBRETIEMPO";
            this.cOL_TOTAL_SOBRETIEMPO.Visible = true;
            this.cOL_TOTAL_SOBRETIEMPO.VisibleIndex = 19;
            this.cOL_TOTAL_SOBRETIEMPO.Width = 123;
            // 
            // cOL_TRANSPORTE
            // 
            this.cOL_TRANSPORTE.Caption = "TRANSPORTE";
            this.cOL_TRANSPORTE.FieldName = "TRANSPORTE";
            this.cOL_TRANSPORTE.Name = "cOL_TRANSPORTE";
            this.cOL_TRANSPORTE.Visible = true;
            this.cOL_TRANSPORTE.VisibleIndex = 20;
            this.cOL_TRANSPORTE.Width = 81;
            // 
            // cOL_ALIMENTACION
            // 
            this.cOL_ALIMENTACION.Caption = "ALIMENTACION";
            this.cOL_ALIMENTACION.FieldName = "ALIMENTACION";
            this.cOL_ALIMENTACION.Name = "cOL_ALIMENTACION";
            this.cOL_ALIMENTACION.Visible = true;
            this.cOL_ALIMENTACION.VisibleIndex = 21;
            this.cOL_ALIMENTACION.Width = 88;
            // 
            // cOL_BONIFICACIÓN
            // 
            this.cOL_BONIFICACIÓN.Caption = "BONIFICACIÓN";
            this.cOL_BONIFICACIÓN.FieldName = "BONIFICACIÓN";
            this.cOL_BONIFICACIÓN.Name = "cOL_BONIFICACIÓN";
            this.cOL_BONIFICACIÓN.Visible = true;
            this.cOL_BONIFICACIÓN.VisibleIndex = 22;
            this.cOL_BONIFICACIÓN.Width = 84;
            // 
            // cOL_TOTAL_INGRESO
            // 
            this.cOL_TOTAL_INGRESO.Caption = "TOTAL INGRESO";
            this.cOL_TOTAL_INGRESO.FieldName = "tot_ingreso";
            this.cOL_TOTAL_INGRESO.Name = "cOL_TOTAL_INGRESO";
            this.cOL_TOTAL_INGRESO.Visible = true;
            this.cOL_TOTAL_INGRESO.VisibleIndex = 23;
            this.cOL_TOTAL_INGRESO.Width = 116;
            // 
            // cOL_T_MAS_BENEFICIOS
            // 
            this.cOL_T_MAS_BENEFICIOS.Caption = "T+ BENEFICIOS";
            this.cOL_T_MAS_BENEFICIOS.FieldName = "T_MAS_BENEFICIOS";
            this.cOL_T_MAS_BENEFICIOS.Name = "cOL_T_MAS_BENEFICIOS";
            this.cOL_T_MAS_BENEFICIOS.Visible = true;
            this.cOL_T_MAS_BENEFICIOS.VisibleIndex = 24;
            this.cOL_T_MAS_BENEFICIOS.Width = 89;
            // 
            // cOL_TOTAL_MO
            // 
            this.cOL_TOTAL_MO.Caption = "TOTAL M/O";
            this.cOL_TOTAL_MO.FieldName = "TOTAL_MO";
            this.cOL_TOTAL_MO.Name = "cOL_TOTAL_MO";
            this.cOL_TOTAL_MO.Visible = true;
            this.cOL_TOTAL_MO.VisibleIndex = 25;
            this.cOL_TOTAL_MO.Width = 72;
            // 
            // Col_fu_descripcion
            // 
            this.Col_fu_descripcion.Caption = "FUERZA";
            this.Col_fu_descripcion.FieldName = "fu_descripcion";
            this.Col_fu_descripcion.Name = "Col_fu_descripcion";
            this.Col_fu_descripcion.Visible = true;
            this.Col_fu_descripcion.VisibleIndex = 0;
            // 
            // cmbIcono
            // 
            this.cmbIcono.AutoHeight = false;
            this.cmbIcono.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIcono.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "S", 0)});
            this.cmbIcono.Name = "cmbIcono";
            // 
            // XROLES_Rpt007_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 431);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucRo_Menu);
            this.Name = "XROLES_Rpt007_frm";
            this.Text = "XROLES_Rpt006_frm";
            this.Load += new System.EventHandler(this.XROLES_Rpt007_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Core.Erp.Reportes.Controles.UCRo_Menu_Reportes ucRo_Menu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grid_control;
        private DevExpress.XtraGrid.Views.Grid.GridView grid_view;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbIcono;
        private DevExpress.XtraGrid.Columns.GridColumn Col_zo_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_em_fecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_pe_FechaIni;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_ca_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_pe_cedulaRuc;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_nombres;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Cargo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_SUELDOACTUAL;
        private DevExpress.XtraGrid.Columns.GridColumn Col_DIAS;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Falta;
        private DevExpress.XtraGrid.Columns.GridColumn Col_VACACIONES;
        private DevExpress.XtraGrid.Columns.GridColumn Col_PERMISO_IESS;
        private DevExpress.XtraGrid.Columns.GridColumn Col_DIAS_EFECTIVOS;
        private DevExpress.XtraGrid.Columns.GridColumn Col_SUELDO_X_DIAS_TRABAJADOS;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_HORAS_25;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_HORAS_50;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_HORAS_100;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_TRANSPORTE;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_ALIMENTACION;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_BONIFICACIÓN;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_TOTAL_SOBRETIEMPO;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_T_MAS_BENEFICIOS;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_TOTAL_MO;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_TOTAL_INGRESO;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_DIA_TRABAJADO;
        private DevExpress.XtraGrid.Columns.GridColumn Col_fu_descripcion;



    }
}