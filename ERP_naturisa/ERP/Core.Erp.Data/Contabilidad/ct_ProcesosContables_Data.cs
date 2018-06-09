using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.SqlClient;
using System.Data.Entity.Validation;



namespace Core.Erp.Data.Contabilidad
{
   public class ct_ProcesosContables_Data
    {
       string mensaje = "";
       /// <summary>
       /// 
       /// </summary>
       /// <param name="IdEmpresa"></param>
       /// <param name="FechaIni"></param>
       /// <param name="FechaFin"></param>
       /// <returns></returns>
       public List<ct_Balance_x_Estado_Resultado_x_Usuario_Info> Get_Estado_Resultado(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string IdUsuario)
       { 
            try
            {
                 List<ct_Balance_x_Estado_Resultado_x_Usuario_Info> Lista = new List<ct_Balance_x_Estado_Resultado_x_Usuario_Info>();


                 using (EntitiesDBConta context = new EntitiesDBConta())
                 {
                     //context.SetCommandTimeOut(3000);



                     IList<spCON_Mayorizar_x_fecha_corte_Result> listBalance =
                context.spCON_Mayorizar_x_fecha_corte(IdEmpresa, FechaIni, FechaFin, "", 0, 0, false, false,true,IdUsuario).ToList();




                     var Querry_x_ER = from C in listBalance
                                       where C.gc_estado_financiero == "ER"
                                       && C.pc_EsMovimiento == "S"
                                       select C;


                     foreach (var item in Querry_x_ER)
                     {
                         ct_Balance_x_Estado_Resultado_x_Usuario_Info Info = new ct_Balance_x_Estado_Resultado_x_Usuario_Info();


                         Info.IdEmpresa = item.IdEmpresa;
                         Info.IdCtaCble = item.IdCtaCble;
                         Info.nom_cuenta = item.nom_cuenta;
                         Info.IdNivelCta = item.IdNivelCta;
                         Info.GrupoCble = item.GrupoCble;
                         Info.OrderGrupoCble = item.OrderGrupoCble;
                         Info.gc_estado_financiero = item.gc_estado_financiero;
                         Info.IdCtaCblePadre = item.IdCtaCblePadre;
                         Info.Saldo_Inicial = item.Saldo_Inicial;
                         Info.Debito_Mes = item.Debito_Mes;
                         Info.Credito_Mes = item.Credito_Mes;
                         Info.Saldo = item.Saldo;
                         Info.pc_EsMovimiento = item.pc_EsMovimiento;
                         Info.gc_signo_operacion = item.gc_signo_operacion;
                         Info.CtaUtilidad = item.CtaUtilidad;
                         Info.Saldo_inicial_x_Movi = item.Saldo_inicial_x_Movi;
                         Info.Debito_Mes_x_Movi = item.Debito_Mes_x_Movi;
                         Info.Credito_Mes_x_Movi = item.Credito_Mes_x_Movi;
                         Info.Saldo_x_Movi = item.Saldo_x_Movi;
                         Info.IdCentroCosto = item.IdCentroCosto;
                         Info.nom_centro_costo = item.nom_centro_costo;
                         Info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                         Info.nom_punto_cargo_grupo = item.nom_punto_cargo_grupo;
                         Info.IdPunto_cargo = item.IdPunto_cargo;
                         Info.nom_punto_cargo = item.nom_punto_cargo;
                         Info.nom_empresa = item.nom_empresa;
                         Info.IdGrupo_Mayor = item.IdGrupo_Mayor;
                         Info.nom_grupo_mayor = item.nom_grupo_mayor;
                         Info.order_grupo_mayor = item.order_grupo_mayor;
                         Info.orden_fila = item.orden_fila;
                         Info.Reg_x_CC = item.Reg_x_CC;
                         Info.Saldo_Inicial_deudor = item.Saldo_Inicial_deudor;
                         Info.Saldo_Inicial_acreedor = item.Saldo_Inicial_acreedor;
                         Info.Saldo_fin_deudor = item.Saldo_fin_deudor;
                         Info.Saldo_fin_acreedor = item.Saldo_fin_acreedor;
                         Info.pc_clave_corta = item.pc_clave_corta;
                         Lista.Add(Info);
                     }

                     return Lista;

                 }
                
            }
            catch (Exception ex)
            {
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
