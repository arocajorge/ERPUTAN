using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Roles
{
    
   public class XROL_Rpt017_Data
    {


        string mensaje = "";
        tb_Empresa_Data empresa_data = new tb_Empresa_Data();
        tb_Empresa_Info info_empresa = new tb_Empresa_Info();

         public List<XROL_Rpt017_Info> Get_Valor_Acumulado_x_empleado(int idEmpresa, int idNomina,string CodCtbteCble, DateTime fi, DateTime ff)
         {
          try
          {
              DateTime f_inicio = Convert.ToDateTime(fi.ToShortDateString());
              DateTime f_fin = Convert.ToDateTime(ff.ToShortDateString());

              List<XROL_Rpt017_Info> Listado = new List<XROL_Rpt017_Info>();
              info_empresa = empresa_data.Get_Info_Empresa(idEmpresa);
              using (EntitiesRolesRptGeneral enti = new EntitiesRolesRptGeneral())
              {
                  var select = from a in enti.vwROL_Rpt017

                         where a.IdEmpresa==idEmpresa
                         && a.IdNomina_Tipo==idNomina
                         && a.pe_FechaIni >= f_inicio
                         && a.pe_FechaIni <= f_fin
                         && a.CodCtbteCble == CodCtbteCble
                               select a;

                  foreach (var item in select)
                  {
                      XROL_Rpt017_Info info = new XROL_Rpt017_Info();
                      
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdTipoCbte = item.IdTipoCbte;
                      info.IdCbteCble = item.IdCbteCble;
                      info.CodCtbteCble = item.CodCtbteCble;
                      info.IdPeriodo=item.IdPeriodo;
                      info.IdNomina_Tipo = item.IdNomina_Tipo;
                      info.secuencia = item.secuencia;
                      info.IdCtaCble = item.IdCtaCble;
                      info.dc_Valor = item.dc_Valor;
                      info.pc_Cuenta = item.pc_Cuenta;
                      info.dc_Observacion = item.dc_Observacion;
                      info.pe_FechaFin = item.pe_FechaFin;
                      info.pe_FechaIni = item.pe_FechaIni;

                      if (item.dc_Valor < 0)
                      {
                          info.credito = (decimal)item.dc_Valor * -1;
                      }
                      else
                      {
                          info.debito = (decimal)item.dc_Valor;
                      }
                      info.em_logo = info_empresa.em_logo;
                      info.RazonSocial = info_empresa.RazonSocial;
                      info.NombreComercial = info_empresa.NombreComercial;
                      Listado.Add(info);   
                  }

                  return Listado;
              }



          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              return new List<XROL_Rpt017_Info>();
          }
      }

    }
}
