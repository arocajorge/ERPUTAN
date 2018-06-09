namespace Core.Erp.Winform.Produccion_Edehsa
{
    partial class FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant));
            this.cmb_estado = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repository_Producto = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechareg = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Obra = new Core.Erp.Winform.Controles.UCPrd_Obra();
            this.label15 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ucGe_Sucursal_combo1 = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.cmbEstadoApro = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtIdLMat = new System.Windows.Forms.TextBox();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra = new DevExpress.XtraGrid.GridControl();
            this.comListadoMaterialesDisponibles_PreAsignado_a_ObraDetInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIdEmpresa = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIdProducto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDet_Kg = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColPre_asignar = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Colpr_descripcion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColCodigoBarra = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLongitudProducto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColAlto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColEspesor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColLargo_pieza_entera = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColCantidad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColLongitud_Despunte = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColCantidad_despunte1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColEs_despunte_usable1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colTotalLongitud = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLargoRestante = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collm_IdEstadoAprobado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdDetTrans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colea_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colea_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colot_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colob_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprov_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRequer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgo_IdEstadoAprob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_idempresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdencompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_iddetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_idsucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.inProductoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comCatalogoInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comCatalogoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inProductoInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prdListadoMaterialesDisponiblesDetInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.errorProviderValidarTxt = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_Producto)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoApro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comListadoMaterialesDisponibles_PreAsignado_a_ObraDetInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProductoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comCatalogoInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comCatalogoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProductoInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdListadoMaterialesDisponiblesDetInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidarTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_estado
            // 
            this.cmb_estado.AutoHeight = false;
            this.cmb_estado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_estado.DisplayMember = "descripcion";
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.ValueMember = "Codigo";
            // 
            // repository_Producto
            // 
            this.repository_Producto.AutoHeight = false;
            this.repository_Producto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repository_Producto.DisplayMember = "pr_codigo";
            this.repository_Producto.Name = "repository_Producto";
            this.repository_Producto.ValueMember = "IdProducto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 821);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lblAnulado);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1303, 821);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpFechareg);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Obra);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.ucGe_Sucursal_combo1);
            this.groupBox1.Controls.Add(this.cmbEstadoApro);
            this.groupBox1.Controls.Add(this.txtIdLMat);
            this.groupBox1.Location = new System.Drawing.Point(8, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1283, 249);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 102;
            this.label9.Text = "#Registro:";
            // 
            // dtpFechareg
            // 
            this.dtpFechareg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechareg.Location = new System.Drawing.Point(116, 130);
            this.dtpFechareg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechareg.Name = "dtpFechareg";
            this.dtpFechareg.Size = new System.Drawing.Size(312, 22);
            this.dtpFechareg.TabIndex = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 198);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 102;
            this.label11.Text = "Observación:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 135);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 99;
            this.label10.Text = "Fecha:";
            // 
            // Obra
            // 
            this.Obra.Location = new System.Drawing.Point(5, 70);
            this.Obra.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Obra.Name = "Obra";
            this.Obra.Size = new System.Drawing.Size(423, 33);
            this.Obra.TabIndex = 110;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 108);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 17);
            this.label15.TabIndex = 137;
            this.label15.Text = "Estado Req.";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.Color.Black;
            this.txtObservacion.Location = new System.Drawing.Point(115, 191);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacion.MaxLength = 500;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(659, 40);
            this.txtObservacion.TabIndex = 109;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(115, 161);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(313, 22);
            this.txtUsuario.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 102;
            this.label2.Text = "Usuario:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 47);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 97;
            this.label14.Text = "Sucursal:";
            // 
            // ucGe_Sucursal_combo1
            // 
            this.ucGe_Sucursal_combo1.Location = new System.Drawing.Point(115, 44);
            this.ucGe_Sucursal_combo1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_Sucursal_combo1.Name = "ucGe_Sucursal_combo1";
            this.ucGe_Sucursal_combo1.Size = new System.Drawing.Size(315, 27);
            this.ucGe_Sucursal_combo1.TabIndex = 135;
            // 
            // cmbEstadoApro
            // 
            this.cmbEstadoApro.Location = new System.Drawing.Point(116, 103);
            this.cmbEstadoApro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstadoApro.Name = "cmbEstadoApro";
            this.cmbEstadoApro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstadoApro.Properties.DisplayMember = "descripcion";
            this.cmbEstadoApro.Properties.ValueMember = "Codigo";
            this.cmbEstadoApro.Properties.View = this.gridView9;
            this.cmbEstadoApro.Size = new System.Drawing.Size(312, 22);
            this.cmbEstadoApro.TabIndex = 136;
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.descripcion});
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // descripcion
            // 
            this.descripcion.Caption = "Descripcion";
            this.descripcion.FieldName = "descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Visible = true;
            this.descripcion.VisibleIndex = 0;
            // 
            // txtIdLMat
            // 
            this.txtIdLMat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIdLMat.Enabled = false;
            this.txtIdLMat.Location = new System.Drawing.Point(113, 18);
            this.txtIdLMat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdLMat.Name = "txtIdLMat";
            this.txtIdLMat.ReadOnly = true;
            this.txtIdLMat.Size = new System.Drawing.Size(243, 22);
            this.txtIdLMat.TabIndex = 101;
            // 
            // lblAnulado
            // 
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(643, 9);
            this.lblAnulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(307, 30);
            this.lblAnulado.TabIndex = 105;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnulado.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox3.Controls.Add(this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra);
            this.groupBox3.Location = new System.Drawing.Point(5, 309);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1291, 370);
            this.groupBox3.TabIndex = 112;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de MaterialesDisponibles a Pedir:";
            // 
            // gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra
            // 
            this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource = this.comListadoMaterialesDisponibles_PreAsignado_a_ObraDetInfoBindingSource;
            this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.Location = new System.Drawing.Point(19, 38);
            this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.MainView = this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra;
            this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.Name = "gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra";
            this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.Size = new System.Drawing.Size(1253, 306);
            this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.TabIndex = 2;
            this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra,
            this.gridView1});
            // 
            // comListadoMaterialesDisponibles_PreAsignado_a_ObraDetInfoBindingSource
            // 
            this.comListadoMaterialesDisponibles_PreAsignado_a_ObraDetInfoBindingSource.DataSource = typeof(Core.Erp.Info.Compras_Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info);
            // 
            // gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra
            // 
            this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand7,
            this.gridBand1,
            this.gridBand6,
            this.gridBand5});
            this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colIdEmpresa,
            this.colIdProducto,
            this.Colpr_descripcion,
            this.ColCodigoBarra,
            this.colLongitudProducto,
            this.ColAlto,
            this.ColEspesor,
            this.colDet_Kg,
            this.gridColumn2,
            this.colTotalLongitud,
            this.colLargoRestante,
            this.ColLargo_pieza_entera,
            this.ColCantidad,
            this.ColLongitud_Despunte,
            this.ColCantidad_despunte1,
            this.ColEs_despunte_usable1,
            this.ColPre_asignar});
            this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.GridControl = this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra;
            this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.Name = "gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra";
            this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.OptionsSelection.MultiSelect = true;
            this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.OptionsView.ShowAutoFilterRow = true;
            this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.OptionsView.ShowGroupPanel = false;
            this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra_CellValueChanged);
            // 
            // gridBand2
            // 
            this.gridBand2.Columns.Add(this.colIdEmpresa);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Visible = false;
            this.gridBand2.Width = 76;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Width = 76;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.Caption = "Producto";
            this.gridBand3.Columns.Add(this.colIdProducto);
            this.gridBand3.Columns.Add(this.colDet_Kg);
            this.gridBand3.Columns.Add(this.ColPre_asignar);
            this.gridBand3.Columns.Add(this.Colpr_descripcion);
            this.gridBand3.Columns.Add(this.ColCodigoBarra);
            this.gridBand3.Columns.Add(this.colLongitudProducto);
            this.gridBand3.Columns.Add(this.ColAlto);
            this.gridBand3.Columns.Add(this.ColEspesor);
            this.gridBand3.Columns.Add(this.gridColumn2);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 563;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Width = 84;
            // 
            // colDet_Kg
            // 
            this.colDet_Kg.Caption = "Peso";
            this.colDet_Kg.FieldName = "Det_Kg";
            this.colDet_Kg.Name = "colDet_Kg";
            this.colDet_Kg.Width = 36;
            // 
            // ColPre_asignar
            // 
            this.ColPre_asignar.Caption = "Pre_asignar";
            this.ColPre_asignar.FieldName = "pre_asignar";
            this.ColPre_asignar.Name = "ColPre_asignar";
            this.ColPre_asignar.Visible = true;
            // 
            // Colpr_descripcion
            // 
            this.Colpr_descripcion.Caption = "Producto";
            this.Colpr_descripcion.FieldName = "pr_descripcion";
            this.Colpr_descripcion.Name = "Colpr_descripcion";
            this.Colpr_descripcion.Visible = true;
            this.Colpr_descripcion.Width = 207;
            // 
            // ColCodigoBarra
            // 
            this.ColCodigoBarra.Caption = "Codigo Barra";
            this.ColCodigoBarra.FieldName = "CodigoBarra";
            this.ColCodigoBarra.Name = "ColCodigoBarra";
            this.ColCodigoBarra.Visible = true;
            this.ColCodigoBarra.Width = 94;
            // 
            // colLongitudProducto
            // 
            this.colLongitudProducto.Caption = "Longitud";
            this.colLongitudProducto.FieldName = "longitud";
            this.colLongitudProducto.Name = "colLongitudProducto";
            this.colLongitudProducto.OptionsColumn.ReadOnly = true;
            this.colLongitudProducto.Visible = true;
            this.colLongitudProducto.Width = 80;
            // 
            // ColAlto
            // 
            this.ColAlto.Caption = "Alto.";
            this.ColAlto.FieldName = "alto";
            this.ColAlto.Name = "ColAlto";
            this.ColAlto.OptionsColumn.ReadOnly = true;
            this.ColAlto.Visible = true;
            this.ColAlto.Width = 58;
            // 
            // ColEspesor
            // 
            this.ColEspesor.Caption = "Espesor";
            this.ColEspesor.FieldName = "espesor";
            this.ColEspesor.Name = "ColEspesor";
            this.ColEspesor.OptionsColumn.ReadOnly = true;
            this.ColEspesor.Visible = true;
            this.ColEspesor.Width = 49;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Aprobación";
            this.gridColumn2.ColumnEdit = this.cmb_estado;
            this.gridColumn2.FieldName = "ea_descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Width = 100;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.Caption = "Piezas Enteras";
            this.gridBand4.Columns.Add(this.ColLargo_pieza_entera);
            this.gridBand4.Columns.Add(this.ColCantidad);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 179;
            // 
            // ColLargo_pieza_entera
            // 
            this.ColLargo_pieza_entera.Caption = "Longitud";
            this.ColLargo_pieza_entera.FieldName = "largo_pieza_entera";
            this.ColLargo_pieza_entera.Name = "ColLargo_pieza_entera";
            this.ColLargo_pieza_entera.Visible = true;
            this.ColLargo_pieza_entera.Width = 179;
            // 
            // ColCantidad
            // 
            this.ColCantidad.Caption = "Cantidad";
            this.ColCantidad.FieldName = "dm_cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Width = 65;
            // 
            // gridBand7
            // 
            this.gridBand7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand7.AppearanceHeader.Options.UseFont = true;
            this.gridBand7.Caption = "Despunte Principal";
            this.gridBand7.Columns.Add(this.ColLongitud_Despunte);
            this.gridBand7.Columns.Add(this.ColCantidad_despunte1);
            this.gridBand7.Columns.Add(this.ColEs_despunte_usable1);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.Width = 257;
            // 
            // ColLongitud_Despunte
            // 
            this.ColLongitud_Despunte.Caption = "Longitud";
            this.ColLongitud_Despunte.FieldName = "largo_despunte1";
            this.ColLongitud_Despunte.Name = "ColLongitud_Despunte";
            this.ColLongitud_Despunte.Visible = true;
            this.ColLongitud_Despunte.Width = 66;
            // 
            // ColCantidad_despunte1
            // 
            this.ColCantidad_despunte1.Caption = "Cantidad";
            this.ColCantidad_despunte1.FieldName = "cantidad_despunte1";
            this.ColCantidad_despunte1.Name = "ColCantidad_despunte1";
            this.ColCantidad_despunte1.Visible = true;
            this.ColCantidad_despunte1.Width = 70;
            // 
            // ColEs_despunte_usable1
            // 
            this.ColEs_despunte_usable1.Caption = "Es Usable";
            this.ColEs_despunte_usable1.FieldName = "es_despunte_usable1";
            this.ColEs_despunte_usable1.Name = "ColEs_despunte_usable1";
            this.ColEs_despunte_usable1.Visible = true;
            this.ColEs_despunte_usable1.Width = 121;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.Caption = "TOTAL";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Visible = false;
            this.gridBand1.Width = 100;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "gridBand6";
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.Visible = false;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Pre-Asignar";
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Visible = false;
            this.gridBand5.Width = 75;
            // 
            // colTotalLongitud
            // 
            this.colTotalLongitud.Caption = "Total Longitud";
            this.colTotalLongitud.FieldName = "largo_total";
            this.colTotalLongitud.Name = "colTotalLongitud";
            this.colTotalLongitud.Width = 114;
            // 
            // colLargoRestante
            // 
            this.colLargoRestante.Caption = "Longitud Restante";
            this.colLargoRestante.FieldName = "largo_restante";
            this.colLargoRestante.Name = "colLargoRestante";
            this.colLargoRestante.Width = 91;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collm_IdEstadoAprobado,
            this.colIdDetTrans,
            this.colIdProveedor,
            this.colMotivo,
            this.colmr_codigo,
            this.colmr_descripcion,
            this.colea_codigo,
            this.colea_descripcion,
            this.colot_codigo,
            this.colob_descripcion,
            this.colprov_descripcion,
            this.colobra,
            this.colproducto,
            this.colFechaRequer,
            this.colIdTransaccion,
            this.colsec,
            this.colchk,
            this.colprecio,
            this.colgo_IdEstadoAprob,
            this.coloc_idempresa,
            this.colIdOrdencompra,
            this.coloc_iddetalle,
            this.coloc_idsucursal,
            this.colIco});
            this.gridView1.GridControl = this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra;
            this.gridView1.Name = "gridView1";
            // 
            // collm_IdEstadoAprobado
            // 
            this.collm_IdEstadoAprobado.FieldName = "lm_IdEstadoAprobado";
            this.collm_IdEstadoAprobado.Name = "collm_IdEstadoAprobado";
            // 
            // colIdDetTrans
            // 
            this.colIdDetTrans.FieldName = "IdDetTrans";
            this.colIdDetTrans.Name = "colIdDetTrans";
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            // 
            // colMotivo
            // 
            this.colMotivo.FieldName = "Motivo";
            this.colMotivo.Name = "colMotivo";
            // 
            // colmr_codigo
            // 
            this.colmr_codigo.FieldName = "mr_codigo";
            this.colmr_codigo.Name = "colmr_codigo";
            // 
            // colmr_descripcion
            // 
            this.colmr_descripcion.FieldName = "mr_descripcion";
            this.colmr_descripcion.Name = "colmr_descripcion";
            // 
            // colea_codigo
            // 
            this.colea_codigo.FieldName = "ea_codigo";
            this.colea_codigo.Name = "colea_codigo";
            // 
            // colea_descripcion
            // 
            this.colea_descripcion.FieldName = "ea_descripcion";
            this.colea_descripcion.Name = "colea_descripcion";
            // 
            // colot_codigo
            // 
            this.colot_codigo.FieldName = "ot_codigo";
            this.colot_codigo.Name = "colot_codigo";
            // 
            // colob_descripcion
            // 
            this.colob_descripcion.FieldName = "ob_descripcion";
            this.colob_descripcion.Name = "colob_descripcion";
            // 
            // colprov_descripcion
            // 
            this.colprov_descripcion.FieldName = "prov_descripcion";
            this.colprov_descripcion.Name = "colprov_descripcion";
            // 
            // colobra
            // 
            this.colobra.FieldName = "obra";
            this.colobra.Name = "colobra";
            // 
            // colproducto
            // 
            this.colproducto.FieldName = "producto";
            this.colproducto.Name = "colproducto";
            // 
            // colFechaRequer
            // 
            this.colFechaRequer.FieldName = "FechaRequer";
            this.colFechaRequer.Name = "colFechaRequer";
            // 
            // colIdTransaccion
            // 
            this.colIdTransaccion.FieldName = "IdTransaccion";
            this.colIdTransaccion.Name = "colIdTransaccion";
            // 
            // colsec
            // 
            this.colsec.FieldName = "sec";
            this.colsec.Name = "colsec";
            // 
            // colchk
            // 
            this.colchk.FieldName = "chk";
            this.colchk.Name = "colchk";
            // 
            // colprecio
            // 
            this.colprecio.FieldName = "precio";
            this.colprecio.Name = "colprecio";
            // 
            // colgo_IdEstadoAprob
            // 
            this.colgo_IdEstadoAprob.FieldName = "go_IdEstadoAprob";
            this.colgo_IdEstadoAprob.Name = "colgo_IdEstadoAprob";
            // 
            // coloc_idempresa
            // 
            this.coloc_idempresa.FieldName = "oc_idempresa";
            this.coloc_idempresa.Name = "coloc_idempresa";
            // 
            // colIdOrdencompra
            // 
            this.colIdOrdencompra.FieldName = "IdOrdencompra";
            this.colIdOrdencompra.Name = "colIdOrdencompra";
            // 
            // coloc_iddetalle
            // 
            this.coloc_iddetalle.FieldName = "oc_iddetalle";
            this.coloc_iddetalle.Name = "coloc_iddetalle";
            // 
            // coloc_idsucursal
            // 
            this.coloc_idsucursal.FieldName = "oc_idsucursal";
            this.coloc_idsucursal.Name = "coloc_idsucursal";
            // 
            // colIco
            // 
            this.colIco.FieldName = "Ico";
            this.colIco.Name = "colIco";
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
            this.ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
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
            this.ucGe_Menu_Superior_Mant1.Location = new System.Drawing.Point(4, 19);
            this.ucGe_Menu_Superior_Mant1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(1295, 36);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
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
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            this.ucGe_Menu_Superior_Mant1.Load += new System.EventHandler(this.ucGe_Menu_Superior_Mant1_Load);
            // 
            // inProductoInfoBindingSource
            // 
            this.inProductoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_Producto_Info);
            // 
            // comCatalogoInfoBindingSource1
            // 
            this.comCatalogoInfoBindingSource1.DataSource = typeof(Core.Erp.Info.Compras.com_Catalogo_Info);
            // 
            // comCatalogoInfoBindingSource
            // 
            this.comCatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Compras.com_Catalogo_Info);
            // 
            // inProductoInfoBindingSource1
            // 
            this.inProductoInfoBindingSource1.DataSource = typeof(Core.Erp.Info.Inventario.in_Producto_Info);
            // 
            // prdListadoMaterialesDisponiblesDetInfoBindingSource
            // 
            this.prdListadoMaterialesDisponiblesDetInfoBindingSource.DataSource = typeof(Core.Erp.Info.Compras_Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ID";
            this.gridColumn5.FieldName = "IdProducto";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Codigo";
            this.gridColumn6.FieldName = "pr_codigo";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Descripcion";
            this.gridColumn7.FieldName = "pr_descripcion";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "ID";
            this.gridColumn8.FieldName = "IdProducto";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Codigo";
            this.gridColumn9.FieldName = "pr_codigo";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Descripcion";
            this.gridColumn10.FieldName = "pr_descripcion";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            // 
            // 
            // 
            this.printableComponentLink1.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream")));
            this.printableComponentLink1.Owner = null;
            this.printableComponentLink1.PrintingSystem = this.printingSystem1;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // errorProviderValidarTxt
            // 
            this.errorProviderValidarTxt.ContainerControl = this;
            // 
            // FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1303, 821);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requerimiento de MaterialesDisponibles Mantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrd_ListadoMaterialesDisponiblesMant_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repository_Producto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoApro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comListadoMaterialesDisponibles_PreAsignado_a_ObraDetInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProductoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comCatalogoInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comCatalogoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProductoInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdListadoMaterialesDisponiblesDetInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidarTxt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource prdListadoMaterialesDisponiblesDetInfoBindingSource;
        private System.Windows.Forms.BindingSource inProductoInfoBindingSource;
        private System.Windows.Forms.BindingSource inProductoInfoBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.BindingSource comListadoMaterialesDisponibles_PreAsignado_a_ObraDetInfoBindingSource;
        private System.Windows.Forms.BindingSource comCatalogoInfoBindingSource;
        private System.Windows.Forms.BindingSource comCatalogoInfoBindingSource1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repository_Producto;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn collm_IdEstadoAprobado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDetTrans;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivo;
        private DevExpress.XtraGrid.Columns.GridColumn colmr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colmr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colea_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colea_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colot_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colob_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colprov_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colobra;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRequer;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTransaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colsec;
        private DevExpress.XtraGrid.Columns.GridColumn colchk;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn colgo_IdEstadoAprob;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_idempresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdencompra;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_iddetalle;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_idsucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIco;
        private System.Windows.Forms.TextBox txtIdLMat;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.DateTimePicker dtpFechareg;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;


        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private Controles.UCPrd_Obra Obra;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ErrorProvider errorProviderValidarTxt;
        private Controles.UCGe_Sucursal_combo ucGe_Sucursal_combo1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEstadoApro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraGrid.Columns.GridColumn descripcion;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdProducto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDet_Kg;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLongitudProducto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColLargo_pieza_entera;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColCantidad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColLongitud_Despunte;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColCantidad_despunte1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColEs_despunte_usable1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTotalLongitud;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLargoRestante;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Colpr_descripcion;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColPre_asignar;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_estado;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColCodigoBarra;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColEspesor;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColAlto;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
    }
}