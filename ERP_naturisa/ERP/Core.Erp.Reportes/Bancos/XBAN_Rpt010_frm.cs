using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.General;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;



namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt010_frm : Form
    {
        ba_Banco_Cuenta_Bus BusCuenta = new ba_Banco_Cuenta_Bus();
        List<ba_Banco_Cuenta_Info> ListaBanco = new List<ba_Banco_Cuenta_Info>();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public XBAN_Rpt010_frm()
        {
            InitializeComponent();
        }

        private void btn_procesar_rpt_Click(object sender, EventArgs e)
        {
            try
            {
                int idBanco = 0;

                idBanco = Convert.ToInt32(cmb_banco.EditValue);

                XBAN_Rpt010_rpt Reporte = new XBAN_Rpt010_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["P_IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["P_IdBanco"].Value = idBanco;
                Reporte.Parameters["P_Fecha_desde"].Value = dtpFecha_desde.Value;
                Reporte.Parameters["P_Fecha_hasta"].Value = dtpFecha_hasta.Value;

                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void XBAN_Rpt010_frm_Load(object sender, EventArgs e)
        {
            try
            {
                
                ListaBanco= BusCuenta.Get_list_Banco_Cuenta(param.IdEmpresa);

                ListaBanco.Add(new ba_Banco_Cuenta_Info(param.IdEmpresa, 0, "TODOS","TODOS"));

                cmb_banco.Properties.DataSource = ListaBanco;
                cmb_banco.EditValue = 1;

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
