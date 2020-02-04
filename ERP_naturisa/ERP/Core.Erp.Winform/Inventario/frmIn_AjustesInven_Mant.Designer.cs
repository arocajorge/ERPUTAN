namespace Core.Erp.Winform.Inventario
{
    partial class frmIn_AjustesInven_Mant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIn_AjustesInven_Mant));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.txtcodigoAjuste = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSucursal_bodega = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtNumAjuste = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_tipoMoviInven = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdMovi_inven_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tm_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cm_tipo_movi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cm_descripcionCorta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.opt_egreso = new System.Windows.Forms.RadioButton();
            this.opt_ingreso = new System.Windows.Forms.RadioButton();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnGrabar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGrabarySalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnlimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelEspacio = new System.Windows.Forms.ToolStripLabel();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.tabControl_detalle = new System.Windows.Forms.TabControl();
            this.tabProducto = new System.Windows.Forms.TabPage();
            this.panelDetalleProducto = new System.Windows.Forms.Panel();
            this.tabContabilidad = new System.Windows.Forms.TabPage();
            this.TmHilo = new System.Windows.Forms.Timer(this.components);
            this.ucCon_GridDiarioContable_ = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipoMoviInven.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.toolStripMain.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.tabControl_detalle.SuspendLayout();
            this.tabProducto.SuspendLayout();
            this.tabContabilidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAnulado);
            this.groupBox1.Controls.Add(this.txtcodigoAjuste);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panelSucursal_bodega);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtNumAjuste);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Principales de Ajuste";
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(520, 16);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(123, 20);
            this.lblAnulado.TabIndex = 14;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // txtcodigoAjuste
            // 
            this.txtcodigoAjuste.Location = new System.Drawing.Point(344, 22);
            this.txtcodigoAjuste.Name = "txtcodigoAjuste";
            this.txtcodigoAjuste.Size = new System.Drawing.Size(157, 20);
            this.txtcodigoAjuste.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo Ajuste:";
            // 
            // panelSucursal_bodega
            // 
            this.panelSucursal_bodega.Location = new System.Drawing.Point(15, 48);
            this.panelSucursal_bodega.Name = "panelSucursal_bodega";
            this.panelSucursal_bodega.Size = new System.Drawing.Size(472, 61);
            this.panelSucursal_bodega.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtObservacion);
            this.groupBox4.Location = new System.Drawing.Point(15, 115);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1027, 73);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Observacion";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacion.Location = new System.Drawing.Point(3, 16);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(1021, 54);
            this.txtObservacion.TabIndex = 8;
            // 
            // txtNumAjuste
            // 
            this.txtNumAjuste.Enabled = false;
            this.txtNumAjuste.Location = new System.Drawing.Point(83, 22);
            this.txtNumAjuste.Name = "txtNumAjuste";
            this.txtNumAjuste.Size = new System.Drawing.Size(157, 20);
            this.txtNumAjuste.TabIndex = 10;
            this.txtNumAjuste.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "#Ajuste:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(931, 16);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(108, 20);
            this.dtpFecha.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(885, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_tipoMoviInven);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.opt_egreso);
            this.groupBox2.Controls.Add(this.opt_ingreso);
            this.groupBox2.Location = new System.Drawing.Point(515, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 71);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Movimiento";
            // 
            // cmb_tipoMoviInven
            // 
            this.cmb_tipoMoviInven.Location = new System.Drawing.Point(140, 35);
            this.cmb_tipoMoviInven.Name = "cmb_tipoMoviInven";
            this.cmb_tipoMoviInven.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipoMoviInven.Properties.DisplayMember = "tm_descripcion2";
            this.cmb_tipoMoviInven.Properties.ValueMember = "IdMovi_inven_tipo";
            this.cmb_tipoMoviInven.Properties.View = this.searchLookUpEdit1View;
            this.cmb_tipoMoviInven.Size = new System.Drawing.Size(384, 20);
            this.cmb_tipoMoviInven.TabIndex = 5;
            this.cmb_tipoMoviInven.EditValueChanged += new System.EventHandler(this.cmb_tipoMoviInven_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdMovi_inven_tipo,
            this.tm_descripcion,
            this.cm_tipo_movi,
            this.cm_descripcionCorta,
            this.Estado,
            this.IdTipoCbte,
            this.IdCtaCble});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // IdMovi_inven_tipo
            // 
            this.IdMovi_inven_tipo.Caption = "Id";
            this.IdMovi_inven_tipo.FieldName = "IdMovi_inven_tipo";
            this.IdMovi_inven_tipo.Name = "IdMovi_inven_tipo";
            this.IdMovi_inven_tipo.Visible = true;
            this.IdMovi_inven_tipo.VisibleIndex = 0;
            this.IdMovi_inven_tipo.Width = 51;
            // 
            // tm_descripcion
            // 
            this.tm_descripcion.Caption = "Descripcion";
            this.tm_descripcion.FieldName = "tm_descripcion";
            this.tm_descripcion.Name = "tm_descripcion";
            this.tm_descripcion.Visible = true;
            this.tm_descripcion.VisibleIndex = 1;
            this.tm_descripcion.Width = 494;
            // 
            // cm_tipo_movi
            // 
            this.cm_tipo_movi.Caption = "Tipo";
            this.cm_tipo_movi.FieldName = "cm_tipo_movi";
            this.cm_tipo_movi.Name = "cm_tipo_movi";
            this.cm_tipo_movi.Visible = true;
            this.cm_tipo_movi.VisibleIndex = 3;
            this.cm_tipo_movi.Width = 65;
            // 
            // cm_descripcionCorta
            // 
            this.cm_descripcionCorta.Caption = "Abreviatura";
            this.cm_descripcionCorta.FieldName = "cm_descripcionCorta";
            this.cm_descripcionCorta.Name = "cm_descripcionCorta";
            this.cm_descripcionCorta.Visible = true;
            this.cm_descripcionCorta.VisibleIndex = 2;
            this.cm_descripcionCorta.Width = 96;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 4;
            this.Estado.Width = 56;
            // 
            // IdTipoCbte
            // 
            this.IdTipoCbte.Caption = "IdTipoCbte";
            this.IdTipoCbte.FieldName = "IdTipoCbte";
            this.IdTipoCbte.Name = "IdTipoCbte";
            this.IdTipoCbte.Visible = true;
            this.IdTipoCbte.VisibleIndex = 5;
            this.IdTipoCbte.Width = 418;
            // 
            // IdCtaCble
            // 
            this.IdCtaCble.Caption = "IdCtaCble";
            this.IdCtaCble.FieldName = "IdCtaCble";
            this.IdCtaCble.Name = "IdCtaCble";
            this.IdCtaCble.Visible = true;
            this.IdCtaCble.VisibleIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Concepto";
            // 
            // opt_egreso
            // 
            this.opt_egreso.AutoSize = true;
            this.opt_egreso.Location = new System.Drawing.Point(17, 42);
            this.opt_egreso.Name = "opt_egreso";
            this.opt_egreso.Size = new System.Drawing.Size(58, 17);
            this.opt_egreso.TabIndex = 1;
            this.opt_egreso.Text = "Egreso";
            this.opt_egreso.UseVisualStyleBackColor = true;
            this.opt_egreso.CheckedChanged += new System.EventHandler(this.opt_egreso_CheckedChanged);
            // 
            // opt_ingreso
            // 
            this.opt_ingreso.AutoSize = true;
            this.opt_ingreso.Checked = true;
            this.opt_ingreso.Location = new System.Drawing.Point(15, 19);
            this.opt_ingreso.Name = "opt_ingreso";
            this.opt_ingreso.Size = new System.Drawing.Size(60, 17);
            this.opt_ingreso.TabIndex = 0;
            this.opt_ingreso.TabStop = true;
            this.opt_ingreso.Text = "Ingreso";
            this.opt_ingreso.UseVisualStyleBackColor = true;
            this.opt_ingreso.CheckedChanged += new System.EventHandler(this.opt_ingreso_CheckedChanged);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGrabar,
            this.toolStripSeparator1,
            this.btnGrabarySalir,
            this.toolStripSeparator3,
            this.btnImprimir,
            this.toolStripSeparator2,
            this.btnlimpiar,
            this.toolStripSeparator5,
            this.toolStripLabelEspacio,
            this.btnAnular,
            this.toolStripSeparator4,
            this.btnSalir});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1058, 25);
            this.toolStripMain.TabIndex = 5;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(62, 22);
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGrabarySalir
            // 
            this.btnGrabarySalir.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabarySalir.Image")));
            this.btnGrabarySalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrabarySalir.Name = "btnGrabarySalir";
            this.btnGrabarySalir.Size = new System.Drawing.Size(103, 22);
            this.btnGrabarySalir.Text = "Guardar y Salir";
            this.btnGrabarySalir.Click += new System.EventHandler(this.btnGrabarySalir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Core.Erp.Winform.Properties.Resources.imprimir;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(51, 22);
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelEspacio
            // 
            this.toolStripLabelEspacio.Name = "toolStripLabelEspacio";
            this.toolStripLabelEspacio.Size = new System.Drawing.Size(106, 22);
            this.toolStripLabelEspacio.Text = "                                 ";
            // 
            // btnAnular
            // 
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(62, 22);
            this.btnAnular.Text = "Anular";
            this.btnAnular.Click += new System.EventHandler(this.mnu_anular_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "&Salir";
            this.btnSalir.Click += new System.EventHandler(this.mnu_salir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1058, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.tabControl_detalle);
            this.panelPrincipal.Controls.Add(this.groupBox1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 25);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1058, 562);
            this.panelPrincipal.TabIndex = 8;
            // 
            // tabControl_detalle
            // 
            this.tabControl_detalle.Controls.Add(this.tabProducto);
            this.tabControl_detalle.Controls.Add(this.tabContabilidad);
            this.tabControl_detalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_detalle.Location = new System.Drawing.Point(0, 204);
            this.tabControl_detalle.Name = "tabControl_detalle";
            this.tabControl_detalle.SelectedIndex = 0;
            this.tabControl_detalle.Size = new System.Drawing.Size(1058, 358);
            this.tabControl_detalle.TabIndex = 4;
            // 
            // tabProducto
            // 
            this.tabProducto.Controls.Add(this.panelDetalleProducto);
            this.tabProducto.Location = new System.Drawing.Point(4, 22);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducto.Size = new System.Drawing.Size(1050, 332);
            this.tabProducto.TabIndex = 0;
            this.tabProducto.Text = "Productos";
            this.tabProducto.UseVisualStyleBackColor = true;
            // 
            // panelDetalleProducto
            // 
            this.panelDetalleProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalleProducto.Location = new System.Drawing.Point(3, 3);
            this.panelDetalleProducto.Name = "panelDetalleProducto";
            this.panelDetalleProducto.Size = new System.Drawing.Size(1044, 326);
            this.panelDetalleProducto.TabIndex = 0;
            // 
            // tabContabilidad
            // 
            this.tabContabilidad.Controls.Add(this.ucCon_GridDiarioContable_);
            this.tabContabilidad.Location = new System.Drawing.Point(4, 22);
            this.tabContabilidad.Name = "tabContabilidad";
            this.tabContabilidad.Padding = new System.Windows.Forms.Padding(3);
            this.tabContabilidad.Size = new System.Drawing.Size(1050, 332);
            this.tabContabilidad.TabIndex = 1;
            this.tabContabilidad.Text = "Diario Contable";
            this.tabContabilidad.UseVisualStyleBackColor = true;
            // 
            // ucCon_GridDiarioContable_
            // 
            this.ucCon_GridDiarioContable_.Botones_Visible = true;
            this.ucCon_GridDiarioContable_.Cabecera_Visible = true;
            this.ucCon_GridDiarioContable_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCon_GridDiarioContable_.Location = new System.Drawing.Point(3, 3);
            this.ucCon_GridDiarioContable_.Name = "ucCon_GridDiarioContable_";
            this.ucCon_GridDiarioContable_.Size = new System.Drawing.Size(1044, 326);
            this.ucCon_GridDiarioContable_.TabIndex = 0;
            // 
            // frmIn_AjustesInven_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 609);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripMain);
            this.Name = "frmIn_AjustesInven_Mant";
            this.Text = "Ajuste de Inventario (Ingresos /Egresos)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIn_AjustesInven_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmIn_AjustesInven_Mant_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipoMoviInven.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.tabControl_detalle.ResumeLayout(false);
            this.tabProducto.ResumeLayout(false);
            this.tabContabilidad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnGrabar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGrabarySalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton opt_egreso;
        private System.Windows.Forms.RadioButton opt_ingreso;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtNumAjuste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelSucursal_bodega;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl_detalle;
        private System.Windows.Forms.TabPage tabProducto;
        private System.Windows.Forms.TabPage tabContabilidad;
        private System.Windows.Forms.Panel panelDetalleProducto;
        private System.Windows.Forms.TextBox txtcodigoAjuste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.Timer TmHilo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnlimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabelEspacio;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_tipoMoviInven;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn IdMovi_inven_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn tm_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn cm_tipo_movi;
        private DevExpress.XtraGrid.Columns.GridColumn cm_descripcionCorta;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn IdTipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn IdCtaCble;
        private Controles.UCCon_GridDiarioContable ucCon_GridDiarioContable_;
    }
}