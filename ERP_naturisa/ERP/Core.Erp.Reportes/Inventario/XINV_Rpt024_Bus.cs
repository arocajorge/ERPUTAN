using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt024_Bus
    {
        XINV_Rpt024_Data oData = new XINV_Rpt024_Data();

        public List<XINV_Rpt024_Info> GetList_Data(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi, string Tipo, DateTime FechaIni, DateTime FechaFin, ref String mensaje)
        {
            try
            {
                return oData.GetList_Data(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdNumMovi, Tipo, FechaIni, FechaFin, ref mensaje);
            }
            catch (Exception)
            {
                return new List<XINV_Rpt024_Info>();
            }
        }
    }
}
