namespace Core.Erp.Winform.Roles_Fj
{
    partial class frmRo_Asignacion_Zona_x_empleado_Mant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRo_Asignacion_Zona_x_empleado_Mant));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_Empleados = new DevExpress.XtraGrid.GridControl();
            this.gridView_Empleados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_IdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_empleados = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Colicono_eliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_parametros_variables = new DevExpress.XtraGrid.GridControl();
            this.gridView_parametros_variables = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_parametro_liquidacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_icono_eliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_parametros_variable = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Nombre_Parametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_parametros_variables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_parametros_variables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_parametros_variable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 29);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1067, 417);
            this.splitContainerControl1.SplitterPosition = 437;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl_Empleados);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(437, 417);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Empleado por zona";
            // 
            // gridControl_Empleados
            // 
            this.gridControl_Empleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Empleados.Location = new System.Drawing.Point(2, 21);
            this.gridControl_Empleados.MainView = this.gridView_Empleados;
            this.gridControl_Empleados.Name = "gridControl_Empleados";
            this.gridControl_Empleados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_empleados,
            this.repositoryItemCheckEdit1,
            this.repositoryItemImageComboBox1});
            this.gridControl_Empleados.Size = new System.Drawing.Size(433, 394);
            this.gridControl_Empleados.TabIndex = 0;
            this.gridControl_Empleados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Empleados});
            // 
            // gridView_Empleados
            // 
            this.gridView_Empleados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_IdEmpleado,
            this.Col_check,
            this.Colicono_eliminar});
            this.gridView_Empleados.GridControl = this.gridControl_Empleados;
            this.gridView_Empleados.Name = "gridView_Empleados";
            this.gridView_Empleados.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_Empleados.OptionsView.ShowGroupPanel = false;
            this.gridView_Empleados.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Empleados_RowClick);
            this.gridView_Empleados.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_Empleados_RowCellClick);
            // 
            // Col_IdEmpleado
            // 
            this.Col_IdEmpleado.Caption = "Empleados";
            this.Col_IdEmpleado.ColumnEdit = this.cmb_empleados;
            this.Col_IdEmpleado.FieldName = "IdEmpleado";
            this.Col_IdEmpleado.Name = "Col_IdEmpleado";
            this.Col_IdEmpleado.Visible = true;
            this.Col_IdEmpleado.VisibleIndex = 1;
            this.Col_IdEmpleado.Width = 336;
            // 
            // cmb_empleados
            // 
            this.cmb_empleados.AutoHeight = false;
            this.cmb_empleados.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_empleados.Name = "cmb_empleados";
            this.cmb_empleados.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_empleado});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // col_empleado
            // 
            this.col_empleado.Caption = "Nombres";
            this.col_empleado.FieldName = "pe_nombreCompleto";
            this.col_empleado.Name = "col_empleado";
            this.col_empleado.Visible = true;
            this.col_empleado.VisibleIndex = 0;
            // 
            // Col_check
            // 
            this.Col_check.Caption = "*";
            this.Col_check.ColumnEdit = this.repositoryItemCheckEdit1;
            this.Col_check.FieldName = "check";
            this.Col_check.Name = "Col_check";
            this.Col_check.Visible = true;
            this.Col_check.VisibleIndex = 0;
            this.Col_check.Width = 20;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repositoryItemCheckEdit1_EditValueChanging);
            // 
            // Colicono_eliminar
            // 
            this.Colicono_eliminar.Caption = "***";
            this.Colicono_eliminar.ColumnEdit = this.repositoryItemImageComboBox1;
            this.Colicono_eliminar.FieldName = "icono_eliminar";
            this.Colicono_eliminar.Name = "Colicono_eliminar";
            this.Colicono_eliminar.OptionsColumn.AllowEdit = false;
            this.Colicono_eliminar.Visible = true;
            this.Colicono_eliminar.VisibleIndex = 2;
            this.Colicono_eliminar.Width = 38;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.repositoryItemImageComboBox1.LargeImages = this.imageList1;
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "anular2_32.x32png.png");
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl_parametros_variables);
            this.groupControl2.Controls.Add(this.panelControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(625, 417);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Zonas asignadas a empleados.";
            // 
            // gridControl_parametros_variables
            // 
            this.gridControl_parametros_variables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_parametros_variables.Location = new System.Drawing.Point(2, 49);
            this.gridControl_parametros_variables.MainView = this.gridView_parametros_variables;
            this.gridControl_parametros_variables.Name = "gridControl_parametros_variables";
            this.gridControl_parametros_variables.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox2});
            this.gridControl_parametros_variables.Size = new System.Drawing.Size(621, 366);
            this.gridControl_parametros_variables.TabIndex = 3;
            this.gridControl_parametros_variables.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_parametros_variables});
            // 
            // gridView_parametros_variables
            // 
            this.gridView_parametros_variables.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_parametro_liquidacion,
            this.Col_icono_eliminar});
            this.gridView_parametros_variables.GridControl = this.gridControl_parametros_variables;
            this.gridView_parametros_variables.Name = "gridView_parametros_variables";
            this.gridView_parametros_variables.OptionsView.ShowGroupPanel = false;
            this.gridView_parametros_variables.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_parametros_variables_RowClick);
            this.gridView_parametros_variables.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_parametros_variables_RowCellClick);
            // 
            // Col_parametro_liquidacion
            // 
            this.Col_parametro_liquidacion.Caption = "Parametros para pago de variable";
            this.Col_parametro_liquidacion.FieldName = "zo_descripcion";
            this.Col_parametro_liquidacion.Name = "Col_parametro_liquidacion";
            this.Col_parametro_liquidacion.Visible = true;
            this.Col_parametro_liquidacion.VisibleIndex = 0;
            this.Col_parametro_liquidacion.Width = 508;
            // 
            // Col_icono_eliminar
            // 
            this.Col_icono_eliminar.Caption = "***";
            this.Col_icono_eliminar.ColumnEdit = this.repositoryItemImageComboBox2;
            this.Col_icono_eliminar.FieldName = "icono_eliminar";
            this.Col_icono_eliminar.Name = "Col_icono_eliminar";
            this.Col_icono_eliminar.OptionsColumn.AllowEdit = false;
            this.Col_icono_eliminar.Visible = true;
            this.Col_icono_eliminar.VisibleIndex = 1;
            this.Col_icono_eliminar.Width = 31;
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.repositoryItemImageComboBox2.LargeImages = this.imageList1;
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.cmb_parametros_variable);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 21);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(621, 28);
            this.panelControl2.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton1.Location = new System.Drawing.Point(565, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(54, 24);
            this.simpleButton1.TabIndex = 150;
            this.simpleButton1.Text = "Agreagar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(130, 13);
            this.labelControl5.TabIndex = 149;
            this.labelControl5.Text = "Parametros liqui. variables:";
            // 
            // cmb_parametros_variable
            // 
            this.cmb_parametros_variable.Location = new System.Drawing.Point(141, 5);
            this.cmb_parametros_variable.Name = "cmb_parametros_variable";
            this.cmb_parametros_variable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_parametros_variable.Properties.DisplayMember = "zo_descripcion";
            this.cmb_parametros_variable.Properties.ValueMember = "IdZona";
            this.cmb_parametros_variable.Properties.View = this.searchLookUpEdit1View;
            this.cmb_parametros_variable.Size = new System.Drawing.Size(347, 20);
            this.cmb_parametros_variable.TabIndex = 148;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Nombre_Parametro});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Col_Nombre_Parametro
            // 
            this.Col_Nombre_Parametro.Caption = "Parametros Pago Variables";
            this.Col_Nombre_Parametro.FieldName = "zo_descripcion";
            this.Col_Nombre_Parametro.Name = "Col_Nombre_Parametro";
            this.Col_Nombre_Parametro.Visible = true;
            this.Col_Nombre_Parametro.VisibleIndex = 0;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 446);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1067, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 5;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1067, 29);
            this.ucGe_Menu.TabIndex = 4;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
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
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            // 
            // frmRo_Asignacion_Zona_x_empleado_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 472);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Asignacion_Zona_x_empleado_Mant";
            this.Text = "frmRo_Asignacion_Zona_x_empleado_Mant";
            this.Load += new System.EventHandler(this.frmRo_Asignacion_Zona_x_empleado_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_parametros_variables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_parametros_variables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_parametros_variable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl_Empleados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Empleados;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdEmpleado;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_empleados;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn col_empleado;
        private DevExpress.XtraGrid.Columns.GridColumn Col_check;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Colicono_eliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl_parametros_variables;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_parametros_variables;
        private DevExpress.XtraGrid.Columns.GridColumn Col_parametro_liquidacion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_icono_eliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_parametros_variable;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Nombre_Parametro;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.ImageList imageList1;
    }
}