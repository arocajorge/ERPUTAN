using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using System.Linq;

using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.General;
using Core.Erp.Business.General;





namespace Core.Erp.Winform.SeguridadAcceso
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool Cerrar = false;
        private seg_usuario_info InfoUsuario;
        private tb_Empresa_Info InfoEmpresa;
        seg_Menu_bus BusMenu = new seg_Menu_bus();
        seg_Menu_info InfoMenu = new seg_Menu_info();

        tb_sis_reporte_Bus BusReporte = new tb_sis_reporte_Bus();
        List<tb_sis_reporte_Info> listReporte = new List<tb_sis_reporte_Info>();
        
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Core.Erp.Business.General.cl_parametrosGenerales_Bus param = Core.Erp.Business.General.cl_parametrosGenerales_Bus.Instance;
        
        public FrmMain()
        {
            try
            {
                InitializeComponent();
                
                ucSeg_Menu_x_Usuario_x_Empresa1.event_treeListMenu_x_Usuario_x_Empresa_MouseDown += ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_MouseDown;
                ucSeg_Menu_x_Usuario_x_Empresa1.event_treeListMenu_x_Usuario_x_Empresa_SelectImageClick += ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_SelectImageClick;
                ucSeg_Menu_x_Usuario_x_Empresa1.event_treeListMenu_x_Usuario_x_Empresa_NodeCellStyle += ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_NodeCellStyle;
                ucSeg_Menu_x_Usuario_x_Empresa1.event_treeListMenu_x_Usuario_x_Empresa_KeyUp += ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_KeyUp;
                ucSeg_Menu_x_Usuario_x_Empresa1.event_btnRefrescarMenu_Click += ucSeg_Menu_x_Usuario_x_Empresa1_event_btnRefrescarMenu_Click;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucSeg_Menu_x_Usuario_x_Empresa1_event_btnRefrescarMenu_Click(object sender, EventArgs e)
        {
            try
            {
                string mensajeError = "";
                CargarMenu(ref mensajeError);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                DevExpress.XtraTreeList.TreeList tree =(DevExpress.XtraTreeList.TreeList)sender;
                DevExpress.XtraTreeList.TreeListHitInfo hitInfo = tree.CalcHitInfo(e.Location);
                if(hitInfo.HitInfoType == DevExpress.XtraTreeList.HitInfoType.Cell)
                {
                    SeleccionarNodo(hitInfo.Node);
                }         
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.Selection.Count > 0)
                {
                    switch(e.KeyCode)
                    {
                        case Keys.Enter:
                            SeleccionarNodo(ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.Selection[0]);
                            break;
                        case Keys.Left:
                            ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.Selection[0].Expanded = false;
                            break;
                        case Keys.Right:
                            ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.Selection[0].Expanded = true;
                            break;
                    }                    
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        void ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            try
            {
                if (e.Node.GetValue("IdMenuPadre") as int? == 0)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_SelectImageClick(object sender, DevExpress.XtraTreeList.NodeClickEventArgs e)
        {
            try
            {
                SeleccionarNodo(e.Node);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeleccionarNodo(DevExpress.XtraTreeList.Nodes.TreeListNode nodo)
        {
            try
            {
                if (nodo.Id == -100000)
                {
                    ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.ExpandAll();
                }                
                else
                {
                    if ((bool)nodo.GetValue("Tiene_FormularioAsociado"))
                    {
                        InfoMenu.IdMenu = (int)nodo.GetValue("IdMenu");
                        InfoMenu.IdMenuPadre = (int)nodo.GetValue("IdMenuPadre");
                        InfoMenu.DescripcionMenu = (string)nodo.GetValue("DescripcionMenu");
                        InfoMenu.PosicionMenu = (int)nodo.GetValue("PosicionMenu");
                        InfoMenu.Habilitado = (bool)nodo.GetValue("Habilitado");
                        InfoMenu.Tiene_FormularioAsociado = (bool)nodo.GetValue("Tiene_FormularioAsociado");
                        InfoMenu.nom_Formulario = (string)nodo.GetValue("nom_Formulario");
                        InfoMenu.nom_Asembly = (string)nodo.GetValue("nom_Asembly");

                        InfoMenu.nivel = (int)nodo.GetValue("nivel");
                        this.Cursor = Cursors.WaitCursor;
                        LlamarFormulario();
                        MarcarNodoPadre(nodo);
                    }
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
      
        private void MarcarNodoPadre(DevExpress.XtraTreeList.Nodes.TreeListNode nodo)
        {
            try
            {
                if (nodo.ParentNode != null)
                {
                    if (nodo.GetValue("IdMenuPadre") as int? !=0)
                    {
                        if (!(bool)nodo.ParentNode.GetValue("Tiene_FormularioAsociado"))
                        {
                            nodo.ParentNode.Selected = true;
                        }
                        else
                        {
                            MarcarNodoPadre(nodo.ParentNode);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void CapturarEventosApariencia(BarItemLinkCollection links)
        {
            try
            {
                foreach (var item in links)
                {
                    if (item.GetType() == typeof(BarSubItemLink))
                    {
                        BarSubItemLink subItems = (BarSubItemLink)item;
                        CapturarEventosApariencia(subItems.Item.ItemLinks);
                    }
                    if (item.GetType() == typeof(BarButtonItemLink))
                    {
                        BarButtonItemLink barItem = (BarButtonItemLink)item;
                        barItem.Item.ItemPress += itemAparienciaPresionado;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void EstablecerTema(BarItemLinkCollection links)
        {
            try
            {                
                foreach (var item in links)
                {
                    if (item.GetType() == typeof(BarSubItemLink))
                    {
                        BarSubItemLink subItems = (BarSubItemLink)item;
                        CapturarEventosApariencia(subItems.Item.ItemLinks);
                    }
                    if (item.GetType() == typeof(BarButtonItemLink))
                    {
                        BarButtonItemLink barItem = (BarButtonItemLink)item;
                        //blcApariencia.ItemLinks[barItem.ItemId].Item.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {  
                DevExpress.UserSkins.BonusSkins.Register();
                SkinHelper.InitSkinPopupMenu(blcApariencia);
                EstablecerTema(blcApariencia.ItemLinks);

                CapturarEventosApariencia(blcApariencia.ItemLinks);


                if (ValidarIngreso())
                {
                    string mensajeError = "";

                    CargarMenu(ref mensajeError);
                    ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.Focus();
                    barStaticItem_param.Caption = "Usuario: " + param.IdUsuario + "   Empresa:[" + param.IdEmpresa + "] - " + param.NombreEmpresa;

                    if (param.InfoEmpresa.em_logo != null)
                    {
                       // pictureEditLogo.Image = Funciones.ArrayAImage(param.InfoEmpresa.em_logo);
                    }



                }
                Cargar_Menu_Ribbon_x_Usuario();
                Cargar_Combo();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        private bool ValidarIngreso()
        {
            try
            {
                FrmSeg_Login login = new FrmSeg_Login();
                login.ShowDialog(this);


                
                if (param.IdUsuario== null)
                {
                    Application.Exit();
                    return false;
                }

                FrmSeg_Login_x_Empresas frm_login_x_empresas = new FrmSeg_Login_x_Empresas();
                frm_login_x_empresas.ShowDialog(this);
                InfoEmpresa = param.InfoEmpresa;
                InfoUsuario = param.InfoUsuario;

                tb_Empresa_Bus BusEmpresa= new tb_Empresa_Bus();

                byte[] fondo = BusEmpresa.Get_Fondo_Pantalla_x_Empresa(param.InfoEmpresa.IdEmpresa);

                  if (fondo!=null)
                  {
                    this.BackgroundImage = Funciones.ArrayAImage(fondo);
                  }

                  if (InfoEmpresa.em_nombre.Equals("DESARROLLO") || InfoEmpresa.em_nombre.Equals("DESarrollo") || InfoEmpresa.em_nombre.Equals("desARROllo") || InfoEmpresa.em_nombre.Equals("desarroLLO"))
                    LBLMENSAJE.Visible = true;
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void LlamarFormulario()
        {
            try
            {
                if (InfoMenu.Tiene_FormularioAsociado == false)
                {
                    return;
                }

                string NombreFormulario = InfoMenu.nom_Formulario;
                string Nombre_Asamble = InfoMenu.nom_Asembly;
                string nombre_dll = "";

                string RutaPantalla = "";

                nombre_dll = Nombre_Asamble;
                System.Reflection.Assembly Ensamblado;
                Ensamblado = System.Reflection.Assembly.LoadFrom(nombre_dll);
                System.Reflection.AssemblyName assemName = Ensamblado.GetName();
                Version ver = assemName.Version;

                Object ObjFrm;
                Type tipo = Ensamblado.GetType(assemName.Name + "." + NombreFormulario);

                RutaPantalla = assemName.Name + "." + NombreFormulario;

                if (tipo == null)
                {
                    MessageBox.Show("No se encontró el formulario Emsamblado:" + Nombre_Asamble + "  Formulario:" + NombreFormulario, "Error de ubicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!this.FormularioEstaAbierto(NombreFormulario))
                    {
                        ObjFrm = Activator.CreateInstance(tipo);
                        Form Formulario = (Form)ObjFrm;
                        Formulario.Text = InfoMenu.DescripcionMenu + " Version:" + ver.ToString();

                        Formulario.MdiParent = this;
                        Formulario.Tag = InfoMenu;
                        Formulario.WindowState = FormWindowState.Maximized;
                        Formulario.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private Boolean FormularioEstaAbierto(String NombreDelFrm)
        {
            try
            {
                bool estaAbierto = false;
                if (this.MdiChildren.Length > 0)
                {
                    for (int i = 0; i < this.MdiChildren.Length; i++)
                    {
                        int posicion = NombreDelFrm.LastIndexOf('.');
                        string nombreCorto = NombreDelFrm.Substring(posicion + 1, NombreDelFrm.Length - posicion - 1);
                        if (posicion != -1)
                        {
                            if (nombreCorto.Equals(this.MdiChildren[i].Name))
                            {
                                estaAbierto = true;
                            }
                        }
                        else if (NombreDelFrm.Contains(this.MdiChildren[i].Name))
                        {
                            estaAbierto = true;
                        }

                        if (estaAbierto)
                        {
                            this.MdiChildren[i].Focus();
                            MessageBox.Show("El formulario o reporte solicitado ya se encuentra abierto");
                            return true;
                        }
                    }
                    return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }

        }

        public void CargarMenu(ref string MensajeError)
        {
            try
            {
                string idUsuario = param.IdUsuario;
                int idEmpresa = param.IdEmpresa;
                string mensaje = "";
                List<seg_Menu_info> lMenuInfo = BusMenu.Get_List_Menu_x_Empresa_x_Usuario(idUsuario, idEmpresa, ref MensajeError);
                //MensajeError = mensaje;
                ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.SelectImageList = ucSeg_Menu_x_Usuario_x_Empresa1.imageList1;
                ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.ColumnsImageList = ucSeg_Menu_x_Usuario_x_Empresa1.imageList1;
                ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.DataSource = null;
                ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.DataSource = lMenuInfo;
                EstablecerIcono(ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.Nodes);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + MensajeError + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void EstablecerIcono(DevExpress.XtraTreeList.Nodes.TreeListNodes lnodos)
        {
            try
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in lnodos)
                {                    
                    string descripcion = (string)nodo.GetValue("DescripcionMenu");
                    if (nodo.Nodes.Count > 0)
                    {
                        EstablecerIcono(nodo.Nodes);

                        if (descripcion.Equals("Mantenimientos") || descripcion.Equals("Mantenimiento"))
                        {
                            nodo.ImageIndex = 1;
                            nodo.SelectImageIndex = 1;
                        }
                        else if (descripcion.Contains("Reporte"))
                        {
                            nodo.ImageIndex = 5;
                            nodo.SelectImageIndex = 5;
                        }
                    }
                    else if ((bool)nodo.GetValue("Tiene_FormularioAsociado"))
                    {
                        nodo.ImageIndex = 2;
                        nodo.SelectImageIndex = 2;
                    }
                    //else if (nodo.GetValue("nom_Formulario").ToString().Length < 1)
                    //{
                    //    nodo.ImageIndex = 6;
                    //    nodo.SelectImageIndex = 6;
                    //}
                    //else
                    //{
                    //    nodo.ImageIndex = 3;
                    //    nodo.SelectImageIndex = 3;
                    //}
                    if ((bool)nodo.GetValue("Tiene_FormularioAsociado"))
                    {
                        nodo.ImageIndex = 2;
                        nodo.SelectImageIndex = 2;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnMostrarMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                switch (dockPanelMenu.Visibility)
                {
                    case DevExpress.XtraBars.Docking.DockVisibility.AutoHide:
                        {
                            dockPanelMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                            break;
                        }
                    case DevExpress.XtraBars.Docking.DockVisibility.Hidden:
                        {
                            dockPanelMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                            break;
                        }
                    case DevExpress.XtraBars.Docking.DockVisibility.Visible:
                        {
                            dockPanelMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea cerrar la aplicación?",param.Nombre_sistema,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    Cerrar = true;
                    Application.Exit();    
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void itemAparienciaPresionado(object sender, ItemClickEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucSeg_Menu_x_Usuario_x_Empresa1_Load(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void Cargar_Menu_Ribbon_x_Usuario()
        {
            try
            {

                

                ribbonMenuTop.Images = imageCollection64_x_64;


                seg_Menu_Pagina_Bus BusPagina = new seg_Menu_Pagina_Bus();
                List<seg_Menu_Pagina_Info> listaPaginas = new List<seg_Menu_Pagina_Info>();
                listaPaginas  = BusPagina.Get_List_Menu_Pagina("");

                foreach (var item in listaPaginas)
                {
                    // Create a Ribbon page.
                    RibbonPage pagina = new RibbonPage();
                    pagina.Text = item.Descripcion;
                    pagina.Name = item.Codigo_Pagina;

                    seg_Menu_Grupo_Bus BusGrupoPagina = new seg_Menu_Grupo_Bus();
                    List<seg_Menu_Grupo_Info> ListaGrupo_x_Pagi = new List<seg_Menu_Grupo_Info>();
                    ListaGrupo_x_Pagi = BusGrupoPagina.Get_List_Menu_Grupo(item.Codigo_Pagina);


                    foreach (var item_x_Grupo_x_Pag in ListaGrupo_x_Pagi )
                    {
                        RibbonPageGroup group_x_Pagina = new RibbonPageGroup();
                        group_x_Pagina.Name = item_x_Grupo_x_Pag.Codigo_Grupo;
                        group_x_Pagina.Text = item_x_Grupo_x_Pag.Descripcion;
                        group_x_Pagina.KeyTip = item_x_Grupo_x_Pag.Descripcion;


                        seg_Menu_Item_Bus BusItems_x_grupo_x_pagi = new seg_Menu_Item_Bus();
                        List<seg_Menu_Item_Info> listMenu_Ribbon_Item = new List<seg_Menu_Item_Info>();

                        listMenu_Ribbon_Item = BusItems_x_grupo_x_pagi.Get_List_Menu_Item(item_x_Grupo_x_Pag.Codigo_Grupo);

                        foreach (var item_x_grupo in listMenu_Ribbon_Item)
                        {

                            BarButtonItem BarButton_item = new BarButtonItem();
                            BarButton_item.Name = item_x_grupo.Codigo_Item;
                            BarButton_item.Caption = item_x_grupo.Descripcion;
                            BarButton_item.ImageIndex = item_x_grupo.ImageIndex;
                            BarButton_item.ItemClick += new ItemClickEventHandler(BarButton_item_Click);
                            BarButton_item.RibbonStyle = RibbonItemStyles.Large;
                            BarButton_item.Tag = item_x_grupo;
                            
                            ribbonMenuTop.Items.Add(BarButton_item);
                            group_x_Pagina.ItemLinks.Add(BarButton_item);

                        }


                        pagina.Groups.Add(group_x_Pagina);    

                    }


                    ribbonMenuTop.Pages.Add(pagina);
                    
                }



            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        void BarButton_item_Click(object sender, ItemClickEventArgs e)
        {

            try
            {
              seg_Menu_Item_Info Info= (seg_Menu_Item_Info)e.Item.Tag;

              

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }
        }


       

        void Cargar_Combo()
        {
            try
            {

                listReporte = BusReporte.Get_List_reporte(true);
                cmb_reportes.DataSource = listReporte;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        
        }

       

        

        private void barEditItem_Reportes_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                if (barEditItem_Reportes.EditValue != null)
                {

                    tb_sis_reporte_Info Info_reporte = new tb_sis_reporte_Info();
                    Info_reporte = listReporte.FirstOrDefault(v => v.CodReporte == barEditItem_Reportes.EditValue.ToString());


                    if (Info_reporte != null)
                    {
                        if (Info_reporte.CodReporte != "")
                        {

                            string NombreFormulario = Info_reporte.Formulario;
                            string Nombre_Asamble = Info_reporte.nom_Asembly +".dll";
                            string nombre_dll = "";

                            string RutaPantalla = "";

                            nombre_dll = Nombre_Asamble;
                            System.Reflection.Assembly Ensamblado;
                            Ensamblado = System.Reflection.Assembly.LoadFrom(nombre_dll);
                            System.Reflection.AssemblyName assemName = Ensamblado.GetName();
                            Version ver = assemName.Version;

                            Object ObjFrm;
                            Type tipo = Ensamblado.GetType(assemName.Name + "." + NombreFormulario);

                            RutaPantalla = assemName.Name + "." + NombreFormulario;

                            if (tipo == null)
                            {
                                MessageBox.Show("No se encontró el formulario de este reporte:" + Nombre_Asamble + "  Formulario:" + NombreFormulario, "Error de ubicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (!this.FormularioEstaAbierto(NombreFormulario))
                                {
                                    ObjFrm = Activator.CreateInstance(tipo);
                                    Form Formulario = (Form)ObjFrm;
                                    Formulario.Text = Info_reporte.Nombre + " Version:" + Info_reporte.VersionActual.ToString();

                                    Formulario.MdiParent = this;
                                    Formulario.Tag = Info_reporte;
                                    Formulario.WindowState = FormWindowState.Maximized;
                                    Formulario.Show();
                                }
                            }




                        }
                    }

                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(!Cerrar)
                if (MessageBox.Show("¿Está seguro que desea cerrar la aplicación?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

    }
}
