namespace Core.Erp.Winform.Roles_Fj
{
    partial class frmRo_Parametros_para_calculo_horas_Extras_x_empresa
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.check_se_paga_horasal25 = new DevExpress.XtraEditors.CheckEdit();
            this.check_se_paga_horasal50 = new DevExpress.XtraEditors.CheckEdit();
            this.check_se_paga_horasal100 = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cmb_Desahucio = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_rubros = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_IdRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_ru_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lb_rubro = new DevExpress.XtraEditors.LabelControl();
            this.check_reverso = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_diasCorte = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMinutoLoch = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_paga_horasal25.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_paga_horasal50.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_paga_horasal100.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Desahucio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_rubros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_reverso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diasCorte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinutoLoch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMinutoLoch);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.check_se_paga_horasal25);
            this.groupControl1.Controls.Add(this.check_se_paga_horasal50);
            this.groupControl1.Controls.Add(this.check_se_paga_horasal100);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(580, 116);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Al Subir marcaciones desde Excel se consideran las:";
            // 
            // check_se_paga_horasal25
            // 
            this.check_se_paga_horasal25.Location = new System.Drawing.Point(5, 63);
            this.check_se_paga_horasal25.Name = "check_se_paga_horasal25";
            this.check_se_paga_horasal25.Properties.Caption = "Horas Extras al 25%";
            this.check_se_paga_horasal25.Size = new System.Drawing.Size(128, 19);
            this.check_se_paga_horasal25.TabIndex = 5;
            // 
            // check_se_paga_horasal50
            // 
            this.check_se_paga_horasal50.Location = new System.Drawing.Point(5, 42);
            this.check_se_paga_horasal50.Name = "check_se_paga_horasal50";
            this.check_se_paga_horasal50.Properties.Caption = "horas Extras al 50%";
            this.check_se_paga_horasal50.Size = new System.Drawing.Size(128, 19);
            this.check_se_paga_horasal50.TabIndex = 4;
            // 
            // check_se_paga_horasal100
            // 
            this.check_se_paga_horasal100.Location = new System.Drawing.Point(5, 22);
            this.check_se_paga_horasal100.Name = "check_se_paga_horasal100";
            this.check_se_paga_horasal100.Properties.Caption = "Horas extras al 100%";
            this.check_se_paga_horasal100.Size = new System.Drawing.Size(164, 19);
            this.check_se_paga_horasal100.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cmb_Desahucio);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.cmb_rubros);
            this.groupControl2.Controls.Add(this.lb_rubro);
            this.groupControl2.Controls.Add(this.check_reverso);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txt_diasCorte);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 145);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(580, 264);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Otros Parametros";
            // 
            // cmb_Desahucio
            // 
            this.cmb_Desahucio.EditValue = "";
            this.cmb_Desahucio.Location = new System.Drawing.Point(171, 89);
            this.cmb_Desahucio.Name = "cmb_Desahucio";
            this.cmb_Desahucio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Desahucio.Properties.DisplayMember = "ru_descripcion";
            this.cmb_Desahucio.Properties.ValueMember = "IdRubro";
            this.cmb_Desahucio.Properties.View = this.gridView1;
            this.cmb_Desahucio.Size = new System.Drawing.Size(300, 20);
            this.cmb_Desahucio.TabIndex = 161;
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
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "IdRubro";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 61;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Concepto";
            this.gridColumn2.FieldName = "ru_descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 1103;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(155, 13);
            this.labelControl3.TabIndex = 160;
            this.labelControl3.Text = "Rubro para rebaja de Desahucio";
            // 
            // cmb_rubros
            // 
            this.cmb_rubros.EditValue = "";
            this.cmb_rubros.Location = new System.Drawing.Point(171, 63);
            this.cmb_rubros.Name = "cmb_rubros";
            this.cmb_rubros.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_rubros.Properties.DisplayMember = "ru_descripcion";
            this.cmb_rubros.Properties.ValueMember = "IdRubro";
            this.cmb_rubros.Properties.View = this.gridView3;
            this.cmb_rubros.Size = new System.Drawing.Size(300, 20);
            this.cmb_rubros.TabIndex = 159;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_IdRubro,
            this.Col_ru_descripcion});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // Col_IdRubro
            // 
            this.Col_IdRubro.Caption = "Id";
            this.Col_IdRubro.FieldName = "IdRubro";
            this.Col_IdRubro.Name = "Col_IdRubro";
            this.Col_IdRubro.Visible = true;
            this.Col_IdRubro.VisibleIndex = 0;
            this.Col_IdRubro.Width = 61;
            // 
            // Col_ru_descripcion
            // 
            this.Col_ru_descripcion.Caption = "Concepto";
            this.Col_ru_descripcion.FieldName = "ru_descripcion";
            this.Col_ru_descripcion.Name = "Col_ru_descripcion";
            this.Col_ru_descripcion.Visible = true;
            this.Col_ru_descripcion.VisibleIndex = 1;
            this.Col_ru_descripcion.Width = 1103;
            // 
            // lb_rubro
            // 
            this.lb_rubro.Location = new System.Drawing.Point(11, 66);
            this.lb_rubro.Name = "lb_rubro";
            this.lb_rubro.Size = new System.Drawing.Size(118, 13);
            this.lb_rubro.TabIndex = 158;
            this.lb_rubro.Text = "Concepto de descuento:";
            // 
            // check_reverso
            // 
            this.check_reverso.Location = new System.Drawing.Point(3, 43);
            this.check_reverso.Name = "check_reverso";
            this.check_reverso.Properties.Caption = "Se crea reverso por horas extras cuando existe remplazo por empleado";
            this.check_reverso.Size = new System.Drawing.Size(373, 19);
            this.check_reverso.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(218, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "dìas de cada mes";
            // 
            // txt_diasCorte
            // 
            this.txt_diasCorte.Location = new System.Drawing.Point(156, 22);
            this.txt_diasCorte.Name = "txt_diasCorte";
            this.txt_diasCorte.Properties.Mask.EditMask = "n0";
            this.txt_diasCorte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_diasCorte.Size = new System.Drawing.Size(56, 20);
            this.txt_diasCorte.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(137, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fecha corte horas extras los";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(580, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
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
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Minutos Lonch";
            // 
            // txtMinutoLoch
            // 
            this.txtMinutoLoch.Location = new System.Drawing.Point(108, 85);
            this.txtMinutoLoch.Name = "txtMinutoLoch";
            this.txtMinutoLoch.Properties.Mask.EditMask = "n0";
            this.txtMinutoLoch.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMinutoLoch.Size = new System.Drawing.Size(116, 20);
            this.txtMinutoLoch.TabIndex = 7;
            // 
            // frmRo_Parametros_para_calculo_horas_Extras_x_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 409);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Parametros_para_calculo_horas_Extras_x_empresa";
            this.Text = "Parametro por empresa para calculo de Horas Extras";
            this.Load += new System.EventHandler(this.frmRo_Parametros_para_calculo_horas_Extras_x_empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_paga_horasal25.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_paga_horasal50.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_paga_horasal100.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Desahucio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_rubros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_reverso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diasCorte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinutoLoch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit check_se_paga_horasal25;
        private DevExpress.XtraEditors.CheckEdit check_se_paga_horasal50;
        private DevExpress.XtraEditors.CheckEdit check_se_paga_horasal100;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_diasCorte;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit check_reverso;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_rubros;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdRubro;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ru_descripcion;
        private DevExpress.XtraEditors.LabelControl lb_rubro;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_Desahucio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMinutoLoch;
        private DevExpress.XtraEditors.LabelControl labelControl4;

    }
}