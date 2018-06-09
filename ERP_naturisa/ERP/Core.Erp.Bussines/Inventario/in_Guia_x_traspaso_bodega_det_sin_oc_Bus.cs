using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;

using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
  public  class in_Guia_x_traspaso_bodega_det_sin_oc_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        in_Guia_x_traspaso_bodega_det_sin_oc_Data odata = new in_Guia_x_traspaso_bodega_det_sin_oc_Data();

        string mensaje = "";
      
      public Boolean GuardarDB(List<in_Guia_x_traspaso_bodega_det_sin_oc_Info> LstInfo)
      {
          try
          {
              return odata.GuardarDB(LstInfo);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_det_sin_oc_Bus) };

              
          }
      }

      public Boolean EliminarDB(int IdEmpresa,decimal IdGuia)
      {
          try
          {
              return odata.EliminarDB(IdEmpresa, IdGuia);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_det_sin_oc_Bus) };

          }
      
      }


      public List<in_Guia_x_traspaso_bodega_det_sin_oc_Info> Get_List_Guia_x_traspaso_bodega_det_sin_oc(int idempresa, decimal IdGuia)
      {
          try
          {
              return odata.Get_List_Guia_x_traspaso_bodega_det_sin_oc(idempresa, IdGuia);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListDetGui_Sin_OC", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_det_sin_oc_Bus) };
         
          }
      
      }
    }
}
