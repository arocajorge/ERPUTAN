namespace Core.Erp.Winform.Controles
{
    partial class UCCP_Proveedor_Autoriza
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_Seleccionar = new System.Windows.Forms.ToolStripButton();
            this.btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.gridControl_AutoriProvee = new DevExpress.XtraGrid.GridControl();
            this.gridView_AutoriProvee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnAutorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txe_nAutoriza = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colValido_Hasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txe_serie = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSerie2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactura_inicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txe_factura_ini_fin = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colfactura_final = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdAutorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Actualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_AutoriProvee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_AutoriProvee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_nAutoriza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_serie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_factura_ini_fin)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Nuevo,
            this.btn_Seleccionar,
            this.btn_Salir,
            this.btn_Actualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Image = global::Core.Erp.Winform.Properties.Resources.nuevo;
            this.btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(131, 22);
            this.btn_Nuevo.Text = "Nueva Autorización";
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Image = global::Core.Erp.Winform.Properties.Resources.nuevo;
            this.btn_Seleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(87, 22);
            this.btn_Seleccionar.Text = "Seleccionar";
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(49, 22);
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // gridControl_AutoriProvee
            // 
            this.gridControl_AutoriProvee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_AutoriProvee.Location = new System.Drawing.Point(0, 25);
            this.gridControl_AutoriProvee.MainView = this.gridView_AutoriProvee;
            this.gridControl_AutoriProvee.Name = "gridControl_AutoriProvee";
            this.gridControl_AutoriProvee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txe_nAutoriza,
            this.txe_serie,
            this.txe_factura_ini_fin});
            this.gridControl_AutoriProvee.Size = new System.Drawing.Size(740, 257);
            this.gridControl_AutoriProvee.TabIndex = 1;
            this.gridControl_AutoriProvee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_AutoriProvee});
            this.gridControl_AutoriProvee.Click += new System.EventHandler(this.gridControl_AutoriProvee_Click);
            // 
            // gridView_AutoriProvee
            // 
            this.gridView_AutoriProvee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnAutorizacion,
            this.colValido_Hasta,
            this.colSerie1,
            this.colSerie2,
            this.colfactura_inicial,
            this.colfactura_final,
            this.Estado,
            this.colIdAutorizacion,
            this.colIdProveedor,
            this.colIdEmpresa});
            this.gridView_AutoriProvee.GridControl = this.gridControl_AutoriProvee;
            this.gridView_AutoriProvee.Name = "gridView_AutoriProvee";
            this.gridView_AutoriProvee.OptionsView.ShowAutoFilterRow = true;
            this.gridView_AutoriProvee.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_AutoriProvee_RowCellClick);
            this.gridView_AutoriProvee.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_AutoriProvee_RowCellStyle);
            this.gridView_AutoriProvee.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_AutoriProvee_FocusedRowChanged);
            this.gridView_AutoriProvee.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_AutoriProvee_CellValueChanged);
            this.gridView_AutoriProvee.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView_AutoriProvee_ValidateRow);
            this.gridView_AutoriProvee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_AutoriProvee_KeyDown);
            this.gridView_AutoriProvee.DoubleClick += new System.EventHandler(this.gridView_AutoriProvee_DoubleClick);
            // 
            // colnAutorizacion
            // 
            this.colnAutorizacion.Caption = "# Autorización";
            this.colnAutorizacion.ColumnEdit = this.txe_nAutoriza;
            this.colnAutorizacion.FieldName = "nAutorizacion";
            this.colnAutorizacion.Name = "colnAutorizacion";
            this.colnAutorizacion.Visible = true;
            this.colnAutorizacion.VisibleIndex = 0;
            this.colnAutorizacion.Width = 322;
            // 
            // txe_nAutoriza
            // 
            this.txe_nAutoriza.AutoHeight = false;
            this.txe_nAutoriza.Mask.EditMask = "\\d{0,37}";
            this.txe_nAutoriza.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txe_nAutoriza.Name = "txe_nAutoriza";
            // 
            // colValido_Hasta
            // 
            this.colValido_Hasta.Caption = "Válido Hasta";
            this.colValido_Hasta.FieldName = "Valido_Hasta";
            this.colValido_Hasta.Name = "colValido_Hasta";
            this.colValido_Hasta.Visible = true;
            this.colValido_Hasta.VisibleIndex = 1;
            this.colValido_Hasta.Width = 118;
            // 
            // colSerie1
            // 
            this.colSerie1.Caption = "Establecimiento";
            this.colSerie1.ColumnEdit = this.txe_serie;
            this.colSerie1.FieldName = "Serie1";
            this.colSerie1.Name = "colSerie1";
            this.colSerie1.Visible = true;
            this.colSerie1.VisibleIndex = 2;
            this.colSerie1.Width = 144;
            // 
            // txe_serie
            // 
            this.txe_serie.AutoHeight = false;
            this.txe_serie.Mask.EditMask = "\\d{0,3}";
            this.txe_serie.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txe_serie.Name = "txe_serie";
            // 
            // colSerie2
            // 
            this.colSerie2.Caption = "Punto Emisión";
            this.colSerie2.ColumnEdit = this.txe_serie;
            this.colSerie2.FieldName = "Serie2";
            this.colSerie2.Name = "colSerie2";
            this.colSerie2.Visible = true;
            this.colSerie2.VisibleIndex = 3;
            this.colSerie2.Width = 144;
            // 
            // colfactura_inicial
            // 
            this.colfactura_inicial.Caption = "Factura Inicial";
            this.colfactura_inicial.ColumnEdit = this.txe_factura_ini_fin;
            this.colfactura_inicial.FieldName = "factura_inicial";
            this.colfactura_inicial.Name = "colfactura_inicial";
            this.colfactura_inicial.Visible = true;
            this.colfactura_inicial.VisibleIndex = 4;
            this.colfactura_inicial.Width = 144;
            // 
            // txe_factura_ini_fin
            // 
            this.txe_factura_ini_fin.AutoHeight = false;
            this.txe_factura_ini_fin.Mask.EditMask = "\\d{0,9}";
            this.txe_factura_ini_fin.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txe_factura_ini_fin.Name = "txe_factura_ini_fin";
            // 
            // colfactura_final
            // 
            this.colfactura_final.Caption = "Factura Final";
            this.colfactura_final.ColumnEdit = this.txe_factura_ini_fin;
            this.colfactura_final.FieldName = "factura_final";
            this.colfactura_final.Name = "colfactura_final";
            this.colfactura_final.Visible = true;
            this.colfactura_final.VisibleIndex = 5;
            this.colfactura_final.Width = 144;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 6;
            this.Estado.Width = 164;
            // 
            // colIdAutorizacion
            // 
            this.colIdAutorizacion.FieldName = "IdAutorizacion";
            this.colIdAutorizacion.Name = "colIdAutorizacion";
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Image = global::Core.Erp.Winform.Properties.Resources.editar1_16x16;
            this.btn_Actualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(79, 22);
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // UCCP_Proveedor_Autoriza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl_AutoriProvee);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UCCP_Proveedor_Autoriza";
            this.Size = new System.Drawing.Size(740, 282);
            this.Load += new System.EventHandler(this.UCCP_Proveedor_Autoriza_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_AutoriProvee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_AutoriProvee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_nAutoriza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_serie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_factura_ini_fin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl gridControl_AutoriProvee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_AutoriProvee;
        private System.Windows.Forms.ToolStripButton btn_Nuevo;
        private System.Windows.Forms.ToolStripButton btn_Seleccionar;
        private System.Windows.Forms.ToolStripButton btn_Salir;
        private DevExpress.XtraGrid.Columns.GridColumn colnAutorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colValido_Hasta;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie1;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie2;
        private DevExpress.XtraGrid.Columns.GridColumn colfactura_inicial;
        private DevExpress.XtraGrid.Columns.GridColumn colfactura_final;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAutorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txe_nAutoriza;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txe_serie;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txe_factura_ini_fin;
        private System.Windows.Forms.ToolStripButton btn_Actualizar;
    }
}
