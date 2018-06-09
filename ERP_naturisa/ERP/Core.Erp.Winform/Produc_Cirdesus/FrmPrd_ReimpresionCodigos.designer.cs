namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_ReimpresionCodigos
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
            this.inmoviinvedetallexProductoCusCiderInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.ucIn_Sucursal_Bodega = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.txtCodbarra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbProducto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridCtrlConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridVwConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigoBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmvtp_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinvedetallexProductoCusCiderInfoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inmoviinvedetallexProductoCusCiderInfoBindingSource
            // 
            this.inmoviinvedetallexProductoCusCiderInfoBindingSource.DataSource = typeof(Core.Erp.Info.Produc_Cirdesus.in_movi_inve_detalle_x_Producto_CusCider_Info);
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
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(885, 29);
            this.ucGe_Menu.TabIndex = 4;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = true;
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            this.ucGe_Menu.event_btnproductos_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnproductos_Click(this.ucGe_Menu_event_btnproductos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.ucIn_Sucursal_Bodega);
            this.groupBox1.Controls.Add(this.txtCodbarra);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbProducto);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.dtpFechaIni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(804, 63);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 129;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ucIn_Sucursal_Bodega
            // 
            this.ucIn_Sucursal_Bodega.Location = new System.Drawing.Point(5, 6);
            this.ucIn_Sucursal_Bodega.Name = "ucIn_Sucursal_Bodega";
            this.ucIn_Sucursal_Bodega.Size = new System.Drawing.Size(470, 54);
            this.ucIn_Sucursal_Bodega.TabIndex = 128;
            this.ucIn_Sucursal_Bodega.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.todos;
            // 
            // txtCodbarra
            // 
            this.txtCodbarra.Location = new System.Drawing.Point(82, 60);
            this.txtCodbarra.Name = "txtCodbarra";
            this.txtCodbarra.Size = new System.Drawing.Size(380, 20);
            this.txtCodbarra.TabIndex = 127;
            this.txtCodbarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodbarra_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 124;
            this.label10.Text = "Códi de Barra:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(476, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 123;
            this.label9.Text = "Producto:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.Location = new System.Drawing.Point(535, 40);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducto.Properties.DisplayMember = "pr_descripcion";
            this.cmbProducto.Properties.ValueMember = "IdProducto";
            this.cmbProducto.Properties.View = this.searchLookUpEdit1View;
            this.cmbProducto.Size = new System.Drawing.Size(344, 20);
            this.cmbProducto.TabIndex = 125;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto1,
            this.colpr_codigo,
            this.colpr_descripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colpr_descripcion, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdProducto1
            // 
            this.colIdProducto1.Caption = "Id";
            this.colIdProducto1.FieldName = "IdProducto";
            this.colIdProducto1.Name = "colIdProducto1";
            this.colIdProducto1.Visible = true;
            this.colIdProducto1.VisibleIndex = 2;
            this.colIdProducto1.Width = 73;
            // 
            // colpr_codigo
            // 
            this.colpr_codigo.Caption = "Código";
            this.colpr_codigo.FieldName = "pr_codigo";
            this.colpr_codigo.Name = "colpr_codigo";
            this.colpr_codigo.Visible = true;
            this.colpr_codigo.VisibleIndex = 1;
            this.colpr_codigo.Width = 327;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Producto";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 0;
            this.colpr_descripcion.Width = 748;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(715, 14);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(165, 20);
            this.dtpFechaFin.TabIndex = 117;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(538, 14);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(118, 20);
            this.dtpFechaIni.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 115;
            this.label1.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "Desde:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridCtrlConsulta);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(885, 395);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // gridCtrlConsulta
            // 
            this.gridCtrlConsulta.DataSource = this.inmoviinvedetallexProductoCusCiderInfoBindingSource;
            this.gridCtrlConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlConsulta.Location = new System.Drawing.Point(3, 52);
            this.gridCtrlConsulta.MainView = this.gridVwConsulta;
            this.gridCtrlConsulta.Name = "gridCtrlConsulta";
            this.gridCtrlConsulta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridCtrlConsulta.Size = new System.Drawing.Size(879, 340);
            this.gridCtrlConsulta.TabIndex = 1;
            this.gridCtrlConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVwConsulta});
            // 
            // gridVwConsulta
            // 
            this.gridVwConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoBarra,
            this.coldm_observacion,
            this.colcm_fecha,
            this.colmvtp_descripcion,
            this.colcheck});
            this.gridVwConsulta.GridControl = this.gridCtrlConsulta;
            this.gridVwConsulta.Name = "gridVwConsulta";
            this.gridVwConsulta.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCodigoBarra
            // 
            this.colCodigoBarra.AppearanceCell.BackColor = System.Drawing.SystemColors.HotTrack;
            this.colCodigoBarra.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.colCodigoBarra.AppearanceCell.Options.UseBackColor = true;
            this.colCodigoBarra.AppearanceCell.Options.UseForeColor = true;
            this.colCodigoBarra.Caption = "Código de Barra";
            this.colCodigoBarra.FieldName = "CodigoBarra";
            this.colCodigoBarra.Name = "colCodigoBarra";
            this.colCodigoBarra.Visible = true;
            this.colCodigoBarra.VisibleIndex = 4;
            this.colCodigoBarra.Width = 349;
            // 
            // coldm_observacion
            // 
            this.coldm_observacion.Caption = "Observación";
            this.coldm_observacion.FieldName = "dm_observacion";
            this.coldm_observacion.Name = "coldm_observacion";
            this.coldm_observacion.Visible = true;
            this.coldm_observacion.VisibleIndex = 3;
            this.coldm_observacion.Width = 502;
            // 
            // colcm_fecha
            // 
            this.colcm_fecha.Caption = "Fecha";
            this.colcm_fecha.FieldName = "cm_fecha";
            this.colcm_fecha.Name = "colcm_fecha";
            this.colcm_fecha.Visible = true;
            this.colcm_fecha.VisibleIndex = 1;
            this.colcm_fecha.Width = 96;
            // 
            // colmvtp_descripcion
            // 
            this.colmvtp_descripcion.Caption = "Tipo/Mov Inventario";
            this.colmvtp_descripcion.FieldName = "pr_descripcion";
            this.colmvtp_descripcion.Name = "colmvtp_descripcion";
            this.colmvtp_descripcion.Visible = true;
            this.colmvtp_descripcion.VisibleIndex = 2;
            this.colmvtp_descripcion.Width = 174;
            // 
            // colcheck
            // 
            this.colcheck.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colcheck.FieldName = "check";
            this.colcheck.Name = "colcheck";
            this.colcheck.OptionsColumn.ShowCaption = false;
            this.colcheck.Visible = true;
            this.colcheck.VisibleIndex = 0;
            this.colcheck.Width = 43;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkTodos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 36);
            this.panel1.TabIndex = 0;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(21, 10);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 0;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // FrmPrd_ReimpresionCodigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmPrd_ReimpresionCodigos";
            this.Text = "Reimpresión de Códigos";
            this.Load += new System.EventHandler(this.Frm_Prd_ReimpresionCodigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinvedetallexProductoCusCiderInfoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource inmoviinvedetallexProductoCusCiderInfoBindingSource;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodbarra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gridCtrlConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVwConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBarra;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colmvtp_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkTodos;
        private Controles.UCIn_Sucursal_Bodega ucIn_Sucursal_Bodega;
        private DevExpress.XtraEditors.SimpleButton BtnBuscar;
    }
}