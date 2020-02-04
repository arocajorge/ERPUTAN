namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_responsable_Cons
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
            this.gc_Responsable = new DevExpress.XtraGrid.GridControl();
            this.gv_Responsable = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Nom_responsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Responsable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Responsable)).BeginInit();
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
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde = new System.DateTime(2017, 1, 1, 11, 1, 56, 516);
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta = new System.DateTime(2017, 3, 1, 11, 1, 56, 516);
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario1.Name = "ucGe_Menu_Mantenimiento_x_usuario1";
            this.ucGe_Menu_Mantenimiento_x_usuario1.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Size = new System.Drawing.Size(684, 116);
            this.ucGe_Menu_Mantenimiento_x_usuario1.TabIndex = 0;
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
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 406);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(684, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // gc_Responsable
            // 
            this.gc_Responsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Responsable.Location = new System.Drawing.Point(0, 116);
            this.gc_Responsable.MainView = this.gv_Responsable;
            this.gc_Responsable.Name = "gc_Responsable";
            this.gc_Responsable.Size = new System.Drawing.Size(684, 290);
            this.gc_Responsable.TabIndex = 2;
            this.gc_Responsable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Responsable});
            // 
            // gv_Responsable
            // 
            this.gv_Responsable.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdResponsable,
            this.col_Nom_responsable,
            this.col_Estado,
            this.col_IdPersona});
            this.gv_Responsable.GridControl = this.gc_Responsable;
            this.gv_Responsable.Name = "gv_Responsable";
            this.gv_Responsable.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_Responsable_RowClick);
            this.gv_Responsable.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gv_Responsable_RowCellStyle);
            // 
            // col_IdResponsable
            // 
            this.col_IdResponsable.Caption = "IdResponsable";
            this.col_IdResponsable.FieldName = "IdResponsable";
            this.col_IdResponsable.Name = "col_IdResponsable";
            this.col_IdResponsable.Visible = true;
            this.col_IdResponsable.VisibleIndex = 0;
            this.col_IdResponsable.Width = 81;
            // 
            // col_Nom_responsable
            // 
            this.col_Nom_responsable.Caption = "Nombre";
            this.col_Nom_responsable.FieldName = "Nom_responsable";
            this.col_Nom_responsable.Name = "col_Nom_responsable";
            this.col_Nom_responsable.Visible = true;
            this.col_Nom_responsable.VisibleIndex = 1;
            this.col_Nom_responsable.Width = 512;
            // 
            // col_Estado
            // 
            this.col_Estado.Caption = "Estado";
            this.col_Estado.FieldName = "Estado";
            this.col_Estado.Name = "col_Estado";
            this.col_Estado.Visible = true;
            this.col_Estado.VisibleIndex = 2;
            this.col_Estado.Width = 73;
            // 
            // col_IdPersona
            // 
            this.col_IdPersona.Caption = "IdPersona";
            this.col_IdPersona.FieldName = "IdPersona";
            this.col_IdPersona.Name = "col_IdPersona";
            // 
            // FrmIn_responsable_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 432);
            this.Controls.Add(this.gc_Responsable);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario1);
            this.Name = "FrmIn_responsable_Cons";
            this.Text = "FrmIn_responsable_Cons";
            this.Load += new System.EventHandler(this.FrmIn_responsable_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Responsable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Responsable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl gc_Responsable;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Responsable;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn col_Nom_responsable;
        private DevExpress.XtraGrid.Columns.GridColumn col_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdPersona;
    }
}