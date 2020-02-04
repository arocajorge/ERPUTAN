using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public class XINV_FJ_Rpt006_Bus
    {
        XINV_FJ_Rpt006_Data data = new XINV_FJ_Rpt006_Data();

        public List<XINV_FJ_Rpt006_Info> Get_Kardes_Movimiento(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, decimal IdProductoIni, decimal IdProductoFin, string IdCentroCosto, string IdSubCentroCosto, int IdMov_inven_tipoIni, int IdMov_inven_tipoFin, string TipoMov, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return data.Get_Kardes_Movimiento(IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, IdProductoIni, IdProductoFin, IdCentroCosto, IdSubCentroCosto, IdMov_inven_tipoIni, IdMov_inven_tipoFin, TipoMov, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                return new List<XINV_FJ_Rpt006_Info>();
            }
        }
    }
}
