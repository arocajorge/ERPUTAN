using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public class XINV_FJ_Rpt005_Bus
    {
        XINV_FJ_Rpt005_Data dataRpt = new XINV_FJ_Rpt005_Data();

        public List<XINV_FJ_Rpt005_Info> get_Kardex_Resumido(int IdEmpresa, int IdBodegaIni, int IdBodegaFin, int IdSucursalIni, int IdSucursalFin, decimal IdProductoIni, decimal IdProductoFin,string IdCentro_costo, string IdSubCentro_costo, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return dataRpt.get_Kardex_Resumido(IdEmpresa, IdBodegaIni, IdBodegaFin, IdSucursalIni, IdSucursalFin, IdProductoIni, IdProductoFin,IdCentro_costo,IdSubCentro_costo, FechaIni, FechaFin);
            }
            catch (Exception)
            {
                return new List<XINV_FJ_Rpt005_Info>();
            }
        }


        public XINV_FJ_Rpt005_Bus()
        {

        }
    }
}
