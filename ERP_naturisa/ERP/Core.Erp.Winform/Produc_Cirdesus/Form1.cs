using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario_Cidersus;
using Core.Erp.Business.Inventario_Cidersus;
using Core.Erp.Reports.Produc_Cirdesus;



namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class Form1 : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public Form1()
        {
            try
            {
               InitializeComponent();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<tbPRD_Rpt_RPRD001_Info> listData = new List<tbPRD_Rpt_RPRD001_Info>();
                prd_ObtenerReporte_Bus Sp = new Business.Produc_Cirdesus.prd_ObtenerReporte_Bus();
                listData=Sp.OptenerData_spPRD_Rpt_RPRD001(6, 1, 1, 1, 1, "admin", "PC");

                XRpt_prd_ReimpresionCodigoBarra CRpt = new XRpt_prd_ReimpresionCodigoBarra();
                CRpt.loadData(listData.ToArray() );


                CReport.PrintingSystem = CRpt.PrintingSystem;
                CRpt.CreateDocument();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }

          

        }

       
        
      
    }
}
