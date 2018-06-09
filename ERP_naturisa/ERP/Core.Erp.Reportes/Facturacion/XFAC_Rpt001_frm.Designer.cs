namespace Core.Erp.Reportes.Facturacion
{
    partial class XFAC_Rpt001_frm
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
            this.pivotGridControlDocumento = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridFieldSucursal = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldCliente = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldAnio = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldTotal = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldDocumento = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldCantidad = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField7 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField8 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField9 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField10 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField11 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField12 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField13 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.ucFa_Menu = new Core.Erp.Reportes.Controles.UCFa_Menu_Reportes();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageData = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.pivotGridFieldVendedor = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPageData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pivotGridControlDocumento
            // 
            this.pivotGridControlDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControlDocumento.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridFieldSucursal,
            this.pivotGridFieldCliente,
            this.pivotGridFieldAnio,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridFieldTotal,
            this.pivotGridFieldDocumento,
            this.pivotGridFieldCantidad,
            this.pivotGridField1,
            this.pivotGridField4,
            this.pivotGridField5,
            this.pivotGridField6,
            this.pivotGridField7,
            this.pivotGridField8,
            this.pivotGridField9,
            this.pivotGridField10,
            this.pivotGridField11,
            this.pivotGridField12,
            this.pivotGridField13,
            this.pivotGridFieldVendedor});
            this.pivotGridControlDocumento.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControlDocumento.Name = "pivotGridControlDocumento";
            this.pivotGridControlDocumento.Size = new System.Drawing.Size(1059, 322);
            this.pivotGridControlDocumento.TabIndex = 0;
            // 
            // pivotGridFieldSucursal
            // 
            this.pivotGridFieldSucursal.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridFieldSucursal.AreaIndex = 0;
            this.pivotGridFieldSucursal.Caption = "Sucursal";
            this.pivotGridFieldSucursal.FieldName = "Su_Descripcion";
            this.pivotGridFieldSucursal.Name = "pivotGridFieldSucursal";
            // 
            // pivotGridFieldCliente
            // 
            this.pivotGridFieldCliente.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridFieldCliente.AreaIndex = 1;
            this.pivotGridFieldCliente.Caption = "Cliente";
            this.pivotGridFieldCliente.FieldName = "nombreCliente";
            this.pivotGridFieldCliente.Name = "pivotGridFieldCliente";
            // 
            // pivotGridFieldAnio
            // 
            this.pivotGridFieldAnio.AreaIndex = 7;
            this.pivotGridFieldAnio.Caption = "Año";
            this.pivotGridFieldAnio.FieldName = "AnioFiscal";
            this.pivotGridFieldAnio.Name = "pivotGridFieldAnio";
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.AreaIndex = 8;
            this.pivotGridField2.Caption = "Mes";
            this.pivotGridField2.FieldName = "NombreMes";
            this.pivotGridField2.Name = "pivotGridField2";
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.AreaIndex = 0;
            this.pivotGridField3.Caption = "Producto";
            this.pivotGridField3.FieldName = "nombreProducto";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // pivotGridFieldTotal
            // 
            this.pivotGridFieldTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridFieldTotal.AreaIndex = 0;
            this.pivotGridFieldTotal.Caption = "Total Vta";
            this.pivotGridFieldTotal.FieldName = "vt_total";
            this.pivotGridFieldTotal.Name = "pivotGridFieldTotal";
            // 
            // pivotGridFieldDocumento
            // 
            this.pivotGridFieldDocumento.AreaIndex = 2;
            this.pivotGridFieldDocumento.Caption = "Num Documento";
            this.pivotGridFieldDocumento.FieldName = "numDocumento";
            this.pivotGridFieldDocumento.Name = "pivotGridFieldDocumento";
            // 
            // pivotGridFieldCantidad
            // 
            this.pivotGridFieldCantidad.AreaIndex = 1;
            this.pivotGridFieldCantidad.Caption = "Cantidad";
            this.pivotGridFieldCantidad.FieldName = "vt_cantidad";
            this.pivotGridFieldCantidad.Name = "pivotGridFieldCantidad";
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.AreaIndex = 3;
            this.pivotGridField1.Caption = "Tipo Documento";
            this.pivotGridField1.FieldName = "IdTipoDocumento";
            this.pivotGridField1.Name = "pivotGridField1";
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.AreaIndex = 5;
            this.pivotGridField4.Caption = "Precio";
            this.pivotGridField4.CellFormat.FormatString = "c2";
            this.pivotGridField4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField4.FieldName = "vt_PrecioFinal";
            this.pivotGridField4.Name = "pivotGridField4";
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.AreaIndex = 6;
            this.pivotGridField5.Caption = "SubTotal";
            this.pivotGridField5.CellFormat.FormatString = "c2";
            this.pivotGridField5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField5.FieldName = "vt_Subtotal";
            this.pivotGridField5.Name = "pivotGridField5";
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.AreaIndex = 9;
            this.pivotGridField6.Caption = "IVA";
            this.pivotGridField6.FieldName = "vt_iva";
            this.pivotGridField6.Name = "pivotGridField6";
            // 
            // pivotGridField7
            // 
            this.pivotGridField7.AreaIndex = 10;
            this.pivotGridField7.Caption = "Categoria";
            this.pivotGridField7.FieldName = "ca_Categoria";
            this.pivotGridField7.Name = "pivotGridField7";
            // 
            // pivotGridField8
            // 
            this.pivotGridField8.AreaIndex = 11;
            this.pivotGridField8.Caption = "Linea";
            this.pivotGridField8.FieldName = "nom_linea";
            this.pivotGridField8.Name = "pivotGridField8";
            // 
            // pivotGridField9
            // 
            this.pivotGridField9.AreaIndex = 12;
            this.pivotGridField9.Caption = "Grupo";
            this.pivotGridField9.FieldName = "nom_grupo";
            this.pivotGridField9.Name = "pivotGridField9";
            // 
            // pivotGridField10
            // 
            this.pivotGridField10.AreaIndex = 13;
            this.pivotGridField10.Caption = "SubGrupo";
            this.pivotGridField10.FieldName = "nom_subgrupo";
            this.pivotGridField10.Name = "pivotGridField10";
            // 
            // pivotGridField11
            // 
            this.pivotGridField11.AreaIndex = 14;
            this.pivotGridField11.Caption = "Tipo de Cliente";
            this.pivotGridField11.FieldName = "Descripcion_tip_cliente";
            this.pivotGridField11.Name = "pivotGridField11";
            // 
            // pivotGridField12
            // 
            this.pivotGridField12.AreaIndex = 15;
            this.pivotGridField12.Caption = "Observación";
            this.pivotGridField12.FieldName = "vt_Observacion";
            this.pivotGridField12.Name = "pivotGridField12";
            // 
            // pivotGridField13
            // 
            this.pivotGridField13.AreaIndex = 16;
            this.pivotGridField13.Caption = "Fecha ";
            this.pivotGridField13.CellFormat.FormatString = "d";
            this.pivotGridField13.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pivotGridField13.FieldName = "vt_fecha";
            this.pivotGridField13.Name = "pivotGridField13";
            // 
            // ucFa_Menu
            // 
            this.ucFa_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFa_Menu.EnableBotonImprimir = true;
            this.ucFa_Menu.EnableBotonRefrescar = true;
            this.ucFa_Menu.EnableBotonSalir = true;
            this.ucFa_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucFa_Menu.Name = "ucFa_Menu";
            this.ucFa_Menu.Size = new System.Drawing.Size(1065, 93);
            this.ucFa_Menu.TabIndex = 2;
            this.ucFa_Menu.VisibleBotonImprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucFa_Menu.VisibleBotonRefrescar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucFa_Menu.VisibleBotonSalir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucFa_Menu.Visiblecmb_TipoNota = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucFa_Menu.VisibleCmbCliente = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucFa_Menu.VisibleCmbMotivo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucFa_Menu.VisibleCmbSucursal = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucFa_Menu.VisibleCmbTipoDocumento = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucFa_Menu.VisibleCmbTipoPago = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucFa_Menu.VisibleCmbTipoProducto = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucFa_Menu.VisibleGrupoFecha = true;
            this.ucFa_Menu.VisibleGrupoMotivo = false;
            this.ucFa_Menu.VisibleGrupoOtros = true;
            this.ucFa_Menu.VisibleGrupoSucursal = true;
            this.ucFa_Menu.VisibleTipo = true;
            this.ucFa_Menu.event_btnConsultar_ItemClick += new Core.Erp.Reportes.Controles.UCFa_Menu_Reportes.delegate_btnConsultar_ItemClick(this.ucFa_Menu_event_btnConsultar_ItemClick);
            this.ucFa_Menu.event_btnImprimir_ItemClick += new Core.Erp.Reportes.Controles.UCFa_Menu_Reportes.delegate_btnImprimir_ItemClick(this.ucFa_Menu_event_btnImprimir_ItemClick);
            this.ucFa_Menu.event_btnSalir_ItemClick += new Core.Erp.Reportes.Controles.UCFa_Menu_Reportes.delegate_btnSalir_ItemClick(this.ucFa_Menu_event_btnSalir_ItemClick);
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 93);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.SelectedTabPage = this.xtraTabPageData;
            this.xtraTabControlMain.Size = new System.Drawing.Size(1065, 350);
            this.xtraTabControlMain.TabIndex = 3;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageData,
            this.xtraTabPage2});
            // 
            // xtraTabPageData
            // 
            this.xtraTabPageData.Controls.Add(this.pivotGridControlDocumento);
            this.xtraTabPageData.Name = "xtraTabPageData";
            this.xtraTabPageData.Size = new System.Drawing.Size(1059, 322);
            this.xtraTabPageData.Text = "Datos";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(0, 0);
            this.xtraTabPage2.Text = "Grafico";
            // 
            // pivotGridFieldVendedor
            // 
            this.pivotGridFieldVendedor.AreaIndex = 4;
            this.pivotGridFieldVendedor.Caption = "Vendedor";
            this.pivotGridFieldVendedor.FieldName = "Vendedor";
            this.pivotGridFieldVendedor.Name = "pivotGridFieldVendedor";
            // 
            // XFAC_Rpt001_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 443);
            this.Controls.Add(this.xtraTabControlMain);
            this.Controls.Add(this.ucFa_Menu);
            this.Name = "XFAC_Rpt001_frm";
            this.Text = "XFAC_Rpt001_frm";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPageData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlDocumento;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldSucursal;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldCliente;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldAnio;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldTotal;
        private Controles.UCFa_Menu_Reportes ucFa_Menu;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldDocumento;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldCantidad;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField7;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField8;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField9;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField10;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField11;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField12;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField13;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageData;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldVendedor;
    }
}