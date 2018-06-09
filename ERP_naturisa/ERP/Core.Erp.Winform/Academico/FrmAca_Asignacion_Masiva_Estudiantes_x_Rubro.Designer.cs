namespace Core.Erp.Winform.Academico
{
    partial class FrmAca_Asignacion_Masiva_Estudiantes_x_Rubro
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
            this.ucAca_Rubro1 = new Core.Erp.Winform.Controles.UCAca_Rubro();
            this.ucAca_Anio_Lectivo1 = new Core.Erp.Winform.Controles.UCAca_Anio_Lectivo();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.gridCtrlEstudiantesContrato = new DevExpress.XtraGrid.GridControl();
            this.gridvwEstudiantesContrato = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdEstudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSeccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColParalelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColChequear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ColContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlEstudiantesContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvwEstudiantesContrato)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucAca_Rubro1
            // 
            this.ucAca_Rubro1.Location = new System.Drawing.Point(4, 8);
            this.ucAca_Rubro1.Margin = new System.Windows.Forms.Padding(4);
            this.ucAca_Rubro1.Name = "ucAca_Rubro1";
            this.ucAca_Rubro1.Size = new System.Drawing.Size(453, 27);
            this.ucAca_Rubro1.TabIndex = 60;
            this.ucAca_Rubro1.Event_UCRubro_EditValueChanged += new Core.Erp.Winform.Controles.UCAca_Rubro.delegadoUCRubro_EditValueChanged(this.ucAca_Rubro1_Event_UCRubro_EditValueChanged);
            // 
            // ucAca_Anio_Lectivo1
            // 
            this.ucAca_Anio_Lectivo1.Location = new System.Drawing.Point(485, 8);
            this.ucAca_Anio_Lectivo1.Margin = new System.Windows.Forms.Padding(4);
            this.ucAca_Anio_Lectivo1.Name = "ucAca_Anio_Lectivo1";
            this.ucAca_Anio_Lectivo1.Size = new System.Drawing.Size(265, 27);
            this.ucAca_Anio_Lectivo1.TabIndex = 59;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(615, 0);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(136, 20);
            this.lblAnulado.TabIndex = 58;
            this.lblAnulado.Text = "***ANULADO***";
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
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(763, 32);
            this.ucGe_Menu.TabIndex = 57;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
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
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // gridCtrlEstudiantesContrato
            // 
            this.gridCtrlEstudiantesContrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlEstudiantesContrato.Location = new System.Drawing.Point(0, 0);
            this.gridCtrlEstudiantesContrato.MainView = this.gridvwEstudiantesContrato;
            this.gridCtrlEstudiantesContrato.Name = "gridCtrlEstudiantesContrato";
            this.gridCtrlEstudiantesContrato.Size = new System.Drawing.Size(763, 301);
            this.gridCtrlEstudiantesContrato.TabIndex = 61;
            this.gridCtrlEstudiantesContrato.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridvwEstudiantesContrato});
            // 
            // gridvwEstudiantesContrato
            // 
            this.gridvwEstudiantesContrato.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdEstudiante,
            this.ColEstudiante,
            this.ColSeccion,
            this.ColCurso,
            this.ColParalelo,
            this.ColContrato,
            this.ColChequear});
            this.gridvwEstudiantesContrato.GridControl = this.gridCtrlEstudiantesContrato;
            this.gridvwEstudiantesContrato.Name = "gridvwEstudiantesContrato";
            this.gridvwEstudiantesContrato.OptionsView.ShowAutoFilterRow = true;
            // 
            // ColIdEstudiante
            // 
            this.ColIdEstudiante.Caption = "Id Estudiante";
            this.ColIdEstudiante.FieldName = "IdEstudiante";
            this.ColIdEstudiante.Name = "ColIdEstudiante";
            this.ColIdEstudiante.OptionsColumn.AllowEdit = false;
            this.ColIdEstudiante.Visible = true;
            this.ColIdEstudiante.VisibleIndex = 0;
            this.ColIdEstudiante.Width = 120;
            // 
            // ColEstudiante
            // 
            this.ColEstudiante.Caption = "Estudiante";
            this.ColEstudiante.FieldName = "nombreCompleto";
            this.ColEstudiante.Name = "ColEstudiante";
            this.ColEstudiante.OptionsColumn.AllowEdit = false;
            this.ColEstudiante.Visible = true;
            this.ColEstudiante.VisibleIndex = 1;
            this.ColEstudiante.Width = 118;
            // 
            // ColSeccion
            // 
            this.ColSeccion.Caption = "Seccion";
            this.ColSeccion.FieldName = "Seccion";
            this.ColSeccion.Name = "ColSeccion";
            this.ColSeccion.OptionsColumn.AllowEdit = false;
            this.ColSeccion.Visible = true;
            this.ColSeccion.VisibleIndex = 4;
            this.ColSeccion.Width = 120;
            // 
            // ColCurso
            // 
            this.ColCurso.Caption = "Curso";
            this.ColCurso.FieldName = "Curso";
            this.ColCurso.Name = "ColCurso";
            this.ColCurso.OptionsColumn.AllowEdit = false;
            this.ColCurso.Visible = true;
            this.ColCurso.VisibleIndex = 2;
            this.ColCurso.Width = 120;
            // 
            // ColParalelo
            // 
            this.ColParalelo.Caption = "Paralelo";
            this.ColParalelo.FieldName = "Paralelo";
            this.ColParalelo.Name = "ColParalelo";
            this.ColParalelo.OptionsColumn.AllowEdit = false;
            this.ColParalelo.Visible = true;
            this.ColParalelo.VisibleIndex = 3;
            this.ColParalelo.Width = 120;
            // 
            // ColChequear
            // 
            this.ColChequear.Caption = "Chequear";
            this.ColChequear.FieldName = "chequear";
            this.ColChequear.Name = "ColChequear";
            this.ColChequear.Visible = true;
            this.ColChequear.VisibleIndex = 6;
            this.ColChequear.Width = 123;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucAca_Rubro1);
            this.panel1.Controls.Add(this.ucAca_Anio_Lectivo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 53);
            this.panel1.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridCtrlEstudiantesContrato);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 301);
            this.panel2.TabIndex = 63;
            // 
            // ColContrato
            // 
            this.ColContrato.Caption = "Contrato";
            this.ColContrato.FieldName = "IdContrato";
            this.ColContrato.Name = "ColContrato";
            // 
            // FrmAca_Asignacion_Masiva_Estudiantes_x_Rubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 386);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAnulado);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAca_Asignacion_Masiva_Estudiantes_x_Rubro";
            this.Text = "Asignacion Masiva de Estudiantes por Rubro";
            this.Load += new System.EventHandler(this.FrmAca_Asignacion_Masiva_Estudiantes_x_Rubro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlEstudiantesContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvwEstudiantesContrato)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCAca_Rubro ucAca_Rubro1;
        private Controles.UCAca_Anio_Lectivo ucAca_Anio_Lectivo1;
        private System.Windows.Forms.Label lblAnulado;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraGrid.GridControl gridCtrlEstudiantesContrato;
        private DevExpress.XtraGrid.Views.Grid.GridView gridvwEstudiantesContrato;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdEstudiante;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstudiante;
        private DevExpress.XtraGrid.Columns.GridColumn ColSeccion;
        private DevExpress.XtraGrid.Columns.GridColumn ColCurso;
        private DevExpress.XtraGrid.Columns.GridColumn ColParalelo;
        private DevExpress.XtraGrid.Columns.GridColumn ColChequear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn ColContrato;
    }
}