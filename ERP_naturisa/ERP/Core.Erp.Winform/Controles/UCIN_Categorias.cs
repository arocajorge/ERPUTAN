using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Nodes.Operations;
using DevExpress.XtraTreeList;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using DevExpress.XtraTreeList.Columns;
using Core.Erp.Info.General;
using Core.Erp.Winform.Inventario;

namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_Categorias : UserControl
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        in_categorias_bus _cateBu = new in_categorias_bus();
        List<in_categorias_Info> _listCategoria = new List<in_categorias_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Boolean _Solo_chequea_unItem = false;
        public TreeListNode _NodoChequeado { get; set; }
        public TreeListNode _NodoSeleccionado { get; set; }
        public in_categorias_Info _iCategoriaInfo { get; set; }
        public List<in_categorias_Info> _iCategoriaListInfo { get; set; }
        public Boolean cambiarempresaRptCons { get; set; }
        public int idempresa { get; set; }
        public delegate void Delegate_treeListCategoria_AfterCheckNode(object sender, NodeEventArgs e);
        public event Delegate_treeListCategoria_AfterCheckNode Event_treeListCategoria_AfterCheckNode;
        
        #endregion
       
        public UCIn_Categorias()
        {
            try
            {
                InitializeComponent();            
                _iCategoriaInfo = new in_categorias_Info();
                _iCategoriaListInfo= new List<in_categorias_Info>();
                Event_treeListCategoria_AfterCheckNode += UCIn_Categorias_Event_treeListCategoria_AfterCheckNode;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void UCIn_Categorias_Event_treeListCategoria_AfterCheckNode(object sender, NodeEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public in_categorias_Info get_categoriainfo()
        {
            try
            {
                return _iCategoriaInfo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new in_categorias_Info();                
            }
        }

        public List< in_categorias_Info> get_categoriaListinfo()
        {
            try
            {

                return _iCategoriaListInfo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<in_categorias_Info>();                
            }
        }
        
        public void set_CategoriaCheckedSelection(in_categorias_Info CategorioInfo)
        {

           try
            {

             _iCategoriaInfo=  CategorioInfo;

               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public List<in_categorias_Info> get_CategoriaList()
        {

            try
            {
                
                return new List<in_categorias_Info>();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<in_categorias_Info>();
            }
        }

        private void treeListCategoria_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void set_Treelist_SelectMultiple(Boolean valor)
        {
            try
            {
                  this.treeListCategoria.OptionsSelection.MultiSelect = valor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

       
        }

        public void set_ChequearTodos(Boolean chequear)
        {
            try
            {
                treeListCategoria.ExpandAll();
                if (chequear == true)
                    treeListCategoria.CheckAll();
                else
                    treeListCategoria.UncheckAll();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void set_Treelist_AllowRecursiveNodeChecking(Boolean valor)
        {
            try
            {
                this.treeListCategoria.OptionsBehavior.AllowRecursiveNodeChecking = valor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Treelist_ShowCheckBoxes(Boolean valor)
        {
            try
            {
             this.treeListCategoria.OptionsView.ShowCheckBoxes = valor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void cargar_treelist()
        {

            try
            {
                if (cambiarempresaRptCons == true && idempresa != 0)
                    _listCategoria = _cateBu.Get_List_categorias(idempresa);
                else
                    _listCategoria = _cateBu.Get_List_categorias(param.IdEmpresa);
                this.treeListCategoria.DataSource = _listCategoria;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCIN_Categorias_Load(object sender, EventArgs e)
        {
            try
            {
                 cargar_treelist();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        public void set_Solo_chequea_unItem(Boolean valor)
        {
            try
            {
                _Solo_chequea_unItem = valor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void treeListCategoria_AfterCheckNode(object sender, NodeEventArgs e)
        {
            try
            {
                TreeListNode childNode = (TreeListNode)e.Node;
                _NodoChequeado = childNode;
                _iCategoriaInfo = (in_categorias_Info)treeListCategoria.GetDataRecordByNode(childNode);               

                if (_Solo_chequea_unItem == true)
                {
                    foreach (TreeListNode childNode2 in treeListCategoria.Nodes)
                    {
                        childNode2.UncheckAll();
                    }

                    childNode.UncheckAll();
                    childNode.Checked = true;
                }
                else
                {
                 _iCategoriaListInfo.Clear();

                    foreach (TreeListNode childNode2 in treeListCategoria.Nodes)
                    {                          
                      
                        if (childNode2.Checked == true)
                        {
                            _iCategoriaListInfo.Add(_iCategoriaInfo);
                        }

                    }
                    foreach (TreeListNode childNoode3 in treeListCategoria.Nodes) { }
                    
                }
                Event_treeListCategoria_AfterCheckNode(_iCategoriaInfo, e);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
              
            }           

        }

        private void cmb_Acciones_Click(object sender, EventArgs e)
        {
            try
            {
                MenuAcciones.Show(cmb_Acciones, new Point(0, cmb_Acciones.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                get_CategoriaList();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                get_categoriainfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                FrmIn_Categoria_Mant frm = new FrmIn_Categoria_Mant();
                frm.ReloadGrid += frm_ReloadGrid;
                
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.set_categoria(_iCategoriaInfo);
                    frm.set_CategoriaCheckedSelection(_iCategoriaInfo);
                    frm.set_Accion(Accion);
                    
                }
                else
                    frm.set_Accion(Accion);

                frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_ReloadGrid()
        {
            try
            {
                cargar_treelist();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

    }
}
