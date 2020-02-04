namespace Core.Erp.Winform.General
{
    partial class FrmGe_Impuesto_Mant
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_plan_cta = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.cmb_tipo_impuesto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoImpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_tipoImpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_codigo_sri = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCodigo_SRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigoSRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_porRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_porcentaje = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_usado_compra = new System.Windows.Forms.CheckBox();
            this.chk_usado_vta = new System.Windows.Forms.CheckBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_impuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_codigo_sri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcentaje.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(777, 29);
            this.ucGe_Menu.TabIndex = 51;
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
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(777, 22);
            this.statusStrip1.TabIndex = 52;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmb_plan_cta);
            this.panel1.Controls.Add(this.cmb_tipo_impuesto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_codigo_sri);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_porcentaje);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chk_usado_compra);
            this.panel1.Controls.Add(this.chk_usado_vta);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_codigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 343);
            this.panel1.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cta. Cble X Vtas.";
            // 
            // cmb_plan_cta
            // 
            this.cmb_plan_cta.Location = new System.Drawing.Point(269, 184);
            this.cmb_plan_cta.Name = "cmb_plan_cta";
            this.cmb_plan_cta.Size = new System.Drawing.Size(395, 26);
            this.cmb_plan_cta.TabIndex = 12;
            // 
            // cmb_tipo_impuesto
            // 
            this.cmb_tipo_impuesto.Location = new System.Drawing.Point(140, 6);
            this.cmb_tipo_impuesto.Name = "cmb_tipo_impuesto";
            this.cmb_tipo_impuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipo_impuesto.Properties.DisplayMember = "nom_tipoImpuesto";
            this.cmb_tipo_impuesto.Properties.ValueMember = "IdTipoImpuesto";
            this.cmb_tipo_impuesto.Properties.View = this.gridView1;
            this.cmb_tipo_impuesto.Size = new System.Drawing.Size(343, 20);
            this.cmb_tipo_impuesto.TabIndex = 11;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoImpuesto,
            this.colnom_tipoImpuesto});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTipoImpuesto
            // 
            this.colIdTipoImpuesto.Caption = "IdTipoImpuesto";
            this.colIdTipoImpuesto.FieldName = "IdTipoImpuesto";
            this.colIdTipoImpuesto.Name = "colIdTipoImpuesto";
            this.colIdTipoImpuesto.Visible = true;
            this.colIdTipoImpuesto.VisibleIndex = 0;
            this.colIdTipoImpuesto.Width = 289;
            // 
            // colnom_tipoImpuesto
            // 
            this.colnom_tipoImpuesto.Caption = "Tipo Impuesto";
            this.colnom_tipoImpuesto.FieldName = "nom_tipoImpuesto";
            this.colnom_tipoImpuesto.Name = "colnom_tipoImpuesto";
            this.colnom_tipoImpuesto.Visible = true;
            this.colnom_tipoImpuesto.VisibleIndex = 1;
            this.colnom_tipoImpuesto.Width = 567;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Impuesto:";
            // 
            // cmb_codigo_sri
            // 
            this.cmb_codigo_sri.Location = new System.Drawing.Point(156, 280);
            this.cmb_codigo_sri.Name = "cmb_codigo_sri";
            this.cmb_codigo_sri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_codigo_sri.Properties.DisplayMember = "co_descripcion";
            this.cmb_codigo_sri.Properties.ValueMember = "IdCodigo_SRI";
            this.cmb_codigo_sri.Properties.View = this.searchLookUpEdit1View;
            this.cmb_codigo_sri.Size = new System.Drawing.Size(396, 20);
            this.cmb_codigo_sri.TabIndex = 9;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCodigo_SRI,
            this.colcodigoSRI,
            this.colco_descripcion,
            this.colco_porRetencion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCodigo_SRI
            // 
            this.colIdCodigo_SRI.Caption = "IdCodigo_SRI";
            this.colIdCodigo_SRI.FieldName = "IdCodigo_SRI";
            this.colIdCodigo_SRI.Name = "colIdCodigo_SRI";
            this.colIdCodigo_SRI.Visible = true;
            this.colIdCodigo_SRI.VisibleIndex = 0;
            this.colIdCodigo_SRI.Width = 136;
            // 
            // colcodigoSRI
            // 
            this.colcodigoSRI.Caption = "codigoSRI";
            this.colcodigoSRI.FieldName = "codigoSRI";
            this.colcodigoSRI.Name = "colcodigoSRI";
            this.colcodigoSRI.Visible = true;
            this.colcodigoSRI.VisibleIndex = 2;
            this.colcodigoSRI.Width = 164;
            // 
            // colco_descripcion
            // 
            this.colco_descripcion.Caption = "Descripcion";
            this.colco_descripcion.FieldName = "co_descripcion";
            this.colco_descripcion.Name = "colco_descripcion";
            this.colco_descripcion.Visible = true;
            this.colco_descripcion.VisibleIndex = 1;
            this.colco_descripcion.Width = 391;
            // 
            // colco_porRetencion
            // 
            this.colco_porRetencion.Caption = "%Retencion";
            this.colco_porRetencion.FieldName = "co_porRetencion";
            this.colco_porRetencion.Name = "colco_porRetencion";
            this.colco_porRetencion.Visible = true;
            this.colco_porRetencion.VisibleIndex = 3;
            this.colco_porRetencion.Width = 165;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Codigo SRI";
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.Location = new System.Drawing.Point(191, 130);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Properties.Mask.EditMask = "d";
            this.txt_porcentaje.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_porcentaje.Size = new System.Drawing.Size(100, 20);
            this.txt_porcentaje.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Porcentaje:";
            // 
            // chk_usado_compra
            // 
            this.chk_usado_compra.AutoSize = true;
            this.chk_usado_compra.Location = new System.Drawing.Point(45, 230);
            this.chk_usado_compra.Name = "chk_usado_compra";
            this.chk_usado_compra.Size = new System.Drawing.Size(125, 17);
            this.chk_usado_compra.TabIndex = 5;
            this.chk_usado_compra.Text = "Usado para Compras";
            this.chk_usado_compra.UseVisualStyleBackColor = true;
            // 
            // chk_usado_vta
            // 
            this.chk_usado_vta.AutoSize = true;
            this.chk_usado_vta.Location = new System.Drawing.Point(42, 192);
            this.chk_usado_vta.Name = "chk_usado_vta";
            this.chk_usado_vta.Size = new System.Drawing.Size(117, 17);
            this.chk_usado_vta.TabIndex = 4;
            this.chk_usado_vta.Text = "Usado para Ventas";
            this.chk_usado_vta.UseVisualStyleBackColor = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(140, 87);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(395, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(140, 61);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(121, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // FrmGe_Impuesto_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmGe_Impuesto_Mant";
            this.Text = "Mantenimiento de Impuesto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGe_Impuesto_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmGe_Impuesto_Mant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_impuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_codigo_sri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcentaje.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_tipo_impuesto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_codigo_sri;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_porcentaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_usado_compra;
        private System.Windows.Forms.CheckBox chk_usado_vta;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Controles.UCCon_PlanCtaCmb cmb_plan_cta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoImpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_tipoImpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCodigo_SRI;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigoSRI;
        private DevExpress.XtraGrid.Columns.GridColumn colco_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colco_porRetencion;
    }
}