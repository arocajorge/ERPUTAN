using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using System.Data.Objects;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Bancos
{
   public class ba_Cbte_Ban_Datos_Entrega_cheq_Data
   {
       public Boolean GrabarDB(ba_Cbte_Ban_Datos_Entrega_cheq_Info info, ref string MensajeError)
       {
           try
           {
              
                   using (EntitiesBanco context = new EntitiesBanco())
                   {
                       ba_Cbte_Ban_Datos_Entrega_cheq address = new ba_Cbte_Ban_Datos_Entrega_cheq();
                       address.IdEmpresa = info.IdEmpresa;
                       address.IdCbteCble = info.IdCbteCble;
                       address.IdTipocbte = info.IdTipocbte;
                       address.fecha_hora_entrega = info.fecha_hora_entrega;
                       address.IdEstado_cheque_cat = info.IdEstado_cheque_cat;
                       address.IdPersona_Entrega = info.IdPersona_Entrega;
                       address.Nota_entrega = info.Nota_entrega;
                       address.fecha_trans = info.fecha_trans;
                       address.usuario = info.usuario;
                       context.ba_Cbte_Ban_Datos_Entrega_cheq.Add(address);
                       context.SaveChanges();
                   }
                   return true;
              
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.InnerException + " " + ex.Message;
               Console.WriteLine(ex.InnerException.Message);
               throw new Exception(ex.InnerException.ToString());
           }
       }

    }
}
