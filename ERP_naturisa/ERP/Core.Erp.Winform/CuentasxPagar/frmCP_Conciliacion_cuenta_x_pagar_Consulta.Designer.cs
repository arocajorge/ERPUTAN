namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_Conciliacion_cuenta_x_pagar_Consulta
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
            this.components = new System.ComponentModel.Container();
            this.cpconciliacionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cxcconciliacionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cpordenpagocancelacionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlConciliacionCP = new DevExpress.XtraGrid.GridControl();
            this.gridViewConciliacionCP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdConciliacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCancelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbteCble_cbtecble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa_cbtecble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte_cbtecble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.cpconciliacionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxcconciliacionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpordenpagocancelacionInfoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConciliacionCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConciliacionCP)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpconciliacionInfoBindingSource
            // 
            this.cpconciliacionInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_conciliacion_Info);
            // 
            // cxcconciliacionInfoBindingSource
            // 
            this.cxcconciliacionInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_conciliacion_Info);
            // 
            // cpordenpagocancelacionInfoBindingSource
            // 
            this.cpordenpagocancelacionInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_orden_pago_cancelacion_Info);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(643, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlConciliacionCP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 236);
            this.panel1.TabIndex = 4;
            // 
            // gridControlConciliacionCP
            // 
            this.gridControlConciliacionCP.DataSource = this.cpconciliacionInfoBindingSource;
            this.gridControlConciliacionCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlConciliacionCP.Location = new System.Drawing.Point(0, 0);
            this.gridControlConciliacionCP.MainView = this.gridViewConciliacionCP;
            this.gridControlConciliacionCP.Name = "gridControlConciliacionCP";
            this.gridControlConciliacionCP.Size = new System.Drawing.Size(643, 236);
            this.gridControlConciliacionCP.TabIndex = 2;
            this.gridControlConciliacionCP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConciliacionCP});
            // 
            // gridViewConciliacionCP
            // 
            this.gridViewConciliacionCP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdConciliacion,
            this.colFecha,
            this.colObservacion,
            this.colEstado,
            this.colIdUsuarioUltMod,
            this.colFecha_Transac,
            this.colFecha_UltMod,
            this.colIdUsuarioUltAnu,
            this.colMotivoAnu,
            this.colnom_pc,
            this.colFecha_UltAnu,
            this.colip,
            this.colIdCancelacion,
            this.colIdCbteCble_cbtecble,
            this.colIdEmpresa_cbtecble,
            this.colIdTipoCbte_cbtecble});
            this.gridViewConciliacionCP.GridControl = this.gridControlConciliacionCP;
            this.gridViewConciliacionCP.Name = "gridViewConciliacionCP";
            this.gridViewConciliacionCP.OptionsBehavior.Editable = false;
            this.gridViewConciliacionCP.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConciliacionCP.OptionsView.ShowGroupPanel = false;
            this.gridViewConciliacionCP.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewConciliacionCP_RowCellStyle);
            this.gridViewConciliacionCP.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewConciliacionCP_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.ReadOnly = true;
            // 
            // colIdConciliacion
            // 
            this.colIdConciliacion.Caption = "Conciliación #";
            this.colIdConciliacion.FieldName = "IdConciliacion";
            this.colIdConciliacion.Name = "colIdConciliacion";
            this.colIdConciliacion.OptionsColumn.ReadOnly = true;
            this.colIdConciliacion.Visible = true;
            this.colIdConciliacion.VisibleIndex = 0;
            this.colIdConciliacion.Width = 74;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.ReadOnly = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 1;
            this.colFecha.Width = 63;
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observación";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.OptionsColumn.ReadOnly = true;
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 2;
            this.colObservacion.Width = 430;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.ReadOnly = true;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 3;
            this.colEstado.Width = 58;
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            this.colIdUsuarioUltMod.OptionsColumn.ReadOnly = true;
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            this.colFecha_Transac.OptionsColumn.ReadOnly = true;
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            this.colFecha_UltMod.OptionsColumn.ReadOnly = true;
            // 
            // colIdUsuarioUltAnu
            // 
            this.colIdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Name = "colIdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.OptionsColumn.ReadOnly = true;
            // 
            // colMotivoAnu
            // 
            this.colMotivoAnu.FieldName = "MotivoAnu";
            this.colMotivoAnu.Name = "colMotivoAnu";
            this.colMotivoAnu.OptionsColumn.ReadOnly = true;
            // 
            // colnom_pc
            // 
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            this.colnom_pc.OptionsColumn.ReadOnly = true;
            // 
            // colFecha_UltAnu
            // 
            this.colFecha_UltAnu.FieldName = "Fecha_UltAnu";
            this.colFecha_UltAnu.Name = "colFecha_UltAnu";
            this.colFecha_UltAnu.OptionsColumn.ReadOnly = true;
            // 
            // colip
            // 
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            this.colip.OptionsColumn.ReadOnly = true;
            // 
            // colIdCancelacion
            // 
            this.colIdCancelacion.FieldName = "IdCancelacion";
            this.colIdCancelacion.Name = "colIdCancelacion";
            this.colIdCancelacion.OptionsColumn.ReadOnly = true;
            // 
            // colIdCbteCble_cbtecble
            // 
            this.colIdCbteCble_cbtecble.FieldName = "IdCbteCble_cbtecble";
            this.colIdCbteCble_cbtecble.Name = "colIdCbteCble_cbtecble";
            this.colIdCbteCble_cbtecble.OptionsColumn.ReadOnly = true;
            // 
            // colIdEmpresa_cbtecble
            // 
            this.colIdEmpresa_cbtecble.FieldName = "IdEmpresa_cbtecble";
            this.colIdEmpresa_cbtecble.Name = "colIdEmpresa_cbtecble";
            this.colIdEmpresa_cbtecble.OptionsColumn.ReadOnly = true;
            // 
            // colIdTipoCbte_cbtecble
            // 
            this.colIdTipoCbte_cbtecble.FieldName = "IdTipoCbte_cbtecble";
            this.colIdTipoCbte_cbtecble.Name = "colIdTipoCbte_cbtecble";
            this.colIdTipoCbte_cbtecble.OptionsColumn.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucGe_Menu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 94);
            this.panel2.TabIndex = 5;
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 5, 5, 9, 35, 32, 976);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 7, 5, 9, 35, 32, 976);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(643, 97);
            this.ucGe_Menu.TabIndex = 0;
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
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = false;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            // 
            // frmCP_Conciliacion_cuenta_x_pagar_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 352);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmCP_Conciliacion_cuenta_x_pagar_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de conciliación de cuentas por pagar";
            this.Load += new System.EventHandler(this.frmCP_Conciliacion_cuenta_x_pagar_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpconciliacionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxcconciliacionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpordenpagocancelacionInfoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConciliacionCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConciliacionCP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cpordenpagocancelacionInfoBindingSource;
        private System.Windows.Forms.BindingSource cxcconciliacionInfoBindingSource;
        private System.Windows.Forms.BindingSource cpconciliacionInfoBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlConciliacionCP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConciliacionCP;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdConciliacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCancelacion;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble_cbtecble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa_cbtecble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte_cbtecble;
    }
}