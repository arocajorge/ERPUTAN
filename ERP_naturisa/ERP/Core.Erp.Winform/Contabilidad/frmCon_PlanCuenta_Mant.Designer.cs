namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_PlanCuenta_Mant
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
            this.cmb_nivel = new System.Windows.Forms.ComboBox();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_grupo_cble = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_naturaleza = new System.Windows.Forms.ComboBox();
            this.cmb_cuenta_padre = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nom_cta = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_es_cta_movi = new DevExpress.XtraEditors.CheckEdit();
            this.chk_esta_cta_afecta_flujo = new DevExpress.XtraEditors.CheckEdit();
            this.chk_estado = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Grupo_x_tipo_gasto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_accion_tipo_gasto = new DevExpress.XtraEditors.DropDownButton();
            this.Menu_accion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCblePadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNivelCta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGrupoCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cuenta_padre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_es_cta_movi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_esta_cta_afecta_flujo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_estado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Grupo_x_tipo_gasto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.Menu_accion.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_nivel
            // 
            this.cmb_nivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nivel.Enabled = false;
            this.cmb_nivel.FormattingEnabled = true;
            this.cmb_nivel.Location = new System.Drawing.Point(616, 131);
            this.cmb_nivel.Name = "cmb_nivel";
            this.cmb_nivel.Size = new System.Drawing.Size(121, 21);
            this.cmb_nivel.TabIndex = 6;
            this.cmb_nivel.SelectedIndexChanged += new System.EventHandler(this.cmb_nivel_SelectedIndexChanged);
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(317, 16);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(157, 20);
            this.lblAnulado.TabIndex = 20;
            this.lblAnulado.Text = "*****ANULADO****";
            this.lblAnulado.Visible = false;
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(649, 79);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(191, 20);
            this.txt_clave.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Codigo Alterno/Clave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Grupo Contable:";
            // 
            // cmb_grupo_cble
            // 
            this.cmb_grupo_cble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_grupo_cble.FormattingEnabled = true;
            this.cmb_grupo_cble.Location = new System.Drawing.Point(384, 131);
            this.cmb_grupo_cble.Name = "cmb_grupo_cble";
            this.cmb_grupo_cble.Size = new System.Drawing.Size(175, 21);
            this.cmb_grupo_cble.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nivel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Naturaleza:";
            // 
            // cmb_naturaleza
            // 
            this.cmb_naturaleza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_naturaleza.FormattingEnabled = true;
            this.cmb_naturaleza.Location = new System.Drawing.Point(140, 131);
            this.cmb_naturaleza.Name = "cmb_naturaleza";
            this.cmb_naturaleza.Size = new System.Drawing.Size(113, 21);
            this.cmb_naturaleza.TabIndex = 4;
            // 
            // cmb_cuenta_padre
            // 
            this.cmb_cuenta_padre.Location = new System.Drawing.Point(140, 53);
            this.cmb_cuenta_padre.Name = "cmb_cuenta_padre";
            this.cmb_cuenta_padre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_cuenta_padre.Properties.DisplayMember = "pc_Cuenta2";
            this.cmb_cuenta_padre.Properties.ValueMember = "IdCtaCble";
            this.cmb_cuenta_padre.Properties.View = this.searchLookUpEdit1View;
            this.cmb_cuenta_padre.Size = new System.Drawing.Size(700, 20);
            this.cmb_cuenta_padre.TabIndex = 0;
            this.cmb_cuenta_padre.EditValueChanged += new System.EventHandler(this.cmb_cuenta_padre_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCtaCble,
            this.colpc_Cuenta,
            this.colIdCtaCblePadre,
            this.colIdNivelCta,
            this.colIdGrupoCble,
            this.colCuentaPadre,
            this.ColClave});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cuenta Padre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Cuenta:";
            // 
            // txt_nom_cta
            // 
            this.txt_nom_cta.Location = new System.Drawing.Point(140, 105);
            this.txt_nom_cta.Name = "txt_nom_cta";
            this.txt_nom_cta.Size = new System.Drawing.Size(700, 20);
            this.txt_nom_cta.TabIndex = 3;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(140, 79);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(136, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // chk_es_cta_movi
            // 
            this.chk_es_cta_movi.Location = new System.Drawing.Point(138, 185);
            this.chk_es_cta_movi.Name = "chk_es_cta_movi";
            this.chk_es_cta_movi.Properties.Caption = "Es Una Cuenta de Movimiento";
            this.chk_es_cta_movi.Size = new System.Drawing.Size(172, 19);
            this.chk_es_cta_movi.TabIndex = 21;
            // 
            // chk_esta_cta_afecta_flujo
            // 
            this.chk_esta_cta_afecta_flujo.Location = new System.Drawing.Point(138, 210);
            this.chk_esta_cta_afecta_flujo.Name = "chk_esta_cta_afecta_flujo";
            this.chk_esta_cta_afecta_flujo.Properties.Caption = "Es Una Cuenta que afecta al flujo";
            this.chk_esta_cta_afecta_flujo.Size = new System.Drawing.Size(187, 19);
            this.chk_esta_cta_afecta_flujo.TabIndex = 22;
            // 
            // chk_estado
            // 
            this.chk_estado.Location = new System.Drawing.Point(319, 185);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Properties.Caption = "Activo";
            this.chk_estado.Size = new System.Drawing.Size(75, 19);
            this.chk_estado.TabIndex = 23;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_accion_tipo_gasto);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.cmb_Grupo_x_tipo_gasto);
            this.panelControl1.Controls.Add(this.chk_estado);
            this.panelControl1.Controls.Add(this.lblAnulado);
            this.panelControl1.Controls.Add(this.chk_esta_cta_afecta_flujo);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.chk_es_cta_movi);
            this.panelControl1.Controls.Add(this.txt_codigo);
            this.panelControl1.Controls.Add(this.cmb_nivel);
            this.panelControl1.Controls.Add(this.txt_nom_cta);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txt_clave);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.cmb_cuenta_padre);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.cmb_naturaleza);
            this.panelControl1.Controls.Add(this.cmb_grupo_cble);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(871, 253);
            this.panelControl1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Grupo por tipo de gasto:";
            // 
            // cmb_Grupo_x_tipo_gasto
            // 
            this.cmb_Grupo_x_tipo_gasto.Location = new System.Drawing.Point(140, 158);
            this.cmb_Grupo_x_tipo_gasto.Name = "cmb_Grupo_x_tipo_gasto";
            this.cmb_Grupo_x_tipo_gasto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Grupo_x_tipo_gasto.Properties.View = this.gridView1;
            this.cmb_Grupo_x_tipo_gasto.Size = new System.Drawing.Size(419, 20);
            this.cmb_Grupo_x_tipo_gasto.TabIndex = 24;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btn_accion_tipo_gasto
            // 
            this.btn_accion_tipo_gasto.ContextMenuStrip = this.Menu_accion;
            this.btn_accion_tipo_gasto.Image = global::Core.Erp.Winform.Properties.Resources.editar1_16x16;
            this.btn_accion_tipo_gasto.Location = new System.Drawing.Point(565, 156);
            this.btn_accion_tipo_gasto.Name = "btn_accion_tipo_gasto";
            this.btn_accion_tipo_gasto.ShowArrowButton = false;
            this.btn_accion_tipo_gasto.Size = new System.Drawing.Size(34, 23);
            this.btn_accion_tipo_gasto.TabIndex = 26;
            this.btn_accion_tipo_gasto.Click += new System.EventHandler(this.btn_accion_tipo_gasto_Click);
            // 
            // Menu_accion
            // 
            this.Menu_accion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Nuevo,
            this.btn_Modificar,
            this.btnConsultar});
            this.Menu_accion.Name = "Menu_accion";
            this.Menu_accion.Size = new System.Drawing.Size(126, 70);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Image = global::Core.Erp.Winform.Properties.Resources.nuevo_32x32;
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(125, 22);
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Image = global::Core.Erp.Winform.Properties.Resources.monificar_32x32;
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(125, 22);
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::Core.Erp.Winform.Properties.Resources.consultar_32x32;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(125, 22);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdTipo_Gasto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 64;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tipo de gasto";
            this.gridColumn2.FieldName = "nom_tipo_Gasto";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 381;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "nivel";
            this.gridColumn3.FieldName = "nivel";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 65;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.Caption = "IdCtaCble";
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.VisibleIndex = 1;
            this.colIdCtaCble.Width = 167;
            // 
            // colpc_Cuenta
            // 
            this.colpc_Cuenta.Caption = "Cuenta";
            this.colpc_Cuenta.FieldName = "pc_Cuenta";
            this.colpc_Cuenta.Name = "colpc_Cuenta";
            this.colpc_Cuenta.Visible = true;
            this.colpc_Cuenta.VisibleIndex = 2;
            this.colpc_Cuenta.Width = 448;
            // 
            // colIdCtaCblePadre
            // 
            this.colIdCtaCblePadre.Caption = "IdCtaCblePadre";
            this.colIdCtaCblePadre.FieldName = "IdCtaCblePadre";
            this.colIdCtaCblePadre.Name = "colIdCtaCblePadre";
            this.colIdCtaCblePadre.Visible = true;
            this.colIdCtaCblePadre.VisibleIndex = 3;
            this.colIdCtaCblePadre.Width = 127;
            // 
            // colIdNivelCta
            // 
            this.colIdNivelCta.Caption = "IdNivelCta";
            this.colIdNivelCta.FieldName = "IdNivelCta";
            this.colIdNivelCta.Name = "colIdNivelCta";
            this.colIdNivelCta.Visible = true;
            this.colIdNivelCta.VisibleIndex = 5;
            this.colIdNivelCta.Width = 83;
            // 
            // colIdGrupoCble
            // 
            this.colIdGrupoCble.Caption = "IdGrupoCble";
            this.colIdGrupoCble.FieldName = "IdGrupoCble";
            this.colIdGrupoCble.Name = "colIdGrupoCble";
            this.colIdGrupoCble.Width = 96;
            // 
            // colCuentaPadre
            // 
            this.colCuentaPadre.Caption = "CuentaPadre";
            this.colCuentaPadre.FieldName = "CuentaPadre";
            this.colCuentaPadre.Name = "colCuentaPadre";
            this.colCuentaPadre.Visible = true;
            this.colCuentaPadre.VisibleIndex = 4;
            this.colCuentaPadre.Width = 250;
            // 
            // ColClave
            // 
            this.ColClave.Caption = "Clave";
            this.ColClave.FieldName = "pc_clave_corta";
            this.ColClave.Name = "ColClave";
            this.ColClave.Visible = true;
            this.ColClave.VisibleIndex = 0;
            this.ColClave.Width = 105;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 282);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(871, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(871, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
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
            // 
            // frmCon_PlanCuenta_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 308);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCon_PlanCuenta_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Cuentas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCon_PlanCuenta_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmCon_PlanCuenta_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cuenta_padre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_es_cta_movi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_esta_cta_afecta_flujo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_estado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Grupo_x_tipo_gasto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.Menu_accion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_grupo_cble;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_naturaleza;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_cuenta_padre;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nom_cta;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCblePadre;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNivelCta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupoCble;
        private System.Windows.Forms.ComboBox cmb_nivel;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaPadre;
        private DevExpress.XtraEditors.CheckEdit chk_es_cta_movi;
        private DevExpress.XtraEditors.CheckEdit chk_esta_cta_afecta_flujo;
        private DevExpress.XtraEditors.CheckEdit chk_estado;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn ColClave;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_Grupo_x_tipo_gasto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.DropDownButton btn_accion_tipo_gasto;
        private System.Windows.Forms.ContextMenuStrip Menu_accion;
        private System.Windows.Forms.ToolStripMenuItem btn_Nuevo;
        private System.Windows.Forms.ToolStripMenuItem btn_Modificar;
        private System.Windows.Forms.ToolStripMenuItem btnConsultar;
    }
}