using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;


namespace Core.Erp.Winform.Inventario
{
    public partial class Frm_Cat_Line_Grup_SubGrup_Mant : Form
    {       
        //Bus
        in_categorias_bus bus_Categoria = new in_categorias_bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();     
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        vwin_categoria_lin_gr_subgr_Bus bus_lin_gr_subgr = new vwin_categoria_lin_gr_subgr_Bus();
    
        in_linea_Bus bus_linea = new in_linea_Bus();
        in_grupo_Bus bus_grupo = new in_grupo_Bus();
        in_subgrupo_Bus bus_subgrupo = new in_subgrupo_Bus();
     

        //Listas
        List<vwin_categoria_lin_gr_subgr_Info> _listCategoria_treeList = new List<vwin_categoria_lin_gr_subgr_Info>();

        List<in_linea_info> listLinea = new List<in_linea_info>();
        List<in_grupo_info> listGrupo = new List<in_grupo_info>();
        List<in_subgrupo_info> listSubGrupo = new List<in_subgrupo_info>();
        List<in_categorias_Info> listCategoria = new List<in_categorias_Info>();

        //Infos
        in_linea_info infoLinea;
        in_grupo_info infoGrupo;
        in_subgrupo_info infoSubGrupo;

        vwin_categoria_lin_gr_subgr_Info _iCategoria = new vwin_categoria_lin_gr_subgr_Info();
        in_categorias_Info _iCategoriaPadre = new in_categorias_Info();

        //Variables
        string titulo = "";

        FrmIn_Linea_Mant ofrLinea;
        FrmIn_Grupo_Mant ofrGrupo;
        FrmIn_SubGrupo_Mant ofrSubGrupo;
        FrmIn_Categoria_Mant fr;
     
        Cl_Enumeradores.eTipo_action accion = new Cl_Enumeradores.eTipo_action();
        
        public Frm_Cat_Line_Grup_SubGrup_Mant()
        {
            InitializeComponent();
        }
           
