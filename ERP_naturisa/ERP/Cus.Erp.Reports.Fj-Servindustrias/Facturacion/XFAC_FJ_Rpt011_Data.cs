using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Cus.Erp.Reports.FJ.Facturacion
{
  public  class XFAC_FJ_Rpt011_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XFAC_FJ_Rpt011_Info> Get_List_Conciliacion(int idEmpresa, int IdPeriodo)
      {
          try
          {
              List<XFAC_FJ_Rpt011_Info> Lista = new List<XFAC_FJ_Rpt011_Info>();
              Cbt = empresaData.Get_Info_Empresa(idEmpresa);
                   
              using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
              {
                  var lst = from q in Context.vwFAC_FJ_Rpt005
                            where q.IdEmpresa == idEmpresa
                            && q.IdPeriodo == IdPeriodo
                            select q;

                  foreach (var item in lst)
                  {
                      XFAC_FJ_Rpt011_Info Info = new XFAC_FJ_Rpt011_Info();
                      Info.IdEmpresa = item.IdEmpresa;
                      Info.IdEmpleado = item.IdEmpleado;
                      Info.IdActivoFijo = item.IdActivoFijo;
                      Info.IdTipoDepreciacion = item.IdTipoDepreciacion;
                      Info.CodActivoFijo = item.CodActivoFijo;
                      Info.Af_Nombre = item.Af_Nombre;
                      Info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                      Info.Valor = item.Valor;
                      Info.Horas_Trabajada_x_Af = item.Horas_Trabajada_x_Af;
                      Info.IdPeriodo = item.IdPeriodo;
                      Info.pe_nombreCompleto = item.pe_nombreCompleto;
                      Info.hora_trabajada = item.hora_trabajada;
                      Info.Centro_costo = item.Centro_costo;
                      Info.Valor = item.hora_trabajada;
                      Info.em_nombre = Cbt.em_nombre;
                      Info.em_logo = Cbt.em_logo;
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
