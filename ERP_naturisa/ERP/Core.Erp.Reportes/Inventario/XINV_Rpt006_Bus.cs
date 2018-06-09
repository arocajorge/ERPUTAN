using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt006_Bus
    {
        XINV_Rpt006_Data Data = new XINV_Rpt006_Data();
        public List<XINV_Rpt006_Info> Obtener_Data(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNumMovi, int IdMoviInvenTipo)
        {
            return Data.Obtener_Data(IdEmpresa, IdSucursal, IdBodega, IdNumMovi, IdMoviInvenTipo);
        }
    }
}
