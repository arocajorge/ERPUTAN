namespace Core.Erp.Winform.Compras
{
    partial class FrmPrd_CotizacionCompra_Mantenimiento
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_Sucursal_combo1 = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.ucCp_Proveedor1 = new Core.Erp.Winform.Controles.UCCp_Proveedor();
            this.LbProveedor = new System.Windows.Forms.Label();
            this.dtpFechareg = new System.Windows.Forms.DateTimePicker();
            this.LbFecha = new System.Windows.Forms.Label();
            this.txtnumcotizaion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlcotizamant = new DevExpress.XtraGrid.GridControl();
            this.gridViewcotizamant = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCant_soli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCant_a_cotizar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdListadoMateriales_lq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbcategoria = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colca_Categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCategoria_cmb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlcotizamant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewcotizamant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbcategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(896, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_Superior_Mant1_event_btnAnular_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "# Cotizacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sucursal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Observacion:";
            // 
            // txtobservacion
            // 
            this.txtobservacion.Location = new System.Drawing.Point(87, 60);
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(673, 32);
            this.txtobservacion.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucGe_Sucursal_combo1);
            this.panel2.Controls.Add(this.ucCp_Proveedor1);
            this.panel2.Controls.Add(this.LbProveedor);
            this.panel2.Controls.Add(this.dtpFechareg);
            this.panel2.Controls.Add(this.LbFecha);
            this.panel2.Controls.Add(this.txtnumcotizaion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtobservacion);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 100);
            this.panel2.TabIndex = 9;
            // 
            // ucGe_Sucursal_combo1
            // 
            this.ucGe_Sucursal_combo1.Location = new System.Drawing.Point(302, 6);
            this.ucGe_Sucursal_combo1.Name = "ucGe_Sucursal_combo1";
            this.ucGe_Sucursal_combo1.Size = new System.Drawing.Size(253, 22);
            this.ucGe_Sucursal_combo1.TabIndex = 104;
            // 
            // ucCp_Proveedor1
            // 
            this.ucCp_Proveedor1.Location = new System.Drawing.Point(87, 28);
            this.ucCp_Proveedor1.Name = "ucCp_Proveedor1";
            this.ucCp_Proveedor1.Size = new System.Drawing.Size(472, 29);
            this.ucCp_Proveedor1.TabIndex = 103;
            // 
            // LbProveedor
            // 
            this.LbProveedor.AutoSize = true;
            this.LbProveedor.Location = new System.Drawing.Point(5, 34);
            this.LbProveedor.Name = "LbProveedor";
            this.LbProveedor.Size = new System.Drawing.Size(50, 13);
            this.LbProveedor.TabIndex = 102;
            this.LbProveedor.Text = "Provedor";
            // 
            // dtpFechareg
            // 
            this.dtpFechareg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechareg.Location = new System.Drawing.Point(608, 6);
            this.dtpFechareg.Name = "dtpFechareg";
            this.dtpFechareg.Size = new System.Drawing.Size(140, 20);
            this.dtpFechareg.TabIndex = 101;
            // 
            // LbFecha
            // 
            this.LbFecha.AutoSize = true;
            this.LbFecha.Location = new System.Drawing.Point(565, 9);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(37, 13);
            this.LbFecha.TabIndex = 10;
            this.LbFecha.Text = "Fecha";
            // 
            // txtnumcotizaion
            // 
            this.txtnumcotizaion.Location = new System.Drawing.Point(87, 6);
            this.txtnumcotizaion.Name = "txtnumcotizaion";
            this.txtnumcotizaion.Size = new System.Drawing.Size(151, 20);
            this.txtnumcotizaion.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControlcotizamant);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 382);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos a Filtrar";
            // 
            // gridControlcotizamant
            // 
            this.gridControlcotizamant.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlcotizamant.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlcotizamant.Location = new System.Drawing.Point(3, 45);
            this.gridControlcotizamant.MainView = this.gridViewcotizamant;
            this.gridControlcotizamant.Name = "gridControlcotizamant";
            this.gridControlcotizamant.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemImageComboBox3});
            this.gridControlcotizamant.Size = new System.Drawing.Size(890, 334);
            this.gridControlcotizamant.TabIndex = 12;
            this.gridControlcotizamant.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewcotizamant});
            // 
            // gridViewcotizamant
            // 
            this.gridViewcotizamant.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Check,
            this.colCant_soli,
            this.colCant_a_cotizar,
            this.colIdListadoMateriales_lq,
            this.colpr_descripcion,
            this.colsaldo});
            this.gridViewcotizamant.GridControl = this.gridControlcotizamant;
            this.gridViewcotizamant.Name = "gridViewcotizamant";
            this.gridViewcotizamant.OptionsFind.AlwaysVisible = true;
            this.gridViewcotizamant.OptionsView.ShowAutoFilterRow = true;
            this.gridViewcotizamant.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewcotizamant_CellValueChanged);
            // 
            // col_Check
            // 
            this.col_Check.Caption = "*";
            this.col_Check.FieldName = "Check";
            this.col_Check.Name = "col_Check";
            this.col_Check.Visible = true;
            this.col_Check.VisibleIndex = 0;
            this.col_Check.Width = 90;
            // 
            // colCant_soli
            // 
            this.colCant_soli.Caption = "Cant Solicita";
            this.colCant_soli.FieldName = "Cant_soli";
            this.colCant_soli.Name = "colCant_soli";
            this.colCant_soli.Visible = true;
            this.colCant_soli.VisibleIndex = 3;
            this.colCant_soli.Width = 208;
            // 
            // colCant_a_cotizar
            // 
            this.colCant_a_cotizar.Caption = "Cantidad Cotiza";
            this.colCant_a_cotizar.FieldName = "Cant_a_cotizar";
            this.colCant_a_cotizar.Name = "colCant_a_cotizar";
            this.colCant_a_cotizar.Visible = true;
            this.colCant_a_cotizar.VisibleIndex = 4;
            this.colCant_a_cotizar.Width = 208;
            // 
            // colIdListadoMateriales_lq
            // 
            this.colIdListadoMateriales_lq.Caption = "Listado Materiales";
            this.colIdListadoMateriales_lq.FieldName = "IdListadoMateriales_lq";
            this.colIdListadoMateriales_lq.Name = "colIdListadoMateriales_lq";
            this.colIdListadoMateriales_lq.Visible = true;
            this.colIdListadoMateriales_lq.VisibleIndex = 1;
            this.colIdListadoMateriales_lq.Width = 208;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Descripcion";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 2;
            this.colpr_descripcion.Width = 208;
            // 
            // colsaldo
            // 
            this.colsaldo.Caption = "Saldo";
            this.colsaldo.FieldName = "saldo";
            this.colsaldo.Name = "colsaldo";
            this.colsaldo.Visible = true;
            this.colsaldo.VisibleIndex = 5;
            this.colsaldo.Width = 216;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 2)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // repositoryItemImageComboBox3
            // 
            this.repositoryItemImageComboBox3.AutoHeight = false;
            this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox3.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", false, 3)});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbcategoria);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 29);
            this.panel1.TabIndex = 11;
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.Location = new System.Drawing.Point(84, 3);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbcategoria.Properties.View = this.gridView1;
            this.cmbcategoria.Size = new System.Drawing.Size(131, 20);
            this.cmbcategoria.TabIndex = 10;
            this.cmbcategoria.EditValueChanged += new System.EventHandler(this.cmbcategoria_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colca_Categoria,
            this.colIdCategoria_cmb});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colca_Categoria
            // 
            this.colca_Categoria.Caption = "Categoría";
            this.colca_Categoria.FieldName = "ca_Categoria";
            this.colca_Categoria.Name = "colca_Categoria";
            this.colca_Categoria.Visible = true;
            this.colca_Categoria.VisibleIndex = 0;
            this.colca_Categoria.Width = 750;
            // 
            // colIdCategoria_cmb
            // 
            this.colIdCategoria_cmb.Caption = "ID";
            this.colIdCategoria_cmb.FieldName = "IdCategoria";
            this.colIdCategoria_cmb.Name = "colIdCategoria_cmb";
            this.colIdCategoria_cmb.Visible = true;
            this.colIdCategoria_cmb.VisibleIndex = 1;
            this.colIdCategoria_cmb.Width = 324;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Categoria:";
            // 
            // FrmPrd_CotizacionCompra_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "FrmPrd_CotizacionCompra_Mantenimiento";
            this.Text = "Mantenimiento Cotización Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrd_CotizacionCompra_Mantenimiento_FormClosing_1);
            this.Load += new System.EventHandler(this.FrmPrd_CotizacionCompra_Mantenimiento_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlcotizamant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewcotizamant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbcategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbcategoria;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colca_Categoria;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoria_cmb;
        private System.Windows.Forms.TextBox txtnumcotizaion;
        private System.Windows.Forms.Label LbFecha;
        private System.Windows.Forms.DateTimePicker dtpFechareg;
        private System.Windows.Forms.Label LbProveedor;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlcotizamant;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewcotizamant;
        private DevExpress.XtraGrid.Columns.GridColumn col_Check;
        private DevExpress.XtraGrid.Columns.GridColumn colCant_soli;
        private DevExpress.XtraGrid.Columns.GridColumn colCant_a_cotizar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdListadoMateriales_lq;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colsaldo;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private Controles.UCGe_Sucursal_combo ucGe_Sucursal_combo1;
        private Controles.UCCp_Proveedor ucCp_Proveedor1;
    }
}