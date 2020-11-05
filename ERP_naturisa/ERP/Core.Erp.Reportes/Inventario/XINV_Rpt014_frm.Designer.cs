namespace Core.Erp.Reportes.Inventario
{
    partial class XINV_Rpt014_frm
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
            this.ucInv_MenuReportes_21 = new Core.Erp.Reportes.Controles.UCInv_MenuReportes_2();
            this.PVGrid_orden_compra = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldcmfecha = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldprdescripcion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fielddmcantidad = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNomCentroCosto = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNomSubcentro1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.PVGrid_orden_compra)).BeginInit();
            this.SuspendLayout();
            // 
            // ucInv_MenuReportes_21
            // 
            this.ucInv_MenuReportes_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucInv_MenuReportes_21.EnableBotonConsultar = true;
            this.ucInv_MenuReportes_21.EnableBotonImprimir = true;
            this.ucInv_MenuReportes_21.EnableBotonSalir = true;
            this.ucInv_MenuReportes_21.Location = new System.Drawing.Point(0, 0);
            this.ucInv_MenuReportes_21.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucInv_MenuReportes_21.Name = "ucInv_MenuReportes_21";
            this.ucInv_MenuReportes_21.Size = new System.Drawing.Size(1653, 117);
            this.ucInv_MenuReportes_21.TabIndex = 0;
            this.ucInv_MenuReportes_21.VisiblebtnImprimir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucInv_MenuReportes_21.VisiblebtnSalir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucInv_MenuReportes_21.VisibleCmb_CentroCosto = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucInv_MenuReportes_21.VisibleCmb_SubCentro = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucInv_MenuReportes_21.VisibleCmbBodega = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucInv_MenuReportes_21.VisibleCmbProducto = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucInv_MenuReportes_21.VisibleCmbProveedor = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucInv_MenuReportes_21.VisibleCmbSucursal = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucInv_MenuReportes_21.VisibleCmbTipoMovInve = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucInv_MenuReportes_21.VisibleDtpDesde = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucInv_MenuReportes_21.VisibleDtpHasta = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucInv_MenuReportes_21.VisibleGrupoBotones = true;
            this.ucInv_MenuReportes_21.VisibleGrupoCategoriaLinea = false;
            this.ucInv_MenuReportes_21.VisibleGrupoCentro_Subcentro_costo = true;
            this.ucInv_MenuReportes_21.VisibleGrupoFecha = true;
            this.ucInv_MenuReportes_21.VisibleGrupoMovimiento = false;
            this.ucInv_MenuReportes_21.VisibleGrupoSucursal = true;
            this.ucInv_MenuReportes_21.event_tnConsultar_ItemClick += new Core.Erp.Reportes.Controles.UCInv_MenuReportes_2.delegate_btnConsultar_ItemClick(this.ucInv_MenuReportes_21_event_tnConsultar_ItemClick);
            this.ucInv_MenuReportes_21.event_btnSalir_ItemClick += new Core.Erp.Reportes.Controles.UCInv_MenuReportes_2.delegate_btnSalir_ItemClick(this.ucInv_MenuReportes_21_event_btnSalir_ItemClick);
            // 
            // PVGrid_orden_compra
            // 
            this.PVGrid_orden_compra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PVGrid_orden_compra.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldcmfecha,
            this.fieldprdescripcion,
            this.fielddmcantidad,
            this.fieldNomCentroCosto,
            this.fieldNomSubcentro1,
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField4,
            this.pivotGridField5});
            this.PVGrid_orden_compra.Location = new System.Drawing.Point(0, 117);
            this.PVGrid_orden_compra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PVGrid_orden_compra.Name = "PVGrid_orden_compra";
            this.PVGrid_orden_compra.Size = new System.Drawing.Size(1653, 607);
            this.PVGrid_orden_compra.TabIndex = 1;
            this.PVGrid_orden_compra.Click += new System.EventHandler(this.PVGrid_orden_compra_Click);
            // 
            // fieldcmfecha
            // 
            this.fieldcmfecha.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldcmfecha.AreaIndex = 1;
            this.fieldcmfecha.Caption = "Fecha";
            this.fieldcmfecha.CellFormat.FormatString = "d";
            this.fieldcmfecha.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fieldcmfecha.FieldName = "cm_fecha";
            this.fieldcmfecha.Name = "fieldcmfecha";
            this.fieldcmfecha.TotalCellFormat.FormatString = "d";
            this.fieldcmfecha.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fieldcmfecha.TotalValueFormat.FormatString = "d";
            this.fieldcmfecha.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fieldcmfecha.ValueFormat.FormatString = "d";
            this.fieldcmfecha.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // fieldprdescripcion
            // 
            this.fieldprdescripcion.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldprdescripcion.AreaIndex = 0;
            this.fieldprdescripcion.Caption = "Producto";
            this.fieldprdescripcion.FieldName = "pr_descripcion";
            this.fieldprdescripcion.Name = "fieldprdescripcion";
            this.fieldprdescripcion.Width = 250;
            // 
            // fielddmcantidad
            // 
            this.fielddmcantidad.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fielddmcantidad.AreaIndex = 0;
            this.fielddmcantidad.Caption = "Cantidad";
            this.fielddmcantidad.CellFormat.FormatString = "n2";
            this.fielddmcantidad.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fielddmcantidad.FieldName = "dm_cantidad";
            this.fielddmcantidad.Name = "fielddmcantidad";
            // 
            // fieldNomCentroCosto
            // 
            this.fieldNomCentroCosto.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldNomCentroCosto.AreaIndex = 0;
            this.fieldNomCentroCosto.Caption = "Centro Costo";
            this.fieldNomCentroCosto.FieldName = "NomCentroCosto";
            this.fieldNomCentroCosto.Name = "fieldNomCentroCosto";
            this.fieldNomCentroCosto.Width = 200;
            // 
            // fieldNomSubcentro1
            // 
            this.fieldNomSubcentro1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldNomSubcentro1.AreaIndex = 1;
            this.fieldNomSubcentro1.Caption = "Sub Centro Costo";
            this.fieldNomSubcentro1.FieldName = "NomSubcentro";
            this.fieldNomSubcentro1.Name = "fieldNomSubcentro1";
            this.fieldNomSubcentro1.Width = 200;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Bodega";
            this.pivotGridField1.FieldName = "bo_Descripcion";
            this.pivotGridField1.Name = "pivotGridField1";
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.AreaIndex = 1;
            this.pivotGridField2.Caption = "Sucursal";
            this.pivotGridField2.FieldName = "Su_Descripcion";
            this.pivotGridField2.Name = "pivotGridField2";
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.AreaIndex = 2;
            this.pivotGridField3.Caption = "Estado";
            this.pivotGridField3.FieldName = "IdEstadoAproba";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.AreaIndex = 3;
            this.pivotGridField4.Caption = "# Movimiento";
            this.pivotGridField4.FieldName = "IdNumMovi";
            this.pivotGridField4.Name = "pivotGridField4";
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField5.AreaIndex = 1;
            this.pivotGridField5.Caption = "U. Medida";
            this.pivotGridField5.FieldName = "NomUnidadMedida";
            this.pivotGridField5.Name = "pivotGridField5";
            // 
            // XINV_Rpt014_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 724);
            this.Controls.Add(this.PVGrid_orden_compra);
            this.Controls.Add(this.ucInv_MenuReportes_21);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "XINV_Rpt014_frm";
            this.Text = "XINV_Rpt014_frm";
            this.Load += new System.EventHandler(this.XINV_Rpt014_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PVGrid_orden_compra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCInv_MenuReportes_2 ucInv_MenuReportes_21;
        private DevExpress.XtraPivotGrid.PivotGridControl PVGrid_orden_compra;
        private DevExpress.XtraPivotGrid.PivotGridField fieldcmfecha;
        private DevExpress.XtraPivotGrid.PivotGridField fieldprdescripcion;
        private DevExpress.XtraPivotGrid.PivotGridField fielddmcantidad;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNomCentroCosto;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNomSubcentro1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
    }
}