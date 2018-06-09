namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_Cierre_Periodo_x_Modulo
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
            this.lblfechaFin = new System.Windows.Forms.Label();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxProcesos = new System.Windows.Forms.GroupBox();
            this.progressBarCierreAnual = new System.Windows.Forms.ProgressBar();
            this.lblmensaje_no_cierra = new System.Windows.Forms.Label();
            this.btn_cierre_anual = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_periodo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_FechaIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_FechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chk_modulos = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chk_periodo_cerrado = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider();
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBoxProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_periodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_modulos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Periodo:";
            // 
            // lblfechaFin
            // 
            this.lblfechaFin.BackColor = System.Drawing.Color.White;
            this.lblfechaFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfechaFin.ForeColor = System.Drawing.Color.Black;
            this.lblfechaFin.Location = new System.Drawing.Point(143, 60);
            this.lblfechaFin.Name = "lblfechaFin";
            this.lblfechaFin.Size = new System.Drawing.Size(257, 23);
            this.lblfechaFin.TabIndex = 14;
            this.lblfechaFin.Text = "01/01/2012";
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.BackColor = System.Drawing.Color.White;
            this.lblFechaIni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechaIni.ForeColor = System.Drawing.Color.Black;
            this.lblFechaIni.Location = new System.Drawing.Point(143, 36);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(257, 23);
            this.lblFechaIni.TabIndex = 13;
            this.lblFechaIni.Text = "01/01/2012";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha Inicio:";
            // 
            // groupBoxProcesos
            // 
            this.groupBoxProcesos.Controls.Add(this.progressBarCierreAnual);
            this.groupBoxProcesos.Controls.Add(this.btn_cierre_anual);
            this.groupBoxProcesos.Controls.Add(this.lblmensaje_no_cierra);
            this.groupBoxProcesos.Controls.Add(this.cmb_periodo);
            this.groupBoxProcesos.Controls.Add(this.lblfechaFin);
            this.groupBoxProcesos.Controls.Add(this.lblFechaIni);
            this.groupBoxProcesos.Controls.Add(this.label1);
            this.groupBoxProcesos.Controls.Add(this.label4);
            this.groupBoxProcesos.Controls.Add(this.label3);
            this.groupBoxProcesos.Location = new System.Drawing.Point(285, 35);
            this.groupBoxProcesos.Name = "groupBoxProcesos";
            this.groupBoxProcesos.Size = new System.Drawing.Size(682, 380);
            this.groupBoxProcesos.TabIndex = 15;
            this.groupBoxProcesos.TabStop = false;
            // 
            // progressBarCierreAnual
            // 
            this.progressBarCierreAnual.Location = new System.Drawing.Point(41, 132);
            this.progressBarCierreAnual.Name = "progressBarCierreAnual";
            this.progressBarCierreAnual.Size = new System.Drawing.Size(359, 23);
            this.progressBarCierreAnual.TabIndex = 2;
            // 
            // lblmensaje_no_cierra
            // 
            this.lblmensaje_no_cierra.AutoSize = true;
            this.errorProvider.SetError(this.lblmensaje_no_cierra, "Año Anterior no cerrado");
            this.lblmensaje_no_cierra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje_no_cierra.ForeColor = System.Drawing.Color.Red;
            this.lblmensaje_no_cierra.Location = new System.Drawing.Point(29, 90);
            this.lblmensaje_no_cierra.Name = "lblmensaje_no_cierra";
            this.lblmensaje_no_cierra.Size = new System.Drawing.Size(371, 25);
            this.lblmensaje_no_cierra.TabIndex = 1;
            this.lblmensaje_no_cierra.Text = "No se ha cerrado el Año Anterior..";
            // 
            // btn_cierre_anual
            // 
            this.btn_cierre_anual.Location = new System.Drawing.Point(299, 161);
            this.btn_cierre_anual.Name = "btn_cierre_anual";
            this.btn_cierre_anual.Size = new System.Drawing.Size(101, 32);
            this.btn_cierre_anual.TabIndex = 0;
            this.btn_cierre_anual.Text = "Cierre Anual";
            this.btn_cierre_anual.Click += new System.EventHandler(this.btn_cierre_anual_Click);
            // 
            // cmb_periodo
            // 
            this.cmb_periodo.Location = new System.Drawing.Point(71, 11);
            this.cmb_periodo.Name = "cmb_periodo";
            this.cmb_periodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_periodo.Properties.DisplayMember = "nom_periodo";
            this.cmb_periodo.Properties.ValueMember = "IdPeriodo";
            this.cmb_periodo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_periodo.Size = new System.Drawing.Size(329, 20);
            this.cmb_periodo.TabIndex = 15;
            this.cmb_periodo.EditValueChanged += new System.EventHandler(this.cmb_periodo_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPeriodo,
            this.colpe_FechaIni,
            this.colpe_FechaFin,
            this.gridColumn1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPeriodo
            // 
            this.colIdPeriodo.Caption = "IdPeriodo";
            this.colIdPeriodo.FieldName = "IdPeriodo";
            this.colIdPeriodo.Name = "colIdPeriodo";
            this.colIdPeriodo.Visible = true;
            this.colIdPeriodo.VisibleIndex = 3;
            this.colIdPeriodo.Width = 103;
            // 
            // colpe_FechaIni
            // 
            this.colpe_FechaIni.Caption = "Fecha Ini";
            this.colpe_FechaIni.FieldName = "pe_FechaIni";
            this.colpe_FechaIni.Name = "colpe_FechaIni";
            this.colpe_FechaIni.Visible = true;
            this.colpe_FechaIni.VisibleIndex = 1;
            this.colpe_FechaIni.Width = 96;
            // 
            // colpe_FechaFin
            // 
            this.colpe_FechaFin.Caption = "Fecha Fin";
            this.colpe_FechaFin.FieldName = "pe_FechaFin";
            this.colpe_FechaFin.Name = "colpe_FechaFin";
            this.colpe_FechaFin.Visible = true;
            this.colpe_FechaFin.VisibleIndex = 2;
            this.colpe_FechaFin.Width = 96;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Periodo";
            this.gridColumn1.FieldName = "nom_periodo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 203;
            // 
            // chk_modulos
            // 
            this.chk_modulos.CheckOnClick = true;
            this.chk_modulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chk_modulos.Location = new System.Drawing.Point(0, 0);
            this.chk_modulos.Name = "chk_modulos";
            this.chk_modulos.Size = new System.Drawing.Size(273, 328);
            this.chk_modulos.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 386);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modulos a Cerrar";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chk_periodo_cerrado);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chk_modulos);
            this.splitContainer1.Size = new System.Drawing.Size(273, 367);
            this.splitContainer1.SplitterDistance = 35;
            this.splitContainer1.TabIndex = 22;
            // 
            // chk_periodo_cerrado
            // 
            this.chk_periodo_cerrado.AutoSize = true;
            this.chk_periodo_cerrado.Location = new System.Drawing.Point(12, 10);
            this.chk_periodo_cerrado.Name = "chk_periodo_cerrado";
            this.chk_periodo_cerrado.Size = new System.Drawing.Size(206, 17);
            this.chk_periodo_cerrado.TabIndex = 16;
            this.chk_periodo_cerrado.Text = "Este Periodo Esta Totalmente Cerrado";
            this.chk_periodo_cerrado.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 415);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(979, 26);
            this.ucGe_BarraEstado.TabIndex = 19;
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
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(979, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 21;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
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
            this.ucGe_Menu_Superior_Mant1.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_Superior_Mant1_event_btnGuardar_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // frmCon_Cierre_Periodo_x_Modulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Controls.Add(this.groupBoxProcesos);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "frmCon_Cierre_Periodo_x_Modulo";
            this.Text = "Cierre de periodo por módulo";
            this.Load += new System.EventHandler(this.frmCon_Cierre_Periodo_x_Modulo_Load);
            this.groupBoxProcesos.ResumeLayout(false);
            this.groupBoxProcesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_periodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_modulos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfechaFin;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxProcesos;
        private DevExpress.XtraEditors.CheckedListBoxControl chk_modulos;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_periodo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_FechaIni;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_FechaFin;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chk_periodo_cerrado;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevExpress.XtraEditors.SimpleButton btn_cierre_anual;
        private System.Windows.Forms.Label lblmensaje_no_cierra;
        private System.Windows.Forms.ProgressBar progressBarCierreAnual;
    }
}