using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;

namespace Cus.Erp.Reports.FJ.Roles
{
  public  class XROLES_Rpt009_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XROLES_Rpt009_Info> Get_Nomina_consolidada(ro_periodo_x_ro_Nomina_TipoLiqui_Info info_)
      {
          List<XROLES_Rpt009_Info> lista = new List<XROLES_Rpt009_Info>();
          try
          {
         
             
              using (Entities_Roles_Fj_Rpt db = new Entities_Roles_Fj_Rpt())
              {

                 // db.SetCommandTimeOut(30000);
                  var query = from q in db.spROLES_Rpt009(info_.IdEmpresa,info_.IdNomina_Tipo,info_.pe_anio,info_.pe_mes)
                            
                              select q;

                  foreach (var item in query)
                  {
                      XROLES_Rpt009_Info info = new XROLES_Rpt009_Info();
                     
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdNomina_Tipo = item.IdNomina_Tipo;
                      info.pe_apellido = item.pe_apellido + " " + item.pe_nombre;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.FechaInicio = item.FechaInicio.ToString().Substring(0, 10);
                      info.EstadoEmpleado = item.EstadoEmpleado;
                      info.ca_descripcion = item.ca_descripcion;
                      info.Valor = item.Valor;
                      info.Descripcion = item.Descripcion;
                      info.Orden = item.Orden;
                      info.pe_anio = item.pe_anio;
                      info.pe_mes = item.pe_mes;
                      info.pe_FechaIni = item.pe_FechaIni.ToString().Substring(0,10);
                      info.Descripcion = item.Descripcion;
                      info.Grupo = item.CatalogoGrupo;
                      info.em_fechaSalida = item.em_fechaSalida;
                      TimeSpan antiguedad;
                      antiguedad =DateTime.Now-item.FechaInicio;
                      info.Antiguedad =Math.Round( antiguedad.TotalDays,0)+" Dias";
                      if (item.EstadoEmpleado != "Activo")
                      {
                          if (item.em_fechaSalida!=null)
                          info.EstadoEmpleado = item.em_fechaSalida.ToString().Substring(0, 10);
                      }
                      info.Centro_costo = item.Centro_costo;
                      info.Af_DescripcionCorta = item.Af_DescripcionCorta;
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
