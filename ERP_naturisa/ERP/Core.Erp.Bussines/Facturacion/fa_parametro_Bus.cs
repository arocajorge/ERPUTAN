using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;

using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion


{ 
    public class fa_parametro_Bus
    {
        fa_parametro_Data pd = new fa_parametro_Data();

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public fa_parametro_info Get_Info_parametro(int idEmpresa)
        {
            try
            {     
                return pd.Get_Info_parametro(idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener", ex.Message), ex) { EntityType = typeof(fa_parametro_Bus) };
            }
        }

        public Boolean ModificarDB(fa_parametro_info Info, ref string mensaje)
        {
            try
            {
                return pd.ModificarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(fa_parametro_Bus) };
            
            }
            
           
        }

        public fa_parametro_Bus() { }
    }
}
