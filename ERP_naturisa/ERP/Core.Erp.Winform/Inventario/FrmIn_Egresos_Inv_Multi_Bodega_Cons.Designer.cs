namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Egresos_Inv_Multi_Bodega_Cons
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
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gridControlMovi_Inv_Egre = new DevExpress.XtraGrid.GridControl();
            this.gridViewMovi_Inv_Egre = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnom_sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNumMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_tipo_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_motivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAproba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMotivo_Inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesc_mov_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMovi_Inv_Egre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovi_Inv_Egre)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 443);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(945, 26);
            this.ucGe_BarraEstado.TabIndex = 0;
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2016, 4, 23, 11, 31, 56, 302);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2016, 5, 24, 11, 31, 56, 302);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(945, 155);
            this.ucGe_Menu.TabIndex = 1;
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
            this.ucGe_Menu.Visible_sucursal = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gridControlMovi_Inv_Egre);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 155);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(945, 288);
            this.panelMain.TabIndex = 2;
            // 
            // gridControlMovi_Inv_Egre
            // 
            this.gridControlMovi_Inv_Egre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMovi_Inv_Egre.Location = new System.Drawing.Point(0, 0);
            this.gridControlMovi_Inv_Egre.MainView = this.gridViewMovi_Inv_Egre;
            this.gridControlMovi_Inv_Egre.Name = "gridControlMovi_Inv_Egre";
            this.gridControlMovi_Inv_Egre.Size = new System.Drawing.Size(945, 288);
            this.gridControlMovi_Inv_Egre.TabIndex = 0;
            this.gridControlMovi_Inv_Egre.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMovi_Inv_Egre});
            // 
            // gridViewMovi_Inv_Egre
            // 
            this.gridViewMovi_Inv_Egre.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnom_sucursal,
            this.colIdNumMovi,
            this.colnom_tipo_inv,
            this.colnom_motivo,
            this.colcm_fecha,
            this.colcm_observacion,
            this.colEstado,
            this.colIdEstadoAproba,
            this.colIdMotivo_Inv,
            this.colDesc_mov_inv});
            this.gridViewMovi_Inv_Egre.GridControl = this.gridControlMovi_Inv_Egre;
            this.gridViewMovi_Inv_Egre.Name = "gridViewMovi_Inv_Egre";
            this.gridViewMovi_Inv_Egre.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridViewMovi_Inv_Egre.OptionsLayout.Columns.StoreAppearance = true;
            this.gridViewMovi_Inv_Egre.OptionsLayout.StoreAllOptions = true;
            this.gridViewMovi_Inv_Egre.OptionsLayout.StoreAppearance = true;
            this.gridViewMovi_Inv_Egre.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMovi_Inv_Egre.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewMovi_Inv_Egre_RowStyle);
            // 
            // colnom_sucursal
            // 
            this.colnom_sucursal.Caption = "Sucursal";
            this.colnom_sucursal.FieldName = "nom_sucursal";
            this.colnom_sucursal.Name = "colnom_sucursal";
            this.colnom_sucursal.Visible = true;
            this.colnom_sucursal.VisibleIndex = 0;
            this.colnom_sucursal.Width = 120;
            // 
            // colIdNumMovi
            // 
            this.colIdNumMovi.Caption = "#Movimiento";
            this.colIdNumMovi.FieldName = "IdNumMovi";
            this.colIdNumMovi.Name = "colIdNumMovi";
            this.colIdNumMovi.Visible = true;
            this.colIdNumMovi.VisibleIndex = 1;
            this.colIdNumMovi.Width = 76;
            // 
            // colnom_tipo_inv
            // 
            this.colnom_tipo_inv.Caption = "Tipo Movi";
            this.colnom_tipo_inv.FieldName = "nom_tipo_inv";
            this.colnom_tipo_inv.Name = "colnom_tipo_inv";
            this.colnom_tipo_inv.Visible = true;
            this.colnom_tipo_inv.VisibleIndex = 2;
            this.colnom_tipo_inv.Width = 96;
            // 
            // colnom_motivo
            // 
            this.colnom_motivo.Caption = "Motivo";
            this.colnom_motivo.FieldName = "nom_motivo";
            this.colnom_motivo.Name = "colnom_motivo";
            this.colnom_motivo.Width = 120;
            // 
            // colcm_fecha
            // 
            this.colcm_fecha.Caption = "Fecha";
            this.colcm_fecha.FieldName = "cm_fecha";
            this.colcm_fecha.Name = "colcm_fecha";
            this.colcm_fecha.Visible = true;
            this.colcm_fecha.VisibleIndex = 4;
            this.colcm_fecha.Width = 174;
            // 
            // colcm_observacion
            // 
            this.colcm_observacion.Caption = "Observacion";
            this.colcm_observacion.FieldName = "cm_observacion";
            this.colcm_observacion.Name = "colcm_observacion";
            this.colcm_observacion.Visible = true;
            this.colcm_observacion.VisibleIndex = 5;
            this.colcm_observacion.Width = 293;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 6;
            this.colEstado.Width = 135;
            // 
            // colIdEstadoAproba
            // 
            this.colIdEstadoAproba.Caption = "IdEstadoAproba";
            this.colIdEstadoAproba.FieldName = "IdEstadoAproba";
            this.colIdEstadoAproba.Name = "colIdEstadoAproba";
            this.colIdEstadoAproba.Visible = true;
            this.colIdEstadoAproba.VisibleIndex = 7;
            this.colIdEstadoAproba.Width = 153;
            // 
            // colIdMotivo_Inv
            // 
            this.colIdMotivo_Inv.FieldName = "IdMotivo_Inv";
            this.colIdMotivo_Inv.Name = "colIdMotivo_Inv";
            // 
            // colDesc_mov_inv
            // 
            this.colDesc_mov_inv.Caption = "Motivo";
            this.colDesc_mov_inv.FieldName = "Desc_mov_inv";
            this.colDesc_mov_inv.Name = "colDesc_mov_inv";
            this.colDesc_mov_inv.Visible = true;
            this.colDesc_mov_inv.VisibleIndex = 3;
            this.colDesc_mov_inv.Width = 115;
            // 
            // FrmIn_Egresos_Inv_Multi_Bodega_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 469);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Name = "FrmIn_Egresos_Inv_Multi_Bodega_Cons";
            this.Text = "Egresos de Inventario Multibodega";
            this.Load += new System.EventHandler(this.FrmIn_Egresos_Inv_Multi_Bodega_Cons_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMovi_Inv_Egre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovi_Inv_Egre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraGrid.GridControl gridControlMovi_Inv_Egre;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMovi_Inv_Egre;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNumMovi;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_tipo_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_motivo;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAproba;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotivo_Inv;
        private DevExpress.XtraGrid.Columns.GridColumn colDesc_mov_inv;
    }
}