using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Efectividad_entrega_x_periodo_xempleado_cosul : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_fectividad_Entrega_x_Periodo_Empleado_Info info = new ro_fectividad_Entrega_x_Periodo_Empleado_Info();
        List<ro_fectividad_Entrega_x_Periodo_Empleado_Info> lista = new List<ro_fectividad_Entrega_x_Periodo_Empleado_Info>();
        ro_fectividad_Entrega_x_Periodo_Empleado_Bus bus_efectivida = new ro_fectividad_Entrega_x_Periodo_Empleado_Bus();
        public frmRo_Efectividad_entrega_x_periodo_xempleado_cosul()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmRo_Efectividad_entrega_x_periodo_xempleado_mant frm = new frmRo_Efectividad_entrega_x_periodo_xempleado_mant();
                frm.Accion = Cl_Enumeradores.eTipo_action.grabar;
                frm.MdiParent = this.MdiParent;
                frm.Show();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info = (ro_fectividad_Entrega_x_Periodo_Empleado_Info)gvw_efectividad.GetFocusedRow();
                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                frmRo_Efectividad_entrega_x_periodo_xempleado_mant frm = new frmRo_Efectividad_entrega_x_periodo_xempleado_mant();
                frm.Accion = Cl_Enumeradores.eTipo_action.actualizar;
                frm.MdiParent = this.MdiParent;
                frm.set(info);
                frm.Show();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
                
                
            }
        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info = (ro_fectividad_Entrega_x_Periodo_Empleado_Info)gvw_efectividad.GetFocusedRow();
                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                frmRo_Efectividad_entrega_x_periodo_xempleado_mant frm = new frmRo_Efectividad_entrega_x_periodo_xempleado_mant();
                frm.Accion = Cl_Enumeradores.eTipo_action.consultar;
                frm.MdiParent = this.MdiParent;
                frm.set(info);
                frm.Show();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {


            try
            {
                Buscar();

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }

        }



        public void Buscar()
        {
            try
            {
                lista = bus_efectivida.listado_Grupos(param.IdEmpresa, ucGe_Menu.fecha_desde, ucGe_Menu.fecha_hasta);
                gc_efectividad.DataSource = lista;
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
        }
    }
}
