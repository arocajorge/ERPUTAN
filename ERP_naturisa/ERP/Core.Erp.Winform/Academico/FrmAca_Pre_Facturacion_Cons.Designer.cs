namespace Core.Erp.Winform.Academico
{
    partial class FrmAca_Pre_Facturacion_Cons
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
            this.gridContro_pre_fac = new DevExpress.XtraGrid.GridControl();
            this.gridView_pre_fac = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_observacion_fact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_IdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_FechaIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_FechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstadoInferior_Forms2 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            ((System.ComponentModel.ISupportInitialize)(this.gridContro_pre_fac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_pre_fac)).BeginInit();
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
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 4, 19, 12, 27, 4, 913);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 6, 19, 12, 27, 4, 913);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(905, 176);
            this.ucGe_Menu.TabIndex = 5;
            this.ucGe_Menu.Visible_bodega = true;
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
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = false;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = true;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            this.ucGe_Menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_event_btnBuscar_Click);
            // 
            // gridContro_pre_fac
            // 
            this.gridContro_pre_fac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContro_pre_fac.Location = new System.Drawing.Point(0, 176);
            this.gridContro_pre_fac.MainView = this.gridView_pre_fac;
            this.gridContro_pre_fac.Name = "gridContro_pre_fac";
            this.gridContro_pre_fac.Size = new System.Drawing.Size(905, 316);
            this.gridContro_pre_fac.TabIndex = 8;
            this.gridContro_pre_fac.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_pre_fac});
            // 
            // gridView_pre_fac
            // 
            this.gridView_pre_fac.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Nombre,
            this.Col_Descripcion,
            this.Col_observacion_fact,
            this.Col_IdPeriodo,
            this.Col_pe_FechaIni,
            this.Col_pe_FechaFin});
            this.gridView_pre_fac.GridControl = this.gridContro_pre_fac;
            this.gridView_pre_fac.Name = "gridView_pre_fac";
            this.gridView_pre_fac.OptionsView.ShowAutoFilterRow = true;
            // 
            // Col_Nombre
            // 
            this.Col_Nombre.Caption = "Sede";
            this.Col_Nombre.FieldName = "Nombre";
            this.Col_Nombre.Name = "Col_Nombre";
            this.Col_Nombre.Visible = true;
            this.Col_Nombre.VisibleIndex = 0;
            // 
            // Col_Descripcion
            // 
            this.Col_Descripcion.Caption = "Año Lectivo";
            this.Col_Descripcion.FieldName = "Descripcion";
            this.Col_Descripcion.Name = "Col_Descripcion";
            this.Col_Descripcion.Visible = true;
            this.Col_Descripcion.VisibleIndex = 1;
            // 
            // Col_observacion_fact
            // 
            this.Col_observacion_fact.Caption = "Observacion";
            this.Col_observacion_fact.FieldName = "observacion_fact";
            this.Col_observacion_fact.Name = "Col_observacion_fact";
            this.Col_observacion_fact.Visible = true;
            this.Col_observacion_fact.VisibleIndex = 2;
            // 
            // Col_IdPeriodo
            // 
            this.Col_IdPeriodo.Caption = "Periodo";
            this.Col_IdPeriodo.FieldName = "IdPeriodo";
            this.Col_IdPeriodo.Name = "Col_IdPeriodo";
            this.Col_IdPeriodo.Visible = true;
            this.Col_IdPeriodo.VisibleIndex = 3;
            // 
            // Col_pe_FechaIni
            // 
            this.Col_pe_FechaIni.Caption = "Fecha Inicio";
            this.Col_pe_FechaIni.FieldName = "pe_FechaIni";
            this.Col_pe_FechaIni.Name = "Col_pe_FechaIni";
            this.Col_pe_FechaIni.Visible = true;
            this.Col_pe_FechaIni.VisibleIndex = 4;
            // 
            // Col_pe_FechaFin
            // 
            this.Col_pe_FechaFin.Caption = "Fecha Fin";
            this.Col_pe_FechaFin.FieldName = "pe_FechaFin";
            this.Col_pe_FechaFin.Name = "Col_pe_FechaFin";
            this.Col_pe_FechaFin.Visible = true;
            this.Col_pe_FechaFin.VisibleIndex = 5;
            // 
            // ucGe_BarraEstadoInferior_Forms2
            // 
            this.ucGe_BarraEstadoInferior_Forms2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms2.Location = new System.Drawing.Point(0, 492);
            this.ucGe_BarraEstadoInferior_Forms2.Name = "ucGe_BarraEstadoInferior_Forms2";
            this.ucGe_BarraEstadoInferior_Forms2.Size = new System.Drawing.Size(905, 26);
            this.ucGe_BarraEstadoInferior_Forms2.TabIndex = 7;
            // 
            // FrmAca_Pre_Facturacion_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 518);
            this.Controls.Add(this.gridContro_pre_fac);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms2);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAca_Pre_Facturacion_Cons";
            this.Text = "FrmAca_Pre_Facturacion_Cons";
            this.Load += new System.EventHandler(this.FrmAca_Pre_Facturacion_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridContro_pre_fac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_pre_fac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraGrid.GridControl gridContro_pre_fac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_pre_fac;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms2;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_observacion_fact;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_FechaIni;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_FechaFin;
    }
}