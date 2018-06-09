using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Academico
{
   public class XACA_Rpt001_Bus
    {
       XACA_Rpt001_Data odata = new XACA_Rpt001_Data();

       public List<XACA_Rpt001_Info>Consultar_data(int IdEmpresa, int IdEstudiante, ref string mensaje)
       {
           return odata.Consultar_data(IdEmpresa, IdEstudiante,ref mensaje);

       }
    }
}
