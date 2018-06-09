using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
   public  class ro_contrato_bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       ro_contrato_data oData = new ro_contrato_data();


       //BUS
       ro_Empleado_Bus oRo_Empleado_Bus = new Roles.ro_Empleado_Bus();


      public List<ro_contrato_Info> ConsultaGeneral(int IdEmpresa)
        {
           try
           {
             return  oData.ConsultaGeneral(IdEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_contrato_bus) };

           
           }

       }

      public Boolean GrabarDB(ro_contrato_Info info, ref string mensaje)
      {
          try
          {
              Boolean valorDevolver=false;           
              decimal id=0;

              

              if (valorDevolver=oData.GrabarDB(info, ref mensaje))
              {
                  //ACTUALIZA FECHA DE ENTRADA EN LA FICHA DEL EMPLEADO, TOMA LOS VALORES SI EL CONTRATO ES VIGENTE
                  if (info.EstadoContrato == "ECT_ACT")
                  {
                      ro_Empleado_Info oRo_Empleado_Info = new ro_Empleado_Info();

                      oRo_Empleado_Info = oRo_Empleado_Bus.Get_Info_Empleado(info.IdEmpresa, info.IdEmpleado);
                      oRo_Empleado_Info.em_fechaIngaRol = info.FechaInicio;
                      oRo_Empleado_Info.em_fecha_Actual= info.FechaInicio;

                      valorDevolver = oRo_Empleado_Bus.ModificarDB(Convert.ToInt32( info.IdEmpresa),Convert.ToInt32( info.IdEmpleado), info.FechaInicio, info.FechaInicio);
                  }
              }

              return valorDevolver;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_contrato_bus) };

          }
      }

      public Boolean ModificarDB(ro_contrato_Info prI, ref string mensaje)
      {
          try
          {
             return oData.ModificarDB(prI, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_contrato_bus) };

          }
       }


      public Boolean CambiarEstadoContrado(int idempresa, int idempleado, int idcontrato)
      {
          try
          {
              return oData.CambiarEstadoContrado( idempresa,idempleado,idcontrato);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "CambiarEstadoContrado", ex.Message), ex) { EntityType = typeof(ro_contrato_bus) };

          }
      }


      public Boolean Get_SiExisteContratoActivo(int idEmpresa,int IdEmpleado)
      {
          try
          {
              return oData.Get_SiExisteContratoActivo(idEmpresa, IdEmpleado);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_SiExisteContratoActivo", ex.Message), ex) { EntityType = typeof(ro_contrato_bus) };

          }
      }

      public Boolean Anular(ro_contrato_Info info)
      {
          try
          {
              return oData.AnularDB(info);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(ro_contrato_bus) };

          }
      }

      public List<ro_contrato_Info> GetListPorEmpleado(int IdEmpresa, decimal IdEmpleado)
      {
          try
          {
              return oData.GetListPorEmpleado(IdEmpresa, IdEmpleado);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListPorEmpleado", ex.Message), ex) { EntityType = typeof(ro_contrato_bus) };


          }

      }

      public Boolean ActualizarContrato(ro_contrato_Info info)
      {
          try
          {
              return oData.ActualizarContrato(info);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarContrato", ex.Message), ex) { EntityType = typeof(ro_contrato_bus) };

          }
      }

      public ro_contrato_bus(){}

    }
}
