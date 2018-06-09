using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Winform.Roles_Fj;
using Core.Erp.Info.General;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Remplazo_x_Empleado_Consul : Form
    {
        public frmRo_Remplazo_x_Empleado_Consul()
        {
            InitializeComponent();
        }
        public Core.Erp.Info.Roles_Fj.ro_Remplazo_x_emplado_Info info = new Info.Roles_Fj.ro_Remplazo_x_emplado_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
       List< Core.Erp.Info.Roles_Fj.ro_Remplazo_x_emplado_Info> lista = new List<Info.Roles_Fj.ro_Remplazo_x_emplado_Info>();
       Core.Erp.Business.Roles_Fj.ro_Remplazo_x_emplado_Bus bus_remplazos = new Core.Erp.Business.Roles_Fj.ro_Remplazo_x_emplado_Bus();

        private void gridView_remplado_x_empleado_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info.IdEmpleado == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                frmRo_Remplazo_x_Empleado_Mant frm = new frmRo_Remplazo_x_Empleado_Mant();
                frm.MdiParent = this.MdiParent;
                frm.Accion = Cl_Enumeradores.eTipo_action.grabar;
                frm.Cargar_datos();
                frm.Show();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());

            }
        }

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                 if (info.IdEmpleado == null)
            {
                MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmRo_Remplazo_x_Empleado_Mant frm = new frmRo_Remplazo_x_Empleado_Mant();
            frm.MdiParent = this.MdiParent;
            frm.Accion = Cl_Enumeradores.eTipo_action.actualizar;
            frm.Cargar_datos();
            frm.Set(info);
            frm.Show();
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                 if (info.IdEmpleado == null)
            {
                MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmRo_Remplazo_x_Empleado_Mant frm = new frmRo_Remplazo_x_Empleado_Mant();
            frm.MdiParent = this.MdiParent;
            frm.Accion = Cl_Enumeradores.eTipo_action.Anular;
            frm.Cargar_datos();
            frm.Set(info);
            frm.Show();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
             if (info.IdEmpleado == null)
            {
                MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmRo_Remplazo_x_Empleado_Mant frm = new frmRo_Remplazo_x_Empleado_Mant();
            frm.MdiParent = this.MdiParent;
            frm.Accion = Cl_Enumeradores.eTipo_action.consultar;
            frm.Cargar_datos();
            frm.Set(info);
            frm.Show();
             
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        private void frmRo_Remplazo_x_Empleado_Consul_Load(object sender, EventArgs e)
        {
            try
            {
                buscar_datos();
                ucGe_Menu.fecha_desde.AddMonths(-1);
                ucGe_Menu.fecha_hasta = DateTime.Now;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        public void buscar_datos()
        {
            try
            {
                lista = bus_remplazos.listado_remplazo(param.IdEmpresa,ucGe_Menu.fecha_desde,ucGe_Menu. fecha_hasta);
                gridControl_remplazo_x_empleado.DataSource = lista;
            }
            catch (Exception ex )
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                buscar_datos();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        private void gridView_remplado_x_empleado_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                info = new Info.Roles_Fj.ro_Remplazo_x_emplado_Info();
                info = (Info.Roles_Fj.ro_Remplazo_x_emplado_Info)gridView_remplado_x_empleado.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());

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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());

            }
        }

        private void gridView_remplado_x_empleado_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                  var data = gridView_remplado_x_empleado.GetRow(e.RowHandle) as Core.Erp.Info.Roles_Fj.ro_Remplazo_x_emplado_Info;
                if (data == null)
                    return;

                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }
       
    }
}
