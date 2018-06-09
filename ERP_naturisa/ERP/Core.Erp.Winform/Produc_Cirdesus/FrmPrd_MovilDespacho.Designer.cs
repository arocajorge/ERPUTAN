namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_MovilDespacho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrd_MovilDespacho));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControlDisponible = new DevExpress.XtraGrid.GridControl();
            this.gridViewDisponible = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdDespacho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenTaller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoBarraMaestro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colot_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIngCB = new System.Windows.Forms.TextBox();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_cliente = new System.Windows.Forms.Panel();
            this.ctrl_Sucbod = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.PanelObra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumDespacho = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaReg = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFFin = new System.Windows.Forms.DateTimePicker();
            this.cmbTipTransporte = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtChofer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPuntoLLegada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPuntoPartida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDisponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDisponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btn_guardar,
            this.toolStripSeparator5,
            this.btn_salir,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(224, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(224, 17);
            this.toolStrip1.TabIndex = 122;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 17);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(74, 14);
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 17);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(53, 14);
            this.btn_salir.Text = "SALIR";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 17);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.gridControlDisponible);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 18);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(216, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DETALLE";
            // 
            // gridControlDisponible
            // 
            this.gridControlDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDisponible.Location = new System.Drawing.Point(3, 36);
            this.gridControlDisponible.MainView = this.gridViewDisponible;
            this.gridControlDisponible.Name = "gridControlDisponible";
            this.gridControlDisponible.Size = new System.Drawing.Size(210, 210);
            this.gridControlDisponible.TabIndex = 73;
            this.gridControlDisponible.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDisponible,
            this.gridView2});
            // 
            // gridViewDisponible
            // 
            this.gridViewDisponible.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold);
            this.gridViewDisponible.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewDisponible.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.gridViewDisponible.Appearance.Row.Options.UseFont = true;
            this.gridViewDisponible.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdDespacho,
            this.colSecuencia,
            this.colIdOrdenTaller,
            this.colHora,
            this.colIdProducto,
            this.colCodigoBarraMaestro,
            this.colCodigoBarra,
            this.colCantidad,
            this.colObservacion,
            this.colot_descripcion,
            this.colpr_descripcion,
            this.gridColumn1});
            this.gridViewDisponible.GridControl = this.gridControlDisponible;
            this.gridViewDisponible.Name = "gridViewDisponible";
            this.gridViewDisponible.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewDisponible.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewDisponible.OptionsView.ShowGroupPanel = false;
            this.gridViewDisponible.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewDisponible_RowCellClick);
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
            // colIdDespacho
            // 
            this.colIdDespacho.FieldName = "IdDespacho";
            this.colIdDespacho.Name = "colIdDespacho";
            // 
            // colSecuencia
            // 
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            // 
            // colIdOrdenTaller
            // 
            this.colIdOrdenTaller.FieldName = "IdOrdenTaller";
            this.colIdOrdenTaller.Name = "colIdOrdenTaller";
            // 
            // colHora
            // 
            this.colHora.Caption = "HORA";
            this.colHora.FieldName = "Hora";
            this.colHora.MinWidth = 40;
            this.colHora.Name = "colHora";
            this.colHora.OptionsColumn.AllowEdit = false;
            this.colHora.OptionsColumn.ReadOnly = true;
            this.colHora.Visible = true;
            this.colHora.VisibleIndex = 6;
            this.colHora.Width = 247;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            // 
            // colCodigoBarraMaestro
            // 
            this.colCodigoBarraMaestro.Caption = "CB";
            this.colCodigoBarraMaestro.FieldName = "CodigoBarra";
            this.colCodigoBarraMaestro.MinWidth = 120;
            this.colCodigoBarraMaestro.Name = "colCodigoBarraMaestro";
            this.colCodigoBarraMaestro.OptionsColumn.AllowEdit = false;
            this.colCodigoBarraMaestro.OptionsColumn.ReadOnly = true;
            this.colCodigoBarraMaestro.Visible = true;
            this.colCodigoBarraMaestro.VisibleIndex = 1;
            this.colCodigoBarraMaestro.Width = 196;
            // 
            // colCodigoBarra
            // 
            this.colCodigoBarra.Caption = "MAESTRO";
            this.colCodigoBarra.FieldName = "CodigoBarraMaestro";
            this.colCodigoBarra.MinWidth = 120;
            this.colCodigoBarra.Name = "colCodigoBarra";
            this.colCodigoBarra.Visible = true;
            this.colCodigoBarra.VisibleIndex = 2;
            this.colCodigoBarra.Width = 216;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "OBSERVACIÓN";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.MinWidth = 120;
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 3;
            this.colObservacion.Width = 229;
            // 
            // colot_descripcion
            // 
            this.colot_descripcion.Caption = "OT";
            this.colot_descripcion.FieldName = "ot_descripcion";
            this.colot_descripcion.MinWidth = 120;
            this.colot_descripcion.Name = "colot_descripcion";
            this.colot_descripcion.OptionsColumn.AllowEdit = false;
            this.colot_descripcion.OptionsColumn.ReadOnly = true;
            this.colot_descripcion.Visible = true;
            this.colot_descripcion.VisibleIndex = 4;
            this.colot_descripcion.Width = 228;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "PRD";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.MinWidth = 120;
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.OptionsColumn.AllowEdit = false;
            this.colpr_descripcion.OptionsColumn.ReadOnly = true;
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 5;
            this.colpr_descripcion.Width = 202;
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn1.FieldName = "Checked";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsColumn.ShowCaption = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 34;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlDisponible;
            this.gridView2.Name = "gridView2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtIngCB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 33);
            this.panel2.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(14, 10);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 12);
            this.label13.TabIndex = 117;
            this.label13.Text = "CB:";
            // 
            // txtIngCB
            // 
            this.txtIngCB.BackColor = System.Drawing.SystemColors.Info;
            this.txtIngCB.Location = new System.Drawing.Point(46, 7);
            this.txtIngCB.Name = "txtIngCB";
            this.txtIngCB.Size = new System.Drawing.Size(144, 17);
            this.txtIngCB.TabIndex = 2;
            this.txtIngCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngCB_KeyPress);
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 18);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(216, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DATOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblAnulado);
            this.panel1.Controls.Add(this.txtObservacion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel_cliente);
            this.panel1.Controls.Add(this.ctrl_Sucbod);
            this.panel1.Controls.Add(this.PanelObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNumDespacho);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpFechaReg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 243);
            this.panel1.TabIndex = 124;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(147, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 131;
            this.label14.Text = "V: K091013";
            // 
            // lblAnulado
            // 
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(50, 165);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(95, 15);
            this.lblAnulado.TabIndex = 128;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnulado.Visible = false;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.txtObservacion.Location = new System.Drawing.Point(34, 147);
            this.txtObservacion.MaxLength = 1000;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(170, 53);
            this.txtObservacion.TabIndex = 130;
            this.txtObservacion.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label8.Location = new System.Drawing.Point(4, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 12);
            this.label8.TabIndex = 129;
            this.label8.Text = "OBS:";
            // 
            // panel_cliente
            // 
            this.panel_cliente.Location = new System.Drawing.Point(5, 114);
            this.panel_cliente.Name = "panel_cliente";
            this.panel_cliente.Size = new System.Drawing.Size(204, 21);
            this.panel_cliente.TabIndex = 126;
            // 
            // ctrl_Sucbod
            // 
            this.ctrl_Sucbod.Location = new System.Drawing.Point(3, 40);
            this.ctrl_Sucbod.Name = "ctrl_Sucbod";
            this.ctrl_Sucbod.Size = new System.Drawing.Size(204, 45);
            this.ctrl_Sucbod.TabIndex = 125;
            this.ctrl_Sucbod.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
            // 
            // PanelObra
            // 
            this.PanelObra.Location = new System.Drawing.Point(5, 89);
            this.PanelObra.Margin = new System.Windows.Forms.Padding(2);
            this.PanelObra.Name = "PanelObra";
            this.PanelObra.Size = new System.Drawing.Size(204, 21);
            this.PanelObra.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label1.Location = new System.Drawing.Point(89, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 116;
            this.label1.Text = "FEC:";
            // 
            // txtNumDespacho
            // 
            this.txtNumDespacho.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNumDespacho.Enabled = false;
            this.txtNumDespacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.txtNumDespacho.Location = new System.Drawing.Point(36, 25);
            this.txtNumDespacho.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumDespacho.MaxLength = 20;
            this.txtNumDespacho.MinimumSize = new System.Drawing.Size(80, 15);
            this.txtNumDespacho.Name = "txtNumDespacho";
            this.txtNumDespacho.ReadOnly = true;
            this.txtNumDespacho.Size = new System.Drawing.Size(164, 17);
            this.txtNumDespacho.TabIndex = 115;
            this.txtNumDespacho.Text = "0";
            this.txtNumDespacho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.txtId.Location = new System.Drawing.Point(36, 6);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.MaximumSize = new System.Drawing.Size(30, 15);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(30, 17);
            this.txtId.TabIndex = 115;
            this.txtId.Text = "0";
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label9.Location = new System.Drawing.Point(4, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 12);
            this.label9.TabIndex = 114;
            this.label9.Text = "DESP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label6.Location = new System.Drawing.Point(4, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 114;
            this.label6.Text = "N#";
            // 
            // dtpFechaReg
            // 
            this.dtpFechaReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.dtpFechaReg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReg.Location = new System.Drawing.Point(120, 6);
            this.dtpFechaReg.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaReg.MaximumSize = new System.Drawing.Size(80, 15);
            this.dtpFechaReg.Name = "dtpFechaReg";
            this.dtpFechaReg.Size = new System.Drawing.Size(80, 15);
            this.dtpFechaReg.TabIndex = 117;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(20, 14);
            this.tabControl1.Location = new System.Drawing.Point(0, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(224, 271);
            this.tabControl1.TabIndex = 123;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 18);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(216, 249);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GUIA DE REMISIÓN";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.dtpFInicio);
            this.groupBox4.Controls.Add(this.dtpFFin);
            this.groupBox4.Controls.Add(this.cmbTipTransporte);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtPlaca);
            this.groupBox4.Controls.Add(this.txtChofer);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtPuntoLLegada);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtPuntoPartida);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtGuia);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 249);
            this.groupBox4.TabIndex = 126;
            this.groupBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label12.Location = new System.Drawing.Point(5, 69);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 12);
            this.label12.TabIndex = 119;
            this.label12.Text = "FF:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label11.Location = new System.Drawing.Point(5, 46);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 119;
            this.label11.Text = "FI:";
            // 
            // dtpFInicio
            // 
            this.dtpFInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.dtpFInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFInicio.Location = new System.Drawing.Point(36, 44);
            this.dtpFInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFInicio.Name = "dtpFInicio";
            this.dtpFInicio.Size = new System.Drawing.Size(80, 17);
            this.dtpFInicio.TabIndex = 120;
            this.dtpFInicio.Tag = "2";
            // 
            // dtpFFin
            // 
            this.dtpFFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.dtpFFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFFin.Location = new System.Drawing.Point(36, 69);
            this.dtpFFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFFin.Name = "dtpFFin";
            this.dtpFFin.Size = new System.Drawing.Size(80, 17);
            this.dtpFFin.TabIndex = 120;
            this.dtpFFin.Tag = "3";
            // 
            // cmbTipTransporte
            // 
            this.cmbTipTransporte.FormattingEnabled = true;
            this.cmbTipTransporte.Items.AddRange(new object[] {
            "Camión",
            "Barco",
            "Avión"});
            this.cmbTipTransporte.Location = new System.Drawing.Point(36, 92);
            this.cmbTipTransporte.Name = "cmbTipTransporte";
            this.cmbTipTransporte.Size = new System.Drawing.Size(170, 20);
            this.cmbTipTransporte.TabIndex = 118;
            this.cmbTipTransporte.Tag = "4";
            this.cmbTipTransporte.Text = "Camión";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 12);
            this.label10.TabIndex = 117;
            this.label10.Text = "TT:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(36, 216);
            this.txtPlaca.MaxLength = 20;
            this.txtPlaca.Multiline = true;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(170, 15);
            this.txtPlaca.TabIndex = 116;
            this.txtPlaca.Tag = "8";
            this.txtPlaca.Text = "0";
            // 
            // txtChofer
            // 
            this.txtChofer.Location = new System.Drawing.Point(36, 195);
            this.txtChofer.MaxLength = 60;
            this.txtChofer.Multiline = true;
            this.txtChofer.Name = "txtChofer";
            this.txtChofer.Size = new System.Drawing.Size(170, 15);
            this.txtChofer.TabIndex = 116;
            this.txtChofer.Tag = "7";
            this.txtChofer.Text = "Sr.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label7.Location = new System.Drawing.Point(5, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 12);
            this.label7.TabIndex = 114;
            this.label7.Text = "PLC:";
            // 
            // txtPuntoLLegada
            // 
            this.txtPuntoLLegada.Location = new System.Drawing.Point(36, 156);
            this.txtPuntoLLegada.MaxLength = 200;
            this.txtPuntoLLegada.Multiline = true;
            this.txtPuntoLLegada.Name = "txtPuntoLLegada";
            this.txtPuntoLLegada.Size = new System.Drawing.Size(170, 33);
            this.txtPuntoLLegada.TabIndex = 116;
            this.txtPuntoLLegada.Tag = "6";
            this.txtPuntoLLegada.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label5.Location = new System.Drawing.Point(7, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 12);
            this.label5.TabIndex = 114;
            this.label5.Text = "CH:";
            // 
            // txtPuntoPartida
            // 
            this.txtPuntoPartida.Location = new System.Drawing.Point(36, 123);
            this.txtPuntoPartida.MaxLength = 200;
            this.txtPuntoPartida.Multiline = true;
            this.txtPuntoPartida.Name = "txtPuntoPartida";
            this.txtPuntoPartida.Size = new System.Drawing.Size(170, 27);
            this.txtPuntoPartida.TabIndex = 116;
            this.txtPuntoPartida.Tag = "5";
            this.txtPuntoPartida.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 12);
            this.label4.TabIndex = 114;
            this.label4.Text = "PLL:";
            // 
            // txtGuia
            // 
            this.txtGuia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtGuia.Enabled = false;
            this.txtGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.txtGuia.Location = new System.Drawing.Point(36, 17);
            this.txtGuia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGuia.MaxLength = 50;
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.ReadOnly = true;
            this.txtGuia.Size = new System.Drawing.Size(50, 17);
            this.txtGuia.TabIndex = 115;
            this.txtGuia.Tag = "1";
            this.txtGuia.Text = "0";
            this.txtGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label3.Location = new System.Drawing.Point(8, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 12);
            this.label3.TabIndex = 114;
            this.label3.Text = "PP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label2.Location = new System.Drawing.Point(5, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 12);
            this.label2.TabIndex = 114;
            this.label2.Text = "#";
            // 
            // FrmPrd_MovilDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(224, 288);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(1, 1);
            this.Name = "FrmPrd_MovilDespacho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DESPACHO";
            this.Load += new System.EventHandler(this.FrmPrd_DespachoMantenimiento_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDisponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDisponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_cliente;
        private Controles.UCIn_Sucursal_Bodega ctrl_Sucbod;
        private System.Windows.Forms.Panel PanelObra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaReg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPuntoPartida;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPuntoLLegada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChofer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumDespacho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFInicio;
        private System.Windows.Forms.DateTimePicker dtpFFin;
        private System.Windows.Forms.ComboBox cmbTipTransporte;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraGrid.GridControl gridControlDisponible;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDisponible;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDespacho;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenTaller;
        private DevExpress.XtraGrid.Columns.GridColumn colHora;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBarraMaestro;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBarra;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colot_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIngCB;
        private System.Windows.Forms.Label label14;
    }
}