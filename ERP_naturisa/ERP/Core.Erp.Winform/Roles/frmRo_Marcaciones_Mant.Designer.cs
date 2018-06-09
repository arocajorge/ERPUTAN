namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Marcaciones_Mant
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dteFecha = new DevExpress.XtraEditors.DateEdit();
            this.cmbEmpleado = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.roEmpleadoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNomCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtHora = new DevExpress.XtraEditors.TextEdit();
            this.cmbTipoMarcacion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.romarcacionestipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoMarcaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colma_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSecuencia = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new DevExpress.XtraEditors.TextEdit();
            this.LbObsrvacion = new System.Windows.Forms.Label();
            this.Colpe_cedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoMarcacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.romarcacionestipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecuencia.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo marcación:";
            // 
            // dteFecha
            // 
            this.dteFecha.EditValue = null;
            this.dteFecha.Location = new System.Drawing.Point(102, 65);
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteFecha.Size = new System.Drawing.Size(129, 20);
            this.dteFecha.TabIndex = 2;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Location = new System.Drawing.Point(102, 40);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEmpleado.Properties.DataSource = this.roEmpleadoInfoBindingSource;
            this.cmbEmpleado.Properties.DisplayMember = "pe_NomCompleto";
            this.cmbEmpleado.Properties.ValueMember = "IdEmpleado";
            this.cmbEmpleado.Properties.View = this.searchLookUpEdit1View;
            this.cmbEmpleado.Size = new System.Drawing.Size(312, 20);
            this.cmbEmpleado.TabIndex = 1;
            // 
            // roEmpleadoInfoBindingSource
            // 
            this.roEmpleadoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Empleado_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNomCompleto,
            this.colIdEmpleado,
            this.Colpe_cedulaRuc});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colNomCompleto
            // 
            this.colNomCompleto.Caption = "Empleado";
            this.colNomCompleto.FieldName = "pe_NomCompleto";
            this.colNomCompleto.Name = "colNomCompleto";
            this.colNomCompleto.Visible = true;
            this.colNomCompleto.VisibleIndex = 2;
            this.colNomCompleto.Width = 842;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.Caption = "Código";
            this.colIdEmpleado.FieldName = "em_codigo";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 1;
            this.colIdEmpleado.Width = 160;
            // 
            // txtHora
            // 
            this.txtHora.EditValue = "00:00";
            this.txtHora.Location = new System.Drawing.Point(102, 90);
            this.txtHora.Name = "txtHora";
            this.txtHora.Properties.Mask.EditMask = "t";
            this.txtHora.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtHora.Size = new System.Drawing.Size(129, 20);
            this.txtHora.TabIndex = 3;
            this.txtHora.EditValueChanged += new System.EventHandler(this.txtHora_EditValueChanged);
            // 
            // cmbTipoMarcacion
            // 
            this.cmbTipoMarcacion.Location = new System.Drawing.Point(102, 114);
            this.cmbTipoMarcacion.Name = "cmbTipoMarcacion";
            this.cmbTipoMarcacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoMarcacion.Properties.DataSource = this.romarcacionestipoInfoBindingSource;
            this.cmbTipoMarcacion.Properties.DisplayMember = "ma_descripcion";
            this.cmbTipoMarcacion.Properties.ValueMember = "IdTipoMarcaciones";
            this.cmbTipoMarcacion.Properties.View = this.searchLookUpEdit2View;
            this.cmbTipoMarcacion.Size = new System.Drawing.Size(129, 20);
            this.cmbTipoMarcacion.TabIndex = 4;
            // 
            // romarcacionestipoInfoBindingSource
            // 
            this.romarcacionestipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_marcaciones_tipo_Info);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoMarcaciones,
            this.colma_descripcion});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTipoMarcaciones
            // 
            this.colIdTipoMarcaciones.Caption = "Código";
            this.colIdTipoMarcaciones.FieldName = "IdTipoMarcaciones";
            this.colIdTipoMarcaciones.Name = "colIdTipoMarcaciones";
            this.colIdTipoMarcaciones.Visible = true;
            this.colIdTipoMarcaciones.VisibleIndex = 1;
            this.colIdTipoMarcaciones.Width = 357;
            // 
            // colma_descripcion
            // 
            this.colma_descripcion.Caption = "Descripción";
            this.colma_descripcion.FieldName = "ma_descripcion";
            this.colma_descripcion.Name = "colma_descripcion";
            this.colma_descripcion.Visible = true;
            this.colma_descripcion.VisibleIndex = 0;
            this.colma_descripcion.Width = 817;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Secuencia:";
            // 
            // txtSecuencia
            // 
            this.txtSecuencia.Location = new System.Drawing.Point(102, 15);
            this.txtSecuencia.Name = "txtSecuencia";
            this.txtSecuencia.Size = new System.Drawing.Size(129, 20);
            this.txtSecuencia.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.LbObsrvacion);
            this.groupBox1.Controls.Add(this.txtSecuencia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbTipoMarcacion);
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.cmbEmpleado);
            this.groupBox1.Controls.Add(this.dteFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 174);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(108, 142);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(312, 20);
            this.txtObservacion.TabIndex = 14;
            // 
            // LbObsrvacion
            // 
            this.LbObsrvacion.AutoSize = true;
            this.LbObsrvacion.Location = new System.Drawing.Point(12, 143);
            this.LbObsrvacion.Name = "LbObsrvacion";
            this.LbObsrvacion.Size = new System.Drawing.Size(67, 13);
            this.LbObsrvacion.TabIndex = 13;
            this.LbObsrvacion.Text = "Observacion";
            // 
            // Colpe_cedulaRuc
            // 
            this.Colpe_cedulaRuc.Caption = "Cedula";
            this.Colpe_cedulaRuc.FieldName = "InfoPersona.pe_cedulaRuc";
            this.Colpe_cedulaRuc.Name = "Colpe_cedulaRuc";
            this.Colpe_cedulaRuc.Visible = true;
            this.Colpe_cedulaRuc.VisibleIndex = 0;
            this.Colpe_cedulaRuc.Width = 137;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(426, 29);
            this.ucGe_Menu.TabIndex = 11;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // frmRo_Marcaciones_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 203);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucGe_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRo_Marcaciones_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento - Marcaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRo_Marcaciones_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmRo_Marcaciones_Mant_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_Marcaciones_Mant_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoMarcacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.romarcacionestipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecuencia.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DateEdit dteFecha;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEmpleado;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtHora;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipoMarcacion;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private System.Windows.Forms.BindingSource roEmpleadoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNomCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private System.Windows.Forms.BindingSource romarcacionestipoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMarcaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colma_descripcion;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtSecuencia;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbObsrvacion;
        private DevExpress.XtraEditors.TextEdit txtObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn Colpe_cedulaRuc;
    }
}