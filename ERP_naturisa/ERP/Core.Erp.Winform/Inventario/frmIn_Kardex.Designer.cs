namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Kardex
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btn_Procesar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbfechas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIncial = new System.Windows.Forms.DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProductos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovi_inven_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNumMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_tipo_movi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_stock_ante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_stock_actu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_precio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodMoviInven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTipoMoviInven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoMoviInven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_IdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_IdOrdenCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_Secuencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_NumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelSucuBod = new System.Windows.Forms.Panel();
            this.colpr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.gbfechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1031, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btn_Procesar
            // 
            this.btn_Procesar.Location = new System.Drawing.Point(18, 230);
            this.btn_Procesar.Name = "btn_Procesar";
            this.btn_Procesar.Size = new System.Drawing.Size(75, 23);
            this.btn_Procesar.TabIndex = 7;
            this.btn_Procesar.Text = "Procesar";
            this.btn_Procesar.UseVisualStyleBackColor = true;
            this.btn_Procesar.Click += new System.EventHandler(this.btn_Procesar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto:";
            // 
            // gbfechas
            // 
            this.gbfechas.Controls.Add(this.label2);
            this.gbfechas.Controls.Add(this.label1);
            this.gbfechas.Controls.Add(this.dtpFechaFinal);
            this.gbfechas.Controls.Add(this.dtpFechaIncial);
            this.gbfechas.Location = new System.Drawing.Point(6, 30);
            this.gbfechas.Name = "gbfechas";
            this.gbfechas.Size = new System.Drawing.Size(214, 121);
            this.gbfechas.TabIndex = 1;
            this.gbfechas.TabStop = false;
            this.gbfechas.Text = "Rango de Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde:";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(9, 85);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 1;
            // 
            // dtpFechaIncial
            // 
            this.dtpFechaIncial.Location = new System.Drawing.Point(9, 42);
            this.dtpFechaIncial.Name = "dtpFechaIncial";
            this.dtpFechaIncial.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIncial.TabIndex = 0;
            this.dtpFechaIncial.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panelSucuBod);
            this.splitContainer1.Size = new System.Drawing.Size(1031, 570);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Procesar);
            this.groupBox1.Controls.Add(this.cmbProductos);
            this.groupBox1.Controls.Add(this.gbfechas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 570);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // cmbProductos
            // 
            this.cmbProductos.Location = new System.Drawing.Point(18, 193);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProductos.Properties.DisplayMember = "Descripcion";
            this.cmbProductos.Properties.ValueMember = "IdProducto";
            this.cmbProductos.Properties.View = this.searchLookUpEdit1View;
            this.cmbProductos.Size = new System.Drawing.Size(206, 20);
            this.cmbProductos.TabIndex = 8;
            this.cmbProductos.EditValueChanged += new System.EventHandler(this.searchLookUpEdit1_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 501);
            this.panel2.TabIndex = 3;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(789, 501);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdBodega,
            this.colIdMovi_inven_tipo,
            this.colIdNumMovi,
            this.colBodega,
            this.colSecuencia,
            this.colmv_tipo_movi,
            this.colIdProducto,
            this.coldm_cantidad,
            this.coldm_stock_ante,
            this.coldm_stock_actu,
            this.coldm_observacion,
            this.coldm_precio,
            this.colmv_costo,
            this.colpeso,
            this.colCodProducto,
            this.colNomProducto,
            this.colMarca,
            this.colcategoria,
            this.colFecha,
            this.colSucursal,
            this.colCodMoviInven,
            this.colCodTipoMoviInven,
            this.colTipoMoviInven,
            this.coloc_IdEmpresa,
            this.coloc_IdSucursal,
            this.coloc_IdOrdenCompra,
            this.coloc_Secuencial,
            this.coloc_NumDocumento,
            this.coloc_observacion,
            this.colCodBarra,
            this.colvalida,
            this.colcm_fecha,
            this.colexistencia});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            // 
            // colIdBodega
            // 
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            // 
            // colIdMovi_inven_tipo
            // 
            this.colIdMovi_inven_tipo.FieldName = "IdMovi_inven_tipo";
            this.colIdMovi_inven_tipo.Name = "colIdMovi_inven_tipo";
            // 
            // colIdNumMovi
            // 
            this.colIdNumMovi.FieldName = "IdNumMovi";
            this.colIdNumMovi.Name = "colIdNumMovi";
            // 
            // colBodega
            // 
            this.colBodega.FieldName = "Bodega";
            this.colBodega.Name = "colBodega";
            this.colBodega.Visible = true;
            this.colBodega.VisibleIndex = 2;
            // 
            // colSecuencia
            // 
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            // 
            // colmv_tipo_movi
            // 
            this.colmv_tipo_movi.Caption = "Tipo";
            this.colmv_tipo_movi.FieldName = "mv_tipo_movi";
            this.colmv_tipo_movi.Name = "colmv_tipo_movi";
            this.colmv_tipo_movi.Visible = true;
            this.colmv_tipo_movi.VisibleIndex = 4;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            // 
            // coldm_cantidad
            // 
            this.coldm_cantidad.Caption = "Cantidad";
            this.coldm_cantidad.FieldName = "dm_cantidad";
            this.coldm_cantidad.Name = "coldm_cantidad";
            this.coldm_cantidad.Visible = true;
            this.coldm_cantidad.VisibleIndex = 6;
            // 
            // coldm_stock_ante
            // 
            this.coldm_stock_ante.FieldName = "dm_stock_ante";
            this.coldm_stock_ante.Name = "coldm_stock_ante";
            // 
            // coldm_stock_actu
            // 
            this.coldm_stock_actu.FieldName = "dm_stock_actu";
            this.coldm_stock_actu.Name = "coldm_stock_actu";
            // 
            // coldm_observacion
            // 
            this.coldm_observacion.FieldName = "dm_observacion";
            this.coldm_observacion.Name = "coldm_observacion";
            // 
            // coldm_precio
            // 
            this.coldm_precio.FieldName = "dm_precio";
            this.coldm_precio.Name = "coldm_precio";
            // 
            // colmv_costo
            // 
            this.colmv_costo.FieldName = "mv_costo";
            this.colmv_costo.Name = "colmv_costo";
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso";
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 7;
            // 
            // colCodProducto
            // 
            this.colCodProducto.FieldName = "CodProducto";
            this.colCodProducto.Name = "colCodProducto";
            // 
            // colNomProducto
            // 
            this.colNomProducto.Caption = "Producto";
            this.colNomProducto.FieldName = "NomProducto";
            this.colNomProducto.Name = "colNomProducto";
            this.colNomProducto.Visible = true;
            this.colNomProducto.VisibleIndex = 5;
            // 
            // colMarca
            // 
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            // 
            // colcategoria
            // 
            this.colcategoria.FieldName = "categoria";
            this.colcategoria.Name = "colcategoria";
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            // 
            // colSucursal
            // 
            this.colSucursal.FieldName = "Sucursal";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.Visible = true;
            this.colSucursal.VisibleIndex = 1;
            // 
            // colCodMoviInven
            // 
            this.colCodMoviInven.FieldName = "CodMoviInven";
            this.colCodMoviInven.Name = "colCodMoviInven";
            // 
            // colCodTipoMoviInven
            // 
            this.colCodTipoMoviInven.FieldName = "CodTipoMoviInven";
            this.colCodTipoMoviInven.Name = "colCodTipoMoviInven";
            // 
            // colTipoMoviInven
            // 
            this.colTipoMoviInven.FieldName = "TipoMoviInven";
            this.colTipoMoviInven.Name = "colTipoMoviInven";
            this.colTipoMoviInven.Visible = true;
            this.colTipoMoviInven.VisibleIndex = 3;
            // 
            // coloc_IdEmpresa
            // 
            this.coloc_IdEmpresa.FieldName = "oc_IdEmpresa";
            this.coloc_IdEmpresa.Name = "coloc_IdEmpresa";
            // 
            // coloc_IdSucursal
            // 
            this.coloc_IdSucursal.FieldName = "oc_IdSucursal";
            this.coloc_IdSucursal.Name = "coloc_IdSucursal";
            // 
            // coloc_IdOrdenCompra
            // 
            this.coloc_IdOrdenCompra.FieldName = "oc_IdOrdenCompra";
            this.coloc_IdOrdenCompra.Name = "coloc_IdOrdenCompra";
            // 
            // coloc_Secuencial
            // 
            this.coloc_Secuencial.FieldName = "oc_Secuencial";
            this.coloc_Secuencial.Name = "coloc_Secuencial";
            // 
            // coloc_NumDocumento
            // 
            this.coloc_NumDocumento.FieldName = "oc_NumDocumento";
            this.coloc_NumDocumento.Name = "coloc_NumDocumento";
            // 
            // coloc_observacion
            // 
            this.coloc_observacion.FieldName = "oc_observacion";
            this.coloc_observacion.Name = "coloc_observacion";
            // 
            // colCodBarra
            // 
            this.colCodBarra.FieldName = "CodBarra";
            this.colCodBarra.Name = "colCodBarra";
            // 
            // colvalida
            // 
            this.colvalida.FieldName = "valida";
            this.colvalida.Name = "colvalida";
            // 
            // colcm_fecha
            // 
            this.colcm_fecha.FieldName = "cm_fecha";
            this.colcm_fecha.Name = "colcm_fecha";
            // 
            // colexistencia
            // 
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.Name = "colexistencia";
            // 
            // panelSucuBod
            // 
            this.panelSucuBod.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSucuBod.Location = new System.Drawing.Point(0, 0);
            this.panelSucuBod.Name = "panelSucuBod";
            this.panelSucuBod.Size = new System.Drawing.Size(789, 69);
            this.panelSucuBod.TabIndex = 2;
            // 
            // colpr_codigo
            // 
            this.colpr_codigo.Caption = "Codigo";
            this.colpr_codigo.FieldName = "pr_codigo";
            this.colpr_codigo.Name = "colpr_codigo";
            this.colpr_codigo.Visible = true;
            this.colpr_codigo.VisibleIndex = 0;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Descripcion";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 1;
            // 
            // colpr_descripcion1
            // 
            this.colpr_descripcion1.Caption = "Descripcion";
            this.colpr_descripcion1.FieldName = "pr_descripcion";
            this.colpr_descripcion1.Name = "colpr_descripcion1";
            this.colpr_descripcion1.Visible = true;
            this.colpr_descripcion1.VisibleIndex = 1;
            // 
            // colpr_codigo1
            // 
            this.colpr_codigo1.Caption = "Codigo";
            this.colpr_codigo1.FieldName = "pr_codigo";
            this.colpr_codigo1.Name = "colpr_codigo1";
            this.colpr_codigo1.Visible = true;
            this.colpr_codigo1.VisibleIndex = 0;
            // 
            // frmIn_Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 595);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmIn_Kardex";
            this.Text = "Kardex de Productos";
            this.Load += new System.EventHandler(this.frmIn_Kardex_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbfechas.ResumeLayout(false);
            this.gbfechas.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox gbfechas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaIncial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button btn_Procesar;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Panel panelSucuBod;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovi_inven_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNumMovi;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_tipo_movi;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_stock_ante;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_stock_actu;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_precio;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colNomProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colcategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colCodMoviInven;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTipoMoviInven;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoMoviInven;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_IdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_IdOrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_Secuencial;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_NumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colCodBarra;
        private DevExpress.XtraGrid.Columns.GridColumn colvalida;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo1;
    }
}