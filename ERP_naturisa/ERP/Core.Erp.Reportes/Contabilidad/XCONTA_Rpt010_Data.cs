using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Contabilidad
{
  public  class XCONTA_Rpt010_Data
    {


      public List<XCONTA_Rpt010_Info> Get_list_Data(int IdEmpresa, DateTime FechaIni,DateTime FechaFin,int IdPunto_cargo_grupo,bool Mostrar_Reg_Cero)
      {
          try
          {
              List<XCONTA_Rpt010_Info> Lista = new List<XCONTA_Rpt010_Info>();

              FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
              FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

              using (EntitiesContabilidadRptGeneral Context = new EntitiesContabilidadRptGeneral())
              {

                  IList<spCONTA_Rpt010_Result> listBalance =
                       Context.spCONTA_Rpt010(IdEmpresa, FechaIni, FechaFin, IdPunto_cargo_grupo, Mostrar_Reg_Cero).ToList();


                  foreach (var item in listBalance)
                  {
                      XCONTA_Rpt010_Info info = new XCONTA_Rpt010_Info();

                      info.IdEmpresa = item.IdEmpresa;
                      info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                      info.IdPunto_cargo = item.IdPunto_cargo;
                      info.IdCtaCble = item.IdCtaCble;
                      info.nom_Punto_cargo = item.nom_Punto_cargo;
                      info.Saldo_Anterior = item.Saldo_Anterior;
                      info.Debito = item.Debito;
                      info.Credito = item.Credito;
                      info.Saldo_Total = item.Saldo_Total;
                      info.nom_empresa = item.nom_empresa;
                      info.nom_punto_cargo_grupo = item.nom_punto_cargo_grupo;
                      info.Anio = FechaIni.Year;

                      Lista.Add(info);
                  }
              }

              return Lista;
          }
          catch (Exception ex)
          {
              string mensaje = "";
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }
    }
}
