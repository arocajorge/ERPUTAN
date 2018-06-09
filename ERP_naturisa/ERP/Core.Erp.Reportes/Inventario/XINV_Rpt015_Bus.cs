using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt015_Bus
    {
        XINV_Rpt015_Data dataRpt = new XINV_Rpt015_Data();

        public List<XINV_Rpt015_Info> consultar_data(int IdEmpresa, int IdSucursal, List<int> lst_bodega, decimal IdProducto, string IdCentroCosto, List<string> lst_subcentro, DateTime Fecha_ini, DateTime Fecha_fin, bool Mostrar_anuladas)
        {
            try
            {
                return dataRpt.consultar_data(IdEmpresa, IdSucursal, lst_bodega, IdProducto, IdCentroCosto, lst_subcentro,Fecha_ini,Fecha_fin, Mostrar_anuladas);
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt015_Info>();
            }
        }
        public XINV_Rpt015_Bus()
        {
        }
    }
}
