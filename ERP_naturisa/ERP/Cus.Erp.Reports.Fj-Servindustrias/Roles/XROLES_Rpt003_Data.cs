using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;


namespace Cus.Erp.Reports.FJ.Roles
{
   public class XROLES_Rpt003_Data
   {
       tb_Empresa_Info Cbt = new tb_Empresa_Info();
       tb_Empresa_Data empresaData = new tb_Empresa_Data();
       public List<XROLES_Rpt003_Info> Get_list_Horas_Extras(int IdEmpresa, int IdNomina_Tipo, int IdNomina_tipo_Liq, int IdPerido)
       {
           List<XROLES_Rpt003_Info> lista = new List<XROLES_Rpt003_Info>();
           try
           {

               using (Entities_Roles_Fj_Rpt db = new Entities_Roles_Fj_Rpt())
               {
                   var query = from q in db.vwROLES_Rpt003
                               where q.IdEmpresa == IdEmpresa
                               && q.IdNominaTipo == IdNomina_Tipo
                               && q.IdNominaTipoLiqui == IdNomina_tipo_Liq
                               && q.IdPeriodo == IdPerido
                               select q;

                   foreach (var item in query)
                   {
                       XROLES_Rpt003_Info info = new XROLES_Rpt003_Info();
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdNominaTipo = item.IdNominaTipo;
                       info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                       info.IdPeriodo = item.IdPeriodo;
                       info.pe_nombreCompleto = item.pe_nombreCompleto;
                       info.pe_cedulaRuc = item.pe_cedulaRuc;
                       info.hora_extra25 = item.hora_extra25;
                       info.hora_extra50 = item.hora_extra50;
                       info.hora_extra100 = item.hora_extra100;
                       info.TotalHorasExtras = item.TotalHorasExtras;
                       info.hora_trabajada = item.hora_trabajada;
                       info.Dias_Efectivos = item.Dias_Efectivos;
                       lista.Add(info);
                   }
               }

               return lista;
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
