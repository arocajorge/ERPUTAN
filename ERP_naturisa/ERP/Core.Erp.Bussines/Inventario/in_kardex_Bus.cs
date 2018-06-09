using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;

using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
   public  class in_kardex_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       in_kardex_Info KarInfo = new in_kardex_Info();
       in_movi_inve_detalle_Bus MoviInvenDet = new in_movi_inve_detalle_Bus();



       public void CalcularSaldoIniciales()
       {
           try
           {
         //  MoviInvenDet.Obtener_list_Movi_inven_det
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "CalcularSaldoIniciales", ex.Message), ex) { EntityType = typeof(in_kardex_Bus) };

           }



        
       }


       public in_kardex_Bus() { }

    }
}
