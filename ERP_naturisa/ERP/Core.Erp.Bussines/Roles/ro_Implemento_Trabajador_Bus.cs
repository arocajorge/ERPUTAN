using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Roles
{
    public class ro_Implemento_Trabajador_Bus
    {
        ro_Implemento_Trabajador_Data Data = new ro_Implemento_Trabajador_Data();

        public List<ro_Implemento_Trabajador_Info> Get_Lista_implementos(int idEmpresa)
        {
            try
            {
                return Data.Get_Lista_implementos(idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_implementos", ex.Message), ex) { EntityType = typeof(ro_Implemento_Trabajador_Bus) };

            }
        }

        public List<ro_Implemento_Trabajador_Info> Get_Lista_implementos_x_tipo(int idEmpresa, int idTipoImplemento)
        {
            try
            {
                return Data.Get_Lista_implementos_x_tipo(idEmpresa, idTipoImplemento);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_implementos_x_tipo", ex.Message), ex) { EntityType = typeof(ro_Implemento_Trabajador_Bus) };

            }
        }
    }
}
