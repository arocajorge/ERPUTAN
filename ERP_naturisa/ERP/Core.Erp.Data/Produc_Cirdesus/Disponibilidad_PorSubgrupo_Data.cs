using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
  public  class Disponibilidad_PorSubgrupo_Data
  {
      string mensaje = "";
      public Boolean Disponibilidad_GT(int IdGrupo, int IdSubGrupo, int PP, int IdEtapa, int Disponibilidad)
      {
          try
          {
              using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
              {

                   var Q = from Dis in context.prd_PiezasEnEspera_Pendiente_PorSubgrupo
                            where Dis.IdGrupo == IdGrupo
                            && Dis.IdSubGrupo == IdSubGrupo
                            && Dis.IdProcesoProductivo==PP
                            && Dis.IdEtapa==IdEtapa
                            select Dis;

                   if (Q.ToList().Count == 0)
                   {
                       var address = new prd_PiezasEnEspera_Pendiente_PorSubgrupo();
                       address.IdGrupo = IdGrupo;
                       address.IdSubGrupo = IdSubGrupo;
                       address.IdProcesoProductivo = PP;

                       address.IdEtapa = IdEtapa;
                       address.Cant_Pieza_Pendie_Por_Procesar_PorSubgrupo = Disponibilidad;

                       context.prd_PiezasEnEspera_Pendiente_PorSubgrupo.Add(address);
                       context.SaveChanges();
                   }
                  return true;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }


    }
}
