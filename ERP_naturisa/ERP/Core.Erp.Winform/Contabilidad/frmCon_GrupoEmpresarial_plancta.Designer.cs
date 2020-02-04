namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_GrupoEmpresarial_plancta
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
            this.lbl_id_new = new System.Windows.Forms.Label();
            this.lblctapadre = new System.Windows.Forms.Label();
            this.lblnivelcuenta = new System.Windows.Forms.Label();
            this.chk_movimiento = new System.Windows.Forms.CheckBox();
            this.chk_activo = new System.Windows.Forms.CheckBox();
            this.cmb_grupocbtle = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_naturaleza = new System.Windows.Forms.ComboBox();
            this.txt_cuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlancta = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpc_Cuenta_gr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuenta_gr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucgE_Cuenta1 = new Core.Erp.Winform.Controles.UCGe_Cuenta();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPlancta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id_new
            // 
            this.lbl_id_new.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_id_new.Location = new System.Drawing.Point(328, 62);
            this.lbl_id_new.Name = "lbl_id_new";
            this.lbl_id_new.Size = new System.Drawing.Size(111, 23);
            this.lbl_id_new.TabIndex = 43;
            this.lbl_id_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_id_new.Visible = false;
            // 
            // lblctapadre
            // 
            this.lblctapadre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblctapadre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblctapadre.ForeColor = System.Drawing.Color.Black;
            this.lblctapadre.Location = new System.Drawing.Point(110, 63);
            this.lblctapadre.Name = "lblctapadre";
            this.lblctapadre.Size = new System.Drawing.Size(104, 19);
            this.lblctapadre.TabIndex = 42;
            this.lblctapadre.Text = "  ";
            this.lblctapadre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblnivelcuenta
            // 
            this.lblnivelcuenta.BackColor = System.Drawing.SystemColors.Control;
            this.lblnivelcuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnivelcuenta.Location = new System.Drawing.Point(110, 149);
            this.lblnivelcuenta.Name = "lblnivelcuenta";
            this.lblnivelcuenta.Size = new System.Drawing.Size(124, 23);
            this.lblnivelcuenta.TabIndex = 41;
            this.lblnivelcuenta.Text = "0";
            this.lblnivelcuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_movimiento
            // 
            this.chk_movimiento.AutoSize = true;
            this.chk_movimiento.Location = new System.Drawing.Point(110, 240);
            this.chk_movimiento.Name = "chk_movimiento";
            this.chk_movimiento.Size = new System.Drawing.Size(114, 17);
            this.chk_movimiento.TabIndex = 39;
            this.chk_movimiento.Text = "Cta de Movimiento";
            this.chk_movimiento.UseVisualStyleBackColor = true;
            // 
            // chk_activo
            // 
            this.chk_activo.AutoSize = true;
            this.chk_activo.Location = new System.Drawing.Point(110, 217);
            this.chk_activo.Name = "chk_activo";
            this.chk_activo.Size = new System.Drawing.Size(56, 17);
            this.chk_activo.TabIndex = 38;
            this.chk_activo.Text = "Activo";
            this.chk_activo.UseVisualStyleBackColor = true;
            // 
            // cmb_grupocbtle
            // 
            this.cmb_grupocbtle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_grupocbtle.FormattingEnabled = true;
            this.cmb_grupocbtle.Location = new System.Drawing.Point(110, 182);
            this.cmb_grupocbtle.Name = "cmb_grupocbtle";
            this.cmb_grupocbtle.Size = new System.Drawing.Size(124, 21);
            this.cmb_grupocbtle.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Grupo Contable:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Nivel Cuenta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Naturaleza:";
            // 
            // cmb_naturaleza
            // 
            this.cmb_naturaleza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_naturaleza.FormattingEnabled = true;
            this.cmb_naturaleza.Items.AddRange(new object[] {
            "DEUDOR",
            "ACREEDOR"});
            this.cmb_naturaleza.Location = new System.Drawing.Point(110, 118);
            this.cmb_naturaleza.Name = "cmb_naturaleza";
            this.cmb_naturaleza.Size = new System.Drawing.Size(124, 21);
            this.cmb_naturaleza.TabIndex = 33;
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.Location = new System.Drawing.Point(110, 92);
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.Size = new System.Drawing.Size(542, 20);
            this.txt_cuenta.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nombre Cuenta:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(213, 63);
            this.txt_id.MaxLength = 3;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(96, 20);
            this.txt_id.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Codigo Cuenta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cuenta Padre:";
            // 
            // cmbPlancta
            // 
            this.cmbPlancta.Location = new System.Drawing.Point(110, 37);
            this.cmbPlancta.Name = "cmbPlancta";
            this.cmbPlancta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPlancta.Properties.View = this.searchLookUpEdit1View;
            this.cmbPlancta.Size = new System.Drawing.Size(542, 20);
            this.cmbPlancta.TabIndex = 47;
            this.cmbPlancta.EditValueChanged += new System.EventHandler(this.cmbPlancta_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpc_Cuenta_gr,
            this.colIdCuenta_gr});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colpc_Cuenta_gr
            // 
            this.colpc_Cuenta_gr.Caption = "Cuenta";
            this.colpc_Cuenta_gr.FieldName = "pc_Cuenta_gr";
            this.colpc_Cuenta_gr.Name = "colpc_Cuenta_gr";
            this.colpc_Cuenta_gr.Visible = true;
            this.colpc_Cuenta_gr.VisibleIndex = 0;
            this.colpc_Cuenta_gr.Width = 915;
            // 
            // colIdCuenta_gr
            // 
            this.colIdCuenta_gr.Caption = "ID";
            this.colIdCuenta_gr.FieldName = "IdCuenta_gr";
            this.colIdCuenta_gr.Name = "colIdCuenta_gr";
            this.colIdCuenta_gr.Visible = true;
            this.colIdCuenta_gr.VisibleIndex = 1;
            this.colIdCuenta_gr.Width = 265;
            // 
            // ucgE_Cuenta1
            // 
            this.ucgE_Cuenta1.Location = new System.Drawing.Point(244, 117);
            this.ucgE_Cuenta1.Name = "ucgE_Cuenta1";
            this.ucgE_Cuenta1.Size = new System.Drawing.Size(408, 23);
            this.ucgE_Cuenta1.TabIndex = 40;
            this.ucgE_Cuenta1.Visible = false;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(667, 29);
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
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_event_btnlimpiar_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // frmCon_GrupoEmpresarial_plancta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 284);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.cmbPlancta);
            this.Controls.Add(this.lbl_id_new);
            this.Controls.Add(this.lblctapadre);
            this.Controls.Add(this.lblnivelcuenta);
            this.Controls.Add(this.ucgE_Cuenta1);
            this.Controls.Add(this.chk_movimiento);
            this.Controls.Add(this.chk_activo);
            this.Controls.Add(this.cmb_grupocbtle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_naturaleza);
            this.Controls.Add(this.txt_cuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCon_GrupoEmpresarial_plancta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan de Cuenta del Grupo Empresarial";
            this.Load += new System.EventHandler(this.frmCon_GrupoEmpresarial_plancta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPlancta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id_new;
        private System.Windows.Forms.Label lblctapadre;
        private System.Windows.Forms.Label lblnivelcuenta;
        private Controles.UCGe_Cuenta ucgE_Cuenta1;
        private System.Windows.Forms.CheckBox chk_movimiento;
        private System.Windows.Forms.CheckBox chk_activo;
        private System.Windows.Forms.ComboBox cmb_grupocbtle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_naturaleza;
        private System.Windows.Forms.TextBox txt_cuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbPlancta;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta_gr;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta_gr;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
    }
}