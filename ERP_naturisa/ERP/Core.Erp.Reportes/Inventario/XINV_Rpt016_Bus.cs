using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
     public class XINV_Rpt016_Bus
    {
         XINV_Rpt016_Data Odata = new XINV_Rpt016_Data();

         public List<XINV_Rpt016_Info> Get_List_Consumo_Detalle(int IdEmpresa, int IdSucursal,string IdCentroCosto,string IdSubCentroCosto,string IdPuntoCargo
            , decimal IdProductoIni, decimal IdProductoFin
            , DateTime FechaIni, DateTime FechaFin
            , string i_tipo_movi, ref string mensaje)
         {
             try
             {
                 return Odata.Get_List_Consumo_Detalle(IdEmpresa, IdSucursal, IdCentroCosto, IdSubCentroCosto, IdPuntoCargo,IdProductoIni, IdProductoFin, FechaIni, FechaFin, i_tipo_movi, ref mensaje);
             }
             catch (Exception ex)
             {
                 return new List<XINV_Rpt016_Info>();
             }
         }
    }
}
