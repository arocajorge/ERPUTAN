namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Aprobacion_Ing_Egr_x_transaccion
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
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoMovInv = new Core.Erp.Winform.Controles.UCIn_TipoMoviInv_Cmb();
            this.opt_egreso = new System.Windows.Forms.RadioButton();
            this.opt_ingreso = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Sucursal_Bodega = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.gridControlAprobación = new DevExpress.XtraGrid.GridControl();
            this.gridViewAprobacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chk_Aprobacion = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAprobación)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAprobacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Aprobacion)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(1009, 28);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 0;
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
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnAprobarGuardarSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAprobarGuardarSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnAprobarGuardarSalir_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnAprobar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAprobar_Click(this.ucGe_Menu_Superior_Mant1_event_btnAprobar_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cmb_Sucursal_Bodega);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 146);
            this.panel1.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(481, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipoMovInv);
            this.groupBox1.Controls.Add(this.opt_egreso);
            this.groupBox1.Controls.Add(this.opt_ingreso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Movimiento:";
            // 
            // cmbTipoMovInv
            // 
            this.cmbTipoMovInv.Location = new System.Drawing.Point(70, 39);
            this.cmbTipoMovInv.Name = "cmbTipoMovInv";
            this.cmbTipoMovInv.Size = new System.Drawing.Size(319, 28);
            this.cmbTipoMovInv.TabIndex = 6;
            this.cmbTipoMovInv.Visible_buton_Acciones = true;
            // 
            // opt_egreso
            // 
            this.opt_egreso.AutoSize = true;
            this.opt_egreso.Location = new System.Drawing.Point(83, 19);
            this.opt_egreso.Name = "opt_egreso";
            this.opt_egreso.Size = new System.Drawing.Size(58, 17);
            this.opt_egreso.TabIndex = 5;
            this.opt_egreso.TabStop = true;
            this.opt_egreso.Text = "Egreso";
            this.opt_egreso.UseVisualStyleBackColor = true;
            this.opt_egreso.CheckedChanged += new System.EventHandler(this.opt_egreso_CheckedChanged);
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
            this.opt_ingreso.CheckedChanged += new System.EventHandler(this.opt_ingreso_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Concepto:";
            // 
            // cmb_Sucursal_Bodega
            // 
            this.cmb_Sucursal_Bodega.Location = new System.Drawing.Point(12, 11);
            this.cmb_Sucursal_Bodega.Name = "cmb_Sucursal_Bodega";
            this.cmb_Sucursal_Bodega.Size = new System.Drawing.Size(462, 53);
            this.cmb_Sucursal_Bodega.TabIndex = 0;
            this.cmb_Sucursal_Bodega.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.todos;
            this.cmb_Sucursal_Bodega.Event_cmb_bodega1_EditValueChanged += new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega.delegate_cmb_bodega1_EditValueChanged(this.cmb_Sucursal_Bodega_Event_cmb_bodega1_EditValueChanged);
            // 
            // gridControlAprobación
            // 
            this.gridControlAprobación.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAprobación.Location = new System.Drawing.Point(0, 174);
            this.gridControlAprobación.MainView = this.gridViewAprobacion;
            this.gridControlAprobación.Name = "gridControlAprobación";
            this.gridControlAprobación.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chk_Aprobacion});
            this.gridControlAprobación.Size = new System.Drawing.Size(1009, 243);
            this.gridControlAprobación.TabIndex = 2;
            this.gridControlAprobación.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAprobacion});
            // 
            // gridViewAprobacion
            // 
            this.gridViewAprobacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.colEstado,
            this.colCheck,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn5});
            this.gridViewAprobacion.GridControl = this.gridControlAprobación;
            this.gridViewAprobacion.Name = "gridViewAprobacion";
            this.gridViewAprobacion.OptionsView.ShowAutoFilterRow = true;
            this.gridViewAprobacion.OptionsView.ShowGroupPanel = false;
            this.gridViewAprobacion.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewAprobacion_CellValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "# Movi";
            this.gridColumn1.FieldName = "IdNumMovi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 104;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Observación";
            this.gridColumn2.FieldName = "cm_observacion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 485;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cod Movi";
            this.gridColumn3.FieldName = "CodMoviInven";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 104;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Fecha";
            this.gridColumn4.FieldName = "cm_fecha";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Width = 97;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "IdEstadoAproba";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 7;
            this.colEstado.Width = 123;
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
            this.chk_Aprobacion.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.chk_Aprobacion_EditValueChanging);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "IdMovi_inven_tipo";
            this.gridColumn7.FieldName = "IdMovi_inven_tipo";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Sucursal";
            this.gridColumn8.FieldName = "nom_sucursal";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 94;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Bodega";
            this.gridColumn9.FieldName = "nom_bodega";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            this.gridColumn9.Width = 119;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Fecha registro";
            this.gridColumn5.DisplayFormat.FormatString = "\"dd/MM/yyyy hh:mm tt\"";
            this.gridColumn5.FieldName = "Fecha_registro";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 131;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 417);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1009, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 3;
            // 
            // FrmIn_Aprobacion_Ing_Egr_x_transaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 443);
            this.Controls.Add(this.gridControlAprobación);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmIn_Aprobacion_Ing_Egr_x_transaccion";
            this.Text = "Aprobación de ingresos - egresos";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAprobación)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAprobacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Aprobacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlAprobación;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAprobacion;
        private Controles.UCIn_Sucursal_Bodega cmb_Sucursal_Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controles.UCIn_TipoMoviInv_Cmb cmbTipoMovInv;
        private System.Windows.Forms.RadioButton opt_egreso;
        private System.Windows.Forms.RadioButton opt_ingreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chk_Aprobacion;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}