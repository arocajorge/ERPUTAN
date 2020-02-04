namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Disponibilidad_Inventario
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
            DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ctrl_Suc_Bod = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpFecha = new DevExpress.XtraEditors.DateEdit();
            this.pnlCategorias = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.spInDispInventarioInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpresaSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursalSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodegaSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProductoSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbo_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_Categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_Pedidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisponibles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImagen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BTProcesar = new System.Windows.Forms.ToolStripButton();
            this.btImprimir = new System.Windows.Forms.ToolStripButton();
            this.btSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spInDispInventarioInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemPictureEdit1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.toolStrip1);
            this.panelControl1.Controls.Add(this.ctrl_Suc_Bod);
            this.panelControl1.Controls.Add(this.checkEdit1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dtpFecha);
            this.panelControl1.Controls.Add(this.pnlCategorias);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(991, 145);
            this.panelControl1.TabIndex = 0;
            // 
            // ctrl_Suc_Bod
            // 
            this.ctrl_Suc_Bod.Location = new System.Drawing.Point(12, 66);
            this.ctrl_Suc_Bod.Name = "ctrl_Suc_Bod";
            this.ctrl_Suc_Bod.Size = new System.Drawing.Size(467, 51);
            this.ctrl_Suc_Bod.TabIndex = 4;
            this.ctrl_Suc_Bod.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.todos;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(112, 41);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "checkEdit1";
            this.checkEdit1.Size = new System.Drawing.Size(21, 19);
            this.checkEdit1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Fecha de Corte";
            // 
            // dtpFecha
            // 
            this.dtpFecha.EditValue = null;
            this.dtpFecha.Location = new System.Drawing.Point(139, 40);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpFecha.Size = new System.Drawing.Size(162, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // pnlCategorias
            // 
            this.pnlCategorias.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCategorias.Location = new System.Drawing.Point(772, 2);
            this.pnlCategorias.Name = "pnlCategorias";
            this.pnlCategorias.Size = new System.Drawing.Size(217, 141);
            this.pnlCategorias.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 145);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(991, 304);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.spInDispInventarioInfoBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 2);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(987, 300);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // spInDispInventarioInfoBindingSource
            // 
            this.spInDispInventarioInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.SpIn_DispInventario_Info);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpresaSi,
            this.colIdSucursalSi,
            this.colIdBodegaSi,
            this.colIdProductoSi,
            this.colSu_Descripcion,
            this.colbo_Descripcion,
            this.colpr_descripcion,
            this.colIdCategoria,
            this.colca_Categoria,
            this.colstock,
            this.colpr_Pedidos,
            this.colIdUsuario,
            this.colpr_codigo,
            this.colDisponibles,
            this.colImagen});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_RowCellClick);
            // 
            // colEmpresaSi
            // 
            this.colEmpresaSi.FieldName = "EmpresaSi";
            this.colEmpresaSi.Name = "colEmpresaSi";
            // 
            // colIdSucursalSi
            // 
            this.colIdSucursalSi.FieldName = "IdSucursalSi";
            this.colIdSucursalSi.Name = "colIdSucursalSi";
            // 
            // colIdBodegaSi
            // 
            this.colIdBodegaSi.FieldName = "IdBodegaSi";
            this.colIdBodegaSi.Name = "colIdBodegaSi";
            // 
            // colIdProductoSi
            // 
            this.colIdProductoSi.FieldName = "IdProductoSi";
            this.colIdProductoSi.Name = "colIdProductoSi";
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Sucursal";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 0;
            this.colSu_Descripcion.Width = 107;
            // 
            // colbo_Descripcion
            // 
            this.colbo_Descripcion.Caption = "Bodega";
            this.colbo_Descripcion.FieldName = "bo_Descripcion";
            this.colbo_Descripcion.Name = "colbo_Descripcion";
            this.colbo_Descripcion.Visible = true;
            this.colbo_Descripcion.VisibleIndex = 1;
            this.colbo_Descripcion.Width = 107;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Item";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 3;
            this.colpr_descripcion.Width = 107;
            // 
            // colIdCategoria
            // 
            this.colIdCategoria.FieldName = "IdCategoria";
            this.colIdCategoria.Name = "colIdCategoria";
            // 
            // colca_Categoria
            // 
            this.colca_Categoria.Caption = "Categoria";
            this.colca_Categoria.FieldName = "ca_Categoria";
            this.colca_Categoria.Name = "colca_Categoria";
            this.colca_Categoria.Visible = true;
            this.colca_Categoria.VisibleIndex = 4;
            this.colca_Categoria.Width = 107;
            // 
            // colstock
            // 
            this.colstock.Caption = "Stock";
            this.colstock.FieldName = "stock";
            this.colstock.Name = "colstock";
            this.colstock.Visible = true;
            this.colstock.VisibleIndex = 5;
            this.colstock.Width = 107;
            // 
            // colpr_Pedidos
            // 
            this.colpr_Pedidos.Caption = "Pedidos";
            this.colpr_Pedidos.FieldName = "pr_Pedidos";
            this.colpr_Pedidos.Name = "colpr_Pedidos";
            this.colpr_Pedidos.Visible = true;
            this.colpr_Pedidos.VisibleIndex = 6;
            this.colpr_Pedidos.Width = 107;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colpr_codigo
            // 
            this.colpr_codigo.Caption = "Codigo";
            this.colpr_codigo.FieldName = "pr_codigo";
            this.colpr_codigo.Name = "colpr_codigo";
            this.colpr_codigo.Visible = true;
            this.colpr_codigo.VisibleIndex = 2;
            this.colpr_codigo.Width = 107;
            // 
            // colDisponibles
            // 
            this.colDisponibles.FieldName = "Disponibles";
            this.colDisponibles.Name = "colDisponibles";
            this.colDisponibles.Visible = true;
            this.colDisponibles.VisibleIndex = 7;
            this.colDisponibles.Width = 195;
            // 
            // colImagen
            // 
            this.colImagen.Caption = " ";
            repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.colImagen.ColumnEdit = repositoryItemPictureEdit1;
            this.colImagen.FieldName = "Imagen";
            this.colImagen.Name = "colImagen";
            this.colImagen.Visible = true;
            this.colImagen.VisibleIndex = 8;
            this.colImagen.Width = 25;
            // 
            // BTProcesar
            // 
            this.BTProcesar.Image = global::Core.Erp.Winform.Properties.Resources.Refres;
            this.BTProcesar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTProcesar.Name = "BTProcesar";
            this.BTProcesar.Size = new System.Drawing.Size(78, 22);
            this.BTProcesar.Text = "Consultar";
            this.BTProcesar.Click += new System.EventHandler(this.BTProcesar_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.Image = global::Core.Erp.Winform.Properties.Resources.imprimir;
            this.btImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(73, 22);
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btSalir
            // 
            this.btSalir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.btSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(49, 22);
            this.btSalir.Text = "Salir";
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTProcesar,
            this.btImprimir,
            this.btSalir});
            this.toolStrip1.Location = new System.Drawing.Point(2, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(770, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FrmIn_Disponibilidad_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 449);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmIn_Disponibilidad_Inventario";
            this.Text = "Disponibilidad De Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spInDispInventarioInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemPictureEdit1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtpFecha;
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.BindingSource spInDispInventarioInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresaSi;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursalSi;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodegaSi;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProductoSi;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colbo_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colca_Categoria;
        private DevExpress.XtraGrid.Columns.GridColumn colstock;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_Pedidos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private Controles.UCIn_Sucursal_Bodega ctrl_Suc_Bod;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDisponibles;
        private DevExpress.XtraGrid.Columns.GridColumn colImagen;
        private DevExpress.XtraEditors.PanelControl pnlCategorias;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTProcesar;
        private System.Windows.Forms.ToolStripButton btImprimir;
        private System.Windows.Forms.ToolStripButton btSalir;
    }
}