namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_MantCodigoSRI
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txt_retencion = new DevExpress.XtraEditors.TextEdit();
            this.cmb_tipCodSRI = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoSRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_estado = new DevExpress.XtraEditors.CheckEdit();
            this.ucCtaCble = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.dtp_valiHasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_valiDesde = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cod_base = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cod_SRI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_retencion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipCodSRI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_estado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txt_retencion);
            this.panelControl1.Controls.Add(this.cmb_tipCodSRI);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.chk_estado);
            this.panelControl1.Controls.Add(this.ucCtaCble);
            this.panelControl1.Controls.Add(this.lblAnulado);
            this.panelControl1.Controls.Add(this.dtp_valiHasta);
            this.panelControl1.Controls.Add(this.dtp_valiDesde);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.label9);
            this.panelControl1.Controls.Add(this.txt_descripcion);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txt_cod_base);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.txt_cod_SRI);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txt_id);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(563, 334);
            this.panelControl1.TabIndex = 2;
            // 
            // txt_retencion
            // 
            this.txt_retencion.Location = new System.Drawing.Point(117, 186);
            this.txt_retencion.Name = "txt_retencion";
            this.txt_retencion.Properties.Mask.EditMask = "f";
            this.txt_retencion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_retencion.Size = new System.Drawing.Size(100, 20);
            this.txt_retencion.TabIndex = 158;
            // 
            // cmb_tipCodSRI
            // 
            this.cmb_tipCodSRI.Location = new System.Drawing.Point(117, 53);
            this.cmb_tipCodSRI.Name = "cmb_tipCodSRI";
            this.cmb_tipCodSRI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipCodSRI.Properties.DisplayMember = "descripcion";
            this.cmb_tipCodSRI.Properties.ValueMember = "IdTipoSRI";
            this.cmb_tipCodSRI.Properties.View = this.searchLookUpEdit1View;
            this.cmb_tipCodSRI.Size = new System.Drawing.Size(204, 20);
            this.cmb_tipCodSRI.TabIndex = 157;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoSRI,
            this.coldescripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTipoSRI
            // 
            this.colIdTipoSRI.Caption = "Id";
            this.colIdTipoSRI.FieldName = "IdTipoSRI";
            this.colIdTipoSRI.Name = "colIdTipoSRI";
            this.colIdTipoSRI.Visible = true;
            this.colIdTipoSRI.VisibleIndex = 0;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(22, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 156;
            this.label6.Text = "Cuenta Contable:";
            // 
            // chk_estado
            // 
            this.chk_estado.Location = new System.Drawing.Point(389, 301);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Properties.Caption = "Activo";
            this.chk_estado.Size = new System.Drawing.Size(75, 19);
            this.chk_estado.TabIndex = 155;
            // 
            // ucCtaCble
            // 
            this.ucCtaCble.Location = new System.Drawing.Point(112, 269);
            this.ucCtaCble.Name = "ucCtaCble";
            this.ucCtaCble.Size = new System.Drawing.Size(443, 26);
            this.ucCtaCble.TabIndex = 154;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(262, 20);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(115, 15);
            this.lblAnulado.TabIndex = 153;
            this.lblAnulado.Text = "*** ANULADO ***";
            this.lblAnulado.Visible = false;
            // 
            // dtp_valiHasta
            // 
            this.dtp_valiHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_valiHasta.Location = new System.Drawing.Point(115, 243);
            this.dtp_valiHasta.Name = "dtp_valiHasta";
            this.dtp_valiHasta.Size = new System.Drawing.Size(206, 20);
            this.dtp_valiHasta.TabIndex = 147;
            // 
            // dtp_valiDesde
            // 
            this.dtp_valiDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_valiDesde.Location = new System.Drawing.Point(115, 217);
            this.dtp_valiDesde.Name = "dtp_valiDesde";
            this.dtp_valiDesde.Size = new System.Drawing.Size(206, 20);
            this.dtp_valiDesde.TabIndex = 145;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(22, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 151;
            this.label7.Text = "Valido hasta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(22, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 150;
            this.label8.Text = "Valido desde:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(22, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 149;
            this.label9.Text = "% Retención:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(115, 139);
            this.txt_descripcion.MaxLength = 150;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(440, 44);
            this.txt_descripcion.TabIndex = 144;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(22, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 148;
            this.label4.Text = "Descripción:";
            // 
            // txt_cod_base
            // 
            this.txt_cod_base.Location = new System.Drawing.Point(115, 110);
            this.txt_cod_base.MaxLength = 20;
            this.txt_cod_base.Name = "txt_cod_base";
            this.txt_cod_base.Size = new System.Drawing.Size(206, 20);
            this.txt_cod_base.TabIndex = 142;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(22, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 146;
            this.label5.Text = "Cod. Base:";
            // 
            // txt_cod_SRI
            // 
            this.txt_cod_SRI.Location = new System.Drawing.Point(115, 83);
            this.txt_cod_SRI.MaxLength = 20;
            this.txt_cod_SRI.Name = "txt_cod_SRI";
            this.txt_cod_SRI.Size = new System.Drawing.Size(206, 20);
            this.txt_cod_SRI.TabIndex = 141;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(22, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 143;
            this.label3.Text = "Cod. SRI:";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(117, 19);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(55, 20);
            this.txt_id.TabIndex = 140;
            this.txt_id.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 139;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 137;
            this.label1.Text = "Tipo Codigo SRI:";
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 363);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(563, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(563, 29);
            this.ucGe_Menu.TabIndex = 0;
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
            this.ucGe_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_event_btnlimpiar_Click_1);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // frmCP_MantCodigoSRI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 389);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCP_MantCodigoSRI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Codigo SRI";
            this.Load += new System.EventHandler(this.frmCP_MantCodigo_SRI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_retencion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipCodSRI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_estado.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controles.UCCon_PlanCtaCmb ucCtaCble;
        private System.Windows.Forms.Label lblAnulado;
      //  private Infragistics.Win.UltraWinEditors.UltraNumericEditor txt_retencion;
        private System.Windows.Forms.DateTimePicker dtp_valiHasta;
        private System.Windows.Forms.DateTimePicker dtp_valiDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cod_base;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cod_SRI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit chk_estado;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_tipCodSRI;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoSRI;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.TextEdit txt_retencion;


    }
}