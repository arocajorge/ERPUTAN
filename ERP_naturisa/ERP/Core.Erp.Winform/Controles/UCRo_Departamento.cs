using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using DevExpress.XtraTreeList.Nodes;
//using Core.Erp.Handlers;
//using Core.Erp.Handlers.Roles;

/*
     ///
     * Planificacion de Horarios
     * Programador : Ing Katiuska Franco T
     * Ultima Version  a unificar 0801 2014 hora 1500 
     * 
     * 
     */
namespace Core.Erp.Winform.Controles
{


    public partial class UCRo_Departamento : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ro_Departamento_Bus BusDep = new ro_Departamento_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;    
        public ro_Departamento_Info InfoDepartamento = new ro_Departamento_Info();
        List<ro_Departamento_Info> LstInfoDep = new List<ro_Departamento_Info>();
        List<ro_Departamento_Info> _LstInfoDep = new List<ro_Departamento_Info>();
        public ro_Departamento_Info _deptInfo { get; set; }
        public TreeListNode _NodoChequeado { get; set; }
        public TreeListNode _NodoSeleccionado { get; set; }
        public Boolean _Solo_chequea_unItem = false;

        public ro_Departamento_Info get_DepartamentoInfo()
        {
            try
            {
                return InfoDepartamento;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ro_Departamento_Info();
            }
        }

        public void Inicializar()
        {
            try
            {
                foreach (TreeListNode childNode2 in TreeListDepartamento.Nodes)
                {
                    childNode2.UncheckAll();
                }
                InfoDepartamento = new ro_Departamento_Info();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }       
        }

        List<ro_Departamento_Info> DEP_CHEKEADOS = new List<ro_Departamento_Info>();


        public void GetITEMSCHEKEADOS(TreeListNodes NODO) 
        {
            try
            {
                foreach (TreeListNode item in NODO)
                    {
                
                        if(item.HasChildren)
                        {
                            if (item.CheckState == CheckState.Checked || item.CheckState == CheckState.Indeterminate)
                            {
                                DEP_CHEKEADOS.Add((ro_Departamento_Info)TreeListDepartamento.GetDataRecordByNode(item));
                            }
                            GetITEMSCHEKEADOS(item.Nodes);
                        }
                        else
                        {
                            if (item.CheckState == CheckState.Checked || item.CheckState == CheckState.Indeterminate) 
                            {
                                DEP_CHEKEADOS.Add((ro_Departamento_Info)TreeListDepartamento.GetDataRecordByNode(item));
                            }
                        }

                    }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }          
        
        }


        public List<ro_Departamento_Info> get_Departamentosinfo()
        {
            try
            {
                DEP_CHEKEADOS.Clear();
               
                    GetITEMSCHEKEADOS(TreeListDepartamento.Nodes);

                   return DEP_CHEKEADOS;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<ro_Departamento_Info>();
            }
        }

     
        public UCRo_Departamento()
        {
            try
            {
                 InitializeComponent();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCRo_Departamento_Load(object sender, EventArgs e)
        {
            try
            {
                load_datos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }     

        public void load_datos()
        {
            try
            {
                LstInfoDep = BusDep.Get_List_Departamento(param.IdEmpresa);
                TreeListDepartamento.DataSource = LstInfoDep;
                ExpandAll();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        // funcion para chear el trelist con el ida del departamento
        public void set_DepartamentoCheckedSelection(ro_Departamento_Info DepartmentInfo)
        {
            try
            {
                _deptInfo = DepartmentInfo;
           
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
                this.TreeListDepartamento.OptionsSelection.MultiSelect = valor;
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
              this.TreeListDepartamento.OptionsBehavior.AllowRecursiveNodeChecking = valor;
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
                 this.TreeListDepartamento.OptionsView.ShowCheckBoxes = valor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void TreeListDepartamento_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                InfoDepartamento = (ro_Departamento_Info)TreeListDepartamento.GetDataRecordByNode(e.Node);
                //InfoDepartamento.IdDepartamentoPadre = ((get_DepartamentoInfo().IdDepartamento));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void TreeListDepartamento_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            try
            {
                TreeListNode childNode = (TreeListNode)e.Node;
                _NodoChequeado = childNode;
                InfoDepartamento = (ro_Departamento_Info)TreeListDepartamento.GetDataRecordByNode(childNode);
                if (_Solo_chequea_unItem == true)
                {
                    foreach (TreeListNode childNode2 in TreeListDepartamento.Nodes)
                    {
                        childNode2.UncheckAll();
                    }
                    childNode.UncheckAll();
                    childNode.Checked = true;
                }
                else
                {
                    _LstInfoDep.Clear();
                    foreach (TreeListNode childNode2 in TreeListDepartamento.Nodes)
                    {
                        if (childNode2.Checked == true)
                        {
                            _LstInfoDep.Add(InfoDepartamento);
                        }
                    }
                   
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ExpandAll()
        {
            try
            {
               TreeListDepartamento.ExpandAll();
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
/// <summary>
/// Prog: Katiuska Franco
/// Ult Mod: 26/02/2014  12:36
/// LIN253
/// </summary>
