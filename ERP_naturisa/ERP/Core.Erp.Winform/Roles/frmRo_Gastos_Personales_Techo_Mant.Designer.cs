namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Gastos_Personales_Techo_Mant
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.gridControlMaxGastosPersonales = new DevExpress.XtraGrid.GridControl();
            this.gridViewMaxGastosPersonales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdGasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdTipoGasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAnioFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMonto_max = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colnom_tipo_gasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelSup = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtObservacion = new System.Windows.Forms.TextBox();
            this.cmbAnioFiscal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMaxGastosPersonales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaxGastosPersonales)).BeginInit();
            this.panelSup.SuspendLayout();
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
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(691, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
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
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
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
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelDetalle);
            this.panelPrincipal.Controls.Add(this.panelSup);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 29);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(691, 233);
            this.panelPrincipal.TabIndex = 1;
            // 
            // panelDetalle
            // 
            this.panelDetalle.Controls.Add(this.gridControlMaxGastosPersonales);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalle.Location = new System.Drawing.Point(0, 36);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(691, 197);
            this.panelDetalle.TabIndex = 1;
            // 
            // gridControlMaxGastosPersonales
            // 
            this.gridControlMaxGastosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMaxGastosPersonales.Location = new System.Drawing.Point(0, 0);
            this.gridControlMaxGastosPersonales.MainView = this.gridViewMaxGastosPersonales;
            this.gridControlMaxGastosPersonales.Name = "gridControlMaxGastosPersonales";
            this.gridControlMaxGastosPersonales.Size = new System.Drawing.Size(691, 197);
            this.gridControlMaxGastosPersonales.TabIndex = 0;
            this.gridControlMaxGastosPersonales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMaxGastosPersonales});
            // 
            // gridViewMaxGastosPersonales
            // 
            this.gridViewMaxGastosPersonales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdGasto,
            this.ColIdTipoGasto,
            this.ColAnioFiscal,
            this.ColMonto_max,
            this.Colnom_tipo_gasto});
            this.gridViewMaxGastosPersonales.GridControl = this.gridControlMaxGastosPersonales;
            this.gridViewMaxGastosPersonales.Name = "gridViewMaxGastosPersonales";
            // 
            // ColIdGasto
            // 
            this.ColIdGasto.Caption = "IdIdGasto";
            this.ColIdGasto.FieldName = "IdGasto";
            this.ColIdGasto.Name = "ColIdGasto";
            // 
            // ColIdTipoGasto
            // 
            this.ColIdTipoGasto.Caption = "Id Tipo";
            this.ColIdTipoGasto.FieldName = "IdTipoGasto";
            this.ColIdTipoGasto.Name = "ColIdTipoGasto";
            this.ColIdTipoGasto.OptionsColumn.ReadOnly = true;
            this.ColIdTipoGasto.Visible = true;
            this.ColIdTipoGasto.VisibleIndex = 0;
            this.ColIdTipoGasto.Width = 82;
            // 
            // ColAnioFiscal
            // 
            this.ColAnioFiscal.Caption = "Año Fiscal";
            this.ColAnioFiscal.FieldName = "AnioFiscal";
            this.ColAnioFiscal.Name = "ColAnioFiscal";
            this.ColAnioFiscal.OptionsColumn.ReadOnly = true;
            this.ColAnioFiscal.Visible = true;
            this.ColAnioFiscal.VisibleIndex = 2;
            this.ColAnioFiscal.Width = 115;
            // 
            // ColMonto_max
            // 
            this.ColMonto_max.Caption = "Monto Maximo";
            this.ColMonto_max.FieldName = "Monto_max";
            this.ColMonto_max.Name = "ColMonto_max";
            this.ColMonto_max.Visible = true;
            this.ColMonto_max.VisibleIndex = 3;
            this.ColMonto_max.Width = 91;
            // 
            // Colnom_tipo_gasto
            // 
            this.Colnom_tipo_gasto.Caption = "Tipo Gasto";
            this.Colnom_tipo_gasto.FieldName = "nom_tipo_gasto";
            this.Colnom_tipo_gasto.Name = "Colnom_tipo_gasto";
            this.Colnom_tipo_gasto.OptionsColumn.ReadOnly = true;
            this.Colnom_tipo_gasto.Visible = true;
            this.Colnom_tipo_gasto.VisibleIndex = 1;
            this.Colnom_tipo_gasto.Width = 756;
            // 
            // panelSup
            // 
            this.panelSup.Controls.Add(this.label2);
            this.panelSup.Controls.Add(this.TxtObservacion);
            this.panelSup.Controls.Add(this.cmbAnioFiscal);
            this.panelSup.Controls.Add(this.label1);
            this.panelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSup.Location = new System.Drawing.Point(0, 0);
            this.panelSup.Name = "panelSup";
            this.panelSup.Size = new System.Drawing.Size(691, 36);
            this.panelSup.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Observacion";
            // 
            // TxtObservacion
            // 
            this.TxtObservacion.Location = new System.Drawing.Point(244, 4);
            this.TxtObservacion.Multiline = true;
            this.TxtObservacion.Name = "TxtObservacion";
            this.TxtObservacion.Size = new System.Drawing.Size(444, 27);
            this.TxtObservacion.TabIndex = 6;
            // 
            // cmbAnioFiscal
            // 
            this.cmbAnioFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnioFiscal.FormattingEnabled = true;
            this.cmbAnioFiscal.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmbAnioFiscal.Location = new System.Drawing.Point(65, 10);
            this.cmbAnioFiscal.Name = "cmbAnioFiscal";
            this.cmbAnioFiscal.Size = new System.Drawing.Size(100, 21);
            this.cmbAnioFiscal.TabIndex = 5;
            this.cmbAnioFiscal.SelectedIndexChanged += new System.EventHandler(this.cmbAnioFiscal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año Fiscal";
            // 
            // frmRo_Gastos_Personales_Techo_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 262);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Gastos_Personales_Techo_Mant";
            this.Text = "Techo de Tipos de Gastos Personales";
            this.Load += new System.EventHandler(this.frmRo_Gastos_Personales_Techo_Mant_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMaxGastosPersonales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaxGastosPersonales)).EndInit();
            this.panelSup.ResumeLayout(false);
            this.panelSup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelDetalle;
        private DevExpress.XtraGrid.GridControl gridControlMaxGastosPersonales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMaxGastosPersonales;
        private System.Windows.Forms.Panel panelSup;
        private System.Windows.Forms.ComboBox cmbAnioFiscal;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdGasto;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdTipoGasto;
        private DevExpress.XtraGrid.Columns.GridColumn ColAnioFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn ColMonto_max;
        private DevExpress.XtraGrid.Columns.GridColumn Colnom_tipo_gasto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtObservacion;

    }
}