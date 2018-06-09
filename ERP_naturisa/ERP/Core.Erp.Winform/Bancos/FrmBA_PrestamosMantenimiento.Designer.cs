namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_PrestamosMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBA_PrestamosMantenimiento));
            this.baCatalogoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtpagoContado = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.txeInteres = new DevExpress.XtraEditors.TextEdit();
            this.txeMontoSol = new DevExpress.XtraEditors.TextEdit();
            this.dtpFechaPago = new DevExpress.XtraEditors.DateEdit();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtNumCuotas = new DevExpress.XtraEditors.TextEdit();
            this.cmbMetodoCalc = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colca_descripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMetCalc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPeriodoPago = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridca_descripcion_Pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCodCatalogoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_cliente = new Core.Erp.Winform.Controles.UCFa_Cliente_x_centro_costo_cmb();
            this.label14 = new System.Windows.Forms.Label();
            this.ucCon_PlanCtaCmb = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.label5 = new System.Windows.Forms.Label();
            this.ucBa_TipoFlujo = new Core.Erp.Winform.Controles.UCBa_TipoFlujo();
            this.dtpFechaReg = new DevExpress.XtraEditors.DateEdit();
            this.txtCodPrestamo = new DevExpress.XtraEditors.TextEdit();
            this.txtIdPrestamo = new DevExpress.XtraEditors.TextEdit();
            this.cmbMotivoPrest = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCodCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbBanco = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.baBancoCuentaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView12 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardarSalir = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnImprimirEC = new System.Windows.Forms.ToolStripButton();
            this.btnCuotas = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.baCbteBanInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControlDetalle = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCuota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIntres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValInte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTotCuota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEstadoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCmbEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbestadoPago = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView11 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCatalogo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCatalogo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodCatalogo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_descripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_estado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_orden1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDiasPlazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemSearchLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemSearchLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemSearchLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemSearchLookUpEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbEstado = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit6View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControlEstado = new DevExpress.XtraGrid.GridControl();
            this.baprestamodetalleInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridColumn28 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmbEstadoPag = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView14 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridColumn29 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.btn_editar = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridColumn31 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.btn_anular = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemSearchLookUpEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView13 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemSearchLookUpEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView15 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemSearchLookUpEdit9 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView16 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemSearchLookUpEdit10 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView17 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemSearchLookUpEdit11 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView18 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemSearchLookUpEdit12 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView19 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridControl_Activos_Prendados = new DevExpress.XtraGrid.GridControl();
            this.gridView_Activos_Prendados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdActivoFijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_acticos_fijo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_CodActivoFijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Af_Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Garantia_Bancaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_valor_cancelado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_valor_pendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Af_costo_compra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_porcentaje_prestamo_x_activo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageBotones = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.baCatalogoInfoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpagoContado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeInteres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeMontoSol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaPago.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCuotas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMetodoCalc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaReg.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaReg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodPrestamo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdPrestamo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMotivoPrest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baBancoCuentaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baCbteBanInfoBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbestadoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit6View)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baprestamodetalleInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoPag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_anular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView19)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Activos_Prendados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Activos_Prendados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_acticos_fijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // baCatalogoInfoBindingSource
            // 
            this.baCatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Bancos.ba_Catalogo_Info);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtpagoContado);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txeInteres);
            this.groupBox2.Controls.Add(this.txeMontoSol);
            this.groupBox2.Controls.Add(this.dtpFechaPago);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.btnGenerar);
            this.groupBox2.Controls.Add(this.txtNumCuotas);
            this.groupBox2.Controls.Add(this.cmbMetodoCalc);
            this.groupBox2.Controls.Add(this.cmbPeriodoPago);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(929, 92);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle del Préstamo:";
            // 
            // txtpagoContado
            // 
            this.txtpagoContado.Location = new System.Drawing.Point(115, 43);
            this.txtpagoContado.Name = "txtpagoContado";
            this.txtpagoContado.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txtpagoContado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtpagoContado.Size = new System.Drawing.Size(114, 20);
            this.txtpagoContado.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Pago Contado:";
            // 
            // txeInteres
            // 
            this.txeInteres.Location = new System.Drawing.Point(603, 17);
            this.txeInteres.Name = "txeInteres";
            this.txeInteres.Properties.Mask.EditMask = "p2";
            this.txeInteres.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeInteres.Size = new System.Drawing.Size(166, 20);
            this.txeInteres.TabIndex = 4;
            // 
            // txeMontoSol
            // 
            this.txeMontoSol.Location = new System.Drawing.Point(115, 19);
            this.txeMontoSol.Name = "txeMontoSol";
            this.txeMontoSol.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeMontoSol.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeMontoSol.Size = new System.Drawing.Size(114, 20);
            this.txeMontoSol.TabIndex = 0;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.EditValue = null;
            this.dtpFechaPago.Location = new System.Drawing.Point(339, 43);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.dtpFechaPago.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaPago.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.dtpFechaPago.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.dtpFechaPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaPago.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpFechaPago.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaPago.TabIndex = 3;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(777, 16);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo Cálculo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(777, 43);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(112, 23);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar Préstamo";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtNumCuotas
            // 
            this.txtNumCuotas.EditValue = "0";
            this.txtNumCuotas.Location = new System.Drawing.Point(339, 18);
            this.txtNumCuotas.Name = "txtNumCuotas";
            this.txtNumCuotas.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtNumCuotas.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtNumCuotas.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtNumCuotas.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtNumCuotas.Properties.Mask.EditMask = "d";
            this.txtNumCuotas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNumCuotas.Size = new System.Drawing.Size(100, 20);
            this.txtNumCuotas.TabIndex = 2;
            // 
            // cmbMetodoCalc
            // 
            this.cmbMetodoCalc.Location = new System.Drawing.Point(603, 43);
            this.cmbMetodoCalc.Name = "cmbMetodoCalc";
            this.cmbMetodoCalc.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.cmbMetodoCalc.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.cmbMetodoCalc.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.cmbMetodoCalc.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.cmbMetodoCalc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMetodoCalc.Properties.DataSource = this.baCatalogoInfoBindingSource;
            this.cmbMetodoCalc.Properties.DisplayMember = "ca_descripcion";
            this.cmbMetodoCalc.Properties.ValueMember = "IdMetCalc";
            this.cmbMetodoCalc.Properties.View = this.gridView4;
            this.cmbMetodoCalc.Size = new System.Drawing.Size(166, 20);
            this.cmbMetodoCalc.TabIndex = 5;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colca_descripcion2,
            this.colIdMetCalc});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colca_descripcion2
            // 
            this.colca_descripcion2.Caption = "Método Cálculo";
            this.colca_descripcion2.FieldName = "ca_descripcion";
            this.colca_descripcion2.Name = "colca_descripcion2";
            this.colca_descripcion2.Visible = true;
            this.colca_descripcion2.VisibleIndex = 0;
            this.colca_descripcion2.Width = 962;
            // 
            // colIdMetCalc
            // 
            this.colIdMetCalc.Caption = "Código";
            this.colIdMetCalc.FieldName = "IdMetCalc";
            this.colIdMetCalc.Name = "colIdMetCalc";
            this.colIdMetCalc.Visible = true;
            this.colIdMetCalc.VisibleIndex = 1;
            this.colIdMetCalc.Width = 152;
            // 
            // cmbPeriodoPago
            // 
            this.cmbPeriodoPago.Location = new System.Drawing.Point(115, 67);
            this.cmbPeriodoPago.Name = "cmbPeriodoPago";
            this.cmbPeriodoPago.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.cmbPeriodoPago.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.cmbPeriodoPago.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.cmbPeriodoPago.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.cmbPeriodoPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPeriodoPago.Properties.DataSource = this.baCatalogoInfoBindingSource;
            this.cmbPeriodoPago.Properties.DisplayMember = "ca_descripcion";
            this.cmbPeriodoPago.Properties.ValueMember = "IdPeriPago";
            this.cmbPeriodoPago.Properties.View = this.gridView6;
            this.cmbPeriodoPago.Size = new System.Drawing.Size(114, 20);
            this.cmbPeriodoPago.TabIndex = 1;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridca_descripcion_Pago,
            this.gridCodCatalogoPago});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // gridca_descripcion_Pago
            // 
            this.gridca_descripcion_Pago.Caption = "Periocidad de Pago";
            this.gridca_descripcion_Pago.FieldName = "ca_descripcion";
            this.gridca_descripcion_Pago.Name = "gridca_descripcion_Pago";
            this.gridca_descripcion_Pago.Visible = true;
            this.gridca_descripcion_Pago.VisibleIndex = 0;
            this.gridca_descripcion_Pago.Width = 695;
            // 
            // gridCodCatalogoPago
            // 
            this.gridCodCatalogoPago.Caption = "Código";
            this.gridCodCatalogoPago.FieldName = "IdPeriPago";
            this.gridCodCatalogoPago.Name = "gridCodCatalogoPago";
            this.gridCodCatalogoPago.Visible = true;
            this.gridCodCatalogoPago.VisibleIndex = 1;
            this.gridCodCatalogoPago.Width = 176;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Periodos de Pago:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(498, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Tasa de Interés:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(233, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Cuotas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fecha Primer Pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Valor financiado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Método de Cálculo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_cliente);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.ucCon_PlanCtaCmb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ucBa_TipoFlujo);
            this.groupBox1.Controls.Add(this.dtpFechaReg);
            this.groupBox1.Controls.Add(this.txtCodPrestamo);
            this.groupBox1.Controls.Add(this.txtIdPrestamo);
            this.groupBox1.Controls.Add(this.cmbMotivoPrest);
            this.groupBox1.Controls.Add(this.cmbBanco);
            this.groupBox1.Controls.Add(this.searchLookUpEdit1);
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Términos del Préstamo:";
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.Enabled_BtnAccion_cc = true;
            this.cmb_cliente.Enabled_BtnAccion_cli = true;
            this.cmb_cliente.Enabled_BtnAccion_Scc = true;
            this.cmb_cliente.Enabled_cmb_Centro_costo = true;
            this.cmb_cliente.Enabled_cmb_Cliente = true;
            this.cmb_cliente.Location = new System.Drawing.Point(282, 88);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.ReadOnly_cmb_Centro_costo = false;
            this.cmb_cliente.ReadOnly_cmb_Cliente = false;
            this.cmb_cliente.ReadOnly_cmb_Subcentro_costo = false;
            this.cmb_cliente.Size = new System.Drawing.Size(311, 21);
            this.cmb_cliente.TabIndex = 23;
            this.cmb_cliente.Visible_BtnAccion_cc = true;
            this.cmb_cliente.Visible_BtnAccion_cli = true;
            this.cmb_cliente.Visible_btnAccion_Scc = true;
            this.cmb_cliente.Visible_cmb_Centro_costo = true;
            this.cmb_cliente.Visible_cmb_Cliente = true;
            this.cmb_cliente.Visible_cmb_Subcentro_costo = true;
            this.cmb_cliente.Visible_lblCentro_costo = true;
            this.cmb_cliente.Visible_lblCliente = true;
            this.cmb_cliente.Visible_lblSub_centro_costo = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(223, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Cta. Cble:";
            // 
            // ucCon_PlanCtaCmb
            // 
            this.ucCon_PlanCtaCmb.Location = new System.Drawing.Point(295, 13);
            this.ucCon_PlanCtaCmb.Name = "ucCon_PlanCtaCmb";
            this.ucCon_PlanCtaCmb.Size = new System.Drawing.Size(298, 26);
            this.ucCon_PlanCtaCmb.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tipo de Flujo:";
            // 
            // ucBa_TipoFlujo
            // 
            this.ucBa_TipoFlujo.Location = new System.Drawing.Point(295, 36);
            this.ucBa_TipoFlujo.Name = "ucBa_TipoFlujo";
            this.ucBa_TipoFlujo.Size = new System.Drawing.Size(298, 26);
            this.ucBa_TipoFlujo.TabIndex = 26;
            // 
            // dtpFechaReg
            // 
            this.dtpFechaReg.EditValue = null;
            this.dtpFechaReg.Location = new System.Drawing.Point(702, 15);
            this.dtpFechaReg.Name = "dtpFechaReg";
            this.dtpFechaReg.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.dtpFechaReg.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaReg.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.dtpFechaReg.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.dtpFechaReg.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaReg.Properties.ReadOnly = true;
            this.dtpFechaReg.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpFechaReg.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaReg.TabIndex = 5;
            // 
            // txtCodPrestamo
            // 
            this.txtCodPrestamo.Location = new System.Drawing.Point(112, 42);
            this.txtCodPrestamo.Name = "txtCodPrestamo";
            this.txtCodPrestamo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtCodPrestamo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtCodPrestamo.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtCodPrestamo.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtCodPrestamo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtCodPrestamo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.txtCodPrestamo.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtCodPrestamo.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtCodPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txtCodPrestamo.TabIndex = 1;
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Location = new System.Drawing.Point(112, 19);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Properties.ReadOnly = true;
            this.txtIdPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txtIdPrestamo.TabIndex = 0;
            // 
            // cmbMotivoPrest
            // 
            this.cmbMotivoPrest.Location = new System.Drawing.Point(112, 88);
            this.cmbMotivoPrest.Name = "cmbMotivoPrest";
            this.cmbMotivoPrest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMotivoPrest.Properties.DataSource = this.baCatalogoInfoBindingSource;
            this.cmbMotivoPrest.Properties.DisplayMember = "ca_descripcion";
            this.cmbMotivoPrest.Properties.ValueMember = "IdMotivoPrestamo";
            this.cmbMotivoPrest.Properties.View = this.gridView5;
            this.cmbMotivoPrest.Size = new System.Drawing.Size(164, 20);
            this.cmbMotivoPrest.TabIndex = 3;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridca_descripcion,
            this.gridCodCatalogo});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // gridca_descripcion
            // 
            this.gridca_descripcion.Caption = "Motivo Prestamo";
            this.gridca_descripcion.FieldName = "ca_descripcion";
            this.gridca_descripcion.Name = "gridca_descripcion";
            this.gridca_descripcion.Visible = true;
            this.gridca_descripcion.VisibleIndex = 0;
            this.gridca_descripcion.Width = 764;
            // 
            // gridCodCatalogo
            // 
            this.gridCodCatalogo.Caption = "Código";
            this.gridCodCatalogo.FieldName = "IdMotivoPrestamo";
            this.gridCodCatalogo.Name = "gridCodCatalogo";
            this.gridCodCatalogo.Visible = true;
            this.gridCodCatalogo.VisibleIndex = 1;
            this.gridCodCatalogo.Width = 107;
            // 
            // cmbBanco
            // 
            this.cmbBanco.Location = new System.Drawing.Point(112, 65);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.cmbBanco.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.cmbBanco.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.cmbBanco.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.cmbBanco.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.cmbBanco.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.cmbBanco.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.cmbBanco.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.cmbBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBanco.Properties.DataSource = this.baBancoCuentaInfoBindingSource;
            this.cmbBanco.Properties.DisplayMember = "ba_descripcion";
            this.cmbBanco.Properties.ValueMember = "IdBanco";
            this.cmbBanco.Properties.View = this.gridView2;
            this.cmbBanco.Size = new System.Drawing.Size(481, 20);
            this.cmbBanco.TabIndex = 2;
            // 
            // baBancoCuentaInfoBindingSource
            // 
            this.baBancoCuentaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Bancos.ba_Banco_Cuenta_Info);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colba_descripcion,
            this.colIdBanco});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colba_descripcion
            // 
            this.colba_descripcion.Caption = "Banco";
            this.colba_descripcion.FieldName = "ba_descripcion";
            this.colba_descripcion.Name = "colba_descripcion";
            this.colba_descripcion.Visible = true;
            this.colba_descripcion.VisibleIndex = 0;
            this.colba_descripcion.Width = 734;
            // 
            // colIdBanco
            // 
            this.colIdBanco.Caption = "Id";
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.Visible = true;
            this.colIdBanco.VisibleIndex = 1;
            this.colIdBanco.Width = 137;
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(-341, 59);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DisplayMember = "ca_descripcion";
            this.searchLookUpEdit1.Properties.ValueMember = "IdPeriPago";
            this.searchLookUpEdit1.Properties.View = this.gridView12;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(100, 20);
            this.searchLookUpEdit1.TabIndex = 25;
            // 
            // gridView12
            // 
            this.gridView12.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView12.Name = "gridView12";
            this.gridView12.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView12.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Periocidad de Pago";
            this.gridColumn1.FieldName = "ca_descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Periodo";
            this.gridColumn2.FieldName = "IdPeriPago";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(603, 52);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(304, 56);
            this.txtObservacion.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(600, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Observación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(599, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha de Registro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Motivo Préstamo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cód. Prestamo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Banco:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Préstamo:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.btnGuardarSalir,
            this.btnImprimir,
            this.btnImprimirEC,
            this.btnCuotas,
            this.toolStripLabel1,
            this.btnAnular,
            this.btnSalir,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(929, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(69, 22);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btnGuardarSalir
            // 
            this.btnGuardarSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarSalir.Image")));
            this.btnGuardarSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardarSalir.Name = "btnGuardarSalir";
            this.btnGuardarSalir.Size = new System.Drawing.Size(103, 22);
            this.btnGuardarSalir.Text = "Guardar y Salir";
            this.btnGuardarSalir.Click += new System.EventHandler(this.btnGuardarSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Core.Erp.Winform.Properties.Resources.imprimir;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(130, 22);
            this.btnImprimir.Text = "Tabla Amortización";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnImprimirEC
            // 
            this.btnImprimirEC.Image = global::Core.Erp.Winform.Properties.Resources.imprimir;
            this.btnImprimirEC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimirEC.Name = "btnImprimirEC";
            this.btnImprimirEC.Size = new System.Drawing.Size(119, 22);
            this.btnImprimirEC.Text = "Estado de Cuenta";
            this.btnImprimirEC.Click += new System.EventHandler(this.btnImprimirEC_Click);
            // 
            // btnCuotas
            // 
            this.btnCuotas.Image = global::Core.Erp.Winform.Properties.Resources._1388723697_1710;
            this.btnCuotas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCuotas.Name = "btnCuotas";
            this.btnCuotas.Size = new System.Drawing.Size(113, 22);
            this.btnCuotas.Text = "Cancelar Cuotas";
            this.btnCuotas.Click += new System.EventHandler(this.btnCuotas_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(166, 22);
            this.toolStripLabel1.Text = "                                                     ";
            // 
            // btnAnular
            // 
            this.btnAnular.Image = global::Core.Erp.Winform.Properties.Resources.eliminar;
            this.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(62, 22);
            this.btnAnular.Text = "Anular";
            this.btnAnular.Visible = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(251, 15);
            this.toolStripLabel2.Text = "                                                 V13042014-K 10:27";
            // 
            // baCbteBanInfoBindingSource
            // 
            this.baCbteBanInfoBindingSource.DataSource = typeof(Core.Erp.Info.Bancos.ba_Cbte_Ban_Info);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 233);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 248);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControlDetalle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(921, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tabla Amortización";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridControlDetalle
            // 
            this.gridControlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDetalle.Location = new System.Drawing.Point(3, 3);
            this.gridControlDetalle.MainView = this.gridViewDetalle;
            this.gridControlDetalle.Name = "gridControlDetalle";
            this.gridControlDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit1,
            this.repositoryItemSearchLookUpEdit2,
            this.repositoryItemSearchLookUpEdit3,
            this.repositoryItemSearchLookUpEdit4,
            this.repositoryItemSearchLookUpEdit5,
            this.cmbEstado,
            this.cmbestadoPago});
            this.gridControlDetalle.Size = new System.Drawing.Size(915, 216);
            this.gridControlDetalle.TabIndex = 22;
            this.gridControlDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalle});
            // 
            // gridViewDetalle
            // 
            this.gridViewDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnNum,
            this.gridColumnCuota,
            this.gridColumnIntres,
            this.gridColumnValInte,
            this.gridColumnTotCuota,
            this.gridColumnSaldo,
            this.gridColumnFecha,
            this.gridColumnObservacion,
            this.gridColumnEstadoPago,
            this.gridColumnCmbEstado,
            this.ColDiasPlazo});
            this.gridViewDetalle.GridControl = this.gridControlDetalle;
            this.gridViewDetalle.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MontoCuota", this.gridColumnCuota, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gridViewDetalle.Name = "gridViewDetalle";
            this.gridViewDetalle.OptionsView.ShowFooter = true;
            this.gridViewDetalle.OptionsView.ShowGroupPanel = false;
            this.gridViewDetalle.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewDetalle_RowCellStyle);
            this.gridViewDetalle.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDetalle_FocusedRowChanged);
            this.gridViewDetalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewDetalle_KeyDown);
            // 
            // gridColumnNum
            // 
            this.gridColumnNum.Caption = "# Pagos";
            this.gridColumnNum.FieldName = "NumCuota";
            this.gridColumnNum.Name = "gridColumnNum";
            this.gridColumnNum.Visible = true;
            this.gridColumnNum.VisibleIndex = 0;
            this.gridColumnNum.Width = 50;
            // 
            // gridColumnCuota
            // 
            this.gridColumnCuota.Caption = "Capital";
            this.gridColumnCuota.FieldName = "SaldoInicial";
            this.gridColumnCuota.Name = "gridColumnCuota";
            this.gridColumnCuota.Visible = true;
            this.gridColumnCuota.VisibleIndex = 2;
            this.gridColumnCuota.Width = 131;
            // 
            // gridColumnIntres
            // 
            this.gridColumnIntres.Caption = "Interés";
            this.gridColumnIntres.FieldName = "Interes";
            this.gridColumnIntres.Name = "gridColumnIntres";
            this.gridColumnIntres.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumnIntres.Visible = true;
            this.gridColumnIntres.VisibleIndex = 3;
            this.gridColumnIntres.Width = 131;
            // 
            // gridColumnValInte
            // 
            this.gridColumnValInte.Caption = "Abono Capital";
            this.gridColumnValInte.FieldName = "AbonoCapital";
            this.gridColumnValInte.Name = "gridColumnValInte";
            this.gridColumnValInte.Visible = true;
            this.gridColumnValInte.VisibleIndex = 4;
            this.gridColumnValInte.Width = 131;
            // 
            // gridColumnTotCuota
            // 
            this.gridColumnTotCuota.Caption = "Total Cuota";
            this.gridColumnTotCuota.FieldName = "TotalCuota";
            this.gridColumnTotCuota.Name = "gridColumnTotCuota";
            this.gridColumnTotCuota.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumnTotCuota.Visible = true;
            this.gridColumnTotCuota.VisibleIndex = 5;
            this.gridColumnTotCuota.Width = 131;
            // 
            // gridColumnSaldo
            // 
            this.gridColumnSaldo.Caption = "Capital Reducido";
            this.gridColumnSaldo.FieldName = "Saldo";
            this.gridColumnSaldo.Name = "gridColumnSaldo";
            this.gridColumnSaldo.Visible = true;
            this.gridColumnSaldo.VisibleIndex = 6;
            this.gridColumnSaldo.Width = 131;
            // 
            // gridColumnFecha
            // 
            this.gridColumnFecha.Caption = "Fecha Pago";
            this.gridColumnFecha.FieldName = "FechaPago";
            this.gridColumnFecha.Name = "gridColumnFecha";
            this.gridColumnFecha.Visible = true;
            this.gridColumnFecha.VisibleIndex = 7;
            this.gridColumnFecha.Width = 131;
            // 
            // gridColumnObservacion
            // 
            this.gridColumnObservacion.Caption = "Observacion";
            this.gridColumnObservacion.FieldName = "Observacion_det";
            this.gridColumnObservacion.Name = "gridColumnObservacion";
            this.gridColumnObservacion.Visible = true;
            this.gridColumnObservacion.VisibleIndex = 8;
            this.gridColumnObservacion.Width = 131;
            // 
            // gridColumnEstadoPago
            // 
            this.gridColumnEstadoPago.Caption = "Estado";
            this.gridColumnEstadoPago.FieldName = "Estado";
            this.gridColumnEstadoPago.Name = "gridColumnEstadoPago";
            // 
            // gridColumnCmbEstado
            // 
            this.gridColumnCmbEstado.Caption = "Estado de pago";
            this.gridColumnCmbEstado.ColumnEdit = this.cmbestadoPago;
            this.gridColumnCmbEstado.FieldName = "EstadoPago";
            this.gridColumnCmbEstado.Name = "gridColumnCmbEstado";
            this.gridColumnCmbEstado.Visible = true;
            this.gridColumnCmbEstado.VisibleIndex = 9;
            this.gridColumnCmbEstado.Width = 116;
            // 
            // cmbestadoPago
            // 
            this.cmbestadoPago.AutoHeight = false;
            this.cmbestadoPago.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbestadoPago.DataSource = this.baCatalogoInfoBindingSource;
            this.cmbestadoPago.DisplayMember = "ca_descripcion";
            this.cmbestadoPago.Name = "cmbestadoPago";
            this.cmbestadoPago.ValueMember = "IdEstadoPago";
            this.cmbestadoPago.View = this.gridView11;
            // 
            // gridView11
            // 
            this.gridView11.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCatalogo1,
            this.colIdTipoCatalogo1,
            this.colCodCatalogo1,
            this.colca_descripcion1,
            this.colca_estado1,
            this.colca_orden1});
            this.gridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView11.Name = "gridView11";
            this.gridView11.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView11.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCatalogo1
            // 
            this.colIdCatalogo1.FieldName = "IdCatalogo";
            this.colIdCatalogo1.Name = "colIdCatalogo1";
            // 
            // colIdTipoCatalogo1
            // 
            this.colIdTipoCatalogo1.FieldName = "IdTipoCatalogo";
            this.colIdTipoCatalogo1.Name = "colIdTipoCatalogo1";
            // 
            // colCodCatalogo1
            // 
            this.colCodCatalogo1.FieldName = "CodCatalogo";
            this.colCodCatalogo1.Name = "colCodCatalogo1";
            // 
            // colca_descripcion1
            // 
            this.colca_descripcion1.Caption = "Estado de pago";
            this.colca_descripcion1.FieldName = "ca_descripcion";
            this.colca_descripcion1.Name = "colca_descripcion1";
            this.colca_descripcion1.Visible = true;
            this.colca_descripcion1.VisibleIndex = 0;
            // 
            // colca_estado1
            // 
            this.colca_estado1.FieldName = "ca_estado";
            this.colca_estado1.Name = "colca_estado1";
            // 
            // colca_orden1
            // 
            this.colca_orden1.FieldName = "ca_orden";
            this.colca_orden1.Name = "colca_orden1";
            // 
            // ColDiasPlazo
            // 
            this.ColDiasPlazo.Caption = "Dia Plazo";
            this.ColDiasPlazo.FieldName = "DiasPlazo";
            this.ColDiasPlazo.Name = "ColDiasPlazo";
            this.ColDiasPlazo.Visible = true;
            this.ColDiasPlazo.VisibleIndex = 1;
            this.ColDiasPlazo.Width = 50;
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemSearchLookUpEdit2
            // 
            this.repositoryItemSearchLookUpEdit2.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2";
            this.repositoryItemSearchLookUpEdit2.View = this.gridView7;
            // 
            // gridView7
            // 
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemSearchLookUpEdit3
            // 
            this.repositoryItemSearchLookUpEdit3.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit3.Name = "repositoryItemSearchLookUpEdit3";
            this.repositoryItemSearchLookUpEdit3.View = this.gridView8;
            // 
            // gridView8
            // 
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemSearchLookUpEdit4
            // 
            this.repositoryItemSearchLookUpEdit4.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit4.Name = "repositoryItemSearchLookUpEdit4";
            this.repositoryItemSearchLookUpEdit4.View = this.gridView9;
            // 
            // gridView9
            // 
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemSearchLookUpEdit5
            // 
            this.repositoryItemSearchLookUpEdit5.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit5.Name = "repositoryItemSearchLookUpEdit5";
            this.repositoryItemSearchLookUpEdit5.View = this.gridView10;
            // 
            // gridView10
            // 
            this.gridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView10.Name = "gridView10";
            this.gridView10.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView10.OptionsView.ShowGroupPanel = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.AutoHeight = false;
            this.cmbEstado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.DisplayMember = "ca_descripcion";
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.ValueMember = "CodCatalogo";
            this.cmbEstado.View = this.repositoryItemSearchLookUpEdit6View;
            // 
            // repositoryItemSearchLookUpEdit6View
            // 
            this.repositoryItemSearchLookUpEdit6View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCatalogo,
            this.colIdTipoCatalogo,
            this.colCodCatalogo,
            this.colca_descripcion,
            this.colca_estado,
            this.colca_orden});
            this.repositoryItemSearchLookUpEdit6View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit6View.Name = "repositoryItemSearchLookUpEdit6View";
            this.repositoryItemSearchLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit6View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCatalogo
            // 
            this.colIdCatalogo.FieldName = "IdCatalogo";
            this.colIdCatalogo.Name = "colIdCatalogo";
            // 
            // colIdTipoCatalogo
            // 
            this.colIdTipoCatalogo.FieldName = "IdTipoCatalogo";
            this.colIdTipoCatalogo.Name = "colIdTipoCatalogo";
            // 
            // colCodCatalogo
            // 
            this.colCodCatalogo.FieldName = "CodCatalogo";
            this.colCodCatalogo.Name = "colCodCatalogo";
            // 
            // colca_descripcion
            // 
            this.colca_descripcion.Caption = "Descripción";
            this.colca_descripcion.FieldName = "ca_descripcion";
            this.colca_descripcion.Name = "colca_descripcion";
            this.colca_descripcion.Visible = true;
            this.colca_descripcion.VisibleIndex = 0;
            // 
            // colca_estado
            // 
            this.colca_estado.FieldName = "ca_estado";
            this.colca_estado.Name = "colca_estado";
            // 
            // colca_orden
            // 
            this.colca_orden.FieldName = "ca_orden";
            this.colca_orden.Name = "colca_orden";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridControlEstado);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(921, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estado Cta. Prestamo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridControlEstado
            // 
            this.gridControlEstado.DataSource = this.baprestamodetalleInfoBindingSource;
            this.gridControlEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEstado.Location = new System.Drawing.Point(3, 3);
            this.gridControlEstado.MainView = this.bandedGridView1;
            this.gridControlEstado.Name = "gridControlEstado";
            this.gridControlEstado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit7,
            this.repositoryItemSearchLookUpEdit8,
            this.repositoryItemSearchLookUpEdit9,
            this.repositoryItemSearchLookUpEdit10,
            this.repositoryItemSearchLookUpEdit11,
            this.repositoryItemSearchLookUpEdit12,
            this.cmbEstadoPag,
            this.btn_editar,
            this.btn_anular});
            this.gridControlEstado.Size = new System.Drawing.Size(915, 216);
            this.gridControlEstado.TabIndex = 23;
            this.gridControlEstado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            this.gridControlEstado.Click += new System.EventHandler(this.gridControlEstado_Click);
            // 
            // baprestamodetalleInfoBindingSource
            // 
            this.baprestamodetalleInfoBindingSource.DataSource = typeof(Core.Erp.Info.Bancos.ba_prestamo_detalle_Info);
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn25,
            this.gridColumn26,
            this.gridColumn27,
            this.gridColumn28,
            this.gridColumn29,
            this.gridColumn30,
            this.gridColumn31,
            this.bandedGridColumn1});
            this.bandedGridView1.GridControl = this.gridControlEstado;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsBehavior.ReadOnly = true;
            this.bandedGridView1.OptionsView.ShowFooter = true;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            this.bandedGridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.bandedGridView1_RowCellClick);
            this.bandedGridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.bandedGridView1_RowCellStyle);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Cuotas";
            this.gridBand1.Columns.Add(this.gridColumn28);
            this.gridBand1.Columns.Add(this.gridColumn4);
            this.gridBand1.Columns.Add(this.gridColumn5);
            this.gridBand1.Columns.Add(this.gridColumn6);
            this.gridBand1.Columns.Add(this.gridColumn7);
            this.gridBand1.Columns.Add(this.gridColumn8);
            this.gridBand1.Columns.Add(this.gridColumn9);
            this.gridBand1.Columns.Add(this.gridColumn10);
            this.gridBand1.Columns.Add(this.gridColumn11);
            this.gridBand1.Columns.Add(this.gridColumn12);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 578;
            // 
            // gridColumn28
            // 
            this.gridColumn28.AppearanceCell.BackColor = System.Drawing.Color.AliceBlue;
            this.gridColumn28.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn28.Caption = "# Cuotas";
            this.gridColumn28.FieldName = "NumCuota";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.Visible = true;
            this.gridColumn28.Width = 33;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.BackColor = System.Drawing.Color.AliceBlue;
            this.gridColumn4.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn4.Caption = "SaldoInicial";
            this.gridColumn4.FieldName = "SaldoInicial";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.Width = 63;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.BackColor = System.Drawing.Color.AliceBlue;
            this.gridColumn5.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn5.Caption = "Interés";
            this.gridColumn5.FieldName = "Interes";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn5.Visible = true;
            this.gridColumn5.Width = 63;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.BackColor = System.Drawing.Color.AliceBlue;
            this.gridColumn6.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn6.Caption = "Abono Capital";
            this.gridColumn6.FieldName = "AbonoCapital";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.Width = 63;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.BackColor = System.Drawing.Color.AliceBlue;
            this.gridColumn7.AppearanceCell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridColumn7.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn7.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn7.Caption = "Total Cuota";
            this.gridColumn7.FieldName = "TotalCuota";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn7.Visible = true;
            this.gridColumn7.Width = 63;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.BackColor = System.Drawing.Color.AliceBlue;
            this.gridColumn8.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn8.Caption = "Saldo";
            this.gridColumn8.FieldName = "Saldo";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.Width = 63;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.BackColor = System.Drawing.Color.AliceBlue;
            this.gridColumn9.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn9.Caption = "Fecha Pago";
            this.gridColumn9.FieldName = "FechaPago";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.Width = 63;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.BackColor = System.Drawing.Color.AliceBlue;
            this.gridColumn10.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn10.Caption = "Observación";
            this.gridColumn10.FieldName = "Observacion_det";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.Width = 59;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Estado";
            this.gridColumn11.FieldName = "Estado";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Width = 41;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceCell.BackColor = System.Drawing.Color.AliceBlue;
            this.gridColumn12.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn12.Caption = "Estado de pago";
            this.gridColumn12.ColumnEdit = this.cmbEstadoPag;
            this.gridColumn12.FieldName = "EstadoPago";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.Width = 108;
            // 
            // cmbEstadoPag
            // 
            this.cmbEstadoPag.AutoHeight = false;
            this.cmbEstadoPag.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstadoPag.DataSource = this.baCatalogoInfoBindingSource;
            this.cmbEstadoPag.DisplayMember = "ca_descripcion";
            this.cmbEstadoPag.Name = "cmbEstadoPag";
            this.cmbEstadoPag.ValueMember = "IdEstadoPago";
            this.cmbEstadoPag.View = this.gridView14;
            // 
            // gridView14
            // 
            this.gridView14.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18});
            this.gridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView14.Name = "gridView14";
            this.gridView14.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView14.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn13
            // 
            this.gridColumn13.FieldName = "IdCatalogo";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // gridColumn14
            // 
            this.gridColumn14.FieldName = "IdTipoCatalogo";
            this.gridColumn14.Name = "gridColumn14";
            // 
            // gridColumn15
            // 
            this.gridColumn15.FieldName = "CodCatalogo";
            this.gridColumn15.Name = "gridColumn15";
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Estado de pago";
            this.gridColumn16.FieldName = "ca_descripcion";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 0;
            // 
            // gridColumn17
            // 
            this.gridColumn17.FieldName = "ca_estado";
            this.gridColumn17.Name = "gridColumn17";
            // 
            // gridColumn18
            // 
            this.gridColumn18.FieldName = "ca_orden";
            this.gridColumn18.Name = "gridColumn18";
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Cancelaciones";
            this.gridBand2.Columns.Add(this.gridColumn29);
            this.gridBand2.Columns.Add(this.gridColumn3);
            this.gridBand2.Columns.Add(this.gridColumn25);
            this.gridBand2.Columns.Add(this.gridColumn26);
            this.gridBand2.Columns.Add(this.gridColumn27);
            this.gridBand2.Columns.Add(this.bandedGridColumn1);
            this.gridBand2.Columns.Add(this.gridColumn30);
            this.gridBand2.Columns.Add(this.gridColumn31);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 372;
            // 
            // gridColumn29
            // 
            this.gridColumn29.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridColumn29.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn29.Caption = "Fecha Cancelación";
            this.gridColumn29.FieldName = "Fecha_Canc";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.Visible = true;
            this.gridColumn29.Width = 62;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridColumn3.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn3.Caption = "# Pagos";
            this.gridColumn3.FieldName = "numcuota_numpago";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.Width = 21;
            // 
            // gridColumn25
            // 
            this.gridColumn25.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridColumn25.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn25.FieldName = "Secuencia";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.Width = 26;
            // 
            // gridColumn26
            // 
            this.gridColumn26.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridColumn26.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn26.Caption = "Monto Cancelado";
            this.gridColumn26.FieldName = "Monto_Canc";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn26.Visible = true;
            this.gridColumn26.Width = 59;
            // 
            // gridColumn27
            // 
            this.gridColumn27.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridColumn27.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn27.Caption = "Saldo Pendiente";
            this.gridColumn27.FieldName = "Saldo_Canc";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.Visible = true;
            this.gridColumn27.Width = 100;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "Observación";
            this.bandedGridColumn1.FieldName = "Observacion_canc";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.Visible = true;
            // 
            // gridColumn30
            // 
            this.gridColumn30.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridColumn30.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn30.ColumnEdit = this.btn_editar;
            this.gridColumn30.FieldName = "btnEditar";
            this.gridColumn30.Name = "gridColumn30";
            this.gridColumn30.OptionsColumn.AllowEdit = false;
            this.gridColumn30.OptionsColumn.ShowCaption = false;
            this.gridColumn30.Visible = true;
            this.gridColumn30.Width = 35;
            // 
            // btn_editar
            // 
            this.btn_editar.Name = "btn_editar";
            // 
            // gridColumn31
            // 
            this.gridColumn31.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridColumn31.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn31.ColumnEdit = this.btn_anular;
            this.gridColumn31.FieldName = "btnAnular";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.OptionsColumn.AllowEdit = false;
            this.gridColumn31.OptionsColumn.ShowCaption = false;
            this.gridColumn31.Visible = true;
            this.gridColumn31.Width = 20;
            // 
            // btn_anular
            // 
            this.btn_anular.Name = "btn_anular";
            // 
            // repositoryItemSearchLookUpEdit7
            // 
            this.repositoryItemSearchLookUpEdit7.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit7.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit7.Name = "repositoryItemSearchLookUpEdit7";
            this.repositoryItemSearchLookUpEdit7.View = this.gridView13;
            // 
            // gridView13
            // 
            this.gridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView13.Name = "gridView13";
            this.gridView13.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView13.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemSearchLookUpEdit8
            // 
            this.repositoryItemSearchLookUpEdit8.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit8.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit8.Name = "repositoryItemSearchLookUpEdit8";
            this.repositoryItemSearchLookUpEdit8.View = this.gridView15;
            // 
            // gridView15
            // 
            this.gridView15.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView15.Name = "gridView15";
            this.gridView15.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView15.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemSearchLookUpEdit9
            // 
            this.repositoryItemSearchLookUpEdit9.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit9.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit9.Name = "repositoryItemSearchLookUpEdit9";
            this.repositoryItemSearchLookUpEdit9.View = this.gridView16;
            // 
            // gridView16
            // 
            this.gridView16.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView16.Name = "gridView16";
            this.gridView16.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView16.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemSearchLookUpEdit10
            // 
            this.repositoryItemSearchLookUpEdit10.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit10.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit10.Name = "repositoryItemSearchLookUpEdit10";
            this.repositoryItemSearchLookUpEdit10.View = this.gridView17;
            // 
            // gridView17
            // 
            this.gridView17.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView17.Name = "gridView17";
            this.gridView17.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView17.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemSearchLookUpEdit11
            // 
            this.repositoryItemSearchLookUpEdit11.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit11.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit11.Name = "repositoryItemSearchLookUpEdit11";
            this.repositoryItemSearchLookUpEdit11.View = this.gridView18;
            // 
            // gridView18
            // 
            this.gridView18.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView18.Name = "gridView18";
            this.gridView18.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView18.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemSearchLookUpEdit12
            // 
            this.repositoryItemSearchLookUpEdit12.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit12.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit12.DisplayMember = "ca_descripcion";
            this.repositoryItemSearchLookUpEdit12.Name = "repositoryItemSearchLookUpEdit12";
            this.repositoryItemSearchLookUpEdit12.ValueMember = "CodCatalogo";
            this.repositoryItemSearchLookUpEdit12.View = this.gridView19;
            // 
            // gridView19
            // 
            this.gridView19.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn24});
            this.gridView19.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView19.Name = "gridView19";
            this.gridView19.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView19.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn19
            // 
            this.gridColumn19.FieldName = "IdCatalogo";
            this.gridColumn19.Name = "gridColumn19";
            // 
            // gridColumn20
            // 
            this.gridColumn20.FieldName = "IdTipoCatalogo";
            this.gridColumn20.Name = "gridColumn20";
            // 
            // gridColumn21
            // 
            this.gridColumn21.FieldName = "CodCatalogo";
            this.gridColumn21.Name = "gridColumn21";
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Descripción";
            this.gridColumn22.FieldName = "ca_descripcion";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 0;
            // 
            // gridColumn23
            // 
            this.gridColumn23.FieldName = "ca_estado";
            this.gridColumn23.Name = "gridColumn23";
            // 
            // gridColumn24
            // 
            this.gridColumn24.FieldName = "ca_orden";
            this.gridColumn24.Name = "gridColumn24";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridControl_Activos_Prendados);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(921, 222);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Activos fijo prendados";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridControl_Activos_Prendados
            // 
            this.gridControl_Activos_Prendados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Activos_Prendados.Location = new System.Drawing.Point(3, 3);
            this.gridControl_Activos_Prendados.MainView = this.gridView_Activos_Prendados;
            this.gridControl_Activos_Prendados.Name = "gridControl_Activos_Prendados";
            this.gridControl_Activos_Prendados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_acticos_fijo});
            this.gridControl_Activos_Prendados.Size = new System.Drawing.Size(915, 216);
            this.gridControl_Activos_Prendados.TabIndex = 0;
            this.gridControl_Activos_Prendados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Activos_Prendados});
            // 
            // gridView_Activos_Prendados
            // 
            this.gridView_Activos_Prendados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdActivoFijo,
            this.Col_Garantia_Bancaria,
            this.col_valor_cancelado,
            this.Col_valor_pendiente,
            this.Col_Af_costo_compra,
            this.Col_porcentaje_prestamo_x_activo});
            this.gridView_Activos_Prendados.GridControl = this.gridControl_Activos_Prendados;
            this.gridView_Activos_Prendados.Name = "gridView_Activos_Prendados";
            this.gridView_Activos_Prendados.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_Activos_Prendados.OptionsView.ShowFooter = true;
            this.gridView_Activos_Prendados.OptionsView.ShowGroupPanel = false;
            this.gridView_Activos_Prendados.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_Activos_Prendados_CellValueChanged);
            this.gridView_Activos_Prendados.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_Activos_Prendados_CellValueChanging);
            this.gridView_Activos_Prendados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_Activos_Prendados_KeyDown);
            // 
            // ColIdActivoFijo
            // 
            this.ColIdActivoFijo.Caption = "Activo Fijo";
            this.ColIdActivoFijo.ColumnEdit = this.cmb_acticos_fijo;
            this.ColIdActivoFijo.FieldName = "IdActivoFijo";
            this.ColIdActivoFijo.Name = "ColIdActivoFijo";
            this.ColIdActivoFijo.Visible = true;
            this.ColIdActivoFijo.VisibleIndex = 0;
            this.ColIdActivoFijo.Width = 329;
            // 
            // cmb_acticos_fijo
            // 
            this.cmb_acticos_fijo.AutoHeight = false;
            this.cmb_acticos_fijo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_acticos_fijo.Name = "cmb_acticos_fijo";
            this.cmb_acticos_fijo.View = this.gridView3;
            this.cmb_acticos_fijo.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cmb_acticos_fijo_EditValueChanging);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_CodActivoFijo,
            this.col_Af_Nombre});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // Col_CodActivoFijo
            // 
            this.Col_CodActivoFijo.Caption = "Codigo";
            this.Col_CodActivoFijo.FieldName = "CodActivoFijo";
            this.Col_CodActivoFijo.Name = "Col_CodActivoFijo";
            this.Col_CodActivoFijo.Visible = true;
            this.Col_CodActivoFijo.VisibleIndex = 0;
            this.Col_CodActivoFijo.Width = 109;
            // 
            // col_Af_Nombre
            // 
            this.col_Af_Nombre.Caption = "Nombre";
            this.col_Af_Nombre.FieldName = "Af_Nombre";
            this.col_Af_Nombre.Name = "col_Af_Nombre";
            this.col_Af_Nombre.Visible = true;
            this.col_Af_Nombre.VisibleIndex = 1;
            this.col_Af_Nombre.Width = 1004;
            // 
            // Col_Garantia_Bancaria
            // 
            this.Col_Garantia_Bancaria.Caption = "Garantia Bancaria";
            this.Col_Garantia_Bancaria.DisplayFormat.FormatString = "n2";
            this.Col_Garantia_Bancaria.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_Garantia_Bancaria.FieldName = "Garantia_Bancaria";
            this.Col_Garantia_Bancaria.Name = "Col_Garantia_Bancaria";
            this.Col_Garantia_Bancaria.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.Col_Garantia_Bancaria.Visible = true;
            this.Col_Garantia_Bancaria.VisibleIndex = 2;
            this.Col_Garantia_Bancaria.Width = 99;
            // 
            // col_valor_cancelado
            // 
            this.col_valor_cancelado.Caption = "Valor Cancelado";
            this.col_valor_cancelado.DisplayFormat.FormatString = "n2";
            this.col_valor_cancelado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_valor_cancelado.FieldName = "valor_cancelado";
            this.col_valor_cancelado.Name = "col_valor_cancelado";
            this.col_valor_cancelado.OptionsColumn.AllowEdit = false;
            this.col_valor_cancelado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.col_valor_cancelado.Visible = true;
            this.col_valor_cancelado.VisibleIndex = 4;
            this.col_valor_cancelado.Width = 106;
            // 
            // Col_valor_pendiente
            // 
            this.Col_valor_pendiente.Caption = "Valor Pendiente";
            this.Col_valor_pendiente.DisplayFormat.FormatString = "n2";
            this.Col_valor_pendiente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_valor_pendiente.FieldName = "valor_pendiente";
            this.Col_valor_pendiente.Name = "Col_valor_pendiente";
            this.Col_valor_pendiente.OptionsColumn.AllowEdit = false;
            this.Col_valor_pendiente.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.Col_valor_pendiente.Visible = true;
            this.Col_valor_pendiente.VisibleIndex = 5;
            this.Col_valor_pendiente.Width = 127;
            // 
            // Col_Af_costo_compra
            // 
            this.Col_Af_costo_compra.Caption = "Valor Adquisicion";
            this.Col_Af_costo_compra.DisplayFormat.FormatString = "n2";
            this.Col_Af_costo_compra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_Af_costo_compra.FieldName = "Af_costo_compra";
            this.Col_Af_costo_compra.Name = "Col_Af_costo_compra";
            this.Col_Af_costo_compra.OptionsColumn.AllowEdit = false;
            this.Col_Af_costo_compra.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.Col_Af_costo_compra.Visible = true;
            this.Col_Af_costo_compra.VisibleIndex = 1;
            this.Col_Af_costo_compra.Width = 121;
            // 
            // Col_porcentaje_prestamo_x_activo
            // 
            this.Col_porcentaje_prestamo_x_activo.Caption = "% Prestamo por activo";
            this.Col_porcentaje_prestamo_x_activo.DisplayFormat.FormatString = "n2";
            this.Col_porcentaje_prestamo_x_activo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_porcentaje_prestamo_x_activo.FieldName = "porcentaje_prestamo_x_activo";
            this.Col_porcentaje_prestamo_x_activo.GroupFormat.FormatString = "n2";
            this.Col_porcentaje_prestamo_x_activo.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_porcentaje_prestamo_x_activo.Name = "Col_porcentaje_prestamo_x_activo";
            this.Col_porcentaje_prestamo_x_activo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.Col_porcentaje_prestamo_x_activo.Visible = true;
            this.Col_porcentaje_prestamo_x_activo.VisibleIndex = 3;
            this.Col_porcentaje_prestamo_x_activo.Width = 115;
            // 
            // imageBotones
            // 
            this.imageBotones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageBotones.ImageStream")));
            this.imageBotones.TransparentColor = System.Drawing.Color.Transparent;
            this.imageBotones.Images.SetKeyName(0, "edit.ico");
            this.imageBotones.Images.SetKeyName(1, "delete.ico");
            this.imageBotones.Images.SetKeyName(2, "imagen_blanco.jpg");
            // 
            // FrmBA_PrestamosMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 481);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmBA_PrestamosMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamo Bancario Mantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBA_PrestamosMantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.frmBA_Prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baCatalogoInfoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpagoContado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeInteres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeMontoSol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaPago.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCuotas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMetodoCalc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaReg.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaReg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodPrestamo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdPrestamo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMotivoPrest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baBancoCuentaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baCbteBanInfoBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbestadoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit6View)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baprestamodetalleInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoPag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_anular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView19)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Activos_Prendados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Activos_Prendados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_acticos_fijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.DateEdit dtpFechaPago;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGenerar;
        private DevExpress.XtraEditors.TextEdit txtNumCuotas;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbMetodoCalc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbPeriodoPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn gridca_descripcion_Pago;
        private DevExpress.XtraGrid.Columns.GridColumn gridCodCatalogoPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DateEdit dtpFechaReg;
        private DevExpress.XtraEditors.TextEdit txtCodPrestamo;
        private DevExpress.XtraEditors.TextEdit txtIdPrestamo;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbMotivoPrest;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridca_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridCodCatalogo;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btnGuardarSalir;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.BindingSource baCatalogoInfoBindingSource;
        private System.Windows.Forms.BindingSource baBancoCuentaInfoBindingSource;
        private System.Windows.Forms.BindingSource baCbteBanInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colca_descripcion2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMetCalc;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colba_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gridControlDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCuota;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIntres;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValInte;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTotCuota;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFecha;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEstadoPago;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCmbEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbestadoPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView11;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCatalogo1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodCatalogo1;
        private DevExpress.XtraGrid.Columns.GridColumn colca_descripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colca_estado1;
        private DevExpress.XtraGrid.Columns.GridColumn colca_orden1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit6View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colca_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colca_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colca_orden;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridControlEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbEstadoPag;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView13;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView15;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit9;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView16;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit10;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView17;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit11;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView18;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit12;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit btn_editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit btn_anular;
        private System.Windows.Forms.ImageList imageBotones;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn8;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn9;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn10;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn11;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn12;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn29;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn28;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn25;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn26;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn27;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn31;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn30;
        private System.Windows.Forms.ToolStripButton btnCuotas;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private System.Windows.Forms.BindingSource baprestamodetalleInfoBindingSource;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnImprimirEC;
        private DevExpress.XtraEditors.TextEdit txeMontoSol;
        private DevExpress.XtraEditors.TextEdit txeInteres;
        private System.Windows.Forms.Label label5;
        private Controles.UCBa_TipoFlujo ucBa_TipoFlujo;
        private System.Windows.Forms.Label label14;
        private Controles.UCCon_PlanCtaCmb ucCon_PlanCtaCmb;
        private DevExpress.XtraGrid.Columns.GridColumn ColDiasPlazo;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraGrid.GridControl gridControl_Activos_Prendados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Activos_Prendados;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdActivoFijo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_acticos_fijo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Garantia_Bancaria;
        private DevExpress.XtraGrid.Columns.GridColumn col_valor_cancelado;
        private DevExpress.XtraGrid.Columns.GridColumn Col_valor_pendiente;
        private DevExpress.XtraGrid.Columns.GridColumn Col_CodActivoFijo;
        private DevExpress.XtraGrid.Columns.GridColumn col_Af_Nombre;
        private DevExpress.XtraEditors.TextEdit txtpagoContado;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Af_costo_compra;
        private DevExpress.XtraGrid.Columns.GridColumn Col_porcentaje_prestamo_x_activo;
        private Controles.UCFa_Cliente_x_centro_costo_cmb cmb_cliente;
    }
}