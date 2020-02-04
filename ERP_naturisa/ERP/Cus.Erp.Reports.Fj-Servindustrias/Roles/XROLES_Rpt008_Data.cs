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
  public  class XROLES_Rpt008_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XROLES_Rpt008_Info> Get_Nomina_consolidada(ro_periodo_x_ro_Nomina_TipoLiqui_Info info_)
      {
          List<XROLES_Rpt008_Info> lista = new List<XROLES_Rpt008_Info>();
          try
          {
         

              using (Entities_Roles_Fj_Rpt db = new Entities_Roles_Fj_Rpt())
              {
                  var query = from q in db.vwROLES_Rpt008
                            where q.pe_anio==info_.pe_anio
                            && q.pe_mes==info_.pe_mes
                            && q.IdTipoNomina==info_.IdNomina_Tipo
                              select q;

                  foreach (var item in query)
                  {
                      XROLES_Rpt008_Info info = new XROLES_Rpt008_Info();
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdTipoNomina = item.IdTipoNomina;
                      info.pe_nombreCompleto = item.pe_nombreCompleto;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.zo_descripcion = item.zo_descripcion;
                      info.fu_descripcion = item.fu_descripcion;
                      info.Disco = item.Disco;
                      info.Placa = item.Placa;
                      info.ru_descripcion = item.ru_descripcion;
                      info.em_fechaIngaRol = item.em_fechaIngaRol.ToString().Substring(0, 10);
                      info.em_status = item.Estado;
                      info.ca_descripcion = item.ca_descripcion;
                      info.Valor = item.Valor;
                      info.rubro = item.rubro;
                      info.Orden = item.Orden;
                      info.Id_Catalogo = item.Id_Catalogo;
                      info.pe_anio = item.pe_anio;
                      info.pe_mes = item.pe_mes;
                      info.pe_FechaIni = item.pe_FechaIni.ToString().Substring(0,10);
                      info.pe_FechaFin = item.pe_FechaFin;
                      info.Descripcion = item.Descripcion;
                      info.Grupo = item.Grupo;
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
