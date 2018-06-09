using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt013_Data
    {
        public List<XCONTA_Rpt013_Info> consultar_data(int IdEmpresa, int IdPeriodo_Actual, string IdCentroCosto, int IdNivel_a_mostrar
    , int IdPunto_cargo_grupo
    , int IdPunto_cargo
    , bool Mostrar_reg_Cero
    , bool MostrarCC,string IdUsuario, ref String MensajeError)
        {
            try
            {
                ct_Plancta_Data Plan_cta_data = new ct_Plancta_Data();
                List<ct_Plancta_Info> list_plan_cta = new List<ct_Plancta_Info>();

                ct_Periodo_Data Periodo_data = new ct_Periodo_Data();
                ct_Periodo_Info Periodo_Info_Actual = new ct_Periodo_Info();
                ct_Periodo_Info Periodo_Info_Anterior = new ct_Periodo_Info();
                List<XCONTA_Rpt002_Info> list_data_Periodo_Actual = new List<XCONTA_Rpt002_Info>();
                List<XCONTA_Rpt002_Info> list_data_Periodo_Anterior = new List<XCONTA_Rpt002_Info>();

                Periodo_Info_Actual = Periodo_data.Get_Info_Periodo(IdEmpresa, IdPeriodo_Actual, ref MensajeError);
                Periodo_Info_Anterior = Periodo_data.Get_Info_PeriodoAnterior(IdEmpresa, IdPeriodo_Actual, ref MensajeError);

                list_data_Periodo_Actual = Get_data_Mayorizado_x_fecha(Periodo_Info_Actual.IdEmpresa, Periodo_Info_Actual.pe_FechaIni, Periodo_Info_Actual.pe_FechaFin, IdCentroCosto, IdNivel_a_mostrar
                 , IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_Cero,MostrarCC,IdUsuario, ref MensajeError);

                list_data_Periodo_Anterior = Get_data_Mayorizado_x_fecha(Periodo_Info_Anterior.IdEmpresa, Periodo_Info_Anterior.pe_FechaIni, Periodo_Info_Anterior.pe_FechaFin, IdCentroCosto, IdNivel_a_mostrar
                , IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_Cero,MostrarCC,IdUsuario, ref MensajeError);

                foreach (var item in list_data_Periodo_Actual.Where(q => q.gc_estado_financiero == "BG").ToList())
                {
                    ct_Plancta_Info _PlantaCtaInfo = new ct_Plancta_Info();

                    _PlantaCtaInfo.IdEmpresa = item.IdEmpresa;
                    _PlantaCtaInfo.IdCtaCble = item.IdCtaCble;
                    _PlantaCtaInfo.pc_Cuenta = item.nom_cuenta;
                    _PlantaCtaInfo.IdCtaCblePadre = (item.IdCtaCblePadre == null) ? "" : item.IdCtaCblePadre;
                    _PlantaCtaInfo.IdNivelCta = item.IdNivelCta;
                    _PlantaCtaInfo.pc_EsMovimiento = item.pc_EsMovimiento;
                    _PlantaCtaInfo.Nom_GrupoCble = item.gc_GrupoCble;
                    _PlantaCtaInfo.gc_estado_financiero = item.gc_estado_financiero;
                    _PlantaCtaInfo.OrderGrupoCble = item.OrderGrupoCble;
                    _PlantaCtaInfo.orden = item.order_grupo_mayor == null ? 0 : (int)item.order_grupo_mayor;
                    _PlantaCtaInfo.IdGrupo_Mayor = item.IdGrupo_Mayor;
                    _PlantaCtaInfo.nom_grupo_mayor = item.nom_grupo_mayor;
                    _PlantaCtaInfo.Nom_GrupoCble = item.GrupoCble;
                    list_plan_cta.Add(_PlantaCtaInfo);
                }
                /*list_plan_cta = Plan_cta_data.Get_Plancta_x_Tipo_Balance(IdEmpresa,"BG", ref MensajeError);*/

                var ListaCtasCbles_x_cbtes_con_movi = from plancta in list_plan_cta
                                                      join lstPeriodo_act in list_data_Periodo_Actual
                                                      on new { plancta.IdEmpresa, plancta.IdCtaCble } equals new { lstPeriodo_act.IdEmpresa, lstPeriodo_act.IdCtaCble } into p_1
                                                      from sublist_data_Periodo_Actual in p_1.DefaultIfEmpty()
                                                      join lstPeriod_ant in list_data_Periodo_Anterior
                                                      on new { plancta.IdEmpresa, plancta.IdCtaCble } equals new { lstPeriod_ant.IdEmpresa, lstPeriod_ant.IdCtaCble } into p_2
                                                      from sublist_data_Periodo_Anterior in p_2.DefaultIfEmpty()
                                                      select new
                                                      {
                                                          plancta.IdEmpresa,
                                                          plancta.IdCtaCble,
                                                          plancta.IdCtaCblePadre,
                                                          Saldo_Periodo_act = sublist_data_Periodo_Actual == null ? 0 : sublist_data_Periodo_Actual.Saldo,
                                                          Saldo_Periodo_ant = sublist_data_Periodo_Anterior == null ? 0 : sublist_data_Periodo_Anterior.Saldo,
                                                          plancta.IdGrupoCble,
                                                          plancta.IdNivelCta,
                                                          plancta.pc_EsMovimiento,
                                                          plancta.pc_Cuenta,
                                                          nom_empresa = sublist_data_Periodo_Actual == null ? "" : sublist_data_Periodo_Actual.nom_empresa,
                                                          nom_CentroCosto = sublist_data_Periodo_Actual == null ? "" : sublist_data_Periodo_Actual.nom_CentroCosto,
                                                          nom_PuntoCargo = sublist_data_Periodo_Actual == null ? "" : sublist_data_Periodo_Actual.nom_PuntoCargo,
                                                          nom_PuntoCargo_Grupo = sublist_data_Periodo_Actual == null ? "" : sublist_data_Periodo_Actual.nom_PuntoCargo_Grupo,
                                                          GrupoCble = plancta.Nom_GrupoCble,
                                                          nom_Periodo_ant = Periodo_Info_Anterior.nom_periodo,
                                                          nom_Periodo_act = Periodo_Info_Actual.nom_periodo,

                                                          IdGrupo_Mayor = plancta.IdGrupo_Mayor,
                                                          nom_grupo_mayor = plancta.nom_grupo_mayor,
                                                          order_grupo_mayor = plancta.orden
                                                      };

                List<XCONTA_Rpt013_Info> listadedatos = new List<XCONTA_Rpt013_Info>();

                foreach (var item_data in ListaCtasCbles_x_cbtes_con_movi)
                {
                    XCONTA_Rpt013_Info Info = new XCONTA_Rpt013_Info();

                    Info.IdEmpresa = item_data.IdEmpresa;
                    Info.gc_estado_financiero = "";
                    Info.GrupoCble = item_data.GrupoCble;
                    Info.IdCentroCosto = IdCentroCosto;
                    Info.IdCtaCble = item_data.IdCtaCble;
                    Info.IdCtaCblePadre = item_data.IdCtaCblePadre;
                    Info.IdNivelCta = item_data.IdNivelCta;
                    Info.IdPuntoCargo = IdPunto_cargo;
                    Info.IdPuntoCargo_Grupo = IdPunto_cargo_grupo;
                    Info.nom_CentroCosto = item_data.nom_CentroCosto;
                    Info.nom_cuenta = item_data.pc_Cuenta;
                    Info.nom_empresa = item_data.nom_empresa;
                    Info.nom_PuntoCargo = item_data.nom_PuntoCargo;
                    Info.nom_PuntoCargo_Grupo = item_data.nom_PuntoCargo_Grupo;
                    Info.OrderGrupoCble = 0;
                    Info.pc_EsMovimiento = item_data.pc_EsMovimiento;
                    Info.Porcen_Periodo1 = 0;
                    Info.Porcen_Periodo2 = 0;
                    Info.Porcen_Variacion = 0;
                    Info.Saldo_Periodo_act = item_data.Saldo_Periodo_act;
                    Info.Saldo_Periodo_ant = item_data.Saldo_Periodo_ant;
                    Info.Saldo_x_Movi_Periodo_act = 0;
                    Info.Saldo_x_Movi_Periodo_ant = 0;
                    Info.Variacion = item_data.Saldo_Periodo_act - item_data.Saldo_Periodo_ant;
                    Info.nom_Periodo_act = item_data.nom_Periodo_act;
                    Info.nom_Periodo_ant = item_data.nom_Periodo_ant;

                    Info.IdGrupo_Mayor = item_data.IdGrupo_Mayor;
                    Info.nom_grupo_mayor = item_data.nom_grupo_mayor;
                    Info.order_grupo_mayor = item_data.order_grupo_mayor;
                    listadedatos.Add(Info);
                }

                if (!Mostrar_reg_Cero)
                {
                    listadedatos = listadedatos.Where(q => Math.Abs((double)q.Saldo_Periodo_act) + Math.Abs((double)q.Saldo_Periodo_ant) != 0).ToList();
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




        public List<XCONTA_Rpt002_Info> Get_data_Mayorizado_x_fecha(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string IdCentroCosto, int IdNivel_a_mostrar
             , int IdPunto_cargo_grupo
           , int IdPunto_cargo
            , bool Mostrar_reg_en_cero
           , bool MostrarCC,string IdUsuario, ref String MensajeError)
        {
            try
            {
                List<XCONTA_Rpt002_Info> listadedatos = new List<XCONTA_Rpt002_Info>();
                using (EntitiesContabilidadRptGeneral Estado_Resultado = new EntitiesContabilidadRptGeneral())
                {


                    Estado_Resultado.SetCommandTimeOut(30000);//timeout 3 minutos

                    IList<spCON_Mayorizar_x_fecha_corte_Result> listBalance =
                    Estado_Resultado.spCON_Mayorizar_x_fecha_corte(IdEmpresa, FechaIni, FechaFin, IdCentroCosto, IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_en_cero, MostrarCC, true, IdUsuario).ToList();

                    var Querry_x_ER = from C in listBalance
                                      where C.gc_estado_financiero == "BG"
                                      && C.IdNivelCta <= IdNivel_a_mostrar
                                      select C;

                    foreach (var item in Querry_x_ER)
                    {
                        XCONTA_Rpt002_Info itemInfo = new XCONTA_Rpt002_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdCtaCble = item.IdCtaCble;
                        itemInfo.nom_cuenta = item.nom_cuenta;
                        itemInfo.nom_cuenta2 = item.IdCtaCble + " " + item.nom_cuenta;
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
                        itemInfo.Credito_Mes_x_Movi = item.Credito_Mes_x_Movi;
                        itemInfo.Saldo_x_Movi = item.Saldo_x_Movi;



                        itemInfo.pc_EsMovimiento = item.pc_EsMovimiento;
                        itemInfo.GrupoCble = item.GrupoCble;
                        //item.OrderGrupoCble + " " + item.GrupoCble;
                        itemInfo.gc_signo_operacion = item.gc_signo_operacion;


                        itemInfo.IdPuntoCargo = item.IdPunto_cargo;
                        itemInfo.IdPuntoCargo_Grupo = item.IdPunto_cargo_grupo;
                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.nom_PuntoCargo = item.nom_punto_cargo;
                        itemInfo.nom_PuntoCargo_Grupo = item.nom_punto_cargo_grupo;
                        itemInfo.nom_CentroCosto = item.nom_centro_costo;
                        itemInfo.nom_empresa = item.nom_empresa;

                        itemInfo.IdGrupo_Mayor = item.IdGrupo_Mayor;
                        itemInfo.nom_grupo_mayor = item.nom_grupo_mayor;
                        itemInfo.order_grupo_mayor = item.order_grupo_mayor;

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
