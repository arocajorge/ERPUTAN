namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaBecas_Cons
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
            this.ucGe_Menu_Mantenimiento_x_usuario1 = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gridControlBecas = new DevExpress.XtraGrid.GridControl();
            this.gridViewBecas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnColIdInstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColIdBeca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColnom_beca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColporcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBecas)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario1
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasSucursales = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde = new System.DateTime(2017, 4, 12, 16, 0, 47, 127);
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta = new System.DateTime(2017, 6, 12, 16, 0, 47, 127);
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucGe_Menu_Mantenimiento_x_usuario1.Name = "ucGe_Menu_Mantenimiento_x_usuario1";
            this.ucGe_Menu_Mantenimiento_x_usuario1.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Size = new System.Drawing.Size(743, 115);
            this.ucGe_Menu_Mantenimiento_x_usuario1.TabIndex = 2;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.Menu_event_btnAnular_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.Menu_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.Menu_event_btnSalir_ItemClick);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 432);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(743, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gridControlBecas);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 115);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(743, 317);
            this.panelMain.TabIndex = 4;
            // 
            // gridControlBecas
            // 
            this.gridControlBecas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBecas.Location = new System.Drawing.Point(0, 0);
            this.gridControlBecas.MainView = this.gridViewBecas;
            this.gridControlBecas.Name = "gridControlBecas";
            this.gridControlBecas.Size = new System.Drawing.Size(743, 317);
            this.gridControlBecas.TabIndex = 3;
            this.gridControlBecas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBecas});
            // 
            // gridViewBecas
            // 
            this.gridViewBecas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnColIdInstitucion,
            this.gridColumnColIdBeca,
            this.gridColumnColnom_beca,
            this.gridColumnColporcentaje,
            this.gridColumnColestado,
            this.IdRubro});
            this.gridViewBecas.GridControl = this.gridControlBecas;
            this.gridViewBecas.Name = "gridViewBecas";
            this.gridViewBecas.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBecas.OptionsView.ShowGroupPanel = false;
            this.gridViewBecas.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewBecas_RowStyle);
            // 
            // gridColumnColIdInstitucion
            // 
            this.gridColumnColIdInstitucion.Caption = "IdInstitucion";
            this.gridColumnColIdInstitucion.FieldName = "IdInstitucion";
            this.gridColumnColIdInstitucion.Name = "gridColumnColIdInstitucion";
            this.gridColumnColIdInstitucion.OptionsColumn.AllowEdit = false;
            // 
            // gridColumnColIdBeca
            // 
            this.gridColumnColIdBeca.Caption = "IdBeca";
            this.gridColumnColIdBeca.FieldName = "IdBeca";
            this.gridColumnColIdBeca.Name = "gridColumnColIdBeca";
            this.gridColumnColIdBeca.OptionsColumn.AllowEdit = false;
            this.gridColumnColIdBeca.Visible = true;
            this.gridColumnColIdBeca.VisibleIndex = 0;
            this.gridColumnColIdBeca.Width = 161;
            // 
            // gridColumnColnom_beca
            // 
            this.gridColumnColnom_beca.Caption = "Descripcion";
            this.gridColumnColnom_beca.FieldName = "nom_beca";
            this.gridColumnColnom_beca.Name = "gridColumnColnom_beca";
            this.gridColumnColnom_beca.OptionsColumn.AllowEdit = false;
            this.gridColumnColnom_beca.Visible = true;
            this.gridColumnColnom_beca.VisibleIndex = 1;
            this.gridColumnColnom_beca.Width = 450;
            // 
            // gridColumnColporcentaje
            // 
            this.gridColumnColporcentaje.Caption = "porcentaje";
            this.gridColumnColporcentaje.FieldName = "porcentaje";
            this.gridColumnColporcentaje.Name = "gridColumnColporcentaje";
            this.gridColumnColporcentaje.OptionsColumn.AllowEdit = false;
            this.gridColumnColporcentaje.Visible = true;
            this.gridColumnColporcentaje.VisibleIndex = 2;
            this.gridColumnColporcentaje.Width = 283;
            // 
            // gridColumnColestado
            // 
            this.gridColumnColestado.Caption = "Estado";
            this.gridColumnColestado.FieldName = "estado";
            this.gridColumnColestado.Name = "gridColumnColestado";
            this.gridColumnColestado.OptionsColumn.AllowEdit = false;
            this.gridColumnColestado.Visible = true;
            this.gridColumnColestado.VisibleIndex = 3;
            this.gridColumnColestado.Width = 286;
            // 
            // IdRubro
            // 
            this.IdRubro.Caption = "ColIdRubro";
            this.IdRubro.FieldName = "IdRubro";
            this.IdRubro.Name = "IdRubro";
            this.IdRubro.OptionsColumn.AllowEdit = false;
            this.IdRubro.Visible = true;
            this.IdRubro.VisibleIndex = 4;
            // 
            // FrmAcaBecas_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 458);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario1);
            this.Name = "FrmAcaBecas_Cons";
            this.Text = "Becas";
            this.Load += new System.EventHandler(this.FrmAcaBecas_Cons_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBecas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraGrid.GridControl gridControlBecas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBecas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColIdInstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColIdBeca;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColnom_beca;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColporcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColestado;
        private DevExpress.XtraGrid.Columns.GridColumn IdRubro;
    }
}