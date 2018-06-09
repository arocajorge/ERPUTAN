using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.Compras
{
   public class XCOMP_NATU_Rpt003_Bus
    {

       XCOMP_NATU_Rpt003_Data Ocdata = new XCOMP_NATU_Rpt003_Data();

       public List<XCOMP_NATU_Rpt003_Info> consultar_data(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, decimal IdProveedor, decimal IdProducto, DateTime Fecha_ini, DateTime Fecha_fin, bool Mostrar_anuladas)
       {
            try
            {
                return Ocdata.consultar_data(IdEmpresa, IdSucursal, IdOrdenCompra, IdProveedor, IdProducto, Fecha_ini, Fecha_fin, Mostrar_anuladas);
            }
            catch (Exception ex)
            {
                return new List<XCOMP_NATU_Rpt003_Info>();
            }

        }

        public XCOMP_NATU_Rpt003_Bus(){}
    }
}
