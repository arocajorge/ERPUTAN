namespace Core.Erp.Winform.General
{
    partial class FrmGe_Tarjeta_Mantenimiento
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtComision = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRetFuente = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCobro_tipo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_descripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcentajeRet1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbRetIva = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCobro_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcentajeRet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_anulado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCobroTipo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCobro_tipo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_descripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBanco = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckEstado = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbretenciones = new System.Windows.Forms.GroupBox();
            this.grbcomision = new System.Windows.Forms.GroupBox();
            this.grbtarjeta = new System.Windows.Forms.GroupBox();
            this.cxccobrotipoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.ctPlanctaInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.ucCon_PlanCtaCmb1 = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.cxccobrotipoInfoBindingSource1 = new System.Windows.Forms.BindingSource();
            this.tbbancoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucCon_PlanCtaCmb2 = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            ((System.ComponentModel.ISupportInitialize)(this.txtComision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRetFuente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRetIva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCobroTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbretenciones.SuspendLayout();
            this.grbcomision.SuspendLayout();
            this.grbtarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobrotipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobrotipoInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbancoInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Cuenta Contable";
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(130, 27);
            this.txtComision.Name = "txtComision";
            this.txtComision.Properties.Mask.EditMask = "n";
            this.txtComision.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtComision.Properties.MaxLength = 7;
            this.txtComision.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtComision.Size = new System.Drawing.Size(142, 20);
            this.txtComision.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "% Comisión";
            // 
            // cmbRetFuente
            // 
            this.cmbRetFuente.Location = new System.Drawing.Point(130, 31);
            this.cmbRetFuente.Name = "cmbRetFuente";
            this.cmbRetFuente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRetFuente.Properties.DataSource = this.cxccobrotipoInfoBindingSource;
            this.cmbRetFuente.Properties.DisplayMember = "tc_descripcion";
            this.cmbRetFuente.Properties.NullText = "";
            this.cmbRetFuente.Properties.PopupSizeable = false;
            this.cmbRetFuente.Properties.ValueMember = "IdCobro_tipo";
            this.cmbRetFuente.Properties.View = this.gridView4;
            this.cmbRetFuente.Size = new System.Drawing.Size(369, 20);
            this.cmbRetFuente.TabIndex = 0;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCobro_tipo1,
            this.coltc_descripcion1,
            this.colPorcentajeRet1});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCobro_tipo1
            // 
            this.colIdCobro_tipo1.FieldName = "IdCobro_tipo";
            this.colIdCobro_tipo1.Name = "colIdCobro_tipo1";
            this.colIdCobro_tipo1.Visible = true;
            this.colIdCobro_tipo1.VisibleIndex = 0;
            this.colIdCobro_tipo1.Width = 226;
            // 
            // coltc_descripcion1
            // 
            this.coltc_descripcion1.FieldName = "tc_descripcion";
            this.coltc_descripcion1.Name = "coltc_descripcion1";
            this.coltc_descripcion1.Visible = true;
            this.coltc_descripcion1.VisibleIndex = 1;
            this.coltc_descripcion1.Width = 425;
            // 
            // colPorcentajeRet1
            // 
            this.colPorcentajeRet1.FieldName = "PorcentajeRet";
            this.colPorcentajeRet1.Name = "colPorcentajeRet1";
            this.colPorcentajeRet1.Visible = true;
            this.colPorcentajeRet1.VisibleIndex = 2;
            this.colPorcentajeRet1.Width = 475;
            // 
            // cmbRetIva
            // 
            this.cmbRetIva.Location = new System.Drawing.Point(130, 57);
            this.cmbRetIva.Name = "cmbRetIva";
            this.cmbRetIva.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRetIva.Properties.DataSource = this.cxccobrotipoInfoBindingSource;
            this.cmbRetIva.Properties.DisplayMember = "tc_descripcion";
            this.cmbRetIva.Properties.NullText = "";
            this.cmbRetIva.Properties.PopupSizeable = false;
            this.cmbRetIva.Properties.ValueMember = "IdCobro_tipo";
            this.cmbRetIva.Properties.View = this.gridView3;
            this.cmbRetIva.Size = new System.Drawing.Size(369, 20);
            this.cmbRetIva.TabIndex = 1;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCobro_tipo,
            this.coltc_descripcion,
            this.colPorcentajeRet});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdCobro_tipo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdCobro_tipo
            // 
            this.colIdCobro_tipo.FieldName = "IdCobro_tipo";
            this.colIdCobro_tipo.Name = "colIdCobro_tipo";
            this.colIdCobro_tipo.Visible = true;
            this.colIdCobro_tipo.VisibleIndex = 0;
            this.colIdCobro_tipo.Width = 143;
            // 
            // coltc_descripcion
            // 
            this.coltc_descripcion.Caption = "Descripcion";
            this.coltc_descripcion.FieldName = "tc_descripcion";
            this.coltc_descripcion.Name = "coltc_descripcion";
            this.coltc_descripcion.Visible = true;
            this.coltc_descripcion.VisibleIndex = 1;
            this.coltc_descripcion.Width = 305;
            // 
            // colPorcentajeRet
            // 
            this.colPorcentajeRet.FieldName = "PorcentajeRet";
            this.colPorcentajeRet.Name = "colPorcentajeRet";
            this.colPorcentajeRet.Visible = true;
            this.colPorcentajeRet.VisibleIndex = 2;
            this.colPorcentajeRet.Width = 678;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Retención Iva %";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Retencion Fuente %";
            // 
            // lbl_anulado
            // 
            this.lbl_anulado.AutoSize = true;
            this.lbl_anulado.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anulado.ForeColor = System.Drawing.Color.Red;
            this.lbl_anulado.Location = new System.Drawing.Point(306, 27);
            this.lbl_anulado.Name = "lbl_anulado";
            this.lbl_anulado.Size = new System.Drawing.Size(153, 23);
            this.lbl_anulado.TabIndex = 77;
            this.lbl_anulado.Text = "**ANULADO**";
            this.lbl_anulado.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Tipo de Cobro";
            // 
            // cmbCobroTipo
            // 
            this.cmbCobroTipo.Location = new System.Drawing.Point(130, 146);
            this.cmbCobroTipo.Name = "cmbCobroTipo";
            this.cmbCobroTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCobroTipo.Properties.DataSource = this.cxccobrotipoInfoBindingSource1;
            this.cmbCobroTipo.Properties.DisplayMember = "tc_descripcion";
            this.cmbCobroTipo.Properties.NullText = "";
            this.cmbCobroTipo.Properties.PopupSizeable = false;
            this.cmbCobroTipo.Properties.ValueMember = "IdCobro_tipo";
            this.cmbCobroTipo.Properties.View = this.gridView5;
            this.cmbCobroTipo.Size = new System.Drawing.Size(381, 20);
            this.cmbCobroTipo.TabIndex = 4;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCobro_tipo2,
            this.coltc_descripcion2});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coltc_descripcion2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdCobro_tipo2
            // 
            this.colIdCobro_tipo2.FieldName = "IdCobro_tipo";
            this.colIdCobro_tipo2.Name = "colIdCobro_tipo2";
            this.colIdCobro_tipo2.Visible = true;
            this.colIdCobro_tipo2.VisibleIndex = 0;
            this.colIdCobro_tipo2.Width = 192;
            // 
            // coltc_descripcion2
            // 
            this.coltc_descripcion2.Caption = "Descripción";
            this.coltc_descripcion2.FieldName = "tc_descripcion";
            this.coltc_descripcion2.Name = "coltc_descripcion2";
            this.coltc_descripcion2.Visible = true;
            this.coltc_descripcion2.VisibleIndex = 1;
            this.coltc_descripcion2.Width = 934;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(130, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(142, 20);
            this.txtId.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Banco";
            // 
            // cmbBanco
            // 
            this.cmbBanco.Location = new System.Drawing.Point(130, 88);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBanco.Properties.DataSource = this.tbbancoInfoBindingSource;
            this.cmbBanco.Properties.DisplayMember = "ba_descripcion";
            this.cmbBanco.Properties.NullText = "";
            this.cmbBanco.Properties.PopupSizeable = false;
            this.cmbBanco.Properties.ValueMember = "IdBanco";
            this.cmbBanco.Properties.View = this.searchLookUpEdit1View;
            this.cmbBanco.Size = new System.Drawing.Size(381, 20);
            this.cmbBanco.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdBanco,
            this.colba_descripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdBanco
            // 
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.Visible = true;
            this.colIdBanco.VisibleIndex = 0;
            this.colIdBanco.Width = 254;
            // 
            // colba_descripcion
            // 
            this.colba_descripcion.FieldName = "ba_descripcion";
            this.colba_descripcion.Name = "colba_descripcion";
            this.colba_descripcion.Visible = true;
            this.colba_descripcion.VisibleIndex = 1;
            this.colba_descripcion.Width = 872;
            // 
            // ckEstado
            // 
            this.ckEstado.Location = new System.Drawing.Point(408, 173);
            this.ckEstado.Name = "ckEstado";
            this.ckEstado.Properties.Caption = "Activo";
            this.ckEstado.Size = new System.Drawing.Size(75, 19);
            this.ckEstado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(130, 59);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(383, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Cuenta Contable";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grbcomision);
            this.panel1.Controls.Add(this.grbtarjeta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 494);
            this.panel1.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grbretenciones);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 96);
            this.panel2.TabIndex = 54;
            // 
            // grbretenciones
            // 
            this.grbretenciones.Controls.Add(this.cmbRetFuente);
            this.grbretenciones.Controls.Add(this.label9);
            this.grbretenciones.Controls.Add(this.cmbRetIva);
            this.grbretenciones.Controls.Add(this.label8);
            this.grbretenciones.Location = new System.Drawing.Point(0, 0);
            this.grbretenciones.Name = "grbretenciones";
            this.grbretenciones.Size = new System.Drawing.Size(592, 108);
            this.grbretenciones.TabIndex = 1;
            this.grbretenciones.TabStop = false;
            this.grbretenciones.Text = "Retenciones emitidas por el banco";
            // 
            // grbcomision
            // 
            this.grbcomision.Controls.Add(this.ucCon_PlanCtaCmb2);
            this.grbcomision.Controls.Add(this.txtComision);
            this.grbcomision.Controls.Add(this.label7);
            this.grbcomision.Controls.Add(this.label6);
            this.grbcomision.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbcomision.Location = new System.Drawing.Point(0, 308);
            this.grbcomision.Name = "grbcomision";
            this.grbcomision.Size = new System.Drawing.Size(592, 186);
            this.grbcomision.TabIndex = 2;
            this.grbcomision.TabStop = false;
            this.grbcomision.Text = "Comisión";
            // 
            // grbtarjeta
            // 
            this.grbtarjeta.Controls.Add(this.ucCon_PlanCtaCmb1);
            this.grbtarjeta.Controls.Add(this.lbl_anulado);
            this.grbtarjeta.Controls.Add(this.txtDescripcion);
            this.grbtarjeta.Controls.Add(this.label4);
            this.grbtarjeta.Controls.Add(this.label3);
            this.grbtarjeta.Controls.Add(this.cmbCobroTipo);
            this.grbtarjeta.Controls.Add(this.label2);
            this.grbtarjeta.Controls.Add(this.label1);
            this.grbtarjeta.Controls.Add(this.txtId);
            this.grbtarjeta.Controls.Add(this.ckEstado);
            this.grbtarjeta.Controls.Add(this.label5);
            this.grbtarjeta.Controls.Add(this.cmbBanco);
            this.grbtarjeta.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbtarjeta.Location = new System.Drawing.Point(0, 0);
            this.grbtarjeta.Name = "grbtarjeta";
            this.grbtarjeta.Size = new System.Drawing.Size(592, 212);
            this.grbtarjeta.TabIndex = 0;
            this.grbtarjeta.TabStop = false;
            this.grbtarjeta.Text = "Tarjeta";
            // 
            // cxccobrotipoInfoBindingSource
            // 
            this.cxccobrotipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_cobro_tipo_Info);
            // 
            // ctPlanctaInfoBindingSource
            // 
            this.ctPlanctaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Plancta_Info);
            // 
            // ucCon_PlanCtaCmb1
            // 
            this.ucCon_PlanCtaCmb1.Location = new System.Drawing.Point(127, 116);
            this.ucCon_PlanCtaCmb1.Name = "ucCon_PlanCtaCmb1";
            this.ucCon_PlanCtaCmb1.Size = new System.Drawing.Size(388, 28);
            this.ucCon_PlanCtaCmb1.TabIndex = 78;
            // 
            // cxccobrotipoInfoBindingSource1
            // 
            this.cxccobrotipoInfoBindingSource1.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_cobro_tipo_Info);
            // 
            // tbbancoInfoBindingSource
            // 
            this.tbbancoInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_banco_Info);
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
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(592, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_event_btnlimpiar_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucCon_PlanCtaCmb2
            // 
            this.ucCon_PlanCtaCmb2.Location = new System.Drawing.Point(127, 55);
            this.ucCon_PlanCtaCmb2.Name = "ucCon_PlanCtaCmb2";
            this.ucCon_PlanCtaCmb2.Size = new System.Drawing.Size(388, 28);
            this.ucCon_PlanCtaCmb2.TabIndex = 79;
            // 
            // FrmGe_Tarjeta_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(592, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmGe_Tarjeta_Mantenimiento";
            this.Text = "Tarjeta - Mantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGe_Tarjeta_Mantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.FrmGe_Tarjeta_Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtComision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRetFuente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRetIva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCobroTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grbretenciones.ResumeLayout(false);
            this.grbretenciones.PerformLayout();
            this.grbcomision.ResumeLayout(false);
            this.grbcomision.PerformLayout();
            this.grbtarjeta.ResumeLayout(false);
            this.grbtarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobrotipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobrotipoInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbancoInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ctPlanctaInfoBindingSource;
        private System.Windows.Forms.BindingSource tbbancoInfoBindingSource;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtComision;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbRetFuente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbRetIva;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.CheckEdit ckEstado;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource cxccobrotipoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcentajeRet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo1;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_descripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcentajeRet1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colba_descripcion;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCobroTipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private System.Windows.Forms.BindingSource cxccobrotipoInfoBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo2;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_descripcion2;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Label lbl_anulado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbcomision;
        private System.Windows.Forms.GroupBox grbretenciones;
        private System.Windows.Forms.GroupBox grbtarjeta;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCCon_PlanCtaCmb ucCon_PlanCtaCmb1;
        private Controles.UCCon_PlanCtaCmb ucCon_PlanCtaCmb2;
    }
}