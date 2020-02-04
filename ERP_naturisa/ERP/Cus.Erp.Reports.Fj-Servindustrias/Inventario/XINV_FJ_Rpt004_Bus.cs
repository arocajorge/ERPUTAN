
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public class XINV_FJ_Rpt004_Bus
    {
        XINV_FJ_Rpt004_Data dataRpt = new XINV_FJ_Rpt004_Data();

        public List<XINV_FJ_Rpt004_Info> get_Kardex_Detallado(int IdEmpresa, int IdBodegaIni, int IdBodegaFin, int IdSucursalIni, int IdSucursalFin, decimal IdProductoIni,
            decimal IdProductoFin, string idCentro_costo, string idSubCentro_costo, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return dataRpt.get_Kardex_Detallado(IdEmpresa, IdBodegaIni, IdBodegaFin, IdSucursalIni, IdSucursalFin, IdProductoIni, IdProductoFin,idCentro_costo,idSubCentro_costo, FechaIni, FechaFin);
            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_Kardex_Detallado", ex.Message), ex) { EntityType = typeof(XINV_FJ_Rpt004_Bus) };
            }
        }


        public XINV_FJ_Rpt004_Bus()
        {

        }
    }
}
