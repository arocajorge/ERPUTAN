namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_ProveedorBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCom_ProveedorBusqueda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridCtrlProveedor = new DevExpress.XtraGrid.GridControl();
            this.cpproveedorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridVwProveedor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_nombre2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSeleccionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwProveedor)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 519);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 519);
            this.panel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridCtrlProveedor);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 494);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Proveedores:";
            // 
            // gridCtrlProveedor
            // 
            this.gridCtrlProveedor.DataSource = this.cpproveedorInfoBindingSource;
            this.gridCtrlProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlProveedor.Location = new System.Drawing.Point(3, 16);
            this.gridCtrlProveedor.MainView = this.gridVwProveedor;
            this.gridCtrlProveedor.Name = "gridCtrlProveedor";
            this.gridCtrlProveedor.Size = new System.Drawing.Size(517, 475);
            this.gridCtrlProveedor.TabIndex = 7;
            this.gridCtrlProveedor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVwProveedor});
            // 
            // cpproveedorInfoBindingSource
            // 
            this.cpproveedorInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_proveedor_Info);
            // 
            // gridVwProveedor
            // 
            this.gridVwProveedor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdProveedor,
            this.colIdPersona,
            this.colpr_nombre2,
            this.colcontacto});
            this.gridVwProveedor.GridControl = this.gridCtrlProveedor;
            this.gridVwProveedor.Name = "gridVwProveedor";
            this.gridVwProveedor.OptionsFind.AlwaysVisible = true;
            this.gridVwProveedor.OptionsView.ShowGroupPanel = false;
            this.gridVwProveedor.DoubleClick += new System.EventHandler(this.gridVwProveedor_DoubleClick);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.Caption = "#Proveedor";
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.OptionsColumn.AllowEdit = false;
            this.colIdProveedor.OptionsColumn.ReadOnly = true;
            this.colIdProveedor.Visible = true;
            this.colIdProveedor.VisibleIndex = 0;
            this.colIdProveedor.Width = 508;
            // 
            // colIdPersona
            // 
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            // 
            // colpr_nombre2
            // 
            this.colpr_nombre2.Caption = "Proveedor";
            this.colpr_nombre2.FieldName = "pr_nombre";
            this.colpr_nombre2.Name = "colpr_nombre2";
            this.colpr_nombre2.OptionsColumn.AllowEdit = false;
            this.colpr_nombre2.OptionsColumn.ReadOnly = true;
            this.colpr_nombre2.Visible = true;
            this.colpr_nombre2.VisibleIndex = 1;
            this.colpr_nombre2.Width = 650;
            // 
            // colcontacto
            // 
            this.colcontacto.Caption = "Contacto";
            this.colcontacto.FieldName = "contacto";
            this.colcontacto.Name = "colcontacto";
            this.colcontacto.OptionsColumn.AllowEdit = false;
            this.colcontacto.OptionsColumn.ReadOnly = true;
            this.colcontacto.Width = 430;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.BtnSeleccionar,
            this.toolStripSeparator1,
            this.btnSalir,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(523, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionar.Image")));
            this.BtnSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(87, 22);
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // FrmCom_ProveedorBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 519);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCom_ProveedorBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Proveedores por Tipo de Productos";
            this.Load += new System.EventHandler(this.FrmCom_ProveedorBusqueda_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwProveedor)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridCtrlProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVwProveedor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnSeleccionar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.BindingSource cpproveedorInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_nombre2;
        private DevExpress.XtraGrid.Columns.GridColumn colcontacto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}