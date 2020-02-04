using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;



using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Business.SeguridadAcceso;



using System.IO;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using DevExpress.XtraTreeList.Columns;
using System.Collections;

namespace Core.Erp.Winform.SeguridadAcceso
{
    public partial class FrmSeg_Menu : Form
    {

        #region variables y atributos
        seg_Menu_Categoria_Info Info_Menu_Categoria_Seleccionado = new seg_Menu_Categoria_Info();
        seg_Menu_Pagina_Info Info_seg_Menu_Pagina_Seleccionado = new seg_Menu_Pagina_Info();
        seg_Menu_Grupo_Info Info_seg_Menu_Grupo_Seleccionado = new seg_Menu_Grupo_Info();
        seg_Menu_Item_Info Info_seg_Menu_Item_Seleccionado = new seg_Menu_Item_Info();

        BindingList<seg_Menu_Item_Info> ListItems = new BindingList<seg_Menu_Item_Info>();
        seg_Menu_Item_Bus busItems = new seg_Menu_Item_Bus();
        TreeListHitInfo dragStartHitInfo;
        ETipoObjectoSelect TipoObjetoSeleccionado_x_Menu;

        TreeListNode NodoSeleccionado;
        int cCategoria_Menu = 1;
        int CModulo = 1;
        int CGrupo = 1;
        Boolean Mover = false;

        TreeListNode NodoSeleccionado_Transaccion;
        seg_Menu_Item_Info Info_seg_Menu_Item_Seleccionado_Transaccion = new seg_Menu_Item_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        seg_Menu_Categoria_Bus BusCategoria = new seg_Menu_Categoria_Bus();
        seg_Menu_Categoria_Info InfoCategoriaOrigen = new seg_Menu_Categoria_Info();
        seg_Menu_Categoria_Info InfoCategoriaDestino = new seg_Menu_Categoria_Info();

        seg_Menu_Pagina_Bus BusPagina = new seg_Menu_Pagina_Bus();
        seg_Menu_Pagina_Info InfoPaginaOrigen = new seg_Menu_Pagina_Info();
        seg_Menu_Pagina_Info InfoPaginaDestino = new seg_Menu_Pagina_Info();

        seg_Menu_Grupo_Bus BusGrupo = new seg_Menu_Grupo_Bus();
        seg_Menu_Grupo_Info InfoGrupoOrigen = new seg_Menu_Grupo_Info();
        seg_Menu_Grupo_Info InfoGrupoDestino = new seg_Menu_Grupo_Info();

        seg_Menu_Item_Bus BusItem = new seg_Menu_Item_Bus();
        seg_Menu_Item_Info InfoItemOrigen = new seg_Menu_Item_Info();
        seg_Menu_Item_Info InfoItemDestino = new seg_Menu_Item_Info();

        seg_Menu_Grupo_x_seg_Menu_Item_Bus Bus_Item_x_Grupo = new seg_Menu_Grupo_x_seg_Menu_Item_Bus();
        seg_Menu_Grupo_x_seg_Menu_Item_Info InfoItem_x_GrupoOrigen = new seg_Menu_Grupo_x_seg_Menu_Item_Info();
        seg_Menu_Grupo_x_seg_Menu_Item_Info InfoItem_x_GrupoDestino = new seg_Menu_Grupo_x_seg_Menu_Item_Info();

        #endregion

        public FrmSeg_Menu()
        {
            InitializeComponent();            
        }       
               
