namespace Core.Erp.Winform.General
{
    partial class FrmGe_Impuesto_Cons
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
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControl_Impuesto = new DevExpress.XtraGrid.GridControl();
            this.gridView_Impuesto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCod_Impuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_impuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsado_en_Ventas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsado_en_Compras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCodigo_SRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoImpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Impuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Impuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasSucursales = true;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 8, 1, 17, 47, 10, 555);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 10, 1, 17, 47, 10, 555);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(667, 114);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 1;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 367);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(667, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 2;
            // 
            // gridControl_Impuesto
            // 
            this.gridControl_Impuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Impuesto.Location = new System.Drawing.Point(0, 114);
            this.gridControl_Impuesto.MainView = this.gridView_Impuesto;
            this.gridControl_Impuesto.Name = "gridControl_Impuesto";
            this.gridControl_Impuesto.Size = new System.Drawing.Size(667, 253);
            this.gridControl_Impuesto.TabIndex = 3;
            this.gridControl_Impuesto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Impuesto});
            // 
            // gridView_Impuesto
            // 
            this.gridView_Impuesto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCod_Impuesto,
            this.colnom_impuesto,
            this.colUsado_en_Ventas,
            this.colUsado_en_Compras,
            this.colporcentaje,
            this.colIdCodigo_SRI,
            this.colIdTipoImpuesto});
            this.gridView_Impuesto.GridControl = this.gridControl_Impuesto;
            this.gridView_Impuesto.Name = "gridView_Impuesto";
            this.gridView_Impuesto.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Impuesto.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCod_Impuesto
            // 
            this.colIdCod_Impuesto.Caption = "IdCod_Impuesto";
            this.colIdCod_Impuesto.FieldName = "IdCod_Impuesto";
            this.colIdCod_Impuesto.Name = "colIdCod_Impuesto";
            this.colIdCod_Impuesto.Visible = true;
            this.colIdCod_Impuesto.VisibleIndex = 0;
            this.colIdCod_Impuesto.Width = 122;
            // 
            // colnom_impuesto
            // 
            this.colnom_impuesto.Caption = "Impuesto";
            this.colnom_impuesto.FieldName = "nom_impuesto";
            this.colnom_impuesto.Name = "colnom_impuesto";
            this.colnom_impuesto.Visible = true;
            this.colnom_impuesto.VisibleIndex = 1;
            this.colnom_impuesto.Width = 341;
            // 
            // colUsado_en_Ventas
            // 
            this.colUsado_en_Ventas.Caption = "Usado_en_Ventas";
            this.colUsado_en_Ventas.FieldName = "Usado_en_Ventas";
            this.colUsado_en_Ventas.Name = "colUsado_en_Ventas";
            this.colUsado_en_Ventas.Visible = true;
            this.colUsado_en_Ventas.VisibleIndex = 2;
            this.colUsado_en_Ventas.Width = 107;
            // 
            // colUsado_en_Compras
            // 
            this.colUsado_en_Compras.Caption = "Usado_en_Compras";
            this.colUsado_en_Compras.FieldName = "Usado_en_Compras";
            this.colUsado_en_Compras.Name = "colUsado_en_Compras";
            this.colUsado_en_Compras.Visible = true;
            this.colUsado_en_Compras.VisibleIndex = 3;
            this.colUsado_en_Compras.Width = 70;
            // 
            // colporcentaje
            // 
            this.colporcentaje.Caption = "porcentaje";
            this.colporcentaje.FieldName = "porcentaje";
            this.colporcentaje.Name = "colporcentaje";
            this.colporcentaje.Visible = true;
            this.colporcentaje.VisibleIndex = 4;
            this.colporcentaje.Width = 70;
            // 
            // colIdCodigo_SRI
            // 
            this.colIdCodigo_SRI.Caption = "IdCodigo_SRI";
            this.colIdCodigo_SRI.FieldName = "IdCodigo_SRI";
            this.colIdCodigo_SRI.Name = "colIdCodigo_SRI";
            this.colIdCodigo_SRI.Visible = true;
            this.colIdCodigo_SRI.VisibleIndex = 5;
            this.colIdCodigo_SRI.Width = 70;
            // 
            // colIdTipoImpuesto
            // 
            this.colIdTipoImpuesto.Caption = "IdTipoImpuesto";
            this.colIdTipoImpuesto.FieldName = "IdTipoImpuesto";
            this.colIdTipoImpuesto.Name = "colIdTipoImpuesto";
            this.colIdTipoImpuesto.Visible = true;
            this.colIdTipoImpuesto.VisibleIndex = 6;
            this.colIdTipoImpuesto.Width = 76;
            // 
            // FrmGe_Impuesto_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 393);
            this.Controls.Add(this.gridControl_Impuesto);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "FrmGe_Impuesto_Cons";
            this.Text = "FrmGe_Impuesto_Cons";
            this.Load += new System.EventHandler(this.FrmGe_Impuesto_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Impuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Impuesto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl gridControl_Impuesto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Impuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCod_Impuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_impuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colUsado_en_Ventas;
        private DevExpress.XtraGrid.Columns.GridColumn colUsado_en_Compras;
        private DevExpress.XtraGrid.Columns.GridColumn colporcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCodigo_SRI;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoImpuesto;
    }
}