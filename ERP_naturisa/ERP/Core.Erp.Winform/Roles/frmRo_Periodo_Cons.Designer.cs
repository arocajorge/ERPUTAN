namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Periodo_Cons
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
            this.gridCtrlPeriodo = new DevExpress.XtraGrid.GridControl();
            this.gridViewPeriodo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFInicia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColMotivoAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPeriodo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCtrlPeriodo
            // 
            this.gridCtrlPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlPeriodo.Location = new System.Drawing.Point(0, 0);
            this.gridCtrlPeriodo.MainView = this.gridViewPeriodo;
            this.gridCtrlPeriodo.Name = "gridCtrlPeriodo";
            this.gridCtrlPeriodo.Size = new System.Drawing.Size(740, 233);
            this.gridCtrlPeriodo.TabIndex = 14;
            this.gridCtrlPeriodo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPeriodo});
            // 
            // gridViewPeriodo
            // 
            this.gridViewPeriodo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdPeriodo,
            this.ColFInicia,
            this.ColFFin,
            this.ColEstado,
            this.ColMotivoAnulacion});
            this.gridViewPeriodo.CustomizationFormBounds = new System.Drawing.Rectangle(512, 442, 216, 185);
            this.gridViewPeriodo.GridControl = this.gridCtrlPeriodo;
            this.gridViewPeriodo.Name = "gridViewPeriodo";
            this.gridViewPeriodo.OptionsBehavior.Editable = false;
            this.gridViewPeriodo.OptionsBehavior.ReadOnly = true;
            this.gridViewPeriodo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPeriodo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.ColIdPeriodo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewPeriodo.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewPeriodo_RowStyle);
            this.gridViewPeriodo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPeriodo_FocusedRowChanged);
            // 
            // ColIdPeriodo
            // 
            this.ColIdPeriodo.Caption = "IdPeriodo";
            this.ColIdPeriodo.FieldName = "IdPeriodo";
            this.ColIdPeriodo.Name = "ColIdPeriodo";
            this.ColIdPeriodo.Visible = true;
            this.ColIdPeriodo.VisibleIndex = 0;
            this.ColIdPeriodo.Width = 213;
            // 
            // ColFInicia
            // 
            this.ColFInicia.Caption = "Fecha Inicia";
            this.ColFInicia.FieldName = "pe_FechaIni";
            this.ColFInicia.Name = "ColFInicia";
            this.ColFInicia.Visible = true;
            this.ColFInicia.VisibleIndex = 1;
            this.ColFInicia.Width = 234;
            // 
            // ColFFin
            // 
            this.ColFFin.Caption = "Fecha Fin";
            this.ColFFin.FieldName = "pe_FechaFin";
            this.ColFFin.Name = "ColFFin";
            this.ColFFin.Visible = true;
            this.ColFFin.VisibleIndex = 2;
            this.ColFFin.Width = 271;
            // 
            // ColEstado
            // 
            this.ColEstado.Caption = "Estado";
            this.ColEstado.FieldName = "pe_estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.Visible = true;
            this.ColEstado.VisibleIndex = 3;
            this.ColEstado.Width = 214;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(740, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.CargarTodasBodegas = false;
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_anular = true;
            this.ucGe_Menu.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu.Enable_boton_consultar = true;
            this.ucGe_Menu.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu.Enable_boton_Duplicar = true;
            this.ucGe_Menu.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu.Enable_boton_GenerarXml = true;
            this.ucGe_Menu.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu.Enable_boton_Importar_XML = true;
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 7, 27, 16, 7, 20, 212);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2015, 9, 27, 16, 7, 20, 212);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(740, 96);
            this.ucGe_Menu.TabIndex = 16;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = false;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridCtrlPeriodo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 233);
            this.panel1.TabIndex = 17;
            // 
            // ColMotivoAnulacion
            // 
            this.ColMotivoAnulacion.Caption = "Motivo Anulacion";
            this.ColMotivoAnulacion.FieldName = "MotivoAnulacion";
            this.ColMotivoAnulacion.Name = "ColMotivoAnulacion";
            // 
            // frmRo_Periodo_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmRo_Periodo_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Periodos";
            this.Load += new System.EventHandler(this.frmRo_Periodo_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPeriodo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCtrlPeriodo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn ColFInicia;
        private DevExpress.XtraGrid.Columns.GridColumn ColFFin;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstado;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn ColMotivoAnulacion;
    }
}