namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Liquidacion_Vacaciones_Mant
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ucGe_Beneficiario = new Core.Erp.Winform.Controles.UCGe_Beneficiario();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_Detalle = new DevExpress.XtraGrid.GridControl();
            this.gridView_Detalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Anio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Total_Remuneracion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Total_Vacaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Valor_Cancelar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.txttotal_vacaciones = new DevExpress.XtraEditors.TextEdit();
            this.txtdias = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtiess = new DevExpress.XtraEditors.TextEdit();
            this.txttotal_remuneracion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txttotal_cancelar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.dtpFechaRetorno = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dtp_anio_hasta = new System.Windows.Forms.DateTimePicker();
            this.dtpanio_desde = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal_vacaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtiess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal_remuneracion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal_cancelar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 49;
            this.labelControl1.Text = "Id Empleado:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ucGe_Beneficiario);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(839, 76);
            this.groupControl1.TabIndex = 50;
            this.groupControl1.Text = "Datos empleado";
            // 
            // ucGe_Beneficiario
            // 
            this.ucGe_Beneficiario.IdTipo_Persona = Core.Erp.Info.General.Cl_Enumeradores.eTipoPersona.CLIENTE;
            this.ucGe_Beneficiario.Location = new System.Drawing.Point(5, 44);
            this.ucGe_Beneficiario.Name = "ucGe_Beneficiario";
            this.ucGe_Beneficiario.Size = new System.Drawing.Size(616, 26);
            this.ucGe_Beneficiario.TabIndex = 57;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(137, 24);
            this.txtid.Name = "txtid";
            this.txtid.Properties.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(86, 20);
            this.txtid.TabIndex = 53;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl_Detalle);
            this.groupControl2.Controls.Add(this.groupControl6);
            this.groupControl2.Controls.Add(this.groupControl5);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 105);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(839, 403);
            this.groupControl2.TabIndex = 51;
            this.groupControl2.Text = "Datos Solicitud vacaciones";
            // 
            // gridControl_Detalle
            // 
            this.gridControl_Detalle.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl_Detalle.Location = new System.Drawing.Point(2, 21);
            this.gridControl_Detalle.MainView = this.gridView_Detalle;
            this.gridControl_Detalle.Name = "gridControl_Detalle";
            this.gridControl_Detalle.Size = new System.Drawing.Size(612, 380);
            this.gridControl_Detalle.TabIndex = 71;
            this.gridControl_Detalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Detalle});
            // 
            // gridView_Detalle
            // 
            this.gridView_Detalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Anio,
            this.Col_Mes,
            this.Col_Total_Remuneracion,
            this.Col_Total_Vacaciones,
            this.Col_Valor_Cancelar});
            this.gridView_Detalle.GridControl = this.gridControl_Detalle;
            this.gridView_Detalle.Name = "gridView_Detalle";
            this.gridView_Detalle.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_Detalle.OptionsView.ShowGroupPanel = false;
            this.gridView_Detalle.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_Detalle_FocusedRowChanged);
            this.gridView_Detalle.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_Detalle_CellValueChanged);
            // 
            // Col_Anio
            // 
            this.Col_Anio.Caption = "Año";
            this.Col_Anio.FieldName = "Anio";
            this.Col_Anio.Name = "Col_Anio";
            this.Col_Anio.Visible = true;
            this.Col_Anio.VisibleIndex = 0;
            // 
            // Col_Mes
            // 
            this.Col_Mes.Caption = "Mes";
            this.Col_Mes.FieldName = "Mes";
            this.Col_Mes.Name = "Col_Mes";
            this.Col_Mes.Visible = true;
            this.Col_Mes.VisibleIndex = 1;
            // 
            // Col_Total_Remuneracion
            // 
            this.Col_Total_Remuneracion.Caption = "Tol. Remuneracion";
            this.Col_Total_Remuneracion.FieldName = "Total_Remuneracion";
            this.Col_Total_Remuneracion.Name = "Col_Total_Remuneracion";
            this.Col_Total_Remuneracion.Visible = true;
            this.Col_Total_Remuneracion.VisibleIndex = 2;
            // 
            // Col_Total_Vacaciones
            // 
            this.Col_Total_Vacaciones.Caption = "Tot. Vacaciones";
            this.Col_Total_Vacaciones.FieldName = "Total_Vacaciones";
            this.Col_Total_Vacaciones.Name = "Col_Total_Vacaciones";
            this.Col_Total_Vacaciones.Visible = true;
            this.Col_Total_Vacaciones.VisibleIndex = 3;
            // 
            // Col_Valor_Cancelar
            // 
            this.Col_Valor_Cancelar.Caption = "Vacaciones";
            this.Col_Valor_Cancelar.FieldName = "Valor_Cancelar";
            this.Col_Valor_Cancelar.Name = "Col_Valor_Cancelar";
            this.Col_Valor_Cancelar.Visible = true;
            this.Col_Valor_Cancelar.VisibleIndex = 4;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.txttotal_vacaciones);
            this.groupControl6.Controls.Add(this.txtdias);
            this.groupControl6.Controls.Add(this.labelControl11);
            this.groupControl6.Controls.Add(this.labelControl10);
            this.groupControl6.Controls.Add(this.txtiess);
            this.groupControl6.Controls.Add(this.txttotal_remuneracion);
            this.groupControl6.Controls.Add(this.labelControl9);
            this.groupControl6.Controls.Add(this.txttotal_cancelar);
            this.groupControl6.Controls.Add(this.labelControl5);
            this.groupControl6.Controls.Add(this.labelControl4);
            this.groupControl6.Location = new System.Drawing.Point(620, 254);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(205, 140);
            this.groupControl6.TabIndex = 70;
            this.groupControl6.Text = "Valor de vacaciones";
            // 
            // txttotal_vacaciones
            // 
            this.txttotal_vacaciones.Location = new System.Drawing.Point(112, 65);
            this.txttotal_vacaciones.Name = "txttotal_vacaciones";
            this.txttotal_vacaciones.Properties.Mask.EditMask = "n2";
            this.txttotal_vacaciones.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txttotal_vacaciones.Size = new System.Drawing.Size(86, 20);
            this.txttotal_vacaciones.TabIndex = 62;
            this.txttotal_vacaciones.EditValueChanged += new System.EventHandler(this.txttotal_vacaciones_EditValueChanged);
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(111, 18);
            this.txtdias.Name = "txtdias";
            this.txtdias.Properties.ReadOnly = true;
            this.txtdias.Size = new System.Drawing.Size(86, 20);
            this.txtdias.TabIndex = 60;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(11, 114);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(80, 13);
            this.labelControl11.TabIndex = 59;
            this.labelControl11.Text = "Valor a cancelar:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(12, 68);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(80, 13);
            this.labelControl10.TabIndex = 58;
            this.labelControl10.Text = "Tot. vacasiones:";
            // 
            // txtiess
            // 
            this.txtiess.Location = new System.Drawing.Point(111, 89);
            this.txtiess.Name = "txtiess";
            this.txtiess.Properties.Mask.EditMask = "n2";
            this.txtiess.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtiess.Size = new System.Drawing.Size(86, 20);
            this.txtiess.TabIndex = 69;
            this.txtiess.EditValueChanged += new System.EventHandler(this.txtiess_EditValueChanged);
            // 
            // txttotal_remuneracion
            // 
            this.txttotal_remuneracion.Location = new System.Drawing.Point(112, 43);
            this.txttotal_remuneracion.Name = "txttotal_remuneracion";
            this.txttotal_remuneracion.Properties.Mask.EditMask = "n2";
            this.txttotal_remuneracion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txttotal_remuneracion.Size = new System.Drawing.Size(86, 20);
            this.txttotal_remuneracion.TabIndex = 61;
            this.txttotal_remuneracion.EditValueChanged += new System.EventHandler(this.txttotal_remuneracion_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(11, 44);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(95, 13);
            this.labelControl9.TabIndex = 57;
            this.labelControl9.Text = "Tot. Remuneracion:";
            // 
            // txttotal_cancelar
            // 
            this.txttotal_cancelar.Location = new System.Drawing.Point(111, 111);
            this.txttotal_cancelar.Name = "txttotal_cancelar";
            this.txttotal_cancelar.Properties.Mask.EditMask = "n2";
            this.txttotal_cancelar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txttotal_cancelar.Size = new System.Drawing.Size(86, 20);
            this.txttotal_cancelar.TabIndex = 63;
            this.txttotal_cancelar.EditValueChanged += new System.EventHandler(this.txttotal_cancelar_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 21);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 13);
            this.labelControl5.TabIndex = 56;
            this.labelControl5.Text = "Dias tomados:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 92);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 13);
            this.labelControl4.TabIndex = 68;
            this.labelControl4.Text = "IESS Personal:";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.dtpFechaRetorno);
            this.groupControl5.Controls.Add(this.dtpFechaPago);
            this.groupControl5.Controls.Add(this.labelControl6);
            this.groupControl5.Controls.Add(this.labelControl18);
            this.groupControl5.Location = new System.Drawing.Point(620, 173);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(205, 75);
            this.groupControl5.TabIndex = 69;
            this.groupControl5.Text = "Fecha Pago/Retorno";
            // 
            // dtpFechaRetorno
            // 
            this.dtpFechaRetorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRetorno.Location = new System.Drawing.Point(93, 24);
            this.dtpFechaRetorno.Name = "dtpFechaRetorno";
            this.dtpFechaRetorno.Size = new System.Drawing.Size(87, 20);
            this.dtpFechaRetorno.TabIndex = 66;
            this.dtpFechaRetorno.ValueChanged += new System.EventHandler(this.dtpFechaRetorno_ValueChanged);
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPago.Location = new System.Drawing.Point(93, 50);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(84, 20);
            this.dtpFechaPago.TabIndex = 64;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(8, 30);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 13);
            this.labelControl6.TabIndex = 55;
            this.labelControl6.Text = "Fecha retorno:";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(11, 50);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(60, 13);
            this.labelControl18.TabIndex = 53;
            this.labelControl18.Text = "Fecha Pago:";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dtpFechaSalida);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.dtpFechaHasta);
            this.groupControl3.Location = new System.Drawing.Point(621, 95);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(204, 72);
            this.groupControl3.TabIndex = 68;
            this.groupControl3.Text = "Fecha vacaciones";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(89, 24);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaSalida.TabIndex = 64;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 49);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(32, 13);
            this.labelControl7.TabIndex = 54;
            this.labelControl7.Text = "Hasta:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(10, 27);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(34, 13);
            this.labelControl8.TabIndex = 53;
            this.labelControl8.Text = "Desde:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(89, 46);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaHasta.TabIndex = 65;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.dtp_anio_hasta);
            this.groupControl4.Controls.Add(this.dtpanio_desde);
            this.groupControl4.Controls.Add(this.labelControl2);
            this.groupControl4.Controls.Add(this.labelControl12);
            this.groupControl4.Location = new System.Drawing.Point(621, 24);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(204, 72);
            this.groupControl4.TabIndex = 67;
            this.groupControl4.Text = "Periodo de liquidacion vacaciones";
            // 
            // dtp_anio_hasta
            // 
            this.dtp_anio_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_anio_hasta.Location = new System.Drawing.Point(89, 45);
            this.dtp_anio_hasta.Name = "dtp_anio_hasta";
            this.dtp_anio_hasta.Size = new System.Drawing.Size(86, 20);
            this.dtp_anio_hasta.TabIndex = 69;
            this.dtp_anio_hasta.ValueChanged += new System.EventHandler(this.dtp_anio_hasta_ValueChanged);
            // 
            // dtpanio_desde
            // 
            this.dtpanio_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpanio_desde.Location = new System.Drawing.Point(89, 23);
            this.dtpanio_desde.Name = "dtpanio_desde";
            this.dtpanio_desde.Size = new System.Drawing.Size(86, 20);
            this.dtpanio_desde.TabIndex = 68;
            this.dtpanio_desde.ValueChanged += new System.EventHandler(this.dtpanio_desde_ValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 67;
            this.labelControl2.Text = "Hasta:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(10, 26);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(34, 13);
            this.labelControl12.TabIndex = 66;
            this.labelControl12.Text = "Desde:";
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = false;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(839, 29);
            this.ucGe_Menu.TabIndex = 48;
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
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // frmRo_Liquidacion_Vacaciones_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 505);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Liquidacion_Vacaciones_Mant";
            this.Text = "frmRo_Liquidacion_Vacasiones_Mant";
            this.Load += new System.EventHandler(this.frmRo_Liquidacion_Vacaciones_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal_vacaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtiess.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal_remuneracion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal_cancelar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtdias;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txttotal_cancelar;
        private DevExpress.XtraEditors.TextEdit txttotal_vacaciones;
        private DevExpress.XtraEditors.TextEdit txttotal_remuneracion;
        private System.Windows.Forms.DateTimePicker dtpFechaRetorno;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private Controles.UCGe_Beneficiario ucGe_Beneficiario;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.DateTimePicker dtp_anio_hasta;
        private System.Windows.Forms.DateTimePicker dtpanio_desde;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtiess;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControl_Detalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Detalle;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Anio;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Mes;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Total_Remuneracion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Total_Vacaciones;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Valor_Cancelar;
    }
}