namespace Core.Erp.Winform.SeguridadAcceso
{
    partial class FrmSeg_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeg_Menu));
            this.RibbonControlMenu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imageCollectionMenu_Ribbon = new DevExpress.Utils.ImageCollection();
            this.barButtonItem_Categ_Menu = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Pagina_Mod = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Grupo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Mover_Arriba = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Mover_Abajo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Anular = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Eliminar_Items = new DevExpress.XtraBars.BarButtonItem();
            this.barMenu = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemReporte = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemFormulario = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCate_Pag_Gru = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_Cate_Grup_Item = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupMover = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupItems_Trans = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucSeg_Propiedades1 = new Core.Erp.Winform.Controles.UCSeg_Propiedades();
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            this.groupControlTransacciones = new DevExpress.XtraEditors.GroupControl();
            this.treeListTransacciones = new DevExpress.XtraTreeList.TreeList();
            this.colDescripcion_t = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageCollection16_x_16 = new DevExpress.Utils.ImageCollection();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.groupControlMenu = new DevExpress.XtraEditors.GroupControl();
            this.treeListMenu = new DevExpress.XtraTreeList.TreeList();
            this.ColDescripcion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ColInfo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageCollection32_x_32 = new DevExpress.Utils.ImageCollection();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControlMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMenu_Ribbon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTransacciones)).BeginInit();
            this.groupControlTransacciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListTransacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection16_x_16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMenu)).BeginInit();
            this.groupControlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32_x_32)).BeginInit();
            this.SuspendLayout();
            // 
            // RibbonControlMenu
            // 
            this.RibbonControlMenu.ExpandCollapseItem.Id = 0;
            this.RibbonControlMenu.ExpandCollapseItem.Name = "";
            this.RibbonControlMenu.Images = this.imageCollectionMenu_Ribbon;
            this.RibbonControlMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RibbonControlMenu.ExpandCollapseItem,
            this.barButtonItem_Categ_Menu,
            this.barButtonItem_Pagina_Mod,
            this.barButtonItem_Grupo,
            this.barButtonItem_Mover_Arriba,
            this.barButtonItem_Mover_Abajo,
            this.barButtonItem_Anular,
            this.barButtonItem_Eliminar_Items,
            this.barMenu,
            this.barButtonItemReporte,
            this.barButtonItemFormulario});
            this.RibbonControlMenu.Location = new System.Drawing.Point(0, 0);
            this.RibbonControlMenu.MaxItemId = 20;
            this.RibbonControlMenu.Name = "RibbonControlMenu";
            this.RibbonControlMenu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageCate_Pag_Gru});
            this.RibbonControlMenu.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.RibbonControlMenu.Size = new System.Drawing.Size(1166, 96);
            this.RibbonControlMenu.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // imageCollectionMenu_Ribbon
            // 
            this.imageCollectionMenu_Ribbon.ImageSize = new System.Drawing.Size(64, 64);
            this.imageCollectionMenu_Ribbon.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionMenu_Ribbon.ImageStream")));
            this.imageCollectionMenu_Ribbon.Images.SetKeyName(0, "Menu_Start3_64x64.png");
            this.imageCollectionMenu_Ribbon.Images.SetKeyName(1, "insert1.png");
            this.imageCollectionMenu_Ribbon.Images.SetKeyName(2, "inventario1_128x128.png");
            this.imageCollectionMenu_Ribbon.Images.SetKeyName(3, "1446074659_Stock Index Up.png");
            this.imageCollectionMenu_Ribbon.Images.SetKeyName(4, "1446074667_Stock Index Down.png");
            this.imageCollectionMenu_Ribbon.Images.SetKeyName(5, "menos.png");
            this.imageCollectionMenu_Ribbon.Images.SetKeyName(6, "formulario_64x64.png");
            this.imageCollectionMenu_Ribbon.Images.SetKeyName(7, "anular2_64x64.png");
            this.imageCollectionMenu_Ribbon.Images.SetKeyName(8, "Report_128x128.png");
            this.imageCollectionMenu_Ribbon.Images.SetKeyName(9, "Add_128x128.png");
            // 
            // barButtonItem_Categ_Menu
            // 
            this.barButtonItem_Categ_Menu.Caption = "Agregar Categoria/Menu";
            this.barButtonItem_Categ_Menu.Id = 1;
            this.barButtonItem_Categ_Menu.ImageIndex = 0;
            this.barButtonItem_Categ_Menu.Name = "barButtonItem_Categ_Menu";
            this.barButtonItem_Categ_Menu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem_Categ_Menu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Categ_Menu_ItemClick);
            // 
            // barButtonItem_Pagina_Mod
            // 
            this.barButtonItem_Pagina_Mod.Caption = "Agregar Pagina/Modulo";
            this.barButtonItem_Pagina_Mod.Id = 2;
            this.barButtonItem_Pagina_Mod.ImageIndex = 1;
            this.barButtonItem_Pagina_Mod.Name = "barButtonItem_Pagina_Mod";
            this.barButtonItem_Pagina_Mod.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem_Pagina_Mod.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Pagina_Mod_ItemClick);
            // 
            // barButtonItem_Grupo
            // 
            this.barButtonItem_Grupo.Caption = "Agregar Grupo";
            this.barButtonItem_Grupo.Id = 3;
            this.barButtonItem_Grupo.ImageIndex = 2;
            this.barButtonItem_Grupo.Name = "barButtonItem_Grupo";
            this.barButtonItem_Grupo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem_Grupo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Grupo_ItemClick);
            // 
            // barButtonItem_Mover_Arriba
            // 
            this.barButtonItem_Mover_Arriba.Caption = "Mover Arriba";
            this.barButtonItem_Mover_Arriba.Id = 4;
            this.barButtonItem_Mover_Arriba.ImageIndex = 3;
            this.barButtonItem_Mover_Arriba.Name = "barButtonItem_Mover_Arriba";
            this.barButtonItem_Mover_Arriba.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem_Mover_Abajo
            // 
            this.barButtonItem_Mover_Abajo.Caption = "Mover Abajo";
            this.barButtonItem_Mover_Abajo.Id = 5;
            this.barButtonItem_Mover_Abajo.ImageIndex = 4;
            this.barButtonItem_Mover_Abajo.Name = "barButtonItem_Mover_Abajo";
            this.barButtonItem_Mover_Abajo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem_Anular
            // 
            this.barButtonItem_Anular.Caption = "Eliminar/Anular";
            this.barButtonItem_Anular.Id = 6;
            this.barButtonItem_Anular.ImageIndex = 5;
            this.barButtonItem_Anular.Name = "barButtonItem_Anular";
            this.barButtonItem_Anular.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem_Anular.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Anular_ItemClick);
            // 
            // barButtonItem_Eliminar_Items
            // 
            this.barButtonItem_Eliminar_Items.Caption = "Eliminar Items/Transcciones/Pantallas";
            this.barButtonItem_Eliminar_Items.Id = 8;
            this.barButtonItem_Eliminar_Items.ImageIndex = 7;
            this.barButtonItem_Eliminar_Items.Name = "barButtonItem_Eliminar_Items";
            this.barButtonItem_Eliminar_Items.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem_Eliminar_Items.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Eliminar_Items_ItemClick);
            // 
            // barMenu
            // 
            this.barMenu.Caption = "Agregar Items/Transacciones/Pantallas";
            this.barMenu.Id = 15;
            this.barMenu.ImageIndex = 9;
            this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemReporte),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemFormulario)});
            this.barMenu.Name = "barMenu";
            this.barMenu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItemReporte
            // 
            this.barButtonItemReporte.Caption = "Reporte";
            this.barButtonItemReporte.Id = 17;
            this.barButtonItemReporte.ImageIndex = 8;
            this.barButtonItemReporte.Name = "barButtonItemReporte";
            this.barButtonItemReporte.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItemReporte.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemReporte_ItemClick);
            // 
            // barButtonItemFormulario
            // 
            this.barButtonItemFormulario.Caption = "Formulario";
            this.barButtonItemFormulario.Id = 18;
            this.barButtonItemFormulario.ImageIndex = 6;
            this.barButtonItemFormulario.Name = "barButtonItemFormulario";
            this.barButtonItemFormulario.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemFormulario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Items_ItemClick);
            // 
            // ribbonPageCate_Pag_Gru
            // 
            this.ribbonPageCate_Pag_Gru.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_Cate_Grup_Item,
            this.ribbonPageGroupMover,
            this.ribbonPageGroupItems_Trans});
            this.ribbonPageCate_Pag_Gru.Name = "ribbonPageCate_Pag_Gru";
            // 
            // ribbonPageGroup_Cate_Grup_Item
            // 
            this.ribbonPageGroup_Cate_Grup_Item.ItemLinks.Add(this.barButtonItem_Categ_Menu);
            this.ribbonPageGroup_Cate_Grup_Item.ItemLinks.Add(this.barButtonItem_Pagina_Mod);
            this.ribbonPageGroup_Cate_Grup_Item.ItemLinks.Add(this.barButtonItem_Grupo);
            this.ribbonPageGroup_Cate_Grup_Item.Name = "ribbonPageGroup_Cate_Grup_Item";
            this.ribbonPageGroup_Cate_Grup_Item.Text = "Categorias/Grupos - Modulos/Items";
            // 
            // ribbonPageGroupMover
            // 
            this.ribbonPageGroupMover.ItemLinks.Add(this.barButtonItem_Mover_Arriba);
            this.ribbonPageGroupMover.ItemLinks.Add(this.barButtonItem_Mover_Abajo);
            this.ribbonPageGroupMover.ItemLinks.Add(this.barButtonItem_Anular);
            this.ribbonPageGroupMover.Name = "ribbonPageGroupMover";
            this.ribbonPageGroupMover.Text = "Mover";
            // 
            // ribbonPageGroupItems_Trans
            // 
            this.ribbonPageGroupItems_Trans.ItemLinks.Add(this.barMenu);
            this.ribbonPageGroupItems_Trans.ItemLinks.Add(this.barButtonItem_Eliminar_Items);
            this.ribbonPageGroupItems_Trans.Name = "ribbonPageGroupItems_Trans";
            this.ribbonPageGroupItems_Trans.Text = "Items/Transaccion - Pantallas";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1166, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucSeg_Propiedades1);
            this.panel1.Controls.Add(this.splitterControl2);
            this.panel1.Controls.Add(this.groupControlTransacciones);
            this.panel1.Controls.Add(this.splitterControl1);
            this.panel1.Controls.Add(this.groupControlMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 343);
            this.panel1.TabIndex = 2;
            // 
            // ucSeg_Propiedades1
            // 
            this.ucSeg_Propiedades1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSeg_Propiedades1.Location = new System.Drawing.Point(712, 0);
            this.ucSeg_Propiedades1.Name = "ucSeg_Propiedades1";
            this.ucSeg_Propiedades1.Size = new System.Drawing.Size(454, 343);
            this.ucSeg_Propiedades1.TabIndex = 9;
            this.ucSeg_Propiedades1.Load += new System.EventHandler(this.ucSeg_Propiedades1_Load);
            // 
            // splitterControl2
            // 
            this.splitterControl2.Location = new System.Drawing.Point(707, 0);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(5, 343);
            this.splitterControl2.TabIndex = 8;
            this.splitterControl2.TabStop = false;
            // 
            // groupControlTransacciones
            // 
            this.groupControlTransacciones.Controls.Add(this.treeListTransacciones);
            this.groupControlTransacciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControlTransacciones.Location = new System.Drawing.Point(344, 0);
            this.groupControlTransacciones.Name = "groupControlTransacciones";
            this.groupControlTransacciones.Size = new System.Drawing.Size(363, 343);
            this.groupControlTransacciones.TabIndex = 7;
            this.groupControlTransacciones.Text = "Transacciones disponibles";
            // 
            // treeListTransacciones
            // 
            this.treeListTransacciones.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDescripcion_t});
            this.treeListTransacciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListTransacciones.Location = new System.Drawing.Point(2, 21);
            this.treeListTransacciones.Name = "treeListTransacciones";
            this.treeListTransacciones.OptionsBehavior.DragNodes = true;
            this.treeListTransacciones.OptionsBehavior.Editable = false;
            this.treeListTransacciones.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListTransacciones.OptionsPrint.UsePrintStyles = true;
            this.treeListTransacciones.SelectImageList = this.imageCollection16_x_16;
            this.treeListTransacciones.Size = new System.Drawing.Size(359, 320);
            this.treeListTransacciones.TabIndex = 5;
            this.treeListTransacciones.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeListTransacciones_DragEnter);
            this.treeListTransacciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeListTransacciones_MouseDown);
            this.treeListTransacciones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeListTransacciones_MouseMove);
            this.treeListTransacciones.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeListTransacciones_MouseUp);
            // 
            // colDescripcion_t
            // 
            this.colDescripcion_t.Caption = "Descripción";
            this.colDescripcion_t.FieldName = "Descripcion";
            this.colDescripcion_t.MinWidth = 33;
            this.colDescripcion_t.Name = "colDescripcion_t";
            this.colDescripcion_t.Visible = true;
            this.colDescripcion_t.VisibleIndex = 0;
            this.colDescripcion_t.Width = 92;
            // 
            // imageCollection16_x_16
            // 
            this.imageCollection16_x_16.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection16_x_16.ImageStream")));
            this.imageCollection16_x_16.Images.SetKeyName(0, "Menu.png");
            this.imageCollection16_x_16.Images.SetKeyName(1, "Modulo.png");
            this.imageCollection16_x_16.Images.SetKeyName(2, "Grupo.png");
            this.imageCollection16_x_16.Images.SetKeyName(3, "Formulario.png");
            this.imageCollection16_x_16.Images.SetKeyName(4, "Reporte.png");
            this.imageCollection16_x_16.Images.SetKeyName(5, "033.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(6, "083.png");
            this.imageCollection16_x_16.Images.SetKeyName(7, "18256_TRASH - FULL.png");
            this.imageCollection16_x_16.Images.SetKeyName(8, "85860-1.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(9, "1444334277_purchase_order.png");
            this.imageCollection16_x_16.Images.SetKeyName(10, "1444334314_Like.png");
            this.imageCollection16_x_16.Images.SetKeyName(11, "1444334352_icon-91.png");
            this.imageCollection16_x_16.Images.SetKeyName(12, "1444334445_Security_Denied.png");
            this.imageCollection16_x_16.Images.SetKeyName(13, "1444334548_Hourglass.png");
            this.imageCollection16_x_16.Images.SetKeyName(14, "1444334593_Send_mail.png");
            this.imageCollection16_x_16.Images.SetKeyName(15, "1446074659_Stock Index Up.png");
            this.imageCollection16_x_16.Images.SetKeyName(16, "1446074667_Stock Index Down.png");
            this.imageCollection16_x_16.Images.SetKeyName(17, "admin_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(18, "admin_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(19, "admin_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(20, "agregar.png");
            this.imageCollection16_x_16.Images.SetKeyName(21, "agregar_doc.png");
            this.imageCollection16_x_16.Images.SetKeyName(22, "agregar_mail_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(23, "agregar_mail_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(24, "agregar_mail_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(25, "agregar_money.png");
            this.imageCollection16_x_16.Images.SetKeyName(26, "agregar_user.png");
            this.imageCollection16_x_16.Images.SetKeyName(27, "agregar2.png");
            this.imageCollection16_x_16.Images.SetKeyName(28, "anterioes5.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(29, "anterior.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(30, "anular_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(31, "anular_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(32, "anular_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(33, "anular_user_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(34, "anular_user_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(35, "anular1_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(36, "anular1_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(37, "anular1_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(38, "anular2_32.x32png.png");
            this.imageCollection16_x_16.Images.SetKeyName(39, "anular2_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(40, "anular2_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(41, "applications_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(42, "applications_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(43, "applications128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(44, "Aprobado.png");
            this.imageCollection16_x_16.Images.SetKeyName(45, "Aprobado_sello.png");
            this.imageCollection16_x_16.Images.SetKeyName(46, "Banco_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(47, "Banco_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(48, "Bank_account_96x96.png");
            this.imageCollection16_x_16.Images.SetKeyName(49, "billetera1_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(50, "billetera1_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(51, "billetera1_106x108.png");
            this.imageCollection16_x_16.Images.SetKeyName(52, "bolso_compra_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(53, "bolso_compra_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(54, "buscar_binoculares_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(55, "buscar_binoculares_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(56, "buscar_binoculares_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(57, "buscar_carpeta_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(58, "buscar_carpeta_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(59, "buscar_carpeta_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(60, "buscar_doc_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(61, "buscar_file_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(62, "buscar_file_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(63, "buscar_file_128X128.png");
            this.imageCollection16_x_16.Images.SetKeyName(64, "buscar_file2_32X32.png");
            this.imageCollection16_x_16.Images.SetKeyName(65, "buscar_file2_64X64.png");
            this.imageCollection16_x_16.Images.SetKeyName(66, "buscar_file2_128X128.png");
            this.imageCollection16_x_16.Images.SetKeyName(67, "buscar_folder_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(68, "buscar_folder_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(69, "buscar_imagen_32X32.png");
            this.imageCollection16_x_16.Images.SetKeyName(70, "buscar_imagen_64X64.png");
            this.imageCollection16_x_16.Images.SetKeyName(71, "buscar_imagen_128X128.png");
            this.imageCollection16_x_16.Images.SetKeyName(72, "Buscar1_32X32.png");
            this.imageCollection16_x_16.Images.SetKeyName(73, "Buscar1_64X64.png");
            this.imageCollection16_x_16.Images.SetKeyName(74, "buscar1_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(75, "buscarPc_32X32.png");
            this.imageCollection16_x_16.Images.SetKeyName(76, "buscarPc_64X64.png");
            this.imageCollection16_x_16.Images.SetKeyName(77, "buscarPc_128X128.png");
            this.imageCollection16_x_16.Images.SetKeyName(78, "cancel_Cuotas_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(79, "cancel_Cuotas_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(80, "cancel_Cuotas_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(81, "cancel_doc_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(82, "cancel_doc_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(83, "cancel_doc_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(84, "candado.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(85, "celeste.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(86, "celeste1.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(87, "chard_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(88, "chart_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(89, "cheque_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(90, "cheque_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(91, "cheque_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(92, "cheque1_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(93, "cheque1_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(94, "cheque1_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(95, "cielo.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(96, "clean_desktop.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(97, "Column-Chart-icon.png");
            this.imageCollection16_x_16.Images.SetKeyName(98, "compras_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(99, "compras_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(100, "compras_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(101, "Computer-icon.png");
            this.imageCollection16_x_16.Images.SetKeyName(102, "condig-system.png");
            this.imageCollection16_x_16.Images.SetKeyName(103, "configurar_96x96.png");
            this.imageCollection16_x_16.Images.SetKeyName(104, "configurar_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(105, "configurar_movil_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(106, "consultar_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(107, "consultar_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(108, "consultar_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(109, "contabilidad_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(110, "contabilidad_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(111, "contabilidad_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(112, "contabilidad1_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(113, "contabilidad1_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(114, "crea-el-proximo-fondo-pantalla-kde-L-DwCFhn.png");
            this.imageCollection16_x_16.Images.SetKeyName(115, "curso.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(116, "curso_.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(117, "cursos.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(118, "custom-reports-icon.png");
            this.imageCollection16_x_16.Images.SetKeyName(119, "cxc_1.png");
            this.imageCollection16_x_16.Images.SetKeyName(120, "cxc_1_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(121, "cxc_1_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(122, "cxc_2_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(123, "cxc_2_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(124, "cxc_3_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(125, "cxc_3_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(126, "cxc_3_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(127, "cxp_1_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(128, "data-icon.png");
            this.imageCollection16_x_16.Images.SetKeyName(129, "dataimport.png");
            this.imageCollection16_x_16.Images.SetKeyName(130, "Deposito_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(131, "Deposito_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(132, "dinero_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(133, "Diseño_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(134, "Diseño_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(135, "Diseño_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(136, "document_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(137, "documento_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(138, "documento_aplicacion.png");
            this.imageCollection16_x_16.Images.SetKeyName(139, "Download.png");
            this.imageCollection16_x_16.Images.SetKeyName(140, "downloads1.png");
            this.imageCollection16_x_16.Images.SetKeyName(141, "edit_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(142, "edit_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(143, "editar_buscar_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(144, "editar_buscar_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(145, "editar1_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(146, "editar1_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(147, "editar2_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(148, "editar3_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(149, "editar3_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(150, "editar6_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(151, "editar6_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(152, "eliminar-la-basura-basura-basura-vacio-icono-7114-128.png");
            this.imageCollection16_x_16.Images.SetKeyName(153, "empleado_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(154, "empresa.png");
            this.imageCollection16_x_16.Images.SetKeyName(155, "entrega_48x48.png");
            this.imageCollection16_x_16.Images.SetKeyName(156, "excalmacion2.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(157, "Excel_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(158, "Excel_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(159, "Excel_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(160, "Excel-icon.png");
            this.imageCollection16_x_16.Images.SetKeyName(161, "Excel-icon_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(162, "Excel-icon_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(163, "Excel-icon_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(164, "exclamacion.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(165, "f7abc7f2.png");
            this.imageCollection16_x_16.Images.SetKeyName(166, "filter2_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(167, "filter2_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(168, "filter3_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(169, "filter3_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(170, "filtro1_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(171, "filtro1_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(172, "folder_downloads.png");
            this.imageCollection16_x_16.Images.SetKeyName(173, "fondo64.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(174, "fondoLogin.png");
            this.imageCollection16_x_16.Images.SetKeyName(175, "form_80x80.png");
            this.imageCollection16_x_16.Images.SetKeyName(176, "form_edit_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(177, "formulario_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(178, "formulario_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(179, "formulario_buscar_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(180, "formulario_edit_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(181, "formularios_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(182, "formularios_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(183, "formularios_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(184, "Generar_Periodos_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(185, "Generar_Periodos_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(186, "Generar_Periodos_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(187, "gnome-system-config.png");
            this.imageCollection16_x_16.Images.SetKeyName(188, "gnome-system-config_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(189, "gnome-system-config_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(190, "gnome-system-monitor.png");
            this.imageCollection16_x_16.Images.SetKeyName(191, "GUARDAR.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(192, "GUARDAR.png");
            this.imageCollection16_x_16.Images.SetKeyName(193, "guardar_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(194, "guardar_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(195, "guardar_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(196, "GUARDAR_SALIR.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(197, "GUARDAR_SALIR1.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(198, "guardar3_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(199, "guardar3_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(200, "guardar5_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(201, "guardar5_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(202, "guardarcomo1_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(203, "guardarcomo1_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(204, "GuardaryAceptar.png");
            this.imageCollection16_x_16.Images.SetKeyName(205, "guardarysalir.png");
            this.imageCollection16_x_16.Images.SetKeyName(206, "herramientas.png");
            this.imageCollection16_x_16.Images.SetKeyName(207, "historial_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(208, "home.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(209, "home.PNG");
            this.imageCollection16_x_16.Images.SetKeyName(210, "home1.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(211, "home1.PNG");
            this.imageCollection16_x_16.Images.SetKeyName(212, "Home-Server-icon.png");
            this.imageCollection16_x_16.Images.SetKeyName(213, "ico_anular3.png");
            this.imageCollection16_x_16.Images.SetKeyName(214, "Ico_Chard_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(215, "ico_guardar1.png");
            this.imageCollection16_x_16.Images.SetKeyName(216, "ico_guardar2.png");
            this.imageCollection16_x_16.Images.SetKeyName(217, "ico_guardar3.png");
            this.imageCollection16_x_16.Images.SetKeyName(218, "Ico_imprimir.png");
            this.imageCollection16_x_16.Images.SetKeyName(219, "Ico_Reporte.png");
            this.imageCollection16_x_16.Images.SetKeyName(220, "ico_sucursal.png");
            this.imageCollection16_x_16.Images.SetKeyName(221, "Ico-Edit-Clear_64.png");
            this.imageCollection16_x_16.Images.SetKeyName(222, "icon-recycle.png");
            this.imageCollection16_x_16.Images.SetKeyName(223, "icon-reports.png");
            this.imageCollection16_x_16.Images.SetKeyName(224, "Image1.png");
            this.imageCollection16_x_16.Images.SetKeyName(225, "images (1).jpg");
            this.imageCollection16_x_16.Images.SetKeyName(226, "images.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(227, "images.png");
            this.imageCollection16_x_16.Images.SetKeyName(228, "importacion_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(229, "imprimir_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(230, "Imprimir_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(231, "Imprimir_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(232, "imprimir5_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(233, "imprimir5_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(234, "inicio_menu_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(235, "insert1.png");
            this.imageCollection16_x_16.Images.SetKeyName(236, "Inventario_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(237, "Inventario_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(238, "Inventario_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(239, "Inventario1.png");
            this.imageCollection16_x_16.Images.SetKeyName(240, "inventario1_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(241, "inventario1_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(242, "inventario1_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(243, "invoice_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(244, "jornada.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(245, "jornada_.png");
            this.imageCollection16_x_16.Images.SetKeyName(246, "limpiar_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(247, "limpiar_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(248, "limpiar_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(249, "limpiar5_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(250, "login.png");
            this.imageCollection16_x_16.Images.SetKeyName(251, "login_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(252, "login_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(253, "login_225x225.png");
            this.imageCollection16_x_16.Images.SetKeyName(254, "LogoDesarrolloITCorp.png");
            this.imageCollection16_x_16.Images.SetKeyName(255, "logoItCorp.png");
            this.imageCollection16_x_16.Images.SetKeyName(256, "logoItCorp_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(257, "Mantenimiento_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(258, "Mantenimiento_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(259, "mas.png");
            this.imageCollection16_x_16.Images.SetKeyName(260, "menos.png");
            this.imageCollection16_x_16.Images.SetKeyName(261, "menu_edit_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(262, "menu_edit_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(263, "menu_edit_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(264, "Menu_Start1_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(265, "Menu_Start1_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(266, "Menu_start2_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(267, "Menu_start2_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(268, "Menu_Start3_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(269, "Menu_Start3_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(270, "Menu_start4_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(271, "Menu_start4_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(272, "Moneda_pila_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(273, "Moneda_pila_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(274, "Moneda_pila_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(275, "Money_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(276, "money-wallet-icon.png");
            this.imageCollection16_x_16.Images.SetKeyName(277, "monificar_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(278, "monificar_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(279, "monificar_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(280, "new-folder-system.png");
            this.imageCollection16_x_16.Images.SetKeyName(281, "nueva_folder1.png");
            this.imageCollection16_x_16.Images.SetKeyName(282, "nuevo_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(283, "nuevo_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(284, "nuevo_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(285, "nuevo2_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(286, "nuevo5_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(287, "ok_2_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(288, "ok_form1_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(289, "ok_form1_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(290, "ok_form1_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(291, "ok2_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(292, "ok2_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(293, "ok2_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(294, "ok3_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(295, "ok3_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(296, "ok3_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(297, "ok4_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(298, "ok4_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(299, "ok4_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(300, "pagar_.png");
            this.imageCollection16_x_16.Images.SetKeyName(301, "pagar_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(302, "pagar_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(303, "pagar_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(304, "para contraseña.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(305, "para contraseña1.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(306, "paralelo.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(307, "paypal_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(308, "plus-24844_640.png");
            this.imageCollection16_x_16.Images.SetKeyName(309, "preferences-system-session.png");
            this.imageCollection16_x_16.Images.SetKeyName(310, "preferences-system-windows-actions.png");
            this.imageCollection16_x_16.Images.SetKeyName(311, "printer_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(312, "printok_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(313, "Produccion_industrial_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(314, "Produccion_industrial_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(315, "Produccion_industrial_83x105.png");
            this.imageCollection16_x_16.Images.SetKeyName(316, "punto_venta_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(317, "purchase_order_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(318, "qrcode_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(319, "qrcode_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(320, "refresh_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(321, "refresh_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(322, "report_grafico_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(323, "report_ventas_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(324, "report-6.png");
            this.imageCollection16_x_16.Images.SetKeyName(325, "reportes.png");
            this.imageCollection16_x_16.Images.SetKeyName(326, "salir_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(327, "salir_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(328, "salir_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(329, "salir5_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(330, "sap-the-best-erp-wallpaper-by-CVOSOFT.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(331, "seccion.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(332, "sede_.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(333, "seguridad_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(334, "seguridad_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(335, "seguridad_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(336, "seguridadyaccesos.png");
            this.imageCollection16_x_16.Images.SetKeyName(337, "seguridadyaccesos_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(338, "seguridadyaccesos_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(339, "seguridadyaccesos_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(340, "services.png");
            this.imageCollection16_x_16.Images.SetKeyName(341, "servicios-informaticos_75x53.png");
            this.imageCollection16_x_16.Images.SetKeyName(342, "servicios-informaticos_150x105.png");
            this.imageCollection16_x_16.Images.SetKeyName(343, "subir.png");
            this.imageCollection16_x_16.Images.SetKeyName(344, "system Preferences.png");
            this.imageCollection16_x_16.Images.SetKeyName(345, "system-file-manager.png");
            this.imageCollection16_x_16.Images.SetKeyName(346, "system-lock-screen.png");
            this.imageCollection16_x_16.Images.SetKeyName(347, "system-software-update.png");
            this.imageCollection16_x_16.Images.SetKeyName(348, "table-add.png");
            this.imageCollection16_x_16.Images.SetKeyName(349, "table-colums.png");
            this.imageCollection16_x_16.Images.SetKeyName(350, "table-down.png");
            this.imageCollection16_x_16.Images.SetKeyName(351, "table-remove.png");
            this.imageCollection16_x_16.Images.SetKeyName(352, "text_documento_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(353, "Toolbox-Red-icon.png");
            this.imageCollection16_x_16.Images.SetKeyName(354, "transaccion_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(355, "trash-aqua-full-icon.png");
            this.imageCollection16_x_16.Images.SetKeyName(356, "update.png");
            this.imageCollection16_x_16.Images.SetKeyName(357, "user_accounts_config_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(358, "user_accounts_config_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(359, "user_accounts_config_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(360, "Usuario_acceso.png");
            this.imageCollection16_x_16.Images.SetKeyName(361, "Usuario_acceso1.png");
            this.imageCollection16_x_16.Images.SetKeyName(362, "ventas_icono.png");
            this.imageCollection16_x_16.Images.SetKeyName(363, "ventas_icono_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(364, "ventas_icono_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(365, "vzen-logo.jpg");
            this.imageCollection16_x_16.Images.SetKeyName(366, "vzen-logo_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(367, "vzen-logo_136x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(368, "Xml_32x32.png");
            this.imageCollection16_x_16.Images.SetKeyName(369, "Xml_64x64.png");
            this.imageCollection16_x_16.Images.SetKeyName(370, "Xml_128x128.png");
            this.imageCollection16_x_16.Images.SetKeyName(371, "zen-launcher_android.jpg");
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(339, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 343);
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.TabStop = false;
            // 
            // groupControlMenu
            // 
            this.groupControlMenu.Controls.Add(this.treeListMenu);
            this.groupControlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControlMenu.Location = new System.Drawing.Point(0, 0);
            this.groupControlMenu.Name = "groupControlMenu";
            this.groupControlMenu.Size = new System.Drawing.Size(339, 343);
            this.groupControlMenu.TabIndex = 5;
            this.groupControlMenu.Text = "Menú";
            // 
            // treeListMenu
            // 
            this.treeListMenu.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.ColDescripcion,
            this.ColInfo});
            this.treeListMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMenu.Location = new System.Drawing.Point(2, 21);
            this.treeListMenu.Name = "treeListMenu";
            this.treeListMenu.OptionsBehavior.DragNodes = true;
            this.treeListMenu.OptionsBehavior.Editable = false;
            this.treeListMenu.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListMenu.SelectImageList = this.imageCollection16_x_16;
            this.treeListMenu.Size = new System.Drawing.Size(335, 320);
            this.treeListMenu.TabIndex = 0;
            this.treeListMenu.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeListMenu_DragDrop);
            this.treeListMenu.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeListMenu_DragEnter);
            this.treeListMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeListMenu_MouseUp);
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.Caption = "Descripción";
            this.ColDescripcion.FieldName = "Descripcion";
            this.ColDescripcion.MinWidth = 33;
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.Visible = true;
            this.ColDescripcion.VisibleIndex = 0;
            this.ColDescripcion.Width = 709;
            // 
            // ColInfo
            // 
            this.ColInfo.Caption = "*";
            this.ColInfo.FieldName = "*";
            this.ColInfo.MinWidth = 33;
            this.ColInfo.Name = "ColInfo";
            this.ColInfo.Width = 45;
            // 
            // imageCollection32_x_32
            // 
            this.imageCollection32_x_32.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection32_x_32.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection32_x_32.ImageStream")));
            this.imageCollection32_x_32.Images.SetKeyName(0, "Menu.png");
            this.imageCollection32_x_32.Images.SetKeyName(1, "Modulo.png");
            this.imageCollection32_x_32.Images.SetKeyName(2, "Grupo.png");
            this.imageCollection32_x_32.Images.SetKeyName(3, "Formulario.png");
            this.imageCollection32_x_32.Images.SetKeyName(4, "Reporte.png");
            this.imageCollection32_x_32.Images.SetKeyName(5, "033.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(6, "083.png");
            this.imageCollection32_x_32.Images.SetKeyName(7, "18256_TRASH - FULL.png");
            this.imageCollection32_x_32.Images.SetKeyName(8, "85860-1.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(9, "1444334277_purchase_order.png");
            this.imageCollection32_x_32.Images.SetKeyName(10, "1444334314_Like.png");
            this.imageCollection32_x_32.Images.SetKeyName(11, "1444334352_icon-91.png");
            this.imageCollection32_x_32.Images.SetKeyName(12, "1444334445_Security_Denied.png");
            this.imageCollection32_x_32.Images.SetKeyName(13, "1444334548_Hourglass.png");
            this.imageCollection32_x_32.Images.SetKeyName(14, "1444334593_Send_mail.png");
            this.imageCollection32_x_32.Images.SetKeyName(15, "1446074659_Stock Index Up.png");
            this.imageCollection32_x_32.Images.SetKeyName(16, "1446074667_Stock Index Down.png");
            this.imageCollection32_x_32.Images.SetKeyName(17, "admin_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(18, "admin_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(19, "admin_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(20, "agregar.png");
            this.imageCollection32_x_32.Images.SetKeyName(21, "agregar_doc.png");
            this.imageCollection32_x_32.Images.SetKeyName(22, "agregar_mail_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(23, "agregar_mail_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(24, "agregar_mail_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(25, "agregar_money.png");
            this.imageCollection32_x_32.Images.SetKeyName(26, "agregar_user.png");
            this.imageCollection32_x_32.Images.SetKeyName(27, "agregar2.png");
            this.imageCollection32_x_32.Images.SetKeyName(28, "anterioes5.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(29, "anterior.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(30, "anular_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(31, "anular_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(32, "anular_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(33, "anular_user_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(34, "anular_user_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(35, "anular1_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(36, "anular1_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(37, "anular1_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(38, "anular2_32.x32png.png");
            this.imageCollection32_x_32.Images.SetKeyName(39, "anular2_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(40, "anular2_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(41, "applications_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(42, "applications_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(43, "applications128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(44, "Aprobado.png");
            this.imageCollection32_x_32.Images.SetKeyName(45, "Aprobado_sello.png");
            this.imageCollection32_x_32.Images.SetKeyName(46, "Banco_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(47, "Banco_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(48, "Bank_account_96x96.png");
            this.imageCollection32_x_32.Images.SetKeyName(49, "billetera1_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(50, "billetera1_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(51, "billetera1_106x108.png");
            this.imageCollection32_x_32.Images.SetKeyName(52, "bolso_compra_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(53, "bolso_compra_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(54, "buscar_binoculares_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(55, "buscar_binoculares_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(56, "buscar_binoculares_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(57, "buscar_carpeta_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(58, "buscar_carpeta_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(59, "buscar_carpeta_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(60, "buscar_doc_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(61, "buscar_file_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(62, "buscar_file_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(63, "buscar_file_128X128.png");
            this.imageCollection32_x_32.Images.SetKeyName(64, "buscar_file2_32X32.png");
            this.imageCollection32_x_32.Images.SetKeyName(65, "buscar_file2_64X64.png");
            this.imageCollection32_x_32.Images.SetKeyName(66, "buscar_file2_128X128.png");
            this.imageCollection32_x_32.Images.SetKeyName(67, "buscar_folder_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(68, "buscar_folder_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(69, "buscar_imagen_32X32.png");
            this.imageCollection32_x_32.Images.SetKeyName(70, "buscar_imagen_64X64.png");
            this.imageCollection32_x_32.Images.SetKeyName(71, "buscar_imagen_128X128.png");
            this.imageCollection32_x_32.Images.SetKeyName(72, "Buscar1_32X32.png");
            this.imageCollection32_x_32.Images.SetKeyName(73, "Buscar1_64X64.png");
            this.imageCollection32_x_32.Images.SetKeyName(74, "buscar1_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(75, "buscarPc_32X32.png");
            this.imageCollection32_x_32.Images.SetKeyName(76, "buscarPc_64X64.png");
            this.imageCollection32_x_32.Images.SetKeyName(77, "buscarPc_128X128.png");
            this.imageCollection32_x_32.Images.SetKeyName(78, "cancel_Cuotas_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(79, "cancel_Cuotas_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(80, "cancel_Cuotas_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(81, "cancel_doc_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(82, "cancel_doc_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(83, "cancel_doc_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(84, "candado.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(85, "celeste.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(86, "celeste1.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(87, "chard_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(88, "chart_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(89, "cheque_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(90, "cheque_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(91, "cheque_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(92, "cheque1_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(93, "cheque1_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(94, "cheque1_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(95, "cielo.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(96, "clean_desktop.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(97, "Column-Chart-icon.png");
            this.imageCollection32_x_32.Images.SetKeyName(98, "compras_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(99, "compras_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(100, "compras_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(101, "Computer-icon.png");
            this.imageCollection32_x_32.Images.SetKeyName(102, "condig-system.png");
            this.imageCollection32_x_32.Images.SetKeyName(103, "configurar_96x96.png");
            this.imageCollection32_x_32.Images.SetKeyName(104, "configurar_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(105, "configurar_movil_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(106, "consultar_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(107, "consultar_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(108, "consultar_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(109, "contabilidad_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(110, "contabilidad_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(111, "contabilidad_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(112, "contabilidad1_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(113, "contabilidad1_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(114, "crea-el-proximo-fondo-pantalla-kde-L-DwCFhn.png");
            this.imageCollection32_x_32.Images.SetKeyName(115, "curso.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(116, "curso_.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(117, "cursos.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(118, "custom-reports-icon.png");
            this.imageCollection32_x_32.Images.SetKeyName(119, "cxc_1.png");
            this.imageCollection32_x_32.Images.SetKeyName(120, "cxc_1_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(121, "cxc_1_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(122, "cxc_2_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(123, "cxc_2_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(124, "cxc_3_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(125, "cxc_3_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(126, "cxc_3_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(127, "cxp_1_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(128, "data-icon.png");
            this.imageCollection32_x_32.Images.SetKeyName(129, "dataimport.png");
            this.imageCollection32_x_32.Images.SetKeyName(130, "Deposito_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(131, "Deposito_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(132, "dinero_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(133, "Diseño_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(134, "Diseño_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(135, "Diseño_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(136, "document_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(137, "documento_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(138, "documento_aplicacion.png");
            this.imageCollection32_x_32.Images.SetKeyName(139, "Download.png");
            this.imageCollection32_x_32.Images.SetKeyName(140, "downloads1.png");
            this.imageCollection32_x_32.Images.SetKeyName(141, "edit_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(142, "edit_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(143, "editar_buscar_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(144, "editar_buscar_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(145, "editar1_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(146, "editar1_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(147, "editar2_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(148, "editar3_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(149, "editar3_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(150, "editar6_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(151, "editar6_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(152, "eliminar-la-basura-basura-basura-vacio-icono-7114-128.png");
            this.imageCollection32_x_32.Images.SetKeyName(153, "empleado_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(154, "empresa.png");
            this.imageCollection32_x_32.Images.SetKeyName(155, "entrega_48x48.png");
            this.imageCollection32_x_32.Images.SetKeyName(156, "excalmacion2.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(157, "Excel_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(158, "Excel_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(159, "Excel_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(160, "Excel-icon.png");
            this.imageCollection32_x_32.Images.SetKeyName(161, "Excel-icon_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(162, "Excel-icon_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(163, "Excel-icon_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(164, "exclamacion.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(165, "f7abc7f2.png");
            this.imageCollection32_x_32.Images.SetKeyName(166, "filter2_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(167, "filter2_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(168, "filter3_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(169, "filter3_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(170, "filtro1_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(171, "filtro1_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(172, "folder_downloads.png");
            this.imageCollection32_x_32.Images.SetKeyName(173, "fondo64.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(174, "fondoLogin.png");
            this.imageCollection32_x_32.Images.SetKeyName(175, "form_80x80.png");
            this.imageCollection32_x_32.Images.SetKeyName(176, "form_edit_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(177, "formulario_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(178, "formulario_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(179, "formulario_buscar_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(180, "formulario_edit_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(181, "formularios_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(182, "formularios_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(183, "formularios_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(184, "Generar_Periodos_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(185, "Generar_Periodos_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(186, "Generar_Periodos_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(187, "gnome-system-config.png");
            this.imageCollection32_x_32.Images.SetKeyName(188, "gnome-system-config_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(189, "gnome-system-config_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(190, "gnome-system-monitor.png");
            this.imageCollection32_x_32.Images.SetKeyName(191, "GUARDAR.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(192, "GUARDAR.png");
            this.imageCollection32_x_32.Images.SetKeyName(193, "guardar_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(194, "guardar_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(195, "guardar_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(196, "GUARDAR_SALIR.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(197, "GUARDAR_SALIR1.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(198, "guardar3_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(199, "guardar3_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(200, "guardar5_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(201, "guardar5_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(202, "guardarcomo1_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(203, "guardarcomo1_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(204, "GuardaryAceptar.png");
            this.imageCollection32_x_32.Images.SetKeyName(205, "guardarysalir.png");
            this.imageCollection32_x_32.Images.SetKeyName(206, "herramientas.png");
            this.imageCollection32_x_32.Images.SetKeyName(207, "historial_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(208, "home.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(209, "home.PNG");
            this.imageCollection32_x_32.Images.SetKeyName(210, "home1.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(211, "home1.PNG");
            this.imageCollection32_x_32.Images.SetKeyName(212, "Home-Server-icon.png");
            this.imageCollection32_x_32.Images.SetKeyName(213, "ico_anular3.png");
            this.imageCollection32_x_32.Images.SetKeyName(214, "Ico_Chard_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(215, "ico_guardar1.png");
            this.imageCollection32_x_32.Images.SetKeyName(216, "ico_guardar2.png");
            this.imageCollection32_x_32.Images.SetKeyName(217, "ico_guardar3.png");
            this.imageCollection32_x_32.Images.SetKeyName(218, "Ico_imprimir.png");
            this.imageCollection32_x_32.Images.SetKeyName(219, "Ico_Reporte.png");
            this.imageCollection32_x_32.Images.SetKeyName(220, "ico_sucursal.png");
            this.imageCollection32_x_32.Images.SetKeyName(221, "Ico-Edit-Clear_64.png");
            this.imageCollection32_x_32.Images.SetKeyName(222, "icon-recycle.png");
            this.imageCollection32_x_32.Images.SetKeyName(223, "icon-reports.png");
            this.imageCollection32_x_32.Images.SetKeyName(224, "Image1.png");
            this.imageCollection32_x_32.Images.SetKeyName(225, "images (1).jpg");
            this.imageCollection32_x_32.Images.SetKeyName(226, "images.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(227, "images.png");
            this.imageCollection32_x_32.Images.SetKeyName(228, "importacion_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(229, "imprimir_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(230, "Imprimir_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(231, "Imprimir_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(232, "imprimir5_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(233, "imprimir5_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(234, "inicio_menu_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(235, "insert1.png");
            this.imageCollection32_x_32.Images.SetKeyName(236, "Inventario_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(237, "Inventario_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(238, "Inventario_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(239, "Inventario1.png");
            this.imageCollection32_x_32.Images.SetKeyName(240, "inventario1_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(241, "inventario1_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(242, "inventario1_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(243, "invoice_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(244, "jornada.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(245, "jornada_.png");
            this.imageCollection32_x_32.Images.SetKeyName(246, "limpiar_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(247, "limpiar_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(248, "limpiar_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(249, "limpiar5_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(250, "login.png");
            this.imageCollection32_x_32.Images.SetKeyName(251, "login_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(252, "login_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(253, "login_225x225.png");
            this.imageCollection32_x_32.Images.SetKeyName(254, "LogoDesarrolloITCorp.png");
            this.imageCollection32_x_32.Images.SetKeyName(255, "logoItCorp.png");
            this.imageCollection32_x_32.Images.SetKeyName(256, "logoItCorp_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(257, "Mantenimiento_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(258, "Mantenimiento_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(259, "mas.png");
            this.imageCollection32_x_32.Images.SetKeyName(260, "menos.png");
            this.imageCollection32_x_32.Images.SetKeyName(261, "menu_edit_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(262, "menu_edit_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(263, "menu_edit_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(264, "Menu_Start1_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(265, "Menu_Start1_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(266, "Menu_start2_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(267, "Menu_start2_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(268, "Menu_Start3_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(269, "Menu_Start3_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(270, "Menu_start4_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(271, "Menu_start4_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(272, "Moneda_pila_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(273, "Moneda_pila_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(274, "Moneda_pila_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(275, "Money_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(276, "money-wallet-icon.png");
            this.imageCollection32_x_32.Images.SetKeyName(277, "monificar_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(278, "monificar_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(279, "monificar_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(280, "new-folder-system.png");
            this.imageCollection32_x_32.Images.SetKeyName(281, "nueva_folder1.png");
            this.imageCollection32_x_32.Images.SetKeyName(282, "nuevo_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(283, "nuevo_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(284, "nuevo_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(285, "nuevo2_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(286, "nuevo5_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(287, "ok_2_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(288, "ok_form1_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(289, "ok_form1_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(290, "ok_form1_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(291, "ok2_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(292, "ok2_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(293, "ok2_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(294, "ok3_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(295, "ok3_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(296, "ok3_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(297, "ok4_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(298, "ok4_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(299, "ok4_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(300, "pagar_.png");
            this.imageCollection32_x_32.Images.SetKeyName(301, "pagar_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(302, "pagar_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(303, "pagar_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(304, "para contraseña.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(305, "para contraseña1.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(306, "paralelo.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(307, "paypal_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(308, "plus-24844_640.png");
            this.imageCollection32_x_32.Images.SetKeyName(309, "preferences-system-session.png");
            this.imageCollection32_x_32.Images.SetKeyName(310, "preferences-system-windows-actions.png");
            this.imageCollection32_x_32.Images.SetKeyName(311, "printer_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(312, "printok_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(313, "Produccion_industrial_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(314, "Produccion_industrial_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(315, "Produccion_industrial_83x105.png");
            this.imageCollection32_x_32.Images.SetKeyName(316, "punto_venta_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(317, "purchase_order_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(318, "qrcode_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(319, "qrcode_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(320, "refresh_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(321, "refresh_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(322, "report_grafico_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(323, "report_ventas_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(324, "report-6.png");
            this.imageCollection32_x_32.Images.SetKeyName(325, "reportes.png");
            this.imageCollection32_x_32.Images.SetKeyName(326, "salir_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(327, "salir_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(328, "salir_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(329, "salir5_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(330, "sap-the-best-erp-wallpaper-by-CVOSOFT.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(331, "seccion.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(332, "sede_.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(333, "seguridad_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(334, "seguridad_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(335, "seguridad_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(336, "seguridadyaccesos.png");
            this.imageCollection32_x_32.Images.SetKeyName(337, "seguridadyaccesos_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(338, "seguridadyaccesos_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(339, "seguridadyaccesos_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(340, "services.png");
            this.imageCollection32_x_32.Images.SetKeyName(341, "servicios-informaticos_75x53.png");
            this.imageCollection32_x_32.Images.SetKeyName(342, "servicios-informaticos_150x105.png");
            this.imageCollection32_x_32.Images.SetKeyName(343, "subir.png");
            this.imageCollection32_x_32.Images.SetKeyName(344, "system Preferences.png");
            this.imageCollection32_x_32.Images.SetKeyName(345, "system-file-manager.png");
            this.imageCollection32_x_32.Images.SetKeyName(346, "system-lock-screen.png");
            this.imageCollection32_x_32.Images.SetKeyName(347, "system-software-update.png");
            this.imageCollection32_x_32.Images.SetKeyName(348, "table-add.png");
            this.imageCollection32_x_32.Images.SetKeyName(349, "table-colums.png");
            this.imageCollection32_x_32.Images.SetKeyName(350, "table-down.png");
            this.imageCollection32_x_32.Images.SetKeyName(351, "table-remove.png");
            this.imageCollection32_x_32.Images.SetKeyName(352, "text_documento_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(353, "Toolbox-Red-icon.png");
            this.imageCollection32_x_32.Images.SetKeyName(354, "transaccion_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(355, "trash-aqua-full-icon.png");
            this.imageCollection32_x_32.Images.SetKeyName(356, "update.png");
            this.imageCollection32_x_32.Images.SetKeyName(357, "user_accounts_config_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(358, "user_accounts_config_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(359, "user_accounts_config_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(360, "Usuario_acceso.png");
            this.imageCollection32_x_32.Images.SetKeyName(361, "Usuario_acceso1.png");
            this.imageCollection32_x_32.Images.SetKeyName(362, "ventas_icono.png");
            this.imageCollection32_x_32.Images.SetKeyName(363, "ventas_icono_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(364, "ventas_icono_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(365, "vzen-logo.jpg");
            this.imageCollection32_x_32.Images.SetKeyName(366, "vzen-logo_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(367, "vzen-logo_136x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(368, "Xml_32x32.png");
            this.imageCollection32_x_32.Images.SetKeyName(369, "Xml_64x64.png");
            this.imageCollection32_x_32.Images.SetKeyName(370, "Xml_128x128.png");
            this.imageCollection32_x_32.Images.SetKeyName(371, "zen-launcher_android.jpg");
            // 
            // FrmSeg_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.RibbonControlMenu);
            this.Name = "FrmSeg_Menu";
            this.Text = "FrmSeg_Menu";
            this.Load += new System.EventHandler(this.FrmSeg_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControlMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMenu_Ribbon)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTransacciones)).EndInit();
            this.groupControlTransacciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListTransacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection16_x_16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMenu)).EndInit();
            this.groupControlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32_x_32)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl RibbonControlMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCate_Pag_Gru;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Cate_Grup_Item;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraTreeList.TreeList treeListMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Categ_Menu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Pagina_Mod;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Grupo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Mover_Arriba;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Mover_Abajo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Anular;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Eliminar_Items;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupMover;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupItems_Trans;
        private DevExpress.Utils.ImageCollection imageCollectionMenu_Ribbon;
        private DevExpress.Utils.ImageCollection imageCollection16_x_16;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ColInfo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ColDescripcion;
        private DevExpress.XtraEditors.GroupControl groupControlMenu;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
        private DevExpress.XtraEditors.GroupControl groupControlTransacciones;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.Utils.ImageCollection imageCollection32_x_32;
        private DevExpress.XtraTreeList.TreeList treeListTransacciones;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescripcion_t;
        private Controles.UCSeg_Propiedades ucSeg_Propiedades1;
        private DevExpress.XtraBars.BarSubItem barMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItemReporte;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFormulario;
    }
}