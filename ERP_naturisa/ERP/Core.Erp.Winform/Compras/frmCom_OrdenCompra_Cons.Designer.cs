namespace Core.Erp.Winform.Compras
{
    partial class frmCom_OrdenCompra_Cons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCom_OrdenCompra_Cons));
            this.gridControlOrdenCompra = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrdenCompra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_NumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_plazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colap_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nom_Comprador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado_pendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEn_guia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbImgGuia = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageListIconos = new System.Windows.Forms.ImageList(this.components);
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_imprimir = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbImgIcon = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdenCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImgGuia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImgIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlOrdenCompra
            // 
            this.gridControlOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrdenCompra.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlOrdenCompra.Location = new System.Drawing.Point(0, 0);
            this.gridControlOrdenCompra.MainView = this.gridViewOrdenCompra;
            this.gridControlOrdenCompra.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlOrdenCompra.Name = "gridControlOrdenCompra";
            this.gridControlOrdenCompra.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbImgIcon,
            this.cmbImgGuia,
            this.cmb_imprimir});
            this.gridControlOrdenCompra.Size = new System.Drawing.Size(1555, 345);
            this.gridControlOrdenCompra.TabIndex = 10;
            this.gridControlOrdenCompra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrdenCompra});
            // 
            // gridViewOrdenCompra
            // 
            this.gridViewOrdenCompra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colIdOrdenCompra,
            this.coloc_NumDocumento,
            this.coloc_plazo,
            this.coloc_fecha,
            this.coloc_observacion,
            this.colEstado,
            this.coltotal,
            this.colap_descripcion,
            this.colpr_nombre,
            this.Nom_Comprador,
            this.colEstado_pendiente,
            this.colEn_guia,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridViewOrdenCompra.CustomizationFormBounds = new System.Drawing.Rectangle(538, 416, 216, 185);
            this.gridViewOrdenCompra.GridControl = this.gridControlOrdenCompra;
            this.gridViewOrdenCompra.Images = this.imageListIconos;
            this.gridViewOrdenCompra.Name = "gridViewOrdenCompra";
            this.gridViewOrdenCompra.OptionsBehavior.ReadOnly = true;
            this.gridViewOrdenCompra.OptionsView.ShowAutoFilterRow = true;
            this.gridViewOrdenCompra.OptionsView.ShowGroupPanel = false;
            this.gridViewOrdenCompra.OptionsView.ShowViewCaption = true;
            this.gridViewOrdenCompra.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdOrdenCompra, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewOrdenCompra.ViewCaption = "Listado de Ordenes de Compra";
            this.gridViewOrdenCompra.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewOrdenCompra_RowClick);
            this.gridViewOrdenCompra.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewOrdenCompra_RowCellStyle);
            this.gridViewOrdenCompra.DoubleClick += new System.EventHandler(this.gridViewOrdenCompra_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sucursal";
            this.gridColumn1.FieldName = "Su_Descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 132;
            // 
            // colIdOrdenCompra
            // 
            this.colIdOrdenCompra.Caption = "#OC";
            this.colIdOrdenCompra.FieldName = "IdOrdenCompra";
            this.colIdOrdenCompra.Name = "colIdOrdenCompra";
            this.colIdOrdenCompra.OptionsColumn.ReadOnly = true;
            this.colIdOrdenCompra.Visible = true;
            this.colIdOrdenCompra.VisibleIndex = 2;
            this.colIdOrdenCompra.Width = 79;
            // 
            // coloc_NumDocumento
            // 
            this.coloc_NumDocumento.AppearanceCell.Options.UseTextOptions = true;
            this.coloc_NumDocumento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.coloc_NumDocumento.Caption = "Código";
            this.coloc_NumDocumento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coloc_NumDocumento.FieldName = "Codigo";
            this.coloc_NumDocumento.Name = "coloc_NumDocumento";
            this.coloc_NumDocumento.OptionsColumn.ReadOnly = true;
            this.coloc_NumDocumento.Visible = true;
            this.coloc_NumDocumento.VisibleIndex = 3;
            this.coloc_NumDocumento.Width = 88;
            // 
            // coloc_plazo
            // 
            this.coloc_plazo.Caption = "Plazo";
            this.coloc_plazo.FieldName = "oc_plazo";
            this.coloc_plazo.Name = "coloc_plazo";
            this.coloc_plazo.OptionsColumn.ReadOnly = true;
            this.coloc_plazo.Visible = true;
            this.coloc_plazo.VisibleIndex = 6;
            this.coloc_plazo.Width = 64;
            // 
            // coloc_fecha
            // 
            this.coloc_fecha.Caption = "Fecha";
            this.coloc_fecha.FieldName = "oc_fecha";
            this.coloc_fecha.Name = "coloc_fecha";
            this.coloc_fecha.OptionsColumn.ReadOnly = true;
            this.coloc_fecha.Visible = true;
            this.coloc_fecha.VisibleIndex = 1;
            this.coloc_fecha.Width = 93;
            // 
            // coloc_observacion
            // 
            this.coloc_observacion.Caption = "Observación";
            this.coloc_observacion.FieldName = "oc_observacion";
            this.coloc_observacion.Name = "coloc_observacion";
            this.coloc_observacion.OptionsColumn.ReadOnly = true;
            this.coloc_observacion.Visible = true;
            this.coloc_observacion.VisibleIndex = 7;
            this.coloc_observacion.Width = 213;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.ReadOnly = true;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 12;
            this.colEstado.Width = 82;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.DisplayFormat.FormatString = "n2";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "Total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.ReadOnly = true;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 9;
            this.coltotal.Width = 78;
            // 
            // colap_descripcion
            // 
            this.colap_descripcion.Caption = "Est. Aprobación";
            this.colap_descripcion.FieldName = "EstadoAprobacion";
            this.colap_descripcion.Name = "colap_descripcion";
            this.colap_descripcion.OptionsColumn.ReadOnly = true;
            this.colap_descripcion.Visible = true;
            this.colap_descripcion.VisibleIndex = 10;
            this.colap_descripcion.Width = 90;
            // 
            // colpr_nombre
            // 
            this.colpr_nombre.Caption = "Proveedor";
            this.colpr_nombre.FieldName = "pe_nombreCompleto";
            this.colpr_nombre.Name = "colpr_nombre";
            this.colpr_nombre.OptionsColumn.ReadOnly = true;
            this.colpr_nombre.Visible = true;
            this.colpr_nombre.VisibleIndex = 4;
            this.colpr_nombre.Width = 220;
            // 
            // Nom_Comprador
            // 
            this.Nom_Comprador.Caption = "Comprador";
            this.Nom_Comprador.FieldName = "Descripcion";
            this.Nom_Comprador.Name = "Nom_Comprador";
            this.Nom_Comprador.OptionsColumn.ReadOnly = true;
            this.Nom_Comprador.Visible = true;
            this.Nom_Comprador.VisibleIndex = 8;
            this.Nom_Comprador.Width = 236;
            // 
            // colEstado_pendiente
            // 
            this.colEstado_pendiente.Caption = "Est. Cierre";
            this.colEstado_pendiente.FieldName = "EstadoCierre";
            this.colEstado_pendiente.Name = "colEstado_pendiente";
            this.colEstado_pendiente.OptionsColumn.ReadOnly = true;
            this.colEstado_pendiente.Visible = true;
            this.colEstado_pendiente.VisibleIndex = 11;
            this.colEstado_pendiente.Width = 87;
            // 
            // colEn_guia
            // 
            this.colEn_guia.Caption = "Guía";
            this.colEn_guia.ColumnEdit = this.cmbImgGuia;
            this.colEn_guia.FieldName = "en_guia";
            this.colEn_guia.Name = "colEn_guia";
            this.colEn_guia.Visible = true;
            this.colEn_guia.VisibleIndex = 13;
            this.colEn_guia.Width = 66;
            // 
            // cmbImgGuia
            // 
            this.cmbImgGuia.AutoHeight = false;
            this.cmbImgGuia.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImgGuia.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "TIENE GUIA", 1)});
            this.cmbImgGuia.Name = "cmbImgGuia";
            this.cmbImgGuia.ReadOnly = true;
            this.cmbImgGuia.SmallImages = this.imageListIconos;
            this.cmbImgGuia.Click += new System.EventHandler(this.cmbImgGuia_Click);
            // 
            // imageListIconos
            // 
            this.imageListIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIconos.ImageStream")));
            this.imageListIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIconos.Images.SetKeyName(0, "buscar_doc_64x64.png");
            this.imageListIconos.Images.SetKeyName(1, "Lupa_16x16.png");
            this.imageListIconos.Images.SetKeyName(2, "imprimir_32x32.png");
            // 
            // gridColumn2
            // 
            this.gridColumn2.ColumnEdit = this.cmb_imprimir;
            this.gridColumn2.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn2.ImageIndex = 2;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 14;
            this.gridColumn2.Width = 94;
            // 
            // cmb_imprimir
            // 
            this.cmb_imprimir.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_imprimir.AutoHeight = false;
            this.cmb_imprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_imprimir.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_imprimir.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, 2)});
            this.cmb_imprimir.Name = "cmb_imprimir";
            this.cmb_imprimir.ReadOnly = true;
            this.cmb_imprimir.SmallImages = this.imageListIconos;
            this.cmb_imprimir.Click += new System.EventHandler(this.cmb_imprimir_Click);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Término";
            this.gridColumn3.FieldName = "TerminoPago";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 112;
            // 
            // cmbImgIcon
            // 
            this.cmbImgIcon.AutoHeight = false;
            this.cmbImgIcon.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImgIcon.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.cmbImgIcon.LargeImages = this.imageListIconos;
            this.cmbImgIcon.Name = "cmbImgIcon";
            this.cmbImgIcon.SmallImages = this.imageListIconos;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2019, 11, 12, 0, 0, 0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2019, 11, 19, 0, 0, 0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1555, 183);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 12;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_beiCerrar = DevExpress.XtraBars.BarItemVisibility.Always;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_delegate_beiCerrar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_beiCerrar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_delegate_beiCerrar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1555, 182);
            this.panel1.TabIndex = 13;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 527);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1555, 32);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlOrdenCompra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 182);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1555, 345);
            this.panel2.TabIndex = 16;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Usuario ult modificación";
            this.gridColumn4.FieldName = "IdUsuarioUltMod";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Fecha ult modificación";
            this.gridColumn5.FieldName = "Fecha_UltMod";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // frmCom_OrdenCompra_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCom_OrdenCompra_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Ordenes de Compra";
            this.Load += new System.EventHandler(this.frmCom_OrdenCompraConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdenCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImgGuia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImgIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlOrdenCompra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_NumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_plazo;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colap_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_nombre;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn Nom_Comprador;
        private System.Windows.Forms.ImageList imageListIconos;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImgIcon;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_pendiente;
        private DevExpress.XtraGrid.Columns.GridColumn colEn_guia;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImgGuia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_imprimir;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}