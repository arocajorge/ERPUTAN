namespace Core.Erp.Winform.Caja
{
    partial class FrmCa_Caja_MovimientoConsulta_Egreso
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
            this.gridControl_MoviCaja = new DevExpress.XtraGrid.GridControl();
            this.UltraGrid_MoviCaja = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCbteCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngEgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNCaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNTipoMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_Beneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_MoviCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_MoviCaja)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_MoviCaja
            // 
            this.gridControl_MoviCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_MoviCaja.Location = new System.Drawing.Point(0, 0);
            this.gridControl_MoviCaja.MainView = this.UltraGrid_MoviCaja;
            this.gridControl_MoviCaja.Name = "gridControl_MoviCaja";
            this.gridControl_MoviCaja.Size = new System.Drawing.Size(1019, 352);
            this.gridControl_MoviCaja.TabIndex = 5;
            this.gridControl_MoviCaja.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGrid_MoviCaja});
            // 
            // UltraGrid_MoviCaja
            // 
            this.UltraGrid_MoviCaja.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCbteCble,
            this.colIngEgr,
            this.colNCaja,
            this.colNTipoMovi,
            this.colcm_valor,
            this.colNom_Beneficiario,
            this.colcm_fecha,
            this.colcm_observacion,
            this.colEstado});
            this.UltraGrid_MoviCaja.GridControl = this.gridControl_MoviCaja;
            this.UltraGrid_MoviCaja.Name = "UltraGrid_MoviCaja";
            this.UltraGrid_MoviCaja.OptionsBehavior.ReadOnly = true;
            this.UltraGrid_MoviCaja.OptionsView.ShowAutoFilterRow = true;
            this.UltraGrid_MoviCaja.OptionsView.ShowGroupPanel = false;
            this.UltraGrid_MoviCaja.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.UltraGrid_MoviCaja_RowCellStyle);
            this.UltraGrid_MoviCaja.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.UltraGrid_MoviCaja_FocusedRowChanged);
            // 
            // colIdCbteCble
            // 
            this.colIdCbteCble.Caption = "# Movimiento";
            this.colIdCbteCble.FieldName = "IdCbteCble";
            this.colIdCbteCble.Name = "colIdCbteCble";
            this.colIdCbteCble.OptionsColumn.AllowEdit = false;
            this.colIdCbteCble.Visible = true;
            this.colIdCbteCble.VisibleIndex = 0;
            this.colIdCbteCble.Width = 112;
            // 
            // colIngEgr
            // 
            this.colIngEgr.Caption = "Tipo";
            this.colIngEgr.FieldName = "IngEgr";
            this.colIngEgr.Name = "colIngEgr";
            this.colIngEgr.OptionsColumn.AllowEdit = false;
            this.colIngEgr.Visible = true;
            this.colIngEgr.VisibleIndex = 7;
            this.colIngEgr.Width = 90;
            // 
            // colNCaja
            // 
            this.colNCaja.Caption = "Caja";
            this.colNCaja.FieldName = "NCaja";
            this.colNCaja.Name = "colNCaja";
            this.colNCaja.OptionsColumn.AllowEdit = false;
            this.colNCaja.Visible = true;
            this.colNCaja.VisibleIndex = 3;
            this.colNCaja.Width = 132;
            // 
            // colNTipoMovi
            // 
            this.colNTipoMovi.Caption = "Motivo";
            this.colNTipoMovi.FieldName = "NTipoMovi";
            this.colNTipoMovi.Name = "colNTipoMovi";
            this.colNTipoMovi.OptionsColumn.AllowEdit = false;
            this.colNTipoMovi.Visible = true;
            this.colNTipoMovi.VisibleIndex = 4;
            this.colNTipoMovi.Width = 111;
            // 
            // colcm_valor
            // 
            this.colcm_valor.Caption = "Monto";
            this.colcm_valor.DisplayFormat.FormatString = "$ #,#######0.00;$ #,#######0.00";
            this.colcm_valor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcm_valor.FieldName = "cm_valor";
            this.colcm_valor.Name = "colcm_valor";
            this.colcm_valor.OptionsColumn.AllowEdit = false;
            this.colcm_valor.Visible = true;
            this.colcm_valor.VisibleIndex = 2;
            this.colcm_valor.Width = 143;
            // 
            // colNom_Beneficiario
            // 
            this.colNom_Beneficiario.Caption = "Beneficiario";
            this.colNom_Beneficiario.FieldName = "Nom_Beneficiario";
            this.colNom_Beneficiario.Name = "colNom_Beneficiario";
            this.colNom_Beneficiario.OptionsColumn.AllowEdit = false;
            this.colNom_Beneficiario.Visible = true;
            this.colNom_Beneficiario.VisibleIndex = 5;
            this.colNom_Beneficiario.Width = 278;
            // 
            // colcm_fecha
            // 
            this.colcm_fecha.Caption = "Fecha";
            this.colcm_fecha.FieldName = "cm_fecha";
            this.colcm_fecha.Name = "colcm_fecha";
            this.colcm_fecha.OptionsColumn.AllowEdit = false;
            this.colcm_fecha.Visible = true;
            this.colcm_fecha.VisibleIndex = 1;
            this.colcm_fecha.Width = 114;
            // 
            // colcm_observacion
            // 
            this.colcm_observacion.Caption = "Observación";
            this.colcm_observacion.FieldName = "cm_observacion";
            this.colcm_observacion.Name = "colcm_observacion";
            this.colcm_observacion.OptionsColumn.AllowEdit = false;
            this.colcm_observacion.Visible = true;
            this.colcm_observacion.VisibleIndex = 6;
            this.colcm_observacion.Width = 200;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Width = 93;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 151);
            this.panel1.TabIndex = 6;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 11, 21, 10, 38, 18, 801);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 1, 21, 10, 38, 18, 801);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1019, 153);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 503);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1019, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl_MoviCaja);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 352);
            this.panel2.TabIndex = 9;
            // 
            // FrmCa_Caja_MovimientoConsulta_Egreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCa_Caja_MovimientoConsulta_Egreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Movimiento de Caja_Egreso";
            this.Load += new System.EventHandler(this.FrmCa_Caja_MovimientoConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_MoviCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_MoviCaja)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_MoviCaja;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGrid_MoviCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble;
        private DevExpress.XtraGrid.Columns.GridColumn colIngEgr;
        private DevExpress.XtraGrid.Columns.GridColumn colNCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colNTipoMovi;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_valor;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_Beneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel2;
    }
}