using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.CuentasxCobrar
{
  public  class cxc_cobro_tipo_motivo_Data
    {
      string mensaje = "";

      public List<cxc_cobro_tipo_motivo_Info> Get_List_cobro_tipo_motivo()
      {
          try
          {
              List<cxc_cobro_tipo_motivo_Info> lista = new List<cxc_cobro_tipo_motivo_Info>();
              EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();

              var select = from q in CxC.cxc_cobro_tipo_motivo select q;
              foreach (var info in select)
              {
                  cxc_cobro_tipo_motivo_Info addressG = new cxc_cobro_tipo_motivo_Info();
                  addressG.IdMotivo_tipo_cobro = info.IdMotivo_tipo_cobro;
                  addressG.nom_Motivo_tipo_cobro = info.nom_Motivo_tipo_cobro;

                  lista.Add(addressG);
              }
              return lista;
          }
          catch (Exception ex)
          {
              string mensaje = "";
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }

      }
    
  }
}
