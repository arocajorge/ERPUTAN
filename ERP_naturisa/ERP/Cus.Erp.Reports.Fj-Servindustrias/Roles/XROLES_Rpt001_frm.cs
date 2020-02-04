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
namespace Cus.Erp.Reports.FJ.Roles
{
    public partial class XROLES_Rpt001_frm : Form
    {
        public XROLES_Rpt001_frm()
        {
            InitializeComponent();
        }


        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        XROLES_Rpt001_Bus Bus_horas_Extras_Detallada = new XROLES_Rpt001_Bus();
        List<XROLES_Rpt001_Info> lista_HE_detalladas = new List<XROLES_Rpt001_Info>();


        XROLES_Rpt003_Bus Bus_horas_Extras_Resumidas = new XROLES_Rpt003_Bus();
        List<XROLES_Rpt003_Info> lista_HE_Resumidas = new List<XROLES_Rpt003_Info>();

        XROLES_Rpt004_Bus Bus_horas_Extras_global = new XROLES_Rpt004_Bus();
        List<XROLES_Rpt004_Info> lista_HE_global = new List<XROLES_Rpt004_Info>();

        private void XROLES_Rpt001_frm_Load(object sender, EventArgs e)
        {
            try
            { 
                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;
               

            }
            catch (Exception ex)
            {
                
                               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;

            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listadoPeriodo = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
                cmbPeriodos.Properties.DataSource = listadoPeriodo.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbPeriodos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                // llamo a las horas extras detallada
                lista_HE_detalladas = Bus_horas_Extras_Detallada.Get_list_Horas_Extras(param.IdEmpresa,Convert.ToInt32( cmbnomina.EditValue),Convert.ToInt32(cmbnominaTipo.EditValue),Convert.ToInt32( cmbPeriodos.EditValue));
                gridControlHoras_Extras.DataSource = lista_HE_detalladas;

                // llamo a las horas resumidas
                lista_HE_Resumidas = Bus_horas_Extras_Resumidas.Get_list_Horas_Extras(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue), Convert.ToInt32(cmbPeriodos.EditValue));
                gridControl_HE_Resumidas.DataSource = lista_HE_Resumidas;

                // lamo a las horas extras globalizadas
                lista_HE_global = Bus_horas_Extras_global.Get_list_Horas_Extras(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue), Convert.ToInt32(cmbPeriodos.EditValue));
                gridControl_HE_Globalizadas.DataSource = lista_HE_global;

            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        
        }

        private void gridControlHoras_Extras_Click(object sender, EventArgs e)
        {

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            { 
                if(check_detalle_HE.Checked==true)
                gridView_Horas_Extras.ShowPrintPreview();
                
                if (check_Resumen_HE.Checked == true)
                    gridView_HE_Resumidas.ShowPrintPreview();

                if (check_General.Checked == true)
                    gridView_HE_Globalizadas.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
