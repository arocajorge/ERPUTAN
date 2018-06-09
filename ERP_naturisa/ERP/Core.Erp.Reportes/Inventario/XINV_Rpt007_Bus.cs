using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt007_Bus
    {
        XINV_Rpt007_Data Data = new XINV_Rpt007_Data();

        public List<XINV_Rpt007_Info> Obtener_Data(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdAjustefisico)
        {
            return Data.Obtener_Data(IdEmpresa, IdSucursal, IdBodega, IdAjustefisico);
        }
    }
}
