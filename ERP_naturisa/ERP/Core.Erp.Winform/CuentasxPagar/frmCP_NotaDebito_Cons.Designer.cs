namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_NotaDebito_Cons
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
            this.gridControlDebito = new DevExpress.XtraGrid.GridControl();
            this.gridViewDebito = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCbteCble_Nota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_FechaNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_Autorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_Nota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_subtotal_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_subtotal_siniva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcn_baseImponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_clas_prove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdClaseProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_nota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoFlujo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_tipo_flujo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDebito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDebito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_flujo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 454);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1017, 26);
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 3, 18, 14, 53, 18, 842);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 5, 18, 14, 53, 18, 842);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(1017, 155);
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
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = true;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = true;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnImpExcel_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImpExcel_ItemClick(this.ucGe_Menu_event_btnImpExcel_ItemClick);
            // 
            // gridControlDebito
            // 
            this.gridControlDebito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDebito.Location = new System.Drawing.Point(0, 155);
            this.gridControlDebito.MainView = this.gridViewDebito;
            this.gridControlDebito.Name = "gridControlDebito";
            this.gridControlDebito.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_tipo_flujo});
            this.gridControlDebito.Size = new System.Drawing.Size(1017, 299);
            this.gridControlDebito.TabIndex = 3;
            this.gridControlDebito.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDebito});
            // 
            // gridViewDebito
            // 
            this.gridViewDebito.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCbteCble_Nota,
            this.colnomProveedor,
            this.colcn_FechaNota,
            this.colcn_fecha,
            this.colcn_Autorizacion,
            this.colcn_Nota,
            this.colcn_observacion,
            this.colcn_total,
            this.colSaldo,
            this.colIdProveedor,
            this.colcn_subtotal_iva,
            this.colcn_subtotal_siniva,
            this.colcn_baseImponible,
            this.colIdUsuario,
            this.colEstado,
            this.coldescripcion_clas_prove,
            this.colIdClaseProveedor,
            this.colcod_nota,
            this.colTipoFlujo,
            this.colCheck});
            this.gridViewDebito.CustomizationFormBounds = new System.Drawing.Rectangle(861, 459, 210, 172);
            this.gridViewDebito.GridControl = this.gridControlDebito;
            this.gridViewDebito.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cn_total", this.colcn_total, "{0:c2}")});
            this.gridViewDebito.Name = "gridViewDebito";
            this.gridViewDebito.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDebito.OptionsView.ShowFooter = true;
            this.gridViewDebito.OptionsView.ShowGroupPanel = false;
            this.gridViewDebito.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewDebito_RowCellStyle);
            this.gridViewDebito.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDebito_FocusedRowChanged);
            this.gridViewDebito.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewDebito_CellValueChanged);
            this.gridViewDebito.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewDebito_CellValueChanging);
            // 
            // colIdCbteCble_Nota
            // 
            this.colIdCbteCble_Nota.Caption = "IdCbteCble";
            this.colIdCbteCble_Nota.FieldName = "IdCbteCble_Nota";
            this.colIdCbteCble_Nota.Name = "colIdCbteCble_Nota";
            this.colIdCbteCble_Nota.OptionsColumn.AllowEdit = false;
            this.colIdCbteCble_Nota.OptionsColumn.ReadOnly = true;
            this.colIdCbteCble_Nota.Visible = true;
            this.colIdCbteCble_Nota.VisibleIndex = 0;
            this.colIdCbteCble_Nota.Width = 45;
            // 
            // colnomProveedor
            // 
            this.colnomProveedor.Caption = "Proveedor";
            this.colnomProveedor.FieldName = "nomProveedor";
            this.colnomProveedor.Name = "colnomProveedor";
            this.colnomProveedor.OptionsColumn.AllowEdit = false;
            this.colnomProveedor.OptionsColumn.ReadOnly = true;
            this.colnomProveedor.Visible = true;
            this.colnomProveedor.VisibleIndex = 2;
            this.colnomProveedor.Width = 184;
            // 
            // colcn_FechaNota
            // 
            this.colcn_FechaNota.Caption = "Fecha vcto.";
            this.colcn_FechaNota.FieldName = "cn_Fecha_vcto";
            this.colcn_FechaNota.Name = "colcn_FechaNota";
            this.colcn_FechaNota.OptionsColumn.AllowEdit = false;
            this.colcn_FechaNota.OptionsColumn.ReadOnly = true;
            this.colcn_FechaNota.Visible = true;
            this.colcn_FechaNota.VisibleIndex = 4;
            this.colcn_FechaNota.Width = 77;
            // 
            // colcn_fecha
            // 
            this.colcn_fecha.Caption = "Fecha";
            this.colcn_fecha.FieldName = "cn_fecha";
            this.colcn_fecha.Name = "colcn_fecha";
            this.colcn_fecha.OptionsColumn.AllowEdit = false;
            this.colcn_fecha.OptionsColumn.ReadOnly = true;
            this.colcn_fecha.Visible = true;
            this.colcn_fecha.VisibleIndex = 3;
            // 
            // colcn_Autorizacion
            // 
            this.colcn_Autorizacion.Caption = "Autorización";
            this.colcn_Autorizacion.FieldName = "cn_Autorizacion";
            this.colcn_Autorizacion.Name = "colcn_Autorizacion";
            this.colcn_Autorizacion.OptionsColumn.AllowEdit = false;
            this.colcn_Autorizacion.OptionsColumn.ReadOnly = true;
            // 
            // colcn_Nota
            // 
            this.colcn_Nota.Caption = "Nota";
            this.colcn_Nota.FieldName = "cn_Nota";
            this.colcn_Nota.Name = "colcn_Nota";
            this.colcn_Nota.OptionsColumn.AllowEdit = false;
            this.colcn_Nota.OptionsColumn.ReadOnly = true;
            this.colcn_Nota.Width = 112;
            // 
            // colcn_observacion
            // 
            this.colcn_observacion.Caption = "Observación";
            this.colcn_observacion.FieldName = "cn_observacion";
            this.colcn_observacion.Name = "colcn_observacion";
            this.colcn_observacion.OptionsColumn.AllowEdit = false;
            this.colcn_observacion.OptionsColumn.ReadOnly = true;
            this.colcn_observacion.Visible = true;
            this.colcn_observacion.VisibleIndex = 5;
            this.colcn_observacion.Width = 143;
            // 
            // colcn_total
            // 
            this.colcn_total.Caption = "Total";
            this.colcn_total.DisplayFormat.FormatString = "n2";
            this.colcn_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcn_total.FieldName = "cn_total";
            this.colcn_total.Name = "colcn_total";
            this.colcn_total.OptionsColumn.AllowEdit = false;
            this.colcn_total.OptionsColumn.ReadOnly = true;
            this.colcn_total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cn_total", "{0:n2}")});
            this.colcn_total.Visible = true;
            this.colcn_total.VisibleIndex = 6;
            this.colcn_total.Width = 93;
            // 
            // colSaldo
            // 
            this.colSaldo.Caption = "Saldo";
            this.colSaldo.DisplayFormat.FormatString = "n2";
            this.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.OptionsColumn.AllowEdit = false;
            this.colSaldo.OptionsColumn.ReadOnly = true;
            this.colSaldo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo", "{0:n2}")});
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 7;
            this.colSaldo.Width = 97;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.OptionsColumn.ReadOnly = true;
            // 
            // colcn_subtotal_iva
            // 
            this.colcn_subtotal_iva.FieldName = "cn_subtotal_iva";
            this.colcn_subtotal_iva.Name = "colcn_subtotal_iva";
            this.colcn_subtotal_iva.OptionsColumn.ReadOnly = true;
            // 
            // colcn_subtotal_siniva
            // 
            this.colcn_subtotal_siniva.FieldName = "cn_subtotal_siniva";
            this.colcn_subtotal_siniva.Name = "colcn_subtotal_siniva";
            this.colcn_subtotal_siniva.OptionsColumn.ReadOnly = true;
            // 
            // colcn_baseImponible
            // 
            this.colcn_baseImponible.FieldName = "cn_baseImponible";
            this.colcn_baseImponible.Name = "colcn_baseImponible";
            this.colcn_baseImponible.OptionsColumn.ReadOnly = true;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.OptionsColumn.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.ReadOnly = true;
            // 
            // coldescripcion_clas_prove
            // 
            this.coldescripcion_clas_prove.Caption = "Clase Proveedor";
            this.coldescripcion_clas_prove.FieldName = "InfoProveedor.descripcion_clas_prove";
            this.coldescripcion_clas_prove.Name = "coldescripcion_clas_prove";
            this.coldescripcion_clas_prove.Width = 106;
            // 
            // colIdClaseProveedor
            // 
            this.colIdClaseProveedor.Caption = "IdClaseProveedor";
            this.colIdClaseProveedor.FieldName = "InfoProveedor.IdClaseProveedor";
            this.colIdClaseProveedor.Name = "colIdClaseProveedor";
            // 
            // colcod_nota
            // 
            this.colcod_nota.Caption = "cod/nota";
            this.colcod_nota.FieldName = "cod_nota";
            this.colcod_nota.Name = "colcod_nota";
            this.colcod_nota.Visible = true;
            this.colcod_nota.VisibleIndex = 1;
            this.colcod_nota.Width = 76;
            // 
            // colTipoFlujo
            // 
            this.colTipoFlujo.Caption = "Tipo flujo";
            this.colTipoFlujo.ColumnEdit = this.cmb_tipo_flujo;
            this.colTipoFlujo.FieldName = "IdTipoFlujo";
            this.colTipoFlujo.Name = "colTipoFlujo";
            this.colTipoFlujo.Visible = true;
            this.colTipoFlujo.VisibleIndex = 8;
            this.colTipoFlujo.Width = 209;
            // 
            // cmb_tipo_flujo
            // 
            this.cmb_tipo_flujo.AutoHeight = false;
            this.cmb_tipo_flujo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipo_flujo.DisplayMember = "Descricion2";
            this.cmb_tipo_flujo.Name = "cmb_tipo_flujo";
            this.cmb_tipo_flujo.ValueMember = "IdTipoFlujo";
            this.cmb_tipo_flujo.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Codigo";
            this.gridColumn1.FieldName = "cod_flujo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 140;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tipo flujo";
            this.gridColumn2.FieldName = "Descricion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 895;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tipo";
            this.gridColumn3.FieldName = "Tipo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 145;
            // 
            // colCheck
            // 
            this.colCheck.Caption = "*";
            this.colCheck.FieldName = "Check";
            this.colCheck.Name = "colCheck";
            // 
            // frmCP_NotaDebito_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 480);
            this.Controls.Add(this.gridControlDebito);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "frmCP_NotaDebito_Cons";
            this.Text = "Consulta Nota Débito al Proveedor";
            this.Load += new System.EventHandler(this.frmCP_NotaDebito_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDebito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDebito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_flujo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraGrid.GridControl gridControlDebito;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDebito;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble_Nota;
        private DevExpress.XtraGrid.Columns.GridColumn colnomProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_FechaNota;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_Autorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_Nota;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_total;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_subtotal_iva;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_subtotal_siniva;
        private DevExpress.XtraGrid.Columns.GridColumn colcn_baseImponible;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_clas_prove;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClaseProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_nota;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoFlujo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_tipo_flujo;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
    }
}