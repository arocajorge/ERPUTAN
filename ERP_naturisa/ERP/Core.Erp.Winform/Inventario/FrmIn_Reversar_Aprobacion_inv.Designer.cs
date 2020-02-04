namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Reversar_Aprobacion_inv
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
            this.gridControlAprobación = new DevExpress.XtraGrid.GridControl();
            this.gridViewAprobacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cm_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chk_Aprobacion = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.col_tm_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Desc_mov_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dt_F_Hasta = new DevExpress.XtraEditors.DateEdit();
            this.dt_F_Desde = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucGe_Sucursal_combo = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.chk_seleccionar_visibles = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opt_egreso = new System.Windows.Forms.RadioButton();
            this.opt_ingreso = new System.Windows.Forms.RadioButton();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAprobación)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAprobacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Aprobacion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_F_Hasta.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_F_Hasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_F_Desde.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_F_Desde.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlAprobación
            // 
            this.gridControlAprobación.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAprobación.Location = new System.Drawing.Point(0, 128);
            this.gridControlAprobación.MainView = this.gridViewAprobacion;
            this.gridControlAprobación.Name = "gridControlAprobación";
            this.gridControlAprobación.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chk_Aprobacion});
            this.gridControlAprobación.Size = new System.Drawing.Size(1008, 359);
            this.gridControlAprobación.TabIndex = 5;
            this.gridControlAprobación.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAprobacion});
            // 
            // gridViewAprobacion
            // 
            this.gridViewAprobacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.col_cm_fecha,
            this.colCheck,
            this.col_tm_descripcion,
            this.col_Desc_mov_inv});
            this.gridViewAprobacion.GridControl = this.gridControlAprobación;
            this.gridViewAprobacion.Name = "gridViewAprobacion";
            this.gridViewAprobacion.OptionsView.ShowAutoFilterRow = true;
            this.gridViewAprobacion.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "# Movi";
            this.gridColumn1.FieldName = "IdNumMovi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 104;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Observación";
            this.gridColumn2.FieldName = "cm_observacion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 485;
            // 
            // col_cm_fecha
            // 
            this.col_cm_fecha.Caption = "Fecha";
            this.col_cm_fecha.FieldName = "cm_fecha";
            this.col_cm_fecha.Name = "col_cm_fecha";
            this.col_cm_fecha.OptionsColumn.AllowEdit = false;
            this.col_cm_fecha.Visible = true;
            this.col_cm_fecha.VisibleIndex = 5;
            this.col_cm_fecha.Width = 97;
            // 
            // colCheck
            // 
            this.colCheck.Caption = "*";
            this.colCheck.ColumnEdit = this.chk_Aprobacion;
            this.colCheck.FieldName = "Checked";
            this.colCheck.Name = "colCheck";
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 0;
            this.colCheck.Width = 20;
            // 
            // chk_Aprobacion
            // 
            this.chk_Aprobacion.AutoHeight = false;
            this.chk_Aprobacion.Name = "chk_Aprobacion";
            // 
            // col_tm_descripcion
            // 
            this.col_tm_descripcion.Caption = "tm_descripcion";
            this.col_tm_descripcion.FieldName = "tm_descripcion";
            this.col_tm_descripcion.Name = "col_tm_descripcion";
            this.col_tm_descripcion.OptionsColumn.AllowEdit = false;
            this.col_tm_descripcion.Visible = true;
            this.col_tm_descripcion.VisibleIndex = 1;
            this.col_tm_descripcion.Width = 94;
            // 
            // col_Desc_mov_inv
            // 
            this.col_Desc_mov_inv.Caption = "Motivo Inv.";
            this.col_Desc_mov_inv.FieldName = "Desc_mov_inv";
            this.col_Desc_mov_inv.Name = "col_Desc_mov_inv";
            this.col_Desc_mov_inv.OptionsColumn.AllowEdit = false;
            this.col_Desc_mov_inv.Visible = true;
            this.col_Desc_mov_inv.VisibleIndex = 4;
            this.col_Desc_mov_inv.Width = 119;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dt_F_Hasta);
            this.panel1.Controls.Add(this.dt_F_Desde);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ucGe_Sucursal_combo);
            this.panel1.Controls.Add(this.chk_seleccionar_visibles);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 100);
            this.panel1.TabIndex = 4;
            // 
            // dt_F_Hasta
            // 
            this.dt_F_Hasta.EditValue = new System.DateTime(2017, 1, 18, 16, 1, 25, 0);
            this.dt_F_Hasta.Location = new System.Drawing.Point(293, 63);
            this.dt_F_Hasta.Name = "dt_F_Hasta";
            this.dt_F_Hasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_F_Hasta.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dt_F_Hasta.Properties.VistaTimeProperties.DisplayFormat.FormatString = "dd/mm/YYYY";
            this.dt_F_Hasta.Properties.VistaTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_F_Hasta.Size = new System.Drawing.Size(100, 20);
            this.dt_F_Hasta.TabIndex = 15;
            // 
            // dt_F_Desde
            // 
            this.dt_F_Desde.EditValue = new System.DateTime(2017, 1, 18, 15, 59, 24, 0);
            this.dt_F_Desde.Location = new System.Drawing.Point(293, 35);
            this.dt_F_Desde.Name = "dt_F_Desde";
            this.dt_F_Desde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_F_Desde.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dt_F_Desde.Size = new System.Drawing.Size(100, 20);
            this.dt_F_Desde.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sucursal";
            // 
            // ucGe_Sucursal_combo
            // 
            this.ucGe_Sucursal_combo.Location = new System.Drawing.Point(95, 6);
            this.ucGe_Sucursal_combo.Name = "ucGe_Sucursal_combo";
            this.ucGe_Sucursal_combo.Size = new System.Drawing.Size(298, 26);
            this.ucGe_Sucursal_combo.TabIndex = 8;
            // 
            // chk_seleccionar_visibles
            // 
            this.chk_seleccionar_visibles.AutoSize = true;
            this.chk_seleccionar_visibles.Location = new System.Drawing.Point(22, 81);
            this.chk_seleccionar_visibles.Name = "chk_seleccionar_visibles";
            this.chk_seleccionar_visibles.Size = new System.Drawing.Size(119, 17);
            this.chk_seleccionar_visibles.TabIndex = 7;
            this.chk_seleccionar_visibles.Text = "Seleccionar visibles";
            this.chk_seleccionar_visibles.UseVisualStyleBackColor = true;
            this.chk_seleccionar_visibles.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(414, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 41);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opt_egreso);
            this.groupBox1.Controls.Add(this.opt_ingreso);
            this.groupBox1.Location = new System.Drawing.Point(95, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 42);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Movimiento:";
            // 
            // opt_egreso
            // 
            this.opt_egreso.AutoSize = true;
            this.opt_egreso.Checked = true;
            this.opt_egreso.Location = new System.Drawing.Point(83, 19);
            this.opt_egreso.Name = "opt_egreso";
            this.opt_egreso.Size = new System.Drawing.Size(58, 17);
            this.opt_egreso.TabIndex = 5;
            this.opt_egreso.TabStop = true;
            this.opt_egreso.Text = "Egreso";
            this.opt_egreso.UseVisualStyleBackColor = true;
            // 
            // opt_ingreso
            // 
            this.opt_ingreso.AutoSize = true;
            this.opt_ingreso.Location = new System.Drawing.Point(6, 19);
            this.opt_ingreso.Name = "opt_ingreso";
            this.opt_ingreso.Size = new System.Drawing.Size(60, 17);
            this.opt_ingreso.TabIndex = 4;
            this.opt_ingreso.TabStop = true;
            this.opt_ingreso.Text = "Ingreso";
            this.opt_ingreso.UseVisualStyleBackColor = true;
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
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(1008, 28);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 3;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
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
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnAprobarGuardarSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAprobarGuardarSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnAprobarGuardarSalir_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnAprobar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAprobar_Click(this.ucGe_Menu_Superior_Mant1_event_btnAprobar_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 487);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1008, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 6;
            // 
            // FrmIn_Reversar_Aprobacion_inv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 513);
            this.Controls.Add(this.gridControlAprobación);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmIn_Reversar_Aprobacion_inv";
            this.Text = "FrmIn_Reversar_Aprobacion_inv";
            this.Load += new System.EventHandler(this.FrmIn_Reversar_Aprobacion_inv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAprobación)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAprobacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Aprobacion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_F_Hasta.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_F_Hasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_F_Desde.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_F_Desde.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlAprobación;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn col_cm_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chk_Aprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn col_tm_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn col_Desc_mov_inv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_seleccionar_visibles;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opt_egreso;
        private System.Windows.Forms.RadioButton opt_ingreso;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private System.Windows.Forms.Label label1;
        private Controles.UCGe_Sucursal_combo ucGe_Sucursal_combo;
        private DevExpress.XtraEditors.DateEdit dt_F_Hasta;
        private DevExpress.XtraEditors.DateEdit dt_F_Desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
    }
}