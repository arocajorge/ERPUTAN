namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_Alerta_Anticipos_x_NotasCreditos
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControl_Anticipos = new DevExpress.XtraGrid.GridControl();
            this.gridView_Anticipos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresaOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenPagoOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuenciaOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEntidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor_cbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_cancelado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_saldo_cbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Anticipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Anticipos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 354);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(761, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
            // 
            // gridControl_Anticipos
            // 
            this.gridControl_Anticipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Anticipos.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Anticipos.MainView = this.gridView_Anticipos;
            this.gridControl_Anticipos.Name = "gridControl_Anticipos";
            this.gridControl_Anticipos.Size = new System.Drawing.Size(761, 325);
            this.gridControl_Anticipos.TabIndex = 0;
            this.gridControl_Anticipos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Anticipos});
            // 
            // gridView_Anticipos
            // 
            this.gridView_Anticipos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresaOP,
            this.colIdOrdenPagoOP,
            this.colSecuenciaOP,
            this.colBeneficiario,
            this.colIdEntidad,
            this.colObservacion,
            this.colValor_cbte,
            this.colvalor_cancelado,
            this.colvalor_saldo_cbte,
            this.colIdEmpresa,
            this.colTipo});
            this.gridView_Anticipos.GridControl = this.gridControl_Anticipos;
            this.gridView_Anticipos.Name = "gridView_Anticipos";
            this.gridView_Anticipos.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Anticipos.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpresaOP
            // 
            this.colIdEmpresaOP.FieldName = "IdEmpresaOP";
            this.colIdEmpresaOP.Name = "colIdEmpresaOP";
            // 
            // colIdOrdenPagoOP
            // 
            this.colIdOrdenPagoOP.Caption = "# OP/NC";
            this.colIdOrdenPagoOP.FieldName = "IdOrdenPagoOP";
            this.colIdOrdenPagoOP.Name = "colIdOrdenPagoOP";
            this.colIdOrdenPagoOP.OptionsColumn.AllowEdit = false;
            this.colIdOrdenPagoOP.Visible = true;
            this.colIdOrdenPagoOP.VisibleIndex = 0;
            this.colIdOrdenPagoOP.Width = 95;
            // 
            // colSecuenciaOP
            // 
            this.colSecuenciaOP.FieldName = "SecuenciaOP";
            this.colSecuenciaOP.Name = "colSecuenciaOP";
            // 
            // colBeneficiario
            // 
            this.colBeneficiario.Caption = "Beneficiario";
            this.colBeneficiario.FieldName = "Beneficiario";
            this.colBeneficiario.Name = "colBeneficiario";
            this.colBeneficiario.OptionsColumn.AllowEdit = false;
            this.colBeneficiario.Visible = true;
            this.colBeneficiario.VisibleIndex = 2;
            this.colBeneficiario.Width = 271;
            // 
            // colIdEntidad
            // 
            this.colIdEntidad.FieldName = "IdEntidad";
            this.colIdEntidad.Name = "colIdEntidad";
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observación";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.OptionsColumn.AllowEdit = false;
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 3;
            this.colObservacion.Width = 325;
            // 
            // colValor_cbte
            // 
            this.colValor_cbte.Caption = "Total";
            this.colValor_cbte.FieldName = "Valor_cbte";
            this.colValor_cbte.Name = "colValor_cbte";
            this.colValor_cbte.OptionsColumn.AllowEdit = false;
            this.colValor_cbte.Visible = true;
            this.colValor_cbte.VisibleIndex = 4;
            this.colValor_cbte.Width = 129;
            // 
            // colvalor_cancelado
            // 
            this.colvalor_cancelado.Caption = "Valor Cancelado";
            this.colvalor_cancelado.FieldName = "valor_cancelado";
            this.colvalor_cancelado.Name = "colvalor_cancelado";
            this.colvalor_cancelado.OptionsColumn.AllowEdit = false;
            this.colvalor_cancelado.Visible = true;
            this.colvalor_cancelado.VisibleIndex = 5;
            this.colvalor_cancelado.Width = 150;
            // 
            // colvalor_saldo_cbte
            // 
            this.colvalor_saldo_cbte.Caption = "Saldo";
            this.colvalor_saldo_cbte.DisplayFormat.FormatString = "n2";
            this.colvalor_saldo_cbte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor_saldo_cbte.FieldName = "valor_saldo_cbte";
            this.colvalor_saldo_cbte.Name = "colvalor_saldo_cbte";
            this.colvalor_saldo_cbte.OptionsColumn.AllowEdit = false;
            this.colvalor_saldo_cbte.Visible = true;
            this.colvalor_saldo_cbte.VisibleIndex = 6;
            this.colvalor_saldo_cbte.Width = 115;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 1;
            this.colTipo.Width = 95;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(761, 29);
            this.ucGe_Menu.TabIndex = 2;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
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
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl_Anticipos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 325);
            this.panel1.TabIndex = 3;
            // 
            // frmCP_Alerta_Anticipos_x_NotasCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "frmCP_Alerta_Anticipos_x_NotasCreditos";
            this.Text = "Anticipos y Notas de Crédito Proveedor";
            this.Load += new System.EventHandler(this.frmCP_Alerta_Anticipos_x_NotasCreditos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Anticipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Anticipos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl gridControl_Anticipos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Anticipos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresaOP;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenPagoOP;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuenciaOP;
        private DevExpress.XtraGrid.Columns.GridColumn colBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEntidad;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colValor_cbte;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_cancelado;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_saldo_cbte;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
    }
}