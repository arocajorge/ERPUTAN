using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class tb_sis_tipoDocumento_tipoValor_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<tb_sis_tipoDocumento_tipoValor_Info> ObtenerTipoDocumento(string Idtipodoc)
        {
            try
            {
                tb_sis_tipoDocumento_tipoValor_Data data = new tb_sis_tipoDocumento_tipoValor_Data();
                return data.ObtenerTipoDocumento(Idtipodoc);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerTipoDocumento", ex.Message), ex) { EntityType = typeof(tb_sis_tipoDocumento_tipoValor_Bus) };
           
            }
        }

        public tb_sis_tipoDocumento_tipoValor_Bus()
        {
            try
            {

            }
            catch (Exception ex)
            {
               oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
            }
        }
    }
}
