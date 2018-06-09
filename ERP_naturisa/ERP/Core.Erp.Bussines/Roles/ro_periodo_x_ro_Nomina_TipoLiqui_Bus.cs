/*CLASE: ro_periodo_x_ro_Nomina_TipoLiqui_Bus
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 04-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 *
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
  public  class ro_periodo_x_ro_Nomina_TipoLiqui_Bus
    {
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      string mensaje = "";
      ro_periodo_x_ro_Nomina_TipoLiqui_Data oData = new ro_periodo_x_ro_Nomina_TipoLiqui_Data();


      public List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ConsultaGeneralPerNomTipLiq(int IdEmpresa)
      {
          try
          {
              return oData.ConsultaGeneralPerNomTipLiq(IdEmpresa);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneralPerNomTipLiq", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }

      }

 // haac 13/01/2014
      public List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ConsultaPerNomTipLiq(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui)
      {
          try
          {
              return oData.ConsultaPerNomTipLiq(IdEmpresa, IdNomina_Tipo, IdNomina_TipoLiqui);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaPerNomTipLiq", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }

      } // haac 13/01/2014


      public List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ConsultaPerNomTipLiq_Asignado(int IdEmpresa, int IdNomina, int IdProceso)
      {
          try
          {
              return oData.ConsultaPerNomTipLiq_Asignado(IdEmpresa, IdNomina, IdProceso);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaPerNomTipLiq_Asignado", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }
      }

      public List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ConsultaPerNomTipLiq_Asignado_x_Empresa(int IdEmpresa)
      {
          try
          {
              return oData.ConsultaPerNomTipLiq_Asignado_x_Empresa(IdEmpresa);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaPerNomTipLiq_Asignado_x_Empresa", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }
      }


      // haac 15/01/2014
      public List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ConsultaPerNomTipLiq_x_Periodo(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo)
      {

          try
          {
              return oData.ConsultaPerNomTipLiq_x_Periodo(IdEmpresa, IdNomina_Tipo, IdNomina_TipoLiqui, IdPeriodo);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaPerNomTipLiq_x_Periodo", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }
           
      }// haac 15/01/2014


      public Boolean GuardarDB(ro_periodo_x_ro_Nomina_TipoLiqui_Info info)
      {
          try
          {
              Boolean valorRetornar = false;

              if (oData.GetExiste(info, ref mensaje))
              {
                  valorRetornar = oData.ModificarDB(info);
              }else{
                  valorRetornar = oData.GuardarDB(info);
              }
              return valorRetornar;

          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }
      }

      public Boolean ModificarDB(ro_periodo_x_ro_Nomina_TipoLiqui_Info info)
      {
          try
          {
              return oData.ModificarDB(info);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }

      }

      // haac 13/01/2014
      public Boolean ModificarPeriodo_Cerrado_S(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo)
      {
          try
          {
              return oData.ModificarPeriodo_Cerrado_S(IdEmpresa, IdNomina_Tipo, IdNomina_TipoLiqui, IdPeriodo);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarPeriodo_Cerrado_S", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }

      } // haac 13/01/2014




      // haac 13/01/2014
      public Boolean ModificarPeriodo_Reverso_N(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo)
      {
          try
          {
              return oData.ModificarPeriodo_Reverso_N(IdEmpresa, IdNomina_Tipo, IdNomina_TipoLiqui, IdPeriodo);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarPeriodo_Reverso_N", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }

      } // haac 13/01/2014

      public Boolean Borrar(ro_periodo_x_ro_Nomina_TipoLiqui_Info Info, ref string mensaje)
      {
          try
          {
              return oData.Borrar(Info, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Borrar", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };            
          }
         
      }

     
   // haac 14/01/2014   
      public ro_periodo_x_ro_Nomina_TipoLiqui_Info ObtenerPeriodoAnterior(int IdEmpresa, int IdPeriodo, int IdNomina_Tipo, int IdNomina_TipoLiqui)
      {
          try
          {
              return oData.ObtenerPeriodoAnterior(IdEmpresa, IdPeriodo, IdNomina_Tipo, IdNomina_TipoLiqui);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPeriodoAnterior", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }
          
          
      }

      public ro_periodo_x_ro_Nomina_TipoLiqui_Info ObtenerPeriodoDespues(int IdEmpresa, int IdPeriodo, int IdNomina_Tipo, int IdNomina_TipoLiqui)
      {
          try
          {
              return oData.ObtenerPeriodoDespues(IdEmpresa, IdPeriodo, IdNomina_Tipo, IdNomina_TipoLiqui);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPeriodoDespues", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }          
          
      }



       public ro_periodo_x_ro_Nomina_TipoLiqui_Info GetInfoPeriodoAnterior(int idEmpresa,  int idNominaTipo, int idNominaTipoLiqui,int idPeriodo)
      {
          try
          {
              return oData.GetInfoPeriodoAnterior(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetInfoPeriodoAnterior", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }
      }


       public ro_periodo_x_ro_Nomina_TipoLiqui_Info GetInfoPeriodoDespues(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo)
       {
           try
           {
               return oData.GetInfoPeriodoDespues(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetInfoPeriodoDespues", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
           }
       }


      //CJimenez 15.01.13
      public Boolean ValidarCerrado(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo)
      {
          try
          {
              return oData.ValidarCerrado(IdEmpresa, IdNomina_Tipo, IdNomina_TipoLiqui, IdPeriodo);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarCerrado", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }
          
      }

      public Boolean ValidarContabilizado(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo)
      {
          try
          {
              return oData.ValidarContabilizado(IdEmpresa, IdNomina_Tipo, IdNomina_TipoLiqui, IdPeriodo);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarContabilizado", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }
          
      }

      public Boolean ValidarProcesado(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo)
      {
          try
          {
              return oData.ValidarProcesado(IdEmpresa, IdNomina_Tipo, IdNomina_TipoLiqui, IdPeriodo);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarProcesado", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          } 
      }
      public Boolean ActualizarContabilizacion(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo)
      {
          try
          {
              return oData.ActualizarContabilizacion(IdEmpresa, IdNomina_Tipo, IdNomina_TipoLiqui, IdPeriodo);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarContabilizacion", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          } 
      }


      public ro_periodo_x_ro_Nomina_TipoLiqui_Info GetInfoPeriodoActual(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, ref string msg)
      { 
       try{
              return oData.GetInfoPeriodoActual(idEmpresa,idNominaTipo,idNominaTipoLiqui, ref msg);
      }  catch (Exception ex)
       {
           Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
           throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetInfoPeriodoActual", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
       }
    }


      public ro_periodo_x_ro_Nomina_TipoLiqui_Info GetInfoConsultaPeriodoPorFecha(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, DateTime fecha, ref string msg)
      {
          try
          {
              return oData.GetInfoConsultaPeriodoPorFecha(idEmpresa, idNominaTipo, idNominaTipoLiqui, fecha, ref msg);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetInfoConsultaPeriodoPorFecha", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }
      }




      public List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ConsultaPerNomTipLiq(int IdEmpresa)
      {
          try
          {
              return oData.ConsultaPerNomTipLiq(IdEmpresa);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaPerNomTipLiq", ex.Message), ex) { EntityType = typeof(ro_periodo_x_ro_Nomina_TipoLiqui_Bus) };
          }
      }






    }
}
