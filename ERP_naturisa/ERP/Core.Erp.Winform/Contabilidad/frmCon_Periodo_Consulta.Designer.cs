namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_Periodo_Consulta
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlPeriodo = new DevExpress.XtraGrid.GridControl();
            this.gridViewPerido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdanioFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pe_mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pe_FechaIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pe_FechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pe_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCerrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPerido)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_anular = true;
            this.ucGe_Menu.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu.Enable_boton_consultar = true;
            this.ucGe_Menu.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu.Enable_boton_Duplicar = true;
            this.ucGe_Menu.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu.Enable_boton_GenerarXml = true;
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 3, 7, 14, 55, 40, 165);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2015, 5, 7, 14, 55, 40, 165);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(783, 116);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_event_btnAnular_ItemClick);
            this.ucGe_Menu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_event_btnImprimir_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlPeriodo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 231);
            this.panel1.TabIndex = 1;
            // 
            // gridControlPeriodo
            // 
            this.gridControlPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPeriodo.Location = new System.Drawing.Point(0, 0);
            this.gridControlPeriodo.MainView = this.gridViewPerido;
            this.gridControlPeriodo.Name = "gridControlPeriodo";
            this.gridControlPeriodo.Size = new System.Drawing.Size(783, 231);
            this.gridControlPeriodo.TabIndex = 5;
            this.gridControlPeriodo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPerido});
            // 
            // gridViewPerido
            // 
            this.gridViewPerido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdPeriodo,
            this.IdanioFiscal,
            this.pe_mes,
            this.pe_FechaIni,
            this.pe_FechaFin,
            this.pe_estado,
            this.colCerrado});
            this.gridViewPerido.GridControl = this.gridControlPeriodo;
            this.gridViewPerido.Name = "gridViewPerido";
            this.gridViewPerido.OptionsBehavior.Editable = false;
            this.gridViewPerido.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPerido.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewPerido_RowClick);
            this.gridViewPerido.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewPerido_RowCellStyle);
            // 
            // IdPeriodo
            // 
            this.IdPeriodo.Caption = "Id Periodo";
            this.IdPeriodo.FieldName = "IdPeriodo";
            this.IdPeriodo.Name = "IdPeriodo";
            this.IdPeriodo.Visible = true;
            this.IdPeriodo.VisibleIndex = 0;
            this.IdPeriodo.Width = 102;
            // 
            // IdanioFiscal
            // 
            this.IdanioFiscal.Caption = "Año Fiscal ";
            this.IdanioFiscal.FieldName = "IdanioFiscal";
            this.IdanioFiscal.Name = "IdanioFiscal";
            this.IdanioFiscal.Visible = true;
            this.IdanioFiscal.VisibleIndex = 1;
            this.IdanioFiscal.Width = 94;
            // 
            // pe_mes
            // 
            this.pe_mes.Caption = "Mes";
            this.pe_mes.FieldName = "pe_mes";
            this.pe_mes.Name = "pe_mes";
            this.pe_mes.Visible = true;
            this.pe_mes.VisibleIndex = 2;
            this.pe_mes.Width = 82;
            // 
            // pe_FechaIni
            // 
            this.pe_FechaIni.Caption = "Fecha Inicio";
            this.pe_FechaIni.FieldName = "pe_FechaIni";
            this.pe_FechaIni.Name = "pe_FechaIni";
            this.pe_FechaIni.Visible = true;
            this.pe_FechaIni.VisibleIndex = 3;
            this.pe_FechaIni.Width = 94;
            // 
            // pe_FechaFin
            // 
            this.pe_FechaFin.Caption = "Fecha Fin";
            this.pe_FechaFin.FieldName = "pe_FechaFin";
            this.pe_FechaFin.Name = "pe_FechaFin";
            this.pe_FechaFin.Visible = true;
            this.pe_FechaFin.VisibleIndex = 4;
            this.pe_FechaFin.Width = 95;
            // 
            // pe_estado
            // 
            this.pe_estado.Caption = "Estado";
            this.pe_estado.FieldName = "pe_estado";
            this.pe_estado.Name = "pe_estado";
            this.pe_estado.Visible = true;
            this.pe_estado.VisibleIndex = 5;
            this.pe_estado.Width = 76;
            // 
            // colCerrado
            // 
            this.colCerrado.Caption = "Esta Cerrado";
            this.colCerrado.FieldName = "pe_cerrado";
            this.colCerrado.Name = "colCerrado";
            this.colCerrado.Visible = true;
            this.colCerrado.VisibleIndex = 6;
            this.colCerrado.Width = 142;
            // 
            // frmCon_Periodo_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCon_Periodo_Consulta";
            this.Text = "CONSULTA PERIODO";
            this.Load += new System.EventHandler(this.frmCon_Periodo_Consulta_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPerido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlPeriodo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPerido;
        private DevExpress.XtraGrid.Columns.GridColumn IdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn IdanioFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn pe_mes;
        private DevExpress.XtraGrid.Columns.GridColumn pe_FechaIni;
        private DevExpress.XtraGrid.Columns.GridColumn pe_FechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn pe_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colCerrado;
    }
}