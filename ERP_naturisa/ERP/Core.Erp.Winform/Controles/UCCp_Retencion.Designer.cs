namespace Core.Erp.Winform.Controles
{
    partial class UCCp_Retencion
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabRetencion = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelGridRet = new System.Windows.Forms.Panel();
            this.gridControl_SRI = new DevExpress.XtraGrid.GridControl();
            this.gridView_SRI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCodigo_SRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_CodigoSRI_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCodigo_SRI_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescriConcate_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigoSRI_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_codigoBase_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_descripcion_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_porRetencion_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoSRI_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_f_vigente_desde_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_f_vigente_hasta_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_estado_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_porRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseImponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigoSRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModificable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNumDoc = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_Generar_XML = new DevExpress.XtraEditors.SimpleButton();
            this.txtIdRetencion = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.UC_numRetencion = new Core.Erp.Winform.Controles.UCGe_NumeroDocTrans();
            this.dtp_fechaEmisionRetencion = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UC_CbteCble_Retencion = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.tabRetencion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelGridRet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SRI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_SRI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CodigoSRI_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.panelNumDoc.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdRetencion.Properties)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRetencion
            // 
            this.tabRetencion.Controls.Add(this.tabPage1);
            this.tabRetencion.Controls.Add(this.tabPage2);
            this.tabRetencion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRetencion.Location = new System.Drawing.Point(0, 0);
            this.tabRetencion.Name = "tabRetencion";
            this.tabRetencion.SelectedIndex = 0;
            this.tabRetencion.Size = new System.Drawing.Size(826, 276);
            this.tabRetencion.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelGridRet);
            this.tabPage1.Controls.Add(this.panelNumDoc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(818, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos para Retención";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelGridRet
            // 
            this.panelGridRet.Controls.Add(this.gridControl_SRI);
            this.panelGridRet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridRet.Location = new System.Drawing.Point(3, 60);
            this.panelGridRet.Name = "panelGridRet";
            this.panelGridRet.Size = new System.Drawing.Size(812, 187);
            this.panelGridRet.TabIndex = 1;
            // 
            // gridControl_SRI
            // 
            this.gridControl_SRI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_SRI.Location = new System.Drawing.Point(0, 0);
            this.gridControl_SRI.MainView = this.gridView_SRI;
            this.gridControl_SRI.Name = "gridControl_SRI";
            this.gridControl_SRI.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_CodigoSRI_grid});
            this.gridControl_SRI.Size = new System.Drawing.Size(812, 187);
            this.gridControl_SRI.TabIndex = 0;
            this.gridControl_SRI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_SRI});
            this.gridControl_SRI.Click += new System.EventHandler(this.gridControl_SRI_Click);
            // 
            // gridView_SRI
            // 
            this.gridView_SRI.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdProveedor,
            this.colIdCodigo_SRI,
            this.colTipo,
            this.colco_porRetencion,
            this.colBaseImponible,
            this.colMontoRetencion,
            this.colcodigoSRI,
            this.colIdCtaCble,
            this.colModificable});
            this.gridView_SRI.GridControl = this.gridControl_SRI;
            this.gridView_SRI.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BaseImponible", this.colBaseImponible, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MontoRetencion", this.colMontoRetencion, "")});
            this.gridView_SRI.Name = "gridView_SRI";
            this.gridView_SRI.OptionsSelection.MultiSelect = true;
            this.gridView_SRI.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_SRI.OptionsView.ShowFooter = true;
            this.gridView_SRI.OptionsView.ShowGroupPanel = false;
            this.gridView_SRI.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_SRI_FocusedRowChanged);
            this.gridView_SRI.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_SRI_CellValueChanged);
            this.gridView_SRI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_SRI_KeyDown);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            // 
            // colIdCodigo_SRI
            // 
            this.colIdCodigo_SRI.Caption = "Retención SRI";
            this.colIdCodigo_SRI.ColumnEdit = this.cmb_CodigoSRI_grid;
            this.colIdCodigo_SRI.FieldName = "IdCodigo_SRI";
            this.colIdCodigo_SRI.Name = "colIdCodigo_SRI";
            this.colIdCodigo_SRI.Visible = true;
            this.colIdCodigo_SRI.VisibleIndex = 0;
            this.colIdCodigo_SRI.Width = 648;
            // 
            // cmb_CodigoSRI_grid
            // 
            this.cmb_CodigoSRI_grid.AutoHeight = false;
            this.cmb_CodigoSRI_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_CodigoSRI_grid.Name = "cmb_CodigoSRI_grid";
            this.cmb_CodigoSRI_grid.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCodigo_SRI_grid,
            this.coldescriConcate_grid,
            this.colcodigoSRI_grid,
            this.colco_codigoBase_grid,
            this.colco_descripcion_grid,
            this.colco_porRetencion_grid,
            this.colIdTipoSRI_grid,
            this.colIdCtaCble_grid,
            this.colco_f_vigente_desde_grid,
            this.colco_f_vigente_hasta_grid,
            this.colco_estado_grid});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCodigo_SRI_grid
            // 
            this.colIdCodigo_SRI_grid.Caption = "IdCodigo_SRI";
            this.colIdCodigo_SRI_grid.FieldName = "IdCodigo_SRI";
            this.colIdCodigo_SRI_grid.Name = "colIdCodigo_SRI_grid";
            this.colIdCodigo_SRI_grid.Visible = true;
            this.colIdCodigo_SRI_grid.VisibleIndex = 1;
            this.colIdCodigo_SRI_grid.Width = 83;
            // 
            // coldescriConcate_grid
            // 
            this.coldescriConcate_grid.Caption = "Descripción";
            this.coldescriConcate_grid.FieldName = "descriConcate";
            this.coldescriConcate_grid.Name = "coldescriConcate_grid";
            this.coldescriConcate_grid.Visible = true;
            this.coldescriConcate_grid.VisibleIndex = 0;
            this.coldescriConcate_grid.Width = 517;
            // 
            // colcodigoSRI_grid
            // 
            this.colcodigoSRI_grid.Caption = "Código SRI";
            this.colcodigoSRI_grid.FieldName = "codigoSRI";
            this.colcodigoSRI_grid.Name = "colcodigoSRI_grid";
            this.colcodigoSRI_grid.Visible = true;
            this.colcodigoSRI_grid.VisibleIndex = 2;
            this.colcodigoSRI_grid.Width = 81;
            // 
            // colco_codigoBase_grid
            // 
            this.colco_codigoBase_grid.Caption = "Código Base";
            this.colco_codigoBase_grid.FieldName = "co_codigoBase";
            this.colco_codigoBase_grid.Name = "colco_codigoBase_grid";
            this.colco_codigoBase_grid.Visible = true;
            this.colco_codigoBase_grid.VisibleIndex = 3;
            this.colco_codigoBase_grid.Width = 86;
            // 
            // colco_descripcion_grid
            // 
            this.colco_descripcion_grid.Caption = "Nombre";
            this.colco_descripcion_grid.FieldName = "co_descripcion";
            this.colco_descripcion_grid.Name = "colco_descripcion_grid";
            this.colco_descripcion_grid.Visible = true;
            this.colco_descripcion_grid.VisibleIndex = 4;
            this.colco_descripcion_grid.Width = 210;
            // 
            // colco_porRetencion_grid
            // 
            this.colco_porRetencion_grid.Caption = "% Retención";
            this.colco_porRetencion_grid.FieldName = "co_porRetencion";
            this.colco_porRetencion_grid.Name = "colco_porRetencion_grid";
            this.colco_porRetencion_grid.Visible = true;
            this.colco_porRetencion_grid.VisibleIndex = 5;
            this.colco_porRetencion_grid.Width = 96;
            // 
            // colIdTipoSRI_grid
            // 
            this.colIdTipoSRI_grid.Caption = "IdTipoSRI";
            this.colIdTipoSRI_grid.FieldName = "IdTipoSRI";
            this.colIdTipoSRI_grid.Name = "colIdTipoSRI_grid";
            this.colIdTipoSRI_grid.Visible = true;
            this.colIdTipoSRI_grid.VisibleIndex = 6;
            this.colIdTipoSRI_grid.Width = 107;
            // 
            // colIdCtaCble_grid
            // 
            this.colIdCtaCble_grid.Caption = "IdCtaCble";
            this.colIdCtaCble_grid.FieldName = "IdCtaCble";
            this.colIdCtaCble_grid.Name = "colIdCtaCble_grid";
            // 
            // colco_f_vigente_desde_grid
            // 
            this.colco_f_vigente_desde_grid.Caption = "Fecha Vigente Desde";
            this.colco_f_vigente_desde_grid.FieldName = "co_f_vigente_desde";
            this.colco_f_vigente_desde_grid.Name = "colco_f_vigente_desde_grid";
            // 
            // colco_f_vigente_hasta_grid
            // 
            this.colco_f_vigente_hasta_grid.Caption = "Fecha Vigente Hasta";
            this.colco_f_vigente_hasta_grid.FieldName = "co_f_vigente_hasta";
            this.colco_f_vigente_hasta_grid.Name = "colco_f_vigente_hasta_grid";
            // 
            // colco_estado_grid
            // 
            this.colco_estado_grid.Caption = "Estado";
            this.colco_estado_grid.FieldName = "co_estado";
            this.colco_estado_grid.Name = "colco_estado_grid";
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 1;
            this.colTipo.Width = 116;
            // 
            // colco_porRetencion
            // 
            this.colco_porRetencion.Caption = "%";
            this.colco_porRetencion.FieldName = "co_porRetencion";
            this.colco_porRetencion.Name = "colco_porRetencion";
            this.colco_porRetencion.OptionsColumn.AllowEdit = false;
            this.colco_porRetencion.Visible = true;
            this.colco_porRetencion.VisibleIndex = 2;
            this.colco_porRetencion.Width = 101;
            // 
            // colBaseImponible
            // 
            this.colBaseImponible.Caption = "Base Imponible";
            this.colBaseImponible.FieldName = "BaseImponible";
            this.colBaseImponible.Name = "colBaseImponible";
            this.colBaseImponible.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colBaseImponible.Visible = true;
            this.colBaseImponible.VisibleIndex = 3;
            this.colBaseImponible.Width = 156;
            // 
            // colMontoRetencion
            // 
            this.colMontoRetencion.Caption = "Monto Retención";
            this.colMontoRetencion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoRetencion.FieldName = "MontoRetencion";
            this.colMontoRetencion.Name = "colMontoRetencion";
            this.colMontoRetencion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colMontoRetencion.Visible = true;
            this.colMontoRetencion.VisibleIndex = 4;
            this.colMontoRetencion.Width = 159;
            // 
            // colcodigoSRI
            // 
            this.colcodigoSRI.FieldName = "codigoSRI";
            this.colcodigoSRI.Name = "colcodigoSRI";
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.Caption = "IdCtaCble";
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            // 
            // colModificable
            // 
            this.colModificable.Caption = "Modificable";
            this.colModificable.FieldName = "Modificable";
            this.colModificable.Name = "colModificable";
            this.colModificable.OptionsColumn.AllowEdit = false;
            // 
            // panelNumDoc
            // 
            this.panelNumDoc.Controls.Add(this.UC_numRetencion);
            this.panelNumDoc.Controls.Add(this.panel1);
            this.panelNumDoc.Controls.Add(this.txtIdRetencion);
            this.panelNumDoc.Controls.Add(this.label1);
            this.panelNumDoc.Controls.Add(this.dtp_fechaEmisionRetencion);
            this.panelNumDoc.Controls.Add(this.label32);
            this.panelNumDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNumDoc.Location = new System.Drawing.Point(3, 3);
            this.panelNumDoc.Name = "panelNumDoc";
            this.panelNumDoc.Size = new System.Drawing.Size(812, 57);
            this.panelNumDoc.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_Generar_XML);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(705, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 57);
            this.panel1.TabIndex = 71;
            // 
            // cmb_Generar_XML
            // 
            this.cmb_Generar_XML.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmb_Generar_XML.Image = global::Core.Erp.Winform.Properties.Resources.Xml_32x321;
            this.cmb_Generar_XML.Location = new System.Drawing.Point(0, 0);
            this.cmb_Generar_XML.Name = "cmb_Generar_XML";
            this.cmb_Generar_XML.Size = new System.Drawing.Size(107, 40);
            this.cmb_Generar_XML.TabIndex = 70;
            this.cmb_Generar_XML.Text = "Generar XML";
            this.cmb_Generar_XML.Click += new System.EventHandler(this.cmb_Generar_XML_Click);
            // 
            // txtIdRetencion
            // 
            this.txtIdRetencion.Enabled = false;
            this.txtIdRetencion.Location = new System.Drawing.Point(626, 3);
            this.txtIdRetencion.Name = "txtIdRetencion";
            this.txtIdRetencion.Size = new System.Drawing.Size(73, 20);
            this.txtIdRetencion.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "IdRetencion:";
            // 
            // UC_numRetencion
            // 
            this.UC_numRetencion.IdEstablecimiento = null;
            this.UC_numRetencion.IdPuntoEmision = null;
            this.UC_numRetencion.IdTipoDocumento = Core.Erp.Info.General.Cl_Enumeradores.eTipoDocumento_Talonario.RETEN;
            this.UC_numRetencion.Location = new System.Drawing.Point(192, 5);
            this.UC_numRetencion.Name = "UC_numRetencion";
            this.UC_numRetencion.Size = new System.Drawing.Size(388, 48);
            this.UC_numRetencion.TabIndex = 67;
            // 
            // dtp_fechaEmisionRetencion
            // 
            this.dtp_fechaEmisionRetencion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaEmisionRetencion.Location = new System.Drawing.Point(14, 20);
            this.dtp_fechaEmisionRetencion.Name = "dtp_fechaEmisionRetencion";
            this.dtp_fechaEmisionRetencion.Size = new System.Drawing.Size(92, 20);
            this.dtp_fechaEmisionRetencion.TabIndex = 66;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(11, 5);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(128, 13);
            this.label32.TabIndex = 65;
            this.label32.Text = "Fecha Emisión Retención";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UC_CbteCble_Retencion);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(818, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diario Retención";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UC_CbteCble_Retencion
            // 
            this.UC_CbteCble_Retencion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_CbteCble_Retencion.IdCtaCble_x_Banco = null;
            this.UC_CbteCble_Retencion.Location = new System.Drawing.Point(3, 3);
            this.UC_CbteCble_Retencion.Name = "UC_CbteCble_Retencion";
            this.UC_CbteCble_Retencion.Size = new System.Drawing.Size(812, 244);
            this.UC_CbteCble_Retencion.TabIndex = 0;
            this.UC_CbteCble_Retencion.Visible_Botones = true;
            this.UC_CbteCble_Retencion.Visible_Cabecera = false;
            this.UC_CbteCble_Retencion.Visible_columna_GrupoPuntoCargo = true;
            this.UC_CbteCble_Retencion.Visible_columna_PuntoCargo = true;
            // 
            // UCCp_Retencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabRetencion);
            this.Name = "UCCp_Retencion";
            this.Size = new System.Drawing.Size(826, 276);
            this.Load += new System.EventHandler(this.UCCp_Retencion_Load);
            this.tabRetencion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelGridRet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SRI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_SRI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CodigoSRI_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.panelNumDoc.ResumeLayout(false);
            this.panelNumDoc.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdRetencion.Properties)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRetencion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelGridRet;
        private System.Windows.Forms.Panel panelNumDoc;
        private DevExpress.XtraGrid.GridControl gridControl_SRI;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_SRI;
        private UCCon_GridDiarioContable UC_CbteCble_Retencion;
        private System.Windows.Forms.Label label32;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCodigo_SRI;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_CodigoSRI_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colco_porRetencion;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseImponible;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoRetencion;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigoSRI;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCodigo_SRI_grid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescriConcate_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigoSRI_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colco_codigoBase_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colco_descripcion_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colco_porRetencion_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoSRI_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colco_f_vigente_desde_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colco_f_vigente_hasta_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colco_estado_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        public DevExpress.XtraEditors.TextEdit txtIdRetencion;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtp_fechaEmisionRetencion;
        public UCGe_NumeroDocTrans UC_numRetencion;
        private DevExpress.XtraEditors.SimpleButton cmb_Generar_XML;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn colModificable;
    }
}
