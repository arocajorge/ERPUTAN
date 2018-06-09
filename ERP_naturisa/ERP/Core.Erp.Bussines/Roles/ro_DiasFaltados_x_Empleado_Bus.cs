using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Roles
{
   public class ro_DiasFaltados_x_Empleado_Bus
    {
     

        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_DiasFaltados_x_Empleado_Data Odata = new ro_DiasFaltados_x_Empleado_Data();
        #endregion

        public Boolean GuardarDB( ro_DiasFaltados_x_Empleado_Info Info)
        {
            try
            {
                return Odata.GuardarDB( Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_DiasFaltados_x_Empleado_Bus) };

            }


        }

        public List<ro_DiasFaltados_x_Empleado_Info> ConsultaGeneral(int IdEmpresa, DateTime FechaDesde, DateTime FechaHasta)
        {
            try
            {
                return Odata.ConsultaGeneral(IdEmpresa, FechaDesde,FechaHasta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_DiasFaltados_x_Empleado_Bus) };

            }

        }

        public Boolean ModificarDB(ro_DiasFaltados_x_Empleado_Info info)
        {
            try
            {
                return Odata.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_DiasFaltados_x_Empleado_Bus) };

            }


        }

        public Boolean Anular(ro_DiasFaltados_x_Empleado_Info info)
        {
            try
            {
                return Odata.Anular(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(ro_DiasFaltados_x_Empleado_Bus) };

            }


        }


        public int Get_Dias_Faltados_x_Periodo(int IdEmpresa, int IdEmpleado, DateTime FechaInic, DateTime FechaFin)
        {
            try
            {
                return Odata.Get_Dias_Faltados_x_Periodo(IdEmpresa, IdEmpleado, FechaInic, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_DiasFaltados_x_Empleado_Bus) };

            }

        }
    }
}