        private void FrmSeg_Menu_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Items();
                Iniciar_TreeList();
                ucSeg_Propiedades1.Mostrar_Propiedades(ETipoObjectoSelect.Categoria);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Cargar_Items()
        {
            try
            {
                ListItems = new BindingList<seg_Menu_Item_Info>(busItems.Get_List_Menu_Item());
                treeListTransacciones.DataSource = ListItems;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Iniciar_TreeList()
        {
            try
            {
                treeListMenu.BeginUnboundLoad();
                TreeListNode nodeCategoria;

                List<seg_Menu_Categoria_Info> ListaInfoCategoria = new List<seg_Menu_Categoria_Info>();
                seg_Menu_Categoria_Bus BusCategoria = new seg_Menu_Categoria_Bus();

                ListaInfoCategoria = BusCategoria.Get_List_Menu_Categoria();

                foreach (var item in ListaInfoCategoria)
                {
                    nodeCategoria = treeListMenu.AppendNode(new object[] { item.Descripcion, item }, null);
                    nodeCategoria.HasChildren = true;
                    nodeCategoria.ImageIndex = 0;
                    nodeCategoria.SelectImageIndex = 0;
                    nodeCategoria.Tag = item;

                    List<seg_Menu_Pagina_Info> ListaInfoPagina = new List<seg_Menu_Pagina_Info>();
                    seg_Menu_Pagina_Bus BusPagina = new seg_Menu_Pagina_Bus();
                    ListaInfoPagina = BusPagina.Get_List_Menu_Pagina(item.Codigo_Categoria);

                    foreach (var item_Pagina in ListaInfoPagina)
                    {
                        TreeListNode nodePagina;
                        nodePagina = treeListMenu.AppendNode(new object[] { item_Pagina.Descripcion, item_Pagina }, nodeCategoria);
                        nodePagina.HasChildren = true;
                        nodePagina.ImageIndex = 1;
                        nodePagina.SelectImageIndex = 1;
                        nodePagina.Tag = item_Pagina;

                        List<seg_Menu_Grupo_Info> ListaInfoGrupo = new List<seg_Menu_Grupo_Info>();
                        seg_Menu_Grupo_Bus BusGrupo = new seg_Menu_Grupo_Bus();
                        ListaInfoGrupo = BusGrupo.Get_List_Menu_Grupo(item_Pagina.Codigo_Pagina);

                        foreach (var item_x_Grupo in ListaInfoGrupo)
                        {
                            TreeListNode nodeGrupo;
                            nodeGrupo = treeListMenu.AppendNode(new object[] { item_x_Grupo.Descripcion, item_x_Grupo }, nodePagina);
                            nodeGrupo.HasChildren = true;
                            nodeGrupo.ImageIndex = 2;
                            nodeGrupo.SelectImageIndex = 2;
                            nodeGrupo.Tag = item_x_Grupo;

                            List<seg_Menu_Item_Info> ListaInfoItems = new List<seg_Menu_Item_Info>();
                            seg_Menu_Item_Bus BusItems = new seg_Menu_Item_Bus();
                            ListaInfoItems = BusItems.Get_List_Menu_Item(item_x_Grupo.Codigo_Grupo);

                            foreach (var item_x_Items in ListaInfoItems)
                            {
                                TreeListNode nodeItem;
                                nodeItem = treeListMenu.AppendNode(new object[] { item_x_Items.Descripcion, item_x_Items }, nodeGrupo);
                                nodeItem.HasChildren = false;
                                nodeItem.ImageIndex = 3;
                                nodeItem.SelectImageIndex = 3;
                                nodeItem.Tag = item_x_Items;
                            }
                        }
                    }
                }
                treeListMenu.EndUnboundLoad();
                treeListMenu.ExpandAll();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void treeListMenu_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                TreeList tl = (TreeList)sender;
                TreeListHitInfo hitInfo = tl.CalcHitInfo(e.Location);

                if (hitInfo.Node != null)
                {

                    barButtonItem_Pagina_Mod.Enabled = false;
                    barButtonItem_Grupo.Enabled = false;
                    barMenu.Enabled = false;

                    Info_Menu_Categoria_Seleccionado = new seg_Menu_Categoria_Info();
                    Info_seg_Menu_Pagina_Seleccionado = new seg_Menu_Pagina_Info();
                    Info_seg_Menu_Grupo_Seleccionado = new seg_Menu_Grupo_Info();
                    Info_seg_Menu_Item_Seleccionado = new seg_Menu_Item_Info();

                    if (hitInfo.Node.GetValue(1).GetType() == typeof(seg_Menu_Categoria_Info))
                    {
                        barButtonItem_Pagina_Mod.Enabled = true;
                        Info_Menu_Categoria_Seleccionado = (seg_Menu_Categoria_Info)hitInfo.Node.GetValue(1);
                        ucSeg_Propiedades1.Mostrar_Propiedades(ETipoObjectoSelect.Categoria);
                        ucSeg_Propiedades1.Set_Propiedades(Info_Menu_Categoria_Seleccionado);
                        TipoObjetoSeleccionado_x_Menu = ETipoObjectoSelect.Categoria;
                    }

                    if (hitInfo.Node.GetValue(1).GetType() == typeof(seg_Menu_Pagina_Info))
                    {
                        barButtonItem_Grupo.Enabled = true;
                        Info_seg_Menu_Pagina_Seleccionado = (seg_Menu_Pagina_Info)hitInfo.Node.GetValue(1);
                        ucSeg_Propiedades1.Mostrar_Propiedades(ETipoObjectoSelect.Pagina);
                        ucSeg_Propiedades1.Set_Propiedades(Info_seg_Menu_Pagina_Seleccionado);
                        TipoObjetoSeleccionado_x_Menu = ETipoObjectoSelect.Pagina;
                    }

                    if (hitInfo.Node.GetValue(1).GetType() == typeof(seg_Menu_Grupo_Info))
                    {
                        barMenu.Enabled = true;
                        Info_seg_Menu_Grupo_Seleccionado = (seg_Menu_Grupo_Info)hitInfo.Node.GetValue(1);
                        ucSeg_Propiedades1.Mostrar_Propiedades(ETipoObjectoSelect.Grupo);
                        ucSeg_Propiedades1.Set_Propiedades(Info_seg_Menu_Grupo_Seleccionado);
                        TipoObjetoSeleccionado_x_Menu = ETipoObjectoSelect.Grupo;
                    }

                    if (hitInfo.Node.GetValue(1).GetType() == typeof(seg_Menu_Item_Info))
                    {
                        Info_seg_Menu_Item_Seleccionado = (seg_Menu_Item_Info)hitInfo.Node.GetValue(1);
                        ucSeg_Propiedades1.Mostrar_Propiedades(ETipoObjectoSelect.Item);
                        ucSeg_Propiedades1.Set_Propiedades(Info_seg_Menu_Item_Seleccionado);
                        TipoObjetoSeleccionado_x_Menu = ETipoObjectoSelect.Item;
                    }

                    tl.FocusedNode = hitInfo.Node;
                    NodoSeleccionado = hitInfo.Node;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        string MensajeError = "";

        private void barButtonItem_Categ_Menu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string NameMenu = "";
                string IdMenu = "";

                NameMenu = "Menu" + cCategoria_Menu;

                seg_Menu_Categoria_Bus BusCategoria = new seg_Menu_Categoria_Bus();
                seg_Menu_Categoria_Info InfoCategoria = new seg_Menu_Categoria_Info();

                InfoCategoria.Descripcion = NameMenu;
                InfoCategoria.Visible = true;
                BusCategoria.GrabarDB(InfoCategoria, ref IdMenu, ref MensajeError);

                TreeListNode newNode = treeListMenu.AppendNode(new object[] { NameMenu, InfoCategoria }, null);

                newNode.ImageIndex = 0;
                newNode.SelectImageIndex = 0;
                newNode.Selected = true;
                newNode.Tag = InfoCategoria;
                treeListMenu.SetNodeIndex(newNode, 0);
                cCategoria_Menu++;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void barButtonItem_Pagina_Mod_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string NamePagina = "";
                string IdModulo = "";

                NamePagina = "Modulo" + CModulo;

                seg_Menu_Pagina_Bus BusPagina = new seg_Menu_Pagina_Bus();
                seg_Menu_Pagina_Info InfoPagina = new seg_Menu_Pagina_Info();

                InfoPagina.Descripcion = NamePagina;
                InfoPagina.Visible = true;
                InfoPagina.Codigo_Categoria = Info_Menu_Categoria_Seleccionado.Codigo_Categoria;
                InfoPagina.ImageIndex = 1;
                InfoPagina.Visible = true;
                
                if (InfoPagina.Codigo_Categoria != null)
                {
                    BusPagina.GrabarDB(InfoPagina, ref IdModulo, ref MensajeError);

                    TreeListNode newNode = treeListMenu.AppendNode(new object[] { NamePagina, InfoPagina }, NodoSeleccionado);
                    newNode.ImageIndex = 1;
                    newNode.SelectImageIndex = 1;
                    newNode.Selected = true;
                    newNode.Tag = InfoPagina;
                    treeListMenu.SetNodeIndex(newNode, 0);
                    CModulo++;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void barButtonItem_Grupo_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string NameGrupo = "";
                string IdGrupo = "";

                NameGrupo = "Grupo" + CGrupo;

                seg_Menu_Grupo_Bus BusGrupo = new seg_Menu_Grupo_Bus();
                seg_Menu_Grupo_Info InfoGrupo = new seg_Menu_Grupo_Info();

                InfoGrupo.Descripcion = NameGrupo;
                InfoGrupo.Visible = true;
                InfoGrupo.Codigo_Pagina = Info_seg_Menu_Pagina_Seleccionado.Codigo_Pagina;
                InfoGrupo.ImageIndex = 2;
                InfoGrupo.Visible = true;
                if (InfoGrupo.Codigo_Pagina != null)
                {
                    BusGrupo.GrabarDB(InfoGrupo, ref IdGrupo, ref MensajeError);

                    TreeListNode newNode = treeListMenu.AppendNode(new object[] { NameGrupo, InfoGrupo }, NodoSeleccionado);
                    newNode.ImageIndex = 2;
                    newNode.SelectImageIndex = 2;
                    newNode.Selected = true;
                    newNode.Tag = InfoGrupo;
                    treeListMenu.SetNodeIndex(newNode, 0);
                    CGrupo++;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        int CTransaccion = 1;
        int CReporte = 1;

        private void barButtonItem_Items_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string NameItem = "";
                string IdItem = "";

                NameItem = "Formulario" + CTransaccion;

                seg_Menu_Item_Bus BusItem = new seg_Menu_Item_Bus();
                seg_Menu_Item_Info InfoItem = new seg_Menu_Item_Info();

                InfoItem.Descripcion = NameItem;
                InfoItem.ImageIndex = 3;
                InfoItem.LargeImageIndex = 2;
                InfoItem.ItemShortcut = "";
                InfoItem.position = 0;
                InfoItem.Tipo = "Formulario";
                BusItem.GrabarDB(InfoItem, ref IdItem, ref MensajeError);
                CTransaccion++;
                ListItems.Add(InfoItem);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void barButtonItem_Eliminar_Items_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                seg_Menu_Item_Bus BusItem = new seg_Menu_Item_Bus();

                if (BusItem.Get_List_Menu_Item_x_Grupo_x_CodItem(Info_seg_Menu_Item_Seleccionado_Transaccion.Codigo_Item).Count() == 0)
                {
                    BusItem.EliminarDB(Info_seg_Menu_Item_Seleccionado_Transaccion, ref MensajeError);
                    ListItems.Remove(Info_seg_Menu_Item_Seleccionado_Transaccion);
                }
                else
                {
                    MessageBox.Show("Esta Transaccion no se puede eliminar por que tiene asociado o asignado a un grupo primero quitelo del grupo antes de eliminar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void treeListTransacciones_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                TreeList tl = (TreeList)sender;
                TreeListHitInfo hitInfo = tl.CalcHitInfo(e.Location);

                if (hitInfo.Node != null)
                {
                    Info_seg_Menu_Item_Seleccionado_Transaccion = new seg_Menu_Item_Info();
                    Info_seg_Menu_Item_Seleccionado_Transaccion = (seg_Menu_Item_Info)treeListTransacciones.GetDataRecordByNode(hitInfo.Node);

                    tl.FocusedNode = hitInfo.Node;
                    hitInfo.Node.Expanded = true;
                    NodoSeleccionado_Transaccion = hitInfo.Node;

                    ucSeg_Propiedades1.Mostrar_Propiedades(ETipoObjectoSelect.Item);
                    ucSeg_Propiedades1.Set_Propiedades(Info_seg_Menu_Item_Seleccionado_Transaccion);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void barButtonItem_Anular_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (TipoObjetoSeleccionado_x_Menu == ETipoObjectoSelect.Item)
                {
                    InfoGrupoOrigen = treeListMenu.FocusedNode.ParentNode.Tag as seg_Menu_Grupo_Info;
                    InfoItem_x_GrupoOrigen.Codigo_Grupo = InfoGrupoOrigen.Codigo_Grupo;
                    InfoItem_x_GrupoOrigen.Codigo_Item = Info_seg_Menu_Item_Seleccionado.Codigo_Item;

                    if (Bus_Item_x_Grupo.EliminarDB(InfoItem_x_GrupoOrigen, ref MensajeError))
                        treeListMenu.DeleteNode(NodoSeleccionado);
                }

                if (TipoObjetoSeleccionado_x_Menu == ETipoObjectoSelect.Grupo)
                {
                    seg_Menu_Grupo_Bus BusGrupo = new seg_Menu_Grupo_Bus();

                    if (BusGrupo.Get_List_Menu_Grupo_ConItem(Info_seg_Menu_Grupo_Seleccionado.Codigo_Grupo).Count() == 0)
                    {
                        BusGrupo.EliminarDB(Info_seg_Menu_Grupo_Seleccionado, ref MensajeError);
                        treeListMenu.DeleteNode(NodoSeleccionado);
                    }
                    else
                    {
                        MessageBox.Show("Este Grupo no se puede eliminar por que tiene asociado o asignado items primero quitelo del grupo antes de eliminar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (TipoObjetoSeleccionado_x_Menu == ETipoObjectoSelect.Pagina)
                {
                    seg_Menu_Pagina_Bus BusPagina = new seg_Menu_Pagina_Bus();

                    if (BusPagina.Get_List_Menu_Pagina_Con_Grupos(Info_seg_Menu_Pagina_Seleccionado.Codigo_Pagina).Count() == 0)
                    {
                        BusPagina.EliminarDB(Info_seg_Menu_Pagina_Seleccionado, ref MensajeError);
                        treeListMenu.DeleteNode(NodoSeleccionado);
                    }
                    else
                    {
                        MessageBox.Show("Esta Pagina no se puede eliminar por que tiene asociado o asignado Grupo primero quitelo de la Pagina antes de eliminar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                if (TipoObjetoSeleccionado_x_Menu == ETipoObjectoSelect.Categoria)
                {

                    seg_Menu_Categoria_Bus BusCategoria = new seg_Menu_Categoria_Bus();

                    if (BusCategoria.Get_List_Menu_Categoria_Con_Pagina(Info_Menu_Categoria_Seleccionado.Codigo_Categoria).Count() == 0)
                    {
                        BusCategoria.EliminarDB(Info_Menu_Categoria_Seleccionado, ref MensajeError);
                        treeListMenu.DeleteNode(NodoSeleccionado);
                    }
                    else
                    {
                        MessageBox.Show("Este Menu no se puede eliminar por que tiene asociado o asignado Grupos primero elimine sus grupos antes de eliminar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void treeListMenu_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Mover = false;
                TreeListNode dragNode, targetNode;
                TreeList tl = sender as TreeList;
                Point p = tl.PointToClient(new Point(e.X, e.Y));

                dragNode = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;
                targetNode = tl.CalcHitInfo(p).Node;

                if (TipoObjetoSeleccionado_x_Menu == ETipoObjectoSelect.Pagina)
                {
                    if (targetNode.Tag.GetType() == typeof(seg_Menu_Pagina_Info))
                    {
                        InfoPaginaOrigen = (seg_Menu_Pagina_Info)dragNode.Tag;
                        InfoPaginaDestino = (seg_Menu_Pagina_Info)targetNode.Tag;
                        Mover = BusPagina.Modificar_Posicion_Pagina(InfoPaginaOrigen, InfoPaginaDestino, ref MensajeError);
                    }

                    if (targetNode.Tag.GetType() == typeof(seg_Menu_Categoria_Info))
                    {
                        InfoPaginaOrigen = (seg_Menu_Pagina_Info)dragNode.Tag;
                        InfoCategoriaDestino = (seg_Menu_Categoria_Info)targetNode.Tag;
                        InfoPaginaOrigen.Codigo_Categoria = InfoCategoriaDestino.Codigo_Categoria;
                        Mover = BusPagina.ModificarDB(InfoPaginaOrigen, ref MensajeError);
                    }
                }
                if (TipoObjetoSeleccionado_x_Menu == ETipoObjectoSelect.Grupo)
                {
                    if (targetNode.Tag.GetType() == typeof(seg_Menu_Grupo_Info))
                    {
                        InfoGrupoOrigen = (seg_Menu_Grupo_Info)dragNode.Tag;
                        InfoGrupoDestino = (seg_Menu_Grupo_Info)targetNode.Tag;
                        Mover = BusGrupo.Modificar_Posicion_Grupo(InfoGrupoOrigen, InfoGrupoDestino, ref MensajeError);
                    }
                    if (targetNode.Tag.GetType() == typeof(seg_Menu_Pagina_Info))
                    {
                        InfoGrupoOrigen = (seg_Menu_Grupo_Info)dragNode.Tag;
                        InfoPaginaDestino = (seg_Menu_Pagina_Info)targetNode.Tag;
                        InfoGrupoOrigen.Codigo_Pagina = InfoPaginaDestino.Codigo_Pagina;
                        Mover = BusGrupo.ModificarDB(InfoGrupoOrigen, ref MensajeError);
                    }
                }

                if (TipoObjetoSeleccionado_x_Menu == ETipoObjectoSelect.Item)
                {
                    if (dragNode!=null)
                    {
                        if (dragNode.Tag != null)
                        {
                            
                        }
                        else
                        {
                            if (targetNode.Tag.GetType() == typeof(seg_Menu_Grupo_Info))
                            {
                                if (InfoItemDestino.Tipo=="Formulario")
                                {
                                    dragNode = dragStartHitInfo.Node;
                                    InfoGrupoDestino = (seg_Menu_Grupo_Info)targetNode.Tag;
                                    InfoItem_x_GrupoOrigen.Codigo_Grupo = InfoGrupoDestino.Codigo_Grupo;
                                    InfoItem_x_GrupoOrigen.Codigo_Item = InfoItemOrigen.Codigo_Item;
                                    InfoItem_x_GrupoOrigen.observacion = "";
                                    if (Bus_Item_x_Grupo.GrabarDB(InfoItem_x_GrupoOrigen, ref MensajeError))
                                    {
                                        TreeListNode nodeItem;
                                        nodeItem = treeListMenu.AppendNode(new object[] { InfoItemOrigen.Descripcion, InfoItemOrigen }, targetNode);
                                        nodeItem.HasChildren = false;
                                        nodeItem.ImageIndex = 3;
                                        nodeItem.SelectImageIndex = 3;
                                        nodeItem.Tag = InfoItemOrigen;
                                    }    
                                }
                            }
                        }
                    }
                    else
                    {
                        if (targetNode.Tag.GetType() == typeof(seg_Menu_Grupo_Info))
                        {
                            dragNode = dragStartHitInfo.Node;
                            InfoGrupoDestino = (seg_Menu_Grupo_Info)targetNode.Tag;
                            InfoItem_x_GrupoOrigen.Codigo_Grupo = InfoGrupoDestino.Codigo_Grupo;
                            InfoItem_x_GrupoOrigen.Codigo_Item = InfoItemOrigen.Codigo_Item;
                            if (Bus_Item_x_Grupo.GrabarDB(InfoItem_x_GrupoOrigen, ref MensajeError))
                            {
                                TreeListNode nodeItem;
                                nodeItem = treeListMenu.AppendNode(new object[] { InfoItemOrigen.Descripcion, InfoItemOrigen }, targetNode);
                                nodeItem.HasChildren = false;
                                nodeItem.ImageIndex = 3;
                                nodeItem.SelectImageIndex = 3;
                                nodeItem.Tag = InfoItemOrigen;
                            }
                        }
                    }
                    
                }

                if (TipoObjetoSeleccionado_x_Menu == ETipoObjectoSelect.Categoria)
                {
                    if (targetNode.Tag.GetType() == typeof(seg_Menu_Categoria_Info))
                    {
                        InfoCategoriaOrigen = (seg_Menu_Categoria_Info)dragNode.Tag;
                        InfoCategoriaDestino = (seg_Menu_Categoria_Info)targetNode.Tag;
                        Mover = BusCategoria.Modificar_Posicion_Categoria(InfoCategoriaOrigen, InfoCategoriaDestino, ref MensajeError);
                    }
                }

                if (Mover)
                {
                    tl.SetNodeIndex(dragNode, tl.GetNodeIndex(targetNode));
                    e.Effect = DragDropEffects.Move;
                }
                else
                    e.Effect = DragDropEffects.None;
                treeListMenu.ExpandAll();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        private void treeListTransacciones_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.None)
                {
                    dragStartHitInfo = (sender as TreeList).CalcHitInfo(new Point(e.X, e.Y));
                    
                    InfoItemOrigen = treeListTransacciones.GetDataRecordByNode(dragStartHitInfo.Node) as seg_Menu_Item_Info;
                    ucSeg_Propiedades1.Mostrar_Propiedades(ETipoObjectoSelect.Item);
                    ucSeg_Propiedades1.Set_Propiedades( InfoItemOrigen);
                    TipoObjetoSeleccionado_x_Menu = ETipoObjectoSelect.Item;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void treeListTransacciones_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left
               && dragStartHitInfo != null && dragStartHitInfo.HitInfoType == HitInfoType.Cell)
                {
                    Size dragSize = SystemInformation.DragSize;
                    Rectangle dragRect = new Rectangle(new Point(dragStartHitInfo.MousePoint.X - dragSize.Width / 2,
                        dragStartHitInfo.MousePoint.Y - dragSize.Height / 2), dragSize);

                    if (!dragRect.Contains(new Point(e.X, e.Y)))
                    {
                        string dragObject = dragStartHitInfo.Node.GetDisplayText(dragStartHitInfo.Column);
                        (sender as TreeList).DoDragDrop(dragObject, DragDropEffects.Copy);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void treeListMenu_DragEnter(object sender, DragEventArgs e)
        {            
            try
            {
                e.Effect = DragDropEffects.Copy;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }       

        private void treeListTransacciones_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                TreeListNode dragNode = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;
                if (dragNode != null)
                    InfoItemOrigen = treeListTransacciones.GetDataRecordByNode(dragNode) as seg_Menu_Item_Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void barButtonItemReporte_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string NameItem = "";
                string IdItem = "";

                NameItem = "Reporte" + CReporte;

                seg_Menu_Item_Bus BusItem = new seg_Menu_Item_Bus();
                seg_Menu_Item_Info InfoItem = new seg_Menu_Item_Info();

                InfoItem.Descripcion = NameItem;
                InfoItem.ImageIndex = 4;
                InfoItem.LargeImageIndex = 4;
                InfoItem.ItemShortcut = "";
                InfoItem.position = 0;
                InfoItem.Tipo = "Reporte";
                BusItem.GrabarDB(InfoItem, ref IdItem, ref MensajeError);
                CReporte++;
                ListItems.Add(InfoItem);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucSeg_Propiedades1_Load(object sender, EventArgs e)
        {

        }            
    }


    public enum ETipoObjectoSelect
    {
        Categoria,
        Pagina,
        Grupo,
        Item
    }

}
