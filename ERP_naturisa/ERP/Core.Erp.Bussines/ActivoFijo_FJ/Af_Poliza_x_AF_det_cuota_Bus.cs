using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.ActivoFijo_FJ;
using Core.Erp.Data.ActivoFijo_FJ;

namespace Core.Erp.Business.ActivoFijo_FJ
{
   public class Af_Poliza_x_AF_det_cuota_Bus
   {
       Af_Poliza_x_AF_det_cuota_Data data = new Af_Poliza_x_AF_det_cuota_Data();
       public bool GuardarDB(List<Af_Poliza_x_AF_det_cuota_Info> lista)
       {
           try
           {
            return   data.GuardarDB(lista);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(Af_Poliza_x_AF_det_cuota_Bus) };
         
              
           }
       }

       public List<Af_Poliza_x_AF_det_cuota_Info> Get_List_Poliza_Detalle_Cuota(int IdEmpresa, int IdPoliza)
       {
           try
           {

               return data.Get_List_Poliza_Detalle_Cuota(IdEmpresa, IdPoliza);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Poliza_Detalle_Cuota", ex.Message), ex) { EntityType = typeof(Af_Poliza_x_AF_det_cuota_Bus) };
         
           }
       }


       public Boolean EliminarDB(int IdEmpresa, int IdPoliza)
       {
           try
           {
               return data.EliminarDB(IdEmpresa, IdPoliza);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Af_Poliza_x_AF_det_cuota_Bus) };
         
           }
       }

    }
}
