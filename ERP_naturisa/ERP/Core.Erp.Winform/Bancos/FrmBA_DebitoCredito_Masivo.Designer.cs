namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_DebitoCredito_Masivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBA_DebitoCredito_Masivo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ultraCmbCtaBanco = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dt_fechaCbte = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idTransaccion = new System.Windows.Forms.TextBox();
            this.txt_Memo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rB_Debito = new System.Windows.Forms.RadioButton();
            this.rB_Credito = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl_CbteBan = new DevExpress.XtraGrid.GridControl();
            this.gridView_CbteBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcb_Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_secuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTipoNota = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.vwTipoNota = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PicturebtnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbl_error = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbCtaBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CbteBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CbteBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTipoNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturebtnEdit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ultraCmbCtaBanco);
            this.groupBox1.Controls.Add(this.dt_fechaCbte);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_idTransaccion);
            this.groupBox1.Controls.Add(this.txt_Memo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // ultraCmbCtaBanco
            // 
            this.ultraCmbCtaBanco.Location = new System.Drawing.Point(89, 44);
            this.ultraCmbCtaBanco.Name = "ultraCmbCtaBanco";
            this.ultraCmbCtaBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraCmbCtaBanco.Properties.DisplayMember = "ba_descripcion";
            this.ultraCmbCtaBanco.Properties.ValueMember = "IdBanco";
            this.ultraCmbCtaBanco.Properties.View = this.gridView3;
            this.ultraCmbCtaBanco.Size = new System.Drawing.Size(328, 20);
            this.ultraCmbCtaBanco.TabIndex = 2;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colba_descripcion});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colba_descripcion
            // 
            this.colba_descripcion.Caption = "Descripcion";
            this.colba_descripcion.FieldName = "ba_descripcion";
            this.colba_descripcion.Name = "colba_descripcion";
            this.colba_descripcion.Visible = true;
            this.colba_descripcion.VisibleIndex = 0;
            // 
            // dt_fechaCbte
            // 
            this.dt_fechaCbte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechaCbte.Location = new System.Drawing.Point(702, 17);
            this.dt_fechaCbte.Name = "dt_fechaCbte";
            this.dt_fechaCbte.Size = new System.Drawing.Size(100, 20);
            this.dt_fechaCbte.TabIndex = 5;
            this.dt_fechaCbte.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdTransacción:";
            // 
            // txt_idTransaccion
            // 
            this.txt_idTransaccion.Location = new System.Drawing.Point(89, 15);
            this.txt_idTransaccion.Name = "txt_idTransaccion";
            this.txt_idTransaccion.ReadOnly = true;
            this.txt_idTransaccion.Size = new System.Drawing.Size(100, 20);
            this.txt_idTransaccion.TabIndex = 1;
            // 
            // txt_Memo
            // 
            this.txt_Memo.Location = new System.Drawing.Point(89, 81);
            this.txt_Memo.Multiline = true;
            this.txt_Memo.Name = "txt_Memo";
            this.txt_Memo.Size = new System.Drawing.Size(713, 33);
            this.txt_Memo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Observación:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rB_Debito);
            this.groupBox3.Controls.Add(this.rB_Credito);
            this.groupBox3.Location = new System.Drawing.Point(458, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 42);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Comprobante";
            // 
            // rB_Debito
            // 
            this.rB_Debito.AutoSize = true;
            this.rB_Debito.Location = new System.Drawing.Point(202, 16);
            this.rB_Debito.Name = "rB_Debito";
            this.rB_Debito.Size = new System.Drawing.Size(124, 17);
            this.rB_Debito.TabIndex = 1;
            this.rB_Debito.Text = "DEBIDO BANCARIO";
            this.rB_Debito.UseVisualStyleBackColor = true;
            this.rB_Debito.CheckedChanged += new System.EventHandler(this.rB_Debito_CheckedChanged);
            // 
            // rB_Credito
            // 
            this.rB_Credito.AutoSize = true;
            this.rB_Credito.Checked = true;
            this.rB_Credito.Location = new System.Drawing.Point(8, 16);
            this.rB_Credito.Name = "rB_Credito";
            this.rB_Credito.Size = new System.Drawing.Size(131, 17);
            this.rB_Credito.TabIndex = 0;
            this.rB_Credito.TabStop = true;
            this.rB_Credito.Text = "CREDITO BANCARIO";
            this.rB_Credito.UseVisualStyleBackColor = true;
            this.rB_Credito.CheckedChanged += new System.EventHandler(this.rB_Credito_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(9, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cta. Bancaria:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_error);
            this.groupBox2.Controls.Add(this.gridControl_CbteBan);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1060, 270);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // gridControl_CbteBan
            // 
            this.gridControl_CbteBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_CbteBan.Location = new System.Drawing.Point(3, 16);
            this.gridControl_CbteBan.MainView = this.gridView_CbteBan;
            this.gridControl_CbteBan.Name = "gridControl_CbteBan";
            this.gridControl_CbteBan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbTipoNota,
            this.PicturebtnEdit});
            this.gridControl_CbteBan.Size = new System.Drawing.Size(1054, 251);
            this.gridControl_CbteBan.TabIndex = 1;
            this.gridControl_CbteBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_CbteBan});
            // 
            // gridView_CbteBan
            // 
            this.gridView_CbteBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcb_Fecha,
            this.colcb_Observacion,
            this.colcb_secuencia,
            this.colcb_Valor,
            this.colIdTipoNota,
            this.colError});
            this.gridView_CbteBan.GridControl = this.gridControl_CbteBan;
            this.gridView_CbteBan.Name = "gridView_CbteBan";
            this.gridView_CbteBan.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_CbteBan.OptionsSelection.MultiSelect = true;
            this.gridView_CbteBan.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_CbteBan.OptionsView.ShowGroupPanel = false;
            this.gridView_CbteBan.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colcb_secuencia, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView_CbteBan.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_CbteBan_RowCellClick);
            this.gridView_CbteBan.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_CbteBan_RowCellStyle);
            this.gridView_CbteBan.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CbteBan_CellValueChanged);
            this.gridView_CbteBan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_CbteBan_KeyDown);
            // 
            // colcb_Fecha
            // 
            this.colcb_Fecha.Caption = "Fecha";
            this.colcb_Fecha.FieldName = "cb_Fecha";
            this.colcb_Fecha.Name = "colcb_Fecha";
            this.colcb_Fecha.Visible = true;
            this.colcb_Fecha.VisibleIndex = 1;
            this.colcb_Fecha.Width = 104;
            // 
            // colcb_Observacion
            // 
            this.colcb_Observacion.Caption = "Observación";
            this.colcb_Observacion.FieldName = "cb_Observacion";
            this.colcb_Observacion.Name = "colcb_Observacion";
            this.colcb_Observacion.Visible = true;
            this.colcb_Observacion.VisibleIndex = 4;
            this.colcb_Observacion.Width = 553;
            // 
            // colcb_secuencia
            // 
            this.colcb_secuencia.Caption = "Sec";
            this.colcb_secuencia.FieldName = "cb_secuencia";
            this.colcb_secuencia.Name = "colcb_secuencia";
            this.colcb_secuencia.OptionsColumn.ReadOnly = true;
            this.colcb_secuencia.Visible = true;
            this.colcb_secuencia.VisibleIndex = 0;
            this.colcb_secuencia.Width = 41;
            // 
            // colcb_Valor
            // 
            this.colcb_Valor.Caption = "Valor";
            this.colcb_Valor.FieldName = "cb_Valor";
            this.colcb_Valor.Name = "colcb_Valor";
            this.colcb_Valor.Visible = true;
            this.colcb_Valor.VisibleIndex = 3;
            this.colcb_Valor.Width = 78;
            // 
            // colIdTipoNota
            // 
            this.colIdTipoNota.Caption = "Motivo";
            this.colIdTipoNota.ColumnEdit = this.cmbTipoNota;
            this.colIdTipoNota.FieldName = "IdTipoNota";
            this.colIdTipoNota.Name = "colIdTipoNota";
            this.colIdTipoNota.Visible = true;
            this.colIdTipoNota.VisibleIndex = 2;
            this.colIdTipoNota.Width = 260;
            // 
            // cmbTipoNota
            // 
            this.cmbTipoNota.AutoHeight = false;
            this.cmbTipoNota.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoNota.DisplayMember = "Descripcion";
            this.cmbTipoNota.Name = "cmbTipoNota";
            this.cmbTipoNota.ValueMember = "IdTipoNota";
            this.cmbTipoNota.View = this.vwTipoNota;
            // 
            // vwTipoNota
            // 
            this.vwTipoNota.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.vwTipoNota.Name = "vwTipoNota";
            this.vwTipoNota.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.vwTipoNota.OptionsView.ShowGroupPanel = false;
            // 
            // PicturebtnEdit
            // 
            this.PicturebtnEdit.Name = "PicturebtnEdit";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "busqueda.jpg");
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 420);
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
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
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
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 391);
            this.panel1.TabIndex = 4;
            // 
            // colError
            // 
            this.colError.Caption = "colError";
            this.colError.Name = "colError";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(86, 3);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(300, 13);
            this.lbl_error.TabIndex = 7;
            this.lbl_error.Text = "** hay errores en la data a subir /debe escoger la cta contable";
            this.lbl_error.Visible = false;
            // 
            // FrmBA_DebitoCredito_Masivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmBA_DebitoCredito_Masivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingreso de Debito y Credito Masivo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBA_DebitoCredito_Masivo_FormClosing);
            this.Load += new System.EventHandler(this.FrmBA_DebitoCredito_Masivo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbCtaBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CbteBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CbteBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTipoNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturebtnEdit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dt_fechaCbte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rB_Debito;
        private System.Windows.Forms.RadioButton rB_Credito;
        private DevExpress.XtraGrid.GridControl gridControl_CbteBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_CbteBan;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_secuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Valor;
        private System.Windows.Forms.TextBox txt_Memo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idTransaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoNota;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbTipoNota;
        private DevExpress.XtraGrid.Views.Grid.GridView vwTipoNota;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit PicturebtnEdit;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SearchLookUpEdit ultraCmbCtaBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colba_descripcion;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn colError;
        private System.Windows.Forms.Label lbl_error;
    }
}