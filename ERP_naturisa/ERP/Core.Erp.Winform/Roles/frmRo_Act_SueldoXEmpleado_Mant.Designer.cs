namespace Core.Erp.Winform.Roles
{

    /// <summary>
    /// 29/10/2013 10.16
    /// </summary>
    partial class frmRo_Act_SueldoXEmpleado_Mant
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
            this.ChkAll = new System.Windows.Forms.CheckBox();
            this.txeIncremento = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtPorcentaje = new System.Windows.Forms.RadioButton();
            this.rbtValor = new System.Windows.Forms.RadioButton();
            this.grdLista = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colem_cedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_fechaIngaRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_sueldoBasicoMen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSueldoActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Colem_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkOpcion = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.roEmpleadoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbDepartamento = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colde_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Colapellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txeIncremento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOpcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChkAll
            // 
            this.ChkAll.AutoSize = true;
            this.ChkAll.Location = new System.Drawing.Point(12, 33);
            this.ChkAll.Name = "ChkAll";
            this.ChkAll.Size = new System.Drawing.Size(111, 17);
            this.ChkAll.TabIndex = 61;
            this.ChkAll.Text = "Seleccionar todos";
            this.ChkAll.UseVisualStyleBackColor = true;
            this.ChkAll.CheckedChanged += new System.EventHandler(this.ChkAll_CheckedChanged);
            // 
            // txeIncremento
            // 
            this.txeIncremento.Location = new System.Drawing.Point(213, 25);
            this.txeIncremento.Name = "txeIncremento";
            this.txeIncremento.Properties.Mask.EditMask = "#,#######0.00;#,#######0.00";
            this.txeIncremento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeIncremento.Size = new System.Drawing.Size(100, 20);
            this.txeIncremento.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Calcular Sueldo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(5, 63);
            this.txtObservacion.MaxLength = 200;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(818, 34);
            this.txtObservacion.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Observación :";
            // 
            // rbtPorcentaje
            // 
            this.rbtPorcentaje.AutoSize = true;
            this.rbtPorcentaje.Location = new System.Drawing.Point(105, 27);
            this.rbtPorcentaje.Name = "rbtPorcentaje";
            this.rbtPorcentaje.Size = new System.Drawing.Size(95, 17);
            this.rbtPorcentaje.TabIndex = 1;
            this.rbtPorcentaje.Text = "Por Porcentaje";
            this.rbtPorcentaje.UseVisualStyleBackColor = true;
            // 
            // rbtValor
            // 
            this.rbtValor.AutoSize = true;
            this.rbtValor.Checked = true;
            this.rbtValor.Location = new System.Drawing.Point(12, 27);
            this.rbtValor.Name = "rbtValor";
            this.rbtValor.Size = new System.Drawing.Size(68, 17);
            this.rbtValor.TabIndex = 0;
            this.rbtValor.TabStop = true;
            this.rbtValor.Text = "Por Valor";
            this.rbtValor.UseVisualStyleBackColor = true;
            this.rbtValor.CheckedChanged += new System.EventHandler(this.rbtValor_CheckedChanged);
            // 
            // grdLista
            // 
            this.grdLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLista.Location = new System.Drawing.Point(0, 0);
            this.grdLista.MainView = this.gridView;
            this.grdLista.Name = "grdLista";
            this.grdLista.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkOpcion,
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit2});
            this.grdLista.Size = new System.Drawing.Size(835, 315);
            this.grdLista.TabIndex = 0;
            this.grdLista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcheck,
            this.colem_cedulaRuc,
            this.ColNombres,
            this.coldepartamento,
            this.colem_fechaIngaRol,
            this.colem_sueldoBasicoMen,
            this.colSueldoActual,
            this.Colem_codigo,
            this.Colapellidos});
            this.gridView.GridControl = this.grdLista;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowViewCaption = true;
            this.gridView.ViewCaption = "Listado de Empleados";
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            this.gridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView_InvalidRowException);
            this.gridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView_ValidateRow);
            this.gridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_KeyDown);
            this.gridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridView_KeyPress);
            // 
            // colcheck
            // 
            this.colcheck.Caption = "...";
            this.colcheck.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colcheck.FieldName = "check";
            this.colcheck.Name = "colcheck";
            this.colcheck.Visible = true;
            this.colcheck.VisibleIndex = 0;
            this.colcheck.Width = 20;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colem_cedulaRuc
            // 
            this.colem_cedulaRuc.Caption = "Cédula/RUC";
            this.colem_cedulaRuc.FieldName = "InfoPersona.pe_cedulaRuc";
            this.colem_cedulaRuc.Name = "colem_cedulaRuc";
            this.colem_cedulaRuc.OptionsColumn.AllowEdit = false;
            this.colem_cedulaRuc.Visible = true;
            this.colem_cedulaRuc.VisibleIndex = 2;
            this.colem_cedulaRuc.Width = 88;
            // 
            // ColNombres
            // 
            this.ColNombres.Caption = "Nombres";
            this.ColNombres.FieldName = "InfoPersona.pe_nombre";
            this.ColNombres.Name = "ColNombres";
            this.ColNombres.OptionsColumn.AllowEdit = false;
            this.ColNombres.Visible = true;
            this.ColNombres.VisibleIndex = 4;
            this.ColNombres.Width = 147;
            // 
            // coldepartamento
            // 
            this.coldepartamento.Caption = "Departamento";
            this.coldepartamento.FieldName = "de_descripcion";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.OptionsColumn.AllowEdit = false;
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 5;
            this.coldepartamento.Width = 134;
            // 
            // colem_fechaIngaRol
            // 
            this.colem_fechaIngaRol.Caption = "Fecha Ingreso";
            this.colem_fechaIngaRol.FieldName = "em_fechaIngaRol";
            this.colem_fechaIngaRol.Name = "colem_fechaIngaRol";
            this.colem_fechaIngaRol.OptionsColumn.AllowEdit = false;
            this.colem_fechaIngaRol.Visible = true;
            this.colem_fechaIngaRol.VisibleIndex = 6;
            this.colem_fechaIngaRol.Width = 61;
            // 
            // colem_sueldoBasicoMen
            // 
            this.colem_sueldoBasicoMen.Caption = "Sueldo Actual";
            this.colem_sueldoBasicoMen.FieldName = "em_sueldoBasicoMen";
            this.colem_sueldoBasicoMen.Name = "colem_sueldoBasicoMen";
            this.colem_sueldoBasicoMen.OptionsColumn.AllowEdit = false;
            this.colem_sueldoBasicoMen.Visible = true;
            this.colem_sueldoBasicoMen.VisibleIndex = 7;
            this.colem_sueldoBasicoMen.Width = 62;
            // 
            // colSueldoActual
            // 
            this.colSueldoActual.Caption = "SueldoNuevo";
            this.colSueldoActual.ColumnEdit = this.repositoryItemTextEdit2;
            this.colSueldoActual.FieldName = "SueldoActual";
            this.colSueldoActual.Name = "colSueldoActual";
            this.colSueldoActual.Visible = true;
            this.colSueldoActual.VisibleIndex = 8;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.EditFormat.FormatString = "D2";
            this.repositoryItemTextEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // Colem_codigo
            // 
            this.Colem_codigo.Caption = "Codigo";
            this.Colem_codigo.FieldName = "em_codigo";
            this.Colem_codigo.Name = "Colem_codigo";
            this.Colem_codigo.Visible = true;
            this.Colem_codigo.VisibleIndex = 1;
            this.Colem_codigo.Width = 61;
            // 
            // chkOpcion
            // 
            this.chkOpcion.AutoHeight = false;
            this.chkOpcion.Name = "chkOpcion";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // roEmpleadoInfoBindingSource
            // 
            this.roEmpleadoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Empleado_Info);
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
            this.ucGe_Menu.Size = new System.Drawing.Size(835, 29);
            this.ucGe_Menu.TabIndex = 56;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txeIncremento);
            this.groupControl1.Controls.Add(this.txtObservacion);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.rbtValor);
            this.groupControl1.Controls.Add(this.rbtPorcentaje);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(835, 103);
            this.groupControl1.TabIndex = 57;
            this.groupControl1.Text = "Seleccione el tipo de incremento";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CmbDepartamento);
            this.panel1.Controls.Add(this.ChkAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 50);
            this.panel1.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Seleccione Departamento Para la Actaulizacion de sueldo";
            // 
            // CmbDepartamento
            // 
            this.CmbDepartamento.Location = new System.Drawing.Point(310, 10);
            this.CmbDepartamento.Name = "CmbDepartamento";
            this.CmbDepartamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbDepartamento.Properties.DisplayMember = "de_descripcion";
            this.CmbDepartamento.Properties.ValueMember = "IdDepartamento";
            this.CmbDepartamento.Properties.View = this.gridLookUpEdit1View;
            this.CmbDepartamento.Size = new System.Drawing.Size(513, 20);
            this.CmbDepartamento.TabIndex = 62;
            this.CmbDepartamento.EditValueChanged += new System.EventHandler(this.CmbDepartamento_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdDepartamento,
            this.Colde_descripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdDepartamento
            // 
            this.ColIdDepartamento.Caption = "Id";
            this.ColIdDepartamento.FieldName = "IdDepartamento";
            this.ColIdDepartamento.Name = "ColIdDepartamento";
            this.ColIdDepartamento.Visible = true;
            this.ColIdDepartamento.VisibleIndex = 0;
            this.ColIdDepartamento.Width = 70;
            // 
            // Colde_descripcion
            // 
            this.Colde_descripcion.Caption = "Descripcion";
            this.Colde_descripcion.FieldName = "de_descripcion";
            this.Colde_descripcion.Name = "Colde_descripcion";
            this.Colde_descripcion.Visible = true;
            this.Colde_descripcion.VisibleIndex = 1;
            this.Colde_descripcion.Width = 718;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdLista);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 315);
            this.panel2.TabIndex = 63;
            // 
            // Colapellidos
            // 
            this.Colapellidos.Caption = "Apellidos";
            this.Colapellidos.FieldName = "InfoPersona.pe_apellido";
            this.Colapellidos.Name = "Colapellidos";
            this.Colapellidos.Visible = true;
            this.Colapellidos.VisibleIndex = 3;
            this.Colapellidos.Width = 140;
            // 
            // frmRo_Act_SueldoXEmpleado_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmRo_Act_SueldoXEmpleado_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso - Actualización de Sueldo";
            this.Load += new System.EventHandler(this.frm_HistoricoSueldo_Consu_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_Act_SueldoXEmpleado_Mant_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txeIncremento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOpcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtPorcentaje;
        private System.Windows.Forms.RadioButton rbtValor;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ChkAll;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit txeIncremento;
        private DevExpress.XtraGrid.GridControl grdLista;
        private System.Windows.Forms.BindingSource roEmpleadoInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkOpcion;
        private DevExpress.XtraGrid.Columns.GridColumn colem_cedulaRuc;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombres;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colem_fechaIngaRol;
        private DevExpress.XtraGrid.Columns.GridColumn colem_sueldoBasicoMen;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colSueldoActual;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GridLookUpEdit CmbDepartamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn Colde_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Colem_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Colapellidos;
    }
}