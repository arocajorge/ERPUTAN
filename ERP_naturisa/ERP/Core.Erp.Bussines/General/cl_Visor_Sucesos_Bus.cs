using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using Core.Erp.Business.General;

namespace Core.Erp.Business.General
{
    public class cl_Visor_Sucesos_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public void GuardarVisor(string Transaccion , Exception e)
        {
           
            try
            {
                if (!(EventLog.Exists("SYSERP_s")))
                {
                   EventLog.CreateEventSource(Transaccion, "SYSERP_s");
                }

                EventLog log = new EventLog("SYSERP_s");
                log.Source = Transaccion;
                log.WriteEntry(e.ToString(), EventLogEntryType.Error);
            }
            catch ( Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarVisor", ex.Message), ex) { EntityType = typeof(cl_Visor_Sucesos_Bus) };
         
            }
         }

        public cl_Visor_Sucesos_Bus() {
            try
            {

            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "cl_Visor_Sucesos_Bus", ex.Message), ex) { EntityType = typeof(cl_Visor_Sucesos_Bus) };
         
            }
        }
    }
}
