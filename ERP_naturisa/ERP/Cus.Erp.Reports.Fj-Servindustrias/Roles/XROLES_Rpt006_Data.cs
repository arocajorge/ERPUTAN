using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
namespace Cus.Erp.Reports.FJ.Roles
{
  public  class XROLES_Rpt006_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XROLES_Rpt006_Info> Get_list_Horas_Extras(int IdEmpresa, int IdNomina_Tipo, DateTime Fecha_Inicio, DateTime Fecha_Fin)
      {
          List<XROLES_Rpt006_Info> lista = new List<XROLES_Rpt006_Info>();
          try
          {
         

              int cont = 0;
              using (Entities_Roles_Fj_Rpt db = new Entities_Roles_Fj_Rpt())
              {
                  var query = from q in db.spROLES_Rpt006(IdEmpresa, IdNomina_Tipo, Fecha_Inicio, Fecha_Fin)
                            
                              select q;

                  foreach (var item in query)
                  {
                      XROLES_Rpt006_Info info = new XROLES_Rpt006_Info();
                      cont++;
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdNomina_Tipo = item.IdNomina_Tipo;
                      info.IdEmpleado = item.IdEmpleado;
                      info.IdRegistro = item.IdRegistro;
                      info.IdNomina_Tipo = item.IdNomina_Tipo;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.pe_nombre = item.pe_nombre;
                      info.pe_apellido = item.pe_apellido;
                      info.pe_nombre = item.pe_nombre;
                      info.es_fecha_registro = item.es_fecha_registro.ToString().Substring(0,10);
                      info.Id_catalogo_Cat = item.Id_catalogo_Cat;
                      info.ca_descripcion = item.ca_descripcion;
                      info.Cargo = item.Cargo;
                      info.IdTurno = item.IdTurno;
                      info.es_jornada_desfasada = item.es_jornada_desfasada;
                      info.de_descripcion = item.de_descripcion;
                      info.Placa = item.Placa;
                      info.zo_descripcion = item.zo_descripcion;
                      info.ru_descripcion = item.ru_descripcion;
                      info.fu_descripcion = item.fu_descripcion;
                      info.Disco = item.Disco;
                      info.em_status = item.em_status;
                      info.pe_nombre = item.pe_nombre+" "+item.pe_apellido;
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
