using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public class XCOMP_Rpt003_Bus
    {
        XCOMP_Rpt003_Data Ocdata = new XCOMP_Rpt003_Data();

        public List<XCOMP_Rpt003_Info> consultar_data(int idempresa, int idsucursal, int IdMovi_inven_tipo, decimal IdNumMovi,int IdBodega, ref String mensaje)
        {
            try
            {
                return Ocdata.consultar_data(idempresa, idsucursal, IdMovi_inven_tipo, IdNumMovi, IdBodega, ref mensaje);

            }
            catch (Exception)
            {
                return new List<XCOMP_Rpt003_Info>();
            }
        }

        public XCOMP_Rpt003_Bus()
        {
                
        }
        
    }
}

