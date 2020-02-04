namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxcCobroDeCXCyDXC_Consulta
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlCuentaxCobrar = new DevExpress.XtraGrid.GridControl();
            this.cxccobroInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCuentaxCobrar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_TotalCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Tarjeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_NumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_estadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Cobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdVendedorCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_propietarioCta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCuentaxCobrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCuentaxCobrar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1201, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.dateEdit2);
            this.panelControl1.Controls.Add(this.dateEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1201, 37);
            this.panelControl1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicio";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(556, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Consultar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(319, 11);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(100, 20);
            this.dateEdit2.TabIndex = 0;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(118, 11);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlCuentaxCobrar);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 62);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1201, 291);
            this.panelControl2.TabIndex = 2;
            // 
            // gridControlCuentaxCobrar
            // 
            this.gridControlCuentaxCobrar.DataSource = this.cxccobroInfoBindingSource;
            this.gridControlCuentaxCobrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCuentaxCobrar.Location = new System.Drawing.Point(2, 2);
            this.gridControlCuentaxCobrar.MainView = this.gridViewCuentaxCobrar;
            this.gridControlCuentaxCobrar.Name = "gridControlCuentaxCobrar";
            this.gridControlCuentaxCobrar.Size = new System.Drawing.Size(1197, 287);
            this.gridControlCuentaxCobrar.TabIndex = 2;
            this.gridControlCuentaxCobrar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCuentaxCobrar});
            // 
            // cxccobroInfoBindingSource
            // 
            this.cxccobroInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_cobro_Info);
            // 
            // gridViewCuentaxCobrar
            // 
            this.gridViewCuentaxCobrar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCobro,
            this.colIdCobro_tipo,
            this.colcr_TotalCobro,
            this.colcr_observacion,
            this.colcr_Banco,
            this.colcr_cuenta,
            this.colcr_Tarjeta,
            this.colnSucursal,
            this.colcr_NumDocumento,
            this.colcr_estado,
            this.colcr_estadoCobro,
            this.colcr_Codigo,
            this.colIdEstadoCobro,
            this.colFecha_Cobro,
            this.colIdVendedorCliente,
            this.colnCliente,
            this.colBancoCuenta,
            this.colcr_propietarioCta,
            this.IdBanco});
            this.gridViewCuentaxCobrar.GridControl = this.gridControlCuentaxCobrar;
            this.gridViewCuentaxCobrar.Name = "gridViewCuentaxCobrar";
            this.gridViewCuentaxCobrar.OptionsBehavior.Editable = false;
            this.gridViewCuentaxCobrar.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCuentaxCobrar.OptionsView.ShowGroupPanel = false;
            this.gridViewCuentaxCobrar.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdCobro, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colIdCobro
            // 
            this.colIdCobro.Caption = "Id Cobro";
            this.colIdCobro.FieldName = "IdCobro";
            this.colIdCobro.Name = "colIdCobro";
            this.colIdCobro.Visible = true;
            this.colIdCobro.VisibleIndex = 1;
            this.colIdCobro.Width = 88;
            // 
            // colIdCobro_tipo
            // 
            this.colIdCobro_tipo.Caption = "Cobro Tipo";
            this.colIdCobro_tipo.FieldName = "IdCobro_tipo";
            this.colIdCobro_tipo.Name = "colIdCobro_tipo";
            this.colIdCobro_tipo.Visible = true;
            this.colIdCobro_tipo.VisibleIndex = 3;
            this.colIdCobro_tipo.Width = 104;
            // 
            // colcr_TotalCobro
            // 
            this.colcr_TotalCobro.Caption = "Total Cobro";
            this.colcr_TotalCobro.FieldName = "cr_TotalCobro";
            this.colcr_TotalCobro.Name = "colcr_TotalCobro";
            this.colcr_TotalCobro.Visible = true;
            this.colcr_TotalCobro.VisibleIndex = 7;
            this.colcr_TotalCobro.Width = 76;
            // 
            // colcr_observacion
            // 
            this.colcr_observacion.Caption = "Observacion";
            this.colcr_observacion.FieldName = "cr_observacion";
            this.colcr_observacion.Name = "colcr_observacion";
            this.colcr_observacion.Visible = true;
            this.colcr_observacion.VisibleIndex = 6;
            this.colcr_observacion.Width = 245;
            // 
            // colcr_Banco
            // 
            this.colcr_Banco.Caption = "Banco";
            this.colcr_Banco.FieldName = "cr_Banco";
            this.colcr_Banco.Name = "colcr_Banco";
            this.colcr_Banco.Visible = true;
            this.colcr_Banco.VisibleIndex = 5;
            this.colcr_Banco.Width = 108;
            // 
            // colcr_cuenta
            // 
            this.colcr_cuenta.Caption = "Cuenta";
            this.colcr_cuenta.FieldName = "cr_cuenta";
            this.colcr_cuenta.Name = "colcr_cuenta";
            this.colcr_cuenta.Width = 55;
            // 
            // colcr_Tarjeta
            // 
            this.colcr_Tarjeta.Caption = "Tarjeta";
            this.colcr_Tarjeta.FieldName = "cr_Tarjeta";
            this.colcr_Tarjeta.Name = "colcr_Tarjeta";
            this.colcr_Tarjeta.Width = 44;
            // 
            // colnSucursal
            // 
            this.colnSucursal.Caption = "Sucursal";
            this.colnSucursal.FieldName = "nSucursal";
            this.colnSucursal.Name = "colnSucursal";
            this.colnSucursal.Visible = true;
            this.colnSucursal.VisibleIndex = 0;
            this.colnSucursal.Width = 107;
            // 
            // colcr_NumDocumento
            // 
            this.colcr_NumDocumento.Caption = "#Documento";
            this.colcr_NumDocumento.FieldName = "cr_NumDocumento";
            this.colcr_NumDocumento.Name = "colcr_NumDocumento";
            this.colcr_NumDocumento.Visible = true;
            this.colcr_NumDocumento.VisibleIndex = 4;
            this.colcr_NumDocumento.Width = 106;
            // 
            // colcr_estado
            // 
            this.colcr_estado.Caption = "Estado";
            this.colcr_estado.FieldName = "cr_estado";
            this.colcr_estado.Name = "colcr_estado";
            this.colcr_estado.Visible = true;
            this.colcr_estado.VisibleIndex = 8;
            this.colcr_estado.Width = 23;
            // 
            // colcr_estadoCobro
            // 
            this.colcr_estadoCobro.Caption = "Estado Cobro";
            this.colcr_estadoCobro.FieldName = "cr_estadoCobro";
            this.colcr_estadoCobro.Name = "colcr_estadoCobro";
            this.colcr_estadoCobro.Width = 72;
            // 
            // colcr_Codigo
            // 
            this.colcr_Codigo.Caption = "Codigo Cobro";
            this.colcr_Codigo.FieldName = "cr_Codigo";
            this.colcr_Codigo.Name = "colcr_Codigo";
            this.colcr_Codigo.Width = 104;
            // 
            // colIdEstadoCobro
            // 
            this.colIdEstadoCobro.Caption = "IdEstadoCobro";
            this.colIdEstadoCobro.FieldName = "IdEstadoCobro";
            this.colIdEstadoCobro.Name = "colIdEstadoCobro";
            this.colIdEstadoCobro.Width = 70;
            // 
            // colFecha_Cobro
            // 
            this.colFecha_Cobro.Caption = "Fecha Cobro";
            this.colFecha_Cobro.FieldName = "Fecha_Cobro";
            this.colFecha_Cobro.Name = "colFecha_Cobro";
            this.colFecha_Cobro.Width = 74;
            // 
            // colIdVendedorCliente
            // 
            this.colIdVendedorCliente.Caption = "Vendedor";
            this.colIdVendedorCliente.FieldName = "IdVendedorCliente";
            this.colIdVendedorCliente.Name = "colIdVendedorCliente";
            this.colIdVendedorCliente.Width = 63;
            // 
            // colnCliente
            // 
            this.colnCliente.Caption = "Cliente";
            this.colnCliente.FieldName = "nCliente";
            this.colnCliente.Name = "colnCliente";
            this.colnCliente.Visible = true;
            this.colnCliente.VisibleIndex = 2;
            this.colnCliente.Width = 228;
            // 
            // colBancoCuenta
            // 
            this.colBancoCuenta.Caption = "Banco Cta.";
            this.colBancoCuenta.FieldName = "BancoCuenta";
            this.colBancoCuenta.Name = "colBancoCuenta";
            this.colBancoCuenta.Width = 56;
            // 
            // colcr_propietarioCta
            // 
            this.colcr_propietarioCta.FieldName = "cr_propietarioCta";
            this.colcr_propietarioCta.Name = "colcr_propietarioCta";
            // 
            // IdBanco
            // 
            this.IdBanco.Caption = "IdBanco";
            this.IdBanco.FieldName = "IdBanco";
            this.IdBanco.Name = "IdBanco";
            // 
            // frmCo_cxcCobroDeCXCyDXC_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 353);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCo_cxcCobroDeCXCyDXC_Consulta";
            this.Text = "frmCo_cxcCobroDeCXCyDXC";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCuentaxCobrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCuentaxCobrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.BindingSource cxccobroInfoBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlCuentaxCobrar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCuentaxCobrar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_TotalCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Banco;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Tarjeta;
        private DevExpress.XtraGrid.Columns.GridColumn colnSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_NumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_estadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Cobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVendedorCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colnCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_propietarioCta;
        private DevExpress.XtraGrid.Columns.GridColumn IdBanco;
    }
}