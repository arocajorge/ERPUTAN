namespace Core.Erp.Winform.Roles
{
    partial class frmRo_GeneracionRDEP_Mant
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRutaERDP = new DevExpress.XtraEditors.ButtonEdit();
            this.LbRuraRDEP = new DevExpress.XtraEditors.LabelControl();
            this.cmdCargarEmpleado = new System.Windows.Forms.Button();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridDetalle = new DevExpress.XtraGrid.GridControl();
            this.viewDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTot_Sueldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColtotDecimoCuarto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColinfoDecimoTercer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColinfototFondoReserva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColtotUtilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColinfoComision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColinfototIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColinfototHoraExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColinfototSueldoDigno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColinfototGastoVivienda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColinfototGastoVestimenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColinfototGastoSalud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColinfototGastoEducacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColinfototGastoAlimentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaERDP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDetalle)).BeginInit();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1285, 29);
            this.ucGe_Menu.TabIndex = 0;
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
            this.ucGe_Menu.Visible_btn_Generar_XML = true;
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
            this.ucGe_Menu.event_btn_Generar_XML_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btn_Generar_XML_Click(this.ucGe_Menu_event_btn_Generar_XML_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRutaERDP);
            this.groupBox1.Controls.Add(this.LbRuraRDEP);
            this.groupBox1.Controls.Add(this.cmdCargarEmpleado);
            this.groupBox1.Controls.Add(this.cmbPeriodo);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1285, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtRutaERDP
            // 
            this.txtRutaERDP.EditValue = "";
            this.txtRutaERDP.Location = new System.Drawing.Point(194, 35);
            this.txtRutaERDP.Name = "txtRutaERDP";
            this.txtRutaERDP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtRutaERDP.Size = new System.Drawing.Size(615, 20);
            this.txtRutaERDP.TabIndex = 21;
            this.txtRutaERDP.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TxtRutaLocal_ButtonClick);
            // 
            // LbRuraRDEP
            // 
            this.LbRuraRDEP.Location = new System.Drawing.Point(6, 38);
            this.LbRuraRDEP.Name = "LbRuraRDEP";
            this.LbRuraRDEP.Size = new System.Drawing.Size(181, 13);
            this.LbRuraRDEP.TabIndex = 12;
            this.LbRuraRDEP.Text = "Ubicacion Donde se Guardara el RDEP";
            // 
            // cmdCargarEmpleado
            // 
            this.cmdCargarEmpleado.Location = new System.Drawing.Point(1164, 11);
            this.cmdCargarEmpleado.Name = "cmdCargarEmpleado";
            this.cmdCargarEmpleado.Size = new System.Drawing.Size(109, 23);
            this.cmdCargarEmpleado.TabIndex = 10;
            this.cmdCargarEmpleado.Text = "&Cargar Empleados";
            this.cmdCargarEmpleado.UseVisualStyleBackColor = true;
            this.cmdCargarEmpleado.Click += new System.EventHandler(this.cmdCargarEmpleado_Click);
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(194, 6);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(100, 21);
            this.cmbPeriodo.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Período:";
            // 
            // gridDetalle
            // 
            this.gridDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDetalle.Location = new System.Drawing.Point(0, 98);
            this.gridDetalle.MainView = this.viewDetalle;
            this.gridDetalle.Name = "gridDetalle";
            this.gridDetalle.Size = new System.Drawing.Size(1285, 373);
            this.gridDetalle.TabIndex = 2;
            this.gridDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDetalle});
            // 
            // viewDetalle
            // 
            this.viewDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColNombre,
            this.ColTot_Sueldo,
            this.ColtotDecimoCuarto,
            this.ColinfoDecimoTercer,
            this.ColinfototFondoReserva,
            this.ColtotUtilidad,
            this.ColinfoComision,
            this.ColinfototIngreso,
            this.ColinfototHoraExtra,
            this.ColinfototSueldoDigno,
            this.ColinfototGastoVivienda,
            this.ColinfototGastoVestimenta,
            this.ColinfototGastoSalud,
            this.ColinfototGastoEducacion,
            this.ColinfototGastoAlimentacion});
            this.viewDetalle.GridControl = this.gridDetalle;
            this.viewDetalle.Name = "viewDetalle";
            this.viewDetalle.OptionsView.ShowGroupPanel = false;
            this.viewDetalle.OptionsView.ShowIndicator = false;
            // 
            // ColNombre
            // 
            this.ColNombre.Caption = "Nombres";
            this.ColNombre.FieldName = "InfoPersona.pe_nombreCompleto";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.Visible = true;
            this.ColNombre.VisibleIndex = 0;
            // 
            // ColTot_Sueldo
            // 
            this.ColTot_Sueldo.Caption = "Tot. Sueldo";
            this.ColTot_Sueldo.FieldName = "totSueldo";
            this.ColTot_Sueldo.Name = "ColTot_Sueldo";
            this.ColTot_Sueldo.Visible = true;
            this.ColTot_Sueldo.VisibleIndex = 1;
            // 
            // ColtotDecimoCuarto
            // 
            this.ColtotDecimoCuarto.Caption = "Tot Dmo 4to";
            this.ColtotDecimoCuarto.FieldName = " totDecimoCuarto";
            this.ColtotDecimoCuarto.Name = "ColtotDecimoCuarto";
            this.ColtotDecimoCuarto.Visible = true;
            this.ColtotDecimoCuarto.VisibleIndex = 2;
            // 
            // ColinfoDecimoTercer
            // 
            this.ColinfoDecimoTercer.Caption = "Decimo Tercer Sueldo";
            this.ColinfoDecimoTercer.FieldName = "totDecimoTercer";
            this.ColinfoDecimoTercer.Name = "ColinfoDecimoTercer";
            this.ColinfoDecimoTercer.Visible = true;
            this.ColinfoDecimoTercer.VisibleIndex = 3;
            // 
            // ColinfototFondoReserva
            // 
            this.ColinfototFondoReserva.Caption = "Fondos de Reserva";
            this.ColinfototFondoReserva.FieldName = "totFondoReserva";
            this.ColinfototFondoReserva.Name = "ColinfototFondoReserva";
            this.ColinfototFondoReserva.Visible = true;
            this.ColinfototFondoReserva.VisibleIndex = 4;
            // 
            // ColtotUtilidad
            // 
            this.ColtotUtilidad.Caption = "Utilidades";
            this.ColtotUtilidad.FieldName = "totUtilidad";
            this.ColtotUtilidad.Name = "ColtotUtilidad";
            this.ColtotUtilidad.Visible = true;
            this.ColtotUtilidad.VisibleIndex = 5;
            // 
            // ColinfoComision
            // 
            this.ColinfoComision.Caption = "Comisiones";
            this.ColinfoComision.FieldName = "totComision";
            this.ColinfoComision.Name = "ColinfoComision";
            this.ColinfoComision.Visible = true;
            this.ColinfoComision.VisibleIndex = 6;
            // 
            // ColinfototIngreso
            // 
            this.ColinfototIngreso.Caption = "Tot. Ingreso";
            this.ColinfototIngreso.FieldName = "totIngreso";
            this.ColinfototIngreso.Name = "ColinfototIngreso";
            this.ColinfototIngreso.Visible = true;
            this.ColinfototIngreso.VisibleIndex = 8;
            // 
            // ColinfototHoraExtra
            // 
            this.ColinfototHoraExtra.Caption = "H. Extra";
            this.ColinfototHoraExtra.FieldName = "totHoraExtra";
            this.ColinfototHoraExtra.Name = "ColinfototHoraExtra";
            this.ColinfototHoraExtra.Visible = true;
            this.ColinfototHoraExtra.VisibleIndex = 7;
            // 
            // ColinfototSueldoDigno
            // 
            this.ColinfototSueldoDigno.Caption = "Sueldo Digno";
            this.ColinfototSueldoDigno.FieldName = "totSueldoDigno";
            this.ColinfototSueldoDigno.Name = "ColinfototSueldoDigno";
            this.ColinfototSueldoDigno.Visible = true;
            this.ColinfototSueldoDigno.VisibleIndex = 9;
            // 
            // ColinfototGastoVivienda
            // 
            this.ColinfototGastoVivienda.Caption = "G. Vivienda";
            this.ColinfototGastoVivienda.FieldName = "totGastoVivienda";
            this.ColinfototGastoVivienda.Name = "ColinfototGastoVivienda";
            this.ColinfototGastoVivienda.Visible = true;
            this.ColinfototGastoVivienda.VisibleIndex = 10;
            // 
            // ColinfototGastoVestimenta
            // 
            this.ColinfototGastoVestimenta.Caption = "G. Vestimenta";
            this.ColinfototGastoVestimenta.FieldName = "totGastoVivienda";
            this.ColinfototGastoVestimenta.Name = "ColinfototGastoVestimenta";
            this.ColinfototGastoVestimenta.Visible = true;
            this.ColinfototGastoVestimenta.VisibleIndex = 11;
            // 
            // ColinfototGastoSalud
            // 
            this.ColinfototGastoSalud.Caption = "G. Salud";
            this.ColinfototGastoSalud.FieldName = "totGastoSalud";
            this.ColinfototGastoSalud.Name = "ColinfototGastoSalud";
            this.ColinfototGastoSalud.Visible = true;
            this.ColinfototGastoSalud.VisibleIndex = 12;
            // 
            // ColinfototGastoEducacion
            // 
            this.ColinfototGastoEducacion.Caption = "G. Educacion";
            this.ColinfototGastoEducacion.FieldName = "totGastoEducacion";
            this.ColinfototGastoEducacion.Name = "ColinfototGastoEducacion";
            this.ColinfototGastoEducacion.Visible = true;
            this.ColinfototGastoEducacion.VisibleIndex = 13;
            // 
            // ColinfototGastoAlimentacion
            // 
            this.ColinfototGastoAlimentacion.Caption = "G. Alimentacion";
            this.ColinfototGastoAlimentacion.FieldName = "totGastoAlimentacion";
            this.ColinfototGastoAlimentacion.Name = "ColinfototGastoAlimentacion";
            this.ColinfototGastoAlimentacion.Visible = true;
            this.ColinfototGastoAlimentacion.VisibleIndex = 14;
            // 
            // frmRo_GeneracionRDEP_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 471);
            this.Controls.Add(this.gridDetalle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_GeneracionRDEP_Mant";
            this.Text = "Generación - Anexo de Retenciones en la fuente por relación de dependencia (RDEP)" +
    "";
            this.Load += new System.EventHandler(this.frmRo_GeneracionRDEP_Mant_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaERDP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDetalle;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button cmdCargarEmpleado;
        private DevExpress.XtraEditors.LabelControl LbRuraRDEP;
        private DevExpress.XtraEditors.ButtonEdit txtRutaERDP;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombre;
        private DevExpress.XtraGrid.Columns.GridColumn ColTot_Sueldo;
        private DevExpress.XtraGrid.Columns.GridColumn ColtotDecimoCuarto;
        private DevExpress.XtraGrid.Columns.GridColumn ColinfoDecimoTercer;
        private DevExpress.XtraGrid.Columns.GridColumn ColinfototFondoReserva;
        private DevExpress.XtraGrid.Columns.GridColumn ColtotUtilidad;
        private DevExpress.XtraGrid.Columns.GridColumn ColinfoComision;
        private DevExpress.XtraGrid.Columns.GridColumn ColinfototIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn ColinfototHoraExtra;
        private DevExpress.XtraGrid.Columns.GridColumn ColinfototSueldoDigno;
        private DevExpress.XtraGrid.Columns.GridColumn ColinfototGastoVivienda;
        private DevExpress.XtraGrid.Columns.GridColumn ColinfototGastoVestimenta;
        private DevExpress.XtraGrid.Columns.GridColumn ColinfototGastoSalud;
        private DevExpress.XtraGrid.Columns.GridColumn ColinfototGastoEducacion;
        private DevExpress.XtraGrid.Columns.GridColumn ColinfototGastoAlimentacion;
    }
}