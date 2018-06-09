namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Tabla_Impu_Renta_Mant
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFraccion = new DevExpress.XtraEditors.TextEdit();
            this.txtExceso = new DevExpress.XtraEditors.TextEdit();
            this.txtImpuesto = new DevExpress.XtraEditors.TextEdit();
            this.txtPorcentaje = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbAnioFiscal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.tbCalendarioInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAnioFiscal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldia_x_mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldia_x_semana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsFeriado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCalendario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSemana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTrimestre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInicial_del_Dia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMes_x_anio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCortoFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCortoMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreDia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreSemana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemana_x_anio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrimestre_x_Anio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreTrimestre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnioFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFraccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExceso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentaje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnioFiscal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCalendarioInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFraccion);
            this.groupBox1.Controls.Add(this.txtExceso);
            this.groupBox1.Controls.Add(this.txtImpuesto);
            this.groupBox1.Controls.Add(this.txtPorcentaje);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.cmbAnioFiscal);
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 217);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // txtFraccion
            // 
            this.txtFraccion.Location = new System.Drawing.Point(189, 57);
            this.txtFraccion.Name = "txtFraccion";
            this.txtFraccion.Properties.Mask.EditMask = "n0";
            this.txtFraccion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFraccion.Properties.Mask.ShowPlaceHolders = false;
            this.txtFraccion.Size = new System.Drawing.Size(169, 20);
            this.txtFraccion.TabIndex = 9;
            // 
            // txtExceso
            // 
            this.txtExceso.Location = new System.Drawing.Point(189, 91);
            this.txtExceso.Name = "txtExceso";
            this.txtExceso.Properties.Mask.EditMask = "n0";
            this.txtExceso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtExceso.Properties.Mask.ShowPlaceHolders = false;
            this.txtExceso.Size = new System.Drawing.Size(169, 20);
            this.txtExceso.TabIndex = 8;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(189, 128);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Properties.Mask.EditMask = "n0";
            this.txtImpuesto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtImpuesto.Properties.Mask.ShowPlaceHolders = false;
            this.txtImpuesto.Size = new System.Drawing.Size(169, 20);
            this.txtImpuesto.TabIndex = 7;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(189, 167);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Properties.Mask.EditMask = "p2";
            this.txtPorcentaje.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPorcentaje.Properties.Mask.ShowPlaceHolders = false;
            this.txtPorcentaje.Size = new System.Drawing.Size(169, 20);
            this.txtPorcentaje.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(58, 174);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Porcentaje(%):";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(58, 131);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(125, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Impuesto Fracción Básica:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(58, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Exceso Hasta:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(58, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Fracción Básica:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(58, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Año Fiscal:";
            // 
            // cmbAnioFiscal
            // 
            this.cmbAnioFiscal.Location = new System.Drawing.Point(189, 29);
            this.cmbAnioFiscal.Name = "cmbAnioFiscal";
            this.cmbAnioFiscal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAnioFiscal.Properties.DataSource = this.tbCalendarioInfoBindingSource;
            this.cmbAnioFiscal.Properties.DisplayMember = "AnioFiscal";
            this.cmbAnioFiscal.Properties.NullText = "";
            this.cmbAnioFiscal.Properties.ValueMember = "AnioFiscal";
            this.cmbAnioFiscal.Properties.View = this.searchLookUpEdit1View;
            this.cmbAnioFiscal.Size = new System.Drawing.Size(100, 20);
            this.cmbAnioFiscal.TabIndex = 5;
            // 
            // tbCalendarioInfoBindingSource
            // 
            this.tbCalendarioInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Calendario_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAnioFiscal1,
            this.colDescripcion,
            this.coldia_x_mes,
            this.coldia_x_semana,
            this.colEsFeriado,
            this.colfecha,
            this.colIdCalendario,
            this.colIdMes,
            this.colIdPeriodo,
            this.colIdSemana,
            this.colIdTrimestre,
            this.colInicial_del_Dia,
            this.colMax,
            this.colMes_x_anio,
            this.colMin,
            this.colNombreCortoFecha,
            this.colNombreCortoMes,
            this.colNombreDia,
            this.colNombreFecha,
            this.colNombreMes,
            this.colNombreSemana,
            this.colSemana_x_anio,
            this.colTrimestre_x_Anio,
            this.colNombreTrimestre});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colAnioFiscal1
            // 
            this.colAnioFiscal1.FieldName = "AnioFiscal";
            this.colAnioFiscal1.Name = "colAnioFiscal1";
            this.colAnioFiscal1.Visible = true;
            this.colAnioFiscal1.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            // 
            // coldia_x_mes
            // 
            this.coldia_x_mes.FieldName = "dia_x_mes";
            this.coldia_x_mes.Name = "coldia_x_mes";
            // 
            // coldia_x_semana
            // 
            this.coldia_x_semana.FieldName = "dia_x_semana";
            this.coldia_x_semana.Name = "coldia_x_semana";
            // 
            // colEsFeriado
            // 
            this.colEsFeriado.FieldName = "EsFeriado";
            this.colEsFeriado.Name = "colEsFeriado";
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            // 
            // colIdCalendario
            // 
            this.colIdCalendario.FieldName = "IdCalendario";
            this.colIdCalendario.Name = "colIdCalendario";
            // 
            // colIdMes
            // 
            this.colIdMes.FieldName = "IdMes";
            this.colIdMes.Name = "colIdMes";
            // 
            // colIdPeriodo
            // 
            this.colIdPeriodo.FieldName = "IdPeriodo";
            this.colIdPeriodo.Name = "colIdPeriodo";
            // 
            // colIdSemana
            // 
            this.colIdSemana.FieldName = "IdSemana";
            this.colIdSemana.Name = "colIdSemana";
            // 
            // colIdTrimestre
            // 
            this.colIdTrimestre.FieldName = "IdTrimestre";
            this.colIdTrimestre.Name = "colIdTrimestre";
            // 
            // colInicial_del_Dia
            // 
            this.colInicial_del_Dia.FieldName = "Inicial_del_Dia";
            this.colInicial_del_Dia.Name = "colInicial_del_Dia";
            // 
            // colMax
            // 
            this.colMax.FieldName = "Max";
            this.colMax.Name = "colMax";
            // 
            // colMes_x_anio
            // 
            this.colMes_x_anio.FieldName = "Mes_x_anio";
            this.colMes_x_anio.Name = "colMes_x_anio";
            // 
            // colMin
            // 
            this.colMin.FieldName = "Min";
            this.colMin.Name = "colMin";
            // 
            // colNombreCortoFecha
            // 
            this.colNombreCortoFecha.FieldName = "NombreCortoFecha";
            this.colNombreCortoFecha.Name = "colNombreCortoFecha";
            // 
            // colNombreCortoMes
            // 
            this.colNombreCortoMes.FieldName = "NombreCortoMes";
            this.colNombreCortoMes.Name = "colNombreCortoMes";
            // 
            // colNombreDia
            // 
            this.colNombreDia.FieldName = "NombreDia";
            this.colNombreDia.Name = "colNombreDia";
            // 
            // colNombreFecha
            // 
            this.colNombreFecha.FieldName = "NombreFecha";
            this.colNombreFecha.Name = "colNombreFecha";
            // 
            // colNombreMes
            // 
            this.colNombreMes.FieldName = "NombreMes";
            this.colNombreMes.Name = "colNombreMes";
            // 
            // colNombreSemana
            // 
            this.colNombreSemana.FieldName = "NombreSemana";
            this.colNombreSemana.Name = "colNombreSemana";
            // 
            // colSemana_x_anio
            // 
            this.colSemana_x_anio.FieldName = "Semana_x_anio";
            this.colSemana_x_anio.Name = "colSemana_x_anio";
            // 
            // colTrimestre_x_Anio
            // 
            this.colTrimestre_x_Anio.FieldName = "Trimestre_x_Anio";
            this.colTrimestre_x_Anio.Name = "colTrimestre_x_Anio";
            // 
            // colNombreTrimestre
            // 
            this.colNombreTrimestre.FieldName = "NombreTrimestre";
            this.colNombreTrimestre.Name = "colNombreTrimestre";
            // 
            // colAnioFiscal
            // 
            this.colAnioFiscal.FieldName = "AnioFiscal";
            this.colAnioFiscal.Name = "colAnioFiscal";
            this.colAnioFiscal.Visible = true;
            this.colAnioFiscal.VisibleIndex = 0;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(395, 29);
            this.ucGe_Menu.TabIndex = 51;
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
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // frmRo_Tabla_Impu_Renta_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 242);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRo_Tabla_Impu_Renta_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento - Tabla de Impuesto a la Renta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRo_Tabla_Impu_Renta_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmRo_Tabla_Impu_Renta_Mant_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_Tabla_Impu_Renta_Mant_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFraccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExceso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentaje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnioFiscal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCalendarioInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtFraccion;
        private DevExpress.XtraEditors.TextEdit txtExceso;
        private DevExpress.XtraEditors.TextEdit txtImpuesto;
        private DevExpress.XtraEditors.TextEdit txtPorcentaje;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource tbCalendarioInfoBindingSource;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbAnioFiscal;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colAnioFiscal1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn coldia_x_mes;
        private DevExpress.XtraGrid.Columns.GridColumn coldia_x_semana;
        private DevExpress.XtraGrid.Columns.GridColumn colEsFeriado;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCalendario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMes;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSemana;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTrimestre;
        private DevExpress.XtraGrid.Columns.GridColumn colInicial_del_Dia;
        private DevExpress.XtraGrid.Columns.GridColumn colMax;
        private DevExpress.XtraGrid.Columns.GridColumn colMes_x_anio;
        private DevExpress.XtraGrid.Columns.GridColumn colMin;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCortoFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCortoMes;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreDia;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreMes;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreSemana;
        private DevExpress.XtraGrid.Columns.GridColumn colSemana_x_anio;
        private DevExpress.XtraGrid.Columns.GridColumn colTrimestre_x_Anio;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreTrimestre;
        private DevExpress.XtraGrid.Columns.GridColumn colAnioFiscal;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
    }
}