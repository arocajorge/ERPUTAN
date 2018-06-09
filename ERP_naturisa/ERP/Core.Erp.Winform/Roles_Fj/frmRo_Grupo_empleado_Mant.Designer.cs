namespace Core.Erp.Winform.Roles_Fj
{
    partial class frmRo_Grupo_empleado_Mant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRo_Grupo_empleado_Mant));
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_Valor_trans = new DevExpress.XtraEditors.TextEdit();
            this.txt_Valor_alime = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_rubros_transp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_rubros_aliment = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_IdRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_ru_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_num_horas_sab_dom = new DevExpress.XtraEditors.TextEdit();
            this.dtFechaSalida = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtnombre = new DevExpress.XtraEditors.TextEdit();
            this.txt_num_calculo_horas_extras = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txt_valor_bono = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl_parametro_Variable = new DevExpress.XtraGrid.GridControl();
            this.gridView_parametro_Variable = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Cool_IdRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_rubro_pago_variable = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_ru_descrip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_rub_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_porcentaje_Pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_icono_eliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Valor_trans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Valor_alime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_rubros_transp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_rubros_aliment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_horas_sab_dom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSalida.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSalida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_calculo_horas_extras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor_bono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_parametro_Variable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_parametro_Variable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_rubro_pago_variable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(590, 29);
            this.ucGe_Menu.TabIndex = 74;
            this.ucGe_Menu.Visible_bntAnular = true;
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
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_Valor_trans);
            this.groupControl1.Controls.Add(this.txt_Valor_alime);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.cmb_rubros_transp);
            this.groupControl1.Controls.Add(this.cmb_rubros_aliment);
            this.groupControl1.Controls.Add(this.txt_num_horas_sab_dom);
            this.groupControl1.Controls.Add(this.dtFechaSalida);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtnombre);
            this.groupControl1.Controls.Add(this.txt_num_calculo_horas_extras);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(590, 155);
            this.groupControl1.TabIndex = 75;
            this.groupControl1.Text = "Datos Grupo";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // txt_Valor_trans
            // 
            this.txt_Valor_trans.Location = new System.Drawing.Point(500, 94);
            this.txt_Valor_trans.Name = "txt_Valor_trans";
            this.txt_Valor_trans.Size = new System.Drawing.Size(71, 20);
            this.txt_Valor_trans.TabIndex = 166;
            // 
            // txt_Valor_alime
            // 
            this.txt_Valor_alime.Location = new System.Drawing.Point(500, 71);
            this.txt_Valor_alime.Name = "txt_Valor_alime";
            this.txt_Valor_alime.Size = new System.Drawing.Size(71, 20);
            this.txt_Valor_alime.TabIndex = 165;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(461, 97);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 164;
            this.labelControl9.Text = "Valor $";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(461, 74);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(33, 13);
            this.labelControl6.TabIndex = 163;
            this.labelControl6.Text = "Valor $";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(8, 97);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(53, 13);
            this.labelControl8.TabIndex = 162;
            this.labelControl8.Text = "Transporte";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 74);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 13);
            this.labelControl7.TabIndex = 161;
            this.labelControl7.Text = "Alimentacion";
            // 
            // cmb_rubros_transp
            // 
            this.cmb_rubros_transp.EditValue = "";
            this.cmb_rubros_transp.Location = new System.Drawing.Point(155, 94);
            this.cmb_rubros_transp.Name = "cmb_rubros_transp";
            this.cmb_rubros_transp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_rubros_transp.Properties.DisplayMember = "ru_descripcion";
            this.cmb_rubros_transp.Properties.ValueMember = "IdRubro";
            this.cmb_rubros_transp.Properties.View = this.gridView1;
            this.cmb_rubros_transp.Size = new System.Drawing.Size(300, 20);
            this.cmb_rubros_transp.TabIndex = 159;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "IdRubro";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 61;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Concepto";
            this.gridColumn2.FieldName = "ru_descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 1103;
            // 
            // cmb_rubros_aliment
            // 
            this.cmb_rubros_aliment.EditValue = "";
            this.cmb_rubros_aliment.Location = new System.Drawing.Point(155, 71);
            this.cmb_rubros_aliment.Name = "cmb_rubros_aliment";
            this.cmb_rubros_aliment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_rubros_aliment.Properties.DisplayMember = "ru_descripcion";
            this.cmb_rubros_aliment.Properties.ValueMember = "IdRubro";
            this.cmb_rubros_aliment.Properties.View = this.gridView3;
            this.cmb_rubros_aliment.Size = new System.Drawing.Size(300, 20);
            this.cmb_rubros_aliment.TabIndex = 158;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_IdRubro,
            this.Col_ru_descripcion});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // Col_IdRubro
            // 
            this.Col_IdRubro.Caption = "Id";
            this.Col_IdRubro.FieldName = "IdRubro";
            this.Col_IdRubro.Name = "Col_IdRubro";
            this.Col_IdRubro.Visible = true;
            this.Col_IdRubro.VisibleIndex = 0;
            this.Col_IdRubro.Width = 61;
            // 
            // Col_ru_descripcion
            // 
            this.Col_ru_descripcion.Caption = "Concepto";
            this.Col_ru_descripcion.FieldName = "ru_descripcion";
            this.Col_ru_descripcion.Name = "Col_ru_descripcion";
            this.Col_ru_descripcion.Visible = true;
            this.Col_ru_descripcion.VisibleIndex = 1;
            this.Col_ru_descripcion.Width = 1103;
            // 
            // txt_num_horas_sab_dom
            // 
            this.txt_num_horas_sab_dom.Location = new System.Drawing.Point(384, 122);
            this.txt_num_horas_sab_dom.Name = "txt_num_horas_sab_dom";
            this.txt_num_horas_sab_dom.Size = new System.Drawing.Size(71, 20);
            this.txt_num_horas_sab_dom.TabIndex = 83;
            this.txt_num_horas_sab_dom.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // dtFechaSalida
            // 
            this.dtFechaSalida.EditValue = null;
            this.dtFechaSalida.Location = new System.Drawing.Point(353, 24);
            this.dtFechaSalida.Name = "dtFechaSalida";
            this.dtFechaSalida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaSalida.Properties.ReadOnly = true;
            this.dtFechaSalida.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFechaSalida.Size = new System.Drawing.Size(100, 20);
            this.dtFechaSalida.TabIndex = 79;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(234, 125);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(149, 13);
            this.labelControl5.TabIndex = 82;
            this.labelControl5.Text = "Horas Extra Feriado S/D (8/10)";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(155, 47);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(416, 20);
            this.txtnombre.TabIndex = 78;
            // 
            // txt_num_calculo_horas_extras
            // 
            this.txt_num_calculo_horas_extras.Location = new System.Drawing.Point(155, 122);
            this.txt_num_calculo_horas_extras.Name = "txt_num_calculo_horas_extras";
            this.txt_num_calculo_horas_extras.Size = new System.Drawing.Size(71, 20);
            this.txt_num_calculo_horas_extras.TabIndex = 81;
            this.txt_num_calculo_horas_extras.EditValueChanged += new System.EventHandler(this.txt_num_calculo_horas_extras_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(8, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(135, 13);
            this.labelControl4.TabIndex = 80;
            this.labelControl4.Text = "Calcular HE sobre (160/240)";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(155, 21);
            this.txtId.Name = "txtId";
            this.txtId.Properties.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(76, 20);
            this.txtId.TabIndex = 77;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 76;
            this.labelControl3.Text = "Nombre Grupo";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(243, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 13);
            this.labelControl2.TabIndex = 75;
            this.labelControl2.Text = "Fecha transaccion";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 74;
            this.labelControl1.Text = "Id Grupo";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.splitContainerControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 184);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(590, 183);
            this.groupControl2.TabIndex = 76;
            this.groupControl2.Text = "Parametros para el calculo de la variable";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 21);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.txt_valor_bono);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl10);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl_parametro_Variable);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(586, 160);
            this.splitContainerControl1.SplitterPosition = 26;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // txt_valor_bono
            // 
            this.txt_valor_bono.Location = new System.Drawing.Point(197, 3);
            this.txt_valor_bono.Name = "txt_valor_bono";
            this.txt_valor_bono.Size = new System.Drawing.Size(112, 20);
            this.txt_valor_bono.TabIndex = 167;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(10, 3);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(171, 13);
            this.labelControl10.TabIndex = 166;
            this.labelControl10.Text = "Bono para el calculo de la variable $";
            // 
            // gridControl_parametro_Variable
            // 
            this.gridControl_parametro_Variable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_parametro_Variable.Location = new System.Drawing.Point(0, 0);
            this.gridControl_parametro_Variable.MainView = this.gridView_parametro_Variable;
            this.gridControl_parametro_Variable.Name = "gridControl_parametro_Variable";
            this.gridControl_parametro_Variable.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_rubro_pago_variable,
            this.repositoryItemImageComboBox1});
            this.gridControl_parametro_Variable.Size = new System.Drawing.Size(586, 129);
            this.gridControl_parametro_Variable.TabIndex = 0;
            this.gridControl_parametro_Variable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_parametro_Variable});
            // 
            // gridView_parametro_Variable
            // 
            this.gridView_parametro_Variable.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Cool_IdRubro,
            this.Col_porcentaje_Pago,
            this.Col_icono_eliminar});
            this.gridView_parametro_Variable.GridControl = this.gridControl_parametro_Variable;
            this.gridView_parametro_Variable.Images = this.imageList1;
            this.gridView_parametro_Variable.Name = "gridView_parametro_Variable";
            this.gridView_parametro_Variable.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_parametro_Variable.OptionsView.ShowFooter = true;
            this.gridView_parametro_Variable.OptionsView.ShowGroupPanel = false;
            this.gridView_parametro_Variable.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_parametro_Variable_RowCellClick);
            // 
            // Cool_IdRubro
            // 
            this.Cool_IdRubro.Caption = "Rubro";
            this.Cool_IdRubro.ColumnEdit = this.cmb_rubro_pago_variable;
            this.Cool_IdRubro.FieldName = "cod_Pago_Variable";
            this.Cool_IdRubro.Name = "Cool_IdRubro";
            this.Cool_IdRubro.Visible = true;
            this.Cool_IdRubro.VisibleIndex = 1;
            this.Cool_IdRubro.Width = 951;
            // 
            // cmb_rubro_pago_variable
            // 
            this.cmb_rubro_pago_variable.AutoHeight = false;
            this.cmb_rubro_pago_variable.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_rubro_pago_variable.Name = "cmb_rubro_pago_variable";
            this.cmb_rubro_pago_variable.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_ru_descrip,
            this.Col_rub_codigo});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Col_ru_descrip
            // 
            this.Col_ru_descrip.Caption = "Rubro";
            this.Col_ru_descrip.FieldName = "nom_Pago_Variable";
            this.Col_ru_descrip.Name = "Col_ru_descrip";
            this.Col_ru_descrip.Visible = true;
            this.Col_ru_descrip.VisibleIndex = 1;
            this.Col_ru_descrip.Width = 1066;
            // 
            // Col_rub_codigo
            // 
            this.Col_rub_codigo.Caption = "Codigo";
            this.Col_rub_codigo.FieldName = "cod_Pago_Variable";
            this.Col_rub_codigo.Name = "Col_rub_codigo";
            this.Col_rub_codigo.Visible = true;
            this.Col_rub_codigo.VisibleIndex = 0;
            this.Col_rub_codigo.Width = 114;
            // 
            // Col_porcentaje_Pago
            // 
            this.Col_porcentaje_Pago.Caption = "% Calculo";
            this.Col_porcentaje_Pago.FieldName = "Porcentaje_calculo";
            this.Col_porcentaje_Pago.Name = "Col_porcentaje_Pago";
            this.Col_porcentaje_Pago.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Porcentaje_calculo", "n2")});
            this.Col_porcentaje_Pago.Visible = true;
            this.Col_porcentaje_Pago.VisibleIndex = 2;
            this.Col_porcentaje_Pago.Width = 184;
            // 
            // Col_icono_eliminar
            // 
            this.Col_icono_eliminar.Caption = "***";
            this.Col_icono_eliminar.ColumnEdit = this.repositoryItemImageComboBox1;
            this.Col_icono_eliminar.FieldName = "icono_eliminar";
            this.Col_icono_eliminar.Name = "Col_icono_eliminar";
            this.Col_icono_eliminar.OptionsColumn.AllowEdit = false;
            this.Col_icono_eliminar.Visible = true;
            this.Col_icono_eliminar.VisibleIndex = 0;
            this.Col_icono_eliminar.Width = 45;
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
            this.repositoryItemImageComboBox1.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "anular2_32.x32png.png");
            // 
            // frmRo_Grupo_empleado_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 367);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Grupo_empleado_Mant";
            this.Text = "Mantenimiento Grupo empleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRo_Grupo_empleado_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmRo_Grupo_empleado_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Valor_trans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Valor_alime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_rubros_transp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_rubros_aliment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_horas_sab_dom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSalida.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSalida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_calculo_horas_extras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor_bono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_parametro_Variable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_parametro_Variable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_rubro_pago_variable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dtFechaSalida;
        private DevExpress.XtraEditors.TextEdit txtnombre;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_num_calculo_horas_extras;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_num_horas_sab_dom;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_rubros_transp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_rubros_aliment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdRubro;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ru_descripcion;
        private DevExpress.XtraEditors.TextEdit txt_Valor_trans;
        private DevExpress.XtraEditors.TextEdit txt_Valor_alime;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.TextEdit txt_valor_bono;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraGrid.GridControl gridControl_parametro_Variable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_parametro_Variable;
        private DevExpress.XtraGrid.Columns.GridColumn Cool_IdRubro;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_rubro_pago_variable;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Col_porcentaje_Pago;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ru_descrip;
        private DevExpress.XtraGrid.Columns.GridColumn Col_rub_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_icono_eliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.ImageList imageList1;

    }
}