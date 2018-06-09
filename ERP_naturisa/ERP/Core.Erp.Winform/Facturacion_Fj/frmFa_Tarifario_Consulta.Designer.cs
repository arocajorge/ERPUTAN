namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class frmFa_Tarifario_Consulta
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
            this.PanelPrincipal = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlTarifarios = new DevExpress.XtraGrid.GridControl();
            this.gridViewTarifarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColcodTarifario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colnom_tarifario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colfecha_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colfecha_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoVigencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            ((System.ComponentModel.ISupportInitialize)(this.PanelPrincipal)).BeginInit();
            this.PanelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTarifarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTarifarios)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2016, 3, 21, 14, 57, 10, 182);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2016, 4, 22, 14, 57, 10, 182);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(915, 145);
            this.ucGe_Menu.TabIndex = 1;
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
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = true;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_event_btnAnular_ItemClick);
            this.ucGe_Menu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_event_btnImprimir_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            this.ucGe_Menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_event_btnBuscar_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.panel1);
            this.PanelPrincipal.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 145);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(915, 260);
            this.PanelPrincipal.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlTarifarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 230);
            this.panel1.TabIndex = 2;
            // 
            // gridControlTarifarios
            // 
            this.gridControlTarifarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTarifarios.Location = new System.Drawing.Point(0, 0);
            this.gridControlTarifarios.MainView = this.gridViewTarifarios;
            this.gridControlTarifarios.Name = "gridControlTarifarios";
            this.gridControlTarifarios.Size = new System.Drawing.Size(911, 230);
            this.gridControlTarifarios.TabIndex = 0;
            this.gridControlTarifarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTarifarios});
            // 
            // gridViewTarifarios
            // 
            this.gridViewTarifarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColcodTarifario,
            this.Colnom_tarifario,
            this.Colobservacion,
            this.Colfecha_inicio,
            this.Colfecha_fin,
            this.Cliente,
            this.colEstadoVigencia});
            this.gridViewTarifarios.GridControl = this.gridControlTarifarios;
            this.gridViewTarifarios.Name = "gridViewTarifarios";
            this.gridViewTarifarios.OptionsBehavior.ReadOnly = true;
            this.gridViewTarifarios.OptionsView.ShowAutoFilterRow = true;
            this.gridViewTarifarios.OptionsView.ShowGroupPanel = false;
            this.gridViewTarifarios.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewTarifarios_RowClick);
            this.gridViewTarifarios.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewTarifarios_RowCellStyle);
            this.gridViewTarifarios.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewTarifarios_FocusedRowChanged);
            // 
            // ColcodTarifario
            // 
            this.ColcodTarifario.Caption = "Codigo";
            this.ColcodTarifario.FieldName = "codTarifario";
            this.ColcodTarifario.Name = "ColcodTarifario";
            this.ColcodTarifario.OptionsColumn.AllowEdit = false;
            this.ColcodTarifario.Visible = true;
            this.ColcodTarifario.VisibleIndex = 0;
            this.ColcodTarifario.Width = 51;
            // 
            // Colnom_tarifario
            // 
            this.Colnom_tarifario.Caption = "Nombre tarifario";
            this.Colnom_tarifario.FieldName = "nom_tarifario";
            this.Colnom_tarifario.Name = "Colnom_tarifario";
            this.Colnom_tarifario.OptionsColumn.AllowEdit = false;
            this.Colnom_tarifario.Visible = true;
            this.Colnom_tarifario.VisibleIndex = 1;
            this.Colnom_tarifario.Width = 157;
            // 
            // Colobservacion
            // 
            this.Colobservacion.Caption = "Observacion";
            this.Colobservacion.FieldName = "observacion";
            this.Colobservacion.Name = "Colobservacion";
            this.Colobservacion.OptionsColumn.AllowEdit = false;
            this.Colobservacion.Visible = true;
            this.Colobservacion.VisibleIndex = 5;
            this.Colobservacion.Width = 157;
            // 
            // Colfecha_inicio
            // 
            this.Colfecha_inicio.Caption = "Fecha Inicio";
            this.Colfecha_inicio.FieldName = "fecha_inicio";
            this.Colfecha_inicio.Name = "Colfecha_inicio";
            this.Colfecha_inicio.OptionsColumn.AllowEdit = false;
            this.Colfecha_inicio.Visible = true;
            this.Colfecha_inicio.VisibleIndex = 3;
            this.Colfecha_inicio.Width = 157;
            // 
            // Colfecha_fin
            // 
            this.Colfecha_fin.Caption = "Fecha Fin";
            this.Colfecha_fin.FieldName = "fecha_fin";
            this.Colfecha_fin.Name = "Colfecha_fin";
            this.Colfecha_fin.OptionsColumn.AllowEdit = false;
            this.Colfecha_fin.Visible = true;
            this.Colfecha_fin.VisibleIndex = 4;
            this.Colfecha_fin.Width = 141;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "pe_nombreCompleto";
            this.Cliente.Name = "Cliente";
            this.Cliente.OptionsColumn.AllowEdit = false;
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 2;
            this.Cliente.Width = 157;
            // 
            // colEstadoVigencia
            // 
            this.colEstadoVigencia.Caption = "Estado";
            this.colEstadoVigencia.FieldName = "nom_EstadoVigencia_cat";
            this.colEstadoVigencia.Name = "colEstadoVigencia";
            this.colEstadoVigencia.OptionsColumn.AllowEdit = false;
            this.colEstadoVigencia.Visible = true;
            this.colEstadoVigencia.VisibleIndex = 6;
            this.colEstadoVigencia.Width = 73;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(2, 232);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(911, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // frmFa_Tarifario_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 405);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmFa_Tarifario_Consulta";
            this.Text = "Tarifarios por cliente consulta";
            this.Load += new System.EventHandler(this.frmFa_Tarifario_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelPrincipal)).EndInit();
            this.PanelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTarifarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTarifarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraEditors.PanelControl PanelPrincipal;
        private DevExpress.XtraGrid.GridControl gridControlTarifarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTarifarios;
        private DevExpress.XtraGrid.Columns.GridColumn ColcodTarifario;
        private DevExpress.XtraGrid.Columns.GridColumn Colnom_tarifario;
        private DevExpress.XtraGrid.Columns.GridColumn Colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn Colfecha_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn Colfecha_fin;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoVigencia;
    }
}