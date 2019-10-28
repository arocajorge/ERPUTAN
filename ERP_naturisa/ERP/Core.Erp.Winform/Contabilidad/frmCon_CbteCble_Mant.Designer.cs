﻿namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_CbteCble_Mant
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
            this.cmb_tipocomprobante = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ctCbtecbletipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbvwtipoComp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltc_TipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_Interno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte_Anul = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_Nemonico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_bucarPLantilla = new System.Windows.Forms.Button();
            this.txt_codCbteCble = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_no_plantillacomprobante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_no_comprobante = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UC_Diario = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_sucursal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lbl_descargar_excel = new System.Windows.Forms.LinkLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.frmConTipoCbteCbleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipocomprobante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbvwtipoComp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmConTipoCbteCbleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_tipocomprobante
            // 
            this.cmb_tipocomprobante.Location = new System.Drawing.Point(608, 67);
            this.cmb_tipocomprobante.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_tipocomprobante.Name = "cmb_tipocomprobante";
            this.cmb_tipocomprobante.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipocomprobante.Properties.DataSource = this.ctCbtecbletipoInfoBindingSource;
            this.cmb_tipocomprobante.Properties.DisplayMember = "tc_TipoCbte";
            this.cmb_tipocomprobante.Properties.ValueMember = "IdTipoCbte";
            this.cmb_tipocomprobante.Properties.View = this.cmbvwtipoComp;
            this.cmb_tipocomprobante.Size = new System.Drawing.Size(603, 22);
            this.cmb_tipocomprobante.TabIndex = 23;
            this.cmb_tipocomprobante.EditValueChanged += new System.EventHandler(this.cmb_tipocomprobante_EditValueChanged);
            // 
            // ctCbtecbletipoInfoBindingSource
            // 
            this.ctCbtecbletipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Cbtecble_tipo_Info);
            // 
            // cmbvwtipoComp
            // 
            this.cmbvwtipoComp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltc_TipoCbte,
            this.colidTipoCbte,
            this.coltc_Interno,
            this.coltc_Estado,
            this.colIdTipoCbte_Anul,
            this.colCodTipoCbte,
            this.coltc_Nemonico});
            this.cmbvwtipoComp.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cmbvwtipoComp.Name = "cmbvwtipoComp";
            this.cmbvwtipoComp.OptionsBehavior.Editable = false;
            this.cmbvwtipoComp.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cmbvwtipoComp.OptionsView.ShowGroupPanel = false;
            // 
            // coltc_TipoCbte
            // 
            this.coltc_TipoCbte.Caption = "Tipo";
            this.coltc_TipoCbte.FieldName = "tc_TipoCbte";
            this.coltc_TipoCbte.Name = "coltc_TipoCbte";
            this.coltc_TipoCbte.Visible = true;
            this.coltc_TipoCbte.VisibleIndex = 0;
            this.coltc_TipoCbte.Width = 295;
            // 
            // colidTipoCbte
            // 
            this.colidTipoCbte.Caption = "ID";
            this.colidTipoCbte.FieldName = "IdTipoCbte";
            this.colidTipoCbte.Name = "colidTipoCbte";
            this.colidTipoCbte.Visible = true;
            this.colidTipoCbte.VisibleIndex = 2;
            this.colidTipoCbte.Width = 497;
            // 
            // coltc_Interno
            // 
            this.coltc_Interno.Caption = "Interno";
            this.coltc_Interno.FieldName = "tc_Interno";
            this.coltc_Interno.Name = "coltc_Interno";
            this.coltc_Interno.Visible = true;
            this.coltc_Interno.VisibleIndex = 3;
            this.coltc_Interno.Width = 93;
            // 
            // coltc_Estado
            // 
            this.coltc_Estado.FieldName = "tc_Estado";
            this.coltc_Estado.Name = "coltc_Estado";
            // 
            // colIdTipoCbte_Anul
            // 
            this.colIdTipoCbte_Anul.FieldName = "IdTipoCbte_Anul";
            this.colIdTipoCbte_Anul.Name = "colIdTipoCbte_Anul";
            // 
            // colCodTipoCbte
            // 
            this.colCodTipoCbte.FieldName = "CodTipoCbte";
            this.colCodTipoCbte.Name = "colCodTipoCbte";
            this.colCodTipoCbte.OptionsColumn.AllowEdit = false;
            this.colCodTipoCbte.Visible = true;
            this.colCodTipoCbte.VisibleIndex = 1;
            this.colCodTipoCbte.Width = 295;
            // 
            // coltc_Nemonico
            // 
            this.coltc_Nemonico.FieldName = "tc_Nemonico";
            this.coltc_Nemonico.Name = "coltc_Nemonico";
            this.coltc_Nemonico.OptionsColumn.AllowEdit = false;
            // 
            // btn_bucarPLantilla
            // 
            this.btn_bucarPLantilla.AutoSize = true;
            this.btn_bucarPLantilla.Location = new System.Drawing.Point(1144, 7);
            this.btn_bucarPLantilla.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bucarPLantilla.Name = "btn_bucarPLantilla";
            this.btn_bucarPLantilla.Size = new System.Drawing.Size(83, 33);
            this.btn_bucarPLantilla.TabIndex = 0;
            this.btn_bucarPLantilla.Text = "Buscar";
            this.btn_bucarPLantilla.UseVisualStyleBackColor = true;
            this.btn_bucarPLantilla.Click += new System.EventHandler(this.btn_bucarPLantilla_Click);
            // 
            // txt_codCbteCble
            // 
            this.txt_codCbteCble.Location = new System.Drawing.Point(167, 67);
            this.txt_codCbteCble.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codCbteCble.MaxLength = 20;
            this.txt_codCbteCble.Name = "txt_codCbteCble";
            this.txt_codCbteCble.Size = new System.Drawing.Size(161, 22);
            this.txt_codCbteCble.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Código Comprobante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de Comprobante:";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(608, 9);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(176, 22);
            this.dtFecha.TabIndex = 8;
            // 
            // txt_concepto
            // 
            this.txt_concepto.Location = new System.Drawing.Point(167, 116);
            this.txt_concepto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_concepto.MaxLength = 250;
            this.txt_concepto.Multiline = true;
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_concepto.Size = new System.Drawing.Size(1043, 62);
            this.txt_concepto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Concepto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Comprobante:";
            // 
            // txt_no_plantillacomprobante
            // 
            this.txt_no_plantillacomprobante.Location = new System.Drawing.Point(991, 9);
            this.txt_no_plantillacomprobante.Margin = new System.Windows.Forms.Padding(4);
            this.txt_no_plantillacomprobante.Name = "txt_no_plantillacomprobante";
            this.txt_no_plantillacomprobante.Size = new System.Drawing.Size(144, 22);
            this.txt_no_plantillacomprobante.TabIndex = 3;
            this.txt_no_plantillacomprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_no_plantillacomprobante_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(811, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. Plantilla Comprobante:";
            // 
            // lbl_no_comprobante
            // 
            this.lbl_no_comprobante.BackColor = System.Drawing.Color.White;
            this.lbl_no_comprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_no_comprobante.Location = new System.Drawing.Point(167, 9);
            this.lbl_no_comprobante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_no_comprobante.Name = "lbl_no_comprobante";
            this.lbl_no_comprobante.Size = new System.Drawing.Size(162, 22);
            this.lbl_no_comprobante.TabIndex = 1;
            this.lbl_no_comprobante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Comprobante:";
            // 
            // UC_Diario
            // 
            this.UC_Diario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_Diario.IdCtaCble_x_Banco = null;
            this.UC_Diario.Location = new System.Drawing.Point(0, 245);
            this.UC_Diario.Margin = new System.Windows.Forms.Padding(5);
            this.UC_Diario.Name = "UC_Diario";
            this.UC_Diario.Size = new System.Drawing.Size(1261, 314);
            this.UC_Diario.TabIndex = 0;
            this.UC_Diario.Visible_Botones = false;
            this.UC_Diario.Visible_Cabecera = false;
            this.UC_Diario.Visible_columna_GrupoPuntoCargo = true;
            this.UC_Diario.Visible_columna_PuntoCargo = true;
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
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1261, 36);
            this.ucGe_Menu.TabIndex = 5;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
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
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmb_sucursal);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lbl_descargar_excel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_tipocomprobante);
            this.panel1.Controls.Add(this.txt_concepto);
            this.panel1.Controls.Add(this.btn_bucarPLantilla);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtFecha);
            this.panel1.Controls.Add(this.txt_no_plantillacomprobante);
            this.panel1.Controls.Add(this.txt_codCbteCble);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_no_comprobante);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 209);
            this.panel1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Sucursal:";
            // 
            // cmb_sucursal
            // 
            this.cmb_sucursal.Location = new System.Drawing.Point(167, 38);
            this.cmb_sucursal.Name = "cmb_sucursal";
            this.cmb_sucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_sucursal.Properties.DisplayMember = "Su_Descripcion";
            this.cmb_sucursal.Properties.ValueMember = "IdSucursal";
            this.cmb_sucursal.Properties.View = this.searchLookUpEdit1View;
            this.cmb_sucursal.Size = new System.Drawing.Size(617, 22);
            this.cmb_sucursal.TabIndex = 47;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(416, 97);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 17);
            this.lblEstado.TabIndex = 46;
            this.lblEstado.Text = "label7";
            this.lblEstado.Visible = false;
            // 
            // lbl_descargar_excel
            // 
            this.lbl_descargar_excel.AutoSize = true;
            this.lbl_descargar_excel.Location = new System.Drawing.Point(16, 183);
            this.lbl_descargar_excel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descargar_excel.Name = "lbl_descargar_excel";
            this.lbl_descargar_excel.Size = new System.Drawing.Size(261, 17);
            this.lbl_descargar_excel.TabIndex = 45;
            this.lbl_descargar_excel.TabStop = true;
            this.lbl_descargar_excel.Text = "Descargar plantilla de excel para diarios";
            this.lbl_descargar_excel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_descargar_excel_LinkClicked);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xls";
            this.saveFileDialog1.FileName = "Plantilla_diario";
            // 
            // frmConTipoCbteCbleBindingSource
            // 
            this.frmConTipoCbteCbleBindingSource.DataSource = typeof(Core.Erp.Winform.Contabilidad.frmCon_TipoCbteCble_Cons);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sucursal";
            this.gridColumn1.FieldName = "Su_Descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 949;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "IdSucursal";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 267;
            // 
            // frmCon_CbteCble_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 559);
            this.Controls.Add(this.UC_Diario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCon_CbteCble_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobante Contable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCon_CbteCble_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmCon_CbteCble_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipocomprobante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbvwtipoComp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmConTipoCbteCbleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codCbteCble;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_no_plantillacomprobante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_no_comprobante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_bucarPLantilla;
        private Controles.UCCon_GridDiarioContable UC_Diario;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_tipocomprobante;
        private DevExpress.XtraGrid.Views.Grid.GridView cmbvwtipoComp;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_TipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colidTipoCbte;
        private System.Windows.Forms.BindingSource ctCbtecbletipoInfoBindingSource;
        private System.Windows.Forms.BindingSource frmConTipoCbteCbleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_Interno;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte_Anul;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_Nemonico;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lbl_descargar_excel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_sucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}