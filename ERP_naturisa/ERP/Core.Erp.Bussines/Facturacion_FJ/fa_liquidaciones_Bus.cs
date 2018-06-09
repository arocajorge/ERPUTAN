using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Info.Facturacion_FJ;
namespace Core.Erp.Business.Facturacion_FJ
{
  public  class fa_liquidaciones_Bus
  {
      fa_liquidaciones_Data data = new fa_liquidaciones_Data();
      fa_liquidaciones_det_Bus detalle_bus = new fa_liquidaciones_det_Bus();
      
      public bool GuardarDB(fa_liquidaciones_Info info)
      { 
          decimal Idliquidaciones=0;
         
          bool ba_si_actualizo_ograbo = false;
          try
          {  
              if(!data.si_existe_en_base(info))
                {
                    ba_si_actualizo_ograbo = data.GuardarDB(info, ref Idliquidaciones);
                    foreach (var item in info.lista)
                    {
                        item.IdLiquidaciones = Idliquidaciones;
                    }
                   }
              else
                {
                    ba_si_actualizo_ograbo= data.ModificarDB(info);
                }
              if (ba_si_actualizo_ograbo)
              {
                 ba_si_actualizo_ograbo= detalle_bus.EliminarDB(info.IdEmpresa,Convert.ToInt32( info.IdLiquidaciones));
                 if (ba_si_actualizo_ograbo)
                 {
                     foreach (var item in info.lista)
                     {
                         item.IdLiquidaciones = info.IdLiquidaciones;
                     }

                   ba_si_actualizo_ograbo=  detalle_bus.GuardarDB(info.lista);
                 }

              }
              return ba_si_actualizo_ograbo;
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_liquidaciones_Bus) };
          }
      }

      public bool ModificarDB(fa_liquidaciones_Info info)
      {
          try
          {
              return data.ModificarDB(info);
            
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_liquidaciones_Bus) };
   
          }
      }

      public bool AnularDB(fa_liquidaciones_Info info)
      {
          try
          {
              return data.AnularDB(info);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(fa_liquidaciones_Bus) };
   
             
          }
      }
      public bool Procesar_Liquidaciones(int IdEmpresa, int IdPEriodo, DateTime fecha_inicio, DateTime fecha_fin)
      {
          try
          {
              return data.Procesar_Liquidaciones(IdEmpresa, IdPEriodo, fecha_inicio, fecha_fin);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_liquidaciones_Bus) };
          }
      }

      public fa_liquidaciones_Info Get_liquidaciones_info(int IdEmpresa, Int32 IdPeriodo)
      {
          try
          {
              return data.Get_liquidaciones_info(IdEmpresa, IdPeriodo);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_liquidaciones_Bus) };
          }
      }
    }
}
