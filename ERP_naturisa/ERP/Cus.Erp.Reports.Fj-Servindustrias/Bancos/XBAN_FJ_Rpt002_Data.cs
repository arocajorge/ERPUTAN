using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Cus.Erp.Reports.FJ.Bancos
{
   public class XBAN_FJ_Rpt002_Data
   {
       tb_Empresa_Info Cbt = new tb_Empresa_Info();
       tb_Empresa_Data empresaData = new tb_Empresa_Data();

       public List<XBAN_FJ_Rpt002_Info> Get_List_FlujoEreso(int idEmpresa, DateTime fi, DateTime ff)
       {
           try
           {
               List<XBAN_FJ_Rpt002_Info> Lista = new List<XBAN_FJ_Rpt002_Info>();
               Cbt = empresaData.Get_Info_Empresa(idEmpresa);

               using (EntitiesBancos_Rpt_Fj Context = new EntitiesBancos_Rpt_Fj())
               {
                   var lst = from q in Context.vwBAN_FJ_Rpt002
                             where q.IdEmpresa == idEmpresa
                              && q.cb_Fecha >= fi
                              && q.cb_Fecha<=ff
                             select q;
                   foreach (var item in lst)
                   {
                       XBAN_FJ_Rpt002_Info Info = new XBAN_FJ_Rpt002_Info();
                       Info.IdEmpresa = item.IdEmpresa;
                       Info.IdConciliacion = item.IdConciliacion;
                       Info.IdBanco = item.IdBanco;
                       Info.IdPeriodo = item.IdPeriodo;
                       Info.tc_TipoCbte = item.tc_TipoCbte;
                       Info.cb_Valor = item.cb_Valor;                      
                       Info.cb_Observacion = item.cb_Observacion;
                       Info.ba_descripcion = item.ba_descripcion;                      
                       Info.em_nombre = Cbt.em_nombre;
                       Info.em_logo = Cbt.em_logo;
                       if (item.cb_Observacion.Length > 80)
                           Info.cb_Observacion = item.cb_Observacion.Substring(0, 80);
                       Lista.Add(Info);
                   }
               }
               return Lista;
           }
           catch (Exception ex)
           {
               string mensaje = "";
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
           }
       }
   
    }
}
