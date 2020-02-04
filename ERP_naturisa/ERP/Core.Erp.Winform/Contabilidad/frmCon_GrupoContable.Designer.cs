namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_GrupoContable
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gridControlGrupoCble = new DevExpress.XtraGrid.GridControl();
            this.gridViewGrupoCble = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGrupoCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgc_GrupoCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgc_Orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgc_estado_financiero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgc_signo_operacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGrupo_Mayor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGrupoCble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGrupoCble)).BeginInit();
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2016, 11, 27, 15, 26, 7, 442);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 1, 27, 15, 26, 7, 442);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(776, 158);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_event_btnImprimir_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            this.ucGe_Menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_event_btnBuscar_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 413);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(776, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gridControlGrupoCble);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 158);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(776, 255);
            this.panelMain.TabIndex = 2;
            // 
            // gridControlGrupoCble
            // 
            this.gridControlGrupoCble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGrupoCble.Location = new System.Drawing.Point(0, 0);
            this.gridControlGrupoCble.MainView = this.gridViewGrupoCble;
            this.gridControlGrupoCble.Name = "gridControlGrupoCble";
            this.gridControlGrupoCble.Size = new System.Drawing.Size(776, 255);
            this.gridControlGrupoCble.TabIndex = 0;
            this.gridControlGrupoCble.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGrupoCble});
            // 
            // gridViewGrupoCble
            // 
            this.gridViewGrupoCble.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGrupoCble,
            this.colgc_GrupoCble,
            this.colgc_Orden,
            this.colgc_estado_financiero,
            this.colgc_signo_operacion,
            this.colIdGrupo_Mayor,
            this.colEstado});
            this.gridViewGrupoCble.GridControl = this.gridControlGrupoCble;
            this.gridViewGrupoCble.Name = "gridViewGrupoCble";
            // 
            // colIdGrupoCble
            // 
            this.colIdGrupoCble.Caption = "IdGrupoCble";
            this.colIdGrupoCble.FieldName = "IdGrupoCble";
            this.colIdGrupoCble.Name = "colIdGrupoCble";
            this.colIdGrupoCble.Visible = true;
            this.colIdGrupoCble.VisibleIndex = 0;
            this.colIdGrupoCble.Width = 131;
            // 
            // colgc_GrupoCble
            // 
            this.colgc_GrupoCble.Caption = "GrupoCble";
            this.colgc_GrupoCble.FieldName = "gc_GrupoCble";
            this.colgc_GrupoCble.Name = "colgc_GrupoCble";
            this.colgc_GrupoCble.Visible = true;
            this.colgc_GrupoCble.VisibleIndex = 1;
            this.colgc_GrupoCble.Width = 397;
            // 
            // colgc_Orden
            // 
            this.colgc_Orden.Caption = "Orden";
            this.colgc_Orden.FieldName = "gc_Orden";
            this.colgc_Orden.Name = "colgc_Orden";
            this.colgc_Orden.Visible = true;
            this.colgc_Orden.VisibleIndex = 5;
            this.colgc_Orden.Width = 105;
            // 
            // colgc_estado_financiero
            // 
            this.colgc_estado_financiero.Caption = "Estado/Financiero";
            this.colgc_estado_financiero.FieldName = "gc_estado_financiero";
            this.colgc_estado_financiero.Name = "colgc_estado_financiero";
            this.colgc_estado_financiero.Visible = true;
            this.colgc_estado_financiero.VisibleIndex = 2;
            this.colgc_estado_financiero.Width = 177;
            // 
            // colgc_signo_operacion
            // 
            this.colgc_signo_operacion.Caption = "Signo/Operacion";
            this.colgc_signo_operacion.FieldName = "gc_signo_operacion";
            this.colgc_signo_operacion.Name = "colgc_signo_operacion";
            this.colgc_signo_operacion.Visible = true;
            this.colgc_signo_operacion.VisibleIndex = 3;
            this.colgc_signo_operacion.Width = 148;
            // 
            // colIdGrupo_Mayor
            // 
            this.colIdGrupo_Mayor.Caption = "IdGrupo_Mayor";
            this.colIdGrupo_Mayor.FieldName = "IdGrupo_Mayor";
            this.colIdGrupo_Mayor.Name = "colIdGrupo_Mayor";
            this.colIdGrupo_Mayor.Visible = true;
            this.colIdGrupo_Mayor.VisibleIndex = 4;
            this.colIdGrupo_Mayor.Width = 105;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 6;
            this.colEstado.Width = 117;
            // 
            // frmCon_GrupoContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 439);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCon_GrupoContable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo Contable";
            this.Load += new System.EventHandler(this.frmCon_GrupoContable_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGrupoCble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGrupoCble)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraGrid.GridControl gridControlGrupoCble;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGrupoCble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupoCble;
        private DevExpress.XtraGrid.Columns.GridColumn colgc_GrupoCble;
        private DevExpress.XtraGrid.Columns.GridColumn colgc_Orden;
        private DevExpress.XtraGrid.Columns.GridColumn colgc_estado_financiero;
        private DevExpress.XtraGrid.Columns.GridColumn colgc_signo_operacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupo_Mayor;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;

    }
}