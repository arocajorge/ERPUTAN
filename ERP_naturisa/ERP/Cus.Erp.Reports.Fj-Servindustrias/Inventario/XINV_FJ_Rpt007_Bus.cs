using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public class XINV_FJ_Rpt007_Bus
    {
        XINV_FJ_Rpt007_Data Data = new XINV_FJ_Rpt007_Data();
        public List<XINV_FJ_Rpt007_Info> consultar_data(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi, ref string mensaje)
        {
            try
            {
                return Data.consultar_data(IdEmpresa,IdSucursal, IdBodega,  IdMovi_inven_tipo, IdNumMovi, ref  mensaje);
            }
            catch (Exception ex)
            {
                return new List<XINV_FJ_Rpt007_Info>();
            }

        }
        public XINV_FJ_Rpt007_Bus()
        {
        }
  }
}

