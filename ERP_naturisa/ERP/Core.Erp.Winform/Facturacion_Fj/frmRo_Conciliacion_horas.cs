using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Conciliacion_horas : Form
    {
        List<fa_registro_unidades_x_equipo_det_Info> lista = new List<fa_registro_unidades_x_equipo_det_Info>();
        fa_registro_unidades_x_equipo_det_Bus bus_detalle = new fa_registro_unidades_x_equipo_det_Bus();
        ct_Periodo_Bus bus_perido = new ct_Periodo_Bus();
        List<ct_Periodo_Info> lista_periodo = new List<ct_Periodo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        Af_Activo_fijo_Bus bus_Activo_foijo = new Af_Activo_fijo_Bus();
        List<Af_Activo_fijo_Info> lista_activo_fijo = new List<Af_Activo_fijo_Info>();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string msg = "";
        public frmRo_Conciliacion_horas()
        {
            InitializeComponent();
        }

        private void frmRo_Conciliacion_horas_Load(object sender, EventArgs e)
        {
            try
            {

                lista_periodo = bus_perido.Get_List_Periodo(param.IdEmpresa, ref msg);
                cmb_periodo.Properties.DataSource = lista_periodo;

                lista_activo_fijo = bus_Activo_foijo.Get_List_ActivoFijo(param.IdEmpresa);
                cmb_AF.Properties.DataSource = lista_activo_fijo;

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_AF.EditValue == null)
                {
                    lista = bus_detalle.Get_List_Conciliacion_Horas(param.IdEmpresa);
                    gc_Conciliacion_horas.DataSource = lista;
                }
                if (cmb_AF.EditValue != null)
                {
                    lista = bus_detalle.Get_List_Conciliacion_Horas(param.IdEmpresa,Convert.ToInt32( cmb_AF.EditValue));
                    gc_Conciliacion_horas.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
          
            }
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                gw_Conciliacion_horas.ShowPrintPreview();

            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
          
            }
        }
    }
}
