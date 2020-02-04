namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_GeneracionFile_Banco_x_cxp_Cons
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl_General = new DevExpress.XtraEditors.PanelControl();
            this.panelControlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridControlArchivos = new DevExpress.XtraGrid.GridControl();
            this.gridViewArchivos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdArchivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNom_Archivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colnom_EstadoArchivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescargarFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDescargarFile = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_General)).BeginInit();
            this.panelControl_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGrid)).BeginInit();
            this.panelControlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlArchivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewArchivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargarFile)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl_General
            // 
            this.panelControl_General.Controls.Add(this.panelControlGrid);
            this.panelControl_General.Controls.Add(this.ucGe_Menu);
            this.panelControl_General.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_General.Location = new System.Drawing.Point(0, 0);
            this.panelControl_General.Name = "panelControl_General";
            this.panelControl_General.Size = new System.Drawing.Size(1087, 511);
            this.panelControl_General.TabIndex = 0;
            // 
            // panelControlGrid
            // 
            this.panelControlGrid.Controls.Add(this.gridControlArchivos);
            this.panelControlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlGrid.Location = new System.Drawing.Point(2, 157);
            this.panelControlGrid.Name = "panelControlGrid";
            this.panelControlGrid.Size = new System.Drawing.Size(1083, 352);
            this.panelControlGrid.TabIndex = 3;
            // 
            // gridControlArchivos
            // 
            this.gridControlArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlArchivos.Location = new System.Drawing.Point(2, 2);
            this.gridControlArchivos.MainView = this.gridViewArchivos;
            this.gridControlArchivos.Name = "gridControlArchivos";
            this.gridControlArchivos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDescargarFile});
            this.gridControlArchivos.Size = new System.Drawing.Size(1079, 348);
            this.gridControlArchivos.TabIndex = 0;
            this.gridControlArchivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewArchivos});
            // 
            // gridViewArchivos
            // 
            this.gridViewArchivos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdArchivo,
            this.ColNom_Archivo,
            this.Colobservacion,
            this.ColTipo,
            this.ColFecha_Transac,
            this.Colnom_EstadoArchivo,
            this.ColDescargarFile});
            this.gridViewArchivos.GridControl = this.gridControlArchivos;
            this.gridViewArchivos.Name = "gridViewArchivos";
            this.gridViewArchivos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewArchivos.OptionsView.ShowGroupPanel = false;
            this.gridViewArchivos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewArchivos_RowClick);
            this.gridViewArchivos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewArchivos_RowCellClick);
            this.gridViewArchivos.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewArchivos_RowCellStyle);
            // 
            // colIdArchivo
            // 
            this.colIdArchivo.Caption = "Cod. Archivo";
            this.colIdArchivo.FieldName = "cod_archivo";
            this.colIdArchivo.Name = "colIdArchivo";
            this.colIdArchivo.OptionsColumn.AllowEdit = false;
            this.colIdArchivo.OptionsColumn.ReadOnly = true;
            this.colIdArchivo.Visible = true;
            this.colIdArchivo.VisibleIndex = 0;
            this.colIdArchivo.Width = 108;
            // 
            // ColNom_Archivo
            // 
            this.ColNom_Archivo.Caption = "Nombre archivo";
            this.ColNom_Archivo.FieldName = "Nom_Archivo";
            this.ColNom_Archivo.Name = "ColNom_Archivo";
            this.ColNom_Archivo.OptionsColumn.AllowEdit = false;
            this.ColNom_Archivo.OptionsColumn.ReadOnly = true;
            this.ColNom_Archivo.Visible = true;
            this.ColNom_Archivo.VisibleIndex = 1;
            this.ColNom_Archivo.Width = 157;
            // 
            // Colobservacion
            // 
            this.Colobservacion.Caption = "Observacion";
            this.Colobservacion.FieldName = "Observacion";
            this.Colobservacion.Name = "Colobservacion";
            this.Colobservacion.OptionsColumn.AllowEdit = false;
            this.Colobservacion.OptionsColumn.ReadOnly = true;
            this.Colobservacion.Visible = true;
            this.Colobservacion.VisibleIndex = 2;
            this.Colobservacion.Width = 157;
            // 
            // ColTipo
            // 
            this.ColTipo.Caption = "Proceso";
            this.ColTipo.FieldName = "nom_proceso_bancario";
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.OptionsColumn.AllowEdit = false;
            this.ColTipo.OptionsColumn.ReadOnly = true;
            this.ColTipo.Visible = true;
            this.ColTipo.VisibleIndex = 3;
            this.ColTipo.Width = 157;
            // 
            // ColFecha_Transac
            // 
            this.ColFecha_Transac.Caption = "Fecha Pago";
            this.ColFecha_Transac.FieldName = "Fecha";
            this.ColFecha_Transac.Name = "ColFecha_Transac";
            this.ColFecha_Transac.OptionsColumn.AllowEdit = false;
            this.ColFecha_Transac.OptionsColumn.ReadOnly = true;
            this.ColFecha_Transac.Visible = true;
            this.ColFecha_Transac.VisibleIndex = 4;
            this.ColFecha_Transac.Width = 81;
            // 
            // Colnom_EstadoArchivo
            // 
            this.Colnom_EstadoArchivo.Caption = "Estado Archivo";
            this.Colnom_EstadoArchivo.FieldName = "nom_EstadoArchivo";
            this.Colnom_EstadoArchivo.Name = "Colnom_EstadoArchivo";
            this.Colnom_EstadoArchivo.OptionsColumn.ReadOnly = true;
            this.Colnom_EstadoArchivo.Visible = true;
            this.Colnom_EstadoArchivo.VisibleIndex = 5;
            this.Colnom_EstadoArchivo.Width = 125;
            // 
            // ColDescargarFile
            // 
            this.ColDescargarFile.ColumnEdit = this.btnDescargarFile;
            this.ColDescargarFile.Name = "ColDescargarFile";
            this.ColDescargarFile.OptionsColumn.ReadOnly = true;
            this.ColDescargarFile.Visible = true;
            this.ColDescargarFile.VisibleIndex = 6;
            this.ColDescargarFile.Width = 57;
            // 
            // btnDescargarFile
            // 
            this.btnDescargarFile.AutoHeight = false;
            this.btnDescargarFile.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::Core.Erp.Winform.Properties.Resources._1455847200_178_Download, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.btnDescargarFile.Name = "btnDescargarFile";
            this.btnDescargarFile.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDescargarFile.Click += new System.EventHandler(this.btnDescargarFile_Click);
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
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 2, 28, 11, 53, 26, 710);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 4, 28, 11, 53, 26, 710);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(2, 2);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(1083, 155);
            this.ucGe_Menu.TabIndex = 2;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
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
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = true;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = true;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_event_btnAnular_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            this.ucGe_Menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_event_btnBuscar_Click);
            // 
            // frmCP_GeneracionFile_Banco_x_cxp_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 511);
            this.Controls.Add(this.panelControl_General);
            this.Name = "frmCP_GeneracionFile_Banco_x_cxp_Cons";
            this.Text = "frmCP_GeneracionFile_Banco_x_cxp_Cons";
            this.Load += new System.EventHandler(this.frmCP_GeneracionFile_Banco_x_cxp_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_General)).EndInit();
            this.panelControl_General.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGrid)).EndInit();
            this.panelControlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlArchivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewArchivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargarFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl_General;
        private DevExpress.XtraEditors.PanelControl panelControlGrid;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraGrid.GridControl gridControlArchivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewArchivos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdArchivo;
        private DevExpress.XtraGrid.Columns.GridColumn ColNom_Archivo;
        private DevExpress.XtraGrid.Columns.GridColumn Colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn ColTipo;
        private DevExpress.XtraGrid.Columns.GridColumn ColFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn Colnom_EstadoArchivo;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescargarFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDescargarFile;
    }
}