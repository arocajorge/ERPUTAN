namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_AnioFiscal
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlAFiscal = new DevExpress.XtraGrid.GridControl();
            this.gridViewAFiscal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdanioFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.af_fechaIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.af_fechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.af_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.af_ctaUtilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAFiscal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAFiscal)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_anular = true;
            this.ucGe_Menu.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu.Enable_boton_consultar = true;
            this.ucGe_Menu.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu.Enable_boton_Duplicar = true;
            this.ucGe_Menu.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu.Enable_boton_GenerarXml = true;
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 4, 15, 11, 51, 48, 848);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2015, 6, 15, 11, 51, 48, 848);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(495, 116);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_event_btnAnular_ItemClick);
            this.ucGe_Menu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_event_btnImprimir_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 338);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(495, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlAFiscal);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 116);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(495, 222);
            this.panelControl1.TabIndex = 2;
            // 
            // gridControlAFiscal
            // 
            this.gridControlAFiscal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAFiscal.Location = new System.Drawing.Point(2, 2);
            this.gridControlAFiscal.MainView = this.gridViewAFiscal;
            this.gridControlAFiscal.Name = "gridControlAFiscal";
            this.gridControlAFiscal.Size = new System.Drawing.Size(491, 218);
            this.gridControlAFiscal.TabIndex = 5;
            this.gridControlAFiscal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAFiscal});
            // 
            // gridViewAFiscal
            // 
            this.gridViewAFiscal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdanioFiscal,
            this.af_fechaIni,
            this.af_fechaFin,
            this.af_estado,
            this.af_ctaUtilidad});
            this.gridViewAFiscal.GridControl = this.gridControlAFiscal;
            this.gridViewAFiscal.Name = "gridViewAFiscal";
            this.gridViewAFiscal.OptionsBehavior.Editable = false;
            this.gridViewAFiscal.OptionsView.ShowAutoFilterRow = true;
            this.gridViewAFiscal.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewAFiscal_RowCellStyle);
            this.gridViewAFiscal.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewAFiscal_FocusedRowChanged);
            // 
            // IdanioFiscal
            // 
            this.IdanioFiscal.Caption = "Año Fiscal";
            this.IdanioFiscal.FieldName = "IdanioFiscal";
            this.IdanioFiscal.Name = "IdanioFiscal";
            this.IdanioFiscal.OptionsColumn.AllowEdit = false;
            this.IdanioFiscal.Visible = true;
            this.IdanioFiscal.VisibleIndex = 0;
            this.IdanioFiscal.Width = 148;
            // 
            // af_fechaIni
            // 
            this.af_fechaIni.Caption = "Fecha Inicio";
            this.af_fechaIni.FieldName = "af_fechaIni";
            this.af_fechaIni.Name = "af_fechaIni";
            this.af_fechaIni.OptionsColumn.AllowEdit = false;
            this.af_fechaIni.Visible = true;
            this.af_fechaIni.VisibleIndex = 1;
            this.af_fechaIni.Width = 148;
            // 
            // af_fechaFin
            // 
            this.af_fechaFin.Caption = "Fecha Fin";
            this.af_fechaFin.FieldName = "af_fechaFin";
            this.af_fechaFin.Name = "af_fechaFin";
            this.af_fechaFin.OptionsColumn.AllowEdit = false;
            this.af_fechaFin.Visible = true;
            this.af_fechaFin.VisibleIndex = 2;
            this.af_fechaFin.Width = 226;
            // 
            // af_estado
            // 
            this.af_estado.Caption = "Estado";
            this.af_estado.FieldName = "af_estado";
            this.af_estado.Name = "af_estado";
            this.af_estado.OptionsColumn.AllowEdit = false;
            this.af_estado.Visible = true;
            this.af_estado.VisibleIndex = 3;
            this.af_estado.Width = 70;
            // 
            // af_ctaUtilidad
            // 
            this.af_ctaUtilidad.Caption = "Cta. Utilidad";
            this.af_ctaUtilidad.FieldName = "af_ctaUtilidad";
            this.af_ctaUtilidad.Name = "af_ctaUtilidad";
            this.af_ctaUtilidad.OptionsColumn.AllowEdit = false;
            // 
            // frmCon_AnioFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 364);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCon_AnioFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Año Fiscal";
            this.Load += new System.EventHandler(this.frmCon_AnioFiscal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAFiscal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAFiscal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlAFiscal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn IdanioFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn af_fechaIni;
        private DevExpress.XtraGrid.Columns.GridColumn af_fechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn af_estado;
        private DevExpress.XtraGrid.Columns.GridColumn af_ctaUtilidad;


    }
}