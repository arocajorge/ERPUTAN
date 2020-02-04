namespace Core.Erp.Winform.Caja
{
    partial class FrmCa_Caja_Talonario_Recibo_Mant
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
            this.lbl_doc_inicial = new System.Windows.Forms.Label();
            this.lbl_a_generar = new System.Windows.Forms.Label();
            this.txt_doc_inicial = new DevExpress.XtraEditors.TextEdit();
            this.txt_cantidad_generar = new DevExpress.XtraEditors.TextEdit();
            this.lbl_doc_final = new System.Windows.Forms.Label();
            this.txt_doc_final = new DevExpress.XtraEditors.TextEdit();
            this.cmb_puntoVta = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmb_sucursal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_idRecibo = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_usado = new System.Windows.Forms.CheckBox();
            this.chk_activo = new System.Windows.Forms.CheckBox();
            this.cmb_TipoDoc = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tipodocumento = new System.Windows.Forms.Label();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Idsucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Su_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdPuntoVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cod_PuntoVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_PuntoVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_inicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_generar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_final.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_puntoVta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idRecibo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_TipoDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sucursal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Punto Emision:";
            // 
            // lbl_doc_inicial
            // 
            this.lbl_doc_inicial.AutoSize = true;
            this.lbl_doc_inicial.Location = new System.Drawing.Point(29, 159);
            this.lbl_doc_inicial.Name = "lbl_doc_inicial";
            this.lbl_doc_inicial.Size = new System.Drawing.Size(63, 13);
            this.lbl_doc_inicial.TabIndex = 7;
            this.lbl_doc_inicial.Text = "Dcto Inicial:";
            // 
            // lbl_a_generar
            // 
            this.lbl_a_generar.AutoSize = true;
            this.lbl_a_generar.Location = new System.Drawing.Point(29, 194);
            this.lbl_a_generar.Name = "lbl_a_generar";
            this.lbl_a_generar.Size = new System.Drawing.Size(97, 13);
            this.lbl_a_generar.TabIndex = 8;
            this.lbl_a_generar.Text = "Recibos a generar:";
            // 
            // txt_doc_inicial
            // 
            this.txt_doc_inicial.Location = new System.Drawing.Point(127, 156);
            this.txt_doc_inicial.Name = "txt_doc_inicial";
            this.txt_doc_inicial.Size = new System.Drawing.Size(119, 20);
            this.txt_doc_inicial.TabIndex = 10;
            this.txt_doc_inicial.EditValueChanged += new System.EventHandler(this.txt_doc_inicial_EditValueChanged);
            // 
            // txt_cantidad_generar
            // 
            this.txt_cantidad_generar.Location = new System.Drawing.Point(127, 187);
            this.txt_cantidad_generar.Name = "txt_cantidad_generar";
            this.txt_cantidad_generar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_cantidad_generar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_cantidad_generar.Size = new System.Drawing.Size(119, 20);
            this.txt_cantidad_generar.TabIndex = 11;
            this.txt_cantidad_generar.EditValueChanged += new System.EventHandler(this.txt_cantidad_generar_EditValueChanged);
            // 
            // lbl_doc_final
            // 
            this.lbl_doc_final.AutoSize = true;
            this.lbl_doc_final.Location = new System.Drawing.Point(29, 228);
            this.lbl_doc_final.Name = "lbl_doc_final";
            this.lbl_doc_final.Size = new System.Drawing.Size(61, 13);
            this.lbl_doc_final.TabIndex = 12;
            this.lbl_doc_final.Text = "Dcto. Final:";
            // 
            // txt_doc_final
            // 
            this.txt_doc_final.Location = new System.Drawing.Point(127, 221);
            this.txt_doc_final.Name = "txt_doc_final";
            this.txt_doc_final.Properties.ReadOnly = true;
            this.txt_doc_final.Size = new System.Drawing.Size(119, 20);
            this.txt_doc_final.TabIndex = 13;
            // 
            // cmb_puntoVta
            // 
            this.cmb_puntoVta.Location = new System.Drawing.Point(127, 97);
            this.cmb_puntoVta.Name = "cmb_puntoVta";
            this.cmb_puntoVta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_puntoVta.Properties.DisplayMember = "nom_PuntoVta";
            this.cmb_puntoVta.Properties.ValueMember = "IdPuntoVta";
            this.cmb_puntoVta.Properties.View = this.gridView1;
            this.cmb_puntoVta.Size = new System.Drawing.Size(193, 20);
            this.cmb_puntoVta.TabIndex = 15;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdPuntoVta,
            this.col_cod_PuntoVta,
            this.col_nom_PuntoVta});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cmb_sucursal
            // 
            this.cmb_sucursal.Location = new System.Drawing.Point(127, 71);
            this.cmb_sucursal.Name = "cmb_sucursal";
            this.cmb_sucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_sucursal.Properties.DisplayMember = "Su_Descripcion";
            this.cmb_sucursal.Properties.ValueMember = "IdSucursal";
            this.cmb_sucursal.Properties.View = this.gridView2;
            this.cmb_sucursal.Size = new System.Drawing.Size(193, 20);
            this.cmb_sucursal.TabIndex = 16;
            this.cmb_sucursal.EditValueChanged += new System.EventHandler(this.cmb_sucursal_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Idsucursal,
            this.col_Su_Descripcion});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // txt_idRecibo
            // 
            this.txt_idRecibo.Location = new System.Drawing.Point(127, 44);
            this.txt_idRecibo.Name = "txt_idRecibo";
            this.txt_idRecibo.Properties.ReadOnly = true;
            this.txt_idRecibo.Size = new System.Drawing.Size(87, 20);
            this.txt_idRecibo.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Id Recibo:";
            // 
            // chk_usado
            // 
            this.chk_usado.AutoSize = true;
            this.chk_usado.Location = new System.Drawing.Point(329, 240);
            this.chk_usado.Name = "chk_usado";
            this.chk_usado.Size = new System.Drawing.Size(57, 17);
            this.chk_usado.TabIndex = 19;
            this.chk_usado.Text = "Usado";
            this.chk_usado.UseVisualStyleBackColor = true;
            // 
            // chk_activo
            // 
            this.chk_activo.AutoSize = true;
            this.chk_activo.Checked = true;
            this.chk_activo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_activo.Location = new System.Drawing.Point(264, 240);
            this.chk_activo.Name = "chk_activo";
            this.chk_activo.Size = new System.Drawing.Size(56, 17);
            this.chk_activo.TabIndex = 20;
            this.chk_activo.Text = "Activo";
            this.chk_activo.UseVisualStyleBackColor = true;
            // 
            // cmb_TipoDoc
            // 
            this.cmb_TipoDoc.Location = new System.Drawing.Point(127, 124);
            this.cmb_TipoDoc.Name = "cmb_TipoDoc";
            this.cmb_TipoDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_TipoDoc.Properties.DisplayMember = "nom_Catalogo_cj";
            this.cmb_TipoDoc.Properties.ValueMember = "IdCatalogo_cj";
            this.cmb_TipoDoc.Properties.View = this.gridView3;
            this.cmb_TipoDoc.Size = new System.Drawing.Size(193, 20);
            this.cmb_TipoDoc.TabIndex = 22;
            this.cmb_TipoDoc.EditValueChanged += new System.EventHandler(this.cmb_TipoDoc_EditValueChanged);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // Tipodocumento
            // 
            this.Tipodocumento.AutoSize = true;
            this.Tipodocumento.Location = new System.Drawing.Point(29, 127);
            this.Tipodocumento.Name = "Tipodocumento";
            this.Tipodocumento.Size = new System.Drawing.Size(89, 13);
            this.Tipodocumento.TabIndex = 21;
            this.Tipodocumento.Text = "Tipo Documento:";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IdCatalogo";
            this.gridColumn1.FieldName = "IdCatalogo_cj";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 89;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre ";
            this.gridColumn2.FieldName = "nom_Catalogo_cj";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 1085;
            // 
            // col_Idsucursal
            // 
            this.col_Idsucursal.Caption = "IdSucursal";
            this.col_Idsucursal.FieldName = "IdSucursal";
            this.col_Idsucursal.Name = "col_Idsucursal";
            this.col_Idsucursal.Visible = true;
            this.col_Idsucursal.VisibleIndex = 0;
            this.col_Idsucursal.Width = 81;
            // 
            // col_Su_Descripcion
            // 
            this.col_Su_Descripcion.Caption = "Descripción";
            this.col_Su_Descripcion.FieldName = "Su_Descripcion";
            this.col_Su_Descripcion.Name = "col_Su_Descripcion";
            this.col_Su_Descripcion.Visible = true;
            this.col_Su_Descripcion.VisibleIndex = 1;
            this.col_Su_Descripcion.Width = 1089;
            // 
            // col_IdPuntoVta
            // 
            this.col_IdPuntoVta.Caption = "IdPuntoVta";
            this.col_IdPuntoVta.FieldName = "IdPuntoVta";
            this.col_IdPuntoVta.Name = "col_IdPuntoVta";
            this.col_IdPuntoVta.Visible = true;
            this.col_IdPuntoVta.VisibleIndex = 0;
            this.col_IdPuntoVta.Width = 82;
            // 
            // col_cod_PuntoVta
            // 
            this.col_cod_PuntoVta.Caption = "Código";
            this.col_cod_PuntoVta.FieldName = "cod_PuntoVta";
            this.col_cod_PuntoVta.Name = "col_cod_PuntoVta";
            this.col_cod_PuntoVta.Visible = true;
            this.col_cod_PuntoVta.VisibleIndex = 1;
            this.col_cod_PuntoVta.Width = 62;
            // 
            // col_nom_PuntoVta
            // 
            this.col_nom_PuntoVta.Caption = "Punto de Venta";
            this.col_nom_PuntoVta.FieldName = "nom_PuntoVta";
            this.col_nom_PuntoVta.Name = "col_nom_PuntoVta";
            this.col_nom_PuntoVta.Visible = true;
            this.col_nom_PuntoVta.VisibleIndex = 2;
            this.col_nom_PuntoVta.Width = 1026;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(398, 29);
            this.ucGe_Menu.TabIndex = 1;
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
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_event_btnlimpiar_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // FrmCa_Caja_Talonario_Recibo_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 269);
            this.Controls.Add(this.cmb_TipoDoc);
            this.Controls.Add(this.Tipodocumento);
            this.Controls.Add(this.chk_activo);
            this.Controls.Add(this.chk_usado);
            this.Controls.Add(this.txt_idRecibo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_sucursal);
            this.Controls.Add(this.cmb_puntoVta);
            this.Controls.Add(this.txt_doc_final);
            this.Controls.Add(this.lbl_doc_final);
            this.Controls.Add(this.txt_cantidad_generar);
            this.Controls.Add(this.txt_doc_inicial);
            this.Controls.Add(this.lbl_a_generar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_doc_inicial);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmCa_Caja_Talonario_Recibo_Mant";
            this.Text = "FrmCa_Caja_Talonario_Recibo_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCa_Caja_Talonario_Recibo_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmCa_Caja_Talonario_Recibo_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_inicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_generar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_final.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_puntoVta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idRecibo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_TipoDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_doc_inicial;
        private System.Windows.Forms.Label lbl_a_generar;
        private DevExpress.XtraEditors.TextEdit txt_doc_inicial;
        private DevExpress.XtraEditors.TextEdit txt_cantidad_generar;
        private System.Windows.Forms.Label lbl_doc_final;
        private DevExpress.XtraEditors.TextEdit txt_doc_final;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_puntoVta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_sucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn col_Idsucursal;
        private DevExpress.XtraGrid.Columns.GridColumn col_Su_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdPuntoVta;
        private DevExpress.XtraGrid.Columns.GridColumn col_cod_PuntoVta;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_PuntoVta;
        private DevExpress.XtraEditors.TextEdit txt_idRecibo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_usado;
        private System.Windows.Forms.CheckBox chk_activo;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_TipoDoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Label Tipodocumento;
    }
}