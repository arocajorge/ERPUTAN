using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Core.Erp.Business.General;
using Core.Erp.Data.General;

using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.class_sri.NotaCredito;

namespace Core.Erp.Business.General
{
  public  class tb_Proceso_SRI_Bus
    {
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

      tb_Proceso_SRI_Data odata = new tb_Proceso_SRI_Data();

      string mensaje = "";
      public factura Deserializar_factura_SRI(string path, ref string numAutorizacion, ref DateTime fechAutoriza, ref string mensaje)
      {
          try
          {
              return odata.Deserializar_factura_SRI(path, ref numAutorizacion, ref fechAutoriza, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Deserializar_factura_SRI", ex.Message), ex) { EntityType = typeof(tb_Proceso_SRI_Bus) };
         
          }


      }

      public notaCredito Deserializar_NotaCredito_SRI(string path, ref string numAutorizacion, ref DateTime fechAutoriza)
      {
          try
          {
              return odata.Deserializar_NotaCredito_SRI(path, ref numAutorizacion, ref fechAutoriza);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Deserializar_NotaCredito_SRI", ex.Message), ex) { EntityType = typeof(tb_Proceso_SRI_Bus) };
         
          }


      }


  


    }
}
