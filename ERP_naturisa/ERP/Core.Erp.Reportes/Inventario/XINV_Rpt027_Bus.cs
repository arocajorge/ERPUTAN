using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt027_Bus
    {
        XINV_Rpt027_Data oData = new XINV_Rpt027_Data();
        public List<XINV_Rpt027_Info> Get_List(DateTime Fecha_desde, DateTime Fecha_hasta, int IdEmpresa, int IdSucursal, List<int> lst_bodega, decimal IdProducto, string idUsuario, bool No_mostrar_valores_en_0, bool Mostrar_detallado)
        {
            try
            {
                return oData.Get_List(Fecha_desde, Fecha_hasta, IdEmpresa, IdSucursal, lst_bodega, IdProducto, idUsuario, No_mostrar_valores_en_0, Mostrar_detallado);
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt027_Info>();
            }
        }
    }
}
