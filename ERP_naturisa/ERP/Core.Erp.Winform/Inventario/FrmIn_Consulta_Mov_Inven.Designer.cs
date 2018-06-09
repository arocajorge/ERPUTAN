namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Consulta_Mov_Inven
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucIn_Sucursal_Bodega = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.btn_buscar = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha_desde = new System.Windows.Forms.DateTimePicker();
            this.gridControl_Egresos_Varios = new DevExpress.XtraGrid.GridControl();
            this.gridView_Egreso_varios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnom_sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_tipo_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNumMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsigno_tipo_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Egresos_Varios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Egreso_varios)).BeginInit();
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
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(904, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
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
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnAceptar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAceptar_Click(this.ucGe_Menu_Superior_Mant1_event_btnAceptar_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 411);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(904, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ucIn_Sucursal_Bodega);
            this.splitContainer1.Panel1.Controls.Add(this.btn_buscar);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFecha_hasta);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFecha_desde);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl_Egresos_Varios);
            this.splitContainer1.Size = new System.Drawing.Size(904, 382);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 2;
            // 
            // ucIn_Sucursal_Bodega
            // 
            this.ucIn_Sucursal_Bodega.Location = new System.Drawing.Point(16, 13);
            this.ucIn_Sucursal_Bodega.Name = "ucIn_Sucursal_Bodega";
            this.ucIn_Sucursal_Bodega.Size = new System.Drawing.Size(462, 53);
            this.ucIn_Sucursal_Bodega.TabIndex = 8;
            this.ucIn_Sucursal_Bodega.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.todos;
            this.ucIn_Sucursal_Bodega.Visible_cmb_bodega = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(770, 33);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(122, 38);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Desde:";
            // 
            // dtpFecha_hasta
            // 
            this.dtpFecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_hasta.Location = new System.Drawing.Point(597, 33);
            this.dtpFecha_hasta.Name = "dtpFecha_hasta";
            this.dtpFecha_hasta.Size = new System.Drawing.Size(108, 20);
            this.dtpFecha_hasta.TabIndex = 2;
            // 
            // dtpFecha_desde
            // 
            this.dtpFecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_desde.Location = new System.Drawing.Point(597, 7);
            this.dtpFecha_desde.Name = "dtpFecha_desde";
            this.dtpFecha_desde.Size = new System.Drawing.Size(108, 20);
            this.dtpFecha_desde.TabIndex = 1;
            // 
            // gridControl_Egresos_Varios
            // 
            this.gridControl_Egresos_Varios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Egresos_Varios.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Egresos_Varios.MainView = this.gridView_Egreso_varios;
            this.gridControl_Egresos_Varios.Name = "gridControl_Egresos_Varios";
            this.gridControl_Egresos_Varios.Size = new System.Drawing.Size(904, 296);
            this.gridControl_Egresos_Varios.TabIndex = 1;
            this.gridControl_Egresos_Varios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Egreso_varios});
            // 
            // gridView_Egreso_varios
            // 
            this.gridView_Egreso_varios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnom_sucursal,
            this.colnom_tipo_inv,
            this.colIdNumMovi,
            this.colcm_fecha,
            this.colcm_observacion,
            this.colsigno_tipo_inv,
            this.gridColumn1});
            this.gridView_Egreso_varios.GridControl = this.gridControl_Egresos_Varios;
            this.gridView_Egreso_varios.Name = "gridView_Egreso_varios";
            this.gridView_Egreso_varios.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Egreso_varios.OptionsView.ShowGroupPanel = false;
            this.gridView_Egreso_varios.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Egreso_varios_RowClick);
            this.gridView_Egreso_varios.DoubleClick += new System.EventHandler(this.gridView_Egreso_varios_DoubleClick);
            // 
            // colnom_sucursal
            // 
            this.colnom_sucursal.Caption = "Sucursal";
            this.colnom_sucursal.FieldName = "nom_sucursal";
            this.colnom_sucursal.Name = "colnom_sucursal";
            this.colnom_sucursal.OptionsColumn.AllowEdit = false;
            this.colnom_sucursal.Visible = true;
            this.colnom_sucursal.VisibleIndex = 0;
            this.colnom_sucursal.Width = 116;
            // 
            // colnom_tipo_inv
            // 
            this.colnom_tipo_inv.Caption = "Tipo Movi Inventario";
            this.colnom_tipo_inv.FieldName = "nom_tipo_inv";
            this.colnom_tipo_inv.Name = "colnom_tipo_inv";
            this.colnom_tipo_inv.OptionsColumn.AllowEdit = false;
            this.colnom_tipo_inv.Visible = true;
            this.colnom_tipo_inv.VisibleIndex = 1;
            this.colnom_tipo_inv.Width = 104;
            // 
            // colIdNumMovi
            // 
            this.colIdNumMovi.Caption = "#NumMovi";
            this.colIdNumMovi.FieldName = "IdNumMovi";
            this.colIdNumMovi.Name = "colIdNumMovi";
            this.colIdNumMovi.OptionsColumn.AllowEdit = false;
            this.colIdNumMovi.Visible = true;
            this.colIdNumMovi.VisibleIndex = 2;
            this.colIdNumMovi.Width = 52;
            // 
            // colcm_fecha
            // 
            this.colcm_fecha.Caption = "Fecha";
            this.colcm_fecha.FieldName = "cm_fecha";
            this.colcm_fecha.Name = "colcm_fecha";
            this.colcm_fecha.OptionsColumn.AllowEdit = false;
            this.colcm_fecha.Visible = true;
            this.colcm_fecha.VisibleIndex = 4;
            this.colcm_fecha.Width = 65;
            // 
            // colcm_observacion
            // 
            this.colcm_observacion.Caption = "Observación";
            this.colcm_observacion.FieldName = "cm_observacion";
            this.colcm_observacion.Name = "colcm_observacion";
            this.colcm_observacion.OptionsColumn.AllowEdit = false;
            this.colcm_observacion.Visible = true;
            this.colcm_observacion.VisibleIndex = 6;
            this.colcm_observacion.Width = 266;
            // 
            // colsigno_tipo_inv
            // 
            this.colsigno_tipo_inv.Caption = "Ing/Egr";
            this.colsigno_tipo_inv.FieldName = "signo";
            this.colsigno_tipo_inv.Name = "colsigno_tipo_inv";
            this.colsigno_tipo_inv.Visible = true;
            this.colsigno_tipo_inv.VisibleIndex = 5;
            this.colsigno_tipo_inv.Width = 65;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "CodMoviInven";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 90;
            // 
            // FrmIn_Consulta_Mov_Inven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 437);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "FrmIn_Consulta_Mov_Inven";
            this.Text = "Consulta de Movimientos de Inventario";
            this.Load += new System.EventHandler(this.FrmIn_Consulta_Mov_Inven_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Egresos_Varios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Egreso_varios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha_hasta;
        private System.Windows.Forms.DateTimePicker dtpFecha_desde;
        private Controles.UCIn_Sucursal_Bodega ucIn_Sucursal_Bodega;
        private DevExpress.XtraGrid.GridControl gridControl_Egresos_Varios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Egreso_varios;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_tipo_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNumMovi;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colsigno_tipo_inv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}