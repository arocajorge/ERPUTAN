namespace Core.Erp.Winform.Academico
{
    partial class FrmAca_Tarjeta_cred_Cons
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
            this.Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlTarjeta = new DevExpress.XtraGrid.GridControl();
            this.gridViewTarjeta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTarjeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTarjeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_tarjeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporc_comision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTarjeta)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.CargarTodasBodegas = false;
            this.Menu.CargarTodasSucursales = true;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Enable_boton_anular = true;
            this.Menu.Enable_boton_CancelarCuotas = true;
            this.Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.Menu.Enable_boton_consultar = true;
            this.Menu.Enable_boton_DiseñoCheque = true;
            this.Menu.Enable_boton_DiseñoChequeComprobante = true;
            this.Menu.Enable_boton_Duplicar = true;
            this.Menu.Enable_boton_GenerarPeriodos = true;
            this.Menu.Enable_boton_GenerarXml = true;
            this.Menu.Enable_boton_Habilitar_Reg = true;
            this.Menu.Enable_boton_Importar_XML = true;
            this.Menu.Enable_boton_imprimir = true;
            this.Menu.Enable_boton_LoteCheque = true;
            this.Menu.Enable_boton_modificar = true;
            this.Menu.Enable_boton_nuevo = true;
            this.Menu.Enable_boton_NuevoCheque = true;
            this.Menu.Enable_boton_periodo = true;
            this.Menu.Enable_boton_salir = true;
            this.Menu.Enable_btnImpExcel = true;
            this.Menu.Enable_Descargar_Marca_Base_exter = true;
            this.Menu.fecha_desde = new System.DateTime(2017, 4, 19, 12, 29, 33, 383);
            this.Menu.fecha_hasta = new System.DateTime(2017, 6, 19, 12, 29, 33, 383);
            this.Menu.FormConsulta = null;
            this.Menu.FormMain = null;
            this.Menu.GridControlConsulta = null;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Perfil_x_usuario = null;
            this.Menu.Size = new System.Drawing.Size(683, 116);
            this.Menu.TabIndex = 0;
            this.Menu.Visible_bodega = false;
            this.Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.Menu.Visible_fechas = false;
            this.Menu.Visible_Grupo_Cancelaciones = true;
            this.Menu.Visible_Grupo_Diseño_Reporte = false;
            this.Menu.Visible_Grupo_filtro = false;
            this.Menu.Visible_Grupo_Impresion = true;
            this.Menu.Visible_Grupo_Otras_Trans = true;
            this.Menu.Visible_Grupo_Transacciones = true;
            this.Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.Menu.Visible_ribbon_control = true;
            this.Menu.Visible_sucursal = false;
            this.Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.Menu_event_btnNuevo_ItemClick);
            this.Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.Menu_event_btnModificar_ItemClick);
            this.Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.Menu_event_btnconsultar_ItemClick);
            this.Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.Menu_event_btnAnular_ItemClick);
            this.Menu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.Menu_event_btnImprimir_ItemClick);
            this.Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.Menu_event_btnSalir_ItemClick);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 354);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(683, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlTarjeta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 238);
            this.panel1.TabIndex = 2;
            // 
            // gridControlTarjeta
            // 
            this.gridControlTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTarjeta.Location = new System.Drawing.Point(0, 0);
            this.gridControlTarjeta.MainView = this.gridViewTarjeta;
            this.gridControlTarjeta.Name = "gridControlTarjeta";
            this.gridControlTarjeta.Size = new System.Drawing.Size(683, 238);
            this.gridControlTarjeta.TabIndex = 0;
            this.gridControlTarjeta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTarjeta});
            // 
            // gridViewTarjeta
            // 
            this.gridViewTarjeta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTarjeta,
            this.colCodTarjeta,
            this.colnom_tarjeta,
            this.colporc_comision,
            this.colestado});
            this.gridViewTarjeta.GridControl = this.gridControlTarjeta;
            this.gridViewTarjeta.Name = "gridViewTarjeta";
            this.gridViewTarjeta.OptionsBehavior.Editable = false;
            this.gridViewTarjeta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewTarjeta.OptionsView.ShowGroupPanel = false;
            this.gridViewTarjeta.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewTarjeta_RowStyle);
            // 
            // colIdTarjeta
            // 
            this.colIdTarjeta.Caption = "IdTarjeta";
            this.colIdTarjeta.FieldName = "IdTarjeta";
            this.colIdTarjeta.Name = "colIdTarjeta";
            this.colIdTarjeta.Visible = true;
            this.colIdTarjeta.VisibleIndex = 4;
            this.colIdTarjeta.Width = 29;
            // 
            // colCodTarjeta
            // 
            this.colCodTarjeta.Caption = "CodTarjeta";
            this.colCodTarjeta.FieldName = "CodTarjeta";
            this.colCodTarjeta.Name = "colCodTarjeta";
            this.colCodTarjeta.Visible = true;
            this.colCodTarjeta.VisibleIndex = 3;
            this.colCodTarjeta.Width = 93;
            // 
            // colnom_tarjeta
            // 
            this.colnom_tarjeta.Caption = "Descripcion";
            this.colnom_tarjeta.FieldName = "nom_tarjeta";
            this.colnom_tarjeta.Name = "colnom_tarjeta";
            this.colnom_tarjeta.Visible = true;
            this.colnom_tarjeta.VisibleIndex = 0;
            this.colnom_tarjeta.Width = 818;
            // 
            // colporc_comision
            // 
            this.colporc_comision.Caption = "% Comision";
            this.colporc_comision.FieldName = "porc_comision";
            this.colporc_comision.Name = "colporc_comision";
            this.colporc_comision.Visible = true;
            this.colporc_comision.VisibleIndex = 1;
            this.colporc_comision.Width = 131;
            // 
            // colestado
            // 
            this.colestado.Caption = "estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 2;
            this.colestado.Width = 109;
            // 
            // FrmAca_Tarjeta_cred_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.Menu);
            this.Name = "FrmAca_Tarjeta_cred_Cons";
            this.Text = "Consulta Tarjeta";
            this.Load += new System.EventHandler(this.FrmAca_Tarjeta_cred_Cons_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTarjeta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlTarjeta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTarjeta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTarjeta;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTarjeta;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_tarjeta;
        private DevExpress.XtraGrid.Columns.GridColumn colporc_comision;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
    }
}