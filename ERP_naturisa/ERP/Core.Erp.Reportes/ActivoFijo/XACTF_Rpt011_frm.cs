using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Reportes.ActivoFijo
{
           
    public partial class XACTF_Rpt011_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string periodo_nombre = "", periodo_inicio = "", periodo_fin = "";
        
        public XACTF_Rpt011_frm()
        {
            InitializeComponent();
        }

        private void XACTF_Rpt011_frm_Load(object sender, EventArgs e)
        {
            try
            {
                //cargar combo
                string MensajeError = "";
                
                ct_Periodo_Bus bus_Periodo = new ct_Periodo_Bus();
                List<ct_Periodo_Info> lista = new List<ct_Periodo_Info>();

                lista = bus_Periodo.Get_List_Periodo(param.IdEmpresa, ref MensajeError);

                cmb_Periodo.Properties.DataSource = lista;
                cmb_Periodo.Properties.DisplayMember = "nom_periodo";
                cmb_Periodo.Properties.ValueMember = "IdPeriodo";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                 XACTF_Rpt011_rpt Reporte = new XACTF_Rpt011_rpt();
                Reporte.RequestParameters = false;

                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;


                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdPeriodo"].Value = (cmb_Periodo.EditValue == null) ? 0 : cmb_Periodo.EditValue;
                Reporte.Parameters["Periodo_Nombre"].Value = periodo_nombre;
                Reporte.Parameters["Periodo_Inicio"].Value = periodo_inicio;
                Reporte.Parameters["Periodo_Fin"].Value = periodo_fin;
                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ct_Periodo_Info info = (ct_Periodo_Info)cmb_Periodo.Properties.View.GetFocusedRow();

                periodo_nombre = info.nom_periodo;
                periodo_inicio = Convert.ToString(info.pe_FechaIni);
                periodo_fin = Convert.ToString(info.pe_FechaFin);
                //periodo = info.pe_FechaIni + "-" + info.pe_FechaFin;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printPreviewBarItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
