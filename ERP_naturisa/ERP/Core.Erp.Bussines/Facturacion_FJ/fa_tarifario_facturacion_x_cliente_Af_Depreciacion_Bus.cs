using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Info.Facturacion_FJ;
namespace Core.Erp.Business.Facturacion_FJ
{
   public class fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Bus
   {
       fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Data data = new fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Data();
       public bool Guardar(fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info item, ref int IdDepreciacion)
       {
           try
           {
               return data.Guardar( item,ref IdDepreciacion );
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(fa_tarifario_facturacion_x_cliente_det_Bus) };
        
           }
       }

       public bool Eliminar(int IdEmpresa, int IdTarifario)
       {
           try
           {
               return data.Eliminar(IdEmpresa,IdTarifario);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar", ex.Message), ex) { EntityType = typeof(fa_tarifario_facturacion_x_cliente_det_Bus) };
        
               
           }
       }

       public List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info> Get_List_Activo_fijos_Depreciar(int idempresa, decimal idtarifario)
       {
           try
           {
               return data.Get_List_Activo_fijos_Depreciar(idempresa, idtarifario);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Activo_fijos_Depreciar", ex.Message), ex) { EntityType = typeof(fa_tarifario_facturacion_x_cliente_det_Bus) };
        
              
           }
       }

       public bool Anular(List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info> lista)
       {
           try
           {
               return data.Anular(lista);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(fa_tarifario_facturacion_x_cliente_det_Bus) };
        
           }
       }

    }
}
