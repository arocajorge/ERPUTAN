namespace Core.Erp.Winform.SeguridadAcceso
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonMenuTop = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imageCollection64_x_64 = new DevExpress.Utils.ImageCollection(this.components);
            this.btnMostrarMenu = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.listMdiChildren = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barStaticItem_param = new DevExpress.XtraBars.BarStaticItem();
            this.blcApariencia = new DevExpress.XtraBars.BarLinkContainerItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.barEditItem_Reportes = new DevExpress.XtraBars.BarEditItem();
            this.cmb_reportes = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodReporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCorto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormulario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVistaRpt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStore_proce_rpt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_Opcion_General = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_Reportes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_Otros = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemImageEditLogo = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dockManagerPaneles = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanelMenu = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucSeg_Menu_x_Usuario_x_Empresa1 = new Core.Erp.Winform.SeguridadAcceso.UCSeg_Menu_x_Usuario_x_Empresa();
            this.LBLMENSAJE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMenuTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection64_x_64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEditLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerPaneles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanelMenu.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonMenuTop
            // 
            this.ribbonMenuTop.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbonMenuTop.ApplicationIcon")));
            this.ribbonMenuTop.ExpandCollapseItem.Id = 0;
            this.ribbonMenuTop.ExpandCollapseItem.Name = "";
            this.ribbonMenuTop.Images = this.imageCollection64_x_64;
            this.ribbonMenuTop.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonMenuTop.ExpandCollapseItem,
            this.btnMostrarMenu,
            this.btnLogOut,
            this.btnSalir,
            this.listMdiChildren,
            this.barStaticItem_param,
            this.blcApariencia,
            this.barButtonItem1,
            this.barListItem1,
            this.barEditItem_Reportes,
            this.barStaticItem1});
            this.ribbonMenuTop.ItemsVertAlign = DevExpress.Utils.VertAlignment.Top;
            this.ribbonMenuTop.Location = new System.Drawing.Point(0, 0);
            this.ribbonMenuTop.MaxItemId = 20;
            this.ribbonMenuTop.Name = "ribbonMenuTop";
            this.ribbonMenuTop.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonMenuTop.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_reportes,
            this.repositoryItemImageEditLogo});
            this.ribbonMenuTop.Size = new System.Drawing.Size(1135, 144);
            this.ribbonMenuTop.StatusBar = this.ribbonStatusBar;
            this.ribbonMenuTop.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // imageCollection64_x_64
            // 
            this.imageCollection64_x_64.ImageSize = new System.Drawing.Size(128, 128);
            this.imageCollection64_x_64.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection64_x_64.ImageStream")));
            this.imageCollection64_x_64.Images.SetKeyName(0, "admin_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(1, "033.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(2, "083.png");
            this.imageCollection64_x_64.Images.SetKeyName(3, "18256_TRASH - FULL.png");
            this.imageCollection64_x_64.Images.SetKeyName(4, "85860-1.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(5, "1444334277_purchase_order.png");
            this.imageCollection64_x_64.Images.SetKeyName(6, "1444334314_Like.png");
            this.imageCollection64_x_64.Images.SetKeyName(7, "1444334352_icon-91.png");
            this.imageCollection64_x_64.Images.SetKeyName(8, "1444334445_Security_Denied.png");
            this.imageCollection64_x_64.Images.SetKeyName(9, "1444334548_Hourglass.png");
            this.imageCollection64_x_64.Images.SetKeyName(10, "1444334593_Send_mail.png");
            this.imageCollection64_x_64.Images.SetKeyName(11, "admin_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(12, "admin_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(13, "admin_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(14, "agregar.png");
            this.imageCollection64_x_64.Images.SetKeyName(15, "agregar_doc.png");
            this.imageCollection64_x_64.Images.SetKeyName(16, "agregar_mail_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(17, "agregar_mail_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(18, "agregar_mail_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(19, "agregar_money.png");
            this.imageCollection64_x_64.Images.SetKeyName(20, "agregar_user.png");
            this.imageCollection64_x_64.Images.SetKeyName(21, "agregar2.png");
            this.imageCollection64_x_64.Images.SetKeyName(22, "anterioes5.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(23, "anterior.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(24, "anular_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(25, "anular_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(26, "anular_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(27, "anular_user_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(28, "anular_user_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(29, "anular1_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(30, "anular1_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(31, "anular1_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(32, "anular2_32.x32png.png");
            this.imageCollection64_x_64.Images.SetKeyName(33, "anular2_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(34, "anular2_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(35, "applications_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(36, "applications_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(37, "applications128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(38, "Aprobado.png");
            this.imageCollection64_x_64.Images.SetKeyName(39, "Aprobado_sello.png");
            this.imageCollection64_x_64.Images.SetKeyName(40, "Banco_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(41, "Banco_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(42, "Bank_account_96x96.png");
            this.imageCollection64_x_64.Images.SetKeyName(43, "billetera1_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(44, "billetera1_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(45, "billetera1_106x108.png");
            this.imageCollection64_x_64.Images.SetKeyName(46, "bolso_compra_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(47, "bolso_compra_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(48, "buscar_binoculares_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(49, "buscar_binoculares_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(50, "buscar_binoculares_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(51, "buscar_carpeta_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(52, "buscar_carpeta_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(53, "buscar_carpeta_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(54, "buscar_doc_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(55, "buscar_file_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(56, "buscar_file_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(57, "buscar_file_128X128.png");
            this.imageCollection64_x_64.Images.SetKeyName(58, "buscar_file2_32X32.png");
            this.imageCollection64_x_64.Images.SetKeyName(59, "buscar_file2_64X64.png");
            this.imageCollection64_x_64.Images.SetKeyName(60, "buscar_file2_128X128.png");
            this.imageCollection64_x_64.Images.SetKeyName(61, "buscar_folder_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(62, "buscar_folder_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(63, "buscar_imagen_32X32.png");
            this.imageCollection64_x_64.Images.SetKeyName(64, "buscar_imagen_64X64.png");
            this.imageCollection64_x_64.Images.SetKeyName(65, "buscar_imagen_128X128.png");
            this.imageCollection64_x_64.Images.SetKeyName(66, "Buscar1_32X32.png");
            this.imageCollection64_x_64.Images.SetKeyName(67, "Buscar1_64X64.png");
            this.imageCollection64_x_64.Images.SetKeyName(68, "buscar1_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(69, "buscarPc_32X32.png");
            this.imageCollection64_x_64.Images.SetKeyName(70, "buscarPc_64X64.png");
            this.imageCollection64_x_64.Images.SetKeyName(71, "buscarPc_128X128.png");
            this.imageCollection64_x_64.Images.SetKeyName(72, "cancel_Cuotas_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(73, "cancel_Cuotas_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(74, "cancel_Cuotas_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(75, "cancel_doc_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(76, "cancel_doc_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(77, "cancel_doc_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(78, "candado.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(79, "celeste.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(80, "celeste1.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(81, "chard_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(82, "chart_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(83, "cheque_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(84, "cheque_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(85, "cheque_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(86, "cheque1_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(87, "cheque1_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(88, "cheque1_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(89, "cielo.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(90, "clean_desktop.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(91, "Column-Chart-icon.png");
            this.imageCollection64_x_64.Images.SetKeyName(92, "compras_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(93, "compras_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(94, "compras_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(95, "Computer-icon.png");
            this.imageCollection64_x_64.Images.SetKeyName(96, "condig-system.png");
            this.imageCollection64_x_64.Images.SetKeyName(97, "configurar_96x96.png");
            this.imageCollection64_x_64.Images.SetKeyName(98, "configurar_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(99, "configurar_movil_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(100, "consultar_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(101, "consultar_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(102, "consultar_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(103, "contabilidad_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(104, "contabilidad_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(105, "contabilidad_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(106, "contabilidad1_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(107, "contabilidad1_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(108, "crea-el-proximo-fondo-pantalla-kde-L-DwCFhn.png");
            this.imageCollection64_x_64.Images.SetKeyName(109, "curso.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(110, "curso_.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(111, "cursos.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(112, "custom-reports-icon.png");
            this.imageCollection64_x_64.Images.SetKeyName(113, "cxc_1.png");
            this.imageCollection64_x_64.Images.SetKeyName(114, "cxc_1_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(115, "cxc_1_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(116, "cxc_2_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(117, "cxc_2_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(118, "cxc_3_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(119, "cxc_3_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(120, "cxc_3_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(121, "cxp_1_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(122, "data-icon.png");
            this.imageCollection64_x_64.Images.SetKeyName(123, "dataimport.png");
            this.imageCollection64_x_64.Images.SetKeyName(124, "Deposito_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(125, "Deposito_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(126, "dinero_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(127, "Diseño_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(128, "Diseño_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(129, "Diseño_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(130, "document_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(131, "documento_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(132, "documento_aplicacion.png");
            this.imageCollection64_x_64.Images.SetKeyName(133, "Download.png");
            this.imageCollection64_x_64.Images.SetKeyName(134, "downloads1.png");
            this.imageCollection64_x_64.Images.SetKeyName(135, "edit_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(136, "edit_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(137, "editar_buscar_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(138, "editar_buscar_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(139, "editar1_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(140, "editar1_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(141, "editar2_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(142, "editar3_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(143, "editar3_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(144, "editar6_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(145, "editar6_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(146, "eliminar-la-basura-basura-basura-vacio-icono-7114-128.png");
            this.imageCollection64_x_64.Images.SetKeyName(147, "empleado_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(148, "empresa.png");
            this.imageCollection64_x_64.Images.SetKeyName(149, "entrega_48x48.png");
            this.imageCollection64_x_64.Images.SetKeyName(150, "excalmacion2.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(151, "Excel_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(152, "Excel_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(153, "Excel_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(154, "Excel-icon.png");
            this.imageCollection64_x_64.Images.SetKeyName(155, "Excel-icon_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(156, "Excel-icon_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(157, "Excel-icon_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(158, "exclamacion.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(159, "f7abc7f2.png");
            this.imageCollection64_x_64.Images.SetKeyName(160, "filter2_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(161, "filter2_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(162, "filter3_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(163, "filter3_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(164, "filtro1_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(165, "filtro1_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(166, "folder_downloads.png");
            this.imageCollection64_x_64.Images.SetKeyName(167, "fondo64.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(168, "fondoLogin.png");
            this.imageCollection64_x_64.Images.SetKeyName(169, "form_80x80.png");
            this.imageCollection64_x_64.Images.SetKeyName(170, "form_edit_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(171, "formulario_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(172, "formulario_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(173, "formulario_buscar_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(174, "formulario_edit_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(175, "formularios_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(176, "formularios_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(177, "formularios_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(178, "Generar_Periodos_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(179, "Generar_Periodos_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(180, "Generar_Periodos_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(181, "gnome-system-config.png");
            this.imageCollection64_x_64.Images.SetKeyName(182, "gnome-system-config_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(183, "gnome-system-config_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(184, "gnome-system-monitor.png");
            this.imageCollection64_x_64.Images.SetKeyName(185, "GUARDAR.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(186, "GUARDAR.png");
            this.imageCollection64_x_64.Images.SetKeyName(187, "guardar_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(188, "guardar_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(189, "guardar_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(190, "GUARDAR_SALIR.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(191, "GUARDAR_SALIR1.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(192, "guardar3_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(193, "guardar3_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(194, "guardar5_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(195, "guardar5_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(196, "guardarcomo1_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(197, "guardarcomo1_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(198, "GuardaryAceptar.png");
            this.imageCollection64_x_64.Images.SetKeyName(199, "guardarysalir.png");
            this.imageCollection64_x_64.Images.SetKeyName(200, "herramientas.png");
            this.imageCollection64_x_64.Images.SetKeyName(201, "historial_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(202, "home.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(203, "home.PNG");
            this.imageCollection64_x_64.Images.SetKeyName(204, "home1.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(205, "home1.PNG");
            this.imageCollection64_x_64.Images.SetKeyName(206, "Home-Server-icon.png");
            this.imageCollection64_x_64.Images.SetKeyName(207, "ico_anular3.png");
            this.imageCollection64_x_64.Images.SetKeyName(208, "Ico_Chard_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(209, "ico_guardar1.png");
            this.imageCollection64_x_64.Images.SetKeyName(210, "ico_guardar2.png");
            this.imageCollection64_x_64.Images.SetKeyName(211, "ico_guardar3.png");
            this.imageCollection64_x_64.Images.SetKeyName(212, "Ico_imprimir.png");
            this.imageCollection64_x_64.Images.SetKeyName(213, "Ico_Reporte.png");
            this.imageCollection64_x_64.Images.SetKeyName(214, "ico_sucursal.png");
            this.imageCollection64_x_64.Images.SetKeyName(215, "Ico-Edit-Clear_64.png");
            this.imageCollection64_x_64.Images.SetKeyName(216, "icon-recycle.png");
            this.imageCollection64_x_64.Images.SetKeyName(217, "icon-reports.png");
            this.imageCollection64_x_64.Images.SetKeyName(218, "Image1.png");
            this.imageCollection64_x_64.Images.SetKeyName(219, "images (1).jpg");
            this.imageCollection64_x_64.Images.SetKeyName(220, "images.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(221, "images.png");
            this.imageCollection64_x_64.Images.SetKeyName(222, "importacion_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(223, "imprimir_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(224, "Imprimir_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(225, "Imprimir_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(226, "imprimir5_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(227, "imprimir5_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(228, "inicio_menu_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(229, "insert1.png");
            this.imageCollection64_x_64.Images.SetKeyName(230, "Inventario_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(231, "Inventario_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(232, "Inventario_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(233, "Inventario1.png");
            this.imageCollection64_x_64.Images.SetKeyName(234, "inventario1_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(235, "inventario1_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(236, "inventario1_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(237, "invoice_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(238, "jornada.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(239, "jornada_.png");
            this.imageCollection64_x_64.Images.SetKeyName(240, "limpiar_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(241, "limpiar_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(242, "limpiar_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(243, "limpiar5_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(244, "login.png");
            this.imageCollection64_x_64.Images.SetKeyName(245, "login_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(246, "login_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(247, "login_225x225.png");
            this.imageCollection64_x_64.Images.SetKeyName(248, "LogoDesarrolloITCorp.png");
            this.imageCollection64_x_64.Images.SetKeyName(249, "logoItCorp.png");
            this.imageCollection64_x_64.Images.SetKeyName(250, "logoItCorp_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(251, "Mantenimiento_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(252, "Mantenimiento_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(253, "mas.png");
            this.imageCollection64_x_64.Images.SetKeyName(254, "menos.png");
            this.imageCollection64_x_64.Images.SetKeyName(255, "menu_edit_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(256, "menu_edit_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(257, "menu_edit_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(258, "Menu_Start1_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(259, "Menu_Start1_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(260, "Menu_start2_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(261, "Menu_start2_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(262, "Menu_Start3_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(263, "Menu_Start3_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(264, "Menu_start4_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(265, "Menu_start4_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(266, "Moneda_pila_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(267, "Moneda_pila_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(268, "Moneda_pila_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(269, "Money_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(270, "money-wallet-icon.png");
            this.imageCollection64_x_64.Images.SetKeyName(271, "monificar_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(272, "monificar_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(273, "monificar_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(274, "new-folder-system.png");
            this.imageCollection64_x_64.Images.SetKeyName(275, "nueva_folder1.png");
            this.imageCollection64_x_64.Images.SetKeyName(276, "nuevo_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(277, "nuevo_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(278, "nuevo_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(279, "nuevo2_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(280, "nuevo5_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(281, "ok_2_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(282, "ok_form1_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(283, "ok_form1_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(284, "ok_form1_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(285, "ok2_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(286, "ok2_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(287, "ok2_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(288, "ok3_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(289, "ok3_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(290, "ok3_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(291, "ok4_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(292, "ok4_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(293, "ok4_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(294, "pagar_.png");
            this.imageCollection64_x_64.Images.SetKeyName(295, "pagar_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(296, "pagar_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(297, "pagar_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(298, "para contraseña.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(299, "para contraseña1.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(300, "paralelo.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(301, "paypal_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(302, "plus-24844_640.png");
            this.imageCollection64_x_64.Images.SetKeyName(303, "preferences-system-session.png");
            this.imageCollection64_x_64.Images.SetKeyName(304, "preferences-system-windows-actions.png");
            this.imageCollection64_x_64.Images.SetKeyName(305, "printer_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(306, "printok_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(307, "Produccion_industrial_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(308, "Produccion_industrial_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(309, "Produccion_industrial_83x105.png");
            this.imageCollection64_x_64.Images.SetKeyName(310, "punto_venta_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(311, "purchase_order_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(312, "qrcode_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(313, "qrcode_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(314, "refresh_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(315, "refresh_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(316, "report_grafico_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(317, "report_ventas_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(318, "report-6.png");
            this.imageCollection64_x_64.Images.SetKeyName(319, "reportes.png");
            this.imageCollection64_x_64.Images.SetKeyName(320, "salir_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(321, "salir_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(322, "salir_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(323, "salir5_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(324, "sap-the-best-erp-wallpaper-by-CVOSOFT.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(325, "seccion.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(326, "sede_.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(327, "seguridad_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(328, "seguridad_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(329, "seguridad_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(330, "seguridadyaccesos.png");
            this.imageCollection64_x_64.Images.SetKeyName(331, "seguridadyaccesos_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(332, "seguridadyaccesos_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(333, "seguridadyaccesos_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(334, "services.png");
            this.imageCollection64_x_64.Images.SetKeyName(335, "servicios-informaticos_75x53.png");
            this.imageCollection64_x_64.Images.SetKeyName(336, "servicios-informaticos_150x105.png");
            this.imageCollection64_x_64.Images.SetKeyName(337, "subir.png");
            this.imageCollection64_x_64.Images.SetKeyName(338, "system Preferences.png");
            this.imageCollection64_x_64.Images.SetKeyName(339, "system-file-manager.png");
            this.imageCollection64_x_64.Images.SetKeyName(340, "system-lock-screen.png");
            this.imageCollection64_x_64.Images.SetKeyName(341, "system-software-update.png");
            this.imageCollection64_x_64.Images.SetKeyName(342, "table-add.png");
            this.imageCollection64_x_64.Images.SetKeyName(343, "table-colums.png");
            this.imageCollection64_x_64.Images.SetKeyName(344, "table-down.png");
            this.imageCollection64_x_64.Images.SetKeyName(345, "table-remove.png");
            this.imageCollection64_x_64.Images.SetKeyName(346, "text_documento_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(347, "Toolbox-Red-icon.png");
            this.imageCollection64_x_64.Images.SetKeyName(348, "transaccion_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(349, "trash-aqua-full-icon.png");
            this.imageCollection64_x_64.Images.SetKeyName(350, "update.png");
            this.imageCollection64_x_64.Images.SetKeyName(351, "user_accounts_config_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(352, "user_accounts_config_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(353, "user_accounts_config_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(354, "Usuario_acceso.png");
            this.imageCollection64_x_64.Images.SetKeyName(355, "Usuario_acceso1.png");
            this.imageCollection64_x_64.Images.SetKeyName(356, "ventas_icono.png");
            this.imageCollection64_x_64.Images.SetKeyName(357, "ventas_icono_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(358, "ventas_icono_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(359, "vzen-logo.jpg");
            this.imageCollection64_x_64.Images.SetKeyName(360, "vzen-logo_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(361, "vzen-logo_136x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(362, "Xml_32x32.png");
            this.imageCollection64_x_64.Images.SetKeyName(363, "Xml_64x64.png");
            this.imageCollection64_x_64.Images.SetKeyName(364, "Xml_128x128.png");
            this.imageCollection64_x_64.Images.SetKeyName(365, "zen-launcher_android.jpg");
            // 
            // btnMostrarMenu
            // 
            this.btnMostrarMenu.Caption = "Menu";
            this.btnMostrarMenu.Id = 1;
            this.btnMostrarMenu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnMostrarMenu.LargeGlyph")));
            this.btnMostrarMenu.LargeImageIndex = 0;
            this.btnMostrarMenu.LargeImageIndexDisabled = 0;
            this.btnMostrarMenu.Name = "btnMostrarMenu";
            this.btnMostrarMenu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnMostrarMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMostrarMenu_ItemClick);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "LogOut";
            this.btnLogOut.Id = 2;
            this.btnLogOut.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLogOut.LargeGlyph")));
            this.btnLogOut.LargeImageIndex = 3;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOut_ItemClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 5;
            this.btnSalir.LargeGlyph = global::Core.Erp.Winform.Properties.Resources.salir_64x64;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // listMdiChildren
            // 
            this.listMdiChildren.Caption = "Formularios";
            this.listMdiChildren.Id = 6;
            this.listMdiChildren.LargeGlyph = global::Core.Erp.Winform.Properties.Resources.formularios_128x128;
            this.listMdiChildren.Name = "listMdiChildren";
            // 
            // barStaticItem_param
            // 
            this.barStaticItem_param.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem_param.Id = 7;
            this.barStaticItem_param.Name = "barStaticItem_param";
            this.barStaticItem_param.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // blcApariencia
            // 
            this.blcApariencia.Caption = "Temas";
            this.blcApariencia.Id = 9;
            this.blcApariencia.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("blcApariencia.LargeGlyph")));
            this.blcApariencia.Name = "blcApariencia";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 14;
            this.barListItem1.Name = "barListItem1";
            // 
            // barEditItem_Reportes
            // 
            this.barEditItem_Reportes.Caption = "Reportes";
            this.barEditItem_Reportes.Edit = this.cmb_reportes;
            this.barEditItem_Reportes.Id = 16;
            this.barEditItem_Reportes.Name = "barEditItem_Reportes";
            this.barEditItem_Reportes.Width = 300;
            this.barEditItem_Reportes.EditValueChanged += new System.EventHandler(this.barEditItem_Reportes_EditValueChanged);
            // 
            // cmb_reportes
            // 
            this.cmb_reportes.AutoHeight = false;
            this.cmb_reportes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_reportes.DisplayMember = "Nombre";
            this.cmb_reportes.Name = "cmb_reportes";
            this.cmb_reportes.ValueMember = "CodReporte";
            this.cmb_reportes.View = this.repositoryItemSearchLookUpEdit2View;
            // 
            // repositoryItemSearchLookUpEdit2View
            // 
            this.repositoryItemSearchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodReporte,
            this.colNombre,
            this.colModulo,
            this.colNombreCorto,
            this.colFormulario,
            this.colVistaRpt,
            this.colObservacion,
            this.colStore_proce_rpt});
            this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            this.repositoryItemSearchLookUpEdit2View.OptionsFind.AlwaysVisible = true;
            this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colCodReporte
            // 
            this.colCodReporte.Caption = "IdReporte";
            this.colCodReporte.FieldName = "CodReporte";
            this.colCodReporte.Name = "colCodReporte";
            this.colCodReporte.Visible = true;
            this.colCodReporte.VisibleIndex = 0;
            this.colCodReporte.Width = 50;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 164;
            // 
            // colModulo
            // 
            this.colModulo.Caption = "Modulo";
            this.colModulo.FieldName = "Modulo";
            this.colModulo.Name = "colModulo";
            this.colModulo.Visible = true;
            this.colModulo.VisibleIndex = 2;
            this.colModulo.Width = 50;
            // 
            // colNombreCorto
            // 
            this.colNombreCorto.Caption = "NombreCorto";
            this.colNombreCorto.FieldName = "NombreCorto";
            this.colNombreCorto.Name = "colNombreCorto";
            this.colNombreCorto.Width = 163;
            // 
            // colFormulario
            // 
            this.colFormulario.Caption = "Formulario";
            this.colFormulario.FieldName = "Formulario";
            this.colFormulario.Name = "colFormulario";
            // 
            // colVistaRpt
            // 
            this.colVistaRpt.Caption = "VistaRpt";
            this.colVistaRpt.FieldName = "VistaRpt";
            this.colVistaRpt.Name = "colVistaRpt";
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observacion";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 3;
            this.colObservacion.Width = 120;
            // 
            // colStore_proce_rpt
            // 
            this.colStore_proce_rpt.Caption = "Store_proce_rpt";
            this.colStore_proce_rpt.FieldName = "Store_proce_rpt";
            this.colStore_proce_rpt.Name = "colStore_proce_rpt";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 17;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_Opcion_General,
            this.ribbonPageGroup_Reportes,
            this.ribbonPageGroup_Otros});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Inicio";
            // 
            // ribbonPageGroup_Opcion_General
            // 
            this.ribbonPageGroup_Opcion_General.ItemLinks.Add(this.btnMostrarMenu);
            this.ribbonPageGroup_Opcion_General.ItemLinks.Add(this.listMdiChildren);
            this.ribbonPageGroup_Opcion_General.ItemLinks.Add(this.blcApariencia);
            this.ribbonPageGroup_Opcion_General.Name = "ribbonPageGroup_Opcion_General";
            this.ribbonPageGroup_Opcion_General.Text = "Opciones Generales";
            // 
            // ribbonPageGroup_Reportes
            // 
            this.ribbonPageGroup_Reportes.ItemLinks.Add(this.barStaticItem1);
            this.ribbonPageGroup_Reportes.ItemLinks.Add(this.barEditItem_Reportes);
            this.ribbonPageGroup_Reportes.Name = "ribbonPageGroup_Reportes";
            this.ribbonPageGroup_Reportes.Text = "Reportes";
            // 
            // ribbonPageGroup_Otros
            // 
            this.ribbonPageGroup_Otros.ItemLinks.Add(this.btnLogOut);
            this.ribbonPageGroup_Otros.ItemLinks.Add(this.btnSalir);
            this.ribbonPageGroup_Otros.Name = "ribbonPageGroup_Otros";
            this.ribbonPageGroup_Otros.Text = "Otros";
            // 
            // repositoryItemImageEditLogo
            // 
            this.repositoryItemImageEditLogo.AutoHeight = false;
            this.repositoryItemImageEditLogo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEditLogo.Name = "repositoryItemImageEditLogo";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem_param);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 564);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonMenuTop;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1135, 31);
            // 
            // dockManagerPaneles
            // 
            this.dockManagerPaneles.Form = this;
            this.dockManagerPaneles.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelMenu});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanelMenu
            // 
            this.dockPanelMenu.Controls.Add(this.dockPanel1_Container);
            this.dockPanelMenu.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanelMenu.ID = new System.Guid("159fd171-eb52-4f90-acdf-2e9d2d41179c");
            this.dockPanelMenu.Location = new System.Drawing.Point(0, 144);
            this.dockPanelMenu.Name = "dockPanelMenu";
            this.dockPanelMenu.OriginalSize = new System.Drawing.Size(258, 200);
            this.dockPanelMenu.Size = new System.Drawing.Size(258, 420);
            this.dockPanelMenu.Text = "Menu";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.panel1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(250, 393);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucSeg_Menu_x_Usuario_x_Empresa1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 393);
            this.panel1.TabIndex = 1;
            // 
            // ucSeg_Menu_x_Usuario_x_Empresa1
            // 
            this.ucSeg_Menu_x_Usuario_x_Empresa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSeg_Menu_x_Usuario_x_Empresa1.Location = new System.Drawing.Point(0, 0);
            this.ucSeg_Menu_x_Usuario_x_Empresa1.Name = "ucSeg_Menu_x_Usuario_x_Empresa1";
            this.ucSeg_Menu_x_Usuario_x_Empresa1.Size = new System.Drawing.Size(250, 393);
            this.ucSeg_Menu_x_Usuario_x_Empresa1.TabIndex = 0;
            this.ucSeg_Menu_x_Usuario_x_Empresa1.Load += new System.EventHandler(this.ucSeg_Menu_x_Usuario_x_Empresa1_Load);
            // 
            // LBLMENSAJE
            // 
            this.LBLMENSAJE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LBLMENSAJE.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMENSAJE.ForeColor = System.Drawing.Color.Red;
            this.LBLMENSAJE.Location = new System.Drawing.Point(666, 97);
            this.LBLMENSAJE.Name = "LBLMENSAJE";
            this.LBLMENSAJE.Size = new System.Drawing.Size(301, 26);
            this.LBLMENSAJE.TabIndex = 4;
            this.LBLMENSAJE.Text = "AMBIENTE DE PRUEBAS";
            this.LBLMENSAJE.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1135, 595);
            this.Controls.Add(this.LBLMENSAJE);
            this.Controls.Add(this.dockPanelMenu);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonMenuTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonMenuTop;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMenuTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection64_x_64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEditLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerPaneles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanelMenu.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonMenuTop;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Opcion_General;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Docking.DockManager dockManagerPaneles;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelMenu;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarButtonItem btnMostrarMenu;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarMdiChildrenListItem listMdiChildren;
        private DevExpress.XtraBars.BarStaticItem barStaticItem_param;
        private DevExpress.XtraBars.BarLinkContainerItem blcApariencia;
        private UCSeg_Menu_x_Usuario_x_Empresa ucSeg_Menu_x_Usuario_x_Empresa1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.Utils.ImageCollection imageCollection64_x_64;
        private System.Windows.Forms.Label LBLMENSAJE;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Reportes;
        private DevExpress.XtraBars.BarEditItem barEditItem_Reportes;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_reportes;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colCodReporte;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colModulo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCorto;
        private DevExpress.XtraGrid.Columns.GridColumn colFormulario;
        private DevExpress.XtraGrid.Columns.GridColumn colVistaRpt;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colStore_proce_rpt;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Otros;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEditLogo;  
    }
}