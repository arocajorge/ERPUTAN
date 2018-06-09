using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt006_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        static string result = Path.GetTempPath();
        String RootReporte = result + @"ComprobanteSolo.repx";

        ba_Banco_Cuenta_Bus cuenta_b = new ba_Banco_Cuenta_Bus();
        XBAN_Rpt005_Bus bus = new XBAN_Rpt005_Bus();
        ba_Banco_Cuenta_Info cuenta_i = new ba_Banco_Cuenta_Info();

        public XBAN_Rpt006_frm(ba_Banco_Cuenta_Info Info)
        {
            InitializeComponent();
            cuenta_i = Info;

            if(Info.ReporteSolo_Cheque!=null)
            File.WriteAllBytes(RootReporte, Info.ReporteSolo_Cheque);

            commandBarItem31.PerformClick();

            XBAN_Rpt006_rpt reportes = new XBAN_Rpt006_rpt();
            if(Info.ReporteSolo_Cheque != null)
                reportes.LoadLayout(RootReporte);

            xrDesignDockManager1.XRDesignPanel.OpenReport(reportes);

        }

        public XBAN_Rpt006_frm()
        {
                
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string reportruta = result + "savesolocheque.repx";
                xrDesignDockManager1.XRDesignPanel.SaveReport(reportruta);
                Byte[] data;
                using (System.IO.FileStream FL = new System.IO.FileStream(reportruta, System.IO.FileMode.Open))
                {

                    using (MemoryStream ms = new MemoryStream())
                    {
                        FL.CopyTo(ms);
                        data = ms.ToArray();
                    }
                }

                cuenta_i.ReporteSolo_Cheque = data;
                cuenta_b.ModificarDB(cuenta_i);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
