using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    class XINV_Rpt026_Bus
    {
        XINV_Rpt026_Data oData = new XINV_Rpt026_Data();

        public List<XINV_Rpt026_Info> Get_list_reporte(int IdEmpresa, int IdSucursal, int IdBodega, string IdCategoria, int IdLinea, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return oData.Get_list_reporte(IdEmpresa, IdSucursal, IdBodega, IdCategoria, IdLinea, Fecha_ini, Fecha_fin);
            }
            catch (Exception)
            {
                return new List<XINV_Rpt026_Info>();
            }
        }
    }
}
