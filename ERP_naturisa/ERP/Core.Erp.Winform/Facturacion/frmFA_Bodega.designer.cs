namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Bodega
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
            this.lbl_id_sucursal = new System.Windows.Forms.Label();
            this.lbl_id_bodega = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_title_id_bodega = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_ctacble_Inv = new Core.Erp.Winform.Controles.UCCon_Plan_de_Cuenta_x_Movimiento();
            this.cmb_ctacble_costo = new Core.Erp.Winform.Controles.UCCon_Plan_de_Cuenta_x_Movimiento();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ucCon_CentroCosto_ctas_Movi = new Core.Erp.Winform.Controles.UCCon_CentroCosto_ctas_Movi();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPuntoEmi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_bodega = new DevExpress.XtraEditors.TextEdit();
            this.chk_estado = new DevExpress.XtraEditors.CheckEdit();
            this.chk_bodega = new DevExpress.XtraEditors.CheckEdit();
            this.chk_manejaFacturacion = new DevExpress.XtraEditors.CheckEdit();
            this.cmbEstadoAproba = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuntoEmi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_estado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_bodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_manejaFacturacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoAproba.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id_sucursal
            // 
            this.lbl_id_sucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_id_sucursal.Location = new System.Drawing.Point(295, 19);
            this.lbl_id_sucursal.Name = "lbl_id_sucursal";
            this.lbl_id_sucursal.Size = new System.Drawing.Size(63, 23);
            this.lbl_id_sucursal.TabIndex = 1;
            this.lbl_id_sucursal.Text = "0";
            this.lbl_id_sucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_id_sucursal.Visible = false;
            // 
            // lbl_id_bodega
            // 
            this.lbl_id_bodega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_id_bodega.Location = new System.Drawing.Point(189, 19);
            this.lbl_id_bodega.Name = "lbl_id_bodega";
            this.lbl_id_bodega.Size = new System.Drawing.Size(100, 23);
            this.lbl_id_bodega.TabIndex = 0;
            this.lbl_id_bodega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la Bodega:";
            // 
            // lbl_title_id_bodega
            // 
            this.lbl_title_id_bodega.AutoSize = true;
            this.lbl_title_id_bodega.Location = new System.Drawing.Point(18, 23);
            this.lbl_title_id_bodega.Name = "lbl_title_id_bodega";
            this.lbl_title_id_bodega.Size = new System.Drawing.Size(59, 13);
            this.lbl_title_id_bodega.TabIndex = 0;
            this.lbl_title_id_bodega.Text = "Id Bodega:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.ucCon_CentroCosto_ctas_Movi);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtPuntoEmi);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_bodega);
            this.panelControl1.Controls.Add(this.chk_estado);
            this.panelControl1.Controls.Add(this.chk_bodega);
            this.panelControl1.Controls.Add(this.chk_manejaFacturacion);
            this.panelControl1.Controls.Add(this.lbl_id_sucursal);
            this.panelControl1.Controls.Add(this.lbl_id_bodega);
            this.panelControl1.Controls.Add(this.lbl_title_id_bodega);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.cmbEstadoAproba);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(655, 298);
            this.panelControl1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.cmb_ctacble_Inv);
            this.groupBox1.Controls.Add(this.cmb_ctacble_costo);
            this.groupBox1.Location = new System.Drawing.Point(21, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 88);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuentas Contables";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(19, 66);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(80, 13);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Cta Cble. Costo:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(102, 13);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Cta Cble. Inventario:";
            // 
            // cmb_ctacble_Inv
            // 
            this.cmb_ctacble_Inv.Location = new System.Drawing.Point(143, 18);
            this.cmb_ctacble_Inv.Name = "cmb_ctacble_Inv";
            this.cmb_ctacble_Inv.Size = new System.Drawing.Size(438, 29);
            this.cmb_ctacble_Inv.TabIndex = 17;
            // 
            // cmb_ctacble_costo
            // 
            this.cmb_ctacble_costo.Location = new System.Drawing.Point(143, 50);
            this.cmb_ctacble_costo.Name = "cmb_ctacble_costo";
            this.cmb_ctacble_costo.Size = new System.Drawing.Size(438, 29);
            this.cmb_ctacble_costo.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 168);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(162, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Estado de Aprobación Inventario:";
            // 
            // ucCon_CentroCosto_ctas_Movi
            // 
            this.ucCon_CentroCosto_ctas_Movi.IdCentroCostoPadre = null;
            this.ucCon_CentroCosto_ctas_Movi.InfoCentroCosto = null;
            this.ucCon_CentroCosto_ctas_Movi.Location = new System.Drawing.Point(185, 127);
            this.ucCon_CentroCosto_ctas_Movi.Name = "ucCon_CentroCosto_ctas_Movi";
            this.ucCon_CentroCosto_ctas_Movi.Size = new System.Drawing.Size(297, 30);
            this.ucCon_CentroCosto_ctas_Movi.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 130);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Centro Costo:";
            // 
            // txtPuntoEmi
            // 
            this.txtPuntoEmi.Location = new System.Drawing.Point(189, 92);
            this.txtPuntoEmi.Name = "txtPuntoEmi";
            this.txtPuntoEmi.Properties.MaxLength = 3;
            this.txtPuntoEmi.Size = new System.Drawing.Size(100, 20);
            this.txtPuntoEmi.TabIndex = 10;
            this.txtPuntoEmi.Validating += new System.ComponentModel.CancelEventHandler(this.txtPuntoEmi_Validating);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 95);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Punto Emisión:";
            // 
            // txt_bodega
            // 
            this.txt_bodega.Location = new System.Drawing.Point(189, 59);
            this.txt_bodega.Name = "txt_bodega";
            this.txt_bodega.Size = new System.Drawing.Size(304, 20);
            this.txt_bodega.TabIndex = 8;
            // 
            // chk_estado
            // 
            this.chk_estado.Location = new System.Drawing.Point(527, 139);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Properties.Caption = "Activo";
            this.chk_estado.Size = new System.Drawing.Size(75, 19);
            this.chk_estado.TabIndex = 7;
            // 
            // chk_bodega
            // 
            this.chk_bodega.Location = new System.Drawing.Point(527, 114);
            this.chk_bodega.Name = "chk_bodega";
            this.chk_bodega.Properties.Caption = "Bodega";
            this.chk_bodega.Size = new System.Drawing.Size(75, 19);
            this.chk_bodega.TabIndex = 6;
            // 
            // chk_manejaFacturacion
            // 
            this.chk_manejaFacturacion.Location = new System.Drawing.Point(527, 89);
            this.chk_manejaFacturacion.Name = "chk_manejaFacturacion";
            this.chk_manejaFacturacion.Properties.Caption = "Maneja Facturación";
            this.chk_manejaFacturacion.Size = new System.Drawing.Size(121, 19);
            this.chk_manejaFacturacion.TabIndex = 5;
            // 
            // cmbEstadoAproba
            // 
            this.cmbEstadoAproba.Location = new System.Drawing.Point(189, 165);
            this.cmbEstadoAproba.Name = "cmbEstadoAproba";
            this.cmbEstadoAproba.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstadoAproba.Properties.DisplayMember = "Descripcion";
            this.cmbEstadoAproba.Properties.NullText = "";
            this.cmbEstadoAproba.Properties.PopupSizeable = false;
            this.cmbEstadoAproba.Properties.ValueMember = "IdEstadoAproba";
            this.cmbEstadoAproba.Properties.View = this.searchLookUpEdit1View;
            this.cmbEstadoAproba.Size = new System.Drawing.Size(169, 20);
            this.cmbEstadoAproba.TabIndex = 14;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id Estado";
            this.gridColumn1.FieldName = "IdEstadoAproba";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descripcion";
            this.gridColumn2.FieldName = "Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Estado";
            this.gridColumn3.FieldName = "estado";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.BackColor = System.Drawing.Color.White;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(655, 25);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
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
            // frmFa_Bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 323);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.MaximizeBox = false;
            this.Name = "frmFa_Bodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Bodega";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFA_Bodega_FormClosing);
            this.Load += new System.EventHandler(this.frmFA_PVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuntoEmi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_estado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_bodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_manejaFacturacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoAproba.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_title_id_bodega;
        private System.Windows.Forms.Label lbl_id_bodega;
        public System.Windows.Forms.Label lbl_id_sucursal;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckEdit chk_estado;
        private DevExpress.XtraEditors.CheckEdit chk_bodega;
        private DevExpress.XtraEditors.CheckEdit chk_manejaFacturacion;
        private DevExpress.XtraEditors.TextEdit txt_bodega;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPuntoEmi;
        private Controles.UCCon_CentroCosto_ctas_Movi ucCon_CentroCosto_ctas_Movi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEstadoAproba;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Controles.UCCon_Plan_de_Cuenta_x_Movimiento cmb_ctacble_Inv;
        private Controles.UCCon_Plan_de_Cuenta_x_Movimiento cmb_ctacble_costo;
    }
}