namespace Core.Erp.Winform
{
    partial class FrmFa_PuntoVta_mant
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
            this.txtIdPuntoVta = new System.Windows.Forms.TextBox();
            this.lblIdPuntoVta = new System.Windows.Forms.Label();
            this.cmbSucursal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.txt_nom_PuntoVta = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.cmb_bodega = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label4 = new System.Windows.Forms.Label();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_bodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdPuntoVta
            // 
            this.txtIdPuntoVta.Location = new System.Drawing.Point(149, 51);
            this.txtIdPuntoVta.MaxLength = 15;
            this.txtIdPuntoVta.Name = "txtIdPuntoVta";
            this.txtIdPuntoVta.Size = new System.Drawing.Size(65, 20);
            this.txtIdPuntoVta.TabIndex = 11;
            // 
            // lblIdPuntoVta
            // 
            this.lblIdPuntoVta.AutoSize = true;
            this.lblIdPuntoVta.Location = new System.Drawing.Point(32, 54);
            this.lblIdPuntoVta.Name = "lblIdPuntoVta";
            this.lblIdPuntoVta.Size = new System.Drawing.Size(83, 13);
            this.lblIdPuntoVta.TabIndex = 12;
            this.lblIdPuntoVta.Text = "Punto de venta:";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.EditValue = "Mantenimiento de punto de venta";
            this.cmbSucursal.Location = new System.Drawing.Point(149, 77);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSucursal.Properties.DisplayMember = "Su_Descripcion2";
            this.cmbSucursal.Properties.ValueMember = "IdSucursal";
            this.cmbSucursal.Properties.View = this.searchLookUpEdit1View;
            this.cmbSucursal.Size = new System.Drawing.Size(246, 20);
            this.cmbSucursal.TabIndex = 10;
            this.cmbSucursal.EditValueChanged += new System.EventHandler(this.cmbSucursal_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdSucursal";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 71;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Sucursal";
            this.gridColumn2.FieldName = "Su_Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 1091;
            // 
            // lblEstado
            // 
            this.lblEstado.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblEstado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(261, 38);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(156, 33);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "**Anulado**";
            this.lblEstado.Visible = false;
            // 
            // txt_nom_PuntoVta
            // 
            this.txt_nom_PuntoVta.Location = new System.Drawing.Point(149, 155);
            this.txt_nom_PuntoVta.MaxLength = 150;
            this.txt_nom_PuntoVta.Name = "txt_nom_PuntoVta";
            this.txt_nom_PuntoVta.Size = new System.Drawing.Size(246, 20);
            this.txt_nom_PuntoVta.TabIndex = 2;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(149, 129);
            this.txt_codigo.MaxLength = 50;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sucursal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código punto emisión:";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(487, 31);
            this.ucGe_Menu.TabIndex = 3;
            this.ucGe_Menu.Visible_bntAnular = true;
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
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // cmb_bodega
            // 
            this.cmb_bodega.Location = new System.Drawing.Point(149, 103);
            this.cmb_bodega.Name = "cmb_bodega";
            this.cmb_bodega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_bodega.Properties.DisplayMember = "bo_Descripcion2";
            this.cmb_bodega.Properties.ValueMember = "IdBodega";
            this.cmb_bodega.Properties.View = this.gridView1;
            this.cmb_bodega.Size = new System.Drawing.Size(246, 20);
            this.cmb_bodega.TabIndex = 13;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bodega:";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Código";
            this.gridColumn3.FieldName = "cod_bodega";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 186;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Bodega";
            this.gridColumn4.FieldName = "bo_Descripcion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 902;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ID";
            this.gridColumn5.FieldName = "IdBodega";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 92;
            // 
            // FrmFa_PuntoVta_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 226);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_bodega);
            this.Controls.Add(this.txtIdPuntoVta);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.lblIdPuntoVta);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nom_PuntoVta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "FrmFa_PuntoVta_mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento punto de venta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFa_PuntoVta_mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmFa_PuntoVta_mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_bodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private System.Windows.Forms.TextBox txt_nom_PuntoVta;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.TextBox txtIdPuntoVta;
        private System.Windows.Forms.Label lblIdPuntoVta;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_bodega;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}