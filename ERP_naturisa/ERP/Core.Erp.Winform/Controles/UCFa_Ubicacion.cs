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
using DevExpress.XtraTreeList.Columns;
using Core.Erp.Info.General;
using Core.Erp.Business.General;



namespace Core.Erp.Winform.Controles
{
    public partial class UCFa_Ubicacion : UserControl
    {
        public UCFa_Ubicacion()
        {
            try
            {
               InitializeComponent();
            }
            catch (Exception ex)
            {
                //string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                //MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }            
        }

        //tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //Boolean _Solo_chequea_unItem = false;
        //tb_ubicacion_Info info = new tb_ubicacion_Info();
        //List<tb_ubicacion_Info> lm = new List<tb_ubicacion_Info>();
        //public TreeListNode _NodoChequeado { get; set; }
        //public TreeListNode _NodoSeleccionado { get; set; }

        //public List<tb_ubicacion_Info> get_ListaUbicacion() { return lm; }

        //public void set_UbicacionCheckedSelection(tb_ubicacion_Info obj)
        //{
        //    try
        //    {
        //        info = new tb_ubicacion_Info();
        //        info.IdUbicacion = obj.IdUbicacion;
        //        info.IdUbicacion_Padre = obj.IdUbicacion_Padre;
        //        info.ub_descripcion = obj.ub_descripcion;
        //        info.ub_nivel = obj.ub_nivel;
        //        info.ub_posicion = obj.ub_posicion;

        //        info.Estado = obj.Estado;

        //        info = obj;
                
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }
        //}

        


        //public tb_ubicacion_Info get_Ubicacion()
        //{
        //    try
        //    {
        //        return info;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //        return new tb_ubicacion_Info();
        //    }

        //}

        //public void load_ubicacion()
        //{
        //    try
        //    {
        //        tb_ubicacion_Bus bus_ubicacion = new tb_ubicacion_Bus();
        //        lm=bus_ubicacion.Get_List_Ubicacion();
        //        this.treelist_Ubicacion.DataSource = lm;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }

        //}

        //private void expandir_nodo()
        //{
        //    try
        //    {
        //        foreach (TreeListNode item in treelist_Ubicacion.Nodes)
        //        {
        //            item.Expanded = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }

        //}

        //private void UCFac_Ubicacion_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        load_ubicacion();
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }

        //}

        //private void treelist_Ubicacion_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        //{
        //    try
        //    {
        //        TreeListNode childNode = (TreeListNode)e.Node;
        //        _NodoSeleccionado = childNode;

        //        info = (tb_ubicacion_Info)treelist_Ubicacion.GetDataRecordByNode(childNode);
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }

        //}

        //public void set_Treelist_SelectMultiple(Boolean valor)
        //{
        //    try
        //    {
        //      this.treelist_Ubicacion.OptionsSelection.MultiSelect = valor;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }

        //}


        //public void set_Treelist_AllowRecursiveNodeChecking(Boolean valor)
        //{
        //    try
        //    {
        //      this.treelist_Ubicacion.OptionsBehavior.AllowRecursiveNodeChecking = valor;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }

        //}


        //public void set_Treelist_ShowCheckBoxes(Boolean valor)
        //{
        //    try
        //    {
        //       this.treelist_Ubicacion.OptionsView.ShowCheckBoxes = valor;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }

        //}

        //public void set_Solo_chequea_unItem(Boolean valor)
        //{
        //    try
        //    {
        //       _Solo_chequea_unItem = valor;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }

        //}

        //private void treelist_Ubicacion_AfterCheckNode(object sender, NodeEventArgs e)
        //{
        //    try
        //    {
        //        TreeListNode childNode = (TreeListNode)e.Node;
        //        _NodoChequeado = childNode;
        //        info = (tb_ubicacion_Info)treelist_Ubicacion.GetDataRecordByNode(childNode);
        //        if (_Solo_chequea_unItem == true)
        //        {
        //            foreach (TreeListNode childNode2 in treelist_Ubicacion.Nodes)
        //            {
        //                childNode2.UncheckAll();
        //            }
        //            childNode.UncheckAll();
        //            childNode.Checked = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }
        //}




    }
}
