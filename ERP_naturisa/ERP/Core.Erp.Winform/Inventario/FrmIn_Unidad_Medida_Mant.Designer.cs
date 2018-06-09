namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Unidad_Medida_Mant
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
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.grbUnidadesConversion = new System.Windows.Forms.GroupBox();
            this.gridControl_conversion = new DevExpress.XtraGrid.GridControl();
            this.gridView_conversion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUnidadMedida_equiva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbUnidadMedida_Equiv = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUnidadMedida2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_alterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_equiv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinterpretacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkUsado_x_Movimiento = new System.Windows.Forms.CheckBox();
            this.chkestado = new System.Windows.Forms.CheckBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodAlterno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdUniMed = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.grbUnidadesConversion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_conversion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_conversion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUnidadMedida_Equiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(688, 29);
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
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 432);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(688, 26);
            this.ucGe_BarraEstado.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblAnulado);
            this.panelMain.Controls.Add(this.grbUnidadesConversion);
            this.panelMain.Controls.Add(this.chkUsado_x_Movimiento);
            this.panelMain.Controls.Add(this.chkestado);
            this.panelMain.Controls.Add(this.txtdescripcion);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.txtCodAlterno);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.txtIdUniMed);
            this.panelMain.Controls.Add(this.lblcodigo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(688, 403);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(275, 24);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(122, 20);
            this.lblAnulado.TabIndex = 10;
            this.lblAnulado.Text = "**ANULADO**";
            this.lblAnulado.Visible = false;
            // 
            // grbUnidadesConversion
            // 
            this.grbUnidadesConversion.Controls.Add(this.gridControl_conversion);
            this.grbUnidadesConversion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbUnidadesConversion.Location = new System.Drawing.Point(0, 179);
            this.grbUnidadesConversion.Name = "grbUnidadesConversion";
            this.grbUnidadesConversion.Size = new System.Drawing.Size(688, 224);
            this.grbUnidadesConversion.TabIndex = 9;
            this.grbUnidadesConversion.TabStop = false;
            this.grbUnidadesConversion.Text = "Unidades de Conversion";
            // 
            // gridControl_conversion
            // 
            this.gridControl_conversion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_conversion.Location = new System.Drawing.Point(3, 16);
            this.gridControl_conversion.MainView = this.gridView_conversion;
            this.gridControl_conversion.Name = "gridControl_conversion";
            this.gridControl_conversion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbUnidadMedida_Equiv});
            this.gridControl_conversion.Size = new System.Drawing.Size(682, 205);
            this.gridControl_conversion.TabIndex = 8;
            this.gridControl_conversion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_conversion});
            // 
            // gridView_conversion
            // 
            this.gridView_conversion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUnidadMedida,
            this.colIdUnidadMedida_equiva,
            this.colvalor_equiv,
            this.colinterpretacion});
            this.gridView_conversion.GridControl = this.gridControl_conversion;
            this.gridView_conversion.Name = "gridView_conversion";
            this.gridView_conversion.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_conversion.OptionsView.ShowGroupPanel = false;
            this.gridView_conversion.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_conversion_CellValueChanged);
            this.gridView_conversion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_conversion_KeyDown);
            // 
            // colIdUnidadMedida
            // 
            this.colIdUnidadMedida.Caption = "IdUnidadMedida";
            this.colIdUnidadMedida.FieldName = "IdUnidadMedida";
            this.colIdUnidadMedida.Name = "colIdUnidadMedida";
            this.colIdUnidadMedida.Width = 136;
            // 
            // colIdUnidadMedida_equiva
            // 
            this.colIdUnidadMedida_equiva.Caption = "UnidadMedida equivalente";
            this.colIdUnidadMedida_equiva.ColumnEdit = this.cmbUnidadMedida_Equiv;
            this.colIdUnidadMedida_equiva.FieldName = "IdUnidadMedida_equiva";
            this.colIdUnidadMedida_equiva.Name = "colIdUnidadMedida_equiva";
            this.colIdUnidadMedida_equiva.Visible = true;
            this.colIdUnidadMedida_equiva.VisibleIndex = 0;
            this.colIdUnidadMedida_equiva.Width = 175;
            // 
            // cmbUnidadMedida_Equiv
            // 
            this.cmbUnidadMedida_Equiv.AutoHeight = false;
            this.cmbUnidadMedida_Equiv.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUnidadMedida_Equiv.DisplayMember = "Descripcion";
            this.cmbUnidadMedida_Equiv.Name = "cmbUnidadMedida_Equiv";
            this.cmbUnidadMedida_Equiv.ValueMember = "IdUnidadMedida";
            this.cmbUnidadMedida_Equiv.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUnidadMedida2,
            this.colDescripcion2,
            this.colcod_alterno});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdUnidadMedida2
            // 
            this.colIdUnidadMedida2.Caption = "IdUnidadMedida";
            this.colIdUnidadMedida2.FieldName = "IdUnidadMedida";
            this.colIdUnidadMedida2.Name = "colIdUnidadMedida2";
            this.colIdUnidadMedida2.Visible = true;
            this.colIdUnidadMedida2.VisibleIndex = 0;
            this.colIdUnidadMedida2.Width = 102;
            // 
            // colDescripcion2
            // 
            this.colDescripcion2.Caption = "Descripcion";
            this.colDescripcion2.FieldName = "Descripcion";
            this.colDescripcion2.Name = "colDescripcion2";
            this.colDescripcion2.Visible = true;
            this.colDescripcion2.VisibleIndex = 1;
            this.colDescripcion2.Width = 822;
            // 
            // colcod_alterno
            // 
            this.colcod_alterno.Caption = "cod_alterno";
            this.colcod_alterno.FieldName = "cod_alterno";
            this.colcod_alterno.Name = "colcod_alterno";
            this.colcod_alterno.Visible = true;
            this.colcod_alterno.VisibleIndex = 2;
            this.colcod_alterno.Width = 256;
            // 
            // colvalor_equiv
            // 
            this.colvalor_equiv.Caption = "Valor";
            this.colvalor_equiv.FieldName = "valor_equiv";
            this.colvalor_equiv.Name = "colvalor_equiv";
            this.colvalor_equiv.Visible = true;
            this.colvalor_equiv.VisibleIndex = 1;
            this.colvalor_equiv.Width = 332;
            // 
            // colinterpretacion
            // 
            this.colinterpretacion.Caption = "Interpretacion";
            this.colinterpretacion.FieldName = "interpretacion";
            this.colinterpretacion.Name = "colinterpretacion";
            this.colinterpretacion.OptionsColumn.AllowEdit = false;
            this.colinterpretacion.Visible = true;
            this.colinterpretacion.VisibleIndex = 2;
            this.colinterpretacion.Width = 673;
            // 
            // chkUsado_x_Movimiento
            // 
            this.chkUsado_x_Movimiento.AutoSize = true;
            this.chkUsado_x_Movimiento.Location = new System.Drawing.Point(34, 132);
            this.chkUsado_x_Movimiento.Name = "chkUsado_x_Movimiento";
            this.chkUsado_x_Movimiento.Size = new System.Drawing.Size(129, 17);
            this.chkUsado_x_Movimiento.TabIndex = 7;
            this.chkUsado_x_Movimiento.Text = "Usado en Movimiento";
            this.chkUsado_x_Movimiento.UseVisualStyleBackColor = true;
            // 
            // chkestado
            // 
            this.chkestado.AutoSize = true;
            this.chkestado.Location = new System.Drawing.Point(34, 96);
            this.chkestado.Name = "chkestado";
            this.chkestado.Size = new System.Drawing.Size(56, 17);
            this.chkestado.TabIndex = 6;
            this.chkestado.Text = "Activo";
            this.chkestado.UseVisualStyleBackColor = true;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(103, 58);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(561, 20);
            this.txtdescripcion.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion:";
            // 
            // txtCodAlterno
            // 
            this.txtCodAlterno.Location = new System.Drawing.Point(514, 28);
            this.txtCodAlterno.Name = "txtCodAlterno";
            this.txtCodAlterno.Size = new System.Drawing.Size(150, 20);
            this.txtCodAlterno.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "codigo Alterno:";
            // 
            // txtIdUniMed
            // 
            this.txtIdUniMed.Location = new System.Drawing.Point(103, 32);
            this.txtIdUniMed.Name = "txtIdUniMed";
            this.txtIdUniMed.Size = new System.Drawing.Size(150, 20);
            this.txtIdUniMed.TabIndex = 1;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(31, 39);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo:";
            // 
            // FrmIn_Unidad_Medida_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 458);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmIn_Unidad_Medida_Mant";
            this.Text = "Mantenimiento de Unidad de Medida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Unidad_Medida_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_Unidad_Medida_Mant_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.grbUnidadesConversion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_conversion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_conversion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUnidadMedida_Equiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox grbUnidadesConversion;
        private DevExpress.XtraGrid.GridControl gridControl_conversion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_conversion;
        private System.Windows.Forms.CheckBox chkUsado_x_Movimiento;
        private System.Windows.Forms.CheckBox chkestado;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodAlterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdUniMed;
        private System.Windows.Forms.Label lblcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida_equiva;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_equiv;
        private DevExpress.XtraGrid.Columns.GridColumn colinterpretacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbUnidadMedida_Equiv;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion2;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_alterno;
        private System.Windows.Forms.Label lblAnulado;
    }
}