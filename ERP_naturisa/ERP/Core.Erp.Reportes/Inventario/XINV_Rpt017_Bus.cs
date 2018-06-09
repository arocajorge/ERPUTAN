using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt017_Bus
    {
        XINV_Rpt017_Data data = new XINV_Rpt017_Data();

        public List<XINV_Rpt017_Info> Get_List(int IdEmpresa, int IdSucursal_origen, int IdBodega_origen, decimal IdTransferencia, ref string msg)
        {
            try
            {
                return data.Get_List(IdEmpresa,IdSucursal_origen,IdBodega_origen, IdTransferencia, ref msg);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
