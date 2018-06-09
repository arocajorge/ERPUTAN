namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_AsignarGT_P_Consulta
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
            this.GridetapasGrupos = new DevExpress.XtraGrid.GridControl();
            this.gridViewEtapasGrupos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColProcesoProductivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEtapa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridetapasGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEtapasGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.CargarTodasBodegas = false;
            this.ucGe_Menu.CargarTodasSucursales = true;
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
            this.ucGe_Menu.Enable_boton_periodo = false;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2016, 12, 31, 15, 56, 43, 121);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 2, 28, 15, 56, 43, 121);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(772, 88);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GridetapasGrupos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 299);
            this.panel1.TabIndex = 2;
            // 
            // GridetapasGrupos
            // 
            this.GridetapasGrupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridetapasGrupos.Location = new System.Drawing.Point(0, 0);
            this.GridetapasGrupos.MainView = this.gridViewEtapasGrupos;
            this.GridetapasGrupos.Name = "GridetapasGrupos";
            this.GridetapasGrupos.Size = new System.Drawing.Size(772, 299);
            this.GridetapasGrupos.TabIndex = 0;
            this.GridetapasGrupos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEtapasGrupos});
            this.GridetapasGrupos.Click += new System.EventHandler(this.GridetapasGrupos_Click);
            // 
            // gridViewEtapasGrupos
            // 
            this.gridViewEtapasGrupos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColProcesoProductivo,
            this.ColEtapa});
            this.gridViewEtapasGrupos.GridControl = this.GridetapasGrupos;
            this.gridViewEtapasGrupos.Name = "gridViewEtapasGrupos";
            this.gridViewEtapasGrupos.OptionsBehavior.Editable = false;
            this.gridViewEtapasGrupos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewEtapasGrupos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewEtapasGrupos_RowClick);
            //this.gridViewEtapasGrupos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewEtapasGrupos_RowCellClick);
            //this.gridViewEtapasGrupos.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewEtapasGrupos_CellValueChanging);
            // 
            // ColProcesoProductivo
            // 
            this.ColProcesoProductivo.Caption = "Proceso productivo";
            this.ColProcesoProductivo.FieldName = "ProcesoProductivo";
            this.ColProcesoProductivo.Name = "ColProcesoProductivo";
            this.ColProcesoProductivo.Visible = true;
            this.ColProcesoProductivo.VisibleIndex = 0;
            this.ColProcesoProductivo.Width = 407;
            // 
            // ColEtapa
            // 
            this.ColEtapa.Caption = "Etapas";
            this.ColEtapa.FieldName = "NombreEtapa";
            this.ColEtapa.Name = "ColEtapa";
            this.ColEtapa.Visible = true;
            this.ColEtapa.VisibleIndex = 1;
            this.ColEtapa.Width = 847;
            // 
            // FrmPrd_AsignarGT_P_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmPrd_AsignarGT_P_Consulta";
            this.Text = "Consulta Proceso Productivo por Etapa";
            this.Load += new System.EventHandler(this.FrmPrd_AsignarGT_P_Consulta_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridetapasGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEtapasGrupos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl GridetapasGrupos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEtapasGrupos;
        private DevExpress.XtraGrid.Columns.GridColumn ColProcesoProductivo;
        private DevExpress.XtraGrid.Columns.GridColumn ColEtapa;
    }
}