namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class FrmFa_Registro_de_horas_x_equipo_Mantenimiento
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
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.gridControlRegistros = new DevExpress.XtraGrid.GridControl();
            this.gridViewRegistros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmb_UnidadMedida = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.txtIdRegistro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ucCon_Periodo1 = new Core.Erp.Winform.Controles.UCCon_Periodo();
            this.ucFa_Cliente_x_centro_costo_cmb1 = new Core.Erp.Winform.Controles.UCFa_Cliente_x_centro_costo_cmb();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.ucFa_CatalogosCmb1 = new Core.Erp.Winform.Controles.UCFa_CatalogosCmb();
            this.lblAnulado = new DevExpress.XtraEditors.LabelControl();
            this.groupBoxEquiposAsignados = new System.Windows.Forms.GroupBox();
            this.gridControlEquiposAsignados = new DevExpress.XtraGrid.GridControl();
            this.gridViewEquiposAsignados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAsignado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.check = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colnom_Activo_fijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_Unidad_Fact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Valor_Unidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.panelPrincipal.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdRegistro.Properties)).BeginInit();
            this.groupBoxEquiposAsignados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEquiposAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEquiposAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 479);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1076, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
            // 
            // ucGe_Menu_Superior_Mant1
            // 
            this.ucGe_Menu_Superior_Mant1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant1.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(1076, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 1;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelDetalle);
            this.panelPrincipal.Controls.Add(this.panelCabecera);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 29);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1076, 450);
            this.panelPrincipal.TabIndex = 2;
            // 
            // panelDetalle
            // 
            this.panelDetalle.Controls.Add(this.gridControlRegistros);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalle.Location = new System.Drawing.Point(0, 166);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(1076, 284);
            this.panelDetalle.TabIndex = 1;
            // 
            // gridControlRegistros
            // 
            this.gridControlRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRegistros.Location = new System.Drawing.Point(0, 0);
            this.gridControlRegistros.MainView = this.gridViewRegistros;
            this.gridControlRegistros.Name = "gridControlRegistros";
            this.gridControlRegistros.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_UnidadMedida});
            this.gridControlRegistros.Size = new System.Drawing.Size(1076, 284);
            this.gridControlRegistros.TabIndex = 0;
            this.gridControlRegistros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRegistros});
            // 
            // gridViewRegistros
            // 
            this.gridViewRegistros.GridControl = this.gridControlRegistros;
            this.gridViewRegistros.Name = "gridViewRegistros";
            this.gridViewRegistros.OptionsView.ColumnAutoWidth = false;
            this.gridViewRegistros.OptionsView.ShowGroupPanel = false;
            this.gridViewRegistros.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewRegistros_CellValueChanged);
            // 
            // cmb_UnidadMedida
            // 
            this.cmb_UnidadMedida.AutoHeight = false;
            this.cmb_UnidadMedida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_UnidadMedida.Name = "cmb_UnidadMedida";
            this.cmb_UnidadMedida.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUnidadMedida,
            this.colDescripcion});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdUnidadMedida
            // 
            this.colIdUnidadMedida.Caption = "ID";
            this.colIdUnidadMedida.FieldName = "IdUnidadMedida";
            this.colIdUnidadMedida.Name = "colIdUnidadMedida";
            this.colIdUnidadMedida.Visible = true;
            this.colIdUnidadMedida.VisibleIndex = 1;
            this.colIdUnidadMedida.Width = 339;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 841;
            // 
            // panelCabecera
            // 
            this.panelCabecera.Controls.Add(this.txtIdRegistro);
            this.panelCabecera.Controls.Add(this.labelControl1);
            this.panelCabecera.Controls.Add(this.labelControl4);
            this.panelCabecera.Controls.Add(this.labelControl2);
            this.panelCabecera.Controls.Add(this.ucCon_Periodo1);
            this.panelCabecera.Controls.Add(this.ucFa_Cliente_x_centro_costo_cmb1);
            this.panelCabecera.Controls.Add(this.labelControl8);
            this.panelCabecera.Controls.Add(this.ucFa_CatalogosCmb1);
            this.panelCabecera.Controls.Add(this.lblAnulado);
            this.panelCabecera.Controls.Add(this.groupBoxEquiposAsignados);
            this.panelCabecera.Controls.Add(this.deFecha);
            this.panelCabecera.Controls.Add(this.labelControl6);
            this.panelCabecera.Controls.Add(this.labelControl3);
            this.panelCabecera.Controls.Add(this.txtObservacion);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1076, 166);
            this.panelCabecera.TabIndex = 0;
            // 
            // txtIdRegistro
            // 
            this.txtIdRegistro.Location = new System.Drawing.Point(101, 9);
            this.txtIdRegistro.Name = "txtIdRegistro";
            this.txtIdRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtIdRegistro.TabIndex = 26;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "# Registro:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 115);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Periodo:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Desde:";
            // 
            // ucCon_Periodo1
            // 
            this.ucCon_Periodo1.Enabled_cmb_Periodo = true;
            this.ucCon_Periodo1.Enabled_de_Desde = true;
            this.ucCon_Periodo1.Enabled_de_Hasta = true;
            this.ucCon_Periodo1.Location = new System.Drawing.Point(23, 108);
            this.ucCon_Periodo1.Name = "ucCon_Periodo1";
            this.ucCon_Periodo1.ReadOnly_cmb_Periodo = false;
            this.ucCon_Periodo1.ReadOnly_de_Desde = true;
            this.ucCon_Periodo1.ReadOnly_de_Hasta = true;
            this.ucCon_Periodo1.Size = new System.Drawing.Size(345, 56);
            this.ucCon_Periodo1.TabIndex = 22;
            this.ucCon_Periodo1.Visible_cmb_Periodo = true;
            this.ucCon_Periodo1.Visible_de_Desde = true;
            this.ucCon_Periodo1.Visible_de_Hasta = true;
            this.ucCon_Periodo1.Visible_lblDesde = false;
            this.ucCon_Periodo1.Visible_lblHasta = true;
            this.ucCon_Periodo1.Visible_lblPeriodo = false;
            // 
            // ucFa_Cliente_x_centro_costo_cmb1
            // 
            this.ucFa_Cliente_x_centro_costo_cmb1.Enabled_BtnAccion_cc = true;
            this.ucFa_Cliente_x_centro_costo_cmb1.Enabled_BtnAccion_cli = true;
            this.ucFa_Cliente_x_centro_costo_cmb1.Enabled_BtnAccion_Scc = true;
            this.ucFa_Cliente_x_centro_costo_cmb1.Enabled_cmb_Centro_costo = true;
            this.ucFa_Cliente_x_centro_costo_cmb1.Enabled_cmb_Cliente = true;
            this.ucFa_Cliente_x_centro_costo_cmb1.Location = new System.Drawing.Point(11, 31);
            this.ucFa_Cliente_x_centro_costo_cmb1.Name = "ucFa_Cliente_x_centro_costo_cmb1";
            this.ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_cmb_Centro_costo = true;
            this.ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_cmb_Cliente = false;
            this.ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_cmb_Subcentro_costo = false;
            this.ucFa_Cliente_x_centro_costo_cmb1.Size = new System.Drawing.Size(654, 75);
            this.ucFa_Cliente_x_centro_costo_cmb1.TabIndex = 21;
            this.ucFa_Cliente_x_centro_costo_cmb1.Visible_BtnAccion_cc = true;
            this.ucFa_Cliente_x_centro_costo_cmb1.Visible_BtnAccion_cli = true;
            this.ucFa_Cliente_x_centro_costo_cmb1.Visible_btnAccion_Scc = true;
            this.ucFa_Cliente_x_centro_costo_cmb1.Visible_cmb_Centro_costo = true;
            this.ucFa_Cliente_x_centro_costo_cmb1.Visible_cmb_Cliente = true;
            this.ucFa_Cliente_x_centro_costo_cmb1.Visible_cmb_Subcentro_costo = true;
            this.ucFa_Cliente_x_centro_costo_cmb1.Visible_lblCentro_costo = true;
            this.ucFa_Cliente_x_centro_costo_cmb1.Visible_lblCliente = true;
            this.ucFa_Cliente_x_centro_costo_cmb1.Visible_lblSub_centro_costo = true;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(516, 10);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(79, 13);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Estado vigencia:";
            // 
            // ucFa_CatalogosCmb1
            // 
            this.ucFa_CatalogosCmb1.Location = new System.Drawing.Point(603, 3);
            this.ucFa_CatalogosCmb1.Name = "ucFa_CatalogosCmb1";
            this.ucFa_CatalogosCmb1.Size = new System.Drawing.Size(279, 30);
            this.ucFa_CatalogosCmb1.TabIndex = 19;
            this.ucFa_CatalogosCmb1.Visible_cmb_Accion = false;
            // 
            // lblAnulado
            // 
            this.lblAnulado.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(279, 7);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(153, 18);
            this.lblAnulado.TabIndex = 18;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // groupBoxEquiposAsignados
            // 
            this.groupBoxEquiposAsignados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEquiposAsignados.Controls.Add(this.gridControlEquiposAsignados);
            this.groupBoxEquiposAsignados.Location = new System.Drawing.Point(672, 31);
            this.groupBoxEquiposAsignados.Name = "groupBoxEquiposAsignados";
            this.groupBoxEquiposAsignados.Size = new System.Drawing.Size(392, 133);
            this.groupBoxEquiposAsignados.TabIndex = 15;
            this.groupBoxEquiposAsignados.TabStop = false;
            this.groupBoxEquiposAsignados.Text = "Equipos Asignados";
            // 
            // gridControlEquiposAsignados
            // 
            this.gridControlEquiposAsignados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEquiposAsignados.Location = new System.Drawing.Point(3, 16);
            this.gridControlEquiposAsignados.MainView = this.gridViewEquiposAsignados;
            this.gridControlEquiposAsignados.Name = "gridControlEquiposAsignados";
            this.gridControlEquiposAsignados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.check});
            this.gridControlEquiposAsignados.Size = new System.Drawing.Size(386, 114);
            this.gridControlEquiposAsignados.TabIndex = 14;
            this.gridControlEquiposAsignados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEquiposAsignados});
            // 
            // gridViewEquiposAsignados
            // 
            this.gridViewEquiposAsignados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAsignado,
            this.colnom_Activo_fijo,
            this.col_nom_Unidad_Fact,
            this.col_Valor_Unidad});
            this.gridViewEquiposAsignados.GridControl = this.gridControlEquiposAsignados;
            this.gridViewEquiposAsignados.Name = "gridViewEquiposAsignados";
            this.gridViewEquiposAsignados.OptionsView.ShowGroupPanel = false;
            this.gridViewEquiposAsignados.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewEquiposAsignados_CellValueChanged);
            // 
            // colAsignado
            // 
            this.colAsignado.Caption = "*";
            this.colAsignado.ColumnEdit = this.check;
            this.colAsignado.FieldName = "Asignado";
            this.colAsignado.Name = "colAsignado";
            this.colAsignado.Visible = true;
            this.colAsignado.VisibleIndex = 0;
            this.colAsignado.Width = 20;
            // 
            // check
            // 
            this.check.AutoHeight = false;
            this.check.Name = "check";
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // colnom_Activo_fijo
            // 
            this.colnom_Activo_fijo.Caption = "Equipo";
            this.colnom_Activo_fijo.FieldName = "Af_DescripcionCorta";
            this.colnom_Activo_fijo.Name = "colnom_Activo_fijo";
            this.colnom_Activo_fijo.OptionsColumn.AllowEdit = false;
            this.colnom_Activo_fijo.Visible = true;
            this.colnom_Activo_fijo.VisibleIndex = 1;
            this.colnom_Activo_fijo.Width = 289;
            // 
            // col_nom_Unidad_Fact
            // 
            this.col_nom_Unidad_Fact.Caption = "Unidad";
            this.col_nom_Unidad_Fact.FieldName = "nom_UnidadFact";
            this.col_nom_Unidad_Fact.Name = "col_nom_Unidad_Fact";
            this.col_nom_Unidad_Fact.OptionsColumn.AllowEdit = false;
            this.col_nom_Unidad_Fact.Visible = true;
            this.col_nom_Unidad_Fact.VisibleIndex = 3;
            this.col_nom_Unidad_Fact.Width = 96;
            // 
            // col_Valor_Unidad
            // 
            this.col_Valor_Unidad.Caption = "U. Actuales";
            this.col_Valor_Unidad.FieldName = "Af_ValorUnidad_Actu";
            this.col_Valor_Unidad.Name = "col_Valor_Unidad";
            this.col_Valor_Unidad.OptionsColumn.AllowEdit = false;
            this.col_Valor_Unidad.Visible = true;
            this.col_Valor_Unidad.VisibleIndex = 2;
            this.col_Valor_Unidad.Width = 93;
            // 
            // deFecha
            // 
            this.deFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deFecha.EditValue = new System.DateTime(2016, 4, 28, 12, 13, 54, 705);
            this.deFecha.Location = new System.Drawing.Point(935, 8);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFecha.Size = new System.Drawing.Size(129, 20);
            this.deFecha.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(888, 11);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(33, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Fecha:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(374, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Observación:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(445, 112);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(212, 47);
            this.txtObservacion.TabIndex = 8;
            // 
            // FrmFa_Registro_de_horas_x_equipo_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 505);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmFa_Registro_de_horas_x_equipo_Mantenimiento";
            this.Text = "Registro de unidades x equipo mantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFa_Registro_de_horas_x_equipo_Mantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.FrmFa_Registro_de_horas_x_equipo_Mantenimiento_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdRegistro.Properties)).EndInit();
            this.groupBoxEquiposAsignados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEquiposAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEquiposAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Panel panelCabecera;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private DevExpress.XtraEditors.MemoEdit txtObservacion;
        private DevExpress.XtraGrid.GridControl gridControlRegistros;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRegistros;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_UnidadMedida;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private System.Windows.Forms.GroupBox groupBoxEquiposAsignados;
        private DevExpress.XtraGrid.GridControl gridControlEquiposAsignados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEquiposAsignados;
        private DevExpress.XtraGrid.Columns.GridColumn colAsignado;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_Activo_fijo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit check;
        private DevExpress.XtraEditors.LabelControl lblAnulado;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_Unidad_Fact;
        private DevExpress.XtraGrid.Columns.GridColumn col_Valor_Unidad;
        private Controles.UCFa_CatalogosCmb ucFa_CatalogosCmb1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Controles.UCFa_Cliente_x_centro_costo_cmb ucFa_Cliente_x_centro_costo_cmb1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Controles.UCCon_Periodo ucCon_Periodo1;
        private DevExpress.XtraEditors.TextEdit txtIdRegistro;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}