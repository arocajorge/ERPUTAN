using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Roles
{
   public class XROL_Rpt013_Data
   {
       string mensaje = "";
       tb_Empresa_Info Cbt = new tb_Empresa_Info();
       tb_Empresa_Data empresaData = new tb_Empresa_Data();
       public List<XROL_Rpt013_Info> Get_List_Vacaciones(int IdEmpresa, decimal IdEmpleado, DateTime FechaInicio,DateTime FechaFin)
       {
           try
           {
               DateTime Fi = Convert.ToDateTime(FechaInicio.ToShortDateString());
               DateTime Ff = Convert.ToDateTime(FechaFin.ToShortDateString());

               List<XROL_Rpt013_Info> listado = new List<XROL_Rpt013_Info>();

               using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
               {
                   string Querty = "select IdEmpresa,IdEmpleado,pe_apellido,pe_nombre,sum( Ingreso) as Ingreso,pe_mes,pe_anio,pe_cedulaRuc from vwROL_Rpt013 " +
                       "where IdEmpresa ='" + IdEmpresa + "' and IdEmpleado='" + IdEmpleado + "' and pe_FechaIni>='" + Fi + "' and pe_FechaFin<='" + Ff + "' "+
                       " group by IdEmpresa,IdEmpleado,pe_apellido,pe_nombre,pe_mes,pe_anio,pe_cedulaRuc";


                   var Consulta = db.Database.SqlQuery<XROL_Rpt013_Info>(Querty);

                   //listado = Consulta.ToList();




                   foreach (var item in Consulta.ToList())
                   {
                       XROL_Rpt013_Info info = new XROL_Rpt013_Info();

                       info.IdEmpresa =item.IdEmpresa;
                       info.IdEmpleado = item.IdEmpleado;
                       info.pe_nombreCompleto = item.pe_apellido+" "+item.pe_nombre;
                       info.pe_apellido = item.pe_apellido;
                       info.pe_nombre = item.pe_nombre;
                       info.pe_cedulaRuc = item.pe_cedulaRuc;
                       info.Ingreso = item.Ingreso;
                       info.pe_mes = item.pe_mes;
                       info.pe_anio = item.pe_anio;
                       info.Periodo = item.pe_anio + "-" + item.pe_mes;
                       info.tot_Ingreso =Convert.ToDouble( item.Ingreso);
                       //info.pe_FechaIni = item.pe_FechaIni;
                       //info.pe_FechaFin = item.pe_FechaFin;

                       listado.Add(info);
                   }

               }
               return listado;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.InnerException.ToString());
           }

       }

    }
}
