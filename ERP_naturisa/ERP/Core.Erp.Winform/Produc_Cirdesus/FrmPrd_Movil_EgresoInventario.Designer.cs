namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_Movil_EgresoInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrd_Movil_EgresoInventario));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridLkUOrdenTaller = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenTaller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadPieza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelObra = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigoAjuste = new System.Windows.Forms.TextBox();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctrl_Sucbod = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumAjuste = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControlDisponible = new DevExpress.XtraGrid.GridControl();
            this.gridViewDisponible = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuarioautorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIngCB = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLkUOrdenTaller.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDisponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDisponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(20, 14);
            this.tabControl1.Location = new System.Drawing.Point(0, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(224, 267);
            this.tabControl1.TabIndex = 127;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 18);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(216, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DATOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridLkUOrdenTaller);
            this.panel1.Controls.Add(this.panelObra);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtcodigoAjuste);
            this.panel1.Controls.Add(this.lblAnulado);
            this.panel1.Controls.Add(this.txtObservacion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ctrl_Sucbod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNumAjuste);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 239);
            this.panel1.TabIndex = 124;
            // 
            // gridLkUOrdenTaller
            // 
            this.gridLkUOrdenTaller.Location = new System.Drawing.Point(33, 127);
            this.gridLkUOrdenTaller.Name = "gridLkUOrdenTaller";
            this.gridLkUOrdenTaller.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.gridLkUOrdenTaller.Properties.Appearance.Options.UseFont = true;
            this.gridLkUOrdenTaller.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLkUOrdenTaller.Properties.DisplayMember = "Codigo";
            this.gridLkUOrdenTaller.Properties.ValueMember = "IdOrdenTaller";
            this.gridLkUOrdenTaller.Properties.View = this.gridLookUpEdit1View;
            this.gridLkUOrdenTaller.Size = new System.Drawing.Size(170, 18);
            this.gridLkUOrdenTaller.TabIndex = 136;
            this.gridLkUOrdenTaller.EditValueChanged += new System.EventHandler(this.gridLkUOrdenTaller_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colIdOrdenTaller,
            this.gridColumn2,
            this.colNomProducto,
            this.colIdProducto1,
            this.colCantidadPieza});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdEmpresa";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colIdOrdenTaller
            // 
            this.colIdOrdenTaller.Caption = "Orden de Taller No.";
            this.colIdOrdenTaller.FieldName = "IdOrdenTaller";
            this.colIdOrdenTaller.Name = "colIdOrdenTaller";
            this.colIdOrdenTaller.Visible = true;
            this.colIdOrdenTaller.VisibleIndex = 0;
            this.colIdOrdenTaller.Width = 135;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Orden de Taller";
            this.gridColumn2.FieldName = "Codigo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 353;
            // 
            // colNomProducto
            // 
            this.colNomProducto.Caption = "Producto Final";
            this.colNomProducto.FieldName = "NomProducto";
            this.colNomProducto.Name = "colNomProducto";
            this.colNomProducto.Visible = true;
            this.colNomProducto.VisibleIndex = 2;
            this.colNomProducto.Width = 514;
            // 
            // colIdProducto1
            // 
            this.colIdProducto1.FieldName = "IdProducto";
            this.colIdProducto1.Name = "colIdProducto1";
            this.colIdProducto1.Width = 273;
            // 
            // colCantidadPieza
            // 
            this.colCantidadPieza.Caption = "Unidades";
            this.colCantidadPieza.FieldName = "CantidadPieza";
            this.colCantidadPieza.Name = "colCantidadPieza";
            this.colCantidadPieza.Visible = true;
            this.colCantidadPieza.VisibleIndex = 3;
            this.colCantidadPieza.Width = 178;
            // 
            // panelObra
            // 
            this.panelObra.Location = new System.Drawing.Point(3, 99);
            this.panelObra.Margin = new System.Windows.Forms.Padding(2);
            this.panelObra.Name = "panelObra";
            this.panelObra.Size = new System.Drawing.Size(204, 21);
            this.panelObra.TabIndex = 135;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label3.Location = new System.Drawing.Point(5, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 12);
            this.label3.TabIndex = 133;
            this.label3.Text = "OT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 132;
            this.label2.Text = "COD:";
            // 
            // txtcodigoAjuste
            // 
            this.txtcodigoAjuste.Location = new System.Drawing.Point(33, 27);
            this.txtcodigoAjuste.Name = "txtcodigoAjuste";
            this.txtcodigoAjuste.Size = new System.Drawing.Size(170, 17);
            this.txtcodigoAjuste.TabIndex = 131;
            // 
            // lblAnulado
            // 
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(59, 179);
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
            this.txtObservacion.Location = new System.Drawing.Point(33, 157);
            this.txtObservacion.MaxLength = 1000;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(170, 53);
            this.txtObservacion.TabIndex = 130;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label8.Location = new System.Drawing.Point(5, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 12);
            this.label8.TabIndex = 129;
            this.label8.Text = "OBS:";
            // 
            // ctrl_Sucbod
            // 
            this.ctrl_Sucbod.Location = new System.Drawing.Point(3, 47);
            this.ctrl_Sucbod.Name = "ctrl_Sucbod";
            this.ctrl_Sucbod.Size = new System.Drawing.Size(204, 45);
            this.ctrl_Sucbod.TabIndex = 125;
            this.ctrl_Sucbod.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
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
            // txtNumAjuste
            // 
            this.txtNumAjuste.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNumAjuste.Enabled = false;
            this.txtNumAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.txtNumAjuste.Location = new System.Drawing.Point(31, 6);
            this.txtNumAjuste.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumAjuste.MaximumSize = new System.Drawing.Size(30, 15);
            this.txtNumAjuste.Name = "txtNumAjuste";
            this.txtNumAjuste.ReadOnly = true;
            this.txtNumAjuste.Size = new System.Drawing.Size(30, 17);
            this.txtNumAjuste.TabIndex = 115;
            this.txtNumAjuste.Text = "0";
            this.txtNumAjuste.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label6.Location = new System.Drawing.Point(5, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 114;
            this.label6.Text = "N#";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(122, 6);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.MaximumSize = new System.Drawing.Size(80, 15);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(80, 15);
            this.dtpFecha.TabIndex = 117;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.gridControlDisponible);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 18);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(216, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DETALLE";
            // 
            // gridControlDisponible
            // 
            this.gridControlDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDisponible.Location = new System.Drawing.Point(3, 36);
            this.gridControlDisponible.MainView = this.gridViewDisponible;
            this.gridControlDisponible.Name = "gridControlDisponible";
            this.gridControlDisponible.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlDisponible.Size = new System.Drawing.Size(210, 206);
            this.gridControlDisponible.TabIndex = 74;
            this.gridControlDisponible.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDisponible});
            // 
            // gridViewDisponible
            // 
            this.gridViewDisponible.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold);
            this.gridViewDisponible.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewDisponible.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.gridViewDisponible.Appearance.Row.Options.UseFont = true;
            this.gridViewDisponible.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.colIdProducto,
            this.colpr_codigo_barra,
            this.colpr_observacion,
            this.colProducto,
            this.colCantidad,
            this.colCodProducto,
            this.colvalida,
            this.colusuarioautorizacion});
            this.gridViewDisponible.GridControl = this.gridControlDisponible;
            this.gridViewDisponible.Name = "gridViewDisponible";
            this.gridViewDisponible.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewDisponible.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewDisponible.OptionsView.ShowGroupPanel = false;
            this.gridViewDisponible.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewDisponible_RowCellClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn3.FieldName = "Checked";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.OptionsColumn.ShowCaption = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 23;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "ID";
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.OptionsColumn.AllowEdit = false;
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 5;
            this.colIdProducto.Width = 52;
            // 
            // colpr_codigo_barra
            // 
            this.colpr_codigo_barra.Caption = "CB";
            this.colpr_codigo_barra.FieldName = "CodBarra";
            this.colpr_codigo_barra.MinWidth = 120;
            this.colpr_codigo_barra.Name = "colpr_codigo_barra";
            this.colpr_codigo_barra.Visible = true;
            this.colpr_codigo_barra.VisibleIndex = 1;
            this.colpr_codigo_barra.Width = 295;
            // 
            // colpr_observacion
            // 
            this.colpr_observacion.Caption = "OBSERVACIÓN";
            this.colpr_observacion.FieldName = "dm_observacion";
            this.colpr_observacion.MinWidth = 120;
            this.colpr_observacion.Name = "colpr_observacion";
            this.colpr_observacion.Visible = true;
            this.colpr_observacion.VisibleIndex = 3;
            this.colpr_observacion.Width = 295;
            // 
            // colProducto
            // 
            this.colProducto.Caption = "PROD";
            this.colProducto.FieldName = "NomProducto";
            this.colProducto.MinWidth = 120;
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.AllowEdit = false;
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 2;
            this.colProducto.Width = 295;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cant";
            this.colCantidad.FieldName = "dm_cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colCodProducto
            // 
            this.colCodProducto.Caption = "COD";
            this.colCodProducto.FieldName = "CodProducto";
            this.colCodProducto.MinWidth = 80;
            this.colCodProducto.Name = "colCodProducto";
            this.colCodProducto.Visible = true;
            this.colCodProducto.VisibleIndex = 4;
            this.colCodProducto.Width = 196;
            // 
            // colvalida
            // 
            this.colvalida.FieldName = "valida";
            this.colvalida.Name = "colvalida";
            // 
            // colusuarioautorizacion
            // 
            this.colusuarioautorizacion.FieldName = "oc_observacion";
            this.colusuarioautorizacion.Name = "colusuarioautorizacion";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtIngCB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 33);
            this.panel2.TabIndex = 73;
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
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btn_guardar,
            this.toolStripSeparator5,
            this.btnSalir,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(224, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(224, 17);
            this.toolStrip1.TabIndex = 126;
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
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 14);
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 17);
            // 
            // FrmPrd_Movil_EgresoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(224, 284);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(1, 1);
            this.Name = "FrmPrd_Movil_EgresoInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Egreso de Inventario";
            this.Load += new System.EventHandler(this.frmIn_EgresoInventario_x_Produccion_Mantenimiento_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLkUOrdenTaller.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDisponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDisponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigoAjuste;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label8;
        private Controles.UCIn_Sucursal_Bodega ctrl_Sucbod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumAjuste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel panelObra;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GridLookUpEdit gridLkUOrdenTaller;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenTaller;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colNomProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadPieza;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraGrid.GridControl gridControlDisponible;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDisponible;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colvalida;
        private DevExpress.XtraGrid.Columns.GridColumn colusuarioautorizacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIngCB;
    }
}