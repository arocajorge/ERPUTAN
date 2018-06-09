using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.ActivoFijo;
using Core.Erp.Info.ActivoFijo;


namespace Core.Erp.Business.ActivoFijo
{
  public   class Af_Activo_fijo_Categoria_Bus
    {
      Af_Activo_fijo_Categoria_Data Odata = new Af_Activo_fijo_Categoria_Data();
      
      public List<Af_Activo_fijo_Categoria_Info> Get_List_Activo_fijo_Categoria(int IdEmpresa, ref string MensajeError)
      {
          try
          {
              return Odata.Get_List_Activo_fijo_Categoria(IdEmpresa, ref MensajeError);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Categoria_Bus) };
          }
      }

      public List<Af_Activo_fijo_Categoria_Info> Get_List_Activo_fijo_Categoria(int IdEmpresa, int IdActivoFijoTipo, ref string MensajeError)
      {
          try
          {
              return Odata.Get_List_Activo_fijo_Categoria(IdEmpresa,IdActivoFijoTipo, ref MensajeError);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Categoria_Bus) };
          }
      }

      public Boolean GrabarDB(Af_Activo_fijo_Categoria_Info Info, ref int IdCategoria, ref string MensajeError)
      {
          try
          {
              return Odata.GrabarDB(Info, IdCategoria, ref MensajeError);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Categoria_Bus) };
          }
      }

      public Boolean ModificarDB(Af_Activo_fijo_Categoria_Info Info, ref string MensajeError)
      {

          try
          {
              return Odata.ModificarDB(Info, ref MensajeError);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Categoria_Bus) };
          }
      }

      public Boolean AnularDB(Af_Activo_fijo_Categoria_Info Info, ref string MensajeError)
      {
          try
          {
              return Odata.AnularDB(Info, ref MensajeError);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Categoria_Bus) };
          }

      }
  }
}
