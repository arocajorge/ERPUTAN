using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace Core.Erp.Info.General
{
    public class Cl_VisorSucucesos
    {
        public void GuardarVisor(string Transaccion, Exception ex)
        {

            try
            {
                if (!(EventLog.Exists("SYSERP_s")))
                {
                    EventLog.CreateEventSource(Transaccion, "SYSERP_s");
                }

                EventLog log = new EventLog("SYSERP_s");
                log.Source = Transaccion;
                log.WriteEntry(ex.ToString(), EventLogEntryType.Error);
            }
            catch (Exception)
            {
                cl_Control_De_Erro cterr = new cl_Control_De_Erro();
                cterr.capturalog(ex.ToString(), Transaccion);
            }
        }


        public Cl_VisorSucucesos()
        {

        }
    }
}
