using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    public class fa_TerminoPago_Distribucion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_TerminoPago_Distribucion_Data data = new fa_TerminoPago_Distribucion_Data();

        public List<fa_TerminoPago_Distribucion_Info> Get_List_TerminoPago_Distribucion(string IdTipoFormaPago)
        {
            try
            {
                return data.Get_List_TerminoPago_Distribucion(IdTipoFormaPago);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "obtenerLista", ex.Message), ex) { EntityType = typeof(fa_TerminoPago_Distribucion_Bus) };
           
            }
        }

        public Boolean GuardarDB(List<fa_TerminoPago_Distribucion_Info> lst, ref string msjError)
        {
            try
            {
                return data.GuardarDB(lst);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(fa_TerminoPago_Distribucion_Bus) };
           
            }
        }

        public Boolean ModificarDB(List<fa_TerminoPago_Distribucion_Info> lst)
        {
            try
            {
                return data.ModificarDB(lst); 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(fa_TerminoPago_Distribucion_Bus) };
           
            }
        }

        public Boolean EliminarDB(string IdTipoFormaPago, ref string msjError)
        {
            try
            {
                return data.EliminarDB(IdTipoFormaPago);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminar", ex.Message), ex) { EntityType = typeof(fa_TerminoPago_Distribucion_Bus) };
           
            }
        }
    }
}
