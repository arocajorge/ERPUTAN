using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Business.General
{
    public class vwtb_Ubicacion_Geografica_Bus
    {
        vwtb_Ubicacion_Geografica_Data data_Ubi = new vwtb_Ubicacion_Geografica_Data();

        public List<vwtb_Ubicacion_Geografica_Info> Get_List_Ubicacion_Geo()
        {
            try
            {
                return data_Ubi.Get_List_Ubicacion_Geo();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_Lst_UbicacionGeo", ex.Message), ex) { EntityType = typeof(vwtb_Ubicacion_Geografica_Bus) };
           
            }
        }


        public vwtb_Ubicacion_Geografica_Bus()
        {

        }
    }
}
