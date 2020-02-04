using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;
using System.Collections;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Zonificacion_cons : Form
    {
        public frmFa_Zonificacion_cons()
        {
            try
            {
               InitializeComponent();
               //ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
               //ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
               //ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                //Log_Error_bus.Log_Error(ex.ToString());
                //MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  
        }

        //void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        this.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        frmFa_Zonificacion_Mant frm = new frmFa_Zonificacion_Mant();
        //        frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
        //        frm.set_ubicacion(info);
        //        frm.ShowDialog();
        //        load_ubicacion();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        frmFa_Zonificacion_Mant frm = new frmFa_Zonificacion_Mant();
        //        frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
        //        frm.ShowDialog();
        //        load_ubicacion();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        //tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //tb_ubicacion_Info info = new tb_ubicacion_Info();

        //public void load_ubicacion()
        //{
        //    try
        //    {
        //        tb_ubicacion_Bus bus_ubicacion = new tb_ubicacion_Bus();
        //        this.treelist_ubicacion.DataSource = bus_ubicacion.Get_List_Ubicacion();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void frmFA_Zonificacion_General_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        load_ubicacion();
        //        expandir_nodo();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void expandir_nodo()
        //{
        //    try
        //    {
        //        foreach (TreeListNode item in treelist_ubicacion.Nodes)
        //        {
        //            item.Expanded = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

 
        //private void treelist_ubicacion_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        //{
        //    try
        //    {
        //        TreeListColumn IdUbicacion = treelist_ubicacion.Columns["IdUbicacion"];
        //        TreeListColumn IdUbicacion_Padre = treelist_ubicacion.Columns["IdUbicacion_Padre"];
        //        TreeListColumn ub_descripcion = treelist_ubicacion.Columns["ub_descripcion"];
        //        TreeListColumn ub_nivel = treelist_ubicacion.Columns["ub_nivel"];
        //        TreeListColumn ub_posicion = treelist_ubicacion.Columns["ub_posicion"];
        //        TreeListColumn Estado = treelist_ubicacion.Columns["Estado"];
        //        TreeListNode childNode = (TreeListNode)e.Node;
        //        foreach (TreeListColumn item in treelist_ubicacion.Columns)
        //        {
        //            switch (item.FieldName)
        //            {
        //                case "IdUbicacion": info.IdUbicacion = Convert.ToString(childNode.GetValue(IdUbicacion)); break;
        //                case "IdUbicacion_Padre": info.IdUbicacion_Padre = Convert.ToString(childNode.GetValue(IdUbicacion_Padre)); break;
        //                case "ub_descripcion": info.ub_descripcion = Convert.ToString(childNode.GetValue(ub_descripcion)); break;
        //                case "ub_nivel": info.ub_nivel = Convert.ToInt32(childNode.GetValue(ub_nivel)); break;
        //                case "ub_posicion": info.ub_posicion = Convert.ToInt32(childNode.GetValue(ub_posicion)); break;
        //                case "Estado": info.Estado = Convert.ToString(childNode.GetValue(Estado)); break;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

       
    }
}
