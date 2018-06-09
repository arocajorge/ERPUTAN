using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Roles
{
    public class ro_Config_SueldoBasico_x_anio_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_Config_SueldoBasico_x_anio_Data data = new ro_Config_SueldoBasico_x_anio_Data();
        public List<ro_Config_SueldoBasico_x_anio_Info> TraerDatos()
        {
            try
            {
                return data.TraerDatos();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraerDatos", ex.Message), ex) { EntityType = typeof(ro_Config_SueldoBasico_x_anio_Bus) };

            }
            


        }

        public Boolean Eliminar(int IdEmpresa)
        {
            try
            {
               return data.Eliminar(IdEmpresa );
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar", ex.Message), ex) { EntityType = typeof(ro_Config_SueldoBasico_x_anio_Bus) };

            }


        }

        public Boolean Grabar(List<ro_Config_SueldoBasico_x_anio_Info> ListaGrabar)
        {
            try
            {
                 return data.Grabar(ListaGrabar );
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Grabar", ex.Message), ex) { EntityType = typeof(ro_Config_SueldoBasico_x_anio_Bus) };

            }


        }
    }
}
