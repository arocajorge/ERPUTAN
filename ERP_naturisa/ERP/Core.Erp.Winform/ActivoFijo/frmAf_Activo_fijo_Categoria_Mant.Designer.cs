namespace Core.Erp.Winform.ActivoFijo
{
    partial class frmAf_Activo_fijo_Categoria_Mant
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_tipoAF = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdActivoFijoTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAf_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu_Superior = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipoAF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblAnulado);
            this.panelMain.Controls.Add(this.chkEstado);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.cmb_tipoAF);
            this.panelMain.Controls.Add(this.txtDescripcion);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.txtCodigo);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.txtId);
            this.panelMain.Controls.Add(this.lblId);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(495, 174);
            this.panelMain.TabIndex = 2;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(137, 134);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(136, 20);
            this.lblAnulado.TabIndex = 9;
            this.lblAnulado.Text = "***ANULADO***";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(403, 134);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 8;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo De Activo:";
            // 
            // cmb_tipoAF
            // 
            this.cmb_tipoAF.Location = new System.Drawing.Point(117, 60);
            this.cmb_tipoAF.Name = "cmb_tipoAF";
            this.cmb_tipoAF.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipoAF.Properties.DisplayMember = "Af_Descripcion2";
            this.cmb_tipoAF.Properties.ValueMember = "IdActivoFijoTipo";
            this.cmb_tipoAF.Properties.View = this.searchLookUpEdit1View;
            this.cmb_tipoAF.Size = new System.Drawing.Size(366, 20);
            this.cmb_tipoAF.TabIndex = 6;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdActivoFijoTipo,
            this.colAf_Descripcion,
            this.colEstado});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdActivoFijoTipo
            // 
            this.colIdActivoFijoTipo.Caption = "IdActivoFijoTipo";
            this.colIdActivoFijoTipo.FieldName = "IdActivoFijoTipo";
            this.colIdActivoFijoTipo.Name = "colIdActivoFijoTipo";
            this.colIdActivoFijoTipo.Visible = true;
            this.colIdActivoFijoTipo.VisibleIndex = 0;
            this.colIdActivoFijoTipo.Width = 145;
            // 
            // colAf_Descripcion
            // 
            this.colAf_Descripcion.Caption = "Descripcion";
            this.colAf_Descripcion.FieldName = "Af_Descripcion";
            this.colAf_Descripcion.Name = "colAf_Descripcion";
            this.colAf_Descripcion.Visible = true;
            this.colAf_Descripcion.VisibleIndex = 1;
            this.colAf_Descripcion.Width = 849;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 2;
            this.colEstado.Width = 186;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(117, 96);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(366, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(352, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(131, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(118, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "0";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // BarraEstado
            // 
            this.BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraEstado.Location = new System.Drawing.Point(0, 203);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(495, 26);
            this.BarraEstado.TabIndex = 1;
            // 
            // ucGe_Menu_Superior
            // 
            this.ucGe_Menu_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior.Name = "ucGe_Menu_Superior";
            this.ucGe_Menu_Superior.Size = new System.Drawing.Size(495, 29);
            this.ucGe_Menu_Superior.TabIndex = 0;
            this.ucGe_Menu_Superior.Visible_bntAnular = true;
            this.ucGe_Menu_Superior.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior.Visible_bntLimpiar = true;
            this.ucGe_Menu_Superior.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior.Visible_bntSalir = true;
            this.ucGe_Menu_Superior.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior.Visible_btnproductos = false;
            this.ucGe_Menu_Superior.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_Superior_event_btnGuardar_Click);
            this.ucGe_Menu_Superior.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_Superior_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu_Superior.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_Superior_event_btnlimpiar_Click);
            this.ucGe_Menu_Superior.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_Superior_event_btnAnular_Click);
            this.ucGe_Menu_Superior.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_event_btnSalir_Click);
            // 
            // frmAf_Activo_fijo_Categoria_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 229);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.ucGe_Menu_Superior);
            this.Name = "frmAf_Activo_fijo_Categoria_Mant";
            this.Text = "frmAf_Activo_fijo_Categoria_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAf_Activo_fijo_Categoria_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmAf_Activo_fijo_Categoria_Mant_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipoAF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior;
        private Controles.UCGe_BarraEstadoInferior_Forms BarraEstado;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_tipoAF;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdActivoFijoTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colAf_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
    }
}