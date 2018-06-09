namespace Core.Erp.Winform.General
{
    partial class FrmGe_DocuAnulados
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
            this.txt_serie1 = new System.Windows.Forms.TextBox();
            this.txt_AutSRI = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_docIni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_serie2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_docFin = new System.Windows.Forms.TextBox();
            this.cmbMotivoAnula = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbTipoDocu = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_doc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Lote = new System.Windows.Forms.RadioButton();
            this.rb_Documento = new System.Windows.Forms.RadioButton();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMotivoAnula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoDocu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_serie1
            // 
            this.txt_serie1.Location = new System.Drawing.Point(292, 91);
            this.txt_serie1.MaxLength = 3;
            this.txt_serie1.Name = "txt_serie1";
            this.txt_serie1.Size = new System.Drawing.Size(89, 20);
            this.txt_serie1.TabIndex = 4;
            this.txt_serie1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_serie1_KeyPress);
            // 
            // txt_AutSRI
            // 
            this.txt_AutSRI.Location = new System.Drawing.Point(106, 116);
            this.txt_AutSRI.MaxLength = 50;
            this.txt_AutSRI.Name = "txt_AutSRI";
            this.txt_AutSRI.Size = new System.Drawing.Size(113, 20);
            this.txt_AutSRI.TabIndex = 6;
            this.txt_AutSRI.Tag = "9";
            this.txt_AutSRI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AutSRI_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(12, 120);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(68, 13);
            this.label35.TabIndex = 55;
            this.label35.Text = "Autorización:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(413, 93);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(43, 13);
            this.label36.TabIndex = 56;
            this.label36.Text = "Serie 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tipo de Doc.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Fecha:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(106, 91);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(113, 20);
            this.dtp_fecha.TabIndex = 3;
            this.dtp_fecha.Tag = "";
            // 
            // txt_docIni
            // 
            this.txt_docIni.Location = new System.Drawing.Point(80, 10);
            this.txt_docIni.MaxLength = 9;
            this.txt_docIni.Name = "txt_docIni";
            this.txt_docIni.Size = new System.Drawing.Size(89, 20);
            this.txt_docIni.TabIndex = 1;
            this.txt_docIni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_docIni_KeyPress);
            this.txt_docIni.Validating += new System.ComponentModel.CancelEventHandler(this.txt_docIni_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "#Doc. Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "Motivo Anulación:";
            // 
            // txt_detalle
            // 
            this.txt_detalle.Location = new System.Drawing.Point(106, 143);
            this.txt_detalle.Multiline = true;
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(436, 61);
            this.txt_detalle.TabIndex = 7;
            this.txt_detalle.Tag = "9";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 111;
            this.label5.Text = "Detalle:";
            // 
            // txt_serie2
            // 
            this.txt_serie2.Location = new System.Drawing.Point(453, 91);
            this.txt_serie2.MaxLength = 3;
            this.txt_serie2.Name = "txt_serie2";
            this.txt_serie2.Size = new System.Drawing.Size(91, 20);
            this.txt_serie2.TabIndex = 5;
            this.txt_serie2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_serie2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 113;
            this.label6.Text = "Serie 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 114;
            this.label7.Text = "#Doc. Fin:";
            // 
            // txt_docFin
            // 
            this.txt_docFin.Location = new System.Drawing.Point(271, 10);
            this.txt_docFin.MaxLength = 9;
            this.txt_docFin.Name = "txt_docFin";
            this.txt_docFin.Size = new System.Drawing.Size(89, 20);
            this.txt_docFin.TabIndex = 2;
            this.txt_docFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_docFin_KeyPress);
            // 
            // cmbMotivoAnula
            // 
            this.cmbMotivoAnula.Location = new System.Drawing.Point(106, 65);
            this.cmbMotivoAnula.Name = "cmbMotivoAnula";
            this.cmbMotivoAnula.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMotivoAnula.Properties.View = this.searchLookUpEdit1View;
            this.cmbMotivoAnula.Size = new System.Drawing.Size(436, 20);
            this.cmbMotivoAnula.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colca_descripcion,
            this.colIdCatalogo});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cmbTipoDocu
            // 
            this.cmbTipoDocu.Location = new System.Drawing.Point(106, 34);
            this.cmbTipoDocu.Name = "cmbTipoDocu";
            this.cmbTipoDocu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoDocu.Properties.View = this.gridView1;
            this.cmbTipoDocu.Size = new System.Drawing.Size(436, 20);
            this.cmbTipoDocu.TabIndex = 1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion,
            this.colCodTipoDocumento});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rb_Lote);
            this.groupBox1.Controls.Add(this.rb_Documento);
            this.groupBox1.Location = new System.Drawing.Point(10, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 91);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle del Documento:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_doc);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(112, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 30);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // txt_doc
            // 
            this.txt_doc.Location = new System.Drawing.Point(93, 7);
            this.txt_doc.MaxLength = 9;
            this.txt_doc.Name = "txt_doc";
            this.txt_doc.Size = new System.Drawing.Size(89, 20);
            this.txt_doc.TabIndex = 1;
            this.txt_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_doc_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "#Doc. Inicio:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_docIni);
            this.groupBox2.Controls.Add(this.txt_docFin);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(112, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 34);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // rb_Lote
            // 
            this.rb_Lote.AutoSize = true;
            this.rb_Lote.Location = new System.Drawing.Point(7, 62);
            this.rb_Lote.Name = "rb_Lote";
            this.rb_Lote.Size = new System.Drawing.Size(65, 17);
            this.rb_Lote.TabIndex = 2;
            this.rb_Lote.Text = "Por Lote";
            this.rb_Lote.UseVisualStyleBackColor = true;
            this.rb_Lote.CheckedChanged += new System.EventHandler(this.rb_Lote_CheckedChanged);
            // 
            // rb_Documento
            // 
            this.rb_Documento.AutoSize = true;
            this.rb_Documento.Checked = true;
            this.rb_Documento.Location = new System.Drawing.Point(7, 19);
            this.rb_Documento.Name = "rb_Documento";
            this.rb_Documento.Size = new System.Drawing.Size(99, 17);
            this.rb_Documento.TabIndex = 0;
            this.rb_Documento.TabStop = true;
            this.rb_Documento.Text = "Por Documento";
            this.rb_Documento.UseVisualStyleBackColor = true;
            this.rb_Documento.CheckedChanged += new System.EventHandler(this.rb_Documento_CheckedChanged);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 302);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(563, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 121;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(563, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
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
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 889;
            // 
            // colCodTipoDocumento
            // 
            this.colCodTipoDocumento.Caption = "Código";
            this.colCodTipoDocumento.FieldName = "CodTipoDocumento";
            this.colCodTipoDocumento.Name = "colCodTipoDocumento";
            this.colCodTipoDocumento.Visible = true;
            this.colCodTipoDocumento.VisibleIndex = 1;
            this.colCodTipoDocumento.Width = 291;
            // 
            // colca_descripcion
            // 
            this.colca_descripcion.Caption = "Descripción";
            this.colca_descripcion.FieldName = "ca_descripcion";
            this.colca_descripcion.Name = "colca_descripcion";
            this.colca_descripcion.Visible = true;
            this.colca_descripcion.VisibleIndex = 0;
            this.colca_descripcion.Width = 881;
            // 
            // colIdCatalogo
            // 
            this.colIdCatalogo.Caption = "Código";
            this.colIdCatalogo.FieldName = "IdCatalogo";
            this.colIdCatalogo.Name = "colIdCatalogo";
            this.colIdCatalogo.Visible = true;
            this.colIdCatalogo.VisibleIndex = 1;
            this.colIdCatalogo.Width = 299;
            // 
            // FrmGe_DocuAnulados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 328);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbTipoDocu);
            this.Controls.Add(this.cmbMotivoAnula);
            this.Controls.Add(this.txt_serie2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_detalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_serie1);
            this.Controls.Add(this.txt_AutSRI);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Name = "FrmGe_DocuAnulados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos Anulados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGe_DocuAnulados_FormClosing);
            this.Load += new System.EventHandler(this.FrmGe_DocuAnulados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbMotivoAnula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoDocu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_serie1;
        private System.Windows.Forms.TextBox txt_AutSRI;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.TextBox txt_docIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_serie2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_docFin;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbMotivoAnula;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colca_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipoDocu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTipoDocumento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_doc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Lote;
        private System.Windows.Forms.RadioButton rb_Documento;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
    }
}