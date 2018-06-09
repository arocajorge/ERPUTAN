namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Generacion_Archivo_Batch_IESS_Mant
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbPeriodos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colpe_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbnominaTipo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColDescripcionProcesoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbnomina = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtRutaArchivo = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTipoNovedad = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView14 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipoLicencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdGenerar = new System.Windows.Forms.Button();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoSucursal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gridControlNovedadesIESS = new DevExpress.XtraGrid.GridControl();
            this.gridViewNovedadesIESS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColCedula_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnominaTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoNovedad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoSucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNovedadesIESS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNovedadesIESS)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(826, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
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
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.cmbPeriodos);
            this.groupBox1.Controls.Add(this.cmbnominaTipo);
            this.groupBox1.Controls.Add(this.cmbnomina);
            this.groupBox1.Controls.Add(this.txtRutaArchivo);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.cmbTipoNovedad);
            this.groupBox1.Controls.Add(this.cmdGenerar);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.txtCodigoSucursal);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 155;
            this.labelControl3.Text = "Período:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 85);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 154;
            this.labelControl5.Text = "Proceso:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(15, 61);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 13);
            this.labelControl6.TabIndex = 153;
            this.labelControl6.Text = "Nómina:";
            // 
            // cmbPeriodos
            // 
            this.cmbPeriodos.Location = new System.Drawing.Point(142, 107);
            this.cmbPeriodos.Name = "cmbPeriodos";
            this.cmbPeriodos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPeriodos.Properties.DisplayMember = "pe_Descripcion";
            this.cmbPeriodos.Properties.ValueMember = "IdPeriodo";
            this.cmbPeriodos.Properties.View = this.gridView2;
            this.cmbPeriodos.Size = new System.Drawing.Size(347, 20);
            this.cmbPeriodos.TabIndex = 152;
            this.cmbPeriodos.EditValueChanged += new System.EventHandler(this.cmbPeriodos_EditValueChanged_1);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdPeriodo,
            this.Colpe_Descripcion});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdPeriodo
            // 
            this.ColIdPeriodo.Caption = "Id Periodo";
            this.ColIdPeriodo.FieldName = "IdPeriodo";
            this.ColIdPeriodo.Name = "ColIdPeriodo";
            this.ColIdPeriodo.Visible = true;
            this.ColIdPeriodo.VisibleIndex = 0;
            this.ColIdPeriodo.Width = 168;
            // 
            // Colpe_Descripcion
            // 
            this.Colpe_Descripcion.Caption = "Descripcion";
            this.Colpe_Descripcion.FieldName = "pe_Descripcion";
            this.Colpe_Descripcion.Name = "Colpe_Descripcion";
            this.Colpe_Descripcion.Visible = true;
            this.Colpe_Descripcion.VisibleIndex = 1;
            this.Colpe_Descripcion.Width = 984;
            // 
            // cmbnominaTipo
            // 
            this.cmbnominaTipo.Location = new System.Drawing.Point(142, 82);
            this.cmbnominaTipo.Name = "cmbnominaTipo";
            this.cmbnominaTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbnominaTipo.Properties.DisplayMember = "DescripcionProcesoNomina";
            this.cmbnominaTipo.Properties.ValueMember = "IdNomina_TipoLiqui";
            this.cmbnominaTipo.Properties.View = this.gridView1;
            this.cmbnominaTipo.Size = new System.Drawing.Size(347, 20);
            this.cmbnominaTipo.TabIndex = 151;
            this.cmbnominaTipo.EditValueChanged += new System.EventHandler(this.cmbnominaTipo_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColDescripcionProcesoNomina});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ColDescripcionProcesoNomina
            // 
            this.ColDescripcionProcesoNomina.Caption = "Proceso";
            this.ColDescripcionProcesoNomina.FieldName = "DescripcionProcesoNomina";
            this.ColDescripcionProcesoNomina.Name = "ColDescripcionProcesoNomina";
            this.ColDescripcionProcesoNomina.Visible = true;
            this.ColDescripcionProcesoNomina.VisibleIndex = 0;
            // 
            // cmbnomina
            // 
            this.cmbnomina.Location = new System.Drawing.Point(142, 56);
            this.cmbnomina.Name = "cmbnomina";
            this.cmbnomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbnomina.Properties.DisplayMember = "Descripcion";
            this.cmbnomina.Properties.ValueMember = "IdNomina_Tipo";
            this.cmbnomina.Properties.View = this.searchLookUpEdit1View;
            this.cmbnomina.Size = new System.Drawing.Size(347, 20);
            this.cmbnomina.TabIndex = 150;
            this.cmbnomina.EditValueChanged += new System.EventHandler(this.cmbnomina_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColDescripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.Caption = "Nomina";
            this.ColDescripcion.FieldName = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.Visible = true;
            this.ColDescripcion.VisibleIndex = 0;
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(142, 129);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtRutaArchivo.Properties.ReadOnly = true;
            this.txtRutaArchivo.Size = new System.Drawing.Size(376, 20);
            this.txtRutaArchivo.TabIndex = 3;
            this.txtRutaArchivo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtRutaArchivo_ButtonClick);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 127);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 13);
            this.labelControl2.TabIndex = 131;
            this.labelControl2.Text = "Ruta del Archivo:";
            // 
            // cmbTipoNovedad
            // 
            this.cmbTipoNovedad.Location = new System.Drawing.Point(142, 30);
            this.cmbTipoNovedad.Name = "cmbTipoNovedad";
            this.cmbTipoNovedad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoNovedad.Properties.DisplayMember = "ca_descripcion";
            this.cmbTipoNovedad.Properties.ValueMember = "IdCatalogo";
            this.cmbTipoNovedad.Properties.View = this.gridView14;
            this.cmbTipoNovedad.Size = new System.Drawing.Size(270, 20);
            this.cmbTipoNovedad.TabIndex = 1;
            this.cmbTipoNovedad.EditValueChanged += new System.EventHandler(this.cmbTipoNovedad_EditValueChanged);
            // 
            // gridView14
            // 
            this.gridView14.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipoLicencia,
            this.gridColumn8});
            this.gridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView14.Name = "gridView14";
            this.gridView14.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView14.OptionsView.ShowGroupPanel = false;
            // 
            // colTipoLicencia
            // 
            this.colTipoLicencia.Caption = "IdCatalogo";
            this.colTipoLicencia.FieldName = "IdCatalogo";
            this.colTipoLicencia.Name = "colTipoLicencia";
            this.colTipoLicencia.Width = 66;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Descripción";
            this.gridColumn8.FieldName = "ca_descripcion";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 1114;
            // 
            // cmdGenerar
            // 
            this.cmdGenerar.Location = new System.Drawing.Point(524, 127);
            this.cmdGenerar.Name = "cmdGenerar";
            this.cmdGenerar.Size = new System.Drawing.Size(100, 23);
            this.cmdGenerar.TabIndex = 4;
            this.cmdGenerar.Text = "&Generar Archivo";
            this.cmdGenerar.UseVisualStyleBackColor = true;
            this.cmdGenerar.Click += new System.EventHandler(this.cmdGenerar_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(95, 13);
            this.labelControl4.TabIndex = 70;
            this.labelControl4.Text = "Código de Sucursal:";
            // 
            // txtCodigoSucursal
            // 
            this.txtCodigoSucursal.Enabled = false;
            this.txtCodigoSucursal.Location = new System.Drawing.Point(142, 6);
            this.txtCodigoSucursal.Name = "txtCodigoSucursal";
            this.txtCodigoSucursal.Size = new System.Drawing.Size(116, 20);
            this.txtCodigoSucursal.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tipo de Novedad:";
            // 
            // gridControlNovedadesIESS
            // 
            this.gridControlNovedadesIESS.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlNovedadesIESS.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlNovedadesIESS.Location = new System.Drawing.Point(0, 184);
            this.gridControlNovedadesIESS.MainView = this.gridViewNovedadesIESS;
            this.gridControlNovedadesIESS.Name = "gridControlNovedadesIESS";
            this.gridControlNovedadesIESS.Size = new System.Drawing.Size(826, 297);
            this.gridControlNovedadesIESS.TabIndex = 2;
            this.gridControlNovedadesIESS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNovedadesIESS});
            // 
            // gridViewNovedadesIESS
            // 
            this.gridViewNovedadesIESS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColCedula_,
            this.ColNombres,
            this.colAnio,
            this.ColValor,
            this.ColDepartamento,
            this.ColNomina});
            this.gridViewNovedadesIESS.GridControl = this.gridControlNovedadesIESS;
            this.gridViewNovedadesIESS.Name = "gridViewNovedadesIESS";
            this.gridViewNovedadesIESS.OptionsView.ShowAutoFilterRow = true;
            // 
            // ColCedula_
            // 
            this.ColCedula_.Caption = "Cedula";
            this.ColCedula_.FieldName = "NoCedula";
            this.ColCedula_.Name = "ColCedula_";
            this.ColCedula_.OptionsColumn.AllowEdit = false;
            this.ColCedula_.Visible = true;
            this.ColCedula_.VisibleIndex = 0;
            // 
            // ColNombres
            // 
            this.ColNombres.Caption = "Nombre";
            this.ColNombres.FieldName = "nombre";
            this.ColNombres.Name = "ColNombres";
            this.ColNombres.OptionsColumn.AllowEdit = false;
            this.ColNombres.Visible = true;
            this.ColNombres.VisibleIndex = 1;
            // 
            // colAnio
            // 
            this.colAnio.Caption = "Año";
            this.colAnio.Name = "colAnio";
            this.colAnio.OptionsColumn.AllowEdit = false;
            // 
            // ColValor
            // 
            this.ColValor.Caption = "Valor por horas extra";
            this.ColValor.FieldName = "ValorExtra";
            this.ColValor.Name = "ColValor";
            this.ColValor.OptionsColumn.AllowEdit = false;
            this.ColValor.Visible = true;
            this.ColValor.VisibleIndex = 3;
            // 
            // ColDepartamento
            // 
            this.ColDepartamento.Caption = "Departamento";
            this.ColDepartamento.FieldName = "departamento";
            this.ColDepartamento.Name = "ColDepartamento";
            this.ColDepartamento.OptionsColumn.AllowEdit = false;
            this.ColDepartamento.Visible = true;
            this.ColDepartamento.VisibleIndex = 2;
            // 
            // ColNomina
            // 
            this.ColNomina.Caption = "Nomina";
            this.ColNomina.FieldName = "nomina";
            this.ColNomina.Name = "ColNomina";
            this.ColNomina.OptionsColumn.AllowEdit = false;
            // 
            // frmRo_Generacion_Archivo_Batch_IESS_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 481);
            this.Controls.Add(this.gridControlNovedadesIESS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Generacion_Archivo_Batch_IESS_Mant";
            this.Text = "Generacion de  Archivo  Batch - Novedades al IESS";
            this.Load += new System.EventHandler(this.frmRo_Generacion_Archivo_Batch_IESS_Mant_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnominaTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoNovedad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoSucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNovedadesIESS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNovedadesIESS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCodigoSucursal;
        private System.Windows.Forms.Button cmdGenerar;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipoNovedad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView14;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoLicencia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit txtRutaArchivo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraGrid.GridControl gridControlNovedadesIESS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNovedadesIESS;
        private DevExpress.XtraGrid.Columns.GridColumn ColCedula_;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombres;
        private DevExpress.XtraGrid.Columns.GridColumn colAnio;
        private DevExpress.XtraGrid.Columns.GridColumn ColValor;
        private DevExpress.XtraGrid.Columns.GridColumn ColDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn ColNomina;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbPeriodos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn Colpe_Descripcion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbnominaTipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcionProcesoNomina;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbnomina;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcion;
    }
}