using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    class XINV_Rpt025_Bus
    {
        XINV_Rpt025_Data data = new XINV_Rpt025_Data();

        public List<XINV_Rpt025_Info> Get_list_reporte(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdProducto, DateTime fecha_ini, DateTime fecha_fin, string signo)
        {
            try
            {
               return data.Get_list_reporte(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdProducto,fecha_ini,fecha_fin,signo);
            }
            catch (Exception)
            {
                return new List<XINV_Rpt025_Info>();
            }
        }
    }
}
