using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Business.General;



namespace Core.Erp.Business.Academico
{
   public class Aca_InstitucionFinanciera_x_cod_establecimiento_Bus
    {

       Aca_InstitucionFinanciera_x_cod_establecimiento_Data da;
      tb_sis_Log_Error_Vzen_Bus oLog ;


      public bool ExisteEstablecimiento(int idInstitucionFinanciera,string cargaFinanciera) {
          try
          {
              return da.ExisteEstablecimiento(idInstitucionFinanciera,cargaFinanciera);

          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteEstablecimiento", ex.Message), ex) { EntityType = typeof(Aca_InstitucionFinanciera_x_cod_establecimiento_Bus) };
          }
      }

      public Aca_InstitucionFinanciera_x_cod_establecimiento_Bus()
      {
          da = new Aca_InstitucionFinanciera_x_cod_establecimiento_Data();
          oLog = new tb_sis_Log_Error_Vzen_Bus();
      }

      public List<Aca_InstitucionFinanciera_x_cod_establecimiento_Info> Get_List_Establecimiento()
      {
          try
          {
             return da.Get_List_Establecimiento();
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Establecimiento", ex.Message), ex) { EntityType = typeof(Aca_InstitucionFinanciera_x_cod_establecimiento_Bus) };
          }
      }

      public bool GrabarDB(Aca_InstitucionFinanciera_x_cod_establecimiento_Info info, ref string mensaje)
      {
          try
          {
              return da.GrabarDB(info, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_InstitucionFinanciera_x_cod_establecimiento_Bus) };
          }
      }

      public bool ActualizarDB(Aca_InstitucionFinanciera_x_cod_establecimiento_Info info, ref string mensaje)
      {
          try
          {
              return da.ActualizarDB(info, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_InstitucionFinanciera_x_cod_establecimiento_Bus) };
          }
      }

      public bool EliminarDB(Aca_InstitucionFinanciera_x_cod_establecimiento_Info info, ref string mensaje)
      {
          try
          {
              return da.AnularDB(info, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Aca_InstitucionFinanciera_x_cod_establecimiento_Bus) };
          }
      }

    }
}
