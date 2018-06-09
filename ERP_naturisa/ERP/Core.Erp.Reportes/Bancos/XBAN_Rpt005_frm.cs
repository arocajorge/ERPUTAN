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
using System.Xml;
using System.Xml.Serialization;

namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt005_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        String RootReporte = result + @"Comprobante de Egreso.repx";
        XBAN_Rpt005_Bus bus = new XBAN_Rpt005_Bus();
        static string result = Path.GetTempPath();
        ba_Banco_Cuenta_Bus cuenta_b = new ba_Banco_Cuenta_Bus();

       
        ba_Banco_Cuenta_Info cuenta_i = new ba_Banco_Cuenta_Info();
        
        public XBAN_Rpt005_frm(ba_Banco_Cuenta_Info Info)
        {
            InitializeComponent();
            try
            {
                cuenta_i = Info;
                if (Info.Reporte != null)
                    File.WriteAllBytes(RootReporte, Info.Reporte);
                commandBarItem31.PerformClick();
                Core.Erp.Reportes.Bancos.XBAN_Rpt005_rpt reportes = new XBAN_Rpt005_rpt();
                if (Info.Reporte != null)
                    reportes.LoadLayout(RootReporte);

                var xml = ChequeComprobante.XML;
                var serializer = new XmlSerializer(typeof(List<XBAN_Rpt005_Info>));
                List<XBAN_Rpt005_Info> lsi;
                using (var reader = new StringReader(xml))
                {
                    lsi = (List<XBAN_Rpt005_Info>)serializer.Deserialize(reader);
                }

                reportes.DataSource = lsi;
                xrDesignDockManager1.XRDesignPanel.OpenReport(reportes);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string reportruta = result + "save.repx";
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
                cuenta_i.Reporte = data;
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
