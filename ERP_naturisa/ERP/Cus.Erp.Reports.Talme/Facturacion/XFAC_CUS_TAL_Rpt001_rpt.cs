using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;


namespace Cus.Erp.Reports.Talme.Facturacion
{
    public partial class XFAC_CUS_TAL_Rpt001_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XFAC_CUS_TAL_Rpt001_rpt()
        {
                InitializeComponent();
        }



       
        
        private void XFAC_CUS_TAL_Rpt001_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            try
            {

                XFAC_CUS_TAL_Rpt001_Bus repbus = new XFAC_CUS_TAL_Rpt001_Bus();
                List<XFAC_CUS_TAL_Rpt001_Info> listDataRpt = new List<XFAC_CUS_TAL_Rpt001_Info>();
                string mensaje = "";


                listDataRpt = repbus.Obtener_data(Convert.ToInt32(Parameters["IdEmpresa"].Value)
                    , Convert.ToInt32(Parameters["IdSucursal"].Value)
                   , Convert.ToInt32(Parameters["IdBodega"].Value)
                   , Convert.ToInt32(Parameters["IdPedido"].Value)
                   , ref mensaje);

                this.DataSource = listDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                
                
            }

            

        }

        private void xrLabel28_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

      
       

        

    }
}
