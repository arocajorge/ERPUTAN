using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt005_Bus
    {
        XINV_Rpt005_Data data = new XINV_Rpt005_Data();
        public List<XINV_Rpt005_Info> Consultar_Data(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNumMovi, int IdMoviInvenTipo)
        {
            return data.Consultar_Data(IdEmpresa, IdSucursal, IdBodega, IdNumMovi, IdMoviInvenTipo);
        }
    }
}
