namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Equipos_Mantenimiento
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
            this.components = new System.ComponentModel.Container();
            this.romarcacionesxempleadoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlMarcacionesEquipo = new DevExpress.XtraGrid.GridControl();
            this.romarcacionesEquipoxTipoMarcacionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewEquipoMarcaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoMarcaciones_sys = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoMarcaciones_Biometrico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEquipoMar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwRomarcacionesEquipoxTipoMarcacionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreEquipo = new DevExpress.XtraEditors.TextEdit();
            this.txtModeloEquipo = new DevExpress.XtraEditors.TextEdit();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.cBoxEstado = new DevExpress.XtraEditors.CheckEdit();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.cmb_formato_hora = new System.Windows.Forms.ComboBox();
            this.cmb_formato_fecha = new System.Windows.Forms.ComboBox();
            this.cmb_tipo_base = new System.Windows.Forms.ComboBox();
            this.dateTimeFechaUltProceso = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_probar_conexion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cadena_conexion = new DevExpress.XtraEditors.ButtonEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            ((System.ComponentModel.ISupportInitialize)(this.romarcacionesxempleadoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMarcacionesEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.romarcacionesEquipoxTipoMarcacionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEquipoMarcaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRomarcacionesEquipoxTipoMarcacionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEquipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModeloEquipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBoxEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cadena_conexion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // romarcacionesxempleadoInfoBindingSource
            // 
            this.romarcacionesxempleadoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_marcaciones_x_empleado_Info);
            // 
            // gridControlMarcacionesEquipo
            // 
            this.gridControlMarcacionesEquipo.DataSource = this.romarcacionesEquipoxTipoMarcacionInfoBindingSource;
            this.gridControlMarcacionesEquipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMarcacionesEquipo.Location = new System.Drawing.Point(2, 21);
            this.gridControlMarcacionesEquipo.MainView = this.gridViewEquipoMarcaciones;
            this.gridControlMarcacionesEquipo.Name = "gridControlMarcacionesEquipo";
            this.gridControlMarcacionesEquipo.Size = new System.Drawing.Size(681, 115);
            this.gridControlMarcacionesEquipo.TabIndex = 46;
            this.gridControlMarcacionesEquipo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEquipoMarcaciones});
            // 
            // romarcacionesEquipoxTipoMarcacionInfoBindingSource
            // 
            this.romarcacionesEquipoxTipoMarcacionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_marcaciones_Equipo_x_TipoMarcacion_Info);
            // 
            // gridViewEquipoMarcaciones
            // 
            this.gridViewEquipoMarcaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoMarcaciones_sys,
            this.colIdTipoMarcaciones_Biometrico,
            this.colIdEquipoMar});
            this.gridViewEquipoMarcaciones.GridControl = this.gridControlMarcacionesEquipo;
            this.gridViewEquipoMarcaciones.Name = "gridViewEquipoMarcaciones";
            // 
            // colIdTipoMarcaciones_sys
            // 
            this.colIdTipoMarcaciones_sys.FieldName = "IdTipoMarcaciones_sys";
            this.colIdTipoMarcaciones_sys.Name = "colIdTipoMarcaciones_sys";
            this.colIdTipoMarcaciones_sys.OptionsColumn.AllowEdit = false;
            this.colIdTipoMarcaciones_sys.Visible = true;
            this.colIdTipoMarcaciones_sys.VisibleIndex = 0;
            // 
            // colIdTipoMarcaciones_Biometrico
            // 
            this.colIdTipoMarcaciones_Biometrico.FieldName = "IdTipoMarcaciones_Biometrico";
            this.colIdTipoMarcaciones_Biometrico.Name = "colIdTipoMarcaciones_Biometrico";
            this.colIdTipoMarcaciones_Biometrico.Visible = true;
            this.colIdTipoMarcaciones_Biometrico.VisibleIndex = 1;
            // 
            // colIdEquipoMar
            // 
            this.colIdEquipoMar.FieldName = "IdEquipoMar";
            this.colIdEquipoMar.Name = "colIdEquipoMar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Equipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Modelo de Equipo:";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.EditValue = "";
            this.txtNombreEquipo.Location = new System.Drawing.Point(127, 47);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(550, 20);
            this.txtNombreEquipo.TabIndex = 7;
            // 
            // txtModeloEquipo
            // 
            this.txtModeloEquipo.Location = new System.Drawing.Point(127, 68);
            this.txtModeloEquipo.Name = "txtModeloEquipo";
            this.txtModeloEquipo.Size = new System.Drawing.Size(218, 20);
            this.txtModeloEquipo.TabIndex = 9;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = false;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(689, 29);
            this.ucGe_Menu.TabIndex = 48;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(127, 23);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(57, 20);
            this.txtid.TabIndex = 133;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(21, 27);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(43, 13);
            this.lblid.TabIndex = 132;
            this.lblid.Text = "Código:";
            // 
            // cBoxEstado
            // 
            this.cBoxEstado.Location = new System.Drawing.Point(602, 24);
            this.cBoxEstado.Name = "cBoxEstado";
            this.cBoxEstado.Properties.Caption = "Activo";
            this.cBoxEstado.Size = new System.Drawing.Size(75, 19);
            this.cBoxEstado.TabIndex = 135;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.ForeColor = System.Drawing.Color.Red;
            this.lbl_Estado.Location = new System.Drawing.Point(2, 2);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(685, 25);
            this.lbl_Estado.TabIndex = 134;
            this.lbl_Estado.Text = "***Anulado***";
            this.lbl_Estado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Estado.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbl_Estado);
            this.panelControl1.Controls.Add(this.cBoxEstado);
            this.panelControl1.Controls.Add(this.txtid);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.lblid);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txtModeloEquipo);
            this.panelControl1.Controls.Add(this.txtNombreEquipo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(689, 111);
            this.panelControl1.TabIndex = 135;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 140);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(689, 355);
            this.groupControl1.TabIndex = 136;
            this.groupControl1.Text = "Datos de Biometrico";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.cmb_formato_hora);
            this.groupControl3.Controls.Add(this.cmb_formato_fecha);
            this.groupControl3.Controls.Add(this.cmb_tipo_base);
            this.groupControl3.Controls.Add(this.dateTimeFechaUltProceso);
            this.groupControl3.Controls.Add(this.label8);
            this.groupControl3.Controls.Add(this.txtTabla);
            this.groupControl3.Controls.Add(this.label5);
            this.groupControl3.Controls.Add(this.btn_probar_conexion);
            this.groupControl3.Controls.Add(this.label7);
            this.groupControl3.Controls.Add(this.label6);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.txt_cadena_conexion);
            this.groupControl3.Controls.Add(this.label2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(2, 159);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(685, 194);
            this.groupControl3.TabIndex = 48;
            this.groupControl3.Text = "Datos de Conexion con Biometrico";
            // 
            // cmb_formato_hora
            // 
            this.cmb_formato_hora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_formato_hora.FormattingEnabled = true;
            this.cmb_formato_hora.Items.AddRange(new object[] {
            "HH:mm:ss"});
            this.cmb_formato_hora.Location = new System.Drawing.Point(526, 89);
            this.cmb_formato_hora.Name = "cmb_formato_hora";
            this.cmb_formato_hora.Size = new System.Drawing.Size(149, 21);
            this.cmb_formato_hora.TabIndex = 42;
            // 
            // cmb_formato_fecha
            // 
            this.cmb_formato_fecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_formato_fecha.FormattingEnabled = true;
            this.cmb_formato_fecha.Items.AddRange(new object[] {
            "dd/MM/yyyy",
            "dd-MM-yyyy",
            "yyyy/MM/dd",
            "yyyy-dd-MM",
            "yyyy-MM-dd",
            "MM/dd/yyyy",
            "MM-dd-yyyy"});
            this.cmb_formato_fecha.Location = new System.Drawing.Point(526, 62);
            this.cmb_formato_fecha.Name = "cmb_formato_fecha";
            this.cmb_formato_fecha.Size = new System.Drawing.Size(149, 21);
            this.cmb_formato_fecha.TabIndex = 41;
            // 
            // cmb_tipo_base
            // 
            this.cmb_tipo_base.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_base.FormattingEnabled = true;
            this.cmb_tipo_base.Items.AddRange(new object[] {
            "Sql",
            "Oracle",
            "Access",
            "My Sql"});
            this.cmb_tipo_base.Location = new System.Drawing.Point(125, 99);
            this.cmb_tipo_base.Name = "cmb_tipo_base";
            this.cmb_tipo_base.Size = new System.Drawing.Size(225, 21);
            this.cmb_tipo_base.TabIndex = 40;
            // 
            // dateTimeFechaUltProceso
            // 
            this.dateTimeFechaUltProceso.Location = new System.Drawing.Point(247, 131);
            this.dateTimeFechaUltProceso.Name = "dateTimeFechaUltProceso";
            this.dateTimeFechaUltProceso.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaUltProceso.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ultima fecha que se descargo las Marcaciones:";
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(125, 65);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(225, 20);
            this.txtTabla.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tabla/Vista:";
            // 
            // btn_probar_conexion
            // 
            this.btn_probar_conexion.Location = new System.Drawing.Point(560, 111);
            this.btn_probar_conexion.Name = "btn_probar_conexion";
            this.btn_probar_conexion.Size = new System.Drawing.Size(115, 29);
            this.btn_probar_conexion.TabIndex = 8;
            this.btn_probar_conexion.Text = "Probar Conexion";
            this.btn_probar_conexion.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Formato de Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Formato de Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Base:";
            // 
            // txt_cadena_conexion
            // 
            this.txt_cadena_conexion.Location = new System.Drawing.Point(125, 31);
            this.txt_cadena_conexion.Name = "txt_cadena_conexion";
            this.txt_cadena_conexion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_cadena_conexion.Size = new System.Drawing.Size(550, 20);
            this.txt_cadena_conexion.TabIndex = 1;
            this.txt_cadena_conexion.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txt_cadena_conexion_ButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cadena de Conexion:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlMarcacionesEquipo);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(2, 21);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(685, 138);
            this.groupControl2.TabIndex = 47;
            this.groupControl2.Text = "Relacion Codigo de Entrada y Salida Vs Codigos del Biometrico";
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 469);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(689, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 137;
            // 
            // frmRo_Equipos_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 495);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRo_Equipos_Mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento - Roles Equipos de Marcaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRo_Marcaciones_Equipos_Mantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.frmRo_Equipos_Mantenimiento_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_Equipos_Mantenimiento_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.romarcacionesxempleadoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMarcacionesEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.romarcacionesEquipoxTipoMarcacionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEquipoMarcaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRomarcacionesEquipoxTipoMarcacionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEquipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModeloEquipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBoxEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cadena_conexion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource romarcacionesxempleadoInfoBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlMarcacionesEquipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEquipoMarcaciones;
        private System.Windows.Forms.BindingSource vwRomarcacionesEquipoxTipoMarcacionInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMarcaciones_sys;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMarcaciones_Biometrico;
        private System.Windows.Forms.BindingSource romarcacionesEquipoxTipoMarcacionInfoBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtNombreEquipo;
        private DevExpress.XtraEditors.TextEdit txtModeloEquipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEquipoMar;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbl_Estado;
        private DevExpress.XtraEditors.CheckEdit cBoxEstado;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.ButtonEdit txt_cadena_conexion;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_probar_conexion;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeFechaUltProceso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_formato_hora;
        private System.Windows.Forms.ComboBox cmb_formato_fecha;
        private System.Windows.Forms.ComboBox cmb_tipo_base;
    }
}