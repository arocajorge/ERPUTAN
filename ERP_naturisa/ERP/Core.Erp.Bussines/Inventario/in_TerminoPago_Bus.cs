using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_TerminoPago_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog=new tb_sis_Log_Error_Vzen_Bus();
            string mensaje = "";
        public List<in_TerminoPago_Info> ObtenerListaTermPago()
        {
            try
            {
                in_TerminoPago_Data data = new in_TerminoPago_Data();
                return data.ObtenerListaTermPago();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaTermPago", ex.Message), ex) { EntityType = typeof(in_TerminoPago_Bus) };

            }
        }
    }
}
