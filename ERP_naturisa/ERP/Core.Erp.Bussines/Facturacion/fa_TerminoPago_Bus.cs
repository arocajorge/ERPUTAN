using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    public class fa_TerminoPago_Bus
    {
        #region CJimenez
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        fa_TerminoPago_Data odata = new fa_TerminoPago_Data();

        public List<fa_TerminoPago_Info> Get_List_TerminoPago(string IdTipoCredito)
        {
            try
            {
                return odata.Get_List_TerminoPago(IdTipoCredito);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPedido_Detalle", ex.Message), ex) { EntityType = typeof(fa_TerminoPago_Bus) };
            }
        }

        public Boolean GuardarDB(fa_TerminoPago_Info _Info, List<fa_TerminoPago_Distribucion_Info> lstTerminoDis, ref string msjError)
        {
            try
            {
                fa_TerminoPago_Distribucion_Bus terminoDisBus = new fa_TerminoPago_Distribucion_Bus();
                if (odata.GuardarDB(_Info))
                {
                    foreach (var item in lstTerminoDis)
                    {
                        item.IdTerminoPago = _Info.IdTerminoPago;
                    }
                    return terminoDisBus.GuardarDB(lstTerminoDis, ref msjError);
                }
                else
                    return false;
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(fa_TerminoPago_Bus) };
           
            }
        }

        public Boolean ModificarDB(fa_TerminoPago_Info _Info, List<fa_TerminoPago_Distribucion_Info> lstTerminoDis, ref string msjError)
        {
            try
            {
                fa_TerminoPago_Distribucion_Bus terminoDisBus = new fa_TerminoPago_Distribucion_Bus();
                foreach (var item in lstTerminoDis)
                {
                    item.IdTerminoPago = _Info.IdTerminoPago;
                }
                if (terminoDisBus.EliminarDB(_Info.IdTerminoPago, ref msjError))
                    if (odata.ModificarDB(_Info, ref msjError))
                        return terminoDisBus.GuardarDB(lstTerminoDis, ref msjError);
                    else
                        return false;
                else
                    return false;
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificacion", ex.Message), ex) { EntityType = typeof(fa_TerminoPago_Bus) };
           
            }
        }

        public List<fa_TerminoPago_Info> Get_List_TerminoPago()
        {
            try
            {
                return odata.Get_List_TerminoPago();
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPedido_Detalle", ex.Message), ex) { EntityType = typeof(fa_TerminoPago_Bus) };
            }
        }
        #endregion
    }
}
