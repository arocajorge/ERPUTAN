using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.ERP.Reports.Grafinpren.Facturacion
{
    public class XFAC_GRAF_Rpt001_Bus
    {

      public List<XFAC_GRAF_Rpt001_Info> Lista_Guias(int idempresa, int idsucursal, int idbodega, decimal idGuiaRemision, ref string mensaje)
      {
          try
          {

              XFAC_GRAF_Rpt001_Data Odata = new XFAC_GRAF_Rpt001_Data();
              return Odata.Lista_Guias(idempresa, idsucursal, idbodega, idGuiaRemision, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Lista_Guias", ex.Message), ex) { EntityType = typeof(XFAC_GRAF_Rpt001_Bus) };
          }
      }
    }
}
