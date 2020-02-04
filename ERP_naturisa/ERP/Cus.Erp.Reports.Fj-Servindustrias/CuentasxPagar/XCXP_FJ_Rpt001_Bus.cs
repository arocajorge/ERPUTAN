using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.CuentasxPagar
{
    public class XCXP_FJ_Rpt001_Bus
    {
        XCXP_FJ_Rpt001_Data oData = new XCXP_FJ_Rpt001_Data();

        public List<XCXP_FJ_Rpt001_Info> Get_Lista_Reporte(int idEmpresa, decimal idTransferencia, decimal idGuia, int idSucursalOrigen, int idSucursalFin, int idBodegaOrigen, int idBodegaFin)
        {
            try
            {
                return oData.Get_Lista_Reporte(idEmpresa, idTransferencia, idGuia, idSucursalOrigen, idSucursalFin, idBodegaOrigen, idBodegaFin);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
