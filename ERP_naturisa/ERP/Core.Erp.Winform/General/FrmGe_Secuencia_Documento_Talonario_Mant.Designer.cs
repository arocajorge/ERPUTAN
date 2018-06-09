namespace Core.Erp.Winform.General
{
    partial class FrmGe_Secuencia_Documento_Talonario_Mant
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
            this.txtpuntoEmision = new DevExpress.XtraEditors.TextEdit();
            this.txtEstablecimiento = new DevExpress.XtraEditors.TextEdit();
            this.txtUltDoc = new DevExpress.XtraEditors.TextEdit();
            this.txtGenerar = new DevExpress.XtraEditors.TextEdit();
            this.txtFoco = new System.Windows.Forms.TextBox();
            this.ultraCmbE_TipoDoc = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDocFinal = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.lblusado = new System.Windows.Forms.Label();
            this.txtnumeroDoc = new DevExpress.XtraEditors.TextEdit();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblfechacad = new System.Windows.Forms.Label();
            this.lblumdocumento = new System.Windows.Forms.Label();
            this.chkUsado = new System.Windows.Forms.CheckBox();
            this.lblnumautorizacion = new System.Windows.Forms.Label();
            this.txtNumeroAut = new DevExpress.XtraEditors.TextEdit();
            this.chkestado = new System.Windows.Forms.CheckBox();
            this.dtFechaCad = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkelectronica = new System.Windows.Forms.CheckBox();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.txtpuntoEmision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstablecimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenerar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_TipoDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumeroDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroAut.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Punto Emision:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Establecimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Documento Inicial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad a Generar:";
            // 
            // txtpuntoEmision
            // 
            this.txtpuntoEmision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpuntoEmision.Location = new System.Drawing.Point(141, 81);
            this.txtpuntoEmision.Name = "txtpuntoEmision";
            this.txtpuntoEmision.Properties.Appearance.Options.UseTextOptions = true;
            this.txtpuntoEmision.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtpuntoEmision.Properties.Mask.BeepOnError = true;
            this.txtpuntoEmision.Properties.Mask.SaveLiteral = false;
            this.txtpuntoEmision.Size = new System.Drawing.Size(98, 20);
            this.txtpuntoEmision.TabIndex = 2;
            this.txtpuntoEmision.EditValueChanged += new System.EventHandler(this.txtpuntoEmision_EditValueChanged);
            this.txtpuntoEmision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpuntoEmision_KeyPress);
            // 
            // txtEstablecimiento
            // 
            this.txtEstablecimiento.Location = new System.Drawing.Point(141, 55);
            this.txtEstablecimiento.Name = "txtEstablecimiento";
            this.txtEstablecimiento.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEstablecimiento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtEstablecimiento.Properties.Mask.BeepOnError = true;
            this.txtEstablecimiento.Properties.Mask.SaveLiteral = false;
            this.txtEstablecimiento.Size = new System.Drawing.Size(98, 20);
            this.txtEstablecimiento.TabIndex = 1;
            this.txtEstablecimiento.EditValueChanged += new System.EventHandler(this.txtEstablecimiento_EditValueChanged);
            this.txtEstablecimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstablecimiento_KeyPress);
            // 
            // txtUltDoc
            // 
            this.txtUltDoc.Location = new System.Drawing.Point(141, 111);
            this.txtUltDoc.Name = "txtUltDoc";
            this.txtUltDoc.Properties.Appearance.Options.UseTextOptions = true;
            this.txtUltDoc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtUltDoc.Properties.Mask.BeepOnError = true;
            this.txtUltDoc.Properties.Mask.EditMask = "\\d?{0,50}";
            this.txtUltDoc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtUltDoc.Properties.Mask.SaveLiteral = false;
            this.txtUltDoc.Size = new System.Drawing.Size(191, 20);
            this.txtUltDoc.TabIndex = 3;
            this.txtUltDoc.EditValueChanged += new System.EventHandler(this.txtUltDoc_EditValueChanged);
            // 
            // txtGenerar
            // 
            this.txtGenerar.Location = new System.Drawing.Point(141, 140);
            this.txtGenerar.Name = "txtGenerar";
            this.txtGenerar.Properties.Appearance.Options.UseTextOptions = true;
            this.txtGenerar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtGenerar.Properties.Mask.BeepOnError = true;
            this.txtGenerar.Properties.Mask.SaveLiteral = false;
            this.txtGenerar.Size = new System.Drawing.Size(98, 20);
            this.txtGenerar.TabIndex = 4;
            this.txtGenerar.EditValueChanged += new System.EventHandler(this.txtGenerar_EditValueChanged);
            this.txtGenerar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGenerar_KeyPress);
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
            this.ultraCmbE_TipoDoc.Location = new System.Drawing.Point(141, 27);
            this.ultraCmbE_TipoDoc.Name = "ultraCmbE_TipoDoc";
            this.ultraCmbE_TipoDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraCmbE_TipoDoc.Properties.DisplayMember = "descripcion";
            this.ultraCmbE_TipoDoc.Properties.NullText = "";
            this.ultraCmbE_TipoDoc.Properties.ValueMember = "codDocumentoTipo";
            this.ultraCmbE_TipoDoc.Properties.View = this.gridView4;
            this.ultraCmbE_TipoDoc.Size = new System.Drawing.Size(191, 20);
            this.ultraCmbE_TipoDoc.TabIndex = 0;
            this.ultraCmbE_TipoDoc.EditValueChanged += new System.EventHandler(this.ultraCmbE_TipoDoc_EditValueChanged);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.col_descripcion});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "codDocumentoTipo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 1;
            this.Codigo.Width = 221;
            // 
            // col_descripcion
            // 
            this.col_descripcion.Caption = "Descripcion";
            this.col_descripcion.FieldName = "descripcion";
            this.col_descripcion.Name = "col_descripcion";
            this.col_descripcion.Visible = true;
            this.col_descripcion.VisibleIndex = 0;
            this.col_descripcion.Width = 920;
            // 
            // txtDocFinal
            // 
            this.txtDocFinal.Enabled = false;
            this.txtDocFinal.Location = new System.Drawing.Point(141, 173);
            this.txtDocFinal.Name = "txtDocFinal";
            this.txtDocFinal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDocFinal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDocFinal.Properties.Mask.BeepOnError = true;
            this.txtDocFinal.Properties.Mask.EditMask = "d";
            this.txtDocFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDocFinal.Properties.Mask.SaveLiteral = false;
            this.txtDocFinal.Properties.ReadOnly = true;
            this.txtDocFinal.Size = new System.Drawing.Size(191, 20);
            this.txtDocFinal.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Documento Final:";
            // 
            // lblusado
            // 
            this.lblusado.AutoSize = true;
            this.lblusado.Location = new System.Drawing.Point(20, 113);
            this.lblusado.Name = "lblusado";
            this.lblusado.Size = new System.Drawing.Size(41, 13);
            this.lblusado.TabIndex = 76;
            this.lblusado.Text = "Usado:";
            // 
            // txtnumeroDoc
            // 
            this.txtnumeroDoc.Location = new System.Drawing.Point(141, 19);
            this.txtnumeroDoc.Name = "txtnumeroDoc";
            this.txtnumeroDoc.Properties.Appearance.Options.UseTextOptions = true;
            this.txtnumeroDoc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtnumeroDoc.Properties.Mask.BeepOnError = true;
            this.txtnumeroDoc.Properties.Mask.EditMask = "\\d?{0,50}";
            this.txtnumeroDoc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtnumeroDoc.Properties.Mask.SaveLiteral = false;
            this.txtnumeroDoc.Properties.ReadOnly = true;
            this.txtnumeroDoc.Size = new System.Drawing.Size(191, 20);
            this.txtnumeroDoc.TabIndex = 0;
            this.txtnumeroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumeroDoc_KeyPress);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(20, 84);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(43, 13);
            this.lblestado.TabIndex = 72;
            this.lblestado.Text = "Estado:";
            // 
            // lblfechacad
            // 
            this.lblfechacad.AutoSize = true;
            this.lblfechacad.Location = new System.Drawing.Point(20, 51);
            this.lblfechacad.Name = "lblfechacad";
            this.lblfechacad.Size = new System.Drawing.Size(94, 13);
            this.lblfechacad.TabIndex = 73;
            this.lblfechacad.Text = "Fecha Caducidad:";
            // 
            // lblumdocumento
            // 
            this.lblumdocumento.AutoSize = true;
            this.lblumdocumento.Location = new System.Drawing.Point(20, 22);
            this.lblumdocumento.Name = "lblumdocumento";
            this.lblumdocumento.Size = new System.Drawing.Size(105, 13);
            this.lblumdocumento.TabIndex = 74;
            this.lblumdocumento.Text = "Numero Documento:";
            // 
            // chkUsado
            // 
            this.chkUsado.AutoSize = true;
            this.chkUsado.Location = new System.Drawing.Point(141, 112);
            this.chkUsado.Name = "chkUsado";
            this.chkUsado.Size = new System.Drawing.Size(35, 17);
            this.chkUsado.TabIndex = 3;
            this.chkUsado.Text = "Si";
            this.chkUsado.UseVisualStyleBackColor = true;
            // 
            // lblnumautorizacion
            // 
            this.lblnumautorizacion.AutoSize = true;
            this.lblnumautorizacion.Location = new System.Drawing.Point(22, 142);
            this.lblnumautorizacion.Name = "lblnumautorizacion";
            this.lblnumautorizacion.Size = new System.Drawing.Size(108, 13);
            this.lblnumautorizacion.TabIndex = 78;
            this.lblnumautorizacion.Text = "Numero Autorizacion:";
            // 
            // txtNumeroAut
            // 
            this.txtNumeroAut.Location = new System.Drawing.Point(141, 139);
            this.txtNumeroAut.Name = "txtNumeroAut";
            this.txtNumeroAut.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumeroAut.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumeroAut.Properties.Mask.BeepOnError = true;
            this.txtNumeroAut.Properties.Mask.EditMask = "\\d{0,37}";
            this.txtNumeroAut.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumeroAut.Properties.Mask.SaveLiteral = false;
            this.txtNumeroAut.Size = new System.Drawing.Size(263, 20);
            this.txtNumeroAut.TabIndex = 6;
            this.txtNumeroAut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroAut_KeyPress);
            // 
            // chkestado
            // 
            this.chkestado.AutoSize = true;
            this.chkestado.Location = new System.Drawing.Point(141, 84);
            this.chkestado.Name = "chkestado";
            this.chkestado.Size = new System.Drawing.Size(56, 17);
            this.chkestado.TabIndex = 2;
            this.chkestado.Text = "Activo";
            this.chkestado.UseVisualStyleBackColor = true;
            // 
            // dtFechaCad
            // 
            this.dtFechaCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaCad.Location = new System.Drawing.Point(141, 51);
            this.dtFechaCad.Name = "dtFechaCad";
            this.dtFechaCad.Size = new System.Drawing.Size(191, 20);
            this.dtFechaCad.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 450);
            this.panel3.TabIndex = 84;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkelectronica);
            this.splitContainer1.Panel1.Controls.Add(this.txtDocFinal);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtGenerar);
            this.splitContainer1.Panel1.Controls.Add(this.txtUltDoc);
            this.splitContainer1.Panel1.Controls.Add(this.ultraCmbE_TipoDoc);
            this.splitContainer1.Panel1.Controls.Add(this.txtEstablecimiento);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtpuntoEmision);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtNumeroAut);
            this.splitContainer1.Panel2.Controls.Add(this.lblumdocumento);
            this.splitContainer1.Panel2.Controls.Add(this.dtFechaCad);
            this.splitContainer1.Panel2.Controls.Add(this.lblusado);
            this.splitContainer1.Panel2.Controls.Add(this.chkUsado);
            this.splitContainer1.Panel2.Controls.Add(this.chkestado);
            this.splitContainer1.Panel2.Controls.Add(this.txtnumeroDoc);
            this.splitContainer1.Panel2.Controls.Add(this.lblfechacad);
            this.splitContainer1.Panel2.Controls.Add(this.lblnumautorizacion);
            this.splitContainer1.Panel2.Controls.Add(this.lblestado);
            this.splitContainer1.Size = new System.Drawing.Size(505, 450);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 0;
            // 
            // chkelectronica
            // 
            this.chkelectronica.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkelectronica.Location = new System.Drawing.Point(366, 49);
            this.chkelectronica.Name = "chkelectronica";
            this.chkelectronica.Size = new System.Drawing.Size(95, 76);
            this.chkelectronica.TabIndex = 5;
            this.chkelectronica.Text = "Es Documento Electrónico";
            this.chkelectronica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkelectronica.UseVisualStyleBackColor = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(505, 29);
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
            // FrmGe_Secuencia_Documento_Talonario_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(505, 479);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.txtFoco);
            this.Name = "FrmGe_Secuencia_Documento_Talonario_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipo y Secuencia por Documento";
            this.Load += new System.EventHandler(this.FrmGe_Secuencia_Documento_Talonario_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtpuntoEmision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstablecimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenerar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_TipoDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumeroDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroAut.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtpuntoEmision;
        private DevExpress.XtraEditors.TextEdit txtEstablecimiento;
        private DevExpress.XtraEditors.TextEdit txtUltDoc;
        private DevExpress.XtraEditors.TextEdit txtGenerar;
        private System.Windows.Forms.TextBox txtFoco;
        private DevExpress.XtraEditors.SearchLookUpEdit ultraCmbE_TipoDoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.TextEdit txtDocFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblusado;
        private DevExpress.XtraEditors.TextEdit txtnumeroDoc;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblfechacad;
        private System.Windows.Forms.Label lblumdocumento;
        private System.Windows.Forms.CheckBox chkUsado;
        private System.Windows.Forms.Label lblnumautorizacion;
        private DevExpress.XtraEditors.TextEdit txtNumeroAut;
        private System.Windows.Forms.CheckBox chkestado;
        private System.Windows.Forms.DateTimePicker dtFechaCad;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chkelectronica;
        private DevExpress.XtraGrid.Columns.GridColumn col_descripcion;
    }
}