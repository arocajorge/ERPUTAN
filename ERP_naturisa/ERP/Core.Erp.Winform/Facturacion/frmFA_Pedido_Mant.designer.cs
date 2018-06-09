namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Pedido_Mant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFa_Pedido_Mant));
            this.gbxCabecera = new System.Windows.Forms.GroupBox();
            this.UC_Sucursal_Bodega = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDatos = new System.Windows.Forms.TabPage();
            this.txtPorDist = new System.Windows.Forms.TextBox();
            this.txtValForPag = new System.Windows.Forms.TextBox();
            this.cmbTerminoPago = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDias_Vct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_Cuotas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlFormaPag = new DevExpress.XtraGrid.GridControl();
            this.gridViewFormaPag = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbteVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDias_Plazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPor_Distribucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_vct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UC_Cliente = new Core.Erp.Winform.Controles.UCFa_Cliente_Facturacion();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEstadoProduccion = new System.Windows.Forms.ComboBox();
            this.facatalogoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.cbxEntrega = new System.Windows.Forms.CheckBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_observacion = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOtro2 = new DevExpress.XtraEditors.TextEdit();
            this.txtOtro1 = new DevExpress.XtraEditors.TextEdit();
            this.txtInteres = new DevExpress.XtraEditors.TextEdit();
            this.txtTransporte = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmb_estado_aprobacion = new System.Windows.Forms.ComboBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cupo_maximo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabOrdDespacho = new System.Windows.Forms.TabPage();
            this.gridControlOrdDesXpedi = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrddesXPedi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdOrdenDespacho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_detallexItems = new DevExpress.XtraGrid.Columns.GridColumn();
            this.producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtFechaVenc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_plazo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txt_pedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDetalleProducto = new System.Windows.Forms.GroupBox();
            this.UCFAModuloFacturacion = new Core.Erp.Winform.Controles.UCFa_GridFactura();
            this.gbxTotales = new System.Windows.Forms.GroupBox();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtSubTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtIva = new DevExpress.XtraEditors.TextEdit();
            this.txtBase12 = new DevExpress.XtraEditors.TextEdit();
            this.txt_Base0 = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btn_grabar = new System.Windows.Forms.ToolStripButton();
            this.btn_guardarSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BtnAnular = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.gbxCabecera.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTerminoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFormaPag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFormaPag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facatalogoInfoBindingSource)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtro2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtro1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransporte.Properties)).BeginInit();
            this.tabOrdDespacho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdDesXpedi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrddesXPedi)).BeginInit();
            this.gbxDetalleProducto.SuspendLayout();
            this.gbxTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBase12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Base0.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCabecera
            // 
            this.gbxCabecera.Controls.Add(this.UC_Sucursal_Bodega);
            this.gbxCabecera.Controls.Add(this.gbxDatos);
            this.gbxCabecera.Controls.Add(this.dtFechaVenc);
            this.gbxCabecera.Controls.Add(this.label8);
            this.gbxCabecera.Controls.Add(this.txt_plazo);
            this.gbxCabecera.Controls.Add(this.label6);
            this.gbxCabecera.Controls.Add(this.label18);
            this.gbxCabecera.Controls.Add(this.txtCodigo);
            this.gbxCabecera.Controls.Add(this.label7);
            this.gbxCabecera.Controls.Add(this.dtFecha);
            this.gbxCabecera.Controls.Add(this.txt_pedido);
            this.gbxCabecera.Controls.Add(this.label1);
            this.gbxCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxCabecera.Location = new System.Drawing.Point(0, 25);
            this.gbxCabecera.Name = "gbxCabecera";
            this.gbxCabecera.Size = new System.Drawing.Size(966, 362);
            this.gbxCabecera.TabIndex = 1;
            this.gbxCabecera.TabStop = false;
            this.gbxCabecera.Text = "Datos Principales de Pedidos";
            // 
            // UC_Sucursal_Bodega
            // 
            this.UC_Sucursal_Bodega.BackColor = System.Drawing.SystemColors.Control;
            this.UC_Sucursal_Bodega.Location = new System.Drawing.Point(188, 14);
            this.UC_Sucursal_Bodega.Name = "UC_Sucursal_Bodega";
            this.UC_Sucursal_Bodega.Size = new System.Drawing.Size(554, 51);
            this.UC_Sucursal_Bodega.TabIndex = 2;
            this.UC_Sucursal_Bodega.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.tabControl1);
            this.gbxDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxDatos.Location = new System.Drawing.Point(3, 84);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(960, 275);
            this.gbxDatos.TabIndex = 6;
            this.gbxDatos.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDatos);
            this.tabControl1.Controls.Add(this.tabOrdDespacho);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 256);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDatos
            // 
            this.tabDatos.Controls.Add(this.txtPorDist);
            this.tabDatos.Controls.Add(this.txtValForPag);
            this.tabDatos.Controls.Add(this.cmbTerminoPago);
            this.tabDatos.Controls.Add(this.labelControl2);
            this.tabDatos.Controls.Add(this.gridControlFormaPag);
            this.tabDatos.Controls.Add(this.UC_Cliente);
            this.tabDatos.Controls.Add(this.label9);
            this.tabDatos.Controls.Add(this.cmbEstadoProduccion);
            this.tabDatos.Controls.Add(this.cbxEntrega);
            this.tabDatos.Controls.Add(this.tabControl2);
            this.tabDatos.Controls.Add(this.cmb_estado_aprobacion);
            this.tabDatos.Controls.Add(this.lbl_Estado);
            this.tabDatos.Controls.Add(this.label10);
            this.tabDatos.Controls.Add(this.txt_cupo_maximo);
            this.tabDatos.Controls.Add(this.label12);
            this.tabDatos.Location = new System.Drawing.Point(4, 22);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatos.Size = new System.Drawing.Size(946, 230);
            this.tabDatos.TabIndex = 0;
            this.tabDatos.Text = "Datos";
            this.tabDatos.UseVisualStyleBackColor = true;
            // 
            // txtPorDist
            // 
            this.txtPorDist.Location = new System.Drawing.Point(865, 110);
            this.txtPorDist.Name = "txtPorDist";
            this.txtPorDist.Size = new System.Drawing.Size(136, 20);
            this.txtPorDist.TabIndex = 6;
            this.txtPorDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValForPag
            // 
            this.txtValForPag.Location = new System.Drawing.Point(1007, 110);
            this.txtValForPag.Name = "txtValForPag";
            this.txtValForPag.Size = new System.Drawing.Size(124, 20);
            this.txtValForPag.TabIndex = 7;
            this.txtValForPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbTerminoPago
            // 
            this.cmbTerminoPago.Location = new System.Drawing.Point(738, 7);
            this.cmbTerminoPago.Name = "cmbTerminoPago";
            this.cmbTerminoPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTerminoPago.Properties.DisplayMember = "Descripcion";
            this.cmbTerminoPago.Properties.NullText = "";
            this.cmbTerminoPago.Properties.ValueMember = "IdTipoFormaPago";
            this.cmbTerminoPago.Properties.View = this.gridView2;
            this.cmbTerminoPago.Size = new System.Drawing.Size(157, 20);
            this.cmbTerminoPago.TabIndex = 4;
            this.cmbTerminoPago.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.cmbTerminoPago_Closed);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion1,
            this.colDias_Vct,
            this.colIdTipoFormaPago,
            this.colNum_Cuotas});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.Caption = "Descripción";
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 0;
            // 
            // colDias_Vct
            // 
            this.colDias_Vct.FieldName = "Dias_Vct";
            this.colDias_Vct.Name = "colDias_Vct";
            // 
            // colIdTipoFormaPago
            // 
            this.colIdTipoFormaPago.FieldName = "IdTipoFormaPago";
            this.colIdTipoFormaPago.Name = "colIdTipoFormaPago";
            // 
            // colNum_Cuotas
            // 
            this.colNum_Cuotas.FieldName = "Num_Cuotas";
            this.colNum_Cuotas.Name = "colNum_Cuotas";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(648, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 13);
            this.labelControl2.TabIndex = 120;
            this.labelControl2.Text = "Término de pago:";
            // 
            // gridControlFormaPag
            // 
            this.gridControlFormaPag.Location = new System.Drawing.Point(649, 33);
            this.gridControlFormaPag.MainView = this.gridViewFormaPag;
            this.gridControlFormaPag.Name = "gridControlFormaPag";
            this.gridControlFormaPag.Size = new System.Drawing.Size(483, 71);
            this.gridControlFormaPag.TabIndex = 5;
            this.gridControlFormaPag.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFormaPag});
            // 
            // gridViewFormaPag
            // 
            this.gridViewFormaPag.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa2,
            this.colIdSucursal2,
            this.colIdBodega1,
            this.colIdCbteVta,
            this.colSecuencia1,
            this.colFecha,
            this.colDias_Plazo,
            this.colPor_Distribucion,
            this.colValor1,
            this.colFecha_vct});
            this.gridViewFormaPag.GridControl = this.gridControlFormaPag;
            this.gridViewFormaPag.Name = "gridViewFormaPag";
            this.gridViewFormaPag.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpresa2
            // 
            this.colIdEmpresa2.FieldName = "IdEmpresa";
            this.colIdEmpresa2.Name = "colIdEmpresa2";
            // 
            // colIdSucursal2
            // 
            this.colIdSucursal2.FieldName = "IdSucursal";
            this.colIdSucursal2.Name = "colIdSucursal2";
            // 
            // colIdBodega1
            // 
            this.colIdBodega1.FieldName = "IdBodega";
            this.colIdBodega1.Name = "colIdBodega1";
            // 
            // colIdCbteVta
            // 
            this.colIdCbteVta.FieldName = "IdCbteVta";
            this.colIdCbteVta.Name = "colIdCbteVta";
            // 
            // colSecuencia1
            // 
            this.colSecuencia1.Caption = "Secuencia";
            this.colSecuencia1.FieldName = "Secuencia";
            this.colSecuencia1.Name = "colSecuencia1";
            this.colSecuencia1.Visible = true;
            this.colSecuencia1.VisibleIndex = 0;
            this.colSecuencia1.Width = 209;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            // 
            // colDias_Plazo
            // 
            this.colDias_Plazo.FieldName = "Dias_Plazo";
            this.colDias_Plazo.Name = "colDias_Plazo";
            // 
            // colPor_Distribucion
            // 
            this.colPor_Distribucion.Caption = "% Distribución";
            this.colPor_Distribucion.FieldName = "Por_Distribucion";
            this.colPor_Distribucion.Name = "colPor_Distribucion";
            this.colPor_Distribucion.Visible = true;
            this.colPor_Distribucion.VisibleIndex = 2;
            this.colPor_Distribucion.Width = 406;
            // 
            // colValor1
            // 
            this.colValor1.Caption = "Valor";
            this.colValor1.FieldName = "Valor";
            this.colValor1.Name = "colValor1";
            this.colValor1.Visible = true;
            this.colValor1.VisibleIndex = 3;
            this.colValor1.Width = 326;
            // 
            // colFecha_vct
            // 
            this.colFecha_vct.Caption = "Fecha Vcto.";
            this.colFecha_vct.FieldName = "Fecha_vct";
            this.colFecha_vct.Name = "colFecha_vct";
            this.colFecha_vct.Visible = true;
            this.colFecha_vct.VisibleIndex = 1;
            this.colFecha_vct.Width = 233;
            // 
            // UC_Cliente
            // 
            this.UC_Cliente.Location = new System.Drawing.Point(0, 10);
            this.UC_Cliente.Name = "UC_Cliente";
            this.UC_Cliente.Size = new System.Drawing.Size(331, 57);
            this.UC_Cliente.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Estado Produccion";
            // 
            // cmbEstadoProduccion
            // 
            this.cmbEstadoProduccion.DataSource = this.facatalogoInfoBindingSource;
            this.cmbEstadoProduccion.DisplayMember = "Nombre";
            this.cmbEstadoProduccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoProduccion.FormattingEnabled = true;
            this.cmbEstadoProduccion.Location = new System.Drawing.Point(511, 39);
            this.cmbEstadoProduccion.Name = "cmbEstadoProduccion";
            this.cmbEstadoProduccion.Size = new System.Drawing.Size(117, 21);
            this.cmbEstadoProduccion.TabIndex = 2;
            this.cmbEstadoProduccion.ValueMember = "IdCatalogo";
            // 
            // facatalogoInfoBindingSource
            // 
            this.facatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Facturacion.fa_catalogo_Info);
            // 
            // cbxEntrega
            // 
            this.cbxEntrega.AutoSize = true;
            this.cbxEntrega.Location = new System.Drawing.Point(162, 73);
            this.cbxEntrega.Name = "cbxEntrega";
            this.cbxEntrega.Size = new System.Drawing.Size(92, 17);
            this.cbxEntrega.TabIndex = 55;
            this.cbxEntrega.Text = "EntregaTalme";
            this.cbxEntrega.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl2.Location = new System.Drawing.Point(3, 136);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(940, 91);
            this.tabControl2.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_observacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(932, 65);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Observacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_observacion
            // 
            this.txt_observacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_observacion.Location = new System.Drawing.Point(3, 3);
            this.txt_observacion.MaxLength = 1000;
            this.txt_observacion.Multiline = true;
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_observacion.Size = new System.Drawing.Size(926, 59);
            this.txt_observacion.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1128, 65);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Otros Valores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOtro2);
            this.groupBox1.Controls.Add(this.txtOtro1);
            this.groupBox1.Controls.Add(this.txtInteres);
            this.groupBox1.Controls.Add(this.txtTransporte);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1122, 59);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // txtOtro2
            // 
            this.txtOtro2.Location = new System.Drawing.Point(771, 13);
            this.txtOtro2.Name = "txtOtro2";
            this.txtOtro2.Properties.Mask.EditMask = "n";
            this.txtOtro2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtOtro2.Size = new System.Drawing.Size(100, 20);
            this.txtOtro2.TabIndex = 121;
            this.txtOtro2.EditValueChanged += new System.EventHandler(this.txtOtro2_EditValueChanged);
            // 
            // txtOtro1
            // 
            this.txtOtro1.Location = new System.Drawing.Point(556, 13);
            this.txtOtro1.Name = "txtOtro1";
            this.txtOtro1.Properties.Mask.EditMask = "n";
            this.txtOtro1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtOtro1.Size = new System.Drawing.Size(100, 20);
            this.txtOtro1.TabIndex = 120;
            this.txtOtro1.EditValueChanged += new System.EventHandler(this.txtOtro1_EditValueChanged);
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(335, 13);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Properties.Mask.EditMask = "n";
            this.txtInteres.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtInteres.Size = new System.Drawing.Size(100, 20);
            this.txtInteres.TabIndex = 119;
            this.txtInteres.EditValueChanged += new System.EventHandler(this.txtInteres_EditValueChanged);
            // 
            // txtTransporte
            // 
            this.txtTransporte.Location = new System.Drawing.Point(134, 13);
            this.txtTransporte.Name = "txtTransporte";
            this.txtTransporte.Properties.Mask.EditMask = "n";
            this.txtTransporte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTransporte.Size = new System.Drawing.Size(100, 20);
            this.txtTransporte.TabIndex = 118;
            this.txtTransporte.EditValueChanged += new System.EventHandler(this.txtTransporte_EditValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 63;
            this.label14.Text = "(+) Transporte";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(479, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 63;
            this.label16.Text = "(+) Otro1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(264, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "(+) Interes";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(697, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 63;
            this.label17.Text = "(+) Otro2";
            // 
            // cmb_estado_aprobacion
            // 
            this.cmb_estado_aprobacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado_aprobacion.FormattingEnabled = true;
            this.cmb_estado_aprobacion.Location = new System.Drawing.Point(511, 8);
            this.cmb_estado_aprobacion.Name = "cmb_estado_aprobacion";
            this.cmb_estado_aprobacion.Size = new System.Drawing.Size(117, 21);
            this.cmb_estado_aprobacion.TabIndex = 1;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Estado.Location = new System.Drawing.Point(446, 107);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(132, 23);
            this.lbl_Estado.TabIndex = 55;
            this.lbl_Estado.Text = "**ANULADO**";
            this.lbl_Estado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Estado.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Estado de Aprobación:";
            // 
            // txt_cupo_maximo
            // 
            this.txt_cupo_maximo.Location = new System.Drawing.Point(511, 67);
            this.txt_cupo_maximo.Name = "txt_cupo_maximo";
            this.txt_cupo_maximo.Size = new System.Drawing.Size(87, 20);
            this.txt_cupo_maximo.TabIndex = 3;
            this.txt_cupo_maximo.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(412, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 63;
            this.label12.Text = "Cupo Max.:";
            // 
            // tabOrdDespacho
            // 
            this.tabOrdDespacho.Controls.Add(this.gridControlOrdDesXpedi);
            this.tabOrdDespacho.Location = new System.Drawing.Point(4, 22);
            this.tabOrdDespacho.Name = "tabOrdDespacho";
            this.tabOrdDespacho.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrdDespacho.Size = new System.Drawing.Size(1142, 230);
            this.tabOrdDespacho.TabIndex = 1;
            this.tabOrdDespacho.Text = "Ordenes de Despacho asociadas";
            this.tabOrdDespacho.UseVisualStyleBackColor = true;
            // 
            // gridControlOrdDesXpedi
            // 
            this.gridControlOrdDesXpedi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrdDesXpedi.Location = new System.Drawing.Point(3, 3);
            this.gridControlOrdDesXpedi.MainView = this.gridViewOrddesXPedi;
            this.gridControlOrdDesXpedi.Name = "gridControlOrdDesXpedi";
            this.gridControlOrdDesXpedi.Size = new System.Drawing.Size(1136, 224);
            this.gridControlOrdDesXpedi.TabIndex = 0;
            this.gridControlOrdDesXpedi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrddesXPedi});
            // 
            // gridViewOrddesXPedi
            // 
            this.gridViewOrddesXPedi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdOrdenDespacho,
            this.od_cantidad,
            this.od_detallexItems,
            this.producto});
            this.gridViewOrddesXPedi.GridControl = this.gridControlOrdDesXpedi;
            this.gridViewOrddesXPedi.GroupCount = 1;
            this.gridViewOrddesXPedi.Name = "gridViewOrddesXPedi";
            this.gridViewOrddesXPedi.OptionsView.ShowGroupPanel = false;
            this.gridViewOrddesXPedi.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.IdOrdenDespacho, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // IdOrdenDespacho
            // 
            this.IdOrdenDespacho.Caption = "IdOrdenDespacho";
            this.IdOrdenDespacho.FieldName = "IdOrdenDespacho";
            this.IdOrdenDespacho.Name = "IdOrdenDespacho";
            this.IdOrdenDespacho.Visible = true;
            this.IdOrdenDespacho.VisibleIndex = 0;
            // 
            // od_cantidad
            // 
            this.od_cantidad.Caption = "od_cantidad";
            this.od_cantidad.FieldName = "od_cantidad";
            this.od_cantidad.Name = "od_cantidad";
            this.od_cantidad.Visible = true;
            this.od_cantidad.VisibleIndex = 1;
            // 
            // od_detallexItems
            // 
            this.od_detallexItems.Caption = "od_detallexItems";
            this.od_detallexItems.FieldName = "od_detallexItems";
            this.od_detallexItems.Name = "od_detallexItems";
            this.od_detallexItems.Visible = true;
            this.od_detallexItems.VisibleIndex = 2;
            // 
            // producto
            // 
            this.producto.Caption = "producto";
            this.producto.FieldName = "producto";
            this.producto.Name = "producto";
            this.producto.Visible = true;
            this.producto.VisibleIndex = 0;
            // 
            // dtFechaVenc
            // 
            this.dtFechaVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaVenc.Location = new System.Drawing.Point(848, 62);
            this.dtFechaVenc.Name = "dtFechaVenc";
            this.dtFechaVenc.Size = new System.Drawing.Size(83, 20);
            this.dtFechaVenc.TabIndex = 5;
            this.dtFechaVenc.ValueChanged += new System.EventHandler(this.dtFechaVenc_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(748, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Fecha de entrega:";
            // 
            // txt_plazo
            // 
            this.txt_plazo.Location = new System.Drawing.Point(892, 40);
            this.txt_plazo.MaxLength = 4;
            this.txt_plazo.Name = "txt_plazo";
            this.txt_plazo.Size = new System.Drawing.Size(39, 20);
            this.txt_plazo.TabIndex = 4;
            this.txt_plazo.Text = "0";
            this.txt_plazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_plazo_KeyPress);
            this.txt_plazo.Leave += new System.EventHandler(this.txt_plazo_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(748, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Fecha:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(85, 46);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(84, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(748, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Días de Plazo:";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(841, 14);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(90, 20);
            this.dtFecha.TabIndex = 3;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // txt_pedido
            // 
            this.txt_pedido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_pedido.Location = new System.Drawing.Point(85, 17);
            this.txt_pedido.MaxLength = 8;
            this.txt_pedido.Name = "txt_pedido";
            this.txt_pedido.ReadOnly = true;
            this.txt_pedido.Size = new System.Drawing.Size(84, 20);
            this.txt_pedido.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido #:";
            // 
            // gbxDetalleProducto
            // 
            this.gbxDetalleProducto.Controls.Add(this.UCFAModuloFacturacion);
            this.gbxDetalleProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDetalleProducto.Location = new System.Drawing.Point(0, 387);
            this.gbxDetalleProducto.Name = "gbxDetalleProducto";
            this.gbxDetalleProducto.Size = new System.Drawing.Size(966, 179);
            this.gbxDetalleProducto.TabIndex = 2;
            this.gbxDetalleProducto.TabStop = false;
            this.gbxDetalleProducto.Text = "Detalle de Productos";
            // 
            // UCFAModuloFacturacion
            // 
            this.UCFAModuloFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCFAModuloFacturacion.Inhabilitar_col_Peso = false;
            this.UCFAModuloFacturacion.Inhabilitar_col_Stock = false;
            this.UCFAModuloFacturacion.Location = new System.Drawing.Point(3, 16);
            this.UCFAModuloFacturacion.Name = "UCFAModuloFacturacion";
            this.UCFAModuloFacturacion.Size = new System.Drawing.Size(960, 160);
            this.UCFAModuloFacturacion.TabIndex = 0;
            this.UCFAModuloFacturacion.ValidaStock = false;
            this.UCFAModuloFacturacion.VisibleCosto = false;
            this.UCFAModuloFacturacion.VisibleDescuento = true;
            this.UCFAModuloFacturacion.VisibleIdPunto_Cargo = true;
            this.UCFAModuloFacturacion.VisiblePeso = true;
            this.UCFAModuloFacturacion.VisiblePorcDescuento = true;
            this.UCFAModuloFacturacion.VisiblePrecio_Iva = true;
            this.UCFAModuloFacturacion.VisibleStock = true;
            // 
            // gbxTotales
            // 
            this.gbxTotales.Controls.Add(this.txtTotal);
            this.gbxTotales.Controls.Add(this.txtSubTotal);
            this.gbxTotales.Controls.Add(this.txtIva);
            this.gbxTotales.Controls.Add(this.txtBase12);
            this.gbxTotales.Controls.Add(this.txt_Base0);
            this.gbxTotales.Controls.Add(this.label2);
            this.gbxTotales.Controls.Add(this.label13);
            this.gbxTotales.Controls.Add(this.label3);
            this.gbxTotales.Controls.Add(this.label5);
            this.gbxTotales.Controls.Add(this.label11);
            this.gbxTotales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxTotales.Location = new System.Drawing.Point(0, 566);
            this.gbxTotales.Name = "gbxTotales";
            this.gbxTotales.Size = new System.Drawing.Size(966, 44);
            this.gbxTotales.TabIndex = 3;
            this.gbxTotales.TabStop = false;
            this.gbxTotales.Text = "Totales";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(805, 13);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.EditValueChanged += new System.EventHandler(this.txtTotal_EditValueChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(613, 13);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 3;
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(403, 12);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 20);
            this.txtIva.TabIndex = 2;
            // 
            // txtBase12
            // 
            this.txtBase12.Enabled = false;
            this.txtBase12.Location = new System.Drawing.Point(260, 12);
            this.txtBase12.Name = "txtBase12";
            this.txtBase12.Size = new System.Drawing.Size(100, 20);
            this.txtBase12.TabIndex = 1;
            // 
            // txt_Base0
            // 
            this.txt_Base0.Enabled = false;
            this.txt_Base0.Location = new System.Drawing.Point(75, 12);
            this.txt_Base0.Name = "txt_Base0";
            this.txt_Base0.Size = new System.Drawing.Size(94, 20);
            this.txt_Base0.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Base 0:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(733, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 63;
            this.label13.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Base Imponible";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "SubTotal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(366, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Iva";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 610);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(966, 22);
            this.statusStrip1.TabIndex = 120;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btn_grabar
            // 
            this.btn_grabar.Image = global::Core.Erp.Winform.Properties.Resources.FormEdit;
            this.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(68, 22);
            this.btn_grabar.Text = "Aceptar";
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // btn_guardarSalir
            // 
            this.btn_guardarSalir.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardarSalir.Image")));
            this.btn_guardarSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardarSalir.Name = "btn_guardarSalir";
            this.btn_guardarSalir.Size = new System.Drawing.Size(103, 22);
            this.btn_guardarSalir.Text = "Guardar y Salir";
            this.btn_guardarSalir.Click += new System.EventHandler(this.btn_guardarSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Core.Erp.Winform.Properties.Resources.imprimir;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Text = "Imprimir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 22);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(166, 22);
            this.toolStripLabel1.Text = "                                                     ";
            // 
            // BtnAnular
            // 
            this.BtnAnular.Image = global::Core.Erp.Winform.Properties.Resources.eliminar;
            this.BtnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(62, 22);
            this.BtnAnular.Text = "Anular";
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_grabar,
            this.btn_guardarSalir,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.btnLimpiar,
            this.toolStripSeparator3,
            this.btn_salir,
            this.toolStripLabel1,
            this.BtnAnular});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(966, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmFa_Pedido_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 632);
            this.Controls.Add(this.gbxDetalleProducto);
            this.Controls.Add(this.gbxTotales);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbxCabecera);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmFa_Pedido_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos de Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFA_Pedido_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmFA_Pedido_Mant_Load);
            this.gbxCabecera.ResumeLayout(false);
            this.gbxCabecera.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            this.tabDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTerminoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFormaPag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFormaPag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facatalogoInfoBindingSource)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtro2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtro1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransporte.Properties)).EndInit();
            this.tabOrdDespacho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdDesXpedi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrddesXPedi)).EndInit();
            this.gbxDetalleProducto.ResumeLayout(false);
            this.gbxTotales.ResumeLayout(false);
            this.gbxTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBase12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Base0.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCabecera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pedido;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFechaVenc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_plazo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_estado_aprobacion;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.TextBox txt_cupo_maximo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_observacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDatos;
        private System.Windows.Forms.TabPage tabOrdDespacho;
        private DevExpress.XtraGrid.GridControl gridControlOrdDesXpedi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrddesXPedi;
        private DevExpress.XtraGrid.Columns.GridColumn IdOrdenDespacho;
        private DevExpress.XtraGrid.Columns.GridColumn od_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn od_detallexItems;
        private DevExpress.XtraGrid.Columns.GridColumn producto;
        private System.Windows.Forms.GroupBox gbxDetalleProducto;
        private System.Windows.Forms.GroupBox gbxTotales;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxEntrega;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEstadoProduccion;
        private System.Windows.Forms.BindingSource facatalogoInfoBindingSource;
        private Controles.UCIn_Sucursal_Bodega UC_Sucursal_Bodega;
        private Controles.UCFa_Cliente_Facturacion UC_Cliente;
        private Controles.UCFa_GridFactura UCFAModuloFacturacion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTerminoPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colDias_Vct;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_Cuotas;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraGrid.GridControl gridControlFormaPag;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewFormaPag;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteVta;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colDias_Plazo;
        private DevExpress.XtraGrid.Columns.GridColumn colPor_Distribucion;
        private DevExpress.XtraGrid.Columns.GridColumn colValor1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_vct;
        private System.Windows.Forms.TextBox txtPorDist;
        private System.Windows.Forms.TextBox txtValForPag;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtSubTotal;
        private DevExpress.XtraEditors.TextEdit txtIva;
        private DevExpress.XtraEditors.TextEdit txtBase12;
        private DevExpress.XtraEditors.TextEdit txt_Base0;
        private DevExpress.XtraEditors.TextEdit txtOtro2;
        private DevExpress.XtraEditors.TextEdit txtOtro1;
        private DevExpress.XtraEditors.TextEdit txtInteres;
        private DevExpress.XtraEditors.TextEdit txtTransporte;
        private System.Windows.Forms.ToolStripButton btn_grabar;
        private System.Windows.Forms.ToolStripButton btn_guardarSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BtnAnular;
        private System.Windows.Forms.ToolStrip toolStrip1;

    }
}