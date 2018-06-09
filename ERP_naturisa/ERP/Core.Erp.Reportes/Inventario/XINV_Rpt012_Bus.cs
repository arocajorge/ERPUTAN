using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt012_Bus
    {
        XINV_Rpt012_Data dataRpt = new XINV_Rpt012_Data();

        public List<XINV_Rpt012_Info> get_List_MoviInveMatriz(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdProducto, string mv_tipo_movi, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return dataRpt.get_List_MoviInveMatriz(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdProducto, mv_tipo_movi, FechaIni, FechaFin);
            }
            catch (Exception)
            {
                return new List<XINV_Rpt012_Info>();
            }
        }

        public XINV_Rpt012_Bus()
        {

        }
    }
}
