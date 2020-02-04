namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Secuencia_Documento_Talonario_Mant
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSerie1 = new DevExpress.XtraEditors.TextEdit();
            this.txtDocIni = new DevExpress.XtraEditors.TextEdit();
            this.txtDocFin = new DevExpress.XtraEditors.TextEdit();
            this.txtDocAct = new DevExpress.XtraEditors.TextEdit();
            this.txtAut = new DevExpress.XtraEditors.TextEdit();
            this.txtSerie2 = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFechaCad = new System.Windows.Forms.DateTimePicker();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtFoco = new System.Windows.Forms.TextBox();
            this.ultraCmbE_TipoDoc = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtsecuencia = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocAct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_TipoDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsecuencia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Documento Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Documento Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Documento Actual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Autorizacion";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(33, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 82);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Serie";
            // 
            // txtSerie1
            // 
            this.txtSerie1.Location = new System.Drawing.Point(139, 172);
            this.txtSerie1.Name = "txtSerie1";
            this.txtSerie1.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSerie1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSerie1.Properties.Mask.BeepOnError = true;
            this.txtSerie1.Properties.Mask.EditMask = "\\d?{0,5}";
            this.txtSerie1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSerie1.Properties.Mask.SaveLiteral = false;
            this.txtSerie1.Size = new System.Drawing.Size(48, 20);
            this.txtSerie1.TabIndex = 0;
            //this.txtSerie1.Validating += new System.ComponentModel.CancelEventHandler(this.txtSerie1_Validating);
            // 
            // txtDocIni
            // 
            this.txtDocIni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocIni.Location = new System.Drawing.Point(139, 198);
            this.txtDocIni.Name = "txtDocIni";
            this.txtDocIni.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDocIni.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDocIni.Properties.Mask.BeepOnError = true;
            this.txtDocIni.Properties.Mask.EditMask = "\\d?{0,50}";
            this.txtDocIni.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDocIni.Properties.Mask.SaveLiteral = false;
            this.txtDocIni.Size = new System.Drawing.Size(223, 20);
            this.txtDocIni.TabIndex = 2;
            //this.txtDocIni.Validating += new System.ComponentModel.CancelEventHandler(this.txtDocIni_Validating);
            // 
            // txtDocFin
            // 
            this.txtDocFin.Location = new System.Drawing.Point(139, 226);
            this.txtDocFin.Name = "txtDocFin";
            this.txtDocFin.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDocFin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDocFin.Properties.Mask.BeepOnError = true;
            this.txtDocFin.Properties.Mask.EditMask = "\\d?{0,50}";
            this.txtDocFin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDocFin.Properties.Mask.SaveLiteral = false;
            this.txtDocFin.Size = new System.Drawing.Size(223, 20);
            this.txtDocFin.TabIndex = 3;
            //this.txtDocFin.Validating += new System.ComponentModel.CancelEventHandler(this.txtDocFin_Validating);
            // 
            // txtDocAct
            // 
            this.txtDocAct.Location = new System.Drawing.Point(139, 252);
            this.txtDocAct.Name = "txtDocAct";
            this.txtDocAct.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDocAct.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDocAct.Properties.Mask.BeepOnError = true;
            this.txtDocAct.Properties.Mask.EditMask = "\\d?{0,50}";
            this.txtDocAct.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDocAct.Properties.Mask.SaveLiteral = false;
            this.txtDocAct.Size = new System.Drawing.Size(223, 20);
            this.txtDocAct.TabIndex = 4;
            //this.txtDocAct.Validating += new System.ComponentModel.CancelEventHandler(this.txtDocAct_Validating);
            // 
            // txtAut
            // 
            this.txtAut.Location = new System.Drawing.Point(139, 282);
            this.txtAut.Name = "txtAut";
            this.txtAut.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAut.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAut.Properties.Mask.BeepOnError = true;
            this.txtAut.Properties.Mask.EditMask = "d";
            this.txtAut.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAut.Properties.Mask.SaveLiteral = false;
            this.txtAut.Size = new System.Drawing.Size(223, 20);
            this.txtAut.TabIndex = 5;
            //this.txtAut.Validating += new System.ComponentModel.CancelEventHandler(this.txtAut_Validating);
            // 
            // txtSerie2
            // 
            this.txtSerie2.Location = new System.Drawing.Point(209, 172);
            this.txtSerie2.Name = "txtSerie2";
            this.txtSerie2.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSerie2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSerie2.Properties.Mask.BeepOnError = true;
            this.txtSerie2.Properties.Mask.EditMask = "\\d?{0,5}";
            this.txtSerie2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSerie2.Properties.Mask.SaveLiteral = false;
            this.txtSerie2.Size = new System.Drawing.Size(48, 20);
            this.txtSerie2.TabIndex = 1;
            //this.txtSerie2.Validating += new System.ComponentModel.CancelEventHandler(this.txtSerie2_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fecha de Caducidad";
            // 
            // dtFechaCad
            // 
            this.dtFechaCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaCad.Location = new System.Drawing.Point(139, 310);
            this.dtFechaCad.Name = "dtFechaCad";
            this.dtFechaCad.Size = new System.Drawing.Size(118, 20);
            this.dtFechaCad.TabIndex = 6;
            //this.dtFechaCad.Validating += new System.ComponentModel.CancelEventHandler(this.dtFechaCad_Validating);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(303, 312);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(59, 17);
            this.chkEstado.TabIndex = 7;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtFoco
            // 
            this.txtFoco.Location = new System.Drawing.Point(534, -28);
            this.txtFoco.Name = "txtFoco";
            this.txtFoco.Size = new System.Drawing.Size(100, 20);
            this.txtFoco.TabIndex = 15;
            // 
            // ultraCmbE_TipoDoc
            // 
            this.ultraCmbE_TipoDoc.Location = new System.Drawing.Point(151, 49);
            this.ultraCmbE_TipoDoc.Name = "ultraCmbE_TipoDoc";
            this.ultraCmbE_TipoDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraCmbE_TipoDoc.Properties.NullText = "";
            this.ultraCmbE_TipoDoc.Properties.ValueMember = "Codigo";
            this.ultraCmbE_TipoDoc.Properties.View = this.gridView4;
            this.ultraCmbE_TipoDoc.Size = new System.Drawing.Size(365, 20);
            this.ultraCmbE_TipoDoc.TabIndex = 65;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(578, 29);
            this.ucGe_Menu.TabIndex = 66;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(346, 175);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 68;
            this.labelControl1.Text = "Secuencia:";
            // 
            // txtsecuencia
            // 
            this.txtsecuencia.EditValue = "0";
            this.txtsecuencia.Enabled = false;
            this.txtsecuencia.Location = new System.Drawing.Point(428, 172);
            this.txtsecuencia.Name = "txtsecuencia";
            this.txtsecuencia.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtsecuencia.Properties.Appearance.Options.UseBackColor = true;
            this.txtsecuencia.Properties.ReadOnly = true;
            this.txtsecuencia.Size = new System.Drawing.Size(100, 20);
            this.txtsecuencia.TabIndex = 67;
            // 
            // frmFa_Secuencia_Documento_Talonario_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(578, 350);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtsecuencia);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ultraCmbE_TipoDoc);
            this.Controls.Add(this.txtFoco);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.dtFechaCad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAut);
            this.Controls.Add(this.txtDocAct);
            this.Controls.Add(this.txtDocFin);
            this.Controls.Add(this.txtDocIni);
            this.Controls.Add(this.txtSerie2);
            this.Controls.Add(this.txtSerie1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFa_Secuencia_Documento_Talonario_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipo y Secuencia por Documento";
            this.Load += new System.EventHandler(this.frmFA_Secuencia_Documento_Talonario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocAct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_TipoDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsecuencia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtSerie1;
        private DevExpress.XtraEditors.TextEdit txtDocIni;
        private DevExpress.XtraEditors.TextEdit txtDocFin;
        private DevExpress.XtraEditors.TextEdit txtDocAct;
        private DevExpress.XtraEditors.TextEdit txtAut;
        private DevExpress.XtraEditors.TextEdit txtSerie2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtFechaCad;
        public System.Windows.Forms.CheckBox chkEstado;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFoco;
        private DevExpress.XtraEditors.SearchLookUpEdit ultraCmbE_TipoDoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtsecuencia;
    }
}