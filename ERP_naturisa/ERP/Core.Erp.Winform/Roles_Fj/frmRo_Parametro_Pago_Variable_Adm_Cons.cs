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
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Parametro_Pago_Variable_Adm_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_parametro_x_pago_variable_Info> lista = new List<ro_parametro_x_pago_variable_Info>();
        ro_parametro_x_pago_variable_Bus bus = new ro_parametro_x_pago_variable_Bus();
        ro_parametro_x_pago_variable_Info info;
        public frmRo_Parametro_Pago_Variable_Adm_Cons()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                frmRo_Parametro_Pago_Variable_Adm_Mant  frm = new frmRo_Parametro_Pago_Variable_Adm_Mant();
                frm.Accion = Cl_Enumeradores.eTipo_action.grabar;
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception)
            {
                
               
            }
        }

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info = (ro_parametro_x_pago_variable_Info)gridView_parametros_variables.GetFocusedRow();

                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (info.Estado == false)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                frmRo_Parametro_Pago_Variable_Adm_Mant frm = new frmRo_Parametro_Pago_Variable_Adm_Mant();
                frm.Accion = Cl_Enumeradores.eTipo_action.actualizar;
                frm.MdiParent = this.MdiParent;
                frm.Set(info);
                frm.Show();
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
                info = (ro_parametro_x_pago_variable_Info)gridView_parametros_variables.GetFocusedRow();
                  if (info.Estado == false)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                frmRo_Parametro_Pago_Variable_Adm_Mant frm = new frmRo_Parametro_Pago_Variable_Adm_Mant();
                frm.Accion = Cl_Enumeradores.eTipo_action.Anular;
                frm.MdiParent = this.MdiParent;
                frm.Set(info);
                frm.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        
        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info = (ro_parametro_x_pago_variable_Info)gridView_parametros_variables.GetFocusedRow();

                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                frmRo_Parametro_Pago_Variable_Adm_Mant frm = new frmRo_Parametro_Pago_Variable_Adm_Mant();
                frm.Accion = Cl_Enumeradores.eTipo_action.consultar;
                frm.MdiParent = this.MdiParent;
                frm.Set(info);
                frm.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        public void Buscar()
        {
            try
            {
                lista = bus.listado_parametro_pago_variable(param.IdEmpresa);
                gridControl_parametros_variables.DataSource = lista;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void frmRo_Parametro_Pago_Variable_Adm_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                Buscar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }
    }
}
