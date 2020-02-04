namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_grupo_x_Tipo_Gasto_Mant
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
            this.cmb_tipo_gasto_padre = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_id_tipo_gasto = new DevExpress.XtraEditors.TextEdit();
            this.txt_Tipo_gasto = new DevExpress.XtraEditors.TextEdit();
            this.txt_orden = new System.Windows.Forms.NumericUpDown();
            this.txt_nivel = new System.Windows.Forms.NumericUpDown();
            this.txt_anulado = new DevExpress.XtraEditors.LabelControl();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_gasto_padre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id_tipo_gasto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tipo_gasto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_orden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nivel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo gasto padre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo gasto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "# Tipo gasto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Orden:";
            // 
            // cmb_tipo_gasto_padre
            // 
            this.cmb_tipo_gasto_padre.Location = new System.Drawing.Point(132, 70);
            this.cmb_tipo_gasto_padre.Name = "cmb_tipo_gasto_padre";
            this.cmb_tipo_gasto_padre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipo_gasto_padre.Properties.DisplayMember = "nom_tipo_Gasto2";
            this.cmb_tipo_gasto_padre.Properties.ValueMember = "IdTipo_Gasto";
            this.cmb_tipo_gasto_padre.Properties.View = this.searchLookUpEdit1View;
            this.cmb_tipo_gasto_padre.Size = new System.Drawing.Size(291, 20);
            this.cmb_tipo_gasto_padre.TabIndex = 5;
            this.cmb_tipo_gasto_padre.EditValueChanged += new System.EventHandler(this.cmb_tipo_gasto_padre_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "IdTipo_Gasto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 79;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Id Padre";
            this.gridColumn2.FieldName = "IdTipo_Gasto_Padre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 121;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tipo Gasto";
            this.gridColumn3.FieldName = "nom_tipo_Gasto";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 422;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nivel";
            this.gridColumn4.FieldName = "nivel";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 100;
            // 
            // txt_id_tipo_gasto
            // 
            this.txt_id_tipo_gasto.Location = new System.Drawing.Point(132, 44);
            this.txt_id_tipo_gasto.Name = "txt_id_tipo_gasto";
            this.txt_id_tipo_gasto.Properties.ReadOnly = true;
            this.txt_id_tipo_gasto.Size = new System.Drawing.Size(46, 20);
            this.txt_id_tipo_gasto.TabIndex = 6;
            // 
            // txt_Tipo_gasto
            // 
            this.txt_Tipo_gasto.Location = new System.Drawing.Point(132, 96);
            this.txt_Tipo_gasto.Name = "txt_Tipo_gasto";
            this.txt_Tipo_gasto.Size = new System.Drawing.Size(291, 20);
            this.txt_Tipo_gasto.TabIndex = 7;
            // 
            // txt_orden
            // 
            this.txt_orden.Location = new System.Drawing.Point(301, 122);
            this.txt_orden.Name = "txt_orden";
            this.txt_orden.Size = new System.Drawing.Size(46, 20);
            this.txt_orden.TabIndex = 12;
            // 
            // txt_nivel
            // 
            this.txt_nivel.Location = new System.Drawing.Point(132, 122);
            this.txt_nivel.Name = "txt_nivel";
            this.txt_nivel.ReadOnly = true;
            this.txt_nivel.Size = new System.Drawing.Size(46, 20);
            this.txt_nivel.TabIndex = 13;
            // 
            // txt_anulado
            // 
            this.txt_anulado.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_anulado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txt_anulado.Location = new System.Drawing.Point(221, 42);
            this.txt_anulado.Name = "txt_anulado";
            this.txt_anulado.Size = new System.Drawing.Size(87, 18);
            this.txt_anulado.TabIndex = 14;
            this.txt_anulado.Text = "ANULADO";
            this.txt_anulado.Visible = false;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 190);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(486, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 11;
            // 
            // ucGe_Menu_Superior_Mant1
            // 
            this.ucGe_Menu_Superior_Mant1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant1.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(486, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 10;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_Superior_Mant1_event_btnGuardar_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_Superior_Mant1_event_btnAnular_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tipo Gasto Padre";
            this.gridColumn5.FieldName = "nom_tipo_Gasto_Padre";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 458;
            // 
            // frmCon_grupo_x_Tipo_Gasto_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 216);
            this.Controls.Add(this.txt_anulado);
            this.Controls.Add(this.txt_nivel);
            this.Controls.Add(this.txt_orden);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Controls.Add(this.txt_Tipo_gasto);
            this.Controls.Add(this.txt_id_tipo_gasto);
            this.Controls.Add(this.cmb_tipo_gasto_padre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCon_grupo_x_Tipo_Gasto_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mantenimiento de tipo de gasto ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCon_grupo_x_Tipo_Gasto_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmCon_grupo_x_Tipo_Gasto_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_gasto_padre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id_tipo_gasto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tipo_gasto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_orden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_tipo_gasto_padre;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txt_id_tipo_gasto;
        private DevExpress.XtraEditors.TextEdit txt_Tipo_gasto;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.NumericUpDown txt_orden;
        private System.Windows.Forms.NumericUpDown txt_nivel;
        private DevExpress.XtraEditors.LabelControl txt_anulado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}