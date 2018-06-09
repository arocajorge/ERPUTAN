using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data;
using Core.Erp.Info.Caja;
using Core.Erp.Business.Caja;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;



namespace Core.Erp.Business.CuentasxCobrar
{
  public  class cxc_cobro_Det_Bus
    {

        #region Declaracion

        cxc_cobro_Det_Data data = new cxc_cobro_Det_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";

        #endregion

         public Boolean GuardarDB(List<cxc_cobro_Det_Info> lista)
          {
              try
              {
                   return data.GuardarDB(lista);
              }
              catch (Exception ex)
              {
                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                  throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
              }

          }

         public Boolean ModificarDetalleCobro(List<cxc_cobro_Det_Info> lista)
         {
             try
             {
                 return data.ModificarDetalleCobro(lista);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDetalleCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
             }

         }

         public List<cxc_cobro_Det_Info> Get_List_Cobro_detalle(int IdEmpresa, int idsucursal, decimal idcobro)
         {
             try
             {
                 return data.Get_List_Cobro_detalle(IdEmpresa, idsucursal, idcobro);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobro_detalle", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
             }

         }

         public List<cxc_cobro_Det_Info> Get_List_cobro_x_documento(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteCble)
         {
             try
             {
                 return data.Get_List_cobro_x_documento(IdEmpresa, IdSucursal, IdBodega, IdCbteCble);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_documento", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
             }
         }

         public Boolean EliminarDetalleCobro(int IdEmpresa, int IdSucursal, decimal IdCobro)
         {
             try
             {
                 return data.EliminarDetalleCobro(IdEmpresa, IdSucursal, IdCobro);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDetalleCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
             }

         }


    }
}
