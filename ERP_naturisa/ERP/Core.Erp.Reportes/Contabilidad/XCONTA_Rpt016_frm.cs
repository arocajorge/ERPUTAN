using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt016_frm : Form
    {
        int anio_actual = DateTime.Now.Year;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<ct_Periodo_Info> ListInfo_Periodo = new List<ct_Periodo_Info>();
        string MensajeError = "";
        public XCONTA_Rpt016_frm()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Get_periodos();
                switch (cmb_Estado.SelectedItem.ToString())
                {
                        
                    case "CUENTAS DE RESULTADO POR TIPO DE GASTO":
                        Imprimir_cuentas_x_tipo_gasto();
                        break;
                    case "CUENTAS DE INGRESO":
                        Llamar_rpt_estado_resultado("INGRESOS                                          ");
                        break;
                    case "CUENTAS DE MATERIA PRIMA":
                        Llamar_rpt_estado_resultado("COSTOS DE PRODUCCION                              ");
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void XCONTA_Rpt016_frm_Load(object sender, EventArgs e)
        {
            try
            {
                cmb_Estado.SelectedItem = "CUENTAS DE RESULTADO POR TIPO DE GASTO";
                cargar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                ct_Periodo_Bus BusPeriodo = new ct_Periodo_Bus();
                List<ct_Periodo_Info> ListPeriodo = new List<ct_Periodo_Info>();
                int anio_actual = DateTime.Now.Year;

                ListPeriodo = BusPeriodo.Get_List_Periodo(param.IdEmpresa, ref MensajeError);

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
        private void cmb_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cmb_Estado.SelectedItem.ToString())
                {
                    case "CUENTAS DE RESULTADO POR TIPO DE GASTO":
                        lbl_nivel.Visible = false;
                        cmb_nivel.Visible = false;
                        chkMostrar_Reg_Cero.Visible = false;
                        break;
                    default:
                        lbl_nivel.Visible = true;
                        cmb_nivel.Visible = true;
                        chkMostrar_Reg_Cero.Visible = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Imprimir_cuentas_x_tipo_gasto()
        {
            try
            {
                XCONTA_Rpt016_rpt rpt = new XCONTA_Rpt016_rpt();
                rpt.p_Anio.Value = 2016;
                rpt.p_Anio.Visible = false;
                rpt.p_Mostrar_CC.Value = chkMostrarCC.Checked;
                rpt.p_Mostrar_CC.Visible = false;
                rpt.set_periodo(ListInfo_Periodo);
                rpt.ShowPreviewDialog();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Get_periodos()
        {
            try
            {
                ListInfo_Periodo = new List<ct_Periodo_Info>();
                foreach (ct_Periodo_Info item in chkList_Periodos.Items.GetCheckedValues())
                {
                    ct_Periodo_Info InfoP = new ct_Periodo_Info();
                    InfoP = item;
                    ListInfo_Periodo.Add(InfoP);
                }
                ListInfo_Periodo = ListInfo_Periodo.OrderBy(q => q.IdPeriodo).ToList();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Llamar_rpt_estado_resultado(string IdGrupoCble)
        {
            try
            {

                splashScreenManager.ShowWaitForm();
                XCONTA_Rpt017_rpt Reporte = new XCONTA_Rpt017_rpt();
                int IdEmpresa = 0;
                int IdNivel_a_mostrar = 0;
                IdEmpresa = param.IdEmpresa;
                Get_periodos();               
                ListInfo_Periodo = ListInfo_Periodo.OrderBy(q => q.IdPeriodo).ToList();
                IdNivel_a_mostrar = (int)cmb_nivel.SelectedValue;
                Reporte.PIdEmpresa.Value = IdEmpresa;
                Reporte.PIdNivel_a_mostrar.Value = IdNivel_a_mostrar;
                Reporte.PMostrar_Reg_en_cero.Value = chkMostrar_Reg_Cero.Checked;
                Reporte.P_MostrarCC.Value = chkMostrarCC.Checked;
                Reporte.P_GrupoCble.Value = IdGrupoCble;
                
                Reporte.PS_NOMBRE_REPORTE.Value = cmb_Estado.SelectedItem.ToString();                

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
    }
}
