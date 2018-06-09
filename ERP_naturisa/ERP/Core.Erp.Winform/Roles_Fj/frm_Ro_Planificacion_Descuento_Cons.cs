using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.Roles;

using Core.Erp.Business.General;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Business.Roles;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frm_Ro_Planificacion_Descuento_Cons : Form
    {
        public frm_Ro_Planificacion_Descuento_Cons()
        {
            InitializeComponent();
        }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion;
        string mensaje = "";

        List<ro_descuento_no_planificados_Info> lista_descuento = new List<ro_descuento_no_planificados_Info>();
        ro_descuento_no_planificados_Bus bus_descuento = new ro_descuento_no_planificados_Bus();
        ro_descuento_no_planificados_Info info;
        frm_Ro_Planificacion_Descuento_Mant frm;
        private void ucGe_Menu_Load(object sender, EventArgs e)
        {
            Cargar_Data();
        }


        public void Cargar_Data()
        {
            try
            {
                lista_descuento = bus_descuento.listado_Descuento(param.IdEmpresa,ucGe_Menu.fecha_desde,ucGe_Menu.fecha_hasta);
                gridControl_descuento.DataSource = lista_descuento;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }
        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info = (ro_descuento_no_planificados_Info)gridView_descuento.GetFocusedRow();
                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                frm = new frm_Ro_Planificacion_Descuento_Mant();
                frm.Accion = Cl_Enumeradores.eTipo_action.consultar;
                frm.MdiParent = this.MdiParent;
                frm.Set(info);
                frm.Show();
              //  frm.event_frm_Ro_Planificacion_Descuento_Mant_FormClosing += frm_event_frm_Ro_Planificacion_Descuento_Mant_FormClosing;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                frm = new frm_Ro_Planificacion_Descuento_Mant();
                frm.Accion = Cl_Enumeradores.eTipo_action.grabar;
                frm.MdiParent = this.MdiParent;
                frm.Show();
              //  frm.event_frm_Ro_Planificacion_Descuento_Mant_FormClosing += frm_event_frm_Ro_Planificacion_Descuento_Mant_FormClosing;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info = (ro_descuento_no_planificados_Info)gridView_descuento.GetFocusedRow();
                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                frm = new frm_Ro_Planificacion_Descuento_Mant();
                frm.Accion = Cl_Enumeradores.eTipo_action.actualizar;
                frm.MdiParent = this.MdiParent;
                frm.Set(info);
                frm.Show();
             //   frm.event_frm_Ro_Planificacion_Descuento_Mant_FormClosing += frm_event_frm_Ro_Planificacion_Descuento_Mant_FormClosing;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info = (ro_descuento_no_planificados_Info)gridView_descuento.GetFocusedRow();
                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (info.Estado == false)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                frm = new frm_Ro_Planificacion_Descuento_Mant();
                frm.Accion = Cl_Enumeradores.eTipo_action.Anular;
                frm.MdiParent = this.MdiParent;
                frm.Set(info);
                frm.Show();
              //  frm.event_frm_Ro_Planificacion_Descuento_Mant_FormClosing += frm_event_frm_Ro_Planificacion_Descuento_Mant_FormClosing;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {
            Cargar_Data();
        }

        private void frm_Ro_Planificacion_Descuento_Cons_Load(object sender, EventArgs e)
        {
            Cargar_Data();
        }
    }
}
