using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Business.Inventario
{
    public class in_Ing_Egr_Inven_estado_apro_Bus
    {
        in_Ing_Egr_Inven_estado_apro_Data dataBus = new in_Ing_Egr_Inven_estado_apro_Data();

        public List<in_Ing_Egr_Inven_estado_apro_Info> Get_List_Ing_Egr_Inven_estado_apro()
        {
            try
            {
                return dataBus.Get_List_Ing_Egr_Inven_estado_apro();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_List_EstadoApro_Ing_Egr", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_estado_apro_Bus) };

            }
        }

        public in_Ing_Egr_Inven_estado_apro_Bus()
        {

        }
    }
}
