namespace Core.Erp.Winform.Academico
{
    partial class Frm_Aca_Apertura_Ciclo_Facturacion
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPeriodoSiguiente = new DevExpress.XtraEditors.SimpleButton();
            this.btnPeriodoAnterior = new DevExpress.XtraEditors.SimpleButton();
            this.btnAperturaAnual = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridCtrlEstudianteCurso = new DevExpress.XtraGrid.GridControl();
            this.gridvwEstudianteCurso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColCod_Estudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColParalelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblAnioLectivo = new DevExpress.XtraEditors.LabelControl();
            this.txtAnioLectivo = new DevExpress.XtraEditors.TextEdit();
            this.txtPeriodo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.galleryControlGallery1 = new DevExpress.XtraBars.Ribbon.Gallery.GalleryControlGallery();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlEstudianteCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvwEstudianteCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnioLectivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPeriodoSiguiente);
            this.groupBox3.Controls.Add(this.btnPeriodoAnterior);
            this.groupBox3.Location = new System.Drawing.Point(35, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(125, 110);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mover Periodo";
            // 
            // btnPeriodoSiguiente
            // 
            this.btnPeriodoSiguiente.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriodoSiguiente.Appearance.Options.UseFont = true;
            this.btnPeriodoSiguiente.Location = new System.Drawing.Point(11, 60);
            this.btnPeriodoSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPeriodoSiguiente.Name = "btnPeriodoSiguiente";
            this.btnPeriodoSiguiente.Size = new System.Drawing.Size(97, 34);
            this.btnPeriodoSiguiente.TabIndex = 4;
            this.btnPeriodoSiguiente.Text = "Cerrar";
            this.btnPeriodoSiguiente.Click += new System.EventHandler(this.btnPeriodoSiguiente_Click);
            // 
            // btnPeriodoAnterior
            // 
            this.btnPeriodoAnterior.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriodoAnterior.Appearance.Options.UseFont = true;
            this.btnPeriodoAnterior.Location = new System.Drawing.Point(11, 18);
            this.btnPeriodoAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPeriodoAnterior.Name = "btnPeriodoAnterior";
            this.btnPeriodoAnterior.Size = new System.Drawing.Size(97, 34);
            this.btnPeriodoAnterior.TabIndex = 6;
            this.btnPeriodoAnterior.Text = "Reversar";
            this.btnPeriodoAnterior.Click += new System.EventHandler(this.btnPeriodoAnterior_Click);
            // 
            // btnAperturaAnual
            // 
            this.btnAperturaAnual.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAperturaAnual.Appearance.Options.UseFont = true;
            this.btnAperturaAnual.Image = global::Core.Erp.Winform.Properties.Resources.system_software_update;
            this.btnAperturaAnual.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAperturaAnual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAperturaAnual.Location = new System.Drawing.Point(218, 18);
            this.btnAperturaAnual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAperturaAnual.Name = "btnAperturaAnual";
            this.btnAperturaAnual.Size = new System.Drawing.Size(396, 127);
            this.btnAperturaAnual.TabIndex = 5;
            this.btnAperturaAnual.Text = "Apertura Anual";
            this.btnAperturaAnual.Click += new System.EventHandler(this.btnAperturaAnual_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridCtrlEstudianteCurso);
            this.groupBox2.Location = new System.Drawing.Point(19, 234);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(892, 436);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // gridCtrlEstudianteCurso
            // 
            this.gridCtrlEstudianteCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlEstudianteCurso.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridCtrlEstudianteCurso.Location = new System.Drawing.Point(3, 17);
            this.gridCtrlEstudianteCurso.MainView = this.gridvwEstudianteCurso;
            this.gridCtrlEstudianteCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridCtrlEstudianteCurso.Name = "gridCtrlEstudianteCurso";
            this.gridCtrlEstudianteCurso.Size = new System.Drawing.Size(886, 417);
            this.gridCtrlEstudianteCurso.TabIndex = 0;
            this.gridCtrlEstudianteCurso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridvwEstudianteCurso});
            // 
            // gridvwEstudianteCurso
            // 
            this.gridvwEstudianteCurso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColCod_Estudiante,
            this.ColEstudiante,
            this.ColCurso,
            this.ColParalelo});
            this.gridvwEstudianteCurso.GridControl = this.gridCtrlEstudianteCurso;
            this.gridvwEstudianteCurso.Name = "gridvwEstudianteCurso";
            // 
            // ColCod_Estudiante
            // 
            this.ColCod_Estudiante.Caption = "Cod. Estudiante";
            this.ColCod_Estudiante.FieldName = "cod_estudiante";
            this.ColCod_Estudiante.Name = "ColCod_Estudiante";
            this.ColCod_Estudiante.Visible = true;
            this.ColCod_Estudiante.VisibleIndex = 0;
            // 
            // ColEstudiante
            // 
            this.ColEstudiante.Caption = "Estudiante";
            this.ColEstudiante.FieldName = "pe_nombreCompleto";
            this.ColEstudiante.Name = "ColEstudiante";
            this.ColEstudiante.Visible = true;
            this.ColEstudiante.VisibleIndex = 1;
            // 
            // ColCurso
            // 
            this.ColCurso.Caption = "Curso";
            this.ColCurso.FieldName = "Curso";
            this.ColCurso.Name = "ColCurso";
            this.ColCurso.Visible = true;
            this.ColCurso.VisibleIndex = 2;
            // 
            // ColParalelo
            // 
            this.ColParalelo.Caption = "Paralelo";
            this.ColParalelo.FieldName = "Paralelo";
            this.ColParalelo.Name = "ColParalelo";
            this.ColParalelo.Visible = true;
            this.ColParalelo.VisibleIndex = 3;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(8, 10);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(879, 196);
            this.xtraTabControl1.TabIndex = 9;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupBox4);
            this.xtraTabPage1.Controls.Add(this.groupBox3);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(873, 165);
            this.xtraTabPage1.Text = "Administrar Periodos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblAnioLectivo);
            this.groupBox4.Controls.Add(this.txtAnioLectivo);
            this.groupBox4.Controls.Add(this.txtPeriodo);
            this.groupBox4.Controls.Add(this.labelControl1);
            this.groupBox4.Location = new System.Drawing.Point(227, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(242, 110);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Periodo Activo";
            // 
            // lblAnioLectivo
            // 
            this.lblAnioLectivo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioLectivo.Location = new System.Drawing.Point(5, 34);
            this.lblAnioLectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAnioLectivo.Name = "lblAnioLectivo";
            this.lblAnioLectivo.Size = new System.Drawing.Size(83, 19);
            this.lblAnioLectivo.TabIndex = 1;
            this.lblAnioLectivo.Text = "Año Lectivo";
            // 
            // txtAnioLectivo
            // 
            this.txtAnioLectivo.Enabled = false;
            this.txtAnioLectivo.Location = new System.Drawing.Point(97, 31);
            this.txtAnioLectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnioLectivo.Name = "txtAnioLectivo";
            this.txtAnioLectivo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnioLectivo.Properties.Appearance.Options.UseFont = true;
            this.txtAnioLectivo.Size = new System.Drawing.Size(128, 26);
            this.txtAnioLectivo.TabIndex = 0;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Enabled = false;
            this.txtPeriodo.Location = new System.Drawing.Point(97, 70);
            this.txtPeriodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodo.Properties.Appearance.Options.UseFont = true;
            this.txtPeriodo.Size = new System.Drawing.Size(128, 26);
            this.txtPeriodo.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(5, 74);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Periodo";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btnAperturaAnual);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(873, 165);
            this.xtraTabPage2.Text = "Apertura Ciclo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xtraTabControl1);
            this.groupBox1.Location = new System.Drawing.Point(24, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(884, 213);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Frm_Aca_Apertura_Ciclo_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 748);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Aca_Apertura_Ciclo_Facturacion";
            this.Text = "Frm_Aca_Apertura_Ciclo_Facturacion";
            this.Load += new System.EventHandler(this.Frm_Aca_Apertura_Ciclo_Facturacion_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlEstudianteCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvwEstudianteCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnioLectivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridCtrlEstudianteCurso;
        private DevExpress.XtraGrid.Views.Grid.GridView gridvwEstudianteCurso;
        private DevExpress.XtraGrid.Columns.GridColumn ColCod_Estudiante;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstudiante;
        private DevExpress.XtraGrid.Columns.GridColumn ColCurso;
        private DevExpress.XtraGrid.Columns.GridColumn ColParalelo;
        private DevExpress.XtraEditors.SimpleButton btnAperturaAnual;
        private DevExpress.XtraEditors.SimpleButton btnPeriodoSiguiente;
        private DevExpress.XtraEditors.SimpleButton btnPeriodoAnterior;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.LabelControl lblAnioLectivo;
        private DevExpress.XtraEditors.TextEdit txtAnioLectivo;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraBars.Ribbon.Gallery.GalleryControlGallery galleryControlGallery1;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}