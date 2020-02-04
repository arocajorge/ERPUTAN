namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_TipoDocumento_Mant
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
            this.checkDeclara = new System.Windows.Forms.CheckBox();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.NumericUpDown();
            this.textNombreC = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCodigoSRI = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.ckbGeneraRetencion = new System.Windows.Forms.CheckBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlTipoSustento = new DevExpress.XtraGrid.GridControl();
            this.gridViewTipoSustento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colco_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTipoSustento = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colco_descripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlTipoDoc = new DevExpress.XtraGrid.GridControl();
            this.gridViewTipodDOc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTipoDocumento = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colca_descripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoSustento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoSustento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoSustento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipodDOc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkDeclara
            // 
            this.checkDeclara.AutoSize = true;
            this.checkDeclara.Checked = true;
            this.checkDeclara.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDeclara.Location = new System.Drawing.Point(406, 86);
            this.checkDeclara.Name = "checkDeclara";
            this.checkDeclara.Size = new System.Drawing.Size(84, 17);
            this.checkDeclara.TabIndex = 4;
            this.checkDeclara.Text = "Declara SRI";
            this.checkDeclara.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblEstado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(364, 7);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(156, 33);
            this.lblEstado.TabIndex = 69;
            this.lblEstado.Text = "**Anulado**";
            this.lblEstado.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Orden:";
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(406, 52);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(100, 20);
            this.txtOrden.TabIndex = 3;
            // 
            // textNombreC
            // 
            this.textNombreC.Location = new System.Drawing.Point(130, 67);
            this.textNombreC.Name = "textNombreC";
            this.textNombreC.Size = new System.Drawing.Size(223, 20);
            this.textNombreC.TabIndex = 1;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(130, 39);
            this.textCodigo.MaxLength = 5;
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(97, 20);
            this.textCodigo.TabIndex = 0;
            this.textCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.textDescripcion_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Código SRI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Código Documento:";
            // 
            // textCodigoSRI
            // 
            this.textCodigoSRI.Location = new System.Drawing.Point(130, 96);
            this.textCodigoSRI.MaxLength = 5;
            this.textCodigoSRI.Name = "textCodigoSRI";
            this.textCodigoSRI.Size = new System.Drawing.Size(223, 20);
            this.textCodigoSRI.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chkEstado);
            this.panelControl1.Controls.Add(this.textCodigoSRI);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.ckbGeneraRetencion);
            this.panelControl1.Controls.Add(this.checkDeclara);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.lblEstado);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.txtOrden);
            this.panelControl1.Controls.Add(this.textCodigo);
            this.panelControl1.Controls.Add(this.textNombreC);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(729, 157);
            this.panelControl1.TabIndex = 1;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(406, 127);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 70;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // ckbGeneraRetencion
            // 
            this.ckbGeneraRetencion.AutoSize = true;
            this.ckbGeneraRetencion.Checked = true;
            this.ckbGeneraRetencion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbGeneraRetencion.Location = new System.Drawing.Point(406, 104);
            this.ckbGeneraRetencion.Name = "ckbGeneraRetencion";
            this.ckbGeneraRetencion.Size = new System.Drawing.Size(113, 17);
            this.ckbGeneraRetencion.TabIndex = 5;
            this.ckbGeneraRetencion.Text = "Genera Retencion";
            this.ckbGeneraRetencion.UseVisualStyleBackColor = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.panel1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(729, 244);
            this.panelControl2.TabIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControlTipoSustento);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(168, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(559, 240);
            this.panelControl3.TabIndex = 0;
            // 
            // gridControlTipoSustento
            // 
            this.gridControlTipoSustento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTipoSustento.Location = new System.Drawing.Point(2, 2);
            this.gridControlTipoSustento.MainView = this.gridViewTipoSustento;
            this.gridControlTipoSustento.Name = "gridControlTipoSustento";
            this.gridControlTipoSustento.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbTipoSustento});
            this.gridControlTipoSustento.Size = new System.Drawing.Size(555, 236);
            this.gridControlTipoSustento.TabIndex = 0;
            this.gridControlTipoSustento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTipoSustento});
            // 
            // gridViewTipoSustento
            // 
            this.gridViewTipoSustento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colco_descripcion});
            this.gridViewTipoSustento.GridControl = this.gridControlTipoSustento;
            this.gridViewTipoSustento.Name = "gridViewTipoSustento";
            this.gridViewTipoSustento.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewTipoSustento.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewTipoSustento.OptionsView.ShowGroupPanel = false;
            this.gridViewTipoSustento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewTipoSustento_KeyDown);
            // 
            // colco_descripcion
            // 
            this.colco_descripcion.Caption = "Tipo De Sustentos ";
            this.colco_descripcion.ColumnEdit = this.cmbTipoSustento;
            this.colco_descripcion.FieldName = "IdCodigo_SRI";
            this.colco_descripcion.Name = "colco_descripcion";
            this.colco_descripcion.Visible = true;
            this.colco_descripcion.VisibleIndex = 0;
            this.colco_descripcion.Width = 1057;
            // 
            // cmbTipoSustento
            // 
            this.cmbTipoSustento.AutoHeight = false;
            this.cmbTipoSustento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoSustento.DisplayMember = "co_descripcion2";
            this.cmbTipoSustento.Name = "cmbTipoSustento";
            this.cmbTipoSustento.ValueMember = "IdCodigo_SRI";
            this.cmbTipoSustento.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colco_descripcion1,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colco_descripcion1
            // 
            this.colco_descripcion1.Caption = "Descripción";
            this.colco_descripcion1.FieldName = "co_descripcion";
            this.colco_descripcion1.Name = "colco_descripcion1";
            this.colco_descripcion1.Visible = true;
            this.colco_descripcion1.VisibleIndex = 1;
            this.colco_descripcion1.Width = 957;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "colco_codigoSRI";
            this.gridColumn1.FieldName = "codigoSRI";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 123;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "colIdCodigoSri";
            this.gridColumn2.FieldName = "IdCodigo_SRI";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlTipoDoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 240);
            this.panel1.TabIndex = 0;
            // 
            // gridControlTipoDoc
            // 
            this.gridControlTipoDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTipoDoc.Location = new System.Drawing.Point(0, 0);
            this.gridControlTipoDoc.MainView = this.gridViewTipodDOc;
            this.gridControlTipoDoc.Name = "gridControlTipoDoc";
            this.gridControlTipoDoc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbTipoDocumento});
            this.gridControlTipoDoc.Size = new System.Drawing.Size(166, 240);
            this.gridControlTipoDoc.TabIndex = 0;
            this.gridControlTipoDoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTipodDOc});
            // 
            // gridViewTipodDOc
            // 
            this.gridViewTipodDOc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCatalogo,
            this.colCodCatalogo,
            this.colca_descripcion,
            this.colca_estado,
            this.colIdTipoCatalogo,
            this.colca_orden});
            this.gridViewTipodDOc.GridControl = this.gridControlTipoDoc;
            this.gridViewTipodDOc.Name = "gridViewTipodDOc";
            this.gridViewTipodDOc.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCatalogo
            // 
            this.colIdCatalogo.FieldName = "IdCatalogo";
            this.colIdCatalogo.Name = "colIdCatalogo";
            // 
            // colCodCatalogo
            // 
            this.colCodCatalogo.FieldName = "CodCatalogo";
            this.colCodCatalogo.Name = "colCodCatalogo";
            // 
            // colca_descripcion
            // 
            this.colca_descripcion.Caption = "Tipos De Documentos";
            this.colca_descripcion.ColumnEdit = this.cmbTipoDocumento;
            this.colca_descripcion.FieldName = "ca_descripcion";
            this.colca_descripcion.Name = "colca_descripcion";
            this.colca_descripcion.Visible = true;
            this.colca_descripcion.VisibleIndex = 0;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.AutoHeight = false;
            this.cmbTipoDocumento.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbTipoDocumento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoDocumento.DisplayMember = "ca_descripcion";
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.ValueMember = "CodCatalogo";
            this.cmbTipoDocumento.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colca_descripcion1});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colca_descripcion1
            // 
            this.colca_descripcion1.Caption = "Descripciónn";
            this.colca_descripcion1.FieldName = "ca_descripcion";
            this.colca_descripcion1.Name = "colca_descripcion1";
            this.colca_descripcion1.Visible = true;
            this.colca_descripcion1.VisibleIndex = 0;
            // 
            // colca_estado
            // 
            this.colca_estado.FieldName = "ca_estado";
            this.colca_estado.Name = "colca_estado";
            // 
            // colIdTipoCatalogo
            // 
            this.colIdTipoCatalogo.FieldName = "IdTipoCatalogo";
            this.colIdTipoCatalogo.Name = "colIdTipoCatalogo";
            // 
            // colca_orden
            // 
            this.colca_orden.FieldName = "ca_orden";
            this.colca_orden.Name = "colca_orden";
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
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(729, 29);
            this.ucGe_Menu.TabIndex = 3;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_event_btnlimpiar_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainer1.Size = new System.Drawing.Size(729, 405);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 4;
            // 
            // frmCP_TipoDocumento_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 434);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCP_TipoDocumento_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipoDocumento_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCP_TipoDocumento_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmCP_TipoDocumento_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoSustento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoSustento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoSustento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipodDOc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkDeclara;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtOrden;
        private System.Windows.Forms.TextBox textNombreC;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCodigoSRI;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControlTipoSustento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTipoSustento;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlTipoDoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTipodDOc;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colca_descripcion;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbTipoDocumento;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colca_descripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colca_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colca_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colco_descripcion;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbTipoSustento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colco_descripcion1;
        private System.Windows.Forms.CheckBox ckbGeneraRetencion;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chkEstado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}