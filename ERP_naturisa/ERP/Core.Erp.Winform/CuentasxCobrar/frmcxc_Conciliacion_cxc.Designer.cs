namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxc_Conciliacion_cxc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.txtNumConcilia = new DevExpress.XtraEditors.TextEdit();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.dteFecha = new DevExpress.XtraEditors.DateEdit();
            this.ucfA_Cliente_Facturacion1 = new Core.Erp.Winform.Controles.UCFa_Cliente_Facturacion();
            this.ucIn_Sucursal_Bodega1 = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.vwcxccobrosPendientesxconciliarInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.vwcxccarteraxcobrarInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.vwfacreditosdebitosconsaldoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControlGeneral = new System.Windows.Forms.TabControl();
            this.tabDocConcilia = new System.Windows.Forms.TabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabDebCre = new System.Windows.Forms.TabPage();
            this.gridControlCreDebSaldo = new DevExpress.XtraGrid.GridControl();
            this.gridViewCreDebSaldo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreDeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumNota_Impresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_Bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_fecha_venc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsc_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivo_Nota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsc_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheck_cds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsaldoAUX_CreDeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoConciliacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdCtaCble_cxc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdCtaCble_Anti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSaldo = new System.Windows.Forms.ComboBox();
            this.gridControlFacturas = new DevExpress.XtraGrid.GridControl();
            this.gridViewFacturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvt_tipoDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvt_NunDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvt_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvt_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalxCobrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvt_Subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvt_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_nombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheck_cartera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvt_fech_venc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_aplicar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoAUX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabDiarioContable = new System.Windows.Forms.TabPage();
            this.pnlDiarioCble = new DevExpress.XtraEditors.PanelControl();
            this.ucCon_GridDiario = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNota2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreDeb2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumNota_Impresa2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomSucursal2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_Bodega2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_fecha2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_fecha_venc2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsc_observacion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_Cliente2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivo_Nota2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsc_total2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheck_cds2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsaldoAUX_CreDeb2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoConciliacion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_Tipo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoNota2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCaja1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompleto2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNota3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreDeb3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumNota_Impresa3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomSucursal3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_Bodega3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_fecha3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_fecha_venc3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsc_observacion3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_Cliente3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivo_Nota3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsc_total3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheck_cds3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsaldoAUX_CreDeb3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoConciliacion3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_Tipo3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoNota3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCaja2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompleto3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_cxc1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Anti1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumConcilia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcxccobrosPendientesxconciliarInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcxccarteraxcobrarInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwfacreditosdebitosconsaldoInfoBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControlGeneral.SuspendLayout();
            this.tabDocConcilia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TabDebCre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCreDebSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCreDebSaldo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFacturas)).BeginInit();
            this.tabDiarioContable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDiarioCble)).BeginInit();
            this.pnlDiarioCble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conciliación #:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Observación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(828, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAnulado);
            this.panel1.Controls.Add(this.txtNumConcilia);
            this.panel1.Controls.Add(this.txtObservacion);
            this.panel1.Controls.Add(this.dteFecha);
            this.panel1.Controls.Add(this.ucfA_Cliente_Facturacion1);
            this.panel1.Controls.Add(this.ucIn_Sucursal_Bodega1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 142);
            this.panel1.TabIndex = 7;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(654, 12);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(168, 24);
            this.lblAnulado.TabIndex = 13;
            this.lblAnulado.Text = "*** ANULADO ***";
            // 
            // txtNumConcilia
            // 
            this.txtNumConcilia.Location = new System.Drawing.Point(98, 9);
            this.txtNumConcilia.Name = "txtNumConcilia";
            this.txtNumConcilia.Size = new System.Drawing.Size(100, 20);
            this.txtNumConcilia.TabIndex = 9;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(98, 101);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(882, 28);
            this.txtObservacion.TabIndex = 11;
            // 
            // dteFecha
            // 
            this.dteFecha.EditValue = null;
            this.dteFecha.Location = new System.Drawing.Point(880, 13);
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteFecha.Size = new System.Drawing.Size(100, 20);
            this.dteFecha.TabIndex = 10;
            // 
            // ucfA_Cliente_Facturacion1
            // 
            this.ucfA_Cliente_Facturacion1.Location = new System.Drawing.Point(12, 65);
            this.ucfA_Cliente_Facturacion1.Name = "ucfA_Cliente_Facturacion1";
            this.ucfA_Cliente_Facturacion1.Size = new System.Drawing.Size(465, 30);
            this.ucfA_Cliente_Facturacion1.TabIndex = 9;
            this.ucfA_Cliente_Facturacion1.Event_cmb_cliente_EditValueChanged += new Core.Erp.Winform.Controles.UCFa_Cliente_Facturacion.Delegate_cmb_cliente_EditValueChanged(this.ucfA_Cliente_Facturacion1_Event_cmb_cliente_EditValueChanged);
            // 
            // ucIn_Sucursal_Bodega1
            // 
            this.ucIn_Sucursal_Bodega1.Location = new System.Drawing.Point(25, 32);
            this.ucIn_Sucursal_Bodega1.Name = "ucIn_Sucursal_Bodega1";
            this.ucIn_Sucursal_Bodega1.Size = new System.Drawing.Size(467, 27);
            this.ucIn_Sucursal_Bodega1.TabIndex = 6;
            this.ucIn_Sucursal_Bodega1.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.todos;
            this.ucIn_Sucursal_Bodega1.Event_cmb_sucursal_SelectedIndexChanged += new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectedIndexChanged(this.ucIn_Sucursal_Bodega1_Event_cmb_sucursal_SelectedIndexChanged);
            // 
            // vwcxccobrosPendientesxconciliarInfoBindingSource
            // 
            this.vwcxccobrosPendientesxconciliarInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.vwcxc_cobros_Pendientes_x_conciliar_Info);
            // 
            // vwcxccarteraxcobrarInfoBindingSource
            // 
            this.vwcxccarteraxcobrarInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.vwcxc_cartera_x_cobrar_Info);
            // 
            // vwfacreditosdebitosconsaldoInfoBindingSource
            // 
            this.vwfacreditosdebitosconsaldoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Facturacion.vwfa_creditos_debitos_con_saldo_Info);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 621);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 28);
            this.panel2.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(983, 28);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControlGeneral);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(983, 454);
            this.panel3.TabIndex = 12;
            // 
            // tabControlGeneral
            // 
            this.tabControlGeneral.AccessibleName = "";
            this.tabControlGeneral.Controls.Add(this.tabDocConcilia);
            this.tabControlGeneral.Controls.Add(this.tabDiarioContable);
            this.tabControlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlGeneral.Location = new System.Drawing.Point(0, 0);
            this.tabControlGeneral.Name = "tabControlGeneral";
            this.tabControlGeneral.SelectedIndex = 0;
            this.tabControlGeneral.Size = new System.Drawing.Size(983, 454);
            this.tabControlGeneral.TabIndex = 2;
            this.tabControlGeneral.Click += new System.EventHandler(this.bloquearDiario);
            // 
            // tabDocConcilia
            // 
            this.tabDocConcilia.Controls.Add(this.panelControl1);
            this.tabDocConcilia.Location = new System.Drawing.Point(4, 22);
            this.tabDocConcilia.Name = "tabDocConcilia";
            this.tabDocConcilia.Padding = new System.Windows.Forms.Padding(3);
            this.tabDocConcilia.Size = new System.Drawing.Size(975, 428);
            this.tabDocConcilia.TabIndex = 0;
            this.tabDocConcilia.Text = "Documentos a Conciliar";
            this.tabDocConcilia.UseVisualStyleBackColor = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainer3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(969, 422);
            this.panelControl1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(2, 2);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer3.Size = new System.Drawing.Size(965, 418);
            this.splitContainer3.SplitterDistance = 231;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TabControl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores disponibles por cruzar:";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabDebCre);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(3, 16);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(959, 212);
            this.TabControl.TabIndex = 1;
            this.TabControl.Click += new System.EventHandler(this.TabControl_Click);
            // 
            // TabDebCre
            // 
            this.TabDebCre.Controls.Add(this.gridControlCreDebSaldo);
            this.TabDebCre.Location = new System.Drawing.Point(4, 22);
            this.TabDebCre.Name = "TabDebCre";
            this.TabDebCre.Padding = new System.Windows.Forms.Padding(3);
            this.TabDebCre.Size = new System.Drawing.Size(951, 186);
            this.TabDebCre.TabIndex = 0;
            this.TabDebCre.Text = "Nota Deb/Cre Pendientes";
            this.TabDebCre.UseVisualStyleBackColor = true;
            // 
            // gridControlCreDebSaldo
            // 
            this.gridControlCreDebSaldo.DataSource = this.vwcxccobrosPendientesxconciliarInfoBindingSource;
            this.gridControlCreDebSaldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCreDebSaldo.Location = new System.Drawing.Point(3, 3);
            this.gridControlCreDebSaldo.MainView = this.gridViewCreDebSaldo;
            this.gridControlCreDebSaldo.Name = "gridControlCreDebSaldo";
            this.gridControlCreDebSaldo.Size = new System.Drawing.Size(945, 180);
            this.gridControlCreDebSaldo.TabIndex = 0;
            this.gridControlCreDebSaldo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCreDebSaldo,
            this.gridView4});
            // 
            // gridViewCreDebSaldo
            // 
            this.gridViewCreDebSaldo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa1,
            this.colIdSucursal1,
            this.colIdBodega1,
            this.colTipo,
            this.colIdNota,
            this.colCreDeb,
            this.colSerie1,
            this.colSerie2,
            this.colNumNota_Impresa,
            this.colIdCliente1,
            this.colNomSucursal,
            this.colNom_Bodega,
            this.colno_fecha,
            this.colno_fecha_venc,
            this.colsc_observacion,
            this.colNom_Cliente,
            this.colMotivo_Nota,
            this.colReferencia1,
            this.colsc_total,
            this.colSaldo1,
            this.colcheck_cds,
            this.colsaldoAUX_CreDeb,
            this.colIdTipoConciliacion,
            this.colIdCobro,
            this.colIdCobro_Tipo,
            this.colNombreCompleto,
            this.colIdTipoNota,
            this.ColIdCtaCble_cxc,
            this.ColIdCtaCble_Anti});
            this.gridViewCreDebSaldo.GridControl = this.gridControlCreDebSaldo;
            this.gridViewCreDebSaldo.Name = "gridViewCreDebSaldo";
            this.gridViewCreDebSaldo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCreDebSaldo.OptionsView.ShowGroupPanel = false;
            this.gridViewCreDebSaldo.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewCreDebSaldo_RowClick);
            this.gridViewCreDebSaldo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewCreDebSaldo_RowCellStyle);
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            // 
            // colIdSucursal1
            // 
            this.colIdSucursal1.FieldName = "IdSucursal";
            this.colIdSucursal1.Name = "colIdSucursal1";
            // 
            // colIdBodega1
            // 
            this.colIdBodega1.FieldName = "IdBodega";
            this.colIdBodega1.Name = "colIdBodega1";
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 4;
            this.colTipo.Width = 66;
            // 
            // colIdNota
            // 
            this.colIdNota.Caption = "IdNota";
            this.colIdNota.FieldName = "IdNota";
            this.colIdNota.Name = "colIdNota";
            this.colIdNota.OptionsColumn.AllowEdit = false;
            this.colIdNota.Visible = true;
            this.colIdNota.VisibleIndex = 5;
            this.colIdNota.Width = 66;
            // 
            // colCreDeb
            // 
            this.colCreDeb.FieldName = "CreDeb";
            this.colCreDeb.Name = "colCreDeb";
            // 
            // colSerie1
            // 
            this.colSerie1.FieldName = "Serie1";
            this.colSerie1.Name = "colSerie1";
            // 
            // colSerie2
            // 
            this.colSerie2.FieldName = "Serie2";
            this.colSerie2.Name = "colSerie2";
            // 
            // colNumNota_Impresa
            // 
            this.colNumNota_Impresa.FieldName = "NumNota_Impresa";
            this.colNumNota_Impresa.Name = "colNumNota_Impresa";
            // 
            // colIdCliente1
            // 
            this.colIdCliente1.FieldName = "IdCliente";
            this.colIdCliente1.Name = "colIdCliente1";
            // 
            // colNomSucursal
            // 
            this.colNomSucursal.Caption = "Sucursal";
            this.colNomSucursal.FieldName = "NomSucursal";
            this.colNomSucursal.Name = "colNomSucursal";
            this.colNomSucursal.OptionsColumn.AllowEdit = false;
            this.colNomSucursal.Visible = true;
            this.colNomSucursal.VisibleIndex = 1;
            this.colNomSucursal.Width = 103;
            // 
            // colNom_Bodega
            // 
            this.colNom_Bodega.Caption = "Bodega";
            this.colNom_Bodega.FieldName = "Nom_Bodega";
            this.colNom_Bodega.Name = "colNom_Bodega";
            this.colNom_Bodega.OptionsColumn.AllowEdit = false;
            this.colNom_Bodega.Visible = true;
            this.colNom_Bodega.VisibleIndex = 2;
            this.colNom_Bodega.Width = 80;
            // 
            // colno_fecha
            // 
            this.colno_fecha.Caption = "Fecha";
            this.colno_fecha.FieldName = "no_fecha";
            this.colno_fecha.Name = "colno_fecha";
            this.colno_fecha.OptionsColumn.AllowEdit = false;
            this.colno_fecha.Visible = true;
            this.colno_fecha.VisibleIndex = 6;
            this.colno_fecha.Width = 66;
            // 
            // colno_fecha_venc
            // 
            this.colno_fecha_venc.FieldName = "no_fecha_venc";
            this.colno_fecha_venc.Name = "colno_fecha_venc";
            // 
            // colsc_observacion
            // 
            this.colsc_observacion.Caption = "Observación";
            this.colsc_observacion.FieldName = "sc_observacion";
            this.colsc_observacion.Name = "colsc_observacion";
            this.colsc_observacion.OptionsColumn.AllowEdit = false;
            this.colsc_observacion.Visible = true;
            this.colsc_observacion.VisibleIndex = 9;
            this.colsc_observacion.Width = 66;
            // 
            // colNom_Cliente
            // 
            this.colNom_Cliente.Caption = "Cliente";
            this.colNom_Cliente.FieldName = "Nom_Cliente";
            this.colNom_Cliente.Name = "colNom_Cliente";
            this.colNom_Cliente.OptionsColumn.AllowEdit = false;
            this.colNom_Cliente.Width = 187;
            // 
            // colMotivo_Nota
            // 
            this.colMotivo_Nota.Caption = "Motivo";
            this.colMotivo_Nota.FieldName = "Motivo_Nota";
            this.colMotivo_Nota.Name = "colMotivo_Nota";
            this.colMotivo_Nota.OptionsColumn.AllowEdit = false;
            this.colMotivo_Nota.Visible = true;
            this.colMotivo_Nota.VisibleIndex = 8;
            this.colMotivo_Nota.Width = 66;
            // 
            // colReferencia1
            // 
            this.colReferencia1.Caption = "Referencia";
            this.colReferencia1.FieldName = "Referencia";
            this.colReferencia1.Name = "colReferencia1";
            this.colReferencia1.OptionsColumn.AllowEdit = false;
            this.colReferencia1.Visible = true;
            this.colReferencia1.VisibleIndex = 7;
            this.colReferencia1.Width = 66;
            // 
            // colsc_total
            // 
            this.colsc_total.Caption = "Valor";
            this.colsc_total.FieldName = "sc_total";
            this.colsc_total.Name = "colsc_total";
            this.colsc_total.OptionsColumn.AllowEdit = false;
            this.colsc_total.Visible = true;
            this.colsc_total.VisibleIndex = 10;
            this.colsc_total.Width = 66;
            // 
            // colSaldo1
            // 
            this.colSaldo1.Caption = "Saldo";
            this.colSaldo1.FieldName = "Saldo";
            this.colSaldo1.Name = "colSaldo1";
            this.colSaldo1.OptionsColumn.AllowEdit = false;
            this.colSaldo1.Visible = true;
            this.colSaldo1.VisibleIndex = 11;
            this.colSaldo1.Width = 74;
            // 
            // colcheck_cds
            // 
            this.colcheck_cds.Caption = "*";
            this.colcheck_cds.FieldName = "check_cds";
            this.colcheck_cds.Name = "colcheck_cds";
            this.colcheck_cds.OptionsColumn.AllowSize = false;
            this.colcheck_cds.Visible = true;
            this.colcheck_cds.VisibleIndex = 0;
            this.colcheck_cds.Width = 30;
            // 
            // colsaldoAUX_CreDeb
            // 
            this.colsaldoAUX_CreDeb.FieldName = "saldoAUX_CreDeb";
            this.colsaldoAUX_CreDeb.Name = "colsaldoAUX_CreDeb";
            // 
            // colIdTipoConciliacion
            // 
            this.colIdTipoConciliacion.Caption = "Tipo Conciliación";
            this.colIdTipoConciliacion.FieldName = "IdTipoConciliacion";
            this.colIdTipoConciliacion.Name = "colIdTipoConciliacion";
            this.colIdTipoConciliacion.OptionsColumn.AllowEdit = false;
            this.colIdTipoConciliacion.Visible = true;
            this.colIdTipoConciliacion.VisibleIndex = 12;
            this.colIdTipoConciliacion.Width = 54;
            // 
            // colIdCobro
            // 
            this.colIdCobro.Caption = "IdCobro";
            this.colIdCobro.FieldName = "IdCobro";
            this.colIdCobro.Name = "colIdCobro";
            this.colIdCobro.OptionsColumn.AllowEdit = false;
            this.colIdCobro.Width = 54;
            // 
            // colIdCobro_Tipo
            // 
            this.colIdCobro_Tipo.Caption = "IdCobro_Tipo";
            this.colIdCobro_Tipo.FieldName = "IdCobro_Tipo";
            this.colIdCobro_Tipo.Name = "colIdCobro_Tipo";
            this.colIdCobro_Tipo.OptionsColumn.AllowEdit = false;
            this.colIdCobro_Tipo.Width = 54;
            // 
            // colNombreCompleto
            // 
            this.colNombreCompleto.Caption = "Cliente";
            this.colNombreCompleto.FieldName = "NombreCompleto";
            this.colNombreCompleto.Name = "colNombreCompleto";
            this.colNombreCompleto.OptionsColumn.AllowEdit = false;
            this.colNombreCompleto.Visible = true;
            this.colNombreCompleto.VisibleIndex = 3;
            this.colNombreCompleto.Width = 187;
            // 
            // colIdTipoNota
            // 
            this.colIdTipoNota.Caption = "IdTipoNota ";
            this.colIdTipoNota.FieldName = "IdTipoNota";
            this.colIdTipoNota.Name = "colIdTipoNota";
            this.colIdTipoNota.OptionsColumn.AllowEdit = false;
            this.colIdTipoNota.Width = 76;
            // 
            // ColIdCtaCble_cxc
            // 
            this.ColIdCtaCble_cxc.Caption = "IdCtaCble_cxc";
            this.ColIdCtaCble_cxc.FieldName = "IdCtaCble_cxc";
            this.ColIdCtaCble_cxc.Name = "ColIdCtaCble_cxc";
            // 
            // ColIdCtaCble_Anti
            // 
            this.ColIdCtaCble_Anti.Caption = "IdCtaCble_Anti";
            this.ColIdCtaCble_Anti.FieldName = "IdCtaCble_Anti";
            this.ColIdCtaCble_Anti.Name = "ColIdCtaCble_Anti";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(965, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Documentos de ventas disponibles:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.cmbSaldo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridControlFacturas);
            this.splitContainer2.Size = new System.Drawing.Size(959, 164);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mostrar Documentos con saldo";
            // 
            // cmbSaldo
            // 
            this.cmbSaldo.FormattingEnabled = true;
            this.cmbSaldo.Items.AddRange(new object[] {
            ">0",
            "<=0"});
            this.cmbSaldo.Location = new System.Drawing.Point(167, 1);
            this.cmbSaldo.Name = "cmbSaldo";
            this.cmbSaldo.Size = new System.Drawing.Size(60, 21);
            this.cmbSaldo.TabIndex = 0;
            // 
            // gridControlFacturas
            // 
            this.gridControlFacturas.DataSource = this.vwcxccarteraxcobrarInfoBindingSource;
            this.gridControlFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFacturas.Location = new System.Drawing.Point(0, 0);
            this.gridControlFacturas.MainView = this.gridViewFacturas;
            this.gridControlFacturas.Name = "gridControlFacturas";
            this.gridControlFacturas.Size = new System.Drawing.Size(959, 135);
            this.gridControlFacturas.TabIndex = 1;
            this.gridControlFacturas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFacturas});
            // 
            // gridViewFacturas
            // 
            this.gridViewFacturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdBodega,
            this.colvt_tipoDoc,
            this.colvt_NunDocumento,
            this.colReferencia,
            this.colIdComprobante,
            this.colCodComprobante,
            this.colSu_Descripcion,
            this.colIdCliente,
            this.colvt_fecha,
            this.colvt_total,
            this.colSaldo,
            this.colTotalxCobrado,
            this.colBodega,
            this.colvt_Subtotal,
            this.colvt_iva,
            this.colpe_nombreCompleto,
            this.colcheck_cartera,
            this.colvt_fech_venc,
            this.colplazo,
            this.colobservacion,
            this.colvalor_aplicar,
            this.colNomCliente,
            this.colSaldoAUX});
            this.gridViewFacturas.GridControl = this.gridControlFacturas;
            this.gridViewFacturas.Name = "gridViewFacturas";
            this.gridViewFacturas.OptionsView.ShowAutoFilterRow = true;
            this.gridViewFacturas.OptionsView.ShowGroupPanel = false;
            this.gridViewFacturas.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewFacturas_RowClick);
            this.gridViewFacturas.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewFacturas_CellValueChanged);
            this.gridViewFacturas.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewFacturas_CellValueChanging);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.Caption = "Sucursal";
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.Width = 99;
            // 
            // colIdBodega
            // 
            this.colIdBodega.Caption = "Bodega";
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            this.colIdBodega.Width = 99;
            // 
            // colvt_tipoDoc
            // 
            this.colvt_tipoDoc.FieldName = "vt_tipoDoc";
            this.colvt_tipoDoc.Name = "colvt_tipoDoc";
            // 
            // colvt_NunDocumento
            // 
            this.colvt_NunDocumento.Caption = "# Documento";
            this.colvt_NunDocumento.FieldName = "vt_NunDocumento";
            this.colvt_NunDocumento.Name = "colvt_NunDocumento";
            this.colvt_NunDocumento.Visible = true;
            this.colvt_NunDocumento.VisibleIndex = 5;
            this.colvt_NunDocumento.Width = 85;
            // 
            // colReferencia
            // 
            this.colReferencia.Caption = "Referencia";
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.OptionsColumn.AllowEdit = false;
            this.colReferencia.Visible = true;
            this.colReferencia.VisibleIndex = 4;
            this.colReferencia.Width = 125;
            // 
            // colIdComprobante
            // 
            this.colIdComprobante.FieldName = "IdComprobante";
            this.colIdComprobante.Name = "colIdComprobante";
            // 
            // colCodComprobante
            // 
            this.colCodComprobante.FieldName = "CodComprobante";
            this.colCodComprobante.Name = "colCodComprobante";
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Sucursal";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.OptionsColumn.AllowEdit = false;
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 1;
            this.colSu_Descripcion.Width = 131;
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colvt_fecha
            // 
            this.colvt_fecha.Caption = "Fecha";
            this.colvt_fecha.FieldName = "vt_fecha";
            this.colvt_fecha.Name = "colvt_fecha";
            this.colvt_fecha.OptionsColumn.AllowEdit = false;
            this.colvt_fecha.Visible = true;
            this.colvt_fecha.VisibleIndex = 6;
            this.colvt_fecha.Width = 89;
            // 
            // colvt_total
            // 
            this.colvt_total.Caption = "Total";
            this.colvt_total.FieldName = "vt_total";
            this.colvt_total.Name = "colvt_total";
            this.colvt_total.OptionsColumn.AllowEdit = false;
            this.colvt_total.Visible = true;
            this.colvt_total.VisibleIndex = 8;
            this.colvt_total.Width = 61;
            // 
            // colSaldo
            // 
            this.colSaldo.Caption = "Saldo";
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.OptionsColumn.AllowEdit = false;
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 9;
            this.colSaldo.Width = 61;
            // 
            // colTotalxCobrado
            // 
            this.colTotalxCobrado.FieldName = "TotalxCobrado";
            this.colTotalxCobrado.Name = "colTotalxCobrado";
            // 
            // colBodega
            // 
            this.colBodega.Caption = "Bodega";
            this.colBodega.FieldName = "Bodega";
            this.colBodega.Name = "colBodega";
            this.colBodega.OptionsColumn.AllowEdit = false;
            this.colBodega.Visible = true;
            this.colBodega.VisibleIndex = 2;
            this.colBodega.Width = 130;
            // 
            // colvt_Subtotal
            // 
            this.colvt_Subtotal.FieldName = "vt_Subtotal";
            this.colvt_Subtotal.Name = "colvt_Subtotal";
            // 
            // colvt_iva
            // 
            this.colvt_iva.FieldName = "vt_iva";
            this.colvt_iva.Name = "colvt_iva";
            // 
            // colpe_nombreCompleto
            // 
            this.colpe_nombreCompleto.Caption = "Cliente";
            this.colpe_nombreCompleto.FieldName = "pe_nombreCompleto";
            this.colpe_nombreCompleto.Name = "colpe_nombreCompleto";
            this.colpe_nombreCompleto.OptionsColumn.AllowEdit = false;
            this.colpe_nombreCompleto.Width = 199;
            // 
            // colcheck_cartera
            // 
            this.colcheck_cartera.Caption = "*";
            this.colcheck_cartera.FieldName = "check_cartera";
            this.colcheck_cartera.Name = "colcheck_cartera";
            this.colcheck_cartera.OptionsColumn.AllowEdit = false;
            this.colcheck_cartera.OptionsColumn.AllowSize = false;
            this.colcheck_cartera.Visible = true;
            this.colcheck_cartera.VisibleIndex = 0;
            this.colcheck_cartera.Width = 27;
            // 
            // colvt_fech_venc
            // 
            this.colvt_fech_venc.Caption = "Fecha de vencimiento";
            this.colvt_fech_venc.FieldName = "vt_fech_venc";
            this.colvt_fech_venc.Name = "colvt_fech_venc";
            this.colvt_fech_venc.OptionsColumn.AllowEdit = false;
            this.colvt_fech_venc.Visible = true;
            this.colvt_fech_venc.VisibleIndex = 7;
            this.colvt_fech_venc.Width = 131;
            // 
            // colplazo
            // 
            this.colplazo.Caption = "Plazo";
            this.colplazo.FieldName = "plazo";
            this.colplazo.Name = "colplazo";
            this.colplazo.Width = 70;
            // 
            // colobservacion
            // 
            this.colobservacion.Caption = "Observación";
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.Width = 124;
            // 
            // colvalor_aplicar
            // 
            this.colvalor_aplicar.Caption = "Valor a aplicar";
            this.colvalor_aplicar.FieldName = "valor_aplicar";
            this.colvalor_aplicar.Name = "colvalor_aplicar";
            this.colvalor_aplicar.Visible = true;
            this.colvalor_aplicar.VisibleIndex = 10;
            this.colvalor_aplicar.Width = 134;
            // 
            // colNomCliente
            // 
            this.colNomCliente.Caption = "Cliente";
            this.colNomCliente.FieldName = "NomCliente";
            this.colNomCliente.Name = "colNomCliente";
            this.colNomCliente.Visible = true;
            this.colNomCliente.VisibleIndex = 3;
            this.colNomCliente.Width = 200;
            // 
            // colSaldoAUX
            // 
            this.colSaldoAUX.FieldName = "SaldoAUX";
            this.colSaldoAUX.Name = "colSaldoAUX";
            // 
            // tabDiarioContable
            // 
            this.tabDiarioContable.Controls.Add(this.pnlDiarioCble);
            this.tabDiarioContable.Location = new System.Drawing.Point(4, 22);
            this.tabDiarioContable.Name = "tabDiarioContable";
            this.tabDiarioContable.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiarioContable.Size = new System.Drawing.Size(975, 428);
            this.tabDiarioContable.TabIndex = 1;
            this.tabDiarioContable.Text = "Diario Contable";
            this.tabDiarioContable.UseVisualStyleBackColor = true;
            // 
            // pnlDiarioCble
            // 
            this.pnlDiarioCble.Controls.Add(this.ucCon_GridDiario);
            this.pnlDiarioCble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDiarioCble.Location = new System.Drawing.Point(3, 3);
            this.pnlDiarioCble.Name = "pnlDiarioCble";
            this.pnlDiarioCble.Size = new System.Drawing.Size(969, 422);
            this.pnlDiarioCble.TabIndex = 0;
            // 
            // ucCon_GridDiario
            // 
            this.ucCon_GridDiario.Visible_Botones = false;
            this.ucCon_GridDiario.Visible_Cabecera = false;
            this.ucCon_GridDiario.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.ucCon_GridDiario.ListaCtaCble = null;
            this.ucCon_GridDiario.Location = new System.Drawing.Point(2, 2);
            this.ucCon_GridDiario.Name = "ucCon_GridDiario";
            this.ucCon_GridDiario.Size = new System.Drawing.Size(965, 418);
            this.ucCon_GridDiario.TabIndex = 0;
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
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(983, 29);
            this.ucGe_Menu.TabIndex = 13;
            this.ucGe_Menu.Visible_bntAnular = true;
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
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = true;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa3,
            this.colIdSucursal3,
            this.colIdBodega3,
            this.colTipo2,
            this.colIdCobro2,
            this.colIdNota2,
            this.colCreDeb2,
            this.colSerie12,
            this.colSerie22,
            this.colNumNota_Impresa2,
            this.colIdCliente3,
            this.colNomSucursal2,
            this.colNom_Bodega2,
            this.colno_fecha2,
            this.colno_fecha_venc2,
            this.colsc_observacion2,
            this.colNom_Cliente2,
            this.colMotivo_Nota2,
            this.colReferencia3,
            this.colsc_total2,
            this.colSaldo3,
            this.colcheck_cds2,
            this.colsaldoAUX_CreDeb2,
            this.colIdTipoConciliacion2,
            this.colIdCobro_Tipo2,
            this.colIdTipoNota2,
            this.colIdCaja1,
            this.colNombreCompleto2});
            this.gridView2.Name = "gridView2";
            // 
            // colIdEmpresa3
            // 
            this.colIdEmpresa3.FieldName = "IdEmpresa";
            this.colIdEmpresa3.Name = "colIdEmpresa3";
            this.colIdEmpresa3.Visible = true;
            this.colIdEmpresa3.VisibleIndex = 0;
            // 
            // colIdSucursal3
            // 
            this.colIdSucursal3.FieldName = "IdSucursal";
            this.colIdSucursal3.Name = "colIdSucursal3";
            this.colIdSucursal3.Visible = true;
            this.colIdSucursal3.VisibleIndex = 1;
            // 
            // colIdBodega3
            // 
            this.colIdBodega3.FieldName = "IdBodega";
            this.colIdBodega3.Name = "colIdBodega3";
            this.colIdBodega3.Visible = true;
            this.colIdBodega3.VisibleIndex = 2;
            // 
            // colTipo2
            // 
            this.colTipo2.FieldName = "Tipo";
            this.colTipo2.Name = "colTipo2";
            this.colTipo2.Visible = true;
            this.colTipo2.VisibleIndex = 3;
            // 
            // colIdCobro2
            // 
            this.colIdCobro2.FieldName = "IdCobro";
            this.colIdCobro2.Name = "colIdCobro2";
            this.colIdCobro2.Visible = true;
            this.colIdCobro2.VisibleIndex = 4;
            // 
            // colIdNota2
            // 
            this.colIdNota2.FieldName = "IdNota";
            this.colIdNota2.Name = "colIdNota2";
            this.colIdNota2.Visible = true;
            this.colIdNota2.VisibleIndex = 5;
            // 
            // colCreDeb2
            // 
            this.colCreDeb2.FieldName = "CreDeb";
            this.colCreDeb2.Name = "colCreDeb2";
            this.colCreDeb2.Visible = true;
            this.colCreDeb2.VisibleIndex = 6;
            // 
            // colSerie12
            // 
            this.colSerie12.FieldName = "Serie1";
            this.colSerie12.Name = "colSerie12";
            this.colSerie12.Visible = true;
            this.colSerie12.VisibleIndex = 7;
            // 
            // colSerie22
            // 
            this.colSerie22.FieldName = "Serie2";
            this.colSerie22.Name = "colSerie22";
            this.colSerie22.Visible = true;
            this.colSerie22.VisibleIndex = 8;
            // 
            // colNumNota_Impresa2
            // 
            this.colNumNota_Impresa2.FieldName = "NumNota_Impresa";
            this.colNumNota_Impresa2.Name = "colNumNota_Impresa2";
            this.colNumNota_Impresa2.Visible = true;
            this.colNumNota_Impresa2.VisibleIndex = 9;
            // 
            // colIdCliente3
            // 
            this.colIdCliente3.FieldName = "IdCliente";
            this.colIdCliente3.Name = "colIdCliente3";
            this.colIdCliente3.Visible = true;
            this.colIdCliente3.VisibleIndex = 10;
            // 
            // colNomSucursal2
            // 
            this.colNomSucursal2.FieldName = "NomSucursal";
            this.colNomSucursal2.Name = "colNomSucursal2";
            this.colNomSucursal2.Visible = true;
            this.colNomSucursal2.VisibleIndex = 11;
            // 
            // colNom_Bodega2
            // 
            this.colNom_Bodega2.FieldName = "Nom_Bodega";
            this.colNom_Bodega2.Name = "colNom_Bodega2";
            this.colNom_Bodega2.Visible = true;
            this.colNom_Bodega2.VisibleIndex = 12;
            // 
            // colno_fecha2
            // 
            this.colno_fecha2.FieldName = "no_fecha";
            this.colno_fecha2.Name = "colno_fecha2";
            this.colno_fecha2.Visible = true;
            this.colno_fecha2.VisibleIndex = 13;
            // 
            // colno_fecha_venc2
            // 
            this.colno_fecha_venc2.FieldName = "no_fecha_venc";
            this.colno_fecha_venc2.Name = "colno_fecha_venc2";
            this.colno_fecha_venc2.Visible = true;
            this.colno_fecha_venc2.VisibleIndex = 14;
            // 
            // colsc_observacion2
            // 
            this.colsc_observacion2.FieldName = "sc_observacion";
            this.colsc_observacion2.Name = "colsc_observacion2";
            this.colsc_observacion2.Visible = true;
            this.colsc_observacion2.VisibleIndex = 15;
            // 
            // colNom_Cliente2
            // 
            this.colNom_Cliente2.FieldName = "Nom_Cliente";
            this.colNom_Cliente2.Name = "colNom_Cliente2";
            this.colNom_Cliente2.Visible = true;
            this.colNom_Cliente2.VisibleIndex = 16;
            // 
            // colMotivo_Nota2
            // 
            this.colMotivo_Nota2.FieldName = "Motivo_Nota";
            this.colMotivo_Nota2.Name = "colMotivo_Nota2";
            this.colMotivo_Nota2.Visible = true;
            this.colMotivo_Nota2.VisibleIndex = 17;
            // 
            // colReferencia3
            // 
            this.colReferencia3.FieldName = "Referencia";
            this.colReferencia3.Name = "colReferencia3";
            this.colReferencia3.Visible = true;
            this.colReferencia3.VisibleIndex = 18;
            // 
            // colsc_total2
            // 
            this.colsc_total2.FieldName = "sc_total";
            this.colsc_total2.Name = "colsc_total2";
            this.colsc_total2.Visible = true;
            this.colsc_total2.VisibleIndex = 19;
            // 
            // colSaldo3
            // 
            this.colSaldo3.FieldName = "Saldo";
            this.colSaldo3.Name = "colSaldo3";
            this.colSaldo3.Visible = true;
            this.colSaldo3.VisibleIndex = 20;
            // 
            // colcheck_cds2
            // 
            this.colcheck_cds2.FieldName = "check_cds";
            this.colcheck_cds2.Name = "colcheck_cds2";
            this.colcheck_cds2.Visible = true;
            this.colcheck_cds2.VisibleIndex = 21;
            // 
            // colsaldoAUX_CreDeb2
            // 
            this.colsaldoAUX_CreDeb2.FieldName = "saldoAUX_CreDeb";
            this.colsaldoAUX_CreDeb2.Name = "colsaldoAUX_CreDeb2";
            this.colsaldoAUX_CreDeb2.Visible = true;
            this.colsaldoAUX_CreDeb2.VisibleIndex = 22;
            // 
            // colIdTipoConciliacion2
            // 
            this.colIdTipoConciliacion2.FieldName = "IdTipoConciliacion";
            this.colIdTipoConciliacion2.Name = "colIdTipoConciliacion2";
            this.colIdTipoConciliacion2.Visible = true;
            this.colIdTipoConciliacion2.VisibleIndex = 23;
            // 
            // colIdCobro_Tipo2
            // 
            this.colIdCobro_Tipo2.FieldName = "IdCobro_Tipo";
            this.colIdCobro_Tipo2.Name = "colIdCobro_Tipo2";
            this.colIdCobro_Tipo2.Visible = true;
            this.colIdCobro_Tipo2.VisibleIndex = 24;
            // 
            // colIdTipoNota2
            // 
            this.colIdTipoNota2.FieldName = "IdTipoNota";
            this.colIdTipoNota2.Name = "colIdTipoNota2";
            this.colIdTipoNota2.Visible = true;
            this.colIdTipoNota2.VisibleIndex = 25;
            // 
            // colIdCaja1
            // 
            this.colIdCaja1.FieldName = "IdCaja";
            this.colIdCaja1.Name = "colIdCaja1";
            this.colIdCaja1.Visible = true;
            this.colIdCaja1.VisibleIndex = 26;
            // 
            // colNombreCompleto2
            // 
            this.colNombreCompleto2.FieldName = "NombreCompleto";
            this.colNombreCompleto2.Name = "colNombreCompleto2";
            this.colNombreCompleto2.Visible = true;
            this.colNombreCompleto2.VisibleIndex = 27;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa1,
            this.colIdSucursal1,
            this.colIdBodega1,
            this.colTipo,
            this.colIdCobro,
            this.colIdNota,
            this.colCreDeb,
            this.colSerie1,
            this.colSerie2,
            this.colNumNota_Impresa,
            this.colIdCliente1,
            this.colNomSucursal,
            this.colNom_Bodega,
            this.colno_fecha,
            this.colno_fecha_venc,
            this.colsc_observacion,
            this.colNom_Cliente,
            this.colMotivo_Nota,
            this.colReferencia1,
            this.colsc_total,
            this.colSaldo1,
            this.colcheck_cds,
            this.colsaldoAUX_CreDeb,
            this.colIdTipoConciliacion,
            this.colIdCobro_Tipo,
            this.colIdTipoNota,
            this.colNombreCompleto,
            this.ColIdCtaCble_cxc,
            this.ColIdCtaCble_Anti});
            this.gridView3.Name = "gridView3";
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa4,
            this.colIdSucursal4,
            this.colIdBodega4,
            this.colTipo3,
            this.colIdCobro3,
            this.colIdNota3,
            this.colCreDeb3,
            this.colSerie13,
            this.colSerie23,
            this.colNumNota_Impresa3,
            this.colIdCliente4,
            this.colNomSucursal3,
            this.colNom_Bodega3,
            this.colno_fecha3,
            this.colno_fecha_venc3,
            this.colsc_observacion3,
            this.colNom_Cliente3,
            this.colMotivo_Nota3,
            this.colReferencia4,
            this.colsc_total3,
            this.colSaldo4,
            this.colcheck_cds3,
            this.colsaldoAUX_CreDeb3,
            this.colIdTipoConciliacion3,
            this.colIdCobro_Tipo3,
            this.colIdTipoNota3,
            this.colIdCaja2,
            this.colNombreCompleto3,
            this.colIdCtaCble_cxc1,
            this.colIdCtaCble_Anti1});
            this.gridView4.GridControl = this.gridControlCreDebSaldo;
            this.gridView4.Name = "gridView4";
            // 
            // colIdEmpresa4
            // 
            this.colIdEmpresa4.FieldName = "IdEmpresa";
            this.colIdEmpresa4.Name = "colIdEmpresa4";
            this.colIdEmpresa4.Visible = true;
            this.colIdEmpresa4.VisibleIndex = 0;
            // 
            // colIdSucursal4
            // 
            this.colIdSucursal4.FieldName = "IdSucursal";
            this.colIdSucursal4.Name = "colIdSucursal4";
            this.colIdSucursal4.Visible = true;
            this.colIdSucursal4.VisibleIndex = 1;
            // 
            // colIdBodega4
            // 
            this.colIdBodega4.FieldName = "IdBodega";
            this.colIdBodega4.Name = "colIdBodega4";
            this.colIdBodega4.Visible = true;
            this.colIdBodega4.VisibleIndex = 2;
            // 
            // colTipo3
            // 
            this.colTipo3.FieldName = "Tipo";
            this.colTipo3.Name = "colTipo3";
            this.colTipo3.Visible = true;
            this.colTipo3.VisibleIndex = 3;
            // 
            // colIdCobro3
            // 
            this.colIdCobro3.FieldName = "IdCobro";
            this.colIdCobro3.Name = "colIdCobro3";
            this.colIdCobro3.Visible = true;
            this.colIdCobro3.VisibleIndex = 4;
            // 
            // colIdNota3
            // 
            this.colIdNota3.FieldName = "IdNota";
            this.colIdNota3.Name = "colIdNota3";
            this.colIdNota3.Visible = true;
            this.colIdNota3.VisibleIndex = 5;
            // 
            // colCreDeb3
            // 
            this.colCreDeb3.FieldName = "CreDeb";
            this.colCreDeb3.Name = "colCreDeb3";
            this.colCreDeb3.Visible = true;
            this.colCreDeb3.VisibleIndex = 6;
            // 
            // colSerie13
            // 
            this.colSerie13.FieldName = "Serie1";
            this.colSerie13.Name = "colSerie13";
            this.colSerie13.Visible = true;
            this.colSerie13.VisibleIndex = 7;
            // 
            // colSerie23
            // 
            this.colSerie23.FieldName = "Serie2";
            this.colSerie23.Name = "colSerie23";
            this.colSerie23.Visible = true;
            this.colSerie23.VisibleIndex = 8;
            // 
            // colNumNota_Impresa3
            // 
            this.colNumNota_Impresa3.FieldName = "NumNota_Impresa";
            this.colNumNota_Impresa3.Name = "colNumNota_Impresa3";
            this.colNumNota_Impresa3.Visible = true;
            this.colNumNota_Impresa3.VisibleIndex = 9;
            // 
            // colIdCliente4
            // 
            this.colIdCliente4.FieldName = "IdCliente";
            this.colIdCliente4.Name = "colIdCliente4";
            this.colIdCliente4.Visible = true;
            this.colIdCliente4.VisibleIndex = 10;
            // 
            // colNomSucursal3
            // 
            this.colNomSucursal3.FieldName = "NomSucursal";
            this.colNomSucursal3.Name = "colNomSucursal3";
            this.colNomSucursal3.Visible = true;
            this.colNomSucursal3.VisibleIndex = 11;
            // 
            // colNom_Bodega3
            // 
            this.colNom_Bodega3.FieldName = "Nom_Bodega";
            this.colNom_Bodega3.Name = "colNom_Bodega3";
            this.colNom_Bodega3.Visible = true;
            this.colNom_Bodega3.VisibleIndex = 12;
            // 
            // colno_fecha3
            // 
            this.colno_fecha3.FieldName = "no_fecha";
            this.colno_fecha3.Name = "colno_fecha3";
            this.colno_fecha3.Visible = true;
            this.colno_fecha3.VisibleIndex = 13;
            // 
            // colno_fecha_venc3
            // 
            this.colno_fecha_venc3.FieldName = "no_fecha_venc";
            this.colno_fecha_venc3.Name = "colno_fecha_venc3";
            this.colno_fecha_venc3.Visible = true;
            this.colno_fecha_venc3.VisibleIndex = 14;
            // 
            // colsc_observacion3
            // 
            this.colsc_observacion3.FieldName = "sc_observacion";
            this.colsc_observacion3.Name = "colsc_observacion3";
            this.colsc_observacion3.Visible = true;
            this.colsc_observacion3.VisibleIndex = 15;
            // 
            // colNom_Cliente3
            // 
            this.colNom_Cliente3.FieldName = "Nom_Cliente";
            this.colNom_Cliente3.Name = "colNom_Cliente3";
            this.colNom_Cliente3.Visible = true;
            this.colNom_Cliente3.VisibleIndex = 16;
            // 
            // colMotivo_Nota3
            // 
            this.colMotivo_Nota3.FieldName = "Motivo_Nota";
            this.colMotivo_Nota3.Name = "colMotivo_Nota3";
            this.colMotivo_Nota3.Visible = true;
            this.colMotivo_Nota3.VisibleIndex = 17;
            // 
            // colReferencia4
            // 
            this.colReferencia4.FieldName = "Referencia";
            this.colReferencia4.Name = "colReferencia4";
            this.colReferencia4.Visible = true;
            this.colReferencia4.VisibleIndex = 18;
            // 
            // colsc_total3
            // 
            this.colsc_total3.FieldName = "sc_total";
            this.colsc_total3.Name = "colsc_total3";
            this.colsc_total3.Visible = true;
            this.colsc_total3.VisibleIndex = 19;
            // 
            // colSaldo4
            // 
            this.colSaldo4.FieldName = "Saldo";
            this.colSaldo4.Name = "colSaldo4";
            this.colSaldo4.Visible = true;
            this.colSaldo4.VisibleIndex = 20;
            // 
            // colcheck_cds3
            // 
            this.colcheck_cds3.FieldName = "check_cds";
            this.colcheck_cds3.Name = "colcheck_cds3";
            this.colcheck_cds3.Visible = true;
            this.colcheck_cds3.VisibleIndex = 21;
            // 
            // colsaldoAUX_CreDeb3
            // 
            this.colsaldoAUX_CreDeb3.FieldName = "saldoAUX_CreDeb";
            this.colsaldoAUX_CreDeb3.Name = "colsaldoAUX_CreDeb3";
            this.colsaldoAUX_CreDeb3.Visible = true;
            this.colsaldoAUX_CreDeb3.VisibleIndex = 22;
            // 
            // colIdTipoConciliacion3
            // 
            this.colIdTipoConciliacion3.FieldName = "IdTipoConciliacion";
            this.colIdTipoConciliacion3.Name = "colIdTipoConciliacion3";
            this.colIdTipoConciliacion3.Visible = true;
            this.colIdTipoConciliacion3.VisibleIndex = 23;
            // 
            // colIdCobro_Tipo3
            // 
            this.colIdCobro_Tipo3.FieldName = "IdCobro_Tipo";
            this.colIdCobro_Tipo3.Name = "colIdCobro_Tipo3";
            this.colIdCobro_Tipo3.Visible = true;
            this.colIdCobro_Tipo3.VisibleIndex = 24;
            // 
            // colIdTipoNota3
            // 
            this.colIdTipoNota3.FieldName = "IdTipoNota";
            this.colIdTipoNota3.Name = "colIdTipoNota3";
            this.colIdTipoNota3.Visible = true;
            this.colIdTipoNota3.VisibleIndex = 25;
            // 
            // colIdCaja2
            // 
            this.colIdCaja2.FieldName = "IdCaja";
            this.colIdCaja2.Name = "colIdCaja2";
            this.colIdCaja2.Visible = true;
            this.colIdCaja2.VisibleIndex = 26;
            // 
            // colNombreCompleto3
            // 
            this.colNombreCompleto3.FieldName = "NombreCompleto";
            this.colNombreCompleto3.Name = "colNombreCompleto3";
            this.colNombreCompleto3.Visible = true;
            this.colNombreCompleto3.VisibleIndex = 27;
            // 
            // colIdCtaCble_cxc1
            // 
            this.colIdCtaCble_cxc1.FieldName = "IdCtaCble_cxc";
            this.colIdCtaCble_cxc1.Name = "colIdCtaCble_cxc1";
            this.colIdCtaCble_cxc1.Visible = true;
            this.colIdCtaCble_cxc1.VisibleIndex = 28;
            // 
            // colIdCtaCble_Anti1
            // 
            this.colIdCtaCble_Anti1.FieldName = "IdCtaCble_Anti";
            this.colIdCtaCble_Anti1.Name = "colIdCtaCble_Anti1";
            this.colIdCtaCble_Anti1.Visible = true;
            this.colIdCtaCble_Anti1.VisibleIndex = 29;
            // 
            // frmCxc_Conciliacion_cxc
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 649);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "frmCxc_Conciliacion_cxc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conciliación de Cuentas por Cobrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmcxc_Conciliacion_cxc_FormClosing);
            this.Load += new System.EventHandler(this.frmcxc_Conciliacion_cxc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumConcilia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcxccobrosPendientesxconciliarInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcxccarteraxcobrarInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwfacreditosdebitosconsaldoInfoBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControlGeneral.ResumeLayout(false);
            this.tabDocConcilia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.TabDebCre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCreDebSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCreDebSaldo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFacturas)).EndInit();
            this.tabDiarioContable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDiarioCble)).EndInit();
            this.pnlDiarioCble.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Controles.UCIn_Sucursal_Bodega ucIn_Sucursal_Bodega1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.DateEdit dteFecha;
        private Controles.UCFa_Cliente_Facturacion ucfA_Cliente_Facturacion1;
        private DevExpress.XtraEditors.TextEdit txtNumConcilia;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.BindingSource vwcxccarteraxcobrarInfoBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource vwfacreditosdebitosconsaldoInfoBindingSource;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.BindingSource vwcxccobrosPendientesxconciliarInfoBindingSource;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.TabControl tabControlGeneral;
        private System.Windows.Forms.TabPage tabDocConcilia;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSaldo;
        private DevExpress.XtraGrid.GridControl gridControlFacturas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFacturas;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colvt_tipoDoc;
        private DevExpress.XtraGrid.Columns.GridColumn colvt_NunDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colIdComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colCodComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colvt_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colvt_total;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalxCobrado;
        private DevExpress.XtraGrid.Columns.GridColumn colBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colvt_Subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colvt_iva;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_nombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck_cartera;
        private DevExpress.XtraGrid.Columns.GridColumn colvt_fech_venc;
        private DevExpress.XtraGrid.Columns.GridColumn colplazo;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_aplicar;
        private DevExpress.XtraGrid.Columns.GridColumn colNomCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoAUX;
        private System.Windows.Forms.TabPage tabDiarioContable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega3;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNota2;
        private DevExpress.XtraGrid.Columns.GridColumn colCreDeb2;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie12;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie22;
        private DevExpress.XtraGrid.Columns.GridColumn colNumNota_Impresa2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente3;
        private DevExpress.XtraGrid.Columns.GridColumn colNomSucursal2;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_Bodega2;
        private DevExpress.XtraGrid.Columns.GridColumn colno_fecha2;
        private DevExpress.XtraGrid.Columns.GridColumn colno_fecha_venc2;
        private DevExpress.XtraGrid.Columns.GridColumn colsc_observacion2;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_Cliente2;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivo_Nota2;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia3;
        private DevExpress.XtraGrid.Columns.GridColumn colsc_total2;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo3;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck_cds2;
        private DevExpress.XtraGrid.Columns.GridColumn colsaldoAUX_CreDeb2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoConciliacion2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_Tipo2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoNota2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCaja1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompleto2;
        private DevExpress.XtraEditors.PanelControl pnlDiarioCble;
        private Controles.UCCon_GridDiarioContable ucCon_GridDiario;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabDebCre;
        private DevExpress.XtraGrid.GridControl gridControlCreDebSaldo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCreDebSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega1;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNota;
        private DevExpress.XtraGrid.Columns.GridColumn colCreDeb;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie1;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie2;
        private DevExpress.XtraGrid.Columns.GridColumn colNumNota_Impresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente1;
        private DevExpress.XtraGrid.Columns.GridColumn colNomSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn colno_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colno_fecha_venc;
        private DevExpress.XtraGrid.Columns.GridColumn colsc_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivo_Nota;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia1;
        private DevExpress.XtraGrid.Columns.GridColumn colsc_total;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo1;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck_cds;
        private DevExpress.XtraGrid.Columns.GridColumn colsaldoAUX_CreDeb;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoConciliacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoNota;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdCtaCble_cxc;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdCtaCble_Anti;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega4;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNota3;
        private DevExpress.XtraGrid.Columns.GridColumn colCreDeb3;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie13;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie23;
        private DevExpress.XtraGrid.Columns.GridColumn colNumNota_Impresa3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente4;
        private DevExpress.XtraGrid.Columns.GridColumn colNomSucursal3;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_Bodega3;
        private DevExpress.XtraGrid.Columns.GridColumn colno_fecha3;
        private DevExpress.XtraGrid.Columns.GridColumn colno_fecha_venc3;
        private DevExpress.XtraGrid.Columns.GridColumn colsc_observacion3;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_Cliente3;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivo_Nota3;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia4;
        private DevExpress.XtraGrid.Columns.GridColumn colsc_total3;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo4;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck_cds3;
        private DevExpress.XtraGrid.Columns.GridColumn colsaldoAUX_CreDeb3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoConciliacion3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_Tipo3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoNota3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCaja2;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompleto3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_cxc1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Anti1;
    }
}