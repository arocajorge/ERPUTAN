namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_factura_TerminoPago_Mant
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fafacturaTerminoPagoDistribucionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDistribucion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_Dias_Vcto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPor_distribucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorioDistribucion = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridControlDistribucion = new DevExpress.XtraGrid.GridControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fafacturaTerminoPagoDistribucionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDistribucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioDistribucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDistribucion)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCuota);
            this.groupBox1.Controls.Add(this.txtDias);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(103, 91);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(80, 20);
            this.txtCuota.TabIndex = 2;
            this.txtCuota.TextChanged += new System.EventHandler(this.txtCuota_TextChanged);
            this.txtCuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuota_KeyPress);
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(333, 95);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(80, 20);
            this.txtDias.TabIndex = 3;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(103, 62);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(310, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(103, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total de Dias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "# Cuota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo:";
            // 
            // fafacturaTerminoPagoDistribucionInfoBindingSource
            // 
            this.fafacturaTerminoPagoDistribucionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Facturacion.fa_TerminoPago_Distribucion_Info);
            // 
            // gridViewDistribucion
            // 
            this.gridViewDistribucion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSecuencia,
            this.colNum_Dias_Vcto,
            this.colPor_distribucion});
            this.gridViewDistribucion.GridControl = this.gridControlDistribucion;
            this.gridViewDistribucion.Name = "gridViewDistribucion";
            this.gridViewDistribucion.OptionsView.ShowFooter = true;
            this.gridViewDistribucion.OptionsView.ShowGroupPanel = false;
            this.gridViewDistribucion.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewDistribucion_CellValueChanged);
            // 
            // colSecuencia
            // 
            this.colSecuencia.Caption = "#";
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            this.colSecuencia.OptionsColumn.AllowEdit = false;
            this.colSecuencia.Visible = true;
            this.colSecuencia.VisibleIndex = 0;
            this.colSecuencia.Width = 30;
            // 
            // colNum_Dias_Vcto
            // 
            this.colNum_Dias_Vcto.Caption = "# Días Vence";
            this.colNum_Dias_Vcto.FieldName = "Num_Dias_Vcto";
            this.colNum_Dias_Vcto.Name = "colNum_Dias_Vcto";
            this.colNum_Dias_Vcto.OptionsColumn.AllowEdit = false;
            this.colNum_Dias_Vcto.Visible = true;
            this.colNum_Dias_Vcto.VisibleIndex = 1;
            this.colNum_Dias_Vcto.Width = 176;
            // 
            // colPor_distribucion
            // 
            this.colPor_distribucion.Caption = "Distribución";
            this.colPor_distribucion.ColumnEdit = this.repositorioDistribucion;
            this.colPor_distribucion.FieldName = "Por_distribucion";
            this.colPor_distribucion.Name = "colPor_distribucion";
            this.colPor_distribucion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Por_distribucion", "{0:N2}")});
            this.colPor_distribucion.Visible = true;
            this.colPor_distribucion.VisibleIndex = 2;
            this.colPor_distribucion.Width = 195;
            // 
            // repositorioDistribucion
            // 
            this.repositorioDistribucion.AutoHeight = false;
            this.repositorioDistribucion.Name = "repositorioDistribucion";
            this.repositorioDistribucion.EditValueChanged += new System.EventHandler(this.repositorioDistribucion_EditValueChanged);
            this.repositorioDistribucion.Validating += new System.ComponentModel.CancelEventHandler(this.repositorioDistribucion_Validating);
            // 
            // gridControlDistribucion
            // 
            this.gridControlDistribucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlDistribucion.DataSource = this.fafacturaTerminoPagoDistribucionInfoBindingSource;
            this.gridControlDistribucion.Location = new System.Drawing.Point(7, 12);
            this.gridControlDistribucion.MainView = this.gridViewDistribucion;
            this.gridControlDistribucion.Name = "gridControlDistribucion";
            this.gridControlDistribucion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorioDistribucion});
            this.gridControlDistribucion.Size = new System.Drawing.Size(583, 205);
            this.gridControlDistribucion.TabIndex = 0;
            this.gridControlDistribucion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDistribucion});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControlDistribucion);
            this.groupBox2.Location = new System.Drawing.Point(6, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 223);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(602, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
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
            // 
            // frmFa_factura_TerminoPago_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(602, 383);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmFa_factura_TerminoPago_Mant";
            this.Text = "Termino de Pago Mantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFa_factura_TerminoPago_Mantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.frmFa_factura_TerminoPago_Mantenimiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fafacturaTerminoPagoDistribucionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDistribucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioDistribucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDistribucion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fafacturaTerminoPagoDistribucionInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDistribucion;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_Dias_Vcto;
        private DevExpress.XtraGrid.Columns.GridColumn colPor_distribucion;
        private DevExpress.XtraGrid.GridControl gridControlDistribucion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtCuota;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositorioDistribucion;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
    }
}