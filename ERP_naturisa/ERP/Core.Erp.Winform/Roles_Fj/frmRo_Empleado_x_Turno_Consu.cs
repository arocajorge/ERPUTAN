using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using System.Globalization;
using Core.Erp.Info.General;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
namespace Core.Erp.Winform.Roles_Fj
{

   
    public partial class frmRo_Empleado_x_Turno_Consu : Form
    {  
        
        
        #region clases
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<ro_planificacion_x_jornada_desfasada_Info> lista = new List<ro_planificacion_x_jornada_desfasada_Info>();
        ro_planificacion_x_jornada_desfasada_Bus bus_planificacion = new ro_planificacion_x_jornada_desfasada_Bus();
        ro_planificacion_x_jornada_desfasada_Info info ;

        frmRo_Empleado_x_Turno_Mant frm;
        #endregion

        public frmRo_Empleado_x_Turno_Consu()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
               
                frm = new frmRo_Empleado_x_Turno_Mant();
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

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (info.Esta_Proceso == "CERRADO")
                {
                    MessageBox.Show("No se puede modificar una planificación cerrada", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                frm = new frmRo_Empleado_x_Turno_Mant();
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

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
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
                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                frm = new frmRo_Empleado_x_Turno_Mant();
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

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (info.Esta_Proceso == "CERRADO")
                {
                    MessageBox.Show("No se puede anular una planificación cerrada", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                frm = new frmRo_Empleado_x_Turno_Mant();
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

        private void gridView_Planificacion_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                info = new ro_planificacion_x_jornada_desfasada_Info();
                info = (ro_planificacion_x_jornada_desfasada_Info)gridView_Planificacion.GetFocusedRow();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRo_Empleado_x_Turno_Consu_Load(object sender, EventArgs e)
        {
            try
            {

                Cargar_datos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        public void Cargar_datos()
        {
            try
            {
               lista=  bus_planificacion.Listado_planificacion_x_periodo(param.IdEmpresa, ucGe_Menu.fecha_desde, ucGe_Menu.fecha_hasta);
               gridControl_Planificacion.DataSource = lista;
            }
            catch (Exception ex)
            {
                
                  MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {
            Cargar_datos();
        }
    }
}
