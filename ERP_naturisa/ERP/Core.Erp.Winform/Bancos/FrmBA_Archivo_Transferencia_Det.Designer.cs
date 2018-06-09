namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Archivo_Transferencia_Det
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
            this.gridControlArchivo_Det = new DevExpress.XtraGrid.GridControl();
            this.gridViewArchivo_Det = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_empresa_origen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_banco_origen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_empresa_destino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_banco_destino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor_cobrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo_x_Cobrar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHEQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColOB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion_cheq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Fecha_cheq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdCbtePago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tipo_cbte_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_agrupar_x_beneficiario = new System.Windows.Forms.ToolStripButton();
            this.txtMotivo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtProceso = new DevExpress.XtraEditors.TextEdit();
            this.txtBanco = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlArchivo_Det)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewArchivo_Det)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProceso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco.Properties)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(988, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
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
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_Superior_Mant1_event_btnImprimir_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 380);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(988, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // gridControlArchivo_Det
            // 
            this.gridControlArchivo_Det.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlArchivo_Det.Location = new System.Drawing.Point(0, 0);
            this.gridControlArchivo_Det.MainView = this.gridViewArchivo_Det;
            this.gridControlArchivo_Det.Name = "gridControlArchivo_Det";
            this.gridControlArchivo_Det.Size = new System.Drawing.Size(988, 282);
            this.gridControlArchivo_Det.TabIndex = 2;
            this.gridControlArchivo_Det.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewArchivo_Det});
            // 
            // gridViewArchivo_Det
            // 
            this.gridViewArchivo_Det.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCedula,
            this.colBeneficiario,
            this.colCuenta,
            this.colValor,
            this.colId_Item,
            this.colEstadoRegistro,
            this.colnom_empresa_origen,
            this.colnom_banco_origen,
            this.colnom_empresa_destino,
            this.colnom_banco_destino,
            this.colValor_cobrado,
            this.colSaldo_x_Cobrar,
            this.colFecha_Proceso,
            this.colFecha,
            this.colCHEQUE,
            this.colReferencia,
            this.ColOB,
            this.colObservacion_cheq,
            this.colcb_Fecha_cheq,
            this.col_IdCbtePago,
            this.col_tipo_cbte_pago});
            this.gridViewArchivo_Det.GridControl = this.gridControlArchivo_Det;
            this.gridViewArchivo_Det.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Valor", this.colValor, "{0:n2}")});
            this.gridViewArchivo_Det.Name = "gridViewArchivo_Det";
            this.gridViewArchivo_Det.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewArchivo_Det.OptionsView.ShowAutoFilterRow = true;
            this.gridViewArchivo_Det.OptionsView.ShowFooter = true;
            this.gridViewArchivo_Det.OptionsView.ShowGroupPanel = false;
            this.gridViewArchivo_Det.OptionsView.ShowViewCaption = true;
            // 
            // colCedula
            // 
            this.colCedula.Caption = "Cedula";
            this.colCedula.FieldName = "pe_cedulaRuc";
            this.colCedula.Name = "colCedula";
            // 
            // colBeneficiario
            // 
            this.colBeneficiario.Caption = "Beneficiario";
            this.colBeneficiario.FieldName = "pe_nombreCompleto";
            this.colBeneficiario.Name = "colBeneficiario";
            this.colBeneficiario.Width = 394;
            // 
            // colCuenta
            // 
            this.colCuenta.Caption = "Cuenta";
            this.colCuenta.FieldName = "num_cta_acreditacion";
            this.colCuenta.Name = "colCuenta";
            // 
            // colValor
            // 
            this.colValor.Caption = "Valor enviado";
            this.colValor.DisplayFormat.FormatString = "c2";
            this.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Valor", "{0:c2}")});
            this.colValor.Width = 156;
            // 
            // colId_Item
            // 
            this.colId_Item.Caption = "Id_Item";
            this.colId_Item.FieldName = "Id_Item";
            this.colId_Item.Name = "colId_Item";
            // 
            // colEstadoRegistro
            // 
            this.colEstadoRegistro.Caption = "Estado";
            this.colEstadoRegistro.FieldName = "nom_EstadoRegistro";
            this.colEstadoRegistro.Name = "colEstadoRegistro";
            // 
            // colnom_empresa_origen
            // 
            this.colnom_empresa_origen.Caption = "Empresa Origen";
            this.colnom_empresa_origen.FieldName = "nom_empresa_origen";
            this.colnom_empresa_origen.Name = "colnom_empresa_origen";
            // 
            // colnom_banco_origen
            // 
            this.colnom_banco_origen.Caption = "Banco Origen";
            this.colnom_banco_origen.FieldName = "nom_banco_origen";
            this.colnom_banco_origen.Name = "colnom_banco_origen";
            // 
            // colnom_empresa_destino
            // 
            this.colnom_empresa_destino.Caption = "Empresa Destino";
            this.colnom_empresa_destino.FieldName = "nom_empresa_destino";
            this.colnom_empresa_destino.Name = "colnom_empresa_destino";
            // 
            // colnom_banco_destino
            // 
            this.colnom_banco_destino.Caption = "Banco Destino";
            this.colnom_banco_destino.FieldName = "nom_banco_destino";
            this.colnom_banco_destino.Name = "colnom_banco_destino";
            // 
            // colValor_cobrado
            // 
            this.colValor_cobrado.Caption = "Valor cobrado";
            this.colValor_cobrado.DisplayFormat.FormatString = "c";
            this.colValor_cobrado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colValor_cobrado.FieldName = "Valor_cobrado";
            this.colValor_cobrado.Name = "colValor_cobrado";
            // 
            // colSaldo_x_Cobrar
            // 
            this.colSaldo_x_Cobrar.Caption = "Saldo";
            this.colSaldo_x_Cobrar.DisplayFormat.FormatString = "c";
            this.colSaldo_x_Cobrar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSaldo_x_Cobrar.FieldName = "Saldo_x_Cobrar";
            this.colSaldo_x_Cobrar.Name = "colSaldo_x_Cobrar";
            // 
            // colFecha_Proceso
            // 
            this.colFecha_Proceso.Caption = "Fecha proceso";
            this.colFecha_Proceso.FieldName = "Fecha_Proceso";
            this.colFecha_Proceso.Name = "colFecha_Proceso";
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha generación";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            // 
            // colCHEQUE
            // 
            this.colCHEQUE.Caption = "Cheque";
            this.colCHEQUE.FieldName = "num_cheq";
            this.colCHEQUE.Name = "colCHEQUE";
            this.colCHEQUE.Width = 129;
            // 
            // colReferencia
            // 
            this.colReferencia.Caption = "Referencia";
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.Width = 190;
            // 
            // ColOB
            // 
            this.ColOB.Caption = "#OB";
            this.ColOB.FieldName = "Secuencial_reg_x_proceso";
            this.ColOB.Name = "ColOB";
            this.ColOB.Width = 50;
            // 
            // colObservacion_cheq
            // 
            this.colObservacion_cheq.Caption = "Observación cheque";
            this.colObservacion_cheq.FieldName = "Observacion_cheq";
            this.colObservacion_cheq.Name = "colObservacion_cheq";
            this.colObservacion_cheq.Width = 375;
            // 
            // colcb_Fecha_cheq
            // 
            this.colcb_Fecha_cheq.Caption = "Fecha";
            this.colcb_Fecha_cheq.FieldName = "cb_Fecha_cheq";
            this.colcb_Fecha_cheq.Name = "colcb_Fecha_cheq";
            this.colcb_Fecha_cheq.Width = 126;
            // 
            // col_IdCbtePago
            // 
            this.col_IdCbtePago.Caption = "# Cbte pago";
            this.col_IdCbtePago.FieldName = "IdCbteCble_pago";
            this.col_IdCbtePago.Name = "col_IdCbtePago";
            // 
            // col_tipo_cbte_pago
            // 
            this.col_tipo_cbte_pago.Caption = "Tipo cbte pago";
            this.col_tipo_cbte_pago.FieldName = "tipo_cbte_pago";
            this.col_tipo_cbte_pago.Name = "col_tipo_cbte_pago";
            this.col_tipo_cbte_pago.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.txtMotivo);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txtProceso);
            this.panel1.Controls.Add(this.txtBanco);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 69);
            this.panel1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_agrupar_x_beneficiario});
            this.toolStrip1.Location = new System.Drawing.Point(0, 44);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(988, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_agrupar_x_beneficiario
            // 
            this.btn_agrupar_x_beneficiario.Image = global::Core.Erp.Winform.Properties.Resources.Carpeta_16x16;
            this.btn_agrupar_x_beneficiario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_agrupar_x_beneficiario.Name = "btn_agrupar_x_beneficiario";
            this.btn_agrupar_x_beneficiario.Size = new System.Drawing.Size(156, 22);
            this.btn_agrupar_x_beneficiario.Text = "Agrupar por beneficiario";
            this.btn_agrupar_x_beneficiario.Click += new System.EventHandler(this.btn_agrupar_x_beneficiario_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(703, 16);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Properties.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(250, 20);
            this.txtMotivo.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(646, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Concepto:";
            // 
            // txtProceso
            // 
            this.txtProceso.Location = new System.Drawing.Point(380, 16);
            this.txtProceso.Name = "txtProceso";
            this.txtProceso.Properties.ReadOnly = true;
            this.txtProceso.Size = new System.Drawing.Size(250, 20);
            this.txtProceso.TabIndex = 3;
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(51, 16);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Properties.ReadOnly = true;
            this.txtBanco.Size = new System.Drawing.Size(253, 20);
            this.txtBanco.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(323, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Proceso:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Banco:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlArchivo_Det);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 282);
            this.panel2.TabIndex = 4;
            // 
            // FrmBA_Archivo_Transferencia_Det
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 406);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "FrmBA_Archivo_Transferencia_Det";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del archivo";
            this.Load += new System.EventHandler(this.FrmBA_Archivo_Transferencia_Det_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlArchivo_Det)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewArchivo_Det)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProceso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl gridControlArchivo_Det;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewArchivo_Det;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Item;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_empresa_origen;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_banco_origen;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_empresa_destino;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_banco_destino;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtProceso;
        private DevExpress.XtraEditors.TextEdit txtBanco;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn colValor_cobrado;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo_x_Cobrar;
        private DevExpress.XtraEditors.TextEdit txtMotivo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Proceso;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colCHEQUE;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn ColOB;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion_cheq;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Fecha_cheq;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdCbtePago;
        private DevExpress.XtraGrid.Columns.GridColumn col_tipo_cbte_pago;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_agrupar_x_beneficiario;
    }
}