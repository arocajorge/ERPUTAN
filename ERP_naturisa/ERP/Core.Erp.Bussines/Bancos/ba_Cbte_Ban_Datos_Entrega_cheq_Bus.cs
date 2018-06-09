using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
namespace Core.Erp.Business.Bancos
{
   public class ba_Cbte_Ban_Datos_Entrega_cheq_Bus
   {
       ba_Cbte_Ban_Datos_Entrega_cheq_Data oData = new ba_Cbte_Ban_Datos_Entrega_cheq_Data();
       public Boolean GrabarDB(ba_Cbte_Ban_Datos_Entrega_cheq_Info info, ref string MensajeError)
       {
           try
           {
               return oData.GrabarDB(info, ref MensajeError);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Vista_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };

           }
       }
    }
}
