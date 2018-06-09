namespace Core.Erp.Winform.SeguridadAcceso
{
    partial class FrmSeg_Menu_Mant
    {

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.uC_Menu_Mantenimientos1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.treeListMenuPadre = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxTienePadre = new System.Windows.Forms.CheckBox();
            this.checkBoxTieneFormulario = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.numericUpDownPosicion = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdMenu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreAsembly = new System.Windows.Forms.TextBox();
            this.txtNombreFormulario = new System.Windows.Forms.TextBox();
            this.lblNombreAsembly = new System.Windows.Forms.Label();
            this.lblNombreFormulario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenuPadre)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosicion)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uC_Menu_Mantenimientos1
            // 
            this.uC_Menu_Mantenimientos1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_Menu_Mantenimientos1.Enabled_bnRetImprimir = true;
            this.uC_Menu_Mantenimientos1.Enabled_bntAnular = true;
            this.uC_Menu_Mantenimientos1.Enabled_bntAprobar = true;
            this.uC_Menu_Mantenimientos1.Enabled_bntGuardar_y_Salir = true;
            this.uC_Menu_Mantenimientos1.Enabled_bntImprimir = true;
            this.uC_Menu_Mantenimientos1.Enabled_bntImprimir_Guia = true;
            this.uC_Menu_Mantenimientos1.Enabled_bntLimpiar = true;
            this.uC_Menu_Mantenimientos1.Enabled_bntSalir = true;
            this.uC_Menu_Mantenimientos1.Enabled_btn_conciliacion_Auto = true;
            this.uC_Menu_Mantenimientos1.Enabled_btn_DiseñoReporte = true;
            this.uC_Menu_Mantenimientos1.Enabled_btn_Generar_XML = true;
            this.uC_Menu_Mantenimientos1.Enabled_btn_Imprimir_Cbte = true;
            this.uC_Menu_Mantenimientos1.Enabled_btn_Imprimir_Cheq = true;
            this.uC_Menu_Mantenimientos1.Enabled_btn_Imprimir_Reten = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnAceptar = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnAprobarGuardarSalir = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnEstadosOC = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnGuardar = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnImpFrm = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnImpLote = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnImpRep = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnImprimirSoporte = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnproductos = true;
            this.uC_Menu_Mantenimientos1.Location = new System.Drawing.Point(0, 0);
            this.uC_Menu_Mantenimientos1.Name = "uC_Menu_Mantenimientos1";
            this.uC_Menu_Mantenimientos1.Size = new System.Drawing.Size(735, 29);
            this.uC_Menu_Mantenimientos1.TabIndex = 0;
            this.uC_Menu_Mantenimientos1.Visible_bntAnular = true;
            this.uC_Menu_Mantenimientos1.Visible_bntAprobar = false;
            this.uC_Menu_Mantenimientos1.Visible_bntDiseñoReporte = false;
            this.uC_Menu_Mantenimientos1.Visible_bntGuardar_y_Salir = true;
            this.uC_Menu_Mantenimientos1.Visible_bntImprimir = false;
            this.uC_Menu_Mantenimientos1.Visible_bntImprimir_Guia = false;
            this.uC_Menu_Mantenimientos1.Visible_bntLimpiar = false;
            this.uC_Menu_Mantenimientos1.Visible_bntReImprimir = false;
            this.uC_Menu_Mantenimientos1.Visible_bntSalir = true;
            this.uC_Menu_Mantenimientos1.Visible_btn_conciliacion_Auto = false;
            this.uC_Menu_Mantenimientos1.Visible_btn_Generar_XML = false;
            this.uC_Menu_Mantenimientos1.Visible_btn_Imprimir_Cbte = false;
            this.uC_Menu_Mantenimientos1.Visible_btn_Imprimir_Cheq = false;
            this.uC_Menu_Mantenimientos1.Visible_btn_Imprimir_Reten = false;
            this.uC_Menu_Mantenimientos1.Visible_btnAceptar = false;
            this.uC_Menu_Mantenimientos1.Visible_btnAprobarGuardarSalir = false;
            this.uC_Menu_Mantenimientos1.Visible_btnEstadosOC = false;
            this.uC_Menu_Mantenimientos1.Visible_btnGuardar = true;
            this.uC_Menu_Mantenimientos1.Visible_btnImpFrm = false;
            this.uC_Menu_Mantenimientos1.Visible_btnImpLote = false;
            this.uC_Menu_Mantenimientos1.Visible_btnImpRep = false;
            this.uC_Menu_Mantenimientos1.Visible_btnImprimirSoporte = false;
            this.uC_Menu_Mantenimientos1.Visible_btnproductos = false;
            this.uC_Menu_Mantenimientos1.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.uC_Menu_Mantenimientos1_event_btnGuardar_Click);
            this.uC_Menu_Mantenimientos1.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.uC_Menu_Mantenimientos1_event_btnGuardar_y_Salir_Click);
            this.uC_Menu_Mantenimientos1.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.uC_Menu_Mantenimientos1_event_btnAnular_Click);
            this.uC_Menu_Mantenimientos1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.uC_Menu_Mantenimientos1_event_btnSalir_Click);
            // 
            // treeListMenuPadre
            // 
            this.treeListMenuPadre.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeListMenuPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMenuPadre.KeyFieldName = "IdMenu";
            this.treeListMenuPadre.Location = new System.Drawing.Point(3, 16);
            this.treeListMenuPadre.Name = "treeListMenuPadre";
            this.treeListMenuPadre.OptionsBehavior.Editable = false;
            this.treeListMenuPadre.OptionsBehavior.EnableFiltering = true;
            this.treeListMenuPadre.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treeListMenuPadre.OptionsPrint.UsePrintStyles = true;
            this.treeListMenuPadre.OptionsView.ShowAutoFilterRow = true;
            this.treeListMenuPadre.OptionsView.ShowCheckBoxes = true;
            this.treeListMenuPadre.OptionsView.ShowSummaryFooter = true;
            this.treeListMenuPadre.ParentFieldName = "IdMenuPadre";
            this.treeListMenuPadre.Size = new System.Drawing.Size(410, 276);
            this.treeListMenuPadre.TabIndex = 1;
            this.treeListMenuPadre.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.treeListMenuPadre_BeforeCheckNode);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Descripcion";
            this.treeListColumn1.FieldName = "DescripcionMenu";
            this.treeListColumn1.MinWidth = 32;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 232;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Id";
            this.treeListColumn2.FieldName = "IdMenu";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 57;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeListMenuPadre);
            this.groupBox1.Location = new System.Drawing.Point(317, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 295);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el menu padre de este menu";
            // 
            // checkBoxTienePadre
            // 
            this.checkBoxTienePadre.AutoSize = true;
            this.checkBoxTienePadre.Checked = true;
            this.checkBoxTienePadre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTienePadre.Location = new System.Drawing.Point(9, 145);
            this.checkBoxTienePadre.Name = "checkBoxTienePadre";
            this.checkBoxTienePadre.Size = new System.Drawing.Size(110, 17);
            this.checkBoxTienePadre.TabIndex = 3;
            this.checkBoxTienePadre.Text = "Tiene nodo padre";
            this.checkBoxTienePadre.UseVisualStyleBackColor = true;
            this.checkBoxTienePadre.CheckedChanged += new System.EventHandler(this.checkBoxTienePadre_CheckedChanged);
            // 
            // checkBoxTieneFormulario
            // 
            this.checkBoxTieneFormulario.AutoSize = true;
            this.checkBoxTieneFormulario.Location = new System.Drawing.Point(9, 178);
            this.checkBoxTieneFormulario.Name = "checkBoxTieneFormulario";
            this.checkBoxTieneFormulario.Size = new System.Drawing.Size(147, 17);
            this.checkBoxTieneFormulario.TabIndex = 4;
            this.checkBoxTieneFormulario.Text = "Tiene formulario asociado";
            this.checkBoxTieneFormulario.UseVisualStyleBackColor = true;
            this.checkBoxTieneFormulario.CheckedChanged += new System.EventHandler(this.checkBoxTieneFormulario_CheckedChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(85, 67);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(220, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // numericUpDownPosicion
            // 
            this.numericUpDownPosicion.Location = new System.Drawing.Point(85, 110);
            this.numericUpDownPosicion.Name = "numericUpDownPosicion";
            this.numericUpDownPosicion.Size = new System.Drawing.Size(84, 20);
            this.numericUpDownPosicion.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdMenu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNombreAsembly);
            this.groupBox2.Controls.Add(this.txtNombreFormulario);
            this.groupBox2.Controls.Add(this.lblNombreAsembly);
            this.groupBox2.Controls.Add(this.lblNombreFormulario);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.numericUpDownPosicion);
            this.groupBox2.Controls.Add(this.checkBoxTieneFormulario);
            this.groupBox2.Controls.Add(this.checkBoxTienePadre);
            this.groupBox2.Location = new System.Drawing.Point(1, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 295);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del menu";
            // 
            // txtIdMenu
            // 
            this.txtIdMenu.Enabled = false;
            this.txtIdMenu.Location = new System.Drawing.Point(85, 33);
            this.txtIdMenu.Name = "txtIdMenu";
            this.txtIdMenu.Size = new System.Drawing.Size(103, 20);
            this.txtIdMenu.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Codigo";
            // 
            // txtNombreAsembly
            // 
            this.txtNombreAsembly.Location = new System.Drawing.Point(136, 260);
            this.txtNombreAsembly.Name = "txtNombreAsembly";
            this.txtNombreAsembly.Size = new System.Drawing.Size(169, 20);
            this.txtNombreAsembly.TabIndex = 12;
            this.txtNombreAsembly.Visible = false;
            // 
            // txtNombreFormulario
            // 
            this.txtNombreFormulario.Location = new System.Drawing.Point(136, 216);
            this.txtNombreFormulario.Name = "txtNombreFormulario";
            this.txtNombreFormulario.Size = new System.Drawing.Size(169, 20);
            this.txtNombreFormulario.TabIndex = 11;
            this.txtNombreFormulario.Visible = false;
            // 
            // lblNombreAsembly
            // 
            this.lblNombreAsembly.AutoSize = true;
            this.lblNombreAsembly.Location = new System.Drawing.Point(6, 263);
            this.lblNombreAsembly.Name = "lblNombreAsembly";
            this.lblNombreAsembly.Size = new System.Drawing.Size(124, 13);
            this.lblNombreAsembly.TabIndex = 8;
            this.lblNombreAsembly.Text = "Nombre del Emsamblado";
            this.lblNombreAsembly.Visible = false;
            // 
            // lblNombreFormulario
            // 
            this.lblNombreFormulario.AutoSize = true;
            this.lblNombreFormulario.Location = new System.Drawing.Point(6, 219);
            this.lblNombreFormulario.Name = "lblNombreFormulario";
            this.lblNombreFormulario.Size = new System.Drawing.Size(112, 13);
            this.lblNombreFormulario.TabIndex = 10;
            this.lblNombreFormulario.Text = "Nombre del Formulario";
            this.lblNombreFormulario.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Posicion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descripcion";
            // 
            // FrmSeg_Menu_Mant
            // 
            this.ClientSize = new System.Drawing.Size(735, 333);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uC_Menu_Mantenimientos1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmSeg_Menu_Mant";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Menus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSeg_Menu_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmSeg_Menu_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenuPadre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosicion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant uC_Menu_Mantenimientos1;
        private DevExpress.XtraTreeList.TreeList treeListMenuPadre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxTienePadre;
        private System.Windows.Forms.CheckBox checkBoxTieneFormulario;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown numericUpDownPosicion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreAsembly;
        private System.Windows.Forms.Label lblNombreFormulario;
        private System.Windows.Forms.TextBox txtNombreAsembly;
        private System.Windows.Forms.TextBox txtNombreFormulario;
        private System.Windows.Forms.TextBox txtIdMenu;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
    }
}