using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxCobrar
{
   public class cxc_cobro_x_caj_Caja_Movimiento_Bus
    {
       cxc_cobro_x_caj_Caja_Movimiento_Data data = new cxc_cobro_x_caj_Caja_Movimiento_Data();
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";

       public List<cxc_cobro_x_caj_Caja_Movimiento_Info> Get_List_cobro_x_caj_Caja_Movimiento(int IdEmpresa)
       {
           try
           {
               return data.Get_List_cobro_x_caj_Caja_Movimiento(IdEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_caj_Caja_Movimiento", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_caj_Caja_Movimiento_Bus) };
           }
       
       
       }

       public List<cxc_cobro_x_caj_Caja_Movimiento_Info> Get_List_cobro_x_caj_Caja_Movimiento(int IdEmpresa, int IdSucursal)
       {
           try
           {
               return data.Get_List_cobro_x_caj_Caja_Movimiento(IdEmpresa, IdSucursal);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_caj_Caja_Movimiento", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_caj_Caja_Movimiento_Bus) };
           }
       
       }
      

       public Boolean GuardarDB(cxc_cobro_x_caj_Caja_Movimiento_Info info)
       {
           try
           {
               return data.GuardarDB(info);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_caj_Caja_Movimiento", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_caj_Caja_Movimiento_Bus) };
           }
       }

       public cxc_cobro_x_caj_Caja_Movimiento_Info Get_Info_cobro_x_caj_Caja_Movimiento(int IdEmpresa, int IdSucursal, decimal IdCobro)
       {
           try
           {
               return data.Get_Info_cobro_x_caj_Caja_Movimiento(IdEmpresa, IdSucursal, IdCobro);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_caj_Caja_Movimiento", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_caj_Caja_Movimiento_Bus) };
           }
          
       }

    }
}
