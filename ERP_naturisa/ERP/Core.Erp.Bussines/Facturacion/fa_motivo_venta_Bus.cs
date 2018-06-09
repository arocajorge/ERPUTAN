using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
   public class fa_motivo_venta_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_motivo_venta_Data Data = new fa_motivo_venta_Data();

       public List<fa_motivo_venta_Info> Get_List_fa_motivo_venta(int IdEmpresa)
       {
           try
           {
               return Data.Get_List_fa_motivo_venta(IdEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_fa_motivo_venta", ex.Message), ex) { EntityType = typeof(fa_motivo_venta_Bus) };
           }
       }

       public Boolean Get_List_fa_motivo_venta_Existe(fa_motivo_venta_Info Info, ref string mensaje)
       {
           try
           {
               return Data.Get_List_fa_motivo_venta_Existe(Info, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Grabar", ex.Message), ex) { EntityType = typeof(fa_motivo_venta_Bus) };
           }
       }

       public Boolean Grabar(fa_motivo_venta_Info Info, ref int idMotivo, ref string msg)
       {
           try
           {
               return Data.GrabarDB(Info, ref idMotivo, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Grabar", ex.Message), ex) { EntityType = typeof(fa_motivo_venta_Bus) };
           }
       }

       public Boolean Modificar(fa_motivo_venta_Info Info, ref string msg)
       {
           try
           {
               return Data.ModificarDB(Info, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(fa_motivo_venta_Bus) };
           }
       }

       public Boolean Anular(fa_motivo_venta_Info Info, ref string msg)
       {
           try
           {
               return Data.AnularDB(Info, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(fa_motivo_venta_Bus) };
           }
       }
    }
}
