namespace Core.Erp.Winform.Academico
{
    partial class FrmAca_Rubros_Adicionales_x_Periodo_x_Estudiante
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
            this.ucAca_Estudiante1 = new Core.Erp.Winform.Controles.UCAca_Estudiante();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstado = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoEstudiante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridCtrlRubros_Adicionales_x_Periodo_x_Estudiante = new DevExpress.XtraGrid.GridControl();
            this.gridvwRubros_Adicionales_x_Periodo_x_Estudiante = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_CodRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_ValorRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_ValorExcepcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ucAca_Rubro1 = new Core.Erp.Winform.Controles.UCAca_Rubro();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlRubros_Adicionales_x_Periodo_x_Estudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvwRubros_Adicionales_x_Periodo_x_Estudiante)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucAca_Estudiante1
            // 
            this.ucAca_Estudiante1.Location = new System.Drawing.Point(88, 26);
            this.ucAca_Estudiante1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucAca_Estudiante1.Name = "ucAca_Estudiante1";
            this.ucAca_Estudiante1.Size = new System.Drawing.Size(269, 33);
            this.ucAca_Estudiante1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSeccion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.txtCurso);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtCodigoEstudiante);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.ucAca_Estudiante1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtSeccion
            // 
            this.txtSeccion.Location = new System.Drawing.Point(512, 33);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(100, 22);
            this.txtSeccion.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seccion";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(737, 33);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.View = this.searchLookUpEdit1View;
            this.cmbEstado.Size = new System.Drawing.Size(100, 22);
            this.cmbEstado.TabIndex = 7;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(737, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Estado Actual";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(631, 33);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 22);
            this.txtCurso.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(633, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Grado/Curso";
            // 
            // txtCodigoEstudiante
            // 
            this.txtCodigoEstudiante.Location = new System.Drawing.Point(394, 33);
            this.txtCodigoEstudiante.Name = "txtCodigoEstudiante";
            this.txtCodigoEstudiante.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoEstudiante.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Estudiante";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridCtrlRubros_Adicionales_x_Periodo_x_Estudiante);
            this.groupBox2.Location = new System.Drawing.Point(1, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(931, 577);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Rubros por Exepcion";
            // 
            // gridCtrlRubros_Adicionales_x_Periodo_x_Estudiante
            // 
            this.gridCtrlRubros_Adicionales_x_Periodo_x_Estudiante.Location = new System.Drawing.Point(12, 22);
            this.gridCtrlRubros_Adicionales_x_Periodo_x_Estudiante.MainView = this.gridvwRubros_Adicionales_x_Periodo_x_Estudiante;
            this.gridCtrlRubros_Adicionales_x_Periodo_x_Estudiante.Name = "gridCtrlRubros_Adicionales_x_Periodo_x_Estudiante";
            this.gridCtrlRubros_Adicionales_x_Periodo_x_Estudiante.Size = new System.Drawing.Size(913, 549);
            this.gridCtrlRubros_Adicionales_x_Periodo_x_Estudiante.TabIndex = 0;
            this.gridCtrlRubros_Adicionales_x_Periodo_x_Estudiante.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridvwRubros_Adicionales_x_Periodo_x_Estudiante});
            // 
            // gridvwRubros_Adicionales_x_Periodo_x_Estudiante
            // 
            this.gridvwRubros_Adicionales_x_Periodo_x_Estudiante.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_CodRubro,
            this.Col_Descripcion,
            this.Col_ValorRubro,
            this.Col_ValorExcepcion,
            this.gridColumn1});
            this.gridvwRubros_Adicionales_x_Periodo_x_Estudiante.GridControl = this.gridCtrlRubros_Adicionales_x_Periodo_x_Estudiante;
            this.gridvwRubros_Adicionales_x_Periodo_x_Estudiante.Name = "gridvwRubros_Adicionales_x_Periodo_x_Estudiante";
            // 
            // Col_CodRubro
            // 
            this.Col_CodRubro.Caption = "Codigo Rubro";
            this.Col_CodRubro.FieldName = "IdRubro";
            this.Col_CodRubro.Name = "Col_CodRubro";
            this.Col_CodRubro.OptionsColumn.AllowEdit = false;
            this.Col_CodRubro.Visible = true;
            this.Col_CodRubro.VisibleIndex = 0;
            // 
            // Col_Descripcion
            // 
            this.Col_Descripcion.Caption = "Rubro";
            this.Col_Descripcion.FieldName = "Descripcion_Rubro";
            this.Col_Descripcion.Name = "Col_Descripcion";
            this.Col_Descripcion.OptionsColumn.AllowEdit = false;
            this.Col_Descripcion.Visible = true;
            this.Col_Descripcion.VisibleIndex = 1;
            // 
            // Col_ValorRubro
            // 
            this.Col_ValorRubro.Caption = "Valor Rubro";
            this.Col_ValorRubro.FieldName = "ValorRubro";
            this.Col_ValorRubro.Name = "Col_ValorRubro";
            this.Col_ValorRubro.OptionsColumn.AllowEdit = false;
            this.Col_ValorRubro.Visible = true;
            this.Col_ValorRubro.VisibleIndex = 2;
            // 
            // Col_ValorExcepcion
            // 
            this.Col_ValorExcepcion.Caption = "Valor Excepcion";
            this.Col_ValorExcepcion.FieldName = "ValorExepcion";
            this.Col_ValorExcepcion.Name = "Col_ValorExcepcion";
            this.Col_ValorExcepcion.Visible = true;
            this.Col_ValorExcepcion.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Chequear";
            this.gridColumn1.FieldName = "check";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
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
            this.ucGe_Menu_Superior_Mant1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(932, 36);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 3;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ucAca_Rubro1);
            this.groupBox3.Location = new System.Drawing.Point(13, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(919, 59);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar Rubro Adicional";
            // 
            // ucAca_Rubro1
            // 
            this.ucAca_Rubro1.Location = new System.Drawing.Point(7, 19);
            this.ucAca_Rubro1.Margin = new System.Windows.Forms.Padding(4);
            this.ucAca_Rubro1.Name = "ucAca_Rubro1";
            this.ucAca_Rubro1.Size = new System.Drawing.Size(450, 33);
            this.ucAca_Rubro1.TabIndex = 10;
            // 
            // FrmAca_Rubros_Adicionales_x_Periodo_x_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 766);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAca_Rubros_Adicionales_x_Periodo_x_Estudiante";
            this.Text = "Rubros Adicionales x Periodo x Estudiante";
            this.Load += new System.EventHandler(this.FrmAca_Rubros_Adicionales_x_Periodo_x_Estudiante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlRubros_Adicionales_x_Periodo_x_Estudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvwRubros_Adicionales_x_Periodo_x_Estudiante)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCAca_Estudiante ucAca_Estudiante1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtCurso;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtCodigoEstudiante;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridCtrlRubros_Adicionales_x_Periodo_x_Estudiante;
        private DevExpress.XtraGrid.Views.Grid.GridView gridvwRubros_Adicionales_x_Periodo_x_Estudiante;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.Columns.GridColumn Col_CodRubro;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ValorRubro;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ValorExcepcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private Controles.UCAca_Rubro ucAca_Rubro1;

    }
}