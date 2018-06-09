namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Administracion_Archivos_PreAvisoCheques_Mant
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControlDetalle = new System.Windows.Forms.TabControl();
            this.tabPageOP = new System.Windows.Forms.TabPage();
            this.groupControlGrid = new DevExpress.XtraEditors.GroupControl();
            this.gridControlDetalleCheques = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetalleCheq = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colchecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_TipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Cheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_giradoA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado_Preaviso_ch_cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbteCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipocbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControlFiltro = new DevExpress.XtraEditors.GroupControl();
            this.chkMostar_che_Preavisados = new DevExpress.XtraEditors.CheckEdit();
            this.dtpFechadesde = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlCabecera = new DevExpress.XtraEditors.GroupControl();
            this.lbNombreFile = new System.Windows.Forms.Label();
            this.txtNombreArc = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFEchaPago = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControlObservacion = new DevExpress.XtraEditors.GroupControl();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbRuta = new DevExpress.XtraEditors.ButtonEdit();
            this.panelMain.SuspendLayout();
            this.tabControlDetalle.SuspendLayout();
            this.tabPageOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlGrid)).BeginInit();
            this.groupControlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleCheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleCheq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlFiltro)).BeginInit();
            this.groupControlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostar_che_Preavisados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCabecera)).BeginInit();
            this.groupControlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreArc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlObservacion)).BeginInit();
            this.groupControlObservacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRuta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 512);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1060, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1060, 29);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
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
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabControlDetalle);
            this.panelMain.Controls.Add(this.groupControlCabecera);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1060, 483);
            this.panelMain.TabIndex = 2;
            // 
            // tabControlDetalle
            // 
            this.tabControlDetalle.Controls.Add(this.tabPageOP);
            this.tabControlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDetalle.Location = new System.Drawing.Point(0, 171);
            this.tabControlDetalle.Name = "tabControlDetalle";
            this.tabControlDetalle.SelectedIndex = 0;
            this.tabControlDetalle.Size = new System.Drawing.Size(1060, 312);
            this.tabControlDetalle.TabIndex = 6;
            // 
            // tabPageOP
            // 
            this.tabPageOP.Controls.Add(this.groupControlGrid);
            this.tabPageOP.Controls.Add(this.groupControlFiltro);
            this.tabPageOP.Location = new System.Drawing.Point(4, 22);
            this.tabPageOP.Name = "tabPageOP";
            this.tabPageOP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOP.Size = new System.Drawing.Size(1052, 286);
            this.tabPageOP.TabIndex = 0;
            this.tabPageOP.Text = "Pago a proveedores";
            this.tabPageOP.UseVisualStyleBackColor = true;
            // 
            // groupControlGrid
            // 
            this.groupControlGrid.Controls.Add(this.gridControlDetalleCheques);
            this.groupControlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlGrid.Location = new System.Drawing.Point(3, 64);
            this.groupControlGrid.Name = "groupControlGrid";
            this.groupControlGrid.Size = new System.Drawing.Size(1046, 219);
            this.groupControlGrid.TabIndex = 12;
            this.groupControlGrid.Text = "Datos Generales";
            // 
            // gridControlDetalleCheques
            // 
            this.gridControlDetalleCheques.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDetalleCheques.Location = new System.Drawing.Point(2, 21);
            this.gridControlDetalleCheques.MainView = this.gridViewDetalleCheq;
            this.gridControlDetalleCheques.Name = "gridControlDetalleCheques";
            this.gridControlDetalleCheques.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlDetalleCheques.Size = new System.Drawing.Size(1042, 196);
            this.gridControlDetalleCheques.TabIndex = 0;
            this.gridControlDetalleCheques.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalleCheq,
            this.gridView1});
            // 
            // gridViewDetalleCheq
            // 
            this.gridViewDetalleCheq.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colchecked,
            this.coltc_TipoCbte,
            this.colba_descripcion,
            this.colcb_Cheque,
            this.colcb_Fecha,
            this.colcb_Observacion,
            this.colcb_Valor,
            this.colcb_giradoA,
            this.colIdEstado_Preaviso_ch_cat,
            this.colIdCbteCble,
            this.colIdTipocbte});
            this.gridViewDetalleCheq.GridControl = this.gridControlDetalleCheques;
            this.gridViewDetalleCheq.Name = "gridViewDetalleCheq";
            this.gridViewDetalleCheq.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDetalleCheq.OptionsView.ShowGroupPanel = false;
            // 
            // colchecked
            // 
            this.colchecked.Caption = "*";
            this.colchecked.FieldName = "Cheked";
            this.colchecked.Name = "colchecked";
            this.colchecked.Visible = true;
            this.colchecked.VisibleIndex = 0;
            this.colchecked.Width = 23;
            // 
            // coltc_TipoCbte
            // 
            this.coltc_TipoCbte.Caption = "TipoCbte";
            this.coltc_TipoCbte.FieldName = "Tipo";
            this.coltc_TipoCbte.Name = "coltc_TipoCbte";
            this.coltc_TipoCbte.OptionsColumn.AllowEdit = false;
            this.coltc_TipoCbte.Visible = true;
            this.coltc_TipoCbte.VisibleIndex = 1;
            this.coltc_TipoCbte.Width = 51;
            // 
            // colba_descripcion
            // 
            this.colba_descripcion.Caption = "Banco";
            this.colba_descripcion.FieldName = "Banco";
            this.colba_descripcion.Name = "colba_descripcion";
            this.colba_descripcion.OptionsColumn.AllowEdit = false;
            this.colba_descripcion.Visible = true;
            this.colba_descripcion.VisibleIndex = 2;
            this.colba_descripcion.Width = 162;
            // 
            // colcb_Cheque
            // 
            this.colcb_Cheque.Caption = "#Cheque";
            this.colcb_Cheque.FieldName = "cb_Cheque";
            this.colcb_Cheque.Name = "colcb_Cheque";
            this.colcb_Cheque.OptionsColumn.AllowEdit = false;
            this.colcb_Cheque.Visible = true;
            this.colcb_Cheque.VisibleIndex = 3;
            this.colcb_Cheque.Width = 87;
            // 
            // colcb_Fecha
            // 
            this.colcb_Fecha.Caption = "Fecha";
            this.colcb_Fecha.FieldName = "cb_Fecha";
            this.colcb_Fecha.Name = "colcb_Fecha";
            this.colcb_Fecha.OptionsColumn.AllowEdit = false;
            this.colcb_Fecha.Visible = true;
            this.colcb_Fecha.VisibleIndex = 4;
            this.colcb_Fecha.Width = 72;
            // 
            // colcb_Observacion
            // 
            this.colcb_Observacion.Caption = "Observacion";
            this.colcb_Observacion.FieldName = "cb_Observacion";
            this.colcb_Observacion.Name = "colcb_Observacion";
            this.colcb_Observacion.OptionsColumn.AllowEdit = false;
            this.colcb_Observacion.Visible = true;
            this.colcb_Observacion.VisibleIndex = 5;
            this.colcb_Observacion.Width = 335;
            // 
            // colcb_Valor
            // 
            this.colcb_Valor.Caption = "Valor";
            this.colcb_Valor.FieldName = "cb_Valor";
            this.colcb_Valor.Name = "colcb_Valor";
            this.colcb_Valor.OptionsColumn.AllowEdit = false;
            this.colcb_Valor.Visible = true;
            this.colcb_Valor.VisibleIndex = 7;
            this.colcb_Valor.Width = 101;
            // 
            // colcb_giradoA
            // 
            this.colcb_giradoA.Caption = "Girado A";
            this.colcb_giradoA.FieldName = "cb_giradoA";
            this.colcb_giradoA.Name = "colcb_giradoA";
            this.colcb_giradoA.OptionsColumn.AllowEdit = false;
            this.colcb_giradoA.Visible = true;
            this.colcb_giradoA.VisibleIndex = 6;
            this.colcb_giradoA.Width = 195;
            // 
            // colIdEstado_Preaviso_ch_cat
            // 
            this.colIdEstado_Preaviso_ch_cat.Caption = "Estado/Preaviso";
            this.colIdEstado_Preaviso_ch_cat.FieldName = "IdEstado_Preaviso_ch_cat";
            this.colIdEstado_Preaviso_ch_cat.Name = "colIdEstado_Preaviso_ch_cat";
            this.colIdEstado_Preaviso_ch_cat.OptionsColumn.AllowEdit = false;
            this.colIdEstado_Preaviso_ch_cat.Width = 84;
            // 
            // colIdCbteCble
            // 
            this.colIdCbteCble.Caption = "IdCbteCble";
            this.colIdCbteCble.FieldName = "IdCbteCble";
            this.colIdCbteCble.Name = "colIdCbteCble";
            this.colIdCbteCble.OptionsColumn.AllowEdit = false;
            // 
            // colIdTipocbte
            // 
            this.colIdTipocbte.Caption = "IdTipocbte";
            this.colIdTipocbte.FieldName = "IdTipocbte";
            this.colIdTipocbte.Name = "colIdTipocbte";
            this.colIdTipocbte.OptionsColumn.AllowEdit = false;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlDetalleCheques;
            this.gridView1.Name = "gridView1";
            // 
            // groupControlFiltro
            // 
            this.groupControlFiltro.Controls.Add(this.chkMostar_che_Preavisados);
            this.groupControlFiltro.Controls.Add(this.dtpFechadesde);
            this.groupControlFiltro.Controls.Add(this.label6);
            this.groupControlFiltro.Controls.Add(this.dtpFechaHasta);
            this.groupControlFiltro.Controls.Add(this.label8);
            this.groupControlFiltro.Controls.Add(this.cmbBuscar);
            this.groupControlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlFiltro.Location = new System.Drawing.Point(3, 3);
            this.groupControlFiltro.Name = "groupControlFiltro";
            this.groupControlFiltro.Size = new System.Drawing.Size(1046, 61);
            this.groupControlFiltro.TabIndex = 11;
            this.groupControlFiltro.Text = "Filtros para Buscar ordenes de pagos";
            // 
            // chkMostar_che_Preavisados
            // 
            this.chkMostar_che_Preavisados.Location = new System.Drawing.Point(359, 33);
            this.chkMostar_che_Preavisados.Name = "chkMostar_che_Preavisados";
            this.chkMostar_che_Preavisados.Properties.Caption = "Mostrar Cheques Preavisados";
            this.chkMostar_che_Preavisados.Size = new System.Drawing.Size(174, 19);
            this.chkMostar_che_Preavisados.TabIndex = 161;
            // 
            // dtpFechadesde
            // 
            this.dtpFechadesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechadesde.Location = new System.Drawing.Point(57, 30);
            this.dtpFechadesde.Name = "dtpFechadesde";
            this.dtpFechadesde.Size = new System.Drawing.Size(100, 20);
            this.dtpFechadesde.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Desde:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(222, 31);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaHasta.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Hasta:";
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.Location = new System.Drawing.Point(643, 29);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(124, 26);
            this.cmbBuscar.TabIndex = 160;
            this.cmbBuscar.Text = "Buscar cheques";
            this.cmbBuscar.Click += new System.EventHandler(this.cmbBuscar_Click);
            // 
            // groupControlCabecera
            // 
            this.groupControlCabecera.Controls.Add(this.lbNombreFile);
            this.groupControlCabecera.Controls.Add(this.txtNombreArc);
            this.groupControlCabecera.Controls.Add(this.txtId);
            this.groupControlCabecera.Controls.Add(this.label2);
            this.groupControlCabecera.Controls.Add(this.dtpFEchaPago);
            this.groupControlCabecera.Controls.Add(this.label1);
            this.groupControlCabecera.Controls.Add(this.groupControlObservacion);
            this.groupControlCabecera.Controls.Add(this.labelControl1);
            this.groupControlCabecera.Controls.Add(this.cmbRuta);
            this.groupControlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlCabecera.Location = new System.Drawing.Point(0, 0);
            this.groupControlCabecera.Name = "groupControlCabecera";
            this.groupControlCabecera.Size = new System.Drawing.Size(1060, 171);
            this.groupControlCabecera.TabIndex = 5;
            this.groupControlCabecera.Text = "Datos Generales";
            // 
            // lbNombreFile
            // 
            this.lbNombreFile.AutoSize = true;
            this.lbNombreFile.Location = new System.Drawing.Point(17, 87);
            this.lbNombreFile.Name = "lbNombreFile";
            this.lbNombreFile.Size = new System.Drawing.Size(102, 13);
            this.lbNombreFile.TabIndex = 172;
            this.lbNombreFile.Text = "Nombre del archivo:";
            // 
            // txtNombreArc
            // 
            this.txtNombreArc.Location = new System.Drawing.Point(125, 84);
            this.txtNombreArc.Name = "txtNombreArc";
            this.txtNombreArc.Properties.MaxLength = 50;
            this.txtNombreArc.Size = new System.Drawing.Size(355, 20);
            this.txtNombreArc.TabIndex = 171;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(125, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 169;
            this.label2.Text = "Id Archivo:";
            // 
            // dtpFEchaPago
            // 
            this.dtpFEchaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFEchaPago.Location = new System.Drawing.Point(924, 24);
            this.dtpFEchaPago.Name = "dtpFEchaPago";
            this.dtpFEchaPago.Size = new System.Drawing.Size(100, 20);
            this.dtpFEchaPago.TabIndex = 167;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(832, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 166;
            this.label1.Text = "Fecha Emision:";
            // 
            // groupControlObservacion
            // 
            this.groupControlObservacion.Controls.Add(this.txtObservacion);
            this.groupControlObservacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlObservacion.Location = new System.Drawing.Point(2, 108);
            this.groupControlObservacion.Name = "groupControlObservacion";
            this.groupControlObservacion.Size = new System.Drawing.Size(1056, 61);
            this.groupControlObservacion.TabIndex = 163;
            this.groupControlObservacion.Text = "Observacion";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacion.Location = new System.Drawing.Point(2, 21);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(1052, 38);
            this.txtObservacion.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 159;
            this.labelControl1.Text = "Ruta  descarga:";
            // 
            // cmbRuta
            // 
            this.cmbRuta.Location = new System.Drawing.Point(125, 58);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbRuta.Properties.ReadOnly = true;
            this.cmbRuta.Size = new System.Drawing.Size(355, 20);
            this.cmbRuta.TabIndex = 158;
            // 
            // FrmBA_Administracion_Archivos_PreAvisoCheques_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 538);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmBA_Administracion_Archivos_PreAvisoCheques_Mant";
            this.Text = "FrmBA_Administracion_Archivos_PreAvisoCheques_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBA_Administracion_Archivos_PreAvisoCheques_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmBA_Administracion_Archivos_PreAvisoCheques_Mant_Load);
            this.panelMain.ResumeLayout(false);
            this.tabControlDetalle.ResumeLayout(false);
            this.tabPageOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlGrid)).EndInit();
            this.groupControlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleCheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleCheq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlFiltro)).EndInit();
            this.groupControlFiltro.ResumeLayout(false);
            this.groupControlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostar_che_Preavisados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCabecera)).EndInit();
            this.groupControlCabecera.ResumeLayout(false);
            this.groupControlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreArc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlObservacion)).EndInit();
            this.groupControlObservacion.ResumeLayout(false);
            this.groupControlObservacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRuta.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraEditors.GroupControl groupControlCabecera;
        private System.Windows.Forms.Label lbNombreFile;
        private DevExpress.XtraEditors.TextEdit txtNombreArc;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFEchaPago;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControlObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit cmbRuta;
        private System.Windows.Forms.TabControl tabControlDetalle;
        private System.Windows.Forms.TabPage tabPageOP;
        private DevExpress.XtraEditors.GroupControl groupControlGrid;
        private DevExpress.XtraGrid.GridControl gridControlDetalleCheques;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalleCheq;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControlFiltro;
        private DevExpress.XtraEditors.CheckEdit chkMostar_che_Preavisados;
        private System.Windows.Forms.DateTimePicker dtpFechadesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton cmbBuscar;
        private DevExpress.XtraGrid.Columns.GridColumn colchecked;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_TipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colba_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Cheque;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Valor;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_giradoA;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado_Preaviso_ch_cat;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipocbte;
    }
}