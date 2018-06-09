namespace Core.Erp.Winform.General
{
    partial class FrmGe_TipoDocumento_Transaccion_Sistema
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
            this.tbsistipoDocumentoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.tbsisDocumentoTipoxEmpresaInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.tbEmpresaInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlTipoDocEmpresa = new DevExpress.XtraGrid.GridControl();
            this.gridViewTipoDocEmpresa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodDocumentoTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApareceComboFac_TipoFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colApareceComboFac_Import = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colApareceTalonario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosicion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbEmpresa = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colem_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlTipoDocumento = new DevExpress.XtraGrid.GridControl();
            this.gridViewTipoDocumento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Modificar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Nuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btn_All_Previus = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Previus = new DevExpress.XtraEditors.SimpleButton();
            this.btn_All_Next = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Next = new DevExpress.XtraEditors.SimpleButton();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbsistipoDocumentoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisDocumentoTipoxEmpresaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaInfoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoDocEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoDocEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // tbsistipoDocumentoInfoBindingSource
            // 
            this.tbsistipoDocumentoInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_sis_tipoDocumento_Info);
            // 
            // tbsisDocumentoTipoxEmpresaInfoBindingSource
            // 
            this.tbsisDocumentoTipoxEmpresaInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_sis_Documento_Tipo_x_Empresa_Info);
            // 
            // tbEmpresaInfoBindingSource
            // 
            this.tbEmpresaInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Empresa_Info);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.gridControlTipoDocEmpresa);
            this.groupBox2.Controls.Add(this.cmbEmpresa);
            this.groupBox2.Location = new System.Drawing.Point(474, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 469);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo De Documento Por Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Empresa";
            // 
            // gridControlTipoDocEmpresa
            // 
            this.gridControlTipoDocEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlTipoDocEmpresa.DataSource = this.tbsisDocumentoTipoxEmpresaInfoBindingSource;
            this.gridControlTipoDocEmpresa.Location = new System.Drawing.Point(19, 53);
            this.gridControlTipoDocEmpresa.MainView = this.gridViewTipoDocEmpresa;
            this.gridControlTipoDocEmpresa.Name = "gridControlTipoDocEmpresa";
            this.gridControlTipoDocEmpresa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gridControlTipoDocEmpresa.Size = new System.Drawing.Size(691, 403);
            this.gridControlTipoDocEmpresa.TabIndex = 10;
            this.gridControlTipoDocEmpresa.TabStop = false;
            this.gridControlTipoDocEmpresa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTipoDocEmpresa});
            // 
            // gridViewTipoDocEmpresa
            // 
            this.gridViewTipoDocEmpresa.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewTipoDocEmpresa.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTipoDocEmpresa.ColumnPanelRowHeight = 60;
            this.gridViewTipoDocEmpresa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodDocumentoTipo,
            this.colApareceComboFac_TipoFact,
            this.colApareceComboFac_Import,
            this.colApareceTalonario,
            this.colDescripcion1,
            this.colPosicion1,
            this.gridColumn1});
            this.gridViewTipoDocEmpresa.DetailHeight = 400;
            this.gridViewTipoDocEmpresa.GridControl = this.gridControlTipoDocEmpresa;
            this.gridViewTipoDocEmpresa.Name = "gridViewTipoDocEmpresa";
            this.gridViewTipoDocEmpresa.OptionsView.ShowGroupPanel = false;
            this.gridViewTipoDocEmpresa.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewTipoDocEmpresa_CellValueChanged);
            // 
            // colcodDocumentoTipo
            // 
            this.colcodDocumentoTipo.Caption = "Codigo Documento Tipo";
            this.colcodDocumentoTipo.FieldName = "codDocumentoTipo";
            this.colcodDocumentoTipo.Name = "colcodDocumentoTipo";
            this.colcodDocumentoTipo.OptionsColumn.AllowEdit = false;
            this.colcodDocumentoTipo.Visible = true;
            this.colcodDocumentoTipo.VisibleIndex = 0;
            this.colcodDocumentoTipo.Width = 85;
            // 
            // colApareceComboFac_TipoFact
            // 
            this.colApareceComboFac_TipoFact.Caption = "Aparece En El Combo de Tipo Factura";
            this.colApareceComboFac_TipoFact.ColumnEdit = this.repositoryItemTextEdit1;
            this.colApareceComboFac_TipoFact.FieldName = "ApareceComboFac_TipoFact";
            this.colApareceComboFac_TipoFact.Name = "colApareceComboFac_TipoFact";
            this.colApareceComboFac_TipoFact.Visible = true;
            this.colApareceComboFac_TipoFact.VisibleIndex = 2;
            this.colApareceComboFac_TipoFact.Width = 111;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "[S-N]?";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit1.Mask.ShowPlaceHolders = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colApareceComboFac_Import
            // 
            this.colApareceComboFac_Import.Caption = "Aparece En El Combo Factura/Importación";
            this.colApareceComboFac_Import.ColumnEdit = this.repositoryItemTextEdit2;
            this.colApareceComboFac_Import.FieldName = "ApareceComboFac_Import";
            this.colApareceComboFac_Import.Name = "colApareceComboFac_Import";
            this.colApareceComboFac_Import.Visible = true;
            this.colApareceComboFac_Import.VisibleIndex = 3;
            this.colApareceComboFac_Import.Width = 125;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = "[S-N]?";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit2.Mask.ShowPlaceHolders = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // colApareceTalonario
            // 
            this.colApareceTalonario.Caption = "Aparece En El Combo Talonario";
            this.colApareceTalonario.FieldName = "ApareceTalonario";
            this.colApareceTalonario.Name = "colApareceTalonario";
            this.colApareceTalonario.Visible = true;
            this.colApareceTalonario.VisibleIndex = 4;
            this.colApareceTalonario.Width = 85;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 1;
            this.colDescripcion1.Width = 209;
            // 
            // colPosicion1
            // 
            this.colPosicion1.FieldName = "Posicion";
            this.colPosicion1.Name = "colPosicion1";
            this.colPosicion1.Visible = true;
            this.colPosicion1.VisibleIndex = 6;
            this.colPosicion1.Width = 109;
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Location = new System.Drawing.Point(250, 20);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEmpresa.Properties.DataSource = this.tbEmpresaInfoBindingSource;
            this.cmbEmpresa.Properties.DisplayMember = "em_nombre";
            this.cmbEmpresa.Properties.NullText = "";
            this.cmbEmpresa.Properties.PopupSizeable = false;
            this.cmbEmpresa.Properties.ValueMember = "IdEmpresa";
            this.cmbEmpresa.Properties.View = this.searchLookUpEdit1View;
            this.cmbEmpresa.Size = new System.Drawing.Size(218, 20);
            this.cmbEmpresa.TabIndex = 12;
            this.cmbEmpresa.EditValueChanged += new System.EventHandler(this.cmbEmpresa_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colem_nombre});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colem_nombre
            // 
            this.colem_nombre.Caption = "Nombre";
            this.colem_nombre.FieldName = "em_nombre";
            this.colem_nombre.Name = "colem_nombre";
            this.colem_nombre.Visible = true;
            this.colem_nombre.VisibleIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.gridControlTipoDocumento);
            this.groupBox1.Controls.Add(this.btn_Modificar);
            this.groupBox1.Controls.Add(this.btn_Nuevo);
            this.groupBox1.Location = new System.Drawing.Point(11, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 469);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo De Documentos Disponibles";
            // 
            // gridControlTipoDocumento
            // 
            this.gridControlTipoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlTipoDocumento.DataSource = this.tbsistipoDocumentoInfoBindingSource;
            this.gridControlTipoDocumento.Location = new System.Drawing.Point(14, 55);
            this.gridControlTipoDocumento.MainView = this.gridViewTipoDocumento;
            this.gridControlTipoDocumento.Name = "gridControlTipoDocumento";
            this.gridControlTipoDocumento.Size = new System.Drawing.Size(347, 403);
            this.gridControlTipoDocumento.TabIndex = 5;
            this.gridControlTipoDocumento.TabStop = false;
            this.gridControlTipoDocumento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTipoDocumento});
            // 
            // gridViewTipoDocumento
            // 
            this.gridViewTipoDocumento.ColumnPanelRowHeight = 25;
            this.gridViewTipoDocumento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoDocumento,
            this.colDescripcion,
            this.colPosicion,
            this.colEstado});
            this.gridViewTipoDocumento.GridControl = this.gridControlTipoDocumento;
            this.gridViewTipoDocumento.Name = "gridViewTipoDocumento";
            this.gridViewTipoDocumento.OptionsBehavior.Editable = false;
            this.gridViewTipoDocumento.OptionsView.ShowGroupPanel = false;
            this.gridViewTipoDocumento.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewTipoDocumento_RowCellStyle);
            // 
            // colIdTipoDocumento
            // 
            this.colIdTipoDocumento.FieldName = "IdTipoDocumento";
            this.colIdTipoDocumento.Name = "colIdTipoDocumento";
            this.colIdTipoDocumento.Visible = true;
            this.colIdTipoDocumento.VisibleIndex = 0;
            this.colIdTipoDocumento.Width = 369;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 313;
            // 
            // colPosicion
            // 
            this.colPosicion.FieldName = "Posicion";
            this.colPosicion.Name = "colPosicion";
            this.colPosicion.Visible = true;
            this.colPosicion.VisibleIndex = 2;
            this.colPosicion.Width = 225;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 3;
            this.colEstado.Width = 273;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(116, 25);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 4;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(22, 25);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 3;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_All_Previus
            // 
            this.btn_All_Previus.Location = new System.Drawing.Point(400, 245);
            this.btn_All_Previus.Name = "btn_All_Previus";
            this.btn_All_Previus.Size = new System.Drawing.Size(54, 23);
            this.btn_All_Previus.TabIndex = 15;
            this.btn_All_Previus.Text = "<<";
            this.btn_All_Previus.Click += new System.EventHandler(this.btn_All_Previus_Click);
            // 
            // btn_Previus
            // 
            this.btn_Previus.Location = new System.Drawing.Point(400, 216);
            this.btn_Previus.Name = "btn_Previus";
            this.btn_Previus.Size = new System.Drawing.Size(54, 23);
            this.btn_Previus.TabIndex = 14;
            this.btn_Previus.Text = "<";
            this.btn_Previus.Click += new System.EventHandler(this.btn_Previus_Click);
            // 
            // btn_All_Next
            // 
            this.btn_All_Next.Location = new System.Drawing.Point(400, 187);
            this.btn_All_Next.Name = "btn_All_Next";
            this.btn_All_Next.Size = new System.Drawing.Size(54, 23);
            this.btn_All_Next.TabIndex = 13;
            this.btn_All_Next.Text = ">>";
            this.btn_All_Next.Click += new System.EventHandler(this.btn_All_Next_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(400, 158);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(54, 23);
            this.btn_Next.TabIndex = 12;
            this.btn_Next.Text = ">";
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
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
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1211, 29);
            this.ucGe_Menu.TabIndex = 18;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Aparece en el Combo Diseñador del Reporte";
            this.gridColumn1.FieldName = "ApareceCombo_FileReporte";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // FrmGe_TipoDocumento_Transaccion_Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1211, 510);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_All_Previus);
            this.Controls.Add(this.btn_Previus);
            this.Controls.Add(this.btn_All_Next);
            this.Controls.Add(this.btn_Next);
            this.Name = "FrmGe_TipoDocumento_Transaccion_Sistema";
            this.Text = "Tipo Documentos / Transacciones Del Sistema";
            this.Load += new System.EventHandler(this.FrmGe_TipoDocumento_Transaccion_Sistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbsistipoDocumentoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisDocumentoTipoxEmpresaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaInfoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoDocEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoDocEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoDocumento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tbsistipoDocumentoInfoBindingSource;
        private System.Windows.Forms.BindingSource tbsisDocumentoTipoxEmpresaInfoBindingSource;
        private System.Windows.Forms.BindingSource tbEmpresaInfoBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControlTipoDocEmpresa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTipoDocEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colcodDocumentoTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colApareceComboFac_TipoFact;
        private DevExpress.XtraGrid.Columns.GridColumn colApareceComboFac_Import;
        private DevExpress.XtraGrid.Columns.GridColumn colApareceTalonario;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colPosicion1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEmpresa;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colem_nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlTipoDocumento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTipoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colPosicion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.SimpleButton btn_Modificar;
        private DevExpress.XtraEditors.SimpleButton btn_Nuevo;
        private DevExpress.XtraEditors.SimpleButton btn_All_Previus;
        private DevExpress.XtraEditors.SimpleButton btn_Previus;
        private DevExpress.XtraEditors.SimpleButton btn_All_Next;
        private DevExpress.XtraEditors.SimpleButton btn_Next;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;

    }
}