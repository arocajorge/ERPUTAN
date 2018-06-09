using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.SqlClient;
using System.Data.Entity.Validation;
namespace Cus.Erp.Reports.FJ.Bancos
{
   public class XBAN_FJ_Rpt003_Data
   {
       tb_Empresa_Info Cbt = new tb_Empresa_Info();
       tb_Empresa_Data empresaData = new tb_Empresa_Data();

       public List<XBAN_FJ_Rpt003_Info> Get_List_FlujoEreso(int idEmpresa, DateTime fi, DateTime ff)
       {
           try
           {
               try
               {
                    List<XBAN_FJ_Rpt003_Info> Lista = new List<XBAN_FJ_Rpt003_Info>();
               Cbt = empresaData.Get_Info_Empresa(idEmpresa);
               DateTime FechaI = Convert.ToDateTime(fi.ToShortDateString());
               DateTime FechaF = Convert.ToDateTime(ff.ToShortDateString());
               using (EntitiesBancos_Rpt_Fj Context = new EntitiesBancos_Rpt_Fj())
               {
                   var lst =( from q in Context.spBAN_Rpt001(idEmpresa, FechaI, FechaF)
                             
                             select q);
                   foreach (var item in lst)
                   {
                       XBAN_FJ_Rpt003_Info Info = new XBAN_FJ_Rpt003_Info();
                       Info.IdEmpresa = item.IdEmpresa;
                       Info.tc_TipoCbte = item.tc_TipoCbte;
                       Info.cb_Valor = Convert.ToDouble(item.cb_Valor);
                       Info.em_nombre = Cbt.em_nombre;
                       Info.em_logo = Cbt.em_logo;                     
                       Lista.Add(Info);
                   }
               }
               return Lista;
               }
               catch (DbEntityValidationException exv)
               {
                     string mensaje = "";
               mensaje = exv.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(exv.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
                  
               }
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
