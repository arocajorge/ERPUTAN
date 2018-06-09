using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.FJ.Bancos
{
  public  class XBAN_FJ_Rpt001_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XBAN_FJ_Rpt001_Info> Get_List_Conciliacion(int idEmpresa, DateTime Fecha_I, DateTime Fecha_F)
      {
          try
          {
              List<XBAN_FJ_Rpt001_Info> Lista = new List<XBAN_FJ_Rpt001_Info>();
              Cbt = empresaData.Get_Info_Empresa(idEmpresa);

              using (EntitiesBancos_Rpt_Fj Context = new EntitiesBancos_Rpt_Fj())
              {
                  var lst = from q in Context.vwBAN_FJ_Rpt001
                            where q.IdEmpresa == idEmpresa
                             && q.cb_Fecha >=Fecha_I
                             &&q.cb_Fecha<=Fecha_F
                            select q;

                  foreach (var item in lst)
                  {
                      XBAN_FJ_Rpt001_Info Info = new XBAN_FJ_Rpt001_Info();
                      Info.IdEmpresa = item.IdEmpresa;
                      Info.IdCbteCble = item.IdCbteCble;
                      Info.IdTipocbte = item.IdTipocbte;
                      Info.cb_FechaCheque = item.cb_FechaCheque;
                      Info.cb_Cheque = item.cb_Cheque;
                      Info.pe_nombreCompleto = item.pe_nombreCompleto;
                      Info.cb_Valor = item.cb_Valor;
                      Info.ca_descripcion = item.ca_descripcion;
                      Info.cb_Fecha = item.cb_Fecha;
                      Info.Nombre = item.Nombre;
                      Info.pe_nombreCompleto = item.pe_nombreCompleto.Trim();
                      Info.cb_Observacion = item.cb_Observacion;
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
