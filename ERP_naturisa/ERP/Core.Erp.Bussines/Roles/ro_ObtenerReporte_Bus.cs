using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
  public  class ro_ObtenerReporte_Bus
    {
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      string mensaje = "";
     
      ro_ObtenerReporte_Data Data = new ro_ObtenerReporte_Data();

      
      public List<tbROL_Rpt002_Info> OptenerData_spROL_Rpt002(int IdEmpresa, decimal IdEmpleado, int IdPeriodo, int IdNomina_Tipo, int IdNomina_TipoLiqui,int IdDepartamento, string tipoConsulta,string IdUsuario, string nom_pc, int secuencia,string OrgCopy)
        {
            try
            {
                return Data.OptenerData_spROL_Rpt002(IdEmpresa, IdEmpleado, IdPeriodo, IdNomina_Tipo, IdNomina_TipoLiqui,IdDepartamento,tipoConsulta, IdUsuario, nom_pc, secuencia, OrgCopy);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OptenerData_spROL_Rpt002", ex.Message), ex) { EntityType = typeof(ro_ObtenerReporte_Bus) };
            }


        }

      // reporte prestamo
      public List<tbROL_Rpt003_Info> OptenerData_spROL_Rpt003(int IdEmpresa, decimal IdPrestamo, int IdNomina_Tipo, string IdRubro, decimal IdEmpleado,
        string IdUsuario, string nom_pc)
          {
          try
          {
              return Data.OptenerData_spROL_Rpt003(IdEmpresa, IdPrestamo, IdNomina_Tipo, IdRubro, IdEmpleado, IdUsuario, nom_pc);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OptenerData_spROL_Rpt003", ex.Message), ex) { EntityType = typeof(ro_ObtenerReporte_Bus) };
          }
      
      }

      //reporte nomina general
      public List<tbROL_NominaGeneral_Info> OptenerData_spROL_NominaGeneral(int IdEmpresa, int Idperiodo, int IdNomina_Tipo, int IdNomina_TipoLiqui,
         int IdDivisionIni, int IdDivisionFin, decimal IdEmpleadoIni, decimal IdEmpleadoFin, string IdUsuario, string nom_pc)
      {
          try
          {
              return Data.OptenerData_spROL_NominaGeneral(IdEmpresa, Idperiodo, IdNomina_Tipo, IdNomina_TipoLiqui, IdDivisionIni, IdDivisionFin, IdEmpleadoIni, IdEmpleadoFin, IdUsuario, nom_pc);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OptenerData_spROL_NominaGeneral", ex.Message), ex) { EntityType = typeof(ro_ObtenerReporte_Bus) };
          }
             
      }
    }
}
