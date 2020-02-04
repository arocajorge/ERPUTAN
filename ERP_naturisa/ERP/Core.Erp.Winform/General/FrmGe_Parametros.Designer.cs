namespace Core.Erp.Winform.General
{
    partial class FrmGe_Parametros
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gridControlParametro = new DevExpress.XtraGrid.GridControl();
            this.gridViewParametro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdParametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParametro)).BeginInit();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(646, 29);
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
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 369);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(646, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gridControlParametro);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(646, 340);
            this.panelMain.TabIndex = 2;
            // 
            // gridControlParametro
            // 
            this.gridControlParametro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlParametro.Location = new System.Drawing.Point(0, 0);
            this.gridControlParametro.MainView = this.gridViewParametro;
            this.gridControlParametro.Name = "gridControlParametro";
            this.gridControlParametro.Size = new System.Drawing.Size(646, 340);
            this.gridControlParametro.TabIndex = 0;
            this.gridControlParametro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewParametro});
            // 
            // gridViewParametro
            // 
            this.gridViewParametro.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colValor,
            this.colIdTipoParam,
            this.colIdParametro,
            this.coldescripcion});
            this.gridViewParametro.GridControl = this.gridControlParametro;
            this.gridViewParametro.Name = "gridViewParametro";
            this.gridViewParametro.OptionsView.ShowAutoFilterRow = true;
            this.gridViewParametro.OptionsView.ShowGroupPanel = false;
            // 
            // colValor
            // 
            this.colValor.Caption = "Valor";
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 2;
            this.colValor.Width = 105;
            // 
            // colIdTipoParam
            // 
            this.colIdTipoParam.Caption = "Tipo";
            this.colIdTipoParam.FieldName = "IdTipoParam";
            this.colIdTipoParam.Name = "colIdTipoParam";
            this.colIdTipoParam.Visible = true;
            this.colIdTipoParam.VisibleIndex = 3;
            this.colIdTipoParam.Width = 249;
            // 
            // colIdParametro
            // 
            this.colIdParametro.Caption = "IdParametro";
            this.colIdParametro.FieldName = "IdParametro";
            this.colIdParametro.Name = "colIdParametro";
            this.colIdParametro.Visible = true;
            this.colIdParametro.VisibleIndex = 0;
            this.colIdParametro.Width = 124;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 686;
            // 
            // FrmGe_Parametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 395);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmGe_Parametros";
            this.Text = "FrmGe_Parametros";
            this.Load += new System.EventHandler(this.FrmGe_Parametros_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParametro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParametro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraGrid.GridControl gridControlParametro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewParametro;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoParam;
        private DevExpress.XtraGrid.Columns.GridColumn colIdParametro;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;

    }
}