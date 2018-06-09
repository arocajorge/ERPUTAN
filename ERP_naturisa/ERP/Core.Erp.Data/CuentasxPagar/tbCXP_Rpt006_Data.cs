using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxPagar
{
   public class tbCXP_Rpt006_Data
   {
       string mensaje = "";
       public List<tbCXP_Rpt006_Info> ConsultaGeneral(int IdEmpresa, string IdUsuario, string nom_pc)
       {
           try
           {
               List<tbCXP_Rpt006_Info> Lst = new List<tbCXP_Rpt006_Info>();
               EntitiesCuentasxPagar oEnti = new EntitiesCuentasxPagar();
               var Query = from q in oEnti.tbCXP_Rpt006
                           where q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario && q.nom_pc == nom_pc 
                           select q;
               foreach (var item in Query)
               {
                   tbCXP_Rpt006_Info Obj = new tbCXP_Rpt006_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdUsuario = item.IdUsuario;
                   Obj.Fecha_Transac = item.Fecha_Transac;
                   Obj.nom_pc = item.nom_pc;
                   Obj.Fecha = item.Fecha;
                   Obj.FechaVence = item.FechaVence;
                   Obj.nDoc = item.nDoc;
                   Obj.NAutorizacion = item.NAutorizacion;
                   Obj.Documento = item.Documento;
                   Obj.pr_CedulaRuc = item.pr_CedulaRuc;
                   Obj.Proveedor = item.Proveedor;
                   Obj.Observacion = item.Observacion;
                   Obj.SubtotalIva = item.SubtotalIva;
                   Obj.SubtotalSinIva = item.SubtotalSinIva;
                   Obj.baseImponible = item.baseImponible;
                   Obj.Total = item.Total;
                   Obj.IdProveedor = item.IdProveedor;
                   Obj.FechaCbte = item.FechaCbte;
                   Obj.IdCbte = item.IdCbte;
                   Lst.Add(Obj);
               }
               return Lst;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               return new List<tbCXP_Rpt006_Info>(); 
           }
       }

       public bool Ejecuta_spCXP_Rpt006(int IdEmpresa, DateTime FDesde, DateTime FHasta, string IdUsuario, string nom_pc)
       {
           try
           {
               using(EntitiesCuentasxPagar enty = new EntitiesCuentasxPagar())
               {
                  // enty.spCXP_Rpt006(IdEmpresa, FDesde, FHasta, IdUsuario, nom_pc);
                   return true;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               return false; 
           }
       }

    }
}
