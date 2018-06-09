using Core.Erp.Data.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt016_Data
    {
        #region Listas_x_periodo
        List<XCONTA_Rpt016_Info> list_data_Periodo_data = new List<XCONTA_Rpt016_Info>();
        List<XCONTA_Rpt016_Info> list_data_Periodo_1 = new List<XCONTA_Rpt016_Info>();
        List<XCONTA_Rpt016_Info> list_data_Periodo_2 = new List<XCONTA_Rpt016_Info>();
        List<XCONTA_Rpt016_Info> list_data_Periodo_3 = new List<XCONTA_Rpt016_Info>();
        List<XCONTA_Rpt016_Info> list_data_Periodo_4 = new List<XCONTA_Rpt016_Info>();
        List<XCONTA_Rpt016_Info> list_data_Periodo_5 = new List<XCONTA_Rpt016_Info>();
        List<XCONTA_Rpt016_Info> list_data_Periodo_6 = new List<XCONTA_Rpt016_Info>();
        List<XCONTA_Rpt016_Info> list_data_Periodo_7 = new List<XCONTA_Rpt016_Info>();
        List<XCONTA_Rpt016_Info> list_data_Periodo_8 = new List<XCONTA_Rpt016_Info>();
        List<XCONTA_Rpt016_Info> list_data_Periodo_9 = new List<XCONTA_Rpt016_Info>();
        List<XCONTA_Rpt016_Info> list_data_Periodo_10 = new List<XCONTA_Rpt016_Info>();
        List<XCONTA_Rpt016_Info> list_data_Periodo_11 = new List<XCONTA_Rpt016_Info>();
        List<XCONTA_Rpt016_Info> list_data_Periodo_12 = new List<XCONTA_Rpt016_Info>();
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

        public List<XCONTA_Rpt016_Info> Get_list_reporte(List<ct_Periodo_Info> lst_periodos, int IdEmpresa, int anio, bool Mostrar_CC)
        {
            try
            {
                tb_Mes_Data BusMes = new tb_Mes_Data();
                List<tb_Mes_info> listMeses = new List<tb_Mes_info>();
                listMeses = BusMes.Get_List_Mes();
                string nMes = "";
                string Nom_Periodo = "";
                List<XCONTA_Rpt016_Info> Lista = new List<XCONTA_Rpt016_Info>();
                int contador = 1;

                foreach (var itemPeriodo in lst_periodos)
                {
                    list_data_Periodo_data = Get_data_x_periodo(IdEmpresa,itemPeriodo.IdPeriodo,Mostrar_CC);
                    nMes = listMeses.FirstOrDefault(v => v.idMes == itemPeriodo.pe_mes).nemonico;
                    Nom_Periodo = itemPeriodo.IdanioFiscal.ToString() + "-" + nMes;
                    if (list_data_Periodo_data.Count!=0)
                    {
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
                            contador++;
                        }    
                    }
                    
                }
                list_data_Periodo_data = Get_data_x_anio(IdEmpresa, anio, Mostrar_CC);
               
                //=====================================================

                var lst_data_final = from plancta in list_data_Periodo_data
                                                      join Data_x_Periodo_1 in list_data_Periodo_1
                                                      on new { plancta.IdTipo_Gasto, plancta.IdCta} equals new { Data_x_Periodo_1.IdTipo_Gasto, Data_x_Periodo_1.IdCta} into ps1
                                                      from sub_Data_x_Periodo_1 in ps1.DefaultIfEmpty()

                                                      join Data_x_Periodo_2 in list_data_Periodo_2
                                                      on new { plancta.IdTipo_Gasto, plancta.IdCta } equals new { Data_x_Periodo_2.IdTipo_Gasto, Data_x_Periodo_2.IdCta } into ps2
                                                      from sub_Data_x_Periodo_2 in ps2.DefaultIfEmpty()

                                                      join Data_x_Periodo_3 in list_data_Periodo_3
                                                      on new { plancta.IdTipo_Gasto, plancta.IdCta } equals new { Data_x_Periodo_3.IdTipo_Gasto, Data_x_Periodo_3.IdCta } into ps3
                                                      from sub_Data_x_Periodo_3 in ps3.DefaultIfEmpty()

                                                      join Data_x_Periodo_4 in list_data_Periodo_4
                                                      on new { plancta.IdTipo_Gasto, plancta.IdCta } equals new { Data_x_Periodo_4.IdTipo_Gasto, Data_x_Periodo_4.IdCta } into ps4
                                                      from sub_Data_x_Periodo_4 in ps4.DefaultIfEmpty()

                                                      join Data_x_Periodo_5 in list_data_Periodo_5
                                                      on new { plancta.IdTipo_Gasto, plancta.IdCta } equals new { Data_x_Periodo_5.IdTipo_Gasto, Data_x_Periodo_5.IdCta } into ps5
                                                      from sub_Data_x_Periodo_5 in ps5.DefaultIfEmpty()

                                                      join Data_x_Periodo_6 in list_data_Periodo_6
                                                      on new { plancta.IdTipo_Gasto, plancta.IdCta } equals new { Data_x_Periodo_6.IdTipo_Gasto, Data_x_Periodo_6.IdCta } into ps6
                                                      from sub_Data_x_Periodo_6 in ps6.DefaultIfEmpty()

                                                      join Data_x_Periodo_7 in list_data_Periodo_7
                                                      on new { plancta.IdTipo_Gasto, plancta.IdCta } equals new { Data_x_Periodo_7.IdTipo_Gasto, Data_x_Periodo_7.IdCta } into ps7
                                                      from sub_Data_x_Periodo_7 in ps7.DefaultIfEmpty()

                                                      join Data_x_Periodo_8 in list_data_Periodo_8
                                                      on new { plancta.IdTipo_Gasto, plancta.IdCta } equals new { Data_x_Periodo_8.IdTipo_Gasto, Data_x_Periodo_8.IdCta } into ps8
                                                      from sub_Data_x_Periodo_8 in ps8.DefaultIfEmpty()

                                                      join Data_x_Periodo_9 in list_data_Periodo_9
                                                      on new { plancta.IdTipo_Gasto, plancta.IdCta } equals new { Data_x_Periodo_9.IdTipo_Gasto, Data_x_Periodo_9.IdCta } into ps9
                                                      from sub_Data_x_Periodo_9 in ps9.DefaultIfEmpty()

                                                      join Data_x_Periodo_10 in list_data_Periodo_10
                                                      on new { plancta.IdTipo_Gasto, plancta.IdCta } equals new { Data_x_Periodo_10.IdTipo_Gasto, Data_x_Periodo_10.IdCta } into ps10
                                                      from sub_Data_x_Periodo_10 in ps10.DefaultIfEmpty()

                                                      join Data_x_Periodo_11 in list_data_Periodo_11
                                                      on new { plancta.IdTipo_Gasto, plancta.IdCta } equals new { Data_x_Periodo_11.IdTipo_Gasto, Data_x_Periodo_11.IdCta } into ps11
                                                      from sub_Data_x_Periodo_11 in ps11.DefaultIfEmpty()

                                                      join Data_x_Periodo_12 in list_data_Periodo_12
                                                      on new { plancta.IdTipo_Gasto, plancta.IdCta } equals new { Data_x_Periodo_12.IdTipo_Gasto, Data_x_Periodo_12.IdCta } into ps12
                                                      from sub_Data_x_Periodo_12 in ps12.DefaultIfEmpty()

                                                      orderby plancta.IdTipo_Gasto

                                                      select new
                                                      {
                                                          plancta.IdEmpresa,
                                                          plancta.IdCta,
                                                          plancta.orden,
                                                          plancta.nivel,
                                                          plancta.IdTipo_Gasto,
                                                          plancta.nom_cuenta,
                                                          plancta.nom_tipo_Gasto,
                                                          plancta.nom_tipo_Gasto_padre,
                                                          plancta.nom_grupo_CC,
                                                          plancta.orden_tipo_gasto,

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
                                                          Saldo_Periodo_12 = (sub_Data_x_Periodo_12 == null ? 0 : sub_Data_x_Periodo_12.Saldo),

                                                          nom_Periodo_1 = nom_periodo_1,
                                                          nom_Periodo_2 = nom_periodo_2,
                                                          nom_Periodo_3 = nom_periodo_3,
                                                          nom_Periodo_4 = nom_periodo_4,
                                                          nom_Periodo_5 = nom_periodo_5,
                                                          nom_Periodo_6 = nom_periodo_6,
                                                          nom_Periodo_7 = nom_periodo_7,
                                                          nom_Periodo_8 = nom_periodo_8,
                                                          nom_Periodo_9 = nom_periodo_9,
                                                          nom_Periodo_10 = nom_periodo_10,
                                                          nom_Periodo_11 = nom_periodo_11,
                                                          nom_Periodo_12 = nom_periodo_12,

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
                                                          Idperiodo_12 = IdPeriodo_12
                                                      };

                foreach (var item in lst_data_final)
                {
                    XCONTA_Rpt016_Info info = new XCONTA_Rpt016_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.nivel = item.nivel;
                    info.orden = item.orden;
                    info.orden_tipo_gasto = item.orden_tipo_gasto;
                    info.IdTipo_Gasto = item.IdTipo_Gasto;
                    info.nom_tipo_Gasto = item.nom_tipo_Gasto;
                    info.nom_tipo_Gasto_padre = item.nom_tipo_Gasto_padre;
                    info.IdCta = item.IdCta;
                    info.nom_cuenta = item.nom_cuenta;
                    info.nom_grupo_CC = item.nom_grupo_CC;

                    info.nom_Periodo_1 = item.nom_Periodo_1;
                    info.nom_Periodo_2 = item.nom_Periodo_2;
                    info.nom_Periodo_3 = item.nom_Periodo_3;
                    info.nom_Periodo_4 = item.nom_Periodo_4;
                    info.nom_Periodo_5 = item.nom_Periodo_5;
                    info.nom_Periodo_6 = item.nom_Periodo_6;
                    info.nom_Periodo_7 = item.nom_Periodo_7;
                    info.nom_Periodo_8 = item.nom_Periodo_8;
                    info.nom_Periodo_9 = item.nom_Periodo_9;
                    info.nom_Periodo_10 = item.nom_Periodo_10;
                    info.nom_Periodo_11 = item.nom_Periodo_11;
                    info.nom_Periodo_12 = item.nom_Periodo_12;

                    info.Saldo_Periodo_1 = item.Saldo_Periodo_1;
                    info.Saldo_Periodo_2 = item.Saldo_Periodo_2;
                    info.Saldo_Periodo_3 = item.Saldo_Periodo_3;
                    info.Saldo_Periodo_4 = item.Saldo_Periodo_4;
                    info.Saldo_Periodo_5 = item.Saldo_Periodo_5;
                    info.Saldo_Periodo_6 = item.Saldo_Periodo_6;
                    info.Saldo_Periodo_7 = item.Saldo_Periodo_7;
                    info.Saldo_Periodo_8 = item.Saldo_Periodo_8;
                    info.Saldo_Periodo_9 = item.Saldo_Periodo_9;
                    info.Saldo_Periodo_10 = item.Saldo_Periodo_10;
                    info.Saldo_Periodo_11 = item.Saldo_Periodo_11;
                    info.Saldo_Periodo_12 = item.Saldo_Periodo_12;
                    Lista.Add(info);
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

        public List<XCONTA_Rpt016_Info> Get_data_x_periodo(int IdEmpresa, int IdPeriodo, bool Mostrar_CC)
        {
            try
            {
                List<XCONTA_Rpt016_Info> Lista = new List<XCONTA_Rpt016_Info>();

                using (EntitiesContabilidadRptGeneral Context = new EntitiesContabilidadRptGeneral())
                {
                    var lst = from q in Context.spCONTA_Rpt016(IdEmpresa, IdPeriodo, Mostrar_CC)
                              select q;

                    foreach (var item in lst)
                    {
                        XCONTA_Rpt016_Info info = new XCONTA_Rpt016_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.nivel = item.nivel;
                        info.orden = item.orden;
                        info.orden_tipo_gasto = item.orden_tipo_gasto;
                        info.IdTipo_Gasto = item.IdTipo_Gasto;
                        info.nom_tipo_Gasto = item.nom_tipo_Gasto;
                        info.nom_tipo_Gasto_padre = item.nom_tipo_Gasto_padre;
                        info.IdCta = item.IdCta;
                        info.nom_cuenta = item.nom_cuenta;
                        info.Saldo = item.dc_Valor;
                        info.nom_grupo_CC = item.nom_grupo_CC;
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

        public List<XCONTA_Rpt016_Info> Get_data_x_anio(int IdEmpresa, int Anio, bool Mostrar_CC)
        {
            try
            {
                List<XCONTA_Rpt016_Info> Lista = new List<XCONTA_Rpt016_Info>();

                using (EntitiesContabilidadRptGeneral Context = new EntitiesContabilidadRptGeneral())
                {
                    var lst = from q in Context.spCONTA_Rpt016_cuentas_x_anio(IdEmpresa, Anio, Mostrar_CC)
                              select q;

                    foreach (var item in lst)
                    {
                        XCONTA_Rpt016_Info info = new XCONTA_Rpt016_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.nivel = item.nivel;
                        info.orden = item.orden;
                        info.orden_tipo_gasto = item.orden_tipo_gasto;
                        info.IdTipo_Gasto = item.IdTipo_Gasto;
                        info.nom_tipo_Gasto = item.nom_tipo_Gasto;
                        info.nom_tipo_Gasto_padre = item.nom_tipo_Gasto_padre;
                        info.IdCta = item.IdCta;
                        info.nom_cuenta = item.nom_cuenta;
                        info.Saldo = item.dc_Valor;
                        info.nom_grupo_CC = item.nom_grupo_CC;
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
