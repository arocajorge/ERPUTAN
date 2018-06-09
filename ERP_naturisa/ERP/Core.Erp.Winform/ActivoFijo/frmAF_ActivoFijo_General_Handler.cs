using Core.Erp.Business.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Info.General;
using Core.Erp.Winform.ActivoFijo_FJ;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.ActivoFijo
{
    public class frmAF_ActivoFijo_General_Handler
    {

    //    #region Declaracion controles

    //    public System.Windows.Forms.Panel panel1;
    //    public Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
    //    public System.Windows.Forms.Panel panel2;
    //    public Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
    //    public DevExpress.XtraGrid.GridControl dgActivoFijo;
    //    public DevExpress.XtraGrid.Views.Grid.GridView gridViewActivoFijo;
    //    public DevExpress.XtraGrid.Columns.GridColumn colEstado;
    //    public DevExpress.XtraGrid.Columns.GridColumn colIdActivoFijo;
    //    public DevExpress.XtraGrid.Columns.GridColumn colAf_Nombre;
    //    public DevExpress.XtraGrid.Columns.GridColumn colAf_Marca;
    //    public DevExpress.XtraGrid.Columns.GridColumn colAf_Modelo;
    //    public DevExpress.XtraGrid.Columns.GridColumn colAf_Color;
    //    public DevExpress.XtraGrid.Columns.GridColumn colEncargado;
    //    public DevExpress.XtraGrid.Columns.GridColumn colAf_observacion;

    //    #endregion

    //    #region Declaración de Variables
    //    tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
    //    public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
    //    List<Af_Activo_fijo_Info> lm = new List<Af_Activo_fijo_Info>();
    //    Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
    //    Af_Activo_fijo_Bus bus_activo_fijo = new Af_Activo_fijo_Bus();
    //    #endregion

    //    Form FrmChildren;
    //    Form FrmParent;
    //    Cl_Enumeradores.eCliente_Vzen eCliente;
    //    frmAF_ActivoFijo_Mant frm;
    //    frmAF_ActivoFijo_Mant_FJ frm_FJ;
    //    public void Set_FrmChildren(Form _FrmChildren)
    //    {
    //        try
    //        {
    //            this.FrmChildren = _FrmChildren;
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }
    //    }

    //    public void Set_FrmParent(Form _FrmParent)
    //    {
    //        try
    //        {
    //            this.FrmParent = _FrmParent;
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }
    //    }

    //    public void Set_eCliente(Cl_Enumeradores.eCliente_Vzen _eCliente)
    //    {
    //        try
    //        {
    //            this.eCliente = _eCliente;
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }
    //    }

    //    public frmAF_ActivoFijo_General_Handler()
    //    {
    //        if (eCliente == 0)
    //        {
    //            eCliente = Cl_Enumeradores.eCliente_Vzen.GENERAL;
    //        }
    //    }

    //    public void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    //    {
    //        try
    //        {
    //            if (info.IdActivoFijo != 0)
    //            {
    //                Llamar_Formulario(Cl_Enumeradores.eTipo_action.Anular);
    //            }
    //            else
    //                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }
    //    }

    //    public void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    //    {
    //        try
    //        {
    //            FrmChildren.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }
    //    }

    //    public void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    //    {
    //        try
    //        {
    //            if (info.IdActivoFijo != 0)
    //            {

    //                Llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
    //            }
    //            else
    //                //Por_favor_seleccione_item_a_consul
    //                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_consul), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }
    //    }

    //    public void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    //    {
    //        try
    //        {
    //            if (info.IdActivoFijo != 0)
    //            {
    //                Llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
    //            }
    //            else
    //                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }
    //    }

    //    public void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    //    {
    //        try
    //        {
    //            Llamar_Formulario(Cl_Enumeradores.eTipo_action.grabar);

    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }
    //    }

    //    public void load_ActivoFijo()
    //    {
    //        try
    //        {
    //            //lm = bus_activo_fijo.Get_List_ActivoFijo(param.IdEmpresa, "");
    //            lm = bus_activo_fijo.Get_List_Vista_Af(param.IdEmpresa);
    //            this.dgActivoFijo.DataSource = lm;
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }
    //    }

    //    public void frm_event_frmAF_ActivoFijo_Mant_FormClosing(object sender, FormClosingEventArgs e)
    //    {
    //        try
    //        {
    //            load_ActivoFijo();
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }

    //    }

    //    public void frmAF_ActivoFijo_General_Load(object sender, EventArgs e)
    //    {
    //        try
    //        {
    //            load_ActivoFijo();
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }

    //    }

    //    public void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
    //    {

    //    }

    //    public void gridViewActivoFijo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    //    {
    //        try
    //        {
    //            info = (Af_Activo_fijo_Info)gridViewActivoFijo.GetFocusedRow();
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }
    //    }

    //    public void gridViewActivoFijo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    //    {
    //        try
    //        {
    //            var data = gridViewActivoFijo.GetRow(e.RowHandle) as Af_Activo_fijo_Info;
    //            if (data == null)
    //                return;
    //            if (data.Estado == "I")
    //                e.Appearance.ForeColor = Color.Red;
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }
    //    }

    //    private Af_Activo_fijo_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
    //    {

    //        try
    //        {
    //            return (Af_Activo_fijo_Info)view.GetRow(view.FocusedRowHandle);
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //            return new Af_Activo_fijo_Info();
    //        }
    //    }

    //    public void gridViewActivoFijo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
    //    {
    //        try
    //        {
    //            info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }
    //    }

    //    private void Llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
    //    {
    //        try
    //        {
    //            switch (eCliente)
    //            {
    //                case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
    //                    break;
    //                case Cl_Enumeradores.eCliente_Vzen.NATURISA:
    //                    break;
    //                case Cl_Enumeradores.eCliente_Vzen.FJ:
    //                    Llamar_Formulario_FJ(Accion);
    //                    break;
    //                case Cl_Enumeradores.eCliente_Vzen.GENERAL:
    //                    Llamar_Formulario_GE(Accion);
    //                    break;
    //                default:
    //                    Llamar_Formulario_GE(Accion);
    //                    break;
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }
    //    }

    //    private void Llamar_Formulario_GE(Cl_Enumeradores.eTipo_action Accion)
    //    {
    //        try
    //        {
    //            frm = new frmAF_ActivoFijo_Mant();
    //            frm.set_Accion(Accion);
    //            if (Accion != Cl_Enumeradores.eTipo_action.grabar)
    //            {
    //                frm.set_ActivoFijo(bus_activo_fijo.Get_Info_ActivoFijo(info.IdEmpresa, info.IdActivoFijo));
    //            }
    //            frm.event_frmAF_ActivoFijo_Mant_FormClosing += new frmAF_ActivoFijo_Mant.delegate_frmAF_ActivoFijo_Mant_FormClosing(frm_event_frmAF_ActivoFijo_Mant_FormClosing);
    //            frm.Show();
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }
    //    }

    //    private void Llamar_Formulario_FJ(Cl_Enumeradores.eTipo_action Accion)
    //    {
    //        try
    //        {
    //            frm_FJ = new frmAF_ActivoFijo_Mant_FJ();
    //            frm_FJ.set_Accion(Accion);
    //            if (Accion != Cl_Enumeradores.eTipo_action.grabar)
    //            {
    //                frm_FJ.set_ActivoFijo(bus_activo_fijo.Get_Info_ActivoFijo(info.IdEmpresa, info.IdActivoFijo));
    //            }
    //            //frm_FJ.event_frmAF_ActivoFijo_Mant_FormClosing += new frmAF_ActivoFijo_Mant_FJ.delegate_frmAF_ActivoFijo_Mant_FormClosing(frm_event_frmAF_ActivoFijo_Mant_FormClosing);
    //            frm_FJ.Show();
    //        }
    //        catch (Exception ex)
    //        {
    //            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
    //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
    //        }
    //    }

    }
}
