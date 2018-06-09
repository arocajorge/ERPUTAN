using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt023_Bus
    {
        XINV_Rpt023_Data oData = new XINV_Rpt023_Data();

        public List<XINV_Rpt023_Info> Get_Lista_Reporte(int idEmpresa, decimal idDev_Inven)
        {
            try
            {
                return oData.Get_Lista_Reporte(idEmpresa, idDev_Inven);
            }
            catch (Exception)
            {
                
                throw;
            }
                    
        }
    }
}
