using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.CAH.Colecturia
{
    public class XCOL_Rpt002_Bus
    {
        XCOL_Rpt002_Data OCdata = new XCOL_Rpt002_Data();

        public List<XCOL_Rpt002_Info> consultar_data(int IdSede)
        {
            try
            {
                return OCdata.consultar_data(IdSede);
            }
            catch (Exception ex)
            {
                return new List<XCOL_Rpt002_Info>();
            }
        }

    }
}
