namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_PlanCuenta_ImportacionWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCon_PlanCuenta_ImportacionWizard));
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.WizardPageBienvenidos = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.wizardPageSeleccionExcel = new DevExpress.XtraWizard.WizardPage();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblMsg1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbHoja = new System.Windows.Forms.ComboBox();
            this.lblHoja = new System.Windows.Forms.Label();
            this.txtSeleccion = new System.Windows.Forms.TextBox();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.wizardPageFin = new DevExpress.XtraWizard.CompletionWizardPage();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.wizardPageVerificacionYCargarData = new DevExpress.XtraWizard.WizardPage();
            this.treeListPlanCta = new DevExpress.XtraTreeList.TreeList();
            this.pc_Cuenta2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCtaCble = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCtaCblePadre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCatalogo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pc_Naturaleza = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdNivelCta = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdGrupoCble = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pc_Estado = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pc_EsMovimiento = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pc_clave_corta = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.wizardPageTipoDeIngresoDatos = new DevExpress.XtraWizard.WizardPage();
            this.lblmsg3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rgImportar = new DevExpress.XtraEditors.RadioGroup();
            this.wizardPageEstadoGrabacion = new DevExpress.XtraWizard.WizardPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridControlProceGrabado = new DevExpress.XtraGrid.GridControl();
            this.gridViewProceGrabado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdCta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstadoGrabado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_imagen_estado = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList_Iconos = new System.Windows.Forms.ImageList(this.components);
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdCuentaPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblNumRegistros = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btn_procesar = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Winform.Contabilidad.frmCon_WaitForm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.WizardPageBienvenidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.wizardPageSeleccionExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.wizardPageFin.SuspendLayout();
            this.wizardPageVerificacionYCargarData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPlanCta)).BeginInit();
            this.wizardPageTipoDeIngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgImportar.Properties)).BeginInit();
            this.wizardPageEstadoGrabacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProceGrabado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProceGrabado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imagen_estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.WizardPageBienvenidos);
            this.wizardControl1.Controls.Add(this.wizardPageSeleccionExcel);
            this.wizardControl1.Controls.Add(this.wizardPageFin);
            this.wizardControl1.Controls.Add(this.wizardPageVerificacionYCargarData);
            this.wizardControl1.Controls.Add(this.wizardPageTipoDeIngresoDatos);
            this.wizardControl1.Controls.Add(this.wizardPageEstadoGrabacion);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.WizardPageBienvenidos,
            this.wizardPageSeleccionExcel,
            this.wizardPageVerificacionYCargarData,
            this.wizardPageTipoDeIngresoDatos,
            this.wizardPageEstadoGrabacion,
            this.wizardPageFin});
            this.wizardControl1.Size = new System.Drawing.Size(1038, 428);
            this.wizardControl1.Text = "Asistente de importacions";
            this.wizardControl1.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_CancelClick);
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            this.wizardControl1.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl1_NextClick);
            this.wizardControl1.Click += new System.EventHandler(this.wizardControl1_Click);
            // 
            // WizardPageBienvenidos
            // 
            this.WizardPageBienvenidos.Controls.Add(this.pictureBox3);
            this.WizardPageBienvenidos.IntroductionText = "Este asistente le ayudara a importar correctamente su plan de cuentas en 3 simple" +
    "s pasos.";
            this.WizardPageBienvenidos.Name = "WizardPageBienvenidos";
            this.WizardPageBienvenidos.Size = new System.Drawing.Size(821, 295);
            this.WizardPageBienvenidos.Text = "Bienvenido al asistente de importación del plan de cuentas";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(426, 154);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 134);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // wizardPageSeleccionExcel
            // 
            this.wizardPageSeleccionExcel.Controls.Add(this.lblLink);
            this.wizardPageSeleccionExcel.Controls.Add(this.lblMsg1);
            this.wizardPageSeleccionExcel.Controls.Add(this.pictureBox1);
            this.wizardPageSeleccionExcel.Controls.Add(this.cmbHoja);
            this.wizardPageSeleccionExcel.Controls.Add(this.lblHoja);
            this.wizardPageSeleccionExcel.Controls.Add(this.txtSeleccion);
            this.wizardPageSeleccionExcel.Controls.Add(this.btnSeleccion);
            this.wizardPageSeleccionExcel.DescriptionText = "1.- Seleccione la ruta deseada.";
            this.wizardPageSeleccionExcel.Name = "wizardPageSeleccionExcel";
            this.wizardPageSeleccionExcel.Size = new System.Drawing.Size(1006, 283);
            this.wizardPageSeleccionExcel.Text = "Asistente de importación: Seleccion de archivo excel.";
            this.wizardPageSeleccionExcel.Click += new System.EventHandler(this.wizardPage1_Click);
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.ForeColor = System.Drawing.Color.Blue;
            this.lblLink.Location = new System.Drawing.Point(33, 213);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(164, 13);
            this.lblLink.TabIndex = 7;
            this.lblLink.Text = "Plantilla ejemplo - descargue aqui";
            this.lblLink.Click += new System.EventHandler(this.lblLink_Click);
            // 
            // lblMsg1
            // 
            this.lblMsg1.AutoSize = true;
            this.lblMsg1.Location = new System.Drawing.Point(357, 213);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(252, 13);
            this.lblMsg1.TabIndex = 6;
            this.lblMsg1.Text = "Espere un momento, obteniendo hojas de calculo....";
            this.lblMsg1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cmbHoja
            // 
            this.cmbHoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoja.FormattingEnabled = true;
            this.cmbHoja.Items.AddRange(new object[] {
            "Plantilla"});
            this.cmbHoja.Location = new System.Drawing.Point(449, 115);
            this.cmbHoja.Name = "cmbHoja";
            this.cmbHoja.Size = new System.Drawing.Size(121, 21);
            this.cmbHoja.TabIndex = 4;
            // 
            // lblHoja
            // 
            this.lblHoja.AutoSize = true;
            this.lblHoja.Location = new System.Drawing.Point(262, 115);
            this.lblHoja.Name = "lblHoja";
            this.lblHoja.Size = new System.Drawing.Size(150, 13);
            this.lblHoja.TabIndex = 2;
            this.lblHoja.Text = "Nombre de la Hoja de calculo:";
            // 
            // txtSeleccion
            // 
            this.txtSeleccion.Location = new System.Drawing.Point(449, 78);
            this.txtSeleccion.Name = "txtSeleccion";
            this.txtSeleccion.Size = new System.Drawing.Size(268, 20);
            this.txtSeleccion.TabIndex = 1;
            this.txtSeleccion.Text = "C:\\Plantillas\\Plantilla Plan de Ctas itCorp.xlsx";
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(279, 78);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(133, 23);
            this.btnSeleccion.TabIndex = 0;
            this.btnSeleccion.Text = "Seleccione el archivo:";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // wizardPageFin
            // 
            this.wizardPageFin.Controls.Add(this.label1);
            this.wizardPageFin.Controls.Add(this.rtbLog);
            this.wizardPageFin.FinishText = "Ud ha finalizado el asistente de importación";
            this.wizardPageFin.Name = "wizardPageFin";
            this.wizardPageFin.Size = new System.Drawing.Size(821, 295);
            this.wizardPageFin.Text = "Finalizando el Asistente de importación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe de errores:";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(41, 38);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(468, 244);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // wizardPageVerificacionYCargarData
            // 
            this.wizardPageVerificacionYCargarData.Controls.Add(this.treeListPlanCta);
            this.wizardPageVerificacionYCargarData.DescriptionText = "2.- Previsualizacion del plan de cuentas a importar";
            this.wizardPageVerificacionYCargarData.Name = "wizardPageVerificacionYCargarData";
            this.wizardPageVerificacionYCargarData.Size = new System.Drawing.Size(1006, 283);
            this.wizardPageVerificacionYCargarData.Text = "Asistente de importación: Verificacion de datos";
            // 
            // treeListPlanCta
            // 
            this.treeListPlanCta.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.pc_Cuenta2,
            this.IdCtaCble,
            this.IdCtaCblePadre,
            this.IdCatalogo,
            this.pc_Naturaleza,
            this.IdNivelCta,
            this.IdGrupoCble,
            this.pc_Estado,
            this.pc_EsMovimiento,
            this.pc_clave_corta});
            this.treeListPlanCta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListPlanCta.KeyFieldName = "IdCtaCble";
            this.treeListPlanCta.Location = new System.Drawing.Point(0, 0);
            this.treeListPlanCta.Name = "treeListPlanCta";
            this.treeListPlanCta.OptionsBehavior.AutoFocusNewNode = true;
            this.treeListPlanCta.OptionsBehavior.Editable = false;
            this.treeListPlanCta.OptionsBehavior.EnableFiltering = true;
            this.treeListPlanCta.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treeListPlanCta.OptionsPrint.PrintAllNodes = true;
            this.treeListPlanCta.OptionsPrint.UsePrintStyles = true;
            this.treeListPlanCta.OptionsView.ShowAutoFilterRow = true;
            this.treeListPlanCta.ParentFieldName = "IdCtaCblePadre";
            this.treeListPlanCta.Size = new System.Drawing.Size(1006, 283);
            this.treeListPlanCta.TabIndex = 4;
            // 
            // pc_Cuenta2
            // 
            this.pc_Cuenta2.Caption = "Cuenta Cble";
            this.pc_Cuenta2.FieldName = "pc_Cuenta2";
            this.pc_Cuenta2.Name = "pc_Cuenta2";
            this.pc_Cuenta2.OptionsColumn.AllowEdit = false;
            this.pc_Cuenta2.Visible = true;
            this.pc_Cuenta2.VisibleIndex = 0;
            this.pc_Cuenta2.Width = 356;
            // 
            // IdCtaCble
            // 
            this.IdCtaCble.Caption = "Id Cta Cble";
            this.IdCtaCble.FieldName = "IdCtaCble";
            this.IdCtaCble.Name = "IdCtaCble";
            this.IdCtaCble.OptionsColumn.AllowEdit = false;
            this.IdCtaCble.Visible = true;
            this.IdCtaCble.VisibleIndex = 8;
            this.IdCtaCble.Width = 73;
            // 
            // IdCtaCblePadre
            // 
            this.IdCtaCblePadre.Caption = "Id Cta Cble Padre";
            this.IdCtaCblePadre.FieldName = "IdCtaCblePadre";
            this.IdCtaCblePadre.Name = "IdCtaCblePadre";
            this.IdCtaCblePadre.OptionsColumn.AllowEdit = false;
            this.IdCtaCblePadre.Visible = true;
            this.IdCtaCblePadre.VisibleIndex = 1;
            this.IdCtaCblePadre.Width = 103;
            // 
            // IdCatalogo
            // 
            this.IdCatalogo.Caption = "Id Catalogo";
            this.IdCatalogo.FieldName = "IdCatalogo";
            this.IdCatalogo.Name = "IdCatalogo";
            this.IdCatalogo.OptionsColumn.AllowEdit = false;
            this.IdCatalogo.Width = 28;
            // 
            // pc_Naturaleza
            // 
            this.pc_Naturaleza.Caption = "Naturaleza";
            this.pc_Naturaleza.FieldName = "pc_Naturaleza";
            this.pc_Naturaleza.Name = "pc_Naturaleza";
            this.pc_Naturaleza.OptionsColumn.AllowEdit = false;
            this.pc_Naturaleza.Visible = true;
            this.pc_Naturaleza.VisibleIndex = 3;
            this.pc_Naturaleza.Width = 53;
            // 
            // IdNivelCta
            // 
            this.IdNivelCta.Caption = "Id Nivel Cta";
            this.IdNivelCta.FieldName = "IdNivelCta";
            this.IdNivelCta.Name = "IdNivelCta";
            this.IdNivelCta.OptionsColumn.AllowEdit = false;
            this.IdNivelCta.Visible = true;
            this.IdNivelCta.VisibleIndex = 2;
            this.IdNivelCta.Width = 70;
            // 
            // IdGrupoCble
            // 
            this.IdGrupoCble.Caption = "Id Grupo Cble";
            this.IdGrupoCble.FieldName = "IdGrupoCble";
            this.IdGrupoCble.Name = "IdGrupoCble";
            this.IdGrupoCble.OptionsColumn.AllowEdit = false;
            this.IdGrupoCble.Visible = true;
            this.IdGrupoCble.VisibleIndex = 4;
            this.IdGrupoCble.Width = 54;
            // 
            // pc_Estado
            // 
            this.pc_Estado.Caption = "Estado";
            this.pc_Estado.FieldName = "pc_Estado";
            this.pc_Estado.Name = "pc_Estado";
            this.pc_Estado.OptionsColumn.AllowEdit = false;
            this.pc_Estado.Visible = true;
            this.pc_Estado.VisibleIndex = 5;
            this.pc_Estado.Width = 20;
            // 
            // pc_EsMovimiento
            // 
            this.pc_EsMovimiento.Caption = "Movimiento";
            this.pc_EsMovimiento.FieldName = "pc_EsMovimiento";
            this.pc_EsMovimiento.Name = "pc_EsMovimiento";
            this.pc_EsMovimiento.OptionsColumn.AllowEdit = false;
            this.pc_EsMovimiento.Visible = true;
            this.pc_EsMovimiento.VisibleIndex = 6;
            this.pc_EsMovimiento.Width = 34;
            // 
            // pc_clave_corta
            // 
            this.pc_clave_corta.Caption = "Clave Corta";
            this.pc_clave_corta.FieldName = "pc_clave_corta";
            this.pc_clave_corta.Name = "pc_clave_corta";
            this.pc_clave_corta.OptionsColumn.AllowEdit = false;
            this.pc_clave_corta.Visible = true;
            this.pc_clave_corta.VisibleIndex = 7;
            this.pc_clave_corta.Width = 30;
            // 
            // wizardPageTipoDeIngresoDatos
            // 
            this.wizardPageTipoDeIngresoDatos.Controls.Add(this.lblmsg3);
            this.wizardPageTipoDeIngresoDatos.Controls.Add(this.pictureBox2);
            this.wizardPageTipoDeIngresoDatos.Controls.Add(this.rgImportar);
            this.wizardPageTipoDeIngresoDatos.DescriptionText = "3.- Seleccione la forma de ingresar sus datos.";
            this.wizardPageTipoDeIngresoDatos.Name = "wizardPageTipoDeIngresoDatos";
            this.wizardPageTipoDeIngresoDatos.Size = new System.Drawing.Size(1006, 283);
            this.wizardPageTipoDeIngresoDatos.Text = "Asistente de importación";
            // 
            // lblmsg3
            // 
            this.lblmsg3.AutoSize = true;
            this.lblmsg3.Location = new System.Drawing.Point(332, 256);
            this.lblmsg3.Name = "lblmsg3";
            this.lblmsg3.Size = new System.Drawing.Size(208, 13);
            this.lblmsg3.TabIndex = 2;
            this.lblmsg3.Text = "Espere un momento, Insertando registros...";
            this.lblmsg3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(148, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // rgImportar
            // 
            this.rgImportar.Location = new System.Drawing.Point(484, 43);
            this.rgImportar.Name = "rgImportar";
            this.rgImportar.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Sobreescribir todo."),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Añadir y mantener existentes.")});
            this.rgImportar.Size = new System.Drawing.Size(227, 96);
            this.rgImportar.TabIndex = 0;
            this.rgImportar.SelectedIndexChanged += new System.EventHandler(this.rgImportar_SelectedIndexChanged);
            // 
            // wizardPageEstadoGrabacion
            // 
            this.wizardPageEstadoGrabacion.Controls.Add(this.splitContainer1);
            this.wizardPageEstadoGrabacion.DescriptionText = "";
            this.wizardPageEstadoGrabacion.Name = "wizardPageEstadoGrabacion";
            this.wizardPageEstadoGrabacion.Size = new System.Drawing.Size(1006, 283);
            this.wizardPageEstadoGrabacion.Text = "Estado de Grabacion";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridControlProceGrabado);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblMensaje);
            this.splitContainer1.Panel2.Controls.Add(this.lblNumRegistros);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_procesar);
            this.splitContainer1.Size = new System.Drawing.Size(1006, 283);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 1;
            // 
            // gridControlProceGrabado
            // 
            this.gridControlProceGrabado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProceGrabado.Location = new System.Drawing.Point(0, 0);
            this.gridControlProceGrabado.MainView = this.gridViewProceGrabado;
            this.gridControlProceGrabado.Name = "gridControlProceGrabado";
            this.gridControlProceGrabado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPopupContainerEdit1,
            this.cmb_imagen_estado});
            this.gridControlProceGrabado.Size = new System.Drawing.Size(1006, 227);
            this.gridControlProceGrabado.TabIndex = 0;
            this.gridControlProceGrabado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProceGrabado});
            // 
            // gridViewProceGrabado
            // 
            this.gridViewProceGrabado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdCta,
            this.colCuenta,
            this.ColEstadoGrabado,
            this.colObservacion,
            this.ColIdCuentaPadre});
            this.gridViewProceGrabado.GridControl = this.gridControlProceGrabado;
            this.gridViewProceGrabado.Name = "gridViewProceGrabado";
            this.gridViewProceGrabado.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProceGrabado.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdCta
            // 
            this.ColIdCta.Caption = "IdCuenta";
            this.ColIdCta.FieldName = "IdCuenta";
            this.ColIdCta.Name = "ColIdCta";
            this.ColIdCta.Visible = true;
            this.ColIdCta.VisibleIndex = 0;
            this.ColIdCta.Width = 152;
            // 
            // colCuenta
            // 
            this.colCuenta.Caption = "Cuenta";
            this.colCuenta.FieldName = "Nom_cuenta";
            this.colCuenta.Name = "colCuenta";
            this.colCuenta.Visible = true;
            this.colCuenta.VisibleIndex = 1;
            this.colCuenta.Width = 387;
            // 
            // ColEstadoGrabado
            // 
            this.ColEstadoGrabado.Caption = "*";
            this.ColEstadoGrabado.ColumnEdit = this.cmb_imagen_estado;
            this.ColEstadoGrabado.FieldName = "Estado_grabado";
            this.ColEstadoGrabado.Name = "ColEstadoGrabado";
            this.ColEstadoGrabado.Visible = true;
            this.ColEstadoGrabado.VisibleIndex = 3;
            this.ColEstadoGrabado.Width = 20;
            // 
            // cmb_imagen_estado
            // 
            this.cmb_imagen_estado.AutoHeight = false;
            this.cmb_imagen_estado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_imagen_estado.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "ERROR", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "OK", 1)});
            this.cmb_imagen_estado.Name = "cmb_imagen_estado";
            this.cmb_imagen_estado.SmallImages = this.imageList_Iconos;
            // 
            // imageList_Iconos
            // 
            this.imageList_Iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Iconos.ImageStream")));
            this.imageList_Iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Iconos.Images.SetKeyName(0, "excalmacion2.jpg");
            this.imageList_Iconos.Images.SetKeyName(1, "Ok_48x48.ico");
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observacion";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 4;
            this.colObservacion.Width = 329;
            // 
            // ColIdCuentaPadre
            // 
            this.ColIdCuentaPadre.Caption = "IdCuentaPadre";
            this.ColIdCuentaPadre.FieldName = "IdCuentaPadre";
            this.ColIdCuentaPadre.Name = "ColIdCuentaPadre";
            this.ColIdCuentaPadre.Visible = true;
            this.ColIdCuentaPadre.VisibleIndex = 2;
            this.ColIdCuentaPadre.Width = 100;
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(31, 30);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(110, 15);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "**Error al cargar**";
            this.lblMensaje.Visible = false;
            // 
            // lblNumRegistros
            // 
            this.lblNumRegistros.AutoSize = true;
            this.lblNumRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRegistros.Location = new System.Drawing.Point(18, 17);
            this.lblNumRegistros.Name = "lblNumRegistros";
            this.lblNumRegistros.Size = new System.Drawing.Size(27, 13);
            this.lblNumRegistros.TabIndex = 2;
            this.lblNumRegistros.Text = "0/0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(189, 7);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(499, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 1;
            // 
            // btn_procesar
            // 
            this.btn_procesar.Location = new System.Drawing.Point(694, 7);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(118, 24);
            this.btn_procesar.TabIndex = 0;
            this.btn_procesar.Text = "Procesar";
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xlsx";
            this.saveFileDialog1.FileName = "Plantilla Ejemplo.xlsx";
            this.saveFileDialog1.Title = "Sistemas: Plantilla de ejemplo";
            // 
            // frmCon_PlanCuenta_ImportacionWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 428);
            this.Controls.Add(this.wizardControl1);
            this.Name = "frmCon_PlanCuenta_ImportacionWizard";
            this.Text = "Importación Plan Cuenta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCon_PlanCuenta_ImportacionWizard_FormClosing);
            this.Load += new System.EventHandler(this.frmCon_PlanCuenta_ImportacionWizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.WizardPageBienvenidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.wizardPageSeleccionExcel.ResumeLayout(false);
            this.wizardPageSeleccionExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.wizardPageFin.ResumeLayout(false);
            this.wizardPageFin.PerformLayout();
            this.wizardPageVerificacionYCargarData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListPlanCta)).EndInit();
            this.wizardPageTipoDeIngresoDatos.ResumeLayout(false);
            this.wizardPageTipoDeIngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgImportar.Properties)).EndInit();
            this.wizardPageEstadoGrabacion.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProceGrabado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProceGrabado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imagen_estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage WizardPageBienvenidos;
        private DevExpress.XtraWizard.WizardPage wizardPageSeleccionExcel;
        private DevExpress.XtraWizard.CompletionWizardPage wizardPageFin;
        private DevExpress.XtraWizard.WizardPage wizardPageVerificacionYCargarData;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.TextBox txtSeleccion;
        private System.Windows.Forms.Label lblHoja;
        private DevExpress.XtraTreeList.TreeList treeListPlanCta;
        private DevExpress.XtraTreeList.Columns.TreeListColumn pc_Cuenta2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdCtaCble;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdCtaCblePadre;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdCatalogo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn pc_Naturaleza;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdNivelCta;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdGrupoCble;
        private DevExpress.XtraTreeList.Columns.TreeListColumn pc_Estado;
        private DevExpress.XtraTreeList.Columns.TreeListColumn pc_EsMovimiento;
        private DevExpress.XtraTreeList.Columns.TreeListColumn pc_clave_corta;
        private System.Windows.Forms.ComboBox cmbHoja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraWizard.WizardPage wizardPageTipoDeIngresoDatos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.RadioGroup rgImportar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblMsg1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label lblmsg3;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraWizard.WizardPage wizardPageEstadoGrabacion;
        private DevExpress.XtraGrid.GridControl gridControlProceGrabado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProceGrabado;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdCta;
        private DevExpress.XtraGrid.Columns.GridColumn colCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstadoGrabado;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btn_procesar;
        private System.Windows.Forms.Label lblNumRegistros;
        private System.Windows.Forms.ProgressBar progressBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_imagen_estado;
        private System.Windows.Forms.ImageList imageList_Iconos;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private System.Windows.Forms.Label lblMensaje;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdCuentaPadre;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}