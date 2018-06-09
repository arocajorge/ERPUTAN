using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt004_Bus
    {
        XINV_Rpt004_Data Ingrdata = new XINV_Rpt004_Data();
        public List<XINV_Rpt004_Info> consultar_data(int IdEmpresa, int IdSucursal_inv_Ini, int IdSucursal_inv_Fin, decimal IdProductoIni, decimal IdProductoFin, decimal IdProveedorIni, decimal IdProveedorFin, DateTime Fecha_oc_Ini, DateTime Fecha_oc_Fin, ref String mensaje)
        {
            try
            {
                return Ingrdata.consultar_data(IdEmpresa, IdSucursal_inv_Ini, IdSucursal_inv_Fin, IdProductoIni, IdProductoFin,  IdProveedorIni, IdProveedorFin, Fecha_oc_Ini, Fecha_oc_Fin, ref mensaje);
            }
            catch (Exception ex)
            {

                return new List<XINV_Rpt004_Info>();
            }
        }
        public XINV_Rpt004_Bus()
        {
        }
    }
}
