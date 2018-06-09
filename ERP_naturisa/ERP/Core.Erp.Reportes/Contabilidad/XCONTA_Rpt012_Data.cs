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
  public  class XCONTA_Rpt012_Data
    {
        #region Variables
        List<XCONTA_Rpt002_Info> list_data_Periodo_data = new List<XCONTA_Rpt002_Info>();
        List<XCONTA_Rpt002_Info> list_data_Periodo_1 = new List<XCONTA_Rpt002_Info>();
        List<XCONTA_Rpt002_Info> list_data_Periodo_2 = new List<XCONTA_Rpt002_Info>();
        List<XCONTA_Rpt002_Info> list_data_Periodo_3 = new List<XCONTA_Rpt002_Info>();
        List<XCONTA_Rpt002_Info> list_data_Periodo_4 = new List<XCONTA_Rpt002_Info>();
        List<XCONTA_Rpt002_Info> list_data_Periodo_5 = new List<XCONTA_Rpt002_Info>();
        List<XCONTA_Rpt002_Info> list_data_Periodo_6 = new List<XCONTA_Rpt002_Info>();
        List<XCONTA_Rpt002_Info> list_data_Periodo_7 = new List<XCONTA_Rpt002_Info>();
        List<XCONTA_Rpt002_Info> list_data_Periodo_8 = new List<XCONTA_Rpt002_Info>();
        List<XCONTA_Rpt002_Info> list_data_Periodo_9 = new List<XCONTA_Rpt002_Info>();
        List<XCONTA_Rpt002_Info> list_data_Periodo_10 = new List<XCONTA_Rpt002_Info>();
        List<XCONTA_Rpt002_Info> list_data_Periodo_11 = new List<XCONTA_Rpt002_Info>();
        List<XCONTA_Rpt002_Info> list_data_Periodo_12 = new List<XCONTA_Rpt002_Info>();
        List<string> Periodos = new List<string>();

        string nom_periodo_1 = "";
        string nom_periodo_2 = "";
        string nom_periodo_3 = "";
        string nom_periodo_4 = "";
        string nom_periodo_5 = "";
        string nom_periodo_6 = "";
        string nom_periodo_7 = "";
        string nom_periodo_8 = "";
        string nom_periodo_9 = "";
        string nom_periodo_10 = "";
        string nom_periodo_11 = "";
        string nom_periodo_12 = "";

        int IdPeriodo_1 = 0;
        int IdPeriodo_2 = 0;
        int IdPeriodo_3 = 0;
        int IdPeriodo_4 = 0;
        int IdPeriodo_5 = 0;
        int IdPeriodo_6 = 0;
        int IdPeriodo_7 = 0;
        int IdPeriodo_8 = 0;
        int IdPeriodo_9 = 0;
        int IdPeriodo_10 = 0;
        int IdPeriodo_11 = 0;
        int IdPeriodo_12 = 0;
        #endregion
    public List<XCONTA_Rpt012_Info> consultar_data(int IdEmpresa, List<ct_Periodo_Info> listPeriodo , string IdCentroCosto, int IdNivel_a_mostrar
    , int IdPunto_cargo_grupo
    , int IdPunto_cargo
    , bool Mostrar_reg_Cero
    , bool MostrarCC,string IdUsuario, ref String MensajeError)
        {
            try
            {
                ct_Plancta_Data Plan_cta_data = new ct_Plancta_Data();
                List<ct_Plancta_Info> list_plan_cta = new List<ct_Plancta_Info>();

                
                int contador = 1;
                int IdPeriodo_max = 0;
                tb_Mes_Data BusMes = new tb_Mes_Data();
                List<tb_Mes_info> listMeses = new List<tb_Mes_info>();
                listMeses = BusMes.Get_List_Mes();
                string nMes = "";
                string Nom_Periodo = "";

                IdPeriodo_max = listPeriodo.Max(q => q.IdPeriodo);
                foreach (var itemPeriodo in listPeriodo)
                {
                    list_data_Periodo_data = Get_data_Mayorizado_x_fecha(itemPeriodo.IdEmpresa, itemPeriodo.pe_FechaIni, itemPeriodo.pe_FechaFin, IdCentroCosto, IdNivel_a_mostrar, IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_Cero,MostrarCC,IdUsuario, ref MensajeError);
                    nMes=listMeses.FirstOrDefault(v => v.idMes == itemPeriodo.pe_mes).nemonico;
                    Nom_Periodo = itemPeriodo.IdanioFiscal.ToString() + "-" + nMes;
                    switch (contador)
                    {
                        case 1: list_data_Periodo_1 = list_data_Periodo_data;
                            IdPeriodo_1 = itemPeriodo.IdPeriodo;
                            nom_periodo_1 = Nom_Periodo;
                            break;
                        case 2: list_data_Periodo_2 = list_data_Periodo_data;
                            IdPeriodo_2 = itemPeriodo.IdPeriodo;
                            nom_periodo_2 = Nom_Periodo;
                            break;
                        case 3: list_data_Periodo_3 = list_data_Periodo_data;
                            IdPeriodo_3 = itemPeriodo.IdPeriodo;
                            nom_periodo_3 = Nom_Periodo;
                            break;
                        case 4: list_data_Periodo_4 = list_data_Periodo_data;
                            IdPeriodo_4 = itemPeriodo.IdPeriodo;
                            nom_periodo_4 = Nom_Periodo;
                            break;
                        case 5: list_data_Periodo_5 = list_data_Periodo_data;
                            IdPeriodo_5 = itemPeriodo.IdPeriodo;
                            nom_periodo_5 = Nom_Periodo;
                            break;
                        case 6: list_data_Periodo_6 = list_data_Periodo_data;
                            IdPeriodo_6 = itemPeriodo.IdPeriodo;
                            nom_periodo_6 = Nom_Periodo;
                            break;
                        case 7: list_data_Periodo_7 = list_data_Periodo_data;
                            IdPeriodo_7 = itemPeriodo.IdPeriodo;
                            nom_periodo_7 = Nom_Periodo;
                            break;
                        case 8: list_data_Periodo_8 = list_data_Periodo_data;
                            IdPeriodo_8 = itemPeriodo.IdPeriodo;
                            nom_periodo_8 = Nom_Periodo;
                            break;
                        case 9: list_data_Periodo_9 = list_data_Periodo_data;
                            IdPeriodo_9 = itemPeriodo.IdPeriodo;
                            nom_periodo_9 = Nom_Periodo;
                            break;
                        case 10: list_data_Periodo_10 = list_data_Periodo_data;
                            IdPeriodo_10 = itemPeriodo.IdPeriodo;
                            nom_periodo_10 = Nom_Periodo;
                            break;
                        case 11: list_data_Periodo_11 = list_data_Periodo_data;
                            IdPeriodo_11 = itemPeriodo.IdPeriodo;
                            nom_periodo_11 = Nom_Periodo;
                            break;
                        case 12: list_data_Periodo_12 = list_data_Periodo_data;
                            IdPeriodo_12 = itemPeriodo.IdPeriodo;
                            nom_periodo_12 = Nom_Periodo;
                            break;
                    }
                    if (list_data_Periodo_data.Count != 0)
                    {
                        Periodos.Add(Nom_Periodo);
                        contador++;
                    }
                }
                List<XCONTA_Rpt002_Info> list_data_Periodo_Actual = new List<XCONTA_Rpt002_Info>();
                ct_Periodo_Data Periodo_data = new ct_Periodo_Data();
                ct_Periodo_Info Periodo_Info_Actual = new ct_Periodo_Info();
                Periodo_Info_Actual = Periodo_data.Get_Info_Periodo(IdEmpresa, IdPeriodo_max, ref MensajeError);

                list_data_Periodo_Actual = Get_data_Mayorizado_x_fecha(Periodo_Info_Actual.IdEmpresa, Periodo_Info_Actual.pe_FechaIni, Periodo_Info_Actual.pe_FechaFin, IdCentroCosto, IdNivel_a_mostrar
               , IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_Cero, MostrarCC,IdUsuario, ref MensajeError);

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

                //=====================================================

                var ListaCtasCbles_x_cbtes_con_movi = from plancta in list_plan_cta
                                                      join Data_x_Periodo_1 in list_data_Periodo_1
                                                      on new { plancta.IdEmpresa, plancta.IdCtaCble } equals new { Data_x_Periodo_1.IdEmpresa, Data_x_Periodo_1.IdCtaCble } into ps1
                                                      from sub_Data_x_Periodo_1 in ps1.DefaultIfEmpty()

                                                      join Data_x_Periodo_2 in list_data_Periodo_2
                                                      on new { plancta.IdEmpresa, plancta.IdCtaCble } equals new { Data_x_Periodo_2.IdEmpresa, Data_x_Periodo_2.IdCtaCble } into ps2
                                                      from sub_Data_x_Periodo_2 in ps2.DefaultIfEmpty()

                                                      join Data_x_Periodo_3 in list_data_Periodo_3
                                                      on new { plancta.IdEmpresa, plancta.IdCtaCble } equals new { Data_x_Periodo_3.IdEmpresa, Data_x_Periodo_3.IdCtaCble } into ps3
                                                      from sub_Data_x_Periodo_3 in ps3.DefaultIfEmpty()

                                                      join Data_x_Periodo_4 in list_data_Periodo_4
                                                      on new { plancta.IdEmpresa, plancta.IdCtaCble } equals new { Data_x_Periodo_4.IdEmpresa, Data_x_Periodo_4.IdCtaCble } into ps4
                                                      from sub_Data_x_Periodo_4 in ps4.DefaultIfEmpty()

                                                      join Data_x_Periodo_5 in list_data_Periodo_5
                                                      on new { plancta.IdEmpresa, plancta.IdCtaCble } equals new { Data_x_Periodo_5.IdEmpresa, Data_x_Periodo_5.IdCtaCble } into ps5
                                                      from sub_Data_x_Periodo_5 in ps5.DefaultIfEmpty()

                                                      join Data_x_Periodo_6 in list_data_Periodo_6
                                                      on new { plancta.IdEmpresa, plancta.IdCtaCble } equals new { Data_x_Periodo_6.IdEmpresa, Data_x_Periodo_6.IdCtaCble } into ps6
                                                      from sub_Data_x_Periodo_6 in ps6.DefaultIfEmpty()

                                                      join Data_x_Periodo_7 in list_data_Periodo_7
                                                      on new { plancta.IdEmpresa, plancta.IdCtaCble } equals new { Data_x_Periodo_7.IdEmpresa, Data_x_Periodo_7.IdCtaCble } into ps7
                                                      from sub_Data_x_Periodo_7 in ps7.DefaultIfEmpty()

                                                      join Data_x_Periodo_8 in list_data_Periodo_8
                                                      on new { plancta.IdEmpresa, plancta.IdCtaCble } equals new { Data_x_Periodo_8.IdEmpresa, Data_x_Periodo_8.IdCtaCble } into ps8
                                                      from sub_Data_x_Periodo_8 in ps8.DefaultIfEmpty()

                                                      join Data_x_Periodo_9 in list_data_Periodo_9
                                                      on new { plancta.IdEmpresa, plancta.IdCtaCble } equals new { Data_x_Periodo_9.IdEmpresa, Data_x_Periodo_9.IdCtaCble } into ps9
                                                      from sub_Data_x_Periodo_9 in ps9.DefaultIfEmpty()

                                                      join Data_x_Periodo_10 in list_data_Periodo_10
                                                      on new { plancta.IdEmpresa, plancta.IdCtaCble } equals new { Data_x_Periodo_10.IdEmpresa, Data_x_Periodo_10.IdCtaCble } into ps10
                                                      from sub_Data_x_Periodo_10 in ps10.DefaultIfEmpty()

                                                      join Data_x_Periodo_11 in list_data_Periodo_11
                                                      on new { plancta.IdEmpresa, plancta.IdCtaCble } equals new { Data_x_Periodo_11.IdEmpresa, Data_x_Periodo_11.IdCtaCble } into ps11
                                                      from sub_Data_x_Periodo_11 in ps11.DefaultIfEmpty()

                                                      join Data_x_Periodo_12 in list_data_Periodo_12
                                                      on new { plancta.IdEmpresa, plancta.IdCtaCble } equals new { Data_x_Periodo_12.IdEmpresa, Data_x_Periodo_12.IdCtaCble } into ps12
                                                      from sub_Data_x_Periodo_12 in ps12.DefaultIfEmpty()

                                                      orderby plancta.IdCtaCble

                                                      select new
                                                      {
                                                          plancta.IdEmpresa,
                                                          plancta.IdCtaCble,
                                                          plancta.IdCtaCblePadre,
                                                          plancta.Nom_GrupoCble,
                                                          Saldo_Periodo_0_SI = (sub_Data_x_Periodo_1 == null ? 0 : sub_Data_x_Periodo_1.Saldo_Inicial),
                                                          Saldo_Periodo_1 = (sub_Data_x_Periodo_1 == null ? 0 : sub_Data_x_Periodo_1.Saldo),
                                                          Saldo_Periodo_2 = (sub_Data_x_Periodo_2 == null ? 0 : sub_Data_x_Periodo_2.Saldo),

                                                          Saldo_Periodo_3 = (sub_Data_x_Periodo_3 == null ? 0 : sub_Data_x_Periodo_3.Saldo),
                                                          Saldo_Periodo_4 = (sub_Data_x_Periodo_4 == null ? 0 : sub_Data_x_Periodo_4.Saldo),
                                                          Saldo_Periodo_5 = (sub_Data_x_Periodo_5 == null ? 0 : sub_Data_x_Periodo_5.Saldo),
                                                          Saldo_Periodo_6 = (sub_Data_x_Periodo_6 == null ? 0 : sub_Data_x_Periodo_6.Saldo),
                                                          Saldo_Periodo_7 = (sub_Data_x_Periodo_7 == null ? 0 : sub_Data_x_Periodo_7.Saldo),
                                                          Saldo_Periodo_8 = (sub_Data_x_Periodo_8 == null ? 0 : sub_Data_x_Periodo_8.Saldo),
                                                          Saldo_Periodo_9 = (sub_Data_x_Periodo_9 == null ? 0 : sub_Data_x_Periodo_9.Saldo),
                                                          Saldo_Periodo_10 = (sub_Data_x_Periodo_10 == null ? 0 : sub_Data_x_Periodo_10.Saldo),
                                                          Saldo_Periodo_11 = (sub_Data_x_Periodo_11 == null ? 0 : sub_Data_x_Periodo_11.Saldo),
                                                          Saldo_Periodo_12= (sub_Data_x_Periodo_12 == null ? 0 : sub_Data_x_Periodo_12.Saldo),

                                                          nom_periodo_1 = nom_periodo_1,
                                                          nom_periodo_2 = nom_periodo_2,
                                                          nom_periodo_3 = nom_periodo_3,
                                                          nom_periodo_4 = nom_periodo_4,
                                                          nom_periodo_5 = nom_periodo_5,
                                                          nom_periodo_6 = nom_periodo_6,
                                                          nom_periodo_7 = nom_periodo_7,
                                                          nom_periodo_8 = nom_periodo_8,
                                                          nom_periodo_9 = nom_periodo_9,
                                                          nom_periodo_10 = nom_periodo_10,
                                                          nom_periodo_11 = nom_periodo_11,
                                                          nom_periodo_12 = nom_periodo_12,

                                                          Idperiodo_1 = IdPeriodo_1,
                                                          Idperiodo_2 = IdPeriodo_2,
                                                          Idperiodo_3 = IdPeriodo_3,
                                                          Idperiodo_4 = IdPeriodo_4,
                                                          Idperiodo_5 = IdPeriodo_5,
                                                          Idperiodo_6 = IdPeriodo_6,
                                                          Idperiodo_7 = IdPeriodo_7,
                                                          Idperiodo_8 = IdPeriodo_8,
                                                          Idperiodo_9 = IdPeriodo_9,
                                                          Idperiodo_10 = IdPeriodo_10,
                                                          Idperiodo_11 = IdPeriodo_11,
                                                          Idperiodo_12 = IdPeriodo_12,

                                                          plancta.IdGrupoCble,
                                                          plancta.IdNivelCta,
                                                          plancta.pc_EsMovimiento,
                                                          plancta.pc_Cuenta,
                                                          plancta.gc_estado_financiero,
                                                          plancta.OrderGrupoCble,
                                                         
                                                          
                                                      };
                string nom_Periodos = "";
                foreach (var item in Periodos)
                {
                    if (nom_Periodos=="")
                    {
                        nom_Periodos = item;    
                    }else
                        nom_Periodos += " / "+item;
                }

                List<XCONTA_Rpt012_Info> listadedatos = new List<XCONTA_Rpt012_Info>();

                foreach (var item_data in ListaCtasCbles_x_cbtes_con_movi)
                {
                    XCONTA_Rpt012_Info Info = new XCONTA_Rpt012_Info();

                    Info.IdEmpresa = item_data.IdEmpresa;
                    Info.gc_estado_financiero = "";
                    Info.GrupoCble = item_data.Nom_GrupoCble;
                    Info.IdCentroCosto = IdCentroCosto;
                    Info.IdCtaCble = item_data.IdCtaCble;
                    Info.IdCtaCblePadre = item_data.IdCtaCblePadre;
                    Info.IdNivelCta = item_data.IdNivelCta;
                    Info.IdPuntoCargo = IdPunto_cargo;
                    Info.IdPuntoCargo_Grupo = IdPunto_cargo_grupo;
                    Info.gc_estado_financiero = item_data.gc_estado_financiero;
                    Info.Periodos_mostrados = nom_Periodos;
                    
                    Info.nom_cuenta = item_data.pc_Cuenta;
                    

                    Info.OrderGrupoCble = item_data.OrderGrupoCble;
                    Info.pc_EsMovimiento = item_data.pc_EsMovimiento;

                    
                    Info.Saldo_Periodo_0_SI = item_data.Saldo_Periodo_0_SI;
                    Info.Saldo_Periodo_1 = item_data.Saldo_Periodo_1;
                    Info.Saldo_Periodo_2 = item_data.Saldo_Periodo_2;
                    Info.Saldo_Periodo_3 = item_data.Saldo_Periodo_3;
                    Info.Saldo_Periodo_4 = item_data.Saldo_Periodo_4;
                    Info.Saldo_Periodo_5 = item_data.Saldo_Periodo_5;
                    Info.Saldo_Periodo_6 = item_data.Saldo_Periodo_6;
                    Info.Saldo_Periodo_7 = item_data.Saldo_Periodo_7;
                    Info.Saldo_Periodo_8 = item_data.Saldo_Periodo_8;
                    Info.Saldo_Periodo_9 = item_data.Saldo_Periodo_9;
                    Info.Saldo_Periodo_10 = item_data.Saldo_Periodo_10;
                    Info.Saldo_Periodo_11 = item_data.Saldo_Periodo_11;
                    Info.Saldo_Periodo_12 = item_data.Saldo_Periodo_12;


                    Info.nom_Periodo_1 = item_data.nom_periodo_1;
                    Info.nom_Periodo_2 = item_data.nom_periodo_2;
                    Info.nom_Periodo_3 = item_data.nom_periodo_3;
                    Info.nom_Periodo_4 = item_data.nom_periodo_4;
                    Info.nom_Periodo_5 = item_data.nom_periodo_5;
                    Info.nom_Periodo_6 = item_data.nom_periodo_6;
                    Info.nom_Periodo_7 = item_data.nom_periodo_7;
                    Info.nom_Periodo_8 = item_data.nom_periodo_8;
                    Info.nom_Periodo_9 = item_data.nom_periodo_9;
                    Info.nom_Periodo_10 = item_data.nom_periodo_10;
                    Info.nom_Periodo_11 = item_data.nom_periodo_11;
                    Info.nom_Periodo_12 = item_data.nom_periodo_12;


                    Info.IdPeriodo_1 = item_data.Idperiodo_1;
                    Info.IdPeriodo_2 = item_data.Idperiodo_2;
                    Info.IdPeriodo_3 = item_data.Idperiodo_3;
                    Info.IdPeriodo_4 = item_data.Idperiodo_4;
                    Info.IdPeriodo_5 = item_data.Idperiodo_5;
                    Info.IdPeriodo_6 = item_data.Idperiodo_6;
                    Info.IdPeriodo_7 = item_data.Idperiodo_7;
                    Info.IdPeriodo_8 = item_data.Idperiodo_8;
                    Info.IdPeriodo_9 = item_data.Idperiodo_9;
                    Info.IdPeriodo_10 = item_data.Idperiodo_10;
                    Info.IdPeriodo_11 = item_data.Idperiodo_11;
                    Info.IdPeriodo_12 = item_data.Idperiodo_12;
                    

                    listadedatos.Add(Info);
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
           ,bool MostrarCC ,string IdUsuario, ref String MensajeError)
        {
            try
            {
                List<XCONTA_Rpt002_Info> listadedatos = new List<XCONTA_Rpt002_Info>();
                using (EntitiesContabilidadRptGeneral Estado_Resultado = new EntitiesContabilidadRptGeneral())
                {


                    Estado_Resultado.SetCommandTimeOut(30000);//timeout 3 minutos

                    IList<spCON_Mayorizar_x_fecha_corte_Result> listBalance =
                    Estado_Resultado.spCON_Mayorizar_x_fecha_corte(IdEmpresa, FechaIni, FechaFin,
                    IdCentroCosto, IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_en_cero, MostrarCC, true, IdUsuario).ToList();


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
                        itemInfo.Saldo = item.Saldo_Mes;

                        itemInfo.Saldo_inicial_x_Movi = item.Saldo_inicial_x_Movi;
                        itemInfo.Debito_Mes_x_Movi = item.Debito_Mes_x_Movi;
                        itemInfo.Credito_Mes_x_Movi = item.Credito_Mes_x_Movi;
                        itemInfo.Saldo_x_Movi = item.Saldo_x_Movi;



                        itemInfo.pc_EsMovimiento = item.pc_EsMovimiento;
                        itemInfo.GrupoCble = item.GrupoCble;
                        itemInfo.gc_signo_operacion = item.gc_signo_operacion;


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
