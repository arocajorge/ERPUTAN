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
using Cus.Erp.Reports.FJ.Facturacion;
namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmFa_Conciliacion_horas_hombre_vs_Horas_Maquina : Form
    {
        List<fa_registro_unidades_x_equipo_det_Info> lista = new List<fa_registro_unidades_x_equipo_det_Info>();
        fa_registro_unidades_x_equipo_det_Bus bus_detalle = new fa_registro_unidades_x_equipo_det_Bus();
        ct_Periodo_Bus bus_perido = new ct_Periodo_Bus();
        List<ct_Periodo_Info> lista_periodo = new List<ct_Periodo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        Af_Activo_fijo_Bus bus_Activo_foijo = new Af_Activo_fijo_Bus();
        List<Af_Activo_fijo_Info> lista_activo_fijo = new List<Af_Activo_fijo_Info>();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ct_Periodo_Info info_periodo = new ct_Periodo_Info();
        string msg = "";

        public frmFa_Conciliacion_horas_hombre_vs_Horas_Maquina()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmFa_Conciliacion_horas_hombre_vs_Horas_Maquina_Load(object sender, EventArgs e)
        {
            try
            {

                lista_periodo = bus_perido.Get_List_Periodo(param.IdEmpresa, ref msg);
                cmb_periodo.Properties.DataSource = lista_periodo;

                lista_activo_fijo = bus_Activo_foijo.Get_List_ActivoFijo(param.IdEmpresa);
                cmb_AF.Properties.DataSource = lista_activo_fijo;
                chek_imprimir.Checked = true;

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (chek_imprimir.Checked)
                {
                    XFAC_FJ_Rpt005_Rpt reporte = new XFAC_FJ_Rpt005_Rpt();
                    reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                    reporte.Parameters["IdPeriodo"].Value = Convert.ToInt32(cmb_periodo.EditValue);
                    reporte.Parameters["Periodo"].Value = info_periodo.smes + " del " + info_periodo.IdanioFiscal;

                    reporte.ShowPreviewDialog();
                }
                else
                {
                    XFAC_FJ_Rpt011_Rpt reporte_resumido = new XFAC_FJ_Rpt011_Rpt();
                    reporte_resumido.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                    reporte_resumido.Parameters["IdPeriodo"].Value = Convert.ToInt32(cmb_periodo.EditValue);
                    reporte_resumido.Parameters["Periodo"].Value = info_periodo.smes + " del " + info_periodo.IdanioFiscal;

                    reporte_resumido.ShowPreviewDialog();
                }

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
                    lista = bus_detalle.Get_List_Conciliacion_Horas_hom_vs_ho_maq(param.IdEmpresa, Convert.ToInt32(cmb_periodo.EditValue));
                    gc_Conciliacion_horas.DataSource = lista;
                }
                if (cmb_AF.EditValue != null)
                {
                    lista = bus_detalle.Get_List_Conciliacion_Horas_hom_vs_ho_maq(param.IdEmpresa, Convert.ToInt32(cmb_periodo.EditValue), Convert.ToInt32(cmb_AF.EditValue));
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

        private void cmb_periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                info_periodo =(ct_Periodo_Info) cmb_periodo.Properties.View.GetFocusedRow();
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
