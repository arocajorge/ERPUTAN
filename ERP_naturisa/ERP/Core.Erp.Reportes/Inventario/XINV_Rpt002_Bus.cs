using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt002_Bus
    {
        XINV_Rpt002_Data Data = new XINV_Rpt002_Data();
        public List<XINV_Rpt002_Info> consultar_data(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi, ref string mensaje)
        {
            try
            {
                return Data.consultar_data(IdEmpresa,IdSucursal, IdBodega,  IdMovi_inven_tipo, IdNumMovi, ref  mensaje);
            }
            catch (Exception ex)
            {
              return new List<XINV_Rpt002_Info>();
            }

        }
        public XINV_Rpt002_Bus()
        {
        }
  }
}

