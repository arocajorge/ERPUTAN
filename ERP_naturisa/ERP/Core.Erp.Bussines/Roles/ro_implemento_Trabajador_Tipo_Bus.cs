using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Roles
{
    public class ro_implemento_Trabajador_Tipo_Bus
    {
        ro_implemento_Trabajador_Tipo_Data Data = new ro_implemento_Trabajador_Tipo_Data();

        public List<ro_implemento_Trabajador_Tipo_Info> Get_Lista_tipo_implemento(int idEmpresa)
        {
            try
            {
                return Data.Get_Lista_tipo_implemento(idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_tipo_implemento", ex.Message), ex) { EntityType = typeof(ro_implemento_Trabajador_Tipo_Bus) };

            }
        }
    }
}
