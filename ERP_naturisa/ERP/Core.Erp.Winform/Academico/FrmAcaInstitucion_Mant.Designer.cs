namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaInstitucion_Mant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcaInstitucion_Mant));
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.TabControlInstitucion = new DevExpress.XtraTab.XtraTabControl();
            this.tabIsntitucion = new DevExpress.XtraTab.XtraTabPage();
            this.txtruc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.ucGe_Paprovciu = new Core.Erp.Winform.Controles.UCGe_PaisProvinciaCiudad();
            this.txtSitioWeb = new DevExpress.XtraEditors.TextEdit();
            this.txtResolucionAcademica = new DevExpress.XtraEditors.TextEdit();
            this.txtSecretario = new DevExpress.XtraEditors.TextEdit();
            this.txtCoordinador = new DevExpress.XtraEditors.TextEdit();
            this.txtRector = new DevExpress.XtraEditors.TextEdit();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigoInstitucion = new DevExpress.XtraEditors.TextEdit();
            this.txtIdInstitucion = new DevExpress.XtraEditors.TextEdit();
            this.lblCodInstitucion = new DevExpress.XtraEditors.LabelControl();
            this.lblIdInstitucion = new DevExpress.XtraEditors.LabelControl();
            this.chkEstado = new DevExpress.XtraEditors.CheckEdit();
            this.lblSitioWeb = new DevExpress.XtraEditors.LabelControl();
            this.lblResolucionAcademica = new DevExpress.XtraEditors.LabelControl();
            this.lblSecretario = new DevExpress.XtraEditors.LabelControl();
            this.lblCoordinador = new DevExpress.XtraEditors.LabelControl();
            this.lblRector = new DevExpress.XtraEditors.LabelControl();
            this.lblFax = new DevExpress.XtraEditors.LabelControl();
            this.lblTelefono = new DevExpress.XtraEditors.LabelControl();
            this.lblDireccion = new DevExpress.XtraEditors.LabelControl();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccion = new DevExpress.XtraEditors.MemoEdit();
            this.tabSede = new DevExpress.XtraTab.XtraTabPage();
            this.treeListSede = new DevExpress.XtraTreeList.TreeList();
            this.colIdEmpresa = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdInstitucion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCodInstitucion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNombre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDireccion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTelefono = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFax = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRector = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCoordinador = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSecretario = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colResolucion_Academica = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSitioWeb = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colEstado = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLogo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colUsuarioCreacion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colUsuarioModificacion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFechaCreacion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFechaMoficacion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colpaisInfo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colciudadInfo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colprovinciaInfo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnTipo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Menu_Man = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.anularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu_Mant = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nuevaSedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarSedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularSedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddJornada = new System.Windows.Forms.ToolStripDropDownButton();
            this.nuevaJornada = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarJornada = new System.Windows.Forms.ToolStripMenuItem();
            this.anularJornadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nuevaSecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarSecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularSecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nuevoCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nuevoParaleloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarParaleloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularParaleloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbprovinciaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbpaisInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acaInstitucionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TabControlInstitucion)).BeginInit();
            this.TabControlInstitucion.SuspendLayout();
            this.tabIsntitucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtruc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSitioWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResolucionAcademica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecretario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoordinador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoInstitucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdInstitucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            this.tabSede.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListSede)).BeginInit();
            this.Menu_Man.SuspendLayout();
            this.toolStripMenu_Mant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbprovinciaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpaisInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionInfoBindingSource)).BeginInit();
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
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1033, 36);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
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
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 493);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1033, 36);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // TabControlInstitucion
            // 
            this.TabControlInstitucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlInstitucion.Location = new System.Drawing.Point(0, 36);
            this.TabControlInstitucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControlInstitucion.Name = "TabControlInstitucion";
            this.TabControlInstitucion.SelectedTabPage = this.tabIsntitucion;
            this.TabControlInstitucion.Size = new System.Drawing.Size(1033, 457);
            this.TabControlInstitucion.TabIndex = 2;
            this.TabControlInstitucion.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabIsntitucion,
            this.tabSede});
            // 
            // tabIsntitucion
            // 
            this.tabIsntitucion.Controls.Add(this.txtruc);
            this.tabIsntitucion.Controls.Add(this.labelControl1);
            this.tabIsntitucion.Controls.Add(this.lblAnulado);
            this.tabIsntitucion.Controls.Add(this.ucGe_Paprovciu);
            this.tabIsntitucion.Controls.Add(this.txtSitioWeb);
            this.tabIsntitucion.Controls.Add(this.txtResolucionAcademica);
            this.tabIsntitucion.Controls.Add(this.txtSecretario);
            this.tabIsntitucion.Controls.Add(this.txtCoordinador);
            this.tabIsntitucion.Controls.Add(this.txtRector);
            this.tabIsntitucion.Controls.Add(this.txtFax);
            this.tabIsntitucion.Controls.Add(this.txtTelefono);
            this.tabIsntitucion.Controls.Add(this.txtNombre);
            this.tabIsntitucion.Controls.Add(this.txtCodigoInstitucion);
            this.tabIsntitucion.Controls.Add(this.txtIdInstitucion);
            this.tabIsntitucion.Controls.Add(this.lblCodInstitucion);
            this.tabIsntitucion.Controls.Add(this.lblIdInstitucion);
            this.tabIsntitucion.Controls.Add(this.chkEstado);
            this.tabIsntitucion.Controls.Add(this.lblSitioWeb);
            this.tabIsntitucion.Controls.Add(this.lblResolucionAcademica);
            this.tabIsntitucion.Controls.Add(this.lblSecretario);
            this.tabIsntitucion.Controls.Add(this.lblCoordinador);
            this.tabIsntitucion.Controls.Add(this.lblRector);
            this.tabIsntitucion.Controls.Add(this.lblFax);
            this.tabIsntitucion.Controls.Add(this.lblTelefono);
            this.tabIsntitucion.Controls.Add(this.lblDireccion);
            this.tabIsntitucion.Controls.Add(this.lblNombre);
            this.tabIsntitucion.Controls.Add(this.txtDireccion);
            this.tabIsntitucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabIsntitucion.Name = "tabIsntitucion";
            this.tabIsntitucion.Size = new System.Drawing.Size(1027, 426);
            this.tabIsntitucion.Text = "Información de la Insitución";
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(180, 81);
            this.txtruc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(184, 22);
            this.txtruc.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 85);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 16);
            this.labelControl1.TabIndex = 46;
            this.labelControl1.Text = "Ruc:";
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(739, 385);
            this.lblAnulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(170, 25);
            this.lblAnulado.TabIndex = 45;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // ucGe_Paprovciu
            // 
            this.ucGe_Paprovciu.Location = new System.Drawing.Point(648, 21);
            this.ucGe_Paprovciu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_Paprovciu.Name = "ucGe_Paprovciu";
            this.ucGe_Paprovciu.Size = new System.Drawing.Size(368, 114);
            this.ucGe_Paprovciu.TabIndex = 12;
            this.ucGe_Paprovciu.Visible_combo_parroquia = false;
            // 
            // txtSitioWeb
            // 
            this.txtSitioWeb.Location = new System.Drawing.Point(180, 351);
            this.txtSitioWeb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSitioWeb.Name = "txtSitioWeb";
            this.txtSitioWeb.Size = new System.Drawing.Size(823, 22);
            this.txtSitioWeb.TabIndex = 11;
            // 
            // txtResolucionAcademica
            // 
            this.txtResolucionAcademica.Location = new System.Drawing.Point(180, 319);
            this.txtResolucionAcademica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResolucionAcademica.Name = "txtResolucionAcademica";
            this.txtResolucionAcademica.Size = new System.Drawing.Size(823, 22);
            this.txtResolucionAcademica.TabIndex = 10;
            // 
            // txtSecretario
            // 
            this.txtSecretario.Location = new System.Drawing.Point(180, 287);
            this.txtSecretario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSecretario.Name = "txtSecretario";
            this.txtSecretario.Size = new System.Drawing.Size(823, 22);
            this.txtSecretario.TabIndex = 9;
            // 
            // txtCoordinador
            // 
            this.txtCoordinador.Location = new System.Drawing.Point(180, 256);
            this.txtCoordinador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCoordinador.Name = "txtCoordinador";
            this.txtCoordinador.Size = new System.Drawing.Size(823, 22);
            this.txtCoordinador.TabIndex = 8;
            // 
            // txtRector
            // 
            this.txtRector.Location = new System.Drawing.Point(180, 224);
            this.txtRector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRector.Name = "txtRector";
            this.txtRector.Size = new System.Drawing.Size(823, 22);
            this.txtRector.TabIndex = 7;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(695, 192);
            this.txtFax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(308, 22);
            this.txtFax.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(180, 192);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(308, 22);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 111);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(465, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtCodigoInstitucion
            // 
            this.txtCodigoInstitucion.Location = new System.Drawing.Point(180, 49);
            this.txtCodigoInstitucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoInstitucion.Name = "txtCodigoInstitucion";
            this.txtCodigoInstitucion.Size = new System.Drawing.Size(184, 22);
            this.txtCodigoInstitucion.TabIndex = 1;
            // 
            // txtIdInstitucion
            // 
            this.txtIdInstitucion.Enabled = false;
            this.txtIdInstitucion.Location = new System.Drawing.Point(180, 17);
            this.txtIdInstitucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdInstitucion.Name = "txtIdInstitucion";
            this.txtIdInstitucion.Size = new System.Drawing.Size(184, 22);
            this.txtIdInstitucion.TabIndex = 0;
            // 
            // lblCodInstitucion
            // 
            this.lblCodInstitucion.Location = new System.Drawing.Point(27, 58);
            this.lblCodInstitucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCodInstitucion.Name = "lblCodInstitucion";
            this.lblCodInstitucion.Size = new System.Drawing.Size(106, 16);
            this.lblCodInstitucion.TabIndex = 12;
            this.lblCodInstitucion.Text = "Código Institución:";
            // 
            // lblIdInstitucion
            // 
            this.lblIdInstitucion.Location = new System.Drawing.Point(27, 26);
            this.lblIdInstitucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblIdInstitucion.Name = "lblIdInstitucion";
            this.lblIdInstitucion.Size = new System.Drawing.Size(78, 16);
            this.lblIdInstitucion.TabIndex = 11;
            this.lblIdInstitucion.Text = "Id Institución:";
            // 
            // chkEstado
            // 
            this.chkEstado.Location = new System.Drawing.Point(928, 383);
            this.chkEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Properties.Caption = "Estado";
            this.chkEstado.Size = new System.Drawing.Size(75, 21);
            this.chkEstado.TabIndex = 10;
            // 
            // lblSitioWeb
            // 
            this.lblSitioWeb.Location = new System.Drawing.Point(27, 359);
            this.lblSitioWeb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSitioWeb.Name = "lblSitioWeb";
            this.lblSitioWeb.Size = new System.Drawing.Size(60, 16);
            this.lblSitioWeb.TabIndex = 9;
            this.lblSitioWeb.Text = "Sitio Web:";
            // 
            // lblResolucionAcademica
            // 
            this.lblResolucionAcademica.Location = new System.Drawing.Point(27, 327);
            this.lblResolucionAcademica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblResolucionAcademica.Name = "lblResolucionAcademica";
            this.lblResolucionAcademica.Size = new System.Drawing.Size(132, 16);
            this.lblResolucionAcademica.TabIndex = 8;
            this.lblResolucionAcademica.Text = "Resolución Academica:";
            // 
            // lblSecretario
            // 
            this.lblSecretario.Location = new System.Drawing.Point(27, 295);
            this.lblSecretario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSecretario.Name = "lblSecretario";
            this.lblSecretario.Size = new System.Drawing.Size(64, 16);
            this.lblSecretario.TabIndex = 7;
            this.lblSecretario.Text = "Secretario:";
            // 
            // lblCoordinador
            // 
            this.lblCoordinador.Location = new System.Drawing.Point(27, 260);
            this.lblCoordinador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCoordinador.Name = "lblCoordinador";
            this.lblCoordinador.Size = new System.Drawing.Size(75, 16);
            this.lblCoordinador.TabIndex = 6;
            this.lblCoordinador.Text = "Coordinador:";
            // 
            // lblRector
            // 
            this.lblRector.Location = new System.Drawing.Point(27, 233);
            this.lblRector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblRector.Name = "lblRector";
            this.lblRector.Size = new System.Drawing.Size(42, 16);
            this.lblRector.TabIndex = 5;
            this.lblRector.Text = "Rector:";
            // 
            // lblFax
            // 
            this.lblFax.Location = new System.Drawing.Point(624, 196);
            this.lblFax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(25, 16);
            this.lblFax.TabIndex = 4;
            this.lblFax.Text = "Fax:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(27, 196);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 16);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(27, 146);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 16);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(27, 119);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(180, 143);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(823, 42);
            this.txtDireccion.TabIndex = 4;
            // 
            // tabSede
            // 
            this.tabSede.Controls.Add(this.treeListSede);
            this.tabSede.Controls.Add(this.toolStripMenu_Mant);
            this.tabSede.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSede.Name = "tabSede";
            this.tabSede.Size = new System.Drawing.Size(1027, 426);
            this.tabSede.Text = "Sede";
            // 
            // treeListSede
            // 
            this.treeListSede.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIdEmpresa,
            this.colIdInstitucion,
            this.colCodInstitucion,
            this.colNombre,
            this.colDireccion,
            this.colTelefono,
            this.colFax,
            this.colRector,
            this.colCoordinador,
            this.colSecretario,
            this.colResolucion_Academica,
            this.colSitioWeb,
            this.colEstado,
            this.colLogo,
            this.colUsuarioCreacion,
            this.colUsuarioModificacion,
            this.colFechaCreacion,
            this.colFechaMoficacion,
            this.colpaisInfo,
            this.colciudadInfo,
            this.colprovinciaInfo,
            this.treeListColumnTipo});
            this.treeListSede.ContextMenuStrip = this.Menu_Man;
            this.treeListSede.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListSede.Location = new System.Drawing.Point(0, 27);
            this.treeListSede.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeListSede.Name = "treeListSede";
            this.treeListSede.OptionsPrint.UsePrintStyles = true;
            this.treeListSede.ParentFieldName = "IdPadre";
            this.treeListSede.Size = new System.Drawing.Size(1027, 399);
            this.treeListSede.TabIndex = 47;
            this.treeListSede.AfterFocusNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeListSede_AfterFocusNode);
            this.treeListSede.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeListSede_MouseUp);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            this.colIdEmpresa.Width = 35;
            // 
            // colIdInstitucion
            // 
            this.colIdInstitucion.FieldName = "IdInstitucion";
            this.colIdInstitucion.Name = "colIdInstitucion";
            this.colIdInstitucion.OptionsColumn.AllowEdit = false;
            this.colIdInstitucion.Width = 35;
            // 
            // colCodInstitucion
            // 
            this.colCodInstitucion.FieldName = "CodInstitucion";
            this.colCodInstitucion.Name = "colCodInstitucion";
            this.colCodInstitucion.OptionsColumn.AllowEdit = false;
            this.colCodInstitucion.Width = 35;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Descripción";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.MinWidth = 88;
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            this.colNombre.Width = 639;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.OptionsColumn.AllowEdit = false;
            this.colDireccion.Width = 35;
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.OptionsColumn.AllowEdit = false;
            this.colTelefono.Width = 36;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            this.colFax.Width = 36;
            // 
            // colRector
            // 
            this.colRector.FieldName = "Rector";
            this.colRector.Name = "colRector";
            this.colRector.OptionsColumn.AllowEdit = false;
            this.colRector.Width = 36;
            // 
            // colCoordinador
            // 
            this.colCoordinador.FieldName = "Coordinador";
            this.colCoordinador.Name = "colCoordinador";
            this.colCoordinador.OptionsColumn.AllowEdit = false;
            this.colCoordinador.Width = 36;
            // 
            // colSecretario
            // 
            this.colSecretario.FieldName = "Secretario";
            this.colSecretario.Name = "colSecretario";
            this.colSecretario.OptionsColumn.AllowEdit = false;
            this.colSecretario.Width = 36;
            // 
            // colResolucion_Academica
            // 
            this.colResolucion_Academica.FieldName = "Resolucion_Academica";
            this.colResolucion_Academica.Name = "colResolucion_Academica";
            this.colResolucion_Academica.OptionsColumn.AllowEdit = false;
            this.colResolucion_Academica.Width = 36;
            // 
            // colSitioWeb
            // 
            this.colSitioWeb.FieldName = "SitioWeb";
            this.colSitioWeb.Name = "colSitioWeb";
            this.colSitioWeb.OptionsColumn.AllowEdit = false;
            this.colSitioWeb.Width = 36;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Width = 36;
            // 
            // colLogo
            // 
            this.colLogo.FieldName = "Logo";
            this.colLogo.Name = "colLogo";
            this.colLogo.OptionsColumn.AllowEdit = false;
            this.colLogo.Width = 36;
            // 
            // colUsuarioCreacion
            // 
            this.colUsuarioCreacion.FieldName = "UsuarioCreacion";
            this.colUsuarioCreacion.Name = "colUsuarioCreacion";
            this.colUsuarioCreacion.OptionsColumn.AllowEdit = false;
            this.colUsuarioCreacion.Width = 36;
            // 
            // colUsuarioModificacion
            // 
            this.colUsuarioModificacion.FieldName = "UsuarioModificacion";
            this.colUsuarioModificacion.Name = "colUsuarioModificacion";
            this.colUsuarioModificacion.OptionsColumn.AllowEdit = false;
            this.colUsuarioModificacion.Width = 36;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.OptionsColumn.AllowEdit = false;
            this.colFechaCreacion.Width = 36;
            // 
            // colFechaMoficacion
            // 
            this.colFechaMoficacion.FieldName = "FechaMoficacion";
            this.colFechaMoficacion.Name = "colFechaMoficacion";
            this.colFechaMoficacion.OptionsColumn.AllowEdit = false;
            this.colFechaMoficacion.Width = 36;
            // 
            // colpaisInfo
            // 
            this.colpaisInfo.FieldName = "paisInfo";
            this.colpaisInfo.Name = "colpaisInfo";
            this.colpaisInfo.OptionsColumn.AllowEdit = false;
            this.colpaisInfo.Width = 36;
            // 
            // colciudadInfo
            // 
            this.colciudadInfo.FieldName = "ciudadInfo";
            this.colciudadInfo.Name = "colciudadInfo";
            this.colciudadInfo.OptionsColumn.AllowEdit = false;
            this.colciudadInfo.Width = 36;
            // 
            // colprovinciaInfo
            // 
            this.colprovinciaInfo.FieldName = "provinciaInfo";
            this.colprovinciaInfo.Name = "colprovinciaInfo";
            this.colprovinciaInfo.OptionsColumn.AllowEdit = false;
            this.colprovinciaInfo.Width = 36;
            // 
            // treeListColumnTipo
            // 
            this.treeListColumnTipo.Caption = "Tipo ";
            this.treeListColumnTipo.FieldName = "Tipo";
            this.treeListColumnTipo.Name = "treeListColumnTipo";
            this.treeListColumnTipo.Visible = true;
            this.treeListColumnTipo.VisibleIndex = 1;
            this.treeListColumnTipo.Width = 112;
            // 
            // Menu_Man
            // 
            this.Menu_Man.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.btn_modificar,
            this.anularToolStripMenuItem});
            this.Menu_Man.Name = "Menu_Man";
            this.Menu_Man.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu_Man.Size = new System.Drawing.Size(143, 76);
            this.Menu_Man.Text = "Sede";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(142, 24);
            this.btn_nuevo.Text = "Nueva";
            this.btn_nuevo.Click += new System.EventHandler(this.nuevToolStripMenuItem_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(142, 24);
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // anularToolStripMenuItem
            // 
            this.anularToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anularToolStripMenuItem.Image")));
            this.anularToolStripMenuItem.Name = "anularToolStripMenuItem";
            this.anularToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.anularToolStripMenuItem.Text = "Anular";
            this.anularToolStripMenuItem.Click += new System.EventHandler(this.anularToolStripMenuItem_Click);
            // 
            // toolStripMenu_Mant
            // 
            this.toolStripMenu_Mant.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.tsddJornada,
            this.toolStripSeparator2,
            this.toolStripDropDownButton3,
            this.toolStripSeparator3,
            this.toolStripDropDownButton4,
            this.toolStripSeparator4,
            this.toolStripDropDownButton5});
            this.toolStripMenu_Mant.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu_Mant.Name = "toolStripMenu_Mant";
            this.toolStripMenu_Mant.Size = new System.Drawing.Size(1027, 27);
            this.toolStripMenu_Mant.TabIndex = 0;
            this.toolStripMenu_Mant.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaSedeToolStripMenuItem,
            this.modificarSedeToolStripMenuItem,
            this.anularSedeToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(71, 24);
            this.toolStripDropDownButton1.Text = "Sede";
            // 
            // nuevaSedeToolStripMenuItem
            // 
            this.nuevaSedeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevaSedeToolStripMenuItem.Image")));
            this.nuevaSedeToolStripMenuItem.Name = "nuevaSedeToolStripMenuItem";
            this.nuevaSedeToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.nuevaSedeToolStripMenuItem.Text = "Nueva Sede";
            this.nuevaSedeToolStripMenuItem.Click += new System.EventHandler(this.nuevaSedeToolStripMenuItem_Click);
            // 
            // modificarSedeToolStripMenuItem
            // 
            this.modificarSedeToolStripMenuItem.Checked = true;
            this.modificarSedeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modificarSedeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarSedeToolStripMenuItem.Image")));
            this.modificarSedeToolStripMenuItem.Name = "modificarSedeToolStripMenuItem";
            this.modificarSedeToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.modificarSedeToolStripMenuItem.Text = "Modificar Sede";
            this.modificarSedeToolStripMenuItem.Click += new System.EventHandler(this.modificarSedeToolStripMenuItem_Click);
            // 
            // anularSedeToolStripMenuItem
            // 
            this.anularSedeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anularSedeToolStripMenuItem.Image")));
            this.anularSedeToolStripMenuItem.Name = "anularSedeToolStripMenuItem";
            this.anularSedeToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.anularSedeToolStripMenuItem.Text = "Anular Sede";
            this.anularSedeToolStripMenuItem.Click += new System.EventHandler(this.anularSedeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsddJornada
            // 
            this.tsddJornada.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaJornada,
            this.modificarJornada,
            this.anularJornadaToolStripMenuItem});
            this.tsddJornada.Image = ((System.Drawing.Image)(resources.GetObject("tsddJornada.Image")));
            this.tsddJornada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddJornada.Name = "tsddJornada";
            this.tsddJornada.Size = new System.Drawing.Size(90, 24);
            this.tsddJornada.Text = "Jornada";
            // 
            // nuevaJornada
            // 
            this.nuevaJornada.Image = ((System.Drawing.Image)(resources.GetObject("nuevaJornada.Image")));
            this.nuevaJornada.Name = "nuevaJornada";
            this.nuevaJornada.Size = new System.Drawing.Size(198, 24);
            this.nuevaJornada.Text = "Nueva Jornada";
            this.nuevaJornada.Click += new System.EventHandler(this.nuevaJornada_Click);
            // 
            // modificarJornada
            // 
            this.modificarJornada.Image = ((System.Drawing.Image)(resources.GetObject("modificarJornada.Image")));
            this.modificarJornada.Name = "modificarJornada";
            this.modificarJornada.Size = new System.Drawing.Size(198, 24);
            this.modificarJornada.Text = "Modificar Jornada";
            this.modificarJornada.Click += new System.EventHandler(this.modificarJornada_Click);
            // 
            // anularJornadaToolStripMenuItem
            // 
            this.anularJornadaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anularJornadaToolStripMenuItem.Image")));
            this.anularJornadaToolStripMenuItem.Name = "anularJornadaToolStripMenuItem";
            this.anularJornadaToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.anularJornadaToolStripMenuItem.Text = "Anular Jornada";
            this.anularJornadaToolStripMenuItem.Click += new System.EventHandler(this.anularJornadaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaSecciónToolStripMenuItem,
            this.modificarSecciónToolStripMenuItem,
            this.anularSecciónToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(89, 24);
            this.toolStripDropDownButton3.Text = "Sección";
            // 
            // nuevaSecciónToolStripMenuItem
            // 
            this.nuevaSecciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevaSecciónToolStripMenuItem.Image")));
            this.nuevaSecciónToolStripMenuItem.Name = "nuevaSecciónToolStripMenuItem";
            this.nuevaSecciónToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.nuevaSecciónToolStripMenuItem.Text = "Nueva Sección";
            this.nuevaSecciónToolStripMenuItem.Click += new System.EventHandler(this.nuevaSecciónToolStripMenuItem_Click);
            // 
            // modificarSecciónToolStripMenuItem
            // 
            this.modificarSecciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarSecciónToolStripMenuItem.Image")));
            this.modificarSecciónToolStripMenuItem.Name = "modificarSecciónToolStripMenuItem";
            this.modificarSecciónToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.modificarSecciónToolStripMenuItem.Text = "Modificar Sección";
            this.modificarSecciónToolStripMenuItem.Click += new System.EventHandler(this.modificarSecciónToolStripMenuItem_Click);
            // 
            // anularSecciónToolStripMenuItem
            // 
            this.anularSecciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anularSecciónToolStripMenuItem.Image")));
            this.anularSecciónToolStripMenuItem.Name = "anularSecciónToolStripMenuItem";
            this.anularSecciónToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.anularSecciónToolStripMenuItem.Text = "Anular Sección";
            this.anularSecciónToolStripMenuItem.Click += new System.EventHandler(this.anularSecciónToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoCursoToolStripMenuItem,
            this.modificarCursoToolStripMenuItem,
            this.anularCursoToolStripMenuItem});
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(75, 24);
            this.toolStripDropDownButton4.Text = "Curso";
            // 
            // nuevoCursoToolStripMenuItem
            // 
            this.nuevoCursoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoCursoToolStripMenuItem.Image")));
            this.nuevoCursoToolStripMenuItem.Name = "nuevoCursoToolStripMenuItem";
            this.nuevoCursoToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.nuevoCursoToolStripMenuItem.Text = "Nuevo Curso";
            this.nuevoCursoToolStripMenuItem.Click += new System.EventHandler(this.nuevoCursoToolStripMenuItem_Click);
            // 
            // modificarCursoToolStripMenuItem
            // 
            this.modificarCursoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarCursoToolStripMenuItem.Image")));
            this.modificarCursoToolStripMenuItem.Name = "modificarCursoToolStripMenuItem";
            this.modificarCursoToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.modificarCursoToolStripMenuItem.Text = "Modificar Curso";
            this.modificarCursoToolStripMenuItem.Click += new System.EventHandler(this.modificarCursoToolStripMenuItem_Click);
            // 
            // anularCursoToolStripMenuItem
            // 
            this.anularCursoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anularCursoToolStripMenuItem.Image")));
            this.anularCursoToolStripMenuItem.Name = "anularCursoToolStripMenuItem";
            this.anularCursoToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.anularCursoToolStripMenuItem.Text = "Anular Curso";
            this.anularCursoToolStripMenuItem.Click += new System.EventHandler(this.anularCursoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoParaleloToolStripMenuItem,
            this.modificarParaleloToolStripMenuItem,
            this.anularParaleloToolStripMenuItem});
            this.toolStripDropDownButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton5.Image")));
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(91, 24);
            this.toolStripDropDownButton5.Text = "Paralelo";
            // 
            // nuevoParaleloToolStripMenuItem
            // 
            this.nuevoParaleloToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoParaleloToolStripMenuItem.Image")));
            this.nuevoParaleloToolStripMenuItem.Name = "nuevoParaleloToolStripMenuItem";
            this.nuevoParaleloToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.nuevoParaleloToolStripMenuItem.Text = "Nuevo Paralelo";
            this.nuevoParaleloToolStripMenuItem.Click += new System.EventHandler(this.nuevoParaleloToolStripMenuItem_Click);
            // 
            // modificarParaleloToolStripMenuItem
            // 
            this.modificarParaleloToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarParaleloToolStripMenuItem.Image")));
            this.modificarParaleloToolStripMenuItem.Name = "modificarParaleloToolStripMenuItem";
            this.modificarParaleloToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.modificarParaleloToolStripMenuItem.Text = "Modificar Paralelo";
            this.modificarParaleloToolStripMenuItem.Click += new System.EventHandler(this.modificarParaleloToolStripMenuItem_Click);
            // 
            // anularParaleloToolStripMenuItem
            // 
            this.anularParaleloToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anularParaleloToolStripMenuItem.Image")));
            this.anularParaleloToolStripMenuItem.Name = "anularParaleloToolStripMenuItem";
            this.anularParaleloToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.anularParaleloToolStripMenuItem.Text = "Anular Paralelo";
            this.anularParaleloToolStripMenuItem.Click += new System.EventHandler(this.anularParaleloToolStripMenuItem_Click);
            // 
            // tbprovinciaInfoBindingSource
            // 
            this.tbprovinciaInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_provincia_Info);
            // 
            // tbpaisInfoBindingSource
            // 
            this.tbpaisInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_pais_Info);
            // 
            // acaInstitucionInfoBindingSource
            // 
            this.acaInstitucionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Institucion_Info);
            // 
            // FrmAcaInstitucion_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 529);
            this.Controls.Add(this.TabControlInstitucion);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAcaInstitucion_Mant";
            this.Text = "FrmAcaInstitucion_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcaInstitucion_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAcaInstitucion_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabControlInstitucion)).EndInit();
            this.TabControlInstitucion.ResumeLayout(false);
            this.tabIsntitucion.ResumeLayout(false);
            this.tabIsntitucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtruc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSitioWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResolucionAcademica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecretario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoordinador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoInstitucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdInstitucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            this.tabSede.ResumeLayout(false);
            this.tabSede.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListSede)).EndInit();
            this.Menu_Man.ResumeLayout(false);
            this.toolStripMenu_Mant.ResumeLayout(false);
            this.toolStripMenu_Mant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbprovinciaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpaisInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaInstitucionInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraTab.XtraTabControl TabControlInstitucion;
        private DevExpress.XtraTab.XtraTabPage tabIsntitucion;
        private DevExpress.XtraTab.XtraTabPage tabSede;
        private DevExpress.XtraEditors.LabelControl lblCoordinador;
        private DevExpress.XtraEditors.LabelControl lblRector;
        private DevExpress.XtraEditors.LabelControl lblFax;
        private DevExpress.XtraEditors.LabelControl lblTelefono;
        private DevExpress.XtraEditors.LabelControl lblDireccion;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.LabelControl lblSecretario;
        private DevExpress.XtraEditors.LabelControl lblSitioWeb;
        private DevExpress.XtraEditors.LabelControl lblResolucionAcademica;
        private DevExpress.XtraEditors.CheckEdit chkEstado;
        private DevExpress.XtraEditors.LabelControl lblCodInstitucion;
        private DevExpress.XtraEditors.LabelControl lblIdInstitucion;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtCodigoInstitucion;
        private DevExpress.XtraEditors.TextEdit txtIdInstitucion;
        private DevExpress.XtraEditors.TextEdit txtCoordinador;
        private DevExpress.XtraEditors.TextEdit txtRector;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private DevExpress.XtraEditors.TextEdit txtSecretario;
        private DevExpress.XtraEditors.TextEdit txtSitioWeb;
        private DevExpress.XtraEditors.TextEdit txtResolucionAcademica;
        private DevExpress.XtraEditors.MemoEdit txtDireccion;
        private System.Windows.Forms.BindingSource tbpaisInfoBindingSource;
        private System.Windows.Forms.BindingSource tbprovinciaInfoBindingSource;
        private Controles.UCGe_PaisProvinciaCiudad ucGe_Paprovciu;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.BindingSource acaInstitucionInfoBindingSource;
        private DevExpress.XtraTreeList.TreeList treeListSede;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdEmpresa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdInstitucion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCodInstitucion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNombre;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDireccion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTelefono;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFax;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRector;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCoordinador;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSecretario;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colResolucion_Academica;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSitioWeb;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEstado;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLogo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colUsuarioCreacion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colUsuarioModificacion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFechaCreacion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFechaMoficacion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colpaisInfo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colciudadInfo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colprovinciaInfo;
        private System.Windows.Forms.ToolStrip toolStripMenu_Mant;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem nuevaSedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarSedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsddJornada;
        private System.Windows.Forms.ToolStripMenuItem nuevaJornada;
        private System.Windows.Forms.ToolStripMenuItem modificarJornada;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem nuevaSecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarSecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem nuevoCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
        private System.Windows.Forms.ToolStripMenuItem nuevoParaleloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarParaleloToolStripMenuItem;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnTipo;
        private System.Windows.Forms.ContextMenuStrip Menu_Man;
        private System.Windows.Forms.ToolStripMenuItem btn_nuevo;
        private System.Windows.Forms.ToolStripMenuItem btn_modificar;
        private System.Windows.Forms.ToolStripMenuItem anularSedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularJornadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularSecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularParaleloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularToolStripMenuItem;
        private DevExpress.XtraEditors.TextEdit txtruc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}