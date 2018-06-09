using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt022_Bus
    {
        XINV_Rpt022_Data oData = new XINV_Rpt022_Data();

        public List<XINV_Rpt022_Info> Get_List(int IdEmpresa, decimal IdDev_Inven, ref string msg)
        {
            try
            {
                return oData.Get_List(IdEmpresa, IdDev_Inven, ref msg);
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt022_Info>();
            }
        }
    }
}
