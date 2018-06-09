using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt001_Bus
    {
        XINV_Rpt001_Data Data = new XINV_Rpt001_Data();
        public List<XINV_Rpt001_Info> consultar_data(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi, ref string mensaje)
        {
            try
            {
                return Data.consultar_data(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdNumMovi,  ref mensaje);
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt001_Info>();
            }
        }
        public XINV_Rpt001_Bus()
        {

        }

    }
}
