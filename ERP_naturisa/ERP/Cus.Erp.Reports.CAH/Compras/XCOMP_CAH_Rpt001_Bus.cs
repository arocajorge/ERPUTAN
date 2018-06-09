using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.CAH.Compras
{
    public class XCOMP_CAH_Rpt001_Bus
    {
        XCOMP_CAH_Rpt001_Data OCdata = new XCOMP_CAH_Rpt001_Data();

        public List<XCOMP_CAH_Rpt001_Info> consultar_data(int idempresa, int idsucursal, decimal IdOrdenCompra, ref string mensaje)
        {
            try
            {
                return OCdata.consultar_data(idempresa, idsucursal, IdOrdenCompra);
            }
            catch (Exception ex)
            {
                return new List<XCOMP_CAH_Rpt001_Info>();
            }
        }
    }
}
