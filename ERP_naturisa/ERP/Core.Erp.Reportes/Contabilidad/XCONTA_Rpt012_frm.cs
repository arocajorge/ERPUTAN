using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;




namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt012_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";

        public XCONTA_Rpt012_frm()
        {
            InitializeComponent();
        }

        private void XCONTA_Rpt012_frm_Load(object sender, EventArgs e)
        {
            cmb_Estado.SelectedItem = "ESTADO DE RESULTADO";
            cargar_combos();
        }

        private void cargar_combos()
        {
            try
            {
                
                ct_Periodo_Bus BusPeriodo = new ct_Periodo_Bus();
                List<ct_Periodo_Info> ListPeriodo = new List<ct_Periodo_Info>();
                int anio_actual = DateTime.Now.Year;


                ListPeriodo =BusPeriodo.Get_List_Periodo(param.IdEmpresa, ref MensajeError);

                foreach (var itemPeriodo in ListPeriodo)
                {
                    if (anio_actual == itemPeriodo.IdanioFiscal)
                    { chkList_Periodos.Items.Add(itemPeriodo, itemPeriodo.nom_periodo, CheckState.Checked, true); }
                    else
                    { chkList_Periodos.Items.Add(itemPeriodo, itemPeriodo.nom_periodo, CheckState.Unchecked, true); }

                }
                ct_Plancta_nivel_Bus BusNivel = new ct_Plancta_nivel_Bus();
                List<ct_Plancta_nivel_Info> listNivel = new List<ct_Plancta_nivel_Info>();
                listNivel = BusNivel.Get_list_Plancta_nivel(param.IdEmpresa);
                cmb_nivel.DataSource = listNivel;

                cmb_nivel.DisplayMember = "IdNivelCta";
                cmb_nivel.ValueMember = "IdNivelCta";
                cmb_nivel.SelectedValue = 5;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Estado.SelectedItem=="ESTADO DE RESULTADO")
                {
                    Llamar_rpt_estado_resultado();
                }
                else
                    Llamar_rpt_balance_general();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Llamar_rpt_balance_general()
        {
            try
            {

                splashScreenManager.ShowWaitForm();
                XCONTA_Rpt012_Rpt Reporte = new XCONTA_Rpt012_Rpt();
                int IdEmpresa = 0;
                int IdNivel_a_mostrar = 0;
                List<ct_Periodo_Info> ListInfo_Periodo = new List<ct_Periodo_Info>();
                IdEmpresa = param.IdEmpresa;


                foreach (ct_Periodo_Info item in chkList_Periodos.Items.GetCheckedValues())
                {
                    ct_Periodo_Info InfoP = new ct_Periodo_Info();
                    InfoP = item;
                    ListInfo_Periodo.Add(InfoP);
                }
                ListInfo_Periodo = ListInfo_Periodo.OrderBy(q => q.IdPeriodo).ToList();
                IdNivel_a_mostrar = (int)cmb_nivel.SelectedValue;
                Reporte.PIdEmpresa.Value = IdEmpresa;
                Reporte.PIdNivel_a_mostrar.Value = IdNivel_a_mostrar;
                Reporte.PMostrar_Reg_en_cero.Value = chkMostrar_Reg_Cero.Checked;

                Reporte.set_periodo(ListInfo_Periodo);

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.ShowPreview();
                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashScreenManager.CloseWaitForm();
            }
        }

        private void Llamar_rpt_estado_resultado()
        {
            try
            {
                
                splashScreenManager.ShowWaitForm();
                XCONTA_Rpt015_rpt Reporte = new XCONTA_Rpt015_rpt();
                int IdEmpresa = 0;
                int IdNivel_a_mostrar = 0;
                List<ct_Periodo_Info> ListInfo_Periodo = new List<ct_Periodo_Info>();
                IdEmpresa = param.IdEmpresa;


                foreach (ct_Periodo_Info item in chkList_Periodos.Items.GetCheckedValues())
                {
                    ct_Periodo_Info InfoP = new ct_Periodo_Info();
                    InfoP = item;
                    ListInfo_Periodo.Add(InfoP);
                }
                ListInfo_Periodo = ListInfo_Periodo.OrderBy(q => q.IdPeriodo).ToList();
                IdNivel_a_mostrar = (int)cmb_nivel.SelectedValue;
                Reporte.PIdEmpresa.Value = IdEmpresa;
                Reporte.PIdNivel_a_mostrar.Value = IdNivel_a_mostrar;
                Reporte.PMostrar_Reg_en_cero.Value = chkMostrar_Reg_Cero.Checked;
                Reporte.P_MostrarCC.Value = chkMostrarCC.Checked;
                Reporte.set_periodo(ListInfo_Periodo);

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.ShowPreview();
                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                splashScreenManager.CloseWaitForm();
               
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
