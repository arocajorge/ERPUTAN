namespace Core.Erp.Reportes.CuentasxPagar
{
    partial class XCXP_Rpt018_frm
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
            this.pgcCXP = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.colpvg_IdCbteCble_Ogiro = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_co_fechaOg = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_Documento = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_co_FechaFactura = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_Num_Autorizacion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_NumRetencion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_co_subtotal_iva = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_co_subtotal_siniva = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_co_valoriva = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_IdOrden_giro_Tipo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_nom_TipoDocumento = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_nom_proveedor = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_nom_sucursal = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_co_descripcion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_re_valor_retencion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_re_Porcen_retencion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_re_Codigo_impuesto = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_re_baseRetencion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_re_tipoRet = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_IdRetencion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_co_total = new DevExpress.XtraPivotGrid.PivotGridField();
            this.col_co_valorpagar = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colpvg_pe_cedulaRuc = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panelMain = new System.Windows.Forms.Panel();
            this.ucCp_Menu_Reportes = new Core.Erp.Reportes.Controles.UCCp_Menu_Reportes();
            ((System.ComponentModel.ISupportInitialize)(this.pgcCXP)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgcCXP
            // 
            this.pgcCXP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgcCXP.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.colpvg_IdCbteCble_Ogiro,
            this.colpvg_co_fechaOg,
            this.colpvg_Documento,
            this.colpvg_co_FechaFactura,
            this.colpvg_Num_Autorizacion,
            this.colpvg_NumRetencion,
            this.colpvg_co_subtotal_iva,
            this.colpvg_co_subtotal_siniva,
            this.colpvg_co_valoriva,
            this.colpvg_IdOrden_giro_Tipo,
            this.colpvg_nom_TipoDocumento,
            this.colpvg_nom_proveedor,
            this.colpvg_nom_sucursal,
            this.colpvg_co_descripcion,
            this.colpvg_re_valor_retencion,
            this.colpvg_re_Porcen_retencion,
            this.colpvg_re_Codigo_impuesto,
            this.colpvg_re_baseRetencion,
            this.colpvg_re_tipoRet,
            this.colpvg_IdRetencion,
            this.colpvg_co_total,
            this.col_co_valorpagar,
            this.colpvg_pe_cedulaRuc});
            this.pgcCXP.Location = new System.Drawing.Point(0, 0);
            this.pgcCXP.Name = "pgcCXP";
            this.pgcCXP.OptionsBehavior.HorizontalScrolling = DevExpress.XtraPivotGrid.PivotGridScrolling.Control;
            this.pgcCXP.OptionsPrint.MergeColumnFieldValues = false;
            this.pgcCXP.OptionsPrint.MergeRowFieldValues = false;
            this.pgcCXP.OptionsPrint.PageSettings.Landscape = true;
            this.pgcCXP.OptionsPrint.PageSettings.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            this.pgcCXP.OptionsPrint.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A2;
            this.pgcCXP.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pgcCXP.OptionsPrint.PrintUnusedFilterFields = false;
            this.pgcCXP.OptionsView.GroupFieldsInCustomizationWindow = false;
            this.pgcCXP.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.pgcCXP.OptionsView.HeaderHeightOffset = 0;
            this.pgcCXP.OptionsView.HeaderWidthOffset = 0;
            this.pgcCXP.OptionsView.ShowColumnHeaders = false;
            this.pgcCXP.OptionsView.ShowDataHeaders = false;
            this.pgcCXP.OptionsView.ShowFilterHeaders = false;
            this.pgcCXP.OptionsView.ShowRowTotals = false;
            this.pgcCXP.Size = new System.Drawing.Size(1302, 366);
            this.pgcCXP.TabIndex = 0;
            // 
            // colpvg_IdCbteCble_Ogiro
            // 
            this.colpvg_IdCbteCble_Ogiro.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colpvg_IdCbteCble_Ogiro.AreaIndex = 2;
            this.colpvg_IdCbteCble_Ogiro.Caption = "Deuda";
            this.colpvg_IdCbteCble_Ogiro.FieldName = "IdCbteCble_Ogiro";
            this.colpvg_IdCbteCble_Ogiro.Name = "colpvg_IdCbteCble_Ogiro";
            // 
            // colpvg_co_fechaOg
            // 
            this.colpvg_co_fechaOg.AreaIndex = 0;
            this.colpvg_co_fechaOg.Caption = "Fecha OG";
            this.colpvg_co_fechaOg.FieldName = "co_fechaOg";
            this.colpvg_co_fechaOg.Name = "colpvg_co_fechaOg";
            // 
            // colpvg_Documento
            // 
            this.colpvg_Documento.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colpvg_Documento.AreaIndex = 3;
            this.colpvg_Documento.Caption = "Documento/Fac";
            this.colpvg_Documento.FieldName = "Documento";
            this.colpvg_Documento.Name = "colpvg_Documento";
            // 
            // colpvg_co_FechaFactura
            // 
            this.colpvg_co_FechaFactura.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colpvg_co_FechaFactura.AreaIndex = 4;
            this.colpvg_co_FechaFactura.Caption = "Fecha Doc.";
            this.colpvg_co_FechaFactura.FieldName = "co_FechaFactura";
            this.colpvg_co_FechaFactura.Name = "colpvg_co_FechaFactura";
            this.colpvg_co_FechaFactura.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.colpvg_co_FechaFactura.ValueFormat.FormatString = "d";
            this.colpvg_co_FechaFactura.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // colpvg_Num_Autorizacion
            // 
            this.colpvg_Num_Autorizacion.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colpvg_Num_Autorizacion.AreaIndex = 5;
            this.colpvg_Num_Autorizacion.Caption = "Aut. SRI";
            this.colpvg_Num_Autorizacion.FieldName = "Num_Autorizacion";
            this.colpvg_Num_Autorizacion.Name = "colpvg_Num_Autorizacion";
            this.colpvg_Num_Autorizacion.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // colpvg_NumRetencion
            // 
            this.colpvg_NumRetencion.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colpvg_NumRetencion.AreaIndex = 6;
            this.colpvg_NumRetencion.Caption = "Nro. Ret";
            this.colpvg_NumRetencion.FieldName = "NumRetencion";
            this.colpvg_NumRetencion.Name = "colpvg_NumRetencion";
            this.colpvg_NumRetencion.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // colpvg_co_subtotal_iva
            // 
            this.colpvg_co_subtotal_iva.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colpvg_co_subtotal_iva.AreaIndex = 7;
            this.colpvg_co_subtotal_iva.Caption = "Base 12";
            this.colpvg_co_subtotal_iva.FieldName = "co_subtotal_iva";
            this.colpvg_co_subtotal_iva.Name = "colpvg_co_subtotal_iva";
            this.colpvg_co_subtotal_iva.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // colpvg_co_subtotal_siniva
            // 
            this.colpvg_co_subtotal_siniva.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colpvg_co_subtotal_siniva.AreaIndex = 8;
            this.colpvg_co_subtotal_siniva.Caption = "Base 0";
            this.colpvg_co_subtotal_siniva.FieldName = "co_subtotal_siniva";
            this.colpvg_co_subtotal_siniva.Name = "colpvg_co_subtotal_siniva";
            this.colpvg_co_subtotal_siniva.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // colpvg_co_valoriva
            // 
            this.colpvg_co_valoriva.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colpvg_co_valoriva.AreaIndex = 9;
            this.colpvg_co_valoriva.Caption = "IVA";
            this.colpvg_co_valoriva.FieldName = "co_valoriva";
            this.colpvg_co_valoriva.Name = "colpvg_co_valoriva";
            // 
            // colpvg_IdOrden_giro_Tipo
            // 
            this.colpvg_IdOrden_giro_Tipo.AreaIndex = 1;
            this.colpvg_IdOrden_giro_Tipo.Caption = "ID Tipo Doc.";
            this.colpvg_IdOrden_giro_Tipo.FieldName = "IdOrden_giro_Tipo";
            this.colpvg_IdOrden_giro_Tipo.Name = "colpvg_IdOrden_giro_Tipo";
            // 
            // colpvg_nom_TipoDocumento
            // 
            this.colpvg_nom_TipoDocumento.AreaIndex = 2;
            this.colpvg_nom_TipoDocumento.Caption = "Tipo Doc.";
            this.colpvg_nom_TipoDocumento.FieldName = "nom_TipoDocumento";
            this.colpvg_nom_TipoDocumento.Name = "colpvg_nom_TipoDocumento";
            // 
            // colpvg_nom_proveedor
            // 
            this.colpvg_nom_proveedor.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colpvg_nom_proveedor.AreaIndex = 0;
            this.colpvg_nom_proveedor.Caption = "Proveedor";
            this.colpvg_nom_proveedor.FieldName = "nom_proveedor";
            this.colpvg_nom_proveedor.Name = "colpvg_nom_proveedor";
            // 
            // colpvg_nom_sucursal
            // 
            this.colpvg_nom_sucursal.AreaIndex = 3;
            this.colpvg_nom_sucursal.Caption = "Sucursal";
            this.colpvg_nom_sucursal.FieldName = "nom_sucursal";
            this.colpvg_nom_sucursal.Name = "colpvg_nom_sucursal";
            // 
            // colpvg_co_descripcion
            // 
            this.colpvg_co_descripcion.AreaIndex = 4;
            this.colpvg_co_descripcion.Caption = "Nom Cod SRI";
            this.colpvg_co_descripcion.FieldName = "co_descripcion";
            this.colpvg_co_descripcion.Name = "colpvg_co_descripcion";
            // 
            // colpvg_re_valor_retencion
            // 
            this.colpvg_re_valor_retencion.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colpvg_re_valor_retencion.AreaIndex = 0;
            this.colpvg_re_valor_retencion.Caption = "Valor Ret.";
            this.colpvg_re_valor_retencion.FieldName = "re_valor_retencion";
            this.colpvg_re_valor_retencion.Name = "colpvg_re_valor_retencion";
            // 
            // colpvg_re_Porcen_retencion
            // 
            this.colpvg_re_Porcen_retencion.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.colpvg_re_Porcen_retencion.AreaIndex = 2;
            this.colpvg_re_Porcen_retencion.Caption = "% Ret";
            this.colpvg_re_Porcen_retencion.FieldName = "re_Porcen_retencion";
            this.colpvg_re_Porcen_retencion.Name = "colpvg_re_Porcen_retencion";
            // 
            // colpvg_re_Codigo_impuesto
            // 
            this.colpvg_re_Codigo_impuesto.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.colpvg_re_Codigo_impuesto.AreaIndex = 1;
            this.colpvg_re_Codigo_impuesto.Caption = "cod SRI";
            this.colpvg_re_Codigo_impuesto.FieldName = "re_Codigo_impuesto";
            this.colpvg_re_Codigo_impuesto.Name = "colpvg_re_Codigo_impuesto";
            // 
            // colpvg_re_baseRetencion
            // 
            this.colpvg_re_baseRetencion.AreaIndex = 5;
            this.colpvg_re_baseRetencion.Caption = "Base Ret.";
            this.colpvg_re_baseRetencion.FieldName = "re_baseRetencion";
            this.colpvg_re_baseRetencion.Name = "colpvg_re_baseRetencion";
            // 
            // colpvg_re_tipoRet
            // 
            this.colpvg_re_tipoRet.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.colpvg_re_tipoRet.AreaIndex = 0;
            this.colpvg_re_tipoRet.Caption = "Tipo Ret.";
            this.colpvg_re_tipoRet.FieldName = "re_tipoRet";
            this.colpvg_re_tipoRet.Name = "colpvg_re_tipoRet";
            // 
            // colpvg_IdRetencion
            // 
            this.colpvg_IdRetencion.AreaIndex = 6;
            this.colpvg_IdRetencion.Caption = "ID Ret";
            this.colpvg_IdRetencion.FieldName = "IdRetencion";
            this.colpvg_IdRetencion.Name = "colpvg_IdRetencion";
            // 
            // colpvg_co_total
            // 
            this.colpvg_co_total.AreaIndex = 7;
            this.colpvg_co_total.Caption = "Valor Factura";
            this.colpvg_co_total.FieldName = "co_total";
            this.colpvg_co_total.Name = "colpvg_co_total";
            // 
            // col_co_valorpagar
            // 
            this.col_co_valorpagar.AreaIndex = 8;
            this.col_co_valorpagar.Caption = "Valor a Pagar";
            this.col_co_valorpagar.FieldName = "co_valorpagar";
            this.col_co_valorpagar.Name = "col_co_valorpagar";
            // 
            // colpvg_pe_cedulaRuc
            // 
            this.colpvg_pe_cedulaRuc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colpvg_pe_cedulaRuc.AreaIndex = 1;
            this.colpvg_pe_cedulaRuc.Caption = "Ruc";
            this.colpvg_pe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.colpvg_pe_cedulaRuc.Name = "colpvg_pe_cedulaRuc";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.pgcCXP);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 95);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1302, 366);
            this.panelMain.TabIndex = 1;
            // 
            // ucCp_Menu_Reportes
            // 
            this.ucCp_Menu_Reportes.CaptionCheck1 = "Check1";
            this.ucCp_Menu_Reportes.CaptionCheck2 = "Check2";
            this.ucCp_Menu_Reportes.CaptionCheck3 = "Check3";
            this.ucCp_Menu_Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucCp_Menu_Reportes.Location = new System.Drawing.Point(0, 0);
            this.ucCp_Menu_Reportes.Name = "ucCp_Menu_Reportes";
            this.ucCp_Menu_Reportes.Size = new System.Drawing.Size(1302, 95);
            this.ucCp_Menu_Reportes.TabIndex = 0;
            this.ucCp_Menu_Reportes.Text_dtpDesde = "Desde: ";
            this.ucCp_Menu_Reportes.Text_dtpHasta = "Hasta:  ";
            this.ucCp_Menu_Reportes.Visble_bei_clase_proveedor = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucCp_Menu_Reportes.Visble_dtpHasta = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucCp_Menu_Reportes.Visible_dtpDesde = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucCp_Menu_Reportes.Visible_groupCheck = false;
            this.ucCp_Menu_Reportes.Visible_Imprimir = true;
            this.ucCp_Menu_Reportes.event_btnRefrescar_ItemClick += new Core.Erp.Reportes.Controles.UCCp_Menu_Reportes.delegate_btnRefrescar_ItemClick(this.ucCp_Menu_Reportes_event_btnRefrescar_ItemClick);
            this.ucCp_Menu_Reportes.event_btnsalir_ItemClick += new Core.Erp.Reportes.Controles.UCCp_Menu_Reportes.delegate_btnsalir_ItemClick(this.ucCp_Menu_Reportes_event_btnsalir_ItemClick);
            this.ucCp_Menu_Reportes.event_btnimprimir_ItemClick += new Core.Erp.Reportes.Controles.UCCp_Menu_Reportes.delegate_btnimprimir_ItemClick(this.ucCp_Menu_Reportes_event_btnimprimir_ItemClick);
            // 
            // XCXP_Rpt018_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 461);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucCp_Menu_Reportes);
            this.Name = "XCXP_Rpt018_frm";
            this.Text = "Matriz de Retenciones";
            this.Load += new System.EventHandler(this.XCXP_Rpt018_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pgcCXP)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCCp_Menu_Reportes ucCp_Menu_Reportes;
        private DevExpress.XtraPivotGrid.PivotGridControl pgcCXP;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_IdCbteCble_Ogiro;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_co_fechaOg;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_Documento;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_co_FechaFactura;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_Num_Autorizacion;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_NumRetencion;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_co_subtotal_iva;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_co_subtotal_siniva;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_co_valoriva;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_IdOrden_giro_Tipo;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_nom_TipoDocumento;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_nom_proveedor;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_nom_sucursal;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_co_descripcion;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_re_valor_retencion;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_re_Porcen_retencion;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_re_Codigo_impuesto;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_re_baseRetencion;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_re_tipoRet;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_IdRetencion;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_co_total;
        private DevExpress.XtraPivotGrid.PivotGridField col_co_valorpagar;
        private DevExpress.XtraPivotGrid.PivotGridField colpvg_pe_cedulaRuc;
        private System.Windows.Forms.Panel panelMain;
    }
}