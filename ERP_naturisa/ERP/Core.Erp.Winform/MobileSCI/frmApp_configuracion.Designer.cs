namespace Core.Erp.Winform.MobileSCI
{
    partial class frmApp_configuracion
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_empresa = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_guardar_salir = new System.Windows.Forms.ToolStripButton();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tb_bodega = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlBodegas = new DevExpress.XtraGrid.GridControl();
            this.gridViewBodegas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.chk_bodegas = new System.Windows.Forms.CheckBox();
            this.tb_subcentros = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlSubcentros = new DevExpress.XtraGrid.GridControl();
            this.gridViewSubcentros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_subcentro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.chk_subcentros = new System.Windows.Forms.CheckBox();
            this.tb_productos = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlProductos = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.chk_productos = new System.Windows.Forms.CheckBox();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Winform.frmGe_Esperar), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tb_bodega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.tb_subcentros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSubcentros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubcentros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.tb_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmb_empresa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(839, 46);
            this.panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empresa";
            // 
            // cmb_empresa
            // 
            this.cmb_empresa.Location = new System.Drawing.Point(86, 13);
            this.cmb_empresa.Name = "cmb_empresa";
            this.cmb_empresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_empresa.Properties.DisplayMember = "em_nombre";
            this.cmb_empresa.Properties.ValueMember = "IdEmpresa";
            this.cmb_empresa.Properties.View = this.searchLookUpEdit1View;
            this.cmb_empresa.Size = new System.Drawing.Size(372, 20);
            this.cmb_empresa.TabIndex = 2;
            this.cmb_empresa.EditValueChanged += new System.EventHandler(this.cmb_empresa_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdEmpresa";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Empresa";
            this.gridColumn2.FieldName = "em_nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 660;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.btn_guardar_salir,
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(839, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::Core.Erp.Winform.Properties.Resources.guardar_32x32;
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(69, 22);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_guardar_salir
            // 
            this.btn_guardar_salir.Image = global::Core.Erp.Winform.Properties.Resources.guardarysalir1;
            this.btn_guardar_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar_salir.Name = "btn_guardar_salir";
            this.btn_guardar_salir.Size = new System.Drawing.Size(102, 22);
            this.btn_guardar_salir.Text = "Guardar y salir";
            this.btn_guardar_salir.Click += new System.EventHandler(this.btn_guardar_salir_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::Core.Erp.Winform.Properties.Resources.salir_32x32;
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 71);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tb_bodega;
            this.xtraTabControl1.Size = new System.Drawing.Size(839, 629);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tb_bodega,
            this.tb_subcentros,
            this.tb_productos});
            // 
            // tb_bodega
            // 
            this.tb_bodega.Controls.Add(this.gridControlBodegas);
            this.tb_bodega.Controls.Add(this.panelControl2);
            this.tb_bodega.Name = "tb_bodega";
            this.tb_bodega.Size = new System.Drawing.Size(833, 601);
            this.tb_bodega.Text = "Bodegas";
            // 
            // gridControlBodegas
            // 
            this.gridControlBodegas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBodegas.Location = new System.Drawing.Point(0, 26);
            this.gridControlBodegas.MainView = this.gridViewBodegas;
            this.gridControlBodegas.Name = "gridControlBodegas";
            this.gridControlBodegas.Size = new System.Drawing.Size(833, 575);
            this.gridControlBodegas.TabIndex = 1;
            this.gridControlBodegas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBodegas});
            // 
            // gridViewBodegas
            // 
            this.gridViewBodegas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_bodega,
            this.gridColumn4,
            this.gridColumn5});
            this.gridViewBodegas.CustomizationFormBounds = new System.Drawing.Rectangle(796, 401, 216, 192);
            this.gridViewBodegas.GridControl = this.gridControlBodegas;
            this.gridViewBodegas.Name = "gridViewBodegas";
            this.gridViewBodegas.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBodegas.OptionsView.ShowGroupPanel = false;
            // 
            // col_bodega
            // 
            this.col_bodega.Caption = "*";
            this.col_bodega.FieldName = "seleccionado";
            this.col_bodega.Name = "col_bodega";
            this.col_bodega.Visible = true;
            this.col_bodega.VisibleIndex = 0;
            this.col_bodega.Width = 41;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Sucursal";
            this.gridColumn4.FieldName = "nom_sucursal";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 311;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Bodega";
            this.gridColumn5.FieldName = "nom_bodega";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 420;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.chk_bodegas);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(833, 26);
            this.panelControl2.TabIndex = 2;
            // 
            // chk_bodegas
            // 
            this.chk_bodegas.AutoSize = true;
            this.chk_bodegas.Location = new System.Drawing.Point(27, 5);
            this.chk_bodegas.Name = "chk_bodegas";
            this.chk_bodegas.Size = new System.Drawing.Size(117, 17);
            this.chk_bodegas.TabIndex = 0;
            this.chk_bodegas.Text = "Seleccionar visibles";
            this.chk_bodegas.UseVisualStyleBackColor = true;
            this.chk_bodegas.CheckedChanged += new System.EventHandler(this.chk_bodegas_CheckedChanged);
            // 
            // tb_subcentros
            // 
            this.tb_subcentros.Controls.Add(this.gridControlSubcentros);
            this.tb_subcentros.Controls.Add(this.panelControl3);
            this.tb_subcentros.Name = "tb_subcentros";
            this.tb_subcentros.Size = new System.Drawing.Size(833, 601);
            this.tb_subcentros.Text = "Sub centros";
            // 
            // gridControlSubcentros
            // 
            this.gridControlSubcentros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSubcentros.Location = new System.Drawing.Point(0, 26);
            this.gridControlSubcentros.MainView = this.gridViewSubcentros;
            this.gridControlSubcentros.Name = "gridControlSubcentros";
            this.gridControlSubcentros.Size = new System.Drawing.Size(833, 575);
            this.gridControlSubcentros.TabIndex = 2;
            this.gridControlSubcentros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSubcentros});
            // 
            // gridViewSubcentros
            // 
            this.gridViewSubcentros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_subcentro,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn10});
            this.gridViewSubcentros.CustomizationFormBounds = new System.Drawing.Rectangle(796, 401, 216, 192);
            this.gridViewSubcentros.GridControl = this.gridControlSubcentros;
            this.gridViewSubcentros.Name = "gridViewSubcentros";
            this.gridViewSubcentros.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSubcentros.OptionsView.ShowGroupPanel = false;
            // 
            // col_subcentro
            // 
            this.col_subcentro.Caption = "*";
            this.col_subcentro.FieldName = "seleccionado";
            this.col_subcentro.Name = "col_subcentro";
            this.col_subcentro.Visible = true;
            this.col_subcentro.VisibleIndex = 0;
            this.col_subcentro.Width = 37;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Centro de costo";
            this.gridColumn6.FieldName = "nom_centro";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 239;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Sub centro de costos";
            this.gridColumn7.FieldName = "nom_subcentro";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 439;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Cod. producción";
            this.gridColumn10.FieldName = "mobile_cod_produccion";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            this.gridColumn10.Width = 100;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.chk_subcentros);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(833, 26);
            this.panelControl3.TabIndex = 3;
            // 
            // chk_subcentros
            // 
            this.chk_subcentros.AutoSize = true;
            this.chk_subcentros.Location = new System.Drawing.Point(27, 5);
            this.chk_subcentros.Name = "chk_subcentros";
            this.chk_subcentros.Size = new System.Drawing.Size(117, 17);
            this.chk_subcentros.TabIndex = 0;
            this.chk_subcentros.Text = "Seleccionar visibles";
            this.chk_subcentros.UseVisualStyleBackColor = true;
            this.chk_subcentros.CheckedChanged += new System.EventHandler(this.chk_subcentros_CheckedChanged);
            // 
            // tb_productos
            // 
            this.tb_productos.Controls.Add(this.gridControlProductos);
            this.tb_productos.Controls.Add(this.panelControl4);
            this.tb_productos.Name = "tb_productos";
            this.tb_productos.Size = new System.Drawing.Size(833, 601);
            this.tb_productos.Text = "Productos";
            // 
            // gridControlProductos
            // 
            this.gridControlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductos.Location = new System.Drawing.Point(0, 26);
            this.gridControlProductos.MainView = this.gridViewProductos;
            this.gridControlProductos.Name = "gridControlProductos";
            this.gridControlProductos.Size = new System.Drawing.Size(833, 575);
            this.gridControlProductos.TabIndex = 3;
            this.gridControlProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductos});
            // 
            // gridViewProductos
            // 
            this.gridViewProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_producto,
            this.gridColumn8,
            this.gridColumn3,
            this.gridColumn9,
            this.gridColumn11});
            this.gridViewProductos.CustomizationFormBounds = new System.Drawing.Rectangle(796, 401, 216, 192);
            this.gridViewProductos.GridControl = this.gridControlProductos;
            this.gridViewProductos.Name = "gridViewProductos";
            this.gridViewProductos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProductos.OptionsView.ShowGroupPanel = false;
            // 
            // col_producto
            // 
            this.col_producto.Caption = "*";
            this.col_producto.FieldName = "seleccionado";
            this.col_producto.Name = "col_producto";
            this.col_producto.Visible = true;
            this.col_producto.VisibleIndex = 0;
            this.col_producto.Width = 60;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Producto";
            this.gridColumn8.FieldName = "nom_producto";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 798;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Categoria";
            this.gridColumn3.FieldName = "nom_categoria";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 396;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Linea";
            this.gridColumn9.FieldName = "nom_linea";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            this.gridColumn9.Width = 302;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Cod. Producción";
            this.gridColumn11.FieldName = "mobile_cod_produccion";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 3;
            this.gridColumn11.Width = 178;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.chk_productos);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(833, 26);
            this.panelControl4.TabIndex = 4;
            // 
            // chk_productos
            // 
            this.chk_productos.AutoSize = true;
            this.chk_productos.Location = new System.Drawing.Point(27, 5);
            this.chk_productos.Name = "chk_productos";
            this.chk_productos.Size = new System.Drawing.Size(117, 17);
            this.chk_productos.TabIndex = 0;
            this.chk_productos.Text = "Seleccionar visibles";
            this.chk_productos.UseVisualStyleBackColor = true;
            this.chk_productos.CheckedChanged += new System.EventHandler(this.chk_productos_CheckedChanged);
            // 
            // frmApp_configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 700);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmApp_configuracion";
            this.Text = "Configuración APP";
            this.Load += new System.EventHandler(this.frmApp_configuracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tb_bodega.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBodegas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBodegas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.tb_subcentros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSubcentros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubcentros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.tb_productos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btn_guardar_salir;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_empresa;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tb_bodega;
        private DevExpress.XtraTab.XtraTabPage tb_subcentros;
        private DevExpress.XtraGrid.GridControl gridControlBodegas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBodegas;
        private DevExpress.XtraGrid.GridControl gridControlSubcentros;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSubcentros;
        private DevExpress.XtraTab.XtraTabPage tb_productos;
        private DevExpress.XtraGrid.GridControl gridControlProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductos;
        private DevExpress.XtraGrid.Columns.GridColumn col_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.CheckBox chk_bodegas;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.CheckBox chk_subcentros;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.CheckBox chk_productos;
        private DevExpress.XtraGrid.Columns.GridColumn col_subcentro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn col_producto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}