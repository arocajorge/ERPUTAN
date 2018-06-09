using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.Produccion_Talme;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produccion_Talme
{
    public class prod_Clave_Autorizacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prod_Clave_Autorizacion_Data data = new prod_Clave_Autorizacion_Data();

        public Boolean GuardarDB(List<prod_Clave_Autorizacion_Info> Lst, int IdEmpresa)
        {
            try
            {
             return data.GuardarDB(Lst, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prod_Clave_Autorizacion_Bus) };

            }

        }


        public Boolean ValidarClave(int IdEmpresa, string Clave, int IdModeloProduccion)
        {
            try
            {
                 return data.ValidarClave(IdEmpresa, Clave, IdModeloProduccion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarClave", ex.Message), ex) { EntityType = typeof(prod_Clave_Autorizacion_Bus) };

            }

        }
    }
}
