using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using Core.Erp.Seguridad_Acceso.Info;
using Core.Erp.Seguridad_Acceso.Business;
namespace Core.Erp.Seguridad_Acceso.Winform_Controls
{    
    public partial class UCMenu_x_Usuario_x_Empresa : UserControl
    {
        
        seg_Menu_bus bus = new seg_Menu_bus();
        public UCMenu_x_Usuario_x_Empresa()
        {
            InitializeComponent();
        }
        seg_Menu_info infoMenu = new seg_Menu_info();

        private void treeListMenu_x_Usuario_x_Empresa_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            SeleccionarNodo(e.Node);
        }        
        private void LlamarFormulario()
        {
            try
            {
                //if (sender.GetType() == typeof(TreeView))
                //{
                //string NombreFormulario = ((TreeView)sender).Tag.ToString();


                if (infoMenu.Tiene_FormularioAsociado == false)
                {
                    return;
                }

                string NombreFormulario = infoMenu.nom_Formulario;
                string Nombre_Asamble = infoMenu.nom_Asembly;
                string nombre_dll = "";

                string RutaPantalla = "";

                nombre_dll = Nombre_Asamble;
                System.Reflection.Assembly Ensamblado;
                Ensamblado = System.Reflection.Assembly.LoadFrom(nombre_dll);
                System.Reflection.AssemblyName assemName = Ensamblado.GetName();
                Version ver = assemName.Version;

                Object ObjFrm;
                Type tipo = Ensamblado.GetType(assemName.Name + "." + NombreFormulario);



                //

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
                        Formulario.Text = infoMenu.DescripcionMenu + " Version:" + ver.ToString();

                        Formulario.MdiParent = (Form)this.ParentForm;
                        Formulario.Tag = infoMenu;
                        Formulario.WindowState = FormWindowState.Maximized;
                        Formulario.Show();
                    }
                }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean FormularioEstaAbierto(String NombreDelFrm)
        {
            try
            {
                if (this.ParentForm.MdiChildren.Length > 0)
                {
                    for (int i = 0; i < this.ParentForm.MdiChildren.Length; i++)
                    {
                        //MessageBox.Show(NombreDelFrm.Substring(NombreDelFrm.IndexOf("frm"), NombreDelFrm.Length - NombreDelFrm.IndexOf("Frm_")));
                        if (NombreDelFrm.Contains(this.ParentForm.MdiChildren[i].Name))
                        {
                            this.ParentForm.MdiChildren[i].Focus();
                            MessageBox.Show("El formulario solicitado ya se encuentra abierto");
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

                //oLog.Log_Error(ex.ToString());
                //mensaje = "Error al Modificar .." + ex.Message;

                return false;

            }

        }

        private void UCMenu_x_Usuario_x_Empresa_Load(object sender, EventArgs e)
        {                    

        }

        public void CargarMenu(ref string MensajeError)
        {
            try
            {
                string idUsuario = Global.ParametrosGlobales.User.IdUsuario;
                int idEmpresa = Global.ParametrosGlobales.Company.IdEmpresa;
                string mensaje = "";
                List<seg_Menu_info> lMenuInfo = bus.Get_List_Menu_x_Empresa_x_Usuario(idUsuario, idEmpresa, ref mensaje);
                //treeListMenu_x_Usuario_x_Empresa.ImageIndexFieldName = "MyIcon";
                //foreach (var item in lMenuInfo)
                //{
                //    myMenuInfo menuIcon = new myMenuInfo();
                //    menuIcon.IdMenu = item.IdMenu;
                //    menuIcon.IdMenuPadre = item.IdMenuPadre;
                //    menuIcon.DescripcionMenu = item.DescripcionMenu;
                //    menuIcon.PosicionMenu = item.PosicionMenu;
                //    menuIcon.Habilitado = item.Habilitado;
                //    menuIcon.Tiene_FormularioAsociado = item.Tiene_FormularioAsociado;
                //    menuIcon.nom_Formulario = item.nom_Formulario;
                //    menuIcon.nom_Asembly = item.nom_Asembly;

                //    menuIcon.nivel = item.nivel;

                //    if (item.Tiene_FormularioAsociado)
                //        menuIcon.MyIcon = Properties.Resources.ico_guardar3;

                //    lMenu.Add(menuIcon);
                //}
                //treeListMenu_x_Usuario_x_Empresa.DataSource = lMenu;
                
                treeListMenu_x_Usuario_x_Empresa.SelectImageList = imageList1;
                treeListMenu_x_Usuario_x_Empresa.ColumnsImageList = imageList1;
                treeListMenu_x_Usuario_x_Empresa.DataSource = lMenuInfo;
                EstablecerIcono(treeListMenu_x_Usuario_x_Empresa.Nodes);
                
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
            }
        }

        private void EstablecerIcono(DevExpress.XtraTreeList.Nodes.TreeListNodes lnodos)
        {
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in lnodos)
            {
                string descripcion = (string)nodo.GetValue("DescripcionMenu");
                if(nodo.Nodes.Count > 0)
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
                else if (nodo.GetValue("nom_Formulario").ToString().Length < 1)
                {
                    nodo.ImageIndex = 6;
                    nodo.SelectImageIndex = 6;
                }
                else
                {
                    nodo.ImageIndex = 3;
                    nodo.SelectImageIndex = 3;
                }
                
                
                //string descripcion = (string)nodo.GetValue("Descripcion");
                //if (descripcion.Equals("Mantenimientos"))
                //{
                //    nodo.ImageIndex = 1;
                //}
            }
        }
        private void treeListMenu_x_Usuario_x_Empresa_SelectImageClick(object sender, DevExpress.XtraTreeList.NodeClickEventArgs e)
        {
            SeleccionarNodo(e.Node);
        }

        private void SeleccionarNodo(DevExpress.XtraTreeList.Nodes.TreeListNode nodo)
        {
            if (nodo.Id == -100000)
            {
                treeListMenu_x_Usuario_x_Empresa.ExpandAll();
            }
            else if (nodo.Nodes.Count > 0)
            {
                return;
            }
            else
            {
                if ((bool)nodo.GetValue("Tiene_FormularioAsociado"))
                {
                    infoMenu.IdMenu = (int)nodo.GetValue("IdMenu");
                    infoMenu.IdMenuPadre = (int)nodo.GetValue("IdMenuPadre");
                    infoMenu.DescripcionMenu = (string)nodo.GetValue("DescripcionMenu");
                    infoMenu.PosicionMenu = (int)nodo.GetValue("PosicionMenu");
                    infoMenu.Habilitado = (bool)nodo.GetValue("Habilitado");
                    infoMenu.Tiene_FormularioAsociado = (bool)nodo.GetValue("Tiene_FormularioAsociado");
                    infoMenu.nom_Formulario = (string)nodo.GetValue("nom_Formulario");
                    infoMenu.nom_Asembly = (string)nodo.GetValue("nom_Asembly");

                    infoMenu.nivel = (int)nodo.GetValue("nivel");

                    LlamarFormulario();                    
                    if(nodo.ParentNode!=null)
                        nodo.ParentNode.Selected = true;                    
                }                
            }
        }

        private void treeListMenu_x_Usuario_x_Empresa_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            TreeList lista = sender as TreeList;
            if (e.Node == lista.FocusedNode)
            {
                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
                Rectangle rectangulo = new Rectangle(e.EditViewInfo.ContentRect.Left,
                    e.EditViewInfo.ContentRect.Top,
                    Convert.ToInt32(e.Graphics.MeasureString(e.CellText,this.treeListMenu_x_Usuario_x_Empresa.Font).Width+1),
                    Convert.ToInt32(e.Graphics.MeasureString(e.CellText,this.treeListMenu_x_Usuario_x_Empresa.Font).Height));
                e.Graphics.FillRectangle(SystemBrushes.Highlight, rectangulo);
                e.Graphics.DrawString(e.CellText, treeListMenu_x_Usuario_x_Empresa.Font, SystemBrushes.HighlightText, rectangulo);

                e.Handled = true;
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnContraer_Click(object sender, EventArgs e)
        {
            treeListMenu_x_Usuario_x_Empresa.ExpandAll();
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            Expandir_o_Contaraer_Nodos(treeListMenu_x_Usuario_x_Empresa.Nodes,false);
        }
        private void Expandir_o_Contaraer_Nodos(TreeListNodes nodos, bool ExpanderContraer)
        {
            try
            {
                foreach (TreeListNode nodo in nodos)
                {
                    if (nodo.Nodes.Count > 0)
                        Expandir_o_Contaraer_Nodos(nodo.Nodes, ExpanderContraer);
                    nodo.Expanded = ExpanderContraer;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al expandir nodos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
