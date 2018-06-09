using Core.Erp.Data.Caja;
using Core.Erp.Info.Caja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Caja
{
    public class caj_catalogo_Bus
    {
        caj_catalogo_Data data = new caj_catalogo_Data();
        public List<caj_catalogo_Info> Lista_catalogo()
        {
            try
            {
                return data.Lista_catalogo();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Lista_Catalogo", ex.Message), ex) { EntityType = typeof(caj_catalogo_Bus) };
            }
        }
    }
}
