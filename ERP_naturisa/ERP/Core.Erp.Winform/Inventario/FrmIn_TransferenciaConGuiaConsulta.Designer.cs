namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_TransferenciaConGuiaConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_TransferenciaConGuiaConsulta));
            this.ultrTransFerencia = new DevExpress.XtraGrid.GridControl();
            this.gridViewTransferencias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdTransferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tr_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sucursal_Origen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bodega_Origen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sucursal_Destino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bodega_Destino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbImagen = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ultrTransFerencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // ultrTransFerencia
            // 
            this.ultrTransFerencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultrTransFerencia.Location = new System.Drawing.Point(0, 154);
            this.ultrTransFerencia.MainView = this.gridViewTransferencias;
            this.ultrTransFerencia.Name = "ultrTransFerencia";
            this.ultrTransFerencia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbImagen});
            this.ultrTransFerencia.Size = new System.Drawing.Size(992, 371);
            this.ultrTransFerencia.TabIndex = 3;
            this.ultrTransFerencia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransferencias});
            // 
            // gridViewTransferencias
            // 
            this.gridViewTransferencias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdTransferencia,
            this.tr_fecha,
            this.Sucursal_Origen,
            this.Bodega_Origen,
            this.Sucursal_Destino,
            this.Bodega_Destino,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridViewTransferencias.GridControl = this.ultrTransFerencia;
            this.gridViewTransferencias.GroupCount = 2;
            this.gridViewTransferencias.Name = "gridViewTransferencias";
            this.gridViewTransferencias.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewTransferencias.OptionsBehavior.Editable = false;
            this.gridViewTransferencias.OptionsView.ShowAutoFilterRow = true;
            this.gridViewTransferencias.OptionsView.ShowGroupPanel = false;
            this.gridViewTransferencias.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Sucursal_Origen, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Bodega_Origen, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.IdTransferencia, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewTransferencias.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewTransferencias_RowCellStyle);
            // 
            // IdTransferencia
            // 
            this.IdTransferencia.Caption = "# Transferencia";
            this.IdTransferencia.FieldName = "IdTransferencia";
            this.IdTransferencia.Name = "IdTransferencia";
            this.IdTransferencia.Visible = true;
            this.IdTransferencia.VisibleIndex = 0;
            this.IdTransferencia.Width = 103;
            // 
            // tr_fecha
            // 
            this.tr_fecha.Caption = "Fecha";
            this.tr_fecha.FieldName = "tr_fecha";
            this.tr_fecha.Name = "tr_fecha";
            this.tr_fecha.Visible = true;
            this.tr_fecha.VisibleIndex = 1;
            this.tr_fecha.Width = 77;
            // 
            // Sucursal_Origen
            // 
            this.Sucursal_Origen.Caption = "Sucursal Origen";
            this.Sucursal_Origen.FieldName = "Sucursal_Origen";
            this.Sucursal_Origen.Name = "Sucursal_Origen";
            this.Sucursal_Origen.Visible = true;
            this.Sucursal_Origen.VisibleIndex = 2;
            this.Sucursal_Origen.Width = 147;
            // 
            // Bodega_Origen
            // 
            this.Bodega_Origen.Caption = "Bodega Origen";
            this.Bodega_Origen.FieldName = "Bodega_Origen";
            this.Bodega_Origen.Name = "Bodega_Origen";
            this.Bodega_Origen.Visible = true;
            this.Bodega_Origen.VisibleIndex = 2;
            this.Bodega_Origen.Width = 147;
            // 
            // Sucursal_Destino
            // 
            this.Sucursal_Destino.Caption = "Sucursal Destino";
            this.Sucursal_Destino.FieldName = "Sucursal_Destino";
            this.Sucursal_Destino.Name = "Sucursal_Destino";
            this.Sucursal_Destino.Visible = true;
            this.Sucursal_Destino.VisibleIndex = 2;
            this.Sucursal_Destino.Width = 181;
            // 
            // Bodega_Destino
            // 
            this.Bodega_Destino.Caption = "Bodega Destino";
            this.Bodega_Destino.FieldName = "Bodega_Destino";
            this.Bodega_Destino.Name = "Bodega_Destino";
            this.Bodega_Destino.Visible = true;
            this.Bodega_Destino.VisibleIndex = 3;
            this.Bodega_Destino.Width = 181;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Estado aprobación";
            this.gridColumn1.FieldName = "EstadoAprobacion_cat";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "# Egr";
            this.gridColumn2.FieldName = "IdNumMovi_Ing_Egr_Inven_Origen";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 72;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "# Ing";
            this.gridColumn3.FieldName = "IdNumMovi_Ing_Egr_Inven_Destino";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            this.gridColumn3.Width = 72;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Estado egreso";
            this.gridColumn4.FieldName = "IdEstadoAproba_egr";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            this.gridColumn4.Width = 72;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Estado ingreso";
            this.gridColumn5.FieldName = "IdEstadoAproba_ing";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 9;
            this.gridColumn5.Width = 97;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Observación";
            this.gridColumn6.FieldName = "tr_Observacion";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 257;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Usuario";
            this.gridColumn7.FieldName = "IdUsuario";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "ID Guia";
            this.gridColumn8.FieldName = "IdGuia";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            this.gridColumn8.Width = 93;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2019, 12, 25, 0, 0, 0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(992, 154);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 2;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_beiCerrar = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Error16x16.png");
            // 
            // cmbImagen
            // 
            this.cmbImagen.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmbImagen.AutoHeight = false;
            this.cmbImagen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImagen.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.cmbImagen.LargeImages = this.imageList1;
            this.cmbImagen.Name = "cmbImagen";
            this.cmbImagen.ReadOnly = true;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tuvo error";
            this.gridColumn9.ColumnEdit = this.cmbImagen;
            this.gridColumn9.FieldName = "TuvoError";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 10;
            // 
            // FrmIn_TransferenciaConGuiaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 525);
            this.Controls.Add(this.ultrTransFerencia);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmIn_TransferenciaConGuiaConsulta";
            this.Text = "FrmIn_TransferenciaConGuiaConsulta";
            this.Load += new System.EventHandler(this.FrmIn_TransferenciaConGuiaConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultrTransFerencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ultrTransFerencia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransferencias;
        private DevExpress.XtraGrid.Columns.GridColumn IdTransferencia;
        private DevExpress.XtraGrid.Columns.GridColumn tr_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal_Origen;
        private DevExpress.XtraGrid.Columns.GridColumn Bodega_Origen;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal_Destino;
        private DevExpress.XtraGrid.Columns.GridColumn Bodega_Destino;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImagen;
    }
}