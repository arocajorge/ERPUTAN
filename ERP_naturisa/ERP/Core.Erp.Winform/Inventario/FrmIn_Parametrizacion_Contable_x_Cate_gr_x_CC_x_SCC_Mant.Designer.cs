namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant
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
            this.ucin_cat_lin_gr_sgr = new Core.Erp.Winform.Controles.ucIn_Linea_Grup_SubGr();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucct_plancta = new Core.Erp.Winform.Controles.UCCon_Plan_de_Cuenta_x_Movimiento();
            this.label3 = new System.Windows.Forms.Label();
            this.ucIn_ProductoCmb1 = new Core.Erp.Winform.Controles.UCIn_ProductoCmb();
            this.cmbCentroCosto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbSubcentroCosto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubcentroCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucin_cat_lin_gr_sgr
            // 
            this.ucin_cat_lin_gr_sgr.Location = new System.Drawing.Point(3, 86);
            this.ucin_cat_lin_gr_sgr.Margin = new System.Windows.Forms.Padding(5);
            this.ucin_cat_lin_gr_sgr.Name = "ucin_cat_lin_gr_sgr";
            this.ucin_cat_lin_gr_sgr.Size = new System.Drawing.Size(696, 150);
            this.ucin_cat_lin_gr_sgr.SubGrupoInfo = null;
            this.ucin_cat_lin_gr_sgr.TabIndex = 0;
            this.ucin_cat_lin_gr_sgr.Visible_Todos_cmb_Categoria = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(792, 36);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bntAnular = false;
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
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 379);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(792, 32);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 2;
            // 
            // ucct_plancta
            // 
            this.ucct_plancta.Location = new System.Drawing.Point(135, 295);
            this.ucct_plancta.Margin = new System.Windows.Forms.Padding(5);
            this.ucct_plancta.Name = "ucct_plancta";
            this.ucct_plancta.Size = new System.Drawing.Size(615, 36);
            this.ucct_plancta.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cuenta Contable:";
            // 
            // ucIn_ProductoCmb1
            // 
            this.ucIn_ProductoCmb1.Location = new System.Drawing.Point(21, 39);
            this.ucIn_ProductoCmb1.Margin = new System.Windows.Forms.Padding(5);
            this.ucIn_ProductoCmb1.Name = "ucIn_ProductoCmb1";
            this.ucIn_ProductoCmb1.Size = new System.Drawing.Size(737, 32);
            this.ucIn_ProductoCmb1.TabIndex = 10;
            this.ucIn_ProductoCmb1.event_cmb_producto_EditValueChanged += new Core.Erp.Winform.Controles.UCIn_ProductoCmb.delegate_cmb_producto_EditValueChanged(this.ucIn_ProductoCmb1_event_cmb_producto_EditValueChanged);
            // 
            // cmbCentroCosto
            // 
            this.cmbCentroCosto.Location = new System.Drawing.Point(189, 232);
            this.cmbCentroCosto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCentroCosto.Name = "cmbCentroCosto";
            this.cmbCentroCosto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCentroCosto.Properties.DisplayMember = "Centro_costo2";
            this.cmbCentroCosto.Properties.ValueMember = "IdCentroCosto";
            this.cmbCentroCosto.Properties.View = this.gridView4;
            this.cmbCentroCosto.Size = new System.Drawing.Size(501, 22);
            this.cmbCentroCosto.TabIndex = 110;
            this.cmbCentroCosto.EditValueChanged += new System.EventHandler(this.cmbCentroCosto_EditValueChanged);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Centro de costo";
            this.gridColumn3.FieldName = "Centro_costo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 1118;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID";
            this.gridColumn4.FieldName = "IdCentroCosto";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 153;
            // 
            // cmbSubcentroCosto
            // 
            this.cmbSubcentroCosto.Location = new System.Drawing.Point(189, 262);
            this.cmbSubcentroCosto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSubcentroCosto.Name = "cmbSubcentroCosto";
            this.cmbSubcentroCosto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSubcentroCosto.Properties.DisplayMember = "Centro_costo2";
            this.cmbSubcentroCosto.Properties.ValueMember = "IdCentroCosto_sub_centro_costo";
            this.cmbSubcentroCosto.Properties.View = this.gridView1;
            this.cmbSubcentroCosto.Size = new System.Drawing.Size(501, 22);
            this.cmbSubcentroCosto.TabIndex = 111;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sub centro de costo";
            this.gridColumn1.FieldName = "Centro_costo2";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 1082;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "IdCentroCosto_sub_centro_costo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 189;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 112;
            this.label1.Text = "Centro de costo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 113;
            this.label2.Text = "Subcentro de costo:";
            // 
            // FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSubcentroCosto);
            this.Controls.Add(this.cmbCentroCosto);
            this.Controls.Add(this.ucIn_ProductoCmb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ucct_plancta);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucin_cat_lin_gr_sgr);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametrización contable de categoria, linea, grupo, subgrupo, centro y subcentro" +
    " de costo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant_FormClosed);
            this.Load += new System.EventHandler(this.FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubcentroCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.ucIn_Linea_Grup_SubGr ucin_cat_lin_gr_sgr;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCCon_Plan_de_Cuenta_x_Movimiento ucct_plancta;
        private System.Windows.Forms.Label label3;
        private Controles.UCIn_ProductoCmb ucIn_ProductoCmb1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCentroCosto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSubcentroCosto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}