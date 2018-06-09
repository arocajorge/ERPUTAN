using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Cus.Erp.Reports.Naturisa.Inventario
{
    public class XINV_NAT_Rpt001_Bus
    {
        XINV_NAT_Rpt001_Data Ocdata = new XINV_NAT_Rpt001_Data();
        public List<XINV_NAT_Rpt001_Info> consultar_data(int IdEmpresa, decimal IdGuia, ref String mensaje)
        {
            try
            {
                return Ocdata.consultar_data(IdEmpresa, IdGuia, ref mensaje);

           }
            catch (Exception ex)
            {
                return new List<XINV_NAT_Rpt001_Info>(); 
            }
        }
        public XINV_NAT_Rpt001_Bus()
        {

        }
    }
}
