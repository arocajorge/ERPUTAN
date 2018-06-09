using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt018_Bus
    {
        XINV_Rpt018_Data oData = new XINV_Rpt018_Data();

        public List<XINV_Rpt018_Info> Get_List(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, int IdProductoIni, int IdProductoFin, DateTime FechaIni, DateTime FechaFin, int dias_stock, Boolean Mostrar_reg_en_cero, ref string Mensaje)
        {
            try
            {
                return oData.Get_List(IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, IdProductoIni, IdProductoFin, FechaIni, FechaFin, dias_stock, Mostrar_reg_en_cero, ref Mensaje);
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt018_Info>();
            }
        }
    }
}
