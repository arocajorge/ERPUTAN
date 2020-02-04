namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_GeneracionFile_Banco_x_cxp_Mant
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Winform.frmGe_Esperar), true, true);
            this.panelControlGeneral = new DevExpress.XtraEditors.PanelControl();
            this.tabControlDetalle = new System.Windows.Forms.TabControl();
            this.tabPageOP = new System.Windows.Forms.TabPage();
            this.gridControlDetalleOP = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetalleOP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Colcheck_op = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Colproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colfecha_op = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colestado_op = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColValor_pagado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colobservacion_op = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdOrdenPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstado_Transferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colnom_banco_destino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTipocta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_cmb_banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_banco = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_ba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImprimir_pago_prov = new System.Windows.Forms.ToolStripButton();
            this.btnAgrupar_x_proveedor = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSecuencial = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_total_op = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.chk_selec_op_visible = new DevExpress.XtraEditors.CheckEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechadesde = new System.Windows.Forms.DateTimePicker();
            this.tabPageTrasnferencia = new System.Windows.Forms.TabPage();
            this.cmbCuentaDestino = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colba_Num_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_monto = new DevExpress.XtraEditors.TextEdit();
            this.ultraCmbE_empresaDest = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.em_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPagePreavisoCheq = new System.Windows.Forms.TabPage();
            this.gridControlDetalleCheques = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetalleCheq = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colchecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Cheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_giradoA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbteCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipocbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa_mvba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_total_cheque = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.chk_selec_cheq_visible = new DevExpress.XtraEditors.CheckEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkMostar_che_Preavisados = new DevExpress.XtraEditors.CheckEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechadesde_cheq = new System.Windows.Forms.DateTimePicker();
            this.btn_buscar_cheq = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaHasta_cheq = new System.Windows.Forms.DateTimePicker();
            this.tabPageRRHH = new System.Windows.Forms.TabPage();
            this.gridControlRRHH = new DevExpress.XtraGrid.GridControl();
            this.gridViewRRHH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControlCabecera = new DevExpress.XtraEditors.GroupControl();
            this.cmb_Motivo_Transferencia = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_IdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblMotivo_transferencia = new System.Windows.Forms.Label();
            this.lbNombreFile = new System.Windows.Forms.Label();
            this.txtNombreArc = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.ucBa_Proceso_x_Banco = new Core.Erp.Winform.Controles.UCBa_Proceso_x_Banco();
            this.dtpFEchaPago = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControlObservacion = new DevExpress.XtraEditors.GroupControl();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbRuta = new DevExpress.XtraEditors.ButtonEdit();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGeneral)).BeginInit();
            this.panelControlGeneral.SuspendLayout();
            this.tabControlDetalle.SuspendLayout();
            this.tabPageOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecuencial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_op.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_selec_op_visible.Properties)).BeginInit();
            this.tabPageTrasnferencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCuentaDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_empresaDest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.tabPagePreavisoCheq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleCheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleCheq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_cheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_selec_cheq_visible.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostar_che_Preavisados.Properties)).BeginInit();
            this.tabPageRRHH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRRHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRRHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCabecera)).BeginInit();
            this.groupControlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Motivo_Transferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreArc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlObservacion)).BeginInit();
            this.groupControlObservacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRuta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlGeneral
            // 
            this.panelControlGeneral.Controls.Add(this.tabControlDetalle);
            this.panelControlGeneral.Controls.Add(this.groupControlCabecera);
            this.panelControlGeneral.Controls.Add(this.ucGe_Menu);
            this.panelControlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelControlGeneral.Name = "panelControlGeneral";
            this.panelControlGeneral.Size = new System.Drawing.Size(1066, 488);
            this.panelControlGeneral.TabIndex = 0;
            // 
            // tabControlDetalle
            // 
            this.tabControlDetalle.Controls.Add(this.tabPageOP);
            this.tabControlDetalle.Controls.Add(this.tabPageTrasnferencia);
            this.tabControlDetalle.Controls.Add(this.tabPagePreavisoCheq);
            this.tabControlDetalle.Controls.Add(this.tabPageRRHH);
            this.tabControlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDetalle.Location = new System.Drawing.Point(2, 197);
            this.tabControlDetalle.Name = "tabControlDetalle";
            this.tabControlDetalle.SelectedIndex = 0;
            this.tabControlDetalle.Size = new System.Drawing.Size(1062, 289);
            this.tabControlDetalle.TabIndex = 5;
            // 
            // tabPageOP
            // 
            this.tabPageOP.Controls.Add(this.gridControlDetalleOP);
            this.tabPageOP.Controls.Add(this.toolStrip1);
            this.tabPageOP.Controls.Add(this.panel2);
            this.tabPageOP.Location = new System.Drawing.Point(4, 22);
            this.tabPageOP.Name = "tabPageOP";
            this.tabPageOP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOP.Size = new System.Drawing.Size(1054, 263);
            this.tabPageOP.TabIndex = 0;
            this.tabPageOP.Text = "Pago a proveedores";
            this.tabPageOP.UseVisualStyleBackColor = true;
            // 
            // gridControlDetalleOP
            // 
            this.gridControlDetalleOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDetalleOP.Location = new System.Drawing.Point(3, 92);
            this.gridControlDetalleOP.MainView = this.gridViewDetalleOP;
            this.gridControlDetalleOP.Name = "gridControlDetalleOP";
            this.gridControlDetalleOP.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.cmb_banco});
            this.gridControlDetalleOP.Size = new System.Drawing.Size(1048, 168);
            this.gridControlDetalleOP.TabIndex = 0;
            this.gridControlDetalleOP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalleOP,
            this.gridView1});
            // 
            // gridViewDetalleOP
            // 
            this.gridViewDetalleOP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Colcheck_op,
            this.Colproveedor,
            this.Colfecha_op,
            this.Colestado_op,
            this.ColValor_pagado,
            this.Colobservacion_op,
            this.ColIdOrdenPago,
            this.ColEstado_Transferencia,
            this.Colnom_banco_destino,
            this.ColTipocta,
            this.gridColumn1,
            this.Col_cmb_banco});
            this.gridViewDetalleOP.GridControl = this.gridControlDetalleOP;
            this.gridViewDetalleOP.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Valor", this.ColValor_pagado, "{0:n2}")});
            this.gridViewDetalleOP.Name = "gridViewDetalleOP";
            this.gridViewDetalleOP.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewDetalleOP.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDetalleOP.OptionsView.ShowFooter = true;
            this.gridViewDetalleOP.OptionsView.ShowGroupPanel = false;
            this.gridViewDetalleOP.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewDetalleOP_CellValueChanged);
            this.gridViewDetalleOP.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewDetalleOP_CellValueChanging);
            this.gridViewDetalleOP.RowCountChanged += new System.EventHandler(this.gridViewDetalleOP_RowCountChanged);
            // 
            // Colcheck_op
            // 
            this.Colcheck_op.Caption = "*";
            this.Colcheck_op.ColumnEdit = this.repositoryItemCheckEdit1;
            this.Colcheck_op.FieldName = "check";
            this.Colcheck_op.Name = "Colcheck_op";
            this.Colcheck_op.Visible = true;
            this.Colcheck_op.VisibleIndex = 0;
            this.Colcheck_op.Width = 28;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // Colproveedor
            // 
            this.Colproveedor.Caption = "Proveedor";
            this.Colproveedor.FieldName = "Beneficiario";
            this.Colproveedor.Name = "Colproveedor";
            this.Colproveedor.OptionsColumn.AllowEdit = false;
            this.Colproveedor.Visible = true;
            this.Colproveedor.VisibleIndex = 2;
            this.Colproveedor.Width = 163;
            // 
            // Colfecha_op
            // 
            this.Colfecha_op.Caption = "Fecha OP";
            this.Colfecha_op.FieldName = "fecha_op";
            this.Colfecha_op.Name = "Colfecha_op";
            this.Colfecha_op.OptionsColumn.AllowEdit = false;
            this.Colfecha_op.Visible = true;
            this.Colfecha_op.VisibleIndex = 5;
            this.Colfecha_op.Width = 139;
            // 
            // Colestado_op
            // 
            this.Colestado_op.Caption = "Estado OP";
            this.Colestado_op.FieldName = "Estado_OP";
            this.Colestado_op.Name = "Colestado_op";
            this.Colestado_op.OptionsColumn.AllowEdit = false;
            this.Colestado_op.Visible = true;
            this.Colestado_op.VisibleIndex = 6;
            this.Colestado_op.Width = 139;
            // 
            // ColValor_pagado
            // 
            this.ColValor_pagado.Caption = "Valor OP";
            this.ColValor_pagado.FieldName = "Valor";
            this.ColValor_pagado.Name = "ColValor_pagado";
            this.ColValor_pagado.OptionsColumn.AllowEdit = false;
            this.ColValor_pagado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Valor", "{0:n2}")});
            this.ColValor_pagado.Visible = true;
            this.ColValor_pagado.VisibleIndex = 7;
            this.ColValor_pagado.Width = 81;
            // 
            // Colobservacion_op
            // 
            this.Colobservacion_op.Caption = "Observacion OP";
            this.Colobservacion_op.FieldName = "Observacion_op";
            this.Colobservacion_op.Name = "Colobservacion_op";
            this.Colobservacion_op.OptionsColumn.AllowEdit = false;
            this.Colobservacion_op.Visible = true;
            this.Colobservacion_op.VisibleIndex = 4;
            this.Colobservacion_op.Width = 148;
            // 
            // ColIdOrdenPago
            // 
            this.ColIdOrdenPago.Caption = "#OP";
            this.ColIdOrdenPago.FieldName = "IdOrdenPago";
            this.ColIdOrdenPago.Name = "ColIdOrdenPago";
            this.ColIdOrdenPago.OptionsColumn.AllowEdit = false;
            this.ColIdOrdenPago.Visible = true;
            this.ColIdOrdenPago.VisibleIndex = 1;
            this.ColIdOrdenPago.Width = 54;
            // 
            // ColEstado_Transferencia
            // 
            this.ColEstado_Transferencia.Caption = "Estado Transferencia";
            this.ColEstado_Transferencia.FieldName = "Estado_Transferencia";
            this.ColEstado_Transferencia.Name = "ColEstado_Transferencia";
            this.ColEstado_Transferencia.OptionsColumn.AllowEdit = false;
            this.ColEstado_Transferencia.Width = 133;
            // 
            // Colnom_banco_destino
            // 
            this.Colnom_banco_destino.Caption = "Banco Acreditacion";
            this.Colnom_banco_destino.FieldName = "nom_banco_destino";
            this.Colnom_banco_destino.Name = "Colnom_banco_destino";
            this.Colnom_banco_destino.Width = 133;
            // 
            // ColTipocta
            // 
            this.ColTipocta.Caption = "Tipo Cuenta";
            this.ColTipocta.FieldName = "IdTipoCta_acreditacion_cat";
            this.ColTipocta.Name = "ColTipocta";
            this.ColTipocta.Width = 92;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Referencia";
            this.gridColumn1.FieldName = "Referencia";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 153;
            // 
            // Col_cmb_banco
            // 
            this.Col_cmb_banco.Caption = "Banco Transferencia";
            this.Col_cmb_banco.ColumnEdit = this.cmb_banco;
            this.Col_cmb_banco.FieldName = "IdBanco_cta_Destino_trans";
            this.Col_cmb_banco.Name = "Col_cmb_banco";
            this.Col_cmb_banco.OptionsColumn.AllowEdit = false;
            this.Col_cmb_banco.Width = 126;
            // 
            // cmb_banco
            // 
            this.cmb_banco.AutoHeight = false;
            this.cmb_banco.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_banco.Name = "cmb_banco";
            this.cmb_banco.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_ba_descripcion});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Col_ba_descripcion
            // 
            this.Col_ba_descripcion.Caption = "Banco";
            this.Col_ba_descripcion.FieldName = "ba_descripcion";
            this.Col_ba_descripcion.Name = "Col_ba_descripcion";
            this.Col_ba_descripcion.Visible = true;
            this.Col_ba_descripcion.VisibleIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlDetalleOP;
            this.gridView1.Name = "gridView1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir_pago_prov,
            this.btnAgrupar_x_proveedor});
            this.toolStrip1.Location = new System.Drawing.Point(3, 67);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1048, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnImprimir_pago_prov
            // 
            this.btnImprimir_pago_prov.Image = global::Core.Erp.Winform.Properties.Resources.imprimir_32x32;
            this.btnImprimir_pago_prov.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir_pago_prov.Name = "btnImprimir_pago_prov";
            this.btnImprimir_pago_prov.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir_pago_prov.Text = "Imprimir";
            this.btnImprimir_pago_prov.Click += new System.EventHandler(this.btnImprimir_pago_prov_Click);
            // 
            // btnAgrupar_x_proveedor
            // 
            this.btnAgrupar_x_proveedor.Image = global::Core.Erp.Winform.Properties.Resources.Carpeta_16x16;
            this.btnAgrupar_x_proveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgrupar_x_proveedor.Name = "btnAgrupar_x_proveedor";
            this.btnAgrupar_x_proveedor.Size = new System.Drawing.Size(148, 22);
            this.btnAgrupar_x_proveedor.Text = "Agrupar por proveedor";
            this.btnAgrupar_x_proveedor.Click += new System.EventHandler(this.btnAgrupar_x_proveedor_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSecuencial);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.txt_total_op);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.chk_selec_op_visible);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpFechaHasta);
            this.panel2.Controls.Add(this.dtpFechadesde);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 64);
            this.panel2.TabIndex = 14;
            // 
            // txtSecuencial
            // 
            this.txtSecuencial.EditValue = "0";
            this.txtSecuencial.Location = new System.Drawing.Point(587, 34);
            this.txtSecuencial.Name = "txtSecuencial";
            this.txtSecuencial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSecuencial.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSecuencial.Size = new System.Drawing.Size(100, 20);
            this.txtSecuencial.TabIndex = 177;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(492, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 176;
            this.label9.Text = "Secuencial inicial:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton2.Image = global::Core.Erp.Winform.Properties.Resources.Add_16_x_16;
            this.simpleButton2.Location = new System.Drawing.Point(527, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(182, 23);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "Crear nueva órden de pago";
            this.simpleButton2.Click += new System.EventHandler(this.btnNuevaOP_Click);
            // 
            // txt_total_op
            // 
            this.txt_total_op.Location = new System.Drawing.Point(240, 33);
            this.txt_total_op.Name = "txt_total_op";
            this.txt_total_op.Properties.DisplayFormat.FormatString = "n2";
            this.txt_total_op.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_total_op.Properties.EditFormat.FormatString = "n2";
            this.txt_total_op.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_total_op.Properties.ReadOnly = true;
            this.txt_total_op.Size = new System.Drawing.Size(100, 20);
            this.txt_total_op.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(163, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Valor total";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.Image = global::Core.Erp.Winform.Properties.Resources.Buscar_docu_16x16;
            this.simpleButton1.Location = new System.Drawing.Point(339, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(182, 23);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Buscar órdenes de pago";
            this.simpleButton1.Click += new System.EventHandler(this.cmbBuscar_Click);
            // 
            // chk_selec_op_visible
            // 
            this.chk_selec_op_visible.Location = new System.Drawing.Point(12, 33);
            this.chk_selec_op_visible.Name = "chk_selec_op_visible";
            this.chk_selec_op_visible.Properties.Caption = "Seleccionar visibles";
            this.chk_selec_op_visible.Size = new System.Drawing.Size(145, 19);
            this.chk_selec_op_visible.TabIndex = 163;
            this.chk_selec_op_visible.CheckedChanged += new System.EventHandler(this.chk_selec_op_visible_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Hasta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Desde:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(203, 7);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaHasta.TabIndex = 69;
            // 
            // dtpFechadesde
            // 
            this.dtpFechadesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechadesde.Location = new System.Drawing.Point(57, 7);
            this.dtpFechadesde.Name = "dtpFechadesde";
            this.dtpFechadesde.Size = new System.Drawing.Size(100, 20);
            this.dtpFechadesde.TabIndex = 68;
            // 
            // tabPageTrasnferencia
            // 
            this.tabPageTrasnferencia.Controls.Add(this.cmbCuentaDestino);
            this.tabPageTrasnferencia.Controls.Add(this.label10);
            this.tabPageTrasnferencia.Controls.Add(this.txt_monto);
            this.tabPageTrasnferencia.Controls.Add(this.ultraCmbE_empresaDest);
            this.tabPageTrasnferencia.Controls.Add(this.label3);
            this.tabPageTrasnferencia.Controls.Add(this.label4);
            this.tabPageTrasnferencia.Location = new System.Drawing.Point(4, 22);
            this.tabPageTrasnferencia.Name = "tabPageTrasnferencia";
            this.tabPageTrasnferencia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTrasnferencia.Size = new System.Drawing.Size(1054, 263);
            this.tabPageTrasnferencia.TabIndex = 1;
            this.tabPageTrasnferencia.Text = "Transferencia Bancaria";
            this.tabPageTrasnferencia.UseVisualStyleBackColor = true;
            // 
            // cmbCuentaDestino
            // 
            this.cmbCuentaDestino.Location = new System.Drawing.Point(93, 30);
            this.cmbCuentaDestino.Name = "cmbCuentaDestino";
            this.cmbCuentaDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCuentaDestino.Properties.DisplayMember = "ba_descripcion";
            this.cmbCuentaDestino.Properties.ValueMember = "IdBanco";
            this.cmbCuentaDestino.Properties.View = this.gridView2;
            this.cmbCuentaDestino.Size = new System.Drawing.Size(322, 20);
            this.cmbCuentaDestino.TabIndex = 32;
            this.cmbCuentaDestino.EditValueChanged += new System.EventHandler(this.cmbCuentaDestino_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdBanco,
            this.Colba_descripcion,
            this.Colba_Num_Cuenta});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdBanco
            // 
            this.colIdBanco.Caption = "Id Cuenta";
            this.colIdBanco.FieldName = "IdBanco ";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.Visible = true;
            this.colIdBanco.VisibleIndex = 0;
            this.colIdBanco.Width = 107;
            // 
            // Colba_descripcion
            // 
            this.Colba_descripcion.Caption = "Descripcion";
            this.Colba_descripcion.FieldName = "ba_descripcion";
            this.Colba_descripcion.Name = "Colba_descripcion";
            this.Colba_descripcion.Visible = true;
            this.Colba_descripcion.VisibleIndex = 1;
            this.Colba_descripcion.Width = 298;
            // 
            // Colba_Num_Cuenta
            // 
            this.Colba_Num_Cuenta.Caption = "Numero Cuenta";
            this.Colba_Num_Cuenta.FieldName = "ba_Num_Cuenta";
            this.Colba_Num_Cuenta.Name = "Colba_Num_Cuenta";
            this.Colba_Num_Cuenta.Visible = true;
            this.Colba_Num_Cuenta.VisibleIndex = 2;
            this.Colba_Num_Cuenta.Width = 741;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Monto:";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(93, 58);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Properties.Mask.EditMask = "c3";
            this.txt_monto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_monto.Size = new System.Drawing.Size(100, 20);
            this.txt_monto.TabIndex = 28;
            // 
            // ultraCmbE_empresaDest
            // 
            this.ultraCmbE_empresaDest.Location = new System.Drawing.Point(94, 6);
            this.ultraCmbE_empresaDest.Name = "ultraCmbE_empresaDest";
            this.ultraCmbE_empresaDest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraCmbE_empresaDest.Properties.DisplayMember = "em_nombre";
            this.ultraCmbE_empresaDest.Properties.ValueMember = "IdEmpresa";
            this.ultraCmbE_empresaDest.Properties.View = this.gridView4;
            this.ultraCmbE_empresaDest.Size = new System.Drawing.Size(322, 20);
            this.ultraCmbE_empresaDest.TabIndex = 21;
            this.ultraCmbE_empresaDest.EditValueChanged += new System.EventHandler(this.ultraCmbE_empresaDest_EditValueChanged);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.em_nombre});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // em_nombre
            // 
            this.em_nombre.Caption = "Nombre";
            this.em_nombre.FieldName = "em_nombre";
            this.em_nombre.Name = "em_nombre";
            this.em_nombre.Visible = true;
            this.em_nombre.VisibleIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Empresa Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cta. Ban. Destino:";
            // 
            // tabPagePreavisoCheq
            // 
            this.tabPagePreavisoCheq.Controls.Add(this.gridControlDetalleCheques);
            this.tabPagePreavisoCheq.Controls.Add(this.panel4);
            this.tabPagePreavisoCheq.Controls.Add(this.panel3);
            this.tabPagePreavisoCheq.Location = new System.Drawing.Point(4, 22);
            this.tabPagePreavisoCheq.Name = "tabPagePreavisoCheq";
            this.tabPagePreavisoCheq.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePreavisoCheq.Size = new System.Drawing.Size(1054, 263);
            this.tabPagePreavisoCheq.TabIndex = 2;
            this.tabPagePreavisoCheq.Text = "Preaviso/Cheques";
            this.tabPagePreavisoCheq.UseVisualStyleBackColor = true;
            // 
            // gridControlDetalleCheques
            // 
            this.gridControlDetalleCheques.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDetalleCheques.Location = new System.Drawing.Point(3, 63);
            this.gridControlDetalleCheques.MainView = this.gridViewDetalleCheq;
            this.gridControlDetalleCheques.Name = "gridControlDetalleCheques";
            this.gridControlDetalleCheques.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gridControlDetalleCheques.Size = new System.Drawing.Size(1048, 197);
            this.gridControlDetalleCheques.TabIndex = 0;
            this.gridControlDetalleCheques.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalleCheq,
            this.gridView5});
            // 
            // gridViewDetalleCheq
            // 
            this.gridViewDetalleCheq.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colchecked,
            this.colcb_Cheque,
            this.colcb_Fecha,
            this.colcb_Observacion,
            this.colcb_Valor,
            this.colcb_giradoA,
            this.colIdCbteCble,
            this.colIdTipocbte,
            this.colIdEmpresa_mvba});
            this.gridViewDetalleCheq.GridControl = this.gridControlDetalleCheques;
            this.gridViewDetalleCheq.Name = "gridViewDetalleCheq";
            this.gridViewDetalleCheq.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDetalleCheq.OptionsView.ShowGroupPanel = false;
            this.gridViewDetalleCheq.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colcb_Cheque, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewDetalleCheq.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewDetalleCheq_CellValueChanged);
            this.gridViewDetalleCheq.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewDetalleCheq_CellValueChanging);
            this.gridViewDetalleCheq.RowCountChanged += new System.EventHandler(this.gridViewDetalleCheq_RowCountChanged);
            // 
            // colchecked
            // 
            this.colchecked.Caption = "*";
            this.colchecked.FieldName = "check";
            this.colchecked.Name = "colchecked";
            this.colchecked.Visible = true;
            this.colchecked.VisibleIndex = 0;
            this.colchecked.Width = 23;
            // 
            // colcb_Cheque
            // 
            this.colcb_Cheque.Caption = "#Cheque";
            this.colcb_Cheque.FieldName = "num_cheq";
            this.colcb_Cheque.Name = "colcb_Cheque";
            this.colcb_Cheque.OptionsColumn.AllowEdit = false;
            this.colcb_Cheque.Visible = true;
            this.colcb_Cheque.VisibleIndex = 1;
            this.colcb_Cheque.Width = 87;
            // 
            // colcb_Fecha
            // 
            this.colcb_Fecha.Caption = "Fecha";
            this.colcb_Fecha.FieldName = "cb_Fecha_cheq";
            this.colcb_Fecha.Name = "colcb_Fecha";
            this.colcb_Fecha.OptionsColumn.AllowEdit = false;
            this.colcb_Fecha.Visible = true;
            this.colcb_Fecha.VisibleIndex = 2;
            this.colcb_Fecha.Width = 72;
            // 
            // colcb_Observacion
            // 
            this.colcb_Observacion.Caption = "Observacion";
            this.colcb_Observacion.FieldName = "Observacion_cheq";
            this.colcb_Observacion.Name = "colcb_Observacion";
            this.colcb_Observacion.OptionsColumn.AllowEdit = false;
            this.colcb_Observacion.Visible = true;
            this.colcb_Observacion.VisibleIndex = 3;
            this.colcb_Observacion.Width = 335;
            // 
            // colcb_Valor
            // 
            this.colcb_Valor.Caption = "Valor";
            this.colcb_Valor.FieldName = "Valor";
            this.colcb_Valor.Name = "colcb_Valor";
            this.colcb_Valor.OptionsColumn.AllowEdit = false;
            this.colcb_Valor.Visible = true;
            this.colcb_Valor.VisibleIndex = 5;
            this.colcb_Valor.Width = 101;
            // 
            // colcb_giradoA
            // 
            this.colcb_giradoA.Caption = "Girado A";
            this.colcb_giradoA.FieldName = "giradoA_cheq";
            this.colcb_giradoA.Name = "colcb_giradoA";
            this.colcb_giradoA.OptionsColumn.AllowEdit = false;
            this.colcb_giradoA.Visible = true;
            this.colcb_giradoA.VisibleIndex = 4;
            this.colcb_giradoA.Width = 195;
            // 
            // colIdCbteCble
            // 
            this.colIdCbteCble.Caption = "IdCbteCble";
            this.colIdCbteCble.FieldName = "IdCbteCble_mvba";
            this.colIdCbteCble.Name = "colIdCbteCble";
            this.colIdCbteCble.OptionsColumn.AllowEdit = false;
            // 
            // colIdTipocbte
            // 
            this.colIdTipocbte.Caption = "IdTipocbte";
            this.colIdTipocbte.FieldName = "IdTipocbte_mvba";
            this.colIdTipocbte.Name = "colIdTipocbte";
            this.colIdTipocbte.OptionsColumn.AllowEdit = false;
            // 
            // colIdEmpresa_mvba
            // 
            this.colIdEmpresa_mvba.Caption = "IdEmpresa_mvba";
            this.colIdEmpresa_mvba.FieldName = "IdEmpresa_mvba";
            this.colIdEmpresa_mvba.Name = "colIdEmpresa_mvba";
            this.colIdEmpresa_mvba.OptionsColumn.AllowEdit = false;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.gridControlDetalleCheques;
            this.gridView5.Name = "gridView5";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_total_cheque);
            this.panel4.Controls.Add(this.labelControl3);
            this.panel4.Controls.Add(this.chk_selec_cheq_visible);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1048, 30);
            this.panel4.TabIndex = 14;
            // 
            // txt_total_cheque
            // 
            this.txt_total_cheque.Location = new System.Drawing.Point(265, 6);
            this.txt_total_cheque.Name = "txt_total_cheque";
            this.txt_total_cheque.Properties.DisplayFormat.FormatString = "n2";
            this.txt_total_cheque.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_total_cheque.Properties.EditFormat.FormatString = "n2";
            this.txt_total_cheque.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_total_cheque.Properties.ReadOnly = true;
            this.txt_total_cheque.Size = new System.Drawing.Size(100, 20);
            this.txt_total_cheque.TabIndex = 165;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(186, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 16);
            this.labelControl3.TabIndex = 164;
            this.labelControl3.Text = "Valor total";
            // 
            // chk_selec_cheq_visible
            // 
            this.chk_selec_cheq_visible.Location = new System.Drawing.Point(20, 6);
            this.chk_selec_cheq_visible.Name = "chk_selec_cheq_visible";
            this.chk_selec_cheq_visible.Properties.Caption = "Seleccionar visibles";
            this.chk_selec_cheq_visible.Size = new System.Drawing.Size(173, 19);
            this.chk_selec_cheq_visible.TabIndex = 166;
            this.chk_selec_cheq_visible.CheckedChanged += new System.EventHandler(this.chk_selec_cheq_visible_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkMostar_che_Preavisados);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dtpFechadesde_cheq);
            this.panel3.Controls.Add(this.btn_buscar_cheq);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dtpFechaHasta_cheq);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 30);
            this.panel3.TabIndex = 13;
            // 
            // chkMostar_che_Preavisados
            // 
            this.chkMostar_che_Preavisados.Location = new System.Drawing.Point(522, 6);
            this.chkMostar_che_Preavisados.Name = "chkMostar_che_Preavisados";
            this.chkMostar_che_Preavisados.Properties.Caption = "Mostrar Cheques Preavisados";
            this.chkMostar_che_Preavisados.Size = new System.Drawing.Size(174, 19);
            this.chkMostar_che_Preavisados.TabIndex = 161;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Desde:";
            // 
            // dtpFechadesde_cheq
            // 
            this.dtpFechadesde_cheq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechadesde_cheq.Location = new System.Drawing.Point(66, 6);
            this.dtpFechadesde_cheq.Name = "dtpFechadesde_cheq";
            this.dtpFechadesde_cheq.Size = new System.Drawing.Size(100, 20);
            this.dtpFechadesde_cheq.TabIndex = 68;
            // 
            // btn_buscar_cheq
            // 
            this.btn_buscar_cheq.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_buscar_cheq.Image = global::Core.Erp.Winform.Properties.Resources.Buscar_docu_16x16;
            this.btn_buscar_cheq.Location = new System.Drawing.Point(371, 4);
            this.btn_buscar_cheq.Name = "btn_buscar_cheq";
            this.btn_buscar_cheq.Size = new System.Drawing.Size(145, 22);
            this.btn_buscar_cheq.TabIndex = 160;
            this.btn_buscar_cheq.Text = "Buscar cheques";
            this.btn_buscar_cheq.Click += new System.EventHandler(this.btn_buscar_cheq_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Hasta:";
            // 
            // dtpFechaHasta_cheq
            // 
            this.dtpFechaHasta_cheq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta_cheq.Location = new System.Drawing.Point(223, 6);
            this.dtpFechaHasta_cheq.Name = "dtpFechaHasta_cheq";
            this.dtpFechaHasta_cheq.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaHasta_cheq.TabIndex = 69;
            // 
            // tabPageRRHH
            // 
            this.tabPageRRHH.Controls.Add(this.gridControlRRHH);
            this.tabPageRRHH.Location = new System.Drawing.Point(4, 22);
            this.tabPageRRHH.Name = "tabPageRRHH";
            this.tabPageRRHH.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRRHH.Size = new System.Drawing.Size(1054, 263);
            this.tabPageRRHH.TabIndex = 3;
            this.tabPageRRHH.Text = "RRHH";
            this.tabPageRRHH.UseVisualStyleBackColor = true;
            // 
            // gridControlRRHH
            // 
            this.gridControlRRHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRRHH.Location = new System.Drawing.Point(3, 3);
            this.gridControlRRHH.MainView = this.gridViewRRHH;
            this.gridControlRRHH.Name = "gridControlRRHH";
            this.gridControlRRHH.Size = new System.Drawing.Size(1048, 257);
            this.gridControlRRHH.TabIndex = 0;
            this.gridControlRRHH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRRHH});
            // 
            // gridViewRRHH
            // 
            this.gridViewRRHH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridViewRRHH.GridControl = this.gridControlRRHH;
            this.gridViewRRHH.Name = "gridViewRRHH";
            this.gridViewRRHH.OptionsBehavior.ReadOnly = true;
            this.gridViewRRHH.OptionsView.ShowAutoFilterRow = true;
            this.gridViewRRHH.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cédula";
            this.gridColumn2.FieldName = "pe_cedulaRuc";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 153;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cta acreditación";
            this.gridColumn3.FieldName = "num_cta_acreditacion";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 180;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Empleado";
            this.gridColumn4.FieldName = "pe_nombreCompleto";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 712;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Valor";
            this.gridColumn5.DisplayFormat.FormatString = "n2";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "Valor";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 135;
            // 
            // groupControlCabecera
            // 
            this.groupControlCabecera.Controls.Add(this.cmb_Motivo_Transferencia);
            this.groupControlCabecera.Controls.Add(this.lblMotivo_transferencia);
            this.groupControlCabecera.Controls.Add(this.lbNombreFile);
            this.groupControlCabecera.Controls.Add(this.txtNombreArc);
            this.groupControlCabecera.Controls.Add(this.txtId);
            this.groupControlCabecera.Controls.Add(this.label2);
            this.groupControlCabecera.Controls.Add(this.ucBa_Proceso_x_Banco);
            this.groupControlCabecera.Controls.Add(this.dtpFEchaPago);
            this.groupControlCabecera.Controls.Add(this.label1);
            this.groupControlCabecera.Controls.Add(this.groupControlObservacion);
            this.groupControlCabecera.Controls.Add(this.labelControl1);
            this.groupControlCabecera.Controls.Add(this.cmbRuta);
            this.groupControlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlCabecera.Location = new System.Drawing.Point(2, 31);
            this.groupControlCabecera.Name = "groupControlCabecera";
            this.groupControlCabecera.Size = new System.Drawing.Size(1062, 166);
            this.groupControlCabecera.TabIndex = 4;
            this.groupControlCabecera.Text = "Datos Generales";
            // 
            // cmb_Motivo_Transferencia
            // 
            this.cmb_Motivo_Transferencia.Location = new System.Drawing.Point(551, 56);
            this.cmb_Motivo_Transferencia.Name = "cmb_Motivo_Transferencia";
            this.cmb_Motivo_Transferencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Motivo_Transferencia.Properties.DisplayMember = "ca_descripcion";
            this.cmb_Motivo_Transferencia.Properties.ValueMember = "IdCatalogo";
            this.cmb_Motivo_Transferencia.Properties.View = this.gridView3;
            this.cmb_Motivo_Transferencia.Size = new System.Drawing.Size(298, 20);
            this.cmb_Motivo_Transferencia.TabIndex = 175;
            this.cmb_Motivo_Transferencia.EditValueChanged += new System.EventHandler(this.cmb_Motivo_Transferencia_EditValueChanged);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_IdCatalogo,
            this.Colca_descripcion});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "I";
            this.gridView3.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // Col_IdCatalogo
            // 
            this.Col_IdCatalogo.Caption = "Id Motivo";
            this.Col_IdCatalogo.FieldName = "IdCatalogo";
            this.Col_IdCatalogo.Name = "Col_IdCatalogo";
            this.Col_IdCatalogo.Visible = true;
            this.Col_IdCatalogo.VisibleIndex = 0;
            this.Col_IdCatalogo.Width = 282;
            // 
            // Colca_descripcion
            // 
            this.Colca_descripcion.Caption = "Motivo de Transferencia";
            this.Colca_descripcion.FieldName = "ca_descripcion";
            this.Colca_descripcion.Name = "Colca_descripcion";
            this.Colca_descripcion.Visible = true;
            this.Colca_descripcion.VisibleIndex = 1;
            this.Colca_descripcion.Width = 870;
            // 
            // lblMotivo_transferencia
            // 
            this.lblMotivo_transferencia.AutoSize = true;
            this.lblMotivo_transferencia.Location = new System.Drawing.Point(435, 59);
            this.lblMotivo_transferencia.Name = "lblMotivo_transferencia";
            this.lblMotivo_transferencia.Size = new System.Drawing.Size(110, 13);
            this.lblMotivo_transferencia.TabIndex = 174;
            this.lblMotivo_transferencia.Text = "Motivo Transferencia:";
            // 
            // lbNombreFile
            // 
            this.lbNombreFile.AutoSize = true;
            this.lbNombreFile.Location = new System.Drawing.Point(435, 85);
            this.lbNombreFile.Name = "lbNombreFile";
            this.lbNombreFile.Size = new System.Drawing.Size(102, 13);
            this.lbNombreFile.TabIndex = 172;
            this.lbNombreFile.Text = "Nombre del archivo:";
            // 
            // txtNombreArc
            // 
            this.txtNombreArc.Location = new System.Drawing.Point(551, 82);
            this.txtNombreArc.Name = "txtNombreArc";
            this.txtNombreArc.Properties.MaxLength = 50;
            this.txtNombreArc.Size = new System.Drawing.Size(298, 20);
            this.txtNombreArc.TabIndex = 171;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(551, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 169;
            this.label2.Text = "Id Registro:";
            // 
            // ucBa_Proceso_x_Banco
            // 
            this.ucBa_Proceso_x_Banco.Location = new System.Drawing.Point(10, 24);
            this.ucBa_Proceso_x_Banco.Name = "ucBa_Proceso_x_Banco";
            this.ucBa_Proceso_x_Banco.Size = new System.Drawing.Size(427, 52);
            this.ucBa_Proceso_x_Banco.TabIndex = 168;
            // 
            // dtpFEchaPago
            // 
            this.dtpFEchaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFEchaPago.Location = new System.Drawing.Point(749, 24);
            this.dtpFEchaPago.Name = "dtpFEchaPago";
            this.dtpFEchaPago.Size = new System.Drawing.Size(100, 20);
            this.dtpFEchaPago.TabIndex = 167;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 166;
            this.label1.Text = "Fecha:";
            // 
            // groupControlObservacion
            // 
            this.groupControlObservacion.Controls.Add(this.txtObservacion);
            this.groupControlObservacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlObservacion.Location = new System.Drawing.Point(2, 108);
            this.groupControlObservacion.Name = "groupControlObservacion";
            this.groupControlObservacion.Size = new System.Drawing.Size(1058, 56);
            this.groupControlObservacion.TabIndex = 163;
            this.groupControlObservacion.Text = "Observacion";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacion.Location = new System.Drawing.Point(2, 21);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(1054, 33);
            this.txtObservacion.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 159;
            this.labelControl1.Text = "Ruta File";
            // 
            // cmbRuta
            // 
            this.cmbRuta.Location = new System.Drawing.Point(74, 78);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbRuta.Properties.ReadOnly = true;
            this.cmbRuta.Size = new System.Drawing.Size(355, 20);
            this.cmbRuta.TabIndex = 158;
            this.cmbRuta.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmbRuta_ButtonClick);
            this.cmbRuta.EditValueChanged += new System.EventHandler(this.cmbRuta_EditValueChanged);
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpLote = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(2, 2);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1062, 29);
            this.ucGe_Menu.TabIndex = 3;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = true;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnContabilizar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnContabilizar_Click(this.ucGe_Menu_event_btnContabilizar_Click);
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // frmCP_GeneracionFile_Banco_x_cxp_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 488);
            this.Controls.Add(this.panelControlGeneral);
            this.Name = "frmCP_GeneracionFile_Banco_x_cxp_Mant";
            this.Text = "Generación de archivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCP_GeneracionFile_Banco_x_cxp_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmCP_GeneracionFile_Banco_x_cxp_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGeneral)).EndInit();
            this.panelControlGeneral.ResumeLayout(false);
            this.tabControlDetalle.ResumeLayout(false);
            this.tabPageOP.ResumeLayout(false);
            this.tabPageOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecuencial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_op.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_selec_op_visible.Properties)).EndInit();
            this.tabPageTrasnferencia.ResumeLayout(false);
            this.tabPageTrasnferencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCuentaDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_empresaDest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.tabPagePreavisoCheq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleCheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleCheq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_cheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_selec_cheq_visible.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostar_che_Preavisados.Properties)).EndInit();
            this.tabPageRRHH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRRHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRRHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCabecera)).EndInit();
            this.groupControlCabecera.ResumeLayout(false);
            this.groupControlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Motivo_Transferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreArc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlObservacion)).EndInit();
            this.groupControlObservacion.ResumeLayout(false);
            this.groupControlObservacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRuta.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlGeneral;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.GroupControl groupControlCabecera;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit cmbRuta;
        private DevExpress.XtraEditors.GroupControl groupControlObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.DateTimePicker dtpFEchaPago;
        private System.Windows.Forms.Label label1;
        private Controles.UCBa_Proceso_x_Banco ucBa_Proceso_x_Banco;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControlDetalle;
        private System.Windows.Forms.TabPage tabPageOP;
        private DevExpress.XtraGrid.GridControl gridControlDetalleOP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalleOP;
        private DevExpress.XtraGrid.Columns.GridColumn Colcheck_op;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Colproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn Colfecha_op;
        private DevExpress.XtraGrid.Columns.GridColumn Colestado_op;
        private DevExpress.XtraGrid.Columns.GridColumn ColValor_pagado;
        private DevExpress.XtraGrid.Columns.GridColumn Colobservacion_op;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdOrdenPago;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstado_Transferencia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.DateTimePicker dtpFechadesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageTrasnferencia;
        private DevExpress.XtraEditors.TextEdit txt_monto;
        private DevExpress.XtraEditors.SearchLookUpEdit ultraCmbE_empresaDest;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn em_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCuentaDestino;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Colba_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Colba_Num_Cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private System.Windows.Forms.Label lbNombreFile;
        private DevExpress.XtraEditors.TextEdit txtNombreArc;
        private System.Windows.Forms.Label lblMotivo_transferencia;
        public DevExpress.XtraEditors.SearchLookUpEdit cmb_Motivo_Transferencia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn Colca_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Colnom_banco_destino;
        private DevExpress.XtraGrid.Columns.GridColumn ColTipocta;
        private System.Windows.Forms.TabPage tabPagePreavisoCheq;
        private DevExpress.XtraEditors.CheckEdit chkMostar_che_Preavisados;
        private System.Windows.Forms.DateTimePicker dtpFechadesde_cheq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta_cheq;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btn_buscar_cheq;
        private DevExpress.XtraGrid.GridControl gridControlDetalleCheques;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalleCheq;
        private DevExpress.XtraGrid.Columns.GridColumn colchecked;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Cheque;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Valor;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_giradoA;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipocbte;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa_mvba;
        private DevExpress.XtraEditors.CheckEdit chk_selec_op_visible;
        private DevExpress.XtraEditors.TextEdit txt_total_op;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.TextEdit txt_total_cheque;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit chk_selec_cheq_visible;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_cmb_banco;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_banco;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ba_descripcion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnImprimir_pago_prov;
        private System.Windows.Forms.ToolStripButton btnAgrupar_x_proveedor;
        private DevExpress.XtraEditors.TextEdit txtSecuencial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPageRRHH;
        private DevExpress.XtraGrid.GridControl gridControlRRHH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRRHH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}