using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;

//version 16:37 v1 13/09
namespace Core.Erp.Business.Produc_Cirdesus
{

    public class vwprd_UsuarioAutorizados_Cidersus_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        vwprd_UsuarioAutorizados_Cidersus_Data data = new vwprd_UsuarioAutorizados_Cidersus_Data();

        public vwprd_UsuarioAutorizados_Cidersus_Info TraerUsuarioAutorizado(string IdLogin, string contrasena)
        {
            try
            {
                return data.TraerUsuarioAutorizado (IdLogin, contrasena);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraerUsuarioAutorizado", ex.Message), ex) { EntityType = typeof(vwprd_UsuarioAutorizados_Cidersus_Bus) };
              
            }

        }
    }
}
