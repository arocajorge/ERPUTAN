using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Contabilidad
{
   public  class XCONTA_Rpt001_Data
    {

       public List<XCONTA_Rpt001_Info> consultar_data(int IdEmpresa,DateTime FechaIni , DateTime FechaFin, string IdCentroCosto,int IdNivel_a_mostrar
           , int IdPunto_cargo_grupo
           , int IdPunto_cargo
           ,bool Mostrar_reg_Cero
           , bool MostrarCC,bool Considerar_Asiento_cierre_anual,string IdUsuario, ref String MensajeError)
       {
           try
           {

               List<XCONTA_Rpt001_Info> listadedatos = new List<XCONTA_Rpt001_Info>();

               FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
               FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

               using (EntitiesContabilidadRptGeneral BalanceGeneral = new EntitiesContabilidadRptGeneral())
               {

                   
                   BalanceGeneral.SetCommandTimeOut(30000);//timeout 3 minutos

                   IList<spCON_Mayorizar_x_fecha_corte_Result> listBalance =
                       BalanceGeneral.spCON_Mayorizar_x_fecha_corte(IdEmpresa, FechaIni, FechaFin, IdCentroCosto, IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_Cero, MostrarCC, Considerar_Asiento_cierre_anual,IdUsuario).Where(v => v.gc_estado_financiero == "BG" && v.IdNivelCta <= IdNivel_a_mostrar).ToList();


                   foreach (var item in listBalance)
                   {
                       XCONTA_Rpt001_Info itemInfo = new XCONTA_Rpt001_Info();
                       itemInfo.IdEmpresa = item.IdEmpresa;
                       itemInfo.IdCtaCble = item.IdCtaCble;
                       itemInfo.nom_cuenta = item.nom_cuenta;
                       itemInfo.IdNivelCta = item.IdNivelCta;
                       itemInfo.IdCtaCblePadre = item.IdCtaCblePadre;
                       itemInfo.GrupoCble = item.GrupoCble;
                       itemInfo.OrderGrupoCble = Convert.ToInt32(item.OrderGrupoCble);
                       itemInfo.gc_estado_financiero = item.gc_estado_financiero;

                       itemInfo.Saldo_Inicial = item.Saldo_Inicial;
                       itemInfo.Debito_Mes = item.Debito_Mes;
                       itemInfo.Credito_Mes = item.Credito_Mes;
                       itemInfo.Saldo = item.Saldo;

                       itemInfo.Saldo_inicial_x_Movi = item.Saldo_inicial_x_Movi;
                       itemInfo.Debito_Mes_x_Movi = item.Debito_Mes_x_Movi;
                       itemInfo.Credito_Mes_x_Movi= item.Credito_Mes_x_Movi;
                       itemInfo.Saldo_x_Movi = item.Saldo_x_Movi;



                       itemInfo.pc_EsMovimiento = item.pc_EsMovimiento;
                       itemInfo.nom_cuenta2 = item.IdCtaCble + " - " + item.nom_cuenta;

                       itemInfo.IdPuntoCargo = item.IdPunto_cargo;
                       itemInfo.IdPuntoCargo_Grupo = item.IdPunto_cargo_grupo;
                       itemInfo.IdCentroCosto = item.IdCentroCosto;
                       itemInfo.nom_PuntoCargo = item.nom_punto_cargo;
                       itemInfo.nom_PuntoCargo_Grupo = item.nom_punto_cargo_grupo;
                       itemInfo.nom_CentroCosto = item.nom_centro_costo;
                       itemInfo.nom_empresa = item.nom_empresa;



                       listadedatos.Add(itemInfo);

                   }
               }
               return listadedatos;
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
