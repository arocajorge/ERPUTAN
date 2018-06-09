namespace Core.Erp.Winform.ActivoFijo_FJ
{
    partial class frmAF_Poliza_x_Activos_Consulta_FJ
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.gridControlPolizas = new DevExpress.XtraGrid.GridControl();
            this.gridViewPolizas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdPoliza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colcod_poliza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colfecha_vigencia_desde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colfecha_vigencia_hasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colnum_cuotas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colvalor_cuota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colsuma_asegurada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Coltotal_meses = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colsubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Coliva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colpe_nombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPolizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPolizas)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 413);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(807, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 2, 22, 12, 22, 27, 544);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 4, 22, 12, 22, 27, 544);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(807, 178);
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
            this.ucGe_Menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_event_btnBuscar_Click);
            // 
            // gridControlPolizas
            // 
            this.gridControlPolizas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPolizas.Location = new System.Drawing.Point(0, 178);
            this.gridControlPolizas.MainView = this.gridViewPolizas;
            this.gridControlPolizas.Name = "gridControlPolizas";
            this.gridControlPolizas.Size = new System.Drawing.Size(807, 235);
            this.gridControlPolizas.TabIndex = 2;
            this.gridControlPolizas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPolizas});
            // 
            // gridViewPolizas
            // 
            this.gridViewPolizas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdPoliza,
            this.Colcod_poliza,
            this.Colfecha_vigencia_desde,
            this.Colfecha_vigencia_hasta,
            this.Colnum_cuotas,
            this.Colvalor_cuota,
            this.Colsuma_asegurada,
            this.Coltotal_meses,
            this.Colsubtotal,
            this.Coliva,
            this.ColTotal,
            this.Colpe_nombreCompleto,
            this.Colobservacion});
            this.gridViewPolizas.GridControl = this.gridControlPolizas;
            this.gridViewPolizas.Name = "gridViewPolizas";
            this.gridViewPolizas.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPolizas.OptionsView.ShowGroupPanel = false;
            this.gridViewPolizas.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewPolizas_RowCellStyle);
            this.gridViewPolizas.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPolizas_FocusedRowChanged);
            // 
            // ColIdPoliza
            // 
            this.ColIdPoliza.Caption = "Id";
            this.ColIdPoliza.FieldName = "IdPoliza";
            this.ColIdPoliza.Name = "ColIdPoliza";
            this.ColIdPoliza.Visible = true;
            this.ColIdPoliza.VisibleIndex = 0;
            this.ColIdPoliza.Width = 27;
            // 
            // Colcod_poliza
            // 
            this.Colcod_poliza.Caption = "Codigo";
            this.Colcod_poliza.FieldName = "cod_poliza";
            this.Colcod_poliza.Name = "Colcod_poliza";
            this.Colcod_poliza.Visible = true;
            this.Colcod_poliza.VisibleIndex = 1;
            this.Colcod_poliza.Width = 60;
            // 
            // Colfecha_vigencia_desde
            // 
            this.Colfecha_vigencia_desde.Caption = "Desde";
            this.Colfecha_vigencia_desde.FieldName = "fecha_vigencia_desde";
            this.Colfecha_vigencia_desde.Name = "Colfecha_vigencia_desde";
            this.Colfecha_vigencia_desde.Visible = true;
            this.Colfecha_vigencia_desde.VisibleIndex = 4;
            this.Colfecha_vigencia_desde.Width = 73;
            // 
            // Colfecha_vigencia_hasta
            // 
            this.Colfecha_vigencia_hasta.Caption = "Hasta";
            this.Colfecha_vigencia_hasta.FieldName = "fecha_vigencia_hasta";
            this.Colfecha_vigencia_hasta.Name = "Colfecha_vigencia_hasta";
            this.Colfecha_vigencia_hasta.Visible = true;
            this.Colfecha_vigencia_hasta.VisibleIndex = 5;
            this.Colfecha_vigencia_hasta.Width = 73;
            // 
            // Colnum_cuotas
            // 
            this.Colnum_cuotas.Caption = "#cuotas";
            this.Colnum_cuotas.FieldName = "num_cuotas";
            this.Colnum_cuotas.Name = "Colnum_cuotas";
            this.Colnum_cuotas.Visible = true;
            this.Colnum_cuotas.VisibleIndex = 6;
            this.Colnum_cuotas.Width = 73;
            // 
            // Colvalor_cuota
            // 
            this.Colvalor_cuota.Caption = "Valor Cuota";
            this.Colvalor_cuota.FieldName = "valor_cuota";
            this.Colvalor_cuota.Name = "Colvalor_cuota";
            this.Colvalor_cuota.Visible = true;
            this.Colvalor_cuota.VisibleIndex = 7;
            this.Colvalor_cuota.Width = 73;
            // 
            // Colsuma_asegurada
            // 
            this.Colsuma_asegurada.Caption = "Suma Asegurada";
            this.Colsuma_asegurada.FieldName = "suma_asegurada";
            this.Colsuma_asegurada.Name = "Colsuma_asegurada";
            this.Colsuma_asegurada.Visible = true;
            this.Colsuma_asegurada.VisibleIndex = 8;
            this.Colsuma_asegurada.Width = 98;
            // 
            // Coltotal_meses
            // 
            this.Coltotal_meses.Caption = "Total Meses";
            this.Coltotal_meses.FieldName = "total_meses";
            this.Coltotal_meses.Name = "Coltotal_meses";
            this.Coltotal_meses.Visible = true;
            this.Coltotal_meses.VisibleIndex = 9;
            this.Coltotal_meses.Width = 87;
            // 
            // Colsubtotal
            // 
            this.Colsubtotal.Caption = "Subtotal";
            this.Colsubtotal.FieldName = "subtotal";
            this.Colsubtotal.Name = "Colsubtotal";
            this.Colsubtotal.Visible = true;
            this.Colsubtotal.VisibleIndex = 10;
            this.Colsubtotal.Width = 73;
            // 
            // Coliva
            // 
            this.Coliva.Caption = "Iva";
            this.Coliva.FieldName = "iva";
            this.Coliva.Name = "Coliva";
            this.Coliva.Visible = true;
            this.Coliva.VisibleIndex = 11;
            this.Coliva.Width = 54;
            // 
            // ColTotal
            // 
            this.ColTotal.Caption = "Total";
            this.ColTotal.FieldName = "Total";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.Visible = true;
            this.ColTotal.VisibleIndex = 12;
            this.ColTotal.Width = 84;
            // 
            // Colpe_nombreCompleto
            // 
            this.Colpe_nombreCompleto.Caption = "Aseguradora";
            this.Colpe_nombreCompleto.FieldName = "pe_nombreCompleto";
            this.Colpe_nombreCompleto.Name = "Colpe_nombreCompleto";
            this.Colpe_nombreCompleto.Visible = true;
            this.Colpe_nombreCompleto.VisibleIndex = 2;
            this.Colpe_nombreCompleto.Width = 187;
            // 
            // Colobservacion
            // 
            this.Colobservacion.Caption = "Observación";
            this.Colobservacion.FieldName = "observacion";
            this.Colobservacion.Name = "Colobservacion";
            this.Colobservacion.Visible = true;
            this.Colobservacion.VisibleIndex = 3;
            this.Colobservacion.Width = 184;
            // 
            // frmAF_Poliza_x_Activos_Consulta_FJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 439);
            this.Controls.Add(this.gridControlPolizas);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "frmAF_Poliza_x_Activos_Consulta_FJ";
            this.Text = "Póliza por equipos consulta";
            this.Load += new System.EventHandler(this.frmAF_Poliza_x_Activos_Consulta_FJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPolizas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPolizas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraGrid.GridControl gridControlPolizas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPolizas;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdPoliza;
        private DevExpress.XtraGrid.Columns.GridColumn Colcod_poliza;
        private DevExpress.XtraGrid.Columns.GridColumn Colfecha_vigencia_desde;
        private DevExpress.XtraGrid.Columns.GridColumn Colfecha_vigencia_hasta;
        private DevExpress.XtraGrid.Columns.GridColumn Colnum_cuotas;
        private DevExpress.XtraGrid.Columns.GridColumn Colvalor_cuota;
        private DevExpress.XtraGrid.Columns.GridColumn Colsuma_asegurada;
        private DevExpress.XtraGrid.Columns.GridColumn Coltotal_meses;
        private DevExpress.XtraGrid.Columns.GridColumn Colsubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn Coliva;
        private DevExpress.XtraGrid.Columns.GridColumn ColTotal;
        private DevExpress.XtraGrid.Columns.GridColumn Colpe_nombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn Colobservacion;
    }
}