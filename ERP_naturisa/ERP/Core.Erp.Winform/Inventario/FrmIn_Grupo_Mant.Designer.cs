namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Grupo_Mant
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.checkActivo = new System.Windows.Forms.CheckBox();
            this.cmbCategoria = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCategoría = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_Categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbLinea = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtIdGrupo = new System.Windows.Forms.TextBox();
            this.txtCodGrupo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtAbreviatura = new System.Windows.Forms.TextBox();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLinea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linea:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoría:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IdGrupo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Abreviatura:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Observación:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 293);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(479, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // checkActivo
            // 
            this.checkActivo.AutoSize = true;
            this.checkActivo.Enabled = false;
            this.checkActivo.Location = new System.Drawing.Point(270, 166);
            this.checkActivo.Name = "checkActivo";
            this.checkActivo.Size = new System.Drawing.Size(56, 17);
            this.checkActivo.TabIndex = 9;
            this.checkActivo.Text = "Activo";
            this.checkActivo.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Location = new System.Drawing.Point(91, 71);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCategoria.Properties.View = this.searchLookUpEdit1View;
            this.cmbCategoria.Size = new System.Drawing.Size(283, 20);
            this.cmbCategoria.TabIndex = 10;
            this.cmbCategoria.EditValueChanged += new System.EventHandler(this.cmbCategoria_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCategoría,
            this.colca_Categoria,
            this.col_Estado});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCategoría
            // 
            this.colIdCategoría.Caption = "Código";
            this.colIdCategoría.FieldName = "IdCategoria";
            this.colIdCategoría.Name = "colIdCategoría";
            this.colIdCategoría.Visible = true;
            this.colIdCategoría.VisibleIndex = 1;
            this.colIdCategoría.Width = 261;
            // 
            // colca_Categoria
            // 
            this.colca_Categoria.Caption = "Descripción";
            this.colca_Categoria.FieldName = "ca_Categoria";
            this.colca_Categoria.Name = "colca_Categoria";
            this.colca_Categoria.Visible = true;
            this.colca_Categoria.VisibleIndex = 0;
            this.colca_Categoria.Width = 656;
            // 
            // col_Estado
            // 
            this.col_Estado.Caption = "Estado";
            this.col_Estado.FieldName = "Estado";
            this.col_Estado.Name = "col_Estado";
            this.col_Estado.Visible = true;
            this.col_Estado.VisibleIndex = 2;
            this.col_Estado.Width = 263;
            // 
            // cmbLinea
            // 
            this.cmbLinea.Location = new System.Drawing.Point(91, 97);
            this.cmbLinea.Name = "cmbLinea";
            this.cmbLinea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLinea.Properties.View = this.searchLookUpEdit2View;
            this.cmbLinea.Size = new System.Drawing.Size(283, 20);
            this.cmbLinea.TabIndex = 11;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstado,
            this.colnom_linea,
            this.colIdLinea});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 2;
            this.colEstado.Width = 257;
            // 
            // colnom_linea
            // 
            this.colnom_linea.Caption = "Descripción";
            this.colnom_linea.FieldName = "nom_linea";
            this.colnom_linea.Name = "colnom_linea";
            this.colnom_linea.Visible = true;
            this.colnom_linea.VisibleIndex = 0;
            this.colnom_linea.Width = 667;
            // 
            // colIdLinea
            // 
            this.colIdLinea.Caption = "Código";
            this.colIdLinea.FieldName = "IdLinea";
            this.colIdLinea.Name = "colIdLinea";
            this.colIdLinea.Visible = true;
            this.colIdLinea.VisibleIndex = 1;
            this.colIdLinea.Width = 256;
            // 
            // txtIdGrupo
            // 
            this.txtIdGrupo.Location = new System.Drawing.Point(91, 42);
            this.txtIdGrupo.Name = "txtIdGrupo";
            this.txtIdGrupo.Size = new System.Drawing.Size(100, 20);
            this.txtIdGrupo.TabIndex = 12;
            // 
            // txtCodGrupo
            // 
            this.txtCodGrupo.Location = new System.Drawing.Point(274, 39);
            this.txtCodGrupo.Name = "txtCodGrupo";
            this.txtCodGrupo.Size = new System.Drawing.Size(100, 20);
            this.txtCodGrupo.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(91, 132);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(283, 20);
            this.txtDescripcion.TabIndex = 14;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(91, 195);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(283, 48);
            this.txtObservacion.TabIndex = 15;
            // 
            // txtAbreviatura
            // 
            this.txtAbreviatura.Location = new System.Drawing.Point(91, 160);
            this.txtAbreviatura.Name = "txtAbreviatura";
            this.txtAbreviatura.Size = new System.Drawing.Size(100, 20);
            this.txtAbreviatura.TabIndex = 16;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(144, 257);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(117, 20);
            this.lblAnulado.TabIndex = 17;
            this.lblAnulado.Text = "***Anulado***";
            this.lblAnulado.Visible = false;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(479, 29);
            this.ucGe_Menu.TabIndex = 18;
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
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // FrmIn_Grupo_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 315);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.lblAnulado);
            this.Controls.Add(this.txtAbreviatura);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodGrupo);
            this.Controls.Add(this.txtIdGrupo);
            this.Controls.Add(this.cmbLinea);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.checkActivo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmIn_Grupo_Mant";
            this.Text = "Mantenimiento de Grupos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Grupo_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_Grupo_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLinea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox checkActivo;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCategoria;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbLinea;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private System.Windows.Forms.TextBox txtIdGrupo;
        private System.Windows.Forms.TextBox txtCodGrupo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtAbreviatura;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_linea;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLinea;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoría;
        private DevExpress.XtraGrid.Columns.GridColumn colca_Categoria;
        private DevExpress.XtraGrid.Columns.GridColumn col_Estado;
        private System.Windows.Forms.Label lblAnulado;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
    }
}