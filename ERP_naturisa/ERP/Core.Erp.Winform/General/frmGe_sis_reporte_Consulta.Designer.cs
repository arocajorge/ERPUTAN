namespace Core.Erp.Winform.General
{
    partial class FrmGe_sis_reporte_Consulta
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
            this.gridControl_Report = new DevExpress.XtraGrid.GridControl();
            this.tbsisreporteInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UltraGrid_Report = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodReporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCorto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTablaRpt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormulario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClass_NomReporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.classInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.classbus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.classdata = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisreporteInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_Report)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_Report
            // 
            this.gridControl_Report.DataSource = this.tbsisreporteInfoBindingSource;
            this.gridControl_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Report.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Report.MainView = this.UltraGrid_Report;
            this.gridControl_Report.Name = "gridControl_Report";
            this.gridControl_Report.Size = new System.Drawing.Size(1256, 300);
            this.gridControl_Report.TabIndex = 9;
            this.gridControl_Report.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGrid_Report});
            // 
            // tbsisreporteInfoBindingSource
            // 
            this.tbsisreporteInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_sis_reporte_Info);
            // 
            // UltraGrid_Report
            // 
            this.UltraGrid_Report.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.UltraGrid_Report.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UltraGrid_Report.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.UltraGrid_Report.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.UltraGrid_Report.ColumnPanelRowHeight = 50;
            this.UltraGrid_Report.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodReporte,
            this.colNombre,
            this.colNombreCorto,
            this.colModulo,
            this.colTablaRpt,
            this.colFormulario,
            this.colOrden,
            this.colClass_NomReporte,
            this.colObservacion,
            this.classInfo,
            this.classbus,
            this.classdata});
            this.UltraGrid_Report.GridControl = this.gridControl_Report;
            this.UltraGrid_Report.Name = "UltraGrid_Report";
            this.UltraGrid_Report.OptionsView.AllowHtmlDrawHeaders = true;
            this.UltraGrid_Report.OptionsView.ShowAutoFilterRow = true;
            this.UltraGrid_Report.OptionsView.ShowGroupPanel = false;
            this.UltraGrid_Report.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            this.UltraGrid_Report.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.UltraGrid_Report_FocusedRowChanged);
            // 
            // colCodReporte
            // 
            this.colCodReporte.Caption = "Codigo del Reporte";
            this.colCodReporte.FieldName = "CodReporte";
            this.colCodReporte.Name = "colCodReporte";
            this.colCodReporte.OptionsColumn.AllowEdit = false;
            this.colCodReporte.Visible = true;
            this.colCodReporte.VisibleIndex = 0;
            this.colCodReporte.Width = 121;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 176;
            // 
            // colNombreCorto
            // 
            this.colNombreCorto.FieldName = "NombreCorto";
            this.colNombreCorto.Name = "colNombreCorto";
            this.colNombreCorto.OptionsColumn.AllowEdit = false;
            this.colNombreCorto.Width = 96;
            // 
            // colModulo
            // 
            this.colModulo.FieldName = "Modulo";
            this.colModulo.Name = "colModulo";
            this.colModulo.OptionsColumn.AllowEdit = false;
            this.colModulo.Visible = true;
            this.colModulo.VisibleIndex = 2;
            this.colModulo.Width = 133;
            // 
            // colTablaRpt
            // 
            this.colTablaRpt.Caption = "Vista Relacionada";
            this.colTablaRpt.FieldName = "VistaRpt";
            this.colTablaRpt.Name = "colTablaRpt";
            this.colTablaRpt.OptionsColumn.AllowEdit = false;
            this.colTablaRpt.Visible = true;
            this.colTablaRpt.VisibleIndex = 3;
            this.colTablaRpt.Width = 139;
            // 
            // colFormulario
            // 
            this.colFormulario.FieldName = "Formulario";
            this.colFormulario.Name = "colFormulario";
            this.colFormulario.OptionsColumn.AllowEdit = false;
            this.colFormulario.Visible = true;
            this.colFormulario.VisibleIndex = 4;
            this.colFormulario.Width = 116;
            // 
            // colOrden
            // 
            this.colOrden.FieldName = "Orden";
            this.colOrden.Name = "colOrden";
            this.colOrden.OptionsColumn.AllowEdit = false;
            this.colOrden.Width = 42;
            // 
            // colClass_NomReporte
            // 
            this.colClass_NomReporte.Caption = "Class Reporte";
            this.colClass_NomReporte.FieldName = "Class_NomReporte";
            this.colClass_NomReporte.Name = "colClass_NomReporte";
            this.colClass_NomReporte.OptionsColumn.AllowEdit = false;
            this.colClass_NomReporte.Visible = true;
            this.colClass_NomReporte.VisibleIndex = 5;
            this.colClass_NomReporte.Width = 114;
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observación";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.OptionsColumn.AllowEdit = false;
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 9;
            this.colObservacion.Width = 51;
            // 
            // classInfo
            // 
            this.classInfo.Caption = "Clase Info";
            this.classInfo.FieldName = "Class_Info";
            this.classInfo.Name = "classInfo";
            this.classInfo.Visible = true;
            this.classInfo.VisibleIndex = 6;
            this.classInfo.Width = 115;
            // 
            // classbus
            // 
            this.classbus.Caption = "Clase Bus";
            this.classbus.FieldName = "Class_Bus";
            this.classbus.Name = "classbus";
            this.classbus.Visible = true;
            this.classbus.VisibleIndex = 7;
            this.classbus.Width = 126;
            // 
            // classdata
            // 
            this.classdata.Caption = "Clase Data";
            this.classdata.FieldName = "Class_Data";
            this.classdata.Name = "classdata";
            this.classdata.Visible = true;
            this.classdata.VisibleIndex = 8;
            this.classdata.Width = 147;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 180);
            this.panel1.TabIndex = 10;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 2, 22, 9, 35, 20, 167);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 3, 23, 9, 35, 20, 167);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1256, 179);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 13;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl_Report);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1256, 300);
            this.panel2.TabIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1256, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmGe_sis_reporte_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 480);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGe_sis_reporte_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte Consulta";
            this.Load += new System.EventHandler(this.frmGe_sis_reporte_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisreporteInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_Report)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Report;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGrid_Report;
        private DevExpress.XtraGrid.Columns.GridColumn colCodReporte;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCorto;
        private DevExpress.XtraGrid.Columns.GridColumn colModulo;
        private DevExpress.XtraGrid.Columns.GridColumn colTablaRpt;
        private DevExpress.XtraGrid.Columns.GridColumn colFormulario;
        private DevExpress.XtraGrid.Columns.GridColumn colOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colClass_NomReporte;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private System.Windows.Forms.BindingSource tbsisreporteInfoBindingSource;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.Columns.GridColumn classInfo;
        private DevExpress.XtraGrid.Columns.GridColumn classbus;
        private DevExpress.XtraGrid.Columns.GridColumn classdata;
    }
}