        void Cargar_Listas()
        {
            try
            {
                listLinea = bus_linea.ConsultaGeneralLinea(param.IdEmpresa);
                listGrupo = bus_grupo.Get_List_Grupo(param.IdEmpresa);
                listSubGrupo = bus_subgrupo.ConsultaGeneralSubGrupo(param.IdEmpresa);
                listCategoria = bus_Categoria.Get_List_categorias(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Cargar_Categorias_TreList()
        {
            try
            {
                _listCategoria_treeList = bus_lin_gr_subgr.Get_List_in_categoria_lin_gr_subg(param.IdEmpresa);
                treeListLinGruSub.DataSource = _listCategoria_treeList;
                treeListLinGruSub.RefreshDataSource();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Frm_Cat_Line_Grup_SubGrup_Mant_Load(object sender, EventArgs e)
        {
            try
            {             
                Cargar_Categorias_TreList();

                Cargar_Listas();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
             
        private void btnMenuItemNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (_iCategoria != null)
                {
                    if (_iCategoria.IdNivel == 1)
                    {                       
                        fr = new FrmIn_Categoria_Mant();
                        fr.ReloadGrid += fr_ReloadGrid;
                        fr.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                        fr.MdiParent = this.MdiParent;
                        fr.Show();
                    }

                    if (_iCategoria.IdNivel == 2)
                    {
                       
                        ofrLinea = new FrmIn_Linea_Mant(Cl_Enumeradores.eTipo_action.grabar);
                        ofrLinea.Delegado_FrmIn_Linea_Mant += ofr_Delegado_FrmIn_Linea_Mant;
                        ofrLinea.Text = ofrLinea.Text + " ***NUEVO REGISTRO***";
                        ofrLinea.MdiParent = this.MdiParent;
                        ofrLinea.Show();
                    }

                    if (_iCategoria.IdNivel == 3)
                    {
                      
                        ofrGrupo = new FrmIn_Grupo_Mant(Cl_Enumeradores.eTipo_action.grabar);
                        ofrGrupo.Delegado_FrmIn_Grupo_Mant += ofrGrupo_Delegado_FrmIn_Grupo_Mant;
                        ofrGrupo.Text = ofrGrupo.Text + " ***NUEVO REGISTRO***";
                        ofrGrupo.MdiParent = this.MdiParent;
                        ofrGrupo.Show();

                    }

                    if (_iCategoria.IdNivel == 4)
                    {
                        
                        ofrSubGrupo = new FrmIn_SubGrupo_Mant(Cl_Enumeradores.eTipo_action.grabar);
                        ofrSubGrupo.Event_FrmIn_SubGrupo_Mant_FormClosing +=ofrSubGrupo_Event_FrmIn_SubGrupo_Mant_FormClosing;
                        ofrSubGrupo.Text = ofrSubGrupo.Text + " ***NUEVO REGISTRO***";
                        ofrSubGrupo.MdiParent = this.MdiParent;
                        ofrSubGrupo.Show();
                    }
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               
                }
                              
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ofrGrupo_Delegado_FrmIn_Grupo_Mant()
        {
            Cargar_Categorias_TreList();
        }

        void ofr_Delegado_FrmIn_Linea_Mant()
        {
            Cargar_Categorias_TreList();
        }

        void fr_ReloadGrid()
        {
            Cargar_Categorias_TreList();
        }
         
        in_categorias_Info info; 
        void Update_Search_Delete(Cl_Enumeradores.eTipo_action accion,string titulo)
        {
            try
            {
                if (_iCategoria != null)
                {
                    if (_iCategoria.IdNivel == 1)
                    {

                        if (_iCategoria.Estado == "I" && accion == Cl_Enumeradores.eTipo_action.actualizar)
                        {
                            MessageBox.Show("No se pueden modificar registros inactivos (I)", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;

                        }
                        else
                        {
                            if (_iCategoria.Estado == "I" && accion == Cl_Enumeradores.eTipo_action.Anular)
                            {
                                MessageBox.Show("El registro seleccionado ya fue anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;

                            }

                            else
                            {


                                fr = new FrmIn_Categoria_Mant();
                                fr.set_Accion(accion);

                                info = new in_categorias_Info();
                                info = listCategoria.FirstOrDefault(q => q.IdEmpresa == _iCategoria.IdEmpresa && q.IdCategoria == _iCategoria.IdCategoria);

                                _iCategoriaPadre = listCategoria.Find(delegate(in_categorias_Info ca)
                                {
                                    return ca.IdCategoria == info.IdCategoriaPadre && ca.IdEmpresa == _iCategoria.IdEmpresa;
                                });

                                fr.set_categoria(info);
                                fr.set_categoriaPadre(_iCategoriaPadre);

                                fr.MdiParent = MdiParent;
                                fr.ReloadGrid += fr_ReloadGrid;
                                fr.Show();
                            }
                        }
                    }

                    if (_iCategoria.IdNivel == 2)
                    {

                        if (_iCategoria.Estado == "I" && accion == Cl_Enumeradores.eTipo_action.actualizar)
                        {
                            MessageBox.Show("No se pueden modificar registros inactivos (I)", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;

                        }
                        else
                        {
                           if (_iCategoria.Estado == "I" && accion == Cl_Enumeradores.eTipo_action.Anular)
                           {
                              MessageBox.Show("El registro seleccionado ya fue anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                             return;

                           }

                           else
                           {
                               ofrLinea = new FrmIn_Linea_Mant();
                               
                               infoLinea = new in_linea_info();
                               infoLinea = listLinea.FirstOrDefault(q => q.IdEmpresa == _iCategoria.IdEmpresa && q.IdCategoria == _iCategoria.IdCategoria && q.IdLinea == _iCategoria.IdLinea);

                               ofrLinea = new FrmIn_Linea_Mant(accion);
                               ofrLinea.Delegado_FrmIn_Linea_Mant += ofr_Delegado_FrmIn_Linea_Mant;
                               ofrLinea.Text = ofrLinea.Text + titulo;
                               ofrLinea._SetInfo = infoLinea;
                               ofrLinea.MdiParent = this.MdiParent;
                               ofrLinea.Show();
                           }
                        
                        }                      
                    }

                    if (_iCategoria.IdNivel == 3)
                    {
                        if (_iCategoria.Estado == "I" && accion == Cl_Enumeradores.eTipo_action.actualizar)
                        {
                            MessageBox.Show("No se pueden modificar registros inactivos (I)", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            if (_iCategoria.Estado == "I" && accion == Cl_Enumeradores.eTipo_action.Anular)
                            {
                                MessageBox.Show("El registro seleccionado ya fue anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                            else
                            {
                                ofrGrupo = new FrmIn_Grupo_Mant();
                                ofrGrupo.Delegado_FrmIn_Grupo_Mant += ofrGrupo_Delegado_FrmIn_Grupo_Mant;

                                infoGrupo = new in_grupo_info();
                                infoGrupo = listGrupo.FirstOrDefault(q => q.IdEmpresa == _iCategoria.IdEmpresa && q.IdCategoria == _iCategoria.IdCategoria && q.IdLinea == _iCategoria.IdLinea && _iCategoria.IdGrupo == q.IdGrupo);

                                ofrGrupo = new FrmIn_Grupo_Mant(accion);
                                ofrGrupo.Delegado_FrmIn_Grupo_Mant += ofrGrupo_Delegado_FrmIn_Grupo_Mant;
                                ofrGrupo.Text = ofrGrupo.Text + titulo;
                                ofrGrupo._SetInfo = infoGrupo;
                                ofrGrupo.MdiParent = this.MdiParent;
                                ofrGrupo.Show();
                            }
                        }
                    }

                    if (_iCategoria.IdNivel == 4)
                    {
                        if (_iCategoria.Estado == "I" && accion == Cl_Enumeradores.eTipo_action.actualizar)
                        {
                            MessageBox.Show("No se pueden modificar registros inactivos (I)", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            if (_iCategoria.Estado == "I" && accion == Cl_Enumeradores.eTipo_action.Anular)
                            {
                                MessageBox.Show("El registro seleccionado ya fue anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                            else
                            {
                                ofrSubGrupo = new FrmIn_SubGrupo_Mant();
                                ofrSubGrupo.Event_FrmIn_SubGrupo_Mant_FormClosing +=ofrSubGrupo_Event_FrmIn_SubGrupo_Mant_FormClosing;

                                infoSubGrupo = new in_subgrupo_info();
                                infoSubGrupo = listSubGrupo.FirstOrDefault(q => q.IdEmpresa == _iCategoria.IdEmpresa && q.IdCategoria == _iCategoria.IdCategoria && q.IdLinea == _iCategoria.IdLinea && _iCategoria.IdGrupo == q.IdGrupo && _iCategoria.IdSubGrupo == q.IdSubgrupo);

                                ofrSubGrupo = new FrmIn_SubGrupo_Mant(accion);
                                ofrSubGrupo.Event_FrmIn_SubGrupo_Mant_FormClosing +=ofrSubGrupo_Event_FrmIn_SubGrupo_Mant_FormClosing;
                                ofrSubGrupo.Text = ofrSubGrupo.Text + titulo;
                                ofrSubGrupo._SetInfo = infoSubGrupo;
                                ofrSubGrupo.MdiParent = this.MdiParent;
                                ofrSubGrupo.Show();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }                              
        }
          
        private void btnMenuItemModificar_Click(object sender, EventArgs e)
        {
            try
            {
                accion = Cl_Enumeradores.eTipo_action.actualizar;
                titulo = "***MODIFICAR REGISTRO***";
                Update_Search_Delete(accion, titulo);
             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        }

        private void btnMenuItemConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                accion = Cl_Enumeradores.eTipo_action.consultar;
                titulo = "***CONSULTAR REGISTRO***";
                Update_Search_Delete(accion, titulo);
                                                         
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
          
        private void treeListLinGruSub_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                TreeListNode childNode = (TreeListNode)e.Node;

                _iCategoria = (vwin_categoria_lin_gr_subgr_Info)treeListLinGruSub.GetDataRecordByNode(childNode);               
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeListLinGruSub_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                 if (e.Button == MouseButtons.Right)
            {               
                Point p = new Point(e.X, e.Y);
                             
                if (_iCategoria != null)
                {

                    if (_iCategoria.IdNivel == 1)
                    {
                        this.btnMenuItemNuevo.Text = "Nueva Categoría";
                        this.btnMenuItemModificar.Text = "Modificar Categoría";
                        this.btnMenuItemConsulta.Text = "Consultar Categoría";
                        this.btnMenuItemAnular.Text = "Anular Categoría";
                    }
                    
                    if (_iCategoria.IdNivel==2)
                    {
                        this.btnMenuItemNuevo.Text = "Nueva Linea";
                        this.btnMenuItemModificar.Text = "Modificar Linea";
                        this.btnMenuItemConsulta.Text = "Consultar Linea";
                        this.btnMenuItemAnular.Text = "Anular Linea";
                    }
                    if (_iCategoria.IdNivel == 3)
                    {
                        this.btnMenuItemNuevo.Text = "Nuevo Grupo";
                        this.btnMenuItemModificar.Text = "Modificar Grupo";
                        this.btnMenuItemConsulta.Text = "Consultar Grupo";
                        this.btnMenuItemAnular.Text = "Anular Grupo";
                    }
                    if (_iCategoria.IdNivel == 4)
                    {
                        this.btnMenuItemNuevo.Text = "Nuevo Sub Grupo";
                        this.btnMenuItemModificar.Text = "Modificar Sub Grupo";
                        this.btnMenuItemConsulta.Text = "Consultar Sub Grupo";
                        this.btnMenuItemAnular.Text = "Anular Sub Grupo";
                    }
                                       
                    menuCategorias.Show(treeListLinGruSub, p);               
                }

            }
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenuItemAnular_Click(object sender, EventArgs e)
        {
            try
            {
                accion = Cl_Enumeradores.eTipo_action.Anular;
                titulo = "***ANULAR REGISTRO***";
                Update_Search_Delete(accion, titulo);
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCatetegoria_Click(object sender, EventArgs e)
        {
            try
            {
                fr = new FrmIn_Categoria_Mant();
                fr.ReloadGrid += fr_ReloadGrid;
                fr.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                fr.MdiParent = this.MdiParent;
                fr.Show();
            }
            catch (Exception ex)
            {                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            try
            {
                 ofrLinea = new FrmIn_Linea_Mant(Cl_Enumeradores.eTipo_action.grabar);
                 ofrLinea.Delegado_FrmIn_Linea_Mant += ofr_Delegado_FrmIn_Linea_Mant;
                 ofrLinea.Text = ofrLinea.Text + " ***NUEVO REGISTRO***";
                 ofrLinea.MdiParent = this.MdiParent;
                 ofrLinea.Show();
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                 ofrGrupo = new FrmIn_Grupo_Mant(Cl_Enumeradores.eTipo_action.grabar);
                 ofrGrupo.Delegado_FrmIn_Grupo_Mant += ofrGrupo_Delegado_FrmIn_Grupo_Mant;
                 ofrGrupo.Text = ofrGrupo.Text + " ***NUEVO REGISTRO***";
                 ofrGrupo.MdiParent = this.MdiParent;
                 ofrGrupo.Show();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                   ofrSubGrupo = new FrmIn_SubGrupo_Mant(Cl_Enumeradores.eTipo_action.grabar);
                   ofrSubGrupo.Event_FrmIn_SubGrupo_Mant_FormClosing += ofrSubGrupo_Event_FrmIn_SubGrupo_Mant_FormClosing;
                   ofrSubGrupo.Text = ofrSubGrupo.Text + " ***NUEVO REGISTRO***";
                   ofrSubGrupo.MdiParent = this.MdiParent;
                   ofrSubGrupo.Show();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ofrSubGrupo_Event_FrmIn_SubGrupo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cargar_Listas();
            Cargar_Categorias_TreList();
        }

        private void treeListLinGruSub_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            try
            {          
                TreeListNode childNode = (TreeListNode)e.Node;
                var data = treeListLinGruSub.GetDataRecordByNode(childNode) as vwin_categoria_lin_gr_subgr_Info;
                if (data == null)
                    return;           
                if (data.Estado == "I")
                {
                    e.Appearance.ForeColor = Color.Red;                               
                }
            }
            catch (Exception ex)
            {               
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {             
                treeListLinGruSub.ShowPrintPreview();
            }
            catch (Exception ex)
            {               
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
