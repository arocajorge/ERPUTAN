namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Producto_Winzard_Import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_Producto_Winzard_Import));
            this.wizardControlImportProducto = new DevExpress.XtraWizard.WizardControl();
            this.WizardPageBienvenidos = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.wizardPageSeleccionExcel = new DevExpress.XtraWizard.WizardPage();
            this.lblMsg1 = new System.Windows.Forms.Label();
            this.cmbHoja = new System.Windows.Forms.ComboBox();
            this.lblHoja = new System.Windows.Forms.Label();
            this.txtSeleccion = new System.Windows.Forms.TextBox();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.lblLink = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wizardPageFin = new DevExpress.XtraWizard.CompletionWizardPage();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.wizardPageVerificacionYCargarData = new DevExpress.XtraWizard.WizardPage();
            this.gridControlProductos = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProductoTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubgrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wizardPageTipoDeIngresoDatos = new DevExpress.XtraWizard.WizardPage();
            this.lblmsg3 = new System.Windows.Forms.Label();
            this.rgImportar = new DevExpress.XtraEditors.RadioGroup();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.wizardPageEstadoGrabacion = new DevExpress.XtraWizard.WizardPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridControlProceGrabado = new DevExpress.XtraGrid.GridControl();
            this.gridViewProceGrabado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCod_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTipoProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoGrabado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstadoGrabado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_imagen_estado = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ColObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblNumRegistros = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btn_procesar = new DevExpress.XtraEditors.SimpleButton();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.saveFileDialogProducto = new System.Windows.Forms.SaveFileDialog();
            this.cmb_IdCtaCble_Inven = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.cmb_IdCtaCble_VenIva = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.cmb_IdCtaCble_Ven0 = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.cmb_IdCtaCble_DesIva = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.cmb_IdCtaCble_Des0 = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_IdCtaCble_DevIva = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.cmb_IdCtaCble_Dev0 = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.cmb_IdCtaCble_Costo = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.cmb_IdCtaCble_Gasto_x_cxp = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.cmb_IdCtaCble_Vta = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlImportProducto)).BeginInit();
            this.wizardControlImportProducto.SuspendLayout();
            this.WizardPageBienvenidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.wizardPageSeleccionExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.wizardPageFin.SuspendLayout();
            this.wizardPageVerificacionYCargarData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).BeginInit();
            this.wizardPageTipoDeIngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgImportar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.wizardPageEstadoGrabacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProceGrabado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProceGrabado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imagen_estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            this.wizardPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardControlImportProducto
            // 
            this.wizardControlImportProducto.Controls.Add(this.WizardPageBienvenidos);
            this.wizardControlImportProducto.Controls.Add(this.wizardPageSeleccionExcel);
            this.wizardControlImportProducto.Controls.Add(this.wizardPageFin);
            this.wizardControlImportProducto.Controls.Add(this.wizardPageVerificacionYCargarData);
            this.wizardControlImportProducto.Controls.Add(this.wizardPageTipoDeIngresoDatos);
            this.wizardControlImportProducto.Controls.Add(this.wizardPageEstadoGrabacion);
            this.wizardControlImportProducto.Controls.Add(this.wizardPage1);
            this.wizardControlImportProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControlImportProducto.Location = new System.Drawing.Point(0, 0);
            this.wizardControlImportProducto.Name = "wizardControlImportProducto";
            this.wizardControlImportProducto.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.WizardPageBienvenidos,
            this.wizardPageSeleccionExcel,
            this.wizardPageVerificacionYCargarData,
            this.wizardPage1,
            this.wizardPageTipoDeIngresoDatos,
            this.wizardPageEstadoGrabacion,
            this.wizardPageFin});
            this.wizardControlImportProducto.Size = new System.Drawing.Size(916, 481);
            this.wizardControlImportProducto.Text = "";
            this.wizardControlImportProducto.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControlImportProducto_CancelClick);
            this.wizardControlImportProducto.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControlImportProducto_FinishClick);
            this.wizardControlImportProducto.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControlImportProducto_NextClick);
            // 
            // WizardPageBienvenidos
            // 
            this.WizardPageBienvenidos.Controls.Add(this.pictureBox3);
            this.WizardPageBienvenidos.IntroductionText = "El asistente le ayudara a importar sus productos en 3 simples pasos.";
            this.WizardPageBienvenidos.Name = "WizardPageBienvenidos";
            this.WizardPageBienvenidos.Size = new System.Drawing.Size(699, 348);
            this.WizardPageBienvenidos.Text = "Bienvenido al asistente de Importacion de Producto";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(332, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 134);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // wizardPageSeleccionExcel
            // 
            this.wizardPageSeleccionExcel.Controls.Add(this.lblMsg1);
            this.wizardPageSeleccionExcel.Controls.Add(this.cmbHoja);
            this.wizardPageSeleccionExcel.Controls.Add(this.lblHoja);
            this.wizardPageSeleccionExcel.Controls.Add(this.txtSeleccion);
            this.wizardPageSeleccionExcel.Controls.Add(this.btnSeleccion);
            this.wizardPageSeleccionExcel.Controls.Add(this.lblLink);
            this.wizardPageSeleccionExcel.Controls.Add(this.pictureBox1);
            this.wizardPageSeleccionExcel.DescriptionText = "1.- Seleccione la ruta deseada.";
            this.wizardPageSeleccionExcel.Name = "wizardPageSeleccionExcel";
            this.wizardPageSeleccionExcel.Size = new System.Drawing.Size(884, 336);
            this.wizardPageSeleccionExcel.Text = "Asistente de importacion: Seleccion de archivo de excel.";
            // 
            // lblMsg1
            // 
            this.lblMsg1.AutoSize = true;
            this.lblMsg1.Location = new System.Drawing.Point(327, 227);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(252, 13);
            this.lblMsg1.TabIndex = 20;
            this.lblMsg1.Text = "Espere un momento, obteniendo hojas de calculo....";
            this.lblMsg1.Visible = false;
            // 
            // cmbHoja
            // 
            this.cmbHoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoja.FormattingEnabled = true;
            this.cmbHoja.Items.AddRange(new object[] {
            "Plantilla"});
            this.cmbHoja.Location = new System.Drawing.Point(419, 129);
            this.cmbHoja.Name = "cmbHoja";
            this.cmbHoja.Size = new System.Drawing.Size(121, 21);
            this.cmbHoja.TabIndex = 19;
            // 
            // lblHoja
            // 
            this.lblHoja.AutoSize = true;
            this.lblHoja.Location = new System.Drawing.Point(232, 129);
            this.lblHoja.Name = "lblHoja";
            this.lblHoja.Size = new System.Drawing.Size(150, 13);
            this.lblHoja.TabIndex = 18;
            this.lblHoja.Text = "Nombre de la Hoja de calculo:";
            // 
            // txtSeleccion
            // 
            this.txtSeleccion.Location = new System.Drawing.Point(419, 92);
            this.txtSeleccion.Name = "txtSeleccion";
            this.txtSeleccion.Size = new System.Drawing.Size(268, 20);
            this.txtSeleccion.TabIndex = 17;
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(249, 92);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(133, 23);
            this.btnSeleccion.TabIndex = 16;
            this.btnSeleccion.Text = "Seleccione el archivo:";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.ForeColor = System.Drawing.Color.Blue;
            this.lblLink.Location = new System.Drawing.Point(20, 223);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(164, 13);
            this.lblLink.TabIndex = 15;
            this.lblLink.Text = "Plantilla ejemplo - descargue aqui";
            this.lblLink.Click += new System.EventHandler(this.lblLink_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // wizardPageFin
            // 
            this.wizardPageFin.Controls.Add(this.label1);
            this.wizardPageFin.Controls.Add(this.rtbLog);
            this.wizardPageFin.FinishText = "Ud ha finalizado el asistente de importacion";
            this.wizardPageFin.Name = "wizardPageFin";
            this.wizardPageFin.Size = new System.Drawing.Size(699, 348);
            this.wizardPageFin.Text = "Finalizando el Asistente de Importacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informe de errores:";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(31, 56);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(468, 244);
            this.rtbLog.TabIndex = 4;
            this.rtbLog.Text = "";
            // 
            // wizardPageVerificacionYCargarData
            // 
            this.wizardPageVerificacionYCargarData.Controls.Add(this.gridControlProductos);
            this.wizardPageVerificacionYCargarData.DescriptionText = "2.- Previsualizacion de los productos a importar.";
            this.wizardPageVerificacionYCargarData.Name = "wizardPageVerificacionYCargarData";
            this.wizardPageVerificacionYCargarData.Size = new System.Drawing.Size(884, 336);
            this.wizardPageVerificacionYCargarData.Text = "Asistente de importacion: Verificacion de Productos.";
            // 
            // gridControlProductos
            // 
            this.gridControlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductos.Location = new System.Drawing.Point(0, 0);
            this.gridControlProductos.MainView = this.gridViewProductos;
            this.gridControlProductos.Name = "gridControlProductos";
            this.gridControlProductos.Size = new System.Drawing.Size(884, 336);
            this.gridControlProductos.TabIndex = 0;
            this.gridControlProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductos});
            // 
            // gridViewProductos
            // 
            this.gridViewProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto2,
            this.colpr_codigo2,
            this.colIdProductoTipo,
            this.colpr_descripcion,
            this.colCategoria,
            this.colLinea,
            this.colgrupo,
            this.colsubgrupo,
            this.colnom_Marca});
            this.gridViewProductos.GridControl = this.gridControlProductos;
            this.gridViewProductos.Name = "gridViewProductos";
            this.gridViewProductos.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto2
            // 
            this.colIdProducto2.Caption = "IdProducto";
            this.colIdProducto2.FieldName = "IdProducto";
            this.colIdProducto2.Name = "colIdProducto2";
            this.colIdProducto2.Visible = true;
            this.colIdProducto2.VisibleIndex = 0;
            this.colIdProducto2.Width = 72;
            // 
            // colpr_codigo2
            // 
            this.colpr_codigo2.Caption = "Codigo";
            this.colpr_codigo2.FieldName = "pr_codigo";
            this.colpr_codigo2.Name = "colpr_codigo2";
            this.colpr_codigo2.Visible = true;
            this.colpr_codigo2.VisibleIndex = 1;
            this.colpr_codigo2.Width = 72;
            // 
            // colIdProductoTipo
            // 
            this.colIdProductoTipo.Caption = "IdProductoTipo";
            this.colIdProductoTipo.FieldName = "IdProductoTipo";
            this.colIdProductoTipo.Name = "colIdProductoTipo";
            this.colIdProductoTipo.Visible = true;
            this.colIdProductoTipo.VisibleIndex = 3;
            this.colIdProductoTipo.Width = 97;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "nombre";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 2;
            this.colpr_descripcion.Width = 939;
            // 
            // colCategoria
            // 
            this.colCategoria.Caption = "Categoria";
            this.colCategoria.FieldName = "nom_Linea";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Visible = true;
            this.colCategoria.VisibleIndex = 4;
            // 
            // colLinea
            // 
            this.colLinea.Caption = "Linea";
            this.colLinea.FieldName = "nom_Linea";
            this.colLinea.Name = "colLinea";
            this.colLinea.Visible = true;
            this.colLinea.VisibleIndex = 5;
            // 
            // colgrupo
            // 
            this.colgrupo.Caption = "grupo";
            this.colgrupo.FieldName = "nom_Grupo";
            this.colgrupo.Name = "colgrupo";
            this.colgrupo.Visible = true;
            this.colgrupo.VisibleIndex = 6;
            // 
            // colsubgrupo
            // 
            this.colsubgrupo.Caption = "sub grupo";
            this.colsubgrupo.FieldName = "nom_SubGrupo";
            this.colsubgrupo.Name = "colsubgrupo";
            this.colsubgrupo.Visible = true;
            this.colsubgrupo.VisibleIndex = 7;
            // 
            // colnom_Marca
            // 
            this.colnom_Marca.Caption = "Marca";
            this.colnom_Marca.FieldName = "nom_Marca";
            this.colnom_Marca.Name = "colnom_Marca";
            this.colnom_Marca.Visible = true;
            this.colnom_Marca.VisibleIndex = 8;
            // 
            // wizardPageTipoDeIngresoDatos
            // 
            this.wizardPageTipoDeIngresoDatos.Controls.Add(this.lblmsg3);
            this.wizardPageTipoDeIngresoDatos.Controls.Add(this.rgImportar);
            this.wizardPageTipoDeIngresoDatos.Controls.Add(this.pictureBox2);
            this.wizardPageTipoDeIngresoDatos.DescriptionText = "4.- Seleccione la forma de ingresar sus datos.";
            this.wizardPageTipoDeIngresoDatos.Name = "wizardPageTipoDeIngresoDatos";
            this.wizardPageTipoDeIngresoDatos.Size = new System.Drawing.Size(884, 336);
            this.wizardPageTipoDeIngresoDatos.Text = "Asistente de importacion.";
            // 
            // lblmsg3
            // 
            this.lblmsg3.AutoSize = true;
            this.lblmsg3.Location = new System.Drawing.Point(242, 272);
            this.lblmsg3.Name = "lblmsg3";
            this.lblmsg3.Size = new System.Drawing.Size(208, 13);
            this.lblmsg3.TabIndex = 7;
            this.lblmsg3.Text = "Espere un momento, Insertando registros...";
            this.lblmsg3.Visible = false;
            // 
            // rgImportar
            // 
            this.rgImportar.Location = new System.Drawing.Point(435, 56);
            this.rgImportar.Name = "rgImportar";
            this.rgImportar.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Sobreescribir todo."),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Añadir y mantener existentes.")});
            this.rgImportar.Size = new System.Drawing.Size(227, 96);
            this.rgImportar.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(69, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // wizardPageEstadoGrabacion
            // 
            this.wizardPageEstadoGrabacion.Controls.Add(this.splitContainer1);
            this.wizardPageEstadoGrabacion.DescriptionText = "";
            this.wizardPageEstadoGrabacion.Name = "wizardPageEstadoGrabacion";
            this.wizardPageEstadoGrabacion.Size = new System.Drawing.Size(884, 336);
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
            this.splitContainer1.Size = new System.Drawing.Size(884, 336);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.TabIndex = 2;
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
            this.gridControlProceGrabado.Size = new System.Drawing.Size(884, 269);
            this.gridControlProceGrabado.TabIndex = 0;
            this.gridControlProceGrabado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProceGrabado});
            // 
            // gridViewProceGrabado
            // 
            this.gridViewProceGrabado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdProducto,
            this.colCod_Producto,
            this.colNom_producto,
            this.ColTipoProducto,
            this.colIdEstadoGrabado,
            this.ColEstadoGrabado,
            this.ColObservacion});
            this.gridViewProceGrabado.GridControl = this.gridControlProceGrabado;
            this.gridViewProceGrabado.Name = "gridViewProceGrabado";
            this.gridViewProceGrabado.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProceGrabado.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdProducto
            // 
            this.ColIdProducto.Caption = "IdProducto";
            this.ColIdProducto.FieldName = "IdProducto";
            this.ColIdProducto.Name = "ColIdProducto";
            this.ColIdProducto.Visible = true;
            this.ColIdProducto.VisibleIndex = 0;
            this.ColIdProducto.Width = 123;
            // 
            // colCod_Producto
            // 
            this.colCod_Producto.Caption = "Codigo Prod.";
            this.colCod_Producto.FieldName = "cod_producto";
            this.colCod_Producto.Name = "colCod_Producto";
            this.colCod_Producto.Visible = true;
            this.colCod_Producto.VisibleIndex = 1;
            this.colCod_Producto.Width = 93;
            // 
            // colNom_producto
            // 
            this.colNom_producto.Caption = "Producto";
            this.colNom_producto.FieldName = "nom_producto";
            this.colNom_producto.Name = "colNom_producto";
            this.colNom_producto.Visible = true;
            this.colNom_producto.VisibleIndex = 2;
            this.colNom_producto.Width = 454;
            // 
            // ColTipoProducto
            // 
            this.ColTipoProducto.Caption = "TipoProducto";
            this.ColTipoProducto.FieldName = "TipoProducto";
            this.ColTipoProducto.Name = "ColTipoProducto";
            this.ColTipoProducto.Visible = true;
            this.ColTipoProducto.VisibleIndex = 3;
            this.ColTipoProducto.Width = 85;
            // 
            // colIdEstadoGrabado
            // 
            this.colIdEstadoGrabado.Caption = "IdEstadoGrabado";
            this.colIdEstadoGrabado.FieldName = "IdEstadoGrabado";
            this.colIdEstadoGrabado.Name = "colIdEstadoGrabado";
            this.colIdEstadoGrabado.Width = 184;
            // 
            // ColEstadoGrabado
            // 
            this.ColEstadoGrabado.Caption = "*";
            this.ColEstadoGrabado.ColumnEdit = this.cmb_imagen_estado;
            this.ColEstadoGrabado.FieldName = "Estado_grabado";
            this.ColEstadoGrabado.Name = "ColEstadoGrabado";
            this.ColEstadoGrabado.Visible = true;
            this.ColEstadoGrabado.VisibleIndex = 4;
            this.ColEstadoGrabado.Width = 33;
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
            // 
            // ColObservacion
            // 
            this.ColObservacion.Caption = "Observacion";
            this.ColObservacion.FieldName = "Observacion";
            this.ColObservacion.Name = "ColObservacion";
            this.ColObservacion.Visible = true;
            this.ColObservacion.VisibleIndex = 5;
            this.ColObservacion.Width = 392;
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
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.labelControl10);
            this.wizardPage1.Controls.Add(this.labelControl9);
            this.wizardPage1.Controls.Add(this.labelControl8);
            this.wizardPage1.Controls.Add(this.labelControl7);
            this.wizardPage1.Controls.Add(this.labelControl6);
            this.wizardPage1.Controls.Add(this.labelControl5);
            this.wizardPage1.Controls.Add(this.labelControl4);
            this.wizardPage1.Controls.Add(this.labelControl3);
            this.wizardPage1.Controls.Add(this.labelControl2);
            this.wizardPage1.Controls.Add(this.labelControl1);
            this.wizardPage1.Controls.Add(this.cmb_IdCtaCble_Vta);
            this.wizardPage1.Controls.Add(this.cmb_IdCtaCble_Gasto_x_cxp);
            this.wizardPage1.Controls.Add(this.cmb_IdCtaCble_Costo);
            this.wizardPage1.Controls.Add(this.cmb_IdCtaCble_Dev0);
            this.wizardPage1.Controls.Add(this.cmb_IdCtaCble_DevIva);
            this.wizardPage1.Controls.Add(this.cmb_IdCtaCble_Des0);
            this.wizardPage1.Controls.Add(this.cmb_IdCtaCble_DesIva);
            this.wizardPage1.Controls.Add(this.cmb_IdCtaCble_Ven0);
            this.wizardPage1.Controls.Add(this.cmb_IdCtaCble_VenIva);
            this.wizardPage1.Controls.Add(this.cmb_IdCtaCble_Inven);
            this.wizardPage1.DescriptionText = "3.- Seleccione las cuentas contables generales del inventario";
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(884, 336);
            this.wizardPage1.Text = "Asistente de importación: Cuentas contables de inventario";
            // 
            // saveFileDialogProducto
            // 
            this.saveFileDialogProducto.DefaultExt = "xlsx";
            this.saveFileDialogProducto.FileName = "Plantilla_Ejemplo_Productos.xlsx";
            // 
            // cmb_IdCtaCble_Inven
            // 
            this.cmb_IdCtaCble_Inven.Location = new System.Drawing.Point(395, 11);
            this.cmb_IdCtaCble_Inven.Name = "cmb_IdCtaCble_Inven";
            this.cmb_IdCtaCble_Inven.Size = new System.Drawing.Size(286, 26);
            this.cmb_IdCtaCble_Inven.TabIndex = 0;
            // 
            // cmb_IdCtaCble_VenIva
            // 
            this.cmb_IdCtaCble_VenIva.Location = new System.Drawing.Point(395, 43);
            this.cmb_IdCtaCble_VenIva.Name = "cmb_IdCtaCble_VenIva";
            this.cmb_IdCtaCble_VenIva.Size = new System.Drawing.Size(286, 26);
            this.cmb_IdCtaCble_VenIva.TabIndex = 1;
            // 
            // cmb_IdCtaCble_Ven0
            // 
            this.cmb_IdCtaCble_Ven0.Location = new System.Drawing.Point(395, 75);
            this.cmb_IdCtaCble_Ven0.Name = "cmb_IdCtaCble_Ven0";
            this.cmb_IdCtaCble_Ven0.Size = new System.Drawing.Size(286, 26);
            this.cmb_IdCtaCble_Ven0.TabIndex = 2;
            // 
            // cmb_IdCtaCble_DesIva
            // 
            this.cmb_IdCtaCble_DesIva.Location = new System.Drawing.Point(395, 107);
            this.cmb_IdCtaCble_DesIva.Name = "cmb_IdCtaCble_DesIva";
            this.cmb_IdCtaCble_DesIva.Size = new System.Drawing.Size(286, 26);
            this.cmb_IdCtaCble_DesIva.TabIndex = 3;
            // 
            // cmb_IdCtaCble_Des0
            // 
            this.cmb_IdCtaCble_Des0.Location = new System.Drawing.Point(395, 139);
            this.cmb_IdCtaCble_Des0.Name = "cmb_IdCtaCble_Des0";
            this.cmb_IdCtaCble_Des0.Size = new System.Drawing.Size(286, 26);
            this.cmb_IdCtaCble_Des0.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(134, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(144, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Cuenta general de inventario:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(134, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(179, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Cuenta general para ventas con IVA:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(134, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(175, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Cuenta general para ventas sin IVA:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(134, 114);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(242, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Cuenta general para descuento en venta con IVA:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(134, 146);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(238, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Cuenta general para descuento en venta sin IVA:";
            // 
            // cmb_IdCtaCble_DevIva
            // 
            this.cmb_IdCtaCble_DevIva.Location = new System.Drawing.Point(395, 173);
            this.cmb_IdCtaCble_DevIva.Name = "cmb_IdCtaCble_DevIva";
            this.cmb_IdCtaCble_DevIva.Size = new System.Drawing.Size(286, 26);
            this.cmb_IdCtaCble_DevIva.TabIndex = 7;
            // 
            // cmb_IdCtaCble_Dev0
            // 
            this.cmb_IdCtaCble_Dev0.Location = new System.Drawing.Point(395, 205);
            this.cmb_IdCtaCble_Dev0.Name = "cmb_IdCtaCble_Dev0";
            this.cmb_IdCtaCble_Dev0.Size = new System.Drawing.Size(286, 26);
            this.cmb_IdCtaCble_Dev0.TabIndex = 8;
            // 
            // cmb_IdCtaCble_Costo
            // 
            this.cmb_IdCtaCble_Costo.Location = new System.Drawing.Point(395, 237);
            this.cmb_IdCtaCble_Costo.Name = "cmb_IdCtaCble_Costo";
            this.cmb_IdCtaCble_Costo.Size = new System.Drawing.Size(286, 26);
            this.cmb_IdCtaCble_Costo.TabIndex = 9;
            // 
            // cmb_IdCtaCble_Gasto_x_cxp
            // 
            this.cmb_IdCtaCble_Gasto_x_cxp.Location = new System.Drawing.Point(395, 269);
            this.cmb_IdCtaCble_Gasto_x_cxp.Name = "cmb_IdCtaCble_Gasto_x_cxp";
            this.cmb_IdCtaCble_Gasto_x_cxp.Size = new System.Drawing.Size(286, 26);
            this.cmb_IdCtaCble_Gasto_x_cxp.TabIndex = 10;
            // 
            // cmb_IdCtaCble_Vta
            // 
            this.cmb_IdCtaCble_Vta.Location = new System.Drawing.Point(395, 301);
            this.cmb_IdCtaCble_Vta.Name = "cmb_IdCtaCble_Vta";
            this.cmb_IdCtaCble_Vta.Size = new System.Drawing.Size(286, 26);
            this.cmb_IdCtaCble_Vta.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(133, 180);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(243, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Cuenta general para devolucion en venta con IVA:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(133, 212);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(239, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Cuenta general para devolucion en venta sin IVA:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(134, 244);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(122, 13);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Cuenta general de costo:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(134, 276);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(233, 13);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "Cuenta general de gasto por cuentas por pagar:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(133, 308);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(124, 13);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "Cuenta general de venta:";
            // 
            // FrmIn_Producto_Winzard_Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 481);
            this.Controls.Add(this.wizardControlImportProducto);
            this.Name = "FrmIn_Producto_Winzard_Import";
            this.Text = "FrmIn_Producto_Winzard_Import";
            this.Load += new System.EventHandler(this.FrmIn_Producto_Winzard_Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlImportProducto)).EndInit();
            this.wizardControlImportProducto.ResumeLayout(false);
            this.WizardPageBienvenidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.wizardPageSeleccionExcel.ResumeLayout(false);
            this.wizardPageSeleccionExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.wizardPageFin.ResumeLayout(false);
            this.wizardPageFin.PerformLayout();
            this.wizardPageVerificacionYCargarData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).EndInit();
            this.wizardPageTipoDeIngresoDatos.ResumeLayout(false);
            this.wizardPageTipoDeIngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgImportar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControlImportProducto;
        private DevExpress.XtraWizard.WelcomeWizardPage WizardPageBienvenidos;
        private DevExpress.XtraWizard.WizardPage wizardPageSeleccionExcel;
        private DevExpress.XtraWizard.CompletionWizardPage wizardPageFin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblMsg1;
        private System.Windows.Forms.ComboBox cmbHoja;
        private System.Windows.Forms.Label lblHoja;
        private System.Windows.Forms.TextBox txtSeleccion;
        private System.Windows.Forms.Button btnSeleccion;
        private DevExpress.XtraWizard.WizardPage wizardPageVerificacionYCargarData;
        private DevExpress.XtraGrid.GridControl gridControlProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductos;
        private DevExpress.XtraWizard.WizardPage wizardPageTipoDeIngresoDatos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.RadioGroup rgImportar;
        private System.Windows.Forms.Label lblmsg3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.SaveFileDialog saveFileDialogProducto;
        private DevExpress.XtraWizard.WizardPage wizardPageEstadoGrabacion;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControlProceGrabado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProceGrabado;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCod_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstadoGrabado;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_imagen_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_producto;
        private DevExpress.XtraGrid.Columns.GridColumn ColTipoProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblNumRegistros;
        private System.Windows.Forms.ProgressBar progressBar;
        private DevExpress.XtraEditors.SimpleButton btn_procesar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoGrabado;
        private DevExpress.XtraGrid.Columns.GridColumn ColObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto2;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProductoTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colLinea;
        private DevExpress.XtraGrid.Columns.GridColumn colgrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colsubgrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_Marca;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private Controles.UCCon_PlanCtaCmb cmb_IdCtaCble_Des0;
        private Controles.UCCon_PlanCtaCmb cmb_IdCtaCble_DesIva;
        private Controles.UCCon_PlanCtaCmb cmb_IdCtaCble_Ven0;
        private Controles.UCCon_PlanCtaCmb cmb_IdCtaCble_VenIva;
        private Controles.UCCon_PlanCtaCmb cmb_IdCtaCble_Inven;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Controles.UCCon_PlanCtaCmb cmb_IdCtaCble_Vta;
        private Controles.UCCon_PlanCtaCmb cmb_IdCtaCble_Gasto_x_cxp;
        private Controles.UCCon_PlanCtaCmb cmb_IdCtaCble_Costo;
        private Controles.UCCon_PlanCtaCmb cmb_IdCtaCble_Dev0;
        private Controles.UCCon_PlanCtaCmb cmb_IdCtaCble_DevIva;
    }
